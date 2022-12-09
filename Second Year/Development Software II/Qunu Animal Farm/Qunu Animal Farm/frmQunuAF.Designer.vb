<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQunuAF
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
        Me.btnNextOrder = New System.Windows.Forms.Button()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grpIceCreamSize = New System.Windows.Forms.GroupBox()
        Me.radLarge = New System.Windows.Forms.RadioButton()
        Me.radMedium = New System.Windows.Forms.RadioButton()
        Me.radSmall = New System.Windows.Forms.RadioButton()
        Me.chkVanilla = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTelephone = New System.Windows.Forms.TextBox()
        Me.grpToppings = New System.Windows.Forms.GroupBox()
        Me.chkCaramel = New System.Windows.Forms.CheckBox()
        Me.chkChocolate = New System.Windows.Forms.CheckBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.lstOutput = New System.Windows.Forms.ListBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.grpIceCreamSize.SuspendLayout()
        Me.grpToppings.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnNextOrder
        '
        Me.btnNextOrder.Location = New System.Drawing.Point(62, 423)
        Me.btnNextOrder.Name = "btnNextOrder"
        Me.btnNextOrder.Size = New System.Drawing.Size(131, 36)
        Me.btnNextOrder.TabIndex = 3
        Me.btnNextOrder.Text = "&Next Order"
        Me.btnNextOrder.UseVisualStyleBackColor = True
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(236, 20)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(228, 32)
        Me.txtName.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(56, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(174, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Customer's Name"
        '
        'grpIceCreamSize
        '
        Me.grpIceCreamSize.Controls.Add(Me.radLarge)
        Me.grpIceCreamSize.Controls.Add(Me.radMedium)
        Me.grpIceCreamSize.Controls.Add(Me.radSmall)
        Me.grpIceCreamSize.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grpIceCreamSize.Location = New System.Drawing.Point(56, 112)
        Me.grpIceCreamSize.Name = "grpIceCreamSize"
        Me.grpIceCreamSize.Size = New System.Drawing.Size(174, 125)
        Me.grpIceCreamSize.TabIndex = 0
        Me.grpIceCreamSize.TabStop = False
        Me.grpIceCreamSize.Text = "Ice Cream Size"
        '
        'radLarge
        '
        Me.radLarge.AutoSize = True
        Me.radLarge.ForeColor = System.Drawing.SystemColors.Desktop
        Me.radLarge.Location = New System.Drawing.Point(6, 92)
        Me.radLarge.Name = "radLarge"
        Me.radLarge.Size = New System.Drawing.Size(85, 27)
        Me.radLarge.TabIndex = 0
        Me.radLarge.Text = "Large"
        Me.radLarge.UseVisualStyleBackColor = True
        '
        'radMedium
        '
        Me.radMedium.AutoSize = True
        Me.radMedium.ForeColor = System.Drawing.SystemColors.Desktop
        Me.radMedium.Location = New System.Drawing.Point(6, 61)
        Me.radMedium.Name = "radMedium"
        Me.radMedium.Size = New System.Drawing.Size(107, 27)
        Me.radMedium.TabIndex = 0
        Me.radMedium.Text = "Medium"
        Me.radMedium.UseVisualStyleBackColor = True
        '
        'radSmall
        '
        Me.radSmall.AutoSize = True
        Me.radSmall.ForeColor = System.Drawing.SystemColors.Desktop
        Me.radSmall.Location = New System.Drawing.Point(6, 31)
        Me.radSmall.Name = "radSmall"
        Me.radSmall.Size = New System.Drawing.Size(85, 27)
        Me.radSmall.TabIndex = 0
        Me.radSmall.Text = "Small"
        Me.radSmall.UseVisualStyleBackColor = True
        '
        'chkVanilla
        '
        Me.chkVanilla.AutoSize = True
        Me.chkVanilla.ForeColor = System.Drawing.SystemColors.Desktop
        Me.chkVanilla.Location = New System.Drawing.Point(6, 31)
        Me.chkVanilla.Name = "chkVanilla"
        Me.chkVanilla.Size = New System.Drawing.Size(98, 27)
        Me.chkVanilla.TabIndex = 0
        Me.chkVanilla.TabStop = False
        Me.chkVanilla.Text = "Vanilla"
        Me.chkVanilla.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(56, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 23)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Telephone No"
        '
        'txtTelephone
        '
        Me.txtTelephone.Location = New System.Drawing.Point(236, 66)
        Me.txtTelephone.Name = "txtTelephone"
        Me.txtTelephone.Size = New System.Drawing.Size(228, 32)
        Me.txtTelephone.TabIndex = 1
        '
        'grpToppings
        '
        Me.grpToppings.Controls.Add(Me.chkCaramel)
        Me.grpToppings.Controls.Add(Me.chkChocolate)
        Me.grpToppings.Controls.Add(Me.chkVanilla)
        Me.grpToppings.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grpToppings.Location = New System.Drawing.Point(285, 112)
        Me.grpToppings.Name = "grpToppings"
        Me.grpToppings.Size = New System.Drawing.Size(179, 125)
        Me.grpToppings.TabIndex = 0
        Me.grpToppings.TabStop = False
        Me.grpToppings.Text = "Toppings"
        '
        'chkCaramel
        '
        Me.chkCaramel.AutoSize = True
        Me.chkCaramel.ForeColor = System.Drawing.SystemColors.Desktop
        Me.chkCaramel.Location = New System.Drawing.Point(6, 98)
        Me.chkCaramel.Name = "chkCaramel"
        Me.chkCaramel.Size = New System.Drawing.Size(111, 27)
        Me.chkCaramel.TabIndex = 0
        Me.chkCaramel.TabStop = False
        Me.chkCaramel.Text = "Caramel"
        Me.chkCaramel.UseVisualStyleBackColor = True
        '
        'chkChocolate
        '
        Me.chkChocolate.AutoSize = True
        Me.chkChocolate.ForeColor = System.Drawing.SystemColors.Desktop
        Me.chkChocolate.Location = New System.Drawing.Point(6, 64)
        Me.chkChocolate.Name = "chkChocolate"
        Me.chkChocolate.Size = New System.Drawing.Size(122, 27)
        Me.chkChocolate.TabIndex = 0
        Me.chkChocolate.TabStop = False
        Me.chkChocolate.Text = "Chocolate"
        Me.chkChocolate.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(205, 243)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(107, 34)
        Me.btnCalculate.TabIndex = 2
        Me.btnCalculate.Text = "&Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'lstOutput
        '
        Me.lstOutput.Font = New System.Drawing.Font("Century", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lstOutput.FormattingEnabled = True
        Me.lstOutput.ItemHeight = 28
        Me.lstOutput.Location = New System.Drawing.Point(62, 289)
        Me.lstOutput.Name = "lstOutput"
        Me.lstOutput.Size = New System.Drawing.Size(402, 116)
        Me.lstOutput.TabIndex = 0
        Me.lstOutput.TabStop = False
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(379, 423)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(85, 36)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmQunuAF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(529, 471)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lstOutput)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.grpToppings)
        Me.Controls.Add(Me.txtTelephone)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.grpIceCreamSize)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.btnNextOrder)
        Me.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.Name = "frmQunuAF"
        Me.ShowIcon = False
        Me.Text = "Qunu Animal Farm"
        Me.grpIceCreamSize.ResumeLayout(False)
        Me.grpIceCreamSize.PerformLayout()
        Me.grpToppings.ResumeLayout(False)
        Me.grpToppings.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnNextOrder As Button
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents grpIceCreamSize As GroupBox
    Friend WithEvents radSmall As RadioButton
    Friend WithEvents chkVanilla As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtTelephone As TextBox
    Friend WithEvents grpToppings As GroupBox
    Friend WithEvents radLarge As RadioButton
    Friend WithEvents radMedium As RadioButton
    Friend WithEvents chkCaramel As CheckBox
    Friend WithEvents chkChocolate As CheckBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents lstOutput As ListBox
    Friend WithEvents btnExit As Button
End Class
