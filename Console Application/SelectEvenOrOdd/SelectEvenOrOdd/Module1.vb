Module Module1
    Dim number As Integer
    Sub Main()
        Console.WriteLine("Enter a number :")
        number = Console.ReadLine()
        Select Case (number Mod 2)
            Case 0
                Console.WriteLine("Even")
            Case 1
                Console.WriteLine("Odd")
        End Select
        Console.ReadKey()
    End Sub

End Module
