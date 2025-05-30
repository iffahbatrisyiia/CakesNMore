Public Class Form3
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click

        If txtName.Text <> "" Then
            UserName = txtName.Text
            Form4.Show()
            Me.Hide()
        Else
            MessageBox.Show("Please enter your name.")
        End If

    End Sub
End Class