<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formUser
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.dashboard = New System.Windows.Forms.ToolStripMenuItem()
        Me.buku = New System.Windows.Forms.ToolStripMenuItem()
        Me.anggota = New System.Windows.Forms.ToolStripMenuItem()
        Me.user = New System.Windows.Forms.ToolStripMenuItem()
        Me.pinjam = New System.Windows.Forms.ToolStripMenuItem()
        Me.kembali = New System.Windows.Forms.ToolStripMenuItem()
        Me.laporan = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbUser = New Guna.UI2.WinForms.Guna2TextBox()
        Me.tbRole = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.tbPass = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnTambah = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.dgvUser = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.kodeUser = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.namaUser = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.passUser = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.roleUser = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnHapus = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.tbCari = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.dgvUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.MenuStrip1.TabIndex = 4
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
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Caprasimo", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label6.Location = New System.Drawing.Point(105, 228)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(185, 32)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Master User"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Montserrat", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(39, 383)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 21)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Role"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Montserrat", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(39, 293)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 21)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Username"
        '
        'tbUser
        '
        Me.tbUser.BorderRadius = 5
        Me.tbUser.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbUser.DefaultText = ""
        Me.tbUser.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbUser.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbUser.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbUser.Font = New System.Drawing.Font("Montserrat SemiBold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbUser.ForeColor = System.Drawing.Color.Black
        Me.tbUser.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbUser.Location = New System.Drawing.Point(132, 290)
        Me.tbUser.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbUser.Name = "tbUser"
        Me.tbUser.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbUser.PlaceholderText = ""
        Me.tbUser.SelectedText = ""
        Me.tbUser.Size = New System.Drawing.Size(214, 31)
        Me.tbUser.TabIndex = 27
        '
        'tbRole
        '
        Me.tbRole.BackColor = System.Drawing.Color.Transparent
        Me.tbRole.BorderRadius = 5
        Me.tbRole.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.tbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.tbRole.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbRole.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbRole.Font = New System.Drawing.Font("Montserrat SemiBold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbRole.ForeColor = System.Drawing.Color.Black
        Me.tbRole.ItemHeight = 30
        Me.tbRole.Items.AddRange(New Object() {"Admin", "Owner", "Pengelola"})
        Me.tbRole.Location = New System.Drawing.Point(132, 377)
        Me.tbRole.Name = "tbRole"
        Me.tbRole.Size = New System.Drawing.Size(214, 36)
        Me.tbRole.TabIndex = 28
        '
        'tbPass
        '
        Me.tbPass.BorderRadius = 5
        Me.tbPass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbPass.DefaultText = ""
        Me.tbPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbPass.Font = New System.Drawing.Font("Montserrat SemiBold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbPass.ForeColor = System.Drawing.Color.Black
        Me.tbPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbPass.Location = New System.Drawing.Point(132, 333)
        Me.tbPass.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbPass.Name = "tbPass"
        Me.tbPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbPass.PlaceholderText = ""
        Me.tbPass.SelectedText = ""
        Me.tbPass.Size = New System.Drawing.Size(214, 31)
        Me.tbPass.TabIndex = 30
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Montserrat", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(39, 336)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 21)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Password"
        '
        'btnTambah
        '
        Me.btnTambah.BorderRadius = 5
        Me.btnTambah.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnTambah.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnTambah.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnTambah.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnTambah.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnTambah.FillColor = System.Drawing.Color.SteelBlue
        Me.btnTambah.FillColor2 = System.Drawing.Color.SteelBlue
        Me.btnTambah.Font = New System.Drawing.Font("Montserrat", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTambah.ForeColor = System.Drawing.Color.White
        Me.btnTambah.Location = New System.Drawing.Point(43, 439)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(303, 38)
        Me.btnTambah.TabIndex = 40
        Me.btnTambah.Text = "Tambah"
        '
        'dgvUser
        '
        Me.dgvUser.AllowUserToResizeColumns = False
        Me.dgvUser.AllowUserToResizeRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Montserrat Medium", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvUser.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Montserrat", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvUser.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvUser.ColumnHeadersHeight = 40
        Me.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvUser.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.kodeUser, Me.namaUser, Me.passUser, Me.roleUser, Me.btnHapus})
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Montserrat Medium", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvUser.DefaultCellStyle = DataGridViewCellStyle7
        Me.dgvUser.GridColor = System.Drawing.Color.SteelBlue
        Me.dgvUser.Location = New System.Drawing.Point(400, 96)
        Me.dgvUser.Name = "dgvUser"
        Me.dgvUser.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Montserrat", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvUser.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dgvUser.RowHeadersVisible = False
        Me.dgvUser.RowHeadersWidth = 51
        Me.dgvUser.RowTemplate.Height = 25
        Me.dgvUser.Size = New System.Drawing.Size(569, 447)
        Me.dgvUser.TabIndex = 44
        Me.dgvUser.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvUser.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvUser.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvUser.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvUser.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvUser.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgvUser.ThemeStyle.GridColor = System.Drawing.Color.SteelBlue
        Me.dgvUser.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvUser.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvUser.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvUser.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvUser.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvUser.ThemeStyle.HeaderStyle.Height = 40
        Me.dgvUser.ThemeStyle.ReadOnly = False
        Me.dgvUser.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvUser.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvUser.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvUser.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgvUser.ThemeStyle.RowsStyle.Height = 25
        Me.dgvUser.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvUser.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'kodeUser
        '
        Me.kodeUser.HeaderText = "Kode"
        Me.kodeUser.MinimumWidth = 6
        Me.kodeUser.Name = "kodeUser"
        '
        'namaUser
        '
        Me.namaUser.HeaderText = "Nama"
        Me.namaUser.MinimumWidth = 6
        Me.namaUser.Name = "namaUser"
        '
        'passUser
        '
        Me.passUser.HeaderText = "Password"
        Me.passUser.MinimumWidth = 6
        Me.passUser.Name = "passUser"
        '
        'roleUser
        '
        Me.roleUser.HeaderText = "Role"
        Me.roleUser.MinimumWidth = 6
        Me.roleUser.Name = "roleUser"
        '
        'btnHapus
        '
        Me.btnHapus.HeaderText = ""
        Me.btnHapus.MinimumWidth = 6
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.btnHapus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.btnHapus.Text = "HAPUS"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'tbCari
        '
        Me.tbCari.BorderRadius = 10
        Me.tbCari.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbCari.DefaultText = ""
        Me.tbCari.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbCari.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbCari.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbCari.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbCari.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbCari.Font = New System.Drawing.Font("Montserrat SemiBold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbCari.ForeColor = System.Drawing.Color.Black
        Me.tbCari.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbCari.IconRight = Global.app_perpus.My.Resources.Resources.find
        Me.tbCari.IconRightOffset = New System.Drawing.Point(10, 0)
        Me.tbCari.Location = New System.Drawing.Point(400, 46)
        Me.tbCari.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbCari.Name = "tbCari"
        Me.tbCari.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbCari.PlaceholderText = "Cari Disini.."
        Me.tbCari.SelectedText = ""
        Me.tbCari.Size = New System.Drawing.Size(569, 40)
        Me.tbCari.TabIndex = 43
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Image = Global.app_perpus.My.Resources.Resources.gbuser
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(132, 87)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(135, 138)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 25
        Me.Guna2PictureBox1.TabStop = False
        '
        'formUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(982, 553)
        Me.Controls.Add(Me.dgvUser)
        Me.Controls.Add(Me.tbCari)
        Me.Controls.Add(Me.btnTambah)
        Me.Controls.Add(Me.tbPass)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tbRole)
        Me.Controls.Add(Me.tbUser)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "formUser"
        Me.Text = "User"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.dgvUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents dashboard As ToolStripMenuItem
    Friend WithEvents buku As ToolStripMenuItem
    Friend WithEvents anggota As ToolStripMenuItem
    Friend WithEvents user As ToolStripMenuItem
    Friend WithEvents pinjam As ToolStripMenuItem
    Friend WithEvents kembali As ToolStripMenuItem
    Friend WithEvents laporan As ToolStripMenuItem
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tbUser As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents tbRole As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents tbPass As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnTambah As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents dgvUser As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents tbCari As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents kodeUser As DataGridViewTextBoxColumn
    Friend WithEvents namaUser As DataGridViewTextBoxColumn
    Friend WithEvents passUser As DataGridViewTextBoxColumn
    Friend WithEvents roleUser As DataGridViewTextBoxColumn
    Friend WithEvents btnHapus As DataGridViewButtonColumn
End Class
