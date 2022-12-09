Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Setting All Output TextBoxes To Read-Only
        txtTotalCharged.ReadOnly = True
        txtAccLabourCharge.ReadOnly = True
        txtAccLabourHours.ReadOnly = True
        txtAccPartsCharge.ReadOnly = True
        txtAccVat.ReadOnly = True
        txtAccTotal.ReadOnly = True
    End Sub

    'Variables For Accumulating Totals
    Dim AccLabourCharge, AccPartsCharge, AccVat, AccTotal As Double
    Dim AccHours, P As Integer

    Function CustomerName(ByVal Name As String) As Boolean
        'Validating Customer's Name
        If (Name.Trim() <> "") Then
            Name = Name.Trim()
            For P = 0 To (Name.Length() - 1)
                Select Case (Name.Substring(P, 1))
                    Case "A" To "Z", "a" To "z"
                        'Continue Validating Name To See If it's Alphabetic
                    Case Else
                        Return False
                End Select
            Next
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub btnCalculate_Click(Sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim JobType, Hours As Integer
        Dim ChargeForParts, TotalCharged, Vat As Double

        'Calling a Function Procedure to Validate customer's Name
        If (CustomerName(txtName.Text)) Then
            'Customer's Name is Valid
        Else
            MessageBox.Show("Customer's Name Must Be Alphabetic", "Customer's Name", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtName.Clear()
            txtName.Focus()
            Exit Sub
        End If

        'Validating Job Type
        If (txtJobType.Text.Trim() <> "") Then
            If (IsNumeric(txtJobType.Text.Trim())) Then
                If (txtJobType.Text.Trim() = "1") Or (txtJobType.Text.Trim() = "2") Then
                    JobType = CInt(txtJobType.Text.Trim())
                Else
                    MessageBox.Show("Job Type Must Be 1 or 2", "Job Type", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtJobType.Clear()
                    txtJobType.Focus()
                    Exit Sub
                End If
            Else
                MessageBox.Show("Job Type Must Be Numeric", "Job Type", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtJobType.Clear()
                txtJobType.Focus()
                Exit Sub
            End If
        Else
            MessageBox.Show("Input job Type", "Job Type", MessageBoxButtons.OK, MessageBoxIcon.Question)
            txtJobType.Clear()
            txtJobType.Focus()
            Exit Sub
        End If

        'Validating Labour Hours
        If (txtHours.Text.Trim() <> "") Then
            If (IsNumeric(txtHours.Text.Trim())) Then
                For P = 0 To (txtHours.Text.Trim().Length() - 1)
                    Select Case (txtHours.Text.Trim().Substring(P, 1))
                        Case " "
                            MessageBox.Show("Labour Hours Must Be Numeric Without A Space Character", "Labour Hours", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            txtHours.Clear()
                            txtHours.Focus()
                            Exit Sub
                        Case ","
                            MessageBox.Show("Labour Hours Must Be A Whole Number", "Labour Hours", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            txtHours.Clear()
                            txtHours.Focus()
                            Exit Sub
                        Case Else
                            'The Labour Hours is a Whole Number
                    End Select
                Next
                Hours = CInt(txtHours.Text.Trim())
                If (Hours <= 0) Then
                    MessageBox.Show("Labour Hours Must Be Greater Than 0", "Labour Hours", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtHours.Clear()
                    txtHours.Focus()
                    Exit Sub
                End If
            Else
                MessageBox.Show("Labour Hours Must Be Numeric", "Labour Hours", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtHours.Clear()
                txtHours.Focus()
                Exit Sub
            End If
        Else
            MessageBox.Show("Input Labour Hours", "Labour Hours", MessageBoxButtons.OK, MessageBoxIcon.Question)
            txtHours.Clear()
            txtHours.Focus()
            Exit Sub
        End If

        'Validating Charge For The Parts Needed
        If (txtChargeForParts.Text.Trim() <> "") Then
            If (IsNumeric(txtChargeForParts.Text.Trim())) Then
                For P = 0 To (txtChargeForParts.Text.Trim().Length() - 1)
                    Select Case (txtChargeForParts.Text.Trim().Substring(P, 1))
                        Case " "
                            MessageBox.Show("Charge For The Parts Needed Must Not Contain A Space Character", "Charge For The Parts", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            txtChargeForParts.Clear()
                            txtChargeForParts.Focus()
                            Exit Sub
                        Case Else
                            'The Charge For The Parts Needed is Valid
                    End Select
                Next
                ChargeForParts = CDbl(txtChargeForParts.Text.Trim())
                If (ChargeForParts <= 0) Then
                    MessageBox.Show("Charge For The Parts Needed Must Be Greater Than 0", "Charge For The Parts", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtChargeForParts.Clear()
                    txtChargeForParts.Focus()
                    Exit Sub
                End If
            Else
                MessageBox.Show("Charge For The Parts Needed Must Be Numeric", "Charge For The Parts", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtChargeForParts.Clear()
                txtChargeForParts.Focus()
                Exit Sub
            End If
        Else
            MessageBox.Show("Input Charge For The Parts Needed", "Charge For The Parts", MessageBoxButtons.OK, MessageBoxIcon.Question)
            txtChargeForParts.Clear()
            txtChargeForParts.Focus()
            Exit Sub
        End If

        'Calculating Total Charged before VAT & Accumulating: Labour Charge (Type 1) And Hours For Labour (Type 2)
        If (JobType = 1) Then
            TotalCharged = (200 * Hours) + ChargeForParts
            AccLabourCharge += (200 * Hours)
        ElseIf (JobType = 2) Then
            TotalCharged = (300 * Hours) + ChargeForParts
            AccHours += Hours
        End If

        'Calculating VAT
        Vat = TotalCharged * 0.15

        'Calculating Total Charged After VAT
        TotalCharged += Vat

        'Accumulating Total Charged For Parts (All Job Types)
        AccPartsCharge += ChargeForParts

        'Accumulating VAT Amount (All Job Types)
        AccVat += Vat

        'Accumulating Total Made by Wagga Technology For All Repairs
        AccTotal += TotalCharged


        'Assigning Values To Text Boxes
        txtTotalCharged.Text = "R" & Math.Round(TotalCharged, 2)
        txtAccLabourCharge.Text = "R" & Math.Round(AccLabourCharge, 2)
        txtAccLabourHours.Text = CStr(AccHours)
        txtAccPartsCharge.Text = "R" & Math.Round(AccPartsCharge, 2)
        txtAccVat.Text = "R" & Math.Round(AccVat, 2)
        txtAccTotal.Text = "R" & Math.Round(AccTotal, 2)

    End Sub

    Sub NextOrder()
        'Clears Customer's Name, Job Type & Total TextBoxes
        txtName.Clear()
        txtJobType.Clear()
        txtTotalCharged.Clear()
    End Sub

    Private Sub btnNextOrder_Click(sender As Object, e As EventArgs) Handles btnNextOrder.Click
        'Calling NextOrder Sub Procedure To Perform Actions
        NextOrder()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Closing The Form
        Me.Close()
    End Sub

End Class