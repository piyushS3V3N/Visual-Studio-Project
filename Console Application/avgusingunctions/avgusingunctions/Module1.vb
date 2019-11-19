Module Module1
    Dim arr() As Integer
    Sub Main()
        Console.WriteLine("Enter the 5 marks to find average ")
        Dim n As Integer = 5
        ReDim arr(n)
        For i = 1 To n
            arr(i) = Console.ReadLine
        Next
        Console.WriteLine("Average Marks : {0}", average(n))
        Console.ReadKey()
    End Sub
    Function average(n As Integer) As Single
        For i = 1 To n
            average = arr(i) + average
        Next
        average = average / n
    End Function
End Module
