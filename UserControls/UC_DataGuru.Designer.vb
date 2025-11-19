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
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbJenisKelamin = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTelepon = New System.Windows.Forms.TextBox()
        Me.txtAlamat = New System.Windows.Forms.TextBox()
        Me.txtNamaGuru = New System.Windows.Forms.TextBox()
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
        Me.txtCariGuru = New System.Windows.Forms.TextBox()
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
        Me.btnSimpan.Location = New System.Drawing.Point(915, 501)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(96, 33)
        Me.btnSimpan.TabIndex = 11
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.SaddleBrown
        Me.GroupBox1.Controls.Add(Me.txtEmail)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.cmbJenisKelamin)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtTelepon)
        Me.GroupBox1.Controls.Add(Me.txtAlamat)
        Me.GroupBox1.Controls.Add(Me.txtNamaGuru)
        Me.GroupBox1.Controls.Add(Me.txtNIP)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnHapus)
        Me.GroupBox1.Controls.Add(Me.btnBatal)
        Me.GroupBox1.Controls.Add(Me.btnUbah)
        Me.GroupBox1.Controls.Add(Me.btnTambah)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 99)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(256, 396)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(132, 214)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(100, 22)
        Me.txtEmail.TabIndex = 17
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(21, 208)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 16)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Email"
        '
        'cmbJenisKelamin
        '
        Me.cmbJenisKelamin.FormattingEnabled = True
        Me.cmbJenisKelamin.Items.AddRange(New Object() {"Laki-Laki", "Perempuan"})
        Me.cmbJenisKelamin.Location = New System.Drawing.Point(132, 112)
        Me.cmbJenisKelamin.Name = "cmbJenisKelamin"
        Me.cmbJenisKelamin.Size = New System.Drawing.Size(100, 24)
        Me.cmbJenisKelamin.TabIndex = 15
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(21, 112)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 16)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Jenis Kelamin"
        '
        'txtTelepon
        '
        Me.txtTelepon.Location = New System.Drawing.Point(132, 186)
        Me.txtTelepon.Name = "txtTelepon"
        Me.txtTelepon.Size = New System.Drawing.Size(100, 22)
        Me.txtTelepon.TabIndex = 11
        '
        'txtAlamat
        '
        Me.txtAlamat.Location = New System.Drawing.Point(132, 152)
        Me.txtAlamat.Multiline = True
        Me.txtAlamat.Name = "txtAlamat"
        Me.txtAlamat.Size = New System.Drawing.Size(100, 22)
        Me.txtAlamat.TabIndex = 10
        '
        'txtNamaGuru
        '
        Me.txtNamaGuru.Location = New System.Drawing.Point(132, 84)
        Me.txtNamaGuru.Name = "txtNamaGuru"
        Me.txtNamaGuru.Size = New System.Drawing.Size(100, 22)
        Me.txtNamaGuru.TabIndex = 9
        '
        'txtNIP
        '
        Me.txtNIP.Location = New System.Drawing.Point(132, 52)
        Me.txtNIP.Name = "txtNIP"
        Me.txtNIP.Size = New System.Drawing.Size(100, 22)
        Me.txtNIP.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(21, 192)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "NO. HP"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(21, 152)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Alamat"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(21, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Nama Guru"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(21, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "NIP"
        '
        'btnHapus
        '
        Me.btnHapus.Location = New System.Drawing.Point(67, 304)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(69, 48)
        Me.btnHapus.TabIndex = 3
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'btnBatal
        '
        Me.btnBatal.Location = New System.Drawing.Point(157, 304)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(75, 48)
        Me.btnBatal.TabIndex = 2
        Me.btnBatal.Text = "Batal"
        Me.btnBatal.UseVisualStyleBackColor = True
        '
        'btnUbah
        '
        Me.btnUbah.Location = New System.Drawing.Point(157, 253)
        Me.btnUbah.Name = "btnUbah"
        Me.btnUbah.Size = New System.Drawing.Size(75, 45)
        Me.btnUbah.TabIndex = 1
        Me.btnUbah.Text = "Ubah"
        Me.btnUbah.UseVisualStyleBackColor = True
        '
        'btnTambah
        '
        Me.btnTambah.Location = New System.Drawing.Point(67, 253)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(69, 45)
        Me.btnTambah.TabIndex = 0
        Me.btnTambah.Text = "Tambah"
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'dgvGuru
        '
        Me.dgvGuru.BackgroundColor = System.Drawing.Color.SaddleBrown
        Me.dgvGuru.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvGuru.Location = New System.Drawing.Point(283, 99)
        Me.dgvGuru.Name = "dgvGuru"
        Me.dgvGuru.RowHeadersWidth = 51
        Me.dgvGuru.RowTemplate.Height = 24
        Me.dgvGuru.Size = New System.Drawing.Size(946, 396)
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
        'txtCariGuru
        '
        Me.txtCariGuru.Location = New System.Drawing.Point(819, 71)
        Me.txtCariGuru.Name = "txtCariGuru"
        Me.txtCariGuru.Size = New System.Drawing.Size(192, 22)
        Me.txtCariGuru.TabIndex = 19
        '
        'UC_DataGuru
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Controls.Add(Me.Cari)
        Me.Controls.Add(Me.txtCariGuru)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgvGuru)
        Me.Controls.Add(Me.lbLJudulUC)
        Me.Name = "UC_DataGuru"
        Me.Size = New System.Drawing.Size(1241, 541)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvGuru, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbLJudulUC As Label
    Friend WithEvents btnSimpan As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtTelepon As TextBox
    Friend WithEvents txtAlamat As TextBox
        Friend WithEvents txtNamaGuru As TextBox
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
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cmbJenisKelamin As ComboBox
    Friend WithEvents Cari As Label
    Friend WithEvents txtCariGuru As TextBox
End Class
