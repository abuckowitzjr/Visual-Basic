Public Class About

    Private Sub About_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        lblProgram.Text = SalesCommission.Program
        lblProgrammer.Text = SalesCommission.Programmer
    End Sub
End Class