Public Class DesktopWatcherService

    Protected Overrides Sub OnStart(ByVal args() As String)
        FileSystemWatcher1.EnableRaisingEvents = True
    End Sub

    Protected Overrides Sub OnStop()
        FileSystemWatcher1.EnableRaisingEvents = False
    End Sub

    Protected Overrides Sub OnCustomCommand(command As Integer)
        MyBase.OnCustomCommand(command)
    End Sub

    Private Sub FileSystemWatcher1_Created(sender As Object, e As System.IO.FileSystemEventArgs) Handles FileSystemWatcher1.Created
        Dim msg As String
        msg = "File Created: " & vbCrLf & "Event Type: " & e.ChangeType.ToString & vbCrLf & "File: " & e.FullPath
        EventLog1.WriteEntry(msg)
    End Sub
End Class
