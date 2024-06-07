Imports MySql.Data.MySqlClient

Public Class formBuku
    Dim conn As MySqlConnection
    Dim cmd As MySqlCommand
    Dim da As New MySqlDataAdapter
    Dim ds As New DataSet
    Dim rd As MySqlDataReader
    Dim kode As String = ""


    Public Property nama As String
    Public Property role As String
    'property variable 

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
            ElseIf TypeOf ctr Is NumericUpDown Then
                DirectCast(ctr, NumericUpDown).Value = 0
            End If
        Next
    End Sub

    Sub tampilKode()
        koneksi()
        ds.Clear()
        da = New MySqlDataAdapter("SELECT CASE WHEN MAX(CAST(SUBSTRING(id_buku, 4) AS UNSIGNED)) IS NULL THEN 'BK001' ELSE CONCAT('BK', LPAD(MAX(CAST(SUBSTRING(id_buku, 4) AS UNSIGNED)) + 1, 3, '0')) END FROM tbl_buku;", conn)
        da.Fill(ds, "nomor")
        kode = ds.Tables("nomor").Rows(0).Item(0).ToString
        tbKode.Text = kode
    End Sub


    Sub tampilData()
        koneksi()
        Try
            ds.Clear()
            da = New MySqlDataAdapter("SELECT * FROM tbl_buku;", conn)
            da.Fill(ds, "buku")
            dgvBuku.Rows.Clear()

            For i As Integer = 0 To ds.Tables("buku").Rows.Count - 1
                dgvBuku.Rows.Add(ds.Tables("buku").Rows(i).Item(0).ToString,
                                              ds.Tables("buku").Rows(i).Item(1).ToString,
                                              ds.Tables("buku").Rows(i).Item(2).ToString,
                                              ds.Tables("buku").Rows(i).Item(3).ToString,
                                              ds.Tables("buku").Rows(i).Item(4).ToString)
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Terjadi kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Sub hapusdata(kode As String)
        koneksi()
        Dim sql As String = "DELETE FROM tbl_buku WHERE id_buku = ?"
        Try
            If rd IsNot Nothing AndAlso Not rd.IsClosed Then
                rd.Close()
            End If
            Dim cmd As New MySqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("kodeBuku", kode)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Data berhasil dihapus")
            tampilData()
            bersihkan()
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan" & ex.Message)
        End Try
    End Sub

    Private Sub formBuku_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
                ElseIf TypeOf ctr Is NumericUpDown Then
                    ctr.Enabled = False
                End If
            Next
        End Try

    End Sub

    Private Sub dgvBuku_DoubleClick(sender As Object, e As EventArgs) Handles dgvBuku.DoubleClick
        If dgvBuku.SelectedRows.Count > 0 Then
            Dim selectRow As DataGridViewRow = dgvBuku.SelectedRows(0)
            tbKode.Text = selectRow.Cells("kodeBuku").Value.ToString()
            tbJudul.Text = selectRow.Cells("judulBuku").Value.ToString()
            tbPenerbit.Text = selectRow.Cells("penerbitBuku").Value.ToString()
            tbRak.Text = selectRow.Cells("rakBuku").Value.ToString()
            tbStok.Text = selectRow.Cells("stokBuku").Value.ToString()
        End If
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Dim cek As Boolean = True

        If tbJudul.Text = "" Then
            ErrorProvider1.SetError(tbJudul, "Masukkan judul buku")
        End If
        If tbPenerbit.Text = "" Then
            ErrorProvider1.SetError(tbPenerbit, "Masukkan penerbit buku")
        End If
        If tbRak.Text = "" Then
            ErrorProvider1.SetError(tbRak, "Pilih rak terlebih dahulu")
        End If
        If tbStok.Text = "" OrElse Convert.ToInt32(tbStok.Text) = 0 Then
            ErrorProvider1.SetError(tbStok, "Stok tidak boleh kosong atau 0")
            cek = False
        End If

        Dim judul As String = tbJudul.Text
        Dim penerbit As String = tbPenerbit.Text
        Dim rak As String = tbRak.Text
        Dim stok As String = tbStok.Text

        ' Check if the title already exists
        Dim checkQuery As String = "SELECT COUNT(*) FROM tbl_buku WHERE judul = @judul"
        cmd = New MySqlCommand(checkQuery, conn)
        cmd.Parameters.AddWithValue("@judul", judul)

        Try
            koneksi()
            tampilKode()
            Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())

            If count > 0 Then
                ' Title already exists, display an error message
                MessageBox.Show("Buku dengan judul tersebut sudah ada!", "Error", MessageBoxButtons.OK)
            Else
                ' Title doesn't exist, proceed with the insert query
                Dim insertQuery As String = "INSERT INTO tbl_buku(id_buku, judul, penerbit, rak, stok) VALUES(?,?,?,?,?)"
                cmd = New MySqlCommand(insertQuery, conn)
                cmd.Parameters.AddWithValue("kodeBuku", tbKode.Text)
                cmd.Parameters.AddWithValue("judulBuku", judul)
                cmd.Parameters.AddWithValue("penerbiBuku", penerbit)
                cmd.Parameters.AddWithValue("rakBuku", rak)
                cmd.Parameters.AddWithValue("stokBuku", stok)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Data berhasil disimpan!")
                tampilData()
                bersihkan()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        If dgvBuku.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = dgvBuku.SelectedRows(0)
            Dim kode As String = selectedRow.Cells("kodeBuku").Value.ToString()
            Dim judul As String = tbJudul.Text
            Dim penerbit As String = tbPenerbit.Text
            Dim rak As String = tbRak.Text
            Dim stok As String = tbStok.Text

            Dim sql As String = "UPDATE tbl_buku SET judul = ?, penerbit = ?, rak = ?, stok = ? WHERE id_buku = ?"

            Try
                Call koneksi()
                Dim cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("judulBuku", judul)
                cmd.Parameters.AddWithValue("penerbitBuku", penerbit)
                cmd.Parameters.AddWithValue("rakBuku", rak)
                cmd.Parameters.AddWithValue("stokBuku", stok)
                cmd.Parameters.AddWithValue("kodeBuku", kode)

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
        If dgvBuku.SelectedRows.Count > 0 Then
            bersihkan()
            Dim selectedRow As DataGridViewRow = dgvBuku.SelectedRows(0)
            Dim kode As String = selectedRow.Cells("kodeBuku").Value.ToString()
            hapusdata(kode)
            tampilData()
        Else
            MessageBox.Show("Pilih baris yang ingin dihapus")
        End If


    End Sub

    Private Sub tbJudul_TextChanged(sender As Object, e As EventArgs) Handles tbJudul.TextChanged
        If tbJudul.Text IsNot "" Then
            ErrorProvider1.SetError(tbJudul, "")
        End If
    End Sub

    Private Sub tbPenerbit_TextChanged(sender As Object, e As EventArgs) Handles tbPenerbit.TextChanged
        If tbPenerbit.Text IsNot "" Then
            ErrorProvider1.SetError(tbPenerbit, "")
        End If
    End Sub

    Private Sub tbRak_TextChanged(sender As Object, e As EventArgs) Handles tbRak.TextChanged
        If tbRak.Text IsNot "" Then
            ErrorProvider1.SetError(tbRak, "")
        End If
    End Sub

    Private Sub tbStok_TextChanged(sender As Object, e As EventArgs) Handles tbStok.TextChanged
        If tbStok.Text IsNot "" Then
            ErrorProvider1.SetError(tbStok, "")
        End If
    End Sub

    Private Sub tbStok_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbStok.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsPunctuation(e.KeyChar) Then
            MsgBox("Masukkan Angka")
            e.Handled = True
        End If
    End Sub

    Private Sub tbJudul_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbJudul.KeyPress
        If Char.IsDigit(e.KeyChar) Or Char.IsPunctuation(e.KeyChar) Then
            MsgBox("Masukkan Huruf")
            e.Handled = True
        End If
    End Sub

    Private Sub tbPenerbit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbPenerbit.KeyPress
        If Char.IsDigit(e.KeyChar) Or Char.IsPunctuation(e.KeyChar) Then
            MsgBox("Masukkan Huruf")
            e.Handled = True
        End If
    End Sub

    Private Sub tbCari_TextChanged(sender As Object, e As EventArgs) Handles tbCari.TextChanged
        If Not String.IsNullOrEmpty(tbCari.Text.Trim()) Then
            Try
                dgvBuku.Rows.Clear()
                koneksi()
                Dim query As String = "SELECT * FROM tbl_buku WHERE judul LIKE @keyword OR penerbit LIKE @keyword OR rak LIKE @keyword"
                Dim cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@keyword", "%" & tbCari.Text & "%")
                Dim adapter As New MySqlDataAdapter(cmd)
                Dim ds As New DataSet
                adapter.Fill(ds, "buku")
                If ds.Tables("buku").Rows.Count > 0 Then
                    For i As Integer = 0 To ds.Tables("buku").Rows.Count - 1
                        dgvBuku.Rows.Add(ds.Tables("buku").Rows(i).Item(0).ToString,
                                    ds.Tables("buku").Rows(i).Item(1).ToString,
                                    ds.Tables("buku").Rows(i).Item(2).ToString,
                                    ds.Tables("buku").Rows(i).Item(3).ToString,
                                    ds.Tables("buku").Rows(i).Item(4).ToString)
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

    Private Sub dashboard_Click(sender As Object, e As EventArgs) Handles dashboard.Click
        Dim form2 As New formDashboard(Me.nama, Me.role)
        form2.Show()
        Me.Hide() 'buat ngeset value
    End Sub

    Private Sub anggota_Click(sender As Object, e As EventArgs) Handles anggota.Click
        Dim form2 As New formAnggota(Me.nama, Me.role)
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
End Class