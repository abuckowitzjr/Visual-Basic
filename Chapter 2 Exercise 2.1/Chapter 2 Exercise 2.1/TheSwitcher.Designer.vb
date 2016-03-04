<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TheSwitcher
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TheSwitcher))
        Me.LightOffPictureBox = New System.Windows.Forms.PictureBox()
        Me.LightOnPictureBox = New System.Windows.Forms.PictureBox()
        Me.ColorGroupBox = New System.Windows.Forms.GroupBox()
        Me.GreenRadioButton = New System.Windows.Forms.RadioButton()
        Me.BlackRadioButton = New System.Windows.Forms.RadioButton()
        Me.RedRadioButton = New System.Windows.Forms.RadioButton()
        Me.BlueRadioButton = New System.Windows.Forms.RadioButton()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.ProgrammerLabel = New System.Windows.Forms.Label()
        Me.PrintButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.OperationLabel = New System.Windows.Forms.Label()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.LightOffPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LightOnPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ColorGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'LightOffPictureBox
        '
        Me.LightOffPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LightOffPictureBox.Image = Global.Chapter_2_Exercise_2._1.My.Resources.Resources.LightOff
        Me.LightOffPictureBox.Location = New System.Drawing.Point(202, 78)
        Me.LightOffPictureBox.Name = "LightOffPictureBox"
        Me.LightOffPictureBox.Size = New System.Drawing.Size(128, 122)
        Me.LightOffPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.LightOffPictureBox.TabIndex = 1
        Me.LightOffPictureBox.TabStop = False
        Me.ToolTip1.SetToolTip(Me.LightOffPictureBox, "Click here to turn the light on or off")
        '
        'LightOnPictureBox
        '
        Me.LightOnPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LightOnPictureBox.Image = Global.Chapter_2_Exercise_2._1.My.Resources.Resources.LightOn
        Me.LightOnPictureBox.Location = New System.Drawing.Point(202, 78)
        Me.LightOnPictureBox.Name = "LightOnPictureBox"
        Me.LightOnPictureBox.Size = New System.Drawing.Size(128, 122)
        Me.LightOnPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.LightOnPictureBox.TabIndex = 0
        Me.LightOnPictureBox.TabStop = False
        Me.ToolTip1.SetToolTip(Me.LightOnPictureBox, "Click here to turn the light on or off")
        '
        'ColorGroupBox
        '
        Me.ColorGroupBox.Controls.Add(Me.GreenRadioButton)
        Me.ColorGroupBox.Controls.Add(Me.BlackRadioButton)
        Me.ColorGroupBox.Controls.Add(Me.RedRadioButton)
        Me.ColorGroupBox.Controls.Add(Me.BlueRadioButton)
        Me.ColorGroupBox.Location = New System.Drawing.Point(34, 66)
        Me.ColorGroupBox.Name = "ColorGroupBox"
        Me.ColorGroupBox.Size = New System.Drawing.Size(132, 145)
        Me.ColorGroupBox.TabIndex = 2
        Me.ColorGroupBox.TabStop = False
        Me.ColorGroupBox.Text = "Choose a color"
        '
        'GreenRadioButton
        '
        Me.GreenRadioButton.AutoSize = True
        Me.GreenRadioButton.Location = New System.Drawing.Point(18, 97)
        Me.GreenRadioButton.Name = "GreenRadioButton"
        Me.GreenRadioButton.Size = New System.Drawing.Size(54, 17)
        Me.GreenRadioButton.TabIndex = 6
        Me.GreenRadioButton.TabStop = True
        Me.GreenRadioButton.Text = "&Green"
        Me.GreenRadioButton.UseVisualStyleBackColor = True
        '
        'BlackRadioButton
        '
        Me.BlackRadioButton.AutoSize = True
        Me.BlackRadioButton.Location = New System.Drawing.Point(18, 28)
        Me.BlackRadioButton.Name = "BlackRadioButton"
        Me.BlackRadioButton.Size = New System.Drawing.Size(52, 17)
        Me.BlackRadioButton.TabIndex = 3
        Me.BlackRadioButton.TabStop = True
        Me.BlackRadioButton.Text = "&Black"
        Me.BlackRadioButton.UseVisualStyleBackColor = True
        '
        'RedRadioButton
        '
        Me.RedRadioButton.AutoSize = True
        Me.RedRadioButton.Location = New System.Drawing.Point(18, 74)
        Me.RedRadioButton.Name = "RedRadioButton"
        Me.RedRadioButton.Size = New System.Drawing.Size(45, 17)
        Me.RedRadioButton.TabIndex = 5
        Me.RedRadioButton.TabStop = True
        Me.RedRadioButton.Text = "&Red"
        Me.RedRadioButton.UseVisualStyleBackColor = True
        '
        'BlueRadioButton
        '
        Me.BlueRadioButton.AutoSize = True
        Me.BlueRadioButton.Location = New System.Drawing.Point(18, 51)
        Me.BlueRadioButton.Name = "BlueRadioButton"
        Me.BlueRadioButton.Size = New System.Drawing.Size(46, 17)
        Me.BlueRadioButton.TabIndex = 4
        Me.BlueRadioButton.TabStop = True
        Me.BlueRadioButton.Text = "B&lue"
        Me.BlueRadioButton.UseVisualStyleBackColor = True
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Location = New System.Drawing.Point(161, 26)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(38, 13)
        Me.NameLabel.TabIndex = 3
        Me.NameLabel.Text = "&Name:"
        '
        'NameTextBox
        '
        Me.NameTextBox.Location = New System.Drawing.Point(202, 23)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(184, 20)
        Me.NameTextBox.TabIndex = 1
        '
        'ProgrammerLabel
        '
        Me.ProgrammerLabel.AutoSize = True
        Me.ProgrammerLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ProgrammerLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ProgrammerLabel.Location = New System.Drawing.Point(17, 273)
        Me.ProgrammerLabel.Name = "ProgrammerLabel"
        Me.ProgrammerLabel.Size = New System.Drawing.Size(168, 15)
        Me.ProgrammerLabel.TabIndex = 5
        Me.ProgrammerLabel.Text = "Programmed by: Arthur Buckowitz"
        '
        'PrintButton
        '
        Me.PrintButton.Location = New System.Drawing.Point(202, 264)
        Me.PrintButton.Name = "PrintButton"
        Me.PrintButton.Size = New System.Drawing.Size(89, 30)
        Me.PrintButton.TabIndex = 6
        Me.PrintButton.Text = "&Print"
        Me.PrintButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(297, 264)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(89, 30)
        Me.ExitButton.TabIndex = 7
        Me.ExitButton.Text = "E&xit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'OperationLabel
        '
        Me.OperationLabel.Font = New System.Drawing.Font("Raavi", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OperationLabel.Location = New System.Drawing.Point(189, 214)
        Me.OperationLabel.Name = "OperationLabel"
        Me.OperationLabel.Size = New System.Drawing.Size(197, 47)
        Me.OperationLabel.TabIndex = 8
        Me.OperationLabel.Text = "Turn the light on"
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'TheSwitcher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(416, 317)
        Me.Controls.Add(Me.OperationLabel)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.PrintButton)
        Me.Controls.Add(Me.ProgrammerLabel)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(Me.NameLabel)
        Me.Controls.Add(Me.ColorGroupBox)
        Me.Controls.Add(Me.LightOffPictureBox)
        Me.Controls.Add(Me.LightOnPictureBox)
        Me.Name = "TheSwitcher"
        Me.Text = "The Switcher"
        CType(Me.LightOffPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LightOnPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ColorGroupBox.ResumeLayout(False)
        Me.ColorGroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LightOnPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents LightOffPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents ColorGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents GreenRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents BlackRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents RedRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents BlueRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents NameLabel As System.Windows.Forms.Label
    Friend WithEvents NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ProgrammerLabel As System.Windows.Forms.Label
    Friend WithEvents PrintButton As System.Windows.Forms.Button
    Friend WithEvents ExitButton As System.Windows.Forms.Button
    Friend WithEvents OperationLabel As System.Windows.Forms.Label
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip

End Class
