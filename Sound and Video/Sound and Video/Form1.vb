Public Class Form1

    'Sound
    'Private Sub btnPlay_Click(sender As System.Object, e As System.EventArgs) Handles btnPlay.Click
    '    My.Computer.Audio.Play("C:\Users\Mike\Desktop\speech off.wav")
    'End Sub
    Dim strPlaylist() As String
    Dim songNum As Integer = 0

    Private Sub AxWindowsMediaPlayer1_Enter(sender As System.Object, e As System.EventArgs) Handles a.Enter
        a.URL = strPlaylist(songNum)
    End Sub

    Private Sub a_PlayStateChange(sender As Object, e As AxWMPLib._WMPOCXEvents_PlayStateChangeEvent) Handles a.PlayStateChange
        If a.playState = WMPLib.WMPPlayState.wmppsStopped Then
            a.url = strPlaylist(songNum)
            songNum += 1
        End If
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        For Each f As String In System.IO.Directory.GetFiles("C:\Users\Mike\Desktop")
            If strPlaylist Is Nothing Then
                ReDim strPlaylist(0)
            Else
                ReDim Preserve strPlaylist(strPlaylist.length)
            End If
            strPlaylist(strPlaylist.length - 1) = f

        Next
        A.url = strPlaylist(songNum)
        songNum += 1
    End Sub
End Class
