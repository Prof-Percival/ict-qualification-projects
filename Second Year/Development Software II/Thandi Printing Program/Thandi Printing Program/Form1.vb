Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'Declarations
        Dim Name As String
        Dim BlackWhite, Colour As Integer


        'Assigning
        If (txtName.Text.Trim.Length - 1) < 1 Then
            MsgBox("Name Must Be Two or More Characters!")
            txtName.Clear()
            txtName.Focus()
            txtTotal.Text = "R0"
            Exit Sub
        End If

        Name = txtName.Text

        If (IsNumeric(txtBlackWhite.Text) = False) Then

            MsgBox("Only Numerics for Number of Pages Are Allowed!")
            txtBlackWhite.Clear()
            'txtBlackWhite.Text = ""
            txtBlackWhite.Focus()
            txtTotal.Text = "R0"
            Exit Sub

        Else
            BlackWhite = CInt(txtBlackWhite.Text)
        End If

        If (IsNumeric(txtColour.Text) = False) Then

            MsgBox("Only Numerics for Number of Pages Are Allowed!")
            txtColour.Clear()
            'txtColour.Text = ""
            txtColour.Focus()
            txtTotal.Text = "R0"
            Exit Sub

        Else
            Colour = CInt(txtColour.Text)
        End If

        If Colour < 0 Then
            MsgBox("Number of Colour Pages Must be >= 0")
            txtColour.Clear()
            txtColour.Focus()
            txtTotal.Text = "R0"
            Exit Sub
        End If

        If BlackWhite < 0 Then
            MsgBox("Number of Black & White Pages Must Be >=0")
            txtBlackWhite.Clear()
            txtBlackWhite.Focus()
            txtTotal.Text = "R0"
            Exit Sub
        End If

        Dim Pages As Integer
        Pages = BlackWhite + Colour

        If Pages < 1 Then
            MsgBox("Total Number of Pages Must Be >= 1 ")
            txtBlackWhite.Clear()
            txtColour.Clear()
            txtBlackWhite.Focus()
            txtTotal.Text = "R0"
            Exit Sub
        End If

        Dim Total As Double

        'Calculations
        Total = (BlackWhite * 0.75) + (Colour * 1.5)

        'Assigning Back to Textbox
        txtTotal.Text = "R" & CStr(Total)

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Me.Dispose()
        Me.Close()
    End Sub

End Class
