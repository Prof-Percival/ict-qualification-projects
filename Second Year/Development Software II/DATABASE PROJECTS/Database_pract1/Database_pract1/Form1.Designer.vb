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
        Me.components = New System.ComponentModel.Container()
        Me.BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MegacitiesDataSet = New Database_pract1.MegacitiesDataSet()
        Me.btnFirst = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCountry = New System.Windows.Forms.TextBox()
        Me.txtPopulation2005 = New System.Windows.Forms.TextBox()
        Me.txtPopulation2015 = New System.Windows.Forms.TextBox()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnLast = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MegacitiesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BindingSource
        '
        Me.BindingSource.DataMember = "Cities"
        Me.BindingSource.DataSource = Me.MegacitiesDataSet
        '
        'MegacitiesDataSet
        '
        Me.MegacitiesDataSet.DataSetName = "MegacitiesDataSet"
        Me.MegacitiesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnFirst
        '
        Me.btnFirst.Location = New System.Drawing.Point(114, 212)
        Me.btnFirst.Margin = New System.Windows.Forms.Padding(5)
        Me.btnFirst.Name = "btnFirst"
        Me.btnFirst.Size = New System.Drawing.Size(102, 34)
        Me.btnFirst.TabIndex = 0
        Me.btnFirst.Text = "&First"
        Me.btnFirst.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(174, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "City"
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(232, 19)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(208, 32)
        Me.txtCity.TabIndex = 0
        Me.txtCity.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(133, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 25)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Country"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(31, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(195, 25)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Population (2005)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(31, 159)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(195, 25)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Population (2015)"
        '
        'txtCountry
        '
        Me.txtCountry.Location = New System.Drawing.Point(232, 63)
        Me.txtCountry.Name = "txtCountry"
        Me.txtCountry.Size = New System.Drawing.Size(208, 32)
        Me.txtCountry.TabIndex = 0
        Me.txtCountry.TabStop = False
        '
        'txtPopulation2005
        '
        Me.txtPopulation2005.Location = New System.Drawing.Point(232, 108)
        Me.txtPopulation2005.Name = "txtPopulation2005"
        Me.txtPopulation2005.Size = New System.Drawing.Size(110, 32)
        Me.txtPopulation2005.TabIndex = 0
        Me.txtPopulation2005.TabStop = False
        '
        'txtPopulation2015
        '
        Me.txtPopulation2015.Location = New System.Drawing.Point(232, 156)
        Me.txtPopulation2015.Name = "txtPopulation2015"
        Me.txtPopulation2015.Size = New System.Drawing.Size(110, 32)
        Me.txtPopulation2015.TabIndex = 0
        Me.txtPopulation2015.TabStop = False
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(114, 267)
        Me.btnNext.Margin = New System.Windows.Forms.Padding(5)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(102, 34)
        Me.btnNext.TabIndex = 2
        Me.btnNext.Text = "&Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnPrevious
        '
        Me.btnPrevious.Location = New System.Drawing.Point(296, 266)
        Me.btnPrevious.Margin = New System.Windows.Forms.Padding(5)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(114, 34)
        Me.btnPrevious.TabIndex = 3
        Me.btnPrevious.Text = "&Previous"
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'btnLast
        '
        Me.btnLast.Location = New System.Drawing.Point(308, 212)
        Me.btnLast.Margin = New System.Windows.Forms.Padding(5)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(102, 34)
        Me.btnLast.TabIndex = 1
        Me.btnLast.Text = "&Last"
        Me.btnLast.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(202, 328)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(5)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(102, 34)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(527, 380)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnLast)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.txtPopulation2015)
        Me.Controls.Add(Me.txtPopulation2005)
        Me.Controls.Add(Me.txtCountry)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCity)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnFirst)
        Me.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "Form1"
        Me.Text = "Database Pract1"
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MegacitiesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BindingSource As BindingSource
    Friend WithEvents Student_RecTableAdapter As MegacitiesDataSetTableAdapters.CitiesTableAdapter
    Friend WithEvents btnFirst As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCity As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCountry As TextBox
    Friend WithEvents txtPopulation2005 As TextBox
    Friend WithEvents txtPopulation2015 As TextBox
    Friend WithEvents btnNext As Button
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnLast As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents MegacitiesDataSet As MegacitiesDataSet
End Class
