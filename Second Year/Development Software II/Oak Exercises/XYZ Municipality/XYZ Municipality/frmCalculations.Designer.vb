<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCalculations
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
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.lblHouseArea = New System.Windows.Forms.Label()
        Me.txtLandArea = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.lblLandArea = New System.Windows.Forms.Label()
        Me.grpAddress = New System.Windows.Forms.GroupBox()
        Me.txtHouseArea = New System.Windows.Forms.TextBox()
        Me.txtHouseTax = New System.Windows.Forms.TextBox()
        Me.lblLandTax = New System.Windows.Forms.Label()
        Me.txtLandTax = New System.Windows.Forms.TextBox()
        Me.lblHouseTax = New System.Windows.Forms.Label()
        Me.lblDiscount = New System.Windows.Forms.Label()
        Me.txtDiscount = New System.Windows.Forms.TextBox()
        Me.lblPropertyTax_Year = New System.Windows.Forms.Label()
        Me.txtPropertyTax_Year = New System.Windows.Forms.TextBox()
        Me.lblPropertyTax_Month = New System.Windows.Forms.Label()
        Me.txtPropertyTax_Month = New System.Windows.Forms.TextBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.grpAddress.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(233, 12)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(237, 32)
        Me.txtName.TabIndex = 0
        Me.txtName.TabStop = False
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(70, 15)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(157, 23)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Name of Owner"
        '
        'btnReturn
        '
        Me.btnReturn.Location = New System.Drawing.Point(12, 508)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(83, 39)
        Me.btnReturn.TabIndex = 0
        Me.btnReturn.Text = "&Return"
        Me.btnReturn.UseVisualStyleBackColor = True
        '
        'lblHouseArea
        '
        Me.lblHouseArea.AutoSize = True
        Me.lblHouseArea.Location = New System.Drawing.Point(89, 222)
        Me.lblHouseArea.Name = "lblHouseArea"
        Me.lblHouseArea.Size = New System.Drawing.Size(163, 23)
        Me.lblHouseArea.TabIndex = 0
        Me.lblHouseArea.Text = "House Area (m²)"
        '
        'txtLandArea
        '
        Me.txtLandArea.Location = New System.Drawing.Point(318, 248)
        Me.txtLandArea.Name = "txtLandArea"
        Me.txtLandArea.Size = New System.Drawing.Size(125, 32)
        Me.txtLandArea.TabIndex = 0
        Me.txtLandArea.TabStop = False
        Me.txtLandArea.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtAddress
        '
        Me.txtAddress.Font = New System.Drawing.Font("Century", 12.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtAddress.Location = New System.Drawing.Point(6, 31)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(394, 129)
        Me.txtAddress.TabIndex = 0
        Me.txtAddress.TabStop = False
        '
        'lblLandArea
        '
        Me.lblLandArea.AutoSize = True
        Me.lblLandArea.Location = New System.Drawing.Point(310, 222)
        Me.lblLandArea.Name = "lblLandArea"
        Me.lblLandArea.Size = New System.Drawing.Size(152, 23)
        Me.lblLandArea.TabIndex = 0
        Me.lblLandArea.Text = "Land Area (m²)"
        '
        'grpAddress
        '
        Me.grpAddress.Controls.Add(Me.txtAddress)
        Me.grpAddress.Location = New System.Drawing.Point(71, 51)
        Me.grpAddress.Name = "grpAddress"
        Me.grpAddress.Size = New System.Drawing.Size(407, 168)
        Me.grpAddress.TabIndex = 0
        Me.grpAddress.TabStop = False
        Me.grpAddress.Text = "Address"
        '
        'txtHouseArea
        '
        Me.txtHouseArea.Location = New System.Drawing.Point(105, 248)
        Me.txtHouseArea.Name = "txtHouseArea"
        Me.txtHouseArea.Size = New System.Drawing.Size(125, 32)
        Me.txtHouseArea.TabIndex = 0
        Me.txtHouseArea.TabStop = False
        Me.txtHouseArea.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtHouseTax
        '
        Me.txtHouseTax.Location = New System.Drawing.Point(94, 320)
        Me.txtHouseTax.Name = "txtHouseTax"
        Me.txtHouseTax.Size = New System.Drawing.Size(147, 32)
        Me.txtHouseTax.TabIndex = 0
        Me.txtHouseTax.TabStop = False
        Me.txtHouseTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblLandTax
        '
        Me.lblLandTax.AutoSize = True
        Me.lblLandTax.Location = New System.Drawing.Point(331, 294)
        Me.lblLandTax.Name = "lblLandTax"
        Me.lblLandTax.Size = New System.Drawing.Size(98, 23)
        Me.lblLandTax.TabIndex = 0
        Me.lblLandTax.Text = "Land Tax"
        '
        'txtLandTax
        '
        Me.txtLandTax.Location = New System.Drawing.Point(303, 320)
        Me.txtLandTax.Name = "txtLandTax"
        Me.txtLandTax.Size = New System.Drawing.Size(151, 32)
        Me.txtLandTax.TabIndex = 0
        Me.txtLandTax.TabStop = False
        Me.txtLandTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblHouseTax
        '
        Me.lblHouseTax.AutoSize = True
        Me.lblHouseTax.Location = New System.Drawing.Point(112, 294)
        Me.lblHouseTax.Name = "lblHouseTax"
        Me.lblHouseTax.Size = New System.Drawing.Size(109, 23)
        Me.lblHouseTax.TabIndex = 0
        Me.lblHouseTax.Text = "House Tax"
        '
        'lblDiscount
        '
        Me.lblDiscount.AutoSize = True
        Me.lblDiscount.Location = New System.Drawing.Point(88, 369)
        Me.lblDiscount.Name = "lblDiscount"
        Me.lblDiscount.Size = New System.Drawing.Size(92, 23)
        Me.lblDiscount.TabIndex = 0
        Me.lblDiscount.Text = "Discount"
        '
        'txtDiscount
        '
        Me.txtDiscount.Location = New System.Drawing.Point(303, 366)
        Me.txtDiscount.Name = "txtDiscount"
        Me.txtDiscount.Size = New System.Drawing.Size(152, 32)
        Me.txtDiscount.TabIndex = 0
        Me.txtDiscount.TabStop = False
        Me.txtDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblPropertyTax_Year
        '
        Me.lblPropertyTax_Year.AutoSize = True
        Me.lblPropertyTax_Year.Location = New System.Drawing.Point(88, 419)
        Me.lblPropertyTax_Year.Name = "lblPropertyTax_Year"
        Me.lblPropertyTax_Year.Size = New System.Drawing.Size(194, 23)
        Me.lblPropertyTax_Year.TabIndex = 0
        Me.lblPropertyTax_Year.Text = "Property Tax / Year"
        '
        'txtPropertyTax_Year
        '
        Me.txtPropertyTax_Year.Location = New System.Drawing.Point(304, 416)
        Me.txtPropertyTax_Year.Name = "txtPropertyTax_Year"
        Me.txtPropertyTax_Year.Size = New System.Drawing.Size(152, 32)
        Me.txtPropertyTax_Year.TabIndex = 0
        Me.txtPropertyTax_Year.TabStop = False
        Me.txtPropertyTax_Year.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblPropertyTax_Month
        '
        Me.lblPropertyTax_Month.AutoSize = True
        Me.lblPropertyTax_Month.Location = New System.Drawing.Point(88, 464)
        Me.lblPropertyTax_Month.Name = "lblPropertyTax_Month"
        Me.lblPropertyTax_Month.Size = New System.Drawing.Size(211, 23)
        Me.lblPropertyTax_Month.TabIndex = 0
        Me.lblPropertyTax_Month.Text = "Property Tax / Month"
        '
        'txtPropertyTax_Month
        '
        Me.txtPropertyTax_Month.Location = New System.Drawing.Point(304, 461)
        Me.txtPropertyTax_Month.Name = "txtPropertyTax_Month"
        Me.txtPropertyTax_Month.Size = New System.Drawing.Size(152, 32)
        Me.txtPropertyTax_Month.TabIndex = 0
        Me.txtPropertyTax_Month.TabStop = False
        Me.txtPropertyTax_Month.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(457, 508)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(83, 39)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmCalculations
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(552, 554)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblPropertyTax_Month)
        Me.Controls.Add(Me.txtPropertyTax_Month)
        Me.Controls.Add(Me.lblPropertyTax_Year)
        Me.Controls.Add(Me.txtPropertyTax_Year)
        Me.Controls.Add(Me.lblDiscount)
        Me.Controls.Add(Me.txtDiscount)
        Me.Controls.Add(Me.txtHouseTax)
        Me.Controls.Add(Me.lblLandTax)
        Me.Controls.Add(Me.txtLandTax)
        Me.Controls.Add(Me.lblHouseTax)
        Me.Controls.Add(Me.txtHouseArea)
        Me.Controls.Add(Me.grpAddress)
        Me.Controls.Add(Me.lblLandArea)
        Me.Controls.Add(Me.txtLandArea)
        Me.Controls.Add(Me.lblHouseArea)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.txtName)
        Me.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCalculations"
        Me.ShowIcon = False
        Me.Text = "Municipality - Calculations"
        Me.grpAddress.ResumeLayout(False)
        Me.grpAddress.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtName As TextBox
    Friend WithEvents lblName As Label
    Friend WithEvents btnReturn As Button
    Friend WithEvents lblHouseArea As Label
    Friend WithEvents txtLandArea As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents lblLandArea As Label
    Friend WithEvents grpAddress As GroupBox
    Friend WithEvents txtHouseArea As TextBox
    Friend WithEvents txtHouseTax As TextBox
    Friend WithEvents lblLandTax As Label
    Friend WithEvents txtLandTax As TextBox
    Friend WithEvents lblHouseTax As Label
    Friend WithEvents lblDiscount As Label
    Friend WithEvents txtDiscount As TextBox
    Friend WithEvents lblPropertyTax_Year As Label
    Friend WithEvents txtPropertyTax_Year As TextBox
    Friend WithEvents lblPropertyTax_Month As Label
    Friend WithEvents txtPropertyTax_Month As TextBox
    Friend WithEvents btnExit As Button
End Class
