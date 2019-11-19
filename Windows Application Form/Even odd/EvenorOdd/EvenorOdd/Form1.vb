Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Val(TextBox1.Text) Mod 2 = 0 Then
            Label3.Text = "Even Number"
        Else
            Label3.Text = "Odd Number"
        End If
    End Sub
End Class
