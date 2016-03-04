<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConcertTicketSales
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ConcertTicketSales))
        Me.btnTicketPriceSchedule = New System.Windows.Forms.Button()
        Me.lstboxSeatLocation = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNumberOfTickets = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintSummaryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnOrder = New System.Windows.Forms.Button()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.TotalTicketsPerSectionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnTicketPriceSchedule
        '
        Me.btnTicketPriceSchedule.Location = New System.Drawing.Point(48, 144)
        Me.btnTicketPriceSchedule.Name = "btnTicketPriceSchedule"
        Me.btnTicketPriceSchedule.Size = New System.Drawing.Size(182, 23)
        Me.btnTicketPriceSchedule.TabIndex = 0
        Me.btnTicketPriceSchedule.Text = "Ticket Price Schedule"
        Me.btnTicketPriceSchedule.UseVisualStyleBackColor = True
        '
        'lstboxSeatLocation
        '
        Me.lstboxSeatLocation.FormattingEnabled = True
        Me.lstboxSeatLocation.ItemHeight = 16
        Me.lstboxSeatLocation.Items.AddRange(New Object() {"Orchestra", "Mezzanine", "General", "Balcony"})
        Me.lstboxSeatLocation.Location = New System.Drawing.Point(274, 72)
        Me.lstboxSeatLocation.Name = "lstboxSeatLocation"
        Me.lstboxSeatLocation.Size = New System.Drawing.Size(182, 132)
        Me.lstboxSeatLocation.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(271, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(156, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Choose a seat location:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "How many tickets:"
        '
        'txtNumberOfTickets
        '
        Me.txtNumberOfTickets.Location = New System.Drawing.Point(156, 85)
        Me.txtNumberOfTickets.Name = "txtNumberOfTickets"
        Me.txtNumberOfTickets.Size = New System.Drawing.Size(92, 22)
        Me.txtNumberOfTickets.TabIndex = 4
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.PrintToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(484, 28)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(44, 24)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(102, 24)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrintSummaryToolStripMenuItem, Me.TotalTicketsPerSectionToolStripMenuItem})
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(51, 24)
        Me.PrintToolStripMenuItem.Text = "Print"
        '
        'PrintSummaryToolStripMenuItem
        '
        Me.PrintSummaryToolStripMenuItem.Name = "PrintSummaryToolStripMenuItem"
        Me.PrintSummaryToolStripMenuItem.Size = New System.Drawing.Size(174, 24)
        Me.PrintSummaryToolStripMenuItem.Text = "Print Summary"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(53, 24)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(119, 24)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'btnOrder
        '
        Me.btnOrder.Location = New System.Drawing.Point(179, 226)
        Me.btnOrder.Name = "btnOrder"
        Me.btnOrder.Size = New System.Drawing.Size(126, 53)
        Me.btnOrder.TabIndex = 6
        Me.btnOrder.Text = "Order"
        Me.btnOrder.UseVisualStyleBackColor = True
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
        'PrintDocument1
        '
        '
        'TotalTicketsPerSectionToolStripMenuItem
        '
        Me.TotalTicketsPerSectionToolStripMenuItem.Name = "TotalTicketsPerSectionToolStripMenuItem"
        Me.TotalTicketsPerSectionToolStripMenuItem.Size = New System.Drawing.Size(239, 24)
        Me.TotalTicketsPerSectionToolStripMenuItem.Text = "Total Tickets Per Section"
        '
        'ConcertTicketSales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 298)
        Me.Controls.Add(Me.btnOrder)
        Me.Controls.Add(Me.txtNumberOfTickets)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstboxSeatLocation)
        Me.Controls.Add(Me.btnTicketPriceSchedule)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "ConcertTicketSales"
        Me.Text = "Concert Ticket Sales"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnTicketPriceSchedule As System.Windows.Forms.Button
    Friend WithEvents lstboxSeatLocation As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNumberOfTickets As System.Windows.Forms.TextBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintSummaryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnOrder As System.Windows.Forms.Button
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents TotalTicketsPerSectionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
