<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EarningsCalculatorForm
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
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.CompletedPiecesTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CalculateButton = New System.Windows.Forms.Button()
        Me.SummaryButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.ClearAllButton = New System.Windows.Forms.Button()
        Me.DollarAmountEarnedTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TotalPiecesTextBox = New System.Windows.Forms.TextBox()
        Me.AveragePayTextBox = New System.Windows.Forms.TextBox()
        Me.TotalPayTextBox = New System.Windows.Forms.TextBox()
        Me.TotalPayLabel = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'NameTextBox
        '
        Me.NameTextBox.Location = New System.Drawing.Point(163, 38)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(177, 22)
        Me.NameTextBox.TabIndex = 0
        '
        'CompletedPiecesTextBox
        '
        Me.CompletedPiecesTextBox.Location = New System.Drawing.Point(240, 78)
        Me.CompletedPiecesTextBox.Name = "CompletedPiecesTextBox"
        Me.CompletedPiecesTextBox.Size = New System.Drawing.Size(100, 22)
        Me.CompletedPiecesTextBox.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(42, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Employee Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(42, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(195, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Number of Pieces Completed:"
        '
        'CalculateButton
        '
        Me.CalculateButton.Location = New System.Drawing.Point(79, 165)
        Me.CalculateButton.Name = "CalculateButton"
        Me.CalculateButton.Size = New System.Drawing.Size(110, 50)
        Me.CalculateButton.TabIndex = 3
        Me.CalculateButton.Text = "Calculate"
        Me.CalculateButton.UseVisualStyleBackColor = True
        '
        'SummaryButton
        '
        Me.SummaryButton.Location = New System.Drawing.Point(79, 369)
        Me.SummaryButton.Name = "SummaryButton"
        Me.SummaryButton.Size = New System.Drawing.Size(110, 50)
        Me.SummaryButton.TabIndex = 5
        Me.SummaryButton.Text = "Summary"
        Me.SummaryButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(195, 165)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(110, 50)
        Me.ClearButton.TabIndex = 4
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'ClearAllButton
        '
        Me.ClearAllButton.Location = New System.Drawing.Point(195, 369)
        Me.ClearAllButton.Name = "ClearAllButton"
        Me.ClearAllButton.Size = New System.Drawing.Size(110, 50)
        Me.ClearAllButton.TabIndex = 6
        Me.ClearAllButton.Text = "Clear All"
        Me.ClearAllButton.UseVisualStyleBackColor = True
        '
        'DollarAmountEarnedTextBox
        '
        Me.DollarAmountEarnedTextBox.BackColor = System.Drawing.Color.White
        Me.DollarAmountEarnedTextBox.Location = New System.Drawing.Point(197, 118)
        Me.DollarAmountEarnedTextBox.Name = "DollarAmountEarnedTextBox"
        Me.DollarAmountEarnedTextBox.ReadOnly = True
        Me.DollarAmountEarnedTextBox.Size = New System.Drawing.Size(143, 22)
        Me.DollarAmountEarnedTextBox.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(42, 121)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(151, 17)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Dollar Amount Earned:"
        '
        'TotalPiecesTextBox
        '
        Me.TotalPiecesTextBox.BackColor = System.Drawing.Color.White
        Me.TotalPiecesTextBox.Location = New System.Drawing.Point(138, 244)
        Me.TotalPiecesTextBox.Name = "TotalPiecesTextBox"
        Me.TotalPiecesTextBox.ReadOnly = True
        Me.TotalPiecesTextBox.Size = New System.Drawing.Size(202, 22)
        Me.TotalPiecesTextBox.TabIndex = 997
        '
        'AveragePayTextBox
        '
        Me.AveragePayTextBox.BackColor = System.Drawing.Color.White
        Me.AveragePayTextBox.Location = New System.Drawing.Point(138, 323)
        Me.AveragePayTextBox.Name = "AveragePayTextBox"
        Me.AveragePayTextBox.ReadOnly = True
        Me.AveragePayTextBox.Size = New System.Drawing.Size(202, 22)
        Me.AveragePayTextBox.TabIndex = 999
        '
        'TotalPayTextBox
        '
        Me.TotalPayTextBox.BackColor = System.Drawing.Color.White
        Me.TotalPayTextBox.Location = New System.Drawing.Point(138, 284)
        Me.TotalPayTextBox.Name = "TotalPayTextBox"
        Me.TotalPayTextBox.ReadOnly = True
        Me.TotalPayTextBox.Size = New System.Drawing.Size(202, 22)
        Me.TotalPayTextBox.TabIndex = 998
        '
        'TotalPayLabel
        '
        Me.TotalPayLabel.AutoSize = True
        Me.TotalPayLabel.Location = New System.Drawing.Point(42, 284)
        Me.TotalPayLabel.Name = "TotalPayLabel"
        Me.TotalPayLabel.Size = New System.Drawing.Size(72, 17)
        Me.TotalPayLabel.TabIndex = 13
        Me.TotalPayLabel.Text = "Total Pay:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(42, 244)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 17)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Total Pieces:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(42, 323)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 17)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Average Pay:"
        '
        'EarningsCalculatorForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 458)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TotalPayLabel)
        Me.Controls.Add(Me.TotalPayTextBox)
        Me.Controls.Add(Me.AveragePayTextBox)
        Me.Controls.Add(Me.TotalPiecesTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DollarAmountEarnedTextBox)
        Me.Controls.Add(Me.ClearAllButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.SummaryButton)
        Me.Controls.Add(Me.CalculateButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CompletedPiecesTextBox)
        Me.Controls.Add(Me.NameTextBox)
        Me.Name = "EarningsCalculatorForm"
        Me.Text = "Earnings Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CompletedPiecesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CalculateButton As System.Windows.Forms.Button
    Friend WithEvents SummaryButton As System.Windows.Forms.Button
    Friend WithEvents ClearButton As System.Windows.Forms.Button
    Friend WithEvents ClearAllButton As System.Windows.Forms.Button
    Friend WithEvents DollarAmountEarnedTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TotalPiecesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AveragePayTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TotalPayTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TotalPayLabel As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label


End Class
