Public Class frmMain

    Private DataTable_Cities As New DataTable
    Private DataTable_Countries As New DataTable

    Private RowIndex As Int16 = 0
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MegacitiesDataSet.Countries' table. You can move, or remove it, as needed.
        'Me.CountriesTableAdapter.Fill(Me.MegacitiesDataSet.Countries)
        'TODO: This line of code loads data into the 'MegacitiesDataSet.Cities' table. You can move, or remove it, as needed.
        'Me.CitiesTableAdapter.Fill(Me.MegacitiesDataSet.Cities)
        'TODO: This line of code loads data into the 'MegacitiesDataSet.Countries' table. You can move, or remove it, as needed.
        'Me.CountriesTableAdapter.Fill(Me.MegacitiesDataSet.Countries)
        'TODO: This line of code loads data into the 'MegacitiesDataSet.Cities' table. You can move, or remove it, as needed.
        'Me.CitiesTableAdapter.Fill(Me.MegacitiesDataSet.Cities)
        'TODO: This line of code loads data into the 'MegacitiesDataSet.Cities' table. You can move, or remove it, as needed.
        'Me.CitiesTableAdapter.Fill(Me.MegacitiesDataSet.Cities)
        'TODO: This line of code loads data into the 'MegacitiesDataSet.Countries' table. You can move, or remove it, as needed.
        ' Me.CountriesTableAdapter.Fill(Me.MegacitiesDataSet.Countries)
        'TODO: This line of code loads data into the 'MegacitiesDataSet.Cities' table. You can move, or remove it, as needed.
        ' Me.CitiesTableAdapter.Fill(Me.MegacitiesDataSet.Cities)
        'TODO: This line of code loads data into the 'MegacitiesDataSet.Cities' table. You can move, or remove it, as needed.
        'Me.CitiesTableAdapter.Fill(Me.MegacitiesDataSet.Cities)

        Dim query As String = "SELECT * FROM Cities"

        Dim Conn_String As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Megacities.accdb"

        Dim da As New OleDb.OleDbDataAdapter(query, Conn_String)

        da.Fill(DataTable_Cities)

        da.Dispose()

        Me.CenterToScreen()

        'Setting Textboxes to ReadOny
        txtCity.ReadOnly = True
        txtCountry.ReadOnly = True
        txtPop2005.ReadOnly = True
        txtPop2015.ReadOnly = True

        'Setting TextBoxes BackColor To White
        txtCity.BackColor = Color.White
        txtCountry.BackColor = Color.White
        txtPop2005.BackColor = Color.White
        txtPop2015.BackColor = Color.White

        'Setting Cursor for Buttons To Hand
        btnFirst.Cursor = Cursors.Hand
        btnNext.Cursor = Cursors.Hand
        btnPrevious.Cursor = Cursors.Hand
        btnLast.Cursor = Cursors.Hand
        btnExit.Cursor = Cursors.Hand

        Me.FormBorderStyle = FormBorderStyle.FixedDialog

        txtCity.Text = CStr(DataTable_Cities.Rows(RowIndex)!city)
        txtCountry.Text = CStr(DataTable_Cities.Rows(RowIndex)!country)
        txtPop2005.Text = CStr(DataTable_Cities.Rows(RowIndex)!pop2005)
        txtPop2015.Text = CStr(DataTable_Cities.Rows(RowIndex)!pop2015)
    End Sub


    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Select Case MessageBox.Show("Are You Sure You Want To Exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            Case DialogResult.Yes
                Me.Close()
            Case DialogResult.No
                Exit Sub
        End Select
    End Sub

    Private Sub btnFirst_Click(sender As Object, e As EventArgs) Handles btnFirst.Click
        If RowIndex <> 0 Then
            RowIndex = 0
            txtCity.Text = CStr(DataTable_Cities.Rows(RowIndex)!city)
            txtCountry.Text = CStr(DataTable_Cities.Rows(RowIndex)!country)

            If Not DataTable_Cities.Rows(RowIndex)!pop2005.ToString.Contains(",") Then
                txtPop2005.Text = CStr(DataTable_Cities.Rows(RowIndex)!pop2005) & ",0"
            Else
                txtPop2005.Text = CStr(DataTable_Cities.Rows(RowIndex)!pop2005)
            End If

            If Not DataTable_Cities.Rows(RowIndex)!pop2015.ToString.Contains(",") Then
                txtPop2015.Text = CStr(DataTable_Cities.Rows(RowIndex)!pop2015) & ",0"
            Else
                txtPop2015.Text = CStr(DataTable_Cities.Rows(RowIndex)!pop2015)
            End If
        Else
            MessageBox.Show("You Are In The First Record", "Database Response", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnLast_Click(sender As Object, e As EventArgs) Handles btnLast.Click
        If RowIndex <> DataTable_Cities.Rows.Count - 1 Then
            RowIndex = DataTable_Cities.Rows.Count - 1
            txtCity.Text = CStr(DataTable_Cities.Rows(RowIndex)!city)
            txtCountry.Text = CStr(DataTable_Cities.Rows(RowIndex)!country)

            If Not DataTable_Cities.Rows(RowIndex)!pop2005.ToString.Contains(",") Then
                txtPop2005.Text = CStr(DataTable_Cities.Rows(RowIndex)!pop2005) & ",0"
            Else
                txtPop2005.Text = CStr(DataTable_Cities.Rows(RowIndex)!pop2005)
            End If

            If Not DataTable_Cities.Rows(RowIndex)!pop2015.ToString.Contains(",") Then
                txtPop2015.Text = CStr(DataTable_Cities.Rows(RowIndex)!pop2015) & ",0"
            Else
                txtPop2015.Text = CStr(DataTable_Cities.Rows(RowIndex)!pop2015)
            End If
        Else
            MessageBox.Show("You Are In The Last Record", "Database Response", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If RowIndex < DataTable_Cities.Rows.Count - 1 Then
            RowIndex += 1
            txtCity.Text = CStr(DataTable_Cities.Rows(RowIndex)!city)
            txtCountry.Text = CStr(DataTable_Cities.Rows(RowIndex)!country)

            If Not DataTable_Cities.Rows(RowIndex)!pop2005.ToString.Contains(",") Then
                txtPop2005.Text = CStr(DataTable_Cities.Rows(RowIndex)!pop2005) & ",0"
            Else
                txtPop2005.Text = CStr(DataTable_Cities.Rows(RowIndex)!pop2005)
            End If

            If Not DataTable_Cities.Rows(RowIndex)!pop2015.ToString.Contains(",") Then
                txtPop2015.Text = CStr(DataTable_Cities.Rows(RowIndex)!pop2015) & ",0"
            Else
                txtPop2015.Text = CStr(DataTable_Cities.Rows(RowIndex)!pop2015)
            End If
        Else
            MessageBox.Show("You Are In The Last Record", "Database Response", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If RowIndex > 0 Then
            RowIndex -= 1
            txtCity.Text = CStr(DataTable_Cities.Rows(RowIndex)!city)
            txtCountry.Text = CStr(DataTable_Cities.Rows(RowIndex)!country)

            If Not DataTable_Cities.Rows(RowIndex)!pop2005.ToString.Contains(",") Then
                txtPop2005.Text = CStr(DataTable_Cities.Rows(RowIndex)!pop2005) & ",0"
            Else
                txtPop2005.Text = CStr(DataTable_Cities.Rows(RowIndex)!pop2005)
            End If

            If Not DataTable_Cities.Rows(RowIndex)!pop2015.ToString.Contains(",") Then
                txtPop2015.Text = CStr(DataTable_Cities.Rows(RowIndex)!pop2015) & ",0"
            Else
                txtPop2015.Text = CStr(DataTable_Cities.Rows(RowIndex)!pop2015)
            End If
        Else
            MessageBox.Show("You Are In The First Record", "Database Response", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class