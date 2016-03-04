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
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.pbRover = New System.Windows.Forms.PictureBox()
        Me.pbBackground = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.pbRover, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbBackground, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.pbRover)
        Me.Panel1.Controls.Add(Me.pbBackground)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(977, 623)
        Me.Panel1.TabIndex = 0
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'pbRover
        '
        Me.pbRover.BackColor = System.Drawing.Color.Olive
        Me.pbRover.Image = Global.MoonPatrol.My.Resources.Resources.Rover
        Me.pbRover.Location = New System.Drawing.Point(45, 418)
        Me.pbRover.Name = "pbRover"
        Me.pbRover.Size = New System.Drawing.Size(168, 71)
        Me.pbRover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbRover.TabIndex = 1
        Me.pbRover.TabStop = False
        '
        'pbBackground
        '
        Me.pbBackground.BackColor = System.Drawing.Color.DimGray
        Me.pbBackground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbBackground.Image = Global.MoonPatrol.My.Resources.Resources.Moon_Patrol_Background1
        Me.pbBackground.Location = New System.Drawing.Point(0, -37)
        Me.pbBackground.Name = "pbBackground"
        Me.pbBackground.Size = New System.Drawing.Size(2733, 671)
        Me.pbBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbBackground.TabIndex = 0
        Me.pbBackground.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(977, 623)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        CType(Me.pbRover, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbBackground, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents pbBackground As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents pbRover As System.Windows.Forms.PictureBox

End Class
