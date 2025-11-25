<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UC_DataSiswa
    Inherits System.Windows.Forms.UserControl

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.dgvSiswa = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmbStatus = New System.Windows.Forms.ComboBox()
        Me.txtTahunMasuk = New System.Windows.Forms.TextBox()
        Me.dtpTanggalLahir = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbJenisKelamin = New System.Windows.Forms.ComboBox()
        Me.cmbKelas = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtAlamat = New System.Windows.Forms.TextBox()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.txtNIS = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btn_Tambah = New System.Windows.Forms.Button()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.lbjudul = New System.Windows.Forms.Label()
        Me.txtCariSiswa = New System.Windows.Forms.TextBox()
        Me.Cari = New System.Windows.Forms.Label()
        Me.cmbFilterKelas = New System.Windows.Forms.ComboBox()
        Me.btnExportPDF = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.dgvSiswa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvSiswa
        '
        Me.dgvSiswa.BackgroundColor = System.Drawing.Color.SaddleBrown
        Me.dgvSiswa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSiswa.Location = New System.Drawing.Point(266, 94)
        Me.dgvSiswa.Name = "dgvSiswa"
        Me.dgvSiswa.RowHeadersWidth = 51
        Me.dgvSiswa.RowTemplate.Height = 24
        Me.dgvSiswa.Size = New System.Drawing.Size(942, 493)
        Me.dgvSiswa.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.SaddleBrown
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.cmbStatus)
        Me.GroupBox1.Controls.Add(Me.txtTahunMasuk)
        Me.GroupBox1.Controls.Add(Me.dtpTanggalLahir)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.cmbJenisKelamin)
        Me.GroupBox1.Controls.Add(Me.cmbKelas)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtAlamat)
        Me.GroupBox1.Controls.Add(Me.txtNama)
        Me.GroupBox1.Controls.Add(Me.txtNIS)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnHapus)
        Me.GroupBox1.Controls.Add(Me.btnBatal)
        Me.GroupBox1.Controls.Add(Me.btnEdit)
        Me.GroupBox1.Controls.Add(Me.btn_Tambah)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 94)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(248, 493)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(26, 288)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(44, 16)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Status"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(21, 255)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(88, 16)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Tahun Masuk"
        '
        'cmbStatus
        '
        Me.cmbStatus.FormattingEnabled = True
        Me.cmbStatus.Location = New System.Drawing.Point(123, 285)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Size = New System.Drawing.Size(100, 24)
        Me.cmbStatus.TabIndex = 19
        '
        'txtTahunMasuk
        '
        Me.txtTahunMasuk.Location = New System.Drawing.Point(123, 255)
        Me.txtTahunMasuk.Name = "txtTahunMasuk"
        Me.txtTahunMasuk.Size = New System.Drawing.Size(100, 22)
        Me.txtTahunMasuk.TabIndex = 18
        '
        'dtpTanggalLahir
        '
        Me.dtpTanggalLahir.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpTanggalLahir.Location = New System.Drawing.Point(123, 221)
        Me.dtpTanggalLahir.Name = "dtpTanggalLahir"
        Me.dtpTanggalLahir.Size = New System.Drawing.Size(100, 22)
        Me.dtpTanggalLahir.TabIndex = 16
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(21, 221)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 16)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Tanggal Lahir"
        '
        'cmbJenisKelamin
        '
        Me.cmbJenisKelamin.FormattingEnabled = True
        Me.cmbJenisKelamin.Location = New System.Drawing.Point(123, 119)
        Me.cmbJenisKelamin.Name = "cmbJenisKelamin"
        Me.cmbJenisKelamin.Size = New System.Drawing.Size(100, 24)
        Me.cmbJenisKelamin.TabIndex = 14
        '
        'cmbKelas
        '
        Me.cmbKelas.FormattingEnabled = True
        Me.cmbKelas.Location = New System.Drawing.Point(123, 190)
        Me.cmbKelas.Name = "cmbKelas"
        Me.cmbKelas.Size = New System.Drawing.Size(100, 24)
        Me.cmbKelas.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(21, 190)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 16)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Kelas"
        '
        'txtAlamat
        '
        Me.txtAlamat.Location = New System.Drawing.Point(123, 156)
        Me.txtAlamat.Multiline = True
        Me.txtAlamat.Name = "txtAlamat"
        Me.txtAlamat.Size = New System.Drawing.Size(100, 22)
        Me.txtAlamat.TabIndex = 11
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(123, 84)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(100, 22)
        Me.txtNama.TabIndex = 9
        '
        'txtNIS
        '
        Me.txtNIS.Location = New System.Drawing.Point(123, 52)
        Me.txtNIS.Name = "txtNIS"
        Me.txtNIS.Size = New System.Drawing.Size(100, 22)
        Me.txtNIS.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(21, 162)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Alamat"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(21, 122)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Jenis Kelamin"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(21, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Nama Siswa"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(21, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "NIS"
        '
        'btnHapus
        '
        Me.btnHapus.Location = New System.Drawing.Point(20, 432)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(75, 39)
        Me.btnHapus.TabIndex = 3
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'btnBatal
        '
        Me.btnBatal.Location = New System.Drawing.Point(123, 432)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(84, 39)
        Me.btnBatal.TabIndex = 2
        Me.btnBatal.Text = "Batal"
        Me.btnBatal.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(123, 376)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(84, 41)
        Me.btnEdit.TabIndex = 1
        Me.btnEdit.Text = "Ubah"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btn_Tambah
        '
        Me.btn_Tambah.Location = New System.Drawing.Point(20, 376)
        Me.btn_Tambah.Name = "btn_Tambah"
        Me.btn_Tambah.Size = New System.Drawing.Size(75, 41)
        Me.btn_Tambah.TabIndex = 0
        Me.btn_Tambah.Text = "Tambah"
        Me.btn_Tambah.UseVisualStyleBackColor = True
        '
        'btnSimpan
        '
        Me.btnSimpan.BackColor = System.Drawing.Color.SaddleBrown
        Me.btnSimpan.ForeColor = System.Drawing.Color.White
        Me.btnSimpan.Location = New System.Drawing.Point(993, 593)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(87, 35)
        Me.btnSimpan.TabIndex = 2
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = False
        '
        'lbjudul
        '
        Me.lbjudul.AutoSize = True
        Me.lbjudul.BackColor = System.Drawing.Color.Transparent
        Me.lbjudul.Font = New System.Drawing.Font("Verdana", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbjudul.ForeColor = System.Drawing.Color.White
        Me.lbjudul.Location = New System.Drawing.Point(4, 29)
        Me.lbjudul.Name = "lbjudul"
        Me.lbjudul.Size = New System.Drawing.Size(271, 48)
        Me.lbjudul.TabIndex = 9
        Me.lbjudul.Text = "Data Siswa"
        '
        'txtCariSiswa
        '
        Me.txtCariSiswa.Location = New System.Drawing.Point(693, 69)
        Me.txtCariSiswa.Name = "txtCariSiswa"
        Me.txtCariSiswa.Size = New System.Drawing.Size(192, 22)
        Me.txtCariSiswa.TabIndex = 17
        '
        'Cari
        '
        Me.Cari.AutoSize = True
        Me.Cari.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Cari.Location = New System.Drawing.Point(640, 75)
        Me.Cari.Name = "Cari"
        Me.Cari.Size = New System.Drawing.Size(31, 16)
        Me.Cari.TabIndex = 18
        Me.Cari.Text = "Cari"
        '
        'cmbFilterKelas
        '
        Me.cmbFilterKelas.FormattingEnabled = True
        Me.cmbFilterKelas.Location = New System.Drawing.Point(1016, 64)
        Me.cmbFilterKelas.Name = "cmbFilterKelas"
        Me.cmbFilterKelas.Size = New System.Drawing.Size(100, 24)
        Me.cmbFilterKelas.TabIndex = 20
        '
        'btnExportPDF
        '
        Me.btnExportPDF.BackColor = System.Drawing.Color.SaddleBrown
        Me.btnExportPDF.ForeColor = System.Drawing.Color.White
        Me.btnExportPDF.Location = New System.Drawing.Point(1086, 593)
        Me.btnExportPDF.Name = "btnExportPDF"
        Me.btnExportPDF.Size = New System.Drawing.Size(87, 35)
        Me.btnExportPDF.TabIndex = 24
        Me.btnExportPDF.Text = "Print"
        Me.btnExportPDF.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Label7.Location = New System.Drawing.Point(931, 69)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 16)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "Filter Kelas"
        '
        'UC_DataSiswa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnExportPDF)
        Me.Controls.Add(Me.cmbFilterKelas)
        Me.Controls.Add(Me.Cari)
        Me.Controls.Add(Me.txtCariSiswa)
        Me.Controls.Add(Me.lbjudul)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgvSiswa)
        Me.Name = "UC_DataSiswa"
        Me.Size = New System.Drawing.Size(1263, 703)
        CType(Me.dgvSiswa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvSiswa As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnSimpan As Button
    Friend WithEvents cmbKelas As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtNIS As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btn_Tambah As Button
    Friend WithEvents lbjudul As Label
    Friend WithEvents cmbJenisKelamin As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents dtpTanggalLahir As DateTimePicker
    Friend WithEvents txtCariSiswa As TextBox
    Friend WithEvents Cari As Label
    Friend WithEvents txtTahunMasuk As TextBox
    Friend WithEvents cmbStatus As ComboBox
    Friend WithEvents cmbFilterKelas As ComboBox
    Friend WithEvents btnExportPDF As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
End Class
