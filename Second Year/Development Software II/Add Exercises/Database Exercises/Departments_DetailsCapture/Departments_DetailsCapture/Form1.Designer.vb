<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnCapture = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtStudent_No = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtMiddleName = New System.Windows.Forms.TextBox()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dtpDateCaptured = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cboMajor = New System.Windows.Forms.ComboBox()
        Me.cboGender = New System.Windows.Forms.ComboBox()
        Me.cboLevel = New System.Windows.Forms.ComboBox()
        Me.BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DepartmentsDataSet = New Departments_DetailsCapture.DepartmentsDataSet()
        Me.IT_DepartmentTableAdapter = New Departments_DetailsCapture.DepartmentsDataSetTableAdapters.IT_DepartmentTableAdapter()
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DepartmentsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(536, 387)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(5)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(79, 36)
        Me.btnExit.TabIndex = 10
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnCapture
        '
        Me.btnCapture.Location = New System.Drawing.Point(250, 387)
        Me.btnCapture.Margin = New System.Windows.Forms.Padding(5)
        Me.btnCapture.Name = "btnCapture"
        Me.btnCapture.Size = New System.Drawing.Size(122, 36)
        Me.btnCapture.TabIndex = 9
        Me.btnCapture.Text = "Ca&pture"
        Me.btnCapture.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(30, 387)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(5)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(79, 36)
        Me.btnClear.TabIndex = 8
        Me.btnClear.Text = "&Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(145, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Student No#"
        '
        'txtStudent_No
        '
        Me.txtStudent_No.Location = New System.Drawing.Point(293, 54)
        Me.txtStudent_No.Name = "txtStudent_No"
        Me.txtStudent_No.Size = New System.Drawing.Size(147, 32)
        Me.txtStudent_No.TabIndex = 0
        Me.txtStudent_No.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(454, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 25)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Last Name"
        '
        'txtMiddleName
        '
        Me.txtMiddleName.Location = New System.Drawing.Point(229, 128)
        Me.txtMiddleName.Name = "txtMiddleName"
        Me.txtMiddleName.Size = New System.Drawing.Size(187, 32)
        Me.txtMiddleName.TabIndex = 2
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(30, 128)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(187, 32)
        Me.txtFirstName.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(63, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(122, 25)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "First Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(252, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(142, 25)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Middle Name"
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(428, 128)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(187, 32)
        Me.txtLastName.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(531, 166)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 25)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Level"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Font = New System.Drawing.Font("Verdana", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label6.Location = New System.Drawing.Point(113, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(419, 38)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Student Details Capture"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(28, 166)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(163, 25)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Gender (M / F)"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(303, 166)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 25)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Major"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(76, 250)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(158, 25)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Date Captured"
        '
        'dtpDateCaptured
        '
        Me.dtpDateCaptured.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDateCaptured.Location = New System.Drawing.Point(240, 246)
        Me.dtpDateCaptured.MinDate = New Date(2021, 11, 10, 0, 0, 0, 0)
        Me.dtpDateCaptured.Name = "dtpDateCaptured"
        Me.dtpDateCaptured.Size = New System.Drawing.Size(154, 32)
        Me.dtpDateCaptured.TabIndex = 7
        Me.dtpDateCaptured.Value = New Date(2021, 11, 10, 0, 0, 0, 0)
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label10.Font = New System.Drawing.Font("Verdana", 16.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label10.ForeColor = System.Drawing.Color.DarkOrange
        Me.Label10.Location = New System.Drawing.Point(163, 311)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(369, 34)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Captured By: Christoph"
        '
        'cboMajor
        '
        Me.cboMajor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMajor.FormattingEnabled = True
        Me.cboMajor.Location = New System.Drawing.Point(194, 193)
        Me.cboMajor.Name = "cboMajor"
        Me.cboMajor.Size = New System.Drawing.Size(294, 33)
        Me.cboMajor.TabIndex = 5
        '
        'cboGender
        '
        Me.cboGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboGender.FormattingEnabled = True
        Me.cboGender.Location = New System.Drawing.Point(49, 194)
        Me.cboGender.Name = "cboGender"
        Me.cboGender.Size = New System.Drawing.Size(121, 33)
        Me.cboGender.TabIndex = 4
        '
        'cboLevel
        '
        Me.cboLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboLevel.FormattingEnabled = True
        Me.cboLevel.Location = New System.Drawing.Point(505, 193)
        Me.cboLevel.Name = "cboLevel"
        Me.cboLevel.Size = New System.Drawing.Size(121, 33)
        Me.cboLevel.TabIndex = 6
        '
        'BindingSource
        '
        Me.BindingSource.DataMember = "IT_Department"
        Me.BindingSource.DataSource = Me.DepartmentsDataSet
        '
        'DepartmentsDataSet
        '
        Me.DepartmentsDataSet.DataSetName = "DepartmentsDataSet"
        Me.DepartmentsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'IT_DepartmentTableAdapter
        '
        Me.IT_DepartmentTableAdapter.ClearBeforeFill = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(664, 438)
        Me.Controls.Add(Me.cboLevel)
        Me.Controls.Add(Me.cboGender)
        Me.Controls.Add(Me.cboMajor)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.dtpDateCaptured)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.txtMiddleName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtStudent_No)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCapture)
        Me.Controls.Add(Me.btnExit)
        Me.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "Form1"
        Me.Text = "Departments_DetailsCapture"
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DepartmentsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnExit As Button
    Friend WithEvents btnCapture As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtStudent_No As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtMiddleName As TextBox
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents dtpDateCaptured As DateTimePicker
    Friend WithEvents Label10 As Label
    Friend WithEvents cboMajor As ComboBox
    Friend WithEvents cboGender As ComboBox
    Friend WithEvents cboLevel As ComboBox
    Friend WithEvents BindingSource As BindingSource
    Friend WithEvents DepartmentsDataSet As DepartmentsDataSet
    Friend WithEvents IT_DepartmentTableAdapter As DepartmentsDataSetTableAdapters.IT_DepartmentTableAdapter
End Class
