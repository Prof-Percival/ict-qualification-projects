Public Class Form1
    Dim OutputVisible As String
    Dim OutputInvisble As String = ""
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        chkMessageVisible.Checked = True
        radBlack.Checked = True
        txtOutput.BackColor = Color.White
    End Sub
    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        ' Validating Name
        Dim Name As String
        If txtName.Text.Trim() <> "" Then
            Dim index As Integer
            Name = txtName.Text.Trim().ToLower()
            For index = 0 To (Name.Trim().Length() - 1)
                Select Case (Name.Substring(index, 1))
                    Case "a" To "z", " "
                        'Name Valid
                    Case Else
                        MessageBox.Show("Name Must Be Alphabetic", "Name", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        txtName.Clear()
                        txtName.Focus()
                        Exit Sub
                End Select
            Next
            Dim indexN, indexS As String
            indexN = Name.Substring(0, 1)
            Dim P As Integer = Name.IndexOf(" ") + 1
            If Name.IndexOf(" ") <> -1 Then
                indexS = Name.Substring(P, 1)
                indexN = indexN.ToUpper()
                indexS = indexS.ToUpper()
                Name = indexN + Name.Substring(1, P - 1) + indexS + Name.Substring(P + 1)
            Else
                indexN = indexN.ToUpper()
                Name = indexN + Name.Substring(1)
            End If
        Else
            MessageBox.Show("Input Name", "Name", MessageBoxButtons.OK, MessageBoxIcon.Question)
            txtName.Clear()
            txtName.Focus()
            Exit Sub
        End If


        'Validating Major
        Dim Major As String
        If txtMajor.Text.Trim() <> "" Then
            Dim index As Integer
            Major = txtMajor.Text.Trim().ToUpper()
            For index = 0 To (Major.Trim().Length() - 1)
                Select Case (Major.Substring(index, 1))
                    Case " ", "A" To "Z"
                        'Major Valid
                    Case Else
                        MessageBox.Show("Major Must Be Alphabetic", "Major", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        txtMajor.Clear()
                        txtMajor.Focus()
                        Exit Sub
                End Select
            Next
        Else
            MessageBox.Show("Input Major", "Major", MessageBoxButtons.OK, MessageBoxIcon.Question)
            txtMajor.Clear()
            txtMajor.Focus()
            Exit Sub
        End If


        ''Validating Phone Number
        'If mskPhone.Text <> "" Then
        '    If mskPhone.Text.Length() = 10 Then
        '        'Phone Number Valid
        '    Else
        '        MessageBox.Show("Phone Number Must Be 10 Digits", "Phone", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '        mskPhone.Clear()
        '        mskPhone.Focus()
        '        Exit Sub
        '    End If
        'Else
        '    MessageBox.Show("Input Phone Number", "Phone", MessageBoxButtons.OK, MessageBoxIcon.Question)
        '    mskPhone.Clear()
        '    mskPhone.Focus()
        '    Exit Sub
        'End If

        chkMessageVisible.Checked = True

        'Formatting String / Text For Output
        Dim Phone As String = mskPhone.Text
        OutputVisible = Name + System.Environment.NewLine + vbCrLf + Major + vbCrLf + vbCrLf + Phone

        'Assigning Formatted Output String To Text Box (OutputVisible)
        txtOutput.Text = OutputVisible

        txtName.ReadOnly = True
        txtMajor.ReadOnly = True
        mskPhone.ReadOnly = True
        txtName.BackColor = Color.White
        txtMajor.BackColor = Color.White
        mskPhone.BackColor = Color.White

    End Sub

    Private Sub chkMessageVisible_CheckedChanged(sender As Object, e As EventArgs) Handles chkMessageVisible.CheckedChanged
        If chkMessageVisible.Checked Then
            'Assigning Formatted Output String To Text Box (OutputVisible)
            txtOutput.Text = OutputVisible
        Else
            txtOutput.Text = OutputInvisble
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Select Case MessageBox.Show("Are You Sure You Want To Exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            Case DialogResult.Yes
                Me.Close()
            Case DialogResult.No
                Exit Sub
        End Select
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtName.Clear()
        txtMajor.Clear()
        mskPhone.Clear()
        txtOutput.Clear()
        txtName.Focus()
        txtName.ReadOnly = False
        txtMajor.ReadOnly = False
        mskPhone.ReadOnly = False
        OutputVisible = ""
        chkMessageVisible.Checked = True
        radBlack.Checked = True
    End Sub

    Private Sub radBlack_CheckedChangedk(sender As Object, e As EventArgs) Handles radBlack.CheckedChanged
        txtName.ForeColor = Color.Black
        txtMajor.ForeColor = Color.Black
        mskPhone.ForeColor = Color.Black
        txtOutput.ForeColor = Color.Black
    End Sub

    Private Sub radRed_CheckedChanged(sender As Object, e As EventArgs) Handles radRed.CheckedChanged
        txtName.ForeColor = Color.Red
        txtMajor.ForeColor = Color.Red
        mskPhone.ForeColor = Color.Red
        txtOutput.ForeColor = Color.Red
    End Sub

    Private Sub radBlue_CheckedChanged(sender As Object, e As EventArgs) Handles radBlue.CheckedChanged
        txtName.ForeColor = Color.Blue
        txtMajor.ForeColor = Color.Blue
        mskPhone.ForeColor = Color.Blue
        txtOutput.ForeColor = Color.Blue
    End Sub

    Private Sub radGreen_CheckedChanged(sender As Object, e As EventArgs) Handles radGreen.CheckedChanged
        txtName.ForeColor = Color.Green
        txtMajor.ForeColor = Color.Green
        mskPhone.ForeColor = Color.Green
        txtOutput.ForeColor = Color.Green
    End Sub

    Private Sub radMagenta_CheckedChanged(sender As Object, e As EventArgs) Handles radMagenta.CheckedChanged
        txtName.ForeColor = Color.Magenta
        txtMajor.ForeColor = Color.Magenta
        mskPhone.ForeColor = Color.Magenta
        txtOutput.ForeColor = Color.Magenta
    End Sub


End Class