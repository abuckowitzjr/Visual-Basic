Public Class Form3

   
    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        NameLabel.Text = MultiForm.strName
        ScoreLabel.Text = MultiForm.decScore.ToString
        GradeLabel.Text = CalculateGrade()
    End Sub
    Private Function CalculateGrade() As String
        Dim strGrade As String
        If (MultiForm.decScore < 60) Then
            strGrade = "F"
        ElseIf (MultiForm.decScore < 70) Then
            strGrade = "D"
        ElseIf (MultiForm.decScore < 80) Then
            strGrade = "C"
        ElseIf (MultiForm.decScore < 90) Then
            strGrade = "B"
        Else
            strGrade = "A"
        End If
        Return strGrade
    End Function
End Class