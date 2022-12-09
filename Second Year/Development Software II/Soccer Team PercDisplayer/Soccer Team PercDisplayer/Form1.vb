Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnPercentage_Click(sender As Object, e As EventArgs) Handles btnPercentage.Click
        Dim i, won, lost, played As Integer
        Dim TeamName As String = ""
        Dim answer As Double
        If txtTeamName.Text <> "" Then
            TeamName = (txtTeamName.Text).ToUpper.Trim
            For i = 0 To TeamName.Length - 1
                Select Case TeamName.Substring(i, 1)
                    Case "A" To "Z", " "
                    Case Else
                        MsgBox("Invalid Characters in Team Name!")
                        txtTeamName.Text = ""
                        txtTeamName.Focus()
                        Exit Sub
                End Select
            Next
        Else
            MsgBox("Team Name Not Input!")
        End If
        If (IsNumeric(txtWon.Text) = False) Then
            MsgBox("Alphabetic Values Are Not Allowed!")
            txtWon.Clear()
            txtWon.Focus()
            Exit Sub
        End If
        If (txtWon.Text.Trim < 0 Or txtWon.Text.Trim > 20) Then
            MsgBox("Games Won Must Be Between 0 & 20!")
            txtWon.Clear()
            txtWon.Focus()
            Exit Sub
        End If
        If (txtLost.Text.Trim < 0 Or txtLost.Text.Trim > 20) Then
            MsgBox("Games Lost Must Be Between 0 & 20!")
            txtLost.Clear()
            txtLost.Focus()
            Exit Sub
        End If
        won = CInt(txtWon.Text)
        lost = CInt(txtLost.Text)
        played = won + lost
        If played > 20 Then
            MsgBox("Games Played Should Be 20 or Less!")
            Exit Sub
        End If
        answer = CDbl((won / played) * 100)
        txtOutput.Text = CStr(answer)
        txtTeamName.Text = TeamName
        txtPlayed.Text = CStr(played)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
