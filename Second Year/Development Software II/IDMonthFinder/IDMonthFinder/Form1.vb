Public Class Form1
    Private Sub btnDetermine_Click(sender As Object, e As EventArgs) Handles btnDetermine.Click
        IDVerify(txtIDNumber.Text.Trim())
    End Sub

    Sub Determine(ByVal IDNumber As String)
        'Assigning Value / Month To TextBox
        Select Case CInt(IDNumber.Substring(2, 2))
            Case 1 : txtMonth.Text = "January"
            Case 2 : txtMonth.Text = "February"
            Case 3 : txtMonth.Text = "March"
            Case 4 : txtMonth.Text = "April"
            Case 5 : txtMonth.Text = "May"
            Case 6 : txtMonth.Text = "June"
            Case 7 : txtMonth.Text = "July"
            Case 8 : txtMonth.Text = "August"
            Case 9 : txtMonth.Text = "September"
            Case 10 : txtMonth.Text = "October"
            Case 11 : txtMonth.Text = "November"
            Case 12 : txtMonth.Text = "December"
        End Select
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtIDNumber.Clear()
        txtMonth.Clear()
        txtIDNumber.Focus()
    End Sub

    Sub IDVerify(ByVal IDNumber As String)
        'ID Validation Begins
        Dim P As Integer
        If (IDNumber <> "") Then
            If (IsNumeric(IDNumber)) Then
                If (IDNumber.Length() = 13) Then
                    For P = 0 To 12
                        Select Case (IDNumber.Substring(P, 1))
                            Case 0 To 9  'Do Nothing
                            Case " "
                                MsgBox("ID Number Must Not Contain Space Character", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "ID Number")
                                txtIDNumber.Clear()
                                txtIDNumber.Focus()
                                Exit Sub
                        End Select
                    Next
                    If (CInt(IDNumber.Substring(2, 1)) = 0) Or (CInt(IDNumber.Substring(2, 1)) = 1) Then
						If (CInt(IDNumber.Substring(2, 1)) = 0) Then
							If (CInt(IDNumber.Substring(3, 1)) >= 1) Then
								'The M1 is Correct
							Else
								MessageBox.Show("Third & Fourth Digits of the ID Number Cannot Be 00", "ID Number", MessageBoxButtons.OK, MessageBoxIcon.Error)
								txtIDNumber.Clear()
								txtIDNumber.Focus()
								Exit Sub
							End If
						ElseIf (CInt(IDNumber.Substring(2, 1)) = 1) Then
							If (CInt(IDNumber.Substring(3, 1)) >= 0) And (CInt(IDNumber.Substring(3, 1)) <= 2) Then
								'The M2 Is Correct
							Else
								MessageBox.Show("Fourth Digit of the ID Number Must Be 0, 1 Or 2 If The Third Digit Is 1", "ID Number", MessageBoxButtons.OK, MessageBoxIcon.Error)
								txtIDNumber.Clear()
								txtIDNumber.Focus()
								Exit Sub
							End If
						End If
					Else
						MessageBox.Show("Third Digit of the ID Number Must Be 0 Or 1", "ID Number", MessageBoxButtons.OK, MessageBoxIcon.Error)
						txtIDNumber.Clear()
						txtIDNumber.Focus()
						Exit Sub
					End If
                Else
                    MsgBox("ID Number Must Be 13 Digits", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "ID Number")
                    txtIDNumber.Clear()
                    txtIDNumber.Focus()
                    Exit Sub
                End If
            Else
                MsgBox("ID Number Must Be Numeric", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "ID Number")
                txtIDNumber.Clear()
                txtIDNumber.Focus()
                Exit Sub
            End If
        Else
            MsgBox("Input ID Number", MsgBoxStyle.OkOnly Or MsgBoxStyle.Question, "ID Number")
            txtIDNumber.Clear()
            txtIDNumber.Focus()
            Exit Sub
        End If
        '
        'ID Validation Ends


        'Calling the Determine Sub Procedure And Passing Verified or Validated ID Number
        Determine(IDNumber)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class