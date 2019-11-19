Module Module1
    Class Course
        Dim id, flag As Integer
        Dim course As String
        Sub New(ByVal courseid As Integer)
            id = courseid
            Select Case courseid
                Case 1
                    course = "BCA"
                Case 2
                    course = "BJMC"
                Case 3
                    course = "B.Com"
                Case Else
                    Console.WriteLine("Invalid Intializer !!")
            End Select
        End Sub
        Function getval() As Integer
            Console.WriteLine("Enter a Course id")
            id = Console.ReadLine
            If id = 1 Or id = 2 Or id = 3 Then
                Console.WriteLine("Id Already Taken")
                flag = 0
                Return flag
            Else
                Console.WriteLine("Enter the Course Name :")
                course = Console.ReadLine
                flag = 1
                Return flag
            End If
        End Function
        Sub Display()
            Console.WriteLine("Course : {0}", course)
            Console.WriteLine("ID : {0}", id)
        End Sub
        Sub New()
            Console.WriteLine("Intializing a empty one ...")
            Do
                flag = getval()
            Loop Until (flag = 1)
        End Sub
    End Class
    Sub Main()
        Dim obj As Course
        Console.WriteLine("Do you want To initialize with ID or Without ID (1/2) :")
        Dim a As Integer = Console.ReadLine
        If a = 1 Then
            Console.WriteLine("Enter Course Id : ")
            Dim intcourse As Integer = Console.ReadLine
            obj = New Course(intcourse)
            obj.Display()
        Else
            obj = New Course
            obj.Display()
        End If
        Console.ReadKey()
    End Sub

End Module
