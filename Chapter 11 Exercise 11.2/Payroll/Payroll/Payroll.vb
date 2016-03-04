'Project:       Payroll Calculator
'Programmer:    Arthur Buckowitz
'Date:          August 6, 2012
'Description:   Processes amount of pay for each employee in selected file, allows information to be printed.


Imports System.IO.File
Imports System.IO
Public Class frmPayroll
    Dim EmployeeInfo() As String
    Dim PayArray() As PayInfo
    Dim Line As Integer = 1
    Private Structure PayInfo
        Dim FirstName As String
        Dim LastName As String
        Dim EmployeeNumber As Integer
        Dim HourlyPayRate As Decimal
        Dim Pay As Decimal
    End Structure
    Private Sub btnOpen_Click(sender As System.Object, e As System.EventArgs) Handles btnOpen.Click
        'Opens selected file, calls on readfile function to process.
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            txtFileName.Text = OpenFileDialog1.FileName
            Line = 1
            lblEmpNumber.Text = ""
            lblFirstName.Text = ""
            lblHourlyRate.Text = ""
            lblLastName.Text = ""
            ReadFile()
            btnFindPay.Enabled = True
        End If
    End Sub

    Private Function ReadFile() As Boolean
        Dim EndOfFile As Boolean = True
        'Reads file, calls on the display sub to display file info.
        Try
            Dim StreamRead As StreamReader = OpenText(txtFileName.Text)
            Dim strLine As String = ""
            Dim i As Integer = 1
            While Not StreamRead.EndOfStream
                strLine = StreamRead.ReadLine()
                If i = Line Then
                    EndOfFile = False
                    Exit While
                End If
                i += 1
            End While
            StreamRead.Close()
            Display(strLine)
        Catch ex As Exception
            MsgBox("Error Reading")
        End Try
        Return EndOfFile
    End Function

    Private Sub Display(ByVal ReadLine As String)
        'Displays the info from the file into labels on the form.
        Try
            If ReadLine Is "" Then
                btnFindPay.Enabled = False
                Exit Sub
            Else
                EmployeeInfo = ReadLine.Split(CChar("|"))
                lblFirstName.Text = EmployeeInfo(0)
                lblLastName.Text = EmployeeInfo(1)
                lblEmpNumber.Text = EmployeeInfo(2)
                lblHourlyRate.Text = Decimal.Parse(EmployeeInfo(3)).ToString("C")
            End If
        Catch ex As Exception
            MsgBox("Invalid Data")
        End Try
    End Sub

    Private Sub btnFindPay_Click(sender As System.Object, e As System.EventArgs) Handles btnFindPay.Click
        'Stores info from file into array, uses calculate function to calculate pay.
        If txtFileName.Text = "" Then
            MsgBox("Please select file you wish to find pay for.")
        ElseIf txtHoursWorked.Text = "" Then
            MsgBox("Please enter number of hours worked.")
        Else
            If PayArray Is Nothing Then
                ReDim PayArray(0)
            Else
                ReDim Preserve PayArray(PayArray.Length)
            End If
            PayArray(PayArray.Length - 1).FirstName = EmployeeInfo(0)
            PayArray(PayArray.Length - 1).LastName = EmployeeInfo(1)
            PayArray(PayArray.Length - 1).EmployeeNumber = Integer.Parse(EmployeeInfo(2))
            PayArray(PayArray.Length - 1).HourlyPayRate = Decimal.Parse(EmployeeInfo(3))
            PayArray(PayArray.Length - 1).Pay = CalculatePay(Integer.Parse(txtHoursWorked.Text), Decimal.Parse(EmployeeInfo(3)))
            Line += 1
            If ReadFile() = True Then
                Line -= 1
            End If
        End If
        txtHoursWorked.Text = ""
    End Sub

    Private Function CalculatePay(HoursWorked As Integer, HourlyRate As Decimal) As Decimal
        Dim PayAmount As Decimal
        'Calculates amount of pay from hours worked and pay rate.
        PayAmount = HoursWorked * HourlyRate
        Return PayAmount
    End Function

    Private Sub txtHoursWorked_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtHoursWorked.TextChanged
        If Not IsNumeric(txtHoursWorked.Text) And txtHoursWorked.Text <> "" Then
            'Validates the hours worked input.
            MsgBox("Hours worked must be numeric, please correct.")
            txtHoursWorked.Text = ""
        End If
    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        'Displays print preview.
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As System.Object, e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim PrintFont As New Font("Arial", 12)
        Dim LineHeightSingle As Single = PrintFont.GetHeight + 2
        Dim HorizontalPrintLocation As Single = e.MarginBounds.Left
        Dim VerticalPrintLocation As Single = e.MarginBounds.Top
        'Designates info to print document 1 for printing.
        For Each Employee As PayInfo In PayArray
            e.Graphics.DrawString("First Name: " & Employee.FirstName, PrintFont, Brushes.Black,
                                  HorizontalPrintLocation, VerticalPrintLocation)
            VerticalPrintLocation += LineHeightSingle
            e.Graphics.DrawString("Last Name: " & Employee.LastName, PrintFont, Brushes.Black,
                                  HorizontalPrintLocation, VerticalPrintLocation)
            VerticalPrintLocation += LineHeightSingle
            e.Graphics.DrawString("Employee Number: " & Employee.EmployeeNumber.ToString, PrintFont, Brushes.Black,
                                  HorizontalPrintLocation, VerticalPrintLocation)
            VerticalPrintLocation += LineHeightSingle
            e.Graphics.DrawString("Pay Rate: " & Employee.HourlyPayRate.ToString("C"), PrintFont, Brushes.Black,
                                  HorizontalPrintLocation, VerticalPrintLocation)
            VerticalPrintLocation += LineHeightSingle
            e.Graphics.DrawString("Pay: " & Employee.Pay.ToString("C"), PrintFont, Brushes.Black,
                                  HorizontalPrintLocation, VerticalPrintLocation)
            VerticalPrintLocation += LineHeightSingle + LineHeightSingle
        Next
    End Sub

    Private Sub frmPayroll_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        'Disables find pay button, until file is selected in open file sub.
        btnFindPay.Enabled = False
    End Sub
End Class
