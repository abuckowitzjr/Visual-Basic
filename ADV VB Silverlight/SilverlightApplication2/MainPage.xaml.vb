Partial Public Class MainPage
    Inherits UserControl

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub btnDo_Click(sender As System.Object, e As System.Windows.RoutedEventArgs) Handles btnDo.Click
        Dim L1 As New Line
        Dim color1 As New SolidColorBrush()
        color1.Color = Color.FromArgb(10, 50, 10, 250)
        With L1
            .X1 = 10
            .Y1 = 10
            .X2 = 200
            .Y2 = 200
            .Stroke = color1
        End With
        Canvas1.Children.Add(L1)
    End Sub

    Private Sub btnElse_Click(sender As System.Object, e As System.Windows.RoutedEventArgs) Handles btnElse.Click
        MessageBox.Show("Hello There 2")
    End Sub
End Class