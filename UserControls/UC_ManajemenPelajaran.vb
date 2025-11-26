Imports System.IO
Imports DocumentFormat.OpenXml.Wordprocessing
' Import ini dibiarkan, tapi nanti di kode kita panggil nama lengkapnya biar aman
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports MySql.Data.MySqlClient

Public Class UC_ManajemenPelajaran

    ' --- VARIABEL GLOBAL ---
    Private IsEditMode As Boolean = False

    ' =================================================================
    ' 1. LOAD & INIT
    ' =================================================================
    Private Sub UC_ManajemenPelajaran_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Mencegah Error Designer saat Rebuild
        If Me.DesignMode Then Return

        ' Atur Format DateTimePicker
        AturFormatJam(dtpMulai)
        AturFormatJam(dtpSelesai)

        SiapkanComboBox()
        TampilData()
        Bersih()


    End Sub





    Sub AturFormatJam(dtp As DateTimePicker)
        dtp.Format = DateTimePickerFormat.Custom
        dtp.CustomFormat = "HH:mm"
        dtp.ShowUpDown = True
    End Sub

    Sub SiapkanComboBox()
        ' 1. Isi Hari Manual untuk INPUT (cmbHari)
        Dim hari() As String = {"Senin", "Selasa", "Rabu", "Kamis", "Jumat", "Sabtu"}
        cmbHari.Items.Clear()
        cmbHari.Items.AddRange(hari)

        ' 2. Isi Hari Manual untuk FILTER (cmbFilterHari)
        cmbFilterHari.Items.Clear()
        cmbFilterHari.Items.Add("Semua") ' Tambah opsi Semua paling atas
        cmbFilterHari.Items.AddRange(hari)
        cmbFilterHari.SelectedIndex = 0  ' Default pilih Semua

        ' 3. Isi Data Database Lainnya (Kelas, Mapel, Guru)
        Try
            ModuleKoneksi.IsiCombo("SELECT Nama_Kelas FROM tbl_kelas ORDER BY Nama_Kelas", cmbKelas)
            ModuleKoneksi.IsiCombo("SELECT Nama_Mapel FROM tbl_mapel ORDER BY Nama_Mapel", cmbMapel)
            ModuleKoneksi.IsiCombo("SELECT Nama_Guru FROM tbl_guru ORDER BY Nama_Guru", cmbGuru)

            ' Isi Filter Kelas
            cmbFilterKelas.Items.Clear()
            cmbFilterKelas.Items.Add("Semua")
            For Each item In cmbKelas.Items : cmbFilterKelas.Items.Add(item) : Next
            cmbFilterKelas.SelectedIndex = 0
        Catch ex As Exception
        End Try
    End Sub
    ' =================================================================
    ' 2. BERSIHKAN FORM
    ' =================================================================
    Sub Bersih()
        cmbKelas.SelectedIndex = -1 : cmbMapel.SelectedIndex = -1 : cmbGuru.SelectedIndex = -1
        cmbHari.SelectedIndex = -1

        ' Reset Jam ke 07:00
        Dim defTime As DateTime = DateTime.Today.AddHours(7)
        dtpMulai.Value = defTime
        dtpSelesai.Value = defTime.AddHours(1)

        IsEditMode = False
        AturInput(False)

        ' Reset Tombol
        btnTambah.Enabled = True
        btnUbah.Enabled = False
        btnHapus.Enabled = False
        btnSimpan.Enabled = False
        btnBatal.Enabled = True
    End Sub

    Sub AturInput(aktif As Boolean)
        cmbKelas.Enabled = aktif
        cmbMapel.Enabled = aktif
        cmbGuru.Enabled = aktif
        cmbHari.Enabled = aktif
        dtpMulai.Enabled = aktif
        dtpSelesai.Enabled = aktif
    End Sub

    ' =================================================================
    ' 3. TAMPIL DATA (SOLUSI ANTI CRASH)
    ' =================================================================
    Sub TampilData()
        ' Query Dasar
        Dim q As String = "SELECT j.ID_Jadwal, j.Hari, " &
                          "TIME_FORMAT(j.Jam_Mulai, '%H:%i') AS Jam_Mulai, " &
                          "TIME_FORMAT(j.Jam_Selesai, '%H:%i') AS Jam_Selesai, " &
                          "k.Nama_Kelas, m.Nama_Mapel, g.Nama_Guru " &
                          "FROM tbl_jadwal j " &
                          "JOIN tbl_kelas k ON j.ID_Kelas = k.ID_Kelas " &
                          "JOIN tbl_mapel m ON j.Kode_Mapel = m.Kode_Mapel " &
                          "JOIN tbl_guru g ON j.NIP_Guru = g.NIP WHERE 1=1 "

        ' --- FILTER KELAS ---
        If cmbFilterKelas.SelectedIndex > 0 And cmbFilterKelas.Text <> "Semua" Then
            q &= $" AND k.Nama_Kelas = '{cmbFilterKelas.Text}'"
        End If

        ' --- FILTER HARI (BAGIAN INI YANG DITAMBAHKAN) ---
        If cmbFilterHari.SelectedIndex > 0 And cmbFilterHari.Text <> "Semua" Then
            q &= $" AND j.Hari = '{cmbFilterHari.Text}'"
        End If

        ' Urutkan berdasarkan Hari (Senin-Sabtu) dan Jam
        q &= " ORDER BY FIELD(j.Hari, 'Senin','Selasa','Rabu','Kamis','Jumat','Sabtu'), j.Jam_Mulai"

        dgvJadwal.DataSource = ModuleKoneksi.AmbilData(q)
        AturGrid()
    End Sub
    ' ==========================================
    ' SUB UNTUK MERAPIKAN JUDUL KOLOM TABEL
    ' ==========================================
    Sub AturGrid()
        If dgvJadwal.Columns.Count > 0 Then
            ' Sembunyikan ID
            dgvJadwal.Columns("ID_Jadwal").Visible = False

            ' Ganti Header
            dgvJadwal.Columns("Nama_Kelas").HeaderText = "Kelas"
            dgvJadwal.Columns("Nama_Mapel").HeaderText = "Mata Pelajaran"
            dgvJadwal.Columns("Nama_Guru").HeaderText = "Guru Pengajar"
            dgvJadwal.Columns("Jam_Mulai").HeaderText = "Mulai"
            dgvJadwal.Columns("Jam_Selesai").HeaderText = "Selesai"

            ' Atur lebar otomatis
            dgvJadwal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        End If
    End Sub
    ' Event Filter Berubah
    Private Sub FilterChanged(sender As Object, e As EventArgs) Handles cmbFilterKelas.SelectedIndexChanged
        TampilData()
    End Sub

    ' Penanganan Error Grid (Silent)
    Private Sub dgvJadwal_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles dgvJadwal.DataError
        e.ThrowException = False
    End Sub

    ' =================================================================
    ' 4. LOGIKA TOMBOL (CRUD)
    ' =================================================================

    ' [A] TAMBAH
    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Bersih()
        IsEditMode = False
        AturInput(True)

        btnTambah.Enabled = False
        btnSimpan.Enabled = True
    End Sub

    ' [B] UBAH
    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        IsEditMode = True
        AturInput(True)

        btnTambah.Enabled = False
        btnUbah.Enabled = False
        btnSimpan.Enabled = True
    End Sub

    ' [C] SIMPAN (VALIDASI BENTROK)
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        ' 1. Validasi Kosong
        If cmbKelas.Text = "" Or cmbGuru.Text = "" Or cmbHari.Text = "" Then
            MsgBox("Lengkapi data jadwal!", vbExclamation) : Return
        End If

        ' 2. Format Jam (PENTING: Tambah :00 untuk detik agar MySQL valid TIME)
        Dim jamMulai As String = dtpMulai.Value.ToString("HH:mm:00")
        Dim jamSelesai As String = dtpSelesai.Value.ToString("HH:mm:00")

        ' Validasi Logika Jam
        If dtpSelesai.Value.TimeOfDay <= dtpMulai.Value.TimeOfDay Then
            MsgBox("Jam Selesai harus lebih besar!", vbExclamation) : Return
        End If

        ' 3. Ambil ID (Pastikan fungsi AmbilNilai di ModuleKoneksi bekerja)
        Dim idKelas As String = ModuleKoneksi.AmbilNilai($"SELECT ID_Kelas FROM tbl_kelas WHERE Nama_Kelas='{cmbKelas.Text}'")
        Dim kodeMapel As String = ModuleKoneksi.AmbilNilai($"SELECT Kode_Mapel FROM tbl_mapel WHERE Nama_Mapel='{cmbMapel.Text}'")
        Dim nipGuru As String = ModuleKoneksi.AmbilNilai($"SELECT NIP FROM tbl_guru WHERE Nama_Guru='{cmbGuru.Text}'")

        ' 4. Validasi Bentrok
        Dim qCek As String = $"SELECT COUNT(*) FROM tbl_jadwal WHERE Hari='{cmbHari.Text}' " &
                             $"AND (NIP_Guru='{nipGuru}' OR ID_Kelas='{idKelas}') " &
                             $"AND ('{jamMulai}' < Jam_Selesai AND '{jamSelesai}' > Jam_Mulai)"



        If Convert.ToInt32(ModuleKoneksi.AmbilNilai(qCek)) > 0 Then
            MsgBox("JADWAL BENTROK! Guru atau Kelas sibuk di jam tersebut.", vbCritical)
            Return
        End If

        ' 5. Proses Simpan
        Dim p As New List(Of MySqlParameter) From {
            New MySqlParameter("@kls", idKelas),
            New MySqlParameter("@mpl", kodeMapel),
            New MySqlParameter("@guru", nipGuru),
            New MySqlParameter("@hari", cmbHari.Text),
            New MySqlParameter("@j1", jamMulai),
            New MySqlParameter("@j2", jamSelesai)
        }

        Dim query As String = ""
        If IsEditMode = False Then
            query = "INSERT INTO tbl_jadwal (ID_Kelas, Kode_Mapel, NIP_Guru, Hari, Jam_Mulai, Jam_Selesai) VALUES (@kls, @mpl, @guru, @hari, @j1, @j2)"
        Else
            query = "UPDATE tbl_jadwal SET ID_Kelas=@kls, Kode_Mapel=@mpl, NIP_Guru=@guru, Hari=@hari, Jam_Mulai=@j1, Jam_Selesai=@j2 WHERE ID_Jadwal=@id"
        End If

        If ModuleKoneksi.EksekusiQuery(query, p) Then
            MsgBox("Jadwal Berhasil Disimpan", vbInformation)
            Bersih()
            TampilData()
        End If
    End Sub

    ' [D] HAPUS
    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click

        If MsgBox("Hapus Jadwal ini?", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.Yes Then

            If ModuleKoneksi.EksekusiQuery("DELETE FROM tbl_jadwal WHERE ID_Jadwal=@id", p) Then
                Bersih()
                TampilData()
            End If
        End If
    End Sub

    ' [E] BATAL
    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Bersih()
    End Sub

    ' =================================================================
    ' 5. KLIK TABEL
    ' =================================================================
    Private Sub dgvJadwal_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvJadwal.CellClick
        If e.RowIndex >= 0 Then
            Dim r = dgvJadwal.Rows(e.RowIndex)
            txtID.Text = r.Cells("ID_Jadwal").Value.ToString()

            cmbHari.Text = r.Cells("Hari").Value.ToString()
            cmbKelas.Text = r.Cells("Nama_Kelas").Value.ToString()
            cmbMapel.Text = r.Cells("Nama_Mapel").Value.ToString()
            cmbGuru.Text = r.Cells("Nama_Guru").Value.ToString()

            ' Set Jam dari Database ke DateTimePicker
            Try
                dtpMulai.Value = DateTime.Parse(r.Cells("Jam_Mulai").Value.ToString())
                dtpSelesai.Value = DateTime.Parse(r.Cells("Jam_Selesai").Value.ToString())
            Catch
            End Try

            AturInput(False)
            btnTambah.Enabled = True
            btnSimpan.Enabled = False
            btnUbah.Enabled = True
            btnHapus.Enabled = True
        End If
    End Sub

    ' =================================================================
    ' 6. CETAK PDF (ANTI AMBIGUOUS)
    ' =================================================================
    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click
        If dgvJadwal.Rows.Count = 0 Then MsgBox("Data kosong!") : Return

        Dim sfd As New SaveFileDialog() With {.Filter = "PDF Files|*.pdf", .FileName = "Jadwal_" & DateTime.Now.ToString("yyyyMMdd")}
        If sfd.ShowDialog() = DialogResult.OK Then
            Try
                ' Gunakan nama lengkap (iTextSharp.text.Document) agar tidak error Ambiguous
                Dim doc As New iTextSharp.text.Document(iTextSharp.text.PageSize.A4.Rotate(), 10, 10, 10, 10)
                PdfWriter.GetInstance(doc, New FileStream(sfd.FileName, FileMode.Create))
                doc.Open()

                Dim judul As String = "JADWAL PELAJARAN"
                If cmbFilterKelas.SelectedIndex > 0 Then judul &= " " & cmbFilterKelas.Text

                Dim p As New iTextSharp.text.Paragraph(judul)
                p.Alignment = iTextSharp.text.Element.ALIGN_CENTER
                doc.Add(p)
                doc.Add(New iTextSharp.text.Paragraph(" "))

                Dim table As New PdfPTable(dgvJadwal.Columns.Count - 1)
                table.WidthPercentage = 100

                ' Header
                For Each col As DataGridViewColumn In dgvJadwal.Columns
                    If col.Visible Then
                        Dim cell As New PdfPCell(New Phrase(col.HeaderText))
                        cell.BackgroundColor = iTextSharp.text.BaseColor.LIGHT_GRAY
                        table.AddCell(cell)
                    End If
                Next

                ' Data
                For Each row As DataGridViewRow In dgvJadwal.Rows
                    For Each cell As DataGridViewCell In row.Cells
                        If dgvJadwal.Columns(cell.ColumnIndex).Visible Then
                            table.AddCell(If(cell.Value Is Nothing, "", cell.Value.ToString()))
                        End If
                    Next
                Next

                doc.Add(table)
                doc.Close()
                MsgBox("PDF Berhasil Disimpan!", vbInformation)
                Process.Start(sfd.FileName)
            Catch ex As Exception
                MsgBox("Gagal PDF: " & ex.Message, vbCritical)
            End Try
        End If
    End Sub

    ' Event saat Filter Kelas ATAU Filter Hari berubah
    Private Sub Filter_Changed(sender As Object, e As EventArgs) Handles cmbFilterKelas.SelectedIndexChanged, cmbFilterHari.SelectedIndexChanged
        TampilData()
    End Sub
    Private Sub dgvJadwal_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvJadwal.CellContentClick

    End Sub
End Class