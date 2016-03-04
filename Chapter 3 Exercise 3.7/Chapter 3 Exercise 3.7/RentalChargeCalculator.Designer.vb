<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RentalChargeCalculatorForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RentalChargeCalculatorForm))
        Me.CustomerNameTextBox = New System.Windows.Forms.TextBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.CityTextBox = New System.Windows.Forms.TextBox()
        Me.StateTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TotalMilesTextBox = New System.Windows.Forms.TextBox()
        Me.TotalCostTextBox = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.CalculateButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.PrintButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.ZIPMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.BeginningOdoMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.EndingOdoMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.TotalDaysMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.SuspendLayout()
        '
        'CustomerNameTextBox
        '
        Me.CustomerNameTextBox.Location = New System.Drawing.Point(116, 16)
        Me.CustomerNameTextBox.Name = "CustomerNameTextBox"
        Me.CustomerNameTextBox.Size = New System.Drawing.Size(210, 20)
        Me.CustomerNameTextBox.TabIndex = 0
        '
        'AddressTextBox
        '
        Me.AddressTextBox.Location = New System.Drawing.Point(116, 42)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(292, 20)
        Me.AddressTextBox.TabIndex = 1
        '
        'CityTextBox
        '
        Me.CityTextBox.Location = New System.Drawing.Point(116, 68)
        Me.CityTextBox.Name = "CityTextBox"
        Me.CityTextBox.Size = New System.Drawing.Size(145, 20)
        Me.CityTextBox.TabIndex = 2
        '
        'StateTextBox
        '
        Me.StateTextBox.Location = New System.Drawing.Point(308, 68)
        Me.StateTextBox.Name = "StateTextBox"
        Me.StateTextBox.Size = New System.Drawing.Size(29, 20)
        Me.StateTextBox.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Customer Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(62, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Address:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(83, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "City:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(267, 71)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "State:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(343, 71)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Zip Code:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(132, 121)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(149, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Beginning Odometer Reading:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(146, 147)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(135, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Ending Odometer Reading:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(192, 173)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(89, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Total Days Used:"
        '
        'TotalMilesTextBox
        '
        Me.TotalMilesTextBox.BackColor = System.Drawing.Color.White
        Me.TotalMilesTextBox.Location = New System.Drawing.Point(338, 224)
        Me.TotalMilesTextBox.Name = "TotalMilesTextBox"
        Me.TotalMilesTextBox.ReadOnly = True
        Me.TotalMilesTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TotalMilesTextBox.TabIndex = 16
        '
        'TotalCostTextBox
        '
        Me.TotalCostTextBox.BackColor = System.Drawing.Color.White
        Me.TotalCostTextBox.Location = New System.Drawing.Point(338, 250)
        Me.TotalCostTextBox.Name = "TotalCostTextBox"
        Me.TotalCostTextBox.ReadOnly = True
        Me.TotalCostTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TotalCostTextBox.TabIndex = 17
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(237, 228)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(95, 13)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Total Miles Driven:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(274, 253)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(58, 13)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Total Cost:"
        '
        'CalculateButton
        '
        Me.CalculateButton.Location = New System.Drawing.Point(23, 215)
        Me.CalculateButton.Name = "CalculateButton"
        Me.CalculateButton.Size = New System.Drawing.Size(96, 30)
        Me.CalculateButton.TabIndex = 8
        Me.CalculateButton.Text = "Calculate"
        Me.CalculateButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(125, 215)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(96, 30)
        Me.ClearButton.TabIndex = 9
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'PrintButton
        '
        Me.PrintButton.Location = New System.Drawing.Point(23, 251)
        Me.PrintButton.Name = "PrintButton"
        Me.PrintButton.Size = New System.Drawing.Size(96, 30)
        Me.PrintButton.TabIndex = 10
        Me.PrintButton.Text = "Print"
        Me.PrintButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(125, 251)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(96, 30)
        Me.ExitButton.TabIndex = 11
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'ZIPMaskedTextBox
        '
        Me.ZIPMaskedTextBox.Location = New System.Drawing.Point(402, 68)
        Me.ZIPMaskedTextBox.Mask = "00000"
        Me.ZIPMaskedTextBox.Name = "ZIPMaskedTextBox"
        Me.ZIPMaskedTextBox.Size = New System.Drawing.Size(36, 20)
        Me.ZIPMaskedTextBox.TabIndex = 4
        Me.ZIPMaskedTextBox.ValidatingType = GetType(Integer)
        '
        'BeginningOdoMaskedTextBox
        '
        Me.BeginningOdoMaskedTextBox.Location = New System.Drawing.Point(287, 118)
        Me.BeginningOdoMaskedTextBox.Mask = "000000"
        Me.BeginningOdoMaskedTextBox.Name = "BeginningOdoMaskedTextBox"
        Me.BeginningOdoMaskedTextBox.Size = New System.Drawing.Size(43, 20)
        Me.BeginningOdoMaskedTextBox.TabIndex = 5
        '
        'EndingOdoMaskedTextBox
        '
        Me.EndingOdoMaskedTextBox.Location = New System.Drawing.Point(287, 144)
        Me.EndingOdoMaskedTextBox.Mask = "000000"
        Me.EndingOdoMaskedTextBox.Name = "EndingOdoMaskedTextBox"
        Me.EndingOdoMaskedTextBox.Size = New System.Drawing.Size(43, 20)
        Me.EndingOdoMaskedTextBox.TabIndex = 6
        '
        'TotalDaysMaskedTextBox
        '
        Me.TotalDaysMaskedTextBox.Location = New System.Drawing.Point(287, 170)
        Me.TotalDaysMaskedTextBox.Mask = "000"
        Me.TotalDaysMaskedTextBox.Name = "TotalDaysMaskedTextBox"
        Me.TotalDaysMaskedTextBox.Size = New System.Drawing.Size(26, 20)
        Me.TotalDaysMaskedTextBox.TabIndex = 7
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'RentalChargeCalculatorForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(462, 297)
        Me.Controls.Add(Me.TotalDaysMaskedTextBox)
        Me.Controls.Add(Me.EndingOdoMaskedTextBox)
        Me.Controls.Add(Me.BeginningOdoMaskedTextBox)
        Me.Controls.Add(Me.ZIPMaskedTextBox)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.PrintButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.CalculateButton)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TotalCostTextBox)
        Me.Controls.Add(Me.TotalMilesTextBox)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.StateTextBox)
        Me.Controls.Add(Me.CityTextBox)
        Me.Controls.Add(Me.AddressTextBox)
        Me.Controls.Add(Me.CustomerNameTextBox)
        Me.Name = "RentalChargeCalculatorForm"
        Me.Text = "Rental Charge Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CustomerNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TotalMilesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TotalCostTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents CalculateButton As System.Windows.Forms.Button
    Friend WithEvents ClearButton As System.Windows.Forms.Button
    Friend WithEvents PrintButton As System.Windows.Forms.Button
    Friend WithEvents ExitButton As System.Windows.Forms.Button
    Friend WithEvents ZIPMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents BeginningOdoMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents EndingOdoMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents TotalDaysMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm

End Class
