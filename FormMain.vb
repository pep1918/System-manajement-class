Imports MySql.Data.MySqlClient
Imports System.Windows.Forms.DataVisualization.Charting

Public Class FormMain

    ' ==============================================================
    ' 1. SAAT APLIKASI DIBUKA (LOAD)
    ' ==============================================================
    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Tampilkan Dashboard (Statistik langsung di PanelUtama)
        RefreshDashboard()
    End Sub

    ' ==============================================================
    ' 2. LOGIKA REFRESH DASHBOARD (DATA LANGSUNG DI PANEL UTAMA)
    ' ==============================================================
    Sub RefreshDashboard()
        Try
            ' Pastikan koneksi terbuka
            ModuleKoneksi.BukaKoneksi()

            ' --- A. Hitung Angka Statistik (Label langsung di PanelUtama) ---

            ' 1. Total Siswa
            ModuleKoneksi.Cmd = New MySqlCommand("SELECT COUNT(*) FROM tbl_siswa", ModuleKoneksi.Conn)
            Dim totalSiswa As Object = ModuleKoneksi.Cmd.ExecuteScalar()
            lblJmlSiswa.Text = If(totalSiswa IsNot Nothing, totalSiswa.ToString(), "0")

            ' 2. Total Guru
            ModuleKoneksi.Cmd = New MySqlCommand("SELECT COUNT(*) FROM tbl_guru", ModuleKoneksi.Conn)
            Dim totalGuru As Object = ModuleKoneksi.Cmd.ExecuteScalar()
            lblJmlGuru.Text = If(totalGuru IsNot Nothing, totalGuru.ToString(), "0")

            ' 3. Total Kelas
            ModuleKoneksi.Cmd = New MySqlCommand("SELECT COUNT(*) FROM tbl_kelas", ModuleKoneksi.Conn)
            Dim totalKelas As Object = ModuleKoneksi.Cmd.ExecuteScalar()
            lblJmlKelas.Text = If(totalKelas IsNot Nothing, totalKelas.ToString(), "0")

            ' --- B. Grafik KKM (Chart langsung di PanelUtama) ---
            Dim queryChart As String = "SELECT nama_mapel, kkm FROM tbl_mapel LIMIT 5"
            ModuleKoneksi.Cmd = New MySqlCommand(queryChart, ModuleKoneksi.Conn)

            ' Gunakan Rd Global
            ModuleKoneksi.Rd = ModuleKoneksi.Cmd.ExecuteReader()

            'ChartKKM.Series.Clear()
            Dim s As New Series("KKM")
            s.ChartType = SeriesChartType.Column
            s.IsValueShownAsLabel = True

            While ModuleKoneksi.Rd.Read()
                Dim mapel As String = ModuleKoneksi.Rd("nama_mapel").ToString()
                Dim kkmVal As Integer = Convert.ToInt32(ModuleKoneksi.Rd("kkm"))

                Dim pIdx As Integer = s.Points.AddXY(mapel, kkmVal)

                ' Warna Hijau jika >= 75, Merah jika kurang
                If kkmVal >= 75 Then
                    s.Points(pIdx).Color = Color.SeaGreen
                Else
                    s.Points(pIdx).Color = Color.Tomato
                End If
            End While

            'ChartKKM.Series.Add(s)
            ModuleKoneksi.Rd.Close() ' Wajib tutup reader

        Catch ex As Exception
            ' Pastikan Reader tertutup jika error
            If ModuleKoneksi.Rd IsNot Nothing AndAlso Not ModuleKoneksi.Rd.IsClosed Then ModuleKoneksi.Rd.Close()
            ' Silent error (opsional: MsgBox(ex.Message))
        End Try
    End Sub

    ' ==============================================================
    ' 3. NAVIGASI MENU (LOGIKA TUMPUK LAYAR)
    ' ==============================================================
    Private Sub BukaMenu(konten As UserControl)
        ' 1. Hapus menu (UserControl) yang sedang terbuka sebelumnya
        ' Kita loop terbalik untuk mencari UserControl yang menutupi Dashboard
        For i As Integer = PanelUtama.Controls.Count - 1 To 0 Step -1
            Dim ctrl = PanelUtama.Controls(i)

            ' Hapus HANYA jika itu adalah UserControl (Menu Siswa, Guru, dll)
            ' JANGAN hapus Label atau Chart Dashboard
            If TypeOf ctrl Is UserControl Then
                PanelUtama.Controls.Remove(ctrl)
                ctrl.Dispose() ' Bersihkan memori
            End If
        Next

        ' 2. Tambahkan Menu Baru di ATAS Dashboard
        konten.Dock = DockStyle.Fill
        PanelUtama.Controls.Add(konten)

        ' 3. PENTING: Taruh di lapisan paling depan agar menutupi Label & Chart
        konten.BringToFront()
    End Sub

    ' ==============================================================
    ' 4. EVENT TOMBOL (PASTIKAN NAMA TOMBOL SESUAI DESAIN)
    ' ==============================================================

    ' Tombol Dashboard (Home)
    ' Pastikan nama tombol di desain adalah btnDashboard
    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        ' Hapus semua UserControl yang menutupi dashboard
        For i As Integer = PanelUtama.Controls.Count - 1 To 0 Step -1
            Dim ctrl = PanelUtama.Controls(i)
            If TypeOf ctrl Is UserControl Then
                PanelUtama.Controls.Remove(ctrl)
                ctrl.Dispose()
            End If
        Next

        ' Karena penutupnya hilang, Label & Chart Dashboard otomatis terlihat lagi
        RefreshDashboard() ' Update angkanya
    End Sub

    Private Sub btnDataSiswa_Click(sender As Object, e As EventArgs) Handles btnDataSiswa.Click
        BukaMenu(New UC_DataSiswa())
    End Sub

    Private Sub btnDataGuru_Click(sender As Object, e As EventArgs) Handles btnDataGuru.Click
        BukaMenu(New UC_DataGuru())
    End Sub

    Private Sub btnDataKelas_Click(sender As Object, e As EventArgs) Handles btnDataKelas.Click
        BukaMenu(New UC_DataKelas())
    End Sub



    Private Sub btnManajemenPelajaran_Click(sender As Object, e As EventArgs) Handles btnManajemenPelajaran.Click
        BukaMenu(New UC_ManajemenPelajaran())
    End Sub

    ' Tombol Tambahan (Laporan) jika ada
    Private Sub btnLaporan_Click(sender As Object, e As EventArgs) Handles btnLaporan.Click
        BukaMenu(New UC_Laporan())
    End Sub

    ' Tombol Logout / Keluar
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        If MsgBox("Yakin ingin keluar?", MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub FormMain_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Application.Exit()
    End Sub

    ' Event kosong bawaan (bisa dihapus jika tidak dipakai)
    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs)
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs)
    End Sub

    Private Sub Panel2_Paint_1(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class