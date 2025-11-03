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
        Me.btnDataKelas = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnDataGuru = New System.Windows.Forms.Button()
        Me.btnManajemenPelajaran = New System.Windows.Forms.Button()
        Me.btnMataPelajaran = New System.Windows.Forms.Button()
        Me.btnDataSiswa = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelUtama = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.PanelUtama.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(255, 655)
        Me.Panel1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnDataKelas)
        Me.GroupBox1.Controls.Add(Me.btnLogout)
        Me.GroupBox1.Controls.Add(Me.btnDataGuru)
        Me.GroupBox1.Controls.Add(Me.btnManajemenPelajaran)
        Me.GroupBox1.Controls.Add(Me.btnMataPelajaran)
        Me.GroupBox1.Controls.Add(Me.btnDataSiswa)
        Me.GroupBox1.Location = New System.Drawing.Point(19, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(220, 611)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        '
        'btnDataKelas
        '
        Me.btnDataKelas.BackColor = System.Drawing.Color.SaddleBrown
        Me.btnDataKelas.ForeColor = System.Drawing.Color.White
        Me.btnDataKelas.Location = New System.Drawing.Point(10, 104)
        Me.btnDataKelas.Name = "btnDataKelas"
        Me.btnDataKelas.Size = New System.Drawing.Size(199, 38)
        Me.btnDataKelas.TabIndex = 2
        Me.btnDataKelas.Text = "Data Kelas"
        Me.btnDataKelas.UseVisualStyleBackColor = False
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.SaddleBrown
        Me.btnLogout.ForeColor = System.Drawing.Color.White
        Me.btnLogout.Location = New System.Drawing.Point(6, 567)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(199, 38)
        Me.btnLogout.TabIndex = 5
        Me.btnLogout.Text = "Keluar"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'btnDataGuru
        '
        Me.btnDataGuru.BackColor = System.Drawing.Color.SaddleBrown
        Me.btnDataGuru.ForeColor = System.Drawing.Color.White
        Me.btnDataGuru.Location = New System.Drawing.Point(10, 60)
        Me.btnDataGuru.Name = "btnDataGuru"
        Me.btnDataGuru.Size = New System.Drawing.Size(199, 38)
        Me.btnDataGuru.TabIndex = 1
        Me.btnDataGuru.Text = "Data Guru"
        Me.btnDataGuru.UseVisualStyleBackColor = False
        '
        'btnManajemenPelajaran
        '
        Me.btnManajemenPelajaran.BackColor = System.Drawing.Color.SaddleBrown
        Me.btnManajemenPelajaran.ForeColor = System.Drawing.Color.White
        Me.btnManajemenPelajaran.Location = New System.Drawing.Point(10, 192)
        Me.btnManajemenPelajaran.Name = "btnManajemenPelajaran"
        Me.btnManajemenPelajaran.Size = New System.Drawing.Size(199, 38)
        Me.btnManajemenPelajaran.TabIndex = 4
        Me.btnManajemenPelajaran.Text = "Manajemen Pelajaran"
        Me.btnManajemenPelajaran.UseVisualStyleBackColor = False
        '
        'btnMataPelajaran
        '
        Me.btnMataPelajaran.BackColor = System.Drawing.Color.SaddleBrown
        Me.btnMataPelajaran.ForeColor = System.Drawing.Color.White
        Me.btnMataPelajaran.Location = New System.Drawing.Point(10, 148)
        Me.btnMataPelajaran.Name = "btnMataPelajaran"
        Me.btnMataPelajaran.Size = New System.Drawing.Size(199, 38)
        Me.btnMataPelajaran.TabIndex = 3
        Me.btnMataPelajaran.Text = "Mata Pelajaran"
        Me.btnMataPelajaran.UseVisualStyleBackColor = False
        '
        'btnDataSiswa
        '
        Me.btnDataSiswa.BackColor = System.Drawing.Color.SaddleBrown
        Me.btnDataSiswa.ForeColor = System.Drawing.Color.White
        Me.btnDataSiswa.Location = New System.Drawing.Point(10, 16)
        Me.btnDataSiswa.Name = "btnDataSiswa"
        Me.btnDataSiswa.Size = New System.Drawing.Size(199, 38)
        Me.btnDataSiswa.TabIndex = 0
        Me.btnDataSiswa.Text = "Data Siswa"
        Me.btnDataSiswa.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel2.Location = New System.Drawing.Point(255, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1078, 72)
        Me.Panel2.TabIndex = 1
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
        'PanelUtama
        '
        Me.PanelUtama.BackgroundImage = CType(resources.GetObject("PanelUtama.BackgroundImage"), System.Drawing.Image)
        Me.PanelUtama.Controls.Add(Me.Label2)
        Me.PanelUtama.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelUtama.Location = New System.Drawing.Point(255, 72)
        Me.PanelUtama.Name = "PanelUtama"
        Me.PanelUtama.Size = New System.Drawing.Size(1078, 583)
        Me.PanelUtama.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(247, -33)
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
        Me.ClientSize = New System.Drawing.Size(1333, 655)
        Me.Controls.Add(Me.PanelUtama)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FormMain"
        Me.Text = "MenuUtama"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.PanelUtama.ResumeLayout(False)
        Me.PanelUtama.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PanelUtama As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnManajemenPelajaran As Button
    Friend WithEvents btnDataSiswa As Button
    Friend WithEvents btnMataPelajaran As Button
    Friend WithEvents btnDataGuru As Button
    Friend WithEvents btnDataKelas As Button
    Friend WithEvents GroupBox1 As GroupBox
End Class
