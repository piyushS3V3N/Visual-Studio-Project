Module Module1
    Interface Common
        Sub Leaves()
    End Interface
    Interface IHr
        Inherits Common
        Sub ShowSalary()
    End Interface
    Interface IFinance
        Inherits Common
        Sub Budget()
    End Interface
    Class ERP
        Implements IHr
        Implements IFinance
        Public Sub ShowSalary() Implements IHr.ShowSalary
            System.Console.WriteLine("Salary will be on 10th")
        End Sub
        Public Sub Budget() Implements IFinance.Budget
            System.Console.WriteLine("Budget is 10 L")
        End Sub
        Public Sub Leaves() Implements Common.Leaves
            System.Console.WriteLine("Leaves are 10 Cs, 20 EL")
        End Sub
    End Class
    Sub Main()
        Dim h As IHr = New ERP()
        h.ShowSalary()
        h.Leaves()
        Console.ReadKey()
    End Sub

End Module