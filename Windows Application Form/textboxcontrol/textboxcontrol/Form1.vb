Public Class Form1
    Dim TextBox2 As New TextBox
    Private Sub TextBox1_getfocus(sender As Object, e As EventArgs) Handles TextBox1.GotFocus
        setnew()
    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        TextBox2.Text = "You Entered " + TextBox1.Text
    End Sub
    Sub setnew()

        Me.Controls.Add(TextBox2)
        Me.SetAutoSizeMode(AutoSizeMode.GrowAndShrink)
        TextBox2.Size = New Size(TextBox2.TextLength + TextBox1.Width, TextBox1.Height + 2500)
        TextBox2.Location = New Point(TextBox1.Left, TextBox1.Height + TextBox1.Top + 25)
        TextBox2.Text = "You Entered " + TextBox1.Text
    End Sub
End Class
