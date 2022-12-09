<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPasma
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.grpTShirtSize = New System.Windows.Forms.GroupBox()
        Me.radLarge = New System.Windows.Forms.RadioButton()
        Me.radMedium = New System.Windows.Forms.RadioButton()
        Me.radSmall = New System.Windows.Forms.RadioButton()
        Me.grpAdditionalColours = New System.Windows.Forms.GroupBox()
        Me.chkMagenta = New System.Windows.Forms.CheckBox()
        Me.chkRed = New System.Windows.Forms.CheckBox()
        Me.chkBlack = New System.Windows.Forms.CheckBox()
        Me.chkNameEngraving = New System.Windows.Forms.CheckBox()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lstOutput = New System.Windows.Forms.ListBox()
        Me.grpTShirtSize.SuspendLayout()
        Me.grpAdditionalColours.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 16.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label1.Location = New System.Drawing.Point(32, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(310, 34)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Pasma Political Party"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(145, 23)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Student Name"
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(115, 242)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(106, 40)
        Me.btnCalculate.TabIndex = 1
        Me.btnCalculate.Text = "&Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(163, 43)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(189, 32)
        Me.txtName.TabIndex = 0
        '
        'grpTShirtSize
        '
        Me.grpTShirtSize.Controls.Add(Me.radLarge)
        Me.grpTShirtSize.Controls.Add(Me.radMedium)
        Me.grpTShirtSize.Controls.Add(Me.radSmall)
        Me.grpTShirtSize.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.grpTShirtSize.Location = New System.Drawing.Point(12, 87)
        Me.grpTShirtSize.Name = "grpTShirtSize"
        Me.grpTShirtSize.Size = New System.Drawing.Size(145, 123)
        Me.grpTShirtSize.TabIndex = 0
        Me.grpTShirtSize.TabStop = False
        Me.grpTShirtSize.Text = "T-Shirt Size"
        '
        'radLarge
        '
        Me.radLarge.AutoSize = True
        Me.radLarge.ForeColor = System.Drawing.SystemColors.Desktop
        Me.radLarge.Location = New System.Drawing.Point(6, 88)
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
        Me.radMedium.Location = New System.Drawing.Point(6, 58)
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
        Me.radSmall.Location = New System.Drawing.Point(6, 28)
        Me.radSmall.Name = "radSmall"
        Me.radSmall.Size = New System.Drawing.Size(85, 27)
        Me.radSmall.TabIndex = 0
        Me.radSmall.Text = "Small"
        Me.radSmall.UseVisualStyleBackColor = True
        '
        'grpAdditionalColours
        '
        Me.grpAdditionalColours.Controls.Add(Me.chkMagenta)
        Me.grpAdditionalColours.Controls.Add(Me.chkRed)
        Me.grpAdditionalColours.Controls.Add(Me.chkBlack)
        Me.grpAdditionalColours.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.grpAdditionalColours.Location = New System.Drawing.Point(163, 87)
        Me.grpAdditionalColours.Name = "grpAdditionalColours"
        Me.grpAdditionalColours.Size = New System.Drawing.Size(205, 123)
        Me.grpAdditionalColours.TabIndex = 0
        Me.grpAdditionalColours.TabStop = False
        Me.grpAdditionalColours.Text = "Additional Colours"
        '
        'chkMagenta
        '
        Me.chkMagenta.AutoSize = True
        Me.chkMagenta.ForeColor = System.Drawing.SystemColors.Desktop
        Me.chkMagenta.Location = New System.Drawing.Point(6, 92)
        Me.chkMagenta.Name = "chkMagenta"
        Me.chkMagenta.Size = New System.Drawing.Size(114, 27)
        Me.chkMagenta.TabIndex = 0
        Me.chkMagenta.TabStop = False
        Me.chkMagenta.Text = "Magenta"
        Me.chkMagenta.UseVisualStyleBackColor = True
        '
        'chkRed
        '
        Me.chkRed.AutoSize = True
        Me.chkRed.ForeColor = System.Drawing.SystemColors.Desktop
        Me.chkRed.Location = New System.Drawing.Point(6, 59)
        Me.chkRed.Name = "chkRed"
        Me.chkRed.Size = New System.Drawing.Size(67, 27)
        Me.chkRed.TabIndex = 0
        Me.chkRed.TabStop = False
        Me.chkRed.Text = "Red"
        Me.chkRed.UseVisualStyleBackColor = True
        '
        'chkBlack
        '
        Me.chkBlack.AutoSize = True
        Me.chkBlack.ForeColor = System.Drawing.SystemColors.Desktop
        Me.chkBlack.Location = New System.Drawing.Point(6, 31)
        Me.chkBlack.Name = "chkBlack"
        Me.chkBlack.Size = New System.Drawing.Size(84, 27)
        Me.chkBlack.TabIndex = 0
        Me.chkBlack.TabStop = False
        Me.chkBlack.Text = "Black"
        Me.chkBlack.UseVisualStyleBackColor = True
        '
        'chkNameEngraving
        '
        Me.chkNameEngraving.AutoSize = True
        Me.chkNameEngraving.ForeColor = System.Drawing.SystemColors.Desktop
        Me.chkNameEngraving.Location = New System.Drawing.Point(83, 213)
        Me.chkNameEngraving.Name = "chkNameEngraving"
        Me.chkNameEngraving.Size = New System.Drawing.Size(190, 27)
        Me.chkNameEngraving.TabIndex = 0
        Me.chkNameEngraving.TabStop = False
        Me.chkNameEngraving.Text = "Name Engraving"
        Me.chkNameEngraving.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(18, 468)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(69, 38)
        Me.btnNext.TabIndex = 2
        Me.btnNext.Text = "&Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(299, 468)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(69, 38)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lstOutput
        '
        Me.lstOutput.FormattingEnabled = True
        Me.lstOutput.ItemHeight = 23
        Me.lstOutput.Location = New System.Drawing.Point(18, 288)
        Me.lstOutput.Name = "lstOutput"
        Me.lstOutput.Size = New System.Drawing.Size(350, 165)
        Me.lstOutput.TabIndex = 0
        Me.lstOutput.TabStop = False
        '
        'frmPasma
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(386, 512)
        Me.Controls.Add(Me.lstOutput)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.chkNameEngraving)
        Me.Controls.Add(Me.grpAdditionalColours)
        Me.Controls.Add(Me.grpTShirtSize)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "frmPasma"
        Me.Text = "Pasma Political Party"
        Me.grpTShirtSize.ResumeLayout(False)
        Me.grpTShirtSize.PerformLayout()
        Me.grpAdditionalColours.ResumeLayout(False)
        Me.grpAdditionalColours.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents txtName As TextBox
    Friend WithEvents grpTShirtSize As GroupBox
    Friend WithEvents radLarge As RadioButton
    Friend WithEvents radMedium As RadioButton
    Friend WithEvents radSmall As RadioButton
    Friend WithEvents grpAdditionalColours As GroupBox
    Friend WithEvents chkMagenta As CheckBox
    Friend WithEvents chkRed As CheckBox
    Friend WithEvents chkBlack As CheckBox
    Friend WithEvents chkNameEngraving As CheckBox
    Friend WithEvents btnNext As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lstOutput As ListBox
End Class
