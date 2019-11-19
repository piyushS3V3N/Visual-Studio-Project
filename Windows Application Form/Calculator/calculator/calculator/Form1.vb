Public Class Form1
    Dim checker As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        checker = TextBox3.Text
        checker = LCase(checker)
        If checker = "addition" Then
            Label4.Text = "Result : " + Str(Val(TextBox1.Text) + Val(TextBox2.Text))
        ElseIf checker = "subtraction" Then
            Label4.Text = "Result : " + Str(Val(TextBox1.Text) - Val(TextBox2.Text))
        ElseIf checker = "multiplication" Then
            Label4.Text = "Result : " + Str(Val(TextBox1.Text) * Val(TextBox2.Text))
        ElseIf checker = "division" Then
            Label4.Text = "Result : " + Str(Val(TextBox1.Text) / Val(TextBox2.Text))
        ElseIf checker = "modulus" Then
            Label4.Text = "Result : " + Str(Val(TextBox1.Text) Mod Val(TextBox2.Text))
        End If
    End Sub
End Class
