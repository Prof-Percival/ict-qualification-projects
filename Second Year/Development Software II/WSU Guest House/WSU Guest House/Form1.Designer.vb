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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtDays = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grpRoomType = New System.Windows.Forms.GroupBox()
        Me.radSuite = New System.Windows.Forms.RadioButton()
        Me.radDouble = New System.Windows.Forms.RadioButton()
        Me.radSingle = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDailyCharge = New System.Windows.Forms.TextBox()
        Me.chkAdditional = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtChargeBeforeVat = New System.Windows.Forms.TextBox()
        Me.txtChargeAfterVat = New System.Windows.Forms.TextBox()
        Me.txtVat = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.grpRoomType.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtDays)
        Me.GroupBox1.Controls.Add(Me.txtName)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 52)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(390, 117)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Guest Details"
        '
        'txtDays
        '
        Me.txtDays.Location = New System.Drawing.Point(138, 78)
        Me.txtDays.Name = "txtDays"
        Me.txtDays.Size = New System.Drawing.Size(95, 32)
        Me.txtDays.TabIndex = 1
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(138, 34)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(236, 32)
        Me.txtName.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(5, 83)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(129, 23)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Days of Stay"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Guest Name"
        '
        'grpRoomType
        '
        Me.grpRoomType.Controls.Add(Me.radSuite)
        Me.grpRoomType.Controls.Add(Me.radDouble)
        Me.grpRoomType.Controls.Add(Me.radSingle)
        Me.grpRoomType.Location = New System.Drawing.Point(414, 52)
        Me.grpRoomType.Name = "grpRoomType"
        Me.grpRoomType.Size = New System.Drawing.Size(169, 124)
        Me.grpRoomType.TabIndex = 0
        Me.grpRoomType.TabStop = False
        Me.grpRoomType.Text = "Room Type"
        '
        'radSuite
        '
        Me.radSuite.Location = New System.Drawing.Point(7, 92)
        Me.radSuite.Name = "radSuite"
        Me.radSuite.Size = New System.Drawing.Size(147, 27)
        Me.radSuite.TabIndex = 0
        Me.radSuite.Text = "S&uite (R500)"
        Me.radSuite.UseVisualStyleBackColor = True
        '
        'radDouble
        '
        Me.radDouble.Location = New System.Drawing.Point(7, 59)
        Me.radDouble.Name = "radDouble"
        Me.radDouble.Size = New System.Drawing.Size(163, 27)
        Me.radDouble.TabIndex = 0
        Me.radDouble.Text = "D&ouble (R350)"
        Me.radDouble.UseVisualStyleBackColor = True
        '
        'radSingle
        '
        Me.radSingle.Location = New System.Drawing.Point(7, 26)
        Me.radSingle.Name = "radSingle"
        Me.radSingle.Size = New System.Drawing.Size(156, 27)
        Me.radSingle.TabIndex = 0
        Me.radSingle.Text = "&Single (R250)"
        Me.radSingle.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Lucida Bright", 16.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(154, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(262, 35)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "WSU Guest House"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(16, 237)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(133, 23)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Daily Charge"
        '
        'txtDailyCharge
        '
        Me.txtDailyCharge.Location = New System.Drawing.Point(255, 234)
        Me.txtDailyCharge.Name = "txtDailyCharge"
        Me.txtDailyCharge.Size = New System.Drawing.Size(161, 32)
        Me.txtDailyCharge.TabIndex = 0
        Me.txtDailyCharge.TabStop = False
        '
        'chkAdditional
        '
        Me.chkAdditional.Location = New System.Drawing.Point(421, 182)
        Me.chkAdditional.Name = "chkAdditional"
        Me.chkAdditional.Size = New System.Drawing.Size(169, 38)
        Me.chkAdditional.TabIndex = 0
        Me.chkAdditional.TabStop = False
        Me.chkAdditional.Text = "Additional Bed"
        Me.chkAdditional.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(13, 366)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(231, 23)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Total Charge (incl VAT)"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(13, 280)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(234, 23)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Total Charge (excl VAT)"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(13, 323)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(131, 23)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "VAT Amount"
        '
        'txtChargeBeforeVat
        '
        Me.txtChargeBeforeVat.Location = New System.Drawing.Point(255, 277)
        Me.txtChargeBeforeVat.Name = "txtChargeBeforeVat"
        Me.txtChargeBeforeVat.Size = New System.Drawing.Size(161, 32)
        Me.txtChargeBeforeVat.TabIndex = 0
        Me.txtChargeBeforeVat.TabStop = False
        '
        'txtChargeAfterVat
        '
        Me.txtChargeAfterVat.Location = New System.Drawing.Point(255, 363)
        Me.txtChargeAfterVat.Name = "txtChargeAfterVat"
        Me.txtChargeAfterVat.Size = New System.Drawing.Size(161, 32)
        Me.txtChargeAfterVat.TabIndex = 0
        Me.txtChargeAfterVat.TabStop = False
        '
        'txtVat
        '
        Me.txtVat.Location = New System.Drawing.Point(255, 320)
        Me.txtVat.Name = "txtVat"
        Me.txtVat.Size = New System.Drawing.Size(161, 32)
        Me.txtVat.TabIndex = 0
        Me.txtVat.TabStop = False
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(189, 179)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(119, 38)
        Me.btnCalculate.TabIndex = 2
        Me.btnCalculate.Text = "&Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(16, 411)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(84, 38)
        Me.btnClear.TabIndex = 3
        Me.btnClear.Text = "Clea&r"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(500, 411)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(84, 38)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Beige
        Me.ClientSize = New System.Drawing.Size(600, 455)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtVat)
        Me.Controls.Add(Me.txtChargeAfterVat)
        Me.Controls.Add(Me.txtChargeBeforeVat)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.chkAdditional)
        Me.Controls.Add(Me.txtDailyCharge)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.grpRoomType)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "WSU Guest House"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.grpRoomType.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtDays As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents grpRoomType As GroupBox
    Friend WithEvents radSuite As RadioButton
    Friend WithEvents radDouble As RadioButton
    Friend WithEvents radSingle As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtDailyCharge As TextBox
    Friend WithEvents chkAdditional As CheckBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtChargeBeforeVat As TextBox
    Friend WithEvents txtChargeAfterVat As TextBox
    Friend WithEvents txtVat As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
End Class
