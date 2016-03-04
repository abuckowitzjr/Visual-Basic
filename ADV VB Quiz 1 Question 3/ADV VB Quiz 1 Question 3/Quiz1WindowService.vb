Imports System.IO

Public Class Quiz1WindowService

    Protected Overrides Sub OnStart(ByVal args() As String)
        FileSystemWatcher1.EnableRaisingEvents = True
    End Sub

    Protected Overrides Sub OnStop()
        FileSystemWatcher1.EnableRaisingEvents = False
    End Sub

    Private Sub FileSystemWatcher1_Changed(sender As Object, e As System.IO.FileSystemEventArgs) Handles FileSystemWatcher1.Changed
        Dim fileChanged As String
        Dim BackupPath As String = "C:\Temp\"
        fileChanged = e.FullPath
        BackupPath &= fileChanged.Substring(fileChanged.LastIndexOf("\") + 1)
        System.IO.File.Copy(fileChanged, BackupPath)
        EventLog1.WriteEntry("File changed: " & fileChanged)
    End Sub
End Class
