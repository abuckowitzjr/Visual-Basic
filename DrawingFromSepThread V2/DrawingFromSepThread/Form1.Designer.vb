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
        Me.pb = New System.Windows.Forms.PictureBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.bw1 = New System.ComponentModel.BackgroundWorker()
        Me.btnStop = New System.Windows.Forms.Button()
        CType(Me.pb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pb
        '
        Me.pb.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pb.Location = New System.Drawing.Point(0, 0)
        Me.pb.Name = "pb"
        Me.pb.Size = New System.Drawing.Size(632, 605)
        Me.pb.TabIndex = 0
        Me.pb.TabStop = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(12, 570)
        Me.ProgressBar1.Maximum = 1000
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(527, 23)
        Me.ProgressBar1.TabIndex = 1
        Me.ProgressBar1.Value = 1
        '
        'bw1
        '
        Me.bw1.WorkerReportsProgress = True
        Me.bw1.WorkerSupportsCancellation = True
        '
        'btnStop
        '
        Me.btnStop.Location = New System.Drawing.Point(545, 569)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(75, 25)
        Me.btnStop.TabIndex = 2
        Me.btnStop.Text = "Stop"
        Me.btnStop.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(632, 605)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.pb)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.pb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pb As System.Windows.Forms.PictureBox
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents bw1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents btnStop As System.Windows.Forms.Button

End Class
