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
        Me.EmailBox1 = New ADV_VB_Email_Box.EmailBox()
        Me.SuspendLayout()
        '
        'EmailBox1
        '
        Me.EmailBox1.ForeColor = System.Drawing.Color.Red
        Me.EmailBox1.Location = New System.Drawing.Point(69, 108)
        Me.EmailBox1.Name = "EmailBox1"
        Me.EmailBox1.Size = New System.Drawing.Size(306, 22)
        Me.EmailBox1.TabIndex = 0
        Me.EmailBox1.Type = ADV_VB_Email_Box.EmailBox.ValidationType.Email
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(466, 319)
        Me.Controls.Add(Me.EmailBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents EmailBox1 As ADV_VB_Email_Box.EmailBox

End Class
