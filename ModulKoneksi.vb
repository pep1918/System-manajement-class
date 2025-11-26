Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.Windows.Forms ' PENTING: Agar ComboBox dikenali

Module ModuleKoneksi

    ' ==============================================================
    ' 1. VARIABEL GLOBAL
    ' ==============================================================
    Public Conn As MySqlConnection
    Public Cmd As MySqlCommand
    Public Da As MySqlDataAdapter
    Public Rd As MySqlDataReader
    Public Ds As DataSet

    ' Variabel User Login
    Public CurrentUser As String = ""       ' Menyimpan Nama User
    Public CurrentUserLevel As String = ""  ' Menyimpan Level (Guru/Siswa)


    ' Konfigurasi Koneksi
    Private Const ConnString As String = "Server=localhost;User Id=root;Password=;Database=db_manajemen_kelas"

    ' ==============================================================
    ' 2. FUNGSI-FUNGSI UTAMA
    ' ==============================================================

    ' Buka Koneksi
    Public Sub BukaKoneksi()
        Try
            If Conn Is Nothing Then Conn = New MySqlConnection(ConnString)
            If Conn.State = ConnectionState.Closed Then Conn.Open()
        Catch ex As Exception
            MsgBox("Koneksi Gagal: " & ex.Message)
        End Try
    End Sub

    ' Ambil Data (Untuk DataGridView)
    Public Function AmbilData(query As String) As DataTable
        Dim dt As New DataTable
        Try
            BukaKoneksi()
            Cmd = New MySqlCommand(query, Conn)
            Da = New MySqlDataAdapter(Cmd)
            Da.Fill(dt)
        Catch ex As Exception
            MsgBox("Gagal Ambil Data: " & ex.Message)
        End Try
        Return dt
    End Function

    ' Eksekusi Query (Insert/Update/Delete)
    Public Function EksekusiQuery(query As String, Optional params As List(Of MySqlParameter) = Nothing) As Boolean
        Try
            BukaKoneksi()
            Cmd = New MySqlCommand(query, Conn)
            If params IsNot Nothing Then
                For Each p As MySqlParameter In params
                    Cmd.Parameters.Add(p)
                Next
            End If
            Cmd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            MsgBox("Gagal Eksekusi: " & ex.Message)
            Return False
        End Try
    End Function

    ' Ambil Satu Nilai (Untuk Hitung Jumlah/Cek ID)
    Public Function AmbilNilai(query As String) As String
        Try
            BukaKoneksi()
            Cmd = New MySqlCommand(query, Conn)
            Dim hasil = Cmd.ExecuteScalar()
            If hasil Is Nothing Then Return "0"
            Return hasil.ToString()
        Catch ex As Exception
            Return "0"
        End Try
    End Function

    ' Isi ComboBox Otomatis
    Public Sub IsiCombo(query As String, cmb As ComboBox)
        Try
            BukaKoneksi()
            Cmd = New MySqlCommand(query, Conn)
            Rd = Cmd.ExecuteReader()

            cmb.Items.Clear()
            While Rd.Read()
                cmb.Items.Add(Rd(0).ToString())
            End While
            Rd.Close()
        Catch ex As Exception
            If Rd IsNot Nothing AndAlso Not Rd.IsClosed Then Rd.Close()
        End Try
    End Sub

End Module