' Impor pustaka konektor MySQL
Imports MySql.Data.MySqlClient

Module ModuleKoneksi

    ' 1. VARIABEL KONEKSI GLOBAL
    Public Conn As MySqlConnection
    Public Cmd As MySqlCommand
    Public Da As MySqlDataAdapter
    Public Ds As DataSet
    Public Rd As MySqlDataReader ' Ini adalah DataReader yang menyebabkan error
    Public CurrentUser As String = ""

    ' 2. VARIABEL HAK AKSES GLOBAL
    Public CurrentUserLevel As String = "" ' (Admin, Guru, Siswa)

    ' 3. STRING KONEKSI DATABASE
    Private Const ConnectionString As String = "Server=localhost;User Id=root;Password=;Database=db_manajemen_kelas"

    ' 4. PROSEDUR UNTUK MEMBUKA KONEKSI
    Public Sub BukaKoneksi()
        Try
            If Conn Is Nothing OrElse Conn.State = ConnectionState.Closed Then
                Conn = New MySqlConnection(ConnectionString)
                Conn.Open()
            End If
        Catch ex As Exception
            MsgBox("Gagal terhubung ke database." & vbCrLf &
                   "Pesan Error: " & ex.Message, vbCritical, "Koneksi Gagal")
        End Try
    End Sub

    ' 5. PROSEDUR UNTUK MENUTUP KONEKSI (INI BAGIAN YANG DIPERBAIKI)
    Public Sub TutupKoneksi()
        Try
            ' ==========================================================
            ' === PERBAIKAN: Selalu tutup DataReader (Rd) jika terbuka ===
            ' Ini akan memperbaiki error "already an open DataReader"
            If Rd IsNot Nothing AndAlso Not Rd.IsClosed Then
                Rd.Close()
            End If
            ' ==========================================================

            ' Hanya tutup koneksi jika sedang terbuka
            If Conn IsNot Nothing AndAlso Conn.State = ConnectionState.Open Then
                Conn.Close()
            End If
        Catch ex As Exception
            ' Abaikan error saat menutup
        Finally
            ' Bersihkan resource koneksi setelah ditutup
            If Conn IsNot Nothing Then
                Conn.Dispose()
                Conn = Nothing
            End If
        End Try
    End Sub

End Module