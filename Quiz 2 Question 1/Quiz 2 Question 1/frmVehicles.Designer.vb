<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVehicles
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
        Me.rbCar = New System.Windows.Forms.RadioButton()
        Me.rbTruck = New System.Windows.Forms.RadioButton()
        Me.txtMake = New System.Windows.Forms.TextBox()
        Me.txtModel = New System.Windows.Forms.TextBox()
        Me.txtYear = New System.Windows.Forms.TextBox()
        Me.txtTrunk = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblTrunk = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.lstbxVehicles = New System.Windows.Forms.ListBox()
        Me.lblDisplay = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'rbCar
        '
        Me.rbCar.AutoSize = True
        Me.rbCar.Location = New System.Drawing.Point(109, 81)
        Me.rbCar.Name = "rbCar"
        Me.rbCar.Size = New System.Drawing.Size(51, 21)
        Me.rbCar.TabIndex = 0
        Me.rbCar.Text = "Car"
        Me.rbCar.UseVisualStyleBackColor = True
        '
        'rbTruck
        '
        Me.rbTruck.AutoSize = True
        Me.rbTruck.Location = New System.Drawing.Point(209, 81)
        Me.rbTruck.Name = "rbTruck"
        Me.rbTruck.Size = New System.Drawing.Size(65, 21)
        Me.rbTruck.TabIndex = 1
        Me.rbTruck.Text = "Truck"
        Me.rbTruck.UseVisualStyleBackColor = True
        '
        'txtMake
        '
        Me.txtMake.Location = New System.Drawing.Point(188, 149)
        Me.txtMake.Name = "txtMake"
        Me.txtMake.Size = New System.Drawing.Size(140, 22)
        Me.txtMake.TabIndex = 2
        '
        'txtModel
        '
        Me.txtModel.Location = New System.Drawing.Point(188, 177)
        Me.txtModel.Name = "txtModel"
        Me.txtModel.Size = New System.Drawing.Size(140, 22)
        Me.txtModel.TabIndex = 3
        '
        'txtYear
        '
        Me.txtYear.Location = New System.Drawing.Point(188, 205)
        Me.txtYear.Name = "txtYear"
        Me.txtYear.Size = New System.Drawing.Size(140, 22)
        Me.txtYear.TabIndex = 4
        '
        'txtTrunk
        '
        Me.txtTrunk.Location = New System.Drawing.Point(188, 233)
        Me.txtTrunk.Name = "txtTrunk"
        Me.txtTrunk.Size = New System.Drawing.Size(140, 22)
        Me.txtTrunk.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(78, 152)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 17)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Make"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(78, 180)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 17)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Model"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(78, 208)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 17)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Year"
        '
        'lblTrunk
        '
        Me.lblTrunk.AutoSize = True
        Me.lblTrunk.Location = New System.Drawing.Point(78, 236)
        Me.lblTrunk.Name = "lblTrunk"
        Me.lblTrunk.Size = New System.Drawing.Size(103, 17)
        Me.lblTrunk.TabIndex = 9
        Me.lblTrunk.Text = "Trunk Capacity"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(198, 278)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(95, 25)
        Me.btnAdd.TabIndex = 6
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'lstbxVehicles
        '
        Me.lstbxVehicles.FormattingEnabled = True
        Me.lstbxVehicles.ItemHeight = 16
        Me.lstbxVehicles.Location = New System.Drawing.Point(494, 123)
        Me.lstbxVehicles.Name = "lstbxVehicles"
        Me.lstbxVehicles.Size = New System.Drawing.Size(240, 132)
        Me.lstbxVehicles.TabIndex = 11
        '
        'lblDisplay
        '
        Me.lblDisplay.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.lblDisplay.Location = New System.Drawing.Point(78, 340)
        Me.lblDisplay.Name = "lblDisplay"
        Me.lblDisplay.Size = New System.Drawing.Size(656, 57)
        Me.lblDisplay.TabIndex = 12
        Me.lblDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmVehicles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(813, 472)
        Me.Controls.Add(Me.lblDisplay)
        Me.Controls.Add(Me.lstbxVehicles)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.lblTrunk)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtTrunk)
        Me.Controls.Add(Me.txtYear)
        Me.Controls.Add(Me.txtModel)
        Me.Controls.Add(Me.txtMake)
        Me.Controls.Add(Me.rbTruck)
        Me.Controls.Add(Me.rbCar)
        Me.Name = "frmVehicles"
        Me.Text = "Vehicles"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rbCar As System.Windows.Forms.RadioButton
    Friend WithEvents rbTruck As System.Windows.Forms.RadioButton
    Friend WithEvents txtMake As System.Windows.Forms.TextBox
    Friend WithEvents txtModel As System.Windows.Forms.TextBox
    Friend WithEvents txtYear As System.Windows.Forms.TextBox
    Friend WithEvents txtTrunk As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblTrunk As System.Windows.Forms.Label
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents lstbxVehicles As System.Windows.Forms.ListBox
    Friend WithEvents lblDisplay As System.Windows.Forms.Label

End Class
