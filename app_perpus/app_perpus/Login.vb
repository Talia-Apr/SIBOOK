Imports MySql.Data.MySqlClient

Public Class Login
    Dim conn As MySqlConnection
    Dim cmd As MySqlCommand
    Dim rd As MySqlDataReader

    Sub koneksi()
        conn = New MySqlConnection("server=localhost;user id=root;password=;database=db_project")
    End Sub

    Sub bersihkan()
        For Each ctr In Me.Controls
            If TypeOf ctr Is TextBox Then
                ctr.Text = " "
            ElseIf TypeOf ctr Is CheckBox Then
                DirectCast(ctr, CheckBox).Checked = False
            End If
        Next
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        koneksi()
        cmd = New MySqlCommand("SELECT `username`, `password`, `role` FROM tbl_user WHERE username = @username AND password = @password", conn)
        cmd.Parameters.Clear()

        cmd.Parameters.Add("@username", MySqlDbType.VarChar).Value = tbNama.Text
        cmd.Parameters.Add("@password", MySqlDbType.VarChar).Value = tbPass.Text

        Try
            conn.Open()

            Using reader As MySqlDataReader = cmd.ExecuteReader
                If reader.HasRows Then
                    reader.Read() ' Move to the first row
                    Dim username As String = reader("username").ToString()
                    Dim role As String = reader("role").ToString()

                    MessageBox.Show("Selamat Datang " & username & "!", "Konfirmasi", MessageBoxButtons.OK)

                    ' Open the appropriate dashboard based on the role
                    If role = "Owner" Then
                        Dim ownerDashboard As New formDashboard(username, role)
                        ownerDashboard.SetMenuVisibilityForOwner()
                        Me.Hide()
                        ownerDashboard.Show()
                    ElseIf role = "Admin" Then
                        Dim adminDashboard As New formDashboard(username, role)
                        adminDashboard.SetMenuVisibilityForAdmin()
                        Me.Hide()
                        adminDashboard.Show()
                    ElseIf role = "Pengelola" Then
                        Dim pengelolaDashboard As New formDashboard(username, role)
                        pengelolaDashboard.SetMenuVisibilityForPengelola()
                        Me.Hide()
                        pengelolaDashboard.Show()
                    Else
                        MessageBox.Show("Role tidak dikenali!", "Error", MessageBoxButtons.OK)
                    End If
                Else
                    ' Username not found, display an error message
                    MessageBox.Show("Masukkan data dengan benar!", "Error", MessageBoxButtons.OK)
                End If

                bersihkan()
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            conn.Close()

        End Try
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        tbPass.UseSystemPasswordChar = True
        Me.CenterToScreen()
    End Sub

    Private Sub cbPass_CheckedChanged(sender As Object, e As EventArgs) Handles cbPass.CheckedChanged
        If tbPass.UseSystemPasswordChar = True Then
            'hide password
            tbPass.UseSystemPasswordChar = False
        Else
            'show password
            tbPass.UseSystemPasswordChar = True
        End If
    End Sub
End Class
