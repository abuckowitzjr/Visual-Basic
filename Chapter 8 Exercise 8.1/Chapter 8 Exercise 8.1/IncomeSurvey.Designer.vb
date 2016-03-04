<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IncomeSurvey
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IncomeSurvey))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnterDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InputDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboveAverageIncomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BelowPovertyLevelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtIDCode = New System.Windows.Forms.TextBox()
        Me.txtNumberHouse = New System.Windows.Forms.TextBox()
        Me.txtYearlyIncome = New System.Windows.Forms.TextBox()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintDocument2 = New System.Drawing.Printing.PrintDocument()
        Me.PrintDocument3 = New System.Drawing.Printing.PrintDocument()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ReportsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(412, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EnterDataToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(44, 24)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'EnterDataToolStripMenuItem
        '
        Me.EnterDataToolStripMenuItem.Name = "EnterDataToolStripMenuItem"
        Me.EnterDataToolStripMenuItem.Size = New System.Drawing.Size(152, 24)
        Me.EnterDataToolStripMenuItem.Text = "Enter Data"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 24)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InputDataToolStripMenuItem, Me.AboveAverageIncomeToolStripMenuItem, Me.BelowPovertyLevelToolStripMenuItem})
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(72, 24)
        Me.ReportsToolStripMenuItem.Text = "Reports"
        '
        'InputDataToolStripMenuItem
        '
        Me.InputDataToolStripMenuItem.Name = "InputDataToolStripMenuItem"
        Me.InputDataToolStripMenuItem.Size = New System.Drawing.Size(233, 24)
        Me.InputDataToolStripMenuItem.Text = "Input Data"
        '
        'AboveAverageIncomeToolStripMenuItem
        '
        Me.AboveAverageIncomeToolStripMenuItem.Name = "AboveAverageIncomeToolStripMenuItem"
        Me.AboveAverageIncomeToolStripMenuItem.Size = New System.Drawing.Size(233, 24)
        Me.AboveAverageIncomeToolStripMenuItem.Text = "Above Average Income"
        '
        'BelowPovertyLevelToolStripMenuItem
        '
        Me.BelowPovertyLevelToolStripMenuItem.Name = "BelowPovertyLevelToolStripMenuItem"
        Me.BelowPovertyLevelToolStripMenuItem.Size = New System.Drawing.Size(233, 24)
        Me.BelowPovertyLevelToolStripMenuItem.Text = "Below Poverty Level"
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
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(152, 24)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(116, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Identification Code:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(227, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Number of Members In Household:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(143, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Yearly Income:"
        '
        'txtIDCode
        '
        Me.txtIDCode.Location = New System.Drawing.Point(250, 48)
        Me.txtIDCode.Name = "txtIDCode"
        Me.txtIDCode.Size = New System.Drawing.Size(139, 22)
        Me.txtIDCode.TabIndex = 0
        '
        'txtNumberHouse
        '
        Me.txtNumberHouse.Location = New System.Drawing.Point(250, 76)
        Me.txtNumberHouse.Name = "txtNumberHouse"
        Me.txtNumberHouse.Size = New System.Drawing.Size(139, 22)
        Me.txtNumberHouse.TabIndex = 1
        '
        'txtYearlyIncome
        '
        Me.txtYearlyIncome.Location = New System.Drawing.Point(250, 104)
        Me.txtYearlyIncome.Name = "txtYearlyIncome"
        Me.txtYearlyIncome.Size = New System.Drawing.Size(139, 22)
        Me.txtYearlyIncome.TabIndex = 2
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
        'PrintDocument2
        '
        '
        'PrintDocument3
        '
        '
        'IncomeSurvey
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(412, 142)
        Me.Controls.Add(Me.txtYearlyIncome)
        Me.Controls.Add(Me.txtNumberHouse)
        Me.Controls.Add(Me.txtIDCode)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "IncomeSurvey"
        Me.Text = "Income Survey"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EnterDataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InputDataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboveAverageIncomeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BelowPovertyLevelToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtIDCode As System.Windows.Forms.TextBox
    Friend WithEvents txtNumberHouse As System.Windows.Forms.TextBox
    Friend WithEvents txtYearlyIncome As System.Windows.Forms.TextBox
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintDocument2 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintDocument3 As System.Drawing.Printing.PrintDocument

End Class
