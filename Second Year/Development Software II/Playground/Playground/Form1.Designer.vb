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
        Me.lstOutputData = New System.Windows.Forms.ListBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtInputData = New System.Windows.Forms.TextBox()
        Me.lblPosNum = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblNegNum = New System.Windows.Forms.Label()
        Me.txtInputData2 = New System.Windows.Forms.TextBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstOutputData
        '
        Me.lstOutputData.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lstOutputData.FormattingEnabled = True
        Me.lstOutputData.ItemHeight = 23
        Me.lstOutputData.Location = New System.Drawing.Point(324, 33)
        Me.lstOutputData.Name = "lstOutputData"
        Me.lstOutputData.Size = New System.Drawing.Size(310, 372)
        Me.lstOutputData.Sorted = True
        Me.lstOutputData.TabIndex = 0
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnAdd.Location = New System.Drawing.Point(25, 203)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(94, 45)
        Me.btnAdd.TabIndex = 1
        Me.btnAdd.Text = "&Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'txtInputData
        '
        Me.txtInputData.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtInputData.Location = New System.Drawing.Point(217, 58)
        Me.txtInputData.Name = "txtInputData"
        Me.txtInputData.Size = New System.Drawing.Size(87, 31)
        Me.txtInputData.TabIndex = 2
        '
        'lblPosNum
        '
        Me.lblPosNum.AutoSize = True
        Me.lblPosNum.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblPosNum.Location = New System.Drawing.Point(12, 61)
        Me.lblPosNum.Name = "lblPosNum"
        Me.lblPosNum.Size = New System.Drawing.Size(189, 25)
        Me.lblPosNum.TabIndex = 3
        Me.lblPosNum.Text = "Input Positive Number"
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Red
        Me.btnExit.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnExit.Location = New System.Drawing.Point(12, 398)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(94, 40)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'lblNegNum
        '
        Me.lblNegNum.AutoSize = True
        Me.lblNegNum.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblNegNum.Location = New System.Drawing.Point(12, 116)
        Me.lblNegNum.Name = "lblNegNum"
        Me.lblNegNum.Size = New System.Drawing.Size(199, 25)
        Me.lblNegNum.TabIndex = 6
        Me.lblNegNum.Text = "Input Negative Number"
        '
        'txtInputData2
        '
        Me.txtInputData2.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtInputData2.Location = New System.Drawing.Point(217, 116)
        Me.txtInputData2.Name = "txtInputData2"
        Me.txtInputData2.Size = New System.Drawing.Size(87, 31)
        Me.txtInputData2.TabIndex = 5
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnClear.Location = New System.Drawing.Point(168, 203)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(94, 45)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "&Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(636, 450)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lblNegNum)
        Me.Controls.Add(Me.txtInputData2)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblPosNum)
        Me.Controls.Add(Me.txtInputData)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.lstOutputData)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstOutputData As ListBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents txtInputData As TextBox
    Friend WithEvents lblPosNum As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents lblNegNum As Label
    Friend WithEvents txtInputData2 As TextBox
    Friend WithEvents btnClear As Button
End Class
