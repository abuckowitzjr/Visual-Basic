<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnAddHelp = New System.Windows.Forms.Button()
        Me.btnAddIT = New System.Windows.Forms.Button()
        Me.lblHelpdesk = New System.Windows.Forms.Label()
        Me.lblIT = New System.Windows.Forms.Label()
        Me.lstTickets = New System.Windows.Forms.ListBox()
        Me.lstProcessedTickets = New System.Windows.Forms.ListBox()
        Me.lblTicketCount = New System.Windows.Forms.Label()
        Me.lblProcessedTicketCount = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnAddHelp
        '
        Me.btnAddHelp.Location = New System.Drawing.Point(141, 63)
        Me.btnAddHelp.Name = "btnAddHelp"
        Me.btnAddHelp.Size = New System.Drawing.Size(117, 42)
        Me.btnAddHelp.TabIndex = 0
        Me.btnAddHelp.Text = "Add Helpdesk"
        Me.btnAddHelp.UseVisualStyleBackColor = True
        '
        'btnAddIT
        '
        Me.btnAddIT.Location = New System.Drawing.Point(381, 63)
        Me.btnAddIT.Name = "btnAddIT"
        Me.btnAddIT.Size = New System.Drawing.Size(117, 42)
        Me.btnAddIT.TabIndex = 1
        Me.btnAddIT.Text = "Add IT"
        Me.btnAddIT.UseVisualStyleBackColor = True
        '
        'lblHelpdesk
        '
        Me.lblHelpdesk.Location = New System.Drawing.Point(141, 124)
        Me.lblHelpdesk.Name = "lblHelpdesk"
        Me.lblHelpdesk.Size = New System.Drawing.Size(117, 23)
        Me.lblHelpdesk.TabIndex = 2
        Me.lblHelpdesk.Text = "0"
        Me.lblHelpdesk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblIT
        '
        Me.lblIT.Location = New System.Drawing.Point(381, 124)
        Me.lblIT.Name = "lblIT"
        Me.lblIT.Size = New System.Drawing.Size(117, 23)
        Me.lblIT.TabIndex = 3
        Me.lblIT.Text = "0"
        Me.lblIT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lstTickets
        '
        Me.lstTickets.FormattingEnabled = True
        Me.lstTickets.ItemHeight = 16
        Me.lstTickets.Location = New System.Drawing.Point(80, 216)
        Me.lstTickets.Name = "lstTickets"
        Me.lstTickets.Size = New System.Drawing.Size(225, 308)
        Me.lstTickets.TabIndex = 4
        '
        'lstProcessedTickets
        '
        Me.lstProcessedTickets.FormattingEnabled = True
        Me.lstProcessedTickets.ItemHeight = 16
        Me.lstProcessedTickets.Location = New System.Drawing.Point(333, 216)
        Me.lstProcessedTickets.Name = "lstProcessedTickets"
        Me.lstProcessedTickets.Size = New System.Drawing.Size(225, 308)
        Me.lstProcessedTickets.TabIndex = 5
        '
        'lblTicketCount
        '
        Me.lblTicketCount.Location = New System.Drawing.Point(141, 546)
        Me.lblTicketCount.Name = "lblTicketCount"
        Me.lblTicketCount.Size = New System.Drawing.Size(117, 23)
        Me.lblTicketCount.TabIndex = 6
        Me.lblTicketCount.Text = "0"
        Me.lblTicketCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblProcessedTicketCount
        '
        Me.lblProcessedTicketCount.Location = New System.Drawing.Point(381, 546)
        Me.lblProcessedTicketCount.Name = "lblProcessedTicketCount"
        Me.lblProcessedTicketCount.Size = New System.Drawing.Size(117, 23)
        Me.lblProcessedTicketCount.TabIndex = 7
        Me.lblProcessedTicketCount.Text = "0"
        Me.lblProcessedTicketCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(638, 670)
        Me.Controls.Add(Me.lblProcessedTicketCount)
        Me.Controls.Add(Me.lblTicketCount)
        Me.Controls.Add(Me.lstProcessedTickets)
        Me.Controls.Add(Me.lstTickets)
        Me.Controls.Add(Me.lblIT)
        Me.Controls.Add(Me.lblHelpdesk)
        Me.Controls.Add(Me.btnAddIT)
        Me.Controls.Add(Me.btnAddHelp)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnAddHelp As System.Windows.Forms.Button
    Friend WithEvents btnAddIT As System.Windows.Forms.Button
    Friend WithEvents lblHelpdesk As System.Windows.Forms.Label
    Friend WithEvents lblIT As System.Windows.Forms.Label
    Friend WithEvents lstTickets As System.Windows.Forms.ListBox
    Friend WithEvents lstProcessedTickets As System.Windows.Forms.ListBox
    Friend WithEvents lblTicketCount As System.Windows.Forms.Label
    Friend WithEvents lblProcessedTicketCount As System.Windows.Forms.Label

End Class
