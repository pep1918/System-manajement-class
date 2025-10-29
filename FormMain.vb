Imports MySql.Data.MySqlClient
Imports System.Windows.Forms  ' <-- INI BENAR. JANGAN DIHAPUS.
Public Class FormMain
    Public roleUser As String

    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If roleUser = "siswa" Then
            btnGuru.Enabled = False
            btnKelas.Enabled = False
            btnMapel.Enabled = False
            btnManajemen.Enabled = False
        End If
    End Sub

    Private Sub ShowUC(uc As UserControl)
        PanelUtama.Controls.Clear()
        uc.Dock = DockStyle.Fill
        PanelUtama.Controls.Add(uc)
    End Sub

    Private Sub btnSiswa_Click(sender As Object, e As EventArgs) Handles btnSiswa.Click
        ShowUC(New UC_DataSiswa)
    End Sub

    Private Sub btnGuru_Click(sender As Object, e As EventArgs) Handles btnGuru.Click
        ShowUC(New UC_DataGuru)
    End Sub

    Private Sub btnKelas_Click(sender As Object, e As EventArgs) Handles btnKelas.Click
        ShowUC(New UC_DataKelas)
    End Sub

    Private Sub btnMapel_Click(sender As Object, e As EventArgs) Handles btnMapel.Click
        ShowUC(New UC_MataPelajaran)
    End Sub

    Private Sub btnManajemen_Click(sender As Object, e As EventArgs) Handles btnManajemen.Click
        ShowUC(New UC_ManajemenPelajaran)
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        FormLogin.Show()
        Me.Hide()
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub PanelUtama_Paint(sender As Object, e As PaintEventArgs) Handles PanelUtama.Paint

    End Sub
End Class
