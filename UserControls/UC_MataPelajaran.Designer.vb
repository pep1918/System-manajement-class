<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UC_MataPelajaran
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtKKM = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNamaMapel = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtKodeMapel = New System.Windows.Forms.TextBox()
        Me.cmbJurusan = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.btnUbah = New System.Windows.Forms.Button()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.dgvMapel = New System.Windows.Forms.DataGridView()
        Me.lblJudulUC = New System.Windows.Forms.Label()
        Me.txtCariMapel = New System.Windows.Forms.TextBox()
        Me.btnLihatHistory = New System.Windows.Forms.Button()
        Me.btnCatatHistoryKKM = New System.Windows.Forms.Button()
        Me.btnExportPDF = New System.Windows.Forms.Button()
        Me.cmbFilterKelas = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvMapel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(743, 60)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 16)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Cari"
        '
        'btnSimpan
        '
        Me.btnSimpan.BackColor = System.Drawing.Color.SaddleBrown
        Me.btnSimpan.ForeColor = System.Drawing.Color.White
        Me.btnSimpan.Location = New System.Drawing.Point(1147, 532)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(81, 29)
        Me.btnSimpan.TabIndex = 6
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.SaddleBrown
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtKKM)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtNamaMapel)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtKodeMapel)
        Me.GroupBox1.Controls.Add(Me.cmbJurusan)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnHapus)
        Me.GroupBox1.Controls.Add(Me.btnBatal)
        Me.GroupBox1.Controls.Add(Me.btnUbah)
        Me.GroupBox1.Controls.Add(Me.btnTambah)
        Me.GroupBox1.Location = New System.Drawing.Point(1, 85)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(256, 441)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(21, 169)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 16)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Kelas"
        '
        'txtKKM
        '
        Me.txtKKM.Location = New System.Drawing.Point(128, 133)
        Me.txtKKM.Name = "txtKKM"
        Me.txtKKM.Size = New System.Drawing.Size(100, 22)
        Me.txtKKM.TabIndex = 17
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(21, 139)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 16)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "KKM"
        '
        'txtNamaMapel
        '
        Me.txtNamaMapel.Location = New System.Drawing.Point(117, 91)
        Me.txtNamaMapel.Name = "txtNamaMapel"
        Me.txtNamaMapel.Size = New System.Drawing.Size(100, 22)
        Me.txtNamaMapel.TabIndex = 15
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(21, 97)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 16)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Mapel"
        '
        'txtKodeMapel
        '
        Me.txtKodeMapel.Location = New System.Drawing.Point(117, 52)
        Me.txtKodeMapel.Name = "txtKodeMapel"
        Me.txtKodeMapel.Size = New System.Drawing.Size(100, 22)
        Me.txtKodeMapel.TabIndex = 8
        '
        'cmbJurusan
        '
        Me.cmbJurusan.FormattingEnabled = True
        Me.cmbJurusan.Location = New System.Drawing.Point(107, 161)
        Me.cmbJurusan.Name = "cmbJurusan"
        Me.cmbJurusan.Size = New System.Drawing.Size(121, 24)
        Me.cmbJurusan.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(21, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Kode Mapel"
        '
        'btnHapus
        '
        Me.btnHapus.Location = New System.Drawing.Point(42, 366)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(72, 41)
        Me.btnHapus.TabIndex = 3
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'btnBatal
        '
        Me.btnBatal.Location = New System.Drawing.Point(142, 366)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(75, 41)
        Me.btnBatal.TabIndex = 2
        Me.btnBatal.Text = "Batal"
        Me.btnBatal.UseVisualStyleBackColor = True
        '
        'btnUbah
        '
        Me.btnUbah.Location = New System.Drawing.Point(142, 306)
        Me.btnUbah.Name = "btnUbah"
        Me.btnUbah.Size = New System.Drawing.Size(75, 41)
        Me.btnUbah.TabIndex = 1
        Me.btnUbah.Text = "Ubah"
        Me.btnUbah.UseVisualStyleBackColor = True
        '
        'btnTambah
        '
        Me.btnTambah.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTambah.Location = New System.Drawing.Point(42, 306)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(72, 41)
        Me.btnTambah.TabIndex = 0
        Me.btnTambah.Text = "Tambah"
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'dgvMapel
        '
        Me.dgvMapel.BackgroundColor = System.Drawing.Color.SaddleBrown
        Me.dgvMapel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMapel.Location = New System.Drawing.Point(283, 85)
        Me.dgvMapel.Name = "dgvMapel"
        Me.dgvMapel.RowHeadersWidth = 51
        Me.dgvMapel.RowTemplate.Height = 24
        Me.dgvMapel.Size = New System.Drawing.Size(955, 441)
        Me.dgvMapel.TabIndex = 4
        '
        'lblJudulUC
        '
        Me.lblJudulUC.AutoSize = True
        Me.lblJudulUC.BackColor = System.Drawing.Color.Transparent
        Me.lblJudulUC.Font = New System.Drawing.Font("Verdana", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJudulUC.ForeColor = System.Drawing.Color.White
        Me.lblJudulUC.Location = New System.Drawing.Point(3, 17)
        Me.lblJudulUC.Name = "lblJudulUC"
        Me.lblJudulUC.Size = New System.Drawing.Size(360, 48)
        Me.lblJudulUC.TabIndex = 9
        Me.lblJudulUC.Text = "Mata Pelajaran"
        '
        'txtCariMapel
        '
        Me.txtCariMapel.Location = New System.Drawing.Point(780, 57)
        Me.txtCariMapel.Name = "txtCariMapel"
        Me.txtCariMapel.Size = New System.Drawing.Size(191, 22)
        Me.txtCariMapel.TabIndex = 17
        '
        'btnLihatHistory
        '
        Me.btnLihatHistory.BackColor = System.Drawing.Color.SaddleBrown
        Me.btnLihatHistory.ForeColor = System.Drawing.Color.White
        Me.btnLihatHistory.Location = New System.Drawing.Point(1035, 532)
        Me.btnLihatHistory.Name = "btnLihatHistory"
        Me.btnLihatHistory.Size = New System.Drawing.Size(81, 29)
        Me.btnLihatHistory.TabIndex = 21
        Me.btnLihatHistory.Text = "History"
        Me.btnLihatHistory.UseVisualStyleBackColor = False
        '
        'btnCatatHistoryKKM
        '
        Me.btnCatatHistoryKKM.BackColor = System.Drawing.Color.SaddleBrown
        Me.btnCatatHistoryKKM.ForeColor = System.Drawing.Color.White
        Me.btnCatatHistoryKKM.Location = New System.Drawing.Point(1122, 567)
        Me.btnCatatHistoryKKM.Name = "btnCatatHistoryKKM"
        Me.btnCatatHistoryKKM.Size = New System.Drawing.Size(106, 29)
        Me.btnCatatHistoryKKM.TabIndex = 22
        Me.btnCatatHistoryKKM.Text = "History KKM"
        Me.btnCatatHistoryKKM.UseVisualStyleBackColor = False
        '
        'btnExportPDF
        '
        Me.btnExportPDF.BackColor = System.Drawing.Color.SaddleBrown
        Me.btnExportPDF.ForeColor = System.Drawing.Color.White
        Me.btnExportPDF.Location = New System.Drawing.Point(1035, 567)
        Me.btnExportPDF.Name = "btnExportPDF"
        Me.btnExportPDF.Size = New System.Drawing.Size(81, 29)
        Me.btnExportPDF.TabIndex = 23
        Me.btnExportPDF.Text = "Print"
        Me.btnExportPDF.UseVisualStyleBackColor = False
        '
        'cmbFilterKelas
        '
        Me.cmbFilterKelas.FormattingEnabled = True
        Me.cmbFilterKelas.Location = New System.Drawing.Point(995, 17)
        Me.cmbFilterKelas.Name = "cmbFilterKelas"
        Me.cmbFilterKelas.Size = New System.Drawing.Size(121, 24)
        Me.cmbFilterKelas.TabIndex = 24
        '
        'UC_MataPelajaran
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Controls.Add(Me.cmbFilterKelas)
        Me.Controls.Add(Me.btnExportPDF)
        Me.Controls.Add(Me.btnCatatHistoryKKM)
        Me.Controls.Add(Me.btnLihatHistory)
        Me.Controls.Add(Me.txtCariMapel)
        Me.Controls.Add(Me.lblJudulUC)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgvMapel)
        Me.Name = "UC_MataPelajaran"
        Me.Size = New System.Drawing.Size(1241, 613)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvMapel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label6 As Label
    Friend WithEvents btnSimpan As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtKodeMapel As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents btnUbah As Button
    Friend WithEvents btnTambah As Button
    Friend WithEvents dgvMapel As DataGridView
    Friend WithEvents lblJudulUC As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNamaMapel As TextBox
    Friend WithEvents txtCariMapel As TextBox
    Friend WithEvents txtKKM As TextBox
    Friend WithEvents cmbJurusan As ComboBox
    Friend WithEvents btnLihatHistory As Button
    Friend WithEvents btnCatatHistoryKKM As Button
    Friend WithEvents btnExportPDF As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbFilterKelas As ComboBox
End Class
