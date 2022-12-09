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
        Me.BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MegacitiesDataSet = New Database_Pract2.MegacitiesDataSet()
        Me.CitiesTableAdapter = New Database_Pract2.MegacitiesDataSetTableAdapters.CitiesTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboCountry = New System.Windows.Forms.ComboBox()
        Me.txtTotalPopulation = New System.Windows.Forms.TextBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.dgvCities = New System.Windows.Forms.DataGridView()
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MegacitiesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvCities, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'CitiesTableAdapter
        '
        Me.CitiesTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(135, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "COUNTRY"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(49, 362)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(213, 25)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "TOTAL POPULATION"
        '
        'cboCountry
        '
        Me.cboCountry.FormattingEnabled = True
        Me.cboCountry.Location = New System.Drawing.Point(251, 22)
        Me.cboCountry.Name = "cboCountry"
        Me.cboCountry.Size = New System.Drawing.Size(174, 33)
        Me.cboCountry.TabIndex = 0
        '
        'txtTotalPopulation
        '
        Me.txtTotalPopulation.Location = New System.Drawing.Point(268, 359)
        Me.txtTotalPopulation.Name = "txtTotalPopulation"
        Me.txtTotalPopulation.Size = New System.Drawing.Size(130, 32)
        Me.txtTotalPopulation.TabIndex = 0
        Me.txtTotalPopulation.TabStop = False
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(268, 409)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(93, 40)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'dgvCities
        '
        Me.dgvCities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCities.Location = New System.Drawing.Point(45, 61)
        Me.dgvCities.Name = "dgvCities"
        Me.dgvCities.ReadOnly = True
        Me.dgvCities.RowHeadersWidth = 51
        Me.dgvCities.RowTemplate.Height = 24
        Me.dgvCities.Size = New System.Drawing.Size(569, 274)
        Me.dgvCities.TabIndex = 0
        Me.dgvCities.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(662, 462)
        Me.Controls.Add(Me.dgvCities)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.txtTotalPopulation)
        Me.Controls.Add(Me.cboCountry)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "Form1"
        Me.Text = "Database_Pract2"
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MegacitiesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvCities, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BindingSource As BindingSource
    Friend WithEvents MegacitiesDataSet As MegacitiesDataSet
    Friend WithEvents CitiesTableAdapter As MegacitiesDataSetTableAdapters.CitiesTableAdapter
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cboCountry As ComboBox
    Friend WithEvents txtTotalPopulation As TextBox
    Friend WithEvents btnExit As Button
    Friend WithEvents dgvCities As DataGridView
End Class
