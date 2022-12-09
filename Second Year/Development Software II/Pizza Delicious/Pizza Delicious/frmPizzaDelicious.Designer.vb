<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPizzaDelicious
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPizzaDelicious))
        Me.picPizzaDelicious = New System.Windows.Forms.PictureBox()
        Me.lstOutput = New System.Windows.Forms.ListBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.grpPizzaSize = New System.Windows.Forms.GroupBox()
        Me.radLarge = New System.Windows.Forms.RadioButton()
        Me.radMedium = New System.Windows.Forms.RadioButton()
        Me.radSmall = New System.Windows.Forms.RadioButton()
        Me.grpToppings = New System.Windows.Forms.GroupBox()
        Me.chkBacon = New System.Windows.Forms.CheckBox()
        Me.chkMozzarellaCheese = New System.Windows.Forms.CheckBox()
        Me.chkGreenPepper = New System.Windows.Forms.CheckBox()
        Me.chkChicken = New System.Windows.Forms.CheckBox()
        Me.chkAvocado = New System.Windows.Forms.CheckBox()
        Me.chkChilli = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grpCustomersDetails = New System.Windows.Forms.GroupBox()
        Me.txtTelephone = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.btnName = New System.Windows.Forms.TextBox()
        Me.lblTelephone = New System.Windows.Forms.Label()
        CType(Me.picPizzaDelicious, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpPizzaSize.SuspendLayout()
        Me.grpToppings.SuspendLayout()
        Me.grpCustomersDetails.SuspendLayout()
        Me.SuspendLayout()
        '
        'picPizzaDelicious
        '
        Me.picPizzaDelicious.Image = Global.Pizza_Delicious.My.Resources.Resources.pizza
        Me.picPizzaDelicious.Location = New System.Drawing.Point(535, 217)
        Me.picPizzaDelicious.Name = "picPizzaDelicious"
        Me.picPizzaDelicious.Size = New System.Drawing.Size(256, 172)
        Me.picPizzaDelicious.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPizzaDelicious.TabIndex = 14
        Me.picPizzaDelicious.TabStop = False
        '
        'lstOutput
        '
        Me.lstOutput.Font = New System.Drawing.Font("Century", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstOutput.FormattingEnabled = True
        Me.lstOutput.ItemHeight = 28
        Me.lstOutput.Location = New System.Drawing.Point(11, 217)
        Me.lstOutput.Name = "lstOutput"
        Me.lstOutput.Size = New System.Drawing.Size(517, 172)
        Me.lstOutput.TabIndex = 0
        Me.lstOutput.TabStop = False
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(708, 400)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(81, 34)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(11, 400)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(90, 34)
        Me.btnClear.TabIndex = 3
        Me.btnClear.Text = "C&lear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(184, 174)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(137, 34)
        Me.btnCalculate.TabIndex = 2
        Me.btnCalculate.Text = "&Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'grpPizzaSize
        '
        Me.grpPizzaSize.Controls.Add(Me.radLarge)
        Me.grpPizzaSize.Controls.Add(Me.radMedium)
        Me.grpPizzaSize.Controls.Add(Me.radSmall)
        Me.grpPizzaSize.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpPizzaSize.Location = New System.Drawing.Point(382, 55)
        Me.grpPizzaSize.Name = "grpPizzaSize"
        Me.grpPizzaSize.Size = New System.Drawing.Size(146, 124)
        Me.grpPizzaSize.TabIndex = 0
        Me.grpPizzaSize.TabStop = False
        Me.grpPizzaSize.Text = "Pizza Size"
        '
        'radLarge
        '
        Me.radLarge.Location = New System.Drawing.Point(7, 82)
        Me.radLarge.Name = "radLarge"
        Me.radLarge.Size = New System.Drawing.Size(97, 34)
        Me.radLarge.TabIndex = 0
        Me.radLarge.Text = "Large"
        Me.radLarge.UseVisualStyleBackColor = True
        '
        'radMedium
        '
        Me.radMedium.Location = New System.Drawing.Point(7, 57)
        Me.radMedium.Name = "radMedium"
        Me.radMedium.Size = New System.Drawing.Size(122, 27)
        Me.radMedium.TabIndex = 0
        Me.radMedium.Text = "Medium"
        Me.radMedium.UseVisualStyleBackColor = True
        '
        'radSmall
        '
        Me.radSmall.Location = New System.Drawing.Point(7, 31)
        Me.radSmall.Name = "radSmall"
        Me.radSmall.Size = New System.Drawing.Size(97, 27)
        Me.radSmall.TabIndex = 0
        Me.radSmall.Text = "Small"
        Me.radSmall.UseVisualStyleBackColor = True
        '
        'grpToppings
        '
        Me.grpToppings.Controls.Add(Me.chkBacon)
        Me.grpToppings.Controls.Add(Me.chkMozzarellaCheese)
        Me.grpToppings.Controls.Add(Me.chkGreenPepper)
        Me.grpToppings.Controls.Add(Me.chkChicken)
        Me.grpToppings.Controls.Add(Me.chkAvocado)
        Me.grpToppings.Controls.Add(Me.chkChilli)
        Me.grpToppings.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpToppings.Location = New System.Drawing.Point(541, 54)
        Me.grpToppings.Name = "grpToppings"
        Me.grpToppings.Size = New System.Drawing.Size(248, 155)
        Me.grpToppings.TabIndex = 0
        Me.grpToppings.TabStop = False
        Me.grpToppings.Text = "Toppings"
        '
        'chkBacon
        '
        Me.chkBacon.Location = New System.Drawing.Point(7, 65)
        Me.chkBacon.Name = "chkBacon"
        Me.chkBacon.Size = New System.Drawing.Size(101, 27)
        Me.chkBacon.TabIndex = 0
        Me.chkBacon.TabStop = False
        Me.chkBacon.Text = "Bacon"
        Me.chkBacon.UseVisualStyleBackColor = True
        '
        'chkMozzarellaCheese
        '
        Me.chkMozzarellaCheese.Location = New System.Drawing.Point(7, 131)
        Me.chkMozzarellaCheese.Name = "chkMozzarellaCheese"
        Me.chkMozzarellaCheese.Size = New System.Drawing.Size(241, 27)
        Me.chkMozzarellaCheese.TabIndex = 0
        Me.chkMozzarellaCheese.TabStop = False
        Me.chkMozzarellaCheese.Text = "Mozzarella Cheese "
        Me.chkMozzarellaCheese.UseVisualStyleBackColor = True
        '
        'chkGreenPepper
        '
        Me.chkGreenPepper.Location = New System.Drawing.Point(7, 98)
        Me.chkGreenPepper.Name = "chkGreenPepper"
        Me.chkGreenPepper.Size = New System.Drawing.Size(182, 27)
        Me.chkGreenPepper.TabIndex = 0
        Me.chkGreenPepper.TabStop = False
        Me.chkGreenPepper.Text = "Green Pepper"
        Me.chkGreenPepper.UseVisualStyleBackColor = True
        '
        'chkChicken
        '
        Me.chkChicken.Location = New System.Drawing.Point(127, 65)
        Me.chkChicken.Name = "chkChicken"
        Me.chkChicken.Size = New System.Drawing.Size(122, 27)
        Me.chkChicken.TabIndex = 0
        Me.chkChicken.TabStop = False
        Me.chkChicken.Text = "Chicken"
        Me.chkChicken.UseVisualStyleBackColor = True
        '
        'chkAvocado
        '
        Me.chkAvocado.Location = New System.Drawing.Point(127, 31)
        Me.chkAvocado.Name = "chkAvocado"
        Me.chkAvocado.Size = New System.Drawing.Size(123, 27)
        Me.chkAvocado.TabIndex = 0
        Me.chkAvocado.TabStop = False
        Me.chkAvocado.Text = "Avocado"
        Me.chkAvocado.UseVisualStyleBackColor = True
        '
        'chkChilli
        '
        Me.chkChilli.Location = New System.Drawing.Point(7, 32)
        Me.chkChilli.Name = "chkChilli"
        Me.chkChilli.Size = New System.Drawing.Size(94, 27)
        Me.chkChilli.TabIndex = 0
        Me.chkChilli.TabStop = False
        Me.chkChilli.Text = "Chilli"
        Me.chkChilli.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 19.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(126, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(544, 47)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Pizza Delicious Ordering System"
        '
        'grpCustomersDetails
        '
        Me.grpCustomersDetails.Controls.Add(Me.txtTelephone)
        Me.grpCustomersDetails.Controls.Add(Me.lblName)
        Me.grpCustomersDetails.Controls.Add(Me.btnName)
        Me.grpCustomersDetails.Controls.Add(Me.lblTelephone)
        Me.grpCustomersDetails.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpCustomersDetails.ForeColor = System.Drawing.Color.Black
        Me.grpCustomersDetails.Location = New System.Drawing.Point(11, 55)
        Me.grpCustomersDetails.Name = "grpCustomersDetails"
        Me.grpCustomersDetails.Size = New System.Drawing.Size(357, 110)
        Me.grpCustomersDetails.TabIndex = 0
        Me.grpCustomersDetails.TabStop = False
        Me.grpCustomersDetails.Text = "Customer's Details"
        '
        'txtTelephone
        '
        Me.txtTelephone.Location = New System.Drawing.Point(134, 75)
        Me.txtTelephone.Name = "txtTelephone"
        Me.txtTelephone.Size = New System.Drawing.Size(215, 32)
        Me.txtTelephone.TabIndex = 1
        '
        'lblName
        '
        Me.lblName.ForeColor = System.Drawing.SystemColors.Desktop
        Me.lblName.Location = New System.Drawing.Point(7, 35)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(74, 23)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Name"
        '
        'btnName
        '
        Me.btnName.Location = New System.Drawing.Point(134, 31)
        Me.btnName.Name = "btnName"
        Me.btnName.Size = New System.Drawing.Size(215, 32)
        Me.btnName.TabIndex = 0
        '
        'lblTelephone
        '
        Me.lblTelephone.ForeColor = System.Drawing.SystemColors.Desktop
        Me.lblTelephone.Location = New System.Drawing.Point(8, 80)
        Me.lblTelephone.Name = "lblTelephone"
        Me.lblTelephone.Size = New System.Drawing.Size(119, 23)
        Me.lblTelephone.TabIndex = 0
        Me.lblTelephone.Text = "Telephone"
        '
        'frmPizzaDelicious
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(802, 437)
        Me.Controls.Add(Me.picPizzaDelicious)
        Me.Controls.Add(Me.lstOutput)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.grpPizzaSize)
        Me.Controls.Add(Me.grpToppings)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.grpCustomersDetails)
        Me.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximumSize = New System.Drawing.Size(820, 484)
        Me.MinimumSize = New System.Drawing.Size(820, 484)
        Me.Name = "frmPizzaDelicious"
        Me.Text = "Pizza Delicious"
        CType(Me.picPizzaDelicious, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpPizzaSize.ResumeLayout(False)
        Me.grpToppings.ResumeLayout(False)
        Me.grpCustomersDetails.ResumeLayout(False)
        Me.grpCustomersDetails.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents picPizzaDelicious As PictureBox
    Friend WithEvents lstOutput As ListBox
    Friend WithEvents btnExit As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnCalculate As Button
    Friend WithEvents grpPizzaSize As GroupBox
    Friend WithEvents radLarge As RadioButton
    Friend WithEvents radMedium As RadioButton
    Friend WithEvents radSmall As RadioButton
    Friend WithEvents grpToppings As GroupBox
    Friend WithEvents chkBacon As CheckBox
    Friend WithEvents chkMozzarellaCheese As CheckBox
    Friend WithEvents chkGreenPepper As CheckBox
    Friend WithEvents chkChicken As CheckBox
    Friend WithEvents chkAvocado As CheckBox
    Friend WithEvents chkChilli As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents grpCustomersDetails As GroupBox
    Friend WithEvents txtTelephone As TextBox
    Friend WithEvents lblName As Label
    Friend WithEvents btnName As TextBox
    Friend WithEvents lblTelephone As Label
End Class
