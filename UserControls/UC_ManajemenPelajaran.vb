Imports MySql.Data.MySqlClient

Public Class UC_ManajemenPelajaran
    Inherits System.Windows.Forms.UserControl

    ' 🔹 Deklarasi variabel global
    Dim conn As MySqlConnection
    Dim cmd As MySqlCommand
    Dim dr As MySqlDataReader
    Dim da As MySqlDataAdapter
    Dim ds As DataSet

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub UC_ManajemenPelajaran_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            isiKelas()
            isiMapel()
            tampilData()
        Catch ex As Exception
            MessageBox.Show("Gagal memuat data: " & ex.Message)
        End Try
    End Sub

    ' 🔹 Fungsi untuk buka koneksi
    Private Sub bukaKoneksi()
        If conn Is Nothing Then
            conn = New MySqlConnection("server=localhost;userid=root;password=;database=manajemen_kelas")
        End If
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
    End Sub

    ' 🔹 Isi combo kelas
    Sub isiKelas()
        Try
            bukaKoneksi()
            cmd = New MySqlCommand("SELECT * FROM kelas", conn)
            dr = cmd.ExecuteReader()
            cmbKelas.Items.Clear()
            While dr.Read()
                cmbKelas.Items.Add(dr("id_kelas").ToString() & " - " & dr("nama_kelas").ToString())
            End While
        Catch ex As Exception
            MessageBox.Show("Gagal mengambil data kelas: " & ex.Message)
        Finally
            If dr IsNot Nothing AndAlso Not dr.IsClosed Then dr.Close()
            conn.Close()
        End Try
    End Sub

    ' 🔹 Isi combo mapel
    Sub isiMapel()
        Try
            bukaKoneksi()
            cmd = New MySqlCommand("SELECT * FROM mapel", conn)
            dr = cmd.ExecuteReader()
            cmbMapel.Items.Clear()
            While dr.Read()
                cmbMapel.Items.Add(dr("id_mapel").ToString() & " - " & dr("nama_mapel").ToString())
            End While
        Catch ex As Exception
            MessageBox.Show("Gagal mengambil data mapel: " & ex.Message)
        Finally
            If dr IsNot Nothing AndAlso Not dr.IsClosed Then dr.Close()
            conn.Close()
        End Try
    End Sub

    ' 🔹 Tampilkan data gabungan
    Sub tampilData()
        Try
            bukaKoneksi()
            da = New MySqlDataAdapter("SELECT kelas.nama_kelas AS 'Kelas', mapel.nama_mapel AS 'Mata Pelajaran'
                                       FROM kelas_mapel
                                       JOIN kelas ON kelas_mapel.id_kelas=kelas.id_kelas
                                       JOIN mapel ON kelas_mapel.id_mapel=mapel.id_mapel", conn)
            ds = New DataSet
            da.Fill(ds, "kelas_mapel")
            dgvManage.DataSource = ds.Tables("kelas_mapel")
        Catch ex As Exception
            MessageBox.Show("Gagal menampilkan data: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    ' 🔹 Tambah data relasi
    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        If cmbKelas.SelectedIndex = -1 Or cmbMapel.SelectedIndex = -1 Then
            MessageBox.Show("Pilih dulu kelas dan mata pelajaran!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Dim idKelas As String = Split(cmbKelas.Text, " - ")(0)
            Dim idMapel As String = Split(cmbMapel.Text, " - ")(0)

            bukaKoneksi()
            cmd = New MySqlCommand("INSERT INTO kelas_mapel (id_kelas, id_mapel) VALUES (@kelas, @mapel)", conn)
            cmd.Parameters.AddWithValue("@kelas", idKelas)
            cmd.Parameters.AddWithValue("@mapel", idMapel)
            cmd.ExecuteNonQuery()

            MessageBox.Show("Relasi kelas dan mapel berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            tampilData()
        Catch ex As Exception
            MessageBox.Show("Gagal menambah relasi: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub dgvManage_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvManage.CellContentClick
        ' Tambah fitur lain di sini kalau butuh edit/hapus
    End Sub

End Class
