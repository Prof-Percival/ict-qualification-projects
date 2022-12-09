Public Class Form1


    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Exit the Form1 >>
        If MessageBox.Show("Are You Sure You Want To Exit", "Title", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Me.Close()
        ElseIf MessageBox.Show("Are You Sure You Want To Exit", "Title", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.No Then
            lstOutputData.Focus()
        End If

        'End IfMsgBox("Are You Sure You Want To Exit")


    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim name1, name2 As String
        'Dim P As Integer = 0
        Dim num1, num2, SquareRootPos, SquareRootNeg, IntPos, IntNeg, RoundPos1, RoundPos2, RoundNeg1, RoundNeg2 As Double

        name1 = txtInputData.Text()
        name2 = txtInputData2.Text()

        If txtInputData.Text = "" Or txtInputData2.Text = "" Then
            MsgBox("At Least One Value must be Entered!")
            txtInputData.Focus()
            Exit Sub
        End If

        num1 = CDbl(txtInputData.Text)
        num2 = CDbl(txtInputData2.Text)

        'Positive Math Evaluations
        SquareRootPos = Math.Sqrt(num1)
        RoundPos1 = Math.Round(num1)
        RoundPos2 = Math.Round(num1, 2)
        IntPos = Int(num1)

        'Negative Math Evaluations
        SquareRootNeg = Math.Sqrt(num2)
        RoundNeg1 = Math.Round(num2)
        RoundNeg2 = Math.Round(num2, 2)
        IntNeg = Int(num2)

        txtInputData.Clear()
        txtInputData2.Clear()

        'Positive Outputs
        lstOutputData.Items.Add("=======================================")
        lstOutputData.Items.Add("| Positive Math Functions Evaluations |")
        lstOutputData.Items.Add("=======================================")
        lstOutputData.Items.Add("Square Root: " & SquareRootPos)
        lstOutputData.Items.Add("Rounding-off Positive Number: " & RoundPos1)
        lstOutputData.Items.Add("Rounding-off to 2 Decimal Places: " & RoundPos2)
        lstOutputData.Items.Add("Converting Positive Number to Integer: " & IntPos)

        lstOutputData.Items.Add("")

        'Negative Outputs
        lstOutputData.Items.Add("=======================================")
        lstOutputData.Items.Add("| Negative Math Functions Evaluations |")
        lstOutputData.Items.Add("=======================================")
        lstOutputData.Items.Add("Square Root: " & SquareRootNeg)
        lstOutputData.Items.Add("Rounding-off Negative Number: " & RoundNeg1)
        lstOutputData.Items.Add("Rounding-off to 2 Decimal Places: " & RoundNeg2)
        lstOutputData.Items.Add("Converting Negative Number to Integer: " & IntNeg)

        'txtInputData.Clear()
        'txtInputData.Focus()

        'name = txtInputData.Text()

        'txtInputData.Clear()

        'Do While name <> "0"

        '    P += 1

        '    MsgBox(P & ". " & name)

        '    'lstOutputData.Items.Add(P & ". " & name)

        '    txtInputData.Clear()

        '    txtInputData.Focus()
        '    name = txtInputData.Text()
        'Loop


        Exit Sub
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lstOutputData.Items.Clear()
        Exit Sub
    End Sub
End Class
