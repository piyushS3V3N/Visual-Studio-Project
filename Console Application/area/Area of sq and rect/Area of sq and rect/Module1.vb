Module Module1
    Dim area_sq, area_rec, perimeter_sq, perimeter_rec, length, breadth, side, choice As Integer
    Sub Main()
        Console.WriteLine("Enter your choice")
        Console.WriteLine("1. Area    2. Square")
        choice = Console.ReadLine
        If choice = 1 Then
            Console.WriteLine("Enter Length :")
            length = Console.ReadLine
            Console.WriteLine("Enter Bradth :")
            breadth = Console.ReadLine
            area_rec = length * breadth
            perimeter_rec = 2 * (length + breadth)
            Console.WriteLine("Area : " & area_rec)
            Console.WriteLine("Perimeter : " & perimeter_rec)
        ElseIf choice = 2 Then
            Console.WriteLine("Enter Side Of Square :")
            side = Console.ReadLine()
            area_sq = side * side
            perimeter_sq = 4 * side
            Console.WriteLine("Area : " & area_sq)
            Console.WriteLine("Perimeter :" & perimeter_sq)
        End If
        Console.ReadKey()
    End Sub

End Module
