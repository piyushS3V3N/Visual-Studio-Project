Module Module1
    Dim number, count_even, count_odd As Integer
    Sub Main()
        Console.WriteLine("Enter the number :")
        number = Console.ReadLine
        Do
            If (number Mod 2 = 0) Then
                count_even = count_even + 1
            Else
                count_odd = count_odd + 1
            End If
            number = number - 1
        Loop While (number)
        Console.WriteLine("Even : {0} " & vbCrLf & "Odd : {1}", count_even, count_odd)
        Console.ReadKey()
    End Sub

End Module
