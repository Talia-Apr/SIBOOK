Imports MySql.Data.MySqlClient

Public Class formDetailPinjam
    Dim conn As New MySqlConnection
    Dim da As New MySqlDataAdapter
    Dim ds As New DataSet
    Dim idPinjam As String = formDataPinjam.idPinjam
    Dim namaPinj As String = formDataPinjam.namaPinj
    Public Property nama1 As String
    Public Property role1 As String

    Sub koneksi()
        conn = New MySqlConnection("server = localhost" + ";user id = root" + ";password=" + "" + ";database=db_project")
    End Sub

    Public Sub New(username As String, role As String)
        InitializeComponent()
        Me.nama1 = username
        Me.role1 = role
        koneksi()
        tampil_data()

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

    Sub tampil_data()
        ds.Clear()

        da = New MySqlDataAdapter("SELECT 
                                       b.judul AS judul,
                                       dp.jumlah AS jumlah,
                                       p.tgl_pinjam AS tgl_pinjam,
                                       p.tgl_kembali AS tgl_kembali
                                   FROM
                                        tbl_pinjam p
                                   JOIN
                                        tbl_detailpinjam dp ON p.id_pinjam = dp.id_pinjam
                                   JOIN
                                        tbl_buku b ON b.id_buku = dp.id_buku
                                   WHERE dp.id_pinjam='" & idPinjam & "'", conn)
        da.Fill(ds, "detail")
        dgvDataPinjam.Rows.Clear()
        For i As Integer = 0 To ds.Tables("detail").Rows.Count - 1
            dgvDataPinjam.Rows.Add(ds.Tables("detail").Rows(i).Item(0).ToString,
                               ds.Tables("detail").Rows(i).Item(1).ToString,
                               ds.Tables("detail").Rows(i).Item(2).ToString,
                               ds.Tables("detail").Rows(i).Item(3).ToString)
        Next
    End Sub

    Private Sub formDetailPinjam_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        koneksi()
        tampil_data()
        tbKode.Text = idPinjam
        tbNama.Text = namaPinj
        Me.CenterToScreen()
    End Sub

    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        Dim form2 As New formPinjam(Me.nama1, Me.role1)
        form2.Show()
        Me.Hide()
        dgvDataPinjam.Rows.Clear()
    End Sub
End Class