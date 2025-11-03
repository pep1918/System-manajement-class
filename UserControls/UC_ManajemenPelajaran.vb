' Impor pustaka konektor MySQL
Imports MySql.Data.MySqlClient

Public Class UC_ManajemenPelajaran
    ' Variabel untuk menyimpan ID Jadwal yang dipilih
    Private selectedIDJadwal As Integer = 0

#Region "Prosedur Bantuan (Hak Akses, Loaders, Tampil, Kosongkan)"

    ' (READ-ONLY) Prosedur untuk mengatur hak akses
    Private Sub AturHakAkses()
        If ModuleKoneksi.CurrentUserLevel = "Siswa" Then
            ' === MODE BACA-SAJA (READ-ONLY) UNTUK SISWA ===
            cmbKelasJadwal.Enabled = False
            cmbMapelJadwal.Enabled = False
            cmbGuruJadwal.Enabled = False
            cmbHariJadwal.Enabled = False
            dtpJamMulai.Enabled = False
            dtpJamSelesai.Enabled = False

            ' <<< PERUBAHAN DI SINI >>>
            btnTambah.Enabled = False
            btnUbah.Enabled = False
            btnHapus.Enabled = False
            btnBatal.Enabled = False

            cmbFilterKelas.Enabled = True
            lblJudulUC.Text = "MELIHAT JADWAL PELAJARAN (Mode Siswa)"
        Else
            lblJudulUC.Text = "MANAJEMEN JADWAL PELAJARAN"
        End If
    End Sub

    ' (READ) Menampilkan data ke DataGridView
    Private Sub TampilData(Optional filterKelasID As Integer = -1)
        Try
            BukaKoneksi()
            Dim query As String = "SELECT ID_Jadwal, Tbl_Kelas.Nama_Kelas, Tbl_Mapel.Nama_Mapel, Tbl_Guru.Nama_Guru, " &
                                  "Hari, Jam_Mulai, Jam_Selesai, " &
                                  "Tbl_Jadwal.ID_Kelas, Tbl_Jadwal.Kode_Mapel, Tbl_Jadwal.NIP_Guru " &
                                  "FROM Tbl_Jadwal " &
                                  "LEFT JOIN Tbl_Kelas ON Tbl_Jadwal.ID_Kelas = Tbl_Kelas.ID_Kelas " &
                                  "LEFT JOIN Tbl_Mapel ON Tbl_Jadwal.Kode_Mapel = Tbl_Mapel.Kode_Mapel " &
                                  "LEFT JOIN Tbl_Guru ON Tbl_Jadwal.NIP_Guru = Tbl_Guru.NIP "

            If filterKelasID <> -1 Then
                query &= " WHERE Tbl_Jadwal.ID_Kelas = @IDKelas"
            End If
            query &= " ORDER BY Tbl_Kelas.Nama_Kelas, FIELD(Hari, 'Senin', 'Selasa', 'Rabu', 'Kamis', 'Jumat', 'Sabtu'), Jam_Mulai"

            Da = New MySqlDataAdapter(query, Conn)

            If filterKelasID <> -1 Then
                Da.SelectCommand.Parameters.AddWithValue("@IDKelas", filterKelasID)
            End If

            Ds = New DataSet()
            Da.Fill(Ds, "Jadwal")
            dgvJadwal.DataSource = Ds.Tables("Jadwal")

            dgvJadwal.Columns("ID_Kelas").Visible = False
            dgvJadwal.Columns("Kode_Mapel").Visible = False
            dgvJadwal.Columns("NIP_Guru").Visible = False
            dgvJadwal.Columns("ID_Jadwal").HeaderText = "ID"

        Catch ex As Exception
            MsgBox("Gagal menampilkan data jadwal: " & ex.Message, vbCritical)
        Finally
            TutupKoneksi()
        End Try
    End Sub

    ' (READ Helper 1) Load Kelas ke ComboBox Form dan ComboBox Filter
    Private Sub LoadKelasJadwal()
        Try
            BukaKoneksi()
            Dim query As String = "SELECT ID_Kelas, Nama_Kelas FROM Tbl_Kelas ORDER BY Nama_Kelas"
            Da = New MySqlDataAdapter(query, Conn)
            Dim dt As New DataTable()
            Da.Fill(dt)

            cmbKelasJadwal.DataSource = dt
            cmbKelasJadwal.DisplayMember = "Nama_Kelas"
            cmbKelasJadwal.ValueMember = "ID_Kelas"

            Dim dtFilter As DataTable = dt.Copy()
            Dim dr As DataRow = dtFilter.NewRow()
            dr("ID_Kelas") = -1
            dr("Nama_Kelas") = "-- Tampilkan Semua Kelas --"
            dtFilter.Rows.InsertAt(dr, 0)

            cmbFilterKelas.DataSource = dtFilter
            cmbFilterKelas.DisplayMember = "Nama_Kelas"
            cmbFilterKelas.ValueMember = "ID_Kelas"

        Catch ex As Exception
            MsgBox("Gagal memuat data kelas: " & ex.Message, vbCritical)
        Finally
            TutupKoneksi()
        End Try
    End Sub

    ' (READ Helper 2) Load Mapel ke ComboBox Form
    Private Sub LoadMapelJadwal()
        Try
            BukaKoneksi()
            Dim query As String = "SELECT Kode_Mapel, Nama_Mapel FROM Tbl_Mapel ORDER BY Nama_Mapel"
            Da = New MySqlDataAdapter(query, Conn)
            Dim dt As New DataTable()
            Da.Fill(dt)
            cmbMapelJadwal.DataSource = dt
            cmbMapelJadwal.DisplayMember = "Nama_Mapel"
            cmbMapelJadwal.ValueMember = "Kode_Mapel"
        Catch ex As Exception
            MsgBox("Gagal memuat data mapel: " & ex.Message, vbCritical)
        Finally
            TutupKoneksi()
        End Try
    End Sub

    ' (READ Helper 3) Load Guru ke ComboBox Form
    Private Sub LoadGuruJadwal()
        Try
            BukaKoneksi()
            Dim query As String = "SELECT NIP, Nama_Guru FROM Tbl_Guru ORDER BY Nama_Guru"
            Da = New MySqlDataAdapter(query, Conn)
            Dim dt As New DataTable()
            Da.Fill(dt)
            cmbGuruJadwal.DataSource = dt
            cmbGuruJadwal.DisplayMember = "Nama_Guru"
            cmbGuruJadwal.ValueMember = "NIP"
        Catch ex As Exception
            MsgBox("Gagal memuat data guru: " & ex.Message, vbCritical)
        Finally
            TutupKoneksi()
        End Try
    End Sub

    ' Membersihkan form input
    Private Sub KosongkanForm()
        cmbKelasJadwal.SelectedIndex = -1
        cmbMapelJadwal.SelectedIndex = -1
        cmbGuruJadwal.SelectedIndex = -1
        cmbHariJadwal.SelectedIndex = -1

        Dim hariIni As Date = Date.Now
        dtpJamMulai.Value = New Date(hariIni.Year, hariIni.Month, hariIni.Day, 7, 0, 0)
        dtpJamSelesai.Value = New Date(hariIni.Year, hariIni.Month, hariIni.Day, 8, 30, 0)

        selectedIDJadwal = 0

        ' <<< PERUBAHAN DI SINI >>>
        If ModuleKoneksi.CurrentUserLevel <> "Siswa" Then
            btnTambah.Enabled = True  ' Tombol Tambah AKTIF
            btnUbah.Enabled = False   ' Tombol Ubah nonaktif
            btnHapus.Enabled = False  ' Tombol Hapus nonaktif
        End If
    End Sub
#End Region

#Region "Event Handler CRUD"

    Private Sub UC_ManajemenPelajaran_Load(sender As Object, e As EventArgs) Handles Me.Load
        AturHakAkses()
        LoadKelasJadwal()
        LoadMapelJadwal()
        LoadGuruJadwal()
        TampilData()
        KosongkanForm()
    End Sub

    ' ==========================================================
    ' <<< LOGIKA BARU UNTUK "Button Tambah" >>>
    ' (CREATE) Tombol Tambah: Hanya untuk menyimpan data BARU (INSERT)
    ' ==========================================================
    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        ' (Logika ini diambil dari btnSimpan Anda yang lama)
        If cmbKelasJadwal.SelectedValue Is Nothing OrElse
           cmbMapelJadwal.SelectedValue Is Nothing OrElse
           cmbGuruJadwal.SelectedValue Is Nothing OrElse
           cmbHariJadwal.SelectedIndex = -1 Then
            MsgBox("Semua field (Kelas, Mapel, Guru, Hari) wajib diisi!", vbExclamation)
            Return
        End If

        Try
            BukaKoneksi()
            Dim query As String = "INSERT INTO Tbl_Jadwal (ID_Kelas, Kode_Mapel, NIP_Guru, Hari, Jam_Mulai, Jam_Selesai) " &
                                  "VALUES (@IDKelas, @KodeMapel, @NIP, @Hari, @JamMulai, @JamSelesai)"
            Cmd = New MySqlCommand(query, Conn)

            Cmd.Parameters.AddWithValue("@IDKelas", cmbKelasJadwal.SelectedValue)
            Cmd.Parameters.AddWithValue("@KodeMapel", cmbMapelJadwal.SelectedValue)
            Cmd.Parameters.AddWithValue("@NIP", cmbGuruJadwal.SelectedValue)
            Cmd.Parameters.AddWithValue("@Hari", cmbHariJadwal.Text)
            Cmd.Parameters.AddWithValue("@JamMulai", dtpJamMulai.Value.ToString("HH:mm:ss"))
            Cmd.Parameters.AddWithValue("@JamSelesai", dtpJamSelesai.Value.ToString("HH:mm:ss"))

            Cmd.ExecuteNonQuery()
            MsgBox("Jadwal baru berhasil disimpan.", vbInformation)

        Catch ex As Exception
            MsgBox("Error saat menyimpan: " & ex.Message, vbCritical)
        Finally
            TutupKoneksi()
        End Try

        TampilData(CInt(cmbFilterKelas.SelectedValue))
        KosongkanForm()
    End Sub

    ' ==========================================================
    ' <<< LOGIKA BARU UNTUK "Button Ubah" >>>
    ' (UPDATE) Tombol Ubah: Hanya untuk menyimpan data EDITAN (UPDATE)
    ' ==========================================================
    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        If selectedIDJadwal = 0 Then
            MsgBox("Pilih data jadwal dari tabel yang ingin diubah.", vbExclamation)
            Return
        End If

        Try
            BukaKoneksi()
            Dim query As String = "UPDATE Tbl_Jadwal SET ID_Kelas = @IDKelas, Kode_Mapel = @KodeMapel, " &
                                  "NIP_Guru = @NIP, Hari = @Hari, Jam_Mulai = @JamMulai, Jam_Selesai = @JamSelesai " &
                                  "WHERE ID_Jadwal = @ID"
            Cmd = New MySqlCommand(query, Conn)

            Cmd.Parameters.AddWithValue("@IDKelas", cmbKelasJadwal.SelectedValue)
            Cmd.Parameters.AddWithValue("@KodeMapel", cmbMapelJadwal.SelectedValue)
            Cmd.Parameters.AddWithValue("@NIP", cmbGuruJadwal.SelectedValue)
            Cmd.Parameters.AddWithValue("@Hari", cmbHariJadwal.Text)
            Cmd.Parameters.AddWithValue("@JamMulai", dtpJamMulai.Value.ToString("HH:mm:ss"))
            Cmd.Parameters.AddWithValue("@JamSelesai", dtpJamSelesai.Value.ToString("HH:mm:ss"))
            Cmd.Parameters.AddWithValue("@ID", selectedIDJadwal) ' Kunci utama

            Cmd.ExecuteNonQuery()
            MsgBox("Jadwal berhasil diupdate.", vbInformation)

        Catch ex As Exception
            MsgBox("Error saat mengupdate jadwal: " & ex.Message, vbCritical)
        Finally
            TutupKoneksi()
        End Try

        TampilData(CInt(cmbFilterKelas.SelectedValue))
        KosongkanForm()
    End Sub

    ' (DELETE) Tombol Hapus (Logika sudah benar)
    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If selectedIDJadwal = 0 Then
            MsgBox("Pilih data jadwal dari tabel yang ingin dihapus.", vbExclamation)
            Return
        End If

        If MsgBox("Apakah Anda yakin ingin menghapus jadwal ini?", vbQuestion + vbYesNo, "Konfirmasi Hapus") = vbNo Then
            Return
        End If

        Try
            BukaKoneksi()
            Dim query As String = "DELETE FROM Tbl_Jadwal WHERE ID_Jadwal = @ID"
            Cmd = New MySqlCommand(query, Conn)
            Cmd.Parameters.AddWithValue("@ID", selectedIDJadwal)

            Cmd.ExecuteNonQuery()
            MsgBox("Data jadwal berhasil dihapus.", vbInformation)

        Catch ex As Exception
            MsgBox("Error saat menghapus: " & ex.Message, vbCritical)
        Finally
            TutupKoneksi()
        End Try

        TampilData(CInt(cmbFilterKelas.SelectedValue))
        KosongkanForm()
    End Sub

    ' ==========================================================
    ' <<< LOGIKA BARU UNTUK "Button Batal" >>>
    ' (BATAL) Tombol untuk membersihkan form
    ' ==========================================================
    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        KosongkanForm()
    End Sub

    ' --- Tombol yang tidak terpakai lagi ---
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        ' KOSONGKAN ATAU HAPUS
    End Sub

#End Region

#Region "Event GridView dan Filter"

    ' Ini adalah bagian dari logika "Button Ubah"
    Private Sub dgvJadwal_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvJadwal.CellClick
        If e.RowIndex >= 0 Then
            Dim baris As DataGridViewRow = dgvJadwal.Rows(e.RowIndex)

            ' Ambil ID untuk Hapus/Ubah
            selectedIDJadwal = CInt(baris.Cells("ID_Jadwal").Value)

            ' Isi form (untuk referensi)
            cmbKelasJadwal.SelectedValue = baris.Cells("ID_Kelas").Value
            cmbMapelJadwal.SelectedValue = baris.Cells("Kode_Mapel").Value
            cmbGuruJadwal.SelectedValue = baris.Cells("NIP_Guru").Value
            cmbHariJadwal.Text = baris.Cells("Hari").Value.ToString()
            dtpJamMulai.Value = CDate(baris.Cells("Jam_Mulai").Value)
            dtpJamSelesai.Value = CDate(baris.Cells("Jam_Selesai").Value)

            ' <<< PERUBAHAN DI SINI >>>
            If ModuleKoneksi.CurrentUserLevel <> "Siswa" Then
                btnTambah.Enabled = False ' Tombol Tambah nonaktif
                btnUbah.Enabled = True    ' Tombol Ubah AKTIF
                btnHapus.Enabled = True   ' Tombol Hapus AKTIF
            End If
        End If
    End Sub

    ' (READ / Filter) (Logika sudah benar)
    Private Sub cmbFilterKelas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFilterKelas.SelectedIndexChanged
        If cmbFilterKelas.SelectedItem IsNot Nothing Then
            Try
                Dim drv As DataRowView = CType(cmbFilterKelas.SelectedItem, DataRowView)
                Dim filterID As Integer = CInt(drv.Row("ID_Kelas"))
                TampilData(filterID)
            Catch ex As Exception
                MsgBox("Error saat memfilter data: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub dgvJadwal_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvJadwal.CellContentClick
        ' Biarkan kosong
    End Sub

#End Region

End Class