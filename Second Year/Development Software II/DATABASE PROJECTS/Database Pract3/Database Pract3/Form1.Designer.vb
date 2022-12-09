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
        Me.components = New System.ComponentModel.Container()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTotPop2005 = New System.Windows.Forms.TextBox()
        Me.cboCountry = New System.Windows.Forms.ComboBox()
        Me.dgvCities = New System.Windows.Forms.DataGridView()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.MegacitiesDataSet = New Database_Pract3.MegacitiesDataSet()
        Me.CitiesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CitiesTableAdapter = New Database_Pract3.MegacitiesDataSetTableAdapters.CitiesTableAdapter()
        CType(Me.dgvCities, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MegacitiesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CitiesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(71, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 25)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "COUNTRY"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 261)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(272, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "TOTAL POPULATION 2005"
        '
        'txtTotPop2005
        '
        Me.txtTotPop2005.BackColor = System.Drawing.SystemColors.Window
        Me.txtTotPop2005.Location = New System.Drawing.Point(304, 257)
        Me.txtTotPop2005.Name = "txtTotPop2005"
        Me.txtTotPop2005.ReadOnly = True
        Me.txtTotPop2005.Size = New System.Drawing.Size(148, 32)
        Me.txtTotPop2005.TabIndex = 0
        Me.txtTotPop2005.TabStop = False
        '
        'cboCountry
        '
        Me.cboCountry.BackColor = System.Drawing.SystemColors.Window
        Me.cboCountry.FormattingEnabled = True
        Me.cboCountry.Location = New System.Drawing.Point(187, 18)
        Me.cboCountry.Name = "cboCountry"
        Me.cboCountry.Size = New System.Drawing.Size(180, 33)
        Me.cboCountry.TabIndex = 0
        '
        'dgvCities
        '
        Me.dgvCities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCities.Location = New System.Drawing.Point(31, 64)
        Me.dgvCities.Name = "dgvCities"
        Me.dgvCities.ReadOnly = True
        Me.dgvCities.RowHeadersWidth = 51
        Me.dgvCities.RowTemplate.Height = 24
        Me.dgvCities.Size = New System.Drawing.Size(436, 181)
        Me.dgvCities.TabIndex = 0
        Me.dgvCities.TabStop = False
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(187, 302)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 37)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'MegacitiesDataSet
        '
        Me.MegacitiesDataSet.DataSetName = "MegacitiesDataSet"
        Me.MegacitiesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CitiesBindingSource
        '
        Me.CitiesBindingSource.DataMember = "Cities"
        Me.CitiesBindingSource.DataSource = Me.MegacitiesDataSet
        '
        'CitiesTableAdapter
        '
        Me.CitiesTableAdapter.ClearBeforeFill = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(493, 346)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtTotPop2005)
        Me.Controls.Add(Me.cboCountry)
        Me.Controls.Add(Me.dgvCities)
        Me.Controls.Add(Me.btnExit)
        Me.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.Text = "Database Pract 3"
        CType(Me.dgvCities, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MegacitiesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CitiesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtTotPop2005 As TextBox
    Friend WithEvents cboCountry As ComboBox
    Friend WithEvents dgvCities As DataGridView
    Friend WithEvents btnExit As Button
    Friend WithEvents MegacitiesDataSet As MegacitiesDataSet
    Friend WithEvents CitiesBindingSource As BindingSource
    Friend WithEvents CitiesTableAdapter As MegacitiesDataSetTableAdapters.CitiesTableAdapter
End Class
