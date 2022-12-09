Public Class Form1

    Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Sub DisplaySum(num1 As Double, num2 As Double)
        Dim Sum As Double
        Sum = num1 + num2
        txtOutput.Text = CStr(Sum)
        txtOutput.ReadOnly = True
    End Sub

    Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim Number1, Number2 As Double
        If (IsNumeric(txtNum1.Text.Trim) = True) Or (IsNumeric(txtNum2.Text.Trim) = True) Then
            Number1 = CDbl(txtNum1.Text.Trim)
            Number2 = CDbl(txtNum2.Text.Trim)
            DisplaySum(Number1, Number2)
        Else
            MsgBox("Input Two Numbers")
            Exit Sub
        End If
    End Sub
End Class
