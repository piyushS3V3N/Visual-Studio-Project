Module Module1
    Dim number, fact As Integer
    Sub Main()
        fact = 1
        Console.WriteLine("Enter a number :")
        number = Console.ReadLine
        Do
            fact = fact * number
            number = number - 1
        Loop While (number)
        Console.WriteLine("Factorial {0}", fact)
        Console.ReadKey()
    End Sub

End Module
