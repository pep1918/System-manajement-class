Imports MySql.Data.MySqlClient
Imports System.Windows.Forms.DataVisualization.Charting

Public Class UC_Beranda

    Private Sub UC_Beranda_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilSummary()
        TampilChartSiswaPerKelas()
        TampilAktivitasTerbaru()
    End Sub

    Private Sub TampilSummary()
        Try
            BukaKoneksi()

            ' === TOTAL SISWA ===
            ' TODO: sesuaikan nama tabel/kolom dengan punyamu
            Cmd = New MySqlCommand("SELECT COUNT(*) FROM Tbl_Siswa", Conn)
            Dim jmlSiswa As Integer = CInt(Cmd.ExecuteScalar())
            lblTotalSiswa.Text = jmlSiswa.ToString()

            ' === TOTAL GURU ===
            Cmd = New MySqlCommand("SELECT COUNT(*) FROM Tbl_Guru", Conn)
            Dim jmlGuru As Integer = CInt(Cmd.ExecuteScalar())
            lblTotalGuru.Text = jmlGuru.ToString()

            ' === TOTAL KELAS ===
            Cmd = New MySqlCommand("SELECT COUNT(*) FROM Tbl_Kelas", Conn)
            Dim jmlKelas As Integer = CInt(Cmd.ExecuteScalar())
            lblTotalKelas.Text = jmlKelas.ToString()

        Catch ex As Exception
            MessageBox.Show("Gagal mengambil summary: " & ex.Message)
        Finally
            TutupKoneksi()
        End Try
    End Sub

    Private Sub TampilChartSiswaPerKelas()
        Try
            BukaKoneksi()

            ' TODO: sesuaikan nama tabel/kolom:
            '   - Tbl_Kelas: berisi daftar kelas (misal Kode_Kelas, Nama_Kelas)
            '   - Tbl_Siswa: punya kolom Kode_Kelas yang mengacu ke kelas
            Dim sql As String =
                "SELECT K.Nama_Kelas, COUNT(S.NIS) AS JumlahSiswa " &
                "FROM Tbl_Kelas K " &
                "LEFT JOIN Tbl_Siswa S ON S.Kode_Kelas = K.Kode_Kelas " &
                "GROUP BY K.Nama_Kelas " &
                "ORDER BY K.Nama_Kelas"

            Cmd = New MySqlCommand(sql, Conn)
            Rd = Cmd.ExecuteReader()

            ' Siapkan chart
            chartSiswaKelas.Series.Clear()
            chartSiswaKelas.ChartAreas(0).AxisX.Title = "Kelas"
            chartSiswaKelas.ChartAreas(0).AxisY.Title = "Jumlah Siswa"

            Dim series = chartSiswaKelas.Series.Add("Siswa")
            series.ChartType = SeriesChartType.Column

            While Rd.Read()
                Dim namaKelas As String = Rd("Nama_Kelas").ToString()
                Dim jumlah As Integer = Convert.ToInt32(Rd("JumlahSiswa"))
                series.Points.AddXY(namaKelas, jumlah)
            End While

        Catch ex As Exception
            MessageBox.Show("Gagal menampilkan grafik: " & ex.Message)
        Finally
            TutupKoneksi()
        End Try
    End Sub

    Private Sub TampilAktivitasTerbaru()
        Try
            BukaKoneksi()

            ' TODO: butuh tabel log, misal Tbl_Aktivitas (Waktu, Username, Deskripsi)
            Dim sql As String =
                "SELECT Waktu, Username, Deskripsi " &
                "FROM Tbl_Aktivitas " &
                "ORDER BY Waktu DESC " &
                "LIMIT 10"

            Cmd = New MySqlCommand(sql, Conn)
            Rd = Cmd.ExecuteReader()

            lstAktivitas.Items.Clear()

            While Rd.Read()
                Dim waktu As DateTime = Convert.ToDateTime(Rd("Waktu"))
                Dim user As String = Rd("Username").ToString()
                Dim desk As String = Rd("Deskripsi").ToString()

                Dim baris As String =
                    waktu.ToString("dd/MM/yyyy HH:mm") & " - " &
                    user & " - " & desk

                lstAktivitas.Items.Add(baris)
            End While

        Catch ex As Exception
            MessageBox.Show("Gagal mengambil aktivitas: " & ex.Message)
        Finally
            TutupKoneksi()
        End Try
    End Sub




End Class
