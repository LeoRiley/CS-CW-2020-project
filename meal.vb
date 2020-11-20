Public Class meal
    Public Property name As String
    Public Property price As Integer
    Public Property ingredients As String

    Public Sub New(mealname As String, priceoffood As Integer, ingredientsinfood As String)
        name = mealname
        price = priceoffood
        ingredients = ingredientsinfood
    End Sub

    Public Sub PrintItem()
        Console.WriteLine()
        Console.WriteLine("item: {0}", name)
        Console.WriteLine("price: £{0}", price)
        Console.WriteLine("ingredients: {0}", ingredients)
    End Sub

End Class

Public Class order
    Public Property orderitemnumbers As New List(Of Integer)
    Sub AddItem(itemNumber As Integer)
        orderitemnumbers.Add(itemNumber)
    End Sub


    Sub printOrder(menu As List(Of meal))
        Dim orderitemsobjs As New List(Of meal)
        'items not being added to class 
        For Each item As Integer In orderitemnumbers
            orderitemsobjs.Add(menu(item))
        Next
        Dim I As Integer = 1
        For Each item As meal In orderitemsobjs
            Console.WriteLine("{0}: {1}", CStr(I), item.name)
            I = I + 1
        Next
        Dim totalcost As Integer
        For Each item As meal In orderitemsobjs
            totalcost += item.price
        Next
        Console.WriteLine("total cost: £" & totalcost)
    End Sub
End Class
