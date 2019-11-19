Public Class Form1
    Private Sub VScrollBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles VScrollBar1.Scroll
        TextBox1.Font = New System.Drawing.Font("", VScrollBar1.Value)
    End Sub
End Class
