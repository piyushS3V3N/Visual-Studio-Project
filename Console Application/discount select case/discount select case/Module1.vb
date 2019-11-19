Module Module1
    Dim amount, netamount, discount As Single
    Sub Main()
        Dim disc As Integer
        Console.WriteLine("Enter the amount of purchase made by customer :")
        amount = Console.ReadLine
        Select Case amount
            Case 5000 To 10000
                disc = 5
            Case Is < 5000
                disc = 2
            Case Is > 10000
                disc = 8
        End Select
        discount = amount * disc / 100
        netamount = amount - discount
        Console.WriteLine("Net amount payable : {0}", netamount)
        Console.WriteLine("Discount {0} %", disc)
        Console.ReadKey()
    End Sub

End Module
