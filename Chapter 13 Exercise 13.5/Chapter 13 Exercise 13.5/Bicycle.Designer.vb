<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBicycle
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
        Me.pbBicycle = New System.Windows.Forms.PictureBox()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.pbBicycle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbBicycle
        '
        Me.pbBicycle.Image = Global.Chapter_13_Exercise_13._5.My.Resources.Resources.Bicycle
        Me.pbBicycle.Location = New System.Drawing.Point(670, 24)
        Me.pbBicycle.Name = "pbBicycle"
        Me.pbBicycle.Size = New System.Drawing.Size(150, 150)
        Me.pbBicycle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbBicycle.TabIndex = 0
        Me.pbBicycle.TabStop = False
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(306, 207)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(107, 42)
        Me.btnStart.TabIndex = 1
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnStop
        '
        Me.btnStop.Location = New System.Drawing.Point(419, 207)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(107, 42)
        Me.btnStop.TabIndex = 2
        Me.btnStop.Text = "Stop"
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'frmBicycle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(832, 261)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.pbBicycle)
        Me.Name = "frmBicycle"
        Me.Text = "Bicycle"
        CType(Me.pbBicycle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pbBicycle As System.Windows.Forms.PictureBox
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents btnStop As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer

End Class
