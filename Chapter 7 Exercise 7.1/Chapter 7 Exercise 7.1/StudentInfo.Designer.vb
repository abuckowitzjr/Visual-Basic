<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentInfo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StudentInfo))
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtUnitsCompleted = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbSenior = New System.Windows.Forms.RadioButton()
        Me.rbFreshman = New System.Windows.Forms.RadioButton()
        Me.rbJunior = New System.Windows.Forms.RadioButton()
        Me.rbSophomore = New System.Windows.Forms.RadioButton()
        Me.chkboxDeansList = New System.Windows.Forms.CheckBox()
        Me.lstboxMajors = New System.Windows.Forms.ListBox()
        Me.comboboxHighschool = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.btnAccept = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintSchoolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddHighSchoolToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintDocument2 = New System.Drawing.Printing.PrintDocument()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(117, 73)
        Me.txtName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(368, 30)
        Me.txtName.TabIndex = 0
        '
        'txtUnitsCompleted
        '
        Me.txtUnitsCompleted.Location = New System.Drawing.Point(216, 114)
        Me.txtUnitsCompleted.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtUnitsCompleted.Name = "txtUnitsCompleted"
        Me.txtUnitsCompleted.Size = New System.Drawing.Size(270, 30)
        Me.txtUnitsCompleted.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 78)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(34, 119)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(162, 25)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Units Completed:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbSenior)
        Me.GroupBox1.Controls.Add(Me.rbFreshman)
        Me.GroupBox1.Controls.Add(Me.rbJunior)
        Me.GroupBox1.Controls.Add(Me.rbSophomore)
        Me.GroupBox1.Location = New System.Drawing.Point(39, 175)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Size = New System.Drawing.Size(196, 208)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Grade Level"
        '
        'rbSenior
        '
        Me.rbSenior.AutoSize = True
        Me.rbSenior.Location = New System.Drawing.Point(28, 159)
        Me.rbSenior.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.rbSenior.Name = "rbSenior"
        Me.rbSenior.Size = New System.Drawing.Size(90, 29)
        Me.rbSenior.TabIndex = 5
        Me.rbSenior.TabStop = True
        Me.rbSenior.Text = "Senior"
        Me.rbSenior.UseVisualStyleBackColor = True
        '
        'rbFreshman
        '
        Me.rbFreshman.AutoSize = True
        Me.rbFreshman.Location = New System.Drawing.Point(28, 33)
        Me.rbFreshman.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.rbFreshman.Name = "rbFreshman"
        Me.rbFreshman.Size = New System.Drawing.Size(121, 29)
        Me.rbFreshman.TabIndex = 2
        Me.rbFreshman.TabStop = True
        Me.rbFreshman.Text = "Freshman"
        Me.rbFreshman.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.rbFreshman.UseVisualStyleBackColor = True
        '
        'rbJunior
        '
        Me.rbJunior.AutoSize = True
        Me.rbJunior.Location = New System.Drawing.Point(28, 117)
        Me.rbJunior.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.rbJunior.Name = "rbJunior"
        Me.rbJunior.Size = New System.Drawing.Size(87, 29)
        Me.rbJunior.TabIndex = 4
        Me.rbJunior.TabStop = True
        Me.rbJunior.Text = "Junior"
        Me.rbJunior.UseVisualStyleBackColor = True
        '
        'rbSophomore
        '
        Me.rbSophomore.AutoSize = True
        Me.rbSophomore.Location = New System.Drawing.Point(28, 75)
        Me.rbSophomore.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.rbSophomore.Name = "rbSophomore"
        Me.rbSophomore.Size = New System.Drawing.Size(135, 29)
        Me.rbSophomore.TabIndex = 3
        Me.rbSophomore.TabStop = True
        Me.rbSophomore.Text = "Sophomore"
        Me.rbSophomore.UseVisualStyleBackColor = True
        '
        'chkboxDeansList
        '
        Me.chkboxDeansList.AutoSize = True
        Me.chkboxDeansList.Location = New System.Drawing.Point(292, 217)
        Me.chkboxDeansList.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.chkboxDeansList.Name = "chkboxDeansList"
        Me.chkboxDeansList.Size = New System.Drawing.Size(130, 29)
        Me.chkboxDeansList.TabIndex = 6
        Me.chkboxDeansList.Text = "Dean's List"
        Me.chkboxDeansList.UseVisualStyleBackColor = True
        '
        'lstboxMajors
        '
        Me.lstboxMajors.FormattingEnabled = True
        Me.lstboxMajors.ItemHeight = 25
        Me.lstboxMajors.Items.AddRange(New Object() {"Accounting", "Business", "Computer Information Systems", "Marketing"})
        Me.lstboxMajors.Location = New System.Drawing.Point(516, 73)
        Me.lstboxMajors.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.lstboxMajors.Name = "lstboxMajors"
        Me.lstboxMajors.Size = New System.Drawing.Size(379, 179)
        Me.lstboxMajors.TabIndex = 6
        '
        'comboboxHighschool
        '
        Me.comboboxHighschool.FormattingEnabled = True
        Me.comboboxHighschool.Items.AddRange(New Object() {"Franklin", "Highland", "West Highland", "Midtown"})
        Me.comboboxHighschool.Location = New System.Drawing.Point(256, 342)
        Me.comboboxHighschool.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.comboboxHighschool.Name = "comboboxHighschool"
        Me.comboboxHighschool.Size = New System.Drawing.Size(229, 33)
        Me.comboboxHighschool.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(252, 311)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 25)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "High School"
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(516, 306)
        Me.btnPrint.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(186, 73)
        Me.btnPrint.TabIndex = 8
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = True
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
        'btnAccept
        '
        Me.btnAccept.Location = New System.Drawing.Point(711, 306)
        Me.btnAccept.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnAccept.Name = "btnAccept"
        Me.btnAccept.Size = New System.Drawing.Size(186, 73)
        Me.btnAccept.TabIndex = 9
        Me.btnAccept.Text = "Accept"
        Me.btnAccept.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(9, 3, 0, 3)
        Me.MenuStrip1.Size = New System.Drawing.Size(936, 30)
        Me.MenuStrip1.TabIndex = 11
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrintSchoolsToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(44, 24)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'PrintSchoolsToolStripMenuItem
        '
        Me.PrintSchoolsToolStripMenuItem.Name = "PrintSchoolsToolStripMenuItem"
        Me.PrintSchoolsToolStripMenuItem.Size = New System.Drawing.Size(163, 24)
        Me.PrintSchoolsToolStripMenuItem.Text = "&Print Schools"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(163, 24)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddHighSchoolToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(47, 24)
        Me.EditToolStripMenuItem.Text = "&Edit"
        '
        'AddHighSchoolToolStripMenuItem
        '
        Me.AddHighSchoolToolStripMenuItem.Name = "AddHighSchoolToolStripMenuItem"
        Me.AddHighSchoolToolStripMenuItem.Size = New System.Drawing.Size(191, 24)
        Me.AddHighSchoolToolStripMenuItem.Text = "A&dd High School"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(53, 24)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(119, 24)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'PrintDocument2
        '
        '
        'StudentInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(936, 409)
        Me.Controls.Add(Me.btnAccept)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.comboboxHighschool)
        Me.Controls.Add(Me.lstboxMajors)
        Me.Controls.Add(Me.chkboxDeansList)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtUnitsCompleted)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "StudentInfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Student Information"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtUnitsCompleted As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbSenior As System.Windows.Forms.RadioButton
    Friend WithEvents rbFreshman As System.Windows.Forms.RadioButton
    Friend WithEvents rbJunior As System.Windows.Forms.RadioButton
    Friend WithEvents rbSophomore As System.Windows.Forms.RadioButton
    Friend WithEvents chkboxDeansList As System.Windows.Forms.CheckBox
    Friend WithEvents comboboxHighschool As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents lstboxMajors As System.Windows.Forms.ListBox
    Friend WithEvents btnAccept As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintSchoolsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddHighSchoolToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintDocument2 As System.Drawing.Printing.PrintDocument

End Class
