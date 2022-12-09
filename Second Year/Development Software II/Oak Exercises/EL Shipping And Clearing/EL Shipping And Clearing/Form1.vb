Public Class Form1

    Private ContainerSize As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MaximizeBox = False
        Me.CenterToScreen()
        Me.FormBorderStyle = FormBorderStyle.FixedDialog
        grpContainerSize.Cursor = Cursors.Hand
        radSmall.Checked = True
        txtGoodsValue.Focus()
        picContainers.Image = My.Resources.Small
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        lstOutput.Items.Clear()

        If txtGoodsValue.Text.Trim() = "" Then
            MessageBox.Show("Input Value of Goods", "Goods Value", MessageBoxButtons.OK, MessageBoxIcon.Question)
            txtGoodsValue.Clear()
            txtGoodsValue.Focus()
            Exit Sub
        End If

        If Not IsNumeric(txtGoodsValue.Text.Trim()) Then
            MessageBox.Show("Value of Goods Must Be Numeric", "Goods Value", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtGoodsValue.Clear()
            txtGoodsValue.Focus()
            Exit Sub
        End If

        If CDbl(txtGoodsValue.Text.Trim()) <= 0 Then
            MessageBox.Show("Value of Goods Must Be Greater Than R0", "Goods Value", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtGoodsValue.Clear()
            txtGoodsValue.Focus()
            Exit Sub
        End If

        Dim GoodsValue As Double = CDbl(txtGoodsValue.Text.Trim())

        Dim FreightCharge As Int16
        If radSmall.Checked Then
            ContainerSize = "Container Size: SMALL"
            FreightCharge = 10000
        End If
        If radMedium.Checked Then
            ContainerSize = "Container Size: MEDIUM"
            FreightCharge = 12000
        End If
        If radLarge.Checked Then
            ContainerSize = "Container Size: LARGE"
            FreightCharge = 15000
        End If

        Dim Insurance As Double = GoodsValue * (1.75 / 100)

        Dim Container_Op_Charges As Double = GoodsValue * (1 / 100)

        If Container_Op_Charges < 1000 Then
            Container_Op_Charges = 1000
        End If

        Dim DocumentationFee As Int16 = 500

        Dim InitialTotal As Double = FreightCharge + Insurance + Container_Op_Charges + DocumentationFee

        Dim Vat As Double = InitialTotal * (14 / 100)

        Dim TotalPayable As Double = InitialTotal + Vat

        lstOutput.Items.Add("               " & ContainerSize)
        lstOutput.Items.Add("-----------------------------------------------------")
        lstOutput.Items.Add("Freight Charge: R" & FreightCharge.ToString("N2"))
        lstOutput.Items.Add("Insurance Charge: R" & Insurance.ToString("N2"))
        lstOutput.Items.Add("Container Operator Charge: R" & Container_Op_Charges.ToString("N2"))
        lstOutput.Items.Add("Documentation Fee: R" & DocumentationFee.ToString("N2"))
        lstOutput.Items.Add("VAT (14%): R" & Vat.ToString("N2"))
        lstOutput.Items.Add(vbCrLf)
        lstOutput.Items.Add("Total Payable: R" & TotalPayable.ToString("N2"))
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Select Case MessageBox.Show("Are You Sure You Want To Clear?", "Clear", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            Case DialogResult.Yes
                txtGoodsValue.Clear()
                radSmall.Checked = True
                lstOutput.Items.Clear()
                txtGoodsValue.Focus()
            Case DialogResult.No
                Exit Sub
        End Select
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Select Case MessageBox.Show("Are You Sure You Want To Exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            Case DialogResult.Yes
                Me.Close()
            Case DialogResult.No
                Exit Sub
        End Select
    End Sub

    Private Sub radSmall_CheckedChanged(sender As Object, e As EventArgs) Handles radSmall.CheckedChanged
        picContainers.Image = My.Resources.Small
    End Sub

    Private Sub radMedium_CheckedChanged(sender As Object, e As EventArgs) Handles radMedium.CheckedChanged
        picContainers.Image = My.Resources.Medium
    End Sub

    Private Sub radLarge_CheckedChanged(sender As Object, e As EventArgs) Handles radLarge.CheckedChanged
        picContainers.Image = My.Resources.Large
    End Sub
End Class