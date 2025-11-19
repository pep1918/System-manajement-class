<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim ChartArea5 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend5 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series5 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelUtama = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.pnlTotalSiswa = New System.Windows.Forms.Panel()
        Me.lblTotalSiswa = New System.Windows.Forms.Label()
        Me.lblTitleTotalSiswa = New System.Windows.Forms.Label()
        Me.pnlTotalGuru = New System.Windows.Forms.Panel()
        Me.lblTotalGuru = New System.Windows.Forms.Label()
        Me.lblTitleTotalGuru = New System.Windows.Forms.Label()
        Me.pnlTotalKelas = New System.Windows.Forms.Panel()
        Me.lblTotalKelas = New System.Windows.Forms.Label()
        Me.lblTitleTotalKelas = New System.Windows.Forms.Label()
        Me.pnlChart = New System.Windows.Forms.Panel()
        Me.lblJudulChart = New System.Windows.Forms.Label()
        Me.chartSiswaKelas = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.pnlAktivitas = New System.Windows.Forms.Panel()
        Me.lblJudulAktivitas = New System.Windows.Forms.Label()
        Me.lstAktivitas = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnDataSiswa = New System.Windows.Forms.Button()
        Me.btnManajemenPelajaran = New System.Windows.Forms.Button()
        Me.btnDataGuru = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnMataPelajaran = New System.Windows.Forms.Button()
        Me.btnDataKelas = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.PanelUtama.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.pnlTotalSiswa.SuspendLayout()
        Me.pnlTotalGuru.SuspendLayout()
        Me.pnlTotalKelas.SuspendLayout()
        Me.pnlChart.SuspendLayout()
        CType(Me.chartSiswaKelas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlAktivitas.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(255, 655)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel2.Location = New System.Drawing.Point(255, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1078, 93)
        Me.Panel2.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(361, 48)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "3Manage Kelas"
        '
        'PanelUtama
        '
        Me.PanelUtama.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.PanelUtama.Controls.Add(Me.Panel5)
        Me.PanelUtama.Controls.Add(Me.pnlTotalSiswa)
        Me.PanelUtama.Controls.Add(Me.pnlTotalGuru)
        Me.PanelUtama.Controls.Add(Me.pnlTotalKelas)
        Me.PanelUtama.Controls.Add(Me.pnlChart)
        Me.PanelUtama.Controls.Add(Me.pnlAktivitas)
        Me.PanelUtama.Controls.Add(Me.Label2)
        Me.PanelUtama.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelUtama.Location = New System.Drawing.Point(255, 93)
        Me.PanelUtama.Name = "PanelUtama"
        Me.PanelUtama.Size = New System.Drawing.Size(1078, 562)
        Me.PanelUtama.TabIndex = 2
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.Label5)
        Me.Panel5.Controls.Add(Me.ListBox2)
        Me.Panel5.Location = New System.Drawing.Point(815, 51)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(251, 479)
        Me.Panel5.TabIndex = 15
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 14)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 16)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Pengumuman"
        '
        'ListBox2
        '
        Me.ListBox2.AccessibleName = ""
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.ItemHeight = 16
        Me.ListBox2.Location = New System.Drawing.Point(15, 39)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(216, 420)
        Me.ListBox2.TabIndex = 3
        '
        'pnlTotalSiswa
        '
        Me.pnlTotalSiswa.BackColor = System.Drawing.Color.Sienna
        Me.pnlTotalSiswa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlTotalSiswa.Controls.Add(Me.lblTotalSiswa)
        Me.pnlTotalSiswa.Controls.Add(Me.lblTitleTotalSiswa)
        Me.pnlTotalSiswa.Location = New System.Drawing.Point(21, 51)
        Me.pnlTotalSiswa.Name = "pnlTotalSiswa"
        Me.pnlTotalSiswa.Size = New System.Drawing.Size(253, 146)
        Me.pnlTotalSiswa.TabIndex = 10
        '
        'lblTotalSiswa
        '
        Me.lblTotalSiswa.AutoSize = True
        Me.lblTotalSiswa.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalSiswa.ForeColor = System.Drawing.Color.White
        Me.lblTotalSiswa.Location = New System.Drawing.Point(12, 76)
        Me.lblTotalSiswa.Name = "lblTotalSiswa"
        Me.lblTotalSiswa.Size = New System.Drawing.Size(43, 46)
        Me.lblTotalSiswa.TabIndex = 1
        Me.lblTotalSiswa.Text = "0"
        '
        'lblTitleTotalSiswa
        '
        Me.lblTitleTotalSiswa.AutoSize = True
        Me.lblTitleTotalSiswa.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleTotalSiswa.ForeColor = System.Drawing.Color.White
        Me.lblTitleTotalSiswa.Location = New System.Drawing.Point(3, 15)
        Me.lblTitleTotalSiswa.Name = "lblTitleTotalSiswa"
        Me.lblTitleTotalSiswa.Size = New System.Drawing.Size(238, 46)
        Me.lblTitleTotalSiswa.TabIndex = 0
        Me.lblTitleTotalSiswa.Text = "Total Siswa"
        '
        'pnlTotalGuru
        '
        Me.pnlTotalGuru.BackColor = System.Drawing.SystemColors.Highlight
        Me.pnlTotalGuru.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlTotalGuru.Controls.Add(Me.lblTotalGuru)
        Me.pnlTotalGuru.Controls.Add(Me.lblTitleTotalGuru)
        Me.pnlTotalGuru.Location = New System.Drawing.Point(280, 51)
        Me.pnlTotalGuru.Name = "pnlTotalGuru"
        Me.pnlTotalGuru.Size = New System.Drawing.Size(253, 146)
        Me.pnlTotalGuru.TabIndex = 11
        '
        'lblTotalGuru
        '
        Me.lblTotalGuru.AutoSize = True
        Me.lblTotalGuru.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalGuru.ForeColor = System.Drawing.Color.White
        Me.lblTotalGuru.Location = New System.Drawing.Point(16, 76)
        Me.lblTotalGuru.Name = "lblTotalGuru"
        Me.lblTotalGuru.Size = New System.Drawing.Size(43, 46)
        Me.lblTotalGuru.TabIndex = 2
        Me.lblTotalGuru.Text = "0"
        '
        'lblTitleTotalGuru
        '
        Me.lblTitleTotalGuru.AutoSize = True
        Me.lblTitleTotalGuru.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleTotalGuru.ForeColor = System.Drawing.Color.White
        Me.lblTitleTotalGuru.Location = New System.Drawing.Point(16, 15)
        Me.lblTitleTotalGuru.Name = "lblTitleTotalGuru"
        Me.lblTitleTotalGuru.Size = New System.Drawing.Size(218, 46)
        Me.lblTitleTotalGuru.TabIndex = 1
        Me.lblTitleTotalGuru.Text = "Total Guru"
        '
        'pnlTotalKelas
        '
        Me.pnlTotalKelas.BackColor = System.Drawing.SystemColors.HotTrack
        Me.pnlTotalKelas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlTotalKelas.Controls.Add(Me.lblTotalKelas)
        Me.pnlTotalKelas.Controls.Add(Me.lblTitleTotalKelas)
        Me.pnlTotalKelas.Location = New System.Drawing.Point(539, 51)
        Me.pnlTotalKelas.Name = "pnlTotalKelas"
        Me.pnlTotalKelas.Size = New System.Drawing.Size(265, 146)
        Me.pnlTotalKelas.TabIndex = 12
        '
        'lblTotalKelas
        '
        Me.lblTotalKelas.AutoSize = True
        Me.lblTotalKelas.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalKelas.ForeColor = System.Drawing.Color.White
        Me.lblTotalKelas.Location = New System.Drawing.Point(21, 85)
        Me.lblTotalKelas.Name = "lblTotalKelas"
        Me.lblTotalKelas.Size = New System.Drawing.Size(43, 46)
        Me.lblTotalKelas.TabIndex = 3
        Me.lblTotalKelas.Text = "0"
        '
        'lblTitleTotalKelas
        '
        Me.lblTitleTotalKelas.AutoSize = True
        Me.lblTitleTotalKelas.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleTotalKelas.ForeColor = System.Drawing.Color.White
        Me.lblTitleTotalKelas.Location = New System.Drawing.Point(20, 27)
        Me.lblTitleTotalKelas.Name = "lblTitleTotalKelas"
        Me.lblTitleTotalKelas.Size = New System.Drawing.Size(230, 46)
        Me.lblTitleTotalKelas.TabIndex = 2
        Me.lblTitleTotalKelas.Text = "Total Kelas"
        '
        'pnlChart
        '
        Me.pnlChart.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnlChart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlChart.Controls.Add(Me.lblJudulChart)
        Me.pnlChart.Controls.Add(Me.chartSiswaKelas)
        Me.pnlChart.Location = New System.Drawing.Point(21, 214)
        Me.pnlChart.Name = "pnlChart"
        Me.pnlChart.Size = New System.Drawing.Size(517, 316)
        Me.pnlChart.TabIndex = 13
        '
        'lblJudulChart
        '
        Me.lblJudulChart.AutoSize = True
        Me.lblJudulChart.Location = New System.Drawing.Point(39, 14)
        Me.lblJudulChart.Name = "lblJudulChart"
        Me.lblJudulChart.Size = New System.Drawing.Size(149, 16)
        Me.lblJudulChart.TabIndex = 5
        Me.lblJudulChart.Text = "Jumlah Siswa per Kelas"
        '
        'chartSiswaKelas
        '
        ChartArea5.Name = "ChartArea1"
        Me.chartSiswaKelas.ChartAreas.Add(ChartArea5)
        Legend5.Name = "Legend1"
        Me.chartSiswaKelas.Legends.Add(Legend5)
        Me.chartSiswaKelas.Location = New System.Drawing.Point(39, 36)
        Me.chartSiswaKelas.Name = "chartSiswaKelas"
        Series5.ChartArea = "ChartArea1"
        Series5.Legend = "Legend1"
        Series5.Name = "Series1"
        Me.chartSiswaKelas.Series.Add(Series5)
        Me.chartSiswaKelas.Size = New System.Drawing.Size(472, 275)
        Me.chartSiswaKelas.TabIndex = 4
        Me.chartSiswaKelas.Text = "Chart1"
        '
        'pnlAktivitas
        '
        Me.pnlAktivitas.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnlAktivitas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlAktivitas.Controls.Add(Me.lblJudulAktivitas)
        Me.pnlAktivitas.Controls.Add(Me.lstAktivitas)
        Me.pnlAktivitas.Location = New System.Drawing.Point(544, 214)
        Me.pnlAktivitas.Name = "pnlAktivitas"
        Me.pnlAktivitas.Size = New System.Drawing.Size(265, 316)
        Me.pnlAktivitas.TabIndex = 14
        '
        'lblJudulAktivitas
        '
        Me.lblJudulAktivitas.AutoSize = True
        Me.lblJudulAktivitas.Location = New System.Drawing.Point(12, 14)
        Me.lblJudulAktivitas.Name = "lblJudulAktivitas"
        Me.lblJudulAktivitas.Size = New System.Drawing.Size(108, 16)
        Me.lblJudulAktivitas.TabIndex = 6
        Me.lblJudulAktivitas.Text = "Aktivitas Terbaru"
        '
        'lstAktivitas
        '
        Me.lstAktivitas.AccessibleName = ""
        Me.lstAktivitas.FormattingEnabled = True
        Me.lstAktivitas.ItemHeight = 16
        Me.lstAktivitas.Location = New System.Drawing.Point(15, 36)
        Me.lstAktivitas.Name = "lstAktivitas"
        Me.lstAktivitas.Size = New System.Drawing.Size(234, 244)
        Me.lstAktivitas.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(247, -33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(157, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "DASHBOARD"
        '
        'btnDataSiswa
        '
        Me.btnDataSiswa.BackColor = System.Drawing.Color.SaddleBrown
        Me.btnDataSiswa.ForeColor = System.Drawing.Color.White
        Me.btnDataSiswa.Location = New System.Drawing.Point(10, 84)
        Me.btnDataSiswa.Name = "btnDataSiswa"
        Me.btnDataSiswa.Size = New System.Drawing.Size(225, 61)
        Me.btnDataSiswa.TabIndex = 0
        Me.btnDataSiswa.Text = "Data Siswa"
        Me.btnDataSiswa.UseVisualStyleBackColor = False
        '
        'btnManajemenPelajaran
        '
        Me.btnManajemenPelajaran.BackColor = System.Drawing.Color.SaddleBrown
        Me.btnManajemenPelajaran.ForeColor = System.Drawing.Color.White
        Me.btnManajemenPelajaran.Location = New System.Drawing.Point(12, 343)
        Me.btnManajemenPelajaran.Name = "btnManajemenPelajaran"
        Me.btnManajemenPelajaran.Size = New System.Drawing.Size(223, 49)
        Me.btnManajemenPelajaran.TabIndex = 4
        Me.btnManajemenPelajaran.Text = "Manajemen Pelajaran"
        Me.btnManajemenPelajaran.UseVisualStyleBackColor = False
        '
        'btnDataGuru
        '
        Me.btnDataGuru.BackColor = System.Drawing.Color.SaddleBrown
        Me.btnDataGuru.ForeColor = System.Drawing.Color.White
        Me.btnDataGuru.Location = New System.Drawing.Point(10, 151)
        Me.btnDataGuru.Name = "btnDataGuru"
        Me.btnDataGuru.Size = New System.Drawing.Size(225, 56)
        Me.btnDataGuru.TabIndex = 1
        Me.btnDataGuru.Text = "Data Guru"
        Me.btnDataGuru.UseVisualStyleBackColor = False
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.SaddleBrown
        Me.btnLogout.ForeColor = System.Drawing.Color.White
        Me.btnLogout.Location = New System.Drawing.Point(3, 578)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(249, 45)
        Me.btnLogout.TabIndex = 5
        Me.btnLogout.Text = "Keluar"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'btnMataPelajaran
        '
        Me.btnMataPelajaran.BackColor = System.Drawing.Color.SaddleBrown
        Me.btnMataPelajaran.ForeColor = System.Drawing.Color.White
        Me.btnMataPelajaran.Location = New System.Drawing.Point(12, 282)
        Me.btnMataPelajaran.Name = "btnMataPelajaran"
        Me.btnMataPelajaran.Size = New System.Drawing.Size(223, 55)
        Me.btnMataPelajaran.TabIndex = 3
        Me.btnMataPelajaran.Text = "Mata Pelajaran"
        Me.btnMataPelajaran.UseVisualStyleBackColor = False
        '
        'btnDataKelas
        '
        Me.btnDataKelas.BackColor = System.Drawing.Color.SaddleBrown
        Me.btnDataKelas.ForeColor = System.Drawing.Color.White
        Me.btnDataKelas.Location = New System.Drawing.Point(12, 223)
        Me.btnDataKelas.Name = "btnDataKelas"
        Me.btnDataKelas.Size = New System.Drawing.Size(223, 53)
        Me.btnDataKelas.TabIndex = 2
        Me.btnDataKelas.Text = "Data Kelas"
        Me.btnDataKelas.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.SaddleBrown
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(12, 409)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(223, 49)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Laporan"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(12, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(234, 48)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Dasboard"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Sienna
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.btnDataKelas)
        Me.GroupBox1.Controls.Add(Me.btnMataPelajaran)
        Me.GroupBox1.Controls.Add(Me.btnLogout)
        Me.GroupBox1.Controls.Add(Me.btnDataGuru)
        Me.GroupBox1.Controls.Add(Me.btnManajemenPelajaran)
        Me.GroupBox1.Controls.Add(Me.btnDataSiswa)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(255, 655)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1333, 655)
        Me.Controls.Add(Me.PanelUtama)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FormMain"
        Me.Text = "MenuUtama"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.PanelUtama.ResumeLayout(False)
        Me.PanelUtama.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.pnlTotalSiswa.ResumeLayout(False)
        Me.pnlTotalSiswa.PerformLayout()
        Me.pnlTotalGuru.ResumeLayout(False)
        Me.pnlTotalGuru.PerformLayout()
        Me.pnlTotalKelas.ResumeLayout(False)
        Me.pnlTotalKelas.PerformLayout()
        Me.pnlChart.ResumeLayout(False)
        Me.pnlChart.PerformLayout()
        CType(Me.chartSiswaKelas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlAktivitas.ResumeLayout(False)
        Me.pnlAktivitas.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PanelUtama As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents pnlTotalSiswa As Panel
    Friend WithEvents lblTotalSiswa As Label
    Friend WithEvents lblTitleTotalSiswa As Label
    Friend WithEvents pnlTotalGuru As Panel
    Friend WithEvents lblTotalGuru As Label
    Friend WithEvents lblTitleTotalGuru As Label
    Friend WithEvents pnlTotalKelas As Panel
    Friend WithEvents lblTotalKelas As Label
    Friend WithEvents lblTitleTotalKelas As Label
    Friend WithEvents pnlChart As Panel
    Friend WithEvents lblJudulChart As Label
    Friend WithEvents chartSiswaKelas As DataVisualization.Charting.Chart
    Friend WithEvents pnlAktivitas As Panel
    Friend WithEvents lblJudulAktivitas As Label
    Friend WithEvents lstAktivitas As ListBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents btnDataKelas As Button
    Friend WithEvents btnMataPelajaran As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnDataGuru As Button
    Friend WithEvents btnManajemenPelajaran As Button
    Friend WithEvents btnDataSiswa As Button
End Class
