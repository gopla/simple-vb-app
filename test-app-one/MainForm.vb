Public Class MainForm
    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        Close()
        LoginForm.Show()
    End Sub

    Private Sub PaketToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PaketToolStripMenuItem.Click
        Dim frm = New Form1
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub AkunToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AkunToolStripMenuItem.Click
        Dim frm = New MasterUserForm
        frm.MdiParent = Me
        frm.Show()
    End Sub
End Class