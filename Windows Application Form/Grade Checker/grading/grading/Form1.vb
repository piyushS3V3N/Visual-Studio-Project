Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Val(TextBox1.Text) > 80 Then
            Label2.Text = "Grade : A"
        ElseIf 60 < Val(TextBox1.Text) <= 80 Then
            Label2.Text = "Grade : B"
        ElseIf 40 < Val(TextBox1.Text) <= 60 Then
            Label2.Text = "Grade : C"
        Else
            Label2.Text = "Fail"
        End If
    End Sub
End Class
