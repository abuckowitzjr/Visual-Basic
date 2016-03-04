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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTotalTesters = New System.Windows.Forms.TextBox()
        Me.txtPrunePunchAverage = New System.Windows.Forms.TextBox()
        Me.txtAppleAdeAverage = New System.Windows.Forms.TextBox()
        Me.lblWinner = New System.Windows.Forms.Label()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(103, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "WINNER"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(166, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Total Number of Testers:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 137)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(196, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Prune Punch Average Rating:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 171)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(179, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Apple Ade Average Rating:"
        '
        'txtTotalTesters
        '
        Me.txtTotalTesters.BackColor = System.Drawing.Color.White
        Me.txtTotalTesters.Location = New System.Drawing.Point(194, 102)
        Me.txtTotalTesters.Name = "txtTotalTesters"
        Me.txtTotalTesters.ReadOnly = True
        Me.txtTotalTesters.Size = New System.Drawing.Size(113, 22)
        Me.txtTotalTesters.TabIndex = 5
        '
        'txtPrunePunchAverage
        '
        Me.txtPrunePunchAverage.BackColor = System.Drawing.Color.White
        Me.txtPrunePunchAverage.Location = New System.Drawing.Point(224, 134)
        Me.txtPrunePunchAverage.Name = "txtPrunePunchAverage"
        Me.txtPrunePunchAverage.ReadOnly = True
        Me.txtPrunePunchAverage.Size = New System.Drawing.Size(83, 22)
        Me.txtPrunePunchAverage.TabIndex = 6
        '
        'txtAppleAdeAverage
        '
        Me.txtAppleAdeAverage.BackColor = System.Drawing.Color.White
        Me.txtAppleAdeAverage.Location = New System.Drawing.Point(207, 168)
        Me.txtAppleAdeAverage.Name = "txtAppleAdeAverage"
        Me.txtAppleAdeAverage.ReadOnly = True
        Me.txtAppleAdeAverage.Size = New System.Drawing.Size(100, 22)
        Me.txtAppleAdeAverage.TabIndex = 7
        '
        'lblWinner
        '
        Me.lblWinner.Font = New System.Drawing.Font("AR JULIAN", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWinner.Location = New System.Drawing.Point(75, 49)
        Me.lblWinner.Name = "lblWinner"
        Me.lblWinner.Size = New System.Drawing.Size(183, 38)
        Me.lblWinner.TabIndex = 8
        Me.lblWinner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(112, 211)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(109, 43)
        Me.btnOK.TabIndex = 9
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'Summary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(332, 270)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.lblWinner)
        Me.Controls.Add(Me.txtAppleAdeAverage)
        Me.Controls.Add(Me.txtPrunePunchAverage)
        Me.Controls.Add(Me.txtTotalTesters)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Summary"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Summary"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtTotalTesters As System.Windows.Forms.TextBox
    Friend WithEvents txtPrunePunchAverage As System.Windows.Forms.TextBox
    Friend WithEvents txtAppleAdeAverage As System.Windows.Forms.TextBox
    Friend WithEvents lblWinner As System.Windows.Forms.Label
    Friend WithEvents btnOK As System.Windows.Forms.Button
End Class
