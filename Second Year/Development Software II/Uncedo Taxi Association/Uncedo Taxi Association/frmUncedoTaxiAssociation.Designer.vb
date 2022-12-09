<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUncedoTaxiAssociation
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
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.txtIDNumber = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.txtSalary = New System.Windows.Forms.TextBox()
        Me.txtHours = New System.Windows.Forms.TextBox()
        Me.txtRegNo = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(195, 178)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(113, 39)
        Me.btnCalculate.TabIndex = 4
        Me.btnCalculate.Text = "&Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'txtIDNumber
        '
        Me.txtIDNumber.Location = New System.Drawing.Point(293, 59)
        Me.txtIDNumber.Name = "txtIDNumber"
        Me.txtIDNumber.Size = New System.Drawing.Size(163, 32)
        Me.txtIDNumber.TabIndex = 1
        Me.txtIDNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(68, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Driver's Name"
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(272, 280)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(125, 32)
        Me.txtTotal.TabIndex = 0
        Me.txtTotal.TabStop = False
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtSalary
        '
        Me.txtSalary.Location = New System.Drawing.Point(272, 232)
        Me.txtSalary.Name = "txtSalary"
        Me.txtSalary.Size = New System.Drawing.Size(125, 32)
        Me.txtSalary.TabIndex = 0
        Me.txtSalary.TabStop = False
        Me.txtSalary.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtHours
        '
        Me.txtHours.Location = New System.Drawing.Point(315, 131)
        Me.txtHours.Name = "txtHours"
        Me.txtHours.Size = New System.Drawing.Size(125, 32)
        Me.txtHours.TabIndex = 3
        Me.txtHours.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtRegNo
        '
        Me.txtRegNo.Location = New System.Drawing.Point(68, 131)
        Me.txtRegNo.Name = "txtRegNo"
        Me.txtRegNo.Size = New System.Drawing.Size(163, 32)
        Me.txtRegNo.TabIndex = 2
        Me.txtRegNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(40, 59)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(213, 32)
        Me.txtName.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(40, 235)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(180, 23)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Employee's Salary"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(346, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 23)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Hours"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(302, 33)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(116, 23)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "ID Number"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(68, 105)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(163, 23)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Vehicle's Reg No"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(40, 283)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(208, 23)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "All Employees Salary"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(385, 335)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(71, 39)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(11, 335)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(74, 39)
        Me.btnNext.TabIndex = 5
        Me.btnNext.Text = "&Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(98, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(294, 28)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Uncedo Taxi Association"
        '
        'frmUncedoTaxiAssociation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(476, 382)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtRegNo)
        Me.Controls.Add(Me.txtHours)
        Me.Controls.Add(Me.txtSalary)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtIDNumber)
        Me.Controls.Add(Me.btnCalculate)
        Me.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "frmUncedoTaxiAssociation"
        Me.ShowIcon = False
        Me.Text = "Uncedo Taxi Association"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCalculate As Button
    Friend WithEvents txtIDNumber As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents txtSalary As TextBox
    Friend WithEvents txtHours As TextBox
    Friend WithEvents txtRegNo As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents Label7 As Label
End Class
