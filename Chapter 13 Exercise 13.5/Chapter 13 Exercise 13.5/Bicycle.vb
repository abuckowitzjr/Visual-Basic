'Project:       Bicycle
'Programmer:    Arthur Buckowitz
'Date:          August 8, 2012
'Description:   When start is clicked, the bicycle moves across the screen, resetting tot he opposite side once off screen,
'               when the stop button is clicked, the bicycle returns to its starting location.

Public Class frmBicycle
    Dim StartLocationX As Integer
    Dim StartLocationY As Integer
    Dim StopLocationX As Integer
    Dim StopLocationY As Integer
    Private Sub btnStart_Click(sender As System.Object, e As System.EventArgs) Handles btnStart.Click
        'starts the timer
        Timer1.Start()
    End Sub

    Private Sub btnStop_Click(sender As System.Object, e As System.EventArgs) Handles btnStop.Click
        'stops the timer and returns bicycle to its starting location
        Timer1.Stop()
        'pbBicycle.Left = StartLocationX
        'pbBicycle.Top = StartLocationY
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        'timer for moving the picture box across the screen
        Static XInteger As Integer = pbBicycle.Left
        Static YInteger As Integer = pbBicycle.Top
        Static WidthInteger As Integer = pbBicycle.Width
        Static HeightInteger As Integer = pbBicycle.Height
        XInteger -= 10
        If XInteger <= -pbBicycle.Width Then
            XInteger = Me.Width
        End If
        pbBicycle.SetBounds(XInteger, YInteger, WidthInteger, HeightInteger)
    End Sub

    Private Sub frmBicycle_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        'stores the starting location of the picture box into variables
        StartLocationX = pbBicycle.Location.X
        StartLocationY = pbBicycle.Location.Y
    End Sub
End Class
