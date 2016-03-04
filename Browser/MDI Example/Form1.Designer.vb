<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Browser
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.WindowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewWindowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TileHorizontallyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TileVerticallyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CascadeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MinimizeAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lbHistory = New System.Windows.Forms.ListBox()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.WindowToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.MdiWindowListItem = Me.WindowToolStripMenuItem
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1452, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'WindowToolStripMenuItem
        '
        Me.WindowToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewWindowToolStripMenuItem, Me.TileHorizontallyToolStripMenuItem, Me.TileVerticallyToolStripMenuItem, Me.CascadeToolStripMenuItem, Me.CloseAllToolStripMenuItem, Me.MinimizeAllToolStripMenuItem})
        Me.WindowToolStripMenuItem.Name = "WindowToolStripMenuItem"
        Me.WindowToolStripMenuItem.Size = New System.Drawing.Size(63, 20)
        Me.WindowToolStripMenuItem.Text = "&Window"
        '
        'NewWindowToolStripMenuItem
        '
        Me.NewWindowToolStripMenuItem.Name = "NewWindowToolStripMenuItem"
        Me.NewWindowToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.NewWindowToolStripMenuItem.Text = "&New Window"
        '
        'TileHorizontallyToolStripMenuItem
        '
        Me.TileHorizontallyToolStripMenuItem.Name = "TileHorizontallyToolStripMenuItem"
        Me.TileHorizontallyToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.TileHorizontallyToolStripMenuItem.Text = "Tile &Horizontally"
        '
        'TileVerticallyToolStripMenuItem
        '
        Me.TileVerticallyToolStripMenuItem.Name = "TileVerticallyToolStripMenuItem"
        Me.TileVerticallyToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.TileVerticallyToolStripMenuItem.Text = "Tile &Vertically"
        '
        'CascadeToolStripMenuItem
        '
        Me.CascadeToolStripMenuItem.Name = "CascadeToolStripMenuItem"
        Me.CascadeToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.CascadeToolStripMenuItem.Text = "&Cascade"
        '
        'CloseAllToolStripMenuItem
        '
        Me.CloseAllToolStripMenuItem.Name = "CloseAllToolStripMenuItem"
        Me.CloseAllToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.CloseAllToolStripMenuItem.Text = "Close &All"
        '
        'MinimizeAllToolStripMenuItem
        '
        Me.MinimizeAllToolStripMenuItem.Name = "MinimizeAllToolStripMenuItem"
        Me.MinimizeAllToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.MinimizeAllToolStripMenuItem.Text = "&Minimize All"
        '
        'lbHistory
        '
        Me.lbHistory.Dock = System.Windows.Forms.DockStyle.Right
        Me.lbHistory.FormattingEnabled = True
        Me.lbHistory.Location = New System.Drawing.Point(1286, 24)
        Me.lbHistory.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.lbHistory.Name = "lbHistory"
        Me.lbHistory.Size = New System.Drawing.Size(166, 726)
        Me.lbHistory.TabIndex = 3
        '
        'Browser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1452, 750)
        Me.Controls.Add(Me.lbHistory)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Browser"
        Me.Text = "Browser Main"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents WindowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewWindowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TileHorizontallyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TileVerticallyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CascadeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MinimizeAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lbHistory As System.Windows.Forms.ListBox

End Class
