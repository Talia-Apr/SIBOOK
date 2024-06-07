Imports System.Globalization
Imports MySql.Data.MySqlClient


Public Class formKembali
    Dim conn As New MySqlConnection
    Dim da As New MySqlDataAdapter
    Dim de As New MySqlDataAdapter
    Dim ds, dst As New DataSet
    Dim kode As String = ""
    Dim id_user As String
    Dim formattedDatebalik As DateTime
    Dim formattedDateterima As DateTime
    Dim cmd As MySqlCommand
    Dim rd As MySqlDataReader
    Dim idAnggota As String = ""
    Private value1 As String
    Private value2 As String
    Private value3 As String
    Private value4 As String
    Dim waktuSekarang As TimeSpan = DateTime.Now.TimeOfDay
    'Dim kodePinjam As String = ""

    Public Property nama As String
    Public Property role As String

    Public Property Nilai1() As String
        Get
            Return value1
        End Get
        Set(value As String)
            value1 = value
        End Set
    End Property

    Public Property Nilai2() As String
        Get
            Return value2
        End Get
        Set(value As String)
            value2 = value
        End Set
    End Property

    Public Property Nilai3() As String
        Get
            Return value3
        End Get
        Set(value As String)
            value3 = value
        End Set
    End Property
    Public Property Nilai4() As String
        Get
            Return value4
        End Get
        Set(value As String)
            value4 = value
        End Set
    End Property

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

    Sub tampilKode()
        ds.Clear()
        da = New MySqlDataAdapter("SELECT CASE WHEN MAX(CAST(SUBSTRING(id_kembali, 5, 3) AS UNSIGNED)) IS NULL
                                    THEN 1 ELSE MAX(CAST(SUBSTRING(id_kembali, 5, 3) AS UNSIGNED)) + 1 END AS nomor
                                    FROM ( SELECT MAX(CAST(SUBSTRING(id_kembali, 9, 2) AS UNSIGNED)) AS bln,
                                                  MAX(CAST(SUBSTRING(id_kembali, 12, 4) AS UNSIGNED)) AS thn,
                                                  id_kembali FROM tbl_kembali GROUP BY id_kembali) a WHERE a.bln = MONTH(NOW()) AND a.thn = YEAR(NOW());", conn)
        da.Fill(ds, "nomor")
        Dim nom As Integer
        nom = Integer.Parse(ds.Tables("nomor").Rows(0).ItemArray(0))
        tbKode.Text = "KMB/" & Format(nom, "0##") & "/" & Format(Now.Month, "0#") & "/" & Now.Year
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

    Private Sub pbCari_Click(sender As Object, e As EventArgs) Handles pbCari.Click
        Dim pinjam As New formData(Me)
        pinjam.ShowDialog()
        tbPinjam.Text = value1
        tbAnggota.Text = value2
        tbTglKembali.Text = value3
    End Sub

    Sub tampil_data()
        tampilKode()
        ds.Clear()
        da = New MySqlDataAdapter("select * from tbl_kembali", conn)
        da.Fill(ds, "tabel")
        dgvKembali.Rows.Clear()

        For i As Integer = 0 To ds.Tables("tabel").Rows.Count - 1
            dgvKembali.Rows.Add(ds.Tables("tabel").Rows(i).Item(0).ToString,
                             ds.Tables("tabel").Rows(i).Item(1).ToString,
                             ds.Tables("tabel").Rows(i).Item(2).ToString,
                             ds.Tables("tabel").Rows(i).Item(3).ToString,
                             ds.Tables("tabel").Rows(i).Item(4).ToString)
        Next
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

    Private Sub pinjam_Click(sender As Object, e As EventArgs) Handles pinjam.Click
        Dim form2 As New formPinjam(Me.nama, Me.role)
        form2.Show()
        Me.Hide()
    End Sub

    Private Sub laporan_Click(sender As Object, e As EventArgs) Handles laporan.Click
        Dim form2 As New formLaporan()
        form2.Show()
        Me.Hide()
    End Sub

    Private Sub pbReload_Click(sender As Object, e As EventArgs) Handles pbReload.Click
        If Not String.IsNullOrEmpty(tbTglTerima.Text.Trim()) Then
            ' Hitung selisih hari
            Dim tanggalKembali As Date = Convert.ToDateTime(tbTglKembali.Text)
            Dim tanggalTerima As Date = Convert.ToDateTime(tbTglTerima.Text)
            Dim selisihHari As Integer = (tanggalTerima - tanggalKembali).Days

            ' Hitung denda (5.000 per hari terlambat)
            Dim dendaPerHari As Integer = 5000
            Dim totalDenda As Integer = selisihHari * dendaPerHari

            ' Tampilkan total denda di TextBox Denda
            tbDenda.Text = totalDenda.ToString()
        Else
            MessageBox.Show("Silakan isi tanggal terima terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    End Sub

    Private Sub btnSelesai_Click(sender As Object, e As EventArgs) Handles btnSelesai.Click
        If tbDenda.Text = "" Then
            ErrorProvider1.SetError(tbDenda, "Masukkan nama anggota")
        End If
        Try
            ds.Clear()
            da = New MySqlDataAdapter("insert into tbl_kembali (id_kembali, id_pinjam, id_anggota, tgl_kembali, tgl_terima) values (?,?,?,?,?)", conn)
            da.SelectCommand.Parameters.AddWithValue("id_kembali", tbKode.Text)
            da.SelectCommand.Parameters.AddWithValue("id_pinjam", tbPinjam.Text)
            da.SelectCommand.Parameters.AddWithValue("id_anggota", idAnggota)
            formattedDatebalik = tbTglKembali.Value + waktuSekarang
            formattedDateterima = tbTglTerima.Value + waktuSekarang
            da.SelectCommand.Parameters.AddWithValue("tgl_kembali", formattedDatebalik)
            da.SelectCommand.Parameters.AddWithValue("tgl_terima", formattedDateterima)
            da.Fill(ds, "pinjam")

            ds.Clear()
            da = New MySqlDataAdapter("insert into tbl_detailkembali (id_kembali, id_buku, tgl_kembali, tgl_terima, denda) values (?,?,?,?,?)", conn)
            da.SelectCommand.Parameters.AddWithValue("id_kembali", tbKode.Text)
            da.SelectCommand.Parameters.AddWithValue("id_buku", value4)
            da.SelectCommand.Parameters.AddWithValue("tgl_kembali", formattedDatebalik)
            da.SelectCommand.Parameters.AddWithValue("tgl_terima", formattedDateterima)
            da.SelectCommand.Parameters.AddWithValue("denda", tbDenda.Text)
            da.Fill(ds, "detail")

            conn.Open()

            Dim deleteCommand As New MySqlCommand("DELETE FROM tbl_detailpinjam WHERE id_pinjam = ?", conn)
            deleteCommand.Parameters.AddWithValue("id_pinjam", tbPinjam.Text)
            deleteCommand.ExecuteNonQuery()

            conn.Close()

            dgvKembali.Rows.Clear()

            Dim StrukKembali As New StrukKembali
            StrukKembali.kodeKembaliStruk = tbKode.Text
            StrukKembali.namaAnggotaStruk = idAnggota
            StrukKembali.Show()
            MessageBox.Show("Data Berhasil di Simpan")
            bersihkan()
            tampilKode()
            tampil_data()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Terjadi Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub tbDenda_TextChanged(sender As Object, e As EventArgs) Handles tbDenda.TextChanged
        If tbDenda.Text IsNot "" Then
            ErrorProvider1.SetError(tbDenda, "")
        End If
    End Sub

    Private Sub tbDenda_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbDenda.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsPunctuation(e.KeyChar) Then
            MsgBox("Masukkan Angka")
            e.Handled = True
        End If
    End Sub

    Private Sub fromKembali_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            koneksi()
            Me.CenterToScreen()
            tampilKode()
            tampil_data()
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

    Private Sub btnPinjam_Click(sender As Object, e As EventArgs) Handles btnPinjam.Click
        bersihkan()
        Dim form As New formDataKembali(Me.nama, Me.role)
        form.Show()
        Me.Hide()
    End Sub

    Private Sub tbAnggota_TextChanged(sender As Object, e As EventArgs) Handles tbAnggota.TextChanged
        Dim query As String = "select id_anggota from tbl_anggota where nama = @namaAnggota"
        koneksi()
        cmd = New MySqlCommand("select id_anggota from tbl_anggota where nama = @namaAnggota", conn)
        cmd.Parameters.Clear()

        cmd.Parameters.Add("@namaAnggota", MySqlDbType.VarChar).Value = tbAnggota.Text

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
    End Sub
End Class