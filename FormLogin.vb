Imports MySql.Data.MySqlClient

Public Class FormLogin

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUsername.Text = "" Or txtPassword.Text = "" Then
            MsgBox("Isi Username dan Password!", vbExclamation)
            Return
        End If

        Try
            ModuleKoneksi.BukaKoneksi()

            ' Ambil kolom Level juga
            Dim query As String = "SELECT * FROM tbl_user WHERE Username=@u AND Password=@p"
            ModuleKoneksi.Cmd = New MySqlCommand(query, ModuleKoneksi.Conn)
            ModuleKoneksi.Cmd.Parameters.AddWithValue("@u", txtUsername.Text)
            ModuleKoneksi.Cmd.Parameters.AddWithValue("@p", txtPassword.Text)

            ModuleKoneksi.Rd = ModuleKoneksi.Cmd.ExecuteReader()

            If ModuleKoneksi.Rd.Read() Then
                ' 1. SIMPAN LEVEL USER KE VARIABEL GLOBAL
                ModuleKoneksi.CurrentUser = ModuleKoneksi.Rd("Nama_Lengkap").ToString()
                ModuleKoneksi.CurrentUserLevel = ModuleKoneksi.Rd("Level").ToString() ' <--- PENTING

                MsgBox("Login Berhasil sebagai " & ModuleKoneksi.CurrentUserLevel)

                ModuleKoneksi.Rd.Close()
                Me.Hide()
                FormMain.Show()
            Else
                ModuleKoneksi.Rd.Close()
                MsgBox("Login Gagal")
            End If

        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
    End Sub

    ' ... (kode lain tetap sama) ...
End Class