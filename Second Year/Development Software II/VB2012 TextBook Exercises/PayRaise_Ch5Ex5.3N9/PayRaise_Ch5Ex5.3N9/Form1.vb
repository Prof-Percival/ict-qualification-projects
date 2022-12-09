Public Class Form1

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Sub Output(ByVal FirstName As String, ByVal LastName As String, ByVal CurrentSalary As Double, ByVal NewSalary As Double)
        'Assigning Values To TextBoxes
        txtFirstName.Text = FirstName
        txtLastName.Text = LastName
        txtCurrentSalary.Text = "$" & CStr(CurrentSalary)
        txtNewSalary.Text = "New Salary For " & FirstName & " " & LastName & ": $" & NewSalary
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clears All TextBoxes
        txtFirstName.Clear()
        txtLastName.Clear()
        txtCurrentSalary.Clear()
        txtNewSalary.Clear()
        txtFirstName.Focus()
    End Sub

    Function Calculate(ByVal CurrentSalary As Double) As Double
        'Calculating New Salary
        Dim NewSalary As Double
        If CurrentSalary < 40000 Then
            NewSalary = Math.Round((CurrentSalary + (CurrentSalary * 0.05)), 2)
        ElseIf CurrentSalary >= 40000 Then
            NewSalary = Math.Round((CurrentSalary + (CurrentSalary * 0.02) + 2000), 2)
        End If
        Return NewSalary
    End Function

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        'Calling Input Sub Procedure To Verify Values
        Input()
    End Sub

    Sub Input()
        'Validating Input Data
        Dim NameCheck As String
        Dim P As Integer

        'First Name Validaton Begins
        Dim FirstName As String
        If (txtFirstName.Text.Trim() <> "") Then
            FirstName = txtFirstName.Text.Trim().ToUpper()
            If FirstName.Trim().Length() >= 3 Then
                For P = 0 To (FirstName.Length() - 1)
                    NameCheck = FirstName.Substring(P, 1)
                    Select Case NameCheck
                        Case "A" To "Z", "-"
                            P += 1
                            'Exit Select
                        Case Else
                            MessageBox.Show("First Name Must Be Alphabetic", "First Name", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            txtFirstName.Clear()
                            txtFirstName.Focus()
                            Exit Sub
                    End Select
                Next
            Else
                MessageBox.Show("First Name Must Be >= 3 Characters", "First Name", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtFirstName.Clear()
                txtFirstName.Focus()
                Exit Sub
            End If

        Else
            MessageBox.Show("Input First Name", "First Name", MessageBoxButtons.OK, MessageBoxIcon.Question)
            txtFirstName.Clear()
            txtFirstName.Focus()
            Exit Sub
        End If
        '
        'First Name Validation Ends


        'Last Name Validaton Begins
        Dim LastName As String
        If (txtLastName.Text.Trim() <> "") Then
            LastName = txtLastName.Text.Trim().ToUpper()
            If LastName.Trim().Length() >= 3 Then
                For P = 0 To (LastName.Length() - 1)
                    NameCheck = LastName.Substring(P, 1)
                    Select Case NameCheck
                        Case "A" To "Z", "-"
                            P += 1
                        Case Else
                            MessageBox.Show("Last Name Must Be Alphabetic", "Last Name", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            txtLastName.Clear()
                            txtLastName.Focus()
                            Exit Sub
                    End Select
                Next
            Else
                MessageBox.Show("Last Name Must Be >= 3 Characters", "Last Name", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtLastName.Clear()
                txtLastName.Focus()
                Exit Sub
            End If
        Else
            MessageBox.Show("Input Last Name", "Last Name", MessageBoxButtons.OK, MessageBoxIcon.Question)
            txtLastName.Clear()
            txtLastName.Focus()
            Exit Sub
        End If
        '
        'Last Name Validation Ends


        'Current Salary Validation Begins
        Dim CurrentSalary As Double
        If (txtCurrentSalary.Text.Trim() <> "") Then
            If (IsNumeric(txtCurrentSalary.Text.Trim())) Then
                CurrentSalary = CDbl(txtCurrentSalary.Text.Trim())
                If CurrentSalary > 0 Then
                    'The Salary is Okay
                Else
                    MsgBox("Current Annual Salary Must Be More Than $0", MsgBoxStyle.OkOnly Or MsgBoxStyle.Question, "Current Annual Salary")
                    txtCurrentSalary.Clear()
                    txtCurrentSalary.Focus()
                    Exit Sub
                End If
            Else
                MsgBox("Current Annual Salary Must Be Numeric", MsgBoxStyle.OkOnly Or MsgBoxStyle.Question, "Current Annual Salary")
                txtCurrentSalary.Clear()
                txtCurrentSalary.Focus()
                Exit Sub
            End If
        Else
            MsgBox("Input Current Annual Salary", MsgBoxStyle.OkOnly Or MsgBoxStyle.Question, "Current Annual Salary")
            txtCurrentSalary.Clear()
            txtCurrentSalary.Focus()
            Exit Sub
        End If
        '
        'Current Salary Validation Ends


        'Calling Calculate Function Procedure & Assigning Returned Value to NewSalary
        Dim NewSalary As Double
        NewSalary = Calculate(CurrentSalary)
        '
        'End of Calling Calculate Function Procedure



        'Rounding Current Salary To 2 Decimal Places
        CurrentSalary = Math.Round(CurrentSalary, 2)


        'Calling Output Sub Procedure & Passing Values
        Output(FirstName, LastName, CurrentSalary, NewSalary)
        '
        'Calling Output Sub Procedure Ends

    End Sub

End Class