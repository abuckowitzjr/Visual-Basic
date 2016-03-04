Public Class Form1

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'StudentsDataSet.students' table. You can move, or remove it, as needed.
        Me.StudentsTableAdapter.Fill(Me.StudentsDataSet.students)

    End Sub
End Class
