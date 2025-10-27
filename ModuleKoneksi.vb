Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Module ModuleKoneksi
    Public conn As MySqlConnection
    Public cmd As MySqlCommand
    Public dr As MySqlDataReader
    Public da As MySqlDataAdapter
    Public ds As DataSet

    Sub bukaKoneksi()
        Try
            Dim str As String = "server=localhost;user id=root;password=;database=db_manajemen_kelas"
            conn = New MySqlConnection(str)
            conn.Open()
        Catch ex As Exception
            MessageBox.Show("Koneksi gagal: " & ex.Message)
        End Try
    End Sub
End Module
