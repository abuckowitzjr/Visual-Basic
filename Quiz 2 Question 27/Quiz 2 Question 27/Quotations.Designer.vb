<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuotations
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rbErnestHemingway = New System.Windows.Forms.RadioButton()
        Me.rbOscarWilde = New System.Windows.Forms.RadioButton()
        Me.rbRobertFrost = New System.Windows.Forms.RadioButton()
        Me.rbWaltWhitman = New System.Windows.Forms.RadioButton()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(386, 153)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(163, 79)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Display Message"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(96, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 17)
        Me.Label1.TabIndex = 200
        Me.Label1.Text = "Authors"
        '
        'rbErnestHemingway
        '
        Me.rbErnestHemingway.AutoSize = True
        Me.rbErnestHemingway.Location = New System.Drawing.Point(126, 106)
        Me.rbErnestHemingway.Name = "rbErnestHemingway"
        Me.rbErnestHemingway.Size = New System.Drawing.Size(146, 21)
        Me.rbErnestHemingway.TabIndex = 1
        Me.rbErnestHemingway.TabStop = True
        Me.rbErnestHemingway.Text = "Ernest Hemingway"
        Me.rbErnestHemingway.UseVisualStyleBackColor = True
        '
        'rbOscarWilde
        '
        Me.rbOscarWilde.AutoSize = True
        Me.rbOscarWilde.Location = New System.Drawing.Point(126, 149)
        Me.rbOscarWilde.Name = "rbOscarWilde"
        Me.rbOscarWilde.Size = New System.Drawing.Size(106, 21)
        Me.rbOscarWilde.TabIndex = 2
        Me.rbOscarWilde.TabStop = True
        Me.rbOscarWilde.Text = "Oscar Wilde"
        Me.rbOscarWilde.UseVisualStyleBackColor = True
        '
        'rbRobertFrost
        '
        Me.rbRobertFrost.AutoSize = True
        Me.rbRobertFrost.Location = New System.Drawing.Point(126, 192)
        Me.rbRobertFrost.Name = "rbRobertFrost"
        Me.rbRobertFrost.Size = New System.Drawing.Size(108, 21)
        Me.rbRobertFrost.TabIndex = 3
        Me.rbRobertFrost.TabStop = True
        Me.rbRobertFrost.Text = "Robert Frost"
        Me.rbRobertFrost.UseVisualStyleBackColor = True
        '
        'rbWaltWhitman
        '
        Me.rbWaltWhitman.AutoSize = True
        Me.rbWaltWhitman.Location = New System.Drawing.Point(126, 235)
        Me.rbWaltWhitman.Name = "rbWaltWhitman"
        Me.rbWaltWhitman.Size = New System.Drawing.Size(116, 21)
        Me.rbWaltWhitman.TabIndex = 4
        Me.rbWaltWhitman.TabStop = True
        Me.rbWaltWhitman.Text = "Walt Whitman"
        Me.rbWaltWhitman.UseVisualStyleBackColor = True
        '
        'lblMessage
        '
        Me.lblMessage.BackColor = System.Drawing.Color.Silver
        Me.lblMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMessage.Location = New System.Drawing.Point(80, 337)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(469, 65)
        Me.lblMessage.TabIndex = 201
        Me.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmQuotations
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(628, 453)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.rbWaltWhitman)
        Me.Controls.Add(Me.rbRobertFrost)
        Me.Controls.Add(Me.rbOscarWilde)
        Me.Controls.Add(Me.rbErnestHemingway)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "frmQuotations"
        Me.Text = "Quotations"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents rbErnestHemingway As System.Windows.Forms.RadioButton
    Friend WithEvents rbOscarWilde As System.Windows.Forms.RadioButton
    Friend WithEvents rbRobertFrost As System.Windows.Forms.RadioButton
    Friend WithEvents rbWaltWhitman As System.Windows.Forms.RadioButton
    Friend WithEvents lblMessage As System.Windows.Forms.Label

End Class
