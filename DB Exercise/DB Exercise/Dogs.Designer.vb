<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dogs
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
        Dim DogIdLabel As System.Windows.Forms.Label
        Dim NameLabel As System.Windows.Forms.Label
        Dim BreedLabel As System.Windows.Forms.Label
        Dim WeightLabel As System.Windows.Forms.Label
        Dim DOBLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dogs))
        Dim DogIdLabel1 As System.Windows.Forms.Label
        Me.DogsDataSet = New DB_Exercise.DogsDataSet()
        Me.DogsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DogsTableAdapter = New DB_Exercise.DogsDataSetTableAdapters.DogsTableAdapter()
        Me.TableAdapterManager = New DB_Exercise.DogsDataSetTableAdapters.TableAdapterManager()
        Me.DogsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.DogsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.DogIdTextBox = New System.Windows.Forms.TextBox()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.BreedTextBox = New System.Windows.Forms.TextBox()
        Me.WeightTextBox = New System.Windows.Forms.TextBox()
        Me.DOBDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.DogIdComboBox = New System.Windows.Forms.ComboBox()
        DogIdLabel = New System.Windows.Forms.Label()
        NameLabel = New System.Windows.Forms.Label()
        BreedLabel = New System.Windows.Forms.Label()
        WeightLabel = New System.Windows.Forms.Label()
        DOBLabel = New System.Windows.Forms.Label()
        DogIdLabel1 = New System.Windows.Forms.Label()
        CType(Me.DogsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DogsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DogsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DogsBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'DogIdLabel
        '
        DogIdLabel.AutoSize = True
        DogIdLabel.Location = New System.Drawing.Point(87, 106)
        DogIdLabel.Name = "DogIdLabel"
        DogIdLabel.Size = New System.Drawing.Size(53, 17)
        DogIdLabel.TabIndex = 1
        DogIdLabel.Text = "Dog Id:"
        '
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.Location = New System.Drawing.Point(87, 134)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(49, 17)
        NameLabel.TabIndex = 3
        NameLabel.Text = "Name:"
        '
        'BreedLabel
        '
        BreedLabel.AutoSize = True
        BreedLabel.Location = New System.Drawing.Point(87, 162)
        BreedLabel.Name = "BreedLabel"
        BreedLabel.Size = New System.Drawing.Size(50, 17)
        BreedLabel.TabIndex = 5
        BreedLabel.Text = "Breed:"
        '
        'WeightLabel
        '
        WeightLabel.AutoSize = True
        WeightLabel.Location = New System.Drawing.Point(87, 190)
        WeightLabel.Name = "WeightLabel"
        WeightLabel.Size = New System.Drawing.Size(56, 17)
        WeightLabel.TabIndex = 7
        WeightLabel.Text = "Weight:"
        '
        'DOBLabel
        '
        DOBLabel.AutoSize = True
        DOBLabel.Location = New System.Drawing.Point(87, 219)
        DOBLabel.Name = "DOBLabel"
        DOBLabel.Size = New System.Drawing.Size(42, 17)
        DOBLabel.TabIndex = 9
        DOBLabel.Text = "DOB:"
        '
        'DogsDataSet
        '
        Me.DogsDataSet.DataSetName = "DogsDataSet"
        Me.DogsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DogsBindingSource
        '
        Me.DogsBindingSource.DataMember = "Dogs"
        Me.DogsBindingSource.DataSource = Me.DogsDataSet
        '
        'DogsTableAdapter
        '
        Me.DogsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.DogsTableAdapter = Me.DogsTableAdapter
        Me.TableAdapterManager.UpdateOrder = DB_Exercise.DogsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DogsBindingNavigator
        '
        Me.DogsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.DogsBindingNavigator.BindingSource = Me.DogsBindingSource
        Me.DogsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.DogsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.DogsBindingNavigator.Dock = System.Windows.Forms.DockStyle.None
        Me.DogsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.DogsBindingNavigatorSaveItem})
        Me.DogsBindingNavigator.Location = New System.Drawing.Point(70, 280)
        Me.DogsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.DogsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.DogsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.DogsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.DogsBindingNavigator.Name = "DogsBindingNavigator"
        Me.DogsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.DogsBindingNavigator.Size = New System.Drawing.Size(288, 27)
        Me.DogsBindingNavigator.TabIndex = 0
        Me.DogsBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 24)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(45, 24)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 24)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 24)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 24)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 27)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 24)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 24)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'DogsBindingNavigatorSaveItem
        '
        Me.DogsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DogsBindingNavigatorSaveItem.Image = CType(resources.GetObject("DogsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.DogsBindingNavigatorSaveItem.Name = "DogsBindingNavigatorSaveItem"
        Me.DogsBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 24)
        Me.DogsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'DogIdTextBox
        '
        Me.DogIdTextBox.BackColor = System.Drawing.Color.White
        Me.DogIdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DogsBindingSource, "DogId", True))
        Me.DogIdTextBox.Location = New System.Drawing.Point(149, 103)
        Me.DogIdTextBox.Name = "DogIdTextBox"
        Me.DogIdTextBox.ReadOnly = True
        Me.DogIdTextBox.Size = New System.Drawing.Size(248, 22)
        Me.DogIdTextBox.TabIndex = 2
        '
        'NameTextBox
        '
        Me.NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DogsBindingSource, "Name", True))
        Me.NameTextBox.Location = New System.Drawing.Point(149, 131)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(248, 22)
        Me.NameTextBox.TabIndex = 4
        '
        'BreedTextBox
        '
        Me.BreedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DogsBindingSource, "Breed", True))
        Me.BreedTextBox.Location = New System.Drawing.Point(149, 159)
        Me.BreedTextBox.Name = "BreedTextBox"
        Me.BreedTextBox.Size = New System.Drawing.Size(248, 22)
        Me.BreedTextBox.TabIndex = 6
        '
        'WeightTextBox
        '
        Me.WeightTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DogsBindingSource, "Weight", True))
        Me.WeightTextBox.Location = New System.Drawing.Point(149, 187)
        Me.WeightTextBox.Name = "WeightTextBox"
        Me.WeightTextBox.Size = New System.Drawing.Size(248, 22)
        Me.WeightTextBox.TabIndex = 8
        '
        'DOBDateTimePicker
        '
        Me.DOBDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DogsBindingSource, "DOB", True))
        Me.DOBDateTimePicker.Location = New System.Drawing.Point(149, 215)
        Me.DOBDateTimePicker.Name = "DOBDateTimePicker"
        Me.DOBDateTimePicker.Size = New System.Drawing.Size(248, 22)
        Me.DOBDateTimePicker.TabIndex = 10
        '
        'DogIdLabel1
        '
        DogIdLabel1.AutoSize = True
        DogIdLabel1.Location = New System.Drawing.Point(145, 48)
        DogIdLabel1.Name = "DogIdLabel1"
        DogIdLabel1.Size = New System.Drawing.Size(81, 17)
        DogIdLabel1.TabIndex = 11
        DogIdLabel1.Text = "Select Dog:"
        '
        'DogIdComboBox
        '
        Me.DogIdComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DogsBindingSource, "DogId", True, System.Windows.Forms.DataSourceUpdateMode.Never))
        Me.DogIdComboBox.DataSource = Me.DogsBindingSource
        Me.DogIdComboBox.DisplayMember = "DogId"
        Me.DogIdComboBox.FormattingEnabled = True
        Me.DogIdComboBox.Location = New System.Drawing.Point(232, 45)
        Me.DogIdComboBox.Name = "DogIdComboBox"
        Me.DogIdComboBox.Size = New System.Drawing.Size(82, 24)
        Me.DogIdComboBox.TabIndex = 12
        '
        'Dogs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(459, 378)
        Me.Controls.Add(DogIdLabel1)
        Me.Controls.Add(Me.DogIdComboBox)
        Me.Controls.Add(DogIdLabel)
        Me.Controls.Add(Me.DogIdTextBox)
        Me.Controls.Add(NameLabel)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(BreedLabel)
        Me.Controls.Add(Me.BreedTextBox)
        Me.Controls.Add(WeightLabel)
        Me.Controls.Add(Me.WeightTextBox)
        Me.Controls.Add(DOBLabel)
        Me.Controls.Add(Me.DOBDateTimePicker)
        Me.Controls.Add(Me.DogsBindingNavigator)
        Me.Name = "Dogs"
        Me.Text = "Dogs"
        CType(Me.DogsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DogsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DogsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DogsBindingNavigator.ResumeLayout(False)
        Me.DogsBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DogsDataSet As DB_Exercise.DogsDataSet
    Friend WithEvents DogsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DogsTableAdapter As DB_Exercise.DogsDataSetTableAdapters.DogsTableAdapter
    Friend WithEvents TableAdapterManager As DB_Exercise.DogsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DogsBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DogsBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents DogIdTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BreedTextBox As System.Windows.Forms.TextBox
    Friend WithEvents WeightTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DOBDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents DogIdComboBox As System.Windows.Forms.ComboBox

End Class
