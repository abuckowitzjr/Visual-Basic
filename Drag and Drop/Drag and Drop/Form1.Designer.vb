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
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblTeamA = New System.Windows.Forms.Label()
        Me.lblTeamB = New System.Windows.Forms.Label()
        Me.lstboxTeamA = New System.Windows.Forms.ListBox()
        Me.lstboxTeamB = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(104, 38)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(201, 22)
        Me.txtName.TabIndex = 0
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(53, 41)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(45, 17)
        Me.lblName.TabIndex = 1
        Me.lblName.Text = "Name"
        '
        'lblTeamA
        '
        Me.lblTeamA.AutoSize = True
        Me.lblTeamA.Location = New System.Drawing.Point(36, 107)
        Me.lblTeamA.Name = "lblTeamA"
        Me.lblTeamA.Size = New System.Drawing.Size(57, 17)
        Me.lblTeamA.TabIndex = 2
        Me.lblTeamA.Text = "Team A"
        '
        'lblTeamB
        '
        Me.lblTeamB.AutoSize = True
        Me.lblTeamB.Location = New System.Drawing.Point(238, 107)
        Me.lblTeamB.Name = "lblTeamB"
        Me.lblTeamB.Size = New System.Drawing.Size(57, 17)
        Me.lblTeamB.TabIndex = 3
        Me.lblTeamB.Text = "Team B"
        '
        'lstboxTeamA
        '
        Me.lstboxTeamA.AllowDrop = True
        Me.lstboxTeamA.FormattingEnabled = True
        Me.lstboxTeamA.ItemHeight = 16
        Me.lstboxTeamA.Location = New System.Drawing.Point(34, 127)
        Me.lstboxTeamA.Name = "lstboxTeamA"
        Me.lstboxTeamA.Size = New System.Drawing.Size(185, 164)
        Me.lstboxTeamA.TabIndex = 4
        '
        'lstboxTeamB
        '
        Me.lstboxTeamB.AllowDrop = True
        Me.lstboxTeamB.FormattingEnabled = True
        Me.lstboxTeamB.ItemHeight = 16
        Me.lstboxTeamB.Location = New System.Drawing.Point(236, 127)
        Me.lstboxTeamB.Name = "lstboxTeamB"
        Me.lstboxTeamB.Size = New System.Drawing.Size(185, 164)
        Me.lstboxTeamB.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(455, 350)
        Me.Controls.Add(Me.lstboxTeamB)
        Me.Controls.Add(Me.lstboxTeamA)
        Me.Controls.Add(Me.lblTeamB)
        Me.Controls.Add(Me.lblTeamA)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.txtName)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblTeamA As System.Windows.Forms.Label
    Friend WithEvents lblTeamB As System.Windows.Forms.Label
    Friend WithEvents lstboxTeamA As System.Windows.Forms.ListBox
    Friend WithEvents lstboxTeamB As System.Windows.Forms.ListBox

End Class
