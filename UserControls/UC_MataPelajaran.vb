Imports MySql.Data.MySqlClient
Imports System.IO
Imports iTextSharp.text
Imports iTextSharp.text.pdf

Public Class UC_MataPelajaran
    Inherits UserControl
    Private selectedKode As String = ""
    Private oldKKM As Integer = 0

#Region "Load & Helper"

    Private Sub UC_MataPelajaran_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilData()
        Bersih()
    End Sub

    Sub Bersih()
        selectedKode = ""
        oldKKM = 0
        txtKodeMapel.Clear()
        txtNamaMapel.Clear()
        txtKKM.Text = "75"
        cmbJurusan.SelectedIndex = -1
        cmbKategori.SelectedIndex = -1
        cmbTingkat.SelectedIndex = -1

        txtKodeMapel.Enabled = True
        btnSimpan.Text = "Simpan"
        btnHapus.Enabled = False
        btnLihatHistory.Enabled = False
    End Sub

    Sub TampilData()
        Try
            ModuleKoneksi.BukaKoneksi()

            Dim query As String = "SELECT kode_mapel, nama_mapel, kkm, tingkat, jurusan, kategori FROM tbl_mapel ORDER BY jurusan, tingkat, nama_mapel"

            ' Gunakan Global Cmd & Da
            ModuleKoneksi.Cmd = New MySqlCommand(query, ModuleKoneksi.Conn)
            ModuleKoneksi.Da = New MySqlDataAdapter(ModuleKoneksi.Cmd)

            Dim dt As New DataTable()
            ModuleKoneksi.Da.Fill(dt)
            dgvMapel.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("Error Tampil Data: " & ex.Message)
        End Try
    End Sub

#End Region

#Region "CRUD & Logika KKM"

    Private Sub dgvMapel_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMapel.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvMapel.Rows(e.RowIndex)

            selectedKode = row.Cells("kode_mapel").Value.ToString()
            txtKodeMapel.Text = selectedKode
            txtNamaMapel.Text = row.Cells("nama_mapel").Value.ToString()

            oldKKM = Convert.ToInt32(row.Cells("kkm").Value)
            txtKKM.Text = oldKKM.ToString()

            cmbTingkat.Text = If(IsDBNull(row.Cells("tingkat").Value), "", row.Cells("tingkat").Value.ToString())
            cmbJurusan.Text = If(IsDBNull(row.Cells("jurusan").Value), "", row.Cells("jurusan").Value.ToString())
            cmbKategori.Text = If(IsDBNull(row.Cells("kategori").Value), "", row.Cells("kategori").Value.ToString())

            txtKodeMapel.Enabled = False
            btnSimpan.Text = "Update"
            btnHapus.Enabled = True
            btnLihatHistory.Enabled = True
        End If
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If txtKodeMapel.Text = "" Or txtNamaMapel.Text = "" Or txtKKM.Text = "" Then
            MessageBox.Show("Semua field wajib diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Dim newKKM As Integer = Convert.ToInt32(txtKKM.Text)
            Dim query As String = ""

            If selectedKode = "" Then
                query = "INSERT INTO tbl_mapel (kode_mapel, nama_mapel, kkm, tingkat, jurusan, kategori) VALUES (@kode, @nama, @kkm, @tkt, @jur, @kat)"
            Else
                query = "UPDATE tbl_mapel SET nama_mapel=@nama, kkm=@kkm, tingkat=@tkt, jurusan=@jur, kategori=@kat WHERE kode_mapel=@kode"
            End If

            ModuleKoneksi.BukaKoneksi()

            ModuleKoneksi.Cmd = New MySqlCommand(query, ModuleKoneksi.Conn)
            ModuleKoneksi.Cmd.Parameters.AddWithValue("@kode", txtKodeMapel.Text)
            ModuleKoneksi.Cmd.Parameters.AddWithValue("@nama", txtNamaMapel.Text)
            ModuleKoneksi.Cmd.Parameters.AddWithValue("@kkm", newKKM)
            ModuleKoneksi.Cmd.Parameters.AddWithValue("@tkt", cmbTingkat.Text)
            ModuleKoneksi.Cmd.Parameters.AddWithValue("@jur", cmbJurusan.Text)
            ModuleKoneksi.Cmd.Parameters.AddWithValue("@kat", cmbKategori.Text)

            ModuleKoneksi.Cmd.ExecuteNonQuery()

            ' Logika History
            If selectedKode <> "" AndAlso oldKKM <> newKKM Then
                CatatHistoryKKM(selectedKode, oldKKM, newKKM)
            End If

            MessageBox.Show("Data Mapel berhasil disimpan!", "Sukses")
            Bersih()
            TampilData()

        Catch ex As Exception
            MessageBox.Show("Gagal Simpan: " & ex.Message)
        End Try
    End Sub

    Private Sub CatatHistoryKKM(kode As String, lama As Integer, baru As Integer)
        Try
            Dim queryLog As String = "INSERT INTO tbl_log_kkm (kode_mapel, kkm_lama, kkm_baru, tgl_ubah, user_pengubah) VALUES (@kd, @lama, @baru, NOW(), @user)"

            ModuleKoneksi.Cmd = New MySqlCommand(queryLog, ModuleKoneksi.Conn)
            ModuleKoneksi.Cmd.Parameters.AddWithValue("@kd", kode)
            ModuleKoneksi.Cmd.Parameters.AddWithValue("@lama", lama)
            ModuleKoneksi.Cmd.Parameters.AddWithValue("@baru", baru)

            Dim userLogin As String = If(String.IsNullOrEmpty(ModuleKoneksi.CurrentUser), "Admin", ModuleKoneksi.CurrentUser)
            ModuleKoneksi.Cmd.Parameters.AddWithValue("@user", userLogin)

            ModuleKoneksi.Cmd.ExecuteNonQuery()
        Catch ex As Exception
            ' Silent error
        End Try
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If selectedKode = "" Then Return
        If MessageBox.Show("Hapus Mapel ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Try
                ModuleKoneksi.BukaKoneksi()
                Dim cmd As New MySqlCommand("DELETE FROM tbl_mapel WHERE kode_mapel=@kode", ModuleKoneksi.Conn)
                cmd.Parameters.AddWithValue("@kode", selectedKode)
                cmd.ExecuteNonQuery()

                Bersih()
                TampilData()
            Catch ex As Exception
                MessageBox.Show("Gagal Hapus: " & ex.Message)
            End Try
        End If
    End Sub

#End Region

#Region "Fitur Tambahan"

    Private Sub btnLihatHistory_Click(sender As Object, e As EventArgs) Handles btnLihatHistory.Click
        If selectedKode = "" Then Return

        Try
            ModuleKoneksi.BukaKoneksi()
            Dim query As String = "SELECT tgl_ubah, kkm_lama, kkm_baru, user_pengubah FROM tbl_log_kkm WHERE kode_mapel = @kode ORDER BY tgl_ubah DESC"

            ModuleKoneksi.Cmd = New MySqlCommand(query, ModuleKoneksi.Conn)
            ModuleKoneksi.Cmd.Parameters.AddWithValue("@kode", selectedKode)
            ModuleKoneksi.Da = New MySqlDataAdapter(ModuleKoneksi.Cmd)

            Dim dt As New DataTable()
            ModuleKoneksi.Da.Fill(dt)

            If dt.Rows.Count > 0 Then
                Dim msg As String = "Riwayat Perubahan KKM (" & txtNamaMapel.Text & "):" & vbCrLf & vbCrLf
                For Each row As DataRow In dt.Rows
                    msg &= String.Format("[{0}] {1} -> {2} (oleh {3})", Convert.ToDateTime(row("tgl_ubah")).ToString("dd/MM/yy HH:mm"), row("kkm_lama"), row("kkm_baru"), row("user_pengubah")) & vbCrLf
                Next
                MessageBox.Show(msg, "History KKM", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Belum ada riwayat perubahan KKM.", "Info")
            End If

        Catch ex As Exception
            MessageBox.Show("Gagal Load History: " & ex.Message)
        End Try
    End Sub

    Private Sub btnExportPDF_Click(sender As Object, e As EventArgs) Handles btnExportPDF.Click
        Dim sfd As New SaveFileDialog()
        sfd.Filter = "PDF Files|*.pdf"
        sfd.FileName = "DataMataPelajaran_" & DateTime.Now.ToString("yyyyMMdd")

        If sfd.ShowDialog() = DialogResult.OK Then
            Try
                Dim doc As New Document(PageSize.A4.Rotate(), 10, 10, 10, 10)
                Dim writer As PdfWriter = PdfWriter.GetInstance(doc, New FileStream(sfd.FileName, FileMode.Create))
                doc.Open()

                Dim p As New Paragraph("DATA MATA PELAJARAN")
                p.Alignment = Element.ALIGN_CENTER
                doc.Add(p)
                doc.Add(New Paragraph(" "))

                Dim table As New PdfPTable(dgvMapel.Columns.Count)
                table.WidthPercentage = 100

                For Each col As DataGridViewColumn In dgvMapel.Columns
                    Dim cell As New PdfPCell(New Phrase(col.HeaderText))
                    cell.BackgroundColor = BaseColor.LIGHT_GRAY
                    table.AddCell(cell)
                Next

                For Each row As DataGridViewRow In dgvMapel.Rows
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

    Private Sub txtKKM_TextChanged(sender As Object, e As EventArgs) Handles txtKKM.TextChanged
    End Sub

    Private Sub dgvMapel_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMapel.CellContentClick
    End Sub

#End Region

End Class