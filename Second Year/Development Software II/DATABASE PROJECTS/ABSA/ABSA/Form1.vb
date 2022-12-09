Public Class Form1

    Private DataTable_Accounts As New DataTable
    Private RowIndex As Integer = 0
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim query As String
        Dim Conn_String As String
        Dim da As OleDb.OleDbDataAdapter

        'Optional Property Settings [BEGINS]
        Me.CenterToScreen()
        Me.FormBorderStyle = FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        cboSearch.DropDownStyle = ComboBoxStyle.DropDownList
        cboSearch.Cursor = Cursors.Hand
        'Optional Property Settings [ENDS]

        query = "SELECT * FROM Accounts"
        Conn_String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\CLIENTS.accdb"

        da = New OleDb.OleDbDataAdapter(query, Conn_String)
        da.Fill(DataTable_Accounts)
        da.Dispose()

        'Loading ComboBox
        For P As Integer = 0 To DataTable_Accounts.Rows.Count - 1
            cboSearch.Items.Add(DataTable_Accounts.Rows(P).Item(0))
        Next

        'Displaying First Account Number From Table on The ComboBox
        'cboSearch.SelectedItem = cboSearch.Items(0)

        'Calling DisplayData Procedure to Display Data
        DisplayData()
    End Sub

    Private Sub DisplayData()
        cboSearch.SelectedItem = cboSearch.Items(RowIndex)
        'Calculations
        Dim Balance, Total, Vat As Double
        Balance = CDbl(DataTable_Accounts.Rows(RowIndex)!BALANCE)
        Vat = Balance * 0.15
        Total = Balance + Vat

        'Displaying (Chose Amounts To Be 2 Decimal Places And Show Currency(R))
        txtSname.Text = CStr(DataTable_Accounts.Rows(RowIndex)!LASTNAME)
        txtInitial.Text = CStr(DataTable_Accounts.Rows(RowIndex)!INITIAL)
        txtBalance.Text = "R" & Balance.ToString("N2")
        txtTotal.Text = "R" + Total.ToString("N2")
    End Sub

    Private Sub btnFirst_Click(sender As Object, e As EventArgs) Handles btnFirst.Click
        If RowIndex <> 0 Then
            RowIndex = 0
            'Calling DisplayData Procedure to Display Data
            DisplayData()
        Else
            MessageBox.Show("You Are In The First Record", "Database", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If RowIndex > 0 Then
            RowIndex -= 1
            'Calling DisplayData Procedure to Display Data
            DisplayData()
        Else
            MessageBox.Show("You Are In The First Record", "Database", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If RowIndex < DataTable_Accounts.Rows.Count - 1 Then
            RowIndex += 1
            'Calling DisplayData Procedure to Display Data
            DisplayData()
        Else
            MessageBox.Show("You Are In The Last Record", "Database", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnLast_Click(sender As Object, e As EventArgs) Handles btnLast.Click
        If RowIndex <> DataTable_Accounts.Rows.Count - 1 Then
            RowIndex = DataTable_Accounts.Rows.Count - 1
            'Calling DisplayData Procedure to Display Data
            DisplayData()
        Else
            MessageBox.Show("You Are In The Last Record", "Database", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub cboSearch_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSearch.SelectedIndexChanged
        'Getting RowIndex From Selected Item in ComboBox
        RowIndex = cboSearch.SelectedIndex

        'Calling DisplayData Procedure to Display Data
        DisplayData()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Select Case MessageBox.Show("Are You Sure You Want To Exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            Case DialogResult.Yes
                Me.Close()
            Case DialogResult.No
                Exit Sub
        End Select
    End Sub
End Class