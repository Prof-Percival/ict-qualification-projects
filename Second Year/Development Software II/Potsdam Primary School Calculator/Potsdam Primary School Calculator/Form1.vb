Public Class frmCalculator
    Private Sub frmCalculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        If txtNum1.Text.Trim = "" Then
            MsgBox("Input Atleast One Digit in 1st Number!")
            txtNum1.Clear()
            txtNum1.Focus()
            txtAnswer.Text = CStr(0)
            Exit Sub
        End If

        If txtNum2.Text.Trim = "" Then
            MsgBox("Input Atleast One Digit in 2nd Number!")
            txtNum2.Clear()
            txtNum2.Focus()
            txtAnswer.Text = CStr(0)
            Exit Sub
        End If

        Dim Num1 As Decimal
        If (IsNumeric(txtNum1.Text.Trim)) Then
            Num1 = CDbl(txtNum1.Text)
        Else
            MsgBox("Alphanumeric Characters Are Not Allowed!")
            txtNum1.Clear()
            txtNum1.Focus()
            txtAnswer.Text = CStr(0)
            Exit Sub
        End If

        Dim Num2 As Decimal
        If (IsNumeric(txtNum2.Text.Trim)) Then
            Num2 = CDbl(txtNum2.Text)
        Else
            MsgBox("Alphanumeric Characters Are Not Allowed!")
            txtNum2.Clear()
            txtNum2.Focus()
            txtAnswer.Text = CStr(0)
            Exit Sub
        End If

        Dim Addition As Decimal
        Addition = Num1 + Num2
        txtAnswer.Text = CStr(Addition)

    End Sub

    Private Sub btnMinus_Click(sender As Object, e As EventArgs)

        If txtNum1.Text.Trim = "" Then
            MsgBox("Input Atleast One Digit in 1st Number!")
            txtNum1.Clear()
            txtNum1.Focus()
            txtAnswer.Text = CStr(0)
            Exit Sub
        End If

        If txtNum2.Text.Trim = "" Then
            MsgBox("Input Atleast One Digit in 2nd Number!")
            txtNum2.Clear()
            txtNum2.Focus()
            txtAnswer.Text = CStr(0)
            Exit Sub
        End If

        Dim Num1 As Decimal
        If (IsNumeric(txtNum1.Text.Trim)) Then
            Num1 = CDbl(txtNum1.Text)
        Else
            MsgBox("Alphanumeric Characters Are Not Allowed!")
            txtNum1.Clear()
            txtNum1.Focus()
            txtAnswer.Text = CStr(0)
            Exit Sub
        End If

        Dim Num2 As Decimal
        If (IsNumeric(txtNum2.Text.Trim)) Then
            Num2 = CDbl(txtNum2.Text)
        Else
            MsgBox("Alphanumeric Characters Are Not Allowed!")
            txtNum2.Clear()
            txtNum2.Focus()
            txtAnswer.Text = CStr(0)
            Exit Sub
        End If

        Dim Subtraction As Decimal
        Subtraction = Num1 - Num2
        txtAnswer.Text = CStr(Subtraction)

    End Sub

    Private Sub btnMultiply_Click(sender As Object, e As EventArgs) Handles btnMultiply.Click
        If txtNum1.Text.Trim = "" Then
            MsgBox("Input Atleast One Digit in 1st Number!")
            txtNum1.Clear()
            txtNum1.Focus()
            txtAnswer.Text = CStr(0)
            Exit Sub
        End If

        If txtNum2.Text.Trim = "" Then
            MsgBox("Input Atleast One Digit in 2nd Number!")
            txtNum2.Clear()
            txtNum2.Focus()
            txtAnswer.Text = CStr(0)
            Exit Sub
        End If

        Dim Num1 As Decimal
        If (IsNumeric(txtNum1.Text.Trim)) Then
            Num1 = CDbl(txtNum1.Text)
        Else
            MsgBox("Alphanumeric Characters Are Not Allowed!")
            txtNum1.Clear()
            txtNum1.Focus()
            txtAnswer.Text = CStr(0)
            Exit Sub
        End If

        Dim Num2 As Decimal
        If (IsNumeric(txtNum2.Text.Trim)) Then
            Num2 = CDbl(txtNum2.Text)
        Else
            MsgBox("Alphanumeric Characters Are Not Allowed!")
            txtNum2.Clear()
            txtNum2.Focus()
            txtAnswer.Text = CStr(0)
            Exit Sub
        End If

        Dim Multiplication
        Multiplication = Num1 * Num2
        txtAnswer.Text = CStr(Multiplication)
    End Sub

    Private Sub btnDivide_Click(sender As Object, e As EventArgs) Handles btnDivide.Click
        If txtNum1.Text.Trim = "" Then
            MsgBox("Input Atleast One Digit in 1st Number!")
            txtNum1.Clear()
            txtNum1.Focus()
            txtAnswer.Text = CStr(0)
            Exit Sub
        End If

        If txtNum2.Text.Trim = "" Then
            MsgBox("Input Atleast One Digit in 2nd Number!")
            txtNum2.Clear()
            txtNum2.Focus()
            txtAnswer.Text = CStr(0)
            Exit Sub
        End If

        If CDbl(txtNum2.Text.Trim) = 0 Then
            MsgBox("You Cannot Divide By 0")
            txtNum2.Clear()
            txtNum2.Focus()
            txtAnswer.Text = CStr(0)
            Exit Sub
        End If

        Dim Num1 As Decimal
        If (IsNumeric(txtNum1.Text.Trim)) Then
            Num1 = CDbl(txtNum1.Text)
        Else
            MsgBox("Alphanumeric Characters Are Not Allowed!")
            txtNum1.Clear()
            txtNum1.Focus()
            txtAnswer.Text = CStr(0)
            Exit Sub
        End If

        Dim Num2 As Decimal
        If (IsNumeric(txtNum2.Text.Trim)) Then
            Num2 = CDbl(txtNum2.Text)
        Else
            MsgBox("Alphanumeric Characters Are Not Allowed!")
            txtNum2.Clear()
            txtNum2.Focus()
            txtAnswer.Text = CStr(0)
            Exit Sub
        End If

        Dim Division As Decimal
        Division = Num1 / Num2
        txtAnswer.Text = CStr(Division)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class