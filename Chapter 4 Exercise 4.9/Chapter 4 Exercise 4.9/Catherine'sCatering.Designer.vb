<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCatherinesCatering
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
        Me.txtboxNumberOfGuests = New System.Windows.Forms.TextBox()
        Me.rbPrimeRib = New System.Windows.Forms.RadioButton()
        Me.rbChicken = New System.Windows.Forms.RadioButton()
        Me.rbPasta = New System.Windows.Forms.RadioButton()
        Me.cbOpenBar = New System.Windows.Forms.CheckBox()
        Me.cbWine = New System.Windows.Forms.CheckBox()
        Me.gboxMenuSelection = New System.Windows.Forms.GroupBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnSummary = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtboxAmountDue = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.gboxMenuSelection.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtboxNumberOfGuests
        '
        Me.txtboxNumberOfGuests.Location = New System.Drawing.Point(225, 29)
        Me.txtboxNumberOfGuests.Name = "txtboxNumberOfGuests"
        Me.txtboxNumberOfGuests.Size = New System.Drawing.Size(63, 22)
        Me.txtboxNumberOfGuests.TabIndex = 0
        '
        'rbPrimeRib
        '
        Me.rbPrimeRib.AutoSize = True
        Me.rbPrimeRib.Location = New System.Drawing.Point(15, 38)
        Me.rbPrimeRib.Name = "rbPrimeRib"
        Me.rbPrimeRib.Size = New System.Drawing.Size(90, 21)
        Me.rbPrimeRib.TabIndex = 1
        Me.rbPrimeRib.TabStop = True
        Me.rbPrimeRib.Text = "Prime Rib"
        Me.rbPrimeRib.UseVisualStyleBackColor = True
        '
        'rbChicken
        '
        Me.rbChicken.AutoSize = True
        Me.rbChicken.Location = New System.Drawing.Point(15, 65)
        Me.rbChicken.Name = "rbChicken"
        Me.rbChicken.Size = New System.Drawing.Size(79, 21)
        Me.rbChicken.TabIndex = 2
        Me.rbChicken.TabStop = True
        Me.rbChicken.Text = "Chicken"
        Me.rbChicken.UseVisualStyleBackColor = True
        '
        'rbPasta
        '
        Me.rbPasta.AutoSize = True
        Me.rbPasta.Location = New System.Drawing.Point(15, 92)
        Me.rbPasta.Name = "rbPasta"
        Me.rbPasta.Size = New System.Drawing.Size(65, 21)
        Me.rbPasta.TabIndex = 3
        Me.rbPasta.TabStop = True
        Me.rbPasta.Text = "Pasta"
        Me.rbPasta.UseVisualStyleBackColor = True
        '
        'cbOpenBar
        '
        Me.cbOpenBar.AutoSize = True
        Me.cbOpenBar.Location = New System.Drawing.Point(208, 136)
        Me.cbOpenBar.Name = "cbOpenBar"
        Me.cbOpenBar.Size = New System.Drawing.Size(91, 21)
        Me.cbOpenBar.TabIndex = 4
        Me.cbOpenBar.Text = "Open Bar"
        Me.cbOpenBar.UseVisualStyleBackColor = True
        '
        'cbWine
        '
        Me.cbWine.AutoSize = True
        Me.cbWine.Location = New System.Drawing.Point(208, 163)
        Me.cbWine.Name = "cbWine"
        Me.cbWine.Size = New System.Drawing.Size(140, 21)
        Me.cbWine.TabIndex = 5
        Me.cbWine.Text = "Wine With Dinner"
        Me.cbWine.UseVisualStyleBackColor = True
        '
        'gboxMenuSelection
        '
        Me.gboxMenuSelection.Controls.Add(Me.rbChicken)
        Me.gboxMenuSelection.Controls.Add(Me.rbPrimeRib)
        Me.gboxMenuSelection.Controls.Add(Me.rbPasta)
        Me.gboxMenuSelection.Location = New System.Drawing.Point(32, 74)
        Me.gboxMenuSelection.Name = "gboxMenuSelection"
        Me.gboxMenuSelection.Size = New System.Drawing.Size(153, 147)
        Me.gboxMenuSelection.TabIndex = 6
        Me.gboxMenuSelection.TabStop = False
        Me.gboxMenuSelection.Text = "Menu Selection"
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(84, 293)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(103, 41)
        Me.btnCalculate.TabIndex = 6
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(193, 293)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(103, 41)
        Me.btnClear.TabIndex = 8
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnSummary
        '
        Me.btnSummary.Location = New System.Drawing.Point(84, 340)
        Me.btnSummary.Name = "btnSummary"
        Me.btnSummary.Size = New System.Drawing.Size(103, 41)
        Me.btnSummary.TabIndex = 7
        Me.btnSummary.Text = "Summary"
        Me.btnSummary.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(193, 340)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(103, 41)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'txtboxAmountDue
        '
        Me.txtboxAmountDue.BackColor = System.Drawing.Color.White
        Me.txtboxAmountDue.Location = New System.Drawing.Point(188, 245)
        Me.txtboxAmountDue.Name = "txtboxAmountDue"
        Me.txtboxAmountDue.ReadOnly = True
        Me.txtboxAmountDue.Size = New System.Drawing.Size(100, 22)
        Me.txtboxAmountDue.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(92, 248)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 17)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Amount Due:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(92, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 17)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Number of Guests:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(205, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 17)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Bar Options"
        '
        'frmCatherinesCatering
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(380, 409)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtboxAmountDue)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnSummary)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.gboxMenuSelection)
        Me.Controls.Add(Me.cbWine)
        Me.Controls.Add(Me.cbOpenBar)
        Me.Controls.Add(Me.txtboxNumberOfGuests)
        Me.Name = "frmCatherinesCatering"
        Me.Text = "Catherine's Catering"
        Me.gboxMenuSelection.ResumeLayout(False)
        Me.gboxMenuSelection.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtboxNumberOfGuests As System.Windows.Forms.TextBox
    Friend WithEvents rbPrimeRib As System.Windows.Forms.RadioButton
    Friend WithEvents rbChicken As System.Windows.Forms.RadioButton
    Friend WithEvents rbPasta As System.Windows.Forms.RadioButton
    Friend WithEvents cbOpenBar As System.Windows.Forms.CheckBox
    Friend WithEvents cbWine As System.Windows.Forms.CheckBox
    Friend WithEvents gboxMenuSelection As System.Windows.Forms.GroupBox
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnSummary As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents txtboxAmountDue As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label

End Class
