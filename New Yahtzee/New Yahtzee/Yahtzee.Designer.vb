<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Yahtzee
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
        Me.pbDie1 = New System.Windows.Forms.PictureBox()
        Me.pbDie2 = New System.Windows.Forms.PictureBox()
        Me.pbDie3 = New System.Windows.Forms.PictureBox()
        Me.pbDie4 = New System.Windows.Forms.PictureBox()
        Me.pbDie6 = New System.Windows.Forms.PictureBox()
        Me.cbOne = New System.Windows.Forms.CheckBox()
        Me.cbTwo = New System.Windows.Forms.CheckBox()
        Me.cbThree = New System.Windows.Forms.CheckBox()
        Me.cbFour = New System.Windows.Forms.CheckBox()
        Me.cbFive = New System.Windows.Forms.CheckBox()
        Me.cbSix = New System.Windows.Forms.CheckBox()
        Me.cbThreeOfKind = New System.Windows.Forms.CheckBox()
        Me.cbFourOfKind = New System.Windows.Forms.CheckBox()
        Me.cbFullHouse = New System.Windows.Forms.CheckBox()
        Me.cbSmStraight = New System.Windows.Forms.CheckBox()
        Me.cbLgStraight = New System.Windows.Forms.CheckBox()
        Me.cbYahtzee = New System.Windows.Forms.CheckBox()
        Me.cbChance = New System.Windows.Forms.CheckBox()
        CType(Me.pbDie1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbDie2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbDie3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbDie4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbDie6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbDie1
        '
        Me.pbDie1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.pbDie1.Location = New System.Drawing.Point(69, 157)
        Me.pbDie1.Name = "pbDie1"
        Me.pbDie1.Size = New System.Drawing.Size(50, 50)
        Me.pbDie1.TabIndex = 0
        Me.pbDie1.TabStop = False
        '
        'pbDie2
        '
        Me.pbDie2.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.pbDie2.Location = New System.Drawing.Point(125, 157)
        Me.pbDie2.Name = "pbDie2"
        Me.pbDie2.Size = New System.Drawing.Size(50, 50)
        Me.pbDie2.TabIndex = 1
        Me.pbDie2.TabStop = False
        '
        'pbDie3
        '
        Me.pbDie3.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.pbDie3.Location = New System.Drawing.Point(181, 157)
        Me.pbDie3.Name = "pbDie3"
        Me.pbDie3.Size = New System.Drawing.Size(50, 50)
        Me.pbDie3.TabIndex = 2
        Me.pbDie3.TabStop = False
        '
        'pbDie4
        '
        Me.pbDie4.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.pbDie4.Location = New System.Drawing.Point(237, 157)
        Me.pbDie4.Name = "pbDie4"
        Me.pbDie4.Size = New System.Drawing.Size(50, 50)
        Me.pbDie4.TabIndex = 3
        Me.pbDie4.TabStop = False
        '
        'pbDie6
        '
        Me.pbDie6.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.pbDie6.Location = New System.Drawing.Point(293, 157)
        Me.pbDie6.Name = "pbDie6"
        Me.pbDie6.Size = New System.Drawing.Size(50, 50)
        Me.pbDie6.TabIndex = 4
        Me.pbDie6.TabStop = False
        '
        'cbOne
        '
        Me.cbOne.AutoSize = True
        Me.cbOne.Location = New System.Drawing.Point(517, 38)
        Me.cbOne.Name = "cbOne"
        Me.cbOne.Size = New System.Drawing.Size(15, 14)
        Me.cbOne.TabIndex = 5
        Me.cbOne.UseVisualStyleBackColor = True
        '
        'cbTwo
        '
        Me.cbTwo.AutoSize = True
        Me.cbTwo.Location = New System.Drawing.Point(517, 58)
        Me.cbTwo.Name = "cbTwo"
        Me.cbTwo.Size = New System.Drawing.Size(15, 14)
        Me.cbTwo.TabIndex = 6
        Me.cbTwo.UseVisualStyleBackColor = True
        '
        'cbThree
        '
        Me.cbThree.AutoSize = True
        Me.cbThree.Location = New System.Drawing.Point(517, 78)
        Me.cbThree.Name = "cbThree"
        Me.cbThree.Size = New System.Drawing.Size(15, 14)
        Me.cbThree.TabIndex = 7
        Me.cbThree.UseVisualStyleBackColor = True
        '
        'cbFour
        '
        Me.cbFour.AutoSize = True
        Me.cbFour.Location = New System.Drawing.Point(517, 98)
        Me.cbFour.Name = "cbFour"
        Me.cbFour.Size = New System.Drawing.Size(15, 14)
        Me.cbFour.TabIndex = 8
        Me.cbFour.UseVisualStyleBackColor = True
        '
        'cbFive
        '
        Me.cbFive.AutoSize = True
        Me.cbFive.Location = New System.Drawing.Point(517, 118)
        Me.cbFive.Name = "cbFive"
        Me.cbFive.Size = New System.Drawing.Size(15, 14)
        Me.cbFive.TabIndex = 9
        Me.cbFive.UseVisualStyleBackColor = True
        '
        'cbSix
        '
        Me.cbSix.AutoSize = True
        Me.cbSix.Location = New System.Drawing.Point(517, 138)
        Me.cbSix.Name = "cbSix"
        Me.cbSix.Size = New System.Drawing.Size(15, 14)
        Me.cbSix.TabIndex = 10
        Me.cbSix.UseVisualStyleBackColor = True
        '
        'cbThreeOfKind
        '
        Me.cbThreeOfKind.AutoSize = True
        Me.cbThreeOfKind.Location = New System.Drawing.Point(517, 157)
        Me.cbThreeOfKind.Name = "cbThreeOfKind"
        Me.cbThreeOfKind.Size = New System.Drawing.Size(15, 14)
        Me.cbThreeOfKind.TabIndex = 11
        Me.cbThreeOfKind.UseVisualStyleBackColor = True
        '
        'cbFourOfKind
        '
        Me.cbFourOfKind.AutoSize = True
        Me.cbFourOfKind.Location = New System.Drawing.Point(517, 177)
        Me.cbFourOfKind.Name = "cbFourOfKind"
        Me.cbFourOfKind.Size = New System.Drawing.Size(15, 14)
        Me.cbFourOfKind.TabIndex = 12
        Me.cbFourOfKind.UseVisualStyleBackColor = True
        '
        'cbFullHouse
        '
        Me.cbFullHouse.AutoSize = True
        Me.cbFullHouse.Location = New System.Drawing.Point(517, 197)
        Me.cbFullHouse.Name = "cbFullHouse"
        Me.cbFullHouse.Size = New System.Drawing.Size(15, 14)
        Me.cbFullHouse.TabIndex = 13
        Me.cbFullHouse.UseVisualStyleBackColor = True
        '
        'cbSmStraight
        '
        Me.cbSmStraight.AutoSize = True
        Me.cbSmStraight.Location = New System.Drawing.Point(517, 217)
        Me.cbSmStraight.Name = "cbSmStraight"
        Me.cbSmStraight.Size = New System.Drawing.Size(15, 14)
        Me.cbSmStraight.TabIndex = 14
        Me.cbSmStraight.UseVisualStyleBackColor = True
        '
        'cbLgStraight
        '
        Me.cbLgStraight.AutoSize = True
        Me.cbLgStraight.Location = New System.Drawing.Point(517, 237)
        Me.cbLgStraight.Name = "cbLgStraight"
        Me.cbLgStraight.Size = New System.Drawing.Size(15, 14)
        Me.cbLgStraight.TabIndex = 15
        Me.cbLgStraight.UseVisualStyleBackColor = True
        '
        'cbYahtzee
        '
        Me.cbYahtzee.AutoSize = True
        Me.cbYahtzee.Location = New System.Drawing.Point(517, 257)
        Me.cbYahtzee.Name = "cbYahtzee"
        Me.cbYahtzee.Size = New System.Drawing.Size(15, 14)
        Me.cbYahtzee.TabIndex = 16
        Me.cbYahtzee.UseVisualStyleBackColor = True
        '
        'cbChance
        '
        Me.cbChance.AutoSize = True
        Me.cbChance.Location = New System.Drawing.Point(517, 277)
        Me.cbChance.Name = "cbChance"
        Me.cbChance.Size = New System.Drawing.Size(15, 14)
        Me.cbChance.TabIndex = 17
        Me.cbChance.UseVisualStyleBackColor = True
        '
        'Yahtzee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.cbChance)
        Me.Controls.Add(Me.cbYahtzee)
        Me.Controls.Add(Me.cbLgStraight)
        Me.Controls.Add(Me.cbSmStraight)
        Me.Controls.Add(Me.cbFullHouse)
        Me.Controls.Add(Me.cbFourOfKind)
        Me.Controls.Add(Me.cbThreeOfKind)
        Me.Controls.Add(Me.cbSix)
        Me.Controls.Add(Me.cbFive)
        Me.Controls.Add(Me.cbFour)
        Me.Controls.Add(Me.cbThree)
        Me.Controls.Add(Me.cbTwo)
        Me.Controls.Add(Me.cbOne)
        Me.Controls.Add(Me.pbDie6)
        Me.Controls.Add(Me.pbDie4)
        Me.Controls.Add(Me.pbDie3)
        Me.Controls.Add(Me.pbDie2)
        Me.Controls.Add(Me.pbDie1)
        Me.Name = "Yahtzee"
        Me.Text = "Yahtzee"
        CType(Me.pbDie1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbDie2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbDie3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbDie4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbDie6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pbDie1 As System.Windows.Forms.PictureBox
    Friend WithEvents pbDie2 As System.Windows.Forms.PictureBox
    Friend WithEvents pbDie3 As System.Windows.Forms.PictureBox
    Friend WithEvents pbDie4 As System.Windows.Forms.PictureBox
    Friend WithEvents pbDie6 As System.Windows.Forms.PictureBox
    Friend WithEvents cbOne As System.Windows.Forms.CheckBox
    Friend WithEvents cbTwo As System.Windows.Forms.CheckBox
    Friend WithEvents cbThree As System.Windows.Forms.CheckBox
    Friend WithEvents cbFour As System.Windows.Forms.CheckBox
    Friend WithEvents cbFive As System.Windows.Forms.CheckBox
    Friend WithEvents cbSix As System.Windows.Forms.CheckBox
    Friend WithEvents cbThreeOfKind As System.Windows.Forms.CheckBox
    Friend WithEvents cbFourOfKind As System.Windows.Forms.CheckBox
    Friend WithEvents cbFullHouse As System.Windows.Forms.CheckBox
    Friend WithEvents cbSmStraight As System.Windows.Forms.CheckBox
    Friend WithEvents cbLgStraight As System.Windows.Forms.CheckBox
    Friend WithEvents cbYahtzee As System.Windows.Forms.CheckBox
    Friend WithEvents cbChance As System.Windows.Forms.CheckBox

End Class
