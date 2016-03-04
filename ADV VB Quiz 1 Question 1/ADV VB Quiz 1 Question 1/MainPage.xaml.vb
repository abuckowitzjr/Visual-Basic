Imports System.Windows.Threading
'Project:       Quiz 1 Question 1
'Programmer:    Arthur Buckowitz
'Date:          September 22, 2012
'Description:   Application draws a circle each second in a random location, once 10 circles are present, all circles are cleared and
'               program continues to draw more circles.

Imports System.Threading

Partial Public Class MainPage
    Inherits UserControl
    Dim count As Integer = 0 'keeps count of how many circles have been drawn

    Private WithEvents mTimer As New DispatcherTimer() 'designates timer

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub btnStart_Click(sender As System.Object, e As System.Windows.RoutedEventArgs) Handles btnStart.Click
        mTimer.Interval = New TimeSpan(0, 0, 1) 'sets timer interval to 1 second ticks
        mTimer.Start() 'starts timer
    End Sub

    Private Sub mTimer_Tick(sender As Object, e As System.EventArgs) Handles mTimer.Tick
        If count <= 9 Then 'checks for number of circles drawn, if not 10 then draw more circles
            Dim rnd As New Random 'declares random number variable
            Dim E1 As New Ellipse 'creates new instance of ellipse
            Dim color1 As New SolidColorBrush() 'creates new instance of solidcolorbrush
            color1.Color = Color.FromArgb(255, 255, 0, 0) 'sets color of stroke
            With E1
                .Height = 100 'sets height of ellipse
                .Width = 100 'sets width of ellipse
                .Stroke = color1 'sets stroke of ellipse
            End With
            Canvas.SetLeft(E1, rnd.Next(20, 281)) 'sets left side of ellipse location to random number
            Canvas.SetTop(E1, rnd.Next(20, 321)) 'sets top side of ellipse location to random number
            Canvas1.Children.Add(E1) 'adds new ellipse to collection of ellipses
            count += 1 'increases count by 1
        Else
            Canvas1.Children.Clear() 'clears collection of ellipses
            count = 0 'sets count back to 0
        End If
    End Sub
End Class