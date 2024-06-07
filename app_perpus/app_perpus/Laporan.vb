Imports MySql.Data.MySqlClient

Public Class formLaporan
    Dim conn As New MySqlConnection
    Dim da As New MySqlDataAdapter
    Dim ds As New DataSet

    Public Property kodePinjamStruk As String
    Public Property namaAnggotaStruk As String

    Sub koneksi()
        conn = New MySqlConnection("server= localhost" + ";user id=root" + "; 
                                        password=" + "; database=db_project" + "")
        conn.Open()
    End Sub

    Private Sub StrukKembali_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
    End Sub

    Sub tampil_strukPinjam()
        Try
            da = New MySqlDataAdapter("SELECT p.id_pinjam, tg.nama AS nama, b.judul AS judul,
                dp.jumlah AS jumlah, p.tgl_pinjam AS tgl_pinjam, p.tgl_kembali AS tgl_kembali FROM tbl_pinjam p JOIN tbl_detailpinjam
                dp ON p.id_pinjam = dp.id_pinjam left join tbl_anggota tg on p.id_anggota = tg.id_anggota LEFT JOIN
                tbl_buku b ON dp.id_buku = b.id_buku", conn)

            da.Fill(ds, "struk")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Terjadi Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub tampil_strukKembali()
        Try
            da = New MySqlDataAdapter("Select tb.id_kembali As id_kembali, tg.nama As nama, tk.judul As judul, tb.tgl_kembali As tgl_kembali, tb.tgl_terima As tgl_terima, dk.denda As denda from tbl_kembali tb join tbl_detailkembali dk on tb.id_kembali = dk.id_kembali left join tbl_anggota tg on tb.id_anggota = tg.id_anggota left join tbl_buku tk on dk.id_buku = tk.id_buku", conn)

            da.Fill(ds, "struk")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Terjadi Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub StrukKembali_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        ds.Clear()
        koneksi()
        Me.CenterToScreen()
    End Sub

    Private Sub btnReportKembali_Click(sender As Object, e As EventArgs) Handles btnReportKembali.Click
        ds.Clear()
        Try
            Dim report As New CrystalReport5

            tampil_strukPinjam()
            report.SetDataSource(ds.Tables("struk"))

            For Each paramField As CrystalDecisions.CrystalReports.Engine.ParameterFieldDefinition In report.ParameterFields
                Select Case paramField.Name
                    Case "nama"
                        paramField.CurrentValues.Clear()
                        paramField.CurrentValues.AddValue(namaAnggotaStruk)
                        report.DataDefinition.ParameterFields(paramField.Name).ApplyCurrentValues(paramField.CurrentValues)
                    Case "id_pinjam"
                        paramField.CurrentValues.Clear()
                        paramField.CurrentValues.AddValue(kodePinjamStruk)
                        report.DataDefinition.ParameterFields(paramField.Name).ApplyCurrentValues(paramField.CurrentValues)
                End Select
            Next

            CrystalReportViewer1.ReportSource = report
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message & vbCrLf & ex.StackTrace, "Crystal Reports Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub btnReportPinjam_Click(sender As Object, e As EventArgs) Handles btnReportPinjam.Click
        ds.Clear()

        Try
            Dim report As New CrystalReport4

            tampil_strukPinjam()
            report.SetDataSource(ds.Tables("struk"))

            For Each paramField As CrystalDecisions.CrystalReports.Engine.ParameterFieldDefinition In report.ParameterFields
                Select Case paramField.Name
                    Case "nama"
                        paramField.CurrentValues.Clear()
                        paramField.CurrentValues.AddValue(namaAnggotaStruk)
                        report.DataDefinition.ParameterFields(paramField.Name).ApplyCurrentValues(paramField.CurrentValues)
                    Case "id_pinjam"
                        paramField.CurrentValues.Clear()
                        paramField.CurrentValues.AddValue(kodePinjamStruk)
                        report.DataDefinition.ParameterFields(paramField.Name).ApplyCurrentValues(paramField.CurrentValues)
                End Select
            Next

            CrystalReportViewer1.ReportSource = report
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message & vbCrLf & ex.StackTrace, "Crystal Reports Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class