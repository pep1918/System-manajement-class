' Impor pustaka konektor MySQL
Imports MySql.Data.MySqlClient

Public Class UC_MataPelajaran
    ' Variabel untuk menyimpan Kode Mapel yang dipilih
    Private selectedKodeMapel As String = ""

#Region "Prosedur Bantuan (Hak Akses, Tampil, Kosongkan)"

    ' (READ-ONLY) Prosedur untuk mengatur hak akses
    Private Sub AturHakAkses()
        If ModuleKoneksi.CurrentUserLevel = "Siswa" Then
            ' === MODE BACA-SAJA (READ-ONLY) UNTUK SISWA ===
            txtKodeMapel.Enabled = False
            txtMapel.Enabled = False ' Menggunakan txtMapel sesuai kode Anda
            numKKM.Enabled = False

            ' <<< PERUBAHAN DI SINI >>>
            btnTambah.Enabled = False
            btnUbah.Enabled = False
            btnHapus.Enabled = False
            btnBatal.Enabled = False

            lblJudulUC.Text = "MELIHAT MATA PELAJARAN (Mode Siswa)"
        Else
            lblJudulUC.Text = "MANAJEMEN MATA PELAJARAN"
        End If
    End Sub

    ' (READ) Menampilkan data ke DataGridView
    Private Sub TampilData()
        Try
            BukaKoneksi()
            Dim query As String = "SELECT Kode_Mapel, Nama_Mapel, KKM FROM Tbl_Mapel"

            Da = New MySqlDataAdapter(query, Conn)
            Ds = New DataSet()
            Da.Fill(Ds, "Mapel")
            dgvMapel.DataSource = Ds.Tables("Mapel")

        Catch ex As Exception
            MsgBox("Gagal menampilkan data mata pelajaran: " & ex.Message, vbCritical)
        Finally
            TutupKoneksi()
        End Try
    End Sub

    ' Membersihkan form input
    Private Sub KosongkanForm()
        txtKodeMapel.Clear()
        txtMapel.Clear()
        numKKM.Value = 75 ' Nilai default

        selectedKodeMapel = ""

        ' <<< PERUBAHAN DI SINI >>>
        If ModuleKoneksi.CurrentUserLevel <> "Siswa" Then
            txtKodeMapel.Enabled = True
            btnTambah.Enabled = True  ' Tombol Tambah AKTIF
            btnUbah.Enabled = False   ' Tombol Ubah nonaktif
            btnHapus.Enabled = False  ' Tombol Hapus nonaktif
        End If

        txtKodeMapel.Focus()
    End Sub

#End Region

#Region "Event Handler CRUD"

    Private Sub UC_MataPelajaran_Load(sender As Object, e As EventArgs) Handles Me.Load
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
        If String.IsNullOrWhiteSpace(txtKodeMapel.Text) OrElse String.IsNullOrWhiteSpace(txtMapel.Text) Then
            MsgBox("Kode Mapel dan Nama Mapel wajib diisi!", vbExclamation)
            Return
        End If

        Try
            BukaKoneksi()
            Dim query As String = "INSERT INTO Tbl_Mapel (Kode_Mapel, Nama_Mapel, KKM) VALUES (@Kode, @Nama, @KKM)"
            Cmd = New MySqlCommand(query, Conn)

            Cmd.Parameters.AddWithValue("@Kode", txtKodeMapel.Text)
            Cmd.Parameters.AddWithValue("@Nama", txtMapel.Text) ' Menggunakan txtMapel
            Cmd.Parameters.AddWithValue("@KKM", numKKM.Value)

            Cmd.ExecuteNonQuery()
            MsgBox("Data mapel baru berhasil disimpan.", vbInformation)

        Catch ex As MySqlException
            If ex.Number = 1062 Then ' Duplikat Kode Mapel (Primary Key)
                MsgBox("Kode Mapel " & txtKodeMapel.Text & " sudah terdaftar.", vbCritical)
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
    ' ==========================================================
    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        ' (Logika ini diambil dari btnEdit Anda yang lama)
        If String.IsNullOrWhiteSpace(selectedKodeMapel) Then
            MsgBox("Pilih data mapel dari tabel terlebih dahulu.", vbExclamation)
            Return
        End If

        Try
            BukaKoneksi()
            Dim query As String = "UPDATE Tbl_Mapel SET Nama_Mapel = @Nama, KKM = @KKM WHERE Kode_Mapel = @Kode"
            Cmd = New MySqlCommand(query, Conn)

            Cmd.Parameters.AddWithValue("@Nama", txtMapel.Text) ' Menggunakan txtMapel
            Cmd.Parameters.AddWithValue("@KKM", numKKM.Value)
            Cmd.Parameters.AddWithValue("@Kode", selectedKodeMapel)

            Cmd.ExecuteNonQuery()
            MsgBox("Data mapel berhasil diupdate.", vbInformation)

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
        If String.IsNullOrWhiteSpace(selectedKodeMapel) Then
            MsgBox("Pilih data mapel dari tabel terlebih dahulu.", vbExclamation)
            Return
        End If

        If MsgBox("Apakah Anda yakin ingin menghapus mapel " & txtMapel.Text & "?", vbQuestion + vbYesNo, "Konfirmasi Hapus") = vbNo Then
            Return
        End If

        Try
            BukaKoneksi()
            Dim query As String = "DELETE FROM Tbl_Mapel WHERE Kode_Mapel = @Kode"
            Cmd = New MySqlCommand(query, Conn)
            Cmd.Parameters.AddWithValue("@Kode", selectedKodeMapel)

            Cmd.ExecuteNonQuery()
            MsgBox("Data mapel berhasil dihapus.", vbInformation)

        Catch ex As MySqlException
            If ex.Number = 1451 Then ' Error Foreign Key
                MsgBox("Gagal menghapus! Mapel ini masih terdaftar di Jadwal.", vbCritical)
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

    ' --- Tombol yang tidak terpakai lagi ---
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        ' KOSONGKAN ATAU HAPUS
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        ' KOSONGKAN ATAU HAPUS
    End Sub

#End Region

#Region "Event GridView dan Pencarian"

    ' Ini adalah bagian dari logika "Button Ubah"
    Private Sub dgvMapel_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMapel.CellClick
        If e.RowIndex >= 0 Then
            Dim baris As DataGridViewRow = dgvMapel.Rows(e.RowIndex)

            selectedKodeMapel = baris.Cells("Kode_Mapel").Value.ToString()
            txtKodeMapel.Text = selectedKodeMapel
            txtMapel.Text = baris.Cells("Nama_Mapel").Value.ToString() ' Mengisi ke txtMapel
            numKKM.Value = CDec(baris.Cells("KKM").Value)

            ' <<< PERUBAHAN DI SINI >>>
            If ModuleKoneksi.CurrentUserLevel <> "Siswa" Then
                txtKodeMapel.Enabled = False ' Primary Key tidak boleh diedit
                btnTambah.Enabled = False ' Tombol Tambah nonaktif
                btnUbah.Enabled = True    ' Tombol Ubah AKTIF
                btnHapus.Enabled = True   ' Tombol Hapus AKTIF
            End If
        End If
    End Sub

    ' (READ / Search) (Logika sudah benar)
    Private Sub txtCariMapel_TextChanged(sender As Object, e As EventArgs) Handles txtCariMapel.TextChanged
        Try
            BukaKoneksi()
            Dim query As String = "SELECT * FROM Tbl_Mapel WHERE Nama_Mapel LIKE @Search OR Kode_Mapel LIKE @Search"

            Da = New MySqlDataAdapter(query, Conn)
            Da.SelectCommand.Parameters.AddWithValue("@Search", "%" & txtCariMapel.Text & "%")

            Ds = New DataSet()
            Da.Fill(Ds, "MapelCari")
            dgvMapel.DataSource = Ds.Tables("MapelCari")

        Catch ex As Exception
            ' Abaikan
        Finally
            TutupKoneksi()
        End Try
    End Sub

    Private Sub dgvMapel_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMapel.CellContentClick

    End Sub

#End Region

End Class