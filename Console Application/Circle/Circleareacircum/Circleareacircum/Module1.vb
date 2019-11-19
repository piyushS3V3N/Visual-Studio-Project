Module Module1
    Dim area, circumference, radius As Single
    Sub Main()
        Console.WriteLine("Enter the radius of circle : ")
        radius = Console.ReadLine
        area = 3.14 * radius * radius
        circumference = 2 * 3.14 * radius
        Console.WriteLine("Area :" & area)
        Console.WriteLine("Circumference : " & circumference)
        Console.ReadKey()
    End Sub

End Module
