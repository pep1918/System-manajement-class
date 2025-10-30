Imports MySql.Data.MySqlClient

Public Class UC_MataPelajaran
    Inherits System.Windows.Forms.UserControl
     
    Public Sub New()
        InitializeComponent()
    End Sub

    Dim id_edit As Integer = 0


    Private Sub UC_MataPelajaran_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampilData()
        setAwal()
    End Sub

    Sub tampilData()
        Call bukaKoneksi()
        da = New MySqlDataAdapter("SELECT * FROM mapel", conn)
        ds = New DataSet
        da.Fill(ds, "mapel")
        dgvMapel.DataSource = ds.Tables("mapel")
        conn.Close()
    End Sub

    Sub setAwal()
        txtKode.Clear()
        txtNama.Clear()
        id_edit = 0
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Call bukaKoneksi()
        If id_edit = 0 Then
            cmd = New MySqlCommand("INSERT INTO mapel (kode_mapel, nama_mapel) VALUES (@kode,@nama)", conn)
        Else
            cmd = New MySqlCommand("UPDATE mapel SET kode_mapel=@kode, nama_mapel=@nama WHERE id_mapel=@id", conn)
            cmd.Parameters.AddWithValue("@id", id_edit)
        End If
        cmd.Parameters.AddWithValue("@kode", txtKode.Text)
        cmd.Parameters.AddWithValue("@nama", txtNama.Text)
        cmd.ExecuteNonQuery()
        conn.Close()
        tampilData()
        setAwal()
    End Sub

    Private Sub dgvMapel_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMapel.CellClick
        Dim baris As Integer = dgvMapel.CurrentRow.Index
        id_edit = dgvMapel.Item(0, baris).Value
        txtKode.Text = dgvMapel.Item(1, baris).Value
        txtNama.Text = dgvMapel.Item(2, baris).Value
    End Sub

    Private Sub lbjudul_Click(sender As Object, e As EventArgs) Handles lbjudul.Click

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class
