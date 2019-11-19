Module Module1

    Sub Main()
        Console.WriteLine("Enter a number :")
        Dim num As Integer = Console.ReadLine
        Console.WriteLine("Cube Of the number is : {0}", cube(num))
        Console.ReadKey()
    End Sub
    Function cube(num As Integer) As Integer
        Dim cubed As Integer = num * num * num
        Return cubed
    End Function
End Module
