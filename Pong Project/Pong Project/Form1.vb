Public Class frmPong
    Dim rnd As New Random
    Dim xspeed As Integer
    Dim yspeed As Integer
    Dim Player1 As Boolean = False
    Private Sub StartToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StartToolStripMenuItem.Click
        XYSpeed(sender, e)
        Timer1.Enabled = True
    End Sub
    Private Sub XYSpeed(ByVal sender As System.Object, ByVal e As System.EventArgs)
        xspeed = Convert.ToInt32(rnd.Next(20, 30))
        yspeed = Convert.ToInt32(rnd.Next(-5, 5))
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Ball.Location.Y >= 197 And Ball.Location.Y <= 542 Then
            If Player1 Then
                Ball.Location = New Point(Ball.Location.X + xspeed, Ball.Location.Y + yspeed)
            Else
                Ball.Location = New Point(Ball.Location.X - xspeed, Ball.Location.Y - yspeed)
            End If
        Else
            If Player1 Then
                Ball.Location = New Point(Ball.Location.X + xspeed, Ball.Location.Y - yspeed)
            Else
                Ball.Location = New Point(Ball.Location.X - xspeed, Ball.Location.Y + yspeed)
            End If
        End If


        If ballhitspaddle() Then
            Player1 = Not Player1
        End If
    End Sub
    Private Function ballhitspaddle() As Boolean
        Dim returnvalue As Boolean = False
        If Ball.Location = Paddle1.Location Then
            returnvalue = True
        Else
            returnvalue = False
        End If

        Return returnvalue
    End Function
    Private Sub UserKeyPressUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
      If e.KeyCode = Keys.Up Then
                Me.Paddle1.Top -= 20
            ElseIf e.KeyCode = Keys.Down Then
                Me.Paddle1.Top += 20
            End If
    End Sub
    Private Sub frmPong_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PictureBox1.SendToBack()
    End Sub

    Private Sub frmPong_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove

    End Sub

    Private Sub BackgroundColorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackgroundColorToolStripMenuItem.Click
    End Sub
    Private Sub ComputerMove(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub

End Class
