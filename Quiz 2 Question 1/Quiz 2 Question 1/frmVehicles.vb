Public Class frmVehicles
    Private Vehicles() As Vehicle

    Private Sub rbTruck_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbTruck.CheckedChanged
        If rbTruck.Checked = True Then
            lblTrunk.Text = "Bed Size"
        Else
            lblTrunk.Text = "Trunk Capacity"
        End If
    End Sub

    Private Sub btnAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnAdd.Click
        ' Allocate space in the array
        If Vehicles Is Nothing Then ' Check if array has anything
            ReDim Vehicles(0) ' Gives you an array with a single slot.
        Else
            ReDim Preserve Vehicles(Vehicles.Length) ' Gains one slot in the array to hold new info.

        End If

        ' Validation
        Dim DT As Date
        Try
            DT = Date.ParseExact(txtYear.Text, "yyyy", Nothing)
        Catch ex As Exception
            DT = DateTime.Parse("1/1/1990")
        End Try

        Dim Cap As Double ' Validation technique 
        If Not Double.TryParse(txtTrunk.Text, Cap) Then
            Cap = 0.0
        End If

        ' Create teh appropriate object and add it to the array
        Dim V As Vehicle
        If rbCar.Checked Then
            V = New Car(txtMake.Text, txtModel.Text, DT, Cap)
        Else
            V = New Truck(txtMake.Text, txtModel.Text, DT, Cap)
        End If

        Vehicles(Vehicles.Length - 1) = V ' Puts the newly instantiated vehicle into the array.

        txtMake.Focus()
        ' Add an item (string) to the list box.

        lstbxVehicles.Items.Add(txtMake.Text & " " & txtModel.Text)

        With txtMake
            .Clear()
            .Focus()
        End With

        txtModel.Clear()
        txtYear.Clear()
        txtTrunk.Clear()
    End Sub

    Private Sub lstbxVehicles_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lstbxVehicles.SelectedIndexChanged
        Dim idx As Integer
        idx = lstbxVehicles.SelectedIndex

        Dim V As Vehicle

        V = Vehicles(idx)

        lblDisplay.Text = V.GetInfo()
    End Sub
End Class

