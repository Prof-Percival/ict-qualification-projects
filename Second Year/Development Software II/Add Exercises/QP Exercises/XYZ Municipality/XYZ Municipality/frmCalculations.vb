Public Class frmCalculations
    Private FormClose As Int32
    Private Sub frmCalculations_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If FormClose = 0 Then
            Select Case MessageBox.Show("Are You Sure You Want To Exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                Case DialogResult.Yes
                    frmHome.Close()
                    e.Cancel = False
                Case DialogResult.No
                    e.Cancel = True
            End Select
        Else
            Exit Sub
        End If
    End Sub

    Private Sub frmCalculations_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()

        'Setting TextBoxes To Read-Only
        txtName.ReadOnly = True
        txtAddress.ReadOnly = True
        txtHouseArea.ReadOnly = True
        txtLandArea.ReadOnly = True
        txtHouseTax.ReadOnly = True
        txtLandTax.ReadOnly = True
        txtDiscount.ReadOnly = True
        txtPropertyTax_Year.ReadOnly = True
        txtPropertyTax_Month.ReadOnly = True

        'Setting TextBoxes Background Color To White
        txtName.BackColor = Color.White
        txtAddress.BackColor = Color.White
        txtHouseArea.BackColor = Color.White
        txtLandArea.BackColor = Color.White
        txtHouseTax.BackColor = Color.White
        txtLandTax.BackColor = Color.White
        txtDiscount.BackColor = Color.White
        txtPropertyTax_Year.BackColor = Color.White
        txtPropertyTax_Month.BackColor = Color.White


        'Assigning Values From Home Page Form To TextBoxes
        txtName.Text = frmHome.NameofOwner
        txtAddress.Text = frmHome.Address
        txtHouseArea.Text = frmHome.HouseArea.ToString("N2") & "m²"
        txtLandArea.Text = frmHome.LandArea.ToString("N2") & "m²"
        txtHouseTax.Text = "R" & frmHome.HouseTax.ToString("N2")
        txtLandTax.Text = "R" & frmHome.LandTax.ToString("N2")
        txtDiscount.Text = "R" & frmHome.Discount.ToString("N2")
        txtPropertyTax_Year.Text = "R" & frmHome.PropertyTax_Year.ToString("N2")
        txtPropertyTax_Month.Text = "R" & frmHome.PropertyTax_Month.ToString("N2")
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        FormClose = 1
        Select Case MessageBox.Show("Are You Sure You Want To Return To Home Page?", "Municipality - Calculations", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            Case DialogResult.Yes
                Select Case MessageBox.Show("Note: The Information Here Will Be Erased", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
                    Case DialogResult.OK
                        frmHome.Show()
                        Me.Close()
                    Case DialogResult.Cancel
                        FormClose = 0
                        Exit Sub
                End Select
            Case DialogResult.No
                FormClose = 0
                Exit Sub
        End Select
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        FormClose = 1
        frmHome.FormClose = 1
        Select Case MessageBox.Show("Are You Sure You Want To Exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            Case DialogResult.Yes
                frmHome.Close()
                Me.Close()
            Case DialogResult.No
                FormClose = 0
                frmHome.FormClose = 0
                Exit Sub
        End Select
    End Sub
End Class