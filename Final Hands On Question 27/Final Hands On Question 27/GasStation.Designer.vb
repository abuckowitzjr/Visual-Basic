<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGasStation
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnPump = New System.Windows.Forms.Button()
        Me.txtNumberOfGallons = New System.Windows.Forms.TextBox()
        Me.lblNumberOfGallons = New System.Windows.Forms.Label()
        Me.gbTypeOfGas = New System.Windows.Forms.GroupBox()
        Me.rbPremium = New System.Windows.Forms.RadioButton()
        Me.lblPremPerGal = New System.Windows.Forms.Label()
        Me.rbPlus = New System.Windows.Forms.RadioButton()
        Me.lblPlusPerGal = New System.Windows.Forms.Label()
        Me.rbRegular = New System.Windows.Forms.RadioButton()
        Me.lblRegPerGal = New System.Windows.Forms.Label()
        Me.lblPremium = New System.Windows.Forms.Label()
        Me.lblPlus = New System.Windows.Forms.Label()
        Me.lblRegular = New System.Windows.Forms.Label()
        Me.gbSummary = New System.Windows.Forms.GroupBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblTotalCost = New System.Windows.Forms.Label()
        Me.lblTotalGallons = New System.Windows.Forms.Label()
        Me.lblTotalSales = New System.Windows.Forms.Label()
        Me.lblType = New System.Windows.Forms.Label()
        Me.lstboxGasTypes = New System.Windows.Forms.ListBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.gbTypeOfGas.SuspendLayout()
        Me.gbSummary.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox1.Controls.Add(Me.btnPump)
        Me.GroupBox1.Controls.Add(Me.txtNumberOfGallons)
        Me.GroupBox1.Controls.Add(Me.lblNumberOfGallons)
        Me.GroupBox1.Controls.Add(Me.gbTypeOfGas)
        Me.GroupBox1.Location = New System.Drawing.Point(39, 25)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(530, 461)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'btnPump
        '
        Me.btnPump.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnPump.Enabled = False
        Me.btnPump.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPump.Location = New System.Drawing.Point(198, 353)
        Me.btnPump.Name = "btnPump"
        Me.btnPump.Size = New System.Drawing.Size(135, 76)
        Me.btnPump.TabIndex = 4
        Me.btnPump.Text = "Pump"
        Me.btnPump.UseVisualStyleBackColor = False
        '
        'txtNumberOfGallons
        '
        Me.txtNumberOfGallons.Location = New System.Drawing.Point(327, 272)
        Me.txtNumberOfGallons.Name = "txtNumberOfGallons"
        Me.txtNumberOfGallons.Size = New System.Drawing.Size(64, 22)
        Me.txtNumberOfGallons.TabIndex = 3
        '
        'lblNumberOfGallons
        '
        Me.lblNumberOfGallons.AutoSize = True
        Me.lblNumberOfGallons.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumberOfGallons.Location = New System.Drawing.Point(139, 275)
        Me.lblNumberOfGallons.Name = "lblNumberOfGallons"
        Me.lblNumberOfGallons.Size = New System.Drawing.Size(166, 20)
        Me.lblNumberOfGallons.TabIndex = 1
        Me.lblNumberOfGallons.Text = "Number of Gallons"
        '
        'gbTypeOfGas
        '
        Me.gbTypeOfGas.Controls.Add(Me.rbPremium)
        Me.gbTypeOfGas.Controls.Add(Me.lblPremPerGal)
        Me.gbTypeOfGas.Controls.Add(Me.rbPlus)
        Me.gbTypeOfGas.Controls.Add(Me.lblPlusPerGal)
        Me.gbTypeOfGas.Controls.Add(Me.rbRegular)
        Me.gbTypeOfGas.Controls.Add(Me.lblRegPerGal)
        Me.gbTypeOfGas.Controls.Add(Me.lblPremium)
        Me.gbTypeOfGas.Controls.Add(Me.lblPlus)
        Me.gbTypeOfGas.Controls.Add(Me.lblRegular)
        Me.gbTypeOfGas.Location = New System.Drawing.Point(31, 21)
        Me.gbTypeOfGas.Name = "gbTypeOfGas"
        Me.gbTypeOfGas.Size = New System.Drawing.Size(463, 167)
        Me.gbTypeOfGas.TabIndex = 0
        Me.gbTypeOfGas.TabStop = False
        '
        'rbPremium
        '
        Me.rbPremium.AutoSize = True
        Me.rbPremium.Location = New System.Drawing.Point(365, 134)
        Me.rbPremium.Name = "rbPremium"
        Me.rbPremium.Size = New System.Drawing.Size(17, 16)
        Me.rbPremium.TabIndex = 2
        Me.rbPremium.TabStop = True
        Me.rbPremium.UseVisualStyleBackColor = True
        '
        'lblPremPerGal
        '
        Me.lblPremPerGal.BackColor = System.Drawing.Color.Green
        Me.lblPremPerGal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPremPerGal.Location = New System.Drawing.Point(306, 100)
        Me.lblPremPerGal.Name = "lblPremPerGal"
        Me.lblPremPerGal.Size = New System.Drawing.Size(133, 26)
        Me.lblPremPerGal.TabIndex = 6
        Me.lblPremPerGal.Text = "$2.83 / gal"
        Me.lblPremPerGal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'rbPlus
        '
        Me.rbPlus.AutoSize = True
        Me.rbPlus.Location = New System.Drawing.Point(226, 134)
        Me.rbPlus.Name = "rbPlus"
        Me.rbPlus.Size = New System.Drawing.Size(17, 16)
        Me.rbPlus.TabIndex = 1
        Me.rbPlus.TabStop = True
        Me.rbPlus.UseVisualStyleBackColor = True
        '
        'lblPlusPerGal
        '
        Me.lblPlusPerGal.BackColor = System.Drawing.Color.Yellow
        Me.lblPlusPerGal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlusPerGal.Location = New System.Drawing.Point(167, 100)
        Me.lblPlusPerGal.Name = "lblPlusPerGal"
        Me.lblPlusPerGal.Size = New System.Drawing.Size(133, 26)
        Me.lblPlusPerGal.TabIndex = 5
        Me.lblPlusPerGal.Text = "$2.69 / gal"
        Me.lblPlusPerGal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'rbRegular
        '
        Me.rbRegular.AutoSize = True
        Me.rbRegular.Location = New System.Drawing.Point(87, 134)
        Me.rbRegular.Name = "rbRegular"
        Me.rbRegular.Size = New System.Drawing.Size(17, 16)
        Me.rbRegular.TabIndex = 0
        Me.rbRegular.TabStop = True
        Me.rbRegular.UseVisualStyleBackColor = True
        '
        'lblRegPerGal
        '
        Me.lblRegPerGal.BackColor = System.Drawing.Color.Red
        Me.lblRegPerGal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegPerGal.Location = New System.Drawing.Point(28, 100)
        Me.lblRegPerGal.Name = "lblRegPerGal"
        Me.lblRegPerGal.Size = New System.Drawing.Size(133, 26)
        Me.lblRegPerGal.TabIndex = 4
        Me.lblRegPerGal.Text = "$2.57 / gal"
        Me.lblRegPerGal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPremium
        '
        Me.lblPremium.BackColor = System.Drawing.Color.Green
        Me.lblPremium.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPremium.Location = New System.Drawing.Point(306, 27)
        Me.lblPremium.Name = "lblPremium"
        Me.lblPremium.Size = New System.Drawing.Size(133, 66)
        Me.lblPremium.TabIndex = 3
        Me.lblPremium.Text = "Premium"
        Me.lblPremium.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPlus
        '
        Me.lblPlus.BackColor = System.Drawing.Color.Yellow
        Me.lblPlus.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlus.Location = New System.Drawing.Point(167, 27)
        Me.lblPlus.Name = "lblPlus"
        Me.lblPlus.Size = New System.Drawing.Size(133, 66)
        Me.lblPlus.TabIndex = 2
        Me.lblPlus.Text = "Plus"
        Me.lblPlus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRegular
        '
        Me.lblRegular.BackColor = System.Drawing.Color.Red
        Me.lblRegular.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegular.Location = New System.Drawing.Point(28, 27)
        Me.lblRegular.Name = "lblRegular"
        Me.lblRegular.Size = New System.Drawing.Size(133, 66)
        Me.lblRegular.TabIndex = 1
        Me.lblRegular.Text = "Regular"
        Me.lblRegular.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gbSummary
        '
        Me.gbSummary.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.gbSummary.Controls.Add(Me.btnClear)
        Me.gbSummary.Controls.Add(Me.lblTotalCost)
        Me.gbSummary.Controls.Add(Me.lblTotalGallons)
        Me.gbSummary.Controls.Add(Me.lblTotalSales)
        Me.gbSummary.Controls.Add(Me.lblType)
        Me.gbSummary.Controls.Add(Me.lstboxGasTypes)
        Me.gbSummary.Location = New System.Drawing.Point(592, 25)
        Me.gbSummary.Name = "gbSummary"
        Me.gbSummary.Size = New System.Drawing.Size(206, 461)
        Me.gbSummary.TabIndex = 1
        Me.gbSummary.TabStop = False
        Me.gbSummary.Text = "Summary"
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(41, 369)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(118, 37)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'lblTotalCost
        '
        Me.lblTotalCost.BackColor = System.Drawing.Color.White
        Me.lblTotalCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCost.Location = New System.Drawing.Point(23, 282)
        Me.lblTotalCost.Name = "lblTotalCost"
        Me.lblTotalCost.Size = New System.Drawing.Size(153, 30)
        Me.lblTotalCost.TabIndex = 4
        '
        'lblTotalGallons
        '
        Me.lblTotalGallons.BackColor = System.Drawing.Color.White
        Me.lblTotalGallons.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalGallons.Location = New System.Drawing.Point(23, 248)
        Me.lblTotalGallons.Name = "lblTotalGallons"
        Me.lblTotalGallons.Size = New System.Drawing.Size(153, 30)
        Me.lblTotalGallons.TabIndex = 3
        '
        'lblTotalSales
        '
        Me.lblTotalSales.BackColor = System.Drawing.Color.White
        Me.lblTotalSales.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalSales.Location = New System.Drawing.Point(23, 214)
        Me.lblTotalSales.Name = "lblTotalSales"
        Me.lblTotalSales.Size = New System.Drawing.Size(153, 30)
        Me.lblTotalSales.TabIndex = 2
        '
        'lblType
        '
        Me.lblType.BackColor = System.Drawing.Color.White
        Me.lblType.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblType.Location = New System.Drawing.Point(23, 180)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(153, 30)
        Me.lblType.TabIndex = 1
        '
        'lstboxGasTypes
        '
        Me.lstboxGasTypes.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstboxGasTypes.FormattingEnabled = True
        Me.lstboxGasTypes.ItemHeight = 20
        Me.lstboxGasTypes.Items.AddRange(New Object() {"Regular", "Plus", "Premium"})
        Me.lstboxGasTypes.Location = New System.Drawing.Point(35, 41)
        Me.lstboxGasTypes.Name = "lstboxGasTypes"
        Me.lstboxGasTypes.Size = New System.Drawing.Size(128, 84)
        Me.lstboxGasTypes.TabIndex = 0
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1
        '
        'frmGasStation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(836, 518)
        Me.Controls.Add(Me.gbSummary)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmGasStation"
        Me.Text = "Gas Station"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gbTypeOfGas.ResumeLayout(False)
        Me.gbTypeOfGas.PerformLayout()
        Me.gbSummary.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnPump As System.Windows.Forms.Button
    Friend WithEvents txtNumberOfGallons As System.Windows.Forms.TextBox
    Friend WithEvents lblNumberOfGallons As System.Windows.Forms.Label
    Friend WithEvents gbTypeOfGas As System.Windows.Forms.GroupBox
    Friend WithEvents rbPremium As System.Windows.Forms.RadioButton
    Friend WithEvents lblPremPerGal As System.Windows.Forms.Label
    Friend WithEvents rbPlus As System.Windows.Forms.RadioButton
    Friend WithEvents lblPlusPerGal As System.Windows.Forms.Label
    Friend WithEvents rbRegular As System.Windows.Forms.RadioButton
    Friend WithEvents lblRegPerGal As System.Windows.Forms.Label
    Friend WithEvents lblPremium As System.Windows.Forms.Label
    Friend WithEvents lblPlus As System.Windows.Forms.Label
    Friend WithEvents lblRegular As System.Windows.Forms.Label
    Friend WithEvents gbSummary As System.Windows.Forms.GroupBox
    Friend WithEvents lstboxGasTypes As System.Windows.Forms.ListBox
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents lblTotalCost As System.Windows.Forms.Label
    Friend WithEvents lblTotalGallons As System.Windows.Forms.Label
    Friend WithEvents lblTotalSales As System.Windows.Forms.Label
    Friend WithEvents lblType As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer

End Class
