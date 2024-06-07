<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formBuku
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbKode = New Guna.UI2.WinForms.Guna2TextBox()
        Me.tbJudul = New Guna.UI2.WinForms.Guna2TextBox()
        Me.tbPenerbit = New Guna.UI2.WinForms.Guna2TextBox()
        Me.tbStok = New Guna.UI2.WinForms.Guna2NumericUpDown()
        Me.btnTambah = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnUbah = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnHapus = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.dgvBuku = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.kodeBuku = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.judulBuku = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.penerbitBuku = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rakBuku = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.stokBuku = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbRak = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.tbCari = New Guna.UI2.WinForms.Guna2TextBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.tbStok, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvBuku, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.MenuStrip1.TabIndex = 2
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Montserrat", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(36, 261)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 21)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Kode"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Montserrat", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(36, 305)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 21)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Judul"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Montserrat", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(36, 347)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 21)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Penerbit"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Montserrat", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(36, 395)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 21)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Rak"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Montserrat", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(39, 444)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 21)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Stok"
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
        Me.tbKode.Location = New System.Drawing.Point(120, 258)
        Me.tbKode.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbKode.Name = "tbKode"
        Me.tbKode.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbKode.PlaceholderText = ""
        Me.tbKode.ReadOnly = True
        Me.tbKode.SelectedText = ""
        Me.tbKode.Size = New System.Drawing.Size(214, 31)
        Me.tbKode.TabIndex = 8
        '
        'tbJudul
        '
        Me.tbJudul.BorderRadius = 5
        Me.tbJudul.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbJudul.DefaultText = ""
        Me.tbJudul.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbJudul.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbJudul.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbJudul.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbJudul.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbJudul.Font = New System.Drawing.Font("Montserrat SemiBold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbJudul.ForeColor = System.Drawing.Color.Black
        Me.tbJudul.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbJudul.Location = New System.Drawing.Point(120, 300)
        Me.tbJudul.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbJudul.Name = "tbJudul"
        Me.tbJudul.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbJudul.PlaceholderText = ""
        Me.tbJudul.SelectedText = ""
        Me.tbJudul.Size = New System.Drawing.Size(214, 31)
        Me.tbJudul.TabIndex = 9
        '
        'tbPenerbit
        '
        Me.tbPenerbit.BorderRadius = 5
        Me.tbPenerbit.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbPenerbit.DefaultText = ""
        Me.tbPenerbit.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbPenerbit.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbPenerbit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbPenerbit.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbPenerbit.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbPenerbit.Font = New System.Drawing.Font("Montserrat SemiBold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbPenerbit.ForeColor = System.Drawing.Color.Black
        Me.tbPenerbit.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbPenerbit.Location = New System.Drawing.Point(120, 344)
        Me.tbPenerbit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbPenerbit.Name = "tbPenerbit"
        Me.tbPenerbit.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbPenerbit.PlaceholderText = ""
        Me.tbPenerbit.SelectedText = ""
        Me.tbPenerbit.Size = New System.Drawing.Size(214, 31)
        Me.tbPenerbit.TabIndex = 10
        '
        'tbStok
        '
        Me.tbStok.BackColor = System.Drawing.Color.Transparent
        Me.tbStok.BorderRadius = 5
        Me.tbStok.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbStok.Font = New System.Drawing.Font("Montserrat SemiBold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbStok.Location = New System.Drawing.Point(120, 436)
        Me.tbStok.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tbStok.Name = "tbStok"
        Me.tbStok.Size = New System.Drawing.Size(214, 36)
        Me.tbStok.TabIndex = 12
        Me.tbStok.UpDownButtonFillColor = System.Drawing.Color.SteelBlue
        Me.tbStok.UpDownButtonForeColor = System.Drawing.Color.White
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
        Me.btnTambah.Location = New System.Drawing.Point(36, 493)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(107, 38)
        Me.btnTambah.TabIndex = 13
        Me.btnTambah.Text = "Tambah"
        '
        'btnUbah
        '
        Me.btnUbah.BorderRadius = 5
        Me.btnUbah.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnUbah.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnUbah.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnUbah.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnUbah.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnUbah.FillColor = System.Drawing.Color.Goldenrod
        Me.btnUbah.FillColor2 = System.Drawing.Color.Goldenrod
        Me.btnUbah.Font = New System.Drawing.Font("Montserrat", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUbah.ForeColor = System.Drawing.Color.White
        Me.btnUbah.Location = New System.Drawing.Point(152, 493)
        Me.btnUbah.Name = "btnUbah"
        Me.btnUbah.Size = New System.Drawing.Size(86, 38)
        Me.btnUbah.TabIndex = 14
        Me.btnUbah.Text = "Ubah"
        '
        'btnHapus
        '
        Me.btnHapus.BorderRadius = 5
        Me.btnHapus.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnHapus.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnHapus.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnHapus.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnHapus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnHapus.FillColor = System.Drawing.Color.Crimson
        Me.btnHapus.FillColor2 = System.Drawing.Color.Crimson
        Me.btnHapus.Font = New System.Drawing.Font("Montserrat", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHapus.ForeColor = System.Drawing.Color.White
        Me.btnHapus.Location = New System.Drawing.Point(244, 493)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(96, 38)
        Me.btnHapus.TabIndex = 15
        Me.btnHapus.Text = "Hapus"
        '
        'dgvBuku
        '
        Me.dgvBuku.AllowUserToResizeColumns = False
        Me.dgvBuku.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Montserrat Medium", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvBuku.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Montserrat", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvBuku.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvBuku.ColumnHeadersHeight = 40
        Me.dgvBuku.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvBuku.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.kodeBuku, Me.judulBuku, Me.penerbitBuku, Me.rakBuku, Me.stokBuku})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Montserrat Medium", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvBuku.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvBuku.GridColor = System.Drawing.Color.SteelBlue
        Me.dgvBuku.Location = New System.Drawing.Point(382, 94)
        Me.dgvBuku.Name = "dgvBuku"
        Me.dgvBuku.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Montserrat", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvBuku.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvBuku.RowHeadersVisible = False
        Me.dgvBuku.RowHeadersWidth = 51
        Me.dgvBuku.RowTemplate.Height = 25
        Me.dgvBuku.Size = New System.Drawing.Size(588, 447)
        Me.dgvBuku.TabIndex = 16
        Me.dgvBuku.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvBuku.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvBuku.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvBuku.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvBuku.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvBuku.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgvBuku.ThemeStyle.GridColor = System.Drawing.Color.SteelBlue
        Me.dgvBuku.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvBuku.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvBuku.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvBuku.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvBuku.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvBuku.ThemeStyle.HeaderStyle.Height = 40
        Me.dgvBuku.ThemeStyle.ReadOnly = False
        Me.dgvBuku.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvBuku.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvBuku.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvBuku.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgvBuku.ThemeStyle.RowsStyle.Height = 25
        Me.dgvBuku.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvBuku.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'kodeBuku
        '
        Me.kodeBuku.HeaderText = "Kode"
        Me.kodeBuku.MinimumWidth = 6
        Me.kodeBuku.Name = "kodeBuku"
        '
        'judulBuku
        '
        Me.judulBuku.HeaderText = "Judul"
        Me.judulBuku.MinimumWidth = 6
        Me.judulBuku.Name = "judulBuku"
        '
        'penerbitBuku
        '
        Me.penerbitBuku.HeaderText = "Penerbit"
        Me.penerbitBuku.MinimumWidth = 6
        Me.penerbitBuku.Name = "penerbitBuku"
        '
        'rakBuku
        '
        Me.rakBuku.HeaderText = "Rak"
        Me.rakBuku.MinimumWidth = 6
        Me.rakBuku.Name = "rakBuku"
        '
        'stokBuku
        '
        Me.stokBuku.HeaderText = "Stok"
        Me.stokBuku.MinimumWidth = 6
        Me.stokBuku.Name = "stokBuku"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Caprasimo", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label6.Location = New System.Drawing.Point(93, 198)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(198, 32)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Master Buku"
        '
        'tbRak
        '
        Me.tbRak.BackColor = System.Drawing.Color.Transparent
        Me.tbRak.BorderRadius = 5
        Me.tbRak.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.tbRak.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.tbRak.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbRak.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbRak.Font = New System.Drawing.Font("Montserrat SemiBold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbRak.ForeColor = System.Drawing.Color.Black
        Me.tbRak.ItemHeight = 30
        Me.tbRak.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"})
        Me.tbRak.Location = New System.Drawing.Point(120, 388)
        Me.tbRak.Name = "tbRak"
        Me.tbRak.Size = New System.Drawing.Size(214, 36)
        Me.tbRak.TabIndex = 20
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Image = Global.app_perpus.My.Resources.Resources.gbbuku
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(124, 57)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(135, 122)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 19
        Me.Guna2PictureBox1.TabStop = False
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
        Me.tbCari.Location = New System.Drawing.Point(382, 44)
        Me.tbCari.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbCari.Name = "tbCari"
        Me.tbCari.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbCari.PlaceholderText = "Cari Disini.."
        Me.tbCari.SelectedText = ""
        Me.tbCari.Size = New System.Drawing.Size(588, 40)
        Me.tbCari.TabIndex = 18
        '
        'formBuku
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(982, 553)
        Me.Controls.Add(Me.tbRak)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.Controls.Add(Me.tbCari)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dgvBuku)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.btnUbah)
        Me.Controls.Add(Me.btnTambah)
        Me.Controls.Add(Me.tbStok)
        Me.Controls.Add(Me.tbPenerbit)
        Me.Controls.Add(Me.tbJudul)
        Me.Controls.Add(Me.tbKode)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "formBuku"
        Me.Text = "Buku"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.tbStok, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvBuku, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents tbKode As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents tbJudul As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents tbPenerbit As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents tbStok As Guna.UI2.WinForms.Guna2NumericUpDown
    Friend WithEvents btnTambah As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnUbah As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnHapus As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents dgvBuku As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents tbCari As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents tbRak As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents kodeBuku As DataGridViewTextBoxColumn
    Friend WithEvents judulBuku As DataGridViewTextBoxColumn
    Friend WithEvents penerbitBuku As DataGridViewTextBoxColumn
    Friend WithEvents rakBuku As DataGridViewTextBoxColumn
    Friend WithEvents stokBuku As DataGridViewTextBoxColumn
End Class
