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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.txtMemberNo = New System.Windows.Forms.TextBox()
        Me.txtOrders = New System.Windows.Forms.TextBox()
        Me.txtOrder = New System.Windows.Forms.TextBox()
        Me.txtMovies = New System.Windows.Forms.TextBox()
        Me.txtCDs = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Copperplate Gothic Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(22, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(503, 34)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Zantsi Online Shopping Club"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(47, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(142, 27)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Member No#"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(131, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 27)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Movies"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(326, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 27)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "CDs"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 221)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(363, 27)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Total Amount for this Order"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 271)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(363, 27)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Total Amount for All Orders"
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(195, 161)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(143, 43)
        Me.btnCalculate.TabIndex = 4
        Me.btnCalculate.Text = "&Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(435, 321)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(94, 40)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(35, 321)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(94, 40)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "Clea&r"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'txtMemberNo
        '
        Me.txtMemberNo.Location = New System.Drawing.Point(195, 48)
        Me.txtMemberNo.MaxLength = 5
        Me.txtMemberNo.Name = "txtMemberNo"
        Me.txtMemberNo.Size = New System.Drawing.Size(125, 34)
        Me.txtMemberNo.TabIndex = 1
        Me.txtMemberNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtOrders
        '
        Me.txtOrders.Location = New System.Drawing.Point(380, 271)
        Me.txtOrders.Name = "txtOrders"
        Me.txtOrders.ReadOnly = True
        Me.txtOrders.Size = New System.Drawing.Size(153, 34)
        Me.txtOrders.TabIndex = 6
        Me.txtOrders.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtOrder
        '
        Me.txtOrder.Location = New System.Drawing.Point(380, 222)
        Me.txtOrder.Name = "txtOrder"
        Me.txtOrder.ReadOnly = True
        Me.txtOrder.Size = New System.Drawing.Size(153, 34)
        Me.txtOrder.TabIndex = 5
        Me.txtOrder.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtMovies
        '
        Me.txtMovies.Location = New System.Drawing.Point(128, 118)
        Me.txtMovies.Name = "txtMovies"
        Me.txtMovies.Size = New System.Drawing.Size(92, 34)
        Me.txtMovies.TabIndex = 2
        Me.txtMovies.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCDs
        '
        Me.txtCDs.Location = New System.Drawing.Point(306, 118)
        Me.txtCDs.Name = "txtCDs"
        Me.txtCDs.Size = New System.Drawing.Size(92, 34)
        Me.txtCDs.TabIndex = 3
        Me.txtCDs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Form1
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(544, 367)
        Me.Controls.Add(Me.txtCDs)
        Me.Controls.Add(Me.txtMovies)
        Me.Controls.Add(Me.txtOrder)
        Me.Controls.Add(Me.txtOrders)
        Me.Controls.Add(Me.txtMemberNo)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Consolas", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Zantsi Online Shopping Club"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents txtMemberNo As TextBox
    Friend WithEvents txtOrders As TextBox
    Friend WithEvents txtOrder As TextBox
    Friend WithEvents txtMovies As TextBox
    Friend WithEvents txtCDs As TextBox
End Class
