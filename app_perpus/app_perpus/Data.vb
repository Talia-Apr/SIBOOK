Imports MySql.Data.MySqlClient

Public Class formData
    Dim conn As New MySqlConnection
    Dim da As New MySqlDataAdapter
    Dim cmd As New MySqlCommand
    Dim ds As New DataSet
    Private layer As formKembali
    Public Property nama As String
    Public Property role As String


    Public Sub New(username As String, role As String)
        InitializeComponent()
        Me.nama = username
        Me.role = role
    End Sub

    Sub koneksi()
        conn = New MySqlConnection("server=localhost;user id=root;password=;database=db_project")
    End Sub

    Public Sub New(pengembalian As formKembali)
        InitializeComponent()
        layer = pengembalian
    End Sub

    Private Sub formData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()

        conn = New MySqlConnection()
        conn.ConnectionString = "server=localhost;user id=root;password=;database=db_project"
        conn.Open()

        Try
            ds.Clear()
            da = New MySqlDataAdapter("select tp.id_pinjam As kodePinjam, tg.nama As Nama, tp.id_buku As IdBuku, tj.tgl_pinjam As TglPinjam, tj.tgl_kembali As TglKembali, tp.jumlah As Jumlah from tbl_detailpinjam tp Left Join tbl_pinjam tj on tp.id_pinjam = tj.id_pinjam Left join tbl_buku tb on tp.id_buku = tb.id_buku Left Join tbl_anggota tg on tj.id_anggota = tg.id_anggota;", conn)
            da.Fill(ds, "pinjam")
            dgvDataPinjam.Rows.Clear()
            For i As Integer = 0 To ds.Tables("pinjam").Rows.Count - 1
                dgvDataPinjam.Rows.Add(ds.Tables("pinjam").Rows(i).Item(0).ToString,
                                    ds.Tables("pinjam").Rows(i).Item(1).ToString,
                                    ds.Tables("pinjam").Rows(i).Item(2).ToString,
                                    ds.Tables("pinjam").Rows(i).Item(3).ToString,
                                    ds.Tables("pinjam").Rows(i).Item(4).ToString,
                                    ds.Tables("pinjam").Rows(i).Item(5).ToString)
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Terjadi Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dgvDataPinjam_DoubleClick(sender As Object, e As EventArgs) Handles dgvDataPinjam.DoubleClick
        Dim form As New formKembali(Me.nama, Me.role)
        form.tbPinjam.Text = dgvDataPinjam.CurrentRow.Cells(0).Value.ToString()
        layer.Nilai1 = dgvDataPinjam.CurrentRow.Cells(0).Value.ToString()

        form.tbAnggota.Text = dgvDataPinjam.CurrentRow.Cells(1).Value.ToString()
        layer.Nilai2 = dgvDataPinjam.CurrentRow.Cells(1).Value.ToString()

        form.tbTglKembali.Text = dgvDataPinjam.CurrentRow.Cells(4).Value.ToString()
        layer.Nilai3 = dgvDataPinjam.CurrentRow.Cells(4).Value.ToString()

        layer.Nilai4 = dgvDataPinjam.CurrentRow.Cells(2).Value.ToString()
        Me.Close()
    End Sub
End Class