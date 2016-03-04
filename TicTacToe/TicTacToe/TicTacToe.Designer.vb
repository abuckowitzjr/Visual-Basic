<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TicTacToeForm
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
        Me.TLButton = New System.Windows.Forms.Button()
        Me.TCButton = New System.Windows.Forms.Button()
        Me.TRButton = New System.Windows.Forms.Button()
        Me.MLButton = New System.Windows.Forms.Button()
        Me.MCButton = New System.Windows.Forms.Button()
        Me.MRButton = New System.Windows.Forms.Button()
        Me.BLButton = New System.Windows.Forms.Button()
        Me.BMButton = New System.Windows.Forms.Button()
        Me.BRButton = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ResetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ButtonColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ContextResetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextButtonColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TLButton
        '
        Me.TLButton.BackColor = System.Drawing.Color.Silver
        Me.TLButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TLButton.Location = New System.Drawing.Point(64, 83)
        Me.TLButton.Margin = New System.Windows.Forms.Padding(4)
        Me.TLButton.Name = "TLButton"
        Me.TLButton.Size = New System.Drawing.Size(110, 88)
        Me.TLButton.TabIndex = 0
        Me.TLButton.UseVisualStyleBackColor = False
        '
        'TCButton
        '
        Me.TCButton.BackColor = System.Drawing.Color.Silver
        Me.TCButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TCButton.Location = New System.Drawing.Point(182, 83)
        Me.TCButton.Margin = New System.Windows.Forms.Padding(4)
        Me.TCButton.Name = "TCButton"
        Me.TCButton.Size = New System.Drawing.Size(110, 88)
        Me.TCButton.TabIndex = 1
        Me.TCButton.UseVisualStyleBackColor = False
        '
        'TRButton
        '
        Me.TRButton.BackColor = System.Drawing.Color.Silver
        Me.TRButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TRButton.Location = New System.Drawing.Point(300, 83)
        Me.TRButton.Margin = New System.Windows.Forms.Padding(4)
        Me.TRButton.Name = "TRButton"
        Me.TRButton.Size = New System.Drawing.Size(110, 88)
        Me.TRButton.TabIndex = 2
        Me.TRButton.UseVisualStyleBackColor = False
        '
        'MLButton
        '
        Me.MLButton.BackColor = System.Drawing.Color.Silver
        Me.MLButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MLButton.Location = New System.Drawing.Point(64, 179)
        Me.MLButton.Margin = New System.Windows.Forms.Padding(4)
        Me.MLButton.Name = "MLButton"
        Me.MLButton.Size = New System.Drawing.Size(110, 88)
        Me.MLButton.TabIndex = 3
        Me.MLButton.UseVisualStyleBackColor = False
        '
        'MCButton
        '
        Me.MCButton.BackColor = System.Drawing.Color.Silver
        Me.MCButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MCButton.Location = New System.Drawing.Point(182, 179)
        Me.MCButton.Margin = New System.Windows.Forms.Padding(4)
        Me.MCButton.Name = "MCButton"
        Me.MCButton.Size = New System.Drawing.Size(110, 88)
        Me.MCButton.TabIndex = 4
        Me.MCButton.UseVisualStyleBackColor = False
        '
        'MRButton
        '
        Me.MRButton.BackColor = System.Drawing.Color.Silver
        Me.MRButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MRButton.Location = New System.Drawing.Point(300, 179)
        Me.MRButton.Margin = New System.Windows.Forms.Padding(4)
        Me.MRButton.Name = "MRButton"
        Me.MRButton.Size = New System.Drawing.Size(110, 88)
        Me.MRButton.TabIndex = 5
        Me.MRButton.UseVisualStyleBackColor = False
        '
        'BLButton
        '
        Me.BLButton.BackColor = System.Drawing.Color.Silver
        Me.BLButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BLButton.Location = New System.Drawing.Point(64, 275)
        Me.BLButton.Margin = New System.Windows.Forms.Padding(4)
        Me.BLButton.Name = "BLButton"
        Me.BLButton.Size = New System.Drawing.Size(110, 88)
        Me.BLButton.TabIndex = 6
        Me.BLButton.UseVisualStyleBackColor = False
        '
        'BMButton
        '
        Me.BMButton.BackColor = System.Drawing.Color.Silver
        Me.BMButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BMButton.Location = New System.Drawing.Point(182, 275)
        Me.BMButton.Margin = New System.Windows.Forms.Padding(4)
        Me.BMButton.Name = "BMButton"
        Me.BMButton.Size = New System.Drawing.Size(110, 88)
        Me.BMButton.TabIndex = 7
        Me.BMButton.UseVisualStyleBackColor = False
        '
        'BRButton
        '
        Me.BRButton.BackColor = System.Drawing.Color.Silver
        Me.BRButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BRButton.Location = New System.Drawing.Point(300, 275)
        Me.BRButton.Margin = New System.Windows.Forms.Padding(4)
        Me.BRButton.Name = "BRButton"
        Me.BRButton.Size = New System.Drawing.Size(110, 88)
        Me.BRButton.TabIndex = 8
        Me.BRButton.UseVisualStyleBackColor = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ResetToolStripMenuItem, Me.ButtonColorToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(475, 28)
        Me.MenuStrip1.TabIndex = 9
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ResetToolStripMenuItem
        '
        Me.ResetToolStripMenuItem.Name = "ResetToolStripMenuItem"
        Me.ResetToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.ResetToolStripMenuItem.Size = New System.Drawing.Size(57, 24)
        Me.ResetToolStripMenuItem.Text = "Reset"
        '
        'ButtonColorToolStripMenuItem
        '
        Me.ButtonColorToolStripMenuItem.Name = "ButtonColorToolStripMenuItem"
        Me.ButtonColorToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.ButtonColorToolStripMenuItem.Size = New System.Drawing.Size(105, 24)
        Me.ButtonColorToolStripMenuItem.Text = "Button Color"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.H), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(45, 24)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ContextResetToolStripMenuItem, Me.ContextButtonColorToolStripMenuItem, Me.CExitToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(163, 98)
        '
        'ContextResetToolStripMenuItem
        '
        Me.ContextResetToolStripMenuItem.Name = "ContextResetToolStripMenuItem"
        Me.ContextResetToolStripMenuItem.Size = New System.Drawing.Size(162, 24)
        Me.ContextResetToolStripMenuItem.Text = "Reset"
        '
        'ContextButtonColorToolStripMenuItem
        '
        Me.ContextButtonColorToolStripMenuItem.Name = "ContextButtonColorToolStripMenuItem"
        Me.ContextButtonColorToolStripMenuItem.Size = New System.Drawing.Size(162, 24)
        Me.ContextButtonColorToolStripMenuItem.Text = "Button Color"
        '
        'CExitToolStripMenuItem
        '
        Me.CExitToolStripMenuItem.Name = "CExitToolStripMenuItem"
        Me.CExitToolStripMenuItem.Size = New System.Drawing.Size(162, 24)
        Me.CExitToolStripMenuItem.Text = "Exit"
        '
        'TicTacToeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(475, 423)
        Me.ContextMenuStrip = Me.ContextMenuStrip1
        Me.ControlBox = False
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.MCButton)
        Me.Controls.Add(Me.BRButton)
        Me.Controls.Add(Me.BLButton)
        Me.Controls.Add(Me.BMButton)
        Me.Controls.Add(Me.MRButton)
        Me.Controls.Add(Me.MLButton)
        Me.Controls.Add(Me.TRButton)
        Me.Controls.Add(Me.TLButton)
        Me.Controls.Add(Me.TCButton)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "TicTacToeForm"
        Me.Text = "Tic Tac Toe"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TLButton As System.Windows.Forms.Button
    Friend WithEvents TCButton As System.Windows.Forms.Button
    Friend WithEvents TRButton As System.Windows.Forms.Button
    Friend WithEvents MLButton As System.Windows.Forms.Button
    Friend WithEvents MCButton As System.Windows.Forms.Button
    Friend WithEvents MRButton As System.Windows.Forms.Button
    Friend WithEvents BLButton As System.Windows.Forms.Button
    Friend WithEvents BMButton As System.Windows.Forms.Button
    Friend WithEvents BRButton As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ResetToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ButtonColorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ContextResetToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextButtonColorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
