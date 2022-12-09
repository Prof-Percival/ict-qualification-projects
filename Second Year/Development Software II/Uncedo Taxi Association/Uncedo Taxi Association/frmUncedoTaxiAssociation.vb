Public Class frmUncedoTaxiAssociation

	Dim Total As Double
	Private Sub frmUncedoTaxiAssociation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Me.CenterToScreen()
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		txtSalary.ReadOnly = True
		txtTotal.ReadOnly = True
		txtName.Focus()
		txtSalary.BackColor = Color.White
		txtTotal.BackColor = Color.White
	End Sub

	Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
		Dim Name As String = txtName.Text
		If DriverName(Name) Then
		Else
			MessageBox.Show("Invalid Driver's Name", "Driver's Name", MessageBoxButtons.OK, MessageBoxIcon.Error)
			txtName.Clear()
			txtName.Focus()
			Exit Sub
		End If
		If txtIDNumber.Text.Trim() <> "" Then
			If IsNumeric(txtIDNumber.Text.Trim()) Then
				For P As Integer = 0 To (txtIDNumber.Text.Trim().Length() - 1)
					Select Case txtIDNumber.Text.Trim().Substring(P, 1)
						Case " "
							MessageBox.Show("Driver's ID Number Must Be Numeric Without A Space Character", "ID Number", MessageBoxButtons.OK, MessageBoxIcon.Error)
							txtIDNumber.Clear()
							txtIDNumber.Focus()
							Exit Sub
						Case ","
							MessageBox.Show("Driver's ID Number Must Be Numeric Without A Comma", "ID Number", MessageBoxButtons.OK, MessageBoxIcon.Error)
							txtIDNumber.Clear()
							txtIDNumber.Focus()
							Exit Sub
						Case Else
					End Select
				Next
				If txtIDNumber.Text.Trim().Length() <> 13 Then
					MessageBox.Show("Driver's ID Number Must Have 13 Digits", "ID Number", MessageBoxButtons.OK, MessageBoxIcon.Error)
					txtIDNumber.Clear()
					txtIDNumber.Focus()
					Exit Sub
				End If
			Else
				MessageBox.Show("Driver's ID Number Must Be Numeric", "ID Number", MessageBoxButtons.OK, MessageBoxIcon.Error)
				txtIDNumber.Clear()
				txtIDNumber.Focus()
				Exit Sub
			End If
		Else
			MessageBox.Show("Input Driver's ID Number", "ID Number", MessageBoxButtons.OK, MessageBoxIcon.Question)
			txtIDNumber.Clear()
			txtIDNumber.Focus()
			Exit Sub
		End If

		Dim IDNumber As String = txtIDNumber.Text.Trim()

		Dim RegNo As String = txtRegNo.Text
		If RegNo.Trim() <> "" Then
			If RegNo.Trim().Length <> 8 Then
				MessageBox.Show("Vehicle's Registration Number Must Be 8 Digits", "Vehicle's Registration Number", MessageBoxButtons.OK, MessageBoxIcon.Error)
				txtRegNo.Clear()
				txtRegNo.Focus()
				Exit Sub
			End If
			RegNo = RegNo.Trim().ToUpper()
			For P As Integer = 0 To 2
				Select Case RegNo.Substring(P, 1)
					Case "A" To "Z"
					Case Else
						MessageBox.Show("First 3 Character's of Vehicle's Registration Number Must Be Alphabetic", "Vehicle's Registration Number", MessageBoxButtons.OK, MessageBoxIcon.Error)
						txtRegNo.Clear()
						txtRegNo.Focus()
						Exit Sub
				End Select
			Next
			For P As Integer = 3 To 5
				Select Case RegNo.Substring(P, 1)
					Case 0 To 9
					Case Else
						MessageBox.Show("Middle 3 Character's of Vehicle's Registration Number Must Be Numbers", "Vehicle's Registration Number", MessageBoxButtons.OK, MessageBoxIcon.Error)
						txtRegNo.Clear()
						txtRegNo.Focus()
						Exit Sub
				End Select
			Next
			If RegNo.EndsWith("EC") Then
			Else
				MessageBox.Show("Vehicle's Registration Number Must End With EC", "Vehicle's Registration Number", MessageBoxButtons.OK, MessageBoxIcon.Error)
				txtRegNo.Clear()
				txtRegNo.Focus()
				Exit Sub
			End If
		Else
			MessageBox.Show("Input Vehicle's Registration Number", "Vehicle's Registration Number", MessageBoxButtons.OK, MessageBoxIcon.Question)
			txtRegNo.Clear()
			txtRegNo.Focus()
			Exit Sub
		End If

		Dim Hours As String = txtHours.Text
		If Hours.Trim() <> "" Then
			Hours = Hours.Trim()
			If IsNumeric(Hours) Then
			Else
				MessageBox.Show("Hours Worked Must Be Numeric", "Hours Worked", MessageBoxButtons.OK, MessageBoxIcon.Error)
				txtHours.Clear()
				txtHours.Focus()
				Exit Sub
			End If

			For P As Integer = 0 To Hours.Length() - 1
				Select Case Hours.Substring(P, 1)
					Case " "
						MessageBox.Show("Hours Worked Must Be Numeric Without A Space Character", "Hours Worked", MessageBoxButtons.OK, MessageBoxIcon.Error)
						txtHours.Clear()
						txtHours.Focus()
						Exit Sub
					Case Else
				End Select
			Next
		Else
			MessageBox.Show("Input Hours Worked", "Hours Worked", MessageBoxButtons.OK, MessageBoxIcon.Question)
			txtHours.Clear()
			txtHours.Focus()
			Exit Sub
		End If
		Dim Salary As Double
		Salary = SalaryCalculate(CDbl(Hours))
		Total += Salary

		'Outputting Values
		txtName.Text = Name
		txtIDNumber.Text = IDNumber
		txtRegNo.Text = RegNo
		txtHours.Text = CStr(Hours)
		txtSalary.Text = "R" & Salary
		txtTotal.Text = "R" & Total

		'Disabling Input Textboxes
		txtName.Enabled = False
		txtIDNumber.Enabled = False
		txtRegNo.Enabled = False
		txtHours.Enabled = False
	End Sub

	Function SalaryCalculate(Hours As Double) As Double
		If Hours > 40 Then
			Hours -= 40
			Return 2000 + (2000 * 0.1) * Hours
		Else
			Return 2000
		End If
	End Function

	Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
		Clear()
	End Sub

	Sub Clear()
		Select Case MessageBox.Show("Are You Sure You Want to Clear?", "Clear", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
			Case DialogResult.Yes
				txtName.Enabled = True
				txtIDNumber.Enabled = True
				txtRegNo.Enabled = True
				txtHours.Enabled = True

				txtName.Clear()
				txtIDNumber.Clear()
				txtRegNo.Clear()
				txtHours.Clear()
				txtSalary.Clear()

				txtName.Focus()
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

	Function DriverName(ByRef Name As String) As Boolean
		If Name.Trim() <> "" Then
			Name = Name.Trim().ToUpper()
			For P As Integer = 0 To Name.Length() - 1
				Select Case Name.Substring(P, 1)
					Case "A" To "Z", " "
					Case Else
						Return False
				End Select
			Next
			If Name.Length() >= 3 And Name.Length() <= 20 Then
			Else
				Return False
			End If
		Else
			Return False
		End If
		Return True
	End Function
End Class