Module Module1
    Public Class Window
        Public Sub New(ByVal top As Integer, ByVal left As Integer)
            Me.top = top
            Me.left = left
        End Sub 'New

        Public Sub DrawWindow()
            Console.WriteLine("Drawing Window at {0}, {1}", top, left)
        End Sub

        Private top As Integer
        Private left As Integer

    End Class

    Public Class ListBox
        Inherits Window

        Public Sub New(ByVal top As Integer, ByVal left As Integer, ByVal theContents As String)
            MyBase.New(top, left) ' 
            mListBoxContents = theContents
        End Sub

        Public Shadows Sub DrawWindow()
            MyBase.DrawWindow()
            Console.WriteLine("Writing string to the listbox: {0}", mListBoxContents)
        End Sub

        Private mListBoxContents As String

    End Class
    Sub Main()
        Dim w As New Window(5, 10)
        w.DrawWindow()

        Dim lb As New ListBox(20, 30, "Hello world")
        lb.DrawWindow()
        Console.ReadKey()
    End Sub

End Module
