Imports System.IO
Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Asn1.Cmp
' Namespace iTextSharp kita panggil lengkap di dalam kode agar tidak bentrok

Public Class UC_DataGuru

    ' --- VARIABEL GLOBAL ---
    Private selectedNIP As String = ""
    Private IsEditMode As Boolean = False ' False=Tambah, True=Ubah

    ' =================================================================
    ' 1. SAAT FORM DIMUAT (LOAD)
    ' =================================================================
    Private Sub UC_DataGuru_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Me.DesignMode Then Return

        SiapkanComboBox() ' <--- Pastikan ini dipanggil
        TampilData()
        Bersih()
    End Sub

    Sub SiapkanComboBox()
        ' 1. Isi Manual (Wajib di-Clear dulu biar gak dobel)
        cmbJK.Items.Clear()
        cmbJK.Items.AddRange({"Laki-laki", "Perempuan"})

        cmbStatus.Items.Clear()
        cmbStatus.Items.AddRange({"PNS", "GTY", "Honorer", "Tetap Yayasan"})

        cmbPendidikan.Items.Clear()
        cmbPendidikan.Items.AddRange({"D3", "S1", "S2", "S3"})

        ' 2. Isi Mapel dari Database (Lewat Module)
        Try
            ModuleKoneksi.IsiCombo("SELECT Nama_Mapel FROM tbl_mapel ORDER BY Nama_Mapel", cmbMapelPengampu)

            ' Isi Filter Mapel juga
            cmbFilterMapel.Items.Clear()
            cmbFilterMapel.Items.Add("Semua")
            For Each item In cmbMapelPengampu.Items : cmbFilterMapel.Items.Add(item) : Next
            cmbFilterMapel.SelectedIndex = 0
        Catch ex As Exception
        End Try
    End Sub

    ' =================================================================
    ' 2. BERSIHKAN FORM
    ' =================================================================
    Sub Bersih()
        ' Kosongkan Input
        txtNIP.Clear() : txtAlamat.Clear() : txtAlamat.Clear()
        txtTelepon.Clear() : txtEmail.Clear()
        cmbJK.SelectedIndex = -1 : cmbMapelPengampu.SelectedIndex = -1
        cmbPendidikan.SelectedIndex = -1 : cmbMapelPengampu.SelectedIndex = -1

        selectedNIP = ""
        IsEditMode = False

        ' Matikan Input (User harus klik Tambah/Ubah dulu)
        AturInput(False)

        ' Atur Tombol
        btnTambah.Enabled = True
        btnUbah.Enabled = False
        btnHapus.Enabled = False
        btnSimpan.Enabled = False
        btnBatal.Enabled = True
    End Sub

    Sub AturInput(aktif As Boolean)
        txtNIP.Enabled = aktif
        txtAlamat.Enabled = aktif
        cmbJK.Enabled = aktif
        txtAlamat.Enabled = aktif
        txtTelepon.Enabled = aktif
        txtEmail.Enabled = aktif
        cmbMapelPengampu.Enabled = aktif
        cmbPendidikan.Enabled = aktif
        cmbMapelPengampu.Enabled = aktif
    End Sub

    ' =================================================================
    ' 3. TAMPIL DATA (READ & FILTER)
    ' =================================================================
    Sub TampilData()
        Dim q As String = "SELECT NIP, Nama_Guru, Jenis_Kelamin, Alamat, Telepon, Email, " &
                          "Status_Kepegawaian, Pendidikan_Terakhir, Mapel_Pengampu " &
                          "FROM tbl_guru WHERE 1=1 "

        ' Filter Pencarian Nama/NIP
        If txtCari.Text <> "" Then
            q &= $" AND (Nama_Guru LIKE '%{txtCari.Text}%' OR NIP LIKE '%{txtCari.Text}%')"
        End If

        ' Filter Mapel
        If cmbFilterMapel.SelectedIndex > 0 And cmbFilterMapel.Text <> "Semua" Then
            q &= $" AND Mapel_Pengampu = '{cmbFilterMapel.Text}'"
        End If

        q &= " ORDER BY Nama_Guru ASC"

        dgvGuru.DataSource = ModuleKoneksi.AmbilData(q)
        AturGrid()
    End Sub

    ' ==========================================
    ' SUB UNTUK MERAPIKAN JUDUL KOLOM TABEL
    ' ==========================================
    Sub AturGrid()
        If dgvGuru.Columns.Count > 0 Then
            ' Ubah Judul Kolom agar lebih rapi
            dgvGuru.Columns("NIP").HeaderText = "NIP"
            dgvGuru.Columns("Nama_Guru").HeaderText = "Nama Guru"
            dgvGuru.Columns("Jenis_Kelamin").HeaderText = "L/P"
            dgvGuru.Columns("Status_Kepegawaian").HeaderText = "Status"
            dgvGuru.Columns("Pendidikan_Terakhir").HeaderText = "Pendidikan"
            dgvGuru.Columns("Mapel_Pengampu").HeaderText = "Mapel"

            ' Sembunyikan kolom yang tidak perlu ditampilkan agar tabel tidak penuh
            If dgvGuru.Columns.Contains("Alamat") Then dgvGuru.Columns("Alamat").Visible = False
            If dgvGuru.Columns.Contains("Telepon") Then dgvGuru.Columns("Telepon").Visible = False
            If dgvGuru.Columns.Contains("Email") Then dgvGuru.Columns("Email").Visible = False
            If dgvGuru.Columns.Contains("Foto") Then dgvGuru.Columns("Foto").Visible = False

            ' Atur lebar otomatis
            dgvGuru.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        End If
    End Sub

    Private Sub txtCari_TextChanged(sender As Object, e As EventArgs) Handles txtCari.TextChanged
        TampilData()
    End Sub

    Private Sub cmbFilterMapel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFilterMapel.SelectedIndexChanged
        TampilData()
    End Sub

    ' =================================================================
    ' 4. LOGIKA TOMBOL (CRUD)
    ' =================================================================

    ' [A] TAMBAH
    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Bersih()
        IsEditMode = False
        AturInput(True)
        txtNIP.Focus()

        btnTambah.Enabled = False
        btnSimpan.Enabled = True
    End Sub

    ' [B] UBAH
    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        If selectedNIP = "" Then MsgBox("Pilih data dulu!") : Return

        IsEditMode = True
        AturInput(True)
        txtNIP.Enabled = False ' NIP tidak boleh diedit (PK)
        txtAlamat.Focus()

        btnTambah.Enabled = False
        btnUbah.Enabled = False
        btnSimpan.Enabled = True
    End Sub

    ' [C] SIMPAN
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        ' 1. Validasi Wajib
        If txtNIP.Text = "" Or txtNama.Text = "" Then
            MsgBox("NIP dan Nama Guru wajib diisi!", vbExclamation)
            Return
        End If

        ' 2. Siapkan Parameter
        Dim p As New List(Of MySqlParameter) From {
            New MySqlParameter("@nip", txtNIP.Text),
            New MySqlParameter("@nm", txtNama.Text),
            New MySqlParameter("@jk", cmbJK.Text),
            New MySqlParameter("@almt", txtAlamat.Text),
            New MySqlParameter("@tlp", txtTelepon.Text),
            New MySqlParameter("@eml", txtEmail.Text),
            New MySqlParameter("@stat", cmbStatus.Text),
            New MySqlParameter("@didik", cmbPendidikan.Text),
            New MySqlParameter("@mpl", cmbMapelPengampu.Text)
        }

        Dim query As String = ""

        If IsEditMode = False Then
            ' --- MODE TAMBAH ---
            ' Cek Duplikat NIP
            Dim cek As String = ModuleKoneksi.AmbilNilai($"SELECT COUNT(*) FROM tbl_guru WHERE NIP='{txtNIP.Text}'")
            If Convert.ToInt32(cek) > 0 Then MsgBox("NIP sudah ada!", vbCritical) : Return

            query = "INSERT INTO tbl_guru (NIP, Nama_Guru, Jenis_Kelamin, Alamat, Telepon, Email, Status_Kepegawaian, Pendidikan_Terakhir, Mapel_Pengampu) " &
                    "VALUES (@nip, @nm, @jk, @almt, @tlp, @eml, @stat, @didik, @mpl)"
        Else
            ' --- MODE UBAH ---
            query = "UPDATE tbl_guru SET Nama_Guru=@nm, Jenis_Kelamin=@jk, Alamat=@almt, Telepon=@tlp, Email=@eml, Status_Kepegawaian=@stat, Pendidikan_Terakhir=@didik, Mapel_Pengampu=@mpl WHERE NIP=@nip"
        End If

        ' 3. Eksekusi
        If ModuleKoneksi.EksekusiQuery(query, p) Then
            MsgBox("Data Guru Berhasil Disimpan", vbInformation)
            Bersih()
            TampilData()
        End If
    End Sub

    ' [D] HAPUS
    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If selectedNIP = "" Then Return

        If MsgBox($"Yakin hapus Guru {txtAlamat.Text}?", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.Yes Then
            Dim p As New List(Of MySqlParameter) From {New MySqlParameter("@nip", selectedNIP)}
            If ModuleKoneksi.EksekusiQuery("DELETE FROM tbl_guru WHERE NIP=@nip", p) Then
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
    ' 5. KLIK TABEL (TRANSFER DATA KE FORM)
    ' =================================================================
    Private Sub dgvGuru_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvGuru.CellClick
        If e.RowIndex >= 0 Then
            Dim r = dgvGuru.Rows(e.RowIndex)
            selectedNIP = r.Cells("NIP").Value.ToString()

            txtNIP.Text = selectedNIP
            txtAlamat.Text = r.Cells("Nama_Guru").Value.ToString()

            ' Handle NULL value dengan aman
            txtAlamat.Text = If(IsDBNull(r.Cells("Alamat").Value), "", r.Cells("Alamat").Value.ToString())
            txtTelepon.Text = If(IsDBNull(r.Cells("Telepon").Value), "", r.Cells("Telepon").Value.ToString())
            txtEmail.Text = If(IsDBNull(r.Cells("Email").Value), "", r.Cells("Email").Value.ToString())

            cmbJK.Text = If(IsDBNull(r.Cells("Jenis_Kelamin").Value), "", r.Cells("Jenis_Kelamin").Value.ToString())
            cmbMapelPengampu.Text = If(IsDBNull(r.Cells("Status_Kepegawaian").Value), "", r.Cells("Status_Kepegawaian").Value.ToString())
            cmbPendidikan.Text = If(IsDBNull(r.Cells("Pendidikan_Terakhir").Value), "", r.Cells("Pendidikan_Terakhir").Value.ToString())
            cmbMapelPengampu.Text = If(IsDBNull(r.Cells("Mapel_Pengampu").Value), "", r.Cells("Mapel_Pengampu").Value.ToString())

            AturInput(False)
            btnTambah.Enabled = True
            btnSimpan.Enabled = False
            btnUbah.Enabled = True
            btnHapus.Enabled = True
        End If
    End Sub

    ' =================================================================
    ' 6. CETAK PDF (ANTI CRASH & AMBIGUOUS)
    ' =================================================================
    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click
        If dgvGuru.Rows.Count = 0 Then MsgBox("Data kosong!", vbExclamation) : Return

        Dim sfd As New SaveFileDialog() With {.Filter = "PDF Files|*.pdf", .FileName = "DataGuru_" & DateTime.Now.ToString("yyyyMMdd")}

        If sfd.ShowDialog() = DialogResult.OK Then
            Try
                ' Menggunakan Namespace Lengkap untuk menghindari error "Ambiguous"
                Dim doc As New iTextSharp.text.Document(iTextSharp.text.PageSize.A4.Rotate(), 10, 10, 10, 10)
                iTextSharp.text.pdf.PdfWriter.GetInstance(doc, New FileStream(sfd.FileName, FileMode.Create))
                doc.Open()

                Dim p As New iTextSharp.text.Paragraph("LAPORAN DATA GURU")
                p.Alignment = iTextSharp.text.Element.ALIGN_CENTER
                doc.Add(p)
                doc.Add(New iTextSharp.text.Paragraph(" "))

                ' Tabel
                Dim table As New iTextSharp.text.pdf.PdfPTable(dgvGuru.Columns.Count)
                table.WidthPercentage = 100

                ' Header
                For Each col As DataGridViewColumn In dgvGuru.Columns
                    Dim cell As New iTextSharp.text.pdf.PdfPCell(New iTextSharp.text.Phrase(col.HeaderText))
                    cell.BackgroundColor = iTextSharp.text.BaseColor.LIGHT_GRAY
                    table.AddCell(cell)
                Next

                ' Isi Data
                For Each row As DataGridViewRow In dgvGuru.Rows
                    If row.IsNewRow Then Continue For

                    For Each cell As DataGridViewCell In row.Cells
                        table.AddCell(If(cell.Value Is Nothing, "", cell.Value.ToString()))
                    Next
                Next

                doc.Add(table)
                doc.Close()
                MsgBox("PDF Berhasil Disimpan!", vbInformation)
                Process.Start(sfd.FileName)

            Catch ex As Exception
                MsgBox("Gagal Cetak: " & ex.Message, vbCritical)
            End Try
        End If
    End Sub

    Private Sub dgvGuru_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvGuru.CellContentClick

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub txtNIP_TextChanged(sender As Object, e As EventArgs) Handles txtNIP.TextChanged

    End Sub
End Class