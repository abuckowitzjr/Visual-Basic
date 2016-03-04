<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HowToConductForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HowToConductForm))
        Me.LiveButton = New System.Windows.Forms.Button()
        Me.SingButton = New System.Windows.Forms.Button()
        Me.DanceButton = New System.Windows.Forms.Button()
        Me.LaughButton = New System.Windows.Forms.Button()
        Me.PrintButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.MessageLabel = New System.Windows.Forms.Label()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LiveButton
        '
        Me.LiveButton.Location = New System.Drawing.Point(24, 89)
        Me.LiveButton.Name = "LiveButton"
        Me.LiveButton.Size = New System.Drawing.Size(133, 38)
        Me.LiveButton.TabIndex = 0
        Me.LiveButton.Text = "Live"
        Me.LiveButton.UseVisualStyleBackColor = True
        '
        'SingButton
        '
        Me.SingButton.Location = New System.Drawing.Point(163, 89)
        Me.SingButton.Name = "SingButton"
        Me.SingButton.Size = New System.Drawing.Size(133, 38)
        Me.SingButton.TabIndex = 1
        Me.SingButton.Text = "Sing"
        Me.SingButton.UseVisualStyleBackColor = True
        '
        'DanceButton
        '
        Me.DanceButton.Location = New System.Drawing.Point(302, 89)
        Me.DanceButton.Name = "DanceButton"
        Me.DanceButton.Size = New System.Drawing.Size(133, 38)
        Me.DanceButton.TabIndex = 2
        Me.DanceButton.Text = "Dance"
        Me.DanceButton.UseVisualStyleBackColor = True
        '
        'LaughButton
        '
        Me.LaughButton.Location = New System.Drawing.Point(441, 89)
        Me.LaughButton.Name = "LaughButton"
        Me.LaughButton.Size = New System.Drawing.Size(133, 38)
        Me.LaughButton.TabIndex = 3
        Me.LaughButton.Text = "Laugh"
        Me.LaughButton.UseVisualStyleBackColor = True
        '
        'PrintButton
        '
        Me.PrintButton.Location = New System.Drawing.Point(233, 133)
        Me.PrintButton.Name = "PrintButton"
        Me.PrintButton.Size = New System.Drawing.Size(133, 38)
        Me.PrintButton.TabIndex = 4
        Me.PrintButton.Text = "Print"
        Me.PrintButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(233, 177)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(133, 38)
        Me.ExitButton.TabIndex = 5
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'MessageLabel
        '
        Me.MessageLabel.BackColor = System.Drawing.Color.White
        Me.MessageLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.MessageLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MessageLabel.Location = New System.Drawing.Point(24, 29)
        Me.MessageLabel.Name = "MessageLabel"
        Me.MessageLabel.Size = New System.Drawing.Size(550, 42)
        Me.MessageLabel.TabIndex = 6
        Me.MessageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Location = New System.Drawing.Point(424, 224)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(163, 13)
        Me.NameLabel.TabIndex = 7
        Me.NameLabel.Text = "Programmed by Arthur Buckowitz"
        '
        'HowToConductForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(599, 246)
        Me.Controls.Add(Me.NameLabel)
        Me.Controls.Add(Me.MessageLabel)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.PrintButton)
        Me.Controls.Add(Me.LaughButton)
        Me.Controls.Add(Me.DanceButton)
        Me.Controls.Add(Me.SingButton)
        Me.Controls.Add(Me.LiveButton)
        Me.Name = "HowToConductForm"
        Me.Text = "How to Conduct Oneself"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LiveButton As System.Windows.Forms.Button
    Friend WithEvents SingButton As System.Windows.Forms.Button
    Friend WithEvents DanceButton As System.Windows.Forms.Button
    Friend WithEvents LaughButton As System.Windows.Forms.Button
    Friend WithEvents PrintButton As System.Windows.Forms.Button
    Friend WithEvents ExitButton As System.Windows.Forms.Button
    Friend WithEvents MessageLabel As System.Windows.Forms.Label
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents NameLabel As System.Windows.Forms.Label

End Class
