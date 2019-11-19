Public Class Form1

    Private Sub CreateButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Panel1.Location = New System.Drawing.Point(26, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New System.Drawing.Size(228, 200)
        Panel1.BackColor = Color.LightBlue

        Dim textBox1 As New TextBox()
        textBox1.Location = New Point(10, 10)
        textBox1.Text = "I am a TextBox"
        textBox1.Size = New Size(200, 30)

        Dim checkBox1 As New CheckBox()
        checkBox1.Location = New Point(10, 50)
        checkBox1.Text = "Check Me"
        checkBox1.Size = New Size(200, 30)

        Panel1.Controls.Add(textBox1)
        Panel1.Controls.Add(checkBox1)

        Controls.Add(Panel1)

    End Sub


End Class
