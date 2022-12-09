Public Class Form1

    Dim P As Integer
    Sub FName(ByRef FirstName As String, ByRef ID As Boolean)

        'Validation of First Name Begins
        '============================================================================================
        If FirstName.Trim() <> "" Then
            FirstName = FirstName.Trim().ToUpper()
            For P = 0 To (FirstName.Length - 1)
                Select Case FirstName.Substring(P, 1)
                    Case "A" To "Z", " "
                        'Continue Validating The First Name
                    Case Else
                        MsgBox("First Name Must Be Alphabetic", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "First Name")
                        txtFName.Clear()
                        txtFName.Focus()
                        txtTBalance.Text = "R" & CStr(0)
                        Exit Sub
                End Select
            Next
            ID = True
        Else
            MsgBox("Input First Name", MsgBoxStyle.OkOnly Or MsgBoxStyle.Question, "First Name")
            txtFName.Clear()
            txtFName.Focus()
            txtTBalance.Text = "R" & CStr(0)
            Exit Sub
        End If

        'Validation of First Name Ends
        '============================================================================================
    End Sub

    Sub LName(ByRef LastName As String, ByRef ID As Boolean)

        'Validation of Last Name Begins
        '============================================================================================
        If LastName.Trim() <> "" Then
            LastName = LastName.Trim().ToUpper()
            For P = 0 To (LastName.Length - 1)
                Select Case LastName.Substring(P, 1)
                    Case "A" To "Z", " "
                        'Continue Validating The Last Name
                    Case Else
                        MsgBox("Last Name Must Be Alphabetic", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "Last Name")
                        txtLName.Clear()
                        txtLName.Focus()
                        txtTBalance.Text = "R" & CStr(0)
                        Exit Sub
                End Select
            Next
            ID = True
        Else
            MsgBox("Input Last Name", MsgBoxStyle.OkOnly Or MsgBoxStyle.Question, "Last Name")
            txtLName.Clear()
            txtLName.Focus()
            txtTBalance.Text = "R" & CStr(0)
            Exit Sub
        End If

        'Validation of Last Name Ends
        '============================================================================================
    End Sub

    Sub Citizenship(ByRef Citizen As String, ByRef ID As Boolean)

        'Validation of Citizen Begins
        '============================================================================================
        If Citizen.Trim <> "" Then
            Citizen = Citizen.Trim().ToUpper()
            For P = 0 To (Citizen.Length - 1)
                Select Case Citizen.Substring(P, 1)
                    Case "A" To "Z", " "
                        'Continue Validating The Citizen
                    Case Else
                        MsgBox("Citizen Must Be Alphabetic", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "Citizen")
                        txtCitizen.Clear()
                        txtCitizen.Focus()
                        txtTBalance.Text = "R" & CStr(0)
                        Exit Sub
                End Select
            Next
            ID = True
        Else
            MsgBox("Input Citizen", MsgBoxStyle.OkOnly Or MsgBoxStyle.Question, "Citizen")
            txtCitizen.Clear()
            txtCitizen.Focus()
            txtTBalance.Text = "R" & CStr(0)
            Exit Sub
        End If

        'Validation of Citizen Ends
        '============================================================================================
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Sub IDValidator(ByRef IDNumber As String, ByRef ID As Boolean)

        'Validation of ID Number Begins
        '============================================================================================
        IDNumber = IDNumber.Trim()
        If IDNumber <> "" Then
            If (IsNumeric(IDNumber)) Then
                If (IDNumber.Length() = 13) Then
                    For P = 0 To 12 Step 1
                        Select Case IDNumber.Substring(P, 1)
                            Case " "
                                MsgBox("ID Number Must Not Contain Space Character", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "ID Number")
                                txtIDNo.Clear()
                                txtIDNo.Focus()
                                txtTBalance.Text = "R" & CStr(0)
                                Exit Sub
                            Case ","
                                MsgBox("ID Number Must Be 13 Digits Without a Decimal Point", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "ID Number")
                                txtIDNo.Clear()
                                txtIDNo.Focus()
                                txtTBalance.Text = "R" & CStr(0)
                                Exit Sub
                            Case Else
                                'Continue Checking for Any Space(s) / Decimal Point Character on the ID Number
                        End Select
                    Next
                    ID = True
                Else
                    MsgBox("ID Number Must Be 13 Digits", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "ID Number")
                    txtIDNo.Clear()
                    txtIDNo.Focus()
                    txtTBalance.Text = "R" & CStr(0)
                    Exit Sub
                End If
            Else
                MsgBox("ID Number Must Be Numeric", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "ID Number")
                txtIDNo.Clear()
                txtIDNo.Focus()
                txtTBalance.Text = "R" & CStr(0)
                Exit Sub
            End If
        Else
            MsgBox("Input ID Number", MsgBoxStyle.OkOnly Or MsgBoxStyle.Question, "ID Number")
            txtIDNo.Clear()
            txtIDNo.Focus()
            txtTBalance.Text = "R" & CStr(0)
            Exit Sub
        End If
        'Validation of ID Number Ends
        '============================================================================================

    End Sub

    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click


        'Calling Procedures And Exiting If Data is Invalid
        Dim IDNumber As String = txtIDNo.Text
        Dim FirstName As String = txtFName.Text
        Dim LastName As String = txtLName.Text
        Dim Citizen As String = txtCitizen.Text
        Dim Balance As String = txtBalance.Text
        Dim TBalance As Double
        Dim ID As Boolean = False
        IDValidator(IDNumber, ID)
        If ID = True Then
            ID = False
            FName(FirstName, ID)
            If ID = True Then
                ID = False
                LName(LastName, ID)
                If ID = True Then
                    ID = False
                    Citizenship(Citizen, ID)
                    If ID = True Then
                        ID = False
                        CurrentBalance(Balance, ID)
                        If ID = True Then
                            'Calling TotalBalance Function Procedure and Assigning Returned Value to TBalance
                            TBalance = TotalBalance(IDNumber, Balance)
                        Else
                            Exit Sub
                        End If
                    Else
                        Exit Sub
                    End If
                Else
                    Exit Sub
                End If
            Else
                Exit Sub
            End If
        Else
            Exit Sub
        End If


        'Calling Output Sub Procedure
        Output(IDNumber, FirstName, LastName, Citizen, Balance, TBalance)
    End Sub

    Sub CurrentBalance(ByRef Balance As String, ByRef ID As Boolean)

        'Validation of Balance Amount Begins
        '============================================================================================
        If Balance.Trim <> "" Then
            Balance = Balance.Trim()
            If (IsNumeric(Balance)) Then
                For P = 0 To (Balance.Length() - 1)
                    Select Case (Balance.Substring(P, 1))
                        Case " "
                            MsgBox("Balance Amount Must Not Contain Space Character", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "Balane Amount")
                            txtBalance.Clear()
                            txtBalance.Focus()
                            txtTBalance.Text = "R" & CStr(0)
                            Exit Sub
                        Case Else
                            'Do Nothing
                    End Select
                Next
                If CDbl(Balance) > 0 Then
                    ID = True
                Else
                    MsgBox("Balance Amount Must Be > 0", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "Balane Amount")
                    txtBalance.Clear()
                    txtBalance.Focus()
                    txtTBalance.Text = "R" & CStr(0)
                    Exit Sub
                End If
            Else
                MsgBox("Balance Amount Must Be Numeric", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "Balane Amount")
                txtBalance.Clear()
                txtBalance.Focus()
                txtTBalance.Text = "R" & CStr(0)
                Exit Sub
            End If
        Else
            MsgBox("Input Balance Amount", MsgBoxStyle.OkOnly Or MsgBoxStyle.Question, "Balane Amount")
            txtBalance.Clear()
            txtBalance.Focus()
            txtTBalance.Text = "R" & CStr(0)
            Exit Sub
        End If

        'Validation of Balance Amount Ends
        '============================================================================================
    End Sub

    Function TotalBalance(ByVal IDNumber As String, ByVal Balance As String) As Double

        Dim Bal As Double = CDbl(Balance)
        'Validating if the ID Starts With Certain Numbers And Calculating Total Balance
        '============================================================================================

        If (CInt(IDNumber.Substring(0, 1) <= 5)) And (CInt(IDNumber.Substring(1, 1) <= 5)) Then
            Return (Math.Round((Bal + (Bal * 0.05)), 2))
        Else
            Return (Math.Round((Bal + (Bal * 0.03)), 2))
        End If

        'The End of Validating if the ID Starts With Certain Numbers And Calculating Total Balance
        '============================================================================================
    End Function

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        'Clears all the Text Boxes
        txtIDNo.Clear()
        txtFName.Clear()
        txtLName.Clear()
        txtCitizen.Clear()
        txtBalance.Clear()
        txtTBalance.Clear()
        txtIDNo.Focus()

    End Sub

    Sub Output(ByVal IDNumber As String, ByVal FirstName As String, ByVal LastName As String, ByVal Citizen As String, ByVal Balance As String, ByVal TBalance As Double)

        'Assigning Values To TextBoxes
        txtIDNo.Text = IDNumber
        txtFName.Text = FirstName
        txtLName.Text = LastName
        txtCitizen.Text = Citizen
        txtBalance.Text = "R" & CStr(Math.Round(CDbl(Balance), 2))
        txtTBalance.Text = "R" & CStr(TBalance)
    End Sub

End Class