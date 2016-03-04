<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FlagViewer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FlagViewer))
        Me.CountryGroupBox = New System.Windows.Forms.GroupBox()
        Me.MexicoRadioButton = New System.Windows.Forms.RadioButton()
        Me.USRadioButton = New System.Windows.Forms.RadioButton()
        Me.CanadaRadioButton = New System.Windows.Forms.RadioButton()
        Me.JapanRadioButton = New System.Windows.Forms.RadioButton()
        Me.DisplayGroupBox = New System.Windows.Forms.GroupBox()
        Me.ProgrammerCheckBox = New System.Windows.Forms.CheckBox()
        Me.TitleCheckBox = New System.Windows.Forms.CheckBox()
        Me.CountryNameCheckBox = New System.Windows.Forms.CheckBox()
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.FlagMessageLabel = New System.Windows.Forms.Label()
        Me.ProgrammerLabel = New System.Windows.Forms.Label()
        Me.PrintButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.USFlagPictureBox = New System.Windows.Forms.PictureBox()
        Me.JapanPictureBox = New System.Windows.Forms.PictureBox()
        Me.CanadaPictureBox = New System.Windows.Forms.PictureBox()
        Me.MexicoPictureBox = New System.Windows.Forms.PictureBox()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.DisplayButton = New System.Windows.Forms.Button()
        Me.CountryGroupBox.SuspendLayout()
        Me.DisplayGroupBox.SuspendLayout()
        CType(Me.USFlagPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JapanPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CanadaPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MexicoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CountryGroupBox
        '
        Me.CountryGroupBox.Controls.Add(Me.MexicoRadioButton)
        Me.CountryGroupBox.Controls.Add(Me.USRadioButton)
        Me.CountryGroupBox.Controls.Add(Me.CanadaRadioButton)
        Me.CountryGroupBox.Controls.Add(Me.JapanRadioButton)
        Me.CountryGroupBox.Location = New System.Drawing.Point(37, 81)
        Me.CountryGroupBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CountryGroupBox.Name = "CountryGroupBox"
        Me.CountryGroupBox.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CountryGroupBox.Size = New System.Drawing.Size(151, 143)
        Me.CountryGroupBox.TabIndex = 8
        Me.CountryGroupBox.TabStop = False
        Me.CountryGroupBox.Text = "Country"
        Me.ToolTip1.SetToolTip(Me.CountryGroupBox, "Choose a country to display the flag")
        '
        'MexicoRadioButton
        '
        Me.MexicoRadioButton.AutoSize = True
        Me.MexicoRadioButton.Location = New System.Drawing.Point(20, 108)
        Me.MexicoRadioButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MexicoRadioButton.Name = "MexicoRadioButton"
        Me.MexicoRadioButton.Size = New System.Drawing.Size(96, 26)
        Me.MexicoRadioButton.TabIndex = 4
        Me.MexicoRadioButton.TabStop = True
        Me.MexicoRadioButton.Text = "&Mexico"
        Me.MexicoRadioButton.UseVisualStyleBackColor = True
        '
        'USRadioButton
        '
        Me.USRadioButton.AutoSize = True
        Me.USRadioButton.Location = New System.Drawing.Point(20, 23)
        Me.USRadioButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.USRadioButton.Name = "USRadioButton"
        Me.USRadioButton.Size = New System.Drawing.Size(152, 26)
        Me.USRadioButton.TabIndex = 2
        Me.USRadioButton.TabStop = True
        Me.USRadioButton.Text = "&United States"
        Me.USRadioButton.UseVisualStyleBackColor = True
        '
        'CanadaRadioButton
        '
        Me.CanadaRadioButton.AutoSize = True
        Me.CanadaRadioButton.Location = New System.Drawing.Point(20, 80)
        Me.CanadaRadioButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CanadaRadioButton.Name = "CanadaRadioButton"
        Me.CanadaRadioButton.Size = New System.Drawing.Size(104, 26)
        Me.CanadaRadioButton.TabIndex = 3
        Me.CanadaRadioButton.TabStop = True
        Me.CanadaRadioButton.Text = "&Canada"
        Me.CanadaRadioButton.UseVisualStyleBackColor = True
        '
        'JapanRadioButton
        '
        Me.JapanRadioButton.AutoSize = True
        Me.JapanRadioButton.Location = New System.Drawing.Point(20, 52)
        Me.JapanRadioButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.JapanRadioButton.Name = "JapanRadioButton"
        Me.JapanRadioButton.Size = New System.Drawing.Size(91, 26)
        Me.JapanRadioButton.TabIndex = 2
        Me.JapanRadioButton.TabStop = True
        Me.JapanRadioButton.Text = "&Japan"
        Me.JapanRadioButton.UseVisualStyleBackColor = True
        '
        'DisplayGroupBox
        '
        Me.DisplayGroupBox.Controls.Add(Me.ProgrammerCheckBox)
        Me.DisplayGroupBox.Controls.Add(Me.TitleCheckBox)
        Me.DisplayGroupBox.Controls.Add(Me.CountryNameCheckBox)
        Me.DisplayGroupBox.Location = New System.Drawing.Point(520, 81)
        Me.DisplayGroupBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DisplayGroupBox.Name = "DisplayGroupBox"
        Me.DisplayGroupBox.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DisplayGroupBox.Size = New System.Drawing.Size(161, 143)
        Me.DisplayGroupBox.TabIndex = 1
        Me.DisplayGroupBox.TabStop = False
        Me.DisplayGroupBox.Text = "Display"
        Me.ToolTip1.SetToolTip(Me.DisplayGroupBox, "Check items you wish to display on screen")
        '
        'ProgrammerCheckBox
        '
        Me.ProgrammerCheckBox.AutoSize = True
        Me.ProgrammerCheckBox.Checked = True
        Me.ProgrammerCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ProgrammerCheckBox.Location = New System.Drawing.Point(25, 81)
        Me.ProgrammerCheckBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ProgrammerCheckBox.Name = "ProgrammerCheckBox"
        Me.ProgrammerCheckBox.Size = New System.Drawing.Size(144, 26)
        Me.ProgrammerCheckBox.TabIndex = 4
        Me.ProgrammerCheckBox.Text = "P&rogrammer"
        Me.ProgrammerCheckBox.UseVisualStyleBackColor = True
        '
        'TitleCheckBox
        '
        Me.TitleCheckBox.AutoSize = True
        Me.TitleCheckBox.Checked = True
        Me.TitleCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.TitleCheckBox.Location = New System.Drawing.Point(25, 25)
        Me.TitleCheckBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TitleCheckBox.Name = "TitleCheckBox"
        Me.TitleCheckBox.Size = New System.Drawing.Size(76, 26)
        Me.TitleCheckBox.TabIndex = 2
        Me.TitleCheckBox.Text = "&Title"
        Me.TitleCheckBox.UseVisualStyleBackColor = True
        '
        'CountryNameCheckBox
        '
        Me.CountryNameCheckBox.AutoSize = True
        Me.CountryNameCheckBox.Checked = True
        Me.CountryNameCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CountryNameCheckBox.Location = New System.Drawing.Point(25, 53)
        Me.CountryNameCheckBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CountryNameCheckBox.Name = "CountryNameCheckBox"
        Me.CountryNameCheckBox.Size = New System.Drawing.Size(160, 26)
        Me.CountryNameCheckBox.TabIndex = 3
        Me.CountryNameCheckBox.Text = "Country &Name"
        Me.CountryNameCheckBox.UseVisualStyleBackColor = True
        '
        'TitleLabel
        '
        Me.TitleLabel.AutoSize = True
        Me.TitleLabel.Font = New System.Drawing.Font("JasmineUPC", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleLabel.Location = New System.Drawing.Point(225, 11)
        Me.TitleLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(244, 68)
        Me.TitleLabel.TabIndex = 2
        Me.TitleLabel.Text = "Flag Viewer"
        '
        'FlagMessageLabel
        '
        Me.FlagMessageLabel.BackColor = System.Drawing.Color.White
        Me.FlagMessageLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.FlagMessageLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlagMessageLabel.Location = New System.Drawing.Point(223, 239)
        Me.FlagMessageLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.FlagMessageLabel.Name = "FlagMessageLabel"
        Me.FlagMessageLabel.Size = New System.Drawing.Size(264, 23)
        Me.FlagMessageLabel.TabIndex = 3
        Me.FlagMessageLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ProgrammerLabel
        '
        Me.ProgrammerLabel.AutoSize = True
        Me.ProgrammerLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ProgrammerLabel.Location = New System.Drawing.Point(16, 331)
        Me.ProgrammerLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ProgrammerLabel.Name = "ProgrammerLabel"
        Me.ProgrammerLabel.Size = New System.Drawing.Size(223, 19)
        Me.ProgrammerLabel.TabIndex = 4
        Me.ProgrammerLabel.Text = "Programmed by: Arthur Buckowitz"
        '
        'PrintButton
        '
        Me.PrintButton.Location = New System.Drawing.Point(421, 304)
        Me.PrintButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PrintButton.Name = "PrintButton"
        Me.PrintButton.Size = New System.Drawing.Size(132, 38)
        Me.PrintButton.TabIndex = 1
        Me.PrintButton.Text = "&Print"
        Me.PrintButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(561, 304)
        Me.ExitButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(132, 38)
        Me.ExitButton.TabIndex = 6
        Me.ExitButton.Text = "E&xit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'USFlagPictureBox
        '
        Me.USFlagPictureBox.Image = Global.Chapter_2_Exercise_2._2.My.Resources.Resources.FlgUSA02
        Me.USFlagPictureBox.Location = New System.Drawing.Point(256, 81)
        Me.USFlagPictureBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.USFlagPictureBox.Name = "USFlagPictureBox"
        Me.USFlagPictureBox.Size = New System.Drawing.Size(197, 143)
        Me.USFlagPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.USFlagPictureBox.TabIndex = 7
        Me.USFlagPictureBox.TabStop = False
        Me.ToolTip1.SetToolTip(Me.USFlagPictureBox, "The flag of the United States")
        Me.USFlagPictureBox.Visible = False
        '
        'JapanPictureBox
        '
        Me.JapanPictureBox.Image = Global.Chapter_2_Exercise_2._2.My.Resources.Resources.FlgJapan
        Me.JapanPictureBox.Location = New System.Drawing.Point(256, 81)
        Me.JapanPictureBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.JapanPictureBox.Name = "JapanPictureBox"
        Me.JapanPictureBox.Size = New System.Drawing.Size(197, 143)
        Me.JapanPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.JapanPictureBox.TabIndex = 9
        Me.JapanPictureBox.TabStop = False
        Me.ToolTip1.SetToolTip(Me.JapanPictureBox, "The flag of Japan")
        Me.JapanPictureBox.Visible = False
        '
        'CanadaPictureBox
        '
        Me.CanadaPictureBox.Image = Global.Chapter_2_Exercise_2._2.My.Resources.Resources.FlgCan
        Me.CanadaPictureBox.Location = New System.Drawing.Point(256, 81)
        Me.CanadaPictureBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CanadaPictureBox.Name = "CanadaPictureBox"
        Me.CanadaPictureBox.Size = New System.Drawing.Size(197, 143)
        Me.CanadaPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.CanadaPictureBox.TabIndex = 10
        Me.CanadaPictureBox.TabStop = False
        Me.ToolTip1.SetToolTip(Me.CanadaPictureBox, "The flag of Canada")
        Me.CanadaPictureBox.Visible = False
        '
        'MexicoPictureBox
        '
        Me.MexicoPictureBox.Image = Global.Chapter_2_Exercise_2._2.My.Resources.Resources.FlgMex
        Me.MexicoPictureBox.Location = New System.Drawing.Point(256, 81)
        Me.MexicoPictureBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MexicoPictureBox.Name = "MexicoPictureBox"
        Me.MexicoPictureBox.Size = New System.Drawing.Size(197, 143)
        Me.MexicoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.MexicoPictureBox.TabIndex = 11
        Me.MexicoPictureBox.TabStop = False
        Me.ToolTip1.SetToolTip(Me.MexicoPictureBox, "The flag of Mexico")
        Me.MexicoPictureBox.Visible = False
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'DisplayButton
        '
        Me.DisplayButton.Location = New System.Drawing.Point(281, 304)
        Me.DisplayButton.Margin = New System.Windows.Forms.Padding(4)
        Me.DisplayButton.Name = "DisplayButton"
        Me.DisplayButton.Size = New System.Drawing.Size(132, 38)
        Me.DisplayButton.TabIndex = 12
        Me.DisplayButton.Text = "Display"
        Me.DisplayButton.UseVisualStyleBackColor = True
        '
        'FlagViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(709, 361)
        Me.Controls.Add(Me.DisplayButton)
        Me.Controls.Add(Me.MexicoPictureBox)
        Me.Controls.Add(Me.CanadaPictureBox)
        Me.Controls.Add(Me.JapanPictureBox)
        Me.Controls.Add(Me.USFlagPictureBox)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.PrintButton)
        Me.Controls.Add(Me.ProgrammerLabel)
        Me.Controls.Add(Me.FlagMessageLabel)
        Me.Controls.Add(Me.TitleLabel)
        Me.Controls.Add(Me.DisplayGroupBox)
        Me.Controls.Add(Me.CountryGroupBox)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FlagViewer"
        Me.Text = "Flag Viewer"
        Me.CountryGroupBox.ResumeLayout(False)
        Me.CountryGroupBox.PerformLayout()
        Me.DisplayGroupBox.ResumeLayout(False)
        Me.DisplayGroupBox.PerformLayout()
        CType(Me.USFlagPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JapanPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CanadaPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MexicoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CountryGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents MexicoRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents USRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents CanadaRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents JapanRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents DisplayGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents ProgrammerCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents TitleCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents CountryNameCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents TitleLabel As System.Windows.Forms.Label
    Friend WithEvents FlagMessageLabel As System.Windows.Forms.Label
    Friend WithEvents ProgrammerLabel As System.Windows.Forms.Label
    Friend WithEvents PrintButton As System.Windows.Forms.Button
    Friend WithEvents ExitButton As System.Windows.Forms.Button
    Friend WithEvents USFlagPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents JapanPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents CanadaPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents MexicoPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents DisplayButton As System.Windows.Forms.Button

End Class
