<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formKembali
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.dashboard = New System.Windows.Forms.ToolStripMenuItem()
        Me.buku = New System.Windows.Forms.ToolStripMenuItem()
        Me.anggota = New System.Windows.Forms.ToolStripMenuItem()
        Me.user = New System.Windows.Forms.ToolStripMenuItem()
        Me.pinjam = New System.Windows.Forms.ToolStripMenuItem()
        Me.kembali = New System.Windows.Forms.ToolStripMenuItem()
        Me.laporan = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnSelesai = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.tbTglTerima = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.tbTglKembali = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbKode = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbDenda = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dgvKembali = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.kodePinjam = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.namaKembali = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bukuPinjam = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tblBalik = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tglTerima = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnPinjam = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.tbAnggota = New Guna.UI2.WinForms.Guna2TextBox()
        Me.tbPinjam = New Guna.UI2.WinForms.Guna2TextBox()
        Me.pbCari = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.pbReload = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.MenuStrip1.SuspendLayout()
        CType(Me.dgvKembali, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbCari, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbReload, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'btnSelesai
        '
        Me.btnSelesai.BorderRadius = 5
        Me.btnSelesai.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSelesai.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSelesai.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSelesai.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSelesai.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSelesai.FillColor = System.Drawing.Color.DarkCyan
        Me.btnSelesai.FillColor2 = System.Drawing.Color.DarkCyan
        Me.btnSelesai.Font = New System.Drawing.Font("Montserrat", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelesai.ForeColor = System.Drawing.Color.White
        Me.btnSelesai.Location = New System.Drawing.Point(39, 489)
        Me.btnSelesai.Name = "btnSelesai"
        Me.btnSelesai.Size = New System.Drawing.Size(334, 38)
        Me.btnSelesai.TabIndex = 72
        Me.btnSelesai.Text = "Selesai"
        '
        'tbTglTerima
        '
        Me.tbTglTerima.BorderRadius = 5
        Me.tbTglTerima.Checked = True
        Me.tbTglTerima.FillColor = System.Drawing.Color.White
        Me.tbTglTerima.Font = New System.Drawing.Font("Montserrat SemiBold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTglTerima.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.tbTglTerima.Location = New System.Drawing.Point(183, 403)
        Me.tbTglTerima.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.tbTglTerima.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.tbTglTerima.Name = "tbTglTerima"
        Me.tbTglTerima.Size = New System.Drawing.Size(190, 31)
        Me.tbTglTerima.TabIndex = 69
        Me.tbTglTerima.Value = New Date(2023, 12, 17, 0, 0, 0, 0)
        '
        'tbTglKembali
        '
        Me.tbTglKembali.BorderRadius = 5
        Me.tbTglKembali.Checked = True
        Me.tbTglKembali.FillColor = System.Drawing.Color.White
        Me.tbTglKembali.Font = New System.Drawing.Font("Montserrat SemiBold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTglKembali.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.tbTglKembali.Location = New System.Drawing.Point(183, 364)
        Me.tbTglKembali.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.tbTglKembali.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.tbTglKembali.Name = "tbTglKembali"
        Me.tbTglKembali.Size = New System.Drawing.Size(190, 31)
        Me.tbTglKembali.TabIndex = 68
        Me.tbTglKembali.Value = New Date(2023, 12, 17, 0, 0, 0, 0)
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Montserrat", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(35, 405)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(129, 21)
        Me.Label7.TabIndex = 64
        Me.Label7.Text = "Tanggal Terima"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Montserrat", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(35, 364)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(141, 21)
        Me.Label5.TabIndex = 63
        Me.Label5.Text = "Tanggal Kembali"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Montserrat", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(35, 326)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 21)
        Me.Label3.TabIndex = 61
        Me.Label3.Text = "Anggota"
        '
        'tbKode
        '
        Me.tbKode.BorderRadius = 5
        Me.tbKode.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbKode.DefaultText = ""
        Me.tbKode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbKode.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbKode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbKode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbKode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbKode.Font = New System.Drawing.Font("Montserrat SemiBold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbKode.ForeColor = System.Drawing.Color.Black
        Me.tbKode.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbKode.Location = New System.Drawing.Point(183, 234)
        Me.tbKode.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbKode.Name = "tbKode"
        Me.tbKode.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbKode.PlaceholderText = ""
        Me.tbKode.ReadOnly = True
        Me.tbKode.SelectedText = ""
        Me.tbKode.Size = New System.Drawing.Size(190, 31)
        Me.tbKode.TabIndex = 60
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Caprasimo", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label6.Location = New System.Drawing.Point(89, 180)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(238, 32)
        Me.Label6.TabIndex = 58
        Me.Label6.Text = "Master Kembali"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Montserrat", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(35, 281)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 21)
        Me.Label2.TabIndex = 57
        Me.Label2.Text = "Pilih Pinjaman"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Montserrat", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(35, 234)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 21)
        Me.Label1.TabIndex = 56
        Me.Label1.Text = "Kode"
        '
        'tbDenda
        '
        Me.tbDenda.BorderRadius = 5
        Me.tbDenda.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbDenda.DefaultText = ""
        Me.tbDenda.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbDenda.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbDenda.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbDenda.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbDenda.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbDenda.Font = New System.Drawing.Font("Montserrat SemiBold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbDenda.ForeColor = System.Drawing.Color.Black
        Me.tbDenda.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbDenda.Location = New System.Drawing.Point(183, 441)
        Me.tbDenda.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbDenda.Name = "tbDenda"
        Me.tbDenda.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbDenda.PlaceholderText = ""
        Me.tbDenda.SelectedText = ""
        Me.tbDenda.Size = New System.Drawing.Size(147, 31)
        Me.tbDenda.TabIndex = 74
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Montserrat", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(35, 441)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 21)
        Me.Label4.TabIndex = 73
        Me.Label4.Text = "Denda"
        '
        'dgvKembali
        '
        Me.dgvKembali.AllowUserToResizeColumns = False
        Me.dgvKembali.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Montserrat Medium", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvKembali.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Montserrat", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvKembali.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvKembali.ColumnHeadersHeight = 40
        Me.dgvKembali.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvKembali.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.kodePinjam, Me.namaKembali, Me.bukuPinjam, Me.tblBalik, Me.tglTerima})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Montserrat Medium", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvKembali.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvKembali.GridColor = System.Drawing.Color.SteelBlue
        Me.dgvKembali.Location = New System.Drawing.Point(401, 44)
        Me.dgvKembali.Name = "dgvKembali"
        Me.dgvKembali.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Montserrat", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvKembali.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvKembali.RowHeadersVisible = False
        Me.dgvKembali.RowHeadersWidth = 51
        Me.dgvKembali.RowTemplate.Height = 25
        Me.dgvKembali.Size = New System.Drawing.Size(569, 447)
        Me.dgvKembali.TabIndex = 76
        Me.dgvKembali.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvKembali.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvKembali.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvKembali.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvKembali.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvKembali.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgvKembali.ThemeStyle.GridColor = System.Drawing.Color.SteelBlue
        Me.dgvKembali.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvKembali.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvKembali.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvKembali.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvKembali.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvKembali.ThemeStyle.HeaderStyle.Height = 40
        Me.dgvKembali.ThemeStyle.ReadOnly = False
        Me.dgvKembali.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvKembali.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvKembali.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvKembali.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgvKembali.ThemeStyle.RowsStyle.Height = 25
        Me.dgvKembali.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvKembali.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'kodePinjam
        '
        Me.kodePinjam.HeaderText = "Kode"
        Me.kodePinjam.MinimumWidth = 6
        Me.kodePinjam.Name = "kodePinjam"
        '
        'namaKembali
        '
        Me.namaKembali.HeaderText = "Pinjam"
        Me.namaKembali.MinimumWidth = 6
        Me.namaKembali.Name = "namaKembali"
        '
        'bukuPinjam
        '
        Me.bukuPinjam.HeaderText = "Anggota"
        Me.bukuPinjam.MinimumWidth = 6
        Me.bukuPinjam.Name = "bukuPinjam"
        '
        'tblBalik
        '
        Me.tblBalik.HeaderText = "Kembali"
        Me.tblBalik.MinimumWidth = 6
        Me.tblBalik.Name = "tblBalik"
        '
        'tglTerima
        '
        Me.tglTerima.HeaderText = "Terima"
        Me.tglTerima.MinimumWidth = 6
        Me.tglTerima.Name = "tglTerima"
        '
        'btnPinjam
        '
        Me.btnPinjam.BackColor = System.Drawing.Color.AliceBlue
        Me.btnPinjam.BorderRadius = 5
        Me.btnPinjam.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnPinjam.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnPinjam.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnPinjam.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnPinjam.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnPinjam.FillColor = System.Drawing.Color.SteelBlue
        Me.btnPinjam.FillColor2 = System.Drawing.Color.LightSeaGreen
        Me.btnPinjam.Font = New System.Drawing.Font("Montserrat", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPinjam.ForeColor = System.Drawing.Color.White
        Me.btnPinjam.Location = New System.Drawing.Point(401, 503)
        Me.btnPinjam.Name = "btnPinjam"
        Me.btnPinjam.Size = New System.Drawing.Size(569, 38)
        Me.btnPinjam.TabIndex = 78
        Me.btnPinjam.Text = "Ke Master Kembali"
        '
        'tbAnggota
        '
        Me.tbAnggota.BorderRadius = 5
        Me.tbAnggota.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbAnggota.DefaultText = ""
        Me.tbAnggota.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbAnggota.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbAnggota.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbAnggota.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbAnggota.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbAnggota.Font = New System.Drawing.Font("Montserrat SemiBold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbAnggota.ForeColor = System.Drawing.Color.Black
        Me.tbAnggota.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbAnggota.Location = New System.Drawing.Point(183, 323)
        Me.tbAnggota.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbAnggota.Name = "tbAnggota"
        Me.tbAnggota.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbAnggota.PlaceholderText = ""
        Me.tbAnggota.ReadOnly = True
        Me.tbAnggota.SelectedText = ""
        Me.tbAnggota.Size = New System.Drawing.Size(190, 31)
        Me.tbAnggota.TabIndex = 79
        '
        'tbPinjam
        '
        Me.tbPinjam.BorderRadius = 5
        Me.tbPinjam.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbPinjam.DefaultText = ""
        Me.tbPinjam.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbPinjam.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbPinjam.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbPinjam.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbPinjam.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbPinjam.Font = New System.Drawing.Font("Montserrat SemiBold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbPinjam.ForeColor = System.Drawing.Color.Black
        Me.tbPinjam.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbPinjam.Location = New System.Drawing.Point(183, 281)
        Me.tbPinjam.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbPinjam.Name = "tbPinjam"
        Me.tbPinjam.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbPinjam.PlaceholderText = ""
        Me.tbPinjam.ReadOnly = True
        Me.tbPinjam.SelectedText = ""
        Me.tbPinjam.Size = New System.Drawing.Size(147, 31)
        Me.tbPinjam.TabIndex = 81
        '
        'pbCari
        '
        Me.pbCari.Image = Global.app_perpus.My.Resources.Resources.magnifying_glass
        Me.pbCari.ImageRotate = 0!
        Me.pbCari.Location = New System.Drawing.Point(341, 281)
        Me.pbCari.Name = "pbCari"
        Me.pbCari.Size = New System.Drawing.Size(32, 31)
        Me.pbCari.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbCari.TabIndex = 80
        Me.pbCari.TabStop = False
        '
        'pbReload
        '
        Me.pbReload.Image = Global.app_perpus.My.Resources.Resources.reloading__1_
        Me.pbReload.ImageRotate = 0!
        Me.pbReload.Location = New System.Drawing.Point(341, 441)
        Me.pbReload.Name = "pbReload"
        Me.pbReload.Size = New System.Drawing.Size(32, 31)
        Me.pbReload.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbReload.TabIndex = 77
        Me.pbReload.TabStop = False
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Image = Global.app_perpus.My.Resources.Resources.return__1_
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(141, 55)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(115, 122)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 59
        Me.Guna2PictureBox1.TabStop = False
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'formKembali
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(982, 553)
        Me.Controls.Add(Me.tbPinjam)
        Me.Controls.Add(Me.pbCari)
        Me.Controls.Add(Me.tbAnggota)
        Me.Controls.Add(Me.btnPinjam)
        Me.Controls.Add(Me.pbReload)
        Me.Controls.Add(Me.dgvKembali)
        Me.Controls.Add(Me.tbDenda)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnSelesai)
        Me.Controls.Add(Me.tbTglTerima)
        Me.Controls.Add(Me.tbTglKembali)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tbKode)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "formKembali"
        Me.Text = "Kembali"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.dgvKembali, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbCari, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbReload, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents btnSelesai As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents tbTglTerima As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents tbTglKembali As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents tbKode As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents tbDenda As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents dgvKembali As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents pbReload As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents btnPinjam As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents tbAnggota As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents pbCari As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents tbPinjam As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents kodePinjam As DataGridViewTextBoxColumn
    Friend WithEvents namaKembali As DataGridViewTextBoxColumn
    Friend WithEvents bukuPinjam As DataGridViewTextBoxColumn
    Friend WithEvents tblBalik As DataGridViewTextBoxColumn
    Friend WithEvents tglTerima As DataGridViewTextBoxColumn
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
