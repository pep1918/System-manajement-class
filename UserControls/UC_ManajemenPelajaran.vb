Imports MySql.Data.MySqlClient


Public Class UC_ManajemenPelajaran


    Public Sub New()
        InitializeComponent()
    End Sub



    Private Sub UC_ManajemenPelajaran_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        isiKelas()
        isiMapel()
        tampilData()
    End Sub

    Sub isiKelas()
        Call bukaKoneksi()
        cmd = New MySqlCommand("SELECT * FROM kelas", conn)
        dr = cmd.ExecuteReader()
        cmbKelas.Items.Clear()
        While dr.Read()
            cmbKelas.Items.Add(dr("id_kelas").ToString() & " - " & dr("nama_kelas").ToString())
        End While
        conn.Close()
    End Sub

    Sub isiMapel()
        Call bukaKoneksi()
        cmd = New MySqlCommand("SELECT * FROM mapel", conn)
        dr = cmd.ExecuteReader()
        cmbMapel.Items.Clear()
        While dr.Read()
            cmbMapel.Items.Add(dr("id_mapel").ToString() & " - " & dr("nama_mapel").ToString())
        End While
        conn.Close()
    End Sub

    Sub tampilData()
        Call bukaKoneksi()
        da = New MySqlDataAdapter("SELECT kelas.nama_kelas, mapel.nama_mapel 
                                   FROM kelas_mapel 
                                   JOIN kelas ON kelas_mapel.id_kelas=kelas.id_kelas 
                                   JOIN mapel ON kelas_mapel.id_mapel=mapel.id_mapel", conn)
        ds = New DataSet
        da.Fill(ds, "kelas_mapel")
        dgvManage.DataSource = ds.Tables("kelas_mapel")
        conn.Close()
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Dim idKelas As String = Split(cmbKelas.Text, " - ")(0)
        Dim idMapel As String = Split(cmbMapel.Text, " - ")(0)

        Call bukaKoneksi()
        cmd = New MySqlCommand("INSERT INTO kelas_mapel (id_kelas,id_mapel) VALUES (@kelas,@mapel)", conn)
        cmd.Parameters.AddWithValue("@kelas", idKelas)
        cmd.Parameters.AddWithValue("@mapel", idMapel)
        cmd.ExecuteNonQuery()
        conn.Close()
        MessageBox.Show("Relasi kelas dan mapel tersimpan!")
        tampilData()
    End Sub

    Private Sub dgvManage_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvManage.CellContentClick

    End Sub
End Class
