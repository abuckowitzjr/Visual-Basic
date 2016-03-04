<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.ScoreLabel = New System.Windows.Forms.Label()
        Me.GradeLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'NameLabel
        '
        Me.NameLabel.BackColor = System.Drawing.Color.White
        Me.NameLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.NameLabel.Location = New System.Drawing.Point(33, 30)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(220, 23)
        Me.NameLabel.TabIndex = 0
        '
        'ScoreLabel
        '
        Me.ScoreLabel.BackColor = System.Drawing.Color.White
        Me.ScoreLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ScoreLabel.Location = New System.Drawing.Point(33, 64)
        Me.ScoreLabel.Name = "ScoreLabel"
        Me.ScoreLabel.Size = New System.Drawing.Size(220, 23)
        Me.ScoreLabel.TabIndex = 1
        '
        'GradeLabel
        '
        Me.GradeLabel.BackColor = System.Drawing.Color.White
        Me.GradeLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.GradeLabel.Location = New System.Drawing.Point(33, 99)
        Me.GradeLabel.Name = "GradeLabel"
        Me.GradeLabel.Size = New System.Drawing.Size(220, 23)
        Me.GradeLabel.TabIndex = 2
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(289, 149)
        Me.Controls.Add(Me.GradeLabel)
        Me.Controls.Add(Me.ScoreLabel)
        Me.Controls.Add(Me.NameLabel)
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Output Form"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents NameLabel As System.Windows.Forms.Label
    Friend WithEvents ScoreLabel As System.Windows.Forms.Label
    Friend WithEvents GradeLabel As System.Windows.Forms.Label
End Class
