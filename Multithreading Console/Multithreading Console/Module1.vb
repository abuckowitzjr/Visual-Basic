
Imports System.Threading
Module Module1

    Sub Main()
        Dim t1 As New Thread(AddressOf task1)
        Dim t2 As New Thread(AddressOf task2)
        t1.Start()
        t2.Start()
        Console.Read()
    End Sub

    Private Sub task1()
        For i As Integer = 1 To 50
            Console.WriteLine("Task 1: " & i)
            Thread.Sleep(10)
        Next
    End Sub

    Private Sub task2()
        For i As Integer = 1 To 50
            Console.WriteLine("Task 2: " & i)
        Next
    End Sub

End Module
