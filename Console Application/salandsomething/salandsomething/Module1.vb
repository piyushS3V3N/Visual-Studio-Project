Module Module1
    Class employee
        Private emp_id As Integer
        Private emp_name As String
        Private basic, DA, TA, Grosssal As Single
        Private emp_designation As String
        Sub getdata(i As Integer)
            emp_id = i
            Console.WriteLine("Employee Name : ")
            emp_name = Console.ReadLine
            Console.WriteLine("Employee Designation :")
            emp_designation = Console.ReadLine
            Console.WriteLine("Enter the Basic Salary : ")
            basic = Console.ReadLine
            Console.WriteLine("Enter the Travelling Allowance :")
            TA = Console.ReadLine
            Console.WriteLine("Enter the Dearness Allowance")
            DA = Console.ReadLine
        End Sub
        Sub Display()
            Console.WriteLine("Employee Id : {0}", emp_id)
            Console.WriteLine("Employee name {0}", emp_name)
        End Sub
        Function calculate() As Single
            Grosssal = DA + TA + basic
            Return Grosssal
        End Function
    End Class
    Sub Main()
        Dim e As employee = New employee
        Dim result As Single
        e.getdata(1)
        result = e.calculate()
        e.Display()
        Console.WriteLine("Gross Salary is {0}", result)
        Console.ReadKey()
    End Sub

End Module
