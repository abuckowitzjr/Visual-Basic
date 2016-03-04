'Project:       Pong Game
'Programmer:    Arthur Buckowitz
'Date:          June 25, 2012
'Description:   The game of Pong, setup for player versus computer, game runs for the best of 5 declaring winner and restarting game.


Public Class frmPong
    Dim ComputerPoint As Integer
    Dim PlayerPoint As Integer
    Dim BallSpeed As Double = 5
    Dim rndMovement As New Random
    Dim XSpeed As Double
    Dim YSpeed As Double
    Private Sub XYSpeed()
        'determines rate of movement for objects of the form.
        XSpeed = rndMovement.Next(4, 6) * BallSpeed
        YSpeed = rndMovement.Next(-4, 4) * BallSpeed + 1
    End Sub
    Private Sub frmPong_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        'moves the player paddle based on mouse move.
        If e.Y > 3 And e.Y < Me.Height - 35 - PlayerPaddle.Height Then
            PlayerPaddle.Location = New Point(PlayerPaddle.Location.X, e.Y)
        End If
    End Sub
    Private Sub GameTimer_Tick(sender As System.Object, e As System.EventArgs) Handles GameTimer.Tick
        'timer for all game related actions.
        ComputerMoveTimer.Enabled = True
        'Moves the ball
        Ball.Location = New Point(CInt(CDbl(Ball.Location.X) + CDbl(XSpeed)), CInt(Ball.Location.Y + YSpeed))
        'Check for top
        If Ball.Location.Y < 30 Then
            Ball.Location = New Point(Ball.Location.X, Ball.Location.Y)
            YSpeed = -YSpeed
        End If
        'Check for bottom
        If Ball.Location.Y > Me.Height - Ball.Size.Height - 30 Then
            Ball.Location = New Point(Ball.Location.X, Me.Height - Ball.Size.Height - 45)
            YSpeed = -YSpeed
        End If
        'Check for player paddle
        If Ball.Bounds.IntersectsWith(PlayerPaddle.Bounds) Then
            Ball.Location = New Point(PlayerPaddle.Location.X - Ball.Size.Width, _
            Ball.Location.Y)
            XYSpeed()
            XSpeed = -XSpeed
        End If
        'Check for computer paddle
        If Ball.Bounds.IntersectsWith(ComputerPaddle.Bounds) Then
            Ball.Location = New Point(ComputerPaddle.Location.X + ComputerPaddle.Size.Width + 1, _
            Ball.Location.Y)
            XYSpeed()
        End If
        'Check for Player score
        If Ball.Location.X < 0 Then
            PlayerPoint += 1
            Ball.Location = New Point(CInt(Me.Size.Width / 2), (CInt(Me.Size.Height / 2)))
            PlayerScore.Text = PlayerPoint.ToString
            GameTimer.Enabled = False
            MessageBox.Show("You Scored!", "Score", MessageBoxButtons.OK)
            If PlayerPoint = 5 Then
                MessageBox.Show("Game Over, You Win!", "Winner", MessageBoxButtons.OK)
                StartTimer.Enabled = False
                PlayerScore.Text = ""
                ComputerScore.Text = ""
                lblStartTime.Text = ""
                lblStartTime.Visible = True
                PlayerPoint = 0
                ComputerPoint = 0
                Ball.Location = New Point(41, 250)
                ComputerPaddle.Location = New Point(5, 195)
                PlayerPaddle.Location = New Point(608, 195)
                Exit Sub
            ElseIf ComputerPoint = 5 Then
                MessageBox.Show("Game Over, The Computer Wins!", "Winner", MessageBoxButtons.OK)
                StartTimer.Enabled = False
                PlayerScore.Text = ""
                ComputerScore.Text = ""
                lblStartTime.Text = ""
                lblStartTime.Visible = True
                PlayerPoint = 0
                ComputerPoint = 0
                Ball.Location = New Point(41, 250)
                ComputerPaddle.Location = New Point(5, 195)
                PlayerPaddle.Location = New Point(608, 195)
                Exit Sub
            End If
            lblStartTime.Text = ""
            StartTimer.Enabled = True
            Ball.Location = New Point(587, 250)
            PlayerPaddle.Location = New Point(608, 195)
        End If
        'Check for Computer score
        If Ball.Location.X > Me.Width - Ball.Size.Width - PlayerPaddle.Width Then
            ComputerPoint += 1
            Ball.Location = New Point(CInt(Me.Size.Width / 2), (CInt(Me.Size.Height / 2)))
            ComputerScore.Text = ComputerPoint.ToString
            GameTimer.Enabled = False
            MessageBox.Show("The Computer Scored!", "Score", MessageBoxButtons.OK)
            If PlayerPoint = 5 Then
                MessageBox.Show("Game Over, You Win!", "Winner", MessageBoxButtons.OK)
                StartTimer.Enabled = False
                PlayerScore.Text = ""
                ComputerScore.Text = ""
                lblStartTime.Text = ""
                lblStartTime.Visible = True
                PlayerPoint = 0
                ComputerPoint = 0
                Ball.Location = New Point(41, 250)
                ComputerPaddle.Location = New Point(5, 195)
                PlayerPaddle.Location = New Point(608, 195)
                Exit Sub
            ElseIf ComputerPoint = 5 Then
                MessageBox.Show("Game Over, The Computer Wins!", "Winner", MessageBoxButtons.OK)
                StartTimer.Enabled = False
                PlayerScore.Text = ""
                ComputerScore.Text = ""
                lblStartTime.Text = ""
                lblStartTime.Visible = True
                PlayerPoint = 0
                ComputerPoint = 0
                Ball.Location = New Point(41, 250)
                ComputerPaddle.Location = New Point(5, 195)
                PlayerPaddle.Location = New Point(608, 195)
                Exit Sub
            End If
            lblStartTime.Text = ""
            StartTimer.Enabled = True
            Ball.Location = New Point(41, 250)
            ComputerPaddle.Location = New Point(5, 195)
        End If
    End Sub
    Private Sub StartGameToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles StartGameToolStripMenuItem.Click
        'starts a new game of Pong.
        StartTimer.Enabled = True
        If StartTimer.Enabled = False Then
            GameTimer.Enabled = True
        End If
    End Sub

    Private Sub StartTimer_Tick(sender As System.Object, e As System.EventArgs) Handles StartTimer.Tick
        'timer for countdown and display of start timer.
        lblStartTime.Visible = True
        If lblStartTime.Text = "" Then
            lblStartTime.Text = "3"
        ElseIf lblStartTime.Text = "3" Then
            lblStartTime.Text = "2"
        ElseIf lblStartTime.Text = "2" Then
            lblStartTime.Text = "1"
        ElseIf lblStartTime.Text = "1" Then
            lblStartTime.Text = "Go"
        ElseIf lblStartTime.Text = "Go" Then
            lblStartTime.Visible = False
            GameTimer.Enabled = True
            StartTimer.Enabled = False
            If Ball.Location.X > 300 Then
                XYSpeed()
                XSpeed = -XSpeed
            Else
                XYSpeed()
            End If
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        'exits the application.
        Application.Exit()
    End Sub

    Private Sub BackgroundColorToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles BackgroundColorToolStripMenuItem.Click
        'changes the background color of the game board.
        ColorDialog1.ShowDialog()
        Me.BackColor = ColorDialog1.Color
    End Sub
    Private Sub PlayerPaddleToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PlayerPaddleToolStripMenuItem.Click
        'changes the color of the player paddle.
        ColorDialog1.ShowDialog()
        PlayerPaddle.BackColor = ColorDialog1.Color
    End Sub
    Private Sub ComputerPaddleToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ComputerPaddleToolStripMenuItem.Click
        'changes the color of the computer paddle.
        ColorDialog1.ShowDialog()
        ComputerPaddle.BackColor = ColorDialog1.Color
    End Sub

    Private Sub ScorePanelColorToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ScorePanelColorToolStripMenuItem.Click
        'changes the color of the background color of the score panel.
        ColorDialog1.ShowDialog()
        lblStartTime.BackColor = ColorDialog1.Color
        lblComputer.BackColor = ColorDialog1.Color
        lblPlayer.BackColor = ColorDialog1.Color
    End Sub

    Private Sub TableLinesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles TableLinesToolStripMenuItem.Click
        'changes the color of the table lines.
        ColorDialog1.ShowDialog()
        lblLine1.BackColor = ColorDialog1.Color
        lblLine2.BackColor = ColorDialog1.Color
        lblLine3.BackColor = ColorDialog1.Color
        lblLine4.BackColor = ColorDialog1.Color
        lblLine5.BackColor = ColorDialog1.Color
    End Sub

    Private Sub TextColorToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles TextColorToolStripMenuItem.Click
        'changes the color of the text.
        ColorDialog1.ShowDialog()
        lblComputer.ForeColor = ColorDialog1.Color
        lblPlayer.ForeColor = ColorDialog1.Color
        ComputerScore.ForeColor = ColorDialog1.Color
        PlayerScore.ForeColor = ColorDialog1.Color
        lblStartTime.ForeColor = ColorDialog1.Color
    End Sub

    Private Sub BallColorToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles BallColorToolStripMenuItem.Click
        'changes the color of the ball.
        ColorDialog1.ShowDialog()
        Ball.BackColor = ColorDialog1.Color
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        'displays information about the program in messagebox.
        MessageBox.Show("Pong" & Environment.NewLine & "Version 1.0" & Environment.NewLine & "Programmed By: Arthur Buckowitz", "About", MessageBoxButtons.OK)
    End Sub

    Private Sub ComputerMoveTimer_Tick(sender As System.Object, e As System.EventArgs) Handles ComputerMoveTimer.Tick
        'timer used the allow the computer to lose, delaying reaction time.
        If Ball.Location.Y > 28 And Ball.Location.Y < Me.Height - 35 - PlayerPaddle.Height Then
            If Ball.Location.X < 425 Then
                ComputerPaddle.Location = New Point(ComputerPaddle.Location.X, Ball.Location.Y)
            End If
        End If
    End Sub
End Class
