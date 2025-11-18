Imports MySql.Data.MySqlClient

Public Class UC_DataSiswa
    Private selectedNIS As String = ""


#Region "Event GridView dan Pencarian"

    Private Sub dgvSiswa_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSiswa.CellClick
        ' ... (Kode CellClick tetap sama) ...
        ' Saat siswa mengklik grid, data akan terisi ke form,
        ' tapi form-nya dalam keadaan nonaktif (disabled), jadi tidak bisa diubah.

        ' Perbarui status tombol (meskipun untuk siswa akan tetap nonaktif)
        If ModuleKoneksi.CurrentUserLevel <> "Siswa" Then
            txtNIS.Enabled = False
            btnSimpan.Enabled = False
            btnEdit.Enabled = True
            btnHapus.Enabled = True
        End If
    End Sub

    Private Sub txtCariSiswa_TextChanged(sender As Object, e As EventArgs) Handles txtCariSiswa.TextChanged
        ' ... (Kode Pencarian tetap sama) ...
        ' Siswa tetap bisa mencari data
    End Sub

    Private Sub lbjudul_Click(sender As Object, e As EventArgs) Handles lbjudul.Click

    End Sub

    Private Sub txtNIS_TextChanged(sender As Object, e As EventArgs) Handles txtNIS.TextChanged

    End Sub

#End Region

End Class