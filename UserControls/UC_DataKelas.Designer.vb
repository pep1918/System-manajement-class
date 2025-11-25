<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_DataKelas
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbKelasTujuan = New System.Windows.Forms.ComboBox()
        Me.cmbTingkat = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTahunAjaran = New System.Windows.Forms.TextBox()
        Me.cmbWaliKelas = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtNamaKelas = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.btnUbah = New System.Windows.Forms.Button()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.dgvKelas = New System.Windows.Forms.DataGridView()
        Me.lblJudulUC = New System.Windows.Forms.Label()
        Me.txtCariKelas = New System.Windows.Forms.TextBox()
        Me.Cari = New System.Windows.Forms.Label()
        Me.lblNamaKelasTerpilih = New System.Windows.Forms.Label()
        Me.btnPindahSiswa = New System.Windows.Forms.Button()
        Me.cmbFilterKelas = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvKelas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSimpan
        '
        Me.btnSimpan.BackColor = System.Drawing.Color.SaddleBrown
        Me.btnSimpan.ForeColor = System.Drawing.Color.White
        Me.btnSimpan.Location = New System.Drawing.Point(1095, 607)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(111, 47)
        Me.btnSimpan.TabIndex = 6
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.SaddleBrown
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cmbKelasTujuan)
        Me.GroupBox1.Controls.Add(Me.cmbTingkat)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtTahunAjaran)
        Me.GroupBox1.Controls.Add(Me.cmbWaliKelas)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtNamaKelas)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.btnHapus)
        Me.GroupBox1.Controls.Add(Me.btnBatal)
        Me.GroupBox1.Controls.Add(Me.btnUbah)
        Me.GroupBox1.Controls.Add(Me.btnTambah)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 93)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(354, 508)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "\"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(24, 199)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 16)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Kelas"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(24, 156)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 16)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Tingjat"
        '
        'cmbKelasTujuan
        '
        Me.cmbKelasTujuan.FormattingEnabled = True
        Me.cmbKelasTujuan.Location = New System.Drawing.Point(149, 191)
        Me.cmbKelasTujuan.Name = "cmbKelasTujuan"
        Me.cmbKelasTujuan.Size = New System.Drawing.Size(189, 24)
        Me.cmbKelasTujuan.TabIndex = 18
        '
        'cmbTingkat
        '
        Me.cmbTingkat.FormattingEnabled = True
        Me.cmbTingkat.Location = New System.Drawing.Point(149, 152)
        Me.cmbTingkat.Name = "cmbTingkat"
        Me.cmbTingkat.Size = New System.Drawing.Size(189, 24)
        Me.cmbTingkat.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(24, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 16)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Kelas"
        '
        'txtTahunAjaran
        '
        Me.txtTahunAjaran.Location = New System.Drawing.Point(149, 76)
        Me.txtTahunAjaran.Name = "txtTahunAjaran"
        Me.txtTahunAjaran.Size = New System.Drawing.Size(189, 22)
        Me.txtTahunAjaran.TabIndex = 14
        '
        'cmbWaliKelas
        '
        Me.cmbWaliKelas.FormattingEnabled = True
        Me.cmbWaliKelas.Location = New System.Drawing.Point(149, 113)
        Me.cmbWaliKelas.Name = "cmbWaliKelas"
        Me.cmbWaliKelas.Size = New System.Drawing.Size(189, 24)
        Me.cmbWaliKelas.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(24, 119)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 16)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "WaliKelas"
        '
        'txtNamaKelas
        '
        Me.txtNamaKelas.Location = New System.Drawing.Point(149, 39)
        Me.txtNamaKelas.Name = "txtNamaKelas"
        Me.txtNamaKelas.Size = New System.Drawing.Size(189, 22)
        Me.txtNamaKelas.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(24, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Tahun Ajaran"
        '
        'btnHapus
        '
        Me.btnHapus.Location = New System.Drawing.Point(41, 444)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(119, 45)
        Me.btnHapus.TabIndex = 3
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'btnBatal
        '
        Me.btnBatal.Location = New System.Drawing.Point(166, 444)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(119, 45)
        Me.btnBatal.TabIndex = 2
        Me.btnBatal.Text = "Batal"
        Me.btnBatal.UseVisualStyleBackColor = True
        '
        'btnUbah
        '
        Me.btnUbah.Location = New System.Drawing.Point(166, 397)
        Me.btnUbah.Name = "btnUbah"
        Me.btnUbah.Size = New System.Drawing.Size(119, 45)
        Me.btnUbah.TabIndex = 1
        Me.btnUbah.Text = "Ubah"
        Me.btnUbah.UseVisualStyleBackColor = True
        '
        'btnTambah
        '
        Me.btnTambah.Location = New System.Drawing.Point(41, 397)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(119, 45)
        Me.btnTambah.TabIndex = 0
        Me.btnTambah.Text = "Tambah"
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'dgvKelas
        '
        Me.dgvKelas.BackgroundColor = System.Drawing.Color.SaddleBrown
        Me.dgvKelas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvKelas.Location = New System.Drawing.Point(372, 93)
        Me.dgvKelas.Name = "dgvKelas"
        Me.dgvKelas.RowHeadersWidth = 51
        Me.dgvKelas.RowTemplate.Height = 24
        Me.dgvKelas.Size = New System.Drawing.Size(846, 508)
        Me.dgvKelas.TabIndex = 4
        '
        'lblJudulUC
        '
        Me.lblJudulUC.AutoSize = True
        Me.lblJudulUC.BackColor = System.Drawing.Color.Transparent
        Me.lblJudulUC.Font = New System.Drawing.Font("Verdana", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJudulUC.ForeColor = System.Drawing.Color.White
        Me.lblJudulUC.Location = New System.Drawing.Point(6, 29)
        Me.lblJudulUC.Name = "lblJudulUC"
        Me.lblJudulUC.Size = New System.Drawing.Size(262, 48)
        Me.lblJudulUC.TabIndex = 9
        Me.lblJudulUC.Text = "Data Kelas"
        '
        'txtCariKelas
        '
        Me.txtCariKelas.Location = New System.Drawing.Point(797, 65)
        Me.txtCariKelas.Name = "txtCariKelas"
        Me.txtCariKelas.Size = New System.Drawing.Size(202, 22)
        Me.txtCariKelas.TabIndex = 16
        '
        'Cari
        '
        Me.Cari.AutoSize = True
        Me.Cari.Location = New System.Drawing.Point(760, 68)
        Me.Cari.Name = "Cari"
        Me.Cari.Size = New System.Drawing.Size(31, 16)
        Me.Cari.TabIndex = 17
        Me.Cari.Text = "Cari"
        '
        'lblNamaKelasTerpilih
        '
        Me.lblNamaKelasTerpilih.AutoSize = True
        Me.lblNamaKelasTerpilih.BackColor = System.Drawing.Color.Transparent
        Me.lblNamaKelasTerpilih.Font = New System.Drawing.Font("Verdana", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNamaKelasTerpilih.ForeColor = System.Drawing.Color.White
        Me.lblNamaKelasTerpilih.Location = New System.Drawing.Point(421, 29)
        Me.lblNamaKelasTerpilih.Name = "lblNamaKelasTerpilih"
        Me.lblNamaKelasTerpilih.Size = New System.Drawing.Size(262, 48)
        Me.lblNamaKelasTerpilih.TabIndex = 18
        Me.lblNamaKelasTerpilih.Text = "Data Kelas"
        '
        'btnPindahSiswa
        '
        Me.btnPindahSiswa.BackColor = System.Drawing.Color.SaddleBrown
        Me.btnPindahSiswa.ForeColor = System.Drawing.Color.White
        Me.btnPindahSiswa.Location = New System.Drawing.Point(978, 607)
        Me.btnPindahSiswa.Name = "btnPindahSiswa"
        Me.btnPindahSiswa.Size = New System.Drawing.Size(111, 47)
        Me.btnPindahSiswa.TabIndex = 19
        Me.btnPindahSiswa.Text = "Print"
        Me.btnPindahSiswa.UseVisualStyleBackColor = False
        '
        'cmbFilterKelas
        '
        Me.cmbFilterKelas.FormattingEnabled = True
        Me.cmbFilterKelas.Location = New System.Drawing.Point(1019, 29)
        Me.cmbFilterKelas.Name = "cmbFilterKelas"
        Me.cmbFilterKelas.Size = New System.Drawing.Size(100, 24)
        Me.cmbFilterKelas.TabIndex = 19
        '
        'UC_DataKelas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Controls.Add(Me.cmbFilterKelas)
        Me.Controls.Add(Me.btnPindahSiswa)
        Me.Controls.Add(Me.lblNamaKelasTerpilih)
        Me.Controls.Add(Me.Cari)
        Me.Controls.Add(Me.txtCariKelas)
        Me.Controls.Add(Me.lblJudulUC)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgvKelas)
        Me.Name = "UC_DataKelas"
        Me.Size = New System.Drawing.Size(1243, 688)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvKelas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSimpan As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmbWaliKelas As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtNamaKelas As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents btnUbah As Button
    Friend WithEvents btnTambah As Button
    Friend WithEvents dgvKelas As DataGridView
    Friend WithEvents lblJudulUC As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtTahunAjaran As TextBox
    Friend WithEvents txtCariKelas As TextBox
    Friend WithEvents Cari As Label
    Friend WithEvents cmbTingkat As ComboBox
    Friend WithEvents cmbKelasTujuan As ComboBox
    Friend WithEvents lblNamaKelasTerpilih As Label
    Friend WithEvents btnPindahSiswa As Button
    Friend WithEvents cmbFilterKelas As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
End Class
