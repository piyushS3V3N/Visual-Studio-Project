Module Module1
    Dim totalmark As Integer
    Sub Main()
        Console.WriteLine("Enter Marks To Find Grade :")
        totalmark = Console.ReadLine
        If totalmark > 80 Then
            Console.WriteLine("GRADE A")
        ElseIf 60 < totalmark <= 80 Then
            Console.WriteLine("GRADE B")
        ElseIf 40 < totalmark <= 60 Then
            Console.WriteLine("GRADE C")
        Else
            Console.WriteLine("FAIL")
        End If
        Console.ReadKey()
    End Sub

End Module
