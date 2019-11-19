Module Module1

    Sub Main()
        Console.WriteLine("Enter the number upto which you want to see fibonacci series")
        Dim num As Integer = Console.ReadLine
        For i As Integer = 0 To num
            fibonacci(i)
        Next
        Console.ReadKey()
    End Sub
    Sub fibonacci(num As Integer)
        Dim a As Integer = 0
        Dim b As Integer = 1
        For i = 0 To num - 1
            Dim temp As Integer = a
            a = b
            b = temp + b
        Next
        Console.WriteLine("Fibonacci : {0}", a)
    End Sub
End Module
