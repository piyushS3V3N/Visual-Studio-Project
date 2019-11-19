Module Module1
    Dim number, sum As Integer
    Sub Main()
        Console.WriteLine("Enter a number:")
        number = Console.ReadLine()
        Do
            sum = sum + number
            number = number - 1
        Loop While (number)
        Console.WriteLine("Sum : {0}", sum)
        Console.ReadKey()
    End Sub

End Module
