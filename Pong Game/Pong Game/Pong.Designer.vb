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
        Me.ComputerPaddle = New System.Windows.Forms.PictureBox()
        Me.Ball = New System.Windows.Forms.PictureBox()
        Me.PlayerPaddle = New System.Windows.Forms.PictureBox()
        Me.lblComputer = New System.Windows.Forms.Label()
        Me.lblPlayer = New System.Windows.Forms.Label()
        Me.ComputerScore = New System.Windows.Forms.Label()
        Me.PlayerScore = New System.Windows.Forms.Label()
        Me.GameTimer = New System.Windows.Forms.Timer(Me.components)
        Me.lblLine5 = New System.Windows.Forms.Label()
        Me.lblLine2 = New System.Windows.Forms.Label()
        Me.lblLine4 = New System.Windows.Forms.Label()
        Me.lblLine1 = New System.Windows.Forms.Label()
        Me.lblLine3 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.GameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StartGameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackgroundColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PaddleColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PlayerPaddleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComputerPaddleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ScorePanelColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TableLinesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BallColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StartTimer = New System.Windows.Forms.Timer(Me.components)
        Me.lblStartTime = New System.Windows.Forms.Label()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.ComputerMoveTimer = New System.Windows.Forms.Timer(Me.components)
        CType(Me.ComputerPaddle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ball, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlayerPaddle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ComputerPaddle
        '
        Me.ComputerPaddle.BackColor = System.Drawing.Color.Gray
        Me.ComputerPaddle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ComputerPaddle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ComputerPaddle.Location = New System.Drawing.Point(4, 158)
        Me.ComputerPaddle.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ComputerPaddle.Name = "ComputerPaddle"
        Me.ComputerPaddle.Size = New System.Drawing.Size(24, 105)
        Me.ComputerPaddle.TabIndex = 0
        Me.ComputerPaddle.TabStop = False
        '
        'Ball
        '
        Me.Ball.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Ball.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Ball.Location = New System.Drawing.Point(31, 203)
        Me.Ball.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Ball.Name = "Ball"
        Me.Ball.Size = New System.Drawing.Size(12, 13)
        Me.Ball.TabIndex = 1
        Me.Ball.TabStop = False
        '
        'PlayerPaddle
        '
        Me.PlayerPaddle.BackColor = System.Drawing.Color.Gray
        Me.PlayerPaddle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PlayerPaddle.Location = New System.Drawing.Point(456, 158)
        Me.PlayerPaddle.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PlayerPaddle.Name = "PlayerPaddle"
        Me.PlayerPaddle.Size = New System.Drawing.Size(24, 105)
        Me.PlayerPaddle.TabIndex = 2
        Me.PlayerPaddle.TabStop = False
        '
        'lblComputer
        '
        Me.lblComputer.BackColor = System.Drawing.Color.Silver
        Me.lblComputer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblComputer.Font = New System.Drawing.Font("Palatino Linotype", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComputer.Location = New System.Drawing.Point(173, 30)
        Me.lblComputer.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblComputer.Name = "lblComputer"
        Me.lblComputer.Size = New System.Drawing.Size(60, 24)
        Me.lblComputer.TabIndex = 3
        Me.lblComputer.Text = "Computer"
        Me.lblComputer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPlayer
        '
        Me.lblPlayer.BackColor = System.Drawing.Color.Silver
        Me.lblPlayer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPlayer.Font = New System.Drawing.Font("Palatino Linotype", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlayer.Location = New System.Drawing.Point(246, 30)
        Me.lblPlayer.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPlayer.Name = "lblPlayer"
        Me.lblPlayer.Size = New System.Drawing.Size(60, 24)
        Me.lblPlayer.TabIndex = 4
        Me.lblPlayer.Text = "Player"
        Me.lblPlayer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ComputerScore
        '
        Me.ComputerScore.BackColor = System.Drawing.Color.Transparent
        Me.ComputerScore.Font = New System.Drawing.Font("Segoe Script", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComputerScore.Location = New System.Drawing.Point(185, 54)
        Me.ComputerScore.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.ComputerScore.Name = "ComputerScore"
        Me.ComputerScore.Size = New System.Drawing.Size(38, 41)
        Me.ComputerScore.TabIndex = 5
        Me.ComputerScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PlayerScore
        '
        Me.PlayerScore.BackColor = System.Drawing.Color.Transparent
        Me.PlayerScore.Font = New System.Drawing.Font("Segoe Script", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlayerScore.Location = New System.Drawing.Point(257, 54)
        Me.PlayerScore.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.PlayerScore.Name = "PlayerScore"
        Me.PlayerScore.Size = New System.Drawing.Size(38, 41)
        Me.PlayerScore.TabIndex = 6
        Me.PlayerScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GameTimer
        '
        Me.GameTimer.Interval = 25
        '
        'lblLine5
        '
        Me.lblLine5.BackColor = System.Drawing.Color.Black
        Me.lblLine5.Location = New System.Drawing.Point(237, 23)
        Me.lblLine5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblLine5.Name = "lblLine5"
        Me.lblLine5.Size = New System.Drawing.Size(5, 375)
        Me.lblLine5.TabIndex = 7
        '
        'lblLine2
        '
        Me.lblLine2.BackColor = System.Drawing.Color.Black
        Me.lblLine2.Location = New System.Drawing.Point(0, 23)
        Me.lblLine2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblLine2.Name = "lblLine2"
        Me.lblLine2.Size = New System.Drawing.Size(3, 375)
        Me.lblLine2.TabIndex = 8
        '
        'lblLine4
        '
        Me.lblLine4.BackColor = System.Drawing.Color.Black
        Me.lblLine4.Location = New System.Drawing.Point(479, 23)
        Me.lblLine4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblLine4.Name = "lblLine4"
        Me.lblLine4.Size = New System.Drawing.Size(3, 375)
        Me.lblLine4.TabIndex = 9
        '
        'lblLine1
        '
        Me.lblLine1.BackColor = System.Drawing.Color.Black
        Me.lblLine1.Location = New System.Drawing.Point(2, 23)
        Me.lblLine1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblLine1.Name = "lblLine1"
        Me.lblLine1.Size = New System.Drawing.Size(480, 3)
        Me.lblLine1.TabIndex = 10
        Me.lblLine1.Text = "Label6"
        '
        'lblLine3
        '
        Me.lblLine3.BackColor = System.Drawing.Color.Black
        Me.lblLine3.Location = New System.Drawing.Point(2, 390)
        Me.lblLine3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblLine3.Name = "lblLine3"
        Me.lblLine3.Size = New System.Drawing.Size(480, 3)
        Me.lblLine3.TabIndex = 11
        Me.lblLine3.Text = "Label7"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GameToolStripMenuItem, Me.ColorToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(482, 24)
        Me.MenuStrip1.TabIndex = 12
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'GameToolStripMenuItem
        '
        Me.GameToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StartGameToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.GameToolStripMenuItem.Name = "GameToolStripMenuItem"
        Me.GameToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.GameToolStripMenuItem.Text = "&Game"
        '
        'StartGameToolStripMenuItem
        '
        Me.StartGameToolStripMenuItem.Name = "StartGameToolStripMenuItem"
        Me.StartGameToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.StartGameToolStripMenuItem.Text = "&Start Game"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'ColorToolStripMenuItem
        '
        Me.ColorToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BackgroundColorToolStripMenuItem, Me.PaddleColorToolStripMenuItem, Me.ScorePanelColorToolStripMenuItem, Me.TableLinesToolStripMenuItem, Me.TextColorToolStripMenuItem, Me.BallColorToolStripMenuItem})
        Me.ColorToolStripMenuItem.Name = "ColorToolStripMenuItem"
        Me.ColorToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.ColorToolStripMenuItem.Text = "&Color"
        '
        'BackgroundColorToolStripMenuItem
        '
        Me.BackgroundColorToolStripMenuItem.Name = "BackgroundColorToolStripMenuItem"
        Me.BackgroundColorToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.BackgroundColorToolStripMenuItem.Text = "&Background Color"
        '
        'PaddleColorToolStripMenuItem
        '
        Me.PaddleColorToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PlayerPaddleToolStripMenuItem, Me.ComputerPaddleToolStripMenuItem})
        Me.PaddleColorToolStripMenuItem.Name = "PaddleColorToolStripMenuItem"
        Me.PaddleColorToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.PaddleColorToolStripMenuItem.Text = "&Paddle Color"
        '
        'PlayerPaddleToolStripMenuItem
        '
        Me.PlayerPaddleToolStripMenuItem.Name = "PlayerPaddleToolStripMenuItem"
        Me.PlayerPaddleToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.PlayerPaddleToolStripMenuItem.Text = "Player Paddle"
        '
        'ComputerPaddleToolStripMenuItem
        '
        Me.ComputerPaddleToolStripMenuItem.Name = "ComputerPaddleToolStripMenuItem"
        Me.ComputerPaddleToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.ComputerPaddleToolStripMenuItem.Text = "Computer Paddle"
        '
        'ScorePanelColorToolStripMenuItem
        '
        Me.ScorePanelColorToolStripMenuItem.Name = "ScorePanelColorToolStripMenuItem"
        Me.ScorePanelColorToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.ScorePanelColorToolStripMenuItem.Text = "Score Panel Color"
        '
        'TableLinesToolStripMenuItem
        '
        Me.TableLinesToolStripMenuItem.Name = "TableLinesToolStripMenuItem"
        Me.TableLinesToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.TableLinesToolStripMenuItem.Text = "Table Lines"
        '
        'TextColorToolStripMenuItem
        '
        Me.TextColorToolStripMenuItem.Name = "TextColorToolStripMenuItem"
        Me.TextColorToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.TextColorToolStripMenuItem.Text = "Text Color"
        '
        'BallColorToolStripMenuItem
        '
        Me.BallColorToolStripMenuItem.Name = "BallColorToolStripMenuItem"
        Me.BallColorToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.BallColorToolStripMenuItem.Text = "Ball Color"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'StartTimer
        '
        Me.StartTimer.Interval = 800
        '
        'lblStartTime
        '
        Me.lblStartTime.BackColor = System.Drawing.Color.Silver
        Me.lblStartTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblStartTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblStartTime.Font = New System.Drawing.Font("Segoe Script", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStartTime.Location = New System.Drawing.Point(159, 104)
        Me.lblStartTime.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblStartTime.Name = "lblStartTime"
        Me.lblStartTime.Size = New System.Drawing.Size(165, 70)
        Me.lblStartTime.TabIndex = 13
        Me.lblStartTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ComputerMoveTimer
        '
        Me.ComputerMoveTimer.Interval = 40
        '
        'frmPong
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Green
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(482, 393)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblStartTime)
        Me.Controls.Add(Me.PlayerPaddle)
        Me.Controls.Add(Me.ComputerPaddle)
        Me.Controls.Add(Me.Ball)
        Me.Controls.Add(Me.lblComputer)
        Me.Controls.Add(Me.lblPlayer)
        Me.Controls.Add(Me.ComputerScore)
        Me.Controls.Add(Me.PlayerScore)
        Me.Controls.Add(Me.lblLine5)
        Me.Controls.Add(Me.lblLine3)
        Me.Controls.Add(Me.lblLine1)
        Me.Controls.Add(Me.lblLine4)
        Me.Controls.Add(Me.lblLine2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "frmPong"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PONG"
        CType(Me.ComputerPaddle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ball, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlayerPaddle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ComputerPaddle As System.Windows.Forms.PictureBox
    Friend WithEvents Ball As System.Windows.Forms.PictureBox
    Friend WithEvents PlayerPaddle As System.Windows.Forms.PictureBox
    Friend WithEvents lblComputer As System.Windows.Forms.Label
    Friend WithEvents lblPlayer As System.Windows.Forms.Label
    Friend WithEvents ComputerScore As System.Windows.Forms.Label
    Friend WithEvents PlayerScore As System.Windows.Forms.Label
    Friend WithEvents GameTimer As System.Windows.Forms.Timer
    Friend WithEvents lblLine5 As System.Windows.Forms.Label
    Friend WithEvents lblLine2 As System.Windows.Forms.Label
    Friend WithEvents lblLine4 As System.Windows.Forms.Label
    Friend WithEvents lblLine1 As System.Windows.Forms.Label
    Friend WithEvents lblLine3 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents GameToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StartGameToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ColorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BackgroundColorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PaddleColorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StartTimer As System.Windows.Forms.Timer
    Friend WithEvents lblStartTime As System.Windows.Forms.Label
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents PlayerPaddleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ComputerPaddleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ScorePanelColorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TableLinesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TextColorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BallColorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ComputerMoveTimer As System.Windows.Forms.Timer

End Class
