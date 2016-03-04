<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPayroll
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPayroll))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtFileName = New System.Windows.Forms.TextBox()
        Me.btnOpen = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.lblEmpNumber = New System.Windows.Forms.Label()
        Me.lblHourlyRate = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtHoursWorked = New System.Windows.Forms.TextBox()
        Me.btnFindPay = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Open File:"
        '
        'txtFileName
        '
        Me.txtFileName.Location = New System.Drawing.Point(108, 33)
        Me.txtFileName.Name = "txtFileName"
        Me.txtFileName.Size = New System.Drawing.Size(264, 22)
        Me.txtFileName.TabIndex = 1
        '
        'btnOpen
        '
        Me.btnOpen.Location = New System.Drawing.Point(378, 32)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(29, 23)
        Me.btnOpen.TabIndex = 2
        Me.btnOpen.Text = "..."
        Me.btnOpen.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'lblFirstName
        '
        Me.lblFirstName.BackColor = System.Drawing.SystemColors.Control
        Me.lblFirstName.Location = New System.Drawing.Point(91, 83)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(255, 23)
        Me.lblFirstName.TabIndex = 3
        Me.lblFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLastName
        '
        Me.lblLastName.BackColor = System.Drawing.SystemColors.Control
        Me.lblLastName.Location = New System.Drawing.Point(91, 109)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(255, 23)
        Me.lblLastName.TabIndex = 4
        Me.lblLastName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblEmpNumber
        '
        Me.lblEmpNumber.BackColor = System.Drawing.SystemColors.Control
        Me.lblEmpNumber.Location = New System.Drawing.Point(91, 135)
        Me.lblEmpNumber.Name = "lblEmpNumber"
        Me.lblEmpNumber.Size = New System.Drawing.Size(255, 23)
        Me.lblEmpNumber.TabIndex = 5
        Me.lblEmpNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblHourlyRate
        '
        Me.lblHourlyRate.BackColor = System.Drawing.SystemColors.Control
        Me.lblHourlyRate.Location = New System.Drawing.Point(91, 161)
        Me.lblHourlyRate.Name = "lblHourlyRate"
        Me.lblHourlyRate.Size = New System.Drawing.Size(255, 23)
        Me.lblHourlyRate.TabIndex = 6
        Me.lblHourlyRate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(59, 218)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 17)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Hours Worked:"
        '
        'txtHoursWorked
        '
        Me.txtHoursWorked.Location = New System.Drawing.Point(168, 215)
        Me.txtHoursWorked.Name = "txtHoursWorked"
        Me.txtHoursWorked.Size = New System.Drawing.Size(129, 22)
        Me.txtHoursWorked.TabIndex = 10
        '
        'btnFindPay
        '
        Me.btnFindPay.Location = New System.Drawing.Point(303, 212)
        Me.btnFindPay.Name = "btnFindPay"
        Me.btnFindPay.Size = New System.Drawing.Size(75, 28)
        Me.btnFindPay.TabIndex = 11
        Me.btnFindPay.Text = "Find Pay"
        Me.btnFindPay.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(336, 288)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(88, 32)
        Me.btnExit.TabIndex = 12
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'frmPayroll
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(436, 332)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnFindPay)
        Me.Controls.Add(Me.txtHoursWorked)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblHourlyRate)
        Me.Controls.Add(Me.lblEmpNumber)
        Me.Controls.Add(Me.lblLastName)
        Me.Controls.Add(Me.lblFirstName)
        Me.Controls.Add(Me.btnOpen)
        Me.Controls.Add(Me.txtFileName)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmPayroll"
        Me.Text = "Payroll"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtFileName As System.Windows.Forms.TextBox
    Friend WithEvents btnOpen As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents lblFirstName As System.Windows.Forms.Label
    Friend WithEvents lblLastName As System.Windows.Forms.Label
    Friend WithEvents lblEmpNumber As System.Windows.Forms.Label
    Friend WithEvents lblHourlyRate As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtHoursWorked As System.Windows.Forms.TextBox
    Friend WithEvents btnFindPay As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog

End Class
