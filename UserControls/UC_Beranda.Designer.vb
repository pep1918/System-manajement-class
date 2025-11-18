<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_Beranda
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.lblTitleTotalSiswa = New System.Windows.Forms.Label()
        Me.lblTitleTotalGuru = New System.Windows.Forms.Label()
        Me.lblTitleTotalKelas = New System.Windows.Forms.Label()
        Me.lstAktivitas = New System.Windows.Forms.ListBox()
        Me.chartSiswaKelas = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.pnlTotalSiswa = New System.Windows.Forms.Panel()
        Me.pnlTotalGuru = New System.Windows.Forms.Panel()
        Me.pnlTotalKelas = New System.Windows.Forms.Panel()
        Me.lblTotalSiswa = New System.Windows.Forms.Label()
        Me.lblTotalGuru = New System.Windows.Forms.Label()
        Me.lblTotalKelas = New System.Windows.Forms.Label()
        Me.pnlChart = New System.Windows.Forms.Panel()
        Me.lblJudulChart = New System.Windows.Forms.Label()
        Me.pnlAktivitas = New System.Windows.Forms.Panel()
        Me.lblJudulAktivitas = New System.Windows.Forms.Label()
        CType(Me.chartSiswaKelas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTotalSiswa.SuspendLayout()
        Me.pnlTotalGuru.SuspendLayout()
        Me.pnlTotalKelas.SuspendLayout()
        Me.pnlChart.SuspendLayout()
        Me.pnlAktivitas.SuspendLayout()
        Me.SuspendLayout()
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
        'lstAktivitas
        '
        Me.lstAktivitas.AccessibleName = "lstAktivitas"
        Me.lstAktivitas.FormattingEnabled = True
        Me.lstAktivitas.ItemHeight = 16
        Me.lstAktivitas.Location = New System.Drawing.Point(15, 55)
        Me.lstAktivitas.Name = "lstAktivitas"
        Me.lstAktivitas.Size = New System.Drawing.Size(299, 228)
        Me.lstAktivitas.TabIndex = 3
        '
        'chartSiswaKelas
        '
        ChartArea1.Name = "ChartArea1"
        Me.chartSiswaKelas.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.chartSiswaKelas.Legends.Add(Legend1)
        Me.chartSiswaKelas.Location = New System.Drawing.Point(39, 36)
        Me.chartSiswaKelas.Name = "chartSiswaKelas"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.chartSiswaKelas.Series.Add(Series1)
        Me.chartSiswaKelas.Size = New System.Drawing.Size(453, 246)
        Me.chartSiswaKelas.TabIndex = 4
        Me.chartSiswaKelas.Text = "Chart1"
        '
        'pnlTotalSiswa
        '
        Me.pnlTotalSiswa.BackColor = System.Drawing.Color.Sienna
        Me.pnlTotalSiswa.Controls.Add(Me.lblTotalSiswa)
        Me.pnlTotalSiswa.Controls.Add(Me.lblTitleTotalSiswa)
        Me.pnlTotalSiswa.Location = New System.Drawing.Point(53, 60)
        Me.pnlTotalSiswa.Name = "pnlTotalSiswa"
        Me.pnlTotalSiswa.Size = New System.Drawing.Size(253, 146)
        Me.pnlTotalSiswa.TabIndex = 5
        '
        'pnlTotalGuru
        '
        Me.pnlTotalGuru.BackColor = System.Drawing.SystemColors.Highlight
        Me.pnlTotalGuru.Controls.Add(Me.lblTotalGuru)
        Me.pnlTotalGuru.Controls.Add(Me.lblTitleTotalGuru)
        Me.pnlTotalGuru.Location = New System.Drawing.Point(312, 60)
        Me.pnlTotalGuru.Name = "pnlTotalGuru"
        Me.pnlTotalGuru.Size = New System.Drawing.Size(253, 146)
        Me.pnlTotalGuru.TabIndex = 6
        '
        'pnlTotalKelas
        '
        Me.pnlTotalKelas.BackColor = System.Drawing.SystemColors.HotTrack
        Me.pnlTotalKelas.Controls.Add(Me.lblTotalKelas)
        Me.pnlTotalKelas.Controls.Add(Me.lblTitleTotalKelas)
        Me.pnlTotalKelas.Location = New System.Drawing.Point(586, 60)
        Me.pnlTotalKelas.Name = "pnlTotalKelas"
        Me.pnlTotalKelas.Size = New System.Drawing.Size(253, 146)
        Me.pnlTotalKelas.TabIndex = 7
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
        'pnlChart
        '
        Me.pnlChart.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnlChart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlChart.Controls.Add(Me.lblJudulChart)
        Me.pnlChart.Controls.Add(Me.chartSiswaKelas)
        Me.pnlChart.Location = New System.Drawing.Point(53, 223)
        Me.pnlChart.Name = "pnlChart"
        Me.pnlChart.Size = New System.Drawing.Size(512, 298)
        Me.pnlChart.TabIndex = 8
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
        'pnlAktivitas
        '
        Me.pnlAktivitas.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnlAktivitas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlAktivitas.Controls.Add(Me.lblJudulAktivitas)
        Me.pnlAktivitas.Controls.Add(Me.lstAktivitas)
        Me.pnlAktivitas.Location = New System.Drawing.Point(586, 223)
        Me.pnlAktivitas.Name = "pnlAktivitas"
        Me.pnlAktivitas.Size = New System.Drawing.Size(341, 298)
        Me.pnlAktivitas.TabIndex = 9
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
        'UC_Beranda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Controls.Add(Me.pnlAktivitas)
        Me.Controls.Add(Me.pnlChart)
        Me.Controls.Add(Me.pnlTotalKelas)
        Me.Controls.Add(Me.pnlTotalGuru)
        Me.Controls.Add(Me.pnlTotalSiswa)
        Me.Name = "UC_Beranda"
        Me.Size = New System.Drawing.Size(1241, 541)
        CType(Me.chartSiswaKelas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTotalSiswa.ResumeLayout(False)
        Me.pnlTotalSiswa.PerformLayout()
        Me.pnlTotalGuru.ResumeLayout(False)
        Me.pnlTotalGuru.PerformLayout()
        Me.pnlTotalKelas.ResumeLayout(False)
        Me.pnlTotalKelas.PerformLayout()
        Me.pnlChart.ResumeLayout(False)
        Me.pnlChart.PerformLayout()
        Me.pnlAktivitas.ResumeLayout(False)
        Me.pnlAktivitas.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblTitleTotalSiswa As Label
    Friend WithEvents lblTitleTotalGuru As Label
    Friend WithEvents lblTitleTotalKelas As Label
    Friend WithEvents lstAktivitas As ListBox
    Friend WithEvents chartSiswaKelas As DataVisualization.Charting.Chart
    Friend WithEvents pnlTotalSiswa As Panel
    Friend WithEvents pnlTotalGuru As Panel
    Friend WithEvents pnlTotalKelas As Panel
    Friend WithEvents lblTotalSiswa As Label
    Friend WithEvents lblTotalGuru As Label
    Friend WithEvents lblTotalKelas As Label
    Friend WithEvents pnlChart As Panel
    Friend WithEvents lblJudulChart As Label
    Friend WithEvents pnlAktivitas As Panel
    Friend WithEvents lblJudulAktivitas As Label
End Class
