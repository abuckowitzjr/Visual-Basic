<ServiceContract()>
Public Interface IShape

    <OperationContract()>
    Function GetSquare() As Shape

    <OperationContract()>
    Function GetRectangle() As Shape

    <OperationContract()>
    Function GetTriangle() As Shape

End Interface