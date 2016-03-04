Public Class Form1
    Friend Vehicles As New ArrayList

    Private Sub btnAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnAdd.Click
        Try
            Dim strMake As String = txtMake.Text
            Dim strModel As String = txtModel.Text
            Dim intYear As Integer = 0
            If IsNumeric(txtYear.Text) Then
                intYear = Integer.Parse(txtYear.Text)
            End If
            Dim intHP As Integer = 250
            If IsNumeric(txtHP.Text) Then
                inthp = Integer.Parse(txtHP.Text)
            End If
            Dim strBrakes As VehicleBrakes
            Select Case cboBrakes.SelectedItem.ToString
                Case "Disc"
                    strBrakes = VehicleBrakes.Disc
                Case "Drum"
                    strBrakes = VehicleBrakes.Drum
                Case "Mechanical"
                    strBrakes = VehicleBrakes.Mechanical
            End Select
            Dim car1 As New Car(strMake, strModel, intYear, strBrakes, intHP)
            Vehicles.Add(car1)
            DisplayVehicles()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub DisplayVehicles()
        Dim lblCar As New Label()
        With lblCar
            .Name = "Car" & Vehicles(Vehicles.Count - 1).ToString
            .Text = Vehicles(Vehicles.Count - 1).ToString
            .Left = 10
            .Top = 60 + (Vehicles.Count - 1) * 25
        End With
        Me.Controls.Add(lblCar)
    End Sub

    Private Sub Form1_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        cboBrakes.Items.Add("Disc")
        cboBrakes.Items.Add("Drum")
        cboBrakes.Items.Add("Mechanical")
    End Sub

    Private Sub btnStart_Click(sender As System.Object, e As System.EventArgs) Handles btnStart.Click
        For Each veh As Object In Vehicles
            Dim vehUnboxed As Vehicle
            If TypeOf veh Is Vehicle Then
                vehUnboxed = DirectCast(veh, Vehicle)
                vehUnboxed.Start()
            End If
        Next
        UpdateCarDisplay()
    End Sub

    Private Sub btnDrive_Click(sender As System.Object, e As System.EventArgs) Handles btnDrive.Click
        For Each veh As Object In Vehicles
            Dim vehUnboxed As Vehicle
            If TypeOf veh Is Vehicle Then
                vehUnboxed = DirectCast(veh, Vehicle)
                vehUnboxed.Drive()
            End If
        Next
        UpdateCarDisplay()
    End Sub

    Private Sub btnGo_Click(sender As System.Object, e As System.EventArgs) Handles btnGo.Click
        For Each veh As Object In Vehicles
            Dim vehUnboxed As Vehicle
            If TypeOf veh Is Vehicle Then
                vehUnboxed = DirectCast(veh, Vehicle)
                vehUnboxed.SpeedUp()
            End If
        Next
        UpdateCarDisplay()
    End Sub

    Private Sub UpdateCarDisplay()
        Dim i As Integer = 0
        For Each veh As Object In Vehicles
            Dim vehUnboxed As Vehicle
            If TypeOf veh Is Vehicle Then
                vehUnboxed = DirectCast(veh, Vehicle)
                Dim lblVehicle As Label = DirectCast(Me.Controls("Car" & Vehicles(i).ToString), Label)
                If vehUnboxed.IsRunning Then
                    lblVehicle.forecolor = Color.Yellow
                Else
                    lblVehicle.foreColor = Color.Green
                End If
                Select Case vehUnboxed.Direction
                    Case VehicleDirection.Forward
                        lblVehicle.ForeColor = Color.Red
                        lblVehicle.Left += vehUnboxed.Speed
                    Case VehicleDirection.Reverse
                        lblVehicle.ForeColor = Color.Blue
                        lblVehicle.Left -= vehUnboxed.Speed
                    Case VehicleDirection.Park
                        lblVehicle.ForeColor = Color.Pink
                End Select
                i += 1
            End If
        Next
    End Sub

    Private Sub btnReverse_Click(sender As System.Object, e As System.EventArgs) Handles btnReverse.Click
        For Each veh As Object In Vehicles
            Dim vehUnboxed As Vehicle
            If TypeOf veh Is Vehicle Then
                vehUnboxed = DirectCast(veh, Vehicle)
                vehUnboxed.Reverse()
            End If
        Next
        UpdateCarDisplay()
    End Sub

   
    Private Sub btnBrake_Click(sender As System.Object, e As System.EventArgs) Handles btnBrake.Click
        For Each veh As Object In Vehicles
            Dim vehUnboxed As Vehicle
            If TypeOf veh Is Vehicle Then
                vehUnboxed = DirectCast(veh, Vehicle)
                vehUnboxed.Slowdown()
            End If
        Next
        UpdateCarDisplay()
    End Sub
End Class
