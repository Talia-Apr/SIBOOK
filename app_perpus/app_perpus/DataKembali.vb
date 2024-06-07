Imports MySql.Data.MySqlClient

Public Class formDataKembali
    Dim conn As New MySqlConnection
    Dim da As New MySqlDataAdapter
    Dim ds As New DataSet
    Public idKembali As String
    Public namaKembali As String

    Public Property nama As String
    Public Property role As String
    'property variable 

    Public Sub New(username As String, role As String)
        InitializeComponent()
        Me.nama = username
        Me.role = role
        ' Menyesuaikan visibilitas menu berdasarkan peran pengguna
    End Sub

    Sub koneksi()
        conn = New MySqlConnection("server = localhost" + ";user id = root" + ";password=" + "" + ";database=db_project")
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
        Try
            ds.Clear()
            da = New MySqlDataAdapter("SELECT
                                        tbl_kembali.id_kembali,
                                        tbl_anggota.nama,
                                        tbl_kembali.tgl_kembali,
                                        tbl_kembali.tgl_terima,
                                        tbl_detailkembali.denda
                                    FROM
                                        tbl_kembali
                                    INNER JOIN
                                        tbl_anggota ON tbl_kembali.id_anggota = tbl_anggota.id_anggota
                                    LEFT JOIN
                                        tbl_detailkembali ON tbl_kembali.id_kembali = tbl_detailkembali.id_kembali
                                    ", conn)
            da.Fill(ds, "kembali")
            dgvDataKembali.Rows.Clear()

            For i As Integer = 0 To ds.Tables("kembali").Rows.Count - 1
                dgvDataKembali.Rows.Add(ds.Tables("kembali").Rows(i).Item("id_kembali").ToString,
                     ds.Tables("kembali").Rows(i).Item("nama").ToString,
                     ds.Tables("kembali").Rows(i).Item("tgl_kembali").ToString,
                     ds.Tables("kembali").Rows(i).Item("tgl_terima").ToString,
                     ds.Tables("kembali").Rows(i).Item("denda").ToString)
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Terjadi Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub formDataKembali_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        Me.CenterToScreen()
        tampil_data()
        Dim total As Integer = 0
        For Each row As DataGridViewRow In dgvDataKembali.Rows
            If row.Cells("dendaKembali").Value IsNot Nothing Then
                total += row.Cells("dendaKembali").Value
            End If
        Next
        tbDenda.Text = total
    End Sub

    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        Dim form2 As New formKembali(Me.nama, Me.role)
        form2.Show()
        Me.Hide()
    End Sub

End Class