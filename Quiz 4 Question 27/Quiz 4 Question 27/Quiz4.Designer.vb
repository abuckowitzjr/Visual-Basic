<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Quiz4
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbNormal = New System.Windows.Forms.RadioButton()
        Me.rbStretch = New System.Windows.Forms.RadioButton()
        Me.rbZoom = New System.Windows.Forms.RadioButton()
        Me.pbPicture = New System.Windows.Forms.PictureBox()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.lstboxPictureFiles = New System.Windows.Forms.ListBox()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox1.SuspendLayout()
        CType(Me.pbPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbNormal)
        Me.GroupBox1.Controls.Add(Me.rbStretch)
        Me.GroupBox1.Controls.Add(Me.rbZoom)
        Me.GroupBox1.Location = New System.Drawing.Point(32, 29)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(714, 81)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Picture Size Mode"
        '
        'rbNormal
        '
        Me.rbNormal.AutoSize = True
        Me.rbNormal.Location = New System.Drawing.Point(595, 33)
        Me.rbNormal.Name = "rbNormal"
        Me.rbNormal.Size = New System.Drawing.Size(74, 21)
        Me.rbNormal.TabIndex = 3
        Me.rbNormal.TabStop = True
        Me.rbNormal.Text = "Normal"
        Me.rbNormal.UseVisualStyleBackColor = True
        '
        'rbStretch
        '
        Me.rbStretch.AutoSize = True
        Me.rbStretch.Location = New System.Drawing.Point(38, 33)
        Me.rbStretch.Name = "rbStretch"
        Me.rbStretch.Size = New System.Drawing.Size(74, 21)
        Me.rbStretch.TabIndex = 1
        Me.rbStretch.TabStop = True
        Me.rbStretch.Text = "Stretch"
        Me.rbStretch.UseVisualStyleBackColor = True
        '
        'rbZoom
        '
        Me.rbZoom.AutoSize = True
        Me.rbZoom.Location = New System.Drawing.Point(325, 33)
        Me.rbZoom.Name = "rbZoom"
        Me.rbZoom.Size = New System.Drawing.Size(65, 21)
        Me.rbZoom.TabIndex = 2
        Me.rbZoom.TabStop = True
        Me.rbZoom.Text = "Zoom"
        Me.rbZoom.UseVisualStyleBackColor = True
        '
        'pbPicture
        '
        Me.pbPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pbPicture.Location = New System.Drawing.Point(32, 128)
        Me.pbPicture.Name = "pbPicture"
        Me.pbPicture.Size = New System.Drawing.Size(714, 443)
        Me.pbPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbPicture.TabIndex = 1
        Me.pbPicture.TabStop = False
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(32, 577)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(714, 69)
        Me.txtDescription.TabIndex = 2
        '
        'lstboxPictureFiles
        '
        Me.lstboxPictureFiles.FormattingEnabled = True
        Me.lstboxPictureFiles.ItemHeight = 16
        Me.lstboxPictureFiles.Location = New System.Drawing.Point(785, 77)
        Me.lstboxPictureFiles.Name = "lstboxPictureFiles"
        Me.lstboxPictureFiles.Size = New System.Drawing.Size(323, 516)
        Me.lstboxPictureFiles.Sorted = True
        Me.lstboxPictureFiles.TabIndex = 3
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(785, 620)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(135, 26)
        Me.btnRemove.TabIndex = 4
        Me.btnRemove.Text = "Remove Picture"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(973, 620)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(135, 26)
        Me.btnAdd.TabIndex = 5
        Me.btnAdd.Text = "Add Picture"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(880, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(141, 17)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Pictures in the Album"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Quiz4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1143, 684)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.lstboxPictureFiles)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.pbPicture)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Quiz4"
        Me.Text = "Quiz 4"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.pbPicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbNormal As System.Windows.Forms.RadioButton
    Friend WithEvents rbStretch As System.Windows.Forms.RadioButton
    Friend WithEvents rbZoom As System.Windows.Forms.RadioButton
    Friend WithEvents pbPicture As System.Windows.Forms.PictureBox
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents lstboxPictureFiles As System.Windows.Forms.ListBox
    Friend WithEvents btnRemove As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog

End Class
