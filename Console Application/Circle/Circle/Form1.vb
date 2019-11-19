Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label4.Text = Val(TextBox1.Text) * 2 * 3.14
        Label5.Text = Val(TextBox1.Text) * Val(TextBox1.Text) * 3.14
    End Sub
End Class
