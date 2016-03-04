'Project:       Smile and Frown
'Programmer:    Arthur Buckowitz
'Date:          August 8, 2012
'Description:   Uses the graphics method to display a smiley face when smile button is clicked, and a frown when the frown 
'               button is clicked.

Imports System.Drawing
Public Class frmFaces
    Dim SmileFrown(1) As Point
    'Displays a smiley face when smile button is clicked

    Private Sub btnSmile_Click(sender As System.Object, e As System.EventArgs) Handles btnSmile.Click
        pbFace.Refresh()
        pbFace.CreateGraphics.FillEllipse(Brushes.Black, 60, 40, 50, 50)
        pbFace.CreateGraphics.FillEllipse(Brushes.Black, 140, 40, 50, 50)
        pbFace.CreateGraphics.FillEllipse(Brushes.Black, 55, 115, 140, 80)
        pbFace.CreateGraphics.FillEllipse(Brushes.LightGray, 45, 90, 160, 80)
        'My.Computer.Audio.Play("C:\Users\Mike\Desktop\Missouri Tech\VB Student Data\StudentData\StudentData In Progress\Sound_Video\chimes.wav")
    End Sub
    'Displays a frown face when the frown button is clicked
    Private Sub btnFrown_Click(sender As System.Object, e As System.EventArgs) Handles btnFrown.Click
        pbFace.Refresh()
        pbFace.CreateGraphics.FillEllipse(Brushes.Black, 60, 40, 50, 50)
        pbFace.CreateGraphics.FillEllipse(Brushes.Black, 140, 40, 50, 50)
        pbFace.CreateGraphics.FillEllipse(Brushes.Black, 55, 155, 140, 80)
        pbFace.CreateGraphics.FillEllipse(Brushes.LightGray, 45, 180, 160, 80)
        'My.Computer.Audio.Play("C:\Users\Mike\Desktop\Speech Off.wav")
    End Sub
    'Allows for graphics to be drawn.
    Private Sub Form1_Paint(sender As Object, e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim GraphicSurface As Graphics = e.Graphics

    End Sub
End Class
