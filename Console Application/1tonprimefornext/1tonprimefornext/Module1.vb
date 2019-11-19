Module Module1
    Dim num As Integer
    Sub Main()
        Dim primecount As Integer
        Console.WriteLine("Enter the value for n :")
        num = Console.ReadLine
        For i = 1 To num
            For n = 1 To i - 1
                If (i Mod n <> 0) Then
                    Exit For
                Else
                    primecount = primecount + 1
                End If
            Next
        Next
        Console.WriteLine("Prime number count : {0}", primecount)
        Console.ReadKey()
    End Sub

End Module
