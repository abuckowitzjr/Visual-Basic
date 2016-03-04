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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtMake = New System.Windows.Forms.TextBox()
        Me.txtModel = New System.Windows.Forms.TextBox()
        Me.txtYear = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtHP = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboBrakes = New System.Windows.Forms.ComboBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnDrive = New System.Windows.Forms.Button()
        Me.btnGo = New System.Windows.Forms.Button()
        Me.btnReverse = New System.Windows.Forms.Button()
        Me.btnPark = New System.Windows.Forms.Button()
        Me.btnBrake = New System.Windows.Forms.Button()
        Me.btnAccel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(37, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Make:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(209, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Model:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(371, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Year:"
        '
        'txtMake
        '
        Me.txtMake.Location = New System.Drawing.Point(89, 21)
        Me.txtMake.Name = "txtMake"
        Me.txtMake.Size = New System.Drawing.Size(100, 22)
        Me.txtMake.TabIndex = 3
        '
        'txtModel
        '
        Me.txtModel.Location = New System.Drawing.Point(265, 21)
        Me.txtModel.Name = "txtModel"
        Me.txtModel.Size = New System.Drawing.Size(100, 22)
        Me.txtModel.TabIndex = 4
        '
        'txtYear
        '
        Me.txtYear.Location = New System.Drawing.Point(419, 21)
        Me.txtYear.Name = "txtYear"
        Me.txtYear.Size = New System.Drawing.Size(100, 22)
        Me.txtYear.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(525, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(27, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "HP"
        '
        'txtHP
        '
        Me.txtHP.Location = New System.Drawing.Point(558, 21)
        Me.txtHP.Name = "txtHP"
        Me.txtHP.Size = New System.Drawing.Size(100, 22)
        Me.txtHP.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(664, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 17)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Brakes:"
        '
        'cboBrakes
        '
        Me.cboBrakes.FormattingEnabled = True
        Me.cboBrakes.Location = New System.Drawing.Point(726, 21)
        Me.cboBrakes.Name = "cboBrakes"
        Me.cboBrakes.Size = New System.Drawing.Size(121, 24)
        Me.cboBrakes.TabIndex = 9
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(864, 21)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 10
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(864, 50)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(75, 23)
        Me.btnStart.TabIndex = 11
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnDrive
        '
        Me.btnDrive.Location = New System.Drawing.Point(864, 79)
        Me.btnDrive.Name = "btnDrive"
        Me.btnDrive.Size = New System.Drawing.Size(75, 23)
        Me.btnDrive.TabIndex = 12
        Me.btnDrive.Text = "Drive"
        Me.btnDrive.UseVisualStyleBackColor = True
        '
        'btnGo
        '
        Me.btnGo.Location = New System.Drawing.Point(864, 108)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(75, 23)
        Me.btnGo.TabIndex = 13
        Me.btnGo.Text = "Go"
        Me.btnGo.UseVisualStyleBackColor = True
        '
        'btnReverse
        '
        Me.btnReverse.Location = New System.Drawing.Point(864, 137)
        Me.btnReverse.Name = "btnReverse"
        Me.btnReverse.Size = New System.Drawing.Size(75, 23)
        Me.btnReverse.TabIndex = 14
        Me.btnReverse.Text = "Rev"
        Me.btnReverse.UseVisualStyleBackColor = True
        '
        'btnPark
        '
        Me.btnPark.Location = New System.Drawing.Point(864, 166)
        Me.btnPark.Name = "btnPark"
        Me.btnPark.Size = New System.Drawing.Size(75, 23)
        Me.btnPark.TabIndex = 15
        Me.btnPark.Text = "Park"
        Me.btnPark.UseVisualStyleBackColor = True
        '
        'btnBrake
        '
        Me.btnBrake.Location = New System.Drawing.Point(864, 195)
        Me.btnBrake.Name = "btnBrake"
        Me.btnBrake.Size = New System.Drawing.Size(75, 23)
        Me.btnBrake.TabIndex = 16
        Me.btnBrake.Text = "Brake"
        Me.btnBrake.UseVisualStyleBackColor = True
        '
        'btnAccel
        '
        Me.btnAccel.Location = New System.Drawing.Point(864, 224)
        Me.btnAccel.Name = "btnAccel"
        Me.btnAccel.Size = New System.Drawing.Size(75, 23)
        Me.btnAccel.TabIndex = 17
        Me.btnAccel.Text = "Accel"
        Me.btnAccel.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(976, 681)
        Me.Controls.Add(Me.btnAccel)
        Me.Controls.Add(Me.btnBrake)
        Me.Controls.Add(Me.btnPark)
        Me.Controls.Add(Me.btnReverse)
        Me.Controls.Add(Me.btnGo)
        Me.Controls.Add(Me.btnDrive)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.cboBrakes)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtHP)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtYear)
        Me.Controls.Add(Me.txtModel)
        Me.Controls.Add(Me.txtMake)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtMake As System.Windows.Forms.TextBox
    Friend WithEvents txtModel As System.Windows.Forms.TextBox
    Friend WithEvents txtYear As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtHP As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cboBrakes As System.Windows.Forms.ComboBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents btnDrive As System.Windows.Forms.Button
    Friend WithEvents btnGo As System.Windows.Forms.Button
    Friend WithEvents btnReverse As System.Windows.Forms.Button
    Friend WithEvents btnPark As System.Windows.Forms.Button
    Friend WithEvents btnBrake As System.Windows.Forms.Button
    Friend WithEvents btnAccel As System.Windows.Forms.Button

End Class
