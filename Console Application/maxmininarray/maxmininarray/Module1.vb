Module Module1
    Dim num(4), max, min As Integer
    Sub Main()
        Console.WriteLine("Enter any 5 number :")
        For i = 0 To 4
            num(i) = Console.ReadLine()
        Next
        max = num(1)
        min = num(1)
        For i = 0 To 4
            If (max < num(i)) Then
                max = num(i)
            End If
            If (min > num(i)) Then
                min = num(i)
            End If
        Next
        Console.WriteLine("Max : {0} Min : {1} ", max, min)
        Console.ReadKey()
    End Sub

End Module
