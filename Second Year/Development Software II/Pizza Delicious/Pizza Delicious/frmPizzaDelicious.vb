Public Class frmPizzaDelicious

    Private Sub frmPizzaDelicious_Click(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MinimizeBox = False
        Me.MaximizeBox = False
        radLarge.Checked = True
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.CenterToScreen()
        grpToppings.Cursor = Cursors.Hand
        btnName.Focus()

        'Selection Mode For The ListBox
        lstOutput.SelectionMode = SelectionMode.One
        'picPizzaDelicious.Image = Image.FromFile("")

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Select Case MessageBox.Show("Are You Sure You Want to Clear?", "Clear", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            Case DialogResult.Yes
                btnName.Clear()
                txtTelephone.Clear()
                lstOutput.Items.Clear()
                'Checking Large Pizza Size Radio Button
                radLarge.Checked = True
                'Unchecking Toppings CheckBoxes
                chkAvocado.Checked = False
                chkBacon.Checked = False
                chkChicken.Checked = False
                chkChilli.Checked = False
                chkGreenPepper.Checked = False
                chkMozzarellaCheese.Checked = False
                btnName.Focus()
            Case DialogResult.No
                Exit Sub
        End Select
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Select Case MessageBox.Show("Are You Sure You Want to Exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            Case DialogResult.Yes
                Me.Close()
            Case DialogResult.No
                Exit Sub
        End Select
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        lstOutput.Items.Clear()
        Dim Name, Telephone As String
        Dim Type As Integer = 0
        Name = Me.btnName.Text
        Telephone = txtTelephone.Text
        NameValidate(Name, Type)
        If Type = 1 Then
            'Customer's Name is Valid
            TelephoneValidate(Telephone, Type)
            If Type = 1 Then
                'Telephone Number is Valid
            Else
                Exit Sub
            End If
        Else
            Exit Sub
        End If

        'Getting Pizza Size And Setting The Pizza Price Accordingly, (Adding Toppings Price if Available)
        Dim Small, Medium, Large As Double 'Pizza Size Price Variables & Values
        Small = 40.9
        Medium = 56.9
        Large = 76.9

        Dim StandardPrice, ToppingsPrice, Vat, TotalPrice As Double
        Dim Chilli, Avocado, Bacon, Chicken, GreenPepper, MozarellaCheese As Double
        Chilli = 0
        Avocado = 0
        Bacon = 0
        Chicken = 0
        GreenPepper = 0
        MozarellaCheese = 0
        ToppingsPrice = 0

        Dim Pizza As String = "SMALL PIZZA"
        Dim Space As String = "                         "
        'Calculating Price For Small Pizza
        If radSmall.Checked Then
            If chkChilli.Checked Then
                Chilli = 5.9
            End If
            If chkAvocado.Checked Then
                Avocado = 7.9
            End If
            If chkBacon.Checked Then
                Bacon = 7.9
            End If
            If chkChicken.Checked Then
                Chicken = 7.9
            End If
            If chkGreenPepper.Checked Then
                GreenPepper = 5.9
            End If
            If chkMozzarellaCheese.Checked Then
                MozarellaCheese = 9.9
            End If
            ToppingsPrice = Chilli + Avocado + Bacon + Chicken + GreenPepper + MozarellaCheese
            StandardPrice = Small + ToppingsPrice
        End If

        'Calculating Price For Medium Pizza
        If radMedium.Checked Then
            Pizza = "MEDIUM PIZZA"
            If chkChilli.Checked Then
                Chilli = 6.9
            End If
            If chkAvocado.Checked Then
                Avocado = 9.9
            End If
            If chkBacon.Checked Then
                Bacon = 9.9
            End If
            If chkChicken.Checked Then
                Chicken = 9.9
            End If
            If chkGreenPepper.Checked Then
                GreenPepper = 6.9
            End If
            If chkMozzarellaCheese.Checked Then
                MozarellaCheese = 12.9
            End If
            ToppingsPrice = Chilli + Avocado + Bacon + Chicken + GreenPepper + MozarellaCheese
            StandardPrice = Medium + ToppingsPrice
        End If

        'Calculating Price For Large Pizza
        If radLarge.Checked Then
            Pizza = "LARGE PIZZA"
            If chkChilli.Checked Then
                Chilli = 7.9
            End If
            If chkAvocado.Checked Then
                Avocado = 12.9
            End If
            If chkBacon.Checked Then
                Bacon = 12.9
            End If
            If chkChicken.Checked Then
                Chicken = 12.9
            End If
            If chkGreenPepper.Checked Then
                GreenPepper = 7.9
            End If
            If chkMozzarellaCheese.Checked Then
                MozarellaCheese = 15.9
            End If
            ToppingsPrice = Chilli + Avocado + Bacon + Chicken + GreenPepper + MozarellaCheese
            StandardPrice = Large + ToppingsPrice
        End If

        'Rounding Prices
        StandardPrice = Math.Round(StandardPrice, 2)
        ToppingsPrice = Math.Round(ToppingsPrice, 2)

        'Calculating VAT
        Vat = Math.Round(StandardPrice * 0.14, 2)

        'Calculating Total Price (incl VAT)
        TotalPrice = Math.Round(StandardPrice + Vat, 2)

        'Displaying Values in Output ListBox
        Me.btnName.Text = Name
        txtTelephone.Text = Telephone
        lstOutput.Items.Add(Space & Pizza)
        lstOutput.Items.Add(vbNewLine)
        lstOutput.Items.Add("Standard Price = R" & StandardPrice.ToString("N2"))
        lstOutput.Items.Add("Price (Toppings) = R" & ToppingsPrice.ToString("N2"))
        lstOutput.Items.Add("VAT (14%) = R" & Vat.ToString("N2"))
        lstOutput.Items.Add("Total Price (incl VAT) = R" & TotalPrice.ToString("N2"))
    End Sub

    Sub NameValidate(ByRef Name As String, ByRef Type As Integer)
        If (Name.Trim() <> "") Then
            Name = Name.Trim().ToUpper()
            For P As Integer = 0 To (Name.Length() - 1)
                Select Case Name.Substring(P, 1)
                    Case "A" To "Z", " "
                        'Customer's Name is Valid
                    Case Else
                        MessageBox.Show("Customer's Name Must Be Alphabetic", "Customer's Name", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Type = 0
                        Me.btnName.Clear()
                        Me.btnName.Focus()
                        Exit Sub
                End Select
            Next
            Type = 1
        Else
            MessageBox.Show("Input Customer's Name", "Customer's Name", MessageBoxButtons.OK, MessageBoxIcon.Question)
            Type = 0
            Me.btnName.Clear()
            Me.btnName.Focus()
            Exit Sub
        End If
    End Sub

    Sub TelephoneValidate(ByRef Telephone As String, ByRef Type As Integer)
        If (Telephone.Trim() <> "") Then
            Telephone = Telephone.Trim()
            If (IsNumeric(Telephone)) Then
                For P As Integer = 0 To (Telephone.Length() - 1)
                    Select Case Telephone.Substring(P, 1)
                        Case "0" To "9"
                            'Telephone Number is A Whole Number
                        Case " "
                            MessageBox.Show("Telephone Number Must Be Numeric Without A Space Character", "Telephone Number", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Type = 0
                            txtTelephone.Clear()
                            txtTelephone.Focus()
                            Exit Sub
                        Case ","
                            MessageBox.Show("Telephone Number Must Be Numeric Without A Comma", "Telephone Number", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Type = 0
                            txtTelephone.Clear()
                            txtTelephone.Focus()
                            Exit Sub
                    End Select
                Next
                If (Telephone.StartsWith("0")) Then
                    If (CInt(Telephone.Length()) >= 10) Then
                        If (CInt(Telephone.Length()) <= 13) Then
                            'Telephone Number is Valid
                            Type = 1
                        Else
                            MessageBox.Show("Telephone Number Must Have Max of 13 Digits", "Telephone Number", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Type = 0
                            txtTelephone.Clear()
                            txtTelephone.Focus()
                            Exit Sub
                        End If
                    Else
                        MessageBox.Show("Telephone Number Must Have Min of 10 Digits", "Telephone Number", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Type = 0
                        txtTelephone.Clear()
                        txtTelephone.Focus()
                        Exit Sub
                    End If
                Else
                    MessageBox.Show("Telephone Number Must Begin With 0", "Telephone Number", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Type = 0
                    txtTelephone.Clear()
                    txtTelephone.Focus()
                    Exit Sub
                End If
            Else
                MessageBox.Show("Telephone Number Must Be Numeric", "Telephone Number", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Type = 0
                txtTelephone.Clear()
                txtTelephone.Focus()
                Exit Sub
            End If
        Else
            MessageBox.Show("Input Telephone Number", "Telephone Number", MessageBoxButtons.OK, MessageBoxIcon.Question)
            Type = 0
            txtTelephone.Clear()
            txtTelephone.Focus()
            Exit Sub
        End If
    End Sub
End Class