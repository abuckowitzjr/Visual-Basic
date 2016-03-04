<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFaces
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
        Me.btnSmile = New System.Windows.Forms.Button()
        Me.btnFrown = New System.Windows.Forms.Button()
        Me.pbFace = New System.Windows.Forms.PictureBox()
        CType(Me.pbFace, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSmile
        '
        Me.btnSmile.Location = New System.Drawing.Point(98, 264)
        Me.btnSmile.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnSmile.Name = "btnSmile"
        Me.btnSmile.Size = New System.Drawing.Size(96, 37)
        Me.btnSmile.TabIndex = 0
        Me.btnSmile.Text = "Smile"
        Me.btnSmile.UseVisualStyleBackColor = True
        '
        'btnFrown
        '
        Me.btnFrown.Location = New System.Drawing.Point(198, 264)
        Me.btnFrown.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnFrown.Name = "btnFrown"
        Me.btnFrown.Size = New System.Drawing.Size(96, 37)
        Me.btnFrown.TabIndex = 1
        Me.btnFrown.Text = "Frown"
        Me.btnFrown.UseVisualStyleBackColor = True
        '
        'pbFace
        '
        Me.pbFace.BackColor = System.Drawing.Color.LightGray
        Me.pbFace.Location = New System.Drawing.Point(71, 29)
        Me.pbFace.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.pbFace.Name = "pbFace"
        Me.pbFace.Size = New System.Drawing.Size(245, 212)
        Me.pbFace.TabIndex = 2
        Me.pbFace.TabStop = False
        '
        'frmFaces
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(395, 360)
        Me.Controls.Add(Me.btnFrown)
        Me.Controls.Add(Me.btnSmile)
        Me.Controls.Add(Me.pbFace)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "frmFaces"
        Me.Text = "Face Paint"
        CType(Me.pbFace, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnSmile As System.Windows.Forms.Button
    Friend WithEvents btnFrown As System.Windows.Forms.Button
    Friend WithEvents pbFace As System.Windows.Forms.PictureBox

End Class
