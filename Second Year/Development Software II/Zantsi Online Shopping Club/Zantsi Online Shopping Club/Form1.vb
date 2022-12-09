Public Class Form1

    Dim P As Integer 'Variable used as Index on the For Loop
    Dim AmountForOrders As Double = 0 'Variable used to hold all Total Amounts for all Orders

    Sub SAMovies(ByRef Movies As String, ByRef id As Boolean)

        'Validation for Number of Movies Begins
        '============================================================================================
        If Movies.Trim() <> "" Then
            Movies = Movies.Trim()
            If (IsNumeric(Movies)) Then
                For P = 0 To (Movies.Length() - 1)
                    Select Case (Movies.Substring(P, 1))
                        Case "0" To "9"
                            'The Number of Movies is a Whole Number
                        Case " "
                            MsgBox("Number of Movies Must Be a Whole Number Without Space Character", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "Movies")
                            txtMovies.Clear()
                            txtMovies.Focus()
                            txtOrder.Text = "R" + CStr(0)
                            Exit Sub
                        Case Else
                            MsgBox("Number of Movies Must Be a Whole Number", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "Movies")
                            txtMovies.Clear()
                            txtMovies.Focus()
                            txtOrder.Text = "R" + CStr(0)
                            Exit Sub
                    End Select
                Next
                id = True
            Else
                MsgBox("Number of Movies Must Be Numeric", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "Movies")
                txtMovies.Clear()
                txtMovies.Focus()
                txtOrder.Text = "R" + CStr(0)
                Exit Sub
            End If
        Else
            MsgBox("Input Number of Movies", MsgBoxStyle.OkOnly Or MsgBoxStyle.Question, "Movies")
            txtMovies.Clear()
            txtMovies.Focus()
            txtOrder.Text = "R" + CStr(0)
            Exit Sub
        End If

        'Validation for Number of Movies Ends
        '============================================================================================
    End Sub

    Sub MusicCDs(ByRef CDs As String, ByRef id As Boolean)

        'Validation for Number of Music CDs Begins
        '============================================================================================
        If CDs.Trim() <> "" Then
            CDs = CDs.Trim()
            If (IsNumeric(CDs)) Then
                For P = 0 To (CDs.Length() - 1)
                    Select Case (CDs.Substring(P, 1))
                        Case "0" To "9"
                            'The Number of Music CDs is a Whole Number
                        Case " "
                            MsgBox("Number of CDs Must Be a Whole Number Without Space Character", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "Music CDs")
                            txtCDs.Clear()
                            txtCDs.Focus()
                            txtOrder.Text = "R" + CStr(0)
                            Exit Sub
                        Case Else
                            MsgBox("Number of Music CDs Must Be a Whole Number", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "Music CDs")
                            txtCDs.Clear()
                            txtCDs.Focus()
                            txtOrder.Text = "R" + CStr(0)
                            Exit Sub
                    End Select
                Next
                id = True
            Else
                MsgBox("Number of Music CDs Must Be Numeric", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "Music CDs")
                txtCDs.Clear()
                txtCDs.Focus()
                txtOrder.Text = "R" + CStr(0)
                Exit Sub
            End If
        Else
            MsgBox("Input Number of Music CDs", MsgBoxStyle.OkOnly Or MsgBoxStyle.Question, "Music CDs")
            txtCDs.Clear()
            txtCDs.Focus()
            txtOrder.Text = "R" + CStr(0)
            Exit Sub
        End If

        'Validation for Number of Music CDs Ends
        '============================================================================================
    End Sub

    Private Sub btnExi_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Close the Program
        Me.Close()
    End Sub

    Sub MemberNumber(ByRef MemberNo As String, ByRef id As Boolean)

        'Validation for Member Number Begins
        '============================================================================================
        If MemberNo.Trim() <> "" Then
            MemberNo = MemberNo.Trim().ToUpper()
            If (MemberNo.Length()) = 5 Then
                If MemberNo.EndsWith("AA") Then
                    'The Member Number is Correct
                    id = True
                Else
                    MsgBox("Member Number Must End with AA", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "Member Number")
                    txtMemberNo.Clear()
                    txtMemberNo.Focus()
                    txtOrder.Text = "R" & CStr(0)
                    Exit Sub
                End If
            Else
                MsgBox("Member Number Must Be 5 Characters", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "Member Number")
                txtMemberNo.Clear()
                txtMemberNo.Focus()
                txtOrder.Text = "R" & CStr(0)
                Exit Sub
            End If
        Else
            MsgBox("Input Member Number", MsgBoxStyle.OkOnly Or MsgBoxStyle.Question, "Member Number")
            txtMemberNo.Clear()
            txtMemberNo.Focus()
            txtOrder.Text = "R" & CStr(0)
            Exit Sub
        End If

        'Validation for Member Number Ends
        '============================================================================================
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        Dim id As Boolean = False
        Dim MemberNo As String = txtMemberNo.Text
        Dim Movies As String = txtMovies.Text
        Dim CDs As String = txtCDs.Text

        MemberNumber(MemberNo, id)
        If (id = True) Then
            id = False
            SAMovies(Movies, id)
            If (id = True) Then
                id = False
                MusicCDs(CDs, id)
                If (id = True) Then
                    id = False
                    MoviesAndCDs(CInt(Movies), CInt(CDs), id)
                    If (id = True) Then
                        Dim AmountForOrder As Double
                        AmountForOrder = CalculateAmount(CInt(Movies), CInt(CDs))
                        Output(MemberNo, CInt(Movies), CInt(CDs), AmountForOrder)
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
    End Sub

    Sub MoviesAndCDs(ByVal Movies As Integer, ByVal CDs As Integer, ByRef id As Boolean)

        'Validation for Number of both Movies and CDs That they're not = 0 Begins 
        '============================================================================================
        If (Movies + CDs) <> 0 Then
            'The Number of both Movies and CDs is not 0
            id = True
        Else
            MsgBox("Both Number of Movies and CDs Cannot Be = 0", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "Movies & CDs")
            txtMovies.Clear()
            txtCDs.Clear()
            txtMovies.Focus()
            txtOrder.Text = "R" + CStr(0)
            Exit Sub
        End If

        'Validation for Number of both Movies and CDs That they're not = 0 Ends 
        '============================================================================================
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        'Clear The Text Boxes Leaving the "Total Amount for All Orders" Text box
        txtMemberNo.Clear()
        txtMovies.Clear()
        txtCDs.Clear()
        txtOrder.Clear()
        txtMemberNo.Focus()

    End Sub

    Function CalculateAmount(ByVal Movies As Integer, ByVal CDs As Integer) As Double

        'Calculations For Total Amounts Begins 
        '============================================================================================
        Dim CDsPrice, MoviesPrice As Double


        'Movies Specials
        If (Movies < 5) Then
            MoviesPrice = Movies * 105
        ElseIf (Movies = 5) Then
            MoviesPrice = Movies * 89.99
        ElseIf (Movies >= 10) Then
            MoviesPrice = Movies * 40
        ElseIf (Movies > 5 And Movies < 10) Then
            MoviesPrice = Movies * 105
        End If

        'CDs Specials
        If (CDs < 3 Or CDs = 4) Then
            CDsPrice = CDs * 99.99
        ElseIf (CDs = 3) Then
            CDsPrice = CDs * 80
        ElseIf (CDs >= 5) Then
            CDsPrice = CDs * 30
        End If


        'Returning Amount For This Order To The Calling Procedure
        Return Math.Round((MoviesPrice + CDsPrice), 2)

        'Calculations For Total Amounts Ends
        '============================================================================================
    End Function

    Sub Output(ByVal MemberNo As String, ByVal Movies As Integer, ByVal CDs As Integer, ByVal AmountForOrder As Double)

        'The AmountForOrders Variable is declared in the Class, not in the Method or Event Handler (btnCalculate)
        AmountForOrders = Math.Round((AmountForOrders + AmountForOrder), 2)

        'Assignment of Values To Text Boxes Begins 
        '============================================================================================
        txtMemberNo.Text = MemberNo
        txtMovies.Text = Movies.ToString()
        txtCDs.Text = CDs.ToString()
        txtOrder.Text = "R" & CStr(AmountForOrder)
        txtOrders.Text = "R" & CStr(AmountForOrders)

        'Assignment of Values To Text Boxes Ends
        '============================================================================================
    End Sub

End Class