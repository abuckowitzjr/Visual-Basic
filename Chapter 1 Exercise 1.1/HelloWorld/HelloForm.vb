' Project:       Chapter 1 Exercise 1.1 
' Programmer:    Arthur Buckowitz
' Date:          5/18/2012
' Description:   This project will display a "Hello World"
'                message in four different languages (English, Spanish, French, Italian)
'                and print the form.

Public Class HelloForm

    Private Sub PushButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnglishButton.Click
        ' Display the Hello World message.

        MessageLabel.Text = "Hello World"
    End Sub

    Private Sub ExitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitButton.Click
        ' Exit the project.

        Me.Close()
    End Sub

    Private Sub SpanishButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SpanishButton.Click
        ' Display the Hello World message in Spanish.

        MessageLabel.Text = "Hola Mundo"
    End Sub

    'Private Sub PrintButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintButton.Click
    '    ' Print the form on the printer.

    '    PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
    '    PrintForm1.Print()
    'End Sub

    Private Sub FrenchButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FrenchButton.Click
        ' Display the Hello World message in French.

        MessageLabel.Text = "Bonjour tout le monde"
    End Sub

    Private Sub ItalianButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ItalianButton.Click
        ' Display the Hello World message in Italian.

        MessageLabel.Text = "Ciao Mondo"
    End Sub
End Class
