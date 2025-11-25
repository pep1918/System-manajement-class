Imports MySql.Data.MySqlClient
Imports System.IO
Imports iTextSharp.text
Imports iTextSharp.text.pdf

' Pastikan nama Class sama dengan nama File
Public Class UC_DataGuru
    Inherits UserControl ' <--- BARIS INI SANGAT PENTING AGAR TIDAK ERROR

    Private selectedNIP As String = ""

    ' ==========================================
    ' 1. SAAT LOAD HALAMAN
    ' ==========================================
    Private Sub UC_DataGuru_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Cek apakah kita sedang dalam Mode Desain atau Running
        If Me.DesignMode Then Return

        Try
            TampilData()
            IsiComboMapel()
            Bersih()

            ' Isi manual combo status & pendidikan jika kosong
            If cmbStatus.Items.Count = 0 Then
                cmbStatus.Items.AddRange(New String() {"PNS", "GTY", "Honorer", "Tetap Yayasan"})
            End If
            If cmbPendidikan.Items.Count = 0 Then
                cmbPendidikan.Items.AddRange(New String() {"D3", "S1", "S2", "S3"})
            End If
        Catch ex As Exception
            ' Abaikan error saat loading awal desain
        End Try
    End Sub

    ' Mengisi Pilihan Mapel dari Database
    Sub IsiComboMapel()
        Try
            ModuleKoneksi.BukaKoneksi()
            ModuleKoneksi.Cmd = New MySqlCommand("SELECT Nama_Mapel FROM tbl_mapel ORDER BY Nama_Mapel", ModuleKoneksi.Conn)
            ModuleKoneksi.Rd = ModuleKoneksi.Cmd.ExecuteReader()

            cmbMapelPengampu.Items.Clear()
            cmbFilterMapel.Items.Clear()
            cmbFilterMapel.Items.Add("Semua")

            While ModuleKoneksi.Rd.Read()
                cmbMapelPengampu.Items.Add(ModuleKoneksi.Rd("Nama_Mapel").ToString())
                cmbFilterMapel.Items.Add(ModuleKoneksi.Rd("Nama_Mapel").ToString())
            End While
            ModuleKoneksi.Rd.Close()
        Catch ex As Exception
            If ModuleKoneksi.Rd IsNot Nothing AndAlso Not ModuleKoneksi.Rd.IsClosed Then ModuleKoneksi.Rd.Close()
        End Try
    End Sub

    ' ==========================================
    ' 2. BERSIHKAN INPUT
    ' ==========================================
    Sub Bersih()
        txtNIP.Clear()
        txtNama.Clear()
        cmbJenisKelamin.SelectedIndex = -1
        txtAlamat.Clear()
        txtTelepon.Clear()
        txtEmail.Clear()

        cmbStatus.SelectedIndex = -1
        cmbPendidikan.SelectedIndex = -1
        cmbMapelPengampu.SelectedIndex = -1

        txtNIP.Enabled = True
        selectedNIP = ""

        btnTambah.Enabled = True
        btnUbah.Enabled = False
        btnHapus.Enabled = False
    End Sub

    ' ==========================================
    ' 3. TAMPIL DATA
    ' ==========================================
    Sub TampilData()
        Try
            ModuleKoneksi.BukaKoneksi()

            Dim query As String = "SELECT NIP, Nama_Guru, Jenis_Kelamin, Alamat, Telepon, Email, Status_Kepegawaian, Pendidikan_Terakhir, Mapel_Pengampu FROM tbl_guru WHERE 1=1 "

            If txtCari.Text <> "" Then
                query &= " AND (Nama_Guru LIKE '%" & txtCari.Text & "%' OR NIP LIKE '%" & txtCari.Text & "%')"
            End If

            If cmbFilterMapel.SelectedIndex > 0 And cmbFilterMapel.Text <> "Semua" Then
                query &= " AND Mapel_Pengampu = '" & cmbFilterMapel.Text & "'"
            End If

            ModuleKoneksi.Cmd = New MySqlCommand(query, ModuleKoneksi.Conn)
            ModuleKoneksi.Da = New MySqlDataAdapter(ModuleKoneksi.Cmd)

            Dim dt As New DataTable()
            ModuleKoneksi.Da.Fill(dt)
            dgvGuru.DataSource = dt

        Catch ex As Exception
            MessageBox.Show("Gagal Tampil: " & ex.Message)
        End Try
    End Sub

    Private Sub txtCari_TextChanged(sender As Object, e As EventArgs) Handles txtCari.TextChanged
        TampilData()
    End Sub

    Private Sub cmbFilterMapel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFilterMapel.SelectedIndexChanged
        TampilData()
    End Sub

    ' ==========================================
    ' 4. PILIH DATA
    ' ==========================================
    Private Sub dgvGuru_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvGuru.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvGuru.Rows(e.RowIndex)
            selectedNIP = row.Cells("NIP").Value.ToString()

            txtNIP.Text = row.Cells("NIP").Value.ToString()
            txtNama.Text = row.Cells("Nama_Guru").Value.ToString()

            cmbJenisKelamin.Text = If(IsDBNull(row.Cells("Jenis_Kelamin").Value), "", row.Cells("Jenis_Kelamin").Value.ToString())
            txtAlamat.Text = If(IsDBNull(row.Cells("Alamat").Value), "", row.Cells("Alamat").Value.ToString())
            txtTelepon.Text = If(IsDBNull(row.Cells("Telepon").Value), "", row.Cells("Telepon").Value.ToString())
            txtEmail.Text = If(IsDBNull(row.Cells("Email").Value), "", row.Cells("Email").Value.ToString())

            cmbStatus.Text = If(IsDBNull(row.Cells("Status_Kepegawaian").Value), "", row.Cells("Status_Kepegawaian").Value.ToString())
            cmbPendidikan.Text = If(IsDBNull(row.Cells("Pendidikan_Terakhir").Value), "", row.Cells("Pendidikan_Terakhir").Value.ToString())
            cmbMapelPengampu.Text = If(IsDBNull(row.Cells("Mapel_Pengampu").Value), "", row.Cells("Mapel_Pengampu").Value.ToString())

            txtNIP.Enabled = False
            btnTambah.Enabled = False
            btnUbah.Enabled = True
            btnHapus.Enabled = True
        End If
    End Sub

    ' ==========================================
    ' 5. CRUD
    ' ==========================================
    Sub JalankanQuery(query As String, pesan As String)
        Try
            ModuleKoneksi.BukaKoneksi()
            ModuleKoneksi.Cmd = New MySqlCommand(query, ModuleKoneksi.Conn)

            ModuleKoneksi.Cmd.Parameters.AddWithValue("@nip", txtNIP.Text)
            ModuleKoneksi.Cmd.Parameters.AddWithValue("@nama", txtNama.Text)
            ModuleKoneksi.Cmd.Parameters.AddWithValue("@jk", cmbJenisKelamin.Text)
            ModuleKoneksi.Cmd.Parameters.AddWithValue("@alamat", txtAlamat.Text)
            ModuleKoneksi.Cmd.Parameters.AddWithValue("@telp", txtTelepon.Text)
            ModuleKoneksi.Cmd.Parameters.AddWithValue("@email", txtEmail.Text)
            ModuleKoneksi.Cmd.Parameters.AddWithValue("@stat", cmbStatus.Text)
            ModuleKoneksi.Cmd.Parameters.AddWithValue("@didik", cmbPendidikan.Text)
            ModuleKoneksi.Cmd.Parameters.AddWithValue("@mapel", cmbMapelPengampu.Text)

            ModuleKoneksi.Cmd.ExecuteNonQuery()
            MessageBox.Show("Data Berhasil " & pesan)
            Bersih()
            TampilData()
        Catch ex As Exception
            MessageBox.Show("Gagal Eksekusi: " & ex.Message)
        End Try
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        If txtNIP.Text = "" Or txtNama.Text = "" Then
            MessageBox.Show("NIP dan Nama wajib diisi!")
            Return
        End If
        Dim query As String = "INSERT INTO tbl_guru (NIP, Nama_Guru, Jenis_Kelamin, Alamat, Telepon, Email, Status_Kepegawaian, Pendidikan_Terakhir, Mapel_Pengampu) VALUES (@nip, @nama, @jk, @alamat, @telp, @email, @stat, @didik, @mapel)"
        JalankanQuery(query, "Ditambahkan")
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        If selectedNIP = "" Then Return
        Dim query As String = "UPDATE tbl_guru SET Nama_Guru=@nama, Jenis_Kelamin=@jk, Alamat=@alamat, Telepon=@telp, Email=@email, Status_Kepegawaian=@stat, Pendidikan_Terakhir=@didik, Mapel_Pengampu=@mapel WHERE NIP=@nip"
        JalankanQuery(query, "Diubah")
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If selectedNIP = "" Then Return
        If MessageBox.Show("Hapus Guru ini?", "Konfirmasi", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Try
                ModuleKoneksi.BukaKoneksi()
                ModuleKoneksi.Cmd = New MySqlCommand("DELETE FROM tbl_guru WHERE NIP=@nip", ModuleKoneksi.Conn)
                ModuleKoneksi.Cmd.Parameters.AddWithValue("@nip", selectedNIP)
                ModuleKoneksi.Cmd.ExecuteNonQuery()

                MessageBox.Show("Data Berhasil Dihapus")
                Bersih()
                TampilData()
            Catch ex As Exception
                MessageBox.Show("Gagal Hapus: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Bersih()
    End Sub

    ' ==========================================
    ' 6. EXPORT PDF
    ' ==========================================
    Private Sub btnExportPDF_Click(sender As Object, e As EventArgs) Handles btnExportPDF.Click
        Dim sfd As New SaveFileDialog()
        sfd.Filter = "PDF Files|*.pdf"
        sfd.FileName = "DataGuru_" & DateTime.Now.ToString("yyyyMMdd")

        If sfd.ShowDialog() = DialogResult.OK Then
            Try
                Dim doc As New Document(PageSize.A4.Rotate(), 10, 10, 10, 10)
                Dim writer As PdfWriter = PdfWriter.GetInstance(doc, New FileStream(sfd.FileName, FileMode.Create))
                doc.Open()

                Dim p As New Paragraph("LAPORAN DATA GURU")
                p.Alignment = Element.ALIGN_CENTER
                doc.Add(p)
                doc.Add(New Paragraph(" "))

                Dim table As New PdfPTable(dgvGuru.Columns.Count)
                table.WidthPercentage = 100

                For Each col As DataGridViewColumn In dgvGuru.Columns
                    Dim cell As New PdfPCell(New Phrase(col.HeaderText))
                    cell.BackgroundColor = BaseColor.LIGHT_GRAY
                    table.AddCell(cell)
                Next

                For Each row As DataGridViewRow In dgvGuru.Rows
                    For Each cell As DataGridViewCell In row.Cells
                        table.AddCell(If(cell.Value Is Nothing, "", cell.Value.ToString()))
                    Next
                Next

                doc.Add(table)
                doc.Close()
                MessageBox.Show("Laporan PDF Berhasil Disimpan!")
            Catch ex As Exception
                MessageBox.Show("Gagal Export PDF: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub txtNIP_TextChanged(sender As Object, e As EventArgs) Handles txtNIP.TextChanged

    End Sub

    Private Sub cmbJenisKelamin_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbJenisKelamin.SelectedIndexChanged

    End Sub

    Private Sub cmbMapelPengampu_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMapelPengampu.SelectedIndexChanged

    End Sub

    Private Sub cmbSpesialisasi_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtNama_TextChanged(sender As Object, e As EventArgs) Handles txtNama.TextChanged

    End Sub

    Private Sub txtAlamat_TextChanged(sender As Object, e As EventArgs) Handles txtAlamat.TextChanged

    End Sub

    Private Sub cmbStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbStatus.SelectedIndexChanged

    End Sub
End Class