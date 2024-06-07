Imports MySql.Data.MySqlClient

Public Class formUser
    Dim conn As MySqlConnection
    Dim cmd As MySqlCommand
    Dim da As New MySqlDataAdapter
    Dim ds As New DataSet
    Dim rd As MySqlDataReader
    Dim kode As String = ""
    Dim id_user As String

    Public Property nama As String
    Public Property role As String

    Sub koneksi()
        conn = New MySqlConnection("server= localhost" + ";user id = root" + ";password=" + "" + ";database=db_project")
        conn.Open()
    End Sub

    Public Sub New(username As String, role As String)
        InitializeComponent()
        Me.nama = username
        Me.role = role
        ' Menyesuaikan visibilitas menu berdasarkan peran pengguna
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

    Sub bersihkan()
        For Each ctr In Me.Controls
            If TypeOf ctr Is TextBox Then
                ctr.Text = ""
            ElseIf TypeOf ctr Is ComboBox Then
                DirectCast(ctr, ComboBox).SelectedItem = Nothing
            End If
        Next
    End Sub

    Sub tampilData()
        koneksi()
        Try
            ds.Clear()
            da = New MySqlDataAdapter("SELECT * FROM tbl_user;", conn)
            da.Fill(ds, "user")
            dgvUser.Rows.Clear()

            For i As Integer = 0 To ds.Tables("user").Rows.Count - 1
                dgvUser.Rows.Add(ds.Tables("user").Rows(i).Item(0).ToString,
                                              ds.Tables("user").Rows(i).Item(1).ToString,
                                              ds.Tables("user").Rows(i).Item(2).ToString,
                                              ds.Tables("user").Rows(i).Item(3).ToString)
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Terjadi kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub formUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            koneksi()
            Me.CenterToScreen()
            tampilData()
            btnHapus.Name = "HAPUS"
        Catch ex As Exception
            MsgBox("Terjadi Kesalahan")
            For Each ctr In Me.Controls
                If TypeOf ctr Is TextBox Then
                    ctr.Enabled = False
                ElseIf TypeOf ctr Is ComboBox Then
                    ctr.Enabled = False
                End If
            Next
        End Try
    End Sub

    Sub hapusdata(kode As String)
        koneksi()
        Dim sql As String = "DELETE FROM tbl_user WHERE id_user = ?"
        Try
            If rd IsNot Nothing AndAlso Not rd.IsClosed Then
                rd.Close()
            End If
            Dim cmd As New MySqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("kodeUser", kode)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Data berhasil dihapus")
            tampilData()
            bersihkan()
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan" & ex.Message)
        End Try
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        koneksi()
        Dim cek As Boolean = True
        Dim kode As String

        If tbUser.Text = "" Then
            ErrorProvider1.SetError(tbUser, "Masukkan nama user")
        End If
        If tbPass.Text = "" Then
            ErrorProvider1.SetError(tbPass, "Masukkan password user")
        End If
        If tbRole.Text = "" Then
            ErrorProvider1.SetError(tbRole, "Masukkan nomor telepon")
        End If

        If tbUser IsNot Nothing And tbPass IsNot Nothing And tbRole IsNot Nothing Then
            If tbRole.SelectedItem = "Admin" Then
                kode = "ADM"
            ElseIf tbRole.SelectedItem = "Owner" Then
                kode = "OWN"
            ElseIf tbRole.SelectedItem = "Pengelola" Then
                kode = "PGL"
            End If
        End If
        ds.Clear()
        da = New MySqlDataAdapter("SELECT 
                                        CASE 
                                        WHEN MAX(CAST(SUBSTRING(id_user, 4, 3) AS UNSIGNED)) IS NULL THEN '" & kode & "001' 
                                        ELSE CONCAT('" & kode & "', LPAD(MAX(CAST(SUBSTRING(id_user, 4, 3) AS UNSIGNED)) + 1, 3, '0')) 
                                        END AS nomor FROM tbl_user WHERE id_user LIKE '" & kode & "%'", conn)
        da.Fill(ds, "tabel")
        Dim nomor As String = ds.Tables("tabel").Rows(0)("nomor")
        id_user = nomor.ToString()
        ds.Clear()
        da = New MySqlDataAdapter("insert into tbl_user Values (?,?,?,?)", conn)
        da.SelectCommand.Parameters.AddWithValue("kodeUser", id_user)
        da.SelectCommand.Parameters.AddWithValue("namaUser", tbUser.Text)
        da.SelectCommand.Parameters.AddWithValue("passUser", tbPass.Text)
        da.SelectCommand.Parameters.AddWithValue("roleUser", tbRole.Text)
        da.Fill(ds, "tabel")
        tampilData()
        bersihkan()
    End Sub

    Private Sub dashboard_Click(sender As Object, e As EventArgs) Handles dashboard.Click
        Dim form2 As New formDashboard(Me.nama, Me.role)
        form2.Show()
        Me.Hide()
    End Sub

    Private Sub buku_Click(sender As Object, e As EventArgs) Handles buku.Click
        Dim form2 As New formBuku(Me.nama, Me.role)
        form2.Show()
        Me.Hide()
    End Sub

    Private Sub anggota_Click(sender As Object, e As EventArgs) Handles anggota.Click
        Dim form2 As New formAnggota(Me.nama, Me.role)
        form2.Show()
        Me.Hide()
    End Sub

    Private Sub tbUser_TextChanged(sender As Object, e As EventArgs) Handles tbUser.TextChanged
        If tbUser.Text IsNot "" Then
            ErrorProvider1.SetError(tbUser, "")
        End If
    End Sub

    Private Sub tbPass_TextChanged(sender As Object, e As EventArgs) Handles tbPass.TextChanged
        If tbPass.Text IsNot "" Then
            ErrorProvider1.SetError(tbPass, "")
        End If
    End Sub

    Private Sub tbUser_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbUser.KeyPress
        If Char.IsDigit(e.KeyChar) Or Char.IsPunctuation(e.KeyChar) Then
            MsgBox("Masukkan Huruf")
            e.Handled = True
        End If
    End Sub

    Private Sub tbCari_TextChanged(sender As Object, e As EventArgs) Handles tbCari.TextChanged
        If Not String.IsNullOrEmpty(tbCari.Text.Trim()) Then
            Try
                dgvUser.Rows.Clear()
                koneksi()
                Dim query As String = "SELECT * FROM tbl_user WHERE username LIKE @keyword OR role LIKE @keyword"
                Dim cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@keyword", "%" & tbCari.Text & "%")
                Dim adapter As New MySqlDataAdapter(cmd)
                Dim ds As New DataSet
                adapter.Fill(ds, "user")
                If ds.Tables("user").Rows.Count > 0 Then
                    For i As Integer = 0 To ds.Tables("user").Rows.Count - 1
                        dgvUser.Rows.Add(ds.Tables("user").Rows(i).Item(0).ToString,
                                    ds.Tables("user").Rows(i).Item(1).ToString,
                                    ds.Tables("user").Rows(i).Item(2).ToString,
                                    ds.Tables("user").Rows(i).Item(3).ToString)
                    Next
                Else
                    MessageBox.Show("Tidak ada hasil yang cocok untuk kata kunci tersebut", "Pencarian", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Catch ex As Exception
                MessageBox.Show("Terjadi kesalahan: " & ex.Message)
            Finally
                conn.Close()
            End Try
        End If
    End Sub

    Private Sub dgvUser_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUser.CellContentClick
        ''If e.ColumnIndex = dgvUser.Columns("btnHapus").Index AndAlso e.RowIndex >= 0 Then
        ''    ' Proses penghapusan data
        ''    If dgvUser.SelectedRows.Count > 0 Then
        ''        Dim selectedRow As DataGridViewRow = dgvUser.Rows(e.RowIndex)
        ''        hapusdata(kode)
        ''        tampilData()
        ''        bersihkan()
        ''    Else
        ''        MessageBox.Show("Pilih baris yang ingin dihapus")
        ''    End If
        ''End If

        'If e.ColumnIndex = dgvUser.Columns("btnHapus").Index AndAlso e.RowIndex >= 0 Then
        '    'Menghapus baris yang sesuai dengan tombol "Remove" yang diklik
        '    dgvUser.Rows.RemoveAt(e.RowIndex)
        'End If

    End Sub
End Class