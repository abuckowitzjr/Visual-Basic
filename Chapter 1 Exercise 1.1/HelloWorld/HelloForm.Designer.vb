<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HelloForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HelloForm))
        Me.MessageLabel = New System.Windows.Forms.Label()
        Me.EnglishButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.SpanishButton = New System.Windows.Forms.Button()
        Me.PrintButton = New System.Windows.Forms.Button()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.FrenchButton = New System.Windows.Forms.Button()
        Me.ItalianButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'MessageLabel
        '
        Me.MessageLabel.BackColor = System.Drawing.Color.White
        Me.MessageLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.MessageLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MessageLabel.Location = New System.Drawing.Point(103, 35)
        Me.MessageLabel.Name = "MessageLabel"
        Me.MessageLabel.Size = New System.Drawing.Size(196, 20)
        Me.MessageLabel.TabIndex = 0
        Me.MessageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'EnglishButton
        '
        Me.EnglishButton.Location = New System.Drawing.Point(83, 91)
        Me.EnglishButton.Name = "EnglishButton"
        Me.EnglishButton.Size = New System.Drawing.Size(115, 42)
        Me.EnglishButton.TabIndex = 1
        Me.EnglishButton.Text = "English"
        Me.EnglishButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(144, 235)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(115, 42)
        Me.ExitButton.TabIndex = 2
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Location = New System.Drawing.Point(228, 305)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(163, 13)
        Me.NameLabel.TabIndex = 3
        Me.NameLabel.Text = "Programmed by Arthur Buckowitz"
        '
        'SpanishButton
        '
        Me.SpanishButton.Location = New System.Drawing.Point(204, 91)
        Me.SpanishButton.Name = "SpanishButton"
        Me.SpanishButton.Size = New System.Drawing.Size(115, 42)
        Me.SpanishButton.TabIndex = 4
        Me.SpanishButton.Text = "Spanish"
        Me.SpanishButton.UseVisualStyleBackColor = True
        '
        'PrintButton
        '
        Me.PrintButton.Location = New System.Drawing.Point(144, 187)
        Me.PrintButton.Name = "PrintButton"
        Me.PrintButton.Size = New System.Drawing.Size(115, 42)
        Me.PrintButton.TabIndex = 5
        Me.PrintButton.Text = "Print"
        Me.PrintButton.UseVisualStyleBackColor = True
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'FrenchButton
        '
        Me.FrenchButton.Location = New System.Drawing.Point(83, 139)
        Me.FrenchButton.Name = "FrenchButton"
        Me.FrenchButton.Size = New System.Drawing.Size(115, 42)
        Me.FrenchButton.TabIndex = 6
        Me.FrenchButton.Text = "French"
        Me.FrenchButton.UseVisualStyleBackColor = True
        '
        'ItalianButton
        '
        Me.ItalianButton.Location = New System.Drawing.Point(204, 139)
        Me.ItalianButton.Name = "ItalianButton"
        Me.ItalianButton.Size = New System.Drawing.Size(115, 42)
        Me.ItalianButton.TabIndex = 7
        Me.ItalianButton.Text = "Italian"
        Me.ItalianButton.UseVisualStyleBackColor = True
        '
        'HelloForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(403, 331)
        Me.Controls.Add(Me.ItalianButton)
        Me.Controls.Add(Me.FrenchButton)
        Me.Controls.Add(Me.PrintButton)
        Me.Controls.Add(Me.SpanishButton)
        Me.Controls.Add(Me.NameLabel)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.EnglishButton)
        Me.Controls.Add(Me.MessageLabel)
        Me.Name = "HelloForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Hello World"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MessageLabel As System.Windows.Forms.Label
    Friend WithEvents EnglishButton As System.Windows.Forms.Button
    Friend WithEvents ExitButton As System.Windows.Forms.Button
    Friend WithEvents NameLabel As System.Windows.Forms.Label
    Friend WithEvents SpanishButton As System.Windows.Forms.Button
    Friend WithEvents PrintButton As System.Windows.Forms.Button
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents ItalianButton As System.Windows.Forms.Button
    Friend WithEvents FrenchButton As System.Windows.Forms.Button

End Class
