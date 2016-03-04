<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CalorieCounterForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CalorieCounterForm))
        Me.FatGramLabel = New System.Windows.Forms.Label()
        Me.CarbohydrateGramLabel = New System.Windows.Forms.Label()
        Me.ProteinGramLabel = New System.Windows.Forms.Label()
        Me.TotalCaloriesLabel = New System.Windows.Forms.Label()
        Me.TotalItemsEnteredLabel = New System.Windows.Forms.Label()
        Me.ProteinGramInputTextBox = New System.Windows.Forms.TextBox()
        Me.CarbGramInputTextBox = New System.Windows.Forms.TextBox()
        Me.FatGramInputTextBox = New System.Windows.Forms.TextBox()
        Me.CaloriesLabel = New System.Windows.Forms.Label()
        Me.TotalCalLabel = New System.Windows.Forms.Label()
        Me.CalculateButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.PrintButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.ProteinGramCalLabel = New System.Windows.Forms.Label()
        Me.CarbGramCalLabel = New System.Windows.Forms.Label()
        Me.FatGramCalLabel = New System.Windows.Forms.Label()
        Me.TotalItemsLabel = New System.Windows.Forms.Label()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.ProgrammerLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'FatGramLabel
        '
        Me.FatGramLabel.AutoSize = True
        Me.FatGramLabel.Location = New System.Drawing.Point(25, 52)
        Me.FatGramLabel.Name = "FatGramLabel"
        Me.FatGramLabel.Size = New System.Drawing.Size(113, 13)
        Me.FatGramLabel.TabIndex = 6
        Me.FatGramLabel.Text = "Enter total grams of fat"
        '
        'CarbohydrateGramLabel
        '
        Me.CarbohydrateGramLabel.AutoSize = True
        Me.CarbohydrateGramLabel.Location = New System.Drawing.Point(25, 90)
        Me.CarbohydrateGramLabel.Name = "CarbohydrateGramLabel"
        Me.CarbohydrateGramLabel.Size = New System.Drawing.Size(168, 13)
        Me.CarbohydrateGramLabel.TabIndex = 7
        Me.CarbohydrateGramLabel.Text = "Enter total grams of carbohydrates"
        '
        'ProteinGramLabel
        '
        Me.ProteinGramLabel.AutoSize = True
        Me.ProteinGramLabel.Location = New System.Drawing.Point(25, 130)
        Me.ProteinGramLabel.Name = "ProteinGramLabel"
        Me.ProteinGramLabel.Size = New System.Drawing.Size(133, 13)
        Me.ProteinGramLabel.TabIndex = 8
        Me.ProteinGramLabel.Text = "Enter total grams of protein"
        '
        'TotalCaloriesLabel
        '
        Me.TotalCaloriesLabel.AutoSize = True
        Me.TotalCaloriesLabel.Location = New System.Drawing.Point(204, 168)
        Me.TotalCaloriesLabel.Name = "TotalCaloriesLabel"
        Me.TotalCaloriesLabel.Size = New System.Drawing.Size(70, 13)
        Me.TotalCaloriesLabel.TabIndex = 9
        Me.TotalCaloriesLabel.Text = "Total calories"
        '
        'TotalItemsEnteredLabel
        '
        Me.TotalItemsEnteredLabel.AutoSize = True
        Me.TotalItemsEnteredLabel.Location = New System.Drawing.Point(204, 207)
        Me.TotalItemsEnteredLabel.Name = "TotalItemsEnteredLabel"
        Me.TotalItemsEnteredLabel.Size = New System.Drawing.Size(97, 13)
        Me.TotalItemsEnteredLabel.TabIndex = 10
        Me.TotalItemsEnteredLabel.Text = "Total items entered"
        '
        'ProteinGramInputTextBox
        '
        Me.ProteinGramInputTextBox.Location = New System.Drawing.Point(207, 127)
        Me.ProteinGramInputTextBox.Name = "ProteinGramInputTextBox"
        Me.ProteinGramInputTextBox.Size = New System.Drawing.Size(66, 20)
        Me.ProteinGramInputTextBox.TabIndex = 12
        '
        'CarbGramInputTextBox
        '
        Me.CarbGramInputTextBox.Location = New System.Drawing.Point(207, 87)
        Me.CarbGramInputTextBox.Name = "CarbGramInputTextBox"
        Me.CarbGramInputTextBox.Size = New System.Drawing.Size(66, 20)
        Me.CarbGramInputTextBox.TabIndex = 1
        '
        'FatGramInputTextBox
        '
        Me.FatGramInputTextBox.Location = New System.Drawing.Point(207, 49)
        Me.FatGramInputTextBox.Name = "FatGramInputTextBox"
        Me.FatGramInputTextBox.Size = New System.Drawing.Size(66, 20)
        Me.FatGramInputTextBox.TabIndex = 0
        '
        'CaloriesLabel
        '
        Me.CaloriesLabel.AutoSize = True
        Me.CaloriesLabel.Location = New System.Drawing.Point(295, 23)
        Me.CaloriesLabel.Name = "CaloriesLabel"
        Me.CaloriesLabel.Size = New System.Drawing.Size(88, 13)
        Me.CaloriesLabel.TabIndex = 15
        Me.CaloriesLabel.Text = "Calories per gram"
        '
        'TotalCalLabel
        '
        Me.TotalCalLabel.BackColor = System.Drawing.SystemColors.Window
        Me.TotalCalLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TotalCalLabel.Location = New System.Drawing.Point(306, 167)
        Me.TotalCalLabel.Name = "TotalCalLabel"
        Me.TotalCalLabel.Size = New System.Drawing.Size(66, 20)
        Me.TotalCalLabel.TabIndex = 16
        '
        'CalculateButton
        '
        Me.CalculateButton.Location = New System.Drawing.Point(90, 246)
        Me.CalculateButton.Name = "CalculateButton"
        Me.CalculateButton.Size = New System.Drawing.Size(112, 30)
        Me.CalculateButton.TabIndex = 17
        Me.CalculateButton.Text = "Calculate"
        Me.CalculateButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(208, 246)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(112, 30)
        Me.ClearButton.TabIndex = 18
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'PrintButton
        '
        Me.PrintButton.Location = New System.Drawing.Point(90, 299)
        Me.PrintButton.Name = "PrintButton"
        Me.PrintButton.Size = New System.Drawing.Size(112, 30)
        Me.PrintButton.TabIndex = 19
        Me.PrintButton.Text = "Print"
        Me.PrintButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(208, 299)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(112, 30)
        Me.ExitButton.TabIndex = 20
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'ProteinGramCalLabel
        '
        Me.ProteinGramCalLabel.BackColor = System.Drawing.SystemColors.Window
        Me.ProteinGramCalLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ProteinGramCalLabel.Location = New System.Drawing.Point(306, 127)
        Me.ProteinGramCalLabel.Name = "ProteinGramCalLabel"
        Me.ProteinGramCalLabel.Size = New System.Drawing.Size(66, 20)
        Me.ProteinGramCalLabel.TabIndex = 21
        '
        'CarbGramCalLabel
        '
        Me.CarbGramCalLabel.BackColor = System.Drawing.SystemColors.Window
        Me.CarbGramCalLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.CarbGramCalLabel.Location = New System.Drawing.Point(306, 87)
        Me.CarbGramCalLabel.Name = "CarbGramCalLabel"
        Me.CarbGramCalLabel.Size = New System.Drawing.Size(66, 20)
        Me.CarbGramCalLabel.TabIndex = 22
        '
        'FatGramCalLabel
        '
        Me.FatGramCalLabel.BackColor = System.Drawing.SystemColors.Window
        Me.FatGramCalLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.FatGramCalLabel.Location = New System.Drawing.Point(306, 49)
        Me.FatGramCalLabel.Name = "FatGramCalLabel"
        Me.FatGramCalLabel.Size = New System.Drawing.Size(66, 20)
        Me.FatGramCalLabel.TabIndex = 23
        '
        'TotalItemsLabel
        '
        Me.TotalItemsLabel.BackColor = System.Drawing.SystemColors.Window
        Me.TotalItemsLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TotalItemsLabel.Location = New System.Drawing.Point(306, 206)
        Me.TotalItemsLabel.Name = "TotalItemsLabel"
        Me.TotalItemsLabel.Size = New System.Drawing.Size(66, 20)
        Me.TotalItemsLabel.TabIndex = 24
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'ProgrammerLabel
        '
        Me.ProgrammerLabel.AutoSize = True
        Me.ProgrammerLabel.Location = New System.Drawing.Point(232, 346)
        Me.ProgrammerLabel.Name = "ProgrammerLabel"
        Me.ProgrammerLabel.Size = New System.Drawing.Size(167, 13)
        Me.ProgrammerLabel.TabIndex = 25
        Me.ProgrammerLabel.Text = "Programmed By: Arthur Buckowitz"
        '
        'CalorieCounterForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(411, 368)
        Me.Controls.Add(Me.ProgrammerLabel)
        Me.Controls.Add(Me.TotalItemsLabel)
        Me.Controls.Add(Me.FatGramCalLabel)
        Me.Controls.Add(Me.CarbGramCalLabel)
        Me.Controls.Add(Me.ProteinGramCalLabel)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.PrintButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.CalculateButton)
        Me.Controls.Add(Me.TotalCalLabel)
        Me.Controls.Add(Me.CaloriesLabel)
        Me.Controls.Add(Me.FatGramInputTextBox)
        Me.Controls.Add(Me.CarbGramInputTextBox)
        Me.Controls.Add(Me.ProteinGramInputTextBox)
        Me.Controls.Add(Me.TotalItemsEnteredLabel)
        Me.Controls.Add(Me.TotalCaloriesLabel)
        Me.Controls.Add(Me.ProteinGramLabel)
        Me.Controls.Add(Me.CarbohydrateGramLabel)
        Me.Controls.Add(Me.FatGramLabel)
        Me.Name = "CalorieCounterForm"
        Me.Text = "Calorie Counter"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FatGramLabel As System.Windows.Forms.Label
    Friend WithEvents CarbohydrateGramLabel As System.Windows.Forms.Label
    Friend WithEvents ProteinGramLabel As System.Windows.Forms.Label
    Friend WithEvents TotalCaloriesLabel As System.Windows.Forms.Label
    Friend WithEvents TotalItemsEnteredLabel As System.Windows.Forms.Label
    Friend WithEvents ProteinGramInputTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CarbGramInputTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FatGramInputTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CaloriesLabel As System.Windows.Forms.Label
    Friend WithEvents TotalCalLabel As System.Windows.Forms.Label
    Friend WithEvents CalculateButton As System.Windows.Forms.Button
    Friend WithEvents ClearButton As System.Windows.Forms.Button
    Friend WithEvents PrintButton As System.Windows.Forms.Button
    Friend WithEvents ExitButton As System.Windows.Forms.Button
    Friend WithEvents ProteinGramCalLabel As System.Windows.Forms.Label
    Friend WithEvents CarbGramCalLabel As System.Windows.Forms.Label
    Friend WithEvents FatGramCalLabel As System.Windows.Forms.Label
    Friend WithEvents TotalItemsLabel As System.Windows.Forms.Label
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents ProgrammerLabel As System.Windows.Forms.Label

End Class
