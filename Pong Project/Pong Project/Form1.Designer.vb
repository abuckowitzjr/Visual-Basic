<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPong
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
        Me.Ball = New System.Windows.Forms.PictureBox()
        Me.Paddle1 = New System.Windows.Forms.PictureBox()
        Me.Paddle2 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.GameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StartToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackgroundColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ScoreColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        CType(Me.Ball, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Paddle1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Paddle2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Ball
        '
        Me.Ball.BackColor = System.Drawing.Color.Transparent
        Me.Ball.BackgroundImage = Global.Pong.My.Resources.Resources.Orange_Ball
        Me.Ball.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Ball.Location = New System.Drawing.Point(532, 367)
        Me.Ball.Name = "Ball"
        Me.Ball.Size = New System.Drawing.Size(34, 25)
        Me.Ball.TabIndex = 0
        Me.Ball.TabStop = False
        '
        'Paddle1
        '
        Me.Paddle1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Paddle1.BackgroundImage = Global.Pong.My.Resources.Resources.depositphotos_2364821_Electricity_of_fire_texture
        Me.Paddle1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Paddle1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Paddle1.Location = New System.Drawing.Point(11, 407)
        Me.Paddle1.Name = "Paddle1"
        Me.Paddle1.Size = New System.Drawing.Size(27, 85)
        Me.Paddle1.TabIndex = 1
        Me.Paddle1.TabStop = False
        '
        'Paddle2
        '
        Me.Paddle2.BackgroundImage = Global.Pong.My.Resources.Resources._375825_xs
        Me.Paddle2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Paddle2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Paddle2.Location = New System.Drawing.Point(797, 464)
        Me.Paddle2.Name = "Paddle2"
        Me.Paddle2.Size = New System.Drawing.Size(27, 85)
        Me.Paddle2.TabIndex = 2
        Me.Paddle2.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 75
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GameToolStripMenuItem, Me.ColorToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(835, 28)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'GameToolStripMenuItem
        '
        Me.GameToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StartToolStripMenuItem, Me.ResetToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.GameToolStripMenuItem.Name = "GameToolStripMenuItem"
        Me.GameToolStripMenuItem.Size = New System.Drawing.Size(60, 24)
        Me.GameToolStripMenuItem.Text = "Game"
        '
        'StartToolStripMenuItem
        '
        Me.StartToolStripMenuItem.Name = "StartToolStripMenuItem"
        Me.StartToolStripMenuItem.Size = New System.Drawing.Size(114, 24)
        Me.StartToolStripMenuItem.Text = "Start"
        '
        'ResetToolStripMenuItem
        '
        Me.ResetToolStripMenuItem.Name = "ResetToolStripMenuItem"
        Me.ResetToolStripMenuItem.Size = New System.Drawing.Size(114, 24)
        Me.ResetToolStripMenuItem.Text = "Reset"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(114, 24)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'ColorToolStripMenuItem
        '
        Me.ColorToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BackgroundColorToolStripMenuItem, Me.ScoreColorToolStripMenuItem})
        Me.ColorToolStripMenuItem.Name = "ColorToolStripMenuItem"
        Me.ColorToolStripMenuItem.Size = New System.Drawing.Size(57, 24)
        Me.ColorToolStripMenuItem.Text = "Color"
        '
        'BackgroundColorToolStripMenuItem
        '
        Me.BackgroundColorToolStripMenuItem.Name = "BackgroundColorToolStripMenuItem"
        Me.BackgroundColorToolStripMenuItem.Size = New System.Drawing.Size(197, 24)
        Me.BackgroundColorToolStripMenuItem.Text = "Background Color"
        '
        'ScoreColorToolStripMenuItem
        '
        Me.ScoreColorToolStripMenuItem.Name = "ScoreColorToolStripMenuItem"
        Me.ScoreColorToolStripMenuItem.Size = New System.Drawing.Size(197, 24)
        Me.ScoreColorToolStripMenuItem.Text = "Score Color"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(53, 24)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(119, 24)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.Pong.My.Resources.Resources.Pong_Background
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(0, 31)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(836, 705)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'frmPong
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Pong.My.Resources.Resources.Pong_Background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(835, 622)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Paddle2)
        Me.Controls.Add(Me.Paddle1)
        Me.Controls.Add(Me.Ball)
        Me.Controls.Add(Me.MenuStrip1)
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmPong"
        Me.Text = "Pong"
        CType(Me.Ball, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Paddle1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Paddle2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Ball As System.Windows.Forms.PictureBox
    Friend WithEvents Paddle1 As System.Windows.Forms.PictureBox
    Friend WithEvents Paddle2 As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents GameToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StartToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ResetToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ColorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BackgroundColorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ScoreColorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog

End Class
