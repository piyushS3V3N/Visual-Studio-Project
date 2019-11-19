Module Module1
    Dim arr() As Integer
    Sub Main()
        Dim current_size As Integer
        Dim check As Integer
        current_size = makearray()
        intializearray(current_size)
        Console.ReadKey()
        Console.Clear()
        Do
            Console.WriteLine("Enter your choice : ")
            Console.WriteLine("1. Resize Array")
            Console.WriteLine("2. Make a new array")
            Console.WriteLine("3. Exit")
            check = Console.ReadLine
            If (check = 1) Then
                Resize(current_size)
            ElseIf (check = 2) Then
                current_size = makearray()
                intializearray(current_size)
            ElseIf (check = 3) Then
                End
            Else
                Console.WriteLine("Please Enter Either yes Or no !!!")
            End If
            Console.Clear()
            Console.WriteLine("Current Size : {0}", current_size)
        Loop
        Console.ReadLine()
    End Sub
    Function makearray() As Integer
        Dim size As Integer
        Console.WriteLine("Enter the size of array : ")
        size = Console.ReadLine()
        ReDim arr(size - 1)
        Console.WriteLine("Array of size {0} has been created.", size)
        Return size - 1
    End Function
    Sub intializearray(size As Integer)
        Console.WriteLine("Enter the elements of array : ")
        For i = 0 To size
            arr(i) = Console.ReadLine
        Next
        For i = 0 To size
            Console.WriteLine("Elements of array at index {0} is {1}", i, arr(i))
        Next
    End Sub
    Sub Resize(crr_size As Integer)
        Dim size As Integer
        Console.WriteLine("Enter the size : ")
        size = Console.ReadLine
        ReDim Preserve arr(size - 1)
        Console.WriteLine("Enter the elements of array : ")
        For i = crr_size To size - 1
            arr(i) = Console.ReadLine
        Next
        For i = 0 To size - 1
            Console.WriteLine("Elements of array at index {0} is {1}", i, arr(i))
        Next
        Console.ReadKey()
    End Sub
End Module
