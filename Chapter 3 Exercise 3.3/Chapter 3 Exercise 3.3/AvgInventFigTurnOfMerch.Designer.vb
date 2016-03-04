<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AvgInventFigTurnOfMerch
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AvgInventFigTurnOfMerch))
        Me.BeginningInvLabel = New System.Windows.Forms.Label()
        Me.EndingInvLabel = New System.Windows.Forms.Label()
        Me.CostOfGoodsSoldLabel = New System.Windows.Forms.Label()
        Me.AverageInvLabel = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CalculateButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.PrintButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.AverageInvTextBox = New System.Windows.Forms.TextBox()
        Me.TurnoverTextBox = New System.Windows.Forms.TextBox()
        Me.ProgrammerLabel = New System.Windows.Forms.Label()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.BeginningInvTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.CostOfGoodsSoldTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.EndingInvTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.SuspendLayout()
        '
        'BeginningInvLabel
        '
        Me.BeginningInvLabel.AutoSize = True
        Me.BeginningInvLabel.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BeginningInvLabel.Location = New System.Drawing.Point(27, 28)
        Me.BeginningInvLabel.Name = "BeginningInvLabel"
        Me.BeginningInvLabel.Size = New System.Drawing.Size(154, 19)
        Me.BeginningInvLabel.TabIndex = 0
        Me.BeginningInvLabel.Text = "Beginning Inventory:"
        '
        'EndingInvLabel
        '
        Me.EndingInvLabel.AutoSize = True
        Me.EndingInvLabel.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EndingInvLabel.Location = New System.Drawing.Point(48, 64)
        Me.EndingInvLabel.Name = "EndingInvLabel"
        Me.EndingInvLabel.Size = New System.Drawing.Size(133, 19)
        Me.EndingInvLabel.TabIndex = 1
        Me.EndingInvLabel.Text = "Ending Inventory:"
        '
        'CostOfGoodsSoldLabel
        '
        Me.CostOfGoodsSoldLabel.AutoSize = True
        Me.CostOfGoodsSoldLabel.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CostOfGoodsSoldLabel.Location = New System.Drawing.Point(38, 101)
        Me.CostOfGoodsSoldLabel.Name = "CostOfGoodsSoldLabel"
        Me.CostOfGoodsSoldLabel.Size = New System.Drawing.Size(143, 19)
        Me.CostOfGoodsSoldLabel.TabIndex = 2
        Me.CostOfGoodsSoldLabel.Text = "Cost of Goods Sold:"
        '
        'AverageInvLabel
        '
        Me.AverageInvLabel.AutoSize = True
        Me.AverageInvLabel.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AverageInvLabel.Location = New System.Drawing.Point(332, 46)
        Me.AverageInvLabel.Name = "AverageInvLabel"
        Me.AverageInvLabel.Size = New System.Drawing.Size(141, 19)
        Me.AverageInvLabel.TabIndex = 6
        Me.AverageInvLabel.Text = "Average Inventory:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(394, 83)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 19)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Turnover:"
        '
        'CalculateButton
        '
        Me.CalculateButton.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CalculateButton.Location = New System.Drawing.Point(231, 142)
        Me.CalculateButton.Name = "CalculateButton"
        Me.CalculateButton.Size = New System.Drawing.Size(99, 38)
        Me.CalculateButton.TabIndex = 3
        Me.CalculateButton.Text = "Calculate"
        Me.CalculateButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearButton.Location = New System.Drawing.Point(336, 142)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(99, 38)
        Me.ClearButton.TabIndex = 4
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'PrintButton
        '
        Me.PrintButton.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrintButton.Location = New System.Drawing.Point(231, 186)
        Me.PrintButton.Name = "PrintButton"
        Me.PrintButton.Size = New System.Drawing.Size(99, 38)
        Me.PrintButton.TabIndex = 5
        Me.PrintButton.Text = "Print"
        Me.PrintButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitButton.Location = New System.Drawing.Point(336, 186)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(99, 38)
        Me.ExitButton.TabIndex = 6
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'AverageInvTextBox
        '
        Me.AverageInvTextBox.BackColor = System.Drawing.Color.White
        Me.AverageInvTextBox.Location = New System.Drawing.Point(479, 47)
        Me.AverageInvTextBox.Name = "AverageInvTextBox"
        Me.AverageInvTextBox.ReadOnly = True
        Me.AverageInvTextBox.Size = New System.Drawing.Size(156, 20)
        Me.AverageInvTextBox.TabIndex = 14
        '
        'TurnoverTextBox
        '
        Me.TurnoverTextBox.BackColor = System.Drawing.Color.White
        Me.TurnoverTextBox.Location = New System.Drawing.Point(479, 84)
        Me.TurnoverTextBox.Name = "TurnoverTextBox"
        Me.TurnoverTextBox.ReadOnly = True
        Me.TurnoverTextBox.Size = New System.Drawing.Size(156, 20)
        Me.TurnoverTextBox.TabIndex = 15
        '
        'ProgrammerLabel
        '
        Me.ProgrammerLabel.AutoSize = True
        Me.ProgrammerLabel.Location = New System.Drawing.Point(487, 232)
        Me.ProgrammerLabel.Name = "ProgrammerLabel"
        Me.ProgrammerLabel.Size = New System.Drawing.Size(167, 13)
        Me.ProgrammerLabel.TabIndex = 16
        Me.ProgrammerLabel.Text = "Programmed By: Arthur Buckowitz"
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'BeginningInvTextBox
        '
        Me.BeginningInvTextBox.Location = New System.Drawing.Point(187, 29)
        Me.BeginningInvTextBox.Mask = "00000000000000000000"
        Me.BeginningInvTextBox.Name = "BeginningInvTextBox"
        Me.BeginningInvTextBox.Size = New System.Drawing.Size(127, 20)
        Me.BeginningInvTextBox.TabIndex = 0
        '
        'CostOfGoodsSoldTextBox
        '
        Me.CostOfGoodsSoldTextBox.Location = New System.Drawing.Point(187, 102)
        Me.CostOfGoodsSoldTextBox.Mask = "00000000000000000000"
        Me.CostOfGoodsSoldTextBox.Name = "CostOfGoodsSoldTextBox"
        Me.CostOfGoodsSoldTextBox.Size = New System.Drawing.Size(127, 20)
        Me.CostOfGoodsSoldTextBox.TabIndex = 2
        '
        'EndingInvTextBox
        '
        Me.EndingInvTextBox.Location = New System.Drawing.Point(187, 65)
        Me.EndingInvTextBox.Mask = "00000000000000000000"
        Me.EndingInvTextBox.Name = "EndingInvTextBox"
        Me.EndingInvTextBox.Size = New System.Drawing.Size(127, 20)
        Me.EndingInvTextBox.TabIndex = 1
        '
        'AvgInventFigTurnOfMerch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(666, 254)
        Me.Controls.Add(Me.EndingInvTextBox)
        Me.Controls.Add(Me.CostOfGoodsSoldTextBox)
        Me.Controls.Add(Me.BeginningInvTextBox)
        Me.Controls.Add(Me.ProgrammerLabel)
        Me.Controls.Add(Me.TurnoverTextBox)
        Me.Controls.Add(Me.AverageInvTextBox)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.PrintButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.CalculateButton)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.AverageInvLabel)
        Me.Controls.Add(Me.CostOfGoodsSoldLabel)
        Me.Controls.Add(Me.EndingInvLabel)
        Me.Controls.Add(Me.BeginningInvLabel)
        Me.Name = "AvgInventFigTurnOfMerch"
        Me.Text = "Average Inventory Figure/Turnover of Merchandise Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BeginningInvLabel As System.Windows.Forms.Label
    Friend WithEvents EndingInvLabel As System.Windows.Forms.Label
    Friend WithEvents CostOfGoodsSoldLabel As System.Windows.Forms.Label
    Friend WithEvents AverageInvLabel As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents CalculateButton As System.Windows.Forms.Button
    Friend WithEvents ClearButton As System.Windows.Forms.Button
    Friend WithEvents PrintButton As System.Windows.Forms.Button
    Friend WithEvents ExitButton As System.Windows.Forms.Button
    Friend WithEvents AverageInvTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TurnoverTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ProgrammerLabel As System.Windows.Forms.Label
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents EndingInvTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents CostOfGoodsSoldTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents BeginningInvTextBox As System.Windows.Forms.MaskedTextBox

End Class
