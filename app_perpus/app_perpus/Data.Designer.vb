<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formData
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnKembali = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dgvDataPinjam = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.kodePinjam = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.namaAnggota = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idBukuPinjam = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tglPinjam = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tglKembali = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jumlah = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvDataPinjam, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.btnKembali.Location = New System.Drawing.Point(598, 490)
        Me.btnKembali.Name = "btnKembali"
        Me.btnKembali.Size = New System.Drawing.Size(372, 45)
        Me.btnKembali.TabIndex = 62
        Me.btnKembali.Text = "Kembali"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Caprasimo", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label6.Location = New System.Drawing.Point(349, 29)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(225, 32)
        Me.Label6.TabIndex = 61
        Me.Label6.Text = "Data Pinjaman"
        '
        'dgvDataPinjam
        '
        Me.dgvDataPinjam.AllowUserToResizeColumns = False
        Me.dgvDataPinjam.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Montserrat Medium", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvDataPinjam.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Montserrat", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDataPinjam.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvDataPinjam.ColumnHeadersHeight = 40
        Me.dgvDataPinjam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvDataPinjam.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.kodePinjam, Me.namaAnggota, Me.idBukuPinjam, Me.tglPinjam, Me.tglKembali, Me.jumlah})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Montserrat Medium", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvDataPinjam.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvDataPinjam.GridColor = System.Drawing.Color.SteelBlue
        Me.dgvDataPinjam.Location = New System.Drawing.Point(12, 84)
        Me.dgvDataPinjam.Name = "dgvDataPinjam"
        Me.dgvDataPinjam.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Montserrat", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDataPinjam.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvDataPinjam.RowHeadersVisible = False
        Me.dgvDataPinjam.RowHeadersWidth = 51
        Me.dgvDataPinjam.RowTemplate.Height = 25
        Me.dgvDataPinjam.Size = New System.Drawing.Size(958, 388)
        Me.dgvDataPinjam.TabIndex = 60
        Me.dgvDataPinjam.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvDataPinjam.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvDataPinjam.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvDataPinjam.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvDataPinjam.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvDataPinjam.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgvDataPinjam.ThemeStyle.GridColor = System.Drawing.Color.SteelBlue
        Me.dgvDataPinjam.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvDataPinjam.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvDataPinjam.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvDataPinjam.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvDataPinjam.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvDataPinjam.ThemeStyle.HeaderStyle.Height = 40
        Me.dgvDataPinjam.ThemeStyle.ReadOnly = False
        Me.dgvDataPinjam.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvDataPinjam.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvDataPinjam.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvDataPinjam.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgvDataPinjam.ThemeStyle.RowsStyle.Height = 25
        Me.dgvDataPinjam.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvDataPinjam.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'kodePinjam
        '
        Me.kodePinjam.HeaderText = "Kode"
        Me.kodePinjam.MinimumWidth = 6
        Me.kodePinjam.Name = "kodePinjam"
        '
        'namaAnggota
        '
        Me.namaAnggota.HeaderText = "Nama Anggota"
        Me.namaAnggota.MinimumWidth = 6
        Me.namaAnggota.Name = "namaAnggota"
        '
        'idBukuPinjam
        '
        Me.idBukuPinjam.HeaderText = "Id Buku"
        Me.idBukuPinjam.MinimumWidth = 6
        Me.idBukuPinjam.Name = "idBukuPinjam"
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
        'jumlah
        '
        Me.jumlah.HeaderText = "Jumlah"
        Me.jumlah.MinimumWidth = 6
        Me.jumlah.Name = "jumlah"
        '
        'formData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(982, 553)
        Me.Controls.Add(Me.btnKembali)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dgvDataPinjam)
        Me.Name = "formData"
        Me.Text = "Data Pinjaman"
        CType(Me.dgvDataPinjam, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnKembali As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Label6 As Label
    Friend WithEvents dgvDataPinjam As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents kodePinjam As DataGridViewTextBoxColumn
    Friend WithEvents namaAnggota As DataGridViewTextBoxColumn
    Friend WithEvents idBukuPinjam As DataGridViewTextBoxColumn
    Friend WithEvents tglPinjam As DataGridViewTextBoxColumn
    Friend WithEvents tglKembali As DataGridViewTextBoxColumn
    Friend WithEvents jumlah As DataGridViewTextBoxColumn
End Class
