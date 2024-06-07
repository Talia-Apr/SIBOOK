<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formDataKembali
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnKembali = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dgvDataKembali = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbDenda = New Guna.UI2.WinForms.Guna2TextBox()
        Me.kodeKembali = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.namaAnggota = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tglPinjam = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tglKembali = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dendaKembali = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvDataKembali, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnKembali
        '
        Me.btnKembali.BackColor = System.Drawing.Color.AliceBlue
        Me.btnKembali.BorderRadius = 5
        Me.btnKembali.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnKembali.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnKembali.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnKembali.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnKembali.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnKembali.FillColor = System.Drawing.Color.SteelBlue
        Me.btnKembali.FillColor2 = System.Drawing.Color.LightSeaGreen
        Me.btnKembali.Font = New System.Drawing.Font("Montserrat", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKembali.ForeColor = System.Drawing.Color.White
        Me.btnKembali.Location = New System.Drawing.Point(646, 492)
        Me.btnKembali.Name = "btnKembali"
        Me.btnKembali.Size = New System.Drawing.Size(324, 45)
        Me.btnKembali.TabIndex = 62
        Me.btnKembali.Text = "Kembali"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Caprasimo", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label6.Location = New System.Drawing.Point(326, 31)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(319, 32)
        Me.Label6.TabIndex = 61
        Me.Label6.Text = "Master Pengembalian"
        '
        'dgvDataKembali
        '
        Me.dgvDataKembali.AllowUserToResizeColumns = False
        Me.dgvDataKembali.AllowUserToResizeRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Montserrat Medium", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvDataKembali.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Montserrat", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDataKembali.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvDataKembali.ColumnHeadersHeight = 40
        Me.dgvDataKembali.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvDataKembali.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.kodeKembali, Me.namaAnggota, Me.tglPinjam, Me.tglKembali, Me.dendaKembali})
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Montserrat Medium", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvDataKembali.DefaultCellStyle = DataGridViewCellStyle7
        Me.dgvDataKembali.GridColor = System.Drawing.Color.SteelBlue
        Me.dgvDataKembali.Location = New System.Drawing.Point(12, 86)
        Me.dgvDataKembali.Name = "dgvDataKembali"
        Me.dgvDataKembali.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Montserrat", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDataKembali.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dgvDataKembali.RowHeadersVisible = False
        Me.dgvDataKembali.RowHeadersWidth = 51
        Me.dgvDataKembali.RowTemplate.Height = 25
        Me.dgvDataKembali.Size = New System.Drawing.Size(958, 388)
        Me.dgvDataKembali.TabIndex = 60
        Me.dgvDataKembali.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvDataKembali.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvDataKembali.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvDataKembali.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvDataKembali.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvDataKembali.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgvDataKembali.ThemeStyle.GridColor = System.Drawing.Color.SteelBlue
        Me.dgvDataKembali.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvDataKembali.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvDataKembali.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvDataKembali.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvDataKembali.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvDataKembali.ThemeStyle.HeaderStyle.Height = 40
        Me.dgvDataKembali.ThemeStyle.ReadOnly = False
        Me.dgvDataKembali.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvDataKembali.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvDataKembali.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvDataKembali.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgvDataKembali.ThemeStyle.RowsStyle.Height = 25
        Me.dgvDataKembali.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvDataKembali.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Montserrat", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label1.Location = New System.Drawing.Point(8, 502)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 24)
        Me.Label1.TabIndex = 63
        Me.Label1.Text = "Total Denda Rp."
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
        Me.tbDenda.Font = New System.Drawing.Font("Montserrat", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbDenda.ForeColor = System.Drawing.Color.Black
        Me.tbDenda.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbDenda.Location = New System.Drawing.Point(165, 495)
        Me.tbDenda.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbDenda.Name = "tbDenda"
        Me.tbDenda.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbDenda.PlaceholderText = ""
        Me.tbDenda.ReadOnly = True
        Me.tbDenda.SelectedText = ""
        Me.tbDenda.Size = New System.Drawing.Size(244, 36)
        Me.tbDenda.TabIndex = 64
        '
        'kodeKembali
        '
        Me.kodeKembali.HeaderText = "Kode"
        Me.kodeKembali.MinimumWidth = 6
        Me.kodeKembali.Name = "kodeKembali"
        '
        'namaAnggota
        '
        Me.namaAnggota.HeaderText = "Nama Anggota"
        Me.namaAnggota.MinimumWidth = 6
        Me.namaAnggota.Name = "namaAnggota"
        '
        'tglPinjam
        '
        Me.tglPinjam.HeaderText = "Tanggal Pinjam"
        Me.tglPinjam.MinimumWidth = 6
        Me.tglPinjam.Name = "tglPinjam"
        '
        'tglKembali
        '
        Me.tglKembali.HeaderText = "Tanggal Kembali"
        Me.tglKembali.MinimumWidth = 6
        Me.tglKembali.Name = "tglKembali"
        '
        'dendaKembali
        '
        Me.dendaKembali.HeaderText = "Denda"
        Me.dendaKembali.MinimumWidth = 6
        Me.dendaKembali.Name = "dendaKembali"
        '
        'formDataKembali
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(982, 553)
        Me.Controls.Add(Me.tbDenda)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnKembali)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dgvDataKembali)
        Me.Name = "formDataKembali"
        Me.Text = "Data Kembali"
        CType(Me.dgvDataKembali, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnKembali As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Label6 As Label
    Friend WithEvents dgvDataKembali As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents tbDenda As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents kodeKembali As DataGridViewTextBoxColumn
    Friend WithEvents namaAnggota As DataGridViewTextBoxColumn
    Friend WithEvents tglPinjam As DataGridViewTextBoxColumn
    Friend WithEvents tglKembali As DataGridViewTextBoxColumn
    Friend WithEvents dendaKembali As DataGridViewTextBoxColumn
End Class
