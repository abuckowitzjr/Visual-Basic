Public Class frmRnrBooks

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'RnrBooksDataSet.Subjects' table. You can move, or remove it, as needed.
        Me.SubjectsTableAdapter1.Fill(Me.RnrBooksDataSet.Subjects)
        'TODO: This line of code loads data into the 'RnrBooksDataSet1.Subjects' table. You can move, or remove it, as needed.
        Me.SubjectsTableAdapter.Fill(Me.RnrBooksDataSet1.Subjects)

    End Sub

    Private Sub cboxSubjects_SelectedIndexChanged(sender As System.Object, e As System.EventArgs)

    End Sub
End Class
