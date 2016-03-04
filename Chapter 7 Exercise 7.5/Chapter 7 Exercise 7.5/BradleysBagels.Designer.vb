<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBradleysBagels
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBradleysBagels))
        Me.comboboxBagelTypes = New System.Windows.Forms.ComboBox()
        Me.btnAddBagelType = New System.Windows.Forms.Button()
        Me.btnRemoveBagelType = New System.Windows.Forms.Button()
        Me.btnClearBagelList = New System.Windows.Forms.Button()
        Me.btnPrintBagelList = New System.Windows.Forms.Button()
        Me.btnDisplayBagelTypeCount = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.SuspendLayout()
        '
        'comboboxBagelTypes
        '
        Me.comboboxBagelTypes.FormattingEnabled = True
        Me.comboboxBagelTypes.Location = New System.Drawing.Point(37, 23)
        Me.comboboxBagelTypes.Name = "comboboxBagelTypes"
        Me.comboboxBagelTypes.Size = New System.Drawing.Size(245, 24)
        Me.comboboxBagelTypes.Sorted = True
        Me.comboboxBagelTypes.TabIndex = 0
        '
        'btnAddBagelType
        '
        Me.btnAddBagelType.Location = New System.Drawing.Point(11, 68)
        Me.btnAddBagelType.Name = "btnAddBagelType"
        Me.btnAddBagelType.Size = New System.Drawing.Size(145, 42)
        Me.btnAddBagelType.TabIndex = 1
        Me.btnAddBagelType.Text = "Add Bagel Type"
        Me.btnAddBagelType.UseVisualStyleBackColor = True
        '
        'btnRemoveBagelType
        '
        Me.btnRemoveBagelType.Location = New System.Drawing.Point(162, 68)
        Me.btnRemoveBagelType.Name = "btnRemoveBagelType"
        Me.btnRemoveBagelType.Size = New System.Drawing.Size(145, 42)
        Me.btnRemoveBagelType.TabIndex = 2
        Me.btnRemoveBagelType.Text = "Remove Bagel Type"
        Me.btnRemoveBagelType.UseVisualStyleBackColor = True
        '
        'btnClearBagelList
        '
        Me.btnClearBagelList.Location = New System.Drawing.Point(11, 116)
        Me.btnClearBagelList.Name = "btnClearBagelList"
        Me.btnClearBagelList.Size = New System.Drawing.Size(145, 42)
        Me.btnClearBagelList.TabIndex = 3
        Me.btnClearBagelList.Text = "Clear Bagel List"
        Me.btnClearBagelList.UseVisualStyleBackColor = True
        '
        'btnPrintBagelList
        '
        Me.btnPrintBagelList.Location = New System.Drawing.Point(162, 116)
        Me.btnPrintBagelList.Name = "btnPrintBagelList"
        Me.btnPrintBagelList.Size = New System.Drawing.Size(145, 42)
        Me.btnPrintBagelList.TabIndex = 4
        Me.btnPrintBagelList.Text = "Print Bagel List"
        Me.btnPrintBagelList.UseVisualStyleBackColor = True
        '
        'btnDisplayBagelTypeCount
        '
        Me.btnDisplayBagelTypeCount.Location = New System.Drawing.Point(11, 164)
        Me.btnDisplayBagelTypeCount.Name = "btnDisplayBagelTypeCount"
        Me.btnDisplayBagelTypeCount.Size = New System.Drawing.Size(145, 42)
        Me.btnDisplayBagelTypeCount.TabIndex = 5
        Me.btnDisplayBagelTypeCount.Text = "Display Bagel Type Count"
        Me.btnDisplayBagelTypeCount.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(162, 164)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(145, 42)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
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
        'frmBradleysBagels
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(319, 221)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnDisplayBagelTypeCount)
        Me.Controls.Add(Me.btnPrintBagelList)
        Me.Controls.Add(Me.btnClearBagelList)
        Me.Controls.Add(Me.btnRemoveBagelType)
        Me.Controls.Add(Me.btnAddBagelType)
        Me.Controls.Add(Me.comboboxBagelTypes)
        Me.Name = "frmBradleysBagels"
        Me.Text = "Bradley's Bagels"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents comboboxBagelTypes As System.Windows.Forms.ComboBox
    Friend WithEvents btnAddBagelType As System.Windows.Forms.Button
    Friend WithEvents btnRemoveBagelType As System.Windows.Forms.Button
    Friend WithEvents btnClearBagelList As System.Windows.Forms.Button
    Friend WithEvents btnPrintBagelList As System.Windows.Forms.Button
    Friend WithEvents btnDisplayBagelTypeCount As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument

End Class
