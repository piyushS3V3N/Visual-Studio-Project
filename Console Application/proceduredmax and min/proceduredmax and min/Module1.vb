Module Module1
    Dim arr() As Integer
    Sub Main()
        maxmin()
    End Sub
    Sub maxmin()

        Console.WriteLine("Enter number of elements :")
        Dim n As Integer = Console.ReadLine
        n = n - 1
        ReDim arr(n)
        For i = 0 To n
            arr(i) = Console.ReadLine()
        Next
        Dim max As Integer = arr(1)
        Dim min As Integer = arr(1)
        For i = 0 To n
            If (max < arr(i)) Then
                max = arr(i)
            End If
            If (min > arr(i)) Then
                min = arr(i)
            End If
        Next
        Console.WriteLine("Max : {0} Min : {1} ", max, min)
        Console.ReadKey()
    End Sub
End Module
