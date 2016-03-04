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
        Me.rbRed = New System.Windows.Forms.RadioButton()
        Me.rbGreen = New System.Windows.Forms.RadioButton()
        Me.rbBlue = New System.Windows.Forms.RadioButton()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'rbRed
        '
        Me.rbRed.AutoSize = True
        Me.rbRed.Checked = True
        Me.rbRed.Location = New System.Drawing.Point(1197, 20)
        Me.rbRed.Name = "rbRed"
        Me.rbRed.Size = New System.Drawing.Size(55, 21)
        Me.rbRed.TabIndex = 0
        Me.rbRed.TabStop = True
        Me.rbRed.Text = "Red"
        Me.rbRed.UseVisualStyleBackColor = True
        '
        'rbGreen
        '
        Me.rbGreen.AutoSize = True
        Me.rbGreen.Location = New System.Drawing.Point(1197, 47)
        Me.rbGreen.Name = "rbGreen"
        Me.rbGreen.Size = New System.Drawing.Size(69, 21)
        Me.rbGreen.TabIndex = 1
        Me.rbGreen.Text = "Green"
        Me.rbGreen.UseVisualStyleBackColor = True
        '
        'rbBlue
        '
        Me.rbBlue.AutoSize = True
        Me.rbBlue.Location = New System.Drawing.Point(1197, 74)
        Me.rbBlue.Name = "rbBlue"
        Me.rbBlue.Size = New System.Drawing.Size(57, 21)
        Me.rbBlue.TabIndex = 2
        Me.rbBlue.Text = "Blue"
        Me.rbBlue.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(1191, 717)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 3
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1278, 752)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.rbBlue)
        Me.Controls.Add(Me.rbGreen)
        Me.Controls.Add(Me.rbRed)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rbRed As System.Windows.Forms.RadioButton
    Friend WithEvents rbGreen As System.Windows.Forms.RadioButton
    Friend WithEvents rbBlue As System.Windows.Forms.RadioButton
    Friend WithEvents btnClear As System.Windows.Forms.Button

End Class
