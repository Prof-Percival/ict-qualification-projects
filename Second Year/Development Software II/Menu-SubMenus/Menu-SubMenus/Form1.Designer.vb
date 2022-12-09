<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.OrderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOrder_Asc = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOrder_Desc = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuColor = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuColor_Back_Blue = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuColor_Back_Red = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuColor_Back_Green = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuColor_Back_White = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuColor_Back_Orange = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuColor_Back_Black = New System.Windows.Forms.ToolStripMenuItem()
        Me.ForeColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuColor_Fore_Blue = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuColor_Fore_Red = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuColor_Fore_Green = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuColor_Fore_White = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuColor_Fore_Orange = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuColor_Fore_Black = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lstOutput = New System.Windows.Forms.ListBox()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OrderToolStripMenuItem, Me.mnuColor, Me.mnuExit, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(380, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'OrderToolStripMenuItem
        '
        Me.OrderToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuOrder_Asc, Me.mnuOrder_Desc})
        Me.OrderToolStripMenuItem.Name = "OrderToolStripMenuItem"
        Me.OrderToolStripMenuItem.Size = New System.Drawing.Size(61, 24)
        Me.OrderToolStripMenuItem.Text = "&Order"
        '
        'mnuOrder_Asc
        '
        Me.mnuOrder_Asc.Name = "mnuOrder_Asc"
        Me.mnuOrder_Asc.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.mnuOrder_Asc.Size = New System.Drawing.Size(223, 26)
        Me.mnuOrder_Asc.Text = "Ascending"
        '
        'mnuOrder_Desc
        '
        Me.mnuOrder_Desc.Name = "mnuOrder_Desc"
        Me.mnuOrder_Desc.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.mnuOrder_Desc.Size = New System.Drawing.Size(223, 26)
        Me.mnuOrder_Desc.Text = "Descending"
        '
        'mnuColor
        '
        Me.mnuColor.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BackColorToolStripMenuItem, Me.ForeColorToolStripMenuItem})
        Me.mnuColor.Name = "mnuColor"
        Me.mnuColor.Size = New System.Drawing.Size(59, 24)
        Me.mnuColor.Text = "&Color"
        '
        'BackColorToolStripMenuItem
        '
        Me.BackColorToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuColor_Back_Blue, Me.mnuColor_Back_Red, Me.mnuColor_Back_Green, Me.mnuColor_Back_White, Me.mnuColor_Back_Orange, Me.mnuColor_Back_Black})
        Me.BackColorToolStripMenuItem.Name = "BackColorToolStripMenuItem"
        Me.BackColorToolStripMenuItem.Size = New System.Drawing.Size(159, 26)
        Me.BackColorToolStripMenuItem.Text = "&BackColor"
        '
        'mnuColor_Back_Blue
        '
        Me.mnuColor_Back_Blue.Name = "mnuColor_Back_Blue"
        Me.mnuColor_Back_Blue.Size = New System.Drawing.Size(141, 26)
        Me.mnuColor_Back_Blue.Text = "B&lue"
        '
        'mnuColor_Back_Red
        '
        Me.mnuColor_Back_Red.Name = "mnuColor_Back_Red"
        Me.mnuColor_Back_Red.Size = New System.Drawing.Size(141, 26)
        Me.mnuColor_Back_Red.Text = "&Red"
        '
        'mnuColor_Back_Green
        '
        Me.mnuColor_Back_Green.Name = "mnuColor_Back_Green"
        Me.mnuColor_Back_Green.Size = New System.Drawing.Size(141, 26)
        Me.mnuColor_Back_Green.Text = "&Green"
        '
        'mnuColor_Back_White
        '
        Me.mnuColor_Back_White.Name = "mnuColor_Back_White"
        Me.mnuColor_Back_White.Size = New System.Drawing.Size(141, 26)
        Me.mnuColor_Back_White.Text = "&White"
        '
        'mnuColor_Back_Orange
        '
        Me.mnuColor_Back_Orange.Name = "mnuColor_Back_Orange"
        Me.mnuColor_Back_Orange.Size = New System.Drawing.Size(141, 26)
        Me.mnuColor_Back_Orange.Text = "&Orange"
        '
        'mnuColor_Back_Black
        '
        Me.mnuColor_Back_Black.Name = "mnuColor_Back_Black"
        Me.mnuColor_Back_Black.Size = New System.Drawing.Size(141, 26)
        Me.mnuColor_Back_Black.Text = "Blac&k"
        '
        'ForeColorToolStripMenuItem
        '
        Me.ForeColorToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuColor_Fore_Blue, Me.mnuColor_Fore_Red, Me.mnuColor_Fore_Green, Me.mnuColor_Fore_White, Me.mnuColor_Fore_Orange, Me.mnuColor_Fore_Black})
        Me.ForeColorToolStripMenuItem.Name = "ForeColorToolStripMenuItem"
        Me.ForeColorToolStripMenuItem.Size = New System.Drawing.Size(159, 26)
        Me.ForeColorToolStripMenuItem.Text = "&ForeColor"
        '
        'mnuColor_Fore_Blue
        '
        Me.mnuColor_Fore_Blue.Name = "mnuColor_Fore_Blue"
        Me.mnuColor_Fore_Blue.Size = New System.Drawing.Size(141, 26)
        Me.mnuColor_Fore_Blue.Text = "B&lue"
        '
        'mnuColor_Fore_Red
        '
        Me.mnuColor_Fore_Red.Name = "mnuColor_Fore_Red"
        Me.mnuColor_Fore_Red.Size = New System.Drawing.Size(141, 26)
        Me.mnuColor_Fore_Red.Text = "&Red"
        '
        'mnuColor_Fore_Green
        '
        Me.mnuColor_Fore_Green.Name = "mnuColor_Fore_Green"
        Me.mnuColor_Fore_Green.Size = New System.Drawing.Size(141, 26)
        Me.mnuColor_Fore_Green.Text = "&Green"
        '
        'mnuColor_Fore_White
        '
        Me.mnuColor_Fore_White.Name = "mnuColor_Fore_White"
        Me.mnuColor_Fore_White.Size = New System.Drawing.Size(141, 26)
        Me.mnuColor_Fore_White.Text = "&White"
        '
        'mnuColor_Fore_Orange
        '
        Me.mnuColor_Fore_Orange.Name = "mnuColor_Fore_Orange"
        Me.mnuColor_Fore_Orange.Size = New System.Drawing.Size(141, 26)
        Me.mnuColor_Fore_Orange.Text = "&Orange"
        '
        'mnuColor_Fore_Black
        '
        Me.mnuColor_Fore_Black.Name = "mnuColor_Fore_Black"
        Me.mnuColor_Fore_Black.Size = New System.Drawing.Size(141, 26)
        Me.mnuColor_Fore_Black.Text = "Blac&k"
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(47, 24)
        Me.mnuExit.Text = "E&xit"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(55, 24)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'lstOutput
        '
        Me.lstOutput.FormattingEnabled = True
        Me.lstOutput.ItemHeight = 23
        Me.lstOutput.Location = New System.Drawing.Point(62, 58)
        Me.lstOutput.Name = "lstOutput"
        Me.lstOutput.Size = New System.Drawing.Size(359, 165)
        Me.lstOutput.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(505, 340)
        Me.Controls.Add(Me.lstOutput)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu-SubMenus"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents OrderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuOrder_Asc As ToolStripMenuItem
    Friend WithEvents mnuOrder_Desc As ToolStripMenuItem
    Friend WithEvents mnuColor As ToolStripMenuItem
    Friend WithEvents BackColorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuColor_Back_Blue As ToolStripMenuItem
    Friend WithEvents mnuColor_Back_Red As ToolStripMenuItem
    Friend WithEvents mnuColor_Back_Green As ToolStripMenuItem
    Friend WithEvents mnuColor_Back_White As ToolStripMenuItem
    Friend WithEvents mnuColor_Back_Orange As ToolStripMenuItem
    Friend WithEvents mnuColor_Back_Black As ToolStripMenuItem
    Friend WithEvents ForeColorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuExit As ToolStripMenuItem
    Friend WithEvents mnuColor_Fore_Blue As ToolStripMenuItem
    Friend WithEvents mnuColor_Fore_Red As ToolStripMenuItem
    Friend WithEvents mnuColor_Fore_Green As ToolStripMenuItem
    Friend WithEvents mnuColor_Fore_White As ToolStripMenuItem
    Friend WithEvents mnuColor_Fore_Orange As ToolStripMenuItem
    Friend WithEvents mnuColor_Fore_Black As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lstOutput As ListBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
