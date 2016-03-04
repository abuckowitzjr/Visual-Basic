<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReadWrite
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
        Me.txtFileName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnOpen = New System.Windows.Forms.Button()
        Me.txtContent = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtInputText = New System.Windows.Forms.TextBox()
        Me.btnAppend = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SuspendLayout()
        '
        'txtFileName
        '
        Me.txtFileName.BackColor = System.Drawing.Color.White
        Me.txtFileName.Location = New System.Drawing.Point(126, 38)
        Me.txtFileName.Name = "txtFileName"
        Me.txtFileName.ReadOnly = True
        Me.txtFileName.Size = New System.Drawing.Size(418, 22)
        Me.txtFileName.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(54, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "File"
        '
        'btnOpen
        '
        Me.btnOpen.Location = New System.Drawing.Point(552, 37)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(33, 23)
        Me.btnOpen.TabIndex = 2
        Me.btnOpen.Text = "...."
        Me.btnOpen.UseVisualStyleBackColor = True
        '
        'txtContent
        '
        Me.txtContent.Location = New System.Drawing.Point(126, 92)
        Me.txtContent.Multiline = True
        Me.txtContent.Name = "txtContent"
        Me.txtContent.Size = New System.Drawing.Size(418, 275)
        Me.txtContent.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(54, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Content"
        '
        'txtInputText
        '
        Me.txtInputText.Location = New System.Drawing.Point(126, 391)
        Me.txtInputText.Name = "txtInputText"
        Me.txtInputText.Size = New System.Drawing.Size(314, 22)
        Me.txtInputText.TabIndex = 5
        '
        'btnAppend
        '
        Me.btnAppend.Enabled = False
        Me.btnAppend.Location = New System.Drawing.Point(465, 389)
        Me.btnAppend.Name = "btnAppend"
        Me.btnAppend.Size = New System.Drawing.Size(79, 26)
        Me.btnAppend.TabIndex = 6
        Me.btnAppend.Text = "Append"
        Me.btnAppend.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.Filter = "Text Files (*.txt)|*.txt"
        '
        'frmReadWrite
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(671, 466)
        Me.Controls.Add(Me.btnAppend)
        Me.Controls.Add(Me.txtInputText)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtContent)
        Me.Controls.Add(Me.btnOpen)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtFileName)
        Me.Name = "frmReadWrite"
        Me.Text = "Read/Write Text files"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtFileName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnOpen As System.Windows.Forms.Button
    Friend WithEvents txtContent As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtInputText As System.Windows.Forms.TextBox
    Friend WithEvents btnAppend As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog

End Class
