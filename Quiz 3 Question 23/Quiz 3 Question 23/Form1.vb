'Project:       Quiz 3 Question 23
'Programmer:    Arthur Buckowitz
'Date:          August 27, 2012
'Description:   When the circle button is clicked, the program draws 10 circles per second on the form,
'               when the square button is clicked, the program draws 10 squares per second on the form,
'               the stop button stops the drawing of shapes on the form.

Imports System.Threading
Public Class Form1
    Public CircleCollection() As Circles
    Public SquareCollection() As Squares
    Private blnCircle As Boolean = False
    Private blnSquare As Boolean = False
    Private rnd As New Random
    Private gr As Graphics
    Dim thread2 As New Thread(AddressOf Me.DrawSquare)
    Dim thread1 As New Thread(AddressOf Me.DrawCircle)

    Private Sub btnDrawCircles_Click(sender As System.Object, e As System.EventArgs) Handles btnDrawCircles.Click
        'sets boolean status, starts thread1
        Try
            blnCircle = True
            btnDrawCircles.Enabled = False
            thread1.Start()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnDrawSquares_Click(sender As System.Object, e As System.EventArgs) Handles btnDrawSquares.Click
        'sets boolean status, starts thread2
        Try
            blnSquare = True
            btnDrawSquares.Enabled = False
            thread2.Start()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnStop_Click(sender As System.Object, e As System.EventArgs) Handles btnStop.Click
        'sets boolean status to stop drawing
        blnCircle = False
        blnSquare = False
        btnDrawCircles.Enabled = True
        btnDrawSquares.Enabled = True
    End Sub

    Private Sub DrawCircle()
        'uses the circles class to create new circles and draw circles on the form
        Try
            Do While blnCircle = True
                Dim circle As New Circles(rnd.Next(5, 838), rnd.Next(5, 661), 40, Color.Blue)
                Dim p As New Pen(circle.Color)
                Dim x As Integer = circle.XPosition
                Dim y As Integer = circle.YPosition
                Dim r As New Rectangle(x, y, circle.Radius, circle.Radius)
                gr.DrawEllipse(p, r)
                Thread.Sleep(100)
            Loop
        Catch ex As Exception
        End Try
    End Sub

    Private Sub DrawSquare()
        'uses the squares class to create new squares and draw squares on the form
        Try
            Do While blnSquare = True
                Dim square As New Squares(rnd.Next(5, 838), rnd.Next(5, 661), 40, Color.Red)
                Dim p As New Pen(square.Color)
                Dim x As Integer = square.XPosition
                Dim y As Integer = square.YPosition
                Dim r As New Rectangle(x, y, square.Size, square.Size)
                gr.DrawRectangle(p, r)
                Thread.Sleep(100)
            Loop
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Form1_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        'exits the program
        Application.Exit()
    End Sub

    Private Sub Form1_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        'sets the picturebox to be drawn on
        gr = pbContainer.CreateGraphics()
    End Sub
End Class
