Imports MySql.Data.MySqlClient

Public Class Form1

    Dim isNew = True
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Index()
        Call IsNotTypable(True)
    End Sub

    Private Sub IsNotTypable(ByVal aktif As Boolean)
        no_resi.Enabled = Not aktif
        package_desc.Enabled = Not aktif
        sender_address.Enabled = Not aktif
        sender_name.Enabled = Not aktif
        receiver_address.Enabled = Not aktif
        receiver_name.Enabled = Not aktif
        weight.Enabled = Not aktif
        price.Enabled = Not aktif

        btn_save.Enabled = Not aktif
        btn_add.Enabled = aktif
        btn_edit.Enabled = aktif
        btn_del.Enabled = aktif
        btn_cancel.Enabled = Not aktif

        label_id.Visible = False
    End Sub

    Private Sub ClearText()
        no_resi.Text = ""
        package_desc.Text = ""
        sender_address.Text = ""
        sender_name.Text = ""
        receiver_address.Text = ""
        receiver_name.Text = ""
        weight.Text = ""
        price.Text = ""
    End Sub

    Private Sub Index()
        Dim dt As DataTable
        Dim adapter As MySqlDataAdapter
        Try
            If txt_cari.Text <> "" Then
                sqlstr = "SELECT no_resi, package_desc, sender_name, sender_address, receiver_name, receiver_address, weight, price, id FROM package WHERE no_resi LIKE '%" & txt_cari.Text & "%'"
            Else
                sqlstr = "SELECT no_resi, package_desc, sender_name, sender_address, receiver_name, receiver_address, weight, price, id FROM package"
            End If
            adapter = New MySqlDataAdapter(sqlstr, openConn())
            dt = New DataTable

            If adapter.Fill(dt) > 0 Then
                dgv_paket.DataSource = dt
                dgv_paket.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
                dgv_paket.Columns(0).HeaderText = "No Resi"
                dgv_paket.Columns(1).HeaderText = "Deskripsi Paket"
                dgv_paket.Columns(2).HeaderText = "Pengirim"
                dgv_paket.Columns(3).HeaderText = "Alamat Pengirim"
                dgv_paket.Columns(4).HeaderText = "Penerima"
                dgv_paket.Columns(5).HeaderText = "Alamat Penerima"
                dgv_paket.Columns(6).HeaderText = "Berat (kg)"
                dgv_paket.Columns(7).HeaderText = "Harga"
                dgv_paket.Columns(8).Visible = False
                closeConn()
            Else
                dgv_paket.DataSource = Nothing
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
            sqlstr = "INSERT INTO package (no_resi, package_desc, sender_name, sender_address, receiver_name, receiver_address, weight, price) VALUES (@p1, @p2, @p3, @p4, @p5, @p6, @p7, @p7)"
            Using myCmd As New MySqlCommand
                With myCmd
                    .CommandText = sqlstr
                    .Connection = openConn()
                    .Parameters.Add("p1", MySqlDbType.String, 255).Value = no_resi.Text
                    .Parameters.Add("p2", MySqlDbType.String, 255).Value = package_desc.Text
                    .Parameters.Add("p3", MySqlDbType.String, 255).Value = sender_name.Text
                    .Parameters.Add("p4", MySqlDbType.String, 255).Value = sender_address.Text
                    .Parameters.Add("p5", MySqlDbType.String, 255).Value = receiver_name.Text
                    .Parameters.Add("p6", MySqlDbType.String, 255).Value = receiver_address.Text
                    .Parameters.Add("p7", MySqlDbType.String, 255).Value = weight.Text
                    .Parameters.Add("p8", MySqlDbType.String, 255).Value = price.Text
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
            sqlstr = "UPDATE package SET no_resi = @p1, package_desc = @p2, sender_name = @p3, sender_address = @p4, receiver_name = @p5, receiver_address = @p6, weight = @p7, price = @p8 WHERE id = @p9"

            Using myCmd As New MySqlCommand
                With myCmd
                    .CommandText = sqlstr
                    .Connection = openConn()
                    .Parameters.Add("p1", MySqlDbType.String, 255).Value = no_resi.Text
                    .Parameters.Add("p2", MySqlDbType.String, 255).Value = package_desc.Text
                    .Parameters.Add("p3", MySqlDbType.String, 255).Value = sender_name.Text
                    .Parameters.Add("p4", MySqlDbType.String, 255).Value = sender_address.Text
                    .Parameters.Add("p5", MySqlDbType.String, 255).Value = receiver_name.Text
                    .Parameters.Add("p6", MySqlDbType.String, 255).Value = receiver_address.Text
                    .Parameters.Add("p7", MySqlDbType.String, 255).Value = weight.Text
                    .Parameters.Add("p8", MySqlDbType.String, 255).Value = price.Text
                    .Parameters.Add("p9", MySqlDbType.String, 255).Value = label_id.Text
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
            sqlstr = "DELETE FROM package WHERE id = @p1"

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

    Private Sub dgv_paket_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_paket.CellClick
        Dim i As Integer
        i = dgv_paket.CurrentRow.Index
        With dgv_paket.Rows.Item(i)
            no_resi.Text = .Cells(0).Value
            package_desc.Text = .Cells(1).Value
            receiver_name.Text = .Cells(4).Value
            receiver_address.Text = .Cells(5).Value
            sender_name.Text = .Cells(2).Value
            sender_address.Text = .Cells(3).Value
            weight.Text = .Cells(6).Value
            price.Text = .Cells(7).Value
            label_id.Text = .Cells(8).Value
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
        Call Index()
    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        isNew = False
        Call IsNotTypable(False)
    End Sub

    Private Sub btn_del_Click(sender As Object, e As EventArgs) Handles btn_del.Click
        If no_resi.Text <> "" Then
            Dim res As MsgBoxResult = Nothing

            res = MsgBox("Hapus data ini?", vbYesNo, "Konfirmasi")
            If res = MsgBoxResult.Yes Then
                Call DeleteData()
                Call Index()
                Call ClearText()
                MsgBox("Data berhasil dihapus.", MsgBoxStyle.Information)
            End If
        Else
                MsgBox("Pilih data yang ingin dihapus!", MsgBoxStyle.Critical)
        End If

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txt_cari.TextChanged
        Call Index()
    End Sub
End Class
