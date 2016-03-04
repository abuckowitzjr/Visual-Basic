<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuckosYachts
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBuckosYachts))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintSummaryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintYachtTypesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.NextCharterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddYachtTypeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveYachtTypeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisplayCountOfYachtTypesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtResponParty = New System.Windows.Forms.TextBox()
        Me.txtHours = New System.Windows.Forms.TextBox()
        Me.txtCost = New System.Windows.Forms.TextBox()
        Me.comboboxYachtType = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.comboboxSize = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument2 = New System.Drawing.Printing.PrintDocument()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(473, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrintSummaryToolStripMenuItem, Me.PrintYachtTypesToolStripMenuItem, Me.ToolStripSeparator1, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(44, 24)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'PrintSummaryToolStripMenuItem
        '
        Me.PrintSummaryToolStripMenuItem.Name = "PrintSummaryToolStripMenuItem"
        Me.PrintSummaryToolStripMenuItem.Size = New System.Drawing.Size(190, 24)
        Me.PrintSummaryToolStripMenuItem.Text = "Print Summary"
        '
        'PrintYachtTypesToolStripMenuItem
        '
        Me.PrintYachtTypesToolStripMenuItem.Name = "PrintYachtTypesToolStripMenuItem"
        Me.PrintYachtTypesToolStripMenuItem.Size = New System.Drawing.Size(190, 24)
        Me.PrintYachtTypesToolStripMenuItem.Text = "Print Yacht Types"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(187, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(190, 24)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator2, Me.NextCharterToolStripMenuItem, Me.AddYachtTypeToolStripMenuItem, Me.RemoveYachtTypeToolStripMenuItem, Me.DisplayCountOfYachtTypesToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(47, 24)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(267, 6)
        '
        'NextCharterToolStripMenuItem
        '
        Me.NextCharterToolStripMenuItem.Name = "NextCharterToolStripMenuItem"
        Me.NextCharterToolStripMenuItem.Size = New System.Drawing.Size(270, 24)
        Me.NextCharterToolStripMenuItem.Text = "Clear for Next Charter"
        '
        'AddYachtTypeToolStripMenuItem
        '
        Me.AddYachtTypeToolStripMenuItem.Name = "AddYachtTypeToolStripMenuItem"
        Me.AddYachtTypeToolStripMenuItem.Size = New System.Drawing.Size(270, 24)
        Me.AddYachtTypeToolStripMenuItem.Text = "Add Yacht Type"
        '
        'RemoveYachtTypeToolStripMenuItem
        '
        Me.RemoveYachtTypeToolStripMenuItem.Name = "RemoveYachtTypeToolStripMenuItem"
        Me.RemoveYachtTypeToolStripMenuItem.Size = New System.Drawing.Size(270, 24)
        Me.RemoveYachtTypeToolStripMenuItem.Text = "Remove Yacht Type"
        '
        'DisplayCountOfYachtTypesToolStripMenuItem
        '
        Me.DisplayCountOfYachtTypesToolStripMenuItem.Name = "DisplayCountOfYachtTypesToolStripMenuItem"
        Me.DisplayCountOfYachtTypesToolStripMenuItem.Size = New System.Drawing.Size(270, 24)
        Me.DisplayCountOfYachtTypesToolStripMenuItem.Text = "Display Count of Yacht Types"
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Responsible Party:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Hours Chartered:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(130, 168)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Calculated Cost:"
        '
        'txtResponParty
        '
        Me.txtResponParty.Location = New System.Drawing.Point(145, 39)
        Me.txtResponParty.Name = "txtResponParty"
        Me.txtResponParty.Size = New System.Drawing.Size(145, 22)
        Me.txtResponParty.TabIndex = 0
        '
        'txtHours
        '
        Me.txtHours.Location = New System.Drawing.Point(135, 67)
        Me.txtHours.Name = "txtHours"
        Me.txtHours.Size = New System.Drawing.Size(155, 22)
        Me.txtHours.TabIndex = 1
        '
        'txtCost
        '
        Me.txtCost.BackColor = System.Drawing.Color.White
        Me.txtCost.Location = New System.Drawing.Point(246, 165)
        Me.txtCost.Name = "txtCost"
        Me.txtCost.ReadOnly = True
        Me.txtCost.Size = New System.Drawing.Size(97, 22)
        Me.txtCost.TabIndex = 6
        '
        'comboboxYachtType
        '
        Me.comboboxYachtType.FormattingEnabled = True
        Me.comboboxYachtType.Items.AddRange(New Object() {"Ranger", "Wavelength", "Catalina", "Coronado", "Hobie", "C & C", "Hans Christian", "Excalibur"})
        Me.comboboxYachtType.Location = New System.Drawing.Point(307, 62)
        Me.comboboxYachtType.Name = "comboboxYachtType"
        Me.comboboxYachtType.Size = New System.Drawing.Size(121, 24)
        Me.comboboxYachtType.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(304, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 17)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Type of Yacht"
        '
        'comboboxSize
        '
        Me.comboboxSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxSize.FormattingEnabled = True
        Me.comboboxSize.Items.AddRange(New Object() {"22", "24", "30", "32", "36", "38", "45"})
        Me.comboboxSize.Location = New System.Drawing.Point(307, 118)
        Me.comboboxSize.Name = "comboboxSize"
        Me.comboboxSize.Size = New System.Drawing.Size(121, 24)
        Me.comboboxSize.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(304, 98)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 17)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Yacht Size"
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(47, 103)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(107, 39)
        Me.btnOK.TabIndex = 4
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(160, 103)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(107, 39)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
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
        'PrintDocument2
        '
        '
        'frmBuckosYachts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(473, 205)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.comboboxSize)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.comboboxYachtType)
        Me.Controls.Add(Me.txtCost)
        Me.Controls.Add(Me.txtHours)
        Me.Controls.Add(Me.txtResponParty)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmBuckosYachts"
        Me.Text = "Bucko's Yachts"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintSummaryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintYachtTypesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents NextCharterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddYachtTypeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RemoveYachtTypeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DisplayCountOfYachtTypesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtResponParty As System.Windows.Forms.TextBox
    Friend WithEvents txtHours As System.Windows.Forms.TextBox
    Friend WithEvents txtCost As System.Windows.Forms.TextBox
    Friend WithEvents comboboxYachtType As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents comboboxSize As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents PrintDocument2 As System.Drawing.Printing.PrintDocument

End Class
