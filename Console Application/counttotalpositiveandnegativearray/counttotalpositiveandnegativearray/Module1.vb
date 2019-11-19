Module Module1
    Dim num(4), countpositive, countnegative As Integer
    Sub Main()
        Console.WriteLine("Enter any 5 number :")
        For i = 0 To 4
            num(i) = Console.ReadLine()
        Next
        For i = 0 To 4
            If (num(i) > 0) Then
                countpositive = countpositive + 1
            ElseIf (num(i) < 0) Then
                countnegative = countnegative + 1
            End If
        Next
        Console.WriteLine("Number Of Postive Number {0}", countpositive)
        Console.WriteLine("Number Of Negative Number {0}", countnegative)
        Console.ReadKey()
    End Sub

End Module
