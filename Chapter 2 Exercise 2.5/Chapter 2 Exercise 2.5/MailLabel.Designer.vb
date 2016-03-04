<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MailLabel
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
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.CityTextBox = New System.Windows.Forms.TextBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.LastNameTextBox = New System.Windows.Forms.TextBox()
        Me.StateTextBox = New System.Windows.Forms.TextBox()
        Me.FirstNameLabel = New System.Windows.Forms.Label()
        Me.LastNameLabel = New System.Windows.Forms.Label()
        Me.AddressLabel = New System.Windows.Forms.Label()
        Me.CityLabel = New System.Windows.Forms.Label()
        Me.StateLabel = New System.Windows.Forms.Label()
        Me.ZipLabel = New System.Windows.Forms.Label()
        Me.AcceptButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.ZipMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.OutputNameLabel = New System.Windows.Forms.Label()
        Me.OutputAddressLabel = New System.Windows.Forms.Label()
        Me.OutputCityStateZipLabel = New System.Windows.Forms.Label()
        Me.ProgrammerLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.Location = New System.Drawing.Point(91, 45)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(151, 20)
        Me.FirstNameTextBox.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.FirstNameTextBox, "Enter first name here")
        '
        'CityTextBox
        '
        Me.CityTextBox.Location = New System.Drawing.Point(91, 108)
        Me.CityTextBox.Name = "CityTextBox"
        Me.CityTextBox.Size = New System.Drawing.Size(151, 20)
        Me.CityTextBox.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.CityTextBox, "Enter city here")
        '
        'AddressTextBox
        '
        Me.AddressTextBox.Location = New System.Drawing.Point(91, 76)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(373, 20)
        Me.AddressTextBox.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.AddressTextBox, "Enter address here")
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.Location = New System.Drawing.Point(315, 45)
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.Size = New System.Drawing.Size(149, 20)
        Me.LastNameTextBox.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.LastNameTextBox, "Enter last name here")
        '
        'StateTextBox
        '
        Me.StateTextBox.Location = New System.Drawing.Point(289, 108)
        Me.StateTextBox.Name = "StateTextBox"
        Me.StateTextBox.Size = New System.Drawing.Size(36, 20)
        Me.StateTextBox.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.StateTextBox, "Enter state here")
        '
        'FirstNameLabel
        '
        Me.FirstNameLabel.AutoSize = True
        Me.FirstNameLabel.Location = New System.Drawing.Point(25, 48)
        Me.FirstNameLabel.Name = "FirstNameLabel"
        Me.FirstNameLabel.Size = New System.Drawing.Size(60, 13)
        Me.FirstNameLabel.TabIndex = 6
        Me.FirstNameLabel.Text = "&First Name:"
        '
        'LastNameLabel
        '
        Me.LastNameLabel.AutoSize = True
        Me.LastNameLabel.Location = New System.Drawing.Point(248, 48)
        Me.LastNameLabel.Name = "LastNameLabel"
        Me.LastNameLabel.Size = New System.Drawing.Size(61, 13)
        Me.LastNameLabel.TabIndex = 7
        Me.LastNameLabel.Text = "&Last Name:"
        '
        'AddressLabel
        '
        Me.AddressLabel.AutoSize = True
        Me.AddressLabel.Location = New System.Drawing.Point(37, 79)
        Me.AddressLabel.Name = "AddressLabel"
        Me.AddressLabel.Size = New System.Drawing.Size(48, 13)
        Me.AddressLabel.TabIndex = 8
        Me.AddressLabel.Text = "A&ddress:"
        '
        'CityLabel
        '
        Me.CityLabel.AutoSize = True
        Me.CityLabel.Location = New System.Drawing.Point(58, 111)
        Me.CityLabel.Name = "CityLabel"
        Me.CityLabel.Size = New System.Drawing.Size(27, 13)
        Me.CityLabel.TabIndex = 9
        Me.CityLabel.Text = "&City:"
        '
        'StateLabel
        '
        Me.StateLabel.AutoSize = True
        Me.StateLabel.Location = New System.Drawing.Point(248, 111)
        Me.StateLabel.Name = "StateLabel"
        Me.StateLabel.Size = New System.Drawing.Size(35, 13)
        Me.StateLabel.TabIndex = 10
        Me.StateLabel.Text = "&State:"
        '
        'ZipLabel
        '
        Me.ZipLabel.AutoSize = True
        Me.ZipLabel.Location = New System.Drawing.Point(331, 111)
        Me.ZipLabel.Name = "ZipLabel"
        Me.ZipLabel.Size = New System.Drawing.Size(55, 13)
        Me.ZipLabel.TabIndex = 11
        Me.ZipLabel.Text = "&ZIP Code:"
        '
        'AcceptButton
        '
        Me.AcceptButton.Location = New System.Drawing.Point(59, 158)
        Me.AcceptButton.Name = "AcceptButton"
        Me.AcceptButton.Size = New System.Drawing.Size(102, 34)
        Me.AcceptButton.TabIndex = 6
        Me.AcceptButton.Text = "&Accept"
        Me.ToolTip1.SetToolTip(Me.AcceptButton, "Display mailing label")
        Me.AcceptButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(330, 158)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(102, 34)
        Me.ExitButton.TabIndex = 8
        Me.ExitButton.Text = "E&xit"
        Me.ToolTip1.SetToolTip(Me.ExitButton, "Exit the program")
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(195, 158)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(102, 34)
        Me.ClearButton.TabIndex = 7
        Me.ClearButton.Text = "C&lear"
        Me.ToolTip1.SetToolTip(Me.ClearButton, "Clear fields to start over")
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'ZipMaskedTextBox
        '
        Me.ZipMaskedTextBox.Location = New System.Drawing.Point(392, 108)
        Me.ZipMaskedTextBox.Mask = "00000-9999"
        Me.ZipMaskedTextBox.Name = "ZipMaskedTextBox"
        Me.ZipMaskedTextBox.Size = New System.Drawing.Size(72, 20)
        Me.ZipMaskedTextBox.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.ZipMaskedTextBox, "Enter ZIP code here")
        '
        'OutputNameLabel
        '
        Me.OutputNameLabel.AutoSize = True
        Me.OutputNameLabel.Location = New System.Drawing.Point(181, 226)
        Me.OutputNameLabel.Name = "OutputNameLabel"
        Me.OutputNameLabel.Size = New System.Drawing.Size(0, 13)
        Me.OutputNameLabel.TabIndex = 503
        Me.OutputNameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'OutputAddressLabel
        '
        Me.OutputAddressLabel.AutoSize = True
        Me.OutputAddressLabel.Location = New System.Drawing.Point(181, 239)
        Me.OutputAddressLabel.Name = "OutputAddressLabel"
        Me.OutputAddressLabel.Size = New System.Drawing.Size(0, 13)
        Me.OutputAddressLabel.TabIndex = 501
        Me.OutputAddressLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'OutputCityStateZipLabel
        '
        Me.OutputCityStateZipLabel.AutoSize = True
        Me.OutputCityStateZipLabel.Location = New System.Drawing.Point(181, 252)
        Me.OutputCityStateZipLabel.Name = "OutputCityStateZipLabel"
        Me.OutputCityStateZipLabel.Size = New System.Drawing.Size(0, 13)
        Me.OutputCityStateZipLabel.TabIndex = 502
        Me.OutputCityStateZipLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ProgrammerLabel
        '
        Me.ProgrammerLabel.AutoSize = True
        Me.ProgrammerLabel.Location = New System.Drawing.Point(12, 295)
        Me.ProgrammerLabel.Name = "ProgrammerLabel"
        Me.ProgrammerLabel.Size = New System.Drawing.Size(166, 13)
        Me.ProgrammerLabel.TabIndex = 500
        Me.ProgrammerLabel.Text = "Programmed by: Arthur Buckowitz"
        '
        'MailLabel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(491, 317)
        Me.Controls.Add(Me.ProgrammerLabel)
        Me.Controls.Add(Me.OutputCityStateZipLabel)
        Me.Controls.Add(Me.OutputAddressLabel)
        Me.Controls.Add(Me.OutputNameLabel)
        Me.Controls.Add(Me.ZipMaskedTextBox)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.AcceptButton)
        Me.Controls.Add(Me.ZipLabel)
        Me.Controls.Add(Me.StateLabel)
        Me.Controls.Add(Me.CityLabel)
        Me.Controls.Add(Me.AddressLabel)
        Me.Controls.Add(Me.LastNameLabel)
        Me.Controls.Add(Me.FirstNameLabel)
        Me.Controls.Add(Me.StateTextBox)
        Me.Controls.Add(Me.LastNameTextBox)
        Me.Controls.Add(Me.AddressTextBox)
        Me.Controls.Add(Me.CityTextBox)
        Me.Controls.Add(Me.FirstNameTextBox)
        Me.Name = "MailLabel"
        Me.Text = "Mail Label"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FirstNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LastNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FirstNameLabel As System.Windows.Forms.Label
    Friend WithEvents LastNameLabel As System.Windows.Forms.Label
    Friend WithEvents AddressLabel As System.Windows.Forms.Label
    Friend WithEvents CityLabel As System.Windows.Forms.Label
    Friend WithEvents StateLabel As System.Windows.Forms.Label
    Friend WithEvents ZipLabel As System.Windows.Forms.Label
    Friend WithEvents AcceptButton As System.Windows.Forms.Button
    Friend WithEvents ExitButton As System.Windows.Forms.Button
    Friend WithEvents ClearButton As System.Windows.Forms.Button
    Friend WithEvents ZipMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents OutputNameLabel As System.Windows.Forms.Label
    Friend WithEvents OutputAddressLabel As System.Windows.Forms.Label
    Friend WithEvents OutputCityStateZipLabel As System.Windows.Forms.Label
    Friend WithEvents ProgrammerLabel As System.Windows.Forms.Label

End Class
