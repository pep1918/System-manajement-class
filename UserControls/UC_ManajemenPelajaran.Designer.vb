<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_ManajemenPelajaran
    Inherits System.Windows.Forms.UserControl

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
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmbHari = New System.Windows.Forms.ComboBox()
        Me.txtTahunAjaran = New System.Windows.Forms.TextBox()
        Me.dtpSelesai = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtpMulai = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbGuru = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbMapel = New System.Windows.Forms.ComboBox()
        Me.Mapel = New System.Windows.Forms.Label()
        Me.cmbKelas = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.btnUbah = New System.Windows.Forms.Button()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.dgvJadwal = New System.Windows.Forms.DataGridView()
        Me.lblJudulUC = New System.Windows.Forms.Label()
        Me.cmbFilterKelas = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnExportPDF = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvJadwal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSimpan
        '
        Me.btnSimpan.BackColor = System.Drawing.Color.SaddleBrown
        Me.btnSimpan.ForeColor = System.Drawing.Color.White
        Me.btnSimpan.Location = New System.Drawing.Point(1020, 603)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(89, 35)
        Me.btnSimpan.TabIndex = 6
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.SaddleBrown
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.cmbHari)
        Me.GroupBox1.Controls.Add(Me.txtTahunAjaran)
        Me.GroupBox1.Controls.Add(Me.dtpSelesai)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.dtpMulai)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cmbGuru)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cmbMapel)
        Me.GroupBox1.Controls.Add(Me.Mapel)
        Me.GroupBox1.Controls.Add(Me.cmbKelas)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.btnHapus)
        Me.GroupBox1.Controls.Add(Me.btnBatal)
        Me.GroupBox1.Controls.Add(Me.btnUbah)
        Me.GroupBox1.Controls.Add(Me.btnTambah)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 91)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(256, 516)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(25, 260)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(87, 16)
        Me.Label9.TabIndex = 34
        Me.Label9.Text = "Tahun Ajaran"
        '
        'cmbHari
        '
        Me.cmbHari.FormattingEnabled = True
        Me.cmbHari.Items.AddRange(New Object() {"Senin", "Selasa", "Rabu", "Kamis", "Juma't"})
        Me.cmbHari.Location = New System.Drawing.Point(105, 155)
        Me.cmbHari.Name = "cmbHari"
        Me.cmbHari.Size = New System.Drawing.Size(100, 24)
        Me.cmbHari.TabIndex = 25
        '
        'txtTahunAjaran
        '
        Me.txtTahunAjaran.Location = New System.Drawing.Point(109, 257)
        Me.txtTahunAjaran.Name = "txtTahunAjaran"
        Me.txtTahunAjaran.Size = New System.Drawing.Size(100, 22)
        Me.txtTahunAjaran.TabIndex = 30
        '
        'dtpSelesai
        '
        Me.dtpSelesai.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpSelesai.Location = New System.Drawing.Point(109, 213)
        Me.dtpSelesai.Name = "dtpSelesai"
        Me.dtpSelesai.ShowUpDown = True
        Me.dtpSelesai.Size = New System.Drawing.Size(96, 22)
        Me.dtpSelesai.TabIndex = 24
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(30, 218)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 16)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Jam Selesai"
        '
        'dtpMulai
        '
        Me.dtpMulai.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpMulai.Location = New System.Drawing.Point(109, 188)
        Me.dtpMulai.Name = "dtpMulai"
        Me.dtpMulai.ShowUpDown = True
        Me.dtpMulai.Size = New System.Drawing.Size(96, 22)
        Me.dtpMulai.TabIndex = 22
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(30, 193)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 16)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Jam Mulai"
        '
        'cmbGuru
        '
        Me.cmbGuru.FormattingEnabled = True
        Me.cmbGuru.Location = New System.Drawing.Point(91, 116)
        Me.cmbGuru.Name = "cmbGuru"
        Me.cmbGuru.Size = New System.Drawing.Size(100, 24)
        Me.cmbGuru.TabIndex = 19
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(30, 163)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 16)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Hari"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(30, 120)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 16)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Guru "
        '
        'cmbMapel
        '
        Me.cmbMapel.FormattingEnabled = True
        Me.cmbMapel.Location = New System.Drawing.Point(105, 76)
        Me.cmbMapel.Name = "cmbMapel"
        Me.cmbMapel.Size = New System.Drawing.Size(100, 24)
        Me.cmbMapel.TabIndex = 16
        '
        'Mapel
        '
        Me.Mapel.AutoSize = True
        Me.Mapel.ForeColor = System.Drawing.Color.White
        Me.Mapel.Location = New System.Drawing.Point(30, 84)
        Me.Mapel.Name = "Mapel"
        Me.Mapel.Size = New System.Drawing.Size(45, 16)
        Me.Mapel.TabIndex = 15
        Me.Mapel.Text = "Mapel"
        '
        'cmbKelas
        '
        Me.cmbKelas.FormattingEnabled = True
        Me.cmbKelas.Location = New System.Drawing.Point(105, 33)
        Me.cmbKelas.Name = "cmbKelas"
        Me.cmbKelas.Size = New System.Drawing.Size(100, 24)
        Me.cmbKelas.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(30, 36)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 16)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Kelas"
        '
        'btnHapus
        '
        Me.btnHapus.Location = New System.Drawing.Point(48, 452)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(75, 41)
        Me.btnHapus.TabIndex = 3
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'btnBatal
        '
        Me.btnBatal.Location = New System.Drawing.Point(130, 452)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(75, 41)
        Me.btnBatal.TabIndex = 2
        Me.btnBatal.Text = "Batal"
        Me.btnBatal.UseVisualStyleBackColor = True
        '
        'btnUbah
        '
        Me.btnUbah.Location = New System.Drawing.Point(129, 386)
        Me.btnUbah.Name = "btnUbah"
        Me.btnUbah.Size = New System.Drawing.Size(76, 48)
        Me.btnUbah.TabIndex = 1
        Me.btnUbah.Text = "Ubah"
        Me.btnUbah.UseVisualStyleBackColor = True
        '
        'btnTambah
        '
        Me.btnTambah.Location = New System.Drawing.Point(50, 386)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(73, 48)
        Me.btnTambah.TabIndex = 0
        Me.btnTambah.Text = "Tambah"
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'dgvJadwal
        '
        Me.dgvJadwal.BackgroundColor = System.Drawing.Color.SaddleBrown
        Me.dgvJadwal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvJadwal.Location = New System.Drawing.Point(274, 91)
        Me.dgvJadwal.Name = "dgvJadwal"
        Me.dgvJadwal.RowHeadersWidth = 51
        Me.dgvJadwal.RowTemplate.Height = 24
        Me.dgvJadwal.Size = New System.Drawing.Size(948, 506)
        Me.dgvJadwal.TabIndex = 4
        '
        'lblJudulUC
        '
        Me.lblJudulUC.AutoSize = True
        Me.lblJudulUC.BackColor = System.Drawing.Color.Transparent
        Me.lblJudulUC.Font = New System.Drawing.Font("Verdana", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJudulUC.ForeColor = System.Drawing.Color.Transparent
        Me.lblJudulUC.Location = New System.Drawing.Point(4, 23)
        Me.lblJudulUC.Name = "lblJudulUC"
        Me.lblJudulUC.Size = New System.Drawing.Size(512, 48)
        Me.lblJudulUC.TabIndex = 9
        Me.lblJudulUC.Text = "Manajemen Pelajaran"
        '
        'cmbFilterKelas
        '
        Me.cmbFilterKelas.FormattingEnabled = True
        Me.cmbFilterKelas.Location = New System.Drawing.Point(795, 61)
        Me.cmbFilterKelas.Name = "cmbFilterKelas"
        Me.cmbFilterKelas.Size = New System.Drawing.Size(192, 24)
        Me.cmbFilterKelas.TabIndex = 23
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(748, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 16)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Kelas"
        '
        'btnExportPDF
        '
        Me.btnExportPDF.BackColor = System.Drawing.Color.SaddleBrown
        Me.btnExportPDF.ForeColor = System.Drawing.Color.White
        Me.btnExportPDF.Location = New System.Drawing.Point(1133, 603)
        Me.btnExportPDF.Name = "btnExportPDF"
        Me.btnExportPDF.Size = New System.Drawing.Size(89, 35)
        Me.btnExportPDF.TabIndex = 32
        Me.btnExportPDF.Text = "Print"
        Me.btnExportPDF.UseVisualStyleBackColor = False
        '
        'UC_ManajemenPelajaran
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Controls.Add(Me.btnExportPDF)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmbFilterKelas)
        Me.Controls.Add(Me.lblJudulUC)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgvJadwal)
        Me.Name = "UC_ManajemenPelajaran"
        Me.Size = New System.Drawing.Size(1241, 685)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvJadwal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSimpan As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmbKelas As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents btnUbah As Button
    Friend WithEvents btnTambah As Button
    Friend WithEvents dgvJadwal As DataGridView
    Friend WithEvents lblJudulUC As Label
    Friend WithEvents Mapel As Label
    Friend WithEvents cmbMapel As ComboBox
    Friend WithEvents cmbGuru As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dtpMulai As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbFilterKelas As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents dtpSelesai As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents cmbHari As ComboBox
    Friend WithEvents txtTahunAjaran As TextBox
    Friend WithEvents btnExportPDF As Button
    Friend WithEvents Label9 As Label
End Class
