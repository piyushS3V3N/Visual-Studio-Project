Module Module1
    Public NotInheritable Class Mycl
        Public Shared Function Add(ByVal num1 As Integer, ByVal num2 As Integer) As Integer
            Return num1 + num2
        End Function
        Public Shared Function [Sub](ByVal num1 As Integer, ByVal num2 As Integer) As Integer
            Return num1 - num2
        End Function
        Public Shared Function Mul(ByVal num1 As Integer, ByVal num2 As Integer) As Integer
            Return num1 * num2
        End Function
    End Class
    Sub Main()
        Dim MyMath As [Mycl]
        Console.WriteLine("Sum= " & MyMath.Add(5, 2).ToString())
        Console.WriteLine("Substraction = " & MyMath.[Sub](9, 2).ToString())
        Dim mul As Integer = MyMath.Mul(7, 2)
        Console.WriteLine("Multiply  = {0}", mul)
        Console.ReadKey()
    End Sub
End Module