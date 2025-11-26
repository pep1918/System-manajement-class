<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_DataGuru
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
        Me.cmbFilterMapel = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmbMapelPengampu = New System.Windows.Forms.ComboBox()
        Me.dtpTanggalLahir = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbJK = New System.Windows.Forms.ComboBox()
        Me.cmbPendidikan = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtAlamat = New System.Windows.Forms.TextBox()
        Me.txtNIP = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Cari = New System.Windows.Forms.Label()
        Me.txtCari = New System.Windows.Forms.TextBox()
        Me.lbjudul = New System.Windows.Forms.Label()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.btnCetak = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbStatus = New System.Windows.Forms.ComboBox()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.btnUbah = New System.Windows.Forms.Button()
        Me.dgvGuru = New System.Windows.Forms.DataGridView()
        Me.txtTelepon = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvGuru, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Label7.Location = New System.Drawing.Point(1274, 110)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 16)
        Me.Label7.TabIndex = 35
        Me.Label7.Text = "Filter Kelas"
        '
        'cmbFilterMapel
        '
        Me.cmbFilterMapel.FormattingEnabled = True
        Me.cmbFilterMapel.Location = New System.Drawing.Point(1353, 102)
        Me.cmbFilterMapel.Name = "cmbFilterMapel"
        Me.cmbFilterMapel.Size = New System.Drawing.Size(140, 24)
        Me.cmbFilterMapel.TabIndex = 33
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(19, 252)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(44, 16)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Status"
        '
        'cmbMapelPengampu
        '
        Me.cmbMapelPengampu.FormattingEnabled = True
        Me.cmbMapelPengampu.Location = New System.Drawing.Point(702, 36)
        Me.cmbMapelPengampu.Name = "cmbMapelPengampu"
        Me.cmbMapelPengampu.Size = New System.Drawing.Size(189, 24)
        Me.cmbMapelPengampu.TabIndex = 19
        '
        'dtpTanggalLahir
        '
        Me.dtpTanggalLahir.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpTanggalLahir.Location = New System.Drawing.Point(182, 212)
        Me.dtpTanggalLahir.Name = "dtpTanggalLahir"
        Me.dtpTanggalLahir.Size = New System.Drawing.Size(189, 22)
        Me.dtpTanggalLahir.TabIndex = 16
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(19, 212)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 16)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Tanggal Lahir"
        '
        'cmbJK
        '
        Me.cmbJK.FormattingEnabled = True
        Me.cmbJK.Location = New System.Drawing.Point(182, 129)
        Me.cmbJK.Name = "cmbJK"
        Me.cmbJK.Size = New System.Drawing.Size(189, 24)
        Me.cmbJK.TabIndex = 14
        '
        'cmbPendidikan
        '
        Me.cmbPendidikan.FormattingEnabled = True
        Me.cmbPendidikan.Location = New System.Drawing.Point(478, 102)
        Me.cmbPendidikan.Name = "cmbPendidikan"
        Me.cmbPendidikan.Size = New System.Drawing.Size(189, 24)
        Me.cmbPendidikan.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(19, 172)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 16)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Kelas"
        '
        'txtAlamat
        '
        Me.txtAlamat.Location = New System.Drawing.Point(457, 36)
        Me.txtAlamat.Name = "txtAlamat"
        Me.txtAlamat.Size = New System.Drawing.Size(189, 22)
        Me.txtAlamat.TabIndex = 9
        '
        'txtNIP
        '
        Me.txtNIP.Location = New System.Drawing.Point(182, 52)
        Me.txtNIP.Name = "txtNIP"
        Me.txtNIP.Size = New System.Drawing.Size(189, 22)
        Me.txtNIP.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(19, 132)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Jenis Kelamin"
        '
        'Cari
        '
        Me.Cari.AutoSize = True
        Me.Cari.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Cari.Location = New System.Drawing.Point(969, 113)
        Me.Cari.Name = "Cari"
        Me.Cari.Size = New System.Drawing.Size(31, 16)
        Me.Cari.TabIndex = 32
        Me.Cari.Text = "Cari"
        '
        'txtCari
        '
        Me.txtCari.Location = New System.Drawing.Point(1034, 107)
        Me.txtCari.Name = "txtCari"
        Me.txtCari.Size = New System.Drawing.Size(192, 22)
        Me.txtCari.TabIndex = 31
        '
        'lbjudul
        '
        Me.lbjudul.AutoSize = True
        Me.lbjudul.BackColor = System.Drawing.Color.Transparent
        Me.lbjudul.Font = New System.Drawing.Font("Verdana", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbjudul.ForeColor = System.Drawing.Color.White
        Me.lbjudul.Location = New System.Drawing.Point(107, 78)
        Me.lbjudul.Name = "lbjudul"
        Me.lbjudul.Size = New System.Drawing.Size(249, 48)
        Me.lbjudul.TabIndex = 30
        Me.lbjudul.Text = "Data Guru"
        '
        'btnSimpan
        '
        Me.btnSimpan.BackColor = System.Drawing.Color.SaddleBrown
        Me.btnSimpan.ForeColor = System.Drawing.Color.White
        Me.btnSimpan.Location = New System.Drawing.Point(1074, 639)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(87, 35)
        Me.btnSimpan.TabIndex = 29
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(19, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Nama Guru"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(19, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "NIP"
        '
        'btnHapus
        '
        Me.btnHapus.Location = New System.Drawing.Point(242, 407)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(119, 45)
        Me.btnHapus.TabIndex = 3
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'btnBatal
        '
        Me.btnBatal.Location = New System.Drawing.Point(242, 458)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(119, 45)
        Me.btnBatal.TabIndex = 2
        Me.btnBatal.Text = "Batal"
        Me.btnBatal.UseVisualStyleBackColor = True
        '
        'btnTambah
        '
        Me.btnTambah.Location = New System.Drawing.Point(92, 407)
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
        Me.btnCetak.Location = New System.Drawing.Point(1167, 639)
        Me.btnCetak.Name = "btnCetak"
        Me.btnCetak.Size = New System.Drawing.Size(87, 35)
        Me.btnCetak.TabIndex = 34
        Me.btnCetak.Text = "Print"
        Me.btnCetak.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.SaddleBrown
        Me.GroupBox1.Controls.Add(Me.cmbStatus)
        Me.GroupBox1.Controls.Add(Me.txtEmail)
        Me.GroupBox1.Controls.Add(Me.txtNama)
        Me.GroupBox1.Controls.Add(Me.txtTelepon)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.dtpTanggalLahir)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.cmbJK)
        Me.GroupBox1.Controls.Add(Me.btnBatal)
        Me.GroupBox1.Controls.Add(Me.btnUbah)
        Me.GroupBox1.Controls.Add(Me.btnHapus)
        Me.GroupBox1.Controls.Add(Me.btnTambah)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtNIP)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(93, 140)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(388, 513)
        Me.GroupBox1.TabIndex = 28
        Me.GroupBox1.TabStop = False
        '
        'cmbStatus
        '
        Me.cmbStatus.FormattingEnabled = True
        Me.cmbStatus.Location = New System.Drawing.Point(182, 252)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Size = New System.Drawing.Size(189, 24)
        Me.cmbStatus.TabIndex = 24
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(182, 86)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(189, 22)
        Me.txtNama.TabIndex = 23
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(182, 366)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(189, 22)
        Me.txtEmail.TabIndex = 23
        '
        'btnUbah
        '
        Me.btnUbah.Location = New System.Drawing.Point(92, 452)
        Me.btnUbah.Name = "btnUbah"
        Me.btnUbah.Size = New System.Drawing.Size(119, 45)
        Me.btnUbah.TabIndex = 1
        Me.btnUbah.Text = "Ubah"
        Me.btnUbah.UseVisualStyleBackColor = True
        '
        'dgvGuru
        '
        Me.dgvGuru.BackgroundColor = System.Drawing.Color.SaddleBrown
        Me.dgvGuru.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvGuru.Location = New System.Drawing.Point(551, 140)
        Me.dgvGuru.Name = "dgvGuru"
        Me.dgvGuru.RowHeadersWidth = 51
        Me.dgvGuru.RowTemplate.Height = 24
        Me.dgvGuru.Size = New System.Drawing.Size(942, 493)
        Me.dgvGuru.TabIndex = 27
        '
        'txtTelepon
        '
        Me.txtTelepon.Location = New System.Drawing.Point(172, 338)
        Me.txtTelepon.Name = "txtTelepon"
        Me.txtTelepon.Size = New System.Drawing.Size(189, 22)
        Me.txtTelepon.TabIndex = 36
        '
        'UC_DataGuru
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cmbFilterMapel)
        Me.Controls.Add(Me.Cari)
        Me.Controls.Add(Me.txtCari)
        Me.Controls.Add(Me.lbjudul)
        Me.Controls.Add(Me.cmbMapelPengampu)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.btnCetak)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgvGuru)
        Me.Controls.Add(Me.txtAlamat)
        Me.Controls.Add(Me.cmbPendidikan)
        Me.Name = "UC_DataGuru"
        Me.Size = New System.Drawing.Size(1583, 749)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvGuru, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label7 As Label
    Friend WithEvents cmbFilterMapel As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents cmbMapelPengampu As ComboBox
    Friend WithEvents dtpTanggalLahir As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents cmbJK As ComboBox
    Friend WithEvents cmbPendidikan As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents txtNIP As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Cari As Label
    Friend WithEvents txtCari As TextBox
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
    Friend WithEvents dgvGuru As DataGridView
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtTelepon As TextBox
    Friend WithEvents cmbStatus As ComboBox
    Friend WithEvents txtNama As TextBox
End Class
