Imports MySql.Data.MySqlClient
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO

Public Class UC_ManajemenPelajaran
    Inherits UserControl
    Private selectedID As String = ""

#Region "Load & Helper"

    Private Sub UC_ManajemenPelajaran_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadComboBoxes()

        ' Default Filter
        If cmbFilterKelas.Items.Count > 0 Then cmbFilterKelas.SelectedIndex = 0

        TampilData()
        Bersih()
    End Sub

    Sub Bersih()
        selectedID = ""
        cmbKelas.SelectedIndex = -1
        cmbGuru.SelectedIndex = -1
        cmbMapel.SelectedIndex = -1
        cmbRuangan.SelectedIndex = -1
        cmbHari.SelectedIndex = -1
        cmbSemester.SelectedIndex = -1
        txtTahunAjaran.Clear()
        dtpMulai.Value = DateTime.Now
        dtpSelesai.Value = DateTime.Now.AddHours(1)

        btnSimpan.Text = "Simpan"
        btnHapus.Enabled = False
    End Sub

    Sub LoadComboBoxes()
        Try
            ' 1. Kelas (Untuk Input)
            IsiCombo("SELECT Nama_Kelas FROM tbl_kelas ORDER BY Nama_Kelas", cmbKelas)

            ' 2. Guru
            IsiCombo("SELECT Nama_Guru FROM tbl_guru ORDER BY Nama_Guru", cmbGuru)

            ' 3. Mapel
            IsiCombo("SELECT Nama_Mapel FROM tbl_mapel ORDER BY Nama_Mapel", cmbMapel)

            ' 4. Filter Kelas (PENTING: Gunakan Rd Terpisah/Tutup Rd sebelumnya)
            ModuleKoneksi.BukaKoneksi()
            ModuleKoneksi.Cmd = New MySqlCommand("SELECT Nama_Kelas FROM tbl_kelas ORDER BY Nama_Kelas", ModuleKoneksi.Conn)
            ModuleKoneksi.Rd = ModuleKoneksi.Cmd.ExecuteReader()

            cmbFilterKelas.Items.Clear()
            cmbFilterKelas.Items.Add("Semua")

            While ModuleKoneksi.Rd.Read()
                cmbFilterKelas.Items.Add(ModuleKoneksi.Rd("Nama_Kelas").ToString())
            End While
            ModuleKoneksi.Rd.Close() ' WAJIB TUTUP

        Catch ex As Exception
            If ModuleKoneksi.Rd IsNot Nothing AndAlso Not ModuleKoneksi.Rd.IsClosed Then ModuleKoneksi.Rd.Close()
        End Try
    End Sub

    ' Helper Isi Combo (Menggunakan Global Rd)
    Sub IsiCombo(query As String, cmb As ComboBox)
        Try
            ModuleKoneksi.BukaKoneksi()
            ModuleKoneksi.Cmd = New MySqlCommand(query, ModuleKoneksi.Conn)
            ModuleKoneksi.Rd = ModuleKoneksi.Cmd.ExecuteReader()

            cmb.Items.Clear()
            While ModuleKoneksi.Rd.Read()
                cmb.Items.Add(ModuleKoneksi.Rd(0).ToString())
            End While
            ModuleKoneksi.Rd.Close() ' WAJIB TUTUP SEBELUM KELUAR
        Catch ex As Exception
            If ModuleKoneksi.Rd IsNot Nothing AndAlso Not ModuleKoneksi.Rd.IsClosed Then ModuleKoneksi.Rd.Close()
        End Try
    End Sub

#End Region

#Region "Logika Inti & Deteksi Bentrok"

    Private Function CekJadwalBentrok(guru As String, ruangan As String, hari As String, mulai As String, selesai As String, currentID As String) As String
        Dim pesanError As String = ""
        Try
            ModuleKoneksi.BukaKoneksi()

            Dim query As String = "SELECT * FROM tbl_jadwal WHERE " &
                                  "(id_guru = @guru OR id_ruangan = @ruang) " &
                                  "AND hari = @hari " &
                                  "AND (@mulai < jam_selesai AND @selesai > jam_mulai)"

            If currentID <> "" Then
                query &= " AND id_jadwal != " & currentID
            End If

            ModuleKoneksi.Cmd = New MySqlCommand(query, ModuleKoneksi.Conn)
            ModuleKoneksi.Cmd.Parameters.AddWithValue("@guru", guru)
            ModuleKoneksi.Cmd.Parameters.AddWithValue("@ruang", ruangan)
            ModuleKoneksi.Cmd.Parameters.AddWithValue("@hari", hari)
            ModuleKoneksi.Cmd.Parameters.AddWithValue("@mulai", mulai)
            ModuleKoneksi.Cmd.Parameters.AddWithValue("@selesai", selesai)

            ' Gunakan Rd Global
            ModuleKoneksi.Rd = ModuleKoneksi.Cmd.ExecuteReader()

            If ModuleKoneksi.Rd.Read() Then
                Dim guruBentrok As String = ModuleKoneksi.Rd("id_guru").ToString()
                Dim ruangBentrok As String = ModuleKoneksi.Rd("id_ruangan").ToString()

                If guruBentrok = guru Then
                    pesanError = "Guru ini sudah mengajar di kelas lain pada jam tersebut!"
                ElseIf ruangBentrok = ruangan Then
                    pesanError = "Ruangan ini sedang dipakai kelas lain pada jam tersebut!"
                End If
            End If
            ModuleKoneksi.Rd.Close() ' WAJIB TUTUP

        Catch ex As Exception
            pesanError = "Error Cek Bentrok: " & ex.Message
            If ModuleKoneksi.Rd IsNot Nothing AndAlso Not ModuleKoneksi.Rd.IsClosed Then ModuleKoneksi.Rd.Close()
        End Try

        Return pesanError
    End Function

    Private Sub TampilData()
        Try
            ModuleKoneksi.BukaKoneksi()

            Dim query As String = "SELECT id_jadwal, hari, jam_mulai, jam_selesai, id_kelas, id_mapel, id_guru, id_ruangan FROM tbl_jadwal WHERE 1=1 "

            ' FILTER KELAS
            If cmbFilterKelas.SelectedIndex > 0 AndAlso cmbFilterKelas.Text <> "Semua" Then
                query &= " AND id_kelas = '" & cmbFilterKelas.Text & "'"
            End If

            query &= " ORDER BY FIELD(hari, 'Senin', 'Selasa', 'Rabu', 'Kamis', 'Jumat', 'Sabtu'), jam_mulai ASC"

            ' Gunakan Cmd & Da Global
            ModuleKoneksi.Cmd = New MySqlCommand(query, ModuleKoneksi.Conn)
            ModuleKoneksi.Da = New MySqlDataAdapter(ModuleKoneksi.Cmd)

            Dim dt As New DataTable()
            ModuleKoneksi.Da.Fill(dt)
            dgvJadwal.DataSource = dt

            dgvJadwal.Columns("id_jadwal").Visible = False
            dgvJadwal.Columns("jam_mulai").DefaultCellStyle.Format = "hh\:mm"
            dgvJadwal.Columns("jam_selesai").DefaultCellStyle.Format = "hh\:mm"

        Catch ex As Exception
            MessageBox.Show("Gagal Tampil Data: " & ex.Message)
        End Try
    End Sub

#End Region

#Region "CRUD Operations"

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If cmbKelas.Text = "" Or cmbGuru.Text = "" Or cmbHari.Text = "" Then
            MessageBox.Show("Lengkapi semua data jadwal!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim jamMulai As String = dtpMulai.Value.ToString("HH:mm:ss")
        Dim jamSelesai As String = dtpSelesai.Value.ToString("HH:mm:ss")

        If TimeSpan.Parse(jamMulai) >= TimeSpan.Parse(jamSelesai) Then
            MessageBox.Show("Jam selesai harus lebih besar dari jam mulai!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim statusBentrok As String = CekJadwalBentrok(cmbGuru.Text, cmbRuangan.Text, cmbHari.Text, jamMulai, jamSelesai, selectedID)
        If statusBentrok <> "" Then
            MessageBox.Show("BENTROK: " & vbCrLf & statusBentrok, "Gagal Simpan", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return
        End If

        Try
            ModuleKoneksi.BukaKoneksi()
            Dim query As String

            If selectedID = "" Then
                query = "INSERT INTO tbl_jadwal (id_kelas, id_guru, id_mapel, id_ruangan, hari, jam_mulai, jam_selesai, tahun_ajaran, semester) " &
                        "VALUES (@kls, @guru, @mapel, @ruang, @hari, @mulai, @selesai, @thn, @sem)"
            Else
                query = "UPDATE tbl_jadwal SET id_kelas=@kls, id_guru=@guru, id_mapel=@mapel, id_ruangan=@ruang, " &
                        "hari=@hari, jam_mulai=@mulai, jam_selesai=@selesai, tahun_ajaran=@thn, semester=@sem WHERE id_jadwal=@id"
            End If

            ModuleKoneksi.Cmd = New MySqlCommand(query, ModuleKoneksi.Conn)
            ModuleKoneksi.Cmd.Parameters.AddWithValue("@kls", cmbKelas.Text)
            ModuleKoneksi.Cmd.Parameters.AddWithValue("@guru", cmbGuru.Text)
            ModuleKoneksi.Cmd.Parameters.AddWithValue("@mapel", cmbMapel.Text)
            ModuleKoneksi.Cmd.Parameters.AddWithValue("@ruang", cmbRuangan.Text)
            ModuleKoneksi.Cmd.Parameters.AddWithValue("@hari", cmbHari.Text)
            ModuleKoneksi.Cmd.Parameters.AddWithValue("@mulai", jamMulai)
            ModuleKoneksi.Cmd.Parameters.AddWithValue("@selesai", jamSelesai)
            ModuleKoneksi.Cmd.Parameters.AddWithValue("@thn", txtTahunAjaran.Text)
            ModuleKoneksi.Cmd.Parameters.AddWithValue("@sem", cmbSemester.Text)

            If selectedID <> "" Then ModuleKoneksi.Cmd.Parameters.AddWithValue("@id", selectedID)

            ModuleKoneksi.Cmd.ExecuteNonQuery()

            MessageBox.Show("Jadwal berhasil disimpan!", "Sukses")
            Bersih()

            ' Reset Filter agar sesuai
            If cmbFilterKelas.Items.Contains(cmbKelas.Text) Then
                cmbFilterKelas.Text = cmbKelas.Text
            End If

            TampilData()
        Catch ex As Exception
            MessageBox.Show("Error Simpan: " & ex.Message)
        End Try
    End Sub

    Private Sub dgvJadwal_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvJadwal.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvJadwal.Rows(e.RowIndex)
            selectedID = row.Cells("id_jadwal").Value.ToString()

            cmbHari.Text = row.Cells("hari").Value.ToString()
            cmbKelas.Text = row.Cells("id_kelas").Value.ToString()
            cmbGuru.Text = row.Cells("id_guru").Value.ToString()
            cmbMapel.Text = row.Cells("id_mapel").Value.ToString()
            cmbRuangan.Text = row.Cells("id_ruangan").Value.ToString()

            dtpMulai.Value = DateTime.Parse(row.Cells("jam_mulai").Value.ToString())
            dtpSelesai.Value = DateTime.Parse(row.Cells("jam_selesai").Value.ToString())

            btnSimpan.Text = "Update"
            btnHapus.Enabled = True
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If selectedID = "" Then Return
        If MessageBox.Show("Hapus jadwal ini?", "Konfirmasi", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Try
                ModuleKoneksi.BukaKoneksi()
                Dim cmd As New MySqlCommand("DELETE FROM tbl_jadwal WHERE id_jadwal = '" & selectedID & "'", ModuleKoneksi.Conn)
                cmd.ExecuteNonQuery()
                Bersih()
                TampilData()
            Catch ex As Exception
                MessageBox.Show("Error Hapus: " & ex.Message)
            End Try
        End If
    End Sub

    ' EVENT FILTER
    Private Sub Filter_Changed(sender As Object, e As EventArgs) Handles cmbFilterKelas.SelectedIndexChanged
        TampilData()
    End Sub

#End Region

#Region "Export PDF"

    Private Sub btnExportPDF_Click(sender As Object, e As EventArgs) Handles btnExportPDF.Click
        Dim sfd As New SaveFileDialog()
        sfd.Filter = "PDF Files|*.pdf"
        sfd.FileName = "JadwalPelajaran_" & DateTime.Now.ToString("yyyyMMdd")

        If sfd.ShowDialog() = DialogResult.OK Then
            Try
                Dim doc As New Document(PageSize.A4.Rotate(), 10, 10, 10, 10)
                Dim writer As PdfWriter = PdfWriter.GetInstance(doc, New FileStream(sfd.FileName, FileMode.Create))
                doc.Open()

                Dim strJudul As String = "JADWAL PELAJARAN"
                If cmbFilterKelas.SelectedIndex > 0 AndAlso cmbFilterKelas.Text <> "Semua" Then
                    strJudul &= " KELAS " & cmbFilterKelas.Text
                End If

                Dim p As New Paragraph(strJudul)
                p.Alignment = Element.ALIGN_CENTER
                doc.Add(p)
                doc.Add(New Paragraph(" "))

                Dim table As New PdfPTable(dgvJadwal.Columns.Count - 1)
                table.WidthPercentage = 100

                For Each col As DataGridViewColumn In dgvJadwal.Columns
                    If col.Visible Then
                        Dim cell As New PdfPCell(New Phrase(col.HeaderText))
                        cell.BackgroundColor = BaseColor.LIGHT_GRAY
                        table.AddCell(cell)
                    End If
                Next

                For Each row As DataGridViewRow In dgvJadwal.Rows
                    For Each cell As DataGridViewCell In row.Cells
                        If dgvJadwal.Columns(cell.ColumnIndex).Visible Then
                            table.AddCell(If(cell.Value IsNot Nothing, cell.Value.ToString(), ""))
                        End If
                    Next
                Next

                doc.Add(table)
                doc.Close()
                MessageBox.Show("Jadwal berhasil diexport ke PDF!")
            Catch ex As Exception
                MessageBox.Show("Gagal Export PDF: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub dgvJadwal_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvJadwal.CellContentClick
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

#End Region

End Class