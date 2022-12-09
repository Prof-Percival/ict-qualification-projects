<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
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
        Me.components = New System.ComponentModel.Container()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnFirst = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPop2015 = New System.Windows.Forms.TextBox()
        Me.txtPop2005 = New System.Windows.Forms.TextBox()
        Me.txtCountry = New System.Windows.Forms.TextBox()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnLast = New System.Windows.Forms.Button()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MegacitiesDataSet = New Database_Pract1.MegacitiesDataSet()
        Me.CitiesTableAdapter = New Database_Pract1.MegacitiesDataSetTableAdapters.CitiesTableAdapter()
        Me.CountriesTableAdapter = New Database_Pract1.MegacitiesDataSetTableAdapters.CountriesTableAdapter()
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MegacitiesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(229, 18)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(187, 32)
        Me.txtCity.TabIndex = 0
        Me.txtCity.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(165, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CITY"
        '
        'btnFirst
        '
        Me.btnFirst.Location = New System.Drawing.Point(32, 218)
        Me.btnFirst.Name = "btnFirst"
        Me.btnFirst.Size = New System.Drawing.Size(75, 33)
        Me.btnFirst.TabIndex = 0
        Me.btnFirst.Text = "&First"
        Me.btnFirst.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(113, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 25)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "COUNTRY"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(201, 25)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "POPULATION 2005"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 167)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(201, 25)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "POPULATION 2015"
        '
        'txtPop2015
        '
        Me.txtPop2015.Location = New System.Drawing.Point(229, 160)
        Me.txtPop2015.Name = "txtPop2015"
        Me.txtPop2015.Size = New System.Drawing.Size(187, 32)
        Me.txtPop2015.TabIndex = 0
        Me.txtPop2015.TabStop = False
        '
        'txtPop2005
        '
        Me.txtPop2005.Location = New System.Drawing.Point(229, 111)
        Me.txtPop2005.Name = "txtPop2005"
        Me.txtPop2005.Size = New System.Drawing.Size(187, 32)
        Me.txtPop2005.TabIndex = 0
        Me.txtPop2005.TabStop = False
        '
        'txtCountry
        '
        Me.txtCountry.Location = New System.Drawing.Point(229, 63)
        Me.txtCountry.Name = "txtCountry"
        Me.txtCountry.Size = New System.Drawing.Size(187, 32)
        Me.txtCountry.TabIndex = 0
        Me.txtCountry.TabStop = False
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(123, 218)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 33)
        Me.btnNext.TabIndex = 1
        Me.btnNext.Text = "&Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(170, 264)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 33)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnLast
        '
        Me.btnLast.Location = New System.Drawing.Point(340, 219)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(75, 33)
        Me.btnLast.TabIndex = 3
        Me.btnLast.Text = "&Last"
        Me.btnLast.UseVisualStyleBackColor = True
        '
        'btnPrevious
        '
        Me.btnPrevious.Location = New System.Drawing.Point(216, 219)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(108, 33)
        Me.btnPrevious.TabIndex = 2
        Me.btnPrevious.Text = "&Previous"
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'BindingSource
        '
        Me.BindingSource.DataMember = "Countries"
        Me.BindingSource.DataSource = Me.MegacitiesDataSet
        '
        'MegacitiesDataSet
        '
        Me.MegacitiesDataSet.DataSetName = "MegacitiesDataSet"
        Me.MegacitiesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CitiesTableAdapter
        '
        Me.CitiesTableAdapter.ClearBeforeFill = True
        '
        'CountriesTableAdapter
        '
        Me.CountriesTableAdapter.ClearBeforeFill = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.MediumTurquoise
        Me.ClientSize = New System.Drawing.Size(443, 309)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.btnLast)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.txtCountry)
        Me.Controls.Add(Me.txtPop2005)
        Me.Controls.Add(Me.txtPop2015)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnFirst)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCity)
        Me.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.ShowIcon = False
        Me.Text = "Database Practical 1"
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MegacitiesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtCity As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnFirst As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPop2015 As TextBox
    Friend WithEvents txtPop2005 As TextBox
    Friend WithEvents txtCountry As TextBox
    Friend WithEvents btnNext As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnLast As Button
    Friend WithEvents btnPrevious As Button
    Friend WithEvents BindingSource As BindingSource
    Friend WithEvents MegacitiesDataSet As MegacitiesDataSet
    Friend WithEvents CitiesTableAdapter As MegacitiesDataSetTableAdapters.CitiesTableAdapter
    Friend WithEvents CountriesTableAdapter As MegacitiesDataSetTableAdapters.CountriesTableAdapter
End Class
