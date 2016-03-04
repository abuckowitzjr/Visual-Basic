<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPotluckParty
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
        Me.lstbxAppetizers = New System.Windows.Forms.ListBox()
        Me.lstbxSalad = New System.Windows.Forms.ListBox()
        Me.lstbxEntree = New System.Windows.Forms.ListBox()
        Me.lstbxDessert = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.SuspendLayout()
        '
        'lstbxAppetizers
        '
        Me.lstbxAppetizers.AllowDrop = True
        Me.lstbxAppetizers.FormattingEnabled = True
        Me.lstbxAppetizers.ItemHeight = 16
        Me.lstbxAppetizers.Location = New System.Drawing.Point(43, 110)
        Me.lstbxAppetizers.Name = "lstbxAppetizers"
        Me.lstbxAppetizers.Size = New System.Drawing.Size(181, 212)
        Me.lstbxAppetizers.TabIndex = 0
        '
        'lstbxSalad
        '
        Me.lstbxSalad.AllowDrop = True
        Me.lstbxSalad.FormattingEnabled = True
        Me.lstbxSalad.ItemHeight = 16
        Me.lstbxSalad.Location = New System.Drawing.Point(230, 110)
        Me.lstbxSalad.Name = "lstbxSalad"
        Me.lstbxSalad.Size = New System.Drawing.Size(181, 212)
        Me.lstbxSalad.TabIndex = 1
        '
        'lstbxEntree
        '
        Me.lstbxEntree.AllowDrop = True
        Me.lstbxEntree.FormattingEnabled = True
        Me.lstbxEntree.ItemHeight = 16
        Me.lstbxEntree.Location = New System.Drawing.Point(43, 345)
        Me.lstbxEntree.Name = "lstbxEntree"
        Me.lstbxEntree.Size = New System.Drawing.Size(181, 212)
        Me.lstbxEntree.TabIndex = 2
        '
        'lstbxDessert
        '
        Me.lstbxDessert.AllowDrop = True
        Me.lstbxDessert.FormattingEnabled = True
        Me.lstbxDessert.ItemHeight = 16
        Me.lstbxDessert.Location = New System.Drawing.Point(230, 345)
        Me.lstbxDessert.Name = "lstbxDessert"
        Me.lstbxDessert.Size = New System.Drawing.Size(181, 212)
        Me.lstbxDessert.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(69, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Name:"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(124, 32)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(257, 22)
        Me.txtName.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(40, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 17)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Appetizers"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(227, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 17)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Salad"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(40, 325)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 17)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Entree"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(227, 325)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 17)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Dessert"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(164, 577)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(123, 40)
        Me.btnSave.TabIndex = 10
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'frmPotluckParty
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(451, 647)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstbxDessert)
        Me.Controls.Add(Me.lstbxEntree)
        Me.Controls.Add(Me.lstbxSalad)
        Me.Controls.Add(Me.lstbxAppetizers)
        Me.Name = "frmPotluckParty"
        Me.Text = "Potluck Party"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstbxAppetizers As System.Windows.Forms.ListBox
    Friend WithEvents lstbxSalad As System.Windows.Forms.ListBox
    Friend WithEvents lstbxEntree As System.Windows.Forms.ListBox
    Friend WithEvents lstbxDessert As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog

End Class
