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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RainPictureBox = New System.Windows.Forms.PictureBox()
        Me.SunPictureBox = New System.Windows.Forms.PictureBox()
        Me.SnowPictureBox = New System.Windows.Forms.PictureBox()
        Me.CloudPictureBox = New System.Windows.Forms.PictureBox()
        Me.PrintButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.MessageLabel = New System.Windows.Forms.Label()
        Me.WeatherGroupBox = New System.Windows.Forms.GroupBox()
        Me.CloudyRadioButton = New System.Windows.Forms.RadioButton()
        Me.RainyRadioButton = New System.Windows.Forms.RadioButton()
        Me.SunnyRadioButton = New System.Windows.Forms.RadioButton()
        Me.SnowyRadioButton = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.RainPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SunPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SnowPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CloudPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.WeatherGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'NameTextBox
        '
        Me.NameTextBox.Location = New System.Drawing.Point(132, 16)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(193, 20)
        Me.NameTextBox.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.NameTextBox, "Enter your name here")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "&Enter your name here:"
        '
        'RainPictureBox
        '
        Me.RainPictureBox.Image = Global.Chapter_2_Exercise_2._3.My.Resources.Resources.Rain
        Me.RainPictureBox.Location = New System.Drawing.Point(125, 132)
        Me.RainPictureBox.Name = "RainPictureBox"
        Me.RainPictureBox.Size = New System.Drawing.Size(97, 74)
        Me.RainPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.RainPictureBox.TabIndex = 2
        Me.RainPictureBox.TabStop = False
        Me.ToolTip1.SetToolTip(Me.RainPictureBox, "Rainy day")
        Me.RainPictureBox.Visible = False
        '
        'SunPictureBox
        '
        Me.SunPictureBox.Image = Global.Chapter_2_Exercise_2._3.My.Resources.Resources.Sun
        Me.SunPictureBox.Location = New System.Drawing.Point(125, 52)
        Me.SunPictureBox.Name = "SunPictureBox"
        Me.SunPictureBox.Size = New System.Drawing.Size(97, 74)
        Me.SunPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.SunPictureBox.TabIndex = 3
        Me.SunPictureBox.TabStop = False
        Me.ToolTip1.SetToolTip(Me.SunPictureBox, "Sunny day")
        Me.SunPictureBox.Visible = False
        '
        'SnowPictureBox
        '
        Me.SnowPictureBox.Image = Global.Chapter_2_Exercise_2._3.My.Resources.Resources.Snow
        Me.SnowPictureBox.Location = New System.Drawing.Point(228, 52)
        Me.SnowPictureBox.Name = "SnowPictureBox"
        Me.SnowPictureBox.Size = New System.Drawing.Size(97, 74)
        Me.SnowPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.SnowPictureBox.TabIndex = 4
        Me.SnowPictureBox.TabStop = False
        Me.ToolTip1.SetToolTip(Me.SnowPictureBox, "Snowy day")
        Me.SnowPictureBox.Visible = False
        '
        'CloudPictureBox
        '
        Me.CloudPictureBox.Image = Global.Chapter_2_Exercise_2._3.My.Resources.Resources.Cloud
        Me.CloudPictureBox.Location = New System.Drawing.Point(228, 132)
        Me.CloudPictureBox.Name = "CloudPictureBox"
        Me.CloudPictureBox.Size = New System.Drawing.Size(97, 74)
        Me.CloudPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.CloudPictureBox.TabIndex = 5
        Me.CloudPictureBox.TabStop = False
        Me.ToolTip1.SetToolTip(Me.CloudPictureBox, "Cloudy day")
        Me.CloudPictureBox.Visible = False
        '
        'PrintButton
        '
        Me.PrintButton.Location = New System.Drawing.Point(250, 215)
        Me.PrintButton.Name = "PrintButton"
        Me.PrintButton.Size = New System.Drawing.Size(75, 23)
        Me.PrintButton.TabIndex = 6
        Me.PrintButton.Text = "&Print"
        Me.ToolTip1.SetToolTip(Me.PrintButton, "Print form")
        Me.PrintButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(250, 244)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(75, 23)
        Me.ExitButton.TabIndex = 7
        Me.ExitButton.Text = "E&xit"
        Me.ToolTip1.SetToolTip(Me.ExitButton, "Exit program")
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'MessageLabel
        '
        Me.MessageLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.MessageLabel.Location = New System.Drawing.Point(12, 215)
        Me.MessageLabel.Name = "MessageLabel"
        Me.MessageLabel.Size = New System.Drawing.Size(231, 19)
        Me.MessageLabel.TabIndex = 8
        Me.ToolTip1.SetToolTip(Me.MessageLabel, "Weather message will display here")
        '
        'WeatherGroupBox
        '
        Me.WeatherGroupBox.Controls.Add(Me.CloudyRadioButton)
        Me.WeatherGroupBox.Controls.Add(Me.RainyRadioButton)
        Me.WeatherGroupBox.Controls.Add(Me.SunnyRadioButton)
        Me.WeatherGroupBox.Controls.Add(Me.SnowyRadioButton)
        Me.WeatherGroupBox.Location = New System.Drawing.Point(23, 61)
        Me.WeatherGroupBox.Name = "WeatherGroupBox"
        Me.WeatherGroupBox.Size = New System.Drawing.Size(88, 118)
        Me.WeatherGroupBox.TabIndex = 9
        Me.WeatherGroupBox.TabStop = False
        Me.WeatherGroupBox.Text = "Choose"
        Me.ToolTip1.SetToolTip(Me.WeatherGroupBox, "Select weather type")
        '
        'CloudyRadioButton
        '
        Me.CloudyRadioButton.AutoSize = True
        Me.CloudyRadioButton.Location = New System.Drawing.Point(14, 87)
        Me.CloudyRadioButton.Name = "CloudyRadioButton"
        Me.CloudyRadioButton.Size = New System.Drawing.Size(57, 17)
        Me.CloudyRadioButton.TabIndex = 13
        Me.CloudyRadioButton.TabStop = True
        Me.CloudyRadioButton.Text = "&Cloudy"
        Me.CloudyRadioButton.UseVisualStyleBackColor = True
        '
        'RainyRadioButton
        '
        Me.RainyRadioButton.AutoSize = True
        Me.RainyRadioButton.Location = New System.Drawing.Point(14, 64)
        Me.RainyRadioButton.Name = "RainyRadioButton"
        Me.RainyRadioButton.Size = New System.Drawing.Size(52, 17)
        Me.RainyRadioButton.TabIndex = 12
        Me.RainyRadioButton.TabStop = True
        Me.RainyRadioButton.Text = "&Rainy"
        Me.RainyRadioButton.UseVisualStyleBackColor = True
        '
        'SunnyRadioButton
        '
        Me.SunnyRadioButton.AutoSize = True
        Me.SunnyRadioButton.Location = New System.Drawing.Point(14, 19)
        Me.SunnyRadioButton.Name = "SunnyRadioButton"
        Me.SunnyRadioButton.Size = New System.Drawing.Size(55, 17)
        Me.SunnyRadioButton.TabIndex = 10
        Me.SunnyRadioButton.TabStop = True
        Me.SunnyRadioButton.Text = "&Sunny"
        Me.SunnyRadioButton.UseVisualStyleBackColor = True
        '
        'SnowyRadioButton
        '
        Me.SnowyRadioButton.AutoSize = True
        Me.SnowyRadioButton.Location = New System.Drawing.Point(14, 42)
        Me.SnowyRadioButton.Name = "SnowyRadioButton"
        Me.SnowyRadioButton.Size = New System.Drawing.Size(57, 17)
        Me.SnowyRadioButton.TabIndex = 11
        Me.SnowyRadioButton.TabStop = True
        Me.SnowyRadioButton.Text = "S&nowy"
        Me.SnowyRadioButton.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 249)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(166, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Programmed by: Arthur Buckowitz"
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(342, 282)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.WeatherGroupBox)
        Me.Controls.Add(Me.MessageLabel)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.PrintButton)
        Me.Controls.Add(Me.CloudPictureBox)
        Me.Controls.Add(Me.SnowPictureBox)
        Me.Controls.Add(Me.SunPictureBox)
        Me.Controls.Add(Me.RainPictureBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.NameTextBox)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.RainPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SunPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SnowPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CloudPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.WeatherGroupBox.ResumeLayout(False)
        Me.WeatherGroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents RainPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents SunPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents SnowPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents CloudPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents PrintButton As System.Windows.Forms.Button
    Friend WithEvents ExitButton As System.Windows.Forms.Button
    Friend WithEvents MessageLabel As System.Windows.Forms.Label
    Friend WithEvents WeatherGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents CloudyRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents RainyRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents SunnyRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents SnowyRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm

End Class
