Public Class Form1
    Private WithEvents myTimer As New Timer
    Dim num As Integer = 1

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        myTimer.Interval = 100
        myTimer.Enabled = True
    End Sub

   Private Sub myTimer_Tick(sender As Object, e As System.EventArgs) Handles myTimer.Tick
        'assuming there are 52 files in total to create the animation.
        'dim myPics as resources.resourceset = my.resources.resourcemanager.resourceset(system.Globalization....
        Label1.Image = Image.FromFile("C:\...\...") 'my.resources.
        If Num = 52 Then
            num = 0
        End If
        num = num + 1
    End Sub
End Class
