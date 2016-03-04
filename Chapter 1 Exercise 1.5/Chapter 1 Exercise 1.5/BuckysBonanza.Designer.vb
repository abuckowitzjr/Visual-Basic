<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BuckysBonanza
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BuckysBonanza))
        Me.SoupButton = New System.Windows.Forms.Button()
        Me.DinerNameLabel = New System.Windows.Forms.Label()
        Me.ChefButton = New System.Windows.Forms.Button()
        Me.FishButton = New System.Windows.Forms.Button()
        Me.PrintButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.SpecialsLabel = New System.Windows.Forms.Label()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.SuspendLayout()
        '
        'SoupButton
        '
        Me.SoupButton.Location = New System.Drawing.Point(42, 101)
        Me.SoupButton.Name = "SoupButton"
        Me.SoupButton.Size = New System.Drawing.Size(123, 31)
        Me.SoupButton.TabIndex = 0
        Me.SoupButton.Text = "Soup of the Day"
        Me.SoupButton.UseVisualStyleBackColor = True
        '
        'DinerNameLabel
        '
        Me.DinerNameLabel.AutoSize = True
        Me.DinerNameLabel.Font = New System.Drawing.Font("Segoe Script", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DinerNameLabel.Location = New System.Drawing.Point(21, 8)
        Me.DinerNameLabel.Name = "DinerNameLabel"
        Me.DinerNameLabel.Size = New System.Drawing.Size(306, 53)
        Me.DinerNameLabel.TabIndex = 1
        Me.DinerNameLabel.Text = "Bucky's Bonanza"
        '
        'ChefButton
        '
        Me.ChefButton.Location = New System.Drawing.Point(184, 101)
        Me.ChefButton.Name = "ChefButton"
        Me.ChefButton.Size = New System.Drawing.Size(123, 31)
        Me.ChefButton.TabIndex = 2
        Me.ChefButton.Text = "Chef's Special"
        Me.ChefButton.UseVisualStyleBackColor = True
        '
        'FishButton
        '
        Me.FishButton.Location = New System.Drawing.Point(113, 138)
        Me.FishButton.Name = "FishButton"
        Me.FishButton.Size = New System.Drawing.Size(123, 31)
        Me.FishButton.TabIndex = 3
        Me.FishButton.Text = "Daily Fish"
        Me.FishButton.UseVisualStyleBackColor = True
        '
        'PrintButton
        '
        Me.PrintButton.Location = New System.Drawing.Point(113, 194)
        Me.PrintButton.Name = "PrintButton"
        Me.PrintButton.Size = New System.Drawing.Size(123, 31)
        Me.PrintButton.TabIndex = 4
        Me.PrintButton.Text = "Print"
        Me.PrintButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(113, 231)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(123, 31)
        Me.ExitButton.TabIndex = 5
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'SpecialsLabel
        '
        Me.SpecialsLabel.BackColor = System.Drawing.Color.White
        Me.SpecialsLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SpecialsLabel.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SpecialsLabel.Location = New System.Drawing.Point(42, 67)
        Me.SpecialsLabel.Name = "SpecialsLabel"
        Me.SpecialsLabel.Size = New System.Drawing.Size(265, 23)
        Me.SpecialsLabel.TabIndex = 6
        Me.SpecialsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Location = New System.Drawing.Point(174, 277)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(163, 13)
        Me.NameLabel.TabIndex = 7
        Me.NameLabel.Text = "Programmed by Arthur Buckowitz"
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'BuckysBonanza
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(349, 297)
        Me.Controls.Add(Me.NameLabel)
        Me.Controls.Add(Me.SpecialsLabel)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.PrintButton)
        Me.Controls.Add(Me.FishButton)
        Me.Controls.Add(Me.ChefButton)
        Me.Controls.Add(Me.DinerNameLabel)
        Me.Controls.Add(Me.SoupButton)
        Me.Name = "BuckysBonanza"
        Me.Text = "Bucky's Bonanza"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SoupButton As System.Windows.Forms.Button
    Friend WithEvents DinerNameLabel As System.Windows.Forms.Label
    Friend WithEvents ChefButton As System.Windows.Forms.Button
    Friend WithEvents FishButton As System.Windows.Forms.Button
    Friend WithEvents PrintButton As System.Windows.Forms.Button
    Friend WithEvents ExitButton As System.Windows.Forms.Button
    Friend WithEvents SpecialsLabel As System.Windows.Forms.Label
    Friend WithEvents NameLabel As System.Windows.Forms.Label
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm

End Class
