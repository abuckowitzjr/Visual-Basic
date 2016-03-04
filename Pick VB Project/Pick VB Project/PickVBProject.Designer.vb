<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PickVBProject
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
        Me.btnGO = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblMoonPatrol = New System.Windows.Forms.Label()
        Me.lblPong = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'btnGO
        '
        Me.btnGO.Location = New System.Drawing.Point(142, 141)
        Me.btnGO.Name = "btnGO"
        Me.btnGO.Size = New System.Drawing.Size(118, 41)
        Me.btnGO.TabIndex = 0
        Me.btnGO.Text = "GO!"
        Me.btnGO.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Moon Patrol"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(74, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Pong"
        '
        'lblMoonPatrol
        '
        Me.lblMoonPatrol.BackColor = System.Drawing.Color.White
        Me.lblMoonPatrol.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMoonPatrol.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMoonPatrol.Location = New System.Drawing.Point(121, 25)
        Me.lblMoonPatrol.Name = "lblMoonPatrol"
        Me.lblMoonPatrol.Size = New System.Drawing.Size(233, 32)
        Me.lblMoonPatrol.TabIndex = 3
        Me.lblMoonPatrol.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPong
        '
        Me.lblPong.BackColor = System.Drawing.Color.White
        Me.lblPong.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPong.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPong.Location = New System.Drawing.Point(121, 69)
        Me.lblPong.Name = "lblPong"
        Me.lblPong.Size = New System.Drawing.Size(233, 32)
        Me.lblPong.TabIndex = 4
        Me.lblPong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        Me.Timer1.Interval = 10
        '
        'PickVBProject
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(395, 210)
        Me.Controls.Add(Me.lblPong)
        Me.Controls.Add(Me.lblMoonPatrol)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnGO)
        Me.Name = "PickVBProject"
        Me.Text = "Pick VB Project"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnGO As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblMoonPatrol As System.Windows.Forms.Label
    Friend WithEvents lblPong As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer

End Class
