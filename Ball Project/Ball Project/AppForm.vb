Imports System.Threading
Public Class AppForm
    Public ballCollection() As Ball
    Private gr As Graphics

    Private Sub AppForm_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Application.Exit()
    End Sub

    Private Sub AppForm_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        gr = pbContainer.CreateGraphics()
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Redraw()
    End Sub

    Private Sub Redraw()
        If ballCollection Is Nothing Then
            Exit Sub
        End If
        gr.Clear(Color.White)
        For Each Ball1 As Ball In ballCollection
            Dim b As New SolidBrush(Ball1.BallColor)
            Dim x As Integer = Ball1.XPosition - Ball1.Radius
            Dim y As Integer = Ball1.YPosition - Ball1.Radius
            Dim r As New Rectangle(x, y, Ball1.Radius * 2, Ball1.Radius * 2)
            gr.FillEllipse(b, r)
        Next
    End Sub


    Private Sub pbContainer_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles pbContainer.MouseClick
        Dim ball1 As New Ball(e.X, e.Y, pbContainer.Height, pbContainer.Width)
        Dim thread1 As New Thread(AddressOf ball1.MoveBall)
        If ballCollection Is Nothing Then
            ReDim ballCollection(0)
        Else
            ReDim Preserve ballCollection(ballCollection.Length)
        End If
        ballCollection(ballCollection.Length - 1) = ball1
        thread1.Start()
        Timer1.Enabled = True
        Redraw()
    End Sub
End Class
