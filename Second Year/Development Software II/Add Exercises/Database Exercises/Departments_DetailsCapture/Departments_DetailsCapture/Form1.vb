Public Class Form1

    Dim query As String
    Dim IT_Dept_DataTable As New DataTable
    Dim Conn_String As String
    Dim Student_No, FirstName, MiddleName, LastName, Major As String
    Dim Gender, Level As Char
    Dim DateCaptured As Date
    Dim Conn As OleDb.OleDbConnection

    Private Sub btnCapture_Click(sender As Object, e As EventArgs) Handles btnCapture.Click
        Student_No = txtStudent_No.Text.Trim()
        FirstName = txtFirstName.Text.Trim()
        MiddleName = txtMiddleName.Text.Trim()
        LastName = txtLastName.Text.Trim()
        Major = CStr(cboMajor.SelectedItem)
        Gender = CChar(cboGender.SelectedItem)
        Level = CChar(cboLevel.SelectedItem)
        DateCaptured = dtpDateCaptured.Value.ToString("yyyy/MM/dd")

        Call CaptureDetails()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DepartmentsDataSet.IT_Department' table. You can move, or remove it, as needed.
        Me.IT_DepartmentTableAdapter.Fill(Me.DepartmentsDataSet.IT_Department)
        'TODO: This line of code loads data into the 'DepartmentsDataSet.IT_Department' table. You can move, or remove it, as needed.
        'Me.IT_DepartmentTableAdapter.Fill(Me.DepartmentsDataSet.IT_Department)
        btnCapture.Cursor = Cursors.Hand
        btnClear.Cursor = Cursors.Hand
        btnExit.Cursor = Cursors.Hand

        Me.CenterToScreen()
        Me.MaximizeBox = False
        Me.FormBorderStyle = FormBorderStyle.FixedDialog
        Me.ShowIcon = False

        cboGender.Cursor = Cursors.Hand
        cboLevel.Cursor = Cursors.Hand
        cboMajor.Cursor = Cursors.Hand
        dtpDateCaptured.Cursor = Cursors.Hand

        'Loading Gender Combobox With Data
        cboGender.Items.Add("M")
        cboGender.Items.Add("F")

        'Loading Major Combobox With Data
        cboMajor.Items.Add("Development Software")
        cboMajor.Items.Add("Support Services")
        cboMajor.Items.Add("Communication Networks")
        cboMajor.Items.Add("Business Analysis")

        'Loading Level Combobox with Data
        cboLevel.Items.Add("1")
        cboLevel.Items.Add("2")
        cboLevel.Items.Add("3")
        cboLevel.Items.Add("4")

        ' query = "INSERT INTO IT_Department Values('" & Student_No & "','" & FirstName & "','" & MiddleName & "','" & LastName & "','" & Gender & "','" & Major & "','" & Level & "'," & DateCaptured & ")"
        'query = "INSERT INTO IT_Department(Student_No,First_Name,Middle_Name,Last_Name,Gender,Major,Level)" &
        '   "Values('" & Student_No & "','" & FirstName & "','" & MiddleName & "','" & LastName & "','" & Gender & "','" & Major & "','" & Level & ")"
        query = "INSERT INTO IT_Department Values('" & Student_No & "','" & FirstName & "','" & MiddleName & "','" & LastName & "'," & Gender & ",'" & Major & "'," & Level & ")"
        Conn_String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Departments.accdb"
        Conn = New OleDb.OleDbConnection(Conn_String)
    End Sub

    Sub CaptureDetails()
        Try
            Dim cmd As New OleDb.OleDbCommand(query, Conn)
            Conn.Open()
            cmd.ExecuteNonQuery()
            MessageBox.Show("Details Captured Successfully", "Details Capture", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Select Case MessageBox.Show("Are You Sure You Want To Exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            Case DialogResult.Yes
                Me.Close()
            Case DialogResult.No
                Exit Sub
        End Select
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Select Case MessageBox.Show("Are You Sure You Want To Clear?", "Clear", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            Case DialogResult.Yes
                txtStudent_No.Clear()
                txtFirstName.Clear()
                txtMiddleName.Clear()
                txtLastName.Clear()
            Case DialogResult.No
                Exit Sub
        End Select
    End Sub
End Class
