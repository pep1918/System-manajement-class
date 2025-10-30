<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMain
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMain))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnManajemen = New System.Windows.Forms.Button()
        Me.btnMapel = New System.Windows.Forms.Button()
        Me.btnKelas = New System.Windows.Forms.Button()
        Me.btnGuru = New System.Windows.Forms.Button()
        Me.btnSiswa = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PanelUtama = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Location = New System.Drawing.Point(12, 91)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 565)
        Me.Panel1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.btnLogout)
        Me.GroupBox1.Controls.Add(Me.btnManajemen)
        Me.GroupBox1.Controls.Add(Me.btnMapel)
        Me.GroupBox1.Controls.Add(Me.btnKelas)
        Me.GroupBox1.Controls.Add(Me.btnGuru)
        Me.GroupBox1.Controls.Add(Me.btnSiswa)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(174, 619)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.SaddleBrown
        Me.btnLogout.ForeColor = System.Drawing.Color.White
        Me.btnLogout.Location = New System.Drawing.Point(6, 384)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(162, 38)
        Me.btnLogout.TabIndex = 5
        Me.btnLogout.Text = "Keluar"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'btnManajemen
        '
        Me.btnManajemen.BackColor = System.Drawing.Color.SaddleBrown
        Me.btnManajemen.ForeColor = System.Drawing.Color.White
        Me.btnManajemen.Location = New System.Drawing.Point(6, 254)
        Me.btnManajemen.Name = "btnManajemen"
        Me.btnManajemen.Size = New System.Drawing.Size(162, 38)
        Me.btnManajemen.TabIndex = 4
        Me.btnManajemen.Text = "Manajemen Pelajaran"
        Me.btnManajemen.UseVisualStyleBackColor = False
        '
        'btnMapel
        '
        Me.btnMapel.BackColor = System.Drawing.Color.SaddleBrown
        Me.btnMapel.ForeColor = System.Drawing.Color.White
        Me.btnMapel.Location = New System.Drawing.Point(6, 210)
        Me.btnMapel.Name = "btnMapel"
        Me.btnMapel.Size = New System.Drawing.Size(162, 38)
        Me.btnMapel.TabIndex = 3
        Me.btnMapel.Text = "Mata Pelajaran"
        Me.btnMapel.UseVisualStyleBackColor = False
        '
        'btnKelas
        '
        Me.btnKelas.BackColor = System.Drawing.Color.SaddleBrown
        Me.btnKelas.ForeColor = System.Drawing.Color.White
        Me.btnKelas.Location = New System.Drawing.Point(6, 166)
        Me.btnKelas.Name = "btnKelas"
        Me.btnKelas.Size = New System.Drawing.Size(162, 38)
        Me.btnKelas.TabIndex = 2
        Me.btnKelas.Text = "Data Kelas"
        Me.btnKelas.UseVisualStyleBackColor = False
        '
        'btnGuru
        '
        Me.btnGuru.BackColor = System.Drawing.Color.SaddleBrown
        Me.btnGuru.ForeColor = System.Drawing.Color.White
        Me.btnGuru.Location = New System.Drawing.Point(6, 122)
        Me.btnGuru.Name = "btnGuru"
        Me.btnGuru.Size = New System.Drawing.Size(162, 38)
        Me.btnGuru.TabIndex = 1
        Me.btnGuru.Text = "Data Guru"
        Me.btnGuru.UseVisualStyleBackColor = False
        '
        'btnSiswa
        '
        Me.btnSiswa.BackColor = System.Drawing.Color.SaddleBrown
        Me.btnSiswa.ForeColor = System.Drawing.Color.White
        Me.btnSiswa.Location = New System.Drawing.Point(6, 78)
        Me.btnSiswa.Name = "btnSiswa"
        Me.btnSiswa.Size = New System.Drawing.Size(162, 38)
        Me.btnSiswa.TabIndex = 0
        Me.btnSiswa.Text = "Data Siswa"
        Me.btnSiswa.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel2.Location = New System.Drawing.Point(232, 13)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(976, 72)
        Me.Panel2.TabIndex = 1
        '
        'PanelUtama
        '
        Me.PanelUtama.BackgroundImage = CType(resources.GetObject("PanelUtama.BackgroundImage"), System.Drawing.Image)
        Me.PanelUtama.Location = New System.Drawing.Point(232, 91)
        Me.PanelUtama.Name = "PanelUtama"
        Me.PanelUtama.Size = New System.Drawing.Size(976, 565)
        Me.PanelUtama.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(378, 48)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "SMAGA SCHOOL"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(9, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(157, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "DASHBOARD"
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1227, 644)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PanelUtama)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FormMain"
        Me.Text = "MenuUtama"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PanelUtama As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnKelas As Button
    Friend WithEvents btnGuru As Button
    Friend WithEvents btnSiswa As Button
    Friend WithEvents btnManajemen As Button
    Friend WithEvents btnMapel As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
