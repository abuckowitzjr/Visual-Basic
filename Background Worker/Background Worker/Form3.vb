Imports System.Threading
Public Class Form3

    Private Delegate Sub upd(ByVal labelNum As Integer, ByVal Message As String)
    Dim t2 As New Thread(AddressOf task2)
    Dim t1 As New Thread(AddressOf task1)
  
    Private Sub UpdateLabels(ByVal labelnum As Integer, ByVal message As String)
        If labelnum = 1 Then
            Label1.Text = Message
        Else
            Label2.Text = Message
        End If
    End Sub

    Private Sub task1()
            For i As Integer = 1 To 2000000
                If i Mod 1000 = 0 Then
                    If InvokeRequired Then
                        Invoke(New upd(AddressOf UpdateLabels), 1, i.ToString)
                    End If
                End If
                Application.DoEvents()
            Next

    End Sub

    Private Sub task2()
        For i As Integer = 1 To 2500000
            If i Mod 1000 = 0 Then
                If InvokeRequired Then
                    Invoke(New upd(AddressOf UpdateLabels), 2, i.ToString)
                End If
            End If
            Application.DoEvents()
        Next
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        t2.Start()
    End Sub

    Private Sub Button1_Click_1(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        'If t1.ThreadState = ThreadState.Unstarted Then
        '    t1.Start()
        'Else
        '    t1.Abort()
        '    t1 = New Thread(AddressOf task1)
        'End If
        t1.Start()
    End Sub

    Private Sub Form3_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
            t1.Abort()
            t2.Abort()
        Catch ex As Exception
        End Try
    End Sub
End Class