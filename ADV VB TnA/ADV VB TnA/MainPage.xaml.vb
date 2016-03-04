Partial Public Class MainPage
    Inherits UserControl

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub MainPage_Loaded(sender As Object, e As System.Windows.RoutedEventArgs) Handles Me.Loaded
        test.Opacity = 0
        TitleLoad.Begin()
        TitleBleed.Begin()
        'Level1.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub btnStart_Click(sender As Object, e As System.Windows.RoutedEventArgs) Handles btnStart.Click
        Canvas2.Visibility = Windows.Visibility.Visible
        TitleScreen.Visibility = Windows.Visibility.Collapsed
        test.Opacity = 100








        'TitleScreen.Visibility = Windows.Visibility.Collapsed
        'Level_1_Background_Scroll.Begin()
        'TitleLoad.Stop()
        'TitleBleed.Stop()
    End Sub

    Private Sub btnOptions_Click(sender As Object, e As System.Windows.RoutedEventArgs) Handles btnOptions.Click
        MessageBox.Show("Hello Again")
    End Sub
End Class