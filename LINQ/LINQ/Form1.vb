Public Class Form1

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim cars(5) As Object
        Dim myquery = From car In cars
                      Select car.make, car.model, car.year
                      Where cars.color = Color.Red
        DataGridView1.DataSource = myquery.toarray

        Dim myquery = From proc In Process.GetProcesses
                      Select proc.Id, proc.ProcessName, proc.MachineName, proc.PrivateMemorySize64
                      Where PrivateMemorySize64 > 50000000
        DataGridView1.DataSource = myquery.ToArray
    End Sub
End Class
