<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AppForm
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
        Me.pbContainer = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.pbContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbContainer
        '
        Me.pbContainer.BackColor = System.Drawing.Color.White
        Me.pbContainer.Location = New System.Drawing.Point(11, 12)
        Me.pbContainer.Name = "pbContainer"
        Me.pbContainer.Size = New System.Drawing.Size(690, 614)
        Me.pbContainer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pbContainer.TabIndex = 0
        Me.pbContainer.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
        '
        'AppForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(713, 638)
        Me.Controls.Add(Me.pbContainer)
        Me.Name = "AppForm"
        Me.Text = "Ball"
        CType(Me.pbContainer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pbContainer As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer

End Class
