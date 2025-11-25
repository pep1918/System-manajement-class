Imports MySql.Data.MySqlClient
Imports System.IO
Imports iTextSharp.text
Imports iTextSharp.text.pdf

Public Class UC_DataKelas
    Inherits UserControl
    ' Variabel Global
    Private selectedIDKelas As String = ""
    Private selectedNamaKelas As String = ""

    ' ==============================================================
    ' 1. LOAD & INIT
    ' ==============================================================
    Private Sub UC_DataKelas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        IsiComboFilter()      ' Isi Filter (Kiri Atas)
        IsiComboKelasTujuan() ' Isi Tujuan Pindah (Kanan Bawah)
        IsiComboGuru()        ' Isi Wali Kelas
        TampilKelas()         ' Tampilkan Tabel Utama
        Bersih()
    End Sub

    Sub Bersih()
        ' Reset Form Kiri
        txtNamaKelas.Clear()
        cmbTingkat.SelectedIndex = -1
        cmbJurusan.SelectedIndex = -1
        cmbWaliKelas.SelectedIndex = -1

        ' Reset Variabel
        selectedIDKelas = ""
        selectedNamaKelas = ""

        ' Reset Form Kanan
        lblNamaKelasTerpilih.Text = "Pilih Kelas di Tabel Kiri"
        dgvKelas.DataSource = Nothing
        cmbKelasTujuan.SelectedIndex = -1

        ' Atur Tombol Kiri
        btnTambah.Enabled = True
        btnUbah.Enabled = False
        btnHapus.Enabled = False

        ' Matikan Tombol Kanan
        btnPindahSiswa.Enabled = False
        btnCetakAbsen.Enabled = False
        btnLihatJadwal.Enabled = False
    End Sub

    ' ==============================================================
    ' 2. PENGISIAN COMBOBOX (HELPER) - GUNAKAN GLOBAL READER (Rd)
    ' ==============================================================

    ' A. Filter Kelas (Ada opsi "Semua")
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
            ModuleKoneksi.Rd.Close() ' WAJIB CLOSE

            If cmbFilterKelas.Items.Count > 0 Then cmbFilterKelas.SelectedIndex = 0
        Catch ex As Exception
            ' Pastikan Rd tertutup jika error
            If ModuleKoneksi.Rd IsNot Nothing AndAlso Not ModuleKoneksi.Rd.IsClosed Then ModuleKoneksi.Rd.Close()
        End Try
    End Sub

    ' B. Kelas Tujuan Pindah (Format: Nama | ID)
    Sub IsiComboKelasTujuan()
        Try
            ModuleKoneksi.BukaKoneksi()
            ModuleKoneksi.Cmd = New MySqlCommand("SELECT ID_Kelas, Nama_Kelas FROM tbl_kelas ORDER BY Nama_Kelas", ModuleKoneksi.Conn)
            ModuleKoneksi.Rd = ModuleKoneksi.Cmd.ExecuteReader()

            cmbKelasTujuan.Items.Clear()
            While ModuleKoneksi.Rd.Read()
                ' Penting: Kita simpan ID di belakang agar bisa diambil saat update
                cmbKelasTujuan.Items.Add(ModuleKoneksi.Rd("Nama_Kelas").ToString() & " | " & ModuleKoneksi.Rd("ID_Kelas").ToString())
            End While
            ModuleKoneksi.Rd.Close()
        Catch ex As Exception
            If ModuleKoneksi.Rd IsNot Nothing AndAlso Not ModuleKoneksi.Rd.IsClosed Then ModuleKoneksi.Rd.Close()
        End Try
    End Sub

    ' C. Wali Kelas
    Sub IsiComboGuru()
        Try
            ModuleKoneksi.BukaKoneksi()
            ModuleKoneksi.Cmd = New MySqlCommand("SELECT NIP, Nama_Guru FROM tbl_guru ORDER BY Nama_Guru", ModuleKoneksi.Conn)
            ModuleKoneksi.Rd = ModuleKoneksi.Cmd.ExecuteReader()

            cmbWaliKelas.Items.Clear()
            While ModuleKoneksi.Rd.Read()
                cmbWaliKelas.Items.Add(ModuleKoneksi.Rd("Nama_Guru").ToString() & " - " & ModuleKoneksi.Rd("NIP").ToString())
            End While
            ModuleKoneksi.Rd.Close()
        Catch ex As Exception
            If ModuleKoneksi.Rd IsNot Nothing AndAlso Not ModuleKoneksi.Rd.IsClosed Then ModuleKoneksi.Rd.Close()
        End Try
    End Sub

    ' ==============================================================
    ' 3. BAGIAN KIRI: CRUD & FILTER TABEL KELAS - GUNAKAN GLOBAL ADAPTER (Da)
    ' ==============================================================

    ' Menampilkan Data Kelas (Merespon Filter)
    Sub TampilKelas()
        Try
            ModuleKoneksi.BukaKoneksi()

            Dim query As String = "SELECT k.ID_Kelas, k.Nama_Kelas, k.Tingkat, k.Jurusan, g.Nama_Guru AS Wali_Kelas, k.NIP_WaliKelas " &
                                  "FROM tbl_kelas k " &
                                  "LEFT JOIN tbl_guru g ON k.NIP_WaliKelas = g.NIP "

            ' LOGIKA FILTER
            If cmbFilterKelas.SelectedIndex > 0 And cmbFilterKelas.Text <> "Semua" Then
                query &= " WHERE k.Nama_Kelas = '" & cmbFilterKelas.Text & "'"
            End If

            query &= " ORDER BY k.Tingkat, k.Nama_Kelas"

            ModuleKoneksi.Cmd = New MySqlCommand(query, ModuleKoneksi.Conn)
            ModuleKoneksi.Da = New MySqlDataAdapter(ModuleKoneksi.Cmd)

            Dim dt As New DataTable()
            ModuleKoneksi.Da.Fill(dt)
            dgvKelas.DataSource = dt

            ' Sembunyikan Kolom ID
            dgvKelas.Columns("ID_Kelas").Visible = False
            dgvKelas.Columns("NIP_WaliKelas").Visible = False
        Catch ex As Exception
            MessageBox.Show("Gagal Tampil Kelas: " & ex.Message)
        End Try
    End Sub

    ' Event Filter Berubah
    Private Sub cmbFilterKelas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFilterKelas.SelectedIndexChanged
        TampilKelas()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs)
        cmbFilterKelas.SelectedIndex = 0
        TampilKelas()
    End Sub

    ' Event Klik Tabel Kelas (Memicu Tampilan Kanan)
    Private Sub dgvKelas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvKelas.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvKelas.Rows(e.RowIndex)

            ' Ambil Data Utama
            selectedIDKelas = row.Cells("ID_Kelas").Value.ToString()
            selectedNamaKelas = row.Cells("Nama_Kelas").Value.ToString()

            ' Isi Form Kiri
            txtNamaKelas.Text = selectedNamaKelas
            cmbTingkat.Text = row.Cells("Tingkat").Value.ToString()
            cmbJurusan.Text = row.Cells("Jurusan").Value.ToString()

            ' Isi Wali Kelas (Cari string yang cocok)
            Dim nipWali As String = row.Cells("NIP_WaliKelas").Value.ToString()
            For Each item As String In cmbWaliKelas.Items
                If item.Contains(nipWali) Then
                    cmbWaliKelas.SelectedItem = item
                    Exit For
                End If
            Next

            ' Aktifkan Tombol Edit Kiri
            btnTambah.Enabled = False
            btnUbah.Enabled = True
            btnHapus.Enabled = True

            ' ===== TRIGGER BAGIAN KANAN =====
            lblNamaKelasTerpilih.Text = "Daftar Siswa: " & selectedNamaKelas
            TampilSiswaPerKelas(selectedIDKelas)

            ' Aktifkan Tombol Kanan
            btnPindahSiswa.Enabled = True
            btnCetakAbsen.Enabled = True
            btnLihatJadwal.Enabled = True
        End If
    End Sub

    ' Helper CRUD - GUNAKAN GLOBAL COMMAND (Cmd)
    Sub JalankanQueryKelas(query As String, pesan As String)
        Try
            ModuleKoneksi.BukaKoneksi()
            ModuleKoneksi.Cmd = New MySqlCommand(query, ModuleKoneksi.Conn)

            Dim nipBersih As String = ""
            If cmbWaliKelas.Text.Contains("-") Then
                nipBersih = cmbWaliKelas.Text.Split("-"c)(1).Trim()
            End If

            ModuleKoneksi.Cmd.Parameters.AddWithValue("@nm", txtNamaKelas.Text)
            ModuleKoneksi.Cmd.Parameters.AddWithValue("@tkt", cmbTingkat.Text)
            ModuleKoneksi.Cmd.Parameters.AddWithValue("@jur", cmbJurusan.Text)
            ModuleKoneksi.Cmd.Parameters.AddWithValue("@wali", nipBersih)
            ModuleKoneksi.Cmd.Parameters.AddWithValue("@id", selectedIDKelas)

            ModuleKoneksi.Cmd.ExecuteNonQuery()
            MessageBox.Show("Data Kelas " & pesan)

            Bersih()
            TampilKelas()
            IsiComboKelasTujuan() ' Refresh target pindah jika ada kelas baru
            IsiComboFilter()      ' Refresh filter jika ada kelas baru
        Catch ex As Exception
            MessageBox.Show("Gagal: " & ex.Message)
        End Try
    End Sub

    ' Tombol CRUD
    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        If txtNamaKelas.Text = "" Then Return
        Dim q As String = "INSERT INTO tbl_kelas (Nama_Kelas, Tingkat, Jurusan, NIP_WaliKelas) VALUES (@nm, @tkt, @jur, @wali)"
        JalankanQueryKelas(q, "Ditambahkan")
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        If selectedIDKelas = "" Then Return
        Dim q As String = "UPDATE tbl_kelas SET Nama_Kelas=@nm, Tingkat=@tkt, Jurusan=@jur, NIP_WaliKelas=@wali WHERE ID_Kelas=@id"
        JalankanQueryKelas(q, "Diubah")
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If selectedIDKelas = "" Then Return
        If dgvKelas.Rows.Count > 0 Then
            MessageBox.Show("Pindahkan siswa terlebih dahulu!", "Gagal Hapus", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If MessageBox.Show("Hapus Kelas ini?", "Konfirmasi", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Dim q As String = "DELETE FROM tbl_kelas WHERE ID_Kelas=@id"
            JalankanQueryKelas(q, "Dihapus")
        End If
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Bersih()
    End Sub

    ' ==============================================================
    ' 4. BAGIAN KANAN: MANAJEMEN SISWA (PINDAH KELAS)
    ' ==============================================================

    Sub TampilSiswaPerKelas(idKelas As String)
        Try
            ModuleKoneksi.BukaKoneksi()
            Dim q As String = "SELECT NIS, Nama_Siswa, Jenis_Kelamin FROM tbl_siswa WHERE ID_Kelas = @id ORDER BY Nama_Siswa"

            ModuleKoneksi.Cmd = New MySqlCommand(q, ModuleKoneksi.Conn)
            ModuleKoneksi.Cmd.Parameters.AddWithValue("@id", idKelas)
            ModuleKoneksi.Da = New MySqlDataAdapter(ModuleKoneksi.Cmd)

            Dim dt As New DataTable()
            ModuleKoneksi.Da.Fill(dt)
            dgvKelas.DataSource = dt
        Catch ex As Exception
        End Try
    End Sub

    ' >>> FITUR PINDAH SISWA <<<
    Private Sub btnPindahSiswa_Click(sender As Object, e As EventArgs) Handles btnPindahSiswa.Click
        If dgvKelas.SelectedRows.Count = 0 Then
            MessageBox.Show("Pilih siswa di tabel kanan dulu!", "Peringatan")
            Return
        End If
        If cmbKelasTujuan.SelectedIndex = -1 Then
            MessageBox.Show("Pilih Kelas Tujuan di ComboBox!", "Peringatan")
            Return
        End If

        Dim splitData() As String = cmbKelasTujuan.Text.Split("|"c)
        Dim namaKelasTujuan As String = splitData(0).Trim()
        Dim idKelasTujuan As String = splitData(1).Trim()

        Dim nisSiswa As String = dgvKelas.SelectedRows(0).Cells("NIS").Value.ToString()
        Dim namaSiswa As String = dgvKelas.SelectedRows(0).Cells("Nama_Siswa").Value.ToString()

        If idKelasTujuan = selectedIDKelas Then
            MessageBox.Show("Siswa sudah berada di kelas ini.", "Info")
            Return
        End If

        If MessageBox.Show($"Pindahkan {namaSiswa} ke {namaKelasTujuan}?", "Konfirmasi Pindah", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Try
                ModuleKoneksi.BukaKoneksi()
                Dim cmd As New MySqlCommand("UPDATE tbl_siswa SET ID_Kelas = @idBaru WHERE NIS = @nis", ModuleKoneksi.Conn)
                cmd.Parameters.AddWithValue("@idBaru", idKelasTujuan)
                cmd.Parameters.AddWithValue("@nis", nisSiswa)
                cmd.ExecuteNonQuery()

                MessageBox.Show("Siswa Berhasil Dipindahkan.")
                TampilSiswaPerKelas(selectedIDKelas)
            Catch ex As Exception
                MessageBox.Show("Gagal Pindah: " & ex.Message)
            End Try
        End If
    End Sub

    ' ==============================================================
    ' 5. FITUR TAMBAHAN (JADWAL & PDF)
    ' ==============================================================

    Private Sub btnLihatJadwal_Click(sender As Object, e As EventArgs)
        If selectedIDKelas = "" Then Return
        Try
            ModuleKoneksi.BukaKoneksi()
            Dim q As String = "SELECT Hari, Jam_Mulai, Kode_Mapel, NIP_Guru FROM tbl_jadwal WHERE ID_Kelas = @id ORDER BY FIELD(Hari, 'Senin','Selasa','Rabu','Kamis','Jumat'), Jam_Mulai"

            ModuleKoneksi.Cmd = New MySqlCommand(q, ModuleKoneksi.Conn)
            ModuleKoneksi.Cmd.Parameters.AddWithValue("@id", selectedIDKelas)
            ModuleKoneksi.Da = New MySqlDataAdapter(ModuleKoneksi.Cmd)

            Dim dt As New DataTable()
            ModuleKoneksi.Da.Fill(dt)

            If dt.Rows.Count > 0 Then
                Dim info As String = $"JADWAL KELAS {selectedNamaKelas}:{vbCrLf}===================={vbCrLf}"
                For Each r As DataRow In dt.Rows
                    info &= $"{r("Hari")} {r("Jam_Mulai")}: {r("Kode_Mapel")} ({r("NIP_Guru")}){vbCrLf}"
                Next
                MessageBox.Show(info, "Jadwal Pelajaran", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Belum ada jadwal untuk kelas ini.", "Info")
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnCetakAbsen_Click(sender As Object, e As EventArgs)
        If dgvKelas.Rows.Count = 0 Then Return

        Dim sfd As New SaveFileDialog()
        sfd.Filter = "PDF Files|*.pdf"
        sfd.FileName = "Absensi_" & selectedNamaKelas.Replace(" ", "_")

        If sfd.ShowDialog() = DialogResult.OK Then
            Try
                Dim doc As New Document(PageSize.A4, 20, 20, 20, 20)
                Dim writer As PdfWriter = PdfWriter.GetInstance(doc, New FileStream(sfd.FileName, FileMode.Create))
                doc.Open()

                Dim p As New Paragraph($"DAFTAR ABSENSI KELAS {selectedNamaKelas}")
                p.Alignment = Element.ALIGN_CENTER
                doc.Add(p)

                Dim namaWali As String = ""
                If cmbWaliKelas.Text.Contains("-") Then
                    namaWali = cmbWaliKelas.Text.Split("-"c)(0).Trim()
                End If
                doc.Add(New Paragraph($"Wali Kelas: {namaWali}"))
                doc.Add(New Paragraph(" "))

                Dim table As New PdfPTable(4)
                table.SetWidths(New Single() {1, 3, 6, 4})
                table.WidthPercentage = 100

                table.AddCell("No")
                table.AddCell("NIS")
                table.AddCell("Nama Siswa")
                table.AddCell("Paraf")

                Dim no As Integer = 1
                For Each row As DataGridViewRow In dgvKelas.Rows
                    table.AddCell(no.ToString())
                    table.AddCell(row.Cells("NIS").Value.ToString())
                    table.AddCell(row.Cells("Nama_Siswa").Value.ToString())
                    table.AddCell(" ")
                    no += 1
                Next

                doc.Add(table)
                doc.Close()
                MessageBox.Show("Absensi PDF Berhasil Dibuat!")
            Catch ex As Exception
                MessageBox.Show("Gagal PDF: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)
    End Sub

    Private Sub dgvKelas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvKelas.CellContentClick

    End Sub
End Class