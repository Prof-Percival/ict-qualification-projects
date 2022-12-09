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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtGoodsValue = New System.Windows.Forms.TextBox()
        Me.grpContainerSize = New System.Windows.Forms.GroupBox()
        Me.radLarge = New System.Windows.Forms.RadioButton()
        Me.radMedium = New System.Windows.Forms.RadioButton()
        Me.radSmall = New System.Windows.Forms.RadioButton()
        Me.lstOutput = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.picContainers = New System.Windows.Forms.PictureBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.grpContainerSize.SuspendLayout()
        CType(Me.picContainers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(58, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(163, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Value of Goods"
        '
        'txtGoodsValue
        '
        Me.txtGoodsValue.Location = New System.Drawing.Point(227, 58)
        Me.txtGoodsValue.Name = "txtGoodsValue"
        Me.txtGoodsValue.Size = New System.Drawing.Size(194, 32)
        Me.txtGoodsValue.TabIndex = 0
        Me.txtGoodsValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'grpContainerSize
        '
        Me.grpContainerSize.Controls.Add(Me.radLarge)
        Me.grpContainerSize.Controls.Add(Me.radMedium)
        Me.grpContainerSize.Controls.Add(Me.radSmall)
        Me.grpContainerSize.ForeColor = System.Drawing.Color.MediumBlue
        Me.grpContainerSize.Location = New System.Drawing.Point(57, 96)
        Me.grpContainerSize.Name = "grpContainerSize"
        Me.grpContainerSize.Size = New System.Drawing.Size(188, 137)
        Me.grpContainerSize.TabIndex = 0
        Me.grpContainerSize.TabStop = False
        Me.grpContainerSize.Text = "Container Size"
        '
        'radLarge
        '
        Me.radLarge.AutoSize = True
        Me.radLarge.ForeColor = System.Drawing.SystemColors.Desktop
        Me.radLarge.Location = New System.Drawing.Point(6, 101)
        Me.radLarge.Name = "radLarge"
        Me.radLarge.Size = New System.Drawing.Size(89, 29)
        Me.radLarge.TabIndex = 0
        Me.radLarge.Text = "Large"
        Me.radLarge.UseVisualStyleBackColor = True
        '
        'radMedium
        '
        Me.radMedium.AutoSize = True
        Me.radMedium.ForeColor = System.Drawing.SystemColors.Desktop
        Me.radMedium.Location = New System.Drawing.Point(6, 66)
        Me.radMedium.Name = "radMedium"
        Me.radMedium.Size = New System.Drawing.Size(112, 29)
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
        Me.radSmall.Size = New System.Drawing.Size(90, 29)
        Me.radSmall.TabIndex = 0
        Me.radSmall.Text = "Small"
        Me.radSmall.UseVisualStyleBackColor = True
        '
        'lstOutput
        '
        Me.lstOutput.Font = New System.Drawing.Font("Verdana", 11.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lstOutput.FormattingEnabled = True
        Me.lstOutput.ItemHeight = 23
        Me.lstOutput.Location = New System.Drawing.Point(46, 284)
        Me.lstOutput.Name = "lstOutput"
        Me.lstOutput.Size = New System.Drawing.Size(436, 211)
        Me.lstOutput.TabIndex = 0
        Me.lstOutput.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Verdana", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.Label2.Location = New System.Drawing.Point(69, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(387, 38)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Shipping And Clearing"
        '
        'picContainers
        '
        Me.picContainers.Location = New System.Drawing.Point(251, 96)
        Me.picContainers.Name = "picContainers"
        Me.picContainers.Size = New System.Drawing.Size(217, 137)
        Me.picContainers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picContainers.TabIndex = 1
        Me.picContainers.TabStop = False
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(46, 509)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(80, 35)
        Me.btnClear.TabIndex = 2
        Me.btnClear.Text = "C&lear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(402, 509)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(80, 35)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(181, 239)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(114, 35)
        Me.btnCalculate.TabIndex = 1
        Me.btnCalculate.Text = "&Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(528, 556)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.picContainers)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lstOutput)
        Me.Controls.Add(Me.grpContainerSize)
        Me.Controls.Add(Me.txtGoodsValue)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.Text = "EL Shipping & Clearing"
        Me.grpContainerSize.ResumeLayout(False)
        Me.grpContainerSize.PerformLayout()
        CType(Me.picContainers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtGoodsValue As TextBox
    Friend WithEvents grpContainerSize As GroupBox
    Friend WithEvents radLarge As RadioButton
    Friend WithEvents radMedium As RadioButton
    Friend WithEvents radSmall As RadioButton
    Friend WithEvents lstOutput As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents picContainers As PictureBox
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnCalculate As Button
End Class
