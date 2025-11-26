Imports MySql.Data.MySqlClient

Public Class FormLogin

    ' ==============================================================
    ' 1. SAAT FORM DIBUKA (LOAD)
    ' ==============================================================
    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Bersihkan inputan saat form muncul
        txtUsername.Clear()
        txtPassword.Clear()

        ' Fokuskan kursor ke username
        txtUsername.Focus()
    End Sub

    ' ==============================================================
    ' 2. TOMBOL LOGIN (INTI LOGIKA)
    ' ==============================================================
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        ' A. Validasi Input Kosong
        If txtUsername.Text = "" Or txtPassword.Text = "" Then
            MsgBox("Username dan Password wajib diisi!", vbExclamation, "Peringatan")
            Return
        End If

        Try
            ' B. Buka Koneksi
            ModuleKoneksi.BukaKoneksi()

            ' C. Cek User di Database
            Dim query As String = "SELECT * FROM tbl_user WHERE Username=@u AND Password=@p"
            ModuleKoneksi.Cmd = New MySqlCommand(query, ModuleKoneksi.Conn)
            ModuleKoneksi.Cmd.Parameters.AddWithValue("@u", txtUsername.Text)
            ModuleKoneksi.Cmd.Parameters.AddWithValue("@p", txtPassword.Text)

            ModuleKoneksi.Rd = ModuleKoneksi.Cmd.ExecuteReader()

            ' D. Pengecekan Hasil
            If ModuleKoneksi.Rd.Read() Then
                ' --- LOGIN SUKSES ---

                ' 1. Simpan Session ke Module (PENTING UNTUK HAK AKSES)
                ModuleKoneksi.CurrentUser = ModuleKoneksi.Rd("Nama_Lengkap").ToString()
                ModuleKoneksi.CurrentUserLevel = ModuleKoneksi.Rd("Level").ToString()

                ' 2. Pesan Sukses
                MsgBox("Login Berhasil! ")

                ' 3. Tutup Reader (Wajib sebelum pindah form)
                ModuleKoneksi.Rd.Close()

                ' 4. Pindah ke Form Utama
                Me.Hide()
                FormMain.Show()
            Else
                ' --- LOGIN GAGAL ---
                ModuleKoneksi.Rd.Close()
                MsgBox("Username atau Password salah!", vbCritical, "Login Gagal")
                txtPassword.Clear()
                txtPassword.Focus()
            End If

        Catch ex As Exception
            ' Pastikan Reader tertutup jika error agar tidak macet
            If ModuleKoneksi.Rd IsNot Nothing AndAlso Not ModuleKoneksi.Rd.IsClosed Then ModuleKoneksi.Rd.Close()
            MsgBox("Error Database: " & ex.Message, vbCritical)
        End Try
    End Sub

    ' ==============================================================
    ' 3. TOMBOL BATAL / KELUAR
    ' ==============================================================
    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles BtnBatal.Click
        If MsgBox("Apakah Anda yakin ingin keluar aplikasi?", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.Yes Then
            Application.Exit()
        End If
    End Sub

    ' ==============================================================
    ' 4. FITUR TAMBAHAN: TEKAN ENTER LOGIN
    ' ==============================================================
    ' Agar user bisa tekan Enter di kotak Password tanpa klik tombol mouse
    Private Sub txtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnLogin_Click(sender, e) ' Panggil fungsi login
        End If
    End Sub

    ' Event TextChanged (Bisa dikosongkan jika tidak dipakai)
    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged
    End Sub

End Class