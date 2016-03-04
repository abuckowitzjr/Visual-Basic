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
        Me.pbSource = New System.Windows.Forms.PictureBox()
        Me.pbTarget = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnResetImage = New System.Windows.Forms.Button()
        CType(Me.pbSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbTarget, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbSource
        '
        Me.pbSource.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pbSource.Image = Global.Drag_and_Drop_Image.My.Resources.Resources.minecraft_creeper_large
        Me.pbSource.Location = New System.Drawing.Point(74, 68)
        Me.pbSource.Name = "pbSource"
        Me.pbSource.Size = New System.Drawing.Size(150, 150)
        Me.pbSource.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbSource.TabIndex = 0
        Me.pbSource.TabStop = False
        '
        'pbTarget
        '
        Me.pbTarget.Location = New System.Drawing.Point(282, 68)
        Me.pbTarget.Name = "pbTarget"
        Me.pbTarget.Size = New System.Drawing.Size(150, 150)
        Me.pbTarget.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbTarget.TabIndex = 1
        Me.pbTarget.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(71, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Source"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(279, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Target"
        '
        'btnResetImage
        '
        Me.btnResetImage.Location = New System.Drawing.Point(190, 249)
        Me.btnResetImage.Name = "btnResetImage"
        Me.btnResetImage.Size = New System.Drawing.Size(122, 37)
        Me.btnResetImage.TabIndex = 4
        Me.btnResetImage.Text = "Reset Image"
        Me.btnResetImage.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(508, 334)
        Me.Controls.Add(Me.btnResetImage)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pbTarget)
        Me.Controls.Add(Me.pbSource)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.pbSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbTarget, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pbSource As System.Windows.Forms.PictureBox
    Friend WithEvents pbTarget As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnResetImage As System.Windows.Forms.Button

End Class
