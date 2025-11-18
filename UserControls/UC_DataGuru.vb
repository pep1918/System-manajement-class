' Impor pustaka konektor MySQL
Imports MySql.Data.MySqlClient

Public Class UC_DataGuru
    ' Variabel untuk menyimpan NIP yang dipilih saat mengedit/menghapus
    Private selectedNIP As String = ""

#Region "Prosedur Bantuan (Hak Akses, Tampil, Kosongkan)"

    ' (READ-ONLY) Prosedur baru untuk mengatur hak akses
    Private Sub AturHakAkses()
        If ModuleKoneksi.CurrentUserLevel = "Siswa" Then
            txtNIP.Enabled = False
            txtNamaGuru.Enabled = False
            cmbJenisKelamin.Enabled = False
            txtAlamat.Enabled = False
            txtTelepon.Enabled = False
            txtEmail.Enabled = False

            ' <<< PERUBAHAN DI SINI >>>
            ' Sesuaikan dengan tombol-tombol baru Anda
            btnTambah.Enabled = False
            btnUbah.Enabled = False
            btnHapus.Enabled = False
            btnBatal.Enabled = False

            lbLJudulUC.Text = "MELIHAT DATA GURU (Mode Siswa)"
        Else
            lbLJudulUC.Text = "MANAJEMEN DATA GURU"
        End If
    End Sub

    ' (READ) Menampilkan data ke DataGridView
    Private Sub TampilData()
        Try
            BukaKoneksi()
            Dim query As String = "SELECT NIP, Nama_Guru, Jenis_Kelamin, Alamat, Telepon, Email FROM Tbl_Guru"

            Da = New MySqlDataAdapter(query, Conn)
            Ds = New DataSet()
            Da.Fill(Ds, "Guru")
            dgvGuru.DataSource = Ds.Tables("Guru")

        Catch ex As Exception
            MsgBox("Gagal menampilkan data guru: " & ex.Message, vbCritical)
        Finally
            TutupKoneksi()
        End Try
    End Sub

    ' Membersihkan form input dan mengatur ulang tombol
    ' Ini adalah fungsi untuk "Button Batal"
    Private Sub KosongkanForm()
        txtNIP.Clear()
        txtNamaGuru.Clear()
        cmbJenisKelamin.SelectedIndex = -1
        txtAlamat.Clear()
        txtTelepon.Clear()
        txtEmail.Clear()

        selectedNIP = ""

        ' <<< PERUBAHAN DI SINI >>>
        ' Atur status tombol untuk mode "Tambah Data Baru"
        If ModuleKoneksi.CurrentUserLevel <> "Siswa" Then
            txtNIP.Enabled = True
            btnTambah.Enabled = True  ' Tombol Tambah AKTIF
            btnUbah.Enabled = False   ' Tombol Ubah nonaktif
            btnHapus.Enabled = False  ' Tombol Hapus nonaktif
        End If

        txtNIP.Focus()
    End Sub

#End Region

#Region "Event Handler CRUD"

    ' Event Load saat UC pertama kali dibuka
    Private Sub UC_DataGuru_Load(sender As Object, e As EventArgs) Handles Me.Load
        AturHakAkses()
        TampilData()
        KosongkanForm()
    End Sub

    ' ==========================================================
    ' <<< LOGIKA BARU UNTUK "Button Tambah" >>>
    ' (CREATE) Tombol Tambah: Hanya untuk menyimpan data BARU (INSERT)
    ' ==========================================================
    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        ' (Logika ini diambil dari btnSimpan Anda yang lama)
        If String.IsNullOrWhiteSpace(txtNIP.Text) OrElse String.IsNullOrWhiteSpace(txtNamaGuru.Text) Then
            MsgBox("NIP dan Nama Guru wajib diisi!", vbExclamation)
            Return
        End If

        Try
            BukaKoneksi()
            Dim query As String = "INSERT INTO Tbl_Guru (NIP, Nama_Guru, Jenis_Kelamin, Alamat, Telepon, Email) " &
                                  "VALUES (@NIP, @Nama, @JK, @Alamat, @Telp, @Email)"
            Cmd = New MySqlCommand(query, Conn)

            Cmd.Parameters.AddWithValue("@NIP", txtNIP.Text)
            Cmd.Parameters.AddWithValue("@Nama", txtNamaGuru.Text)
            Cmd.Parameters.AddWithValue("@JK", cmbJenisKelamin.Text)
            Cmd.Parameters.AddWithValue("@Alamat", txtAlamat.Text)
            Cmd.Parameters.AddWithValue("@Telp", txtTelepon.Text)
            Cmd.Parameters.AddWithValue("@Email", txtEmail.Text)

            Cmd.ExecuteNonQuery()
            MsgBox("Data guru baru berhasil disimpan.", vbInformation)

        Catch ex As MySqlException
            If ex.Number = 1062 Then ' Duplikat NIP
                MsgBox("NIP " & txtNIP.Text & " sudah terdaftar.", vbCritical)
            Else
                MsgBox("Error MySQL saat menyimpan: " & ex.Message, vbCritical)
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
    ' <<< LOGIKA BARU UNTUK "Button Ubah" >>>
    ' (UPDATE) Tombol Ubah: Hanya untuk menyimpan data EDITAN (UPDATE)
    ' Ganti nama 'btnEdit' di desainer Anda menjadi 'btnUbah'
    ' ==========================================================
    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        ' (Logika ini diambil dari btnEdit Anda yang lama)
        If String.IsNullOrWhiteSpace(selectedNIP) Then
            MsgBox("Pilih data guru dari tabel terlebih dahulu.", vbExclamation)
            Return
        End If

        Try
            BukaKoneksi()
            Dim query As String = "UPDATE Tbl_Guru SET Nama_Guru = @Nama, Jenis_Kelamin = @JK, Alamat = @Alamat, " &
                                  "Telepon = @Telp, Email = @Email " &
                                  "WHERE NIP = @NIP"
            Cmd = New MySqlCommand(query, Conn)

            Cmd.Parameters.AddWithValue("@Nama", txtNamaGuru.Text)
            Cmd.Parameters.AddWithValue("@JK", cmbJenisKelamin.Text)
            Cmd.Parameters.AddWithValue("@Alamat", txtAlamat.Text)
            Cmd.Parameters.AddWithValue("@Telp", txtTelepon.Text)
            Cmd.Parameters.AddWithValue("@Email", txtEmail.Text)
            Cmd.Parameters.AddWithValue("@NIP", selectedNIP) ' Ambil dari variabel global

            Cmd.ExecuteNonQuery()
            MsgBox("Data guru berhasil diupdate.", vbInformation)

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
        If String.IsNullOrWhiteSpace(selectedNIP) Then
            MsgBox("Pilih data guru dari tabel terlebih dahulu.", vbExclamation)
            Return
        End If

        If MsgBox("Apakah Anda yakin ingin menghapus data guru " & txtNamaGuru.Text & "?", vbQuestion + vbYesNo, "Konfirmasi Hapus") = vbNo Then
            Return
        End If

        Try
            BukaKoneksi()
            Dim query As String = "DELETE FROM Tbl_Guru WHERE NIP = @NIP"
            Cmd = New MySqlCommand(query, Conn)
            Cmd.Parameters.AddWithValue("@NIP", selectedNIP)

            Cmd.ExecuteNonQuery()
            MsgBox("Data guru berhasil dihapus.", vbInformation)

        Catch ex As MySqlException
            If ex.Number = 1451 Then ' Error Foreign Key
                MsgBox("Gagal menghapus! Guru ini masih terdaftar sebagai Wali Kelas atau Pengajar di Jadwal.", vbCritical)
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
    ' Pastikan Anda punya tombol bernama 'btnBatal' di desainer
    ' ==========================================================
    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        KosongkanForm()
    End Sub

    ' --- Tombol yang tidak terpakai lagi ---
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        ' KOSONGKAN ATAU HAPUS. Logika sudah dipindah ke btnTambah dan btnUbah
    End Sub

    ' Jika Anda masih punya 'btnTambah' lama yang event-nya kosong, hapus saja
    ' Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
    '    ' Logika lama (KosongkanForm) dipindah ke btnBatal_Click
    ' End Sub

#End Region

#Region "Event GridView dan Pencarian"

    ' Event saat baris di DataGridView di-klik
    ' Ini adalah bagian dari logika "Button Ubah" Anda
    Private Sub dgvGuru_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvGuru.CellClick
        If e.RowIndex >= 0 Then
            Dim baris As DataGridViewRow = dgvGuru.Rows(e.RowIndex)

            ' Ambil data dari Grid dan masukkan ke Form
            selectedNIP = baris.Cells("NIP").Value.ToString()
            txtNIP.Text = selectedNIP
            txtNamaGuru.Text = baris.Cells("Nama_Guru").Value.ToString()
            cmbJenisKelamin.Text = baris.Cells("Jenis_Kelamin").Value.ToString()
            txtAlamat.Text = baris.Cells("Alamat").Value.ToString()
            txtTelepon.Text = baris.Cells("Telepon").Value.ToString()
            txtEmail.Text = baris.Cells("Email").Value.ToString()

            ' <<< PERUBAHAN DI SINI >>>
            ' Atur tombol untuk mode "Ubah"
            If ModuleKoneksi.CurrentUserLevel <> "Siswa" Then
                txtNIP.Enabled = False ' Primary Key tidak boleh diedit
                btnTambah.Enabled = False ' Tombol Tambah nonaktif
                btnUbah.Enabled = True    ' TomTbol Ubah AKTIF
                btnHapus.Enabled = True   ' Tombol Hapus AKTIF
            End If
        End If
    End Sub

    ' (READ / Search) (Logika sudah benar)
    Private Sub txtCariGuru_TextChanged(sender As Object, e As EventArgs) Handles txtCariGuru.TextChanged
        Try
            BukaKoneksi()
            Dim query As String = "SELECT * FROM Tbl_Guru WHERE Nama_Guru LIKE @Search OR NIP LIKE @Search"

            Da = New MySqlDataAdapter(query, Conn)
            Da.SelectCommand.Parameters.AddWithValue("@Search", "%" & txtCariGuru.Text & "%")

            Ds = New DataSet()
            Da.Fill(Ds, "GuruCari")
            dgvGuru.DataSource = Ds.Tables("GuruCari")

        Catch ex As Exception
        Finally
            TutupKoneksi()
        End Try
    End Sub

    ' Event handler di bawah ini bisa Anda hapus jika tidak ada isinya
    Private Sub dgvGuru_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvGuru.CellContentClick
        ' Biarkan kosong
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter
        ' Biarkan kosong
    End Sub

    Private Sub cmbJenisKelamin_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbJenisKelamin.SelectedIndexChanged

    End Sub

    Private Sub txtNIP_TextChanged(sender As Object, e As EventArgs) Handles txtNIP.TextChanged

    End Sub

#End Region

End Class