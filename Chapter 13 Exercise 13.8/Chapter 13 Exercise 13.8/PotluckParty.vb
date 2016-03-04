'Project:       Potluck Party
'Programmer:    Arthur Buckowitz
'Date:          August 8, 2012
'Description:   Allows the user to drag and drop the entered name into cooresponding listboxes, the user can save
'               the contents of the listboxes into respective files, which load into the listboxes when the
'               form loads.


Imports System.IO

Public Class frmPotluckParty

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        'calls subs to save contents of listboxes
        SaveAppetizer()
        SaveDessert()
        SaveEntree()
        SaveSalad()
    End Sub

    Private Sub SaveAppetizer()
        'save contents of appetizers to file
        Try
            Dim AppetizerItemsInteger As Integer
            Dim AppetizerStreamwriter As StreamWriter = New StreamWriter("Appetizers.txt", False)
            AppetizerItemsInteger = lstbxAppetizers.Items.Count - 1
            For IndexInteger As Integer = 0 To AppetizerItemsInteger
                AppetizerStreamwriter.WriteLine(lstbxAppetizers.Items(IndexInteger))
            Next IndexInteger
            AppetizerStreamwriter.Close()
        Catch ex As Exception
            MsgBox("Error writing")
        End Try
    End Sub

    Private Sub SaveSalad()
        'save contents of salad to file
        Try
            Dim SaladItemsInteger As Integer
            Dim SaladStreamwriter As StreamWriter = New StreamWriter("Salad.txt", False)
            SaladItemsInteger = lstbxSalad.Items.Count - 1
            For IndexInteger As Integer = 0 To SaladItemsInteger
                SaladStreamwriter.WriteLine(lstbxSalad.Items(IndexInteger))
            Next IndexInteger
            SaladStreamwriter.Close()
        Catch ex As Exception
            MsgBox("Error writing")
        End Try
    End Sub

    Private Sub SaveEntree()
        'save contents of entree to file
        Try
            Dim EntreeItemsInteger As Integer
            Dim EntreeStreamwriter As StreamWriter = New StreamWriter("Entree.txt", False)
            EntreeItemsInteger = lstbxEntree.Items.Count - 1
            For IndexInteger As Integer = 0 To EntreeItemsInteger
                EntreeStreamwriter.WriteLine(lstbxEntree.Items(IndexInteger))
            Next IndexInteger
            EntreeStreamwriter.Close()
        Catch ex As Exception
            MsgBox("Error writing")
        End Try
    End Sub

    Private Sub SaveDessert()
        'save contents of dessert to file
        Try
            Dim DessertItemsInteger As Integer
            Dim DessertStreamwriter As StreamWriter = New StreamWriter("Dessert.txt", False)
            DessertItemsInteger = lstbxDessert.Items.Count - 1
            For IndexInteger As Integer = 0 To DessertItemsInteger
                DessertStreamwriter.WriteLine(lstbxDessert.Items(IndexInteger))
            Next IndexInteger
            DessertStreamwriter.Close()
        Catch ex As Exception
            MsgBox("Error writing")
        End Try
    End Sub

    Private Sub txtName_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles txtName.MouseDown
        'allows drag and drop from textbox
        If e.Button = Windows.Forms.MouseButtons.Left Then
            With txtName
                .SelectAll()
                DoDragDrop(.SelectedText, DragDropEffects.Move)
            End With
        End If
    End Sub

    Private Sub lstbxAppetizers_DragDrop(sender As Object, e As System.Windows.Forms.DragEventArgs) Handles lstbxAppetizers.DragDrop
        'allows input to be dropped into listbox
        lstbxAppetizers.Items.Add(e.Data.GetData(DataFormats.Text).ToString())
        txtName.Clear()
    End Sub

    Private Sub lstbxAppetizers_DragEnter(sender As Object, e As System.Windows.Forms.DragEventArgs) Handles lstbxAppetizers.DragEnter
        'allows input to enter listbox
        e.Effect = DragDropEffects.Move
    End Sub

    Private Sub lstbxDessert_DragDrop(sender As Object, e As System.Windows.Forms.DragEventArgs) Handles lstbxDessert.DragDrop
        'allows input to be dropped into listbox
        lstbxDessert.Items.Add(e.Data.GetData(DataFormats.Text).ToString())
        txtName.Clear()
    End Sub

    Private Sub lstbxDessert_DragEnter(sender As Object, e As System.Windows.Forms.DragEventArgs) Handles lstbxDessert.DragEnter
        'allows input to enter listbox
        e.Effect = DragDropEffects.Move
    End Sub

    Private Sub lstbxEntree_DragDrop(sender As Object, e As System.Windows.Forms.DragEventArgs) Handles lstbxEntree.DragDrop
        'allows input to be dropped into listbox
        lstbxEntree.Items.Add(e.Data.GetData(DataFormats.Text).ToString())
        txtName.Clear()
    End Sub

    Private Sub lstbxEntree_DragEnter(sender As Object, e As System.Windows.Forms.DragEventArgs) Handles lstbxEntree.DragEnter
        'allows input to enter listbox
        e.Effect = DragDropEffects.Move
    End Sub

    Private Sub lstbxSalad_DragDrop(sender As Object, e As System.Windows.Forms.DragEventArgs) Handles lstbxSalad.DragDrop
        'allows input to be dropped into listbox
        lstbxSalad.Items.Add(e.Data.GetData(DataFormats.Text).ToString())
        txtName.Clear()
    End Sub

    Private Sub lstbxSalad_DragEnter(sender As Object, e As System.Windows.Forms.DragEventArgs) Handles lstbxSalad.DragEnter
        'allows input to enter listbox
        e.Effect = DragDropEffects.Move
    End Sub

    Private Sub txtName_MouseEnter(sender As Object, e As System.EventArgs) Handles txtName.MouseEnter
        'changes cursor when mouse enters textbox field
        With txtName
            If .Text <> "" Then
                .SelectAll()
                .Cursor = Cursors.Arrow
            Else
                .Cursor = Cursors.IBeam
            End If
        End With
    End Sub

    Private Sub frmPotluckParty_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        'calls on subs to load info into listboxes
        LoadAppetizers()
        LoadDessert()
        LoadEntree()
        LoadSalad()
    End Sub

    Private Sub LoadAppetizers()
        'loads contents of appetizers to listbox
        Try
            Dim stringAppetizer As String
            Dim AppetizerStreamreader As StreamReader = New StreamReader("Appetizers.txt", False)
            Do Until AppetizerStreamreader.Peek = -1
                stringAppetizer = AppetizerStreamreader.ReadLine
                lstbxAppetizers.Items.Add(stringAppetizer)
            Loop
            AppetizerStreamreader.Close()
        Catch ex As Exception
            MsgBox("Error reading")
        End Try
    End Sub

    Private Sub LoadSalad()
        'loads contents of salad to listbox
        Try
            Dim stringSalad As String
            Dim SaladStreamreader As StreamReader = New StreamReader("Salad.txt", False)
            Do Until SaladStreamreader.Peek = -1
                stringSalad = SaladStreamreader.ReadLine
                lstbxSalad.Items.Add(stringSalad)
            Loop
            SaladStreamreader.Close()
        Catch ex As Exception
            MsgBox("Error reading")
        End Try
    End Sub

    Private Sub LoadEntree()
        'loads contents of entree to listbox
        Try
            Dim stringEntree As String
            Dim EntreeStreamreader As StreamReader = New StreamReader("Entree.txt", False)
            Do Until EntreeStreamreader.Peek = -1
                stringEntree = EntreeStreamreader.ReadLine
                lstbxEntree.Items.Add(stringEntree)
            Loop
            EntreeStreamreader.Close()
        Catch ex As Exception
            MsgBox("Error reading")
        End Try
    End Sub

    Private Sub LoadDessert()
        'loads contents of dessert to listbox
        Try
            Dim stringDessert As String
            Dim DessertStreamreader As StreamReader = New StreamReader("Dessert.txt", False)
            Do Until DessertStreamreader.Peek = -1
                stringDessert = DessertStreamreader.ReadLine
                lstbxDessert.Items.Add(stringDessert)
            Loop
            DessertStreamreader.Close()
        Catch ex As Exception
            MsgBox("Error reading")
        End Try
    End Sub

    Private Sub txtName_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtName.TextChanged
        'validates user input for textbox
        If IsNumeric(txtName.Text) And txtName.Text <> "" Then
            MsgBox("Only letters may be entered for name.")
            txtName.Text = ""
        End If
    End Sub
End Class
