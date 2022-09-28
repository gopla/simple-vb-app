Imports MySql.Data.MySqlClient

Public Class MasterUserForm

    Dim isNew = True

    Private Sub IsNotTypable(ByVal aktif As Boolean)
        email.Enabled = Not aktif
        password.Enabled = Not aktif

        btn_save.Enabled = Not aktif
        btn_add.Enabled = aktif
        btn_edit.Enabled = aktif
        btn_del.Enabled = aktif
        btn_cancel.Enabled = Not aktif
    End Sub

    Private Sub ClearText()
        email.Text = ""
        password.Text = ""

        txt_cari.Text = ""
    End Sub

    Private Sub ShowData()
        Dim dt As DataTable
        Dim adapter As MySqlDataAdapter
        Try
            If txt_cari.Text <> "" Then
                sqlstr = "SELECT email, password, id FROM user WHERE email LIKE '%" & txt_cari.Text & "%'"
            Else
                sqlstr = "SELECT email, password, id FROM user"
            End If
            adapter = New MySqlDataAdapter(sqlstr, openConn())
            dt = New DataTable

            If adapter.Fill(dt) > 0 Then
                dgv_akun.DataSource = dt
                dgv_akun.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
                dgv_akun.Columns(0).HeaderText = "Email"
                dgv_akun.Columns(1).Visible = False
                dgv_akun.Columns(2).Visible = False
                closeConn()
            Else
                dgv_akun.DataSource = Nothing
                closeConn()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            closeConn()
        End Try
    End Sub

    Private Sub StoreData()
        Try
            sqlstr = "INSERT INTO user (email, password) VALUES (@p1, md5(@p2))"
            Using myCmd As New MySqlCommand
                With myCmd
                    .CommandText = sqlstr
                    .Connection = openConn()
                    .Parameters.Add("p1", MySqlDbType.String, 255).Value = email.Text
                    .Parameters.Add("p2", MySqlDbType.String, 255).Value = password.Text
                    .ExecuteNonQuery()
                End With
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            closeConn()
        End Try
    End Sub

    Private Sub UpdateData()
        Try
            sqlstr = "UPDATE user SET email = @p1, password = md5(@p2) WHERE id = @p3"

            Using myCmd As New MySqlCommand
                With myCmd
                    .CommandText = sqlstr
                    .Connection = openConn()
                    .Parameters.Add("p1", MySqlDbType.String, 255).Value = email.Text
                    .Parameters.Add("p2", MySqlDbType.String, 255).Value = password.Text
                    .Parameters.Add("p3", MySqlDbType.String, 255).Value = label_id.Text
                    .ExecuteNonQuery()
                End With
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            closeConn()
        End Try
    End Sub

    Private Sub DeleteData()
        Try
            sqlstr = "DELETE FROM user WHERE id = @p1"

            Using myCmd As New MySqlCommand
                With myCmd
                    .CommandText = sqlstr
                    .Connection = openConn()
                    .Parameters.Add("p1", MySqlDbType.String, 255).Value = label_id.Text
                    .ExecuteNonQuery()
                End With
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            closeConn()
        End Try
    End Sub

    Private Sub MasterUserForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call IsNotTypable(True)
        Call ShowData()
    End Sub

    Private Sub txt_cari_TextChanged(sender As Object, e As EventArgs) Handles txt_cari.TextChanged
        Call ShowData()
    End Sub

    Private Sub dgv_akun_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_akun.CellClick
        Dim i As Integer
        i = dgv_akun.CurrentRow.Index
        With dgv_akun.Rows.Item(i)
            email.Text = .Cells(0).Value
            'password.Text = .Cells(1).Value

            label_id.Text = .Cells(2).Value
        End With
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Call ClearText()
        Call IsNotTypable(True)
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        Call ClearText()
        Call IsNotTypable(False)
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        If isNew Then
            Call StoreData()
        Else
            Call UpdateData()
        End If

        Call ClearText()
        Call IsNotTypable(True)
        Call ShowData()
    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        isNew = False
        Call IsNotTypable(False)
    End Sub

    Private Sub btn_del_Click(sender As Object, e As EventArgs) Handles btn_del.Click
        If email.Text <> "" Then
            Dim res As MsgBoxResult = Nothing

            res = MsgBox("Hapus data ini?", vbYesNo, "Konfirmasi")
            If res = MsgBoxResult.Yes Then
                Call DeleteData()
                Call ShowData()
                Call ClearText()
                MsgBox("Data berhasil dihapus.", MsgBoxStyle.Information)
            End If
        Else
            MsgBox("Pilih data yang ingin dihapus!", MsgBoxStyle.Critical)
        End If

    End Sub
End Class