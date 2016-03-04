<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRnrBooks
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
        Dim SubjectCodeLabel As System.Windows.Forms.Label
        Dim SubjectLabel As System.Windows.Forms.Label
        Me.SubjectsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RnrBooksDataSet1 = New Chapter_10_Exercise_10._1.RnrBooksDataSet1()
        Me.SubjectsTableAdapter = New Chapter_10_Exercise_10._1.RnrBooksDataSet1TableAdapters.SubjectsTableAdapter()
        Me.RnrBooksDataSet = New Chapter_10_Exercise_10._1.RnrBooksDataSet()
        Me.SubjectsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.SubjectsTableAdapter1 = New Chapter_10_Exercise_10._1.RnrBooksDataSetTableAdapters.SubjectsTableAdapter()
        Me.TableAdapterManager = New Chapter_10_Exercise_10._1.RnrBooksDataSetTableAdapters.TableAdapterManager()
        Me.SubjectCodeLabel1 = New System.Windows.Forms.Label()
        Me.SubjectComboBox = New System.Windows.Forms.ComboBox()
        Me.RnrBooksDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        SubjectCodeLabel = New System.Windows.Forms.Label()
        SubjectLabel = New System.Windows.Forms.Label()
        CType(Me.SubjectsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RnrBooksDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RnrBooksDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SubjectsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RnrBooksDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SubjectCodeLabel
        '
        SubjectCodeLabel.AutoSize = True
        SubjectCodeLabel.Location = New System.Drawing.Point(94, 101)
        SubjectCodeLabel.Name = "SubjectCodeLabel"
        SubjectCodeLabel.Size = New System.Drawing.Size(96, 17)
        SubjectCodeLabel.TabIndex = 1
        SubjectCodeLabel.Text = "Subject Code:"
        '
        'SubjectsBindingSource
        '
        Me.SubjectsBindingSource.DataMember = "Subjects"
        Me.SubjectsBindingSource.DataSource = Me.RnrBooksDataSet1
        '
        'RnrBooksDataSet1
        '
        Me.RnrBooksDataSet1.DataSetName = "RnrBooksDataSet1"
        Me.RnrBooksDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SubjectsTableAdapter
        '
        Me.SubjectsTableAdapter.ClearBeforeFill = True
        '
        'RnrBooksDataSet
        '
        Me.RnrBooksDataSet.DataSetName = "RnrBooksDataSet"
        Me.RnrBooksDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SubjectsBindingSource1
        '
        Me.SubjectsBindingSource1.DataMember = "Subjects"
        Me.SubjectsBindingSource1.DataSource = Me.RnrBooksDataSet
        '
        'SubjectsTableAdapter1
        '
        Me.SubjectsTableAdapter1.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.SubjectsTableAdapter = Me.SubjectsTableAdapter1
        Me.TableAdapterManager.UpdateOrder = Chapter_10_Exercise_10._1.RnrBooksDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SubjectCodeLabel1
        '
        Me.SubjectCodeLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SubjectsBindingSource1, "SubjectCode", True))
        Me.SubjectCodeLabel1.Location = New System.Drawing.Point(196, 101)
        Me.SubjectCodeLabel1.Name = "SubjectCodeLabel1"
        Me.SubjectCodeLabel1.Size = New System.Drawing.Size(100, 23)
        Me.SubjectCodeLabel1.TabIndex = 2
        Me.SubjectCodeLabel1.Text = "Label1"
        '
        'SubjectLabel
        '
        SubjectLabel.AutoSize = True
        SubjectLabel.Location = New System.Drawing.Point(94, 64)
        SubjectLabel.Name = "SubjectLabel"
        SubjectLabel.Size = New System.Drawing.Size(59, 17)
        SubjectLabel.TabIndex = 3
        SubjectLabel.Text = "Subject:"
        '
        'SubjectComboBox
        '
        Me.SubjectComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SubjectsBindingSource1, "Subject", True))
        Me.SubjectComboBox.DataSource = Me.SubjectsBindingSource1
        Me.SubjectComboBox.DisplayMember = "Subject"
        Me.SubjectComboBox.FormattingEnabled = True
        Me.SubjectComboBox.Location = New System.Drawing.Point(159, 61)
        Me.SubjectComboBox.Name = "SubjectComboBox"
        Me.SubjectComboBox.Size = New System.Drawing.Size(121, 24)
        Me.SubjectComboBox.TabIndex = 4
        '
        'RnrBooksDataSetBindingSource
        '
        Me.RnrBooksDataSetBindingSource.DataSource = Me.RnrBooksDataSet
        Me.RnrBooksDataSetBindingSource.Position = 0
        '
        'frmRnrBooks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(390, 182)
        Me.Controls.Add(SubjectLabel)
        Me.Controls.Add(Me.SubjectComboBox)
        Me.Controls.Add(SubjectCodeLabel)
        Me.Controls.Add(Me.SubjectCodeLabel1)
        Me.Name = "frmRnrBooks"
        Me.Text = "R 'n R Books"
        CType(Me.SubjectsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RnrBooksDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RnrBooksDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SubjectsBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RnrBooksDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RnrBooksDataSet1 As Chapter_10_Exercise_10._1.RnrBooksDataSet1
    Friend WithEvents SubjectsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SubjectsTableAdapter As Chapter_10_Exercise_10._1.RnrBooksDataSet1TableAdapters.SubjectsTableAdapter
    Friend WithEvents RnrBooksDataSet As Chapter_10_Exercise_10._1.RnrBooksDataSet
    Friend WithEvents SubjectsBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents SubjectsTableAdapter1 As Chapter_10_Exercise_10._1.RnrBooksDataSetTableAdapters.SubjectsTableAdapter
    Friend WithEvents TableAdapterManager As Chapter_10_Exercise_10._1.RnrBooksDataSetTableAdapters.TableAdapterManager
    Friend WithEvents SubjectCodeLabel1 As System.Windows.Forms.Label
    Friend WithEvents SubjectComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents RnrBooksDataSetBindingSource As System.Windows.Forms.BindingSource

End Class
