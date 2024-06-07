Imports MySql.Data.MySqlClient


Public Class formDashboard
    Public Property StringPass As String
    Dim conn As MySqlConnection
    Dim cmd As MySqlCommand
    Dim rd As MySqlDataReader
    Dim nama As String
    Dim role As String

    Public Property nama1 As String
    Public Property role1 As String

    Public Sub New(username As String, role As String)
        InitializeComponent()
        Me.nama1 = username
        Me.role1 = role
        lblNama.Text = "Selamat Datang, " & username & "!"
        lblRole.Text = "Sebagai : " & role
        SetMenuVisibilityByRole(role)
    End Sub

    Private Sub SetMenuVisibilityByRole(role As String)
        Select Case role
            Case "Owner"
                SetMenuVisibilityForOwner()
            Case "Admin"
                SetMenuVisibilityForAdmin()
            Case "Pengelola"
                SetMenuVisibilityForPengelola()
            Case Else
                ' Menyembunyikan semua menu jika rolenya tidak cocok
                HideAllMenus()
        End Select
    End Sub

    Private Sub HideAllMenus()
        ' Menyembunyikan semua ToolStripMenuItem
        For Each item As ToolStripItem In MenuStrip1.Items
            If TypeOf item Is ToolStripMenuItem Then
                CType(item, ToolStripMenuItem).Visible = False
            End If
        Next
    End Sub

    Public Sub SetMenuVisibilityForOwner()
        buku.Visible = False
        anggota.Visible = False
        pinjam.Visible = False
        kembali.Visible = False
        laporan.Visible = False

        'hide
        dashboard.Visible = True
        user.Visible = True
        laporan.Visible = True
    End Sub

    Public Sub SetMenuVisibilityForAdmin()
        user.Visible = False
        laporan.Visible = False

        buku.Visible = True
        anggota.Visible = True
        pinjam.Visible = True
        kembali.Visible = True
        dashboard.Visible = True
    End Sub

    Public Sub SetMenuVisibilityForPengelola()
        laporan.Visible = False
        user.Visible = False
        buku.Visible = False

        'hide
        dashboard.Visible = True
        anggota.Visible = True
        pinjam.Visible = True
        kembali.Visible = True
    End Sub

    Sub koneksi()
        conn = New MySqlConnection("server=localhost;user id=root;password=;database=db_project")
    End Sub

    Private Sub formDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Refresh()
        Me.CenterToScreen()
        koneksi()
        Dim cmdBuku As New MySqlCommand("SELECT COALESCE(COUNT(*), 0) FROM tbl_buku", conn)
        Dim cmdAnggota As New MySqlCommand("SELECT COALESCE(COUNT(*), 0) FROM tbl_anggota", conn)
        Dim cmdPinjam As New MySqlCommand("SELECT COALESCE(COUNT(*), 0) FROM tbl_pinjam", conn)
        Try
            conn.Open()

            Dim hitungBuku As Integer = Convert.ToInt32(cmdBuku.ExecuteScalar())
            lblTotalBuku.Text = hitungBuku.ToString()

            Dim hitungAnggota As Integer = Convert.ToInt32(cmdAnggota.ExecuteScalar())
            lblTotalAnggota.Text = hitungAnggota.ToString()

            Dim hitungPinjam As Integer = Convert.ToInt32(cmdPinjam.ExecuteScalar())
            lblTotalPinjam.Text = hitungPinjam.ToString()

        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub buku_Click(sender As Object, e As EventArgs) Handles buku.Click
        Dim form2 As New formBuku(Me.nama1, Me.role1)
        form2.Show()
        Me.Hide()
    End Sub

    Private Sub anggota_Click(sender As Object, e As EventArgs) Handles anggota.Click
        Dim form2 As New formAnggota(Me.nama1, Me.role1)
        form2.Show()
        Me.Hide()
    End Sub

    Private Sub user_Click(sender As Object, e As EventArgs) Handles user.Click
        Dim form2 As New formUser(Me.nama1, Me.role1)
        form2.Show()
        Me.Hide()
    End Sub

    Private Sub pinjam_Click(sender As Object, e As EventArgs) Handles pinjam.Click
        Dim form2 As New formPinjam(Me.nama1, Me.role1)
        form2.Show()
        Me.Hide()
    End Sub

    Private Sub kembali_Click(sender As Object, e As EventArgs) Handles kembali.Click
        Dim form2 As New formKembali(Me.nama1, Me.role1)
        form2.Show()
        Me.Hide()
    End Sub

    Private Sub laporan_Click(sender As Object, e As EventArgs) Handles laporan.Click
        Dim form2 As New formLaporan()
        form2.Show()
        Me.Hide()
    End Sub
End Class