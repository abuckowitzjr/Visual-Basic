<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFactorial
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
        Me.lblInput = New System.Windows.Forms.Label()
        Me.txtNumber = New System.Windows.Forms.TextBox()
        Me.lblInformation = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.lblDisplay = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblInput
        '
        Me.lblInput.AutoSize = True
        Me.lblInput.Location = New System.Drawing.Point(98, 115)
        Me.lblInput.Name = "lblInput"
        Me.lblInput.Size = New System.Drawing.Size(253, 17)
        Me.lblInput.TabIndex = 0
        Me.lblInput.Text = "Type a positive integer smaller than 30"
        '
        'txtNumber
        '
        Me.txtNumber.Location = New System.Drawing.Point(381, 112)
        Me.txtNumber.Name = "txtNumber"
        Me.txtNumber.Size = New System.Drawing.Size(58, 22)
        Me.txtNumber.TabIndex = 1
        '
        'lblInformation
        '
        Me.lblInformation.Location = New System.Drawing.Point(38, 30)
        Me.lblInformation.Name = "lblInformation"
        Me.lblInformation.Size = New System.Drawing.Size(460, 42)
        Me.lblInformation.TabIndex = 2
        Me.lblInformation.Text = "Factorial of a number is the product of all the positive integers less than or eq" & _
    "ual to the number ( Factorial of 4 is 1*2*3*4 which is equal to 24)"
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(170, 167)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(167, 39)
        Me.btnCalculate.TabIndex = 3
        Me.btnCalculate.Text = "Calculate Factorial"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'lblDisplay
        '
        Me.lblDisplay.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDisplay.Location = New System.Drawing.Point(80, 258)
        Me.lblDisplay.Name = "lblDisplay"
        Me.lblDisplay.Size = New System.Drawing.Size(376, 50)
        Me.lblDisplay.TabIndex = 4
        Me.lblDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmFactorial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(536, 350)
        Me.Controls.Add(Me.lblDisplay)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblInformation)
        Me.Controls.Add(Me.txtNumber)
        Me.Controls.Add(Me.lblInput)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFactorial"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Factorial"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblInput As System.Windows.Forms.Label
    Friend WithEvents txtNumber As System.Windows.Forms.TextBox
    Friend WithEvents lblInformation As System.Windows.Forms.Label
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents lblDisplay As System.Windows.Forms.Label

End Class
