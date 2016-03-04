'WriteObjects
'------------
'- _filepath
'------------
'+ Write(object)
'+ ReadAll() in object()
'+ Read(integer) as object
Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary
Public Class WriteObjects
    Private _FilePath As String

    Public Sub New() 'Constructor
        _FilePath = ""
    End Sub

    Public Sub New(ByVal FilePath As String)
        Me.FilePath = FilePath
    End Sub

    Public Property FilePath As String
        Get
            Return _FilePath
        End Get
        Set(value As String)
            If File.Exists(value) Then
                _FilePath = value
            Else
                Dim a As FileStream = File.Create(value)
                a.Close()
            End If
        End Set
    End Property

    Public Sub Write(CarObject As Cars)
        Dim fs As FileStream
        Try
            fs = New FileStream(Me.FilePath, FileMode.Append)
            Dim bf As New BinaryFormatter()
            bf.Serialize(fs, CarObject)
        Catch ex As Exception
            Throw New Exception("Write failed")
        Finally
            If Not fs Is Nothing Then
                fs.Close()
            End If
        End Try
    End Sub

    Public Function ReadAll() As Cars()
        Dim Cars() As Cars
        Dim fs As FileStream
        Try
            fs = New FileStream(Me.FilePath, FileMode.Open)
            Dim bf As New BinaryFormatter()
            While fs.Position < fs.Length
                Dim obj As Object = bf.Deserialize(fs)
                Dim CarObj As Cars
                If TypeOf (obj) Is Cars Then
                    CarObj = DirectCast(obj, Cars)
                    If Cars Is Nothing Then
                        ReDim Cars(0)
                    Else
                        ReDim Preserve Cars(Cars.Length)
                    End If
                    Cars(Cars.Length - 1) = CarObj
                End If
            End While
        Catch ex As Exception
            Throw New Exception("ReadAll failed")
        Finally
            If Not fs Is Nothing Then
                fs.Close()
            End If
        End Try
        Return Cars
    End Function

End Class
