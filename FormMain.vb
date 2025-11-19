' Tidak perlu 'Imports MySql.Data.MySqlClient' di sini
' karena form ini tidak berinteraksi langsung dengan database.

Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class FormMain

    ' =========================================================================
    ' PROSEDUR BANTUAN (HELPER)
    ' Tugas: Membersihkan PanelUtama dan memuat User Control yang baru ke dalamnya.
    ' =========================================================================
    Private Sub LoadUserControl(control As UserControl)
        ' 1. Hapus kontrol apa pun yang sedang ada di panel
        PanelUtama.Controls.Clear()

        ' 2. Atur agar User Control memenuhi seluruh area panel
        control.Dock = DockStyle.Fill

        ' 3. Tambahkan User Control baru ke panel
        PanelUtama.Controls.Add(control)
    End Sub



    ' =========================================================================
    ' EVENT HANDLER UNTUK TOMBOL MENU NAVIGASI
    ' Setiap tombol akan membuat instance baru dari UC-nya masing-masing
    ' dan memanggil prosedur LoadUserControl.
    ' =========================================================================

    Private Sub btnDataSiswa_Click(sender As Object, e As EventArgs) Handles btnDataSiswa.Click
        ' Muat UC Data Siswa
        Dim uc As New UC_DataSiswa()
        LoadUserControl(uc)
    End Sub

    Private Sub btnDataGuru_Click(sender As Object, e As EventArgs) Handles btnDataGuru.Click
        ' Muat UC Data Guru
        Dim uc As New UC_DataGuru()
        LoadUserControl(uc)
    End Sub

    Private Sub btnDataKelas_Click(sender As Object, e As EventArgs) Handles btnDataKelas.Click
        ' Muat UC Data Kelas
        Dim uc As New UC_DataKelas()
        LoadUserControl(uc)
    End Sub

    Private Sub btnMataPelajaran_Click(sender As Object, e As EventArgs) Handles btnMataPelajaran.Click
        ' Muat UC Mata Pelajaran
        Dim uc As New UC_MataPelajaran()
        LoadUserControl(uc)
    End Sub

    Private Sub btnManajemenPelajaran_Click(sender As Object, e As EventArgs) Handles btnManajemenPelajaran.Click
        ' Muat UC Manajemen Pelajaran (Jadwal)
        Dim uc As New UC_ManajemenPelajaran()
        LoadUserControl(uc)
    End Sub


    ' =========================================================================
    ' EVENT PENUTUP FORM
    ' =========================================================================
    Private Sub FormMain_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        ' Baris ini WAJIB ada.
        ' Karena FormLogin hanya di-Hide (disembunyikan),
        ' kita harus menutup seluruh aplikasi secara paksa saat FormMain ditutup.
        Application.Exit()
    End Sub

    Private Sub PanelUtama_Paint(sender As Object, e As PaintEventArgs) Handles PanelUtama.Paint

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub GroupBox1_Enter_1(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class