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
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtHeight = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtWidth = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtLitresNeeded = New System.Windows.Forms.TextBox()
        Me.txtTotalLitres = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(152, 147)
        Me.btnCalculate.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(116, 41)
        Me.btnCalculate.TabIndex = 2
        Me.btnCalculate.Text = "&Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(10, 316)
        Me.btnNext.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(81, 36)
        Me.btnNext.TabIndex = 3
        Me.btnNext.Text = "&Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(306, 316)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(81, 38)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(63, 68)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Heigth"
        '
        'txtHeight
        '
        Me.txtHeight.Location = New System.Drawing.Point(38, 98)
        Me.txtHeight.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtHeight.Name = "txtHeight"
        Me.txtHeight.Size = New System.Drawing.Size(133, 35)
        Me.txtHeight.TabIndex = 0
        Me.txtHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(43, 266)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 28)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Total Litres"
        '
        'txtWidth
        '
        Me.txtWidth.Location = New System.Drawing.Point(242, 98)
        Me.txtWidth.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtWidth.Name = "txtWidth"
        Me.txtWidth.Size = New System.Drawing.Size(133, 35)
        Me.txtWidth.TabIndex = 1
        Me.txtWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(267, 68)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 28)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Width"
        '
        'txtLitresNeeded
        '
        Me.txtLitresNeeded.BackColor = System.Drawing.SystemColors.Window
        Me.txtLitresNeeded.Location = New System.Drawing.Point(202, 208)
        Me.txtLitresNeeded.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtLitresNeeded.Name = "txtLitresNeeded"
        Me.txtLitresNeeded.ReadOnly = True
        Me.txtLitresNeeded.Size = New System.Drawing.Size(133, 35)
        Me.txtLitresNeeded.TabIndex = 0
        Me.txtLitresNeeded.TabStop = False
        Me.txtLitresNeeded.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTotalLitres
        '
        Me.txtTotalLitres.BackColor = System.Drawing.SystemColors.Window
        Me.txtTotalLitres.Location = New System.Drawing.Point(202, 263)
        Me.txtTotalLitres.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtTotalLitres.Name = "txtTotalLitres"
        Me.txtTotalLitres.ReadOnly = True
        Me.txtTotalLitres.Size = New System.Drawing.Size(133, 35)
        Me.txtTotalLitres.TabIndex = 0
        Me.txtTotalLitres.TabStop = False
        Me.txtTotalLitres.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(43, 211)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(150, 28)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Litres Needed"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Enabled = False
        Me.Label5.Font = New System.Drawing.Font("Century", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(13, 16)
        Me.Label5.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(383, 31)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Misi Mba Painting (PTY) Ltd"
        '
        'Form1
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(409, 356)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtTotalLitres)
        Me.Controls.Add(Me.txtLitresNeeded)
        Me.Controls.Add(Me.txtWidth)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtHeight)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnCalculate)
        Me.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Misi Mba Painting (PTY) Ltd"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtHeight As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtWidth As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtLitresNeeded As TextBox
    Friend WithEvents txtTotalLitres As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
