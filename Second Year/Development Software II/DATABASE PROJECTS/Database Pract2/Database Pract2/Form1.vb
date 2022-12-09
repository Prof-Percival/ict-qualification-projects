Public Class Form1

    Private query As String
    Private Conn_String As String
    Private TotPop2005, TotPop2015 As Double
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.CenterToScreen()
        Me.FormBorderStyle = FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        cboCountry.Cursor = Cursors.Hand
        btnExit.Cursor = Cursors.Hand

        txtTotPop2005.TextAlign = HorizontalAlignment.Center
        txtTotPop2015.TextAlign = HorizontalAlignment.Center

        Conn_String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Megacities.accdb"
        query = "SELECT * FROM Cities"

        Dim dt As New DataTable

        Dim da As New OleDb.OleDbDataAdapter(query, Conn_String)
        da.Fill(dt)
        da.Dispose()

        For P As UInt16 = 0 To dt.Rows.Count - 1
            cboCountry.Items.Add(dt.Rows(P)!country)
            TotPop2005 += CDbl(dt.Rows(P)!pop2005)
            TotPop2015 += CDbl(dt.Rows(P)!pop2015)
        Next

        'Displaying Data in DataGridView & TextBoxes
        dgvCities.DataSource = dt
        txtTotPop2005.Text = TotPop2005.ToString("N1")
        txtTotPop2015.Text = TotPop2015.ToString("N1")

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Select Case MessageBox.Show("Are You Sure You Want To Exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            Case DialogResult.Yes
                Me.Close()
            Case DialogResult.No
                Exit Sub
        End Select
    End Sub

    Private Sub DisplayData(dt As DataTable)
        TotPop2005 = 0
        TotPop2015 = 0
        For P As UInt16 = 0 To dt.Rows.Count - 1
            TotPop2005 += CDbl(dt.Rows(P)!pop2005)
            TotPop2015 += CDbl(dt.Rows(P)!pop2015)
        Next

        'Displaying Data in DataGridView & TextBoxes
        dgvCities.DataSource = dt
        dgvCities.Refresh()
        txtTotPop2005.Text = TotPop2005.ToString("N1")
        txtTotPop2015.Text = TotPop2015.ToString("N1")

        dgvCities.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        dgvCities.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvCities.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
    End Sub

    Private Sub cboCountry_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCountry.SelectedIndexChanged
        query = "SELECT city, pop2005, pop2015 FROM Cities WHERE country = '" & CStr(cboCountry.SelectedItem) & "'"
        Dim DataTable_Cities As New DataTable
        Dim da As New OleDb.OleDbDataAdapter(query, Conn_String)
        da.Fill(DataTable_Cities)
        da.Dispose()

        DisplayData(DataTable_Cities)
    End Sub
End Class