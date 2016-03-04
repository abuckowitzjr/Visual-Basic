<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmJobInfo
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
        Me.txtJobNumber = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCustomerName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtHourOfLabor = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtSalesTax = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtSubtotal = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtLabor = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtParts = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.txtAmountCharged = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtJobNumber
        '
        Me.txtJobNumber.Location = New System.Drawing.Point(120, 24)
        Me.txtJobNumber.Name = "txtJobNumber"
        Me.txtJobNumber.Size = New System.Drawing.Size(226, 22)
        Me.txtJobNumber.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Job Number:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Customer Name:"
        '
        'txtCustomerName
        '
        Me.txtCustomerName.Location = New System.Drawing.Point(144, 52)
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.Size = New System.Drawing.Size(202, 22)
        Me.txtCustomerName.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(180, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Amount Charged For Parts:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(25, 111)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 17)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Hours of Labor:"
        '
        'txtHourOfLabor
        '
        Me.txtHourOfLabor.Location = New System.Drawing.Point(138, 108)
        Me.txtHourOfLabor.Name = "txtHourOfLabor"
        Me.txtHourOfLabor.Size = New System.Drawing.Size(208, 22)
        Me.txtHourOfLabor.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(160, 279)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 17)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Total:"
        '
        'txtTotal
        '
        Me.txtTotal.BackColor = System.Drawing.Color.White
        Me.txtTotal.Location = New System.Drawing.Point(210, 276)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(136, 22)
        Me.txtTotal.TabIndex = 805
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(160, 251)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 17)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Sales Tax:"
        '
        'txtSalesTax
        '
        Me.txtSalesTax.BackColor = System.Drawing.Color.White
        Me.txtSalesTax.Location = New System.Drawing.Point(240, 248)
        Me.txtSalesTax.Name = "txtSalesTax"
        Me.txtSalesTax.ReadOnly = True
        Me.txtSalesTax.Size = New System.Drawing.Size(106, 22)
        Me.txtSalesTax.TabIndex = 804
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(160, 223)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 17)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Subtotal:"
        '
        'txtSubtotal
        '
        Me.txtSubtotal.BackColor = System.Drawing.Color.White
        Me.txtSubtotal.Location = New System.Drawing.Point(230, 220)
        Me.txtSubtotal.Name = "txtSubtotal"
        Me.txtSubtotal.ReadOnly = True
        Me.txtSubtotal.Size = New System.Drawing.Size(116, 22)
        Me.txtSubtotal.TabIndex = 803
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(160, 195)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 17)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Labor:"
        '
        'txtLabor
        '
        Me.txtLabor.BackColor = System.Drawing.Color.White
        Me.txtLabor.Location = New System.Drawing.Point(215, 192)
        Me.txtLabor.Name = "txtLabor"
        Me.txtLabor.ReadOnly = True
        Me.txtLabor.Size = New System.Drawing.Size(131, 22)
        Me.txtLabor.TabIndex = 802
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(160, 167)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(45, 17)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "Parts:"
        '
        'txtParts
        '
        Me.txtParts.BackColor = System.Drawing.Color.White
        Me.txtParts.Location = New System.Drawing.Point(211, 164)
        Me.txtParts.Name = "txtParts"
        Me.txtParts.ReadOnly = True
        Me.txtParts.Size = New System.Drawing.Size(135, 22)
        Me.txtParts.TabIndex = 801
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(28, 156)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(101, 48)
        Me.btnCalculate.TabIndex = 4
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(28, 210)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(101, 48)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(28, 264)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(101, 48)
        Me.btnOK.TabIndex = 6
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'txtAmountCharged
        '
        Me.txtAmountCharged.Location = New System.Drawing.Point(211, 80)
        Me.txtAmountCharged.Name = "txtAmountCharged"
        Me.txtAmountCharged.Size = New System.Drawing.Size(135, 22)
        Me.txtAmountCharged.TabIndex = 2
        '
        'frmJobInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(371, 337)
        Me.Controls.Add(Me.txtAmountCharged)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtSalesTax)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtSubtotal)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtLabor)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtParts)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtHourOfLabor)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCustomerName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtJobNumber)
        Me.Name = "frmJobInfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Job Information"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtJobNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCustomerName As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtHourOfLabor As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtSalesTax As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtSubtotal As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtLabor As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtParts As System.Windows.Forms.TextBox
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents txtAmountCharged As System.Windows.Forms.TextBox
End Class
