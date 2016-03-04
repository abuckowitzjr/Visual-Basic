Public Class Form1
    Dim Grades(,) As Decimal '4 columns and 1 row (Array)
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        'input
        Dim strName As String
        Dim decQuiz1 As Decimal
        Dim decQuiz2 As Decimal
        Dim decQuiz3 As Decimal
        Dim decFinal As Decimal
        Try
            strName = txtName.Text
            decQuiz1 = Decimal.Parse(txtQuiz1.Text)
            decQuiz2 = Decimal.Parse(txtQuiz2.Text)
            decQuiz3 = Decimal.Parse(txtQuiz3.Text)
            decFinal = Decimal.Parse(txtFinal.Text)
        Catch ex As Exception
            Exit Sub
        End Try
        'process
        If Grades Is Nothing Then
            ReDim Grades(3, 0)
        Else
            ReDim Preserve Grades(3, Grades.GetUpperBound(1) + 1)
        End If
        Grades(0, Grades.GetUpperBound(1)) = decQuiz1
        Grades(1, Grades.GetUpperBound(1)) = decQuiz2
        Grades(2, Grades.GetUpperBound(1)) = decQuiz3
        Grades(3, Grades.GetUpperBound(1)) = decFinal
        'output
        lstboxNames.Items.Add(strName)
    End Sub
    Private Function getAverage(ByVal Index As Integer) As Decimal
        Dim avg As Decimal
        avg = ((Grades(0, Index) + Grades(1, Index) + Grades(2, Index) + Grades(3, Index)) / 4)
        Return avg
    End Function
    Private Sub lstboxNames_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstboxNames.SelectedIndexChanged
        lblAverage.Text = getAverage(lstboxNames.SelectedIndex).ToString("N2")
    End Sub
End Class
