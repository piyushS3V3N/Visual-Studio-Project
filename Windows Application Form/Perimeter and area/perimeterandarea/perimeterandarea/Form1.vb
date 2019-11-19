Public Class Form1
    Dim Area, Perimeter As Integer

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Area = Val(TextBox3.Text) * Val(TextBox3.Text)
        Perimeter = 4 * Val(TextBox3.Text)
        Label11.Text = Area
        Label13.Text = Perimeter
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Area = Val(TextBox1.Text) * Val(TextBox2.Text)
        Perimeter = 2 * (Val(TextBox1.Text) + Val(TextBox2.Text))
        Label10.Text = Area
        Label12.Text = Perimeter
    End Sub

End Class
