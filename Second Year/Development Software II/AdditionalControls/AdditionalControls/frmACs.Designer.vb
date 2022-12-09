<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmACs
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
        Me.components = New System.ComponentModel.Container()
        Me.cboTitle = New System.Windows.Forms.ComboBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtFullName = New System.Windows.Forms.TextBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtSeconds = New System.Windows.Forms.TextBox()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tmrWatch = New System.Windows.Forms.Timer(Me.components)
        Me.ttpTooltip = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnShowFullName = New System.Windows.Forms.Button()
        Me.ttbName = New System.Windows.Forms.TextBox()
        Me.ttbFullName = New System.Windows.Forms.TextBox()
        Me.ttbSurname = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.vsbAC = New System.Windows.Forms.VScrollBar()
        Me.SuspendLayout()
        '
        'cboTitle
        '
        Me.cboTitle.FormattingEnabled = True
        Me.cboTitle.Location = New System.Drawing.Point(28, 55)
        Me.cboTitle.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cboTitle.Name = "cboTitle"
        Me.cboTitle.Size = New System.Drawing.Size(80, 31)
        Me.cboTitle.TabIndex = 0
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(45, 29)
        Me.lblName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(53, 23)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Title"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(116, 55)
        Me.txtName.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(248, 32)
        Me.txtName.TabIndex = 1
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(83, 101)
        Me.btnDisplay.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(193, 33)
        Me.btnDisplay.TabIndex = 2
        Me.btnDisplay.Text = "&Display Full Name"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(191, 29)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 23)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Name"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(279, 226)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(85, 33)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'txtFullName
        '
        Me.txtFullName.Location = New System.Drawing.Point(28, 170)
        Me.txtFullName.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtFullName.Name = "txtFullName"
        Me.txtFullName.Size = New System.Drawing.Size(336, 32)
        Me.txtFullName.TabIndex = 0
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(13, 226)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(85, 33)
        Me.btnClear.TabIndex = 3
        Me.btnClear.Text = "&Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(132, 144)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 23)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Full Name"
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(450, 57)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(215, 40)
        Me.btnStart.TabIndex = 0
        Me.btnStart.TabStop = False
        Me.btnStart.Text = "&Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(450, 121)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 23)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Seconds"
        '
        'txtSeconds
        '
        Me.txtSeconds.Location = New System.Drawing.Point(540, 116)
        Me.txtSeconds.Name = "txtSeconds"
        Me.txtSeconds.Size = New System.Drawing.Size(125, 32)
        Me.txtSeconds.TabIndex = 0
        Me.txtSeconds.TabStop = False
        '
        'btnStop
        '
        Me.btnStop.Location = New System.Drawing.Point(450, 172)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(215, 40)
        Me.btnStop.TabIndex = 0
        Me.btnStop.TabStop = False
        Me.btnStop.Text = "S&top"
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(486, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(145, 28)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Stop Watch"
        '
        'tmrWatch
        '
        Me.tmrWatch.Interval = 1
        '
        'btnShowFullName
        '
        Me.btnShowFullName.Location = New System.Drawing.Point(249, 355)
        Me.btnShowFullName.Name = "btnShowFullName"
        Me.btnShowFullName.Size = New System.Drawing.Size(229, 45)
        Me.btnShowFullName.TabIndex = 0
        Me.btnShowFullName.TabStop = False
        Me.btnShowFullName.Text = "Show Full Name"
        Me.btnShowFullName.UseVisualStyleBackColor = True
        '
        'ttbName
        '
        Me.ttbName.Location = New System.Drawing.Point(109, 305)
        Me.ttbName.Name = "ttbName"
        Me.ttbName.Size = New System.Drawing.Size(194, 32)
        Me.ttbName.TabIndex = 0
        Me.ttbName.TabStop = False
        '
        'ttbFullName
        '
        Me.ttbFullName.Location = New System.Drawing.Point(157, 420)
        Me.ttbFullName.Name = "ttbFullName"
        Me.ttbFullName.Size = New System.Drawing.Size(506, 32)
        Me.ttbFullName.TabIndex = 0
        Me.ttbFullName.TabStop = False
        Me.ttbFullName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ttbSurname
        '
        Me.ttbSurname.Location = New System.Drawing.Point(439, 305)
        Me.ttbSurname.Name = "ttbSurname"
        Me.ttbSurname.Size = New System.Drawing.Size(224, 32)
        Me.ttbSurname.TabIndex = 0
        Me.ttbSurname.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(43, 308)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(43, 423)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 23)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Full Name"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(340, 308)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(95, 23)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Surname"
        '
        'vsbAC
        '
        Me.vsbAC.Location = New System.Drawing.Point(702, 1)
        Me.vsbAC.Name = "vsbAC"
        Me.vsbAC.Size = New System.Drawing.Size(26, 508)
        Me.vsbAC.TabIndex = 5
        '
        'frmACs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(729, 511)
        Me.Controls.Add(Me.vsbAC)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ttbSurname)
        Me.Controls.Add(Me.ttbFullName)
        Me.Controls.Add(Me.ttbName)
        Me.Controls.Add(Me.btnShowFullName)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.txtSeconds)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.txtFullName)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.cboTitle)
        Me.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "frmACs"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Additional Controls"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cboTitle As ComboBox
    Friend WithEvents lblName As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents btnDisplay As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents txtFullName As TextBox
    Friend WithEvents btnClear As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents btnStart As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txtSeconds As TextBox
    Friend WithEvents btnStop As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents tmrWatch As Timer
    Friend WithEvents ttpTooltip As ToolTip
    Friend WithEvents btnShowFullName As Button
    Friend WithEvents ttbName As TextBox
    Friend WithEvents ttbFullName As TextBox
    Friend WithEvents ttbSurname As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents vsbAC As VScrollBar
End Class
