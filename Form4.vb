Public Class Form4
    Private Sub btnSubmitOrder_Click(sender As Object, e As EventArgs) Handles btnSubmitOrder.Click
        MsgBox("Your delight is in the oven... metaphorically, for now.")
        Me.Close()
        Application.Exit()
    End Sub

    Private Sub btnCalculateTotal_Click(sender As Object, e As EventArgs) Handles btnCalculateTotal.Click
        Dim total, tax, final As Decimal

        total = (count8 * price8) + (countTiered * priceTiered) + (countSpecialty * priceSpecialty)
        tax = total * 0.1
        final = total + tax

        lblTotalPrice.Text = "For a wish made edible:               $" & final

    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblName.Text = "Dear " & UserName & ", please confirm your order."

        txtCount8.Text = count8
        txtCountTiered.Text = countTiered
        txtCountSpecialty.Text = countSpecialty

        txtPrice8.Text = count8 * price8
        txtPriceTiered.Text = countTiered * priceTiered
        txtPriceSpecialty.Text = countSpecialty * priceSpecialty

        Dim total, tax As Decimal

        total = (count8 * price8) + (countTiered * priceTiered) + (countSpecialty * priceSpecialty)
        tax = total * 0.1

        txtTax.Text = tax

    End Sub

End Class