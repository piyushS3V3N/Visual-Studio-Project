MustInherit Class Page
    Public Function Number() As Integer
        Return 28
    End Function
End Class

Class TextPage
    Inherits Page
End Class

Module Module1
    Sub Main()
        ' Create new TextPage.
        Dim t As TextPage = New TextPage

        ' Write result of Number Function.
        Console.WriteLine(t.Number())
        Console.ReadKey()
    End Sub
End Module