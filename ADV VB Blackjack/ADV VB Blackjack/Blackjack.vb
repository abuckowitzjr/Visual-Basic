'Imports Cards
Option Strict Off
Imports System.Reflection

Public Class frmBlackjack
    Dim pack As Object

    Private Sub btnSelect_Click(sender As System.Object, e As System.EventArgs) Handles btnSelect.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            TextBox1.Text = OpenFileDialog1.FileName
            If IsValidDll(OpenFileDialog1.FileName) Then
                Dim da As Assembly = Assembly.LoadFrom(OpenFileDialog1.FileName)
                Dim objType As Type = da.GetType("Cards.PackOfCards")
                'Dim objTypes As Type() = da.GetTypes
                pack = Activator.CreateInstance(objType)
            End If
        End If
    End Sub

    Private Function IsValidDll(ByVal dllFile As String) As Boolean
        Return True
    End Function

    Private Sub btnGetCard_Click(sender As System.Object, e As System.EventArgs) Handles btnGetCard.Click
        Try
            Dim b As Object = pack.GetCard()
            PictureBox1.Image = b.Suit
            Label1.Text = b.Face
            Label2.Text = b.Face
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class
