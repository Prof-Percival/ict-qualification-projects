Public Class frmQunuAF
    Private Sub frmQunuAF_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grpIceCreamSize.Cursor = Cursors.Hand
        grpToppings.Cursor = Cursors.Hand
        Me.CenterToScreen()

        radLarge.Checked = True
        chkVanilla.Checked = False
        chkChocolate.Checked = False
        chkCaramel.Checked = False
    End Sub

    Sub Clear()
        txtName.Clear()
        txtTelephone.Clear()
        lstOutput.Items.Clear()
        radMedium.Checked = True
        chkVanilla.Checked = False
        chkCaramel.Checked = False
        chkChocolate.Checked = False
    End Sub

    Private Sub btnNextOrder_Click(sender As Object, e As EventArgs) Handles btnNextOrder.Click
        Clear()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Function CustomerName(Name As String) As Boolean
        If Name.Trim <> "" Then
            Name = Name.Trim.ToUpper
            For P As Integer = 0 To Name.Length - 1
                Select Case Name.Substring(P, 1)
                    Case "A" To "Z", " "
                    Case Else
                        Return False
                End Select
            Next
        Else
            Return False
        End If
        Return True
    End Function

    Function TelephoneNo(Telephone As String) As Boolean
        If Telephone.Trim <> "" Then
            Telephone = Telephone.Trim
            If IsNumeric(Telephone) Then
                For P As Integer = 0 To Telephone.Length - 1
                    Select Case Telephone.Substring(P, 1)
                        Case ","
                            Return False
                        Case Else

                    End Select
                Next
                If Not Telephone.StartsWith("0") Then
                    Return False
                End If
                If Not (CInt(Telephone.Length) >= 10 And CInt(Telephone.Length) <= 13) Then
                    Return False
                End If
            Else
                Return False
            End If
        Else
            Return False
        End If
        Return True
    End Function

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        lstOutput.Items.Clear()
        Dim StandardPrice, Toppings, Vanilla, Chocolate, Caramel As Integer
        Dim Vat, TotalPrice As Double

        Vanilla = 0
        Chocolate = 0
        Caramel = 0

        If CustomerName(txtName.Text) = False Then
            MsgBox("Invalid Customer's Name")
            txtName.Clear()
            txtName.Focus()
            Exit Sub
        End If

        If TelephoneNo(txtTelephone.Text) = False Then
            MsgBox("Invalid Telephone Number")
            txtTelephone.Clear()
            txtTelephone.Focus()
            Exit Sub
        End If

        If radSmall.Checked Then
            StandardPrice = 45
        ElseIf radMedium.Checked Then
            StandardPrice = 60
        ElseIf radLarge.Checked Then
            StandardPrice = 80
        End If

        If chkVanilla.Checked Then
            Vanilla = 15
        End If
        If chkChocolate.Checked Then
            Chocolate = 23
        End If
        If chkCaramel.Checked Then
            Caramel = 27
        End If

        'Calculations
        Toppings = Vanilla + Chocolate + Caramel

        Vat = (StandardPrice + Toppings) * (15 / 100)

        TotalPrice = StandardPrice + Toppings + Vat

        'Display
        lstOutput.Items.Add("Standard Price = R" & StandardPrice.ToString("N2"))
        lstOutput.Items.Add("Price (Toppings) = R" & Toppings.ToString("N2"))
        lstOutput.Items.Add("VAT Amount (15%) = R" & Vat.ToString("N2"))
        lstOutput.Items.Add("Total Price (incl VAT) = R" & TotalPrice.ToString("N2"))

    End Sub
End Class