<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Summary
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
        Me.btnOK = New System.Windows.Forms.Button()
        Me.txtPartsTotal = New System.Windows.Forms.TextBox()
        Me.txtLaborTotal = New System.Windows.Forms.TextBox()
        Me.txtSalesTaxTotal = New System.Windows.Forms.TextBox()
        Me.txtTotalsTotal = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(69, 190)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(104, 44)
        Me.btnOK.TabIndex = 0
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'txtPartsTotal
        '
        Me.txtPartsTotal.BackColor = System.Drawing.Color.White
        Me.txtPartsTotal.Location = New System.Drawing.Point(63, 64)
        Me.txtPartsTotal.Name = "txtPartsTotal"
        Me.txtPartsTotal.ReadOnly = True
        Me.txtPartsTotal.Size = New System.Drawing.Size(161, 22)
        Me.txtPartsTotal.TabIndex = 1
        '
        'txtLaborTotal
        '
        Me.txtLaborTotal.BackColor = System.Drawing.Color.White
        Me.txtLaborTotal.Location = New System.Drawing.Point(67, 91)
        Me.txtLaborTotal.Name = "txtLaborTotal"
        Me.txtLaborTotal.ReadOnly = True
        Me.txtLaborTotal.Size = New System.Drawing.Size(157, 22)
        Me.txtLaborTotal.TabIndex = 2
        '
        'txtSalesTaxTotal
        '
        Me.txtSalesTaxTotal.BackColor = System.Drawing.Color.White
        Me.txtSalesTaxTotal.Location = New System.Drawing.Point(92, 120)
        Me.txtSalesTaxTotal.Name = "txtSalesTaxTotal"
        Me.txtSalesTaxTotal.ReadOnly = True
        Me.txtSalesTaxTotal.Size = New System.Drawing.Size(132, 22)
        Me.txtSalesTaxTotal.TabIndex = 3
        '
        'txtTotalsTotal
        '
        Me.txtTotalsTotal.BackColor = System.Drawing.Color.White
        Me.txtTotalsTotal.Location = New System.Drawing.Point(69, 149)
        Me.txtTotalsTotal.Name = "txtTotalsTotal"
        Me.txtTotalsTotal.ReadOnly = True
        Me.txtTotalsTotal.Size = New System.Drawing.Size(155, 22)
        Me.txtTotalsTotal.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 17)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Parts:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 17)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Labor:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 123)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 17)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Sales Tax:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 152)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 17)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Totals:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 27)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(212, 17)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Dollar Amount For All Customers"
        '
        'Summary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(243, 256)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtTotalsTotal)
        Me.Controls.Add(Me.txtSalesTaxTotal)
        Me.Controls.Add(Me.txtLaborTotal)
        Me.Controls.Add(Me.txtPartsTotal)
        Me.Controls.Add(Me.btnOK)
        Me.Name = "Summary"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Summary"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents txtPartsTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtLaborTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtSalesTaxTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalsTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
