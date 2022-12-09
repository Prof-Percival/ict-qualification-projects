Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lstOutput.Cursor = Cursors.Hand
        MenuStrip1.Cursor = Cursors.Arrow
        Me.Cursor = Cursors.No
        lstOutput.Items.Add("Christoph Percival")
        lstOutput.Items.Add("Development Software")
        lstOutput.Items.Add("Buffalo City Campus")
        lstOutput.Items.Add("Potsdam")
        lstOutput.Items.Add("East London")
    End Sub

    Private Sub mnuOrder_Desc_Click(Sender As Object, e As EventArgs) Handles mnuOrder_Desc.Click
        Dim temp(4) As String
        lstOutput.Sorted = True
        For P As Integer = 0 To 4
            temp(P) = lstOutput.Items(P)
        Next
        lstOutput.Sorted = False
        lstOutput.Items.Clear()
        For P As Integer = 4 To 0 Step -1
            lstOutput.Items.Add(temp(P))
        Next
        mnuOrder_Asc.Checked = False
        mnuOrder_Desc.Checked = True
    End Sub

    Private Sub mnuOrder_Asc_Click(sender As Object, e As EventArgs) Handles mnuOrder_Asc.Click
        lstOutput.Sorted = True
        mnuOrder_Asc.Checked = True
        mnuOrder_Desc.Checked = False
    End Sub

    Private Sub mnuExit_Click(Sender As Object, e As EventArgs) Handles mnuExit.Click
        Select Case MessageBox.Show("Are You Sure You Want To Exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            Case DialogResult.Yes
                Me.Close()
            Case DialogResult.No
                Exit Sub
        End Select
    End Sub


    'Setting Back Color Begins
    '
    Private Sub mnuColor_Back_Blue_Click(sender As Object, e As EventArgs) Handles mnuColor_Back_Blue.Click
        lstOutput.BackColor = Color.Blue
        mnuColor_Back_Blue.Checked = True
        mnuColor_Back_Red.Checked = False
        mnuColor_Back_Green.Checked = False
        mnuColor_Back_White.Checked = False
        mnuColor_Back_Orange.Checked = False
        mnuColor_Back_Black.Checked = False
    End Sub

    Private Sub mnuColor_Back_Red_Click(sender As Object, e As EventArgs) Handles mnuColor_Back_Red.Click
        lstOutput.BackColor = Color.Red
        mnuColor_Back_Blue.Checked = False
        mnuColor_Back_Red.Checked = True
        mnuColor_Back_Green.Checked = False
        mnuColor_Back_White.Checked = False
        mnuColor_Back_Orange.Checked = False
        mnuColor_Back_Black.Checked = False
    End Sub

    Private Sub mnuColor_Back_Green_Click(sender As Object, e As EventArgs) Handles mnuColor_Back_Green.Click
        lstOutput.BackColor = Color.Green
        mnuColor_Back_Blue.Checked = False
        mnuColor_Back_Red.Checked = False
        mnuColor_Back_Green.Checked = True
        mnuColor_Back_White.Checked = False
        mnuColor_Back_Orange.Checked = False
        mnuColor_Back_Black.Checked = False
    End Sub

    Private Sub mnuColor_Back_White_Click(sender As Object, e As EventArgs) Handles mnuColor_Back_White.Click
        lstOutput.BackColor = Color.White
        mnuColor_Back_Blue.Checked = False
        mnuColor_Back_Red.Checked = False
        mnuColor_Back_Green.Checked = False
        mnuColor_Back_White.Checked = True
        mnuColor_Back_Orange.Checked = False
        mnuColor_Back_Black.Checked = False
    End Sub

    Private Sub mnuColor_Back_Orange_Click(sender As Object, e As EventArgs) Handles mnuColor_Back_Orange.Click
        lstOutput.BackColor = Color.Orange
        mnuColor_Back_Blue.Checked = False
        mnuColor_Back_Red.Checked = False
        mnuColor_Back_Green.Checked = False
        mnuColor_Back_White.Checked = False
        mnuColor_Back_Orange.Checked = True
        mnuColor_Back_Black.Checked = False
    End Sub

    Private Sub mnuColor_Back_Black_Click(sender As Object, e As EventArgs) Handles mnuColor_Back_Black.Click
        lstOutput.BackColor = Color.Black
        mnuColor_Back_Blue.Checked = False
        mnuColor_Back_Red.Checked = False
        mnuColor_Back_Green.Checked = False
        mnuColor_Back_White.Checked = False
        mnuColor_Back_Orange.Checked = False
        mnuColor_Back_Black.Checked = True
    End Sub
    '
    'Setting Back Color Ends


    'Setting Fore Color Begins
    '
    Private Sub mnuColor_Fore_Blue_Click(sender As Object, e As EventArgs) Handles mnuColor_Fore_Blue.Click
        lstOutput.ForeColor = Color.Blue
        mnuColor_Fore_Blue.Checked = True
        mnuColor_Fore_Red.Checked = False
        mnuColor_Fore_Green.Checked = False
        mnuColor_Fore_White.Checked = False
        mnuColor_Fore_Orange.Checked = False
        mnuColor_Fore_Black.Checked = False
    End Sub

    Private Sub mnuColor_Fore_Red_Click(sender As Object, e As EventArgs) Handles mnuColor_Fore_Red.Click
        lstOutput.ForeColor = Color.Red
        mnuColor_Fore_Blue.Checked = False
        mnuColor_Fore_Red.Checked = True
        mnuColor_Fore_Green.Checked = False
        mnuColor_Fore_White.Checked = False
        mnuColor_Fore_Orange.Checked = False
        mnuColor_Fore_Black.Checked = False
    End Sub

    Private Sub mnuColor_Fore_Green_Click(sender As Object, e As EventArgs) Handles mnuColor_Fore_Green.Click
        lstOutput.ForeColor = Color.Green
        mnuColor_Fore_Blue.Checked = False
        mnuColor_Fore_Red.Checked = False
        mnuColor_Fore_Green.Checked = True
        mnuColor_Fore_White.Checked = False
        mnuColor_Fore_Orange.Checked = False
        mnuColor_Fore_Black.Checked = False
    End Sub

    Private Sub mnuColor_Fore_White_Click(sender As Object, e As EventArgs) Handles mnuColor_Fore_White.Click
        lstOutput.ForeColor = Color.White
        mnuColor_Fore_Blue.Checked = False
        mnuColor_Fore_Red.Checked = False
        mnuColor_Fore_Green.Checked = False
        mnuColor_Fore_White.Checked = True
        mnuColor_Fore_Orange.Checked = False
        mnuColor_Fore_Black.Checked = False
    End Sub

    Private Sub mnuColor_Fore_Orange_Click(sender As Object, e As EventArgs) Handles mnuColor_Fore_Orange.Click
        lstOutput.ForeColor = Color.Orange
        mnuColor_Fore_Blue.Checked = False
        mnuColor_Fore_Red.Checked = False
        mnuColor_Fore_Green.Checked = False
        mnuColor_Fore_White.Checked = False
        mnuColor_Fore_Orange.Checked = True
        mnuColor_Fore_Black.Checked = False
    End Sub

    Private Sub mnuColor_Fore_Black_Click(sender As Object, e As EventArgs) Handles mnuColor_Fore_Black.Click
        lstOutput.ForeColor = Color.Black
        mnuColor_Fore_Blue.Checked = True
        mnuColor_Fore_Red.Checked = False
        mnuColor_Fore_Green.Checked = False
        mnuColor_Fore_White.Checked = False
        mnuColor_Fore_Orange.Checked = False
        mnuColor_Fore_Black.Checked = True
    End Sub
    '
    'Setting Fore Color Ends //Cursor
End Class
