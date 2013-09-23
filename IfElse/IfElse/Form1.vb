
Option Strict On

Public Class Form1

    Private Sub btnFindLarger_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFindLarger.Click
        Dim Num1, Num2 As Double

        If Not ((IsNumeric(txtFirstNum.Text)) And IsNumeric(txtSecondNum.Text)) Then
            MessageBox.Show("error: please type a number!", "error")
            Return
        End If

        Num1 = CDbl(txtFirstNum.Text)
        Num2 = CDbl(txtSecondNum.Text)


        If (Num1 < 0 Or Num2 < 0) Then
            MessageBox.Show("Error: please type a POSITIVE number!", "Error")
            Return
        End If

        If (Num1 > Num2) Then
            txtResult.Text = "larger number is" & Num1
        ElseIf (Num2 > Num1) Then
            txtResult.Text = "Larger number is" & Num2
        Else
            txtResult.Text = "The two are equal"
        End If



    End Sub

End Class