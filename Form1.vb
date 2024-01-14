Public Class Form1
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
        'this closes the form
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load

        For decRates As Decimal = 5 To 8 Step 0.25
            lstRates.Items.Add(decRates)
        Next decRates

        For decYears As Decimal = 1 To 30
            lstYears.Items.Add(decYears)
        Next decYears

        'this provides the list of numbers in the list boxes without me having to type them each out individually

    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Dim decYears As Decimal ' multiply by 12 to get months
        Dim decRates As Decimal ' divide by 12 
        Dim decAmtFinanced As Decimal ' the principle
        Dim decMonthPayment As Decimal ' final total to be in label

        'my variables declared

        Decimal.TryParse(lstRates.SelectedItem.ToString, decRates)
        Decimal.TryParse(lstYears.SelectedItem.ToString, decYears)
        Decimal.TryParse(txtAmtFinanced.Text, decAmtFinanced)

        'this assigns the selected value from the listboxes and text box to the appropriate variables

        If decAmtFinanced < 100 Then
            MsgBox("Please enter a valid number greater than 100")
            txtAmtFinanced.Text = String.Empty
            lblMonthPayment.Text = String.Empty
        End If

        'this makes sure a number greater than 100 is entered, if not a message pops up and clears the textbox and label

        'Equation rate/12, nPer*12, PV

        decRates /= 100
        'this makes the percentage into a decimal so that it works in the calculations

        decMonthPayment = -Financial.Pmt(decRates / 12, decYears * 12, decAmtFinanced)


        lblMonthPayment.Text = decMonthPayment.ToString("C2")

        'This is the equation for calculating the monthly payment. It then puts the total into the label

        'I realized the error on my part. I was doing the calculation wrong when trying to check it against the calculator.
        'when you initially said to use the financial payment method it was actually correct so I apologize for the mishap on my part and hopefully got it squared away.

    End Sub


    Private Sub lstRates_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstRates.SelectedIndexChanged
        lblMonthPayment.Text = String.Empty
        'this clears the label if the selection is changed
    End Sub

    Private Sub lstYears_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstYears.SelectedIndexChanged
        lblMonthPayment.Text = String.Empty
        'this clears the label if the selection is changed
    End Sub

    Private Sub txtAmtFinanced_TextChanged(sender As Object, e As EventArgs) Handles txtAmtFinanced.TextChanged
        lblMonthPayment.Text = String.Empty
        'this clears the label if the number is changed
    End Sub

    Private Sub txtAmtFinanced_Click(sender As Object, e As EventArgs) Handles txtAmtFinanced.Click
        txtAmtFinanced.SelectAll()
        'This selects all the text so the user can type over it when they re-enter the textbox
    End Sub
End Class
