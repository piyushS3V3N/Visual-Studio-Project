Module Module1

    Sub Main()
        Dim pass As String
        Console.WriteLine("Enter a pass :")
        pass = Console.ReadLine
        If pass = "mypass1234" Then
            Console.WriteLine("Correct Password ")
        Else
            Console.WriteLine("Incorrect Password ")
        End If
        Console.ReadKey()
    End Sub

End Module
