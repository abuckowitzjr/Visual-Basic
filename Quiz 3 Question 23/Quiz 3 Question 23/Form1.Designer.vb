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
        Me.components = New System.ComponentModel.Container()
        Me.btnDrawCircles = New System.Windows.Forms.Button()
        Me.btnDrawSquares = New System.Windows.Forms.Button()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.pbContainer = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.pbContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnDrawCircles
        '
        Me.btnDrawCircles.Location = New System.Drawing.Point(78, 608)
        Me.btnDrawCircles.Name = "btnDrawCircles"
        Me.btnDrawCircles.Size = New System.Drawing.Size(137, 47)
        Me.btnDrawCircles.TabIndex = 0
        Me.btnDrawCircles.Text = "Draw Circles"
        Me.btnDrawCircles.UseVisualStyleBackColor = True
        '
        'btnDrawSquares
        '
        Me.btnDrawSquares.Location = New System.Drawing.Point(373, 608)
        Me.btnDrawSquares.Name = "btnDrawSquares"
        Me.btnDrawSquares.Size = New System.Drawing.Size(137, 47)
        Me.btnDrawSquares.TabIndex = 1
        Me.btnDrawSquares.Text = "Draw Squares"
        Me.btnDrawSquares.UseVisualStyleBackColor = True
        '
        'btnStop
        '
        Me.btnStop.Location = New System.Drawing.Point(668, 608)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(137, 47)
        Me.btnStop.TabIndex = 2
        Me.btnStop.Text = "Stop"
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'pbContainer
        '
        Me.pbContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbContainer.Location = New System.Drawing.Point(0, 0)
        Me.pbContainer.Name = "pbContainer"
        Me.pbContainer.Size = New System.Drawing.Size(882, 705)
        Me.pbContainer.TabIndex = 3
        Me.pbContainer.TabStop = False
        '
        'Timer1
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(882, 705)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.btnDrawSquares)
        Me.Controls.Add(Me.btnDrawCircles)
        Me.Controls.Add(Me.pbContainer)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.pbContainer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnDrawCircles As System.Windows.Forms.Button
    Friend WithEvents btnDrawSquares As System.Windows.Forms.Button
    Friend WithEvents btnStop As System.Windows.Forms.Button
    Friend WithEvents pbContainer As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer

End Class
