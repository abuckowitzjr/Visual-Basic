<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lblSmallest = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnShowNumbers = New System.Windows.Forms.Button()
        Me.lblLargest = New System.Windows.Forms.Label()
        Me.lblAverage = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(47, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Smallest"
        '
        'lblSmallest
        '
        Me.lblSmallest.Location = New System.Drawing.Point(28, 52)
        Me.lblSmallest.Name = "lblSmallest"
        Me.lblSmallest.Size = New System.Drawing.Size(101, 30)
        Me.lblSmallest.TabIndex = 1
        Me.lblSmallest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(157, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Largest"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(264, 29)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Average"
        '
        'btnShowNumbers
        '
        Me.btnShowNumbers.Location = New System.Drawing.Point(111, 96)
        Me.btnShowNumbers.Name = "btnShowNumbers"
        Me.btnShowNumbers.Size = New System.Drawing.Size(149, 47)
        Me.btnShowNumbers.TabIndex = 6
        Me.btnShowNumbers.Text = "Show Numbers"
        Me.btnShowNumbers.UseVisualStyleBackColor = True
        '
        'lblLargest
        '
        Me.lblLargest.Location = New System.Drawing.Point(135, 52)
        Me.lblLargest.Name = "lblLargest"
        Me.lblLargest.Size = New System.Drawing.Size(101, 30)
        Me.lblLargest.TabIndex = 7
        Me.lblLargest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAverage
        '
        Me.lblAverage.Location = New System.Drawing.Point(242, 52)
        Me.lblAverage.Name = "lblAverage"
        Me.lblAverage.Size = New System.Drawing.Size(101, 30)
        Me.lblAverage.TabIndex = 8
        Me.lblAverage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(371, 158)
        Me.Controls.Add(Me.lblAverage)
        Me.Controls.Add(Me.lblLargest)
        Me.Controls.Add(Me.btnShowNumbers)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblSmallest)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblSmallest As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnShowNumbers As System.Windows.Forms.Button
    Friend WithEvents lblLargest As System.Windows.Forms.Label
    Friend WithEvents lblAverage As System.Windows.Forms.Label

End Class
