Public Class Form1

    Private query As String
    Private Conn_String As String
    Private TotPop2005 As Double
    Private DataTable_CC As New DataTable
    Private da As OleDb.OleDbDataAdapter
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MegacitiesDataSet.Cities' table. You can move, or remove it, as needed.
        Me.CitiesTableAdapter.Fill(Me.MegacitiesDataSet.Cities)

        Me.CenterToScreen()
        Me.FormBorderStyle = FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        cboCountry.Cursor = Cursors.Hand
        btnExit.Cursor = Cursors.Hand
        cboCountry.DropDownStyle = ComboBoxStyle.DropDownList

        txtTotPop2005.TextAlign = HorizontalAlignment.Center

        Conn_String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Megacities.accdb"
        query = "SELECT country FROM Countries"

        Dim DataTable_C As New DataTable
        da = New OleDb.OleDbDataAdapter(query, Conn_String)
        da.Fill(DataTable_C)
        da.Dispose()

        For P As UInt16 = 0 To DataTable_C.Rows.Count - 1
            cboCountry.Items.Add(DataTable_C.Rows(P)!country)
        Next

        cboCountry.SelectedItem = cboCountry.Items(0)

        query = "SELECT * FROM Cities"
        Dim dt As New DataTable
        da = New OleDb.OleDbDataAdapter(query, Conn_String)
        da.Fill(dt)
        da.Dispose()

        'Displaying Data in DataGridView
        dgvCities.DataSource = dt
        dgvCities.Refresh()

        CalculatePop(dt)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Select Case MessageBox.Show("Are You Sure You Want To Exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            Case DialogResult.Yes
                Me.Close()
            Case DialogResult.No
                Exit Sub
        End Select
    End Sub

    Private Sub CalculatePop(dt As DataTable)
        TotPop2005 = 0
        For P As Int16 = 0 To dt.Rows.Count - 1
            TotPop2005 += CDbl(dt.Rows(P)!pop2005)
        Next

        'Displaying Data in TextBox
        txtTotPop2005.Text = TotPop2005.ToString("N1")

        dgvCities.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        dgvCities.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvCities.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
    End Sub

    Private Sub cboCountry_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCountry.SelectedIndexChanged
        query = "SELECT Cities.city, Countries.monetaryUnit, Countries.pop2005 FROM Cities INNER JOIN Countries ON Cities.country = Countries.country WHERE Countries.country = '" & CStr(cboCountry.SelectedItem) & "'"
        'Dim DataTable_Cities As New DataTable
        'DataTable_CC = New DataTable
        DataTable_CC.Clear()
        da = New OleDb.OleDbDataAdapter(query, Conn_String)
        da.Fill(DataTable_CC)
        da.Dispose()

        dgvCities.DataSource = DataTable_CC
        dgvCities.Refresh()

        CalculatePop(DataTable_CC)
    End Sub
End Class