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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTeamName = New System.Windows.Forms.TextBox()
        Me.txtPlayed = New System.Windows.Forms.TextBox()
        Me.txtOutput = New System.Windows.Forms.TextBox()
        Me.txtWon = New System.Windows.Forms.TextBox()
        Me.btnPercentage = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtLost = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 36)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Team Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 94)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Games Won"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 194)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(142, 23)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Games Played"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(28, 320)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 23)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Output"
        '
        'txtTeamName
        '
        Me.txtTeamName.Location = New System.Drawing.Point(176, 33)
        Me.txtTeamName.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtTeamName.Name = "txtTeamName"
        Me.txtTeamName.Size = New System.Drawing.Size(338, 31)
        Me.txtTeamName.TabIndex = 4
        '
        'txtPlayed
        '
        Me.txtPlayed.Location = New System.Drawing.Point(176, 191)
        Me.txtPlayed.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtPlayed.Name = "txtPlayed"
        Me.txtPlayed.ReadOnly = True
        Me.txtPlayed.Size = New System.Drawing.Size(170, 31)
        Me.txtPlayed.TabIndex = 5
        '
        'txtOutput
        '
        Me.txtOutput.Location = New System.Drawing.Point(188, 317)
        Me.txtOutput.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.ReadOnly = True
        Me.txtOutput.Size = New System.Drawing.Size(170, 31)
        Me.txtOutput.TabIndex = 6
        '
        'txtWon
        '
        Me.txtWon.Location = New System.Drawing.Point(176, 86)
        Me.txtWon.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtWon.Name = "txtWon"
        Me.txtWon.Size = New System.Drawing.Size(170, 31)
        Me.txtWon.TabIndex = 7
        '
        'btnPercentage
        '
        Me.btnPercentage.Location = New System.Drawing.Point(188, 240)
        Me.btnPercentage.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnPercentage.Name = "btnPercentage"
        Me.btnPercentage.Size = New System.Drawing.Size(129, 33)
        Me.btnPercentage.TabIndex = 8
        Me.btnPercentage.Text = "&Percentage"
        Me.btnPercentage.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Red
        Me.btnExit.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnExit.Location = New System.Drawing.Point(200, 368)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(129, 47)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "&Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'txtLost
        '
        Me.txtLost.Location = New System.Drawing.Point(176, 139)
        Me.txtLost.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtLost.Name = "txtLost"
        Me.txtLost.Size = New System.Drawing.Size(170, 31)
        Me.txtLost.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 147)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 23)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Games Lost"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(533, 435)
        Me.Controls.Add(Me.txtLost)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnPercentage)
        Me.Controls.Add(Me.txtWon)
        Me.Controls.Add(Me.txtOutput)
        Me.Controls.Add(Me.txtPlayed)
        Me.Controls.Add(Me.txtTeamName)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "PSL-APP"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtTeamName As TextBox
    Friend WithEvents txtPlayed As TextBox
    Friend WithEvents txtOutput As TextBox
    Friend WithEvents txtWon As TextBox
    Friend WithEvents btnPercentage As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents txtLost As TextBox
    Friend WithEvents Label5 As Label
End Class
