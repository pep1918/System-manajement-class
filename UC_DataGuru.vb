Imports MySql.Data.MySqlClient
Imports UAS

Public Class UC_DataGuru
    Inherits UserControl

    Public Sub New()
        InitializeComponent()
    End Sub

    Dim id_edit As Integer = 0

    Private Sub UC_DataGuru_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampilData()
        setAwal()
    End Sub

    Sub tampilData()
        Try
            bukaKoneksi()
            da = New MySqlDataAdapter("SELECT * FROM guru", conn)
            ds = New DataSet
            da.Fill(ds, "guru")
            dgvGuru.DataSource = ds.Tables("guru")
        Catch ex As Exception
            MessageBox.Show("Gagal menampilkan data: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Sub setAwal()
        txtNIP.Clear()
        txtNama.Clear()
        txtAlamat.Clear()
        txtHp.Clear()
        id_edit = 0
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Try
            bukaKoneksi()

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

            MessageBox.Show("Data guru berhasil disimpan!", "Sukses")
            tampilData()
            setAwal()

        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub dgvGuru_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvGuru.CellClick
        If e.RowIndex >= 0 Then
            Dim baris As Integer = e.RowIndex
            id_edit = dgvGuru.Item("id_guru", baris).Value
            txtNIP.Text = dgvGuru.Item("nip", baris).Value.ToString()
            txtNama.Text = dgvGuru.Item("nama_guru", baris).Value.ToString()
            txtAlamat.Text = dgvGuru.Item("alamat", baris).Value.ToString()
            txtHp.Text = dgvGuru.Item("no_hp", baris).Value.ToString()
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If id_edit = 0 Then
            MessageBox.Show("Pilih data guru terlebih dahulu!")
            Exit Sub
        End If

        Try
            bukaKoneksi()
            cmd = New MySqlCommand("DELETE FROM guru WHERE id_guru=@id", conn)
            cmd.Parameters.AddWithValue("@id", id_edit)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Data guru dihapus!")
            tampilData()
            setAwal()
        Catch ex As Exception
            MessageBox.Show("Gagal menghapus data: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
End Class
