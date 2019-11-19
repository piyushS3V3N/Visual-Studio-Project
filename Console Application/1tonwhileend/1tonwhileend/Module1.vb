Module Module1
    Dim num, sum As Integer
    Sub Main()
        Dim temp As Integer
        Console.WriteLine("Enter a Number upto which you want sum")
        num = Console.ReadLine
        temp = num
        While (num <> 0)
            sum = sum + num
            num = num - 1
        End While
        Console.WriteLine("Sum of given {0} is : {1}", temp, sum)
        Console.ReadKey()
    End Sub

End Module
