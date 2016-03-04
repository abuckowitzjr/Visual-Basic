<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class About
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
        Me.lblProgram = New System.Windows.Forms.Label()
        Me.lblProgrammer = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblProgram
        '
        Me.lblProgram.Location = New System.Drawing.Point(12, 46)
        Me.lblProgram.Name = "lblProgram"
        Me.lblProgram.Size = New System.Drawing.Size(325, 17)
        Me.lblProgram.TabIndex = 0
        Me.lblProgram.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblProgrammer
        '
        Me.lblProgrammer.Location = New System.Drawing.Point(12, 68)
        Me.lblProgrammer.Name = "lblProgrammer"
        Me.lblProgrammer.Size = New System.Drawing.Size(325, 17)
        Me.lblProgrammer.TabIndex = 1
        Me.lblProgrammer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'About
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(349, 130)
        Me.Controls.Add(Me.lblProgrammer)
        Me.Controls.Add(Me.lblProgram)
        Me.Name = "About"
        Me.Text = "About"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblProgram As System.Windows.Forms.Label
    Friend WithEvents lblProgrammer As System.Windows.Forms.Label
End Class
