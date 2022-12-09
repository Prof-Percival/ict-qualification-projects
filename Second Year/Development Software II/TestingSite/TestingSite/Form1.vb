Public Class Form1

    Private Sub btnTest_Click(sender As Object, e As EventArgs) Handles btnTest.Click
        MessageBox.Show("Good Morning, ohh woooh owh woooh", "Lyrics", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)

        MsgBox("Good Morning, ohh woooh owh woooh " & 20, MsgBoxStyle.Exclamation Or MsgBoxStyle.YesNo, "Lyrics")

        'Dim Age As Integer = 30
        'Age = Int(InputBox("Input Your Age", "Age"))
        'Select Case Age
        '    Case 12 To 16
        '        MsgBox("PG Is Needed!", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "Message")
        '    Case Is > 16
        '        MsgBox("No PG is Needed", MsgBoxStyle.OkOnly Or MsgBoxStyle.Information, "Message")
        '    Case Is < 12
        '        MsgBox("You're Too oung To Watch this Movie!", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "Message")
        'End Select

        If radYear1.Checked Then
            MsgBox("You're Too oung To Watch this Movie!", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "Message")
        ElseIf radYear2.Checked Then
            MsgBox("PG Is Needed!", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "Message")
        ElseIf radYear3.Checked Then
            MsgBox("No PG is Needed", MsgBoxStyle.OkOnly Or MsgBoxStyle.Information, "Message")
        Else
            'MsgBox("You Must Make A Selection", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "Message")
            MessageBox.Show("You Must Make A Selection", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If


        'Finding Month First 3 Characters
        'Dim dt As Date = #12/4/2013#
        'Dim str As String = dt.ToString("D")
        'Dim n As Integer = str.IndexOf(" ")
        'n = str.IndexOf(" ", n + 1)
        'lstNames.Items.Add(str)
        'lstNames.Items.Add(vbCrLf)
        'lstNames.Items.Add(n & "\n")
        'lstNames.Items.Add(System.Environment.NewLine)
        'lstNames.Items.Add(CStr(str.Substring(n + 1, 3)))

        Dim tree As String = "redwood", ht As Double = 362
        Trees(ht, tree)
    End Sub

    Sub Trees(ByVal height As Double, ByVal treeName As String)
        lstNames.Items.Add("The tallest " & treeName & " tree in the U.S. is " & height & " feet.")
        height = 223
        treeName = "pine"
        lstNames.Items.Add(System.Environment.NewLine)
        lstNames.Items.Add(vbCrLf)
        lstNames.Items.Add("The tallest " & treeName & " in the U.S. is " & height & " feet.")
    End Sub

End Class
