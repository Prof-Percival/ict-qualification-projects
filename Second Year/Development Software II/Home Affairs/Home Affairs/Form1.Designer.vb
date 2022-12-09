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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtDoB = New System.Windows.Forms.TextBox()
        Me.txtResidentStatus = New System.Windows.Forms.TextBox()
        Me.txtGender = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnShow = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(138, 11)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(148, 68)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(183, 85)
        Me.txtID.MaxLength = 13
        Me.txtID.Name = "txtID"
        Me.txtID.ShortcutsEnabled = False
        Me.txtID.Size = New System.Drawing.Size(140, 26)
        Me.txtID.TabIndex = 0
        Me.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtDoB
        '
        Me.txtDoB.BackColor = System.Drawing.SystemColors.Window
        Me.txtDoB.Location = New System.Drawing.Point(183, 189)
        Me.txtDoB.MaxLength = 10
        Me.txtDoB.Name = "txtDoB"
        Me.txtDoB.ReadOnly = True
        Me.txtDoB.Size = New System.Drawing.Size(129, 26)
        Me.txtDoB.TabIndex = 0
        Me.txtDoB.TabStop = False
        Me.txtDoB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtResidentStatus
        '
        Me.txtResidentStatus.BackColor = System.Drawing.SystemColors.Window
        Me.txtResidentStatus.Location = New System.Drawing.Point(183, 225)
        Me.txtResidentStatus.MaxLength = 21
        Me.txtResidentStatus.Name = "txtResidentStatus"
        Me.txtResidentStatus.ReadOnly = True
        Me.txtResidentStatus.Size = New System.Drawing.Size(193, 26)
        Me.txtResidentStatus.TabIndex = 0
        Me.txtResidentStatus.TabStop = False
        Me.txtResidentStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtGender
        '
        Me.txtGender.BackColor = System.Drawing.SystemColors.Window
        Me.txtGender.Location = New System.Drawing.Point(183, 157)
        Me.txtGender.MaxLength = 6
        Me.txtGender.Name = "txtGender"
        Me.txtGender.ReadOnly = True
        Me.txtGender.Size = New System.Drawing.Size(113, 26)
        Me.txtGender.TabIndex = 0
        Me.txtGender.TabStop = False
        Me.txtGender.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 92)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID Number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 196)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 19)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Date of Birth"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 165)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 19)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Gender"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 225)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(171, 19)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Residential Status"
        '
        'btnShow
        '
        Me.btnShow.Location = New System.Drawing.Point(163, 117)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(65, 31)
        Me.btnShow.TabIndex = 1
        Me.btnShow.Text = "&SHOW"
        Me.btnShow.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(4, 264)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(65, 26)
        Me.btnClear.TabIndex = 2
        Me.btnClear.Text = "&Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(333, 264)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(55, 27)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(393, 296)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnShow)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtGender)
        Me.Controls.Add(Me.txtResidentStatus)
        Me.Controls.Add(Me.txtDoB)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Home Affairs ID Validator"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtDoB As TextBox
    Friend WithEvents txtResidentStatus As TextBox
    Friend WithEvents txtGender As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnShow As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
End Class
