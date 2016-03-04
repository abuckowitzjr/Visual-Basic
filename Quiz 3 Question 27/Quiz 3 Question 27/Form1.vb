'Project:       Quiz 3 Question 27
'Programmer:    Arthur Buckowitz
'Date:          June 26, 2012
'Description:   When form loads, 100 random numbers are generated between 1 and 1000, the numbers are stored in an array.
'               When button is pressed, the smallest, largest, and average of all the numbers in the array are displayed in labels.

Public Class Form1

    Dim Number(99) As Integer

    Private Sub Form1_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        'generates and stores 100 random numbers between 1 and 1000 to an array.
        Dim rnd As New Random
        Dim ArrayIndex As Integer = 0
        Do Until ArrayIndex = 100
            Number(ArrayIndex) = rnd.Next(1, 1000)
            ArrayIndex += 1
        Loop
    End Sub

    Private Sub btnShownumbers_Click(sender As System.Object, e As System.EventArgs) Handles btnShowNumbers.Click
        'performs loop to establish the smallest, largest, and average of all numbers in the array, displays numbers to labels.
        Dim Smallest As Integer
        Dim Largest As Integer
        Dim Sum As Integer
        Dim Average As Integer
        For i As Integer = 0 To 99
            If Number(i) <= 499 And Smallest = 0 Then
                Smallest = Number(i)
            ElseIf Number(i) >= 500 And Largest = 0 Then
                Largest = Number(i)
            ElseIf Number(i) > Largest Then
                Largest = Number(i)
            ElseIf Number(i) < Smallest Then
                Smallest = Number(i)
            End If
            Sum = Sum + Number(i)
        Next
        Average = (CInt(Sum / 100))
        lblSmallest.Text = Smallest.ToString
        lblLargest.Text = Largest.ToString
        lblAverage.Text = Average.ToString
    End Sub
End Class
