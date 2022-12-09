Public Class frmPasma
    Private Sub frmPasma_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Me.MaximizeBox = False
        Me.FormBorderStyle = FormBorderStyle.FixedDialog
        grpAdditionalColours.Cursor = Cursors.Hand
        grpTShirtSize.Cursor = Cursors.Hand

        radLarge.Checked = True

    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Clear()
    End Sub

    Sub Clear()
        Select Case MessageBox.Show("Are You Sure You Want To Clear?", "Clear", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            Case DialogResult.Yes
                txtName.Clear()
                lstOutput.Items.Clear()
                radMedium.Checked = True
                chkBlack.Checked = False
                chkMagenta.Checked = False
                chkRed.Checked = False
                chkNameEngraving.Checked = False
            Case DialogResult.No
                Exit Sub
        End Select

    End Sub
    Function CustomerName(ByRef Name As String) As Integer
        'Return 0 for Empty TextBox or S, 1 For Invalid Characters, 2 for Valid Characters
        If Name.Trim() <> "" Then
            Name = Name.Trim().ToUpper()
            For P As Integer = 0 To Name.Length() - 1
                Select Case Name.Substring(P, 1)
                    Case "A" To "Z", " "
                    Case Else
                        Return 1
                End Select
            Next
            Return 2
        Else
            Return 0
        End If
    End Function

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Select Case MessageBox.Show("Are You Sure You Want To Exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            Case DialogResult.Yes
                Me.Close()
            Case DialogResult.No
                Exit Sub
        End Select
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        lstOutput.Items.Clear()
        Dim Name As String = txtName.Text
        Dim ReturnedValue As Integer
        'Calling function CustomerName to Validate Name
        ReturnedValue = CustomerName(Name)
        If ReturnedValue = 0 Then
            MessageBox.Show("Input Student's Name", "Student's Name", MessageBoxButtons.OK, MessageBoxIcon.Question)
            txtName.Clear()
            txtName.Focus()
            Exit Sub
        ElseIf ReturnedValue = 1 Then
            MessageBox.Show("Student's Name Must Be Alphabetic", "Student's Name", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtName.Clear()
            txtName.Focus()
            Exit Sub
        ElseIf ReturnedValue = 2 Then
            'Student's Name is Valid
        End If

        'Calculations
        Dim ShirtPrice As Integer
        Dim ColoursPrice, PriceRed, PriceBlack, PriceMagenta, PriceNameEngraving, Vat, Price, TotalPrice As Double

        'Default Values For Additional Colours And Name Engraving
        PriceBlack = 0
        PriceMagenta = 0
        PriceRed = 0
        PriceNameEngraving = 0

        Dim TShirt, Space As String
        Space = "               "
        TShirt = "SMALL T-Shirt"

        'Price for T-Shirt Size
        If radSmall.Checked Then
            ShirtPrice = 50
        End If
        If radMedium.Checked Then
            TShirt = "MEDIUM T-Shirt"
            ShirtPrice = 75
        End If
        If radLarge.Checked Then
            TShirt = "LARGE T-Shirt"
            ShirtPrice = 100
        End If

        'Any Checked Additional Colour New Price
        If chkBlack.Checked Then
            PriceBlack = 55.9
        End If
        If chkRed.Checked Then
            PriceRed = 43.9
        End If
        If chkMagenta.Checked Then
            PriceMagenta = 80.99
        End If

        'Price For Name Engraving if Selected
        If chkNameEngraving.Checked Then
            PriceNameEngraving = 100.99
        End If

        'Calculating Price For Additional Colours
        ColoursPrice = PriceBlack + PriceRed + PriceMagenta

        'Calculating Price Before VAT
        Price = ShirtPrice + ColoursPrice + PriceNameEngraving

        'Calculating VAT (15%)
        Vat = Price * 0.15

        'Calculating Price After VAT
        TotalPrice = Price + Vat

        'Rounding Off Prices to 2 Decimal Places
        ColoursPrice = Math.Round(ColoursPrice, 2)
        Vat = Math.Round(Vat, 2)
        TotalPrice = Math.Round(TotalPrice, 2)

        'Displaying Name in Uppercase
        txtName.Text = Name

        'Displaying Values in a ListBox
        lstOutput.Items.Add(Space & TShirt)
        lstOutput.Items.Add(vbCrLf)
        lstOutput.Items.Add("Standard Price = R" & ShirtPrice.ToString("N2"))
        lstOutput.Items.Add("Price (Additional Colours) = R" & ColoursPrice.ToString("N2"))
        lstOutput.Items.Add("Price (Name Engraving) = R" & PriceNameEngraving.ToString("N2"))
        lstOutput.Items.Add("VAT (15%) = R" & Vat.ToString("N2"))
        lstOutput.Items.Add("Total Price (incl VAT) = R" & TotalPrice.ToString("N2"))

    End Sub
End Class
