'Project:       Tic Tac Toe
'Programmer:    Arthur Buckowitz
'Date:          June 19, 2012
'Description:   The game of Tic Tac Toe, upon user click X or O is placed within buttons based on player turn, when player wins, message
'               box is displayed declaring the winner.
Public Class TicTacToeForm
    Dim blnPlayer1 As Boolean = True
    Private Sub Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TLButton.Click, TCButton.Click, TRButton.Click, MLButton.Click, MCButton.Click, MRButton.Click, BLButton.Click, BMButton.Click, BRButton.Click
        'When the button is pressed, designates X or O on the button based on player turn, every click fires CheckForWinner Sub Procedure.
        Try
            Dim btn As Button = DirectCast(sender, Button)
            If btn.Text = "" Then
                If blnPlayer1 = True Then
                    btn.Text = "X"
                Else
                    btn.Text = "O"
                End If
                blnPlayer1 = Not blnPlayer1
            End If
        Catch ex As FormatException
            MessageBox.Show("Error", "Error", MessageBoxButtons.OK)
        Catch ex As Exception
            MessageBox.Show("Error", "Error", MessageBoxButtons.OK)
        End Try
        CheckForWinner(sender, e)
    End Sub
    Private Sub CheckForWinner(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Sub Procedure for checking to see if there is a winner.
        If TLButton.Text = "X" And TCButton.Text = "X" And TRButton.Text = "X" Then
            MessageBox.Show("Player 1 is the winner", "Winner", MessageBoxButtons.OK)
            LockFurtherInput()
        ElseIf TLButton.Text = "O" And TCButton.Text = "O" And TRButton.Text = "O" Then
            MessageBox.Show("Player 2 is the winner", "Winner", MessageBoxButtons.OK)
            LockFurtherInput()
        ElseIf MLButton.Text = "X" And MCButton.Text = "X" And MRButton.Text = "X" Then
            MessageBox.Show("Player 1 is the winner", "Winner", MessageBoxButtons.OK)
            LockFurtherInput()
        ElseIf MLButton.Text = "O" And MCButton.Text = "O" And MRButton.Text = "O" Then
            MessageBox.Show("Player 2 is the winner", "Winner", MessageBoxButtons.OK)
            LockFurtherInput()
        ElseIf BLButton.Text = "X" And BMButton.Text = "X" And BRButton.Text = "X" Then
            MessageBox.Show("Player 1 is the winner", "Winner", MessageBoxButtons.OK)
            LockFurtherInput()
        ElseIf BLButton.Text = "O" And BMButton.Text = "O" And BRButton.Text = "O" Then
            MessageBox.Show("Player 2 is the winner", "Winner", MessageBoxButtons.OK)
            LockFurtherInput()
        ElseIf TLButton.Text = "X" And MLButton.Text = "X" And BLButton.Text = "X" Then
            MessageBox.Show("Player 1 is the winner", "Winner", MessageBoxButtons.OK)
            LockFurtherInput()
        ElseIf TLButton.Text = "O" And MLButton.Text = "O" And BLButton.Text = "O" Then
            MessageBox.Show("Player 2 is the winner", "Winner", MessageBoxButtons.OK)
            LockFurtherInput()
        ElseIf TCButton.Text = "X" And MCButton.Text = "X" And BMButton.Text = "X" Then
            MessageBox.Show("Player 1 is the winner", "Winner", MessageBoxButtons.OK)
            LockFurtherInput()
        ElseIf TCButton.Text = "O" And MCButton.Text = "O" And BMButton.Text = "O" Then
            MessageBox.Show("Player 2 is the winner", "Winner", MessageBoxButtons.OK)
            LockFurtherInput()
        ElseIf TRButton.Text = "X" And MRButton.Text = "X" And BRButton.Text = "X" Then
            MessageBox.Show("Player 1 is the winner", "Winner", MessageBoxButtons.OK)
            LockFurtherInput()
        ElseIf TRButton.Text = "O" And MRButton.Text = "O" And BRButton.Text = "O" Then
            MessageBox.Show("Player 2 is the winner", "Winner", MessageBoxButtons.OK)
            LockFurtherInput()
        ElseIf TLButton.Text = "X" And MCButton.Text = "X" And BRButton.Text = "X" Then
            MessageBox.Show("Player 1 is the winner", "Winner", MessageBoxButtons.OK)
            LockFurtherInput()
        ElseIf TLButton.Text = "O" And MCButton.Text = "O" And BRButton.Text = "O" Then
            MessageBox.Show("Player 2 is the winner", "Winner", MessageBoxButtons.OK)
            LockFurtherInput()
        ElseIf TRButton.Text = "X" And MCButton.Text = "X" And BLButton.Text = "X" Then
            MessageBox.Show("Player 1 is the winner", "Winner", MessageBoxButtons.OK)
            LockFurtherInput()
        ElseIf TRButton.Text = "O" And MCButton.Text = "O" And BLButton.Text = "O" Then
            MessageBox.Show("Player 2 is the winner", "Winner", MessageBoxButtons.OK)
            LockFurtherInput()
        ElseIf TRButton.Text.Contains("X") = True And TCButton.Text = Nothing And TLButton.Text = Nothing And MLButton.Text = Nothing And MRButton.Text = Nothing And
            MCButton.Text = Nothing And BLButton.Text = Nothing And BMButton.Text = Nothing And BRButton.Text = Nothing Then
            MessageBox.Show("It's a tie!", "Tie", MessageBoxButtons.OK)
            LockFurtherInput()
        End If
        If TRButton.Text.Contains("X") = True Then

        End If
    End Sub

    Private Sub LockFurtherInput()
        TLButton.Enabled = False
        TCButton.Enabled = False
        TRButton.Enabled = False
        MLButton.Enabled = False
        MCButton.Enabled = False
        MRButton.Enabled = False
        BLButton.Enabled = False
        BMButton.Enabled = False
        BRButton.Enabled = False
    End Sub
    Private Sub ResetToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResetToolStripMenuItem.Click
        'Calls the reset sub procedure.
        ResetSubProcedure()
    End Sub
    Private Sub ResetSubProcedure()
        'sub procedure for reseting the form to start a new game.
        blnPlayer1 = True
        TLButton.Text = ""
        TCButton.Text = ""
        TRButton.Text = ""
        MRButton.Text = ""
        MCButton.Text = ""
        MLButton.Text = ""
        BLButton.Text = ""
        BMButton.Text = ""
        BRButton.Text = ""
        TLButton.Enabled = True
        TCButton.Enabled = True
        TRButton.Enabled = True
        MLButton.Enabled = True
        MCButton.Enabled = True
        MRButton.Enabled = True
        BLButton.Enabled = True
        BMButton.Enabled = True
        BRButton.Enabled = True
    End Sub
    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        'calls the exit sub procedure.
        ExitSubProcedure()
    End Sub
    Private Sub ExitSubProcedure()
        'sub procedure for exiting the application.
        Application.Exit()
    End Sub
    Private Sub ButtonColorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonColorToolStripMenuItem.Click
        'calls the button color sub procedure.
        ButtonColorSubProcedure()
    End Sub
    Private Sub ButtonColorSubProcedure()
        'sub procedure for changin the color of the buttons based on user selection in color dialog box.
        Try
            If ColorDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Dim selectedButColor As Color
                selectedButColor = ColorDialog1.Color
                TLButton.BackColor = selectedButColor
                TCButton.BackColor = selectedButColor
                TRButton.BackColor = selectedButColor
                MRButton.BackColor = selectedButColor
                MCButton.BackColor = selectedButColor
                MLButton.BackColor = selectedButColor
                BLButton.BackColor = selectedButColor
                BMButton.BackColor = selectedButColor
                BRButton.BackColor = selectedButColor
            End If
        Catch ex As FormatException
            MessageBox.Show("Error", "Error", MessageBoxButtons.OK)
        Catch ex As Exception
            MessageBox.Show("Error", "Error", MessageBoxButtons.OK)
        End Try
    End Sub
    Private Sub ContextResetToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ContextResetToolStripMenuItem.Click
        'calls the reset sub procedure for context menu.
        ResetSubProcedure()
    End Sub
    Private Sub CExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CExitToolStripMenuItem.Click
        'calls the exit sub procedure for the context menu.
        ExitToolStripMenuItem_Click(sender, e)
    End Sub
    Private Sub ContextButtonColorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ContextButtonColorToolStripMenuItem.Click
        'calls the button color sub procedure for context menu.
        ButtonColorSubProcedure()
    End Sub
End Class
