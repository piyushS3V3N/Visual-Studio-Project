Module Module1
    Dim num, sum As Integer
    Sub Main()
        Console.WriteLine("Enter a number : ")
        num = Console.ReadLine()
        For i = 1 To num
            sum = sum + i
        Next
        Console.WriteLine("Sum {0} is {1}", num, sum)
        Console.ReadKey()
    End Sub

End Module
