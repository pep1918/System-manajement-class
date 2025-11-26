<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMain
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMain))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnLogOut = New System.Windows.Forms.Button()
        Me.btnLaporan = New System.Windows.Forms.Button()
        Me.btnDashboard = New System.Windows.Forms.Button()
        Me.btnDataKelas = New System.Windows.Forms.Button()
        Me.btnDataSiswa = New System.Windows.Forms.Button()
        Me.btnDataGuru = New System.Windows.Forms.Button()
        Me.btnManajemenPelajaran = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelUtama = New System.Windows.Forms.Panel()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.LabelAlamat = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.LabelNamaPerpustakaan = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ButtonAnggota = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.lblJumlahKelas = New System.Windows.Forms.Label()
        Me.lblJmlKelas = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ButtonPeminjaman = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.ksks = New System.Windows.Forms.Label()
        Me.lblJmlGuru = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.ButtonPetugas = New System.Windows.Forms.Button()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblJmlSiswa = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.PanelUtama.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnLogOut)
        Me.Panel1.Controls.Add(Me.btnLaporan)
        Me.Panel1.Controls.Add(Me.btnDashboard)
        Me.Panel1.Controls.Add(Me.btnDataKelas)
        Me.Panel1.Controls.Add(Me.btnDataSiswa)
        Me.Panel1.Controls.Add(Me.btnDataGuru)
        Me.Panel1.Controls.Add(Me.btnManajemenPelajaran)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(259, 810)
        Me.Panel1.TabIndex = 0
        '
        'btnLogOut
        '
        Me.btnLogOut.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btnLogOut.ForeColor = System.Drawing.Color.White
        Me.btnLogOut.Location = New System.Drawing.Point(14, 736)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.Size = New System.Drawing.Size(223, 49)
        Me.btnLogOut.TabIndex = 25
        Me.btnLogOut.Text = "Keluar"
        Me.btnLogOut.UseVisualStyleBackColor = False
        '
        'btnLaporan
        '
        Me.btnLaporan.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.btnLaporan.ForeColor = System.Drawing.Color.White
        Me.btnLaporan.Location = New System.Drawing.Point(14, 548)
        Me.btnLaporan.Name = "btnLaporan"
        Me.btnLaporan.Size = New System.Drawing.Size(223, 49)
        Me.btnLaporan.TabIndex = 23
        Me.btnLaporan.Text = "Laporan"
        Me.btnLaporan.UseVisualStyleBackColor = False
        '
        'btnDashboard
        '
        Me.btnDashboard.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.btnDashboard.ForeColor = System.Drawing.Color.White
        Me.btnDashboard.Location = New System.Drawing.Point(12, 237)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Size = New System.Drawing.Size(225, 61)
        Me.btnDashboard.TabIndex = 22
        Me.btnDashboard.Text = "Dashboard"
        Me.btnDashboard.UseVisualStyleBackColor = False
        '
        'btnDataKelas
        '
        Me.btnDataKelas.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.btnDataKelas.ForeColor = System.Drawing.Color.White
        Me.btnDataKelas.Location = New System.Drawing.Point(14, 434)
        Me.btnDataKelas.Name = "btnDataKelas"
        Me.btnDataKelas.Size = New System.Drawing.Size(223, 53)
        Me.btnDataKelas.TabIndex = 19
        Me.btnDataKelas.Text = "Data Kelas"
        Me.btnDataKelas.UseVisualStyleBackColor = False
        '
        'btnDataSiswa
        '
        Me.btnDataSiswa.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.btnDataSiswa.ForeColor = System.Drawing.Color.White
        Me.btnDataSiswa.Location = New System.Drawing.Point(12, 304)
        Me.btnDataSiswa.Name = "btnDataSiswa"
        Me.btnDataSiswa.Size = New System.Drawing.Size(225, 61)
        Me.btnDataSiswa.TabIndex = 17
        Me.btnDataSiswa.Text = "Data Siswa"
        Me.btnDataSiswa.UseVisualStyleBackColor = False
        '
        'btnDataGuru
        '
        Me.btnDataGuru.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.btnDataGuru.ForeColor = System.Drawing.Color.White
        Me.btnDataGuru.Location = New System.Drawing.Point(12, 372)
        Me.btnDataGuru.Name = "btnDataGuru"
        Me.btnDataGuru.Size = New System.Drawing.Size(225, 56)
        Me.btnDataGuru.TabIndex = 18
        Me.btnDataGuru.Text = "Data Guru"
        Me.btnDataGuru.UseVisualStyleBackColor = False
        '
        'btnManajemenPelajaran
        '
        Me.btnManajemenPelajaran.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.btnManajemenPelajaran.ForeColor = System.Drawing.Color.White
        Me.btnManajemenPelajaran.Location = New System.Drawing.Point(14, 493)
        Me.btnManajemenPelajaran.Name = "btnManajemenPelajaran"
        Me.btnManajemenPelajaran.Size = New System.Drawing.Size(223, 49)
        Me.btnManajemenPelajaran.TabIndex = 21
        Me.btnManajemenPelajaran.Text = "Manajemen Pelajaran"
        Me.btnManajemenPelajaran.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(259, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1312, 122)
        Me.Panel2.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(57, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(456, 53)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Manajemen Kelas"
        '
        'PanelUtama
        '
        Me.PanelUtama.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.PanelUtama.Controls.Add(Me.GroupBox6)
        Me.PanelUtama.Controls.Add(Me.GroupBox2)
        Me.PanelUtama.Controls.Add(Me.GroupBox3)
        Me.PanelUtama.Controls.Add(Me.GroupBox4)
        Me.PanelUtama.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelUtama.Location = New System.Drawing.Point(259, 122)
        Me.PanelUtama.Name = "PanelUtama"
        Me.PanelUtama.Size = New System.Drawing.Size(1312, 688)
        Me.PanelUtama.TabIndex = 2
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.GroupBox6.Controls.Add(Me.LabelAlamat)
        Me.GroupBox6.Controls.Add(Me.Label13)
        Me.GroupBox6.Controls.Add(Me.LabelNamaPerpustakaan)
        Me.GroupBox6.Controls.Add(Me.Panel8)
        Me.GroupBox6.Controls.Add(Me.Label7)
        Me.GroupBox6.Controls.Add(Me.Label10)
        Me.GroupBox6.Location = New System.Drawing.Point(42, 280)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(1115, 277)
        Me.GroupBox6.TabIndex = 33
        Me.GroupBox6.TabStop = False
        '
        'LabelAlamat
        '
        Me.LabelAlamat.AutoSize = True
        Me.LabelAlamat.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAlamat.ForeColor = System.Drawing.Color.White
        Me.LabelAlamat.Location = New System.Drawing.Point(65, 133)
        Me.LabelAlamat.Name = "LabelAlamat"
        Me.LabelAlamat.Size = New System.Drawing.Size(107, 20)
        Me.LabelAlamat.TabIndex = 7
        Me.LabelAlamat.Text = "Jalan Mexico"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(46, 108)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(67, 20)
        Me.Label13.TabIndex = 6
        Me.Label13.Text = "Alamat"
        '
        'LabelNamaPerpustakaan
        '
        Me.LabelNamaPerpustakaan.AutoSize = True
        Me.LabelNamaPerpustakaan.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNamaPerpustakaan.ForeColor = System.Drawing.Color.White
        Me.LabelNamaPerpustakaan.Location = New System.Drawing.Point(65, 82)
        Me.LabelNamaPerpustakaan.Name = "LabelNamaPerpustakaan"
        Me.LabelNamaPerpustakaan.Size = New System.Drawing.Size(152, 20)
        Me.LabelNamaPerpustakaan.TabIndex = 5
        Me.LabelNamaPerpustakaan.Text = "SMA 200 Surabaya"
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.Transparent
        Me.Panel8.BackgroundImage = CType(resources.GetObject("Panel8.BackgroundImage"), System.Drawing.Image)
        Me.Panel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel8.Location = New System.Drawing.Point(13, 21)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(26, 22)
        Me.Panel8.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(45, 21)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(328, 26)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Data Untuk Manajemen Kelas"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(46, 57)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(177, 20)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "Nama Perpustakaan"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Crimson
        Me.GroupBox2.Controls.Add(Me.ButtonAnggota)
        Me.GroupBox2.Controls.Add(Me.Panel5)
        Me.GroupBox2.Controls.Add(Me.lblJumlahKelas)
        Me.GroupBox2.Controls.Add(Me.lblJmlKelas)
        Me.GroupBox2.Location = New System.Drawing.Point(639, 76)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(270, 138)
        Me.GroupBox2.TabIndex = 32
        Me.GroupBox2.TabStop = False
        '
        'ButtonAnggota
        '
        Me.ButtonAnggota.Enabled = False
        Me.ButtonAnggota.Location = New System.Drawing.Point(0, 116)
        Me.ButtonAnggota.Name = "ButtonAnggota"
        Me.ButtonAnggota.Size = New System.Drawing.Size(270, 23)
        Me.ButtonAnggota.TabIndex = 5
        Me.ButtonAnggota.UseVisualStyleBackColor = True
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Transparent
        Me.Panel5.BackgroundImage = CType(resources.GetObject("Panel5.BackgroundImage"), System.Drawing.Image)
        Me.Panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel5.Location = New System.Drawing.Point(194, 51)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(56, 57)
        Me.Panel5.TabIndex = 3
        '
        'lblJumlahKelas
        '
        Me.lblJumlahKelas.AutoSize = True
        Me.lblJumlahKelas.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJumlahKelas.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblJumlahKelas.Location = New System.Drawing.Point(8, 17)
        Me.lblJumlahKelas.Name = "lblJumlahKelas"
        Me.lblJumlahKelas.Size = New System.Drawing.Size(156, 26)
        Me.lblJumlahKelas.TabIndex = 4
        Me.lblJumlahKelas.Text = "Jumlah Kelas"
        '
        'lblJmlKelas
        '
        Me.lblJmlKelas.AutoSize = True
        Me.lblJmlKelas.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJmlKelas.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblJmlKelas.Location = New System.Drawing.Point(79, 61)
        Me.lblJmlKelas.Name = "lblJmlKelas"
        Me.lblJmlKelas.Size = New System.Drawing.Size(31, 32)
        Me.lblJmlKelas.TabIndex = 3
        Me.lblJmlKelas.Text = "5"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.DeepPink
        Me.GroupBox3.Controls.Add(Me.ButtonPeminjaman)
        Me.GroupBox3.Controls.Add(Me.Panel4)
        Me.GroupBox3.Controls.Add(Me.ksks)
        Me.GroupBox3.Controls.Add(Me.lblJmlGuru)
        Me.GroupBox3.Location = New System.Drawing.Point(363, 75)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(270, 138)
        Me.GroupBox3.TabIndex = 31
        Me.GroupBox3.TabStop = False
        '
        'ButtonPeminjaman
        '
        Me.ButtonPeminjaman.Enabled = False
        Me.ButtonPeminjaman.Location = New System.Drawing.Point(0, 116)
        Me.ButtonPeminjaman.Name = "ButtonPeminjaman"
        Me.ButtonPeminjaman.Size = New System.Drawing.Size(270, 23)
        Me.ButtonPeminjaman.TabIndex = 8
        Me.ButtonPeminjaman.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Transparent
        Me.Panel4.BackgroundImage = CType(resources.GetObject("Panel4.BackgroundImage"), System.Drawing.Image)
        Me.Panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel4.Location = New System.Drawing.Point(193, 51)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(71, 57)
        Me.Panel4.TabIndex = 5
        '
        'ksks
        '
        Me.ksks.AutoSize = True
        Me.ksks.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ksks.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ksks.Location = New System.Drawing.Point(6, 19)
        Me.ksks.Name = "ksks"
        Me.ksks.Size = New System.Drawing.Size(148, 26)
        Me.ksks.TabIndex = 7
        Me.ksks.Text = "Jumlah Guru"
        '
        'lblJmlGuru
        '
        Me.lblJmlGuru.AutoSize = True
        Me.lblJmlGuru.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJmlGuru.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblJmlGuru.Location = New System.Drawing.Point(96, 59)
        Me.lblJmlGuru.Name = "lblJmlGuru"
        Me.lblJmlGuru.Size = New System.Drawing.Size(31, 32)
        Me.lblJmlGuru.TabIndex = 6
        Me.lblJmlGuru.Text = "5"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Orange
        Me.GroupBox4.Controls.Add(Me.ButtonPetugas)
        Me.GroupBox4.Controls.Add(Me.Panel6)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.lblJmlSiswa)
        Me.GroupBox4.Location = New System.Drawing.Point(67, 74)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(270, 138)
        Me.GroupBox4.TabIndex = 30
        Me.GroupBox4.TabStop = False
        '
        'ButtonPetugas
        '
        Me.ButtonPetugas.Enabled = False
        Me.ButtonPetugas.Location = New System.Drawing.Point(0, 116)
        Me.ButtonPetugas.Name = "ButtonPetugas"
        Me.ButtonPetugas.Size = New System.Drawing.Size(270, 23)
        Me.ButtonPetugas.TabIndex = 9
        Me.ButtonPetugas.UseVisualStyleBackColor = True
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Transparent
        Me.Panel6.BackgroundImage = CType(resources.GetObject("Panel6.BackgroundImage"), System.Drawing.Image)
        Me.Panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel6.Location = New System.Drawing.Point(200, 44)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(64, 58)
        Me.Panel6.TabIndex = 8
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label11.Location = New System.Drawing.Point(6, 18)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(160, 26)
        Me.Label11.TabIndex = 7
        Me.Label11.Text = "Jumlah Siswa"
        '
        'lblJmlSiswa
        '
        Me.lblJmlSiswa.AutoSize = True
        Me.lblJmlSiswa.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJmlSiswa.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblJmlSiswa.Location = New System.Drawing.Point(95, 62)
        Me.lblJmlSiswa.Name = "lblJmlSiswa"
        Me.lblJmlSiswa.Size = New System.Drawing.Size(31, 32)
        Me.lblJmlSiswa.TabIndex = 6
        Me.lblJmlSiswa.Text = "5"
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1571, 810)
        Me.Controls.Add(Me.PanelUtama)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FormMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MenuUtama"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.PanelUtama.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PanelUtama As Panel
    Friend WithEvents btnLaporan As Button
    Friend WithEvents btnDashboard As Button
    Friend WithEvents btnDataKelas As Button
    Friend WithEvents btnDataSiswa As Button
    Friend WithEvents btnDataGuru As Button
    Friend WithEvents btnManajemenPelajaran As Button
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents LabelAlamat As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents LabelNamaPerpustakaan As Label
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ButtonAnggota As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents lblJumlahKelas As Label
    Friend WithEvents lblJmlKelas As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents ButtonPeminjaman As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents ksks As Label
    Friend WithEvents lblJmlGuru As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label11 As Label
    Friend WithEvents lblJmlSiswa As Label
    Friend WithEvents btnLogOut As Button
    Friend WithEvents ButtonPetugas As Button
    Friend WithEvents Label1 As Label
End Class
