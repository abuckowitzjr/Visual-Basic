' NOTE: You can use the "Rename" command on the context menu to change the interface name "IService1" in both code and config file together.
<ServiceContract()>
Public Interface IMath

    <OperationContract()>
    Function add(ByVal num1 As Integer, ByVal num2 As Integer) As Long


    <OperationContract()>
    Function subtract(ByVal num1 As Integer, ByVal num2 As Integer) As Long


End Interface

' Use a data contract as illustrated in the sample below to add composite types to service operations

<DataContract()>
Public Class CompositeType

    <DataMember()>
    Public Property BoolValue() As Boolean

    <DataMember()>
    Public Property StringValue() As String

End Class
