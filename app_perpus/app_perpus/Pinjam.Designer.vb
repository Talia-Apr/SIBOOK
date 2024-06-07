<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formPinjam
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbKode = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbAnggota = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.tbBuku = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.tbJumlah = New Guna.UI2.WinForms.Guna2NumericUpDown()
        Me.tbTglPinjam = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.tbTglKembali = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.btnSelesai = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnTambah = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.dgvPinjam = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.bukuPinjam = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jumlahPinjam = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnHapus = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.btnPinjam = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.MenuStrip1.SuspendLayout()
        CType(Me.tbJumlah, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvPinjam, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.MenuStrip1.TabIndex = 5
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
        Me.Label6.Location = New System.Drawing.Point(60, 178)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(278, 32)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "Form Peminjaman"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Montserrat", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(32, 274)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 21)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Pilih Anggota"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Montserrat", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(32, 229)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 21)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Kode"
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
        Me.tbKode.Location = New System.Drawing.Point(180, 229)
        Me.tbKode.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbKode.Name = "tbKode"
        Me.tbKode.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbKode.PlaceholderText = ""
        Me.tbKode.ReadOnly = True
        Me.tbKode.SelectedText = ""
        Me.tbKode.Size = New System.Drawing.Size(190, 31)
        Me.tbKode.TabIndex = 39
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Montserrat", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(32, 317)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 21)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "Pilih Buku"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Montserrat", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(32, 359)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 21)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "Jumlah"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Montserrat", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(32, 400)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(132, 21)
        Me.Label5.TabIndex = 44
        Me.Label5.Text = "Tanggal Pinjam"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Montserrat", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(32, 441)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(141, 21)
        Me.Label7.TabIndex = 46
        Me.Label7.Text = "Tanggal Kembali"
        '
        'tbAnggota
        '
        Me.tbAnggota.BackColor = System.Drawing.Color.Transparent
        Me.tbAnggota.BorderRadius = 5
        Me.tbAnggota.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.tbAnggota.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.tbAnggota.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbAnggota.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbAnggota.Font = New System.Drawing.Font("Montserrat SemiBold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbAnggota.ForeColor = System.Drawing.Color.Black
        Me.tbAnggota.ItemHeight = 30
        Me.tbAnggota.Location = New System.Drawing.Point(180, 267)
        Me.tbAnggota.Name = "tbAnggota"
        Me.tbAnggota.Size = New System.Drawing.Size(190, 36)
        Me.tbAnggota.TabIndex = 48
        '
        'tbBuku
        '
        Me.tbBuku.BackColor = System.Drawing.Color.Transparent
        Me.tbBuku.BorderRadius = 5
        Me.tbBuku.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.tbBuku.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.tbBuku.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbBuku.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbBuku.Font = New System.Drawing.Font("Montserrat SemiBold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbBuku.ForeColor = System.Drawing.Color.Black
        Me.tbBuku.ItemHeight = 30
        Me.tbBuku.Location = New System.Drawing.Point(180, 313)
        Me.tbBuku.Name = "tbBuku"
        Me.tbBuku.Size = New System.Drawing.Size(190, 36)
        Me.tbBuku.TabIndex = 49
        '
        'tbJumlah
        '
        Me.tbJumlah.BackColor = System.Drawing.Color.Transparent
        Me.tbJumlah.BorderRadius = 5
        Me.tbJumlah.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbJumlah.Font = New System.Drawing.Font("Montserrat SemiBold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbJumlah.Location = New System.Drawing.Point(180, 357)
        Me.tbJumlah.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tbJumlah.Name = "tbJumlah"
        Me.tbJumlah.Size = New System.Drawing.Size(190, 36)
        Me.tbJumlah.TabIndex = 50
        Me.tbJumlah.UpDownButtonFillColor = System.Drawing.Color.SteelBlue
        Me.tbJumlah.UpDownButtonForeColor = System.Drawing.Color.White
        '
        'tbTglPinjam
        '
        Me.tbTglPinjam.BorderRadius = 5
        Me.tbTglPinjam.Checked = True
        Me.tbTglPinjam.FillColor = System.Drawing.Color.White
        Me.tbTglPinjam.Font = New System.Drawing.Font("Montserrat SemiBold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTglPinjam.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.tbTglPinjam.Location = New System.Drawing.Point(180, 400)
        Me.tbTglPinjam.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.tbTglPinjam.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.tbTglPinjam.Name = "tbTglPinjam"
        Me.tbTglPinjam.Size = New System.Drawing.Size(190, 31)
        Me.tbTglPinjam.TabIndex = 51
        Me.tbTglPinjam.Value = New Date(2023, 12, 17, 0, 0, 0, 0)
        '
        'tbTglKembali
        '
        Me.tbTglKembali.BorderRadius = 5
        Me.tbTglKembali.Checked = True
        Me.tbTglKembali.FillColor = System.Drawing.Color.White
        Me.tbTglKembali.Font = New System.Drawing.Font("Montserrat SemiBold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTglKembali.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.tbTglKembali.Location = New System.Drawing.Point(180, 439)
        Me.tbTglKembali.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.tbTglKembali.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.tbTglKembali.Name = "tbTglKembali"
        Me.tbTglKembali.Size = New System.Drawing.Size(190, 31)
        Me.tbTglKembali.TabIndex = 52
        Me.tbTglKembali.Value = New Date(2023, 12, 17, 0, 0, 0, 0)
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
        Me.btnSelesai.Location = New System.Drawing.Point(214, 484)
        Me.btnSelesai.Name = "btnSelesai"
        Me.btnSelesai.Size = New System.Drawing.Size(156, 38)
        Me.btnSelesai.TabIndex = 55
        Me.btnSelesai.Text = "Selesai"
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
        Me.btnTambah.Location = New System.Drawing.Point(36, 484)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(172, 38)
        Me.btnTambah.TabIndex = 53
        Me.btnTambah.Text = "Tambah"
        '
        'dgvPinjam
        '
        Me.dgvPinjam.AllowUserToResizeColumns = False
        Me.dgvPinjam.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Montserrat Medium", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvPinjam.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Montserrat", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPinjam.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvPinjam.ColumnHeadersHeight = 40
        Me.dgvPinjam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvPinjam.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.bukuPinjam, Me.jumlahPinjam, Me.btnHapus})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Montserrat Medium", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvPinjam.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvPinjam.GridColor = System.Drawing.Color.SteelBlue
        Me.dgvPinjam.Location = New System.Drawing.Point(401, 45)
        Me.dgvPinjam.Name = "dgvPinjam"
        Me.dgvPinjam.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Montserrat", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPinjam.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvPinjam.RowHeadersVisible = False
        Me.dgvPinjam.RowHeadersWidth = 51
        Me.dgvPinjam.RowTemplate.Height = 25
        Me.dgvPinjam.Size = New System.Drawing.Size(569, 447)
        Me.dgvPinjam.TabIndex = 57
        Me.dgvPinjam.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvPinjam.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvPinjam.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvPinjam.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvPinjam.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvPinjam.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgvPinjam.ThemeStyle.GridColor = System.Drawing.Color.SteelBlue
        Me.dgvPinjam.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvPinjam.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvPinjam.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvPinjam.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvPinjam.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvPinjam.ThemeStyle.HeaderStyle.Height = 40
        Me.dgvPinjam.ThemeStyle.ReadOnly = False
        Me.dgvPinjam.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvPinjam.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvPinjam.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvPinjam.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgvPinjam.ThemeStyle.RowsStyle.Height = 25
        Me.dgvPinjam.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvPinjam.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'bukuPinjam
        '
        Me.bukuPinjam.HeaderText = "Buku"
        Me.bukuPinjam.MinimumWidth = 6
        Me.bukuPinjam.Name = "bukuPinjam"
        '
        'jumlahPinjam
        '
        Me.jumlahPinjam.HeaderText = "Jumlah"
        Me.jumlahPinjam.MinimumWidth = 6
        Me.jumlahPinjam.Name = "jumlahPinjam"
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
        Me.btnPinjam.Location = New System.Drawing.Point(401, 506)
        Me.btnPinjam.Name = "btnPinjam"
        Me.btnPinjam.Size = New System.Drawing.Size(569, 38)
        Me.btnPinjam.TabIndex = 58
        Me.btnPinjam.Text = "Ke Master Pinjam"
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Image = Global.app_perpus.My.Resources.Resources.borrow
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(141, 50)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(115, 122)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 36
        Me.Guna2PictureBox1.TabStop = False
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'formPinjam
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(982, 553)
        Me.Controls.Add(Me.btnPinjam)
        Me.Controls.Add(Me.dgvPinjam)
        Me.Controls.Add(Me.btnSelesai)
        Me.Controls.Add(Me.btnTambah)
        Me.Controls.Add(Me.tbTglKembali)
        Me.Controls.Add(Me.tbTglPinjam)
        Me.Controls.Add(Me.tbJumlah)
        Me.Controls.Add(Me.tbBuku)
        Me.Controls.Add(Me.tbAnggota)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tbKode)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "formPinjam"
        Me.Text = "Pinjam"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.tbJumlah, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvPinjam, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents tbKode As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents tbAnggota As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents tbBuku As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents tbJumlah As Guna.UI2.WinForms.Guna2NumericUpDown
    Friend WithEvents tbTglPinjam As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents tbTglKembali As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents btnSelesai As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnTambah As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents dgvPinjam As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents bukuPinjam As DataGridViewTextBoxColumn
    Friend WithEvents jumlahPinjam As DataGridViewTextBoxColumn
    Friend WithEvents btnHapus As DataGridViewButtonColumn
    Friend WithEvents btnPinjam As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
