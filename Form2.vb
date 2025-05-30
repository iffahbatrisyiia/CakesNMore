Public Class Form2
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Initial setup
        txtCustomisation.Clear()
        txtOccassion.Clear()

        rdo8InchCake.Checked = False
        rdoTieredCake.Checked = False
        rdoSpecialtyCake.Checked = False

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If rdo8InchCake.Checked Then count8 += 1
        If rdoTieredCake.Checked Then countTiered += 1
        If rdoSpecialtyCake.Checked Then countSpecialty += 1

        Dim nextOrder As New Form2()
        nextOrder.Show()
        Me.Close()
    End Sub

    Private Sub btnFinish_Click(sender As Object, e As EventArgs) Handles btnFinish.Click
        If rdo8InchCake.Checked Then count8 += 1
        If rdoTieredCake.Checked Then countTiered += 1
        If rdoSpecialtyCake.Checked Then countSpecialty += 1

        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class