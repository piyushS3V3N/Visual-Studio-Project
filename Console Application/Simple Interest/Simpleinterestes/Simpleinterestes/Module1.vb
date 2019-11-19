Module Module1
    Dim si, principal, rate, time As Integer
    Sub Main()
        Console.WriteLine("Enter the Principal Amount :")
        principal = Console.ReadLine
        Console.WriteLine("Enter the Interest Rate : ")
        rate = Console.ReadLine
        Console.WriteLine("Enter the Time :")
        time = Console.ReadLine
        si = principal * rate * time
        Console.WriteLine("Simple Interest : " & si)
        Console.ReadKey()
    End Sub

End Module
