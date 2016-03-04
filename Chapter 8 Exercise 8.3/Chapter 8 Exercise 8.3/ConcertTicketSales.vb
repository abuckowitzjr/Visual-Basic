'Project:       Concert Ticket Sales
'Programmer:    Arthur Buckowitz
'Date:          June 27, 2012
'Description:   Tracks tickets ordered based on how many tickeet, what seating the tickets are in, and displays 
'               information in messageboxes.  All of the sales information can be printed with the print summary menu item.

Public Class ConcertTicketSales
    Const ORCHESTRA As Decimal = CDec(40.0)
    Const MEZZANINE As Decimal = CDec(27.5)
    Const GENERAL As Decimal = CDec(15.0)
    Const BALCONY As Decimal = CDec(10.0)
    Dim SumOfAllSales As Decimal
    Dim intIndex As Integer = 0
    Dim TicketInfo(0) As Tickets
    Structure Tickets
        Dim NumberOfTickets As Integer
        Dim SeatLocation As String
        Dim TotalCost As Decimal
    End Structure

    Private Function CalculateTotalCost(num1 As Integer) As Decimal
        'calculates the total cost for each sale.
        Dim Total As Decimal
        If lstboxSeatLocation.SelectedItem Is "Orchestra" Then
            Total = num1 * ORCHESTRA
        ElseIf lstboxSeatLocation.SelectedItem Is "Mezzanine" Then
            Total = num1 * MEZZANINE
        ElseIf lstboxSeatLocation.SelectedItem Is "General" Then
            Total = num1 * GENERAL
        ElseIf lstboxSeatLocation.SelectedItem Is "Balcony" Then
            Total = num1 * BALCONY
        End If
        Return Total
    End Function

    Private Sub txtNumberOfTickets_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtNumberOfTickets.TextChanged
        'validate user input for number of tickets entered.
        If Not IsNumeric(txtNumberOfTickets.Text) And txtNumberOfTickets.Text <> "" Then
            MessageBox.Show("Letters may not be entered for Number of Tickets.", "Input Error", MessageBoxButtons.OK)
            txtNumberOfTickets.Text = ""
            txtNumberOfTickets.Focus()
        End If
    End Sub

    Private Sub btnOrder_Click(sender As System.Object, e As System.EventArgs) Handles btnOrder.Click
        Dim NewOrder As Tickets
        Dim MessageBoxResult As Integer
        'validates that information is present, if so, stores information in an array, confirms user acceptance before storing.
        If txtNumberOfTickets.Text = "" Then
            MessageBox.Show("Please enter the Number of Tickets you wish to purchase.", "Input Error", MessageBoxButtons.OK)
            txtNumberOfTickets.Focus()
        ElseIf lstboxSeatLocation.SelectedItem Is Nothing Then
            MessageBox.Show("Please select your preferred seat location for the event.", "Input Error", MessageBoxButtons.OK)
            lstboxSeatLocation.Focus()
        Else
            MessageBoxResult = MessageBox.Show("Is the information for your order correct?" & Environment.NewLine & Environment.NewLine &
                                                       "Number of Tickets: " & txtNumberOfTickets.Text & Environment.NewLine &
                                                       "Seat Location: " & lstboxSeatLocation.SelectedItem.ToString & Environment.NewLine &
                                                       "Total Cost: " & CalculateTotalCost(CInt(txtNumberOfTickets.Text)).ToString("C"), "Confirm Order",
                                                       MessageBoxButtons.YesNo)
            If MessageBoxResult = vbYes Then
                If intIndex = 0 Then
                    NewOrder.NumberOfTickets = Integer.Parse(txtNumberOfTickets.Text)
                    NewOrder.SeatLocation = CStr(lstboxSeatLocation.SelectedItem)
                    NewOrder.TotalCost = CalculateTotalCost(CInt(txtNumberOfTickets.Text))
                    TicketInfo(0) = NewOrder
                    intIndex += 1
                Else
                    ReDim Preserve TicketInfo(intIndex)
                    NewOrder.NumberOfTickets = Integer.Parse(txtNumberOfTickets.Text)
                    NewOrder.SeatLocation = CStr(lstboxSeatLocation.SelectedItem)
                    NewOrder.TotalCost = CalculateTotalCost(CInt(txtNumberOfTickets.Text))
                    TicketInfo(intIndex) = NewOrder
                    intIndex += 1
                End If
                txtNumberOfTickets.Text = ""
                lstboxSeatLocation.ClearSelected()
                txtNumberOfTickets.Focus()
            End If
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        'exits the program.
        Application.Exit()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        'displays the about item.
        AboutBox1.Show()
    End Sub

    Private Sub btnTicketPriceSchedule_Click(sender As System.Object, e As System.EventArgs) Handles btnTicketPriceSchedule.Click
        'displays price schedule in messagebox.
        MessageBox.Show("Orchestra Seating: " & ORCHESTRA.ToString("C") & " per ticket" & Environment.NewLine & "Mezzanine Seating: " &
                        MEZZANINE.ToString("C") & " per ticket" & Environment.NewLine & "General Seating: " & GENERAL.ToString("C") &
                        " per ticket" & Environment.NewLine & "Balcony Seating: " & BALCONY.ToString("C") & " per ticket",
                        "Ticket Price Schedule", MessageBoxButtons.OK)
    End Sub

    Private Sub PrintSummaryToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PrintSummaryToolStripMenuItem.Click
        'verifies that there is information available to display in print preview, if so, displays print preview dialog.
        If intIndex = 0 Then
            MessageBox.Show("No orders have been entered.", "Input Error", MessageBoxButtons.OK)
        Else
            PrintPreviewDialog1.ShowDialog()
        End If

    End Sub

    Private Sub PrintDocument1_PrintPage(sender As System.Object, e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        'designates information to print document to send to printer.
        Dim PrintFont As New Font("Arial", 12)
        Dim LineHeightSingle As Single = PrintFont.GetHeight + 2
        Dim HorizontalPrintLocationSingle As Single = e.MarginBounds.Left
        Dim VerticalPrintLocationSingle As Single = e.MarginBounds.Top
        Static PageNum As Integer = 1
        For Each TicketOrder As Tickets In TicketInfo
            If PageNum <= 2 Then
                e.Graphics.DrawString("Number of Tickets Ordered: " & TicketOrder.NumberOfTickets.ToString, PrintFont, Brushes.Black,
                                                      HorizontalPrintLocationSingle, VerticalPrintLocationSingle)
                VerticalPrintLocationSingle += LineHeightSingle
                e.Graphics.DrawString("Seat Location: " & TicketOrder.SeatLocation.ToString, PrintFont, Brushes.Black,
                                          HorizontalPrintLocationSingle, VerticalPrintLocationSingle)
                VerticalPrintLocationSingle += LineHeightSingle
                e.Graphics.DrawString("Total Cost: " & TicketOrder.TotalCost.ToString("C"), PrintFont, Brushes.Black,
                                          HorizontalPrintLocationSingle, VerticalPrintLocationSingle)
                VerticalPrintLocationSingle += LineHeightSingle + LineHeightSingle
            Else
                e.HasMorePages = False
            End If
            If VerticalPrintLocationSingle >= e.MarginBounds.Bottom Then
                e.HasMorePages = True
                VerticalPrintLocationSingle = e.MarginBounds.Top
                PageNum += 1
            End If
        Next
    End Sub

    Private Sub TotalTicketsPerSectionToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles TotalTicketsPerSectionToolStripMenuItem.Click
        'displays the total amoutn of tickets sold for each type of seating in a messagebox.
        Dim OrchestraTickets As Integer
        Dim MezzanineTickets As Integer
        Dim GeneralTickets As Integer
        Dim BalconyTickets As Integer
        If intIndex = 0 Then
            MessageBox.Show("No orders have been entered.", "Input Error", MessageBoxButtons.OK)
        Else
            For Each SeatLocation As Tickets In TicketInfo
                If SeatLocation.SeatLocation = "Orchestra" Then
                    OrchestraTickets = OrchestraTickets + SeatLocation.NumberOfTickets
                ElseIf SeatLocation.SeatLocation = "Mezzanine" Then
                    MezzanineTickets = MezzanineTickets + SeatLocation.NumberOfTickets
                ElseIf SeatLocation.SeatLocation = "General" Then
                    GeneralTickets = GeneralTickets + SeatLocation.NumberOfTickets
                ElseIf SeatLocation.SeatLocation = "Balcony" Then
                    BalconyTickets = BalconyTickets + SeatLocation.NumberOfTickets
                End If
            Next
            MessageBox.Show("Orchestra Seats Sold : " & OrchestraTickets.ToString & Environment.NewLine & "Mezzanine Seats Sold : " &
                            MezzanineTickets.ToString & Environment.NewLine & "General Seats Sold : " & GeneralTickets.ToString &
                            Environment.NewLine & "Balcony Seats Sold: " & BalconyTickets.ToString, "Total Seats Sold", MessageBoxButtons.OK)
        End If
    End Sub
End Class
