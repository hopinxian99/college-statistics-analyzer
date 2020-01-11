<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.KolejBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AssigmentDataSet = New WindowsApplication1.assigmentDataSet()
        Me.Kolej_TableAdapter = New WindowsApplication1.assigmentDataSetTableAdapters.kolej_TableAdapter()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KolejBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AssigmentDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Chart1
        '
        Me.Chart1.BackColor = System.Drawing.Color.Silver
        ChartArea2.BackColor = System.Drawing.Color.PowderBlue
        ChartArea2.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea2)
        Me.Chart1.DataSource = Me.KolejBindingSource
        Me.Chart1.IsSoftShadows = False
        Legend2.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend2)
        Me.Chart1.Location = New System.Drawing.Point(0, 50)
        Me.Chart1.Name = "Chart1"
        Series2.ChartArea = "ChartArea1"
        Series2.IsValueShownAsLabel = True
        Series2.Legend = "Legend1"
        Series2.Name = "Kolej"
        Series2.XValueMember = "KEMUDAHAN DEWAN/BILIK PEPERIKSAAN KOLEJ MATRIKULASI"
        Series2.YValueMembers = "F3"
        Me.Chart1.Series.Add(Series2)
        Me.Chart1.Size = New System.Drawing.Size(980, 403)
        Me.Chart1.TabIndex = 1
        Me.Chart1.Text = "Chart1"
        '
        'KolejBindingSource
        '
        Me.KolejBindingSource.DataMember = "kolej$"
        Me.KolejBindingSource.DataSource = Me.AssigmentDataSet
        '
        'AssigmentDataSet
        '
        Me.AssigmentDataSet.DataSetName = "assigmentDataSet"
        Me.AssigmentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Kolej_TableAdapter
        '
        Me.Kolej_TableAdapter.ClearBeforeFill = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.GrayText
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(981, 53)
        Me.Panel1.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(245, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(415, 38)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Chart kuantiti versus Kolej"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(981, 452)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Chart1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KolejBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AssigmentDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Chart1 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents AssigmentDataSet As WindowsApplication1.assigmentDataSet
    Friend WithEvents KolejBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Kolej_TableAdapter As WindowsApplication1.assigmentDataSetTableAdapters.kolej_TableAdapter
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
