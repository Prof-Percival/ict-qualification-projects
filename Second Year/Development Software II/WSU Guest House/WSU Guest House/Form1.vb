Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Setting Textboxes To Align Text on Center
        txtDays.TextAlign = HorizontalAlignment.Center
        txtDailyCharge.TextAlign = HorizontalAlignment.Center
        txtChargeBeforeVat.TextAlign = HorizontalAlignment.Center
        txtVat.TextAlign = HorizontalAlignment.Center
        txtChargeAfterVat.TextAlign = HorizontalAlignment.Center

        'Setting Output TextBoxes to ReadOnly
        txtDailyCharge.ReadOnly = True
        txtChargeBeforeVat.ReadOnly = True
        txtVat.ReadOnly = True
        txtChargeAfterVat.ReadOnly = True

        'Setting Back Color Of The Output Textboxes
        txtDailyCharge.BackColor = Color.White
        txtChargeBeforeVat.BackColor = Color.White
        txtVat.BackColor = Color.White
        txtChargeAfterVat.BackColor = Color.White

        'Setting The Form Not To Allow Maximise
        Me.MaximizeBox = False

        Me.AutoScaleMode = AutoScaleMode.None

        'Setting The Form Border Style
        Me.FormBorderStyle = FormBorderStyle.FixedToolWindow
        Me.ShowInTaskbar = True

        'Checking Our Radio Button (Double Room)
        radDouble.Checked = True

        'Setting Cursor Type for Radio buttons & CheckBox
        grpRoomType.Cursor = Cursors.Hand
        chkAdditional.Cursor = Cursors.Hand

        'Changing The Form Not To Show Icon
        Me.ShowIcon = False
    End Sub

    Function NameValidate(ByVal Name As String, ByRef Value As Integer) As Boolean
        If (Name.Trim() <> "") Then
            Value = 1
            Name = Name.Trim()
            For P As Integer = 0 To Name.Length() - 1
                Select Case Name.Substring(P, 1)
                    Case "A" To "Z", "a" To "z", " "
                        'Name is Valid
                    Case Else
                        Return False
                End Select
            Next
        Else
            'Value = 0 (Optional)
            Return False
        End If
        Return True
    End Function

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim Value As Integer = 0

        'Validating Name
        If NameValidate(txtName.Text, Value) Then
            'Name is Valid
        Else
            If (Value = 0) Then
                MessageBox.Show("Input Name", "Guest Name", MessageBoxButtons.OK, MessageBoxIcon.Question)
            End If
            If (Value = 1) Then
                MessageBox.Show("Guest Name Must Be Alphabetic", "Guest Name", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            txtName.Clear()
            txtName.Focus()
            Exit Sub
        End If

        'Validating Number of Days of Stay
        If (txtDays.Text.Trim() <> "") Then
            If (IsNumeric(txtDays.Text.Trim())) Then
                For P As Integer = 0 To (txtDays.Text.Trim().Length() - 1)
                    Select Case (txtDays.Text.Trim().Substring(P, 1))
                        Case ","
                            MessageBox.Show("Number of Days of Stay Must Be A Whole Number", "Number of Days of Stay", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            txtDays.Clear()
                            txtDays.Focus()
                            Exit Sub
                        Case " "
                            MessageBox.Show("Number of Days of Stay Must Be A Whole Number Without A Space Character", "Number of Days of Stay", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            txtDays.Clear()
                            txtDays.Focus()
                            Exit Sub
                        Case Else
                            'Name Is A Whole Number
                    End Select
                Next
                If (CInt(txtDays.Text.Trim()) < 1) Then
                    MessageBox.Show("Number of Days of Stay Must Not Be Less Than 1", "Number of Days of Stay", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtDays.Clear()
                    txtDays.Focus()
                    Exit Sub
                End If
            Else
                MessageBox.Show("Number of Days of Stay Must Be Numeric", "Number of Days of Stay", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtDays.Clear()
                txtDays.Focus()
                Exit Sub
            End If
        Else
            MessageBox.Show("Input Number of Days of Stay", "Number of Days of Stay", MessageBoxButtons.OK, MessageBoxIcon.Question)
            txtDays.Clear()
            txtDays.Focus()
            Exit Sub
        End If
        Dim Days As Integer = CInt(txtDays.Text.Trim())

        Dim DailyCharge As Integer, Price As Integer = 0, AdditionalBedCharge As Integer = 0

        'Calculating Daily Charge
        If (radSingle.Checked) Then
            Price = 250
        End If

        If (radDouble.Checked) Then
            Price = 350
        End If

        If (radSuite.Checked) Then
            Price = 500
        End If

        If (chkAdditional.Checked) Then
            AdditionalBedCharge = 50
        End If
        DailyCharge = Price + AdditionalBedCharge

        'Calculating Total Charge Before VAT
        Dim CHargeBeforeVat As Integer = (Price + AdditionalBedCharge) * Days

        'Calculating VAT
        Dim Vat As Double = CHargeBeforeVat * 0.14

        'Calculating Total Charge After VAT
        Dim ChargeAfterVat As Double = CHargeBeforeVat + Vat


        'Assigning Values to Text Boxes
        txtDailyCharge.Text = "R" & DailyCharge.ToString("N2")
        txtChargeBeforeVat.Text = "R" & CHargeBeforeVat.ToString("N2")
        txtVat.Text = "R" & Vat.ToString("N2")
        txtChargeAfterVat.Text = "R" & ChargeAfterVat.ToString("N2")
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Select Case MessageBox.Show("Are You Sure You Want To Clear?", "Clear", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            Case DialogResult.Yes
                txtName.Clear()
                txtDays.Clear()
                txtDailyCharge.Clear()
                txtChargeBeforeVat.Clear()
                txtVat.Clear()
                txtChargeAfterVat.Clear()
                txtName.Focus()
                chkAdditional.Checked = False
                radDouble.Checked = True
            Case DialogResult.No
                Exit Sub
        End Select
    End Sub

    Private Sub btnExit_Cick(sender As Object, e As EventArgs) Handles btnExit.Click
        Select Case MessageBox.Show("Are You Sure You Want To Exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            Case DialogResult.Yes
                Me.Close()
            Case DialogResult.No
                Exit Sub
        End Select
    End Sub
End Class