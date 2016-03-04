<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VBDesignLTD
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VBDesignLTD))
        Me.HeadDesignerButton = New System.Windows.Forms.Button()
        Me.PhoneButton = New System.Windows.Forms.Button()
        Me.DeptButton = New System.Windows.Forms.Button()
        Me.PrintButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.HeadDesignerLabel = New System.Windows.Forms.Label()
        Me.TelephoneLabel = New System.Windows.Forms.Label()
        Me.DepartmentLabel = New System.Windows.Forms.Label()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.SuspendLayout()
        '
        'HeadDesignerButton
        '
        Me.HeadDesignerButton.Location = New System.Drawing.Point(12, 12)
        Me.HeadDesignerButton.Name = "HeadDesignerButton"
        Me.HeadDesignerButton.Size = New System.Drawing.Size(129, 36)
        Me.HeadDesignerButton.TabIndex = 0
        Me.HeadDesignerButton.Text = "Head Designer"
        Me.HeadDesignerButton.UseVisualStyleBackColor = True
        '
        'PhoneButton
        '
        Me.PhoneButton.Location = New System.Drawing.Point(12, 96)
        Me.PhoneButton.Name = "PhoneButton"
        Me.PhoneButton.Size = New System.Drawing.Size(129, 36)
        Me.PhoneButton.TabIndex = 1
        Me.PhoneButton.Text = "Telephone Number"
        Me.PhoneButton.UseVisualStyleBackColor = True
        '
        'DeptButton
        '
        Me.DeptButton.Location = New System.Drawing.Point(12, 54)
        Me.DeptButton.Name = "DeptButton"
        Me.DeptButton.Size = New System.Drawing.Size(129, 36)
        Me.DeptButton.TabIndex = 2
        Me.DeptButton.Text = "Department"
        Me.DeptButton.UseVisualStyleBackColor = True
        '
        'PrintButton
        '
        Me.PrintButton.Location = New System.Drawing.Point(12, 156)
        Me.PrintButton.Name = "PrintButton"
        Me.PrintButton.Size = New System.Drawing.Size(61, 34)
        Me.PrintButton.TabIndex = 3
        Me.PrintButton.Text = "Print"
        Me.PrintButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(80, 156)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(61, 34)
        Me.ExitButton.TabIndex = 4
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Location = New System.Drawing.Point(173, 177)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(163, 13)
        Me.NameLabel.TabIndex = 5
        Me.NameLabel.Text = "Programmed by Arthur Buckowitz"
        '
        'HeadDesignerLabel
        '
        Me.HeadDesignerLabel.BackColor = System.Drawing.Color.White
        Me.HeadDesignerLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.HeadDesignerLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HeadDesignerLabel.Location = New System.Drawing.Point(154, 17)
        Me.HeadDesignerLabel.Name = "HeadDesignerLabel"
        Me.HeadDesignerLabel.Size = New System.Drawing.Size(182, 25)
        Me.HeadDesignerLabel.TabIndex = 6
        '
        'TelephoneLabel
        '
        Me.TelephoneLabel.BackColor = System.Drawing.Color.White
        Me.TelephoneLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TelephoneLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TelephoneLabel.Location = New System.Drawing.Point(154, 101)
        Me.TelephoneLabel.Name = "TelephoneLabel"
        Me.TelephoneLabel.Size = New System.Drawing.Size(182, 25)
        Me.TelephoneLabel.TabIndex = 9
        '
        'DepartmentLabel
        '
        Me.DepartmentLabel.BackColor = System.Drawing.Color.White
        Me.DepartmentLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DepartmentLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DepartmentLabel.Location = New System.Drawing.Point(154, 59)
        Me.DepartmentLabel.Name = "DepartmentLabel"
        Me.DepartmentLabel.Size = New System.Drawing.Size(182, 25)
        Me.DepartmentLabel.TabIndex = 10
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'VBDesignLTD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(350, 203)
        Me.Controls.Add(Me.DepartmentLabel)
        Me.Controls.Add(Me.TelephoneLabel)
        Me.Controls.Add(Me.HeadDesignerLabel)
        Me.Controls.Add(Me.NameLabel)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.PrintButton)
        Me.Controls.Add(Me.DeptButton)
        Me.Controls.Add(Me.PhoneButton)
        Me.Controls.Add(Me.HeadDesignerButton)
        Me.Name = "VBDesignLTD"
        Me.Text = "VB Design LTD"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents HeadDesignerButton As System.Windows.Forms.Button
    Friend WithEvents PhoneButton As System.Windows.Forms.Button
    Friend WithEvents DeptButton As System.Windows.Forms.Button
    Friend WithEvents PrintButton As System.Windows.Forms.Button
    Friend WithEvents ExitButton As System.Windows.Forms.Button
    Friend WithEvents NameLabel As System.Windows.Forms.Label
    Friend WithEvents HeadDesignerLabel As System.Windows.Forms.Label
    Friend WithEvents TelephoneLabel As System.Windows.Forms.Label
    Friend WithEvents DepartmentLabel As System.Windows.Forms.Label
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm

End Class
