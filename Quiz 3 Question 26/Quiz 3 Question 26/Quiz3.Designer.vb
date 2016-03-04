<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuiz3
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblNewPerson = New System.Windows.Forms.Label()
        Me.txtNewPerson = New System.Windows.Forms.TextBox()
        Me.btnHire = New System.Windows.Forms.Button()
        Me.lstboxCurrentEmployees = New System.Windows.Forms.ListBox()
        Me.lblCurrentEmployees = New System.Windows.Forms.Label()
        Me.btnFire = New System.Windows.Forms.Button()
        Me.btnReHire = New System.Windows.Forms.Button()
        Me.lblTotalCurrentEmployees = New System.Windows.Forms.Label()
        Me.lstboxPastEmployees = New System.Windows.Forms.ListBox()
        Me.lblPastEmployees = New System.Windows.Forms.Label()
        Me.lblTotalPastEmployees = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(681, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(45, 24)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(62, 24)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'lblNewPerson
        '
        Me.lblNewPerson.AutoSize = True
        Me.lblNewPerson.Location = New System.Drawing.Point(54, 57)
        Me.lblNewPerson.Name = "lblNewPerson"
        Me.lblNewPerson.Size = New System.Drawing.Size(84, 17)
        Me.lblNewPerson.TabIndex = 1
        Me.lblNewPerson.Text = "New Person"
        '
        'txtNewPerson
        '
        Me.txtNewPerson.Location = New System.Drawing.Point(144, 54)
        Me.txtNewPerson.Name = "txtNewPerson"
        Me.txtNewPerson.Size = New System.Drawing.Size(201, 22)
        Me.txtNewPerson.TabIndex = 0
        '
        'btnHire
        '
        Me.btnHire.Location = New System.Drawing.Point(356, 52)
        Me.btnHire.Name = "btnHire"
        Me.btnHire.Size = New System.Drawing.Size(118, 26)
        Me.btnHire.TabIndex = 1
        Me.btnHire.Text = "Hire"
        Me.btnHire.UseVisualStyleBackColor = True
        '
        'lstboxCurrentEmployees
        '
        Me.lstboxCurrentEmployees.FormattingEnabled = True
        Me.lstboxCurrentEmployees.ItemHeight = 16
        Me.lstboxCurrentEmployees.Items.AddRange(New Object() {"Bob", "Cheryl", "Joe", "Rob"})
        Me.lstboxCurrentEmployees.Location = New System.Drawing.Point(38, 147)
        Me.lstboxCurrentEmployees.Name = "lstboxCurrentEmployees"
        Me.lstboxCurrentEmployees.Size = New System.Drawing.Size(218, 180)
        Me.lstboxCurrentEmployees.Sorted = True
        Me.lstboxCurrentEmployees.TabIndex = 2
        '
        'lblCurrentEmployees
        '
        Me.lblCurrentEmployees.AutoSize = True
        Me.lblCurrentEmployees.Location = New System.Drawing.Point(35, 121)
        Me.lblCurrentEmployees.Name = "lblCurrentEmployees"
        Me.lblCurrentEmployees.Size = New System.Drawing.Size(128, 17)
        Me.lblCurrentEmployees.TabIndex = 5
        Me.lblCurrentEmployees.Text = "Current Employees"
        '
        'btnFire
        '
        Me.btnFire.Location = New System.Drawing.Point(262, 194)
        Me.btnFire.Name = "btnFire"
        Me.btnFire.Size = New System.Drawing.Size(155, 26)
        Me.btnFire.TabIndex = 3
        Me.btnFire.Text = "Fire"
        Me.btnFire.UseVisualStyleBackColor = True
        '
        'btnReHire
        '
        Me.btnReHire.Location = New System.Drawing.Point(262, 239)
        Me.btnReHire.Name = "btnReHire"
        Me.btnReHire.Size = New System.Drawing.Size(155, 26)
        Me.btnReHire.TabIndex = 5
        Me.btnReHire.Text = "Re-hire"
        Me.btnReHire.UseVisualStyleBackColor = True
        '
        'lblTotalCurrentEmployees
        '
        Me.lblTotalCurrentEmployees.Location = New System.Drawing.Point(38, 357)
        Me.lblTotalCurrentEmployees.Name = "lblTotalCurrentEmployees"
        Me.lblTotalCurrentEmployees.Size = New System.Drawing.Size(218, 23)
        Me.lblTotalCurrentEmployees.TabIndex = 8
        Me.lblTotalCurrentEmployees.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lstboxPastEmployees
        '
        Me.lstboxPastEmployees.FormattingEnabled = True
        Me.lstboxPastEmployees.ItemHeight = 16
        Me.lstboxPastEmployees.Items.AddRange(New Object() {"Mike", "Paula", "Will"})
        Me.lstboxPastEmployees.Location = New System.Drawing.Point(423, 147)
        Me.lstboxPastEmployees.Name = "lstboxPastEmployees"
        Me.lstboxPastEmployees.Size = New System.Drawing.Size(218, 180)
        Me.lstboxPastEmployees.Sorted = True
        Me.lstboxPastEmployees.TabIndex = 4
        '
        'lblPastEmployees
        '
        Me.lblPastEmployees.AutoSize = True
        Me.lblPastEmployees.Location = New System.Drawing.Point(420, 121)
        Me.lblPastEmployees.Name = "lblPastEmployees"
        Me.lblPastEmployees.Size = New System.Drawing.Size(109, 17)
        Me.lblPastEmployees.TabIndex = 10
        Me.lblPastEmployees.Text = "Past Employees"
        '
        'lblTotalPastEmployees
        '
        Me.lblTotalPastEmployees.Location = New System.Drawing.Point(423, 357)
        Me.lblTotalPastEmployees.Name = "lblTotalPastEmployees"
        Me.lblTotalPastEmployees.Size = New System.Drawing.Size(218, 23)
        Me.lblTotalPastEmployees.TabIndex = 11
        Me.lblTotalPastEmployees.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmQuiz3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(681, 433)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblTotalPastEmployees)
        Me.Controls.Add(Me.lblPastEmployees)
        Me.Controls.Add(Me.lstboxPastEmployees)
        Me.Controls.Add(Me.lblTotalCurrentEmployees)
        Me.Controls.Add(Me.btnReHire)
        Me.Controls.Add(Me.btnFire)
        Me.Controls.Add(Me.lblCurrentEmployees)
        Me.Controls.Add(Me.lstboxCurrentEmployees)
        Me.Controls.Add(Me.btnHire)
        Me.Controls.Add(Me.txtNewPerson)
        Me.Controls.Add(Me.lblNewPerson)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmQuiz3"
        Me.Text = "Quiz 3"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblNewPerson As System.Windows.Forms.Label
    Friend WithEvents txtNewPerson As System.Windows.Forms.TextBox
    Friend WithEvents btnHire As System.Windows.Forms.Button
    Friend WithEvents lstboxCurrentEmployees As System.Windows.Forms.ListBox
    Friend WithEvents lblCurrentEmployees As System.Windows.Forms.Label
    Friend WithEvents btnFire As System.Windows.Forms.Button
    Friend WithEvents btnReHire As System.Windows.Forms.Button
    Friend WithEvents lblTotalCurrentEmployees As System.Windows.Forms.Label
    Friend WithEvents lstboxPastEmployees As System.Windows.Forms.ListBox
    Friend WithEvents lblPastEmployees As System.Windows.Forms.Label
    Friend WithEvents lblTotalPastEmployees As System.Windows.Forms.Label

End Class
