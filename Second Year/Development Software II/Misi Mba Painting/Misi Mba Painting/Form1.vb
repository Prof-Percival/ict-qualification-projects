Public Class Form1

    Dim TotalLitres As Integer = 0

    Function Litres(ByVal Height As Double, ByVal Width As Double) As Integer
        'Calculating Area
        Dim Area As Double
        Area = Height * Width

        'Returning Value to Event PProcedure (Calling Statement)
        Return Math.Round(((Area / 15) * 5), 0)
    End Function

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim P As Integer
        'Height of the Wall Validation Begins        
        If (txtHeight.Text.Trim() <> "") Then
            If (IsNumeric(txtHeight.Text.Trim())) Then
                For P = 0 To (txtHeight.Text.Trim().Length() - 1)
                    Select Case (txtHeight.Text.Trim().Substring(P, 1))
                        Case " "
                            MessageBox.Show("Height of the Wall Must Be Numeric Without a Space Character", "Heigh of the Wall", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            txtHeight.Clear()
                            txtHeight.Focus()
                            Exit Sub
                    End Select
                Next
                If (CDbl(txtHeight.Text.Trim()) > 0) Then
                    'The Height Value is Valid
                Else
                    MessageBox.Show("Height of the Wall Must Be Greater Than 0", "Heigh of the Wall", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtHeight.Clear()
                    txtHeight.Focus()
                    Exit Sub
                End If
            Else
                MessageBox.Show("Height of the Wall Must Be Numeric", "Heigh of the Wall", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtHeight.Clear()
                txtHeight.Focus()
                Exit Sub
            End If
        Else
            MessageBox.Show("Input Height of the Wall", "Heigh of the Wall", MessageBoxButtons.OK, MessageBoxIcon.Question)
            txtHeight.Clear()
            txtHeight.Focus()
            Exit Sub
        End If
        '
        'Height of the Wall Validation Ends


        'Width of the Wall Validation Begins        
        If (txtWidth.Text.Trim() <> "") Then
            If (IsNumeric(txtWidth.Text.Trim())) Then
                For P = 0 To (txtWidth.Text.Trim().Length() - 1)
                    Select Case (txtWidth.Text.Trim().Substring(P, 1))
                        Case " "
                            MessageBox.Show("Width of the Wall Must Be Numeric Without a Space Character", "Width of the Wall", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            txtWidth.Clear()
                            txtWidth.Focus()
                            Exit Sub
                    End Select
                Next
                If (CDbl(txtWidth.Text.Trim()) > 0) Then
                    'The Width Value is Valid
                Else
                    MessageBox.Show("Width of the Wall Must Be Greater Than 0", "Width of the Wall", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtWidth.Clear()
                    txtWidth.Focus()
                    Exit Sub
                End If
            Else
                MessageBox.Show("Width of the Wall Must Be Numeric", "Width of the Wall", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtWidth.Clear()
                txtWidth.Focus()
                Exit Sub
            End If
        Else
            MessageBox.Show("Input Width of the Wall", "Width of the Wall", MessageBoxButtons.OK, MessageBoxIcon.Question)
            txtWidth.Clear()
            txtWidth.Focus()
            Exit Sub
        End If
        '
        'Width of the Wall Validation Ends

        'Calculating Litres Needed by Calling Function Procedure & Calculating Total Litres So Far
        Dim LitresNeeded As Integer
        LitresNeeded = Litres(CDbl(txtHeight.Text.Trim()), CDbl(txtWidth.Text.Trim()))
        TotalLitres += LitresNeeded

        'Assigning Values To Textboxes
        txtHeight.Text = txtHeight.Text.Trim()
        txtWidth.Text = txtWidth.Text.Trim()
        txtLitresNeeded.Text = LitresNeeded.ToString() & "ℓ"
        txtTotalLitres.Text = TotalLitres.ToString() & "ℓ"

        'Disabling Input Text Boxes
        txtHeight.Enabled() = False
        txtWidth.Enabled() = False

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Close The App
        Me.Close()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        'Calling Sub Procedure To Perform Actions
        ReInput()
    End Sub

    Sub ReInput()
        'Clearing and Enabling Text boxes
        txtHeight.Clear()
        txtWidth.Clear()
        txtLitresNeeded.Clear()
        txtHeight.Enabled() = True
        txtWidth.Enabled() = True
        txtHeight.Focus()
    End Sub
End Class