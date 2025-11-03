' Impor pustaka konektor MySQL
Imports MySql.Data.MySqlClient

Public Class FormLogin

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If String.IsNullOrWhiteSpace(txtUsername.Text) OrElse String.IsNullOrWhiteSpace(txtPassword.Text) Then
            MsgBox("Username dan Password tidak boleh kosong!", vbExclamation)
            Return
        End If

        Try
            BukaKoneksi() ' Memanggil dari ModuleKoneksi

            Dim query As String = "SELECT * FROM Tbl_User WHERE Username = @Username AND Password = @Password"
            Cmd = New MySqlCommand(query, Conn)
            Cmd.Parameters.AddWithValue("@Username", txtUsername.Text)
            Cmd.Parameters.AddWithValue("@Password", txtPassword.Text)

            ' DataReader (Rd) dibuka di sini
            Rd = Cmd.ExecuteReader()
            Rd.Read()

            If Rd.HasRows Then
                ' Jika data ditemukan (login berhasil)
                Dim namaLengkap As String = Rd.Item("Nama_Lengkap").ToString()
                Dim userLevel As String = Rd.Item("Level").ToString()

                ' Simpan level pengguna ke variabel global
                ModuleKoneksi.CurrentUserLevel = userLevel

                MsgBox("Login Berhasil! Selamat Datang, " & namaLengkap, vbInformation, "Sukses")

                Dim frmMain As New FormMain()
                Me.Hide()
                frmMain.Show()
            Else
                ' Jika data tidak ditemukan
                MsgBox("Username atau Password salah!", vbExclamation, "Gagal Login")
                txtPassword.Clear()
                txtUsername.Focus()
            End If

        Catch ex As Exception
            MsgBox("Terjadi error saat login: " & ex.Message, vbCritical)
        Finally
            ' Bagian ini akan memanggil 'TutupKoneksi()' yang sudah diperbarui.
            ' 'TutupKoneksi()' akan menutup 'Rd' dan 'Conn' secara otomatis.
            TutupKoneksi()
        End Try
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles BtnBatal.Click
        ' Menutup seluruh aplikasi
        Application.Exit()
    End Sub

End Class