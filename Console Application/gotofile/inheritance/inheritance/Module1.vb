Module Module1
    Class Employee
        Protected emp_id As Integer
        Protected emp_name, emp_designation As String
        Protected basic, DA, TA, gross_salary As Single
        Function Calculate() As Integer
            gross_salary = basic + DA + TA
            Return gross_salary
        End Function
        Sub Display()
            Console.Clear()
            Console.WriteLine("Employee Id : {0}", emp_id)
            Console.WriteLine("Employee Name : {0}", emp_name)
            Console.WriteLine("Basic Salary : {0}", basic)
            Console.WriteLine("Dearness Allowance : {0}", DA)
            Console.WriteLine("Travel Allowance : {0}", TA)
            Console.WriteLine("Gross Salary : {0}", gross_salary)
        End Sub
        Sub Entry()
            Console.WriteLine("Enter Employee Id :")
            emp_id = Console.ReadLine()
            Console.WriteLine("Enter Employee Name : ")
            emp_name = Console.ReadLine
            Console.WriteLine("Enter Basic Salary : ")
            basic = Console.ReadLine
            Console.WriteLine("Enter Dearness Allowance : ")
            DA = Console.ReadLine
            Console.WriteLine("Enter Travel Allowance : ")
            TA = Console.ReadLine
            Dim Final_salary As Single = Calculate()
        End Sub
        Class Engineer
            Inherits Employee
            Sub Input_designation()
                Console.WriteLine("Enter the Employee Designation :")
                emp_designation = Console.ReadLine
            End Sub
            Sub Output_designation()
                Console.WriteLine("Employee Designation Is : {0}", emp_designation)
            End Sub
        End Class
    End Class
    Sub Main()
        Dim eng As Employee.Engineer = New Employee.Engineer
        eng.Entry()
        eng.Input_designation()
        eng.Display()
        eng.Output_designation()
        Console.ReadKey()
    End Sub

End Module
