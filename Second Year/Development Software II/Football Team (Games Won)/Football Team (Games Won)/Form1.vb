Public Class Form1
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        'Validation for Team Name
        Dim P As Integer
        Dim TeamName As String
        If (txtTeamName.Text.Trim) <> "" Then
            TeamName = txtTeamName.Text.Trim.ToUpper
            For P = 0 To (txtTeamName.Text.Trim.Length - 1)
                Select Case TeamName.Substring(P, 1)
                    Case "A" To "Z", " "
                        'Do Nothing
                    Case Else
                        MsgBox("Invalid Team Name!")
                        txtTeamName.Clear()
                        txtTeamName.Focus()
                        txtPercentage.Text = CStr(0) & "%"
                        Exit Sub
                End Select
            Next
        Else
            MsgBox("Team Name Cannot Be Blank!")
            txtTeamName.Clear()
            txtTeamName.Focus()
            txtPercentage.Text = CStr(0) & "%"
            Exit Sub
        End If

        'Validation for Games Won
        Dim Won As Decimal
        If (IsNumeric(txtWon.Text.Trim)) Then
            Won = CDbl(txtWon.Text)
            If Won >= 0 And Won <= 20 Then
                Won = CDbl(txtWon.Text)
            Else
                MsgBox("Games Won Must be Between 0 & 20")
                txtWon.Clear()
                txtWon.Focus()
                txtPercentage.Text = CStr(0) & "%"
                Exit Sub
            End If
        Else
            MsgBox("Games Won Must Be Numerics")
            txtWon.Clear()
            txtWon.Focus()
            txtPercentage.Text = CStr(0) & "%"
            Exit Sub
        End If

        'Validation for Games Lost
        Dim Lost As Decimal
        If (IsNumeric(txtLost.Text.Trim)) Then
            Lost = CDbl(txtLost.Text)
            If Lost >= 0 And Lost <= 20 Then
                Won = CDbl(txtWon.Text)
            Else
                MsgBox("Games Lost Must be Between 0 & 20")
                txtLost.Clear()
                txtLost.Focus()
                txtPercentage.Text = CStr(0) & "%"
                Exit Sub
            End If
        Else
            MsgBox("Games Lost Must Be Numerics")
            txtLost.Clear()
            txtLost.Focus()
            txtPercentage.Text = CStr(0) & "%"
            Exit Sub
        End If

        'Validation for Games Played
        Dim Played As Decimal
        Played = Won + Lost
        If Played > 20 Then
            MsgBox("Games Played Cannot Be Greater Than 20")
            txtWon.Clear()
            txtLost.Clear()
            txtWon.Focus()
            txtPercentage.Text = CStr(0) & "%"
            Exit Sub
        End If

        If Played = 0 Then
            MsgBox("Games Played Cannot Be Equal To 0")
            txtWon.Clear()
            txtLost.Clear()
            txtWon.Focus()
            txtPercentage.Text = CStr(0) & "%"
            Exit Sub
        End If

        'Finding Percentage of Games Won
        Dim WonPercentage As Double
        WonPercentage = (Won / Played) * 100

        'Displaying Messages On Text Boxes
        txtPercentage.Text = CStr(WonPercentage) & "%"
        txtTeamName.Text = TeamName

        'Use the below instruction only if the user will use the progrm once and closed it, else avoid it.
        'txtTeamName.ReadOnly = vbYes

        'Use this statement to change the Back Colour of a Contol. ForeColor changes the Text colour
        'btnExit.BackColor = Color.Red
    End Sub
End Class
