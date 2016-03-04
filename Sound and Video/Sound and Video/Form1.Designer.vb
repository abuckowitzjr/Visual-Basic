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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btnPlay = New System.Windows.Forms.Button()
        Me.a = New AxWMPLib.AxWindowsMediaPlayer()
        CType(Me.a, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnPlay
        '
        Me.btnPlay.Location = New System.Drawing.Point(288, 421)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(149, 75)
        Me.btnPlay.TabIndex = 0
        Me.btnPlay.Text = "Play"
        Me.btnPlay.UseVisualStyleBackColor = True
        '
        'a
        '
        Me.a.Dock = System.Windows.Forms.DockStyle.Fill
        Me.a.Enabled = True
        Me.a.Location = New System.Drawing.Point(0, 0)
        Me.a.Name = "a"
        Me.a.OcxState = CType(resources.GetObject("a.OcxState"), System.Windows.Forms.AxHost.State)
        Me.a.Size = New System.Drawing.Size(770, 609)
        Me.a.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(770, 609)
        Me.Controls.Add(Me.a)
        Me.Controls.Add(Me.btnPlay)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.a, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnPlay As System.Windows.Forms.Button
    Friend WithEvents a As AxWMPLib.AxWindowsMediaPlayer

End Class
