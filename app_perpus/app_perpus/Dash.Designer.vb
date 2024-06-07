<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formDashboard
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
        Me.lblNama = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.dashboard = New System.Windows.Forms.ToolStripMenuItem()
        Me.buku = New System.Windows.Forms.ToolStripMenuItem()
        Me.anggota = New System.Windows.Forms.ToolStripMenuItem()
        Me.user = New System.Windows.Forms.ToolStripMenuItem()
        Me.pinjam = New System.Windows.Forms.ToolStripMenuItem()
        Me.kembali = New System.Windows.Forms.ToolStripMenuItem()
        Me.laporan = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblRole = New System.Windows.Forms.Label()
        Me.pnlTotalBuku = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.lblTotalBuku = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pnlAnggota = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.lblTotalAnggota = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.pnlTotalPinjam = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.lblTotalPinjam = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2GradientPanel1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.Guna2PictureBox4 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2PictureBox3 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2PictureBox2 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.MenuStrip1.SuspendLayout()
        Me.pnlTotalBuku.SuspendLayout()
        Me.pnlAnggota.SuspendLayout()
        Me.pnlTotalPinjam.SuspendLayout()
        Me.Guna2GradientPanel1.SuspendLayout()
        CType(Me.Guna2PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblNama
        '
        Me.lblNama.AutoSize = True
        Me.lblNama.BackColor = System.Drawing.Color.Transparent
        Me.lblNama.Font = New System.Drawing.Font("Montserrat ExtraBold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNama.ForeColor = System.Drawing.Color.White
        Me.lblNama.Location = New System.Drawing.Point(117, 25)
        Me.lblNama.Name = "lblNama"
        Me.lblNama.Size = New System.Drawing.Size(64, 24)
        Me.lblNama.TabIndex = 0
        Me.lblNama.Text = "Nama"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.SteelBlue
        Me.MenuStrip1.Font = New System.Drawing.Font("Montserrat", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.dashboard, Me.buku, Me.anggota, Me.user, Me.pinjam, Me.kembali, Me.laporan})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(982, 32)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'dashboard
        '
        Me.dashboard.ForeColor = System.Drawing.Color.White
        Me.dashboard.Name = "dashboard"
        Me.dashboard.Size = New System.Drawing.Size(121, 28)
        Me.dashboard.Text = "Dashboard"
        '
        'buku
        '
        Me.buku.ForeColor = System.Drawing.Color.White
        Me.buku.Name = "buku"
        Me.buku.Size = New System.Drawing.Size(72, 28)
        Me.buku.Text = "Buku"
        '
        'anggota
        '
        Me.anggota.ForeColor = System.Drawing.Color.White
        Me.anggota.Name = "anggota"
        Me.anggota.Size = New System.Drawing.Size(101, 28)
        Me.anggota.Text = "Anggota"
        '
        'user
        '
        Me.user.ForeColor = System.Drawing.Color.White
        Me.user.Name = "user"
        Me.user.Size = New System.Drawing.Size(64, 28)
        Me.user.Text = "User"
        '
        'pinjam
        '
        Me.pinjam.ForeColor = System.Drawing.Color.White
        Me.pinjam.Name = "pinjam"
        Me.pinjam.Size = New System.Drawing.Size(137, 28)
        Me.pinjam.Text = "Peminjaman"
        '
        'kembali
        '
        Me.kembali.ForeColor = System.Drawing.Color.White
        Me.kembali.Name = "kembali"
        Me.kembali.Size = New System.Drawing.Size(154, 28)
        Me.kembali.Text = "Pengembalian"
        '
        'laporan
        '
        Me.laporan.ForeColor = System.Drawing.Color.White
        Me.laporan.Name = "laporan"
        Me.laporan.Size = New System.Drawing.Size(95, 28)
        Me.laporan.Text = "Laporan"
        '
        'lblRole
        '
        Me.lblRole.AutoSize = True
        Me.lblRole.BackColor = System.Drawing.Color.Transparent
        Me.lblRole.Font = New System.Drawing.Font("Montserrat", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRole.ForeColor = System.Drawing.Color.White
        Me.lblRole.Location = New System.Drawing.Point(117, 49)
        Me.lblRole.Name = "lblRole"
        Me.lblRole.Size = New System.Drawing.Size(49, 24)
        Me.lblRole.TabIndex = 2
        Me.lblRole.Text = "Role"
        '
        'pnlTotalBuku
        '
        Me.pnlTotalBuku.BackColor = System.Drawing.Color.Transparent
        Me.pnlTotalBuku.Controls.Add(Me.lblTotalBuku)
        Me.pnlTotalBuku.Controls.Add(Me.Guna2PictureBox2)
        Me.pnlTotalBuku.Controls.Add(Me.Label2)
        Me.pnlTotalBuku.FillColor = System.Drawing.Color.White
        Me.pnlTotalBuku.Location = New System.Drawing.Point(57, 263)
        Me.pnlTotalBuku.Name = "pnlTotalBuku"
        Me.pnlTotalBuku.Radius = 10
        Me.pnlTotalBuku.ShadowColor = System.Drawing.Color.Black
        Me.pnlTotalBuku.Size = New System.Drawing.Size(255, 241)
        Me.pnlTotalBuku.TabIndex = 3
        '
        'lblTotalBuku
        '
        Me.lblTotalBuku.AutoSize = True
        Me.lblTotalBuku.Font = New System.Drawing.Font("Caprasimo", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalBuku.ForeColor = System.Drawing.Color.SteelBlue
        Me.lblTotalBuku.Location = New System.Drawing.Point(117, 182)
        Me.lblTotalBuku.Name = "lblTotalBuku"
        Me.lblTotalBuku.Size = New System.Drawing.Size(22, 23)
        Me.lblTotalBuku.TabIndex = 8
        Me.lblTotalBuku.Text = "0"
        Me.lblTotalBuku.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Caprasimo", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label2.Location = New System.Drawing.Point(66, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 23)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Total Buku"
        '
        'pnlAnggota
        '
        Me.pnlAnggota.BackColor = System.Drawing.Color.Transparent
        Me.pnlAnggota.Controls.Add(Me.lblTotalAnggota)
        Me.pnlAnggota.Controls.Add(Me.Guna2PictureBox3)
        Me.pnlAnggota.Controls.Add(Me.Label4)
        Me.pnlAnggota.FillColor = System.Drawing.Color.White
        Me.pnlAnggota.Location = New System.Drawing.Point(363, 263)
        Me.pnlAnggota.Name = "pnlAnggota"
        Me.pnlAnggota.Radius = 10
        Me.pnlAnggota.ShadowColor = System.Drawing.Color.Black
        Me.pnlAnggota.Size = New System.Drawing.Size(255, 241)
        Me.pnlAnggota.TabIndex = 4
        '
        'lblTotalAnggota
        '
        Me.lblTotalAnggota.AutoSize = True
        Me.lblTotalAnggota.Font = New System.Drawing.Font("Caprasimo", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalAnggota.ForeColor = System.Drawing.Color.SteelBlue
        Me.lblTotalAnggota.Location = New System.Drawing.Point(117, 182)
        Me.lblTotalAnggota.Name = "lblTotalAnggota"
        Me.lblTotalAnggota.Size = New System.Drawing.Size(22, 23)
        Me.lblTotalAnggota.TabIndex = 11
        Me.lblTotalAnggota.Text = "0"
        Me.lblTotalAnggota.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Caprasimo", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label4.Location = New System.Drawing.Point(52, 39)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(154, 23)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Total Anggota"
        '
        'pnlTotalPinjam
        '
        Me.pnlTotalPinjam.BackColor = System.Drawing.Color.Transparent
        Me.pnlTotalPinjam.Controls.Add(Me.lblTotalPinjam)
        Me.pnlTotalPinjam.Controls.Add(Me.Guna2PictureBox4)
        Me.pnlTotalPinjam.Controls.Add(Me.Label5)
        Me.pnlTotalPinjam.FillColor = System.Drawing.Color.White
        Me.pnlTotalPinjam.Location = New System.Drawing.Point(663, 263)
        Me.pnlTotalPinjam.Name = "pnlTotalPinjam"
        Me.pnlTotalPinjam.Radius = 10
        Me.pnlTotalPinjam.ShadowColor = System.Drawing.Color.Black
        Me.pnlTotalPinjam.Size = New System.Drawing.Size(255, 241)
        Me.pnlTotalPinjam.TabIndex = 5
        '
        'lblTotalPinjam
        '
        Me.lblTotalPinjam.AutoSize = True
        Me.lblTotalPinjam.Font = New System.Drawing.Font("Caprasimo", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalPinjam.ForeColor = System.Drawing.Color.SteelBlue
        Me.lblTotalPinjam.Location = New System.Drawing.Point(115, 182)
        Me.lblTotalPinjam.Name = "lblTotalPinjam"
        Me.lblTotalPinjam.Size = New System.Drawing.Size(22, 23)
        Me.lblTotalPinjam.TabIndex = 14
        Me.lblTotalPinjam.Text = "0"
        Me.lblTotalPinjam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Caprasimo", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label5.Location = New System.Drawing.Point(57, 39)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(139, 23)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Total Pinjam"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Caprasimo", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label1.Location = New System.Drawing.Point(413, 200)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(169, 32)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Dashboard"
        '
        'Guna2GradientPanel1
        '
        Me.Guna2GradientPanel1.BorderRadius = 10
        Me.Guna2GradientPanel1.Controls.Add(Me.Guna2PictureBox1)
        Me.Guna2GradientPanel1.Controls.Add(Me.lblNama)
        Me.Guna2GradientPanel1.Controls.Add(Me.lblRole)
        Me.Guna2GradientPanel1.FillColor = System.Drawing.Color.SteelBlue
        Me.Guna2GradientPanel1.FillColor2 = System.Drawing.Color.PowderBlue
        Me.Guna2GradientPanel1.Location = New System.Drawing.Point(57, 69)
        Me.Guna2GradientPanel1.Name = "Guna2GradientPanel1"
        Me.Guna2GradientPanel1.Size = New System.Drawing.Size(861, 100)
        Me.Guna2GradientPanel1.TabIndex = 7
        '
        'Guna2PictureBox4
        '
        Me.Guna2PictureBox4.Image = Global.app_perpus.My.Resources.Resources.gbpinjam
        Me.Guna2PictureBox4.ImageRotate = 0!
        Me.Guna2PictureBox4.Location = New System.Drawing.Point(80, 79)
        Me.Guna2PictureBox4.Name = "Guna2PictureBox4"
        Me.Guna2PictureBox4.Size = New System.Drawing.Size(95, 88)
        Me.Guna2PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox4.TabIndex = 12
        Me.Guna2PictureBox4.TabStop = False
        '
        'Guna2PictureBox3
        '
        Me.Guna2PictureBox3.Image = Global.app_perpus.My.Resources.Resources.gbmember
        Me.Guna2PictureBox3.ImageRotate = 0!
        Me.Guna2PictureBox3.Location = New System.Drawing.Point(82, 79)
        Me.Guna2PictureBox3.Name = "Guna2PictureBox3"
        Me.Guna2PictureBox3.Size = New System.Drawing.Size(95, 88)
        Me.Guna2PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox3.TabIndex = 9
        Me.Guna2PictureBox3.TabStop = False
        '
        'Guna2PictureBox2
        '
        Me.Guna2PictureBox2.Image = Global.app_perpus.My.Resources.Resources.gbbuku
        Me.Guna2PictureBox2.ImageRotate = 0!
        Me.Guna2PictureBox2.Location = New System.Drawing.Point(82, 79)
        Me.Guna2PictureBox2.Name = "Guna2PictureBox2"
        Me.Guna2PictureBox2.Size = New System.Drawing.Size(95, 88)
        Me.Guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox2.TabIndex = 7
        Me.Guna2PictureBox2.TabStop = False
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.Image = Global.app_perpus.My.Resources.Resources.gbuser
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(20, 6)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(91, 88)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 3
        Me.Guna2PictureBox1.TabStop = False
        '
        'formDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(982, 553)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pnlTotalPinjam)
        Me.Controls.Add(Me.pnlAnggota)
        Me.Controls.Add(Me.pnlTotalBuku)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Guna2GradientPanel1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "formDashboard"
        Me.Text = "Dashboard"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.pnlTotalBuku.ResumeLayout(False)
        Me.pnlTotalBuku.PerformLayout()
        Me.pnlAnggota.ResumeLayout(False)
        Me.pnlAnggota.PerformLayout()
        Me.pnlTotalPinjam.ResumeLayout(False)
        Me.pnlTotalPinjam.PerformLayout()
        Me.Guna2GradientPanel1.ResumeLayout(False)
        Me.Guna2GradientPanel1.PerformLayout()
        CType(Me.Guna2PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNama As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents dashboard As ToolStripMenuItem
    Friend WithEvents buku As ToolStripMenuItem
    Friend WithEvents anggota As ToolStripMenuItem
    Friend WithEvents user As ToolStripMenuItem
    Friend WithEvents pinjam As ToolStripMenuItem
    Friend WithEvents kembali As ToolStripMenuItem
    Friend WithEvents laporan As ToolStripMenuItem
    Friend WithEvents lblRole As Label
    Friend WithEvents pnlTotalBuku As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents pnlAnggota As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents pnlTotalPinjam As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2PictureBox2 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblTotalBuku As Label
    Friend WithEvents lblTotalAnggota As Label
    Friend WithEvents Guna2PictureBox3 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lblTotalPinjam As Label
    Friend WithEvents Guna2PictureBox4 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Guna2GradientPanel1 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
End Class
