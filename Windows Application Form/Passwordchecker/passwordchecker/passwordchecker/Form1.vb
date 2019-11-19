Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "Mypass1234" Then
            Label2.Text = "Entered password Is correct !!!"
        ElseIf TextBox1.Text = "" Then
            Label2.Text = "Please Enter a password to check ..."
        Else
            Label2.Text = "Incorrect Password ..."
        End If
    End Sub
End Class
