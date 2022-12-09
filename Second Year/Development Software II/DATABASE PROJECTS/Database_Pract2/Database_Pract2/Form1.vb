Public Class Form1
    Dim DataTable_Cities As New DataTable
    Dim DataAdapter_F As OleDb.OleDbDataAdapter
    Dim Conn_String As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\PROJECTS\3rd Year\DES25P0\DATABASES\Megacities.accdb"
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MaximizeBox = False
        Me.CenterToScreen()
        cboCountry.Cursor = Cursors.Hand
        btnExit.Cursor = Cursors.Hand
        txtTotalPopulation.ReadOnly = True
        txtTotalPopulation.BackColor = Color.White
        'TODO: This line of code loads data into the 'MegacitiesDataSet.Cities' table. You can move, or remove it, as needed.
        'Me.CitiesTableAdapter.Fill(Me.MegacitiesDataSet.Cities)

        Dim SQL As String
        Dim DataAdapter As OleDb.OleDbDataAdapter
        SQL = "SELECT * FROM Cities"

        DataAdapter = New OleDb.OleDbDataAdapter(SQL, Conn_String)

        DataAdapter.Fill(DataTable_Cities)

        DataAdapter.Dispose()

        'Load The Combobox with Country Names
        For P As Integer = 0 To DataTable_Cities.Rows.Count - 1
            cboCountry.Items.Add(DataTable_Cities.Rows(P)!country)
        Next

        'Display The Citites in DataGrid
        dgvCities.DataSource = DataTable_Cities
        dgvCities.Refresh()
    End Sub

    Sub DisplayData(dt As DataTable)
        Dim Pop2005, Pop2015 As Double
        For P As Integer = 0 To dt.Rows.Count - 1
            Pop2005 += CDbl(dt.Rows(P)!pop2005)
            Pop2015 += CDbl(dt.Rows(P)!pop2015)
        Next

        Dim TotPop As Double
        TotPop = Pop2005 + Pop2015
        txtTotalPopulation.Text = TotPop
    End Sub

    Private Sub cboCountry_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCountry.SelectedIndexChanged
        Dim DataTable_F_Cities As New DataTable
        Dim SQL_F As String
        'Fill The Citites Datatable With Records for the selected country only
        SQL_F = "SELECT * FROM Cities WHERE country = '" & CStr(cboCountry.SelectedItem) & "'"


        DataAdapter_F = New OleDb.OleDbDataAdapter(SQL_F, Conn_String)
        DataAdapter_F.Fill(DataTable_F_Cities)
        DataAdapter_F.Dispose()

        'Display The Citites in The DataGrid
        dgvCities.DataSource = DataTable_F_Cities
        dgvCities.Refresh()

        'Calculating Total Population
        DisplayData(DataTable_F_Cities)
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
