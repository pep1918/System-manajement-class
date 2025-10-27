Imports MySql.Data.MySqlClient

Public Class FormLogin
    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbRole.Items.Add("guru")
        cmbRole.Items.Add("siswa")
        cmbRole.SelectedIndex = 0
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Call bukaKoneksi()

        Dim query As String = "SELECT * FROM user WHERE username=@u AND password=@p AND role=@r"
        cmd = New MySqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@u", txtUsername.Text)
        cmd.Parameters.AddWithValue("@p", txtPassword.Text)
        cmd.Parameters.AddWithValue("@r", cmbRole.Text)

        dr = cmd.ExecuteReader()

        If dr.Read() Then
            MessageBox.Show("Login berhasil sebagai " & cmbRole.Text)
            FormMain.roleUser = cmbRole.Text
            FormMain.Show()
            Me.Hide()
        Else
            MessageBox.Show("Login gagal! Cek username, password, dan role.")
        End If
        conn.Close()
    End Sub
End Class
