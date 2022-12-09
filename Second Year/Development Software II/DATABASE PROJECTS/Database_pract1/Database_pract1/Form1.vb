Public Class Form1

    Dim RowIndex As Integer = 0
    Dim dtCities As New DataTable
    Dim ConnectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\PROJECTS\3rd Year\DES25P0\DATABASE PROJECTS\Database_pract1\Database_pract1\Megacities.accdb"
    Dim dsMegacitites As New DataSet
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MegacitiesDataSet.Cities' table. You can move, or remove it, as needed.
        'Me.CitiesTableAdapter.Fill(Me.MegacitiesDataSet.Cities)
        txtCity.ReadOnly = True
        txtCountry.ReadOnly = True
        txtPopulation2005.ReadOnly = True
        txtPopulation2015.ReadOnly = True
        txtCity.BackColor = Color.White
        txtCountry.BackColor = Color.White
        txtPopulation2005.BackColor = Color.White
        txtPopulation2015.BackColor = Color.White
        Me.MaximizeBox = False
        Me.CenterToScreen()
        'TODO: This line of code loads data into the '_181021DatabaseDataSet1.Student_Rec' table. You can move, or remove it, as needed.
        'Me.Student_RecTableAdapter.Fill(Me._181021DatabaseDataSet1.Student_Rec)

        Dim sql As String
        Dim DataAdapter As OleDb.OleDbDataAdapter
        sql = "SELECT * From Cities"
        DataAdapter = New OleDb.OleDbDataAdapter(sql, ConnectionString)
        'DataAdapter.Fill(dtCities)
        DataAdapter.Fill(dsMegacitites, "Cities")
        DataAdapter.Dispose()
        'CitiesTableAdapter.Fill(dtCities)
        'DisplayData()
        Call DisplayDataUsing_DataSet()
    End Sub

    Sub DisplayDataUsing_DataSet()
        txtCity.Text = CStr(dsMegacitites.Tables("Cities").Rows(RowIndex)!City)
        txtCountry.Text = CStr(dsMegacitites.Tables("Cities").Rows(RowIndex)!Country)
        If ((dsMegacitites.Tables("Cities").Rows(RowIndex)!Pop2005).ToString().Contains(",")) Then
            txtPopulation2005.Text = CStr(dsMegacitites.Tables("Cities").Rows(RowIndex).Item(2))
        Else
            txtPopulation2005.Text = CStr(dsMegacitites.Tables("Cities").Rows(RowIndex).Item(2)) & ",0"
        End If

        If ((dsMegacitites.Tables("Cities").Rows(RowIndex)!Pop2015).ToString().Contains(",")) Then
            txtPopulation2015.Text = CStr(dsMegacitites.Tables("Cities").Rows(RowIndex).Item(3))
        Else
            txtPopulation2015.Text = CStr(dsMegacitites.Tables("Cities").Rows(RowIndex).Item(3)) & ",0"
        End If
    End Sub

    Sub DisplayData()
        txtCity.Text = CStr(dtCities.Rows(RowIndex)!City)
        txtCountry.Text = CStr(dtCities.Rows(RowIndex)!Country)
        If ((dtCities.Rows(RowIndex)!Pop2005).ToString().Contains(",")) Then
            txtPopulation2005.Text = CStr(dtCities.Rows(RowIndex)!Pop2005)
        Else
            txtPopulation2005.Text = CStr(dtCities.Rows(RowIndex)!Pop2005) & ",0"
        End If

        If ((dtCities.Rows(RowIndex)!Pop2015).ToString().Contains(",")) Then
            txtPopulation2015.Text = CStr(dtCities.Rows(RowIndex)!Pop2015)
        Else
            txtPopulation2015.Text = CStr(dtCities.Rows(RowIndex)!Pop2015) & ",0"
        End If
    End Sub

    Private Sub btnFirst_Click(sender As Object, e As EventArgs) Handles btnFirst.Click
        RowIndex = 0
        'DisplayData()
        Call DisplayDataUsing_DataSet()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If RowIndex < dsMegacitites.Tables("Cities").Rows.Count - 1 Then
            RowIndex += 1
            'DisplayData()
            Call DisplayDataUsing_DataSet()
        Else
            MessageBox.Show("You Are In The Last Record", "Database - Cities", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
    End Sub

    Private Sub btnLast_Click(sender As Object, e As EventArgs) Handles btnLast.Click
        RowIndex = dsMegacitites.Tables("Cities").Rows.Count - 1
        'DisplayData()
        Call DisplayDataUsing_DataSet()
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If RowIndex > 0 Then
            RowIndex -= 1
            'DisplayData()
            Call DisplayDataUsing_DataSet()
        Else
            MessageBox.Show("You Are In The First Record", "Database - Cities", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
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