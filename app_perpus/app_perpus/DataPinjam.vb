Imports MySql.Data.MySqlClient

Public Class formDataPinjam
    Dim conn As New MySqlConnection
    Dim da As New MySqlDataAdapter
    Dim ds As New DataSet
    Public idPinjam As String
    Public namaPinj As String

    Public Property nama As String
    Public Property role As String

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
            da = New MySqlDataAdapter("select tbl_pinjam.id_pinjam, tbl_anggota.nama, tbl_pinjam.tgl_pinjam, tbl_pinjam.tgl_kembali, tbl_pinjam.jumlah FROM tbl_pinjam INNER JOIN tbl_anggota ON tbl_pinjam.id_anggota = tbl_anggota.id_anggota", conn)
            da.Fill(ds, "pinjam")
            dgvDataPinjam.Rows.Clear()

            For i As Integer = 0 To ds.Tables("pinjam").Rows.Count - 1
                dgvDataPinjam.Rows.Add(ds.Tables("pinjam").Rows(i).Item("id_pinjam").ToString,
                     ds.Tables("pinjam").Rows(i).Item("nama").ToString,
                     ds.Tables("pinjam").Rows(i).Item("tgl_pinjam").ToString,
                     ds.Tables("pinjam").Rows(i).Item("tgl_kembali").ToString,
                     ds.Tables("pinjam").Rows(i).Item("jumlah").ToString)

            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Terjadi Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub formDataPinjam_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        tampil_data()
        Me.CenterToScreen()
    End Sub

    Private Sub formDataPinjam_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        koneksi()
        tampil_data()
        Me.CenterToScreen()
    End Sub


    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        Dim form2 As New formPinjam(Me.nama, Me.role)
        form2.Show()
        Me.Hide()
    End Sub

    Private Sub dgvDataPinjam_DoubleClick(sender As Object, e As EventArgs) Handles dgvDataPinjam.DoubleClick
        Try
            If dgvDataPinjam.SelectedRows.Count > 0 Then
                Dim selectedRow As DataGridViewRow = dgvDataPinjam.SelectedRows(0)
                idPinjam = selectedRow.Cells("kodePinjam").Value.ToString()
                namaPinj = selectedRow.Cells("namaAnggota").Value.ToString()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Terjadi Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        bersihkan()

        Dim form2 As New formDetailPinjam(idPinjam, namaPinj)
        form2.Show()

        Me.Hide()

        Me.Dispose()
    End Sub

End Class