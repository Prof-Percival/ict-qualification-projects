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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.grpStudentInformation = New System.Windows.Forms.GroupBox()
        Me.mskPhone = New System.Windows.Forms.MaskedTextBox()
        Me.txtMajor = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.grpTextColor = New System.Windows.Forms.GroupBox()
        Me.radRed = New System.Windows.Forms.RadioButton()
        Me.radBlue = New System.Windows.Forms.RadioButton()
        Me.radGreen = New System.Windows.Forms.RadioButton()
        Me.radMagenta = New System.Windows.Forms.RadioButton()
        Me.radBlack = New System.Windows.Forms.RadioButton()
        Me.txtOutput = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.chkMessageVisible = New System.Windows.Forms.CheckBox()
        Me.picImage = New System.Windows.Forms.PictureBox()
        Me.grpStudentInformation.SuspendLayout()
        Me.grpTextColor.SuspendLayout()
        CType(Me.picImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpStudentInformation
        '
        Me.grpStudentInformation.Controls.Add(Me.mskPhone)
        Me.grpStudentInformation.Controls.Add(Me.txtMajor)
        Me.grpStudentInformation.Controls.Add(Me.Label1)
        Me.grpStudentInformation.Controls.Add(Me.txtName)
        Me.grpStudentInformation.Controls.Add(Me.Label2)
        Me.grpStudentInformation.Controls.Add(Me.Label3)
        Me.grpStudentInformation.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.grpStudentInformation.Location = New System.Drawing.Point(34, 12)
        Me.grpStudentInformation.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.grpStudentInformation.Name = "grpStudentInformation"
        Me.grpStudentInformation.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.grpStudentInformation.Size = New System.Drawing.Size(326, 156)
        Me.grpStudentInformation.TabIndex = 0
        Me.grpStudentInformation.TabStop = False
        Me.grpStudentInformation.Text = "Student Information"
        '
        'mskPhone
        '
        Me.mskPhone.Location = New System.Drawing.Point(84, 105)
        Me.mskPhone.Mask = "(999) 000-0000"
        Me.mskPhone.Name = "mskPhone"
        Me.mskPhone.Size = New System.Drawing.Size(225, 32)
        Me.mskPhone.TabIndex = 2
        '
        'txtMajor
        '
        Me.txtMajor.Location = New System.Drawing.Point(84, 67)
        Me.txtMajor.Name = "txtMajor"
        Me.txtMajor.Size = New System.Drawing.Size(225, 32)
        Me.txtMajor.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label1.Location = New System.Drawing.Point(7, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name:"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(84, 28)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(225, 32)
        Me.txtName.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label2.Location = New System.Drawing.Point(7, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 23)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Major:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label3.Location = New System.Drawing.Point(7, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 23)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Phone:"
        '
        'grpTextColor
        '
        Me.grpTextColor.Controls.Add(Me.radRed)
        Me.grpTextColor.Controls.Add(Me.radBlue)
        Me.grpTextColor.Controls.Add(Me.radGreen)
        Me.grpTextColor.Controls.Add(Me.radMagenta)
        Me.grpTextColor.Controls.Add(Me.radBlack)
        Me.grpTextColor.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.grpTextColor.Location = New System.Drawing.Point(368, 12)
        Me.grpTextColor.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.grpTextColor.Name = "grpTextColor"
        Me.grpTextColor.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.grpTextColor.Size = New System.Drawing.Size(130, 156)
        Me.grpTextColor.TabIndex = 0
        Me.grpTextColor.TabStop = False
        Me.grpTextColor.Text = "Text Color"
        '
        'radRed
        '
        Me.radRed.AutoSize = True
        Me.radRed.Cursor = System.Windows.Forms.Cursors.Hand
        Me.radRed.ForeColor = System.Drawing.SystemColors.Desktop
        Me.radRed.Location = New System.Drawing.Point(7, 48)
        Me.radRed.Name = "radRed"
        Me.radRed.Size = New System.Drawing.Size(66, 27)
        Me.radRed.TabIndex = 0
        Me.radRed.Text = "Red"
        Me.radRed.UseVisualStyleBackColor = True
        '
        'radBlue
        '
        Me.radBlue.AutoSize = True
        Me.radBlue.Cursor = System.Windows.Forms.Cursors.Hand
        Me.radBlue.ForeColor = System.Drawing.SystemColors.Desktop
        Me.radBlue.Location = New System.Drawing.Point(7, 72)
        Me.radBlue.Name = "radBlue"
        Me.radBlue.Size = New System.Drawing.Size(73, 27)
        Me.radBlue.TabIndex = 0
        Me.radBlue.Text = "Blue"
        Me.radBlue.UseVisualStyleBackColor = True
        '
        'radGreen
        '
        Me.radGreen.AutoSize = True
        Me.radGreen.Cursor = System.Windows.Forms.Cursors.Hand
        Me.radGreen.ForeColor = System.Drawing.SystemColors.Desktop
        Me.radGreen.Location = New System.Drawing.Point(7, 96)
        Me.radGreen.Name = "radGreen"
        Me.radGreen.Size = New System.Drawing.Size(88, 27)
        Me.radGreen.TabIndex = 0
        Me.radGreen.Text = "Green"
        Me.radGreen.UseVisualStyleBackColor = True
        '
        'radMagenta
        '
        Me.radMagenta.AutoSize = True
        Me.radMagenta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.radMagenta.ForeColor = System.Drawing.SystemColors.Desktop
        Me.radMagenta.Location = New System.Drawing.Point(7, 120)
        Me.radMagenta.Name = "radMagenta"
        Me.radMagenta.Size = New System.Drawing.Size(113, 27)
        Me.radMagenta.TabIndex = 0
        Me.radMagenta.Text = "Magenta"
        Me.radMagenta.UseVisualStyleBackColor = True
        '
        'radBlack
        '
        Me.radBlack.AutoSize = True
        Me.radBlack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.radBlack.ForeColor = System.Drawing.SystemColors.Desktop
        Me.radBlack.Location = New System.Drawing.Point(7, 24)
        Me.radBlack.Name = "radBlack"
        Me.radBlack.Size = New System.Drawing.Size(83, 27)
        Me.radBlack.TabIndex = 0
        Me.radBlack.Text = "Black"
        Me.radBlack.UseVisualStyleBackColor = True
        '
        'txtOutput
        '
        Me.txtOutput.Location = New System.Drawing.Point(121, 188)
        Me.txtOutput.Multiline = True
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.ReadOnly = True
        Me.txtOutput.Size = New System.Drawing.Size(377, 125)
        Me.txtOutput.TabIndex = 0
        Me.txtOutput.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(34, 191)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 23)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Output:"
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(191, 395)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(94, 38)
        Me.btnDisplay.TabIndex = 3
        Me.btnDisplay.Text = "&Display"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(306, 395)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(94, 38)
        Me.btnReset.TabIndex = 4
        Me.btnReset.Text = "&Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(423, 395)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(94, 38)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'chkMessageVisible
        '
        Me.chkMessageVisible.AutoSize = True
        Me.chkMessageVisible.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chkMessageVisible.Location = New System.Drawing.Point(180, 340)
        Me.chkMessageVisible.Name = "chkMessageVisible"
        Me.chkMessageVisible.Size = New System.Drawing.Size(179, 27)
        Me.chkMessageVisible.TabIndex = 0
        Me.chkMessageVisible.TabStop = False
        Me.chkMessageVisible.Text = "Message Visible"
        Me.chkMessageVisible.UseVisualStyleBackColor = True
        '
        'picImage
        '
        Me.picImage.Image = CType(resources.GetObject("picImage.Image"), System.Drawing.Image)
        Me.picImage.Location = New System.Drawing.Point(12, 324)
        Me.picImage.Name = "picImage"
        Me.picImage.Size = New System.Drawing.Size(153, 160)
        Me.picImage.TabIndex = 6
        Me.picImage.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FloralWhite
        Me.ClientSize = New System.Drawing.Size(542, 489)
        Me.Controls.Add(Me.picImage)
        Me.Controls.Add(Me.chkMessageVisible)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtOutput)
        Me.Controls.Add(Me.grpTextColor)
        Me.Controls.Add(Me.grpStudentInformation)
        Me.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "                                      Student Information"
        Me.grpStudentInformation.ResumeLayout(False)
        Me.grpStudentInformation.PerformLayout()
        Me.grpTextColor.ResumeLayout(False)
        Me.grpTextColor.PerformLayout()
        CType(Me.picImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grpStudentInformation As GroupBox
    Friend WithEvents mskPhone As MaskedTextBox
    Friend WithEvents txtMajor As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents grpTextColor As GroupBox
    Friend WithEvents radRed As RadioButton
    Friend WithEvents radBlue As RadioButton
    Friend WithEvents radGreen As RadioButton
    Friend WithEvents radMagenta As RadioButton
    Friend WithEvents radBlack As RadioButton
    Friend WithEvents txtOutput As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnDisplay As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents chkMessageVisible As CheckBox
    Friend WithEvents picImage As PictureBox
End Class
