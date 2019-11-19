Module Module1
    Dim amount, net_amount, discount As Single
    Sub Main()
        Dim disc As Integer
        Console.WriteLine("Enter the amount of purchase made by customer : ")
        amount = Console.ReadLine
        If (5000 < amount And amount < 10000) Then
            disc = 5
        ElseIf (amount < 5000) Then
            disc = 2
        ElseIf (amount > 10000) Then
            disc = 8
        End If
        discount = amount * disc / 100
        net_amount = amount - discount
        Console.WriteLine("Net Amount Payable : " & net_amount)
        Console.WriteLine("Discount " & disc & " %")
        Console.ReadKey()
    End Sub

End Module
