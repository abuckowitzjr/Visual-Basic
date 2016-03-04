<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QuizForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(QuizForm))
        Me.Answer1RadioButton = New System.Windows.Forms.RadioButton()
        Me.Answer2RadioButton = New System.Windows.Forms.RadioButton()
        Me.Answer3RadioButton = New System.Windows.Forms.RadioButton()
        Me.Answer4RadioButton = New System.Windows.Forms.RadioButton()
        Me.PreviousButton = New System.Windows.Forms.Button()
        Me.NextButton = New System.Windows.Forms.Button()
        Me.PrintButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.LightBulbOffPictureBox = New System.Windows.Forms.PictureBox()
        Me.QuestionNumberLabel = New System.Windows.Forms.Label()
        Me.QuestionLabel = New System.Windows.Forms.Label()
        Me.ProgrammerLabel = New System.Windows.Forms.Label()
        Me.LightBulbOnPictureBox = New System.Windows.Forms.PictureBox()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        CType(Me.LightBulbOffPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LightBulbOnPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Answer1RadioButton
        '
        Me.Answer1RadioButton.AutoSize = True
        Me.Answer1RadioButton.Location = New System.Drawing.Point(77, 143)
        Me.Answer1RadioButton.Name = "Answer1RadioButton"
        Me.Answer1RadioButton.Size = New System.Drawing.Size(88, 17)
        Me.Answer1RadioButton.TabIndex = 1
        Me.Answer1RadioButton.TabStop = True
        Me.Answer1RadioButton.Text = "Check Boxes"
        Me.Answer1RadioButton.UseVisualStyleBackColor = True
        '
        'Answer2RadioButton
        '
        Me.Answer2RadioButton.AutoSize = True
        Me.Answer2RadioButton.Location = New System.Drawing.Point(77, 166)
        Me.Answer2RadioButton.Name = "Answer2RadioButton"
        Me.Answer2RadioButton.Size = New System.Drawing.Size(92, 17)
        Me.Answer2RadioButton.TabIndex = 2
        Me.Answer2RadioButton.TabStop = True
        Me.Answer2RadioButton.Text = "Radio Buttons"
        Me.Answer2RadioButton.UseVisualStyleBackColor = True
        '
        'Answer3RadioButton
        '
        Me.Answer3RadioButton.AutoSize = True
        Me.Answer3RadioButton.Location = New System.Drawing.Point(77, 189)
        Me.Answer3RadioButton.Name = "Answer3RadioButton"
        Me.Answer3RadioButton.Size = New System.Drawing.Size(62, 17)
        Me.Answer3RadioButton.TabIndex = 3
        Me.Answer3RadioButton.TabStop = True
        Me.Answer3RadioButton.Text = "List Box"
        Me.Answer3RadioButton.UseVisualStyleBackColor = True
        '
        'Answer4RadioButton
        '
        Me.Answer4RadioButton.AutoSize = True
        Me.Answer4RadioButton.Location = New System.Drawing.Point(77, 212)
        Me.Answer4RadioButton.Name = "Answer4RadioButton"
        Me.Answer4RadioButton.Size = New System.Drawing.Size(78, 17)
        Me.Answer4RadioButton.TabIndex = 4
        Me.Answer4RadioButton.TabStop = True
        Me.Answer4RadioButton.Text = "Text Boxes"
        Me.Answer4RadioButton.UseVisualStyleBackColor = True
        '
        'PreviousButton
        '
        Me.PreviousButton.Enabled = False
        Me.PreviousButton.Location = New System.Drawing.Point(35, 285)
        Me.PreviousButton.Name = "PreviousButton"
        Me.PreviousButton.Size = New System.Drawing.Size(105, 48)
        Me.PreviousButton.TabIndex = 5
        Me.PreviousButton.Text = "Previous"
        Me.PreviousButton.UseVisualStyleBackColor = True
        '
        'NextButton
        '
        Me.NextButton.Location = New System.Drawing.Point(146, 285)
        Me.NextButton.Name = "NextButton"
        Me.NextButton.Size = New System.Drawing.Size(105, 48)
        Me.NextButton.TabIndex = 0
        Me.NextButton.Text = "Next"
        Me.NextButton.UseVisualStyleBackColor = True
        '
        'PrintButton
        '
        Me.PrintButton.Location = New System.Drawing.Point(308, 285)
        Me.PrintButton.Name = "PrintButton"
        Me.PrintButton.Size = New System.Drawing.Size(105, 48)
        Me.PrintButton.TabIndex = 6
        Me.PrintButton.Text = "Print"
        Me.PrintButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(419, 285)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(105, 48)
        Me.ExitButton.TabIndex = 7
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'LightBulbOffPictureBox
        '
        Me.LightBulbOffPictureBox.Image = Global.Elementary_VB_Quiz_1.My.Resources.Resources.LightOff
        Me.LightBulbOffPictureBox.Location = New System.Drawing.Point(344, 118)
        Me.LightBulbOffPictureBox.Name = "LightBulbOffPictureBox"
        Me.LightBulbOffPictureBox.Size = New System.Drawing.Size(146, 142)
        Me.LightBulbOffPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.LightBulbOffPictureBox.TabIndex = 8
        Me.LightBulbOffPictureBox.TabStop = False
        '
        'QuestionNumberLabel
        '
        Me.QuestionNumberLabel.BackColor = System.Drawing.Color.Silver
        Me.QuestionNumberLabel.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuestionNumberLabel.Location = New System.Drawing.Point(15, 13)
        Me.QuestionNumberLabel.Name = "QuestionNumberLabel"
        Me.QuestionNumberLabel.Size = New System.Drawing.Size(97, 35)
        Me.QuestionNumberLabel.TabIndex = 9
        Me.QuestionNumberLabel.Text = "Question 1"
        Me.QuestionNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'QuestionLabel
        '
        Me.QuestionLabel.BackColor = System.Drawing.Color.Silver
        Me.QuestionLabel.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuestionLabel.Location = New System.Drawing.Point(15, 58)
        Me.QuestionLabel.Name = "QuestionLabel"
        Me.QuestionLabel.Size = New System.Drawing.Size(531, 34)
        Me.QuestionLabel.TabIndex = 10
        Me.QuestionLabel.Text = "Which of the following controls would be best for multiple choice questions?"
        Me.QuestionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ProgrammerLabel
        '
        Me.ProgrammerLabel.BackColor = System.Drawing.Color.Silver
        Me.ProgrammerLabel.Location = New System.Drawing.Point(-1, 354)
        Me.ProgrammerLabel.Name = "ProgrammerLabel"
        Me.ProgrammerLabel.Size = New System.Drawing.Size(559, 18)
        Me.ProgrammerLabel.TabIndex = 11
        Me.ProgrammerLabel.Text = "Programmer: Arthur Buckowitz"
        Me.ProgrammerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LightBulbOnPictureBox
        '
        Me.LightBulbOnPictureBox.Image = Global.Elementary_VB_Quiz_1.My.Resources.Resources.LightOn
        Me.LightBulbOnPictureBox.Location = New System.Drawing.Point(344, 118)
        Me.LightBulbOnPictureBox.Name = "LightBulbOnPictureBox"
        Me.LightBulbOnPictureBox.Size = New System.Drawing.Size(146, 142)
        Me.LightBulbOnPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.LightBulbOnPictureBox.TabIndex = 12
        Me.LightBulbOnPictureBox.TabStop = False
        Me.LightBulbOnPictureBox.Visible = False
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'QuizForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(558, 371)
        Me.ControlBox = False
        Me.Controls.Add(Me.LightBulbOnPictureBox)
        Me.Controls.Add(Me.ProgrammerLabel)
        Me.Controls.Add(Me.QuestionLabel)
        Me.Controls.Add(Me.QuestionNumberLabel)
        Me.Controls.Add(Me.LightBulbOffPictureBox)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.PrintButton)
        Me.Controls.Add(Me.NextButton)
        Me.Controls.Add(Me.PreviousButton)
        Me.Controls.Add(Me.Answer4RadioButton)
        Me.Controls.Add(Me.Answer3RadioButton)
        Me.Controls.Add(Me.Answer2RadioButton)
        Me.Controls.Add(Me.Answer1RadioButton)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "QuizForm"
        Me.Text = "Elementary VB Quiz1"
        CType(Me.LightBulbOffPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LightBulbOnPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Answer1RadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents Answer2RadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents Answer3RadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents Answer4RadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents PreviousButton As System.Windows.Forms.Button
    Friend WithEvents NextButton As System.Windows.Forms.Button
    Friend WithEvents PrintButton As System.Windows.Forms.Button
    Friend WithEvents ExitButton As System.Windows.Forms.Button
    Friend WithEvents LightBulbOffPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents QuestionNumberLabel As System.Windows.Forms.Label
    Friend WithEvents QuestionLabel As System.Windows.Forms.Label
    Friend WithEvents ProgrammerLabel As System.Windows.Forms.Label
    Friend WithEvents LightBulbOnPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm

End Class
