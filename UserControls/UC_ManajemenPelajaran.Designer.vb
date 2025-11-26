<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_ManajemenPelajaran
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
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbFilterKelas = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmbHari = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbKelas = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Cari = New System.Windows.Forms.Label()
        Me.lbjudul = New System.Windows.Forms.Label()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.btnCetak = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbMapel = New System.Windows.Forms.ComboBox()
        Me.dtpSelesai = New System.Windows.Forms.DateTimePicker()
        Me.cmbGuru = New System.Windows.Forms.ComboBox()
        Me.dtpMulai = New System.Windows.Forms.DateTimePicker()
        Me.btnUbah = New System.Windows.Forms.Button()
        Me.dgvJadwal = New System.Windows.Forms.DataGridView()
        Me.cmbFilterHari = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvJadwal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Label7.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(1171, 48)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(104, 20)
        Me.Label7.TabIndex = 35
        Me.Label7.Text = "Filter Kelas"
        '
        'cmbFilterKelas
        '
        Me.cmbFilterKelas.FormattingEnabled = True
        Me.cmbFilterKelas.Location = New System.Drawing.Point(1281, 44)
        Me.cmbFilterKelas.Name = "cmbFilterKelas"
        Me.cmbFilterKelas.Size = New System.Drawing.Size(145, 24)
        Me.cmbFilterKelas.TabIndex = 33
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(21, 236)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(89, 18)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Jam Mulai"
        '
        'cmbHari
        '
        Me.cmbHari.FormattingEnabled = True
        Me.cmbHari.Location = New System.Drawing.Point(139, 97)
        Me.cmbHari.Name = "cmbHari"
        Me.cmbHari.Size = New System.Drawing.Size(189, 24)
        Me.cmbHari.TabIndex = 19
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(21, 193)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 18)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Mapel"
        '
        'cmbKelas
        '
        Me.cmbKelas.FormattingEnabled = True
        Me.cmbKelas.Location = New System.Drawing.Point(139, 52)
        Me.cmbKelas.Name = "cmbKelas"
        Me.cmbKelas.Size = New System.Drawing.Size(189, 24)
        Me.cmbKelas.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(21, 148)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 18)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Guru"
        '
        'Cari
        '
        Me.Cari.AutoSize = True
        Me.Cari.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Cari.Location = New System.Drawing.Point(912, 52)
        Me.Cari.Name = "Cari"
        Me.Cari.Size = New System.Drawing.Size(64, 16)
        Me.Cari.TabIndex = 32
        Me.Cari.Text = "Filter Hari"
        '
        'lbjudul
        '
        Me.lbjudul.AutoSize = True
        Me.lbjudul.BackColor = System.Drawing.Color.Transparent
        Me.lbjudul.Font = New System.Drawing.Font("Verdana", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbjudul.ForeColor = System.Drawing.Color.White
        Me.lbjudul.Location = New System.Drawing.Point(37, 25)
        Me.lbjudul.Name = "lbjudul"
        Me.lbjudul.Size = New System.Drawing.Size(360, 48)
        Me.lbjudul.TabIndex = 30
        Me.lbjudul.Text = "Mata Pelajaran"
        '
        'btnSimpan
        '
        Me.btnSimpan.BackColor = System.Drawing.Color.SaddleBrown
        Me.btnSimpan.ForeColor = System.Drawing.Color.White
        Me.btnSimpan.Location = New System.Drawing.Point(1201, 600)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(99, 45)
        Me.btnSimpan.TabIndex = 29
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(21, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 18)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Hari"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(21, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 18)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Kelas"
        '
        'btnHapus
        '
        Me.btnHapus.Location = New System.Drawing.Point(68, 419)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(119, 45)
        Me.btnHapus.TabIndex = 3
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'btnBatal
        '
        Me.btnBatal.Location = New System.Drawing.Point(209, 419)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(119, 45)
        Me.btnBatal.TabIndex = 2
        Me.btnBatal.Text = "Batal"
        Me.btnBatal.UseVisualStyleBackColor = True
        '
        'btnTambah
        '
        Me.btnTambah.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTambah.Location = New System.Drawing.Point(68, 358)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(119, 45)
        Me.btnTambah.TabIndex = 0
        Me.btnTambah.Text = "Tambah"
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'btnCetak
        '
        Me.btnCetak.BackColor = System.Drawing.Color.SaddleBrown
        Me.btnCetak.ForeColor = System.Drawing.Color.White
        Me.btnCetak.Location = New System.Drawing.Point(1306, 600)
        Me.btnCetak.Name = "btnCetak"
        Me.btnCetak.Size = New System.Drawing.Size(99, 45)
        Me.btnCetak.TabIndex = 34
        Me.btnCetak.Text = "Print"
        Me.btnCetak.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.SaddleBrown
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cmbMapel)
        Me.GroupBox1.Controls.Add(Me.dtpSelesai)
        Me.GroupBox1.Controls.Add(Me.cmbGuru)
        Me.GroupBox1.Controls.Add(Me.dtpMulai)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.cmbHari)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.cmbKelas)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnHapus)
        Me.GroupBox1.Controls.Add(Me.btnBatal)
        Me.GroupBox1.Controls.Add(Me.btnUbah)
        Me.GroupBox1.Controls.Add(Me.btnTambah)
        Me.GroupBox1.Location = New System.Drawing.Point(45, 85)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(346, 493)
        Me.GroupBox1.TabIndex = 28
        Me.GroupBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(21, 275)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 18)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "Jam Selesai"
        '
        'cmbMapel
        '
        Me.cmbMapel.FormattingEnabled = True
        Me.cmbMapel.Location = New System.Drawing.Point(139, 187)
        Me.cmbMapel.Name = "cmbMapel"
        Me.cmbMapel.Size = New System.Drawing.Size(189, 24)
        Me.cmbMapel.TabIndex = 24
        '
        'dtpSelesai
        '
        Me.dtpSelesai.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpSelesai.Location = New System.Drawing.Point(139, 232)
        Me.dtpSelesai.Name = "dtpSelesai"
        Me.dtpSelesai.Size = New System.Drawing.Size(189, 22)
        Me.dtpSelesai.TabIndex = 38
        '
        'cmbGuru
        '
        Me.cmbGuru.FormattingEnabled = True
        Me.cmbGuru.Location = New System.Drawing.Point(139, 142)
        Me.cmbGuru.Name = "cmbGuru"
        Me.cmbGuru.Size = New System.Drawing.Size(189, 24)
        Me.cmbGuru.TabIndex = 23
        '
        'dtpMulai
        '
        Me.dtpMulai.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpMulai.Location = New System.Drawing.Point(139, 275)
        Me.dtpMulai.Name = "dtpMulai"
        Me.dtpMulai.Size = New System.Drawing.Size(189, 22)
        Me.dtpMulai.TabIndex = 37
        '
        'btnUbah
        '
        Me.btnUbah.Location = New System.Drawing.Point(209, 358)
        Me.btnUbah.Name = "btnUbah"
        Me.btnUbah.Size = New System.Drawing.Size(119, 45)
        Me.btnUbah.TabIndex = 1
        Me.btnUbah.Text = "Ubah"
        Me.btnUbah.UseVisualStyleBackColor = True
        '
        'dgvJadwal
        '
        Me.dgvJadwal.BackgroundColor = System.Drawing.Color.SaddleBrown
        Me.dgvJadwal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvJadwal.Location = New System.Drawing.Point(409, 85)
        Me.dgvJadwal.Name = "dgvJadwal"
        Me.dgvJadwal.RowHeadersWidth = 51
        Me.dgvJadwal.RowTemplate.Height = 24
        Me.dgvJadwal.Size = New System.Drawing.Size(1017, 493)
        Me.dgvJadwal.TabIndex = 27
        '
        'cmbFilterHari
        '
        Me.cmbFilterHari.FormattingEnabled = True
        Me.cmbFilterHari.Location = New System.Drawing.Point(1003, 44)
        Me.cmbFilterHari.Name = "cmbFilterHari"
        Me.cmbFilterHari.Size = New System.Drawing.Size(147, 24)
        Me.cmbFilterHari.TabIndex = 39
        '
        'UC_ManajemenPelajaran
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Controls.Add(Me.cmbFilterHari)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cmbFilterKelas)
        Me.Controls.Add(Me.Cari)
        Me.Controls.Add(Me.lbjudul)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.btnCetak)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgvJadwal)
        Me.Name = "UC_ManajemenPelajaran"
        Me.Size = New System.Drawing.Size(1605, 693)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvJadwal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label7 As Label
    Friend WithEvents cmbFilterKelas As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents cmbHari As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cmbKelas As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Cari As Label
    Friend WithEvents lbjudul As Label
    Friend WithEvents btnSimpan As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnCetak As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnUbah As Button
    Friend WithEvents dgvJadwal As DataGridView
    Friend WithEvents cmbGuru As ComboBox
    Friend WithEvents dtpMulai As DateTimePicker
    Friend WithEvents dtpSelesai As DateTimePicker
    Friend WithEvents cmbMapel As ComboBox
    Friend WithEvents cmbFilterHari As ComboBox
    Friend WithEvents Label4 As Label
End Class
