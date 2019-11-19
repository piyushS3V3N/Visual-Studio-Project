Module Module1
    Class Student
        Protected Sname, name As String
        Protected enroll As Integer
    End Class
    Class Test : Inherits Student
        Protected marks(4) As Integer
        Sub Entry()
            Console.WriteLine("Enter the Enrollement Number :")
            enroll = Console.ReadLine()
            Console.WriteLine("Enter the First Name Of Student : ")
            name = Console.ReadLine()
            Console.WriteLine("Enter the Surname Of Student :")
            Sname = Console.ReadLine()
            Console.WriteLine("Enter the Marks Of 5 Subjects :")
            For i = 0 To 4
                marks(i) = Console.ReadLine
            Next
        End Sub
    End Class
    Class Result : Inherits Test
        Function Calculate() As Decimal
            Dim sum As Decimal = 0.0
            For i = 0 To 4
                sum = sum + marks(i)
            Next
            Return sum
        End Function
    End Class
    Sub Main()
        Dim stu As New Result
        stu.Entry()
        Dim result As Decimal = stu.Calculate
        Console.WriteLine("Total Marks : {0}", result)
        Console.ReadKey()
    End Sub

End Module
