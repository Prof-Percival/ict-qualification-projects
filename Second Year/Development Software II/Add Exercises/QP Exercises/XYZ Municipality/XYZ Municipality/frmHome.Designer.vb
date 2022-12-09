<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHome
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
        Me.txtHouseArea = New System.Windows.Forms.TextBox()
        Me.lblLandArea = New System.Windows.Forms.Label()
        Me.txtLandArea = New System.Windows.Forms.TextBox()
        Me.lblHouseArea = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblProvince = New System.Windows.Forms.Label()
        Me.lblCity = New System.Windows.Forms.Label()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.lblSuburb = New System.Windows.Forms.Label()
        Me.lblStreetName = New System.Windows.Forms.Label()
        Me.lblPostalCode = New System.Windows.Forms.Label()
        Me.txtPostalCode = New System.Windows.Forms.TextBox()
        Me.txtSuburb = New System.Windows.Forms.TextBox()
        Me.txtStreetName = New System.Windows.Forms.TextBox()
        Me.grpAddress = New System.Windows.Forms.GroupBox()
        Me.cboProvince = New System.Windows.Forms.ComboBox()
        Me.lblHouseAge = New System.Windows.Forms.Label()
        Me.txtHouseAge = New System.Windows.Forms.TextBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblDetailsCapture = New System.Windows.Forms.Label()
        Me.grpAddress.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtHouseArea
        '
        Me.txtHouseArea.Location = New System.Drawing.Point(93, 365)
        Me.txtHouseArea.Name = "txtHouseArea"
        Me.txtHouseArea.Size = New System.Drawing.Size(125, 32)
        Me.txtHouseArea.TabIndex = 6
        Me.txtHouseArea.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblLandArea
        '
        Me.lblLandArea.AutoSize = True
        Me.lblLandArea.Location = New System.Drawing.Point(316, 339)
        Me.lblLandArea.Name = "lblLandArea"
        Me.lblLandArea.Size = New System.Drawing.Size(152, 23)
        Me.lblLandArea.TabIndex = 0
        Me.lblLandArea.Text = "Land Area (m²)"
        '
        'txtLandArea
        '
        Me.txtLandArea.Location = New System.Drawing.Point(324, 365)
        Me.txtLandArea.Name = "txtLandArea"
        Me.txtLandArea.Size = New System.Drawing.Size(125, 32)
        Me.txtLandArea.TabIndex = 7
        Me.txtLandArea.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblHouseArea
        '
        Me.lblHouseArea.AutoSize = True
        Me.lblHouseArea.Location = New System.Drawing.Point(77, 339)
        Me.lblHouseArea.Name = "lblHouseArea"
        Me.lblHouseArea.Size = New System.Drawing.Size(163, 23)
        Me.lblHouseArea.TabIndex = 0
        Me.lblHouseArea.Text = "House Area (m²)"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(71, 60)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(157, 23)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Name of Owner"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(234, 57)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(237, 32)
        Me.txtName.TabIndex = 0
        '
        'lblProvince
        '
        Me.lblProvince.AutoSize = True
        Me.lblProvince.ForeColor = System.Drawing.SystemColors.Desktop
        Me.lblProvince.Location = New System.Drawing.Point(6, 159)
        Me.lblProvince.Name = "lblProvince"
        Me.lblProvince.Size = New System.Drawing.Size(90, 23)
        Me.lblProvince.TabIndex = 0
        Me.lblProvince.Text = "Province"
        '
        'lblCity
        '
        Me.lblCity.AutoSize = True
        Me.lblCity.ForeColor = System.Drawing.SystemColors.Desktop
        Me.lblCity.Location = New System.Drawing.Point(6, 118)
        Me.lblCity.Name = "lblCity"
        Me.lblCity.Size = New System.Drawing.Size(49, 23)
        Me.lblCity.TabIndex = 0
        Me.lblCity.Text = "City"
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(169, 115)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(201, 32)
        Me.txtCity.TabIndex = 3
        '
        'lblSuburb
        '
        Me.lblSuburb.AutoSize = True
        Me.lblSuburb.ForeColor = System.Drawing.SystemColors.Desktop
        Me.lblSuburb.Location = New System.Drawing.Point(6, 77)
        Me.lblSuburb.Name = "lblSuburb"
        Me.lblSuburb.Size = New System.Drawing.Size(78, 23)
        Me.lblSuburb.TabIndex = 0
        Me.lblSuburb.Text = "Suburb"
        '
        'lblStreetName
        '
        Me.lblStreetName.AutoSize = True
        Me.lblStreetName.ForeColor = System.Drawing.SystemColors.Desktop
        Me.lblStreetName.Location = New System.Drawing.Point(6, 34)
        Me.lblStreetName.Name = "lblStreetName"
        Me.lblStreetName.Size = New System.Drawing.Size(129, 23)
        Me.lblStreetName.TabIndex = 0
        Me.lblStreetName.Text = "Street Name"
        '
        'lblPostalCode
        '
        Me.lblPostalCode.AutoSize = True
        Me.lblPostalCode.ForeColor = System.Drawing.SystemColors.Desktop
        Me.lblPostalCode.Location = New System.Drawing.Point(6, 199)
        Me.lblPostalCode.Name = "lblPostalCode"
        Me.lblPostalCode.Size = New System.Drawing.Size(118, 23)
        Me.lblPostalCode.TabIndex = 0
        Me.lblPostalCode.Text = "Postal Code"
        '
        'txtPostalCode
        '
        Me.txtPostalCode.Location = New System.Drawing.Point(169, 196)
        Me.txtPostalCode.Name = "txtPostalCode"
        Me.txtPostalCode.Size = New System.Drawing.Size(95, 32)
        Me.txtPostalCode.TabIndex = 5
        Me.txtPostalCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtSuburb
        '
        Me.txtSuburb.Location = New System.Drawing.Point(169, 74)
        Me.txtSuburb.Name = "txtSuburb"
        Me.txtSuburb.Size = New System.Drawing.Size(201, 32)
        Me.txtSuburb.TabIndex = 2
        '
        'txtStreetName
        '
        Me.txtStreetName.Location = New System.Drawing.Point(169, 31)
        Me.txtStreetName.Name = "txtStreetName"
        Me.txtStreetName.Size = New System.Drawing.Size(237, 32)
        Me.txtStreetName.TabIndex = 1
        '
        'grpAddress
        '
        Me.grpAddress.Controls.Add(Me.cboProvince)
        Me.grpAddress.Controls.Add(Me.txtStreetName)
        Me.grpAddress.Controls.Add(Me.txtSuburb)
        Me.grpAddress.Controls.Add(Me.lblProvince)
        Me.grpAddress.Controls.Add(Me.lblPostalCode)
        Me.grpAddress.Controls.Add(Me.txtCity)
        Me.grpAddress.Controls.Add(Me.txtPostalCode)
        Me.grpAddress.Controls.Add(Me.lblCity)
        Me.grpAddress.Controls.Add(Me.lblStreetName)
        Me.grpAddress.Controls.Add(Me.lblSuburb)
        Me.grpAddress.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grpAddress.Location = New System.Drawing.Point(71, 95)
        Me.grpAddress.Name = "grpAddress"
        Me.grpAddress.Size = New System.Drawing.Size(413, 238)
        Me.grpAddress.TabIndex = 1
        Me.grpAddress.TabStop = False
        Me.grpAddress.Text = "Address"
        '
        'cboProvince
        '
        Me.cboProvince.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboProvince.FormattingEnabled = True
        Me.cboProvince.IntegralHeight = False
        Me.cboProvince.Location = New System.Drawing.Point(169, 156)
        Me.cboProvince.Name = "cboProvince"
        Me.cboProvince.Size = New System.Drawing.Size(201, 31)
        Me.cboProvince.TabIndex = 4
        '
        'lblHouseAge
        '
        Me.lblHouseAge.AutoSize = True
        Me.lblHouseAge.ForeColor = System.Drawing.SystemColors.Desktop
        Me.lblHouseAge.Location = New System.Drawing.Point(78, 411)
        Me.lblHouseAge.Name = "lblHouseAge"
        Me.lblHouseAge.Size = New System.Drawing.Size(182, 23)
        Me.lblHouseAge.TabIndex = 8
        Me.lblHouseAge.Text = "House Age (Years)"
        '
        'txtHouseAge
        '
        Me.txtHouseAge.Location = New System.Drawing.Point(266, 407)
        Me.txtHouseAge.Name = "txtHouseAge"
        Me.txtHouseAge.Size = New System.Drawing.Size(95, 32)
        Me.txtHouseAge.TabIndex = 8
        Me.txtHouseAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(12, 451)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(84, 37)
        Me.btnClear.TabIndex = 9
        Me.btnClear.Text = "C&lear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(228, 451)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(107, 40)
        Me.btnCalculate.TabIndex = 10
        Me.btnCalculate.Text = "&Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(464, 451)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(71, 37)
        Me.btnExit.TabIndex = 11
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblDetailsCapture
        '
        Me.lblDetailsCapture.AutoSize = True
        Me.lblDetailsCapture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDetailsCapture.Font = New System.Drawing.Font("Wide Latin", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.lblDetailsCapture.ForeColor = System.Drawing.Color.Teal
        Me.lblDetailsCapture.Location = New System.Drawing.Point(56, 8)
        Me.lblDetailsCapture.Name = "lblDetailsCapture"
        Me.lblDetailsCapture.Size = New System.Drawing.Size(427, 39)
        Me.lblDetailsCapture.TabIndex = 0
        Me.lblDetailsCapture.Text = "Details Capture"
        '
        'frmHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(547, 499)
        Me.Controls.Add(Me.lblDetailsCapture)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lblHouseAge)
        Me.Controls.Add(Me.txtHouseAge)
        Me.Controls.Add(Me.grpAddress)
        Me.Controls.Add(Me.txtHouseArea)
        Me.Controls.Add(Me.lblLandArea)
        Me.Controls.Add(Me.txtLandArea)
        Me.Controls.Add(Me.lblHouseArea)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.txtName)
        Me.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.Name = "frmHome"
        Me.ShowIcon = False
        Me.Text = "Municipality - Home"
        Me.grpAddress.ResumeLayout(False)
        Me.grpAddress.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtHouseArea As TextBox
    Friend WithEvents lblLandArea As Label
    Friend WithEvents txtLandArea As TextBox
    Friend WithEvents lblHouseArea As Label
    Friend WithEvents lblName As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblProvince As Label
    Friend WithEvents lblCity As Label
    Friend WithEvents txtCity As TextBox
    Friend WithEvents lblSuburb As Label
    Friend WithEvents lblStreetName As Label
    Friend WithEvents lblPostalCode As Label
    Friend WithEvents txtPostalCode As TextBox
    Friend WithEvents txtSuburb As TextBox
    Friend WithEvents txtStreetName As TextBox
    Friend WithEvents grpAddress As GroupBox
    Friend WithEvents cboProvince As ComboBox
    Friend WithEvents lblHouseAge As Label
    Friend WithEvents txtHouseAge As TextBox
    Friend WithEvents btnClear As Button
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblDetailsCapture As Label
End Class
