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
        Me.btnExit = New System.Windows.Forms.Button()
        Me.dgvCities = New System.Windows.Forms.DataGridView()
        Me.cboCountry = New System.Windows.Forms.ComboBox()
        Me.txtTotPop2005 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTotPop2015 = New System.Windows.Forms.TextBox()
        CType(Me.dgvCities, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(189, 358)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 37)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'dgvCities
        '
        Me.dgvCities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCities.Location = New System.Drawing.Point(33, 76)
        Me.dgvCities.Name = "dgvCities"
        Me.dgvCities.ReadOnly = True
        Me.dgvCities.RowHeadersWidth = 51
        Me.dgvCities.RowTemplate.Height = 24
        Me.dgvCities.Size = New System.Drawing.Size(436, 181)
        Me.dgvCities.TabIndex = 0
        Me.dgvCities.TabStop = False
        '
        'cboCountry
        '
        Me.cboCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCountry.FormattingEnabled = True
        Me.cboCountry.Location = New System.Drawing.Point(189, 30)
        Me.cboCountry.Name = "cboCountry"
        Me.cboCountry.Size = New System.Drawing.Size(180, 33)
        Me.cboCountry.TabIndex = 0
        '
        'txtTotPop2005
        '
        Me.txtTotPop2005.BackColor = System.Drawing.SystemColors.Window
        Me.txtTotPop2005.Location = New System.Drawing.Point(306, 269)
        Me.txtTotPop2005.Name = "txtTotPop2005"
        Me.txtTotPop2005.ReadOnly = True
        Me.txtTotPop2005.Size = New System.Drawing.Size(148, 32)
        Me.txtTotPop2005.TabIndex = 0
        Me.txtTotPop2005.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 273)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(272, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "TOTAL POPULATION 2005"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(73, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 25)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "COUNTRY"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 317)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(272, 25)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "TOTAL POPULATION 2015"
        '
        'txtTotPop2015
        '
        Me.txtTotPop2015.BackColor = System.Drawing.SystemColors.Window
        Me.txtTotPop2015.Location = New System.Drawing.Point(306, 313)
        Me.txtTotPop2015.Name = "txtTotPop2015"
        Me.txtTotPop2015.ReadOnly = True
        Me.txtTotPop2015.Size = New System.Drawing.Size(148, 32)
        Me.txtTotPop2015.TabIndex = 0
        Me.txtTotPop2015.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(493, 400)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtTotPop2015)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtTotPop2005)
        Me.Controls.Add(Me.cboCountry)
        Me.Controls.Add(Me.dgvCities)
        Me.Controls.Add(Me.btnExit)
        Me.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.Text = "Database Pract 2"
        CType(Me.dgvCities, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnExit As Button
    Friend WithEvents dgvCities As DataGridView
    Friend WithEvents cboCountry As ComboBox
    Friend WithEvents txtTotPop2005 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtTotPop2015 As TextBox
End Class
