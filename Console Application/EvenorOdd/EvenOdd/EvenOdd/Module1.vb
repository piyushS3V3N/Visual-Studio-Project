Module Module1
    Dim num As Integer
    Sub Main()
        Console.WriteLine("Enter a number :")
        num = Console.ReadLine
        If num Mod 2 = 0 Then
            Console.WriteLine("Number is Even")
        Else
            Console.WriteLine("Number is Odd")
        End If
        Console.ReadKey()
    End Sub

End Module
