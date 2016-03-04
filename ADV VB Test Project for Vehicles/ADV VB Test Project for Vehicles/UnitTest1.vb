Imports System.Text

<TestClass()>
Public Class UnitTest1

    <TestMethod()>
    Public Sub TestCarAge()
        Dim car1 As New ADV_VB_Vehicle__Test_.Car
        car1.Year = 2010
        Assert.AreEqual(car1.Age, 2)
    End Sub
    <TestMethod()>
    Public Sub TestConstructor()
        Dim car1 As New ADV_VB_Vehicle__Test_.Car("Ford", "Focus", 2010)
        Assert.AreEqual(car1.Age, 2)
        Assert.AreEqual(car1.Year, 2010)
        Assert.AreEqual(car1.Make, "Ford")
        Assert.AreEqual(car1.Model, "Focus")
    End Sub

End Class
