<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDetailsApp
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblMajor = New System.Windows.Forms.Label()
        Me.txtMajor = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblCName = New System.Windows.Forms.Label()
        Me.lblCompanyName = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(35, 43)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(122, 24)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "My Name Is:"
        '
        'lblMajor
        '
        Me.lblMajor.AutoSize = True
        Me.lblMajor.Location = New System.Drawing.Point(35, 115)
        Me.lblMajor.Name = "lblMajor"
        Me.lblMajor.Size = New System.Drawing.Size(120, 24)
        Me.lblMajor.TabIndex = 1
        Me.lblMajor.Text = "My Major Is:"
        '
        'txtMajor
        '
        Me.txtMajor.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtMajor.Location = New System.Drawing.Point(172, 110)
        Me.txtMajor.Name = "txtMajor"
        Me.txtMajor.Size = New System.Drawing.Size(255, 34)
        Me.txtMajor.TabIndex = 2
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtName.Location = New System.Drawing.Point(172, 38)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(255, 34)
        Me.txtName.TabIndex = 3
        '
        'btnDisplay
        '
        Me.btnDisplay.BackColor = System.Drawing.Color.Silver
        Me.btnDisplay.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnDisplay.Location = New System.Drawing.Point(120, 186)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(112, 44)
        Me.btnDisplay.TabIndex = 4
        Me.btnDisplay.Text = "&Display"
        Me.btnDisplay.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Silver
        Me.btnExit.Location = New System.Drawing.Point(296, 187)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(112, 44)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'lblCName
        '
        Me.lblCName.AutoSize = True
        Me.lblCName.ForeColor = System.Drawing.Color.Red
        Me.lblCName.Location = New System.Drawing.Point(452, 206)
        Me.lblCName.Name = "lblCName"
        Me.lblCName.Size = New System.Drawing.Size(0, 24)
        Me.lblCName.TabIndex = 6
        '
        'lblCompanyName
        '
        Me.lblCompanyName.AutoSize = True
        Me.lblCompanyName.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblCompanyName.ForeColor = System.Drawing.Color.Red
        Me.lblCompanyName.Location = New System.Drawing.Point(401, 234)
        Me.lblCompanyName.Name = "lblCompanyName"
        Me.lblCompanyName.Size = New System.Drawing.Size(124, 19)
        Me.lblCompanyName.TabIndex = 7
        Me.lblCompanyName.Text = "© PCP Software"
        '
        'frmDetailsApp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(521, 256)
        Me.Controls.Add(Me.lblCompanyName)
        Me.Controls.Add(Me.lblCName)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtMajor)
        Me.Controls.Add(Me.lblMajor)
        Me.Controls.Add(Me.lblName)
        Me.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDetailsApp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Details App"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents lblMajor As Label
    Friend WithEvents txtMajor As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents btnDisplay As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblCName As Label
    Friend WithEvents lblCompanyName As Label
End Class
