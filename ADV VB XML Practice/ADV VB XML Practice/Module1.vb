Imports System.Xml.Serialization
Imports System.Xml
Imports System.IO

Module Module1

    Sub Main()
        'Open file Filmorama.xmp
        Dim dehydrated As FileStream = New FileStream("Filmorama.xml", FileMode.Open)
        'create an Xmlserializer instance to handle deserializing filmorderlist
        Dim serialize As XmlSerializer = New XmlSerializer(GetType(FilmOrderList))
        'create an object to contain the deserialized instance of the object
        Dim MyFilmOrder As FilmOrderList = New FilmOrderList
        serialize.Serialize(Console.Out, MyFilmOrder)
        'deserialize object
        MyFilmOrder = CType(serialize.Deserialize(dehydrated), FilmOrderList)

        Dim SingleFilmOrder As FilmOrder
        For Each SingleFilmOrder In MyFilmOrder.FilmOrders
            Console.Out.WriteLine("{0}, {1}, {2}", SingleFilmOrder.Name, SingleFilmOrder.FilmId, SingleFilmOrder.Quantity)
        Next
        Console.ReadLine()
    End Sub

End Module
