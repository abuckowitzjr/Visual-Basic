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
        Me.btnCircle = New System.Windows.Forms.Button()
        Me.btnPolygon = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCircle
        '
        Me.btnCircle.Location = New System.Drawing.Point(181, 511)
        Me.btnCircle.Name = "btnCircle"
        Me.btnCircle.Size = New System.Drawing.Size(113, 47)
        Me.btnCircle.TabIndex = 0
        Me.btnCircle.Text = "Circle"
        Me.btnCircle.UseVisualStyleBackColor = True
        '
        'btnPolygon
        '
        Me.btnPolygon.Location = New System.Drawing.Point(326, 511)
        Me.btnPolygon.Name = "btnPolygon"
        Me.btnPolygon.Size = New System.Drawing.Size(113, 47)
        Me.btnPolygon.TabIndex = 1
        Me.btnPolygon.Text = "Polygon"
        Me.btnPolygon.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(77, 55)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(499, 426)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(649, 590)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnPolygon)
        Me.Controls.Add(Me.btnCircle)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCircle As System.Windows.Forms.Button
    Friend WithEvents btnPolygon As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
