Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Something"
        Me.HelpButton = True
    End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

        Label1.Location = New Point(50, 50)
        Label1.Text = "You have just moved the label"
    End Sub
    Private Sub Label1_DoubleClick(sender As Object, e As EventArgs) Handles Label1.DoubleClick
        Dim Label2 As New Label
        Label2.Text = "Another Label"
        Label2.Location = New Point(Label1.Left, Label1.Height +
         Label1.Top + 25)
        Me.Controls.Add(Label2)
    End Sub
End Class
