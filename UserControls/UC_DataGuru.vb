Imports MySql.Data.MySqlClient

Public Class UC_DataGuru
    Inherits System.Windows.Forms.UserControl

    Public Sub New()
        InitializeComponent()
    End Sub

    Dim id_edit As Integer = 0

    Private Sub UC_DataGuru_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            tampilData()
            setAwal()
        End Sub

        Sub tampilData()
            Call bukaKoneksi()
            da = New MySqlDataAdapter("SELECT * FROM guru", conn)
            ds = New DataSet
            da.Fill(ds, "guru")
            dgvGuru.DataSource = ds.Tables("guru")
            conn.Close()
        End Sub

        Sub setAwal()
            txtNIP.Clear()
            txtNama.Clear()
            txtAlamat.Clear()
            txtHp.Clear()
            id_edit = 0
        End Sub

        Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
            Call bukaKoneksi()

            If id_edit = 0 Then
                cmd = New MySqlCommand("INSERT INTO guru (nip, nama_guru, alamat, no_hp) VALUES (@nip,@nama,@alamat,@hp)", conn)
            Else
                cmd = New MySqlCommand("UPDATE guru SET nip=@nip, nama_guru=@nama, alamat=@alamat, no_hp=@hp WHERE id_guru=@id", conn)
                cmd.Parameters.AddWithValue("@id", id_edit)
            End If

            cmd.Parameters.AddWithValue("@nip", txtNIP.Text)
            cmd.Parameters.AddWithValue("@nama", txtNama.Text)
            cmd.Parameters.AddWithValue("@alamat", txtAlamat.Text)
            cmd.Parameters.AddWithValue("@hp", txtHp.Text)
            cmd.ExecuteNonQuery()
            conn.Close()

            MessageBox.Show("Data tersimpan!")
            tampilData()
            setAwal()
        End Sub

        Private Sub dgvGuru_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvGuru.CellClick
            Dim baris As Integer = dgvGuru.CurrentRow.Index
            id_edit = dgvGuru.Item(0, baris).Value
            txtNIP.Text = dgvGuru.Item(1, baris).Value
            txtNama.Text = dgvGuru.Item(2, baris).Value
            txtAlamat.Text = dgvGuru.Item(3, baris).Value
            txtHp.Text = dgvGuru.Item(4, baris).Value
        End Sub

        Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
            If id_edit = 0 Then Exit Sub
            Call bukaKoneksi()
            cmd = New MySqlCommand("DELETE FROM guru WHERE id_guru=@id", conn)
            cmd.Parameters.AddWithValue("@id", id_edit)
            cmd.ExecuteNonQuery()
            conn.Close()
            MessageBox.Show("Data dihapus!")
            tampilData()
            setAwal()
        End Sub

    Private Sub lbjudul_Click(sender As Object, e As EventArgs) Handles lbjudul.Click

    End Sub
End Class
