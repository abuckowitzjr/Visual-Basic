Public Class Dogs
    Dim newDataset As New DataSet
    Private Sub DogsBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles DogsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.DogsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DogsDataSet)

    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DogsDataSet.Dogs' table. You can move, or remove it, as needed.
        Me.DogsTableAdapter.Fill(Me.DogsDataSet.Dogs)
       
    End Sub
End Class
