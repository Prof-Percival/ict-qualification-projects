Public Class frmACs
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboTitle.Cursor = Cursors.Hand
        Me.MaximizeBox = False
        Me.ShowIcon = False
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.BackColor = Color.Magenta
        Dim Titles(5) As String '= {"Mr", "Mrs", "Ms", "Dr", "Prof"}
        'cboTitle.Items.Add("")
        'cboTitle.Items.Add("Check")
        'cboTitle.Items.Add("Done")
        Titles(0) = ""
        Titles(1) = "Mr"
        Titles(2) = "Mrs"
        Titles(3) = "Ms"
        Titles(4) = "Dr"
        Titles(5) = "Prof"
        cboTitle.DataSource = Titles
        'cboTitle.Sorted = True
        ' cboTitle.BackColor = Color.LightBlue
        txtFullName.TabStop = False
        txtFullName.ReadOnly = True
        txtFullName.BackColor = Color.White
        txtFullName.TextAlign = HorizontalAlignment.Center
        tmrWatch.Interval = 100
        txtSeconds.TextAlign = HorizontalAlignment.Center
        txtSeconds.Font = New Font("Century", 13.8, FontStyle.Bold)
        ttpTooltip.SetToolTip(btnExit, "Close The App")
        ttpTooltip.BackColor = Color.MintCream
        ttpTooltip.ForeColor = Color.DarkRed
        'btnExit.Location = New Point(279, 226)
        'lblName.Location = New Point(45, 28)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Select Case MessageBox.Show("Are You Sure You Want To Exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            Case DialogResult.Yes
                Me.Close()
            Case DialogResult.No
                Exit Sub
        End Select
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        Dim Title As String
        If cboTitle.SelectedIndex <> -1 And cboTitle.SelectedItem <> "" Then
            Title = cboTitle.Text & ". "
        Else
            MessageBox.Show("Select a Title", "Title", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cboTitle.Focus()
            Exit Sub
        End If

        Dim P As Integer
        Dim Name, indexN, indexS As String
        If txtName.Text.Trim() <> "" Then
            Name = txtName.Text.Trim().ToLower()
            If (Name.IndexOf(" ") <> -1) Then
                For P = 0 To Name.Trim().Length - 1
                    Select Case (Name.Trim().Substring(P, 1))
                        Case "a" To "z", " "
                        Case Else
                            MessageBox.Show("Name Must Be Alphabetic", "Name", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            txtName.Clear()
                            txtName.Focus()
                            Exit Sub
                    End Select
                Next
                P = Name.IndexOf(" ") + 1
                indexN = Name.Substring(0, 1).ToUpper
                indexS = Name.Substring(P, 1).ToUpper()
                P -= 1
                Name = Title & indexN & Name.Substring(1, P) & indexS & Name.Substring(P + 2)
            Else
                MessageBox.Show("Name Must Contain Surname", "Name", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtName.Clear()
                txtName.Focus()
                Exit Sub
            End If
        Else
            MessageBox.Show("Input Name", "Name", MessageBoxButtons.OK, MessageBoxIcon.Question)
            txtName.Clear()
            txtName.Focus()
            Exit Sub
        End If
        txtFullName.Text = Name
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        Select Case MessageBox.Show("Are You Sure You Want To Clear?", "Clear", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            Case DialogResult.Yes
                txtName.Clear()
                txtFullName.Clear()
                cboTitle.SelectedItem = ""
                cboTitle.Focus()
            Case DialogResult.No
                Exit Sub
        End Select
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        txtSeconds.Text = "0"
        'tmrWatch.Enabled = True
        tmrWatch.Start()
    End Sub

    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        'tmrWatch.Enabled = False
        tmrWatch.Stop()
    End Sub

    Private Sub tmrWatch_Tick(sender As Object, e As EventArgs) Handles tmrWatch.Tick
        txtSeconds.Text = (CDbl(txtSeconds.Text) + 0.1).ToString("N1")
    End Sub

    Private Sub btnShowFullName_Click(sender As Object, e As EventArgs) Handles btnShowFullName.Click
        Dim Name, Surname, FullName As String
        If ttbName.Text.Trim() <> "" Then
            Name = ttbName.Text.Trim().ToUpper()
            Dim i As Integer
            For i = 0 To Name.Length() - 1
                Select Case Name.Substring(i, 1)
                    Case "A" To "Z"
                    Case Else
                        MsgBox("Name Must Be Alphabetic", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "Name")
                        ttbName.Clear()
                        ttbName.Focus()
                        Exit Sub
                End Select
            Next
            'Name = ttbName.Text.Trim()
        Else
            MsgBox("Input Name", MsgBoxStyle.OkOnly Or MsgBoxStyle.Question, "Name")
            ttbName.Clear()
            ttbName.Focus()
            Exit Sub
        End If
        If ttbSurname.Text.Trim() <> "" Then
            Surname = ttbSurname.Text.Trim().ToUpper()
            Dim i As Integer
            For i = 0 To Surname.Length() - 1
                Select Case Surname.Substring(i, 1)
                    Case "A" To "Z"
                    Case Else
                        MsgBox("Surname Must Be Alphabetic", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "Surname")
                        ttbSurname.Clear()
                        ttbSurname.Focus()
                        Exit Sub
                End Select
            Next
            ' Surname = ttbSurname.Text.Trim()
        Else
            MsgBox("Input Surname", MsgBoxStyle.OkOnly Or MsgBoxStyle.Question, "Surname")
            ttbSurname.Clear()
            ttbSurname.Focus()
            Exit Sub
        End If

        Dim N, S As String
        Name = Name.ToLower()
        Surname = Surname.ToLower()
        N = Name.Substring(0, 1).ToUpper()
        S = Surname.Substring(0, 1).ToUpper()
        Name = N & Name.Substring(1)
        Surname = S & Surname.Substring(1)
        FullName = Name & " " & Surname

        ttbFullName.Text = FullName

        MessageBox.Show("You've Been hacked...", "Trojan Horse", MessageBoxButtons.OK, MessageBoxIcon.Warning)

    End Sub

    Private Sub vsbAC_Scroll(sender As Object, e As ScrollEventArgs) Handles vsbAC.Scroll
        'Me.Top = vsbAC.Value
    End Sub
End Class