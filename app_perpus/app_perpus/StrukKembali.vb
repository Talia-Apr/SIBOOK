Imports MySql.Data.MySqlClient

Public Class StrukKembali
    Dim conn As New MySqlConnection
    Dim da As New MySqlDataAdapter
    Dim ds As New DataSet

    Public Property kodeKembaliStruk As String
    Public Property namaAnggotaStruk As String

    Sub koneksi()
        conn = New MySqlConnection("server= localhost" + ";user id=root" + "; 
                                        password=" + "; database=db_project" + "")
        conn.Open()
    End Sub

    Private Sub StrukKembali_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
    End Sub

    Sub tampil_struk()
        Try
            da = New MySqlDataAdapter("Select tb.id_kembali As id_kembali, tg.nama As nama, tk.judul As judul, tb.tgl_kembali As tgl_kembali, tb.tgl_terima As tgl_terima, dk.denda As denda from tbl_kembali tb join tbl_detailkembali dk on tb.id_kembali = dk.id_kembali left join tbl_anggota tg on tb.id_anggota = tg.id_anggota left join tbl_buku tk on dk.id_buku = tk.id_buku where dk.id_kembali = @id_kembali", conn)
            da.SelectCommand.Parameters.AddWithValue("@id_kembali", kodeKembaliStruk)
            da.Fill(ds, "struk")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Terjadi Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub StrukKembali_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        ds.Clear()
        koneksi()
        Try
            Dim report As New CrystalReport2

            tampil_struk()
            report.SetDataSource(ds.Tables("struk"))

            For Each paramField As CrystalDecisions.CrystalReports.Engine.ParameterFieldDefinition In report.ParameterFields
                Select Case paramField.Name
                    Case "nama"
                        paramField.CurrentValues.Clear()
                        paramField.CurrentValues.AddValue(namaAnggotaStruk)
                        report.DataDefinition.ParameterFields(paramField.Name).ApplyCurrentValues(paramField.CurrentValues)
                    Case "id_kembali"
                        paramField.CurrentValues.Clear()
                        paramField.CurrentValues.AddValue(kodeKembaliStruk)
                        report.DataDefinition.ParameterFields(paramField.Name).ApplyCurrentValues(paramField.CurrentValues)
                End Select
            Next

            CrystalReportViewer1.ReportSource = report
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message & vbCrLf & ex.StackTrace, "Crystal Reports Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class