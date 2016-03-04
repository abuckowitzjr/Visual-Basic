Public Class RandomNumberGenerator
    Inherits Random

    Private Shared ReadOnly _instance As RandomNumberGenerator = New RandomNumberGenerator

    Private Sub New()
        MyBase.New(System.DateTime.Now.Ticks Mod System.Int32.MaxValue)
    End Sub

    Public Shared Function GetInstance() As RandomNumberGenerator
        Return _instance
    End Function

End Class
