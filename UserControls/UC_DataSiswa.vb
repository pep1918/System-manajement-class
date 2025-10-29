Imports MySql.Data.MySqlClient


Public Class UC_DataSiswa
        Inherits System.Windows.Forms.UserControl

        Public Sub New()
        InitializeComponent()
    End Sub

    Dim id_edit As Integer = 0

    Private Sub UC_DataSiswa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampilData()
        isiKelas()
        setAwal()
    End Sub

    Sub tampilData()
        Call bukaKoneksi()
        da = New MySqlDataAdapter("SELECT siswa.id_siswa, siswa.nis, siswa.nama_siswa, siswa.alamat, siswa.no_hp, kelas.nama_kelas 
                                   FROM siswa JOIN kelas ON siswa.id_kelas=kelas.id_kelas", conn)
        ds = New DataSet
        da.Fill(ds, "siswa")
        dgvSiswa.DataSource = ds.Tables("siswa")
        conn.Close()
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

    Sub setAwal()
        txtNis.Clear()
        txtNama.Clear()
        txtAlamat.Clear()
        txtNoHP.Clear()
        cmbKelas.Text = ""
        id_edit = 0
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If txtNis.Text = "" Or txtNama.Text = "" Or cmbKelas.Text = "" Then
            MessageBox.Show("Lengkapi semua data!")
            Exit Sub
        End If

        Dim id_kelas As String = Split(cmbKelas.Text, " - ")(0)
        Call bukaKoneksi()

        If id_edit = 0 Then
            ' INSERT
            Dim q As String = "INSERT INTO siswa (nis, nama_siswa, alamat, no_hp, id_kelas) VALUES (@nis,@nama,@alamat,@hp,@kelas)"
            cmd = New MySqlCommand(q, conn)
        Else
            ' UPDATE
            Dim q As String = "UPDATE siswa SET nis=@nis, nama_siswa=@nama, alamat=@alamat, no_hp=@hp, id_kelas=@kelas WHERE id_siswa=@id"
            cmd = New MySqlCommand(q, conn)
            cmd.Parameters.AddWithValue("@id", id_edit)
        End If

        cmd.Parameters.AddWithValue("@nis", txtNis.Text)
        cmd.Parameters.AddWithValue("@nama", txtNama.Text)
        cmd.Parameters.AddWithValue("@alamat", txtAlamat.Text)
        cmd.Parameters.AddWithValue("@hp", txtNoHP.Text)
        cmd.Parameters.AddWithValue("@kelas", id_kelas)
        cmd.ExecuteNonQuery()
        conn.Close()

        MessageBox.Show("Data tersimpan!")
        tampilData()
        setAwal()
    End Sub

    Private Sub dgvSiswa_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSiswa.CellClick
        Try
            Dim baris As Integer = dgvSiswa.CurrentRow.Index
            id_edit = dgvSiswa.Item(0, baris).Value
            txtNis.Text = dgvSiswa.Item(1, baris).Value
            txtNama.Text = dgvSiswa.Item(2, baris).Value
            txtAlamat.Text = dgvSiswa.Item(3, baris).Value
            txtNoHP.Text = dgvSiswa.Item(4, baris).Value
            cmbKelas.Text = dgvSiswa.Item(5, baris).Value
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If id_edit = 0 Then
            MessageBox.Show("Pilih data dulu yang akan dihapus!")
            Exit Sub
        End If

        If MessageBox.Show("Yakin hapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Call bukaKoneksi()
            cmd = New MySqlCommand("DELETE FROM siswa WHERE id_siswa=@id", conn)
            cmd.Parameters.AddWithValue("@id", id_edit)
            cmd.ExecuteNonQuery()
            conn.Close()
            MessageBox.Show("Data terhapus!")
            tampilData()
            setAwal()
        End If
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        setAwal()
    End Sub

    Private Sub dgvSiswa_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSiswa.CellContentClick

    End Sub
End Class
