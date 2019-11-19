Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListView1.Location = New Point(10, 10)
        ListView1.Size = New Size(150, 150)
        Dim ListItem1 As ListViewItem
        ListItem1 = ListView1.Items.Add("Item 1")
        Dim ListItem2 As ListViewItem
        ListItem2 = ListView1.Items.Add("Item 2")
        Dim ListItem3 As ListViewItem
        ListItem3 = ListView1.Items.Add("Item 3")
        Dim ListItem4 As ListViewItem
        ListItem4 = ListView1.Items.Add("Item 4")
        ListView1.View = View.SmallIcon
        Me.Text = "ListView"
    End Sub
End Class