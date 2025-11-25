<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UC_DataGuru
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
        Me.lbLJudulUC = New System.Windows.Forms.Label()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtTelepon = New System.Windows.Forms.TextBox()
        Me.cmbJenisKelamin = New System.Windows.Forms.ComboBox()
        Me.cmbStatus = New System.Windows.Forms.ComboBox()
        Me.cmbMapelPengampu = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtAlamat = New System.Windows.Forms.TextBox()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.txtNIP = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.btnUbah = New System.Windows.Forms.Button()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.dgvGuru = New System.Windows.Forms.DataGridView()
        Me.Cari = New System.Windows.Forms.Label()
        Me.txtCari = New System.Windows.Forms.TextBox()
        Me.cmbFilterMapel = New System.Windows.Forms.ComboBox()
        Me.btnExportPDF = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvGuru, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbLJudulUC
        '
        Me.lbLJudulUC.AutoSize = True
        Me.lbLJudulUC.BackColor = System.Drawing.Color.Transparent
        Me.lbLJudulUC.Font = New System.Drawing.Font("Verdana", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbLJudulUC.ForeColor = System.Drawing.Color.White
        Me.lbLJudulUC.Location = New System.Drawing.Point(25, 27)
        Me.lbLJudulUC.Name = "lbLJudulUC"
        Me.lbLJudulUC.Size = New System.Drawing.Size(249, 48)
        Me.lbLJudulUC.TabIndex = 8
        Me.lbLJudulUC.Text = "Data Guru"
        '
        'btnSimpan
        '
        Me.btnSimpan.BackColor = System.Drawing.Color.SaddleBrown
        Me.btnSimpan.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSimpan.ForeColor = System.Drawing.Color.White
        Me.btnSimpan.Location = New System.Drawing.Point(1158, 573)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(111, 47)
        Me.btnSimpan.TabIndex = 11
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.SaddleBrown
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnHapus)
        Me.GroupBox1.Controls.Add(Me.btnBatal)
        Me.GroupBox1.Controls.Add(Me.btnUbah)
        Me.GroupBox1.Controls.Add(Me.btnTambah)
        Me.GroupBox1.Controls.Add(Me.txtTelepon)
        Me.GroupBox1.Controls.Add(Me.cmbJenisKelamin)
        Me.GroupBox1.Controls.Add(Me.cmbStatus)
        Me.GroupBox1.Controls.Add(Me.cmbMapelPengampu)
        Me.GroupBox1.Controls.Add(Me.txtAlamat)
        Me.GroupBox1.Controls.Add(Me.txtNama)
        Me.GroupBox1.Controls.Add(Me.txtNIP)
        Me.GroupBox1.Location = New System.Drawing.Point(49, 99)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(354, 468)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(21, 241)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(90, 16)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "Jenis Kelamin"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(21, 206)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 16)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Pengajar"
        '
        'txtTelepon
        '
        Me.txtTelepon.Location = New System.Drawing.Point(143, 173)
        Me.txtTelepon.Multiline = True
        Me.txtTelepon.Name = "txtTelepon"
        Me.txtTelepon.Size = New System.Drawing.Size(189, 24)
        Me.txtTelepon.TabIndex = 19
        '
        'cmbJenisKelamin
        '
        Me.cmbJenisKelamin.FormattingEnabled = True
        Me.cmbJenisKelamin.Items.AddRange(New Object() {"Laki-Laki", "Perempuan"})
        Me.cmbJenisKelamin.Location = New System.Drawing.Point(143, 237)
        Me.cmbJenisKelamin.Name = "cmbJenisKelamin"
        Me.cmbJenisKelamin.Size = New System.Drawing.Size(189, 24)
        Me.cmbJenisKelamin.TabIndex = 22
        '
        'cmbStatus
        '
        Me.cmbStatus.FormattingEnabled = True
        Me.cmbStatus.Items.AddRange(New Object() {"Laki-Laki", "Perempuan"})
        Me.cmbStatus.Location = New System.Drawing.Point(143, 109)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Size = New System.Drawing.Size(189, 24)
        Me.cmbStatus.TabIndex = 15
        '
        'cmbMapelPengampu
        '
        Me.cmbMapelPengampu.FormattingEnabled = True
        Me.cmbMapelPengampu.Items.AddRange(New Object() {"Laki-Laki", "Perempuan"})
        Me.cmbMapelPengampu.Location = New System.Drawing.Point(143, 205)
        Me.cmbMapelPengampu.Name = "cmbMapelPengampu"
        Me.cmbMapelPengampu.Size = New System.Drawing.Size(189, 24)
        Me.cmbMapelPengampu.TabIndex = 19
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(21, 117)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 16)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Status"
        '
        'txtAlamat
        '
        Me.txtAlamat.Location = New System.Drawing.Point(143, 141)
        Me.txtAlamat.Multiline = True
        Me.txtAlamat.Name = "txtAlamat"
        Me.txtAlamat.Size = New System.Drawing.Size(189, 24)
        Me.txtAlamat.TabIndex = 10
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(143, 79)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(189, 22)
        Me.txtNama.TabIndex = 9
        '
        'txtNIP
        '
        Me.txtNIP.Location = New System.Drawing.Point(143, 49)
        Me.txtNIP.Name = "txtNIP"
        Me.txtNIP.Size = New System.Drawing.Size(189, 22)
        Me.txtNIP.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(21, 179)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Telepon"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(21, 148)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Alamat"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(21, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Nama Guru"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(21, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "NIP"
        '
        'btnHapus
        '
        Me.btnHapus.Location = New System.Drawing.Point(58, 394)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(119, 45)
        Me.btnHapus.TabIndex = 3
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'btnBatal
        '
        Me.btnBatal.Location = New System.Drawing.Point(183, 394)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(119, 45)
        Me.btnBatal.TabIndex = 2
        Me.btnBatal.Text = "Batal"
        Me.btnBatal.UseVisualStyleBackColor = True
        '
        'btnUbah
        '
        Me.btnUbah.Location = New System.Drawing.Point(183, 343)
        Me.btnUbah.Name = "btnUbah"
        Me.btnUbah.Size = New System.Drawing.Size(119, 45)
        Me.btnUbah.TabIndex = 1
        Me.btnUbah.Text = "Ubah"
        Me.btnUbah.UseVisualStyleBackColor = True
        '
        'btnTambah
        '
        Me.btnTambah.Location = New System.Drawing.Point(58, 343)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(119, 45)
        Me.btnTambah.TabIndex = 0
        Me.btnTambah.Text = "Tambah"
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'dgvGuru
        '
        Me.dgvGuru.BackgroundColor = System.Drawing.Color.SaddleBrown
        Me.dgvGuru.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvGuru.Location = New System.Drawing.Point(433, 99)
        Me.dgvGuru.Name = "dgvGuru"
        Me.dgvGuru.RowHeadersWidth = 51
        Me.dgvGuru.RowTemplate.Height = 24
        Me.dgvGuru.Size = New System.Drawing.Size(877, 468)
        Me.dgvGuru.TabIndex = 9
        '
        'Cari
        '
        Me.Cari.AutoSize = True
        Me.Cari.Location = New System.Drawing.Point(782, 74)
        Me.Cari.Name = "Cari"
        Me.Cari.Size = New System.Drawing.Size(31, 16)
        Me.Cari.TabIndex = 20
        Me.Cari.Text = "Cari"
        '
        'txtCari
        '
        Me.txtCari.Location = New System.Drawing.Point(819, 71)
        Me.txtCari.Name = "txtCari"
        Me.txtCari.Size = New System.Drawing.Size(192, 22)
        Me.txtCari.TabIndex = 19
        '
        'cmbFilterMapel
        '
        Me.cmbFilterMapel.FormattingEnabled = True
        Me.cmbFilterMapel.Items.AddRange(New Object() {"Laki-Laki", "Perempuan"})
        Me.cmbFilterMapel.Location = New System.Drawing.Point(1163, 71)
        Me.cmbFilterMapel.Name = "cmbFilterMapel"
        Me.cmbFilterMapel.Size = New System.Drawing.Size(100, 24)
        Me.cmbFilterMapel.TabIndex = 21
        '
        'btnExportPDF
        '
        Me.btnExportPDF.BackColor = System.Drawing.Color.SaddleBrown
        Me.btnExportPDF.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExportPDF.ForeColor = System.Drawing.Color.White
        Me.btnExportPDF.Location = New System.Drawing.Point(1041, 573)
        Me.btnExportPDF.Name = "btnExportPDF"
        Me.btnExportPDF.Size = New System.Drawing.Size(111, 47)
        Me.btnExportPDF.TabIndex = 24
        Me.btnExportPDF.Text = "Print"
        Me.btnExportPDF.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(1116, 77)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 16)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Filter"
        '
        'UC_DataGuru
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnExportPDF)
        Me.Controls.Add(Me.Cari)
        Me.Controls.Add(Me.txtCari)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgvGuru)
        Me.Controls.Add(Me.lbLJudulUC)
        Me.Controls.Add(Me.cmbFilterMapel)
        Me.Name = "UC_DataGuru"
        Me.Size = New System.Drawing.Size(1331, 668)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvGuru, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbLJudulUC As Label
    Friend WithEvents btnSimpan As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtNIP As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents btnUbah As Button
    Friend WithEvents btnTambah As Button
    Friend WithEvents dgvGuru As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents cmbStatus As ComboBox
    Friend WithEvents Cari As Label
    Friend WithEvents txtCari As TextBox
    Friend WithEvents cmbMapelPengampu As ComboBox
    Friend WithEvents cmbFilterMapel As ComboBox
    Friend WithEvents cmbJenisKelamin As ComboBox
    Friend WithEvents txtTelepon As TextBox
    Friend WithEvents btnExportPDF As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
End Class
