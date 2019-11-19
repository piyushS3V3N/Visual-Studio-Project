Public Class Form1
    Dim u As Double
    Dim l As Double
    Public Function Display()
        Dim i, n As Double
        Dim r As Double
        Dim s As Double
        For i = l To u
            n = i
            s = 0
            While n > 0
                r = n Mod 10
                s += (r * r * r)
                n \= 10
            End While
            If i = s Then
                ListBox1.Items.Add(i)
            End If
        Next
        Return Display
    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListBox1.Items.Clear()
        u = Val(TextBox1.Text)
        l = Val(TextBox2.Text)
        Display()
    End Sub
End Class
