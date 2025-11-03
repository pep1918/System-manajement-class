' Impor pustaka konektor MySQL
Imports MySql.Data.MySqlClient

Public Class UC_DataKelas
    ' Variabel untuk menyimpan ID Kelas yang dipilih saat mengedit/menghapus
    Private selectedIDKelas As Integer = 0

#Region "Prosedur Bantuan (Hak Akses, Load, Tampil, Kosongkan)"

    ' (READ-ONLY) Prosedur untuk mengatur hak akses
    Private Sub AturHakAkses()
        If ModuleKoneksi.CurrentUserLevel = "Siswa" Then
            ' === MODE BACA-SAJA (READ-ONLY) UNTUK SISWA ===
            txtNamaKelas.Enabled = False
            txtTahunAjaran.Enabled = False
            cmbWaliKelas.Enabled = False

            ' <<< PERUBAHAN DI SINI >>>
            ' Sesuaikan dengan nama tombol baru Anda
            btnTambah.Enabled = False
            btnUbah.Enabled = False
            btnHapus.Enabled = False
            btnBatal.Enabled = False

            lblJudulUC.Text = "MELIHAT DATA KELAS (Mode Siswa)"
        Else
            lblJudulUC.Text = "MANAJEMEN DATA KELAS"
        End If
    End Sub

    ' (READ) Menampilkan data ke DataGridView
    Private Sub TampilData()
        Try
            BukaKoneksi()
            ' JOIN untuk menampilkan Nama Wali Kelas
            Dim query As String = "SELECT ID_Kelas, Nama_Kelas, Tahun_Ajaran, Tbl_Kelas.NIP_WaliKelas, Tbl_Guru.Nama_Guru " &
                                  "FROM Tbl_Kelas " &
                                  "LEFT JOIN Tbl_Guru ON Tbl_Kelas.NIP_WaliKelas = Tbl_Guru.NIP"

            Da = New MySqlDataAdapter(query, Conn)
            Ds = New DataSet()
            Da.Fill(Ds, "Kelas")
            dgvKelas.DataSource = Ds.Tables("Kelas")

            ' Atur Tampilan Header
            dgvKelas.Columns("ID_Kelas").HeaderText = "ID"
            dgvKelas.Columns("Nama_Kelas").HeaderText = "Nama Kelas"
            dgvKelas.Columns("Tahun_Ajaran").HeaderText = "Tahun Ajaran"
            dgvKelas.Columns("Nama_Guru").HeaderText = "Wali Kelas"
            dgvKelas.Columns("NIP_WaliKelas").Visible = False ' Sembunyikan Foreign Key

        Catch ex As Exception
            MsgBox("Gagal menampilkan data kelas: " & ex.Message, vbCritical)
        Finally
            TutupKoneksi()
        End Try
    End Sub

    ' (READ Helper) Memuat data guru ke ComboBox Wali Kelas
    Private Sub LoadWaliKelas()
        Try
            BukaKoneksi()
            Dim query As String = "SELECT NIP, Nama_Guru FROM Tbl_Guru ORDER BY Nama_Guru"
            Da = New MySqlDataAdapter(query, Conn)
            Dim dt As New DataTable()
            Da.Fill(dt)

            ' Tambahkan satu baris kosong di atas untuk pilihan "Tidak Ada"
            Dim dr As DataRow = dt.NewRow()
            dr("NIP") = DBNull.Value ' Ini akan disimpan sebagai NULL di database
            dr("Nama_Guru") = "- Tidak Ada Wali Kelas -"
            dt.Rows.InsertAt(dr, 0)

            cmbWaliKelas.DataSource = dt
            cmbWaliKelas.DisplayMember = "Nama_Guru"
            cmbWaliKelas.ValueMember = "NIP"

        Catch ex As Exception
            MsgBox("Gagal memuat data wali kelas: " & ex.Message, vbCritical)
        Finally
            TutupKoneksi()
        End Try
    End Sub

    ' Membersihkan form input (Ini adalah fungsi untuk "Button Batal")
    Private Sub KosongkanForm()
        txtNamaKelas.Clear()
        txtTahunAjaran.Clear()
        cmbWaliKelas.SelectedIndex = 0 ' Pilih "- Tidak Ada Wali Kelas -"

        selectedIDKelas = 0

        ' <<< PERUBAHAN DI SINI >>>
        ' Atur status tombol untuk mode "Tambah Data Baru"
        If ModuleKoneksi.CurrentUserLevel <> "Siswa" Then
            btnTambah.Enabled = True  ' Tombol Tambah AKTIF
            btnUbah.Enabled = False   ' Tombol Ubah nonaktif
            btnHapus.Enabled = False  ' Tombol Hapus nonaktif
        End If

        txtNamaKelas.Focus()
    End Sub

#End Region

#Region "Event Handler CRUD"

    Private Sub UC_DataKelas_Load(sender As Object, e As EventArgs) Handles Me.Load
        AturHakAkses()
        LoadWaliKelas() ' Load ComboBox dulu
        TampilData()
        KosongkanForm()
    End Sub

    ' ==========================================================
    ' <<< LOGIKA BARU UNTUK "Button Tambah" >>>
    ' (CREATE) Tombol Tambah: Hanya untuk menyimpan data BARU (INSERT)
    ' ==========================================================
    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        ' (Logika ini diambil dari btnSimpan Anda yang lama)
        If String.IsNullOrWhiteSpace(txtNamaKelas.Text) Then
            MsgBox("Nama Kelas wajib diisi!", vbExclamation)
            Return
        End If

        Try
            BukaKoneksi()
            Dim query As String = "INSERT INTO Tbl_Kelas (Nama_Kelas, Tahun_Ajaran, NIP_WaliKelas) " &
                                  "VALUES (@Nama, @Tahun, @NIP)"
            Cmd = New MySqlCommand(query, Conn)

            Cmd.Parameters.AddWithValue("@Nama", txtNamaKelas.Text)
            Cmd.Parameters.AddWithValue("@Tahun", txtTahunAjaran.Text)

            ' Cek jika memilih "- Tidak Ada Wali Kelas -"
            If cmbWaliKelas.SelectedValue Is DBNull.Value OrElse cmbWaliKelas.SelectedIndex = 0 Then
                Cmd.Parameters.AddWithValue("@NIP", DBNull.Value)
            Else
                Cmd.Parameters.AddWithValue("@NIP", cmbWaliKelas.SelectedValue)
            End If

            Cmd.ExecuteNonQuery()
            MsgBox("Data kelas baru berhasil disimpan.", vbInformation)

        Catch ex As Exception
            MsgBox("Error saat menyimpan: " & ex.Message, vbCritical)
        Finally
            TutupKoneksi()
        End Try

        TampilData()
        KosongkanForm()
    End Sub

    ' ==========================================================
    ' <<< LOGIKA BARU UNTUK "Button Ubah" >>>
    ' (UPDATE) Tombol Ubah: Hanya untuk menyimpan data EDITAN (UPDATE)
    ' ==========================================================
    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        ' (Logika ini diambil dari btnEdit Anda yang lama)
        If selectedIDKelas = 0 Then
            MsgBox("Pilih data kelas dari tabel terlebih dahulu.", vbExclamation)
            Return
        End If

        Try
            BukaKoneksi()
            Dim query As String = "UPDATE Tbl_Kelas SET Nama_Kelas = @Nama, Tahun_Ajaran = @Tahun, NIP_WaliKelas = @NIP " &
                                  "WHERE ID_Kelas = @ID"
            Cmd = New MySqlCommand(query, Conn)

            Cmd.Parameters.AddWithValue("@Nama", txtNamaKelas.Text)
            Cmd.Parameters.AddWithValue("@Tahun", txtTahunAjaran.Text)

            If cmbWaliKelas.SelectedValue Is DBNull.Value OrElse cmbWaliKelas.SelectedIndex = 0 Then
                Cmd.Parameters.AddWithValue("@NIP", DBNull.Value)
            Else
                Cmd.Parameters.AddWithValue("@NIP", cmbWaliKelas.SelectedValue)
            End If

            Cmd.Parameters.AddWithValue("@ID", selectedIDKelas)

            Cmd.ExecuteNonQuery()
            MsgBox("Data kelas berhasil diupdate.", vbInformation)

        Catch ex As Exception
            MsgBox("Error saat mengupdate: " & ex.Message, vbCritical)
        Finally
            TutupKoneksi()
        End Try

        TampilData()
        KosongkanForm()
    End Sub

    ' (DELETE) Tombol Hapus (Logika sudah benar)
    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If selectedIDKelas = 0 Then
            MsgBox("Pilih data kelas dari tabel terlebih dahulu.", vbExclamation)
            Return
        End If

        If MsgBox("Apakah Anda yakin ingin menghapus kelas " & txtNamaKelas.Text & "?", vbQuestion + vbYesNo, "Konfirmasi Hapus") = vbNo Then
            Return
        End If

        Try
            BukaKoneksi()
            Dim query As String = "DELETE FROM Tbl_Kelas WHERE ID_Kelas = @ID"
            Cmd = New MySqlCommand(query, Conn)
            Cmd.Parameters.AddWithValue("@ID", selectedIDKelas)

            Cmd.ExecuteNonQuery()
            MsgBox("Data kelas berhasil dihapus.", vbInformation)

        Catch ex As MySqlException
            If ex.Number = 1451 Then ' Error Foreign Key
                MsgBox("Gagal menghapus! Kelas ini masih memiliki Siswa atau Jadwal yang terdaftar.", vbCritical)
            Else
                MsgBox("Error MySQL saat menghapus: " & ex.Message, vbCritical)
            End If
        Catch ex As Exception
            MsgBox("Error umum: " & ex.Message, vbCritical)
        Finally
            TutupKoneksi()
        End Try

        TampilData()
        KosongkanForm()
    End Sub

    ' ==========================================================
    ' <<< LOGIKA BARU UNTUK "Button Batal" >>>
    ' (BATAL) Tombol untuk membersihkan form
    ' ==========================================================
    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        KosongkanForm()
    End Sub




#End Region

#Region "Event GridView dan Pencarian"

    ' Ini adalah bagian dari logika "Button Ubah"
    Private Sub dgvKelas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvKelas.CellClick
        If e.RowIndex >= 0 Then
            Dim baris As DataGridViewRow = dgvKelas.Rows(e.RowIndex)

            ' Ambil data dari Grid dan masukkan ke Form
            selectedIDKelas = CInt(baris.Cells("ID_Kelas").Value)
            txtNamaKelas.Text = baris.Cells("Nama_Kelas").Value.ToString()
            txtTahunAjaran.Text = baris.Cells("Tahun_Ajaran").Value.ToString()

            ' Cek jika NIP Wali Kelas-nya NULL
            If baris.Cells("NIP_WaliKelas").Value Is DBNull.Value Then
                cmbWaliKelas.SelectedIndex = 0 ' - Tidak Ada Wali Kelas -
            Else
                cmbWaliKelas.SelectedValue = baris.Cells("NIP_WaliKelas").Value.ToString()
            End If

            ' <<< PERUBAHAN DI SINI >>>
            ' Atur tombol untuk mode "Ubah"
            If ModuleKoneksi.CurrentUserLevel <> "Siswa" Then
                btnTambah.Enabled = False ' Tombol Tambah nonaktif
                btnUbah.Enabled = True    ' Tombol Ubah AKTIF
                btnHapus.Enabled = True   ' Tombol Hapus AKTIF
            End If
        End If
    End Sub

    ' (READ / Search) (Logika sudah benar)
    Private Sub txtCariKelas_TextChanged(sender As Object, e As EventArgs) Handles txtCariKelas.TextChanged
        Try
            BukaKoneksi()
            Dim query As String = "SELECT ID_Kelas, Nama_Kelas, Tahun_Ajaran, Tbl_Kelas.NIP_WaliKelas, Tbl_Guru.Nama_Guru " &
                                  "FROM Tbl_Kelas " &
                                  "LEFT JOIN Tbl_Guru ON Tbl_Kelas.NIP_WaliKelas = Tbl_Guru.NIP " &
                                  "WHERE Nama_Kelas LIKE @Search OR Tahun_Ajaran LIKE @Search OR Tbl_Guru.Nama_Guru LIKE @Search"

            Da = New MySqlDataAdapter(query, Conn)
            Da.SelectCommand.Parameters.AddWithValue("@Search", "%" & txtCariKelas.Text & "%")

            Ds = New DataSet()
            Da.Fill(Ds, "KelasCari")
            dgvKelas.DataSource = Ds.Tables("KelasCari")

        Catch ex As Exception
            ' Abaikan error saat mengetik
        Finally
            TutupKoneksi()
        End Try
    End Sub

    Private Sub dgvKelas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvKelas.CellContentClick
        ' Biarkan kosong
    End Sub

    Private Sub txtNamaKelas_TextChanged(sender As Object, e As EventArgs) Handles txtNamaKelas.TextChanged
        ' Biarkan kosong
    End Sub

#End Region

End Class