Public Class Form1
    Private Sub btnOrder_Click(sender As Object, e As EventArgs) Handles btnOrder.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        MsgBox("Leaving so soon? I'll be here, frosted and waiting...")
        Me.Close()
    End Sub
End Class
