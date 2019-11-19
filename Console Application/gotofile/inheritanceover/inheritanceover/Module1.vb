Module Module1
    Const BonusRate As Decimal = 1.45D
    Const PayRate As Decimal = 14.75D
    Class Payroll
        Overridable Function PayEmployee(
        ByVal HoursWorked As Decimal,
        ByVal PayRate As Decimal) As Decimal
            PayEmployee = HoursWorked * PayRate
        End Function
    End Class
    Class BonusPayroll
        Inherits Payroll
        Overrides Function PayEmployee(
        ByVal HoursWorked As Decimal,
        ByVal PayRate As Decimal) As Decimal
            PayEmployee = MyBase.PayEmployee(HoursWorked, PayRate) * BonusRate
        End Function
    End Class
    Sub RunPayroll()
        Dim PayrollItem As Payroll = New Payroll
        Dim BonusPayrollItem As New BonusPayroll
        Dim HoursWorked As Decimal = 40

        Console.WriteLine("Normal pay is: " &
        PayrollItem.PayEmployee(HoursWorked, PayRate))
        Console.WriteLine("Pay with bonus is: " &
        BonusPayrollItem.PayEmployee(HoursWorked, PayRate))
    End Sub
    Public Class TaxClass
        Overloads Function TaxAmount(ByVal decPrice As Decimal,
         ByVal TaxRate As Single) As String
            TaxAmount = "Price is a Decimal. Tax is Rs " &
           (CStr(decPrice * TaxRate))
        End Function
        Overloads Function TaxAmount(ByVal strPrice As String,
          ByVal TaxRate As Single) As String
            TaxAmount = "Price is a String. Tax is Rs " &
           CStr((CDec(strPrice) * TaxRate))
        End Function
    End Class
    Sub Main()
        Console.WriteLine("PayRoll")
        RunPayroll()
        Console.WriteLine("Taxing : ")
        Const TaxRate As Single = 0.08
        Dim strPrice As String = "64.00"
        Dim decPrice As Decimal = 64
        Dim aclass As New TaxClass
        Console.WriteLine(aclass.TaxAmount(strPrice, TaxRate))
        Console.WriteLine(aclass.TaxAmount(decPrice, TaxRate))
        Console.ReadKey()
    End Sub
End Module
