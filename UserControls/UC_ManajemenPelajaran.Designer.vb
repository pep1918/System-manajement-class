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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UC_ManajemenPelajaran))
        Me.Label6 = New System.Windows.Forms.Label()
        Me.bt_simpan = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbMapel = New System.Windows.Forms.ComboBox()
        Me.Mapel = New System.Windows.Forms.Label()
        Me.clbMapel = New System.Windows.Forms.CheckedListBox()
        Me.cmbKelas = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.dgvManage = New System.Windows.Forms.DataGridView()
        Me.lbjudul = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvManage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(801, 23)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 16)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Label6"
        '
        'bt_simpan
        '
        Me.bt_simpan.Location = New System.Drawing.Point(891, 503)
        Me.bt_simpan.Name = "bt_simpan"
        Me.bt_simpan.Size = New System.Drawing.Size(75, 23)
        Me.bt_simpan.TabIndex = 6
        Me.bt_simpan.Text = "Simpan"
        Me.bt_simpan.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbMapel)
        Me.GroupBox1.Controls.Add(Me.Mapel)
        Me.GroupBox1.Controls.Add(Me.clbMapel)
        Me.GroupBox1.Controls.Add(Me.cmbKelas)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.btnTambah)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 91)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(256, 396)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'cmbMapel
        '
        Me.cmbMapel.FormattingEnabled = True
        Me.cmbMapel.Location = New System.Drawing.Point(91, 240)
        Me.cmbMapel.Name = "cmbMapel"
        Me.cmbMapel.Size = New System.Drawing.Size(100, 24)
        Me.cmbMapel.TabIndex = 16
        '
        'Mapel
        '
        Me.Mapel.AutoSize = True
        Me.Mapel.Location = New System.Drawing.Point(39, 156)
        Me.Mapel.Name = "Mapel"
        Me.Mapel.Size = New System.Drawing.Size(45, 16)
        Me.Mapel.TabIndex = 15
        Me.Mapel.Text = "Mapel"
        '
        'clbMapel
        '
        Me.clbMapel.FormattingEnabled = True
        Me.clbMapel.Location = New System.Drawing.Point(96, 132)
        Me.clbMapel.Name = "clbMapel"
        Me.clbMapel.Size = New System.Drawing.Size(120, 89)
        Me.clbMapel.TabIndex = 14
        '
        'cmbKelas
        '
        Me.cmbKelas.FormattingEnabled = True
        Me.cmbKelas.Location = New System.Drawing.Point(116, 79)
        Me.cmbKelas.Name = "cmbKelas"
        Me.cmbKelas.Size = New System.Drawing.Size(100, 24)
        Me.cmbKelas.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(39, 87)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 16)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Kelas"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(21, 356)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Hapus"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(116, 356)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Batal"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(116, 327)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Ubah"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnTambah
        '
        Me.btnTambah.Location = New System.Drawing.Point(21, 327)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(75, 23)
        Me.btnTambah.TabIndex = 0
        Me.btnTambah.Text = "Tambah"
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'dgvManage
        '
        Me.dgvManage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvManage.Location = New System.Drawing.Point(274, 91)
        Me.dgvManage.Name = "dgvManage"
        Me.dgvManage.RowHeadersWidth = 51
        Me.dgvManage.RowTemplate.Height = 24
        Me.dgvManage.Size = New System.Drawing.Size(759, 396)
        Me.dgvManage.TabIndex = 4
        '
        'lbjudul
        '
        Me.lbjudul.AutoSize = True
        Me.lbjudul.Location = New System.Drawing.Point(30, 39)
        Me.lbjudul.Name = "lbjudul"
        Me.lbjudul.Size = New System.Drawing.Size(139, 16)
        Me.lbjudul.TabIndex = 9
        Me.lbjudul.Text = "Manajemen Pelajaran"
        '
        'UC_ManajemenPelajaran
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.Controls.Add(Me.lbjudul)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.bt_simpan)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgvManage)
        Me.Name = "UC_ManajemenPelajaran"
        Me.Size = New System.Drawing.Size(1045, 541)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvManage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label6 As Label
    Friend WithEvents bt_simpan As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmbKelas As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents btnTambah As Button
    Friend WithEvents dgvManage As DataGridView
    Friend WithEvents lbjudul As Label
    Friend WithEvents clbMapel As CheckedListBox
    Friend WithEvents Mapel As Label
    Friend WithEvents cmbMapel As ComboBox
End Class
