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
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtWon = New System.Windows.Forms.TextBox()
        Me.txtTeamName = New System.Windows.Forms.TextBox()
        Me.txtLost = New System.Windows.Forms.TextBox()
        Me.txtPercentage = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(92, 132)
        Me.btnCalculate.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(139, 39)
        Me.btnCalculate.TabIndex = 0
        Me.btnCalculate.Text = "&Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(146, 223)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(85, 39)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 16)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 27)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Team Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 59)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 27)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Games Won"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(178, 59)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(142, 27)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Games Lost"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(4, 176)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(311, 27)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Percentage of Games Won"
        '
        'txtWon
        '
        Me.txtWon.Location = New System.Drawing.Point(37, 90)
        Me.txtWon.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtWon.Name = "txtWon"
        Me.txtWon.Size = New System.Drawing.Size(77, 34)
        Me.txtWon.TabIndex = 6
        Me.txtWon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTeamName
        '
        Me.txtTeamName.Location = New System.Drawing.Point(152, 13)
        Me.txtTeamName.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtTeamName.Name = "txtTeamName"
        Me.txtTeamName.Size = New System.Drawing.Size(284, 34)
        Me.txtTeamName.TabIndex = 7
        '
        'txtLost
        '
        Me.txtLost.Location = New System.Drawing.Point(206, 90)
        Me.txtLost.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtLost.Name = "txtLost"
        Me.txtLost.Size = New System.Drawing.Size(77, 34)
        Me.txtLost.TabIndex = 8
        Me.txtLost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPercentage
        '
        Me.txtPercentage.Location = New System.Drawing.Point(329, 176)
        Me.txtPercentage.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtPercentage.Name = "txtPercentage"
        Me.txtPercentage.ReadOnly = True
        Me.txtPercentage.Size = New System.Drawing.Size(77, 34)
        Me.txtPercentage.TabIndex = 9
        Me.txtPercentage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Form1
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(448, 275)
        Me.Controls.Add(Me.txtPercentage)
        Me.Controls.Add(Me.txtLost)
        Me.Controls.Add(Me.txtTeamName)
        Me.Controls.Add(Me.txtWon)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalculate)
        Me.Font = New System.Drawing.Font("Consolas", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PSL App"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtWon As TextBox
    Friend WithEvents txtTeamName As TextBox
    Friend WithEvents txtLost As TextBox
    Friend WithEvents txtPercentage As TextBox
End Class
