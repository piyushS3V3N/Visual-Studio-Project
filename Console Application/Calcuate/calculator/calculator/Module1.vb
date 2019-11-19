Module Module1
    Dim num1, num2, result As Integer
    Dim check As String
    Sub Main()
        Console.WriteLine("Enter a the name of Airthemetic operation you want to do")
        check = Console.ReadLine
        LCase(check)
        Console.WriteLine("Enter two values : ")
        num1 = Console.ReadLine
        num2 = Console.ReadLine
        If check = "addition" Or check = "add" Then
            result = num1 + num2
        ElseIf check = "subtraction" Or check = "sub" Then
            result = num1 - num2
        ElseIf check = "multiplication" Or check = "mul" Then
            result = num1 * num2
        ElseIf check = "division" Or check = "div" Or check = "divide" Then
            result = num1 / num2
        ElseIf check = "modulus" Or check = "mod" Then
            result = num2 Mod num1
        End If
        Console.WriteLine("RESULT : " & result)
        Console.ReadKey()
    End Sub

End Module
