Imports MySql.Data.MySqlClient
Public Class LoginForm
    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Auth()

        Try
            sqlstr = "SELECT * FROM user WHERE email = @p1 AND password = md5(@p2)"
            Using myCmd As New MySqlCommand
                With myCmd
                    .CommandText = sqlstr
                    .Connection = openConn()
                    .Parameters.Add("p1", MySqlDbType.String, 255).Value = email.Text
                    .Parameters.Add("p2", MySqlDbType.String, 255).Value = password.Text
                End With
                dataReader = myCmd.ExecuteReader()
            End Using
            dataReader.Read()

            If dataReader.HasRows Then
                Hide()
                MainForm.Show()
            Else
                MsgBox("Gagal", MsgBoxStyle.Critical)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        Finally
            closeConn()
        End Try
    End Sub

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        If email.Text <> "" Or password.Text <> "" Then
            Call Auth()
        Else
            MsgBox("Isi email dan password", MsgBoxStyle.Critical)
        End If
    End Sub
End Class