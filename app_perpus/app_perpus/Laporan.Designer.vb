<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formLaporan
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
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.btnReportPinjam = New Guna.UI2.WinForms.Guna2Button()
        Me.btnReportKembali = New Guna.UI2.WinForms.Guna2Button()
        Me.SuspendLayout()
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(982, 553)
        Me.CrystalReportViewer1.TabIndex = 0
        '
        'btnReportPinjam
        '
        Me.btnReportPinjam.BorderRadius = 5
        Me.btnReportPinjam.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnReportPinjam.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnReportPinjam.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnReportPinjam.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnReportPinjam.FillColor = System.Drawing.Color.SteelBlue
        Me.btnReportPinjam.Font = New System.Drawing.Font("Montserrat", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReportPinjam.ForeColor = System.Drawing.Color.White
        Me.btnReportPinjam.Location = New System.Drawing.Point(19, 217)
        Me.btnReportPinjam.Name = "btnReportPinjam"
        Me.btnReportPinjam.Size = New System.Drawing.Size(162, 45)
        Me.btnReportPinjam.TabIndex = 1
        Me.btnReportPinjam.Text = "Peminjaman"
        '
        'btnReportKembali
        '
        Me.btnReportKembali.BorderRadius = 5
        Me.btnReportKembali.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnReportKembali.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnReportKembali.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnReportKembali.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnReportKembali.FillColor = System.Drawing.Color.CadetBlue
        Me.btnReportKembali.Font = New System.Drawing.Font("Montserrat", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReportKembali.ForeColor = System.Drawing.Color.White
        Me.btnReportKembali.Location = New System.Drawing.Point(19, 304)
        Me.btnReportKembali.Name = "btnReportKembali"
        Me.btnReportKembali.Size = New System.Drawing.Size(162, 45)
        Me.btnReportKembali.TabIndex = 2
        Me.btnReportKembali.Text = "Pengembalian"
        '
        'formLaporan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(982, 553)
        Me.Controls.Add(Me.btnReportKembali)
        Me.Controls.Add(Me.btnReportPinjam)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Name = "formLaporan"
        Me.Text = "Laporan"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents btnReportPinjam As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnReportKembali As Guna.UI2.WinForms.Guna2Button
End Class
