<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SummaryForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTotalSales = New System.Windows.Forms.TextBox()
        Me.txtTotalCommission = New System.Windows.Forms.TextBox()
        Me.txtTotalPay = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(71, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Total Sales:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Total Commission:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(82, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Total Pay:"
        '
        'txtTotalSales
        '
        Me.txtTotalSales.BackColor = System.Drawing.Color.White
        Me.txtTotalSales.Location = New System.Drawing.Point(160, 18)
        Me.txtTotalSales.Name = "txtTotalSales"
        Me.txtTotalSales.ReadOnly = True
        Me.txtTotalSales.Size = New System.Drawing.Size(155, 22)
        Me.txtTotalSales.TabIndex = 3
        '
        'txtTotalCommission
        '
        Me.txtTotalCommission.BackColor = System.Drawing.Color.White
        Me.txtTotalCommission.Location = New System.Drawing.Point(160, 45)
        Me.txtTotalCommission.Name = "txtTotalCommission"
        Me.txtTotalCommission.ReadOnly = True
        Me.txtTotalCommission.Size = New System.Drawing.Size(155, 22)
        Me.txtTotalCommission.TabIndex = 4
        '
        'txtTotalPay
        '
        Me.txtTotalPay.BackColor = System.Drawing.Color.White
        Me.txtTotalPay.Location = New System.Drawing.Point(160, 72)
        Me.txtTotalPay.Name = "txtTotalPay"
        Me.txtTotalPay.ReadOnly = True
        Me.txtTotalPay.Size = New System.Drawing.Size(155, 22)
        Me.txtTotalPay.TabIndex = 5
        '
        'Summary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(347, 116)
        Me.Controls.Add(Me.txtTotalPay)
        Me.Controls.Add(Me.txtTotalCommission)
        Me.Controls.Add(Me.txtTotalSales)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Summary"
        Me.Text = "Summary"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtTotalSales As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalCommission As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalPay As System.Windows.Forms.TextBox
End Class
