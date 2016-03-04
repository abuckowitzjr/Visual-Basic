Public Class frmPublishers

    Private Sub PublishersBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs)
        Me.Validate()
        Me.PublishersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ContactsDataSet)

    End Sub

    Private Sub frmPublishers_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ContactsDataSet.Publishers' table. You can move, or remove it, as needed.
        Me.PublishersTableAdapter.Fill(Me.ContactsDataSet.Publishers)

    End Sub
End Class
