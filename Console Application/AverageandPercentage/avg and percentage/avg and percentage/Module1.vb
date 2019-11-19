Module Module1
    Dim avg, percent, num1, num2, num3, num4, num5 As Single
    Sub Main()
        Console.WriteLine("Enter 5 number :")
        num1 = Console.ReadLine
        num2 = Console.ReadLine
        num3 = Console.ReadLine
        num4 = Console.ReadLine
        num5 = Console.ReadLine
        avg = (num1 + num2 + num3 + num4 + num5) / 5
        percent = avg * 100 / 100
        Console.WriteLine("Average : " & avg)
        Console.WriteLine("Percentage : " & percent & "%")
        Console.ReadKey()
    End Sub

End Module
