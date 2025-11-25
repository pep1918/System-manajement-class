Imports MySql.Data.MySqlClient
Imports System.IO
Imports iTextSharp.text
Imports iTextSharp.text.pdf

Public Class UC_DataSiswa
    Inherits UserControl
    Private selectedNIS As String = ""

    ' --- LOGIKA UMUM & HELPER ---
#Region "Helper & Validasi"

    Sub Bersih()
        txtNIS.Clear()
        txtNama.Clear()
        txtJurusan.Clear()
        txtTahunMasuk.Clear()
        cmbKelas.SelectedIndex = -1
        cmbJenisKelamin.SelectedIndex = -1
        cmbStatus.SelectedIndex = -1
        dtpTanggalLahir.Value = Now
        txtNIS.Enabled = True
        selectedNIS = ""

        btnSimpan.Enabled = True
        btnEdit.Enabled = False
        btnHapus.Enabled = False
    End Sub

    Private Function CekNISDuplikat(nis As String) As Boolean
        Dim hasil As Boolean = False
        Try
            ModuleKoneksi.BukaKoneksi()

            Dim query As String = "SELECT COUNT(*) FROM tbl_siswa WHERE nis = @nis"
            ModuleKoneksi.Cmd = New MySqlCommand(query, ModuleKoneksi.Conn)
            ModuleKoneksi.Cmd.Parameters.AddWithValue("@nis", nis)

            Dim count As Integer = Convert.ToInt32(ModuleKoneksi.Cmd.ExecuteScalar())
            If count > 0 Then hasil = True

        Catch ex As Exception
            MessageBox.Show("Gagal Cek NIS: " & ex.Message)
        End Try
        Return hasil
    End Function

    Private Sub TampilData()
        Try
            ModuleKoneksi.BukaKoneksi()

            Dim query As String = "SELECT * FROM tbl_siswa WHERE 1=1 "

            If Not String.IsNullOrWhiteSpace(txtCariSiswa.Text) Then
                query &= " AND (nama LIKE @cari OR nis LIKE @cari)"
            End If
            If cmbFilterKelas.SelectedIndex > -1 AndAlso cmbFilterKelas.Text <> "Semua" Then
                query &= " AND kelas = '" & cmbFilterKelas.Text & "'"
            End If
            If cmbFilterStatus.SelectedIndex > -1 AndAlso cmbFilterStatus.Text <> "Semua" Then
                query &= " AND status = '" & cmbFilterStatus.Text & "'"
            End If
            If cmbFilterJurusan.SelectedIndex > -1 AndAlso cmbFilterJurusan.Text <> "Semua" Then
                query &= " AND jurusan = '" & cmbFilterJurusan.Text & "'"
            End If

            ModuleKoneksi.Cmd = New MySqlCommand(query, ModuleKoneksi.Conn)

            If Not String.IsNullOrWhiteSpace(txtCariSiswa.Text) Then
                ModuleKoneksi.Cmd.Parameters.AddWithValue("@cari", "%" & txtCariSiswa.Text & "%")
            End If

            ModuleKoneksi.Da = New MySqlDataAdapter(ModuleKoneksi.Cmd)
            Dim dt As New DataTable()
            ModuleKoneksi.Da.Fill(dt)
            dgvSiswa.DataSource = dt

        Catch ex As Exception
            MessageBox.Show("Gagal memuat data: " & ex.Message)
        End Try
    End Sub
#End Region

    ' --- EVENT BAWAAN ---
#Region "Event GridView dan Pencarian"

    Private Sub UC_DataSiswa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilData()
        Bersih()
    End Sub

    Private Sub dgvSiswa_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSiswa.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvSiswa.Rows(e.RowIndex)
            selectedNIS = row.Cells("nis").Value.ToString()
            txtNIS.Text = row.Cells("nis").Value.ToString()
            txtNama.Text = row.Cells("nama").Value.ToString()

            Try
                dtpTanggalLahir.Value = Convert.ToDateTime(row.Cells("tgl_lahir").Value)
                cmbKelas.Text = row.Cells("kelas").Value.ToString()
                txtJurusan.Text = row.Cells("jurusan").Value.ToString()
                txtTahunMasuk.Text = row.Cells("tahun_masuk").Value.ToString()
                cmbJenisKelamin.Text = row.Cells("jenis_kelamin").Value.ToString()
                cmbStatus.Text = row.Cells("status").Value.ToString()
            Catch
            End Try

            If ModuleKoneksi.CurrentUserLevel <> "Siswa" Then
                txtNIS.Enabled = False
                btnSimpan.Enabled = False
                btnEdit.Enabled = True
                btnHapus.Enabled = True
            End If
        End If
    End Sub

    Private Sub txtCariSiswa_TextChanged(sender As Object, e As EventArgs) Handles txtCariSiswa.TextChanged
        TampilData()
    End Sub

    Private Sub Filter_Changed(sender As Object, e As EventArgs) Handles cmbFilterKelas.SelectedIndexChanged
        TampilData()
    End Sub

    Private Sub btnResetFilter_Click(sender As Object, e As EventArgs) 
        cmbFilterKelas.SelectedIndex = -1
        cmbFilterStatus.SelectedIndex = -1
        cmbFilterJurusan.SelectedIndex = -1
        txtCariSiswa.Clear()
        TampilData()
    End Sub
#End Region

    ' --- CRUD ---
#Region "CRUD Operations"

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If txtNIS.Text = "" Or txtNama.Text = "" Then
            MessageBox.Show("NIS dan Nama wajib diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If CekNISDuplikat(txtNIS.Text) Then
            MessageBox.Show("NIS sudah terdaftar!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Try
            ModuleKoneksi.BukaKoneksi()
            Dim query As String = "INSERT INTO tbl_siswa (nis, nama, tgl_lahir, kelas, jurusan, tahun_masuk, jenis_kelamin, status) VALUES (@nis, @nama, @tgl, @kls, @jur, @thn, @jk, @stat)"

            ModuleKoneksi.Cmd = New MySqlCommand(query, ModuleKoneksi.Conn)
            ModuleKoneksi.Cmd.Parameters.AddWithValue("@nis", txtNIS.Text)
            ModuleKoneksi.Cmd.Parameters.AddWithValue("@nama", txtNama.Text)
            ModuleKoneksi.Cmd.Parameters.AddWithValue("@tgl", dtpTanggalLahir.Value.ToString("yyyy-MM-dd"))
            ModuleKoneksi.Cmd.Parameters.AddWithValue("@kls", cmbKelas.Text)
            ModuleKoneksi.Cmd.Parameters.AddWithValue("@jur", txtJurusan.Text)
            ModuleKoneksi.Cmd.Parameters.AddWithValue("@thn", txtTahunMasuk.Text)
            ModuleKoneksi.Cmd.Parameters.AddWithValue("@jk", cmbJenisKelamin.Text)
            ModuleKoneksi.Cmd.Parameters.AddWithValue("@stat", cmbStatus.Text)

            ModuleKoneksi.Cmd.ExecuteNonQuery()
            MessageBox.Show("Data berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Bersih()
            TampilData()

        Catch ex As Exception
            MessageBox.Show("Error Simpan: " & ex.Message)
        End Try
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If selectedNIS = "" Then Return

        Try
            ModuleKoneksi.BukaKoneksi()
            Dim query As String = "UPDATE tbl_siswa SET nama=@nama, tgl_lahir=@tgl, kelas=@kls, jurusan=@jur, tahun_masuk=@thn, jenis_kelamin=@jk, status=@stat WHERE nis=@nis"

            ModuleKoneksi.Cmd = New MySqlCommand(query, ModuleKoneksi.Conn)
            ModuleKoneksi.Cmd.Parameters.AddWithValue("@nama", txtNama.Text)
            ModuleKoneksi.Cmd.Parameters.AddWithValue("@tgl", dtpTanggalLahir.Value.ToString("yyyy-MM-dd"))
            ModuleKoneksi.Cmd.Parameters.AddWithValue("@kls", cmbKelas.Text)
            ModuleKoneksi.Cmd.Parameters.AddWithValue("@jur", txtJurusan.Text)
            ModuleKoneksi.Cmd.Parameters.AddWithValue("@thn", txtTahunMasuk.Text)
            ModuleKoneksi.Cmd.Parameters.AddWithValue("@jk", cmbJenisKelamin.Text)
            ModuleKoneksi.Cmd.Parameters.AddWithValue("@stat", cmbStatus.Text)
            ModuleKoneksi.Cmd.Parameters.AddWithValue("@nis", selectedNIS)

            ModuleKoneksi.Cmd.ExecuteNonQuery()
            MessageBox.Show("Data berhasil diupdate!", "Sukses")
            Bersih()
            TampilData()

        Catch ex As Exception
            MessageBox.Show("Error Update: " & ex.Message)
        End Try
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If selectedNIS = "" Then Return

        If MessageBox.Show("Yakin ingin menghapus siswa ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Try
                ModuleKoneksi.BukaKoneksi()
                Dim query As String = "DELETE FROM tbl_siswa WHERE nis=@nis"
                ModuleKoneksi.Cmd = New MySqlCommand(query, ModuleKoneksi.Conn)
                ModuleKoneksi.Cmd.Parameters.AddWithValue("@nis", selectedNIS)

                ModuleKoneksi.Cmd.ExecuteNonQuery()
                MessageBox.Show("Data berhasil dihapus!", "Sukses")
                Bersih()
                TampilData()
            Catch ex As Exception
                MessageBox.Show("Error Hapus: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Bersih()
    End Sub
#End Region

    ' --- EXPORT PDF SAJA ---
#Region "Export Features"

    Private Sub btnExportPDF_Click(sender As Object, e As EventArgs) Handles btnExportPDF.Click
        Dim sfd As New SaveFileDialog()
        sfd.Filter = "PDF Files|*.pdf"
        sfd.FileName = "DataSiswa_" & DateTime.Now.ToString("yyyyMMdd")

        If sfd.ShowDialog() = DialogResult.OK Then
            Try
                Dim doc As New Document(PageSize.A4.Rotate(), 10, 10, 10, 10)
                Dim writer As PdfWriter = PdfWriter.GetInstance(doc, New FileStream(sfd.FileName, FileMode.Create))
                doc.Open()

                Dim p As New Paragraph("LAPORAN DATA SISWA")
                p.Alignment = Element.ALIGN_CENTER
                doc.Add(p)
                doc.Add(New Paragraph(" "))

                Dim table As New PdfPTable(dgvSiswa.Columns.Count)
                table.WidthPercentage = 100

                ' Header PDF
                For Each col As DataGridViewColumn In dgvSiswa.Columns
                    Dim cell As New PdfPCell(New Phrase(col.HeaderText))
                    cell.BackgroundColor = BaseColor.LIGHT_GRAY
                    table.AddCell(cell)
                Next

                ' Data PDF
                For Each row As DataGridViewRow In dgvSiswa.Rows
                    For Each cell As DataGridViewCell In row.Cells
                        table.AddCell(If(cell.Value IsNot Nothing, cell.Value.ToString(), ""))
                    Next
                Next

                doc.Add(table)
                doc.Close()
                MessageBox.Show("PDF Berhasil disimpan!")
            Catch ex As Exception
                MessageBox.Show("Gagal Export PDF: " & ex.Message)
            End Try
        End If
    End Sub
#End Region

End Class