Module Module1
    Dim num, sum As Integer
    Sub Main()
        Dim temp As Integer
        Console.WriteLine("Enter a number")
        num = Console.ReadLine()
        temp = num
        Do
            sum = sum + num
            num = num - 1
        Loop While (num > 0)
        Console.WriteLine("Sum of Number upto {0} is {1} ", temp, sum)
        Console.ReadKey()
    End Sub

End Module
