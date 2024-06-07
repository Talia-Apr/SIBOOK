Imports System.Globalization
Imports MySql.Data.MySqlClient


Public Class formPinjam
    Dim conn As New MySqlConnection
    Dim da As New MySqlDataAdapter
    Dim de As New MySqlDataAdapter
    Dim ds, dst As New DataSet
    Dim kode As String = ""
    Dim id_user As String
    Dim formattedDate As DateTime
    Dim formattedDatebalik As DateTime
    Dim waktuSekarang As TimeSpan = DateTime.Now.TimeOfDay
    Dim cmd As MySqlCommand
    Dim rd As MySqlDataReader
    Dim idAnggota As String = ""
    Dim kodePinjam As String = ""

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
            ElseIf TypeOf ctr Is NumericUpDown Then
                DirectCast(ctr, NumericUpDown).Value = 1
            End If
        Next
    End Sub


    Sub isi_anggota()
        da = New MySqlDataAdapter("select * from tbl_anggota order by id_anggota", conn)
        da.Fill(ds, "anggota")
        tbAnggota.Items.Clear()
        For i As Integer = 0 To ds.Tables("anggota").Rows.Count - 1
            tbAnggota.Items.Add(ds.Tables("anggota").Rows(i).Item(1).ToString())
        Next
    End Sub

    Sub isi_buku()
        da = New MySqlDataAdapter("select * from tbl_buku order by id_buku", conn)
        da.Fill(ds, "buku")
        tbBuku.Items.Clear()
        For i As Integer = 0 To ds.Tables("buku").Rows.Count - 1
            tbBuku.Items.Add(ds.Tables("buku").Rows(i).Item(1).ToString())
        Next

    End Sub

    Sub tampilKode()
        ds.Clear()
        da = New MySqlDataAdapter("SELECT CASE WHEN MAX(CAST(SUBSTRING(id_pinjam, 5, 3) AS UNSIGNED)) IS NULL
                                    THEN 1 ELSE MAX(CAST(SUBSTRING(id_pinjam, 5, 3) AS UNSIGNED)) + 1 END AS nomor
                                    FROM ( SELECT MAX(CAST(SUBSTRING(id_pinjam, 9, 2) AS UNSIGNED)) AS bln,
                                                  MAX(CAST(SUBSTRING(id_pinjam, 12, 4) AS UNSIGNED)) AS thn,
                                                  id_pinjam FROM tbl_pinjam GROUP BY id_pinjam) a WHERE a.bln = MONTH(NOW()) AND a.thn = YEAR(NOW());", conn)
        da.Fill(ds, "nomor")
        Dim nom As Integer
        nom = Integer.Parse(ds.Tables("nomor").Rows(0).ItemArray(0))
        tbKode.Text = "PJM/" & Format(nom, "0##") & "/" & Format(Now.Month, "0#") & "/" & Now.Year
    End Sub

    Private Sub formPinjam_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            koneksi()
            Me.CenterToScreen()
            isi_anggota()
            isi_buku()
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

    Private Sub formPinjam_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        tampilKode()
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

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Try
            Dim nama_anggota As String = tbAnggota.SelectedItem.ToString()
            Dim judul As String = tbBuku.SelectedItem.ToString()

            ' Cek apakah menu sudah ada di DataGridView
            Dim existingRow As DataGridViewRow = Nothing
            For Each row As DataGridViewRow In dgvPinjam.Rows
                If row.Cells("bukuPinjam").Value IsNot Nothing AndAlso row.Cells("bukuPinjam").Value.ToString() = judul Then
                    existingRow = row
                    Exit For
                End If
            Next
            If existingRow IsNot Nothing Then
                Dim jumlah As Integer = Integer.Parse(existingRow.Cells("jumlahPinjam").Value) + Integer.Parse(tbJumlah.Text)
                existingRow.Cells("jumlahPinjam").Value = jumlah
            Else
                ds.Clear()
                da = New MySqlDataAdapter("select judul, stok from tbl_buku where judul ='" & judul & "'", conn)
                da.Fill(ds, "buku")
                If ds.Tables("buku").Rows.Count > 0 Then
                    Dim stok As Integer = Integer.Parse(ds.Tables("buku").Rows(0).Item("stok"))

                    If stok > 0 Then
                        Dim jumlah As Integer = Integer.Parse(tbJumlah.Text)

                        If jumlah <= stok Then
                            dgvPinjam.Rows.Add(judul, jumlah)

                            If conn.State = ConnectionState.Closed Then
                                conn.Open()
                            End If

                            Dim newStok As Integer = stok - jumlah
                            Dim updateCommand As New MySqlCommand("UPDATE tbl_buku SET stok = @newStok WHERE judul = @judul", conn)
                            updateCommand.Parameters.AddWithValue("@newStok", newStok)
                            updateCommand.Parameters.AddWithValue("@judul", judul)
                            updateCommand.ExecuteNonQuery()

                            conn.Close()
                            bersihkan()
                        Else
                            MessageBox.Show("Maaf, stok buku tidak mencukupi.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        End If
                    ElseIf stok = 0 Then
                        MessageBox.Show("Maaf, stock buku habis.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Terjadi Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub tbTglPinjam_ValueChanged(sender As Object, e As EventArgs) Handles tbTglPinjam.ValueChanged
        tbTglKembali.Value = tbTglPinjam.Value.AddDays(7)
    End Sub

    Private Sub btnSelesai_Click(sender As Object, e As EventArgs) Handles btnSelesai.Click
        Try
            ds.Clear()
            da = New MySqlDataAdapter("insert into tbl_pinjam (id_pinjam, id_anggota, tgl_pinjam, tgl_kembali, jumlah) values (?,?,?,?,?)", conn)
            da.SelectCommand.Parameters.AddWithValue("id_pinjam", tbKode.Text)
            da.SelectCommand.Parameters.AddWithValue("id_anggota", idAnggota)
            formattedDate = tbTglPinjam.Value + waktuSekarang
            formattedDatebalik = tbTglKembali.Value + waktuSekarang
            da.SelectCommand.Parameters.AddWithValue("tgl_pinjam", formattedDate)
            da.SelectCommand.Parameters.AddWithValue("tgl_kembali", formattedDatebalik)
            da.SelectCommand.Parameters.AddWithValue("jumlah", tbJumlah.Text)
            da.Fill(ds, "pinjam")

            For i As Integer = 0 To dgvPinjam.Rows.Count - 1
                Dim jumlah As Integer = dgvPinjam.Rows(i).Cells("jumlahPinjam").Value
                Dim judul As String = dgvPinjam.Rows(i).Cells("bukuPinjam").Value
                de = New MySqlDataAdapter("select id_buku from tbl_buku where judul ='" & judul & "'", conn)
                de.Fill(dst, "buku")
                Dim id_buku As String = dst.Tables(0).Rows(0).Item(0)
                If Not (jumlah = 0) Then

                    ds.Clear()
                    da = New MySqlDataAdapter("insert into tbl_detailpinjam (id_pinjam, id_buku, jumlah) values (?,?,?)", conn)
                    da.SelectCommand.Parameters.AddWithValue("id_pinjam", tbKode.Text)
                    da.SelectCommand.Parameters.AddWithValue("id_buku", id_buku)
                    da.SelectCommand.Parameters.AddWithValue("jumlah", jumlah)
                    da.Fill(ds, "detail")
                End If

            Next

            dgvPinjam.Rows.Clear()

            Dim StrukPinjam As New StrukPinjam
            StrukPinjam.kodePinjamStruk = tbKode.Text
            StrukPinjam.namaAnggotaStruk = idAnggota
            StrukPinjam.Show()
            MessageBox.Show("Data Berhasil di Simpan")
            bersihkan()
            tampilKode()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Terjadi Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnPinjam_Click(sender As Object, e As EventArgs) Handles btnPinjam.Click
        bersihkan()
        formDataPinjam.Show()
        Me.Hide()
    End Sub

    Private Sub tbAnggota_SelectedValueChanged(sender As Object, e As EventArgs) Handles tbAnggota.SelectedValueChanged
        If tbAnggota.SelectedItem IsNot Nothing Then
            Dim query As String = "select id_anggota from tbl_anggota where nama = @namaAnggota"
            koneksi()
            cmd = New MySqlCommand("select id_anggota from tbl_anggota where nama = @namaAnggota", conn)
            cmd.Parameters.Clear()

            cmd.Parameters.Add("@namaAnggota", MySqlDbType.VarChar).Value = tbAnggota.SelectedItem.ToString()

            Try
                Using reader As MySqlDataReader = cmd.ExecuteReader
                    If reader.HasRows Then
                        reader.Read()
                        Dim anggota As String = reader("id_anggota").ToString()

                        idAnggota = anggota
                    Else

                        bersihkan()
                    End If
                End Using

                conn.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
        End If

    End Sub

    Private Sub dgvPinjam_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPinjam.CellContentClick
        If e.ColumnIndex = dgvPinjam.Columns("btnHapus").Index AndAlso e.RowIndex >= 0 Then
            'Menghapus baris yang sesuai dengan tombol "Remove" yang diklik
            dgvPinjam.Rows.RemoveAt(e.RowIndex)
        End If
    End Sub
End Class