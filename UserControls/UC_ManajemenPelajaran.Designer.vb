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
        Me.cmbHariJadwal = New System.Windows.Forms.ComboBox()
        Me.dtpJamSelesai = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtpJamMulai = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbGuruJadwal = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbMapelJadwal = New System.Windows.Forms.ComboBox()
        Me.Mapel = New System.Windows.Forms.Label()
        Me.cmbKelasJadwal = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.btnUbah = New System.Windows.Forms.Button()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.dgvJadwal = New System.Windows.Forms.DataGridView()
        Me.lblJudulUC = New System.Windows.Forms.Label()
        Me.cmbFilterKelas = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvJadwal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSimpan
        '
        Me.btnSimpan.BackColor = System.Drawing.Color.SaddleBrown
        Me.btnSimpan.ForeColor = System.Drawing.Color.White
        Me.btnSimpan.Location = New System.Drawing.Point(898, 493)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(89, 35)
        Me.btnSimpan.TabIndex = 6
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.SaddleBrown
        Me.GroupBox1.Controls.Add(Me.cmbHariJadwal)
        Me.GroupBox1.Controls.Add(Me.dtpJamSelesai)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.dtpJamMulai)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cmbGuruJadwal)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cmbMapelJadwal)
        Me.GroupBox1.Controls.Add(Me.Mapel)
        Me.GroupBox1.Controls.Add(Me.cmbKelasJadwal)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.btnHapus)
        Me.GroupBox1.Controls.Add(Me.btnBatal)
        Me.GroupBox1.Controls.Add(Me.btnUbah)
        Me.GroupBox1.Controls.Add(Me.btnTambah)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 91)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(256, 396)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        '
        'cmbHariJadwal
        '
        Me.cmbHariJadwal.FormattingEnabled = True
        Me.cmbHariJadwal.Items.AddRange(New Object() {"Senin", "Selasa", "Rabu", "Kamis", "Juma't"})
        Me.cmbHariJadwal.Location = New System.Drawing.Point(91, 155)
        Me.cmbHariJadwal.Name = "cmbHariJadwal"
        Me.cmbHariJadwal.Size = New System.Drawing.Size(100, 24)
        Me.cmbHariJadwal.TabIndex = 25
        '
        'dtpJamSelesai
        '
        Me.dtpJamSelesai.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpJamSelesai.Location = New System.Drawing.Point(109, 213)
        Me.dtpJamSelesai.Name = "dtpJamSelesai"
        Me.dtpJamSelesai.ShowUpDown = True
        Me.dtpJamSelesai.Size = New System.Drawing.Size(96, 22)
        Me.dtpJamSelesai.TabIndex = 24
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
        'dtpJamMulai
        '
        Me.dtpJamMulai.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpJamMulai.Location = New System.Drawing.Point(109, 188)
        Me.dtpJamMulai.Name = "dtpJamMulai"
        Me.dtpJamMulai.ShowUpDown = True
        Me.dtpJamMulai.Size = New System.Drawing.Size(96, 22)
        Me.dtpJamMulai.TabIndex = 22
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
        'cmbGuruJadwal
        '
        Me.cmbGuruJadwal.FormattingEnabled = True
        Me.cmbGuruJadwal.Location = New System.Drawing.Point(91, 116)
        Me.cmbGuruJadwal.Name = "cmbGuruJadwal"
        Me.cmbGuruJadwal.Size = New System.Drawing.Size(100, 24)
        Me.cmbGuruJadwal.TabIndex = 19
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
        'cmbMapelJadwal
        '
        Me.cmbMapelJadwal.FormattingEnabled = True
        Me.cmbMapelJadwal.Location = New System.Drawing.Point(91, 76)
        Me.cmbMapelJadwal.Name = "cmbMapelJadwal"
        Me.cmbMapelJadwal.Size = New System.Drawing.Size(100, 24)
        Me.cmbMapelJadwal.TabIndex = 16
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
        'cmbKelasJadwal
        '
        Me.cmbKelasJadwal.FormattingEnabled = True
        Me.cmbKelasJadwal.Location = New System.Drawing.Point(91, 33)
        Me.cmbKelasJadwal.Name = "cmbKelasJadwal"
        Me.cmbKelasJadwal.Size = New System.Drawing.Size(100, 24)
        Me.cmbKelasJadwal.TabIndex = 13
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
        Me.btnHapus.Location = New System.Drawing.Point(48, 319)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(75, 41)
        Me.btnHapus.TabIndex = 3
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'btnBatal
        '
        Me.btnBatal.Location = New System.Drawing.Point(130, 319)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(75, 41)
        Me.btnBatal.TabIndex = 2
        Me.btnBatal.Text = "Batal"
        Me.btnBatal.UseVisualStyleBackColor = True
        '
        'btnUbah
        '
        Me.btnUbah.Location = New System.Drawing.Point(129, 253)
        Me.btnUbah.Name = "btnUbah"
        Me.btnUbah.Size = New System.Drawing.Size(76, 48)
        Me.btnUbah.TabIndex = 1
        Me.btnUbah.Text = "Ubah"
        Me.btnUbah.UseVisualStyleBackColor = True
        '
        'btnTambah
        '
        Me.btnTambah.Location = New System.Drawing.Point(50, 253)
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
        Me.dgvJadwal.Size = New System.Drawing.Size(948, 396)
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
        Me.cmbFilterKelas.Location = New System.Drawing.Point(933, 47)
        Me.cmbFilterKelas.Name = "cmbFilterKelas"
        Me.cmbFilterKelas.Size = New System.Drawing.Size(100, 24)
        Me.cmbFilterKelas.TabIndex = 23
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(848, 55)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 16)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Kelas"
        '
        'UC_ManajemenPelajaran
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Peru
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmbFilterKelas)
        Me.Controls.Add(Me.lblJudulUC)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgvJadwal)
        Me.Name = "UC_ManajemenPelajaran"
        Me.Size = New System.Drawing.Size(1241, 541)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvJadwal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSimpan As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmbKelasJadwal As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents btnUbah As Button
    Friend WithEvents btnTambah As Button
    Friend WithEvents dgvJadwal As DataGridView
    Friend WithEvents lblJudulUC As Label
    Friend WithEvents Mapel As Label
    Friend WithEvents cmbMapelJadwal As ComboBox
    Friend WithEvents cmbGuruJadwal As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dtpJamMulai As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbFilterKelas As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents dtpJamSelesai As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents cmbHariJadwal As ComboBox
End Class
