Public Class Form1
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        '====================================================================================\
        'Validation of Registration Number Begins

        Dim RegNo As String
        'Verifying if the Registration Number is not Blank
        If txtRegNo.Text.Trim <> "" Then
            RegNo = txtRegNo.Text.Trim.ToUpper
        Else
            MsgBox("Registration No Cannot Be Blank!")
            txtRegNo.Clear()
            txtRegNo.Focus()
            Exit Sub
        End If

        'Verifying that Registration Number Length is <= 10
        If (RegNo.Length) <= 10 Then
            'Do Nothing
        Else
            MsgBox("Registration Number Must Be <= 10 Characters!")
            txtRegNo.Clear()
            txtRegNo.Focus()
            Exit Sub
        End If

        If (RegNo.Length >= 3) Then
            'Do Nothing
        Else
            MsgBox("Registration Number Must Have At Least 3 Characters!")
            txtRegNo.Clear()
            txtRegNo.Focus()
            Exit Sub
        End If

        Dim P As Integer
        For P = 0 To 2
            Select Case RegNo.Substring(P, 1)
                Case "A" To "Z"
                    'Do Nothing
                Case Else
                    MsgBox("First 3 Characters Must Be Alphabetics!")
                    txtRegNo.Clear()
                    txtRegNo.Focus()
                    Exit Sub
            End Select
        Next
        If RegNo.EndsWith("EC") Then
            'Do Nothing
        Else
            MsgBox("The Registration Number Must End With EC")
            txtRegNo.Clear()
            txtRegNo.Focus()
            Exit Sub
        End If

        'Done Validating The Registration Number
        '===========================================================================================



        'Validation of Driver's Last Name Begins
        '===========================================================================================
        Dim LastName As String
        If txtLastName.Text.Trim <> "" Then
            LastName = txtLastName.Text.Trim.ToUpper
            For P = 0 To LastName.Length - 1
                Select Case LastName.Substring(P, 1)
                    Case "A" To "Z", " "
                        'Do Nothing
                    Case Else
                        MsgBox("Driver's Last Name Must Be Alphabetic!")
                        txtLastName.Clear()
                        txtLastName.Focus()
                        Exit Sub
                End Select
            Next
        Else
            MsgBox("Driver's Last Name Cannot Be Blank!")
            txtLastName.Clear()
            txtLastName.Focus()
            Exit Sub
        End If

        'Driver's Last Name Vaidation Ends Here
        '============================================================================================



        'Validation of Number of Kilometres Driven Begins
        '============================================================================================
        Dim KMs As Double
        If txtKMs.Text.Trim <> "" Then
            If (IsNumeric(txtKMs.Text.Trim)) Then
                KMs = CDbl(txtKMs.Text.Trim)
                If KMs > 0 Then
                    'Do Nothing
                Else
                    MsgBox("Number of Kilometres Must Be > 0")
                    txtKMs.Clear()
                    txtKMs.Focus()
                    Exit Sub
                End If
            Else
                MsgBox("Number of Kilometres Must Be Mumeric!")
                txtKMs.Clear()
                txtKMs.Focus()
                Exit Sub
            End If
        Else
            MsgBox("Number of Kilometres Cannot Be Blank!")
            txtKMs.Clear()
            txtKMs.Focus()
            Exit Sub
        End If

        'Validation of Number of Kilometres Driven Ends
        '============================================================================================



        'Validation of Litres of Petrol Used Begins
        '============================================================================================
        Dim Litres As Double
        If txtLitres.Text.Trim <> "" Then
            If (IsNumeric(txtLitres.Text.Trim)) Then
                Litres = CDbl(txtLitres.Text.Trim)
                If Litres > 0 Then
                    'Do Nothing
                Else
                    MsgBox("Litres of Petrol Used Must Be > 0")
                    txtLitres.Clear()
                    txtLitres.Focus()
                    Exit Sub
                End If
            Else
                MsgBox("Litres of Petrol Used Must Be Mumeric!")
                txtLitres.Clear()
                txtLitres.Focus()
                Exit Sub
            End If
        Else
            MsgBox("Litres of Petrol Used Cannot Be Blank!")
            txtLitres.Clear()
            txtLitres.Focus()
            Exit Sub
        End If

        'Validation of Litres of Petrol Used Begins
        '============================================================================================



        'Calculations
        Dim TravelledKMs As Double
        TravelledKMs = KMs / Litres
        TravelledKMs = Math.Round(TravelledKMs, 2)

        'Assigning Vaues To List Box
        lstOutput.Items.Add("Kilometres Travelled Per Litre = " & TravelledKMs & "Km/l")
        lstOutput.Items.Add(System.Environment.NewLine)
        lstOutput.Items.Add("Taxi Registration No: " & RegNo)
        lstOutput.Items.Add(vbCrLf)
        'lstOutput.Items.Add(vbNewLine)
        lstOutput.Items.Add("Driver's Last Name: " & LastName)

        'Clearing The Text Boxes For New Input
        txtRegNo.Clear()
        txtLastName.Text = ""
        txtKMs.Clear()
        txtLitres.Text = ""


    End Sub

End Class