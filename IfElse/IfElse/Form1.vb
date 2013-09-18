Option Strict On

Public Class Form1

    Private Sub btnFindLarger_Click(sender As System.Object, e As System.EventArgs) Handles btnFindLarger.Click
        Dim Num1, Num2, largerNum As Double
        Num1 = CDbl(txtFirstNum.Text)
        Num2 = CDbl(txtSecondNum.Text)
        If Num1 > Num2 Then
            largerNum = Num1
        Else
            largerNum = Num2
        End If
        txtResult.Text = "The Larger Numer is" & largerNum
    End Sub

    Private Sub txtFirstNum_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFirstNum.TextChanged

    End Sub
End Class
