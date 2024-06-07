Imports MySql.Data.MySqlClient

Public Class formAnggota
    Dim conn As MySqlConnection
    Dim cmd As MySqlCommand
    Dim da As New MySqlDataAdapter
    Dim ds As New DataSet
    Dim rd As MySqlDataReader
    Dim kode As String = ""

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

    Sub tampilKode()
        koneksi()
        ds.Clear()
        da = New MySqlDataAdapter("SELECT CASE WHEN MAX(CAST(SUBSTRING(id_anggota, 4) AS UNSIGNED)) IS NULL THEN 'AG001' ELSE CONCAT('AG', LPAD(MAX(CAST(SUBSTRING(id_anggota, 4) AS UNSIGNED)) + 1, 3, '0')) END FROM tbl_anggota;", conn)
        da.Fill(ds, "nomor")
        kode = ds.Tables("nomor").Rows(0).Item(0).ToString
        tbKode.Text = kode
    End Sub

    Sub tampilData()
        koneksi()
        Try
            ds.Clear()
            da = New MySqlDataAdapter("SELECT * FROM tbl_anggota;", conn)
            da.Fill(ds, "anggota")
            dgvAnggota.Rows.Clear()

            For i As Integer = 0 To ds.Tables("anggota").Rows.Count - 1
                dgvAnggota.Rows.Add(ds.Tables("anggota").Rows(i).Item(0).ToString,
                                              ds.Tables("anggota").Rows(i).Item(1).ToString,
                                              ds.Tables("anggota").Rows(i).Item(2).ToString,
                                              ds.Tables("anggota").Rows(i).Item(3).ToString,
                                              ds.Tables("anggota").Rows(i).Item(4).ToString)
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Terjadi kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub hapusdata(kode As String)
        koneksi()
        Dim sql As String = "DELETE FROM tbl_anggota WHERE id_anggota = ?"
        Try
            If rd IsNot Nothing AndAlso Not rd.IsClosed Then
                rd.Close()
            End If
            Dim cmd As New MySqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("kodeAnggota", kode)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Data berhasil dihapus")
            tampilData()
            bersihkan()
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan" & ex.Message)
        End Try
    End Sub

    Private Sub formAnggota_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            koneksi()
            Me.CenterToScreen()
            tampilData()
            tampilKode()
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

    Private Sub dgvAnggota_DoubleClick(sender As Object, e As EventArgs) Handles dgvAnggota.DoubleClick
        If dgvAnggota.SelectedRows.Count > 0 Then
            Dim selectRow As DataGridViewRow = dgvAnggota.SelectedRows(0)
            tbKode.Text = selectRow.Cells("kodeAnggota").Value.ToString()
            tbNama.Text = selectRow.Cells("namaAnggota").Value.ToString()
            tbKel.Text = selectRow.Cells("kelAnggota").Value.ToString()
            tbTelp.Text = selectRow.Cells("telpAnggota").Value.ToString()
            tbAlamat.Text = selectRow.Cells("alamatAnggota").Value.ToString()
        End If
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Dim cek As Boolean = True

        If tbNama.Text = "" Then
            ErrorProvider1.SetError(tbNama, "Masukkan nama anggota")
        End If
        If tbKel.Text = "" Then
            ErrorProvider1.SetError(tbKel, "Pilih jenis kelamin")
        End If
        If tbTelp.Text = "" Then
            ErrorProvider1.SetError(tbTelp, "Masukkan nomor telepon")
        End If
        If tbAlamat.Text = "" Then
            ErrorProvider1.SetError(tbAlamat, "Masukkan alamat")
            cek = False
        End If
        koneksi()
        tampilKode()
        Dim nama As String = tbNama.Text
        Dim gender As String = tbKel.Text
        Dim telp As String = tbTelp.Text
        Dim alamat As String = tbAlamat.Text
        Dim query As String = "INSERT INTO tbl_anggota(id_anggota,nama,jenis_kelamin,telp_anggota,alamat) VALUES(?,?,?,?,?)"
        cmd = New MySqlCommand(query, conn)
        cmd.Parameters.AddWithValue("kodeAnggota", tbKode.Text)
        cmd.Parameters.AddWithValue("namaAnggota", nama)
        cmd.Parameters.AddWithValue("kelAnggota", gender)
        cmd.Parameters.AddWithValue("telpAnggota", telp)
        cmd.Parameters.AddWithValue("alamatAnggota", alamat)
        cmd.ExecuteNonQuery()
        MessageBox.Show("Data berhasil disimpan!")
        tampilData()
        bersihkan()
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        If dgvAnggota.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = dgvAnggota.SelectedRows(0)
            Dim kode As String = selectedRow.Cells("kodeAnggota").Value.ToString()
            Dim nama As String = tbNama.Text
            Dim gender As String = tbKel.Text
            Dim telp As String = tbTelp.Text
            Dim alamat As String = tbAlamat.Text

            Dim sql As String = "UPDATE tbl_anggota SET nama = ?, jenis_kelamin = ?, telp_anggota = ?, alamat = ? WHERE id_anggota = ?"

            Try
                Call koneksi()
                Dim cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("namaAnggota", nama)
                cmd.Parameters.AddWithValue("kelAnggota", gender)
                cmd.Parameters.AddWithValue("telpAnggota", telp)
                cmd.Parameters.AddWithValue("alamatAnggota", alamat)
                cmd.Parameters.AddWithValue("kodeAnggota", kode)

                cmd.ExecuteNonQuery()
                MessageBox.Show("Data berhasil diupdate")
                tampilData()
                bersihkan()
            Catch ex As Exception
                MessageBox.Show("Terjadi kesalahan: " & ex.Message)
            Finally
                conn.Close()
            End Try
        Else
            MessageBox.Show("Pilih baris yang ingin diupdate terlebih dahulu")
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If dgvAnggota.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = dgvAnggota.SelectedRows(0)
            Dim kode As String = selectedRow.Cells("kodeAnggota").Value.ToString()
            hapusdata(kode)
            tampilData()
            tampilKode()
            bersihkan()
        Else
            MessageBox.Show("Pilih baris yang ingin dihapus")
        End If
    End Sub

    Private Sub tbNama_TextChanged(sender As Object, e As EventArgs) Handles tbNama.TextChanged
        If tbNama.Text IsNot "" Then
            ErrorProvider1.SetError(tbNama, "")
        End If
    End Sub

    Private Sub tbTelp_TextChanged(sender As Object, e As EventArgs) Handles tbTelp.TextChanged
        If tbTelp.Text IsNot "" Then
            ErrorProvider1.SetError(tbTelp, "")
        End If
    End Sub

    Private Sub tbAlamat_TextChanged(sender As Object, e As EventArgs) Handles tbAlamat.TextChanged
        If tbAlamat.Text IsNot "" Then
            ErrorProvider1.SetError(tbAlamat, "")
        End If
    End Sub

    Private Sub tbKel_TextChanged(sender As Object, e As EventArgs) Handles tbKel.TextChanged
        If tbKel.Text IsNot "" Then
            ErrorProvider1.SetError(tbKel, "")
        End If
    End Sub

    Private Sub tbNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbNama.KeyPress
        If Char.IsDigit(e.KeyChar) Or Char.IsPunctuation(e.KeyChar) Then
            MsgBox("Masukkan Huruf")
            e.Handled = True
        End If
    End Sub

    Private Sub tbTelp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbTelp.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsPunctuation(e.KeyChar) Then
            MsgBox("Masukkan Angka")
            e.Handled = True
        End If
    End Sub

    Private Sub dashboard_Click(sender As Object, e As EventArgs) Handles dashboard.Click
        Dim form2 As New formDashboard(Me.nama, Me.role)
        form2.Show()
        Me.Hide() 'buat ngeset value
    End Sub

    Private Sub buku_Click(sender As Object, e As EventArgs) Handles buku.Click
        Dim form2 As New formBuku(Me.nama, Me.role)
        form2.Show()
        Me.Hide()
    End Sub


    Private Sub user_Click(sender As Object, e As EventArgs) Handles user.Click
        Dim form2 As New formUser(Me.nama, Me.role)
        form2.Show()
        Me.Hide()
    End Sub

    Private Sub pinjam_Click(sender As Object, e As EventArgs) Handles pinjam.Click
        Dim form2 As New formPinjam(Me.nama, Me.role)
        form2.Show()
        Me.Hide()
    End Sub

    Private Sub kembali_Click(sender As Object, e As EventArgs) Handles kembali.Click
        Dim form2 As New formKembali(Me.nama, Me.role)
        form2.Show()
        Me.Hide()
    End Sub

    Private Sub laporan_Click(sender As Object, e As EventArgs) Handles laporan.Click
        Dim form2 As New formLaporan()
        form2.Show()
        Me.Hide()
    End Sub

    Private Sub tbCari_TextChanged(sender As Object, e As EventArgs) Handles tbCari.TextChanged
        If Not String.IsNullOrEmpty(tbCari.Text.Trim()) Then
            Try
                dgvAnggota.Rows.Clear()
                koneksi()
                Dim query As String = "SELECT * FROM tbl_anggota WHERE nama LIKE @keyword OR jenis_kelamin LIKE @keyword OR telp_anggota LIKE @keyword OR alamat LIKE @keyword"
                Dim cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@keyword", "%" & tbCari.Text & "%")
                Dim adapter As New MySqlDataAdapter(cmd)
                Dim ds As New DataSet
                adapter.Fill(ds, "anggota")
                If ds.Tables("anggota").Rows.Count > 0 Then
                    For i As Integer = 0 To ds.Tables("anggota").Rows.Count - 1
                        dgvAnggota.Rows.Add(ds.Tables("anggota").Rows(i).Item(0).ToString,
                                    ds.Tables("anggota").Rows(i).Item(1).ToString,
                                    ds.Tables("anggota").Rows(i).Item(2).ToString,
                                    ds.Tables("anggota").Rows(i).Item(3).ToString,
                                    ds.Tables("anggota").Rows(i).Item(4).ToString)
                    Next
                Else
                    MessageBox.Show("Tidak ada hasil yang cocok untuk kata kunci tersebut.", "Pencarian", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Catch ex As Exception
                MessageBox.Show("Terjadi kesalahan: " & ex.Message)
            Finally
                conn.Close()
            End Try
        End If
    End Sub
End Class