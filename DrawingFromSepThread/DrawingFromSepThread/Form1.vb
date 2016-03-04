Imports System.Threading
Public Class Form1
    Dim t As Thread
    Dim b As Bitmap


    Private Sub Form1_Load(sender As Object, e As System.EventArgs) Handles MyBase.Load
        b = New Bitmap(pb.Width, pb.Height)
        Dim o As New oval(b)
        t = New Thread(AddressOf o.Draw)
        t.Start()
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Me.Refresh()
    End Sub

    Private Sub pb_Paint(sender As Object, e As System.Windows.Forms.PaintEventArgs) Handles pb.Paint
        e.Graphics.DrawImage(b, 0, 0)
    End Sub

End Class

Public Class oval
    Dim picbox As PictureBox
    Dim graph As Graphics

    Public Sub New(ByRef b As Bitmap)
        graph = Graphics.FromImage(b)
    End Sub

    Public Sub Draw()
        Dim r As New Random
        Do
            Dim p As New Pen(Color.FromArgb(r.Next(0, 255), r.Next(0, 255), r.Next(0, 255)), r.Next(2, 10))
            p.DashStyle = Drawing2D.DashStyle.Dash
            graph.DrawEllipse(p, New Rectangle(r.Next(1, 375), r.Next(1, 375), r.Next(250, 500), r.Next(250, 500)))
            Thread.Sleep(50)
        Loop
    End Sub
End Class