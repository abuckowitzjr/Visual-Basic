Module Module1

    Sub Main()
        For i As Integer = 1 To 10
            For j As Integer = 1 To 10
                Console.Write((i * j).ToString + vbTab)
            Next j
            Console.WriteLine()
        Next i
        Console.Read()
    End Sub

End Module
