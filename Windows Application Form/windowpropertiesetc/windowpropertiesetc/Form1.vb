Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim button1 As New Button()
        Dim button2 As New Button()
        button1.Text = "OK"
        button1.Location = New Point(10, 10)
        button2.Text = "Cancel"
        button2.Location = New Point(button1.Left, button1.Height + button1.Top + 10)
        Me.Text = "Windows Properties Etc"
        Me.HelpButton = True
        Me.FormBorderStyle = FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.AcceptButton = button1
        Me.CancelButton = button2
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Height = 150
        Me.Width = 180
        Me.Controls.Add(button1)
        Me.Controls.Add(button2)
    End Sub

End Class
