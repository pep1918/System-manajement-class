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
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Location = New System.Drawing.Point(12, 91)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 565)
        Me.Panel1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnLogout)
        Me.GroupBox1.Controls.Add(Me.btnManajemen)
        Me.GroupBox1.Controls.Add(Me.btnMapel)
        Me.GroupBox1.Controls.Add(Me.btnKelas)
        Me.GroupBox1.Controls.Add(Me.btnGuru)
        Me.GroupBox1.Controls.Add(Me.btnSiswa)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(174, 529)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'btnLogout
        '
        Me.btnLogout.Location = New System.Drawing.Point(21, 449)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(162, 38)
        Me.btnLogout.TabIndex = 5
        Me.btnLogout.Text = "Keluar"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'btnManajemen
        '
        Me.btnManajemen.Location = New System.Drawing.Point(6, 228)
        Me.btnManajemen.Name = "btnManajemen"
        Me.btnManajemen.Size = New System.Drawing.Size(162, 38)
        Me.btnManajemen.TabIndex = 4
        Me.btnManajemen.Text = "Manajemen Pelajaran"
        Me.btnManajemen.UseVisualStyleBackColor = True
        '
        'btnMapel
        '
        Me.btnMapel.Location = New System.Drawing.Point(6, 184)
        Me.btnMapel.Name = "btnMapel"
        Me.btnMapel.Size = New System.Drawing.Size(162, 38)
        Me.btnMapel.TabIndex = 3
        Me.btnMapel.Text = "Mata Pelajaran"
        Me.btnMapel.UseVisualStyleBackColor = True
        '
        'btnKelas
        '
        Me.btnKelas.Location = New System.Drawing.Point(6, 140)
        Me.btnKelas.Name = "btnKelas"
        Me.btnKelas.Size = New System.Drawing.Size(162, 38)
        Me.btnKelas.TabIndex = 2
        Me.btnKelas.Text = "Data Kelas"
        Me.btnKelas.UseVisualStyleBackColor = True
        '
        'btnGuru
        '
        Me.btnGuru.Location = New System.Drawing.Point(6, 96)
        Me.btnGuru.Name = "btnGuru"
        Me.btnGuru.Size = New System.Drawing.Size(162, 38)
        Me.btnGuru.TabIndex = 1
        Me.btnGuru.Text = "Data Guru"
        Me.btnGuru.UseVisualStyleBackColor = True
        '
        'btnSiswa
        '
        Me.btnSiswa.Location = New System.Drawing.Point(6, 52)
        Me.btnSiswa.Name = "btnSiswa"
        Me.btnSiswa.Size = New System.Drawing.Size(162, 38)
        Me.btnSiswa.TabIndex = 0
        Me.btnSiswa.Text = "Data Siswa"
        Me.btnSiswa.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Location = New System.Drawing.Point(232, 13)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(976, 72)
        Me.Panel2.TabIndex = 1
        '
        'PanelUtama
        '
        Me.PanelUtama.Location = New System.Drawing.Point(232, 91)
        Me.PanelUtama.Name = "PanelUtama"
        Me.PanelUtama.Size = New System.Drawing.Size(976, 565)
        Me.PanelUtama.TabIndex = 2
        '
        'Panel4
        '
        Me.Panel4.Location = New System.Drawing.Point(12, 12)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(200, 73)
        Me.Panel4.TabIndex = 3
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1227, 644)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.PanelUtama)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FormMain"
        Me.Text = "MenuUtama"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PanelUtama As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnKelas As Button
    Friend WithEvents btnGuru As Button
    Friend WithEvents btnSiswa As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btnManajemen As Button
    Friend WithEvents btnMapel As Button
    Friend WithEvents btnLogout As Button
End Class
