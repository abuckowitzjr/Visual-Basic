<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPublishers
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
        Dim NameLabel As System.Windows.Forms.Label
        Dim PubIDLabel As System.Windows.Forms.Label
        Dim Company_NameLabel As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim CityLabel As System.Windows.Forms.Label
        Dim StateLabel As System.Windows.Forms.Label
        Dim ZipLabel As System.Windows.Forms.Label
        Dim TelephoneLabel As System.Windows.Forms.Label
        Dim FaxLabel As System.Windows.Forms.Label
        Me.ContactsDataSet = New Chapter_10_Exercise_10._3.ContactsDataSet()
        Me.PublishersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PublishersTableAdapter = New Chapter_10_Exercise_10._3.ContactsDataSetTableAdapters.PublishersTableAdapter()
        Me.TableAdapterManager = New Chapter_10_Exercise_10._3.ContactsDataSetTableAdapters.TableAdapterManager()
        Me.NameComboBox = New System.Windows.Forms.ComboBox()
        Me.PubIDLabel1 = New System.Windows.Forms.Label()
        Me.Company_NameLabel1 = New System.Windows.Forms.Label()
        Me.AddressLabel1 = New System.Windows.Forms.Label()
        Me.CityLabel1 = New System.Windows.Forms.Label()
        Me.StateLabel1 = New System.Windows.Forms.Label()
        Me.ZipLabel1 = New System.Windows.Forms.Label()
        Me.TelephoneLabel1 = New System.Windows.Forms.Label()
        Me.FaxLabel1 = New System.Windows.Forms.Label()
        NameLabel = New System.Windows.Forms.Label()
        PubIDLabel = New System.Windows.Forms.Label()
        Company_NameLabel = New System.Windows.Forms.Label()
        AddressLabel = New System.Windows.Forms.Label()
        CityLabel = New System.Windows.Forms.Label()
        StateLabel = New System.Windows.Forms.Label()
        ZipLabel = New System.Windows.Forms.Label()
        TelephoneLabel = New System.Windows.Forms.Label()
        FaxLabel = New System.Windows.Forms.Label()
        CType(Me.ContactsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PublishersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ContactsDataSet
        '
        Me.ContactsDataSet.DataSetName = "ContactsDataSet"
        Me.ContactsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PublishersBindingSource
        '
        Me.PublishersBindingSource.DataMember = "Publishers"
        Me.PublishersBindingSource.DataSource = Me.ContactsDataSet
        '
        'PublishersTableAdapter
        '
        Me.PublishersTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.PublishersTableAdapter = Me.PublishersTableAdapter
        Me.TableAdapterManager.UpdateOrder = Chapter_10_Exercise_10._3.ContactsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.Location = New System.Drawing.Point(60, 39)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(49, 17)
        NameLabel.TabIndex = 1
        NameLabel.Text = "Name:"
        '
        'NameComboBox
        '
        Me.NameComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PublishersBindingSource, "Name", True))
        Me.NameComboBox.DataSource = Me.PublishersBindingSource
        Me.NameComboBox.DisplayMember = "Name"
        Me.NameComboBox.FormattingEnabled = True
        Me.NameComboBox.Location = New System.Drawing.Point(115, 36)
        Me.NameComboBox.Name = "NameComboBox"
        Me.NameComboBox.Size = New System.Drawing.Size(180, 24)
        Me.NameComboBox.TabIndex = 2
        '
        'PubIDLabel
        '
        PubIDLabel.AutoSize = True
        PubIDLabel.Location = New System.Drawing.Point(81, 91)
        PubIDLabel.Name = "PubIDLabel"
        PubIDLabel.Size = New System.Drawing.Size(54, 17)
        PubIDLabel.TabIndex = 2
        PubIDLabel.Text = "Pub ID:"
        '
        'PubIDLabel1
        '
        Me.PubIDLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PublishersBindingSource, "PubID", True))
        Me.PubIDLabel1.Location = New System.Drawing.Point(141, 91)
        Me.PubIDLabel1.Name = "PubIDLabel1"
        Me.PubIDLabel1.Size = New System.Drawing.Size(100, 23)
        Me.PubIDLabel1.TabIndex = 3
        Me.PubIDLabel1.Text = "Label1"
        '
        'Company_NameLabel
        '
        Company_NameLabel.AutoSize = True
        Company_NameLabel.Location = New System.Drawing.Point(81, 114)
        Company_NameLabel.Name = "Company_NameLabel"
        Company_NameLabel.Size = New System.Drawing.Size(112, 17)
        Company_NameLabel.TabIndex = 4
        Company_NameLabel.Text = "Company Name:"
        '
        'Company_NameLabel1
        '
        Me.Company_NameLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PublishersBindingSource, "Company Name", True))
        Me.Company_NameLabel1.Location = New System.Drawing.Point(199, 114)
        Me.Company_NameLabel1.Name = "Company_NameLabel1"
        Me.Company_NameLabel1.Size = New System.Drawing.Size(100, 23)
        Me.Company_NameLabel1.TabIndex = 5
        Me.Company_NameLabel1.Text = "Label1"
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.Location = New System.Drawing.Point(81, 138)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(64, 17)
        AddressLabel.TabIndex = 6
        AddressLabel.Text = "Address:"
        '
        'AddressLabel1
        '
        Me.AddressLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PublishersBindingSource, "Address", True))
        Me.AddressLabel1.Location = New System.Drawing.Point(151, 138)
        Me.AddressLabel1.Name = "AddressLabel1"
        Me.AddressLabel1.Size = New System.Drawing.Size(100, 23)
        Me.AddressLabel1.TabIndex = 7
        Me.AddressLabel1.Text = "Label1"
        '
        'CityLabel
        '
        CityLabel.AutoSize = True
        CityLabel.Location = New System.Drawing.Point(81, 162)
        CityLabel.Name = "CityLabel"
        CityLabel.Size = New System.Drawing.Size(35, 17)
        CityLabel.TabIndex = 8
        CityLabel.Text = "City:"
        '
        'CityLabel1
        '
        Me.CityLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PublishersBindingSource, "City", True))
        Me.CityLabel1.Location = New System.Drawing.Point(122, 162)
        Me.CityLabel1.Name = "CityLabel1"
        Me.CityLabel1.Size = New System.Drawing.Size(100, 23)
        Me.CityLabel1.TabIndex = 9
        Me.CityLabel1.Text = "Label1"
        '
        'StateLabel
        '
        StateLabel.AutoSize = True
        StateLabel.Location = New System.Drawing.Point(81, 185)
        StateLabel.Name = "StateLabel"
        StateLabel.Size = New System.Drawing.Size(45, 17)
        StateLabel.TabIndex = 10
        StateLabel.Text = "State:"
        '
        'StateLabel1
        '
        Me.StateLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PublishersBindingSource, "State", True))
        Me.StateLabel1.Location = New System.Drawing.Point(132, 185)
        Me.StateLabel1.Name = "StateLabel1"
        Me.StateLabel1.Size = New System.Drawing.Size(100, 23)
        Me.StateLabel1.TabIndex = 11
        Me.StateLabel1.Text = "Label1"
        '
        'ZipLabel
        '
        ZipLabel.AutoSize = True
        ZipLabel.Location = New System.Drawing.Point(81, 208)
        ZipLabel.Name = "ZipLabel"
        ZipLabel.Size = New System.Drawing.Size(32, 17)
        ZipLabel.TabIndex = 12
        ZipLabel.Text = "Zip:"
        '
        'ZipLabel1
        '
        Me.ZipLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PublishersBindingSource, "Zip", True))
        Me.ZipLabel1.Location = New System.Drawing.Point(119, 208)
        Me.ZipLabel1.Name = "ZipLabel1"
        Me.ZipLabel1.Size = New System.Drawing.Size(100, 23)
        Me.ZipLabel1.TabIndex = 13
        Me.ZipLabel1.Text = "Label1"
        '
        'TelephoneLabel
        '
        TelephoneLabel.AutoSize = True
        TelephoneLabel.Location = New System.Drawing.Point(81, 232)
        TelephoneLabel.Name = "TelephoneLabel"
        TelephoneLabel.Size = New System.Drawing.Size(80, 17)
        TelephoneLabel.TabIndex = 14
        TelephoneLabel.Text = "Telephone:"
        '
        'TelephoneLabel1
        '
        Me.TelephoneLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PublishersBindingSource, "Telephone", True))
        Me.TelephoneLabel1.Location = New System.Drawing.Point(167, 232)
        Me.TelephoneLabel1.Name = "TelephoneLabel1"
        Me.TelephoneLabel1.Size = New System.Drawing.Size(100, 23)
        Me.TelephoneLabel1.TabIndex = 15
        Me.TelephoneLabel1.Text = "Label1"
        '
        'FaxLabel
        '
        FaxLabel.AutoSize = True
        FaxLabel.Location = New System.Drawing.Point(81, 255)
        FaxLabel.Name = "FaxLabel"
        FaxLabel.Size = New System.Drawing.Size(34, 17)
        FaxLabel.TabIndex = 16
        FaxLabel.Text = "Fax:"
        '
        'FaxLabel1
        '
        Me.FaxLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PublishersBindingSource, "Fax", True))
        Me.FaxLabel1.Location = New System.Drawing.Point(121, 255)
        Me.FaxLabel1.Name = "FaxLabel1"
        Me.FaxLabel1.Size = New System.Drawing.Size(100, 23)
        Me.FaxLabel1.TabIndex = 17
        Me.FaxLabel1.Text = "Label1"
        '
        'frmPublishers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(365, 322)
        Me.Controls.Add(FaxLabel)
        Me.Controls.Add(Me.FaxLabel1)
        Me.Controls.Add(TelephoneLabel)
        Me.Controls.Add(Me.TelephoneLabel1)
        Me.Controls.Add(ZipLabel)
        Me.Controls.Add(Me.ZipLabel1)
        Me.Controls.Add(StateLabel)
        Me.Controls.Add(Me.StateLabel1)
        Me.Controls.Add(CityLabel)
        Me.Controls.Add(Me.CityLabel1)
        Me.Controls.Add(AddressLabel)
        Me.Controls.Add(Me.AddressLabel1)
        Me.Controls.Add(Company_NameLabel)
        Me.Controls.Add(Me.Company_NameLabel1)
        Me.Controls.Add(PubIDLabel)
        Me.Controls.Add(Me.PubIDLabel1)
        Me.Controls.Add(NameLabel)
        Me.Controls.Add(Me.NameComboBox)
        Me.Name = "frmPublishers"
        Me.Text = "Publishers"
        CType(Me.ContactsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PublishersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ContactsDataSet As Chapter_10_Exercise_10._3.ContactsDataSet
    Friend WithEvents PublishersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PublishersTableAdapter As Chapter_10_Exercise_10._3.ContactsDataSetTableAdapters.PublishersTableAdapter
    Friend WithEvents TableAdapterManager As Chapter_10_Exercise_10._3.ContactsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents NameComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents PubIDLabel1 As System.Windows.Forms.Label
    Friend WithEvents Company_NameLabel1 As System.Windows.Forms.Label
    Friend WithEvents AddressLabel1 As System.Windows.Forms.Label
    Friend WithEvents CityLabel1 As System.Windows.Forms.Label
    Friend WithEvents StateLabel1 As System.Windows.Forms.Label
    Friend WithEvents ZipLabel1 As System.Windows.Forms.Label
    Friend WithEvents TelephoneLabel1 As System.Windows.Forms.Label
    Friend WithEvents FaxLabel1 As System.Windows.Forms.Label

End Class
