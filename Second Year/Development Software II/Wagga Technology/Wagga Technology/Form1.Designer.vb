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
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.btnNextOrder = New System.Windows.Forms.Button()
        Me.txtJobType = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtHours = New System.Windows.Forms.TextBox()
        Me.txtChargeForParts = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtTotalCharged = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtAccVat = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtAccLabourCharge = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtAccLabourHours = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtAccPartsCharge = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtAccTotal = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(106, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(188, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Customer's Name"
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(229, 179)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(125, 44)
        Me.btnCalculate.TabIndex = 4
        Me.btnCalculate.Text = "&Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'txtName
        '
        Me.txtName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtName.Location = New System.Drawing.Point(301, 50)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(219, 38)
        Me.txtName.TabIndex = 0
        '
        'btnNextOrder
        '
        Me.btnNextOrder.Location = New System.Drawing.Point(15, 540)
        Me.btnNextOrder.Name = "btnNextOrder"
        Me.btnNextOrder.Size = New System.Drawing.Size(135, 42)
        Me.btnNextOrder.TabIndex = 5
        Me.btnNextOrder.Text = "&Next Order"
        Me.btnNextOrder.UseVisualStyleBackColor = True
        '
        'txtJobType
        '
        Me.txtJobType.Location = New System.Drawing.Point(87, 132)
        Me.txtJobType.MaxLength = 1
        Me.txtJobType.Name = "txtJobType"
        Me.txtJobType.Size = New System.Drawing.Size(125, 38)
        Me.txtJobType.TabIndex = 1
        Me.txtJobType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Century Schoolbook", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(72, 5)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(496, 37)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Wagga Tech Computer Repairs"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(98, 101)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 28)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Job Type"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(278, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 28)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Hours"
        '
        'txtHours
        '
        Me.txtHours.Location = New System.Drawing.Point(250, 132)
        Me.txtHours.Name = "txtHours"
        Me.txtHours.Size = New System.Drawing.Size(125, 38)
        Me.txtHours.TabIndex = 2
        Me.txtHours.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtChargeForParts
        '
        Me.txtChargeForParts.Location = New System.Drawing.Point(410, 132)
        Me.txtChargeForParts.Name = "txtChargeForParts"
        Me.txtChargeForParts.Size = New System.Drawing.Size(125, 38)
        Me.txtChargeForParts.TabIndex = 3
        Me.txtChargeForParts.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(384, 101)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(176, 28)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Charge for Parts"
        '
        'txtTotalCharged
        '
        Me.txtTotalCharged.Location = New System.Drawing.Point(334, 231)
        Me.txtTotalCharged.Name = "txtTotalCharged"
        Me.txtTotalCharged.Size = New System.Drawing.Size(151, 38)
        Me.txtTotalCharged.TabIndex = 0
        Me.txtTotalCharged.TabStop = False
        Me.txtTotalCharged.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(67, 236)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(261, 28)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Total Charged (incl VAT)"
        '
        'txtAccVat
        '
        Me.txtAccVat.Location = New System.Drawing.Point(418, 442)
        Me.txtAccVat.Name = "txtAccVat"
        Me.txtAccVat.Size = New System.Drawing.Size(151, 38)
        Me.txtAccVat.TabIndex = 0
        Me.txtAccVat.TabStop = False
        Me.txtAccVat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label9.Location = New System.Drawing.Point(67, 447)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(240, 28)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "VAT Amount (All Jobs)"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 15.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label10.Location = New System.Drawing.Point(159, 276)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(259, 30)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Accumulated Totals"
        '
        'txtAccLabourCharge
        '
        Me.txtAccLabourCharge.Location = New System.Drawing.Point(418, 310)
        Me.txtAccLabourCharge.Name = "txtAccLabourCharge"
        Me.txtAccLabourCharge.Size = New System.Drawing.Size(151, 38)
        Me.txtAccLabourCharge.TabIndex = 0
        Me.txtAccLabourCharge.TabStop = False
        Me.txtAccLabourCharge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label11.Location = New System.Drawing.Point(67, 315)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(345, 28)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Charge For Labour (Type 1 Jobs)"
        '
        'txtAccLabourHours
        '
        Me.txtAccLabourHours.Location = New System.Drawing.Point(418, 354)
        Me.txtAccLabourHours.Name = "txtAccLabourHours"
        Me.txtAccLabourHours.Size = New System.Drawing.Size(151, 38)
        Me.txtAccLabourHours.TabIndex = 0
        Me.txtAccLabourHours.TabStop = False
        Me.txtAccLabourHours.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label12.Location = New System.Drawing.Point(67, 359)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(332, 28)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Hours For Labour (Type 2 Jobs)"
        '
        'txtAccPartsCharge
        '
        Me.txtAccPartsCharge.Location = New System.Drawing.Point(418, 398)
        Me.txtAccPartsCharge.Name = "txtAccPartsCharge"
        Me.txtAccPartsCharge.Size = New System.Drawing.Size(151, 38)
        Me.txtAccPartsCharge.TabIndex = 0
        Me.txtAccPartsCharge.TabStop = False
        Me.txtAccPartsCharge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label13.Location = New System.Drawing.Point(67, 403)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(282, 28)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Charge For Parts (All Jobs)"
        '
        'txtAccTotal
        '
        Me.txtAccTotal.Location = New System.Drawing.Point(418, 486)
        Me.txtAccTotal.Name = "txtAccTotal"
        Me.txtAccTotal.Size = New System.Drawing.Size(151, 38)
        Me.txtAccTotal.TabIndex = 0
        Me.txtAccTotal.TabStop = False
        Me.txtAccTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label14.Location = New System.Drawing.Point(67, 491)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(340, 28)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "Total Amount Made (All Repairs)"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(561, 540)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(73, 39)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(645, 588)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.txtAccTotal)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtAccPartsCharge)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtAccLabourHours)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtAccLabourCharge)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtAccVat)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtTotalCharged)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtChargeForParts)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtHours)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtJobType)
        Me.Controls.Add(Me.btnNextOrder)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Wagga Technology"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents txtName As TextBox
    Friend WithEvents btnNextOrder As Button
    Friend WithEvents txtJobType As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtHours As TextBox
    Friend WithEvents txtChargeForParts As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtTotalCharged As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtAccVat As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtAccLabourCharge As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtAccLabourHours As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtAccPartsCharge As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtAccTotal As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents btnExit As Button
End Class
