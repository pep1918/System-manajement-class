Imports MySql.Data.MySqlClient

Public Class UC_DataKelas
    Inherits System.Windows.Forms.UserControl

    Public Sub New()
        InitializeComponent()
    End Sub

    Dim id_edit As Integer = 0

    Private Sub UC_DataKelas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        isiGuru()
        tampilData()
        setAwal()
    End Sub

    Sub isiGuru()
        Call bukaKoneksi()
        cmd = New MySqlCommand("SELECT * FROM guru", conn)
        dr = cmd.ExecuteReader()
        cmbWali.Items.Clear()
        While dr.Read()
            cmbWali.Items.Add(dr("id_guru").ToString() & " - " & dr("nama_guru").ToString())
        End While
        conn.Close()
    End Sub

    Sub tampilData()
        Call bukaKoneksi()
        da = New MySqlDataAdapter("SELECT kelas.id_kelas, kelas.nama_kelas, guru.nama_guru FROM kelas 
                                   LEFT JOIN guru ON kelas.wali_kelas=guru.id_guru", conn)
        ds = New DataSet
        da.Fill(ds, "kelas")
        dgvKelas.DataSource = ds.Tables("kelas")
        conn.Close()
    End Sub

    Sub setAwal()
        txtNamaKelas.Clear()
        cmbWali.Text = ""
        id_edit = 0
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If txtNamaKelas.Text = "" Then Exit Sub
        Dim id_guru As String = Split(cmbWali.Text, " - ")(0)

        Call bukaKoneksi()
        If id_edit = 0 Then
            cmd = New MySqlCommand("INSERT INTO kelas (nama_kelas, wali_kelas) VALUES (@nama,@wali)", conn)
        Else
            cmd = New MySqlCommand("UPDATE kelas SET nama_kelas=@nama, wali_kelas=@wali WHERE id_kelas=@id", conn)
            cmd.Parameters.AddWithValue("@id", id_edit)
        End If

        cmd.Parameters.AddWithValue("@nama", txtNamaKelas.Text)
        cmd.Parameters.AddWithValue("@wali", id_guru)
        cmd.ExecuteNonQuery()
        conn.Close()
        MessageBox.Show("Data kelas tersimpan!")
        tampilData()
        setAwal()
    End Sub

    Private Sub dgvKelas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvKelas.CellClick
        Dim baris As Integer = dgvKelas.CurrentRow.Index
        id_edit = dgvKelas.Item(0, baris).Value
        txtNamaKelas.Text = dgvKelas.Item(1, baris).Value
        cmbWali.Text = dgvKelas.Item(2, baris).Value
    End Sub

    Private Sub cmbWali_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbWali.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnTambah.Click

    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click

    End Sub
End Class
