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
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtQuiz1 = New System.Windows.Forms.TextBox()
        Me.txtQuiz2 = New System.Windows.Forms.TextBox()
        Me.txtQuiz3 = New System.Windows.Forms.TextBox()
        Me.txtFinal = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lstboxNames = New System.Windows.Forms.ListBox()
        Me.lblAverage = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(89, 24)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(208, 22)
        Me.txtName.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(86, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Quiz 1:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(86, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Quiz 2:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(86, 111)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Quiz 3:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(97, 139)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 17)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Final:"
        '
        'txtQuiz1
        '
        Me.txtQuiz1.Location = New System.Drawing.Point(145, 52)
        Me.txtQuiz1.Name = "txtQuiz1"
        Me.txtQuiz1.Size = New System.Drawing.Size(152, 22)
        Me.txtQuiz1.TabIndex = 6
        '
        'txtQuiz2
        '
        Me.txtQuiz2.Location = New System.Drawing.Point(145, 80)
        Me.txtQuiz2.Name = "txtQuiz2"
        Me.txtQuiz2.Size = New System.Drawing.Size(152, 22)
        Me.txtQuiz2.TabIndex = 7
        '
        'txtQuiz3
        '
        Me.txtQuiz3.Location = New System.Drawing.Point(145, 108)
        Me.txtQuiz3.Name = "txtQuiz3"
        Me.txtQuiz3.Size = New System.Drawing.Size(152, 22)
        Me.txtQuiz3.TabIndex = 8
        '
        'txtFinal
        '
        Me.txtFinal.Location = New System.Drawing.Point(145, 136)
        Me.txtFinal.Name = "txtFinal"
        Me.txtFinal.Size = New System.Drawing.Size(152, 22)
        Me.txtFinal.TabIndex = 9
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(109, 188)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(104, 43)
        Me.btnAdd.TabIndex = 10
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(393, 222)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 17)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Average:"
        '
        'lstboxNames
        '
        Me.lstboxNames.FormattingEnabled = True
        Me.lstboxNames.ItemHeight = 16
        Me.lstboxNames.Location = New System.Drawing.Point(341, 24)
        Me.lstboxNames.Name = "lstboxNames"
        Me.lstboxNames.Size = New System.Drawing.Size(242, 180)
        Me.lstboxNames.TabIndex = 13
        '
        'lblAverage
        '
        Me.lblAverage.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.lblAverage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAverage.Location = New System.Drawing.Point(464, 217)
        Me.lblAverage.Name = "lblAverage"
        Me.lblAverage.Size = New System.Drawing.Size(65, 29)
        Me.lblAverage.TabIndex = 14
        Me.lblAverage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(616, 259)
        Me.Controls.Add(Me.lblAverage)
        Me.Controls.Add(Me.lstboxNames)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtFinal)
        Me.Controls.Add(Me.txtQuiz3)
        Me.Controls.Add(Me.txtQuiz2)
        Me.Controls.Add(Me.txtQuiz1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtName)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtQuiz1 As System.Windows.Forms.TextBox
    Friend WithEvents txtQuiz2 As System.Windows.Forms.TextBox
    Friend WithEvents txtQuiz3 As System.Windows.Forms.TextBox
    Friend WithEvents txtFinal As System.Windows.Forms.TextBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lstboxNames As System.Windows.Forms.ListBox
    Friend WithEvents lblAverage As System.Windows.Forms.Label

End Class
