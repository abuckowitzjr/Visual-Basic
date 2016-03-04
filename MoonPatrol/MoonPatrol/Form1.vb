Public Class Form1
    Dim speed As Integer = 15
    Dim myRover As New Rover(100, 20, 1000, 20)
    Dim blnFalling As Boolean = False
    Dim blnUp As Boolean = False
    Dim intPxlUp As Integer = 0
    Dim allBullets As New List(Of Bullet)
    Private Sub Form1_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Left Then
            pbRover.Location = New Point(pbRover.Location.X - speed, pbRover.Location.Y)
        ElseIf e.KeyCode = Keys.Right Then
            pbRover.Location = New Point(pbRover.Location.X + speed, pbRover.Location.Y)
        ElseIf e.KeyCode = Keys.Up Then
            pbRover.Location = New Point(pbRover.Location.X, pbRover.Location.Y - intPxlUp)
            If blnUp = False Then
                blnUp = True
            End If
        ElseIf e.KeyCode = Keys.Space Then
            allBullets.Add(New Bullet(pbRover.Location.X, pbRover.Location.Y, CChar("U")))
            allBullets.Add(New Bullet(pbRover.Location.X, pbRover.Location.Y, CChar("F")))
        End If
    End Sub
    Private Sub Form1_Resize(sender As Object, e As System.EventArgs) Handles Me.Resize
        pbBackground.Location = New Point(0, Panel1.Height - pbBackground.Height)
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        If pbBackground.Location.X <= Panel1.Width - 2733 Then
            pbBackground.Location = New Point(0, pbBackground.Location.Y)
        End If
        pbBackground.Location = New Point(pbBackground.Location.X - speed, pbBackground.Location.Y)
        'going up
        If blnUp = True And intPxlUp < myRover.JumpHeight Then
            If myRover.JumpHeight - intPxlUp <= 5 Then
                blnUp = False
                blnFalling = True
                intPxlUp = myRover.JumpHeight
                pbRover.Location = New Point(pbRover.Location.X, pbRover.Location.Y - (myRover.JumpHeight))
            Else
                pbRover.Location = New Point(pbRover.Location.X, pbRover.Location.Y - 5)
                intPxlUp += 5
            End If
        End If
        'falling
        If blnFalling And intPxlUp < myRover.JumpHeight Then
            'still falling
            If intPxlUp > 5 Then
                pbRover.Location = New Point(pbRover.Location.X, pbRover.Location.Y + 5)
                intPxlUp -= 5
            ElseIf intPxlUp >= 0 Then
                pbRover.Location = New Point(pbRover.Location.X, pbRover.Location.Y + intPxlUp)
                intPxlUp = 0
                blnFalling = False
            End If
        End If
        DisplayBullets()
    End Sub
    Private Sub DisplayBullets()
        RemoveBullets()
        If allBullets.Count > 0 Then
            For Each Bullet1 In allBullets
                If Bullet1.Direction = "F" Then
                    Bullet1.X += 15
                Else
                    Bullet1.Y -= 15
                End If
                Dim lbt As New Button
                With lbt
                    .BackColor = Color.Red
                    .AutoSize = False
                    .Height = 15
                    .Width = 15
                    .Location = New Point(Bullet1.X, Bullet1.Y)
                    .Visible = True
                    .BringToFront()
                End With
                Panel1.Controls.Add(lbt)
                Me.Refresh()
            Next
        End If
    End Sub
    Private Sub RemoveBullets()
        'removes all bullet object from the list.
        If allBullets.Count > 0 Then
            For Each bullet1 In allBullets
                If (bullet1.Y < 0 Or bullet1.X > Me.Height) Then
                    allBullets.Remove(bullet1)
                End If
            Next
        End If
        'remove all bullets from the panel
        For Each Control1 As Control In Panel1.Controls
            If TypeOf (Control1) Is Button Then
                Panel1.Controls.Remove(Control1)
            End If
        Next
    End Sub
End Class
