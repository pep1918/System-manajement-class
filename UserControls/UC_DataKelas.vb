Imports MySql.Data.MySqlClient
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO

Public Class UC_DataKelas

    ' --- VARIABEL GLOBAL ---
    Private selectedID As String = ""
    Private IsEditMode As Boolean = False

    ' =================================================================
    ' 1. SAAT FORM DIMUAT (LOAD)
    ' =================================================================
    Private Sub UC_DataKelas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Mencegah error designer
        If Me.DesignMode Then Return

        ' Atur DateTimePicker
        dtpTahunAjaran.Format = DateTimePickerFormat.Custom
        dtpTahunAjaran.CustomFormat = "yyyy"
        dtpTahunAjaran.ShowUpDown = True

        IsiComboWaliKelas()
        IsiComboFilter() ' <--- INI YANG TADI ERROR, SEKARANG SUDAH ADA DI BAWAH
        TampilData()
        Bersih()
    End Sub

    Sub IsiComboWaliKelas()
        ' HANYA TAMPILKAN NAMA (Tanpa NIP)
        Try
            ModuleKoneksi.IsiCombo("SELECT Nama_Guru FROM tbl_guru ORDER BY Nama_Guru", cmbWaliKelas)
        Catch ex As Exception
        End Try
    End Sub

    ' --- INI SUB YANG SEBELUMNYA HILANG ---
    Sub IsiComboFilter()
        Try
            ModuleKoneksi.BukaKoneksi()
            ModuleKoneksi.Cmd = New MySqlCommand("SELECT Nama_Kelas FROM tbl_kelas ORDER BY Nama_Kelas", ModuleKoneksi.Conn)
            ModuleKoneksi.Rd = ModuleKoneksi.Cmd.ExecuteReader()

            cmbFilterKelas.Items.Clear()
            cmbFilterKelas.Items.Add("Semua")

            While ModuleKoneksi.Rd.Read()
                cmbFilterKelas.Items.Add(ModuleKoneksi.Rd("Nama_Kelas").ToString())
            End While
            ModuleKoneksi.Rd.Close()

            If cmbFilterKelas.Items.Count > 0 Then cmbFilterKelas.SelectedIndex = 0
        Catch ex As Exception
            If ModuleKoneksi.Rd IsNot Nothing AndAlso Not ModuleKoneksi.Rd.IsClosed Then ModuleKoneksi.Rd.Close()
        End Try
    End Sub

    ' =================================================================
    ' 2. BERSIHKAN FORM
    ' =================================================================
    Sub Bersih()
        txtKelas.Clear()
        dtpTahunAjaran.Value = DateTime.Now
        cmbWaliKelas.SelectedIndex = -1

        selectedID = ""
        IsEditMode = False

        AturInput(False)

        btnTambah.Enabled = True
        btnUbah.Enabled = False
        btnHapus.Enabled = False
        btnSimpan.Enabled = False
        btnBatal.Enabled = True
    End Sub

    Sub AturInput(aktif As Boolean)
        txtKelas.Enabled = aktif
        dtpTahunAjaran.Enabled = aktif
        cmbWaliKelas.Enabled = aktif
    End Sub

    ' =================================================================
    ' 3. TAMPIL DATA (READ)
    ' =================================================================
    Sub TampilData()
        Dim q As String = "SELECT k.ID_Kelas, k.Nama_Kelas, k.Tahun_Ajaran, g.Nama_Guru, k.NIP_WaliKelas " &
                          "FROM tbl_kelas k " &
                          "LEFT JOIN tbl_guru g ON k.NIP_WaliKelas = g.NIP WHERE 1=1 "

        ' Filter Kelas (Merespon ComboBox Filter)
        If cmbFilterKelas.SelectedIndex > 0 And cmbFilterKelas.Text <> "Semua" Then
            q &= $" AND k.Nama_Kelas = '{cmbFilterKelas.Text}'"
        End If

        ' Filter Pencarian Text
        If txtCari.Text <> "" Then
            q &= " AND k.Nama_Kelas LIKE '%" & txtCari.Text & "%'"
        End If

        q &= " ORDER BY k.Nama_Kelas ASC"

        dgvKelas.DataSource = ModuleKoneksi.AmbilData(q)
        AturGrid()
    End Sub

    ' ==========================================
    ' SUB UNTUK MERAPIKAN JUDUL KOLOM TABEL
    ' ==========================================
    Sub AturGrid()
        If dgvKelas.Columns.Count > 0 Then
            ' Sembunyikan ID dan NIP (karena user hanya butuh lihat Nama)
            dgvKelas.Columns("ID_Kelas").Visible = False
            dgvKelas.Columns("NIP_WaliKelas").Visible = False

            ' Ganti Header
            dgvKelas.Columns("Nama_Kelas").HeaderText = "Nama Kelas"
            dgvKelas.Columns("Tahun_Ajaran").HeaderText = "Thn Ajaran"
            dgvKelas.Columns("Nama_Guru").HeaderText = "Wali Kelas"

            ' Atur lebar otomatis
            dgvKelas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        End If
    End Sub

    ' Event Filter Berubah
    Private Sub cmbFilterKelas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFilterKelas.SelectedIndexChanged
        TampilData()
    End Sub

    Private Sub txtCari_TextChanged(sender As Object, e As EventArgs) Handles txtCari.TextChanged
        TampilData()
    End Sub

    ' =================================================================
    ' 4. LOGIKA TOMBOL (CRUD)
    ' =================================================================

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Bersih()
        IsEditMode = False
        AturInput(True)
        txtKelas.Focus()

        btnTambah.Enabled = False
        btnSimpan.Enabled = True
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        If selectedID = "" Then MsgBox("Pilih data dulu!") : Return
        IsEditMode = True
        AturInput(True)
        txtKelas.Focus()

        btnTambah.Enabled = False
        btnUbah.Enabled = False
        btnSimpan.Enabled = True
    End Sub



    ' =================================================================
    ' 6. CETAK PDF
    ' =================================================================
    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click
        If dgvKelas.Rows.Count = 0 Then MsgBox("Data kosong!", vbExclamation) : Return

        Dim sfd As New SaveFileDialog() With {.Filter = "PDF Files|*.pdf", .FileName = "DataKelas_" & DateTime.Now.ToString("yyyyMMdd")}

        If sfd.ShowDialog() = DialogResult.OK Then
            Try
                Dim doc As New iTextSharp.text.Document(iTextSharp.text.PageSize.A4, 20, 20, 20, 20)
                PdfWriter.GetInstance(doc, New FileStream(sfd.FileName, FileMode.Create))
                doc.Open()

                Dim p As New iTextSharp.text.Paragraph("LAPORAN DATA KELAS")
                p.Alignment = iTextSharp.text.Element.ALIGN_CENTER
                doc.Add(p)
                doc.Add(New iTextSharp.text.Paragraph(" "))

                Dim table As New PdfPTable(3)
                table.WidthPercentage = 100

                For Each h As String In {"Nama Kelas", "Tahun Ajaran", "Wali Kelas"}
                    Dim cell As New PdfPCell(New iTextSharp.text.Phrase(h))
                    cell.BackgroundColor = iTextSharp.text.BaseColor.LIGHT_GRAY
                    table.AddCell(cell)
                Next

                For Each row As DataGridViewRow In dgvKelas.Rows
                    If row.IsNewRow Then Continue For

                    Dim vKelas As String = If(row.Cells("Nama_Kelas").Value Is Nothing, "", row.Cells("Nama_Kelas").Value.ToString())
                    Dim vTahun As String = If(row.Cells("Tahun_Ajaran").Value Is Nothing, "", row.Cells("Tahun_Ajaran").Value.ToString())
                    Dim vWali As String = If(row.Cells("Nama_Guru").Value Is Nothing, "-", row.Cells("Nama_Guru").Value.ToString())

                    table.AddCell(vKelas)
                    table.AddCell(vTahun)
                    table.AddCell(vWali)
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

    Private Sub cmbWaliKelas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbWaliKelas.SelectedIndexChanged

    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        ' 1. Validasi
        If txtKelas.Text = "" Or cmbWaliKelas.Text = "" Then
            MsgBox("Nama Kelas dan Wali Kelas wajib diisi!", vbExclamation)
            Return
        End If

        ' 2. CARI NIP BERDASARKAN NAMA (Logika Baru)
        ' Karena di combo cuma ada nama, kita tanya database: "Siapa NIP dari Guru bernama X?"
        Dim nipWali As String = ModuleKoneksi.AmbilNilai($"SELECT NIP FROM tbl_guru WHERE Nama_Guru='{cmbWaliKelas.Text}'")

        If nipWali = "0" Or nipWali = "" Then
            MsgBox("Data Guru tidak ditemukan di database!", vbCritical)
            Return
        End If

        ' 3. Format Tahun Ajaran (yyyy/yyyy+1)
        Dim thn As Integer = dtpTahunAjaran.Value.Year
        Dim thnAjaran As String = thn.ToString() & "/" & (thn + 1).ToString()

        ' 4. Siapkan Parameter
        Dim p As New List(Of MySqlParameter) From {
            New MySqlParameter("@nm", txtKelas.Text),
            New MySqlParameter("@thn", thnAjaran),
            New MySqlParameter("@wali", nipWali)
        }

        Dim query As String = ""

        If IsEditMode = False Then
            ' INSERT
            query = "INSERT INTO tbl_kelas (Nama_Kelas, Tahun_Ajaran, NIP_WaliKelas) VALUES (@nm, @thn, @wali)"
        Else
            ' UPDATE
            query = "UPDATE tbl_kelas SET Nama_Kelas=@nm, Tahun_Ajaran=@thn, NIP_WaliKelas=@wali WHERE ID_Kelas=@id"
            p.Add(New MySqlParameter("@id", selectedID))
        End If

        ' 5. Eksekusi
        If ModuleKoneksi.EksekusiQuery(query, p) Then
            MsgBox("Data Kelas Berhasil Disimpan", vbInformation)
            Bersih()
            TampilData()
            IsiComboFilter() ' Update filter
        End If
    End Sub
    Private Sub dgvKelas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvKelas.CellContentClick

    End Sub
End Class