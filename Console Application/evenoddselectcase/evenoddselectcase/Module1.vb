Module Module1
    Dim num As Integer
    Sub Main()
        Console.WriteLine("Enter a number :")
        num = Console.ReadLine
        Select Case num Mod 2
            Case 0
                Console.WriteLine("Even")
            Case Else
                Console.WriteLine("Odd")
        End Select

        Console.ReadKey()
    End Sub

End Module
