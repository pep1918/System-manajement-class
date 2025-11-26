Imports MySql.Data.MySqlClient
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO

Public Class UC_DataSiswa

    Private selectedNIS As String = ""
    Private IsEditMode As Boolean = False
    Private selectedID As String = ""

    ' ==============================================================
    ' 1. LOAD & INITIALIZATION
    ' ==============================================================
    Private Sub UC_DataSiswa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' 1. Isi ComboBox Kelas dari Database (Untuk Inputan)
        ModuleKoneksi.IsiCombo("SELECT Nama_Kelas FROM tbl_kelas ORDER BY Nama_Kelas", cmbKelas)

        ' 2. Isi Filter Kelas (Copy dari cmbKelas + opsi Semua)
        cmbFilterKelas.Items.Clear()
        cmbFilterKelas.Items.Add("Semua")
        For Each item In cmbKelas.Items : cmbFilterKelas.Items.Add(item) : Next
        If cmbFilterKelas.Items.Count > 0 Then cmbFilterKelas.SelectedIndex = 0

        ' 3. Isi Manual Lainnya
        If cmbJK.Items.Count = 0 Then cmbJK.Items.AddRange({"Laki-laki", "Perempuan"})
        If cmbStatus.Items.Count = 0 Then cmbStatus.Items.AddRange({"Aktif", "Nonaktif", "Lulus", "Pindah"})

        TampilData()
        Bersih()
    End Sub

    Sub Bersih()
        txtNIS.Clear() : txtNama.Clear()
        cmbJK.SelectedIndex = -1 : cmbKelas.SelectedIndex = -1 : cmbStatus.SelectedIndex = -1
        dtpLahir.Value = DateTime.Now

        txtNIS.Enabled = True
        selectedNIS = ""
        btnTambah.Enabled = True : btnUbah.Enabled = False : btnHapus.Enabled = False
    End Sub

    ' ==============================================================
    ' 2. TAMPIL DATA (DENGAN JOIN & FILTER)
    ' ==============================================================
    Sub TampilData()
        ' Query JOIN agar kita dapat Nama Kelas, bukan cuma angka ID
        Dim q As String = "SELECT s.NIS, s.Nama_Siswa, s.Jenis_Kelamin, k.Nama_Kelas, s.Jurusan, s.Tahun_Masuk, s.Status, s.Tanggal_Lahir " &
                          "FROM tbl_siswa s " &
                          "LEFT JOIN tbl_kelas k ON s.ID_Kelas = k.ID_Kelas WHERE 1=1 "

        ' Filter Pencarian
        If txtCariSiswa.Text <> "" Then
            q &= " AND (s.Nama_Siswa LIKE '%" & txtCariSiswa.Text & "%' OR s.NIS LIKE '%" & txtCariSiswa.Text & "%')"
        End If

        ' Filter Kelas
        If cmbFilterKelas.SelectedIndex > 0 And cmbFilterKelas.Text <> "Semua" Then
            q &= " AND k.Nama_Kelas = '" & cmbFilterKelas.Text & "'"
        End If

        q &= " ORDER BY s.Nama_Siswa ASC"

        dgvSiswa.DataSource = ModuleKoneksi.AmbilData(q)
        AturGrid()
    End Sub

    ' ==========================================
    ' SUB UNTUK MERAPIKAN JUDUL KOLOM TABEL
    ' ==========================================
    Sub AturGrid()
        If dgvSiswa.Columns.Count > 0 Then
            dgvSiswa.Columns("Nama_Siswa").HeaderText = "Nama Siswa"
            dgvSiswa.Columns("Jenis_Kelamin").HeaderText = "Jenis Kelamin"
            dgvSiswa.Columns("Nama_Kelas").HeaderText = "Kelas"
            dgvSiswa.Columns("Tahun_Masuk").HeaderText = "Tahun Masuk"
            dgvSiswa.Columns("Tanggal_Lahir").HeaderText = "Tanggal Lahir"

            ' Sembunyikan yang tidak perlu
            If dgvSiswa.Columns.Contains("Alamat") Then dgvSiswa.Columns("Alamat").Visible = False

            dgvSiswa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        End If
    End Sub

    Private Sub txtCariSiswa_TextChanged(sender As Object, e As EventArgs) Handles txtCariSiswa.TextChanged
        TampilData()
    End Sub

    Private Sub cmbFilterKelas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFilterKelas.SelectedIndexChanged
        TampilData()
    End Sub

    ' ==============================================================
    ' 3. HELPER PARAMETER (LOGIKA MENCARI ID KELAS)
    ' ==============================================================
    Private Function SiapkanParameter() As List(Of MySqlParameter)
        ' 1. Cari ID Kelas berdasarkan Nama Kelas yang dipilih di ComboBox
        Dim idKelas As String = ModuleKoneksi.AmbilNilai($"SELECT ID_Kelas FROM tbl_kelas WHERE Nama_Kelas='{cmbKelas.Text}'")

        ' 2. Bungkus Parameter
        Dim p As New List(Of MySqlParameter) From {
            New MySqlParameter("@nis", txtNIS.Text),
            New MySqlParameter("@nm", txtNama.Text),
            New MySqlParameter("@jk", cmbJK.Text),
            New MySqlParameter("@tgl", dtpLahir.Value.ToString("yyyy-MM-dd")),
            New MySqlParameter("@idk", idKelas), ' Masukkan ID yang sudah dicari           
            New MySqlParameter("@stt", cmbStatus.Text)
        }
        Return p
    End Function

    ' ==============================================================
    ' 4. CRUD OPERATIONS
    ' ==============================================================

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        If txtNIS.Text = "" Or txtNama.Text = "" Or cmbKelas.Text = "" Then
            MsgBox("NIS, Nama, dan Kelas Wajib Diisi!") : Return
        End If

        ' Cek Duplikat NIS
        Dim cek As String = ModuleKoneksi.AmbilNilai($"SELECT COUNT(*) FROM tbl_siswa WHERE NIS='{txtNIS.Text}'")
        If Convert.ToInt32(cek) > 0 Then MsgBox("NIS sudah terdaftar!", vbCritical) : Return

        Dim q As String = "INSERT INTO tbl_siswa (NIS, Nama_Siswa, Jenis_Kelamin, Tanggal_Lahir, ID_Kelas, Jurusan, Tahun_Masuk, Status) VALUES (@nis, @nm, @jk, @tgl, @idk, @jur, @thn, @stt)"

        If ModuleKoneksi.EksekusiQuery(q, SiapkanParameter()) Then
            MsgBox("Data Berhasil Disimpan")
            Bersih()
            TampilData()
        End If
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        If selectedNIS = "" Then Return

        Dim q As String = "UPDATE tbl_siswa SET Nama_Siswa=@nm, Jenis_Kelamin=@jk, Tanggal_Lahir=@tgl, ID_Kelas=@idk, Jurusan=@jur, Tahun_Masuk=@thn, Status=@stt WHERE NIS=@nis"

        If ModuleKoneksi.EksekusiQuery(q, SiapkanParameter()) Then
            MsgBox("Data Berhasil Diubah")
            Bersih()
            TampilData()
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If selectedNIS = "" Then Return
        If MsgBox("Yakin hapus siswa ini?", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.Yes Then

            Dim p As New List(Of MySqlParameter) From {New MySqlParameter("@nis", selectedNIS)}

            If ModuleKoneksi.EksekusiQuery("DELETE FROM tbl_siswa WHERE NIS=@nis", p) Then
                Bersih()
                TampilData()
            End If
        End If
    End Sub

    ' Klik Tabel -> Isi Form
    Private Sub dgvSiswa_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSiswa.CellClick
        If e.RowIndex >= 0 Then
            Dim r = dgvSiswa.Rows(e.RowIndex)
            selectedNIS = r.Cells("NIS").Value.ToString()

            ' Isi Form
            txtNIS.Text = selectedNIS
            txtNama.Text = r.Cells("Nama_Siswa").Value.ToString()

            cmbJK.Text = If(IsDBNull(r.Cells("Jenis_Kelamin").Value), "", r.Cells("Jenis_Kelamin").Value.ToString())
            cmbStatus.Text = If(IsDBNull(r.Cells("Status").Value), "", r.Cells("Status").Value.ToString())

            ' Isi ComboBox Kelas (Ambil Nama Kelas dari kolom tabel)
            cmbKelas.Text = If(IsDBNull(r.Cells("Nama_Kelas").Value), "", r.Cells("Nama_Kelas").Value.ToString())

            Try
                dtpLahir.Value = Convert.ToDateTime(r.Cells("Tanggal_Lahir").Value)
            Catch
                dtpLahir.Value = DateTime.Now
            End Try

            txtNIS.Enabled = False
            btnTambah.Enabled = False : btnUbah.Enabled = True : btnHapus.Enabled = True
        End If
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Bersih()
    End Sub

    ' ==============================================================
    ' 5. EXPORT PDF
    ' ==============================================================
    Private Sub btnExportPDF_Click(sender As Object, e As EventArgs) Handles btnCetak.Click
        If dgvSiswa.Rows.Count = 0 Then Return

        Dim sfd As New SaveFileDialog() With {.Filter = "PDF Files|*.pdf", .FileName = "LaporanSiswa_" & DateTime.Now.ToString("yyyyMMdd")}
        If sfd.ShowDialog() = DialogResult.OK Then
            Try
                Dim doc As New Document(PageSize.A4.Rotate(), 10, 10, 10, 10)
                PdfWriter.GetInstance(doc, New FileStream(sfd.FileName, FileMode.Create))
                doc.Open()

                Dim p As New Paragraph("LAPORAN DATA SISWA") With {.Alignment = Element.ALIGN_CENTER}
                doc.Add(p)

                Dim subJudul As String = If(cmbFilterKelas.SelectedIndex > 0, "KELAS: " & cmbFilterKelas.Text, "SEMUA KELAS")
                doc.Add(New Paragraph(subJudul) With {.Alignment = Element.ALIGN_CENTER})
                doc.Add(New Paragraph(" "))


                Dim table As New PdfPTable(dgvSiswa.Columns.Count) With {.WidthPercentage = 100}

                For Each col As DataGridViewColumn In dgvSiswa.Columns
                    table.AddCell(New PdfPCell(New Phrase(col.HeaderText)) With {.BackgroundColor = BaseColor.LIGHT_GRAY})
                Next

                For Each row As DataGridViewRow In dgvSiswa.Rows
                    For Each cell As DataGridViewCell In row.Cells
                        Dim val As String = If(cell.Value Is Nothing, "", cell.Value.ToString())
                        If TypeOf cell.Value Is DateTime Then val = Convert.ToDateTime(val).ToString("dd/MM/yyyy")
                        table.AddCell(val)
                    Next
                Next

                doc.Add(table)
                doc.Close()
                MsgBox("PDF Berhasil Disimpan!")
            Catch ex As Exception
                MsgBox("Gagal PDF: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub dgvSiswa_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSiswa.CellContentClick

    End Sub


    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub cmbStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbStatus.SelectedIndexChanged

    End Sub

    Private Sub dtpTanggalLahir_ValueChanged(sender As Object, e As EventArgs) Handles dtpLahir.ValueChanged

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub cmbJK_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbJK.SelectedIndexChanged

    End Sub

    Private Sub cmbKelas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbKelas.SelectedIndexChanged

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub txtNama_TextChanged(sender As Object, e As EventArgs) Handles txtNama.TextChanged

    End Sub

    Private Sub txtNIS_TextChanged(sender As Object, e As EventArgs) Handles txtNIS.TextChanged

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub lbjudul_Click(sender As Object, e As EventArgs) Handles lbjudul.Click

    End Sub

    Private Sub Cari_Click(sender As Object, e As EventArgs) Handles Cari.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        ' 1. Validasi Input
        If txtNIS.Text = "" Or txtNama.Text = "" Or cmbKelas.Text = "" Then
            MsgBox("NIS, Nama, dan Kelas wajib diisi!", vbExclamation)
            Return
        End If

        ' 2. Ambil ID Kelas
        Dim idKelas As String = ModuleKoneksi.AmbilNilai($"SELECT ID_Kelas FROM tbl_kelas WHERE Nama_Kelas='{cmbKelas.Text}'")
        If idKelas = "0" Then MsgBox("Kelas tidak valid!", vbCritical) : Return

        ' 3. Siapkan Parameter (LENGKAP DENGAN ALAMAT & TELEPON)
        Dim p As New List(Of MySqlParameter) From {
            New MySqlParameter("@nis", txtNIS.Text),
            New MySqlParameter("@nm", txtNama.Text),
            New MySqlParameter("@jk", cmbJK.Text),
            New MySqlParameter("@tgl", dtpLahir.Value.ToString("yyyy-MM-dd")),
            New MySqlParameter("@idk", idKelas),
            New MySqlParameter("@stt", cmbStatus.Text),
            New MySqlParameter("@almt", txtAlamat.Text),   ' <-- Tambahan
            New MySqlParameter("@tlp", txtTelepon.Text)    ' <-- Tambahan
        }

        Dim query As String = ""

        If IsEditMode = False Then
            ' INSERT
            Dim cek As String = ModuleKoneksi.AmbilNilai($"SELECT COUNT(*) FROM tbl_siswa WHERE NIS='{txtNIS.Text}'")
            If Convert.ToInt32(cek) > 0 Then MsgBox("NIS sudah terdaftar!", vbExclamation) : Return

            query = "INSERT INTO tbl_siswa (NIS, Nama_Siswa, Jenis_Kelamin, Tanggal_Lahir, ID_Kelas, Jurusan, Tahun_Masuk, Status, Alamat, Telepon) " &
                    "VALUES (@nis, @nm, @jk, @tgl, @idk, @jur, @thn, @stt, @almt, @tlp)"
        Else
            ' UPDATE (PERBAIKAN DISINI)
            query = "UPDATE tbl_siswa SET Nama_Siswa=@nm, Jenis_Kelamin=@jk, Tanggal_Lahir=@tgl, ID_Kelas=@idk, Jurusan=@jur, Tahun_Masuk=@thn, Status=@stt, Alamat=@almt, Telepon=@tlp " &
                    "WHERE NIS=@nis"
        End If

        If ModuleKoneksi.EksekusiQuery(query, p) Then
            MsgBox("Data Berhasil Disimpan", vbInformation)
            Bersih()
            TampilData()
        End If
    End Sub
    Private Sub txtAlamat_TextChanged(sender As Object, e As EventArgs) Handles txtAlamat.TextChanged

    End Sub
End Class