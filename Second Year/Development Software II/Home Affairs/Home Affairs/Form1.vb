Public Class Form1

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Button to Close The App
        Me.Close()
    End Sub
    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        'Calling IDValidator Sub Procedure
        IDValidator(txtID.Text)
    End Sub

    Sub IDValidator(ByVal IDNumber As String)
        Dim P As Integer
        'ID Number Validation Begins
        If (IDNumber.Trim() <> "") Then
            IDNumber = IDNumber.Trim()
            If (IsNumeric(IDNumber)) Then
                If (IDNumber.Length() = 13) Then
                    For P = 0 To 12 Step 1
                        Select Case (IDNumber.Substring(P, 1))
                            Case 0 To 9
                            'The ID Number is Without Space Character or Comma
                            Case " "
                                MessageBox.Show("ID Number Must Be Numeric Without A Space Character", "ID Number", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                txtID.Clear()
                                txtID.Focus()
                                Exit Sub
                            Case ","
                                MessageBox.Show("ID Number Must Be Numeric Without A Comma Character", "ID Number", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                txtID.Clear()
                                txtID.Focus()
                                Exit Sub
                        End Select
                    Next
                Else
                    MessageBox.Show("ID Number Must Be 13 Digits Long", "ID Number", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtID.Clear()
                    txtID.Focus()
                    Exit Sub
                End If
            Else
                MessageBox.Show("ID Number Must Be Numeric", "ID Number", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtID.Clear()
                txtID.Focus()
                Exit Sub
            End If
        Else
            MessageBox.Show("Input ID Number", "ID Number", MessageBoxButtons.OK, MessageBoxIcon.Question)
            txtID.Clear()
            txtID.Focus()
            Exit Sub
        End If
        '
        'ID Number Validation Ends


        'Month (MM) Validation Begins
        If (CInt(IDNumber.Substring(2, 1)) = 0) Or (CInt(IDNumber.Substring(2, 1)) = 1) Then
            If (CInt(IDNumber.Substring(2, 1)) = 0) Then
                If (CInt(IDNumber.Substring(3, 1)) >= 1) Then
                    'The M1 is Correct
                Else
                    MessageBox.Show("3rd & 4th Digits of the ID Number Cannot Be 00", "ID Number", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtID.Clear()
                    txtID.Focus()
                    Exit Sub
                End If
            ElseIf (CInt(IDNumber.Substring(2, 1)) = 1) Then
                If (CInt(IDNumber.Substring(3, 1)) >= 0) And (CInt(IDNumber.Substring(3, 1)) <= 2) Then
                    'The M2 Is Correct
                Else
                    MessageBox.Show("4th Digit of the ID Number Must Be 0, 1 Or 2 If The 3rd Digit Is 1", "ID Number", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtID.Clear()
                    txtID.Focus()
                    Exit Sub
                End If
            End If
        Else
            MessageBox.Show("3rd Digit of the ID Number Must Be 0 Or 1", "ID Number", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtID.Clear()
            txtID.Focus()
            Exit Sub
        End If
        '
        'Month (MM) Validation Ends


        'Day (DD) Validation Begins
        If (CInt(IDNumber.Substring(4, 1)) >= 0) And (CInt(IDNumber.Substring(4, 1)) <= 3) Then
            If (CInt(IDNumber.Substring(4, 1)) = 0) Then
                If (CInt(IDNumber.Substring(5, 1)) >= 1) Then
                    'D1 And D2 Are Valid
                Else
                    MessageBox.Show("5th & 6th Digits of the ID Number Cannot Be 00", "ID Number", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtID.Clear()
                    txtID.Focus()
                    Exit Sub
                End If
            ElseIf (CInt(IDNumber.Substring(4, 1)) = 3) Then
                If (CInt(IDNumber.Substring(5, 1)) <= 1) Then
                Else
                    MessageBox.Show("6th Digit of the ID Number Must Be 0 or 1 If The 5th Digit Is 3", "ID Number", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtID.Clear()
                    txtID.Focus()
                    Exit Sub
                End If
            ElseIf (CInt(IDNumber.Substring(4, 1)) >= 4) Then
                MessageBox.Show("5th Digit of the ID Number Must Be 0, 1, 2 or 3", "ID Number", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtID.Clear()
                txtID.Focus()
                Exit Sub
            End If
        Else
            MessageBox.Show("5th Digit of the ID Number Must Be 0, 1, 2 or 3", "ID Number", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtID.Clear()
            txtID.Focus()
            Exit Sub
        End If
        '
        'Day (DD) Validation Ends


        ' Simultaneous Validation for Month (MM) & Day (DD) Begins
        If (IDNumber.Substring(2, 2) = "01") Or (IDNumber.Substring(2, 2) = "03") Or (IDNumber.Substring(2, 2) = "05") Or (IDNumber.Substring(2, 2) = "07") Or (IDNumber.Substring(2, 2) = "08") Or (IDNumber.Substring(2, 2) = "10") Or (IDNumber.Substring(2, 2) = "12") Then
            'DD is 31 or Less
        ElseIf (IDNumber.Substring(2, 2) = "04") Or (IDNumber.Substring(2, 2) = "06") Or (IDNumber.Substring(2, 2) = "09") Or (IDNumber.Substring(2, 2) = "11") Then
            If (CInt(IDNumber.Substring(4, 2) <= 30)) Then
                'DD is 30 or Less
            Else
                MessageBox.Show("IF MM = 04, 06, 09 or 11 Then DD Must Be <= 30", "ID Number", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtID.Clear()
                txtID.Focus()
                Exit Sub
            End If
        ElseIf (IDNumber.Substring(2, 2) = "02") Then
            If (CInt(IDNumber.Substring(4, 2) <= 29)) Then
                'DD is 28, 29 or Less
            Else
                MessageBox.Show("IF MM = 02 Then DD Must Be <= 29", "ID Number", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtID.Clear()
                txtID.Focus()
                Exit Sub
            End If
        End If
        '
        ' Simultaneous Validation for Month (MM) & Day (DD) Ends


        'Year (YY) Validation to Determine Year of Birth Begins
        Dim YY As String = ""
        If (CInt(IDNumber.Substring(0, 2)) <= 20) Then
            YY = "20" & (IDNumber.Substring(0, 2))
        ElseIf (CInt(IDNumber.Substring(0, 2)) >= 21) And (CInt(IDNumber.Substring(0, 2)) <= 99) Then
            YY = "19" & (IDNumber.Substring(0, 2))
        End If
        '
        'Year (YY) Validation to Determine Year of Birth Ends


        'C - Residential Status (11th Digit) & A - (12th Digit) Validation Begins
        Dim ResidentialStatus As String = ""
        If (CInt(IDNumber.Substring(10, 1)) = 0) Or (CInt(IDNumber.Substring(10, 1)) = 1) Then
            If (CInt(IDNumber.Substring(10, 1)) = 0) Then
                If (CInt(IDNumber.Substring(11, 1)) = 8) Then
                    ResidentialStatus = "South African Citizen"
                Else
                    MessageBox.Show("12th Digit Must Be 8 If 11th Digit is 0", "ID Number", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtID.Clear()
                    txtID.Focus()
                    Exit Sub
                End If
            End If
            If (CInt(IDNumber.Substring(10, 1)) = 1) Then
                If (CInt(IDNumber.Substring(11, 1)) = 9) Then
                    ResidentialStatus = "Permanent Resident"
                Else
                    MessageBox.Show("12th Digit Must Be 9 If 11th Digit is 1", "ID Number", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtID.Clear()
                    txtID.Focus()
                    Exit Sub
                End If
            End If
        Else
            MessageBox.Show("11th Digit Must Be 0 Or 1", "ID Number", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtID.Clear()
            txtID.Focus()
            Exit Sub
        End If
        '
        'C - Residential Status (11th Digit) & A - (12th Digit)  Validation Ends


        'SSSS Validation To Determine Gender Begins
        Dim Gender As String = ""
        If (CInt(IDNumber.Substring(6, 4)) <= 4999) Then
            Gender = "Female"
        ElseIf (CInt(IDNumber.Substring(6, 4)) >= 5000) And (CInt(IDNumber.Substring(6, 4)) <= 9999) Then
            Gender = "Male"
        End If
        '
        'SSSS Validation to Determine Gender Ends



        'Assigning Values To Variables Begins
        Dim DD, MM, DoB As String
        DD = (IDNumber.Substring(4, 2))
        MM = (IDNumber.Substring(2, 2))
        DoB = DD & "/" & MM & "/" & YY
        '
        'Assigning Values To Variables Ends


        'Assigning Values to TextBoxes Begins
        txtID.Text = IDNumber
        txtDoB.Text = DoB
        txtGender.Text = Gender
        txtResidentStatus.Text = ResidentialStatus
        '
        'Assigning Values To TextBoxes Ends
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'button to Clear Text Boxes
        txtID.Clear()
        txtDoB.Clear()
        txtGender.Clear()
        txtResidentStatus.Clear()
        txtID.Focus()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class