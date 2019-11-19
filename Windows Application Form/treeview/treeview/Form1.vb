Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TreeView1.Location = New Point(10, 10)
        Me.Controls.Add(TreeView1)
        TreeView1.Nodes.Clear()
        Dim root = New TreeNode("Application")
        TreeView1.Nodes.Add(root)
        TreeView1.Nodes(0).Nodes.Add(New TreeNode("Project 1"))
        For loopindex As Integer = 1 To 4
            TreeView1.Nodes(0).Nodes(0).Nodes.Add(New _
               TreeNode("Sub Project" & Str(loopindex)))
        Next loopindex
        TreeView1.Nodes(0).Nodes.Add(New TreeNode("Project 6"))
        For loopindex As Integer = 1 To 3
            TreeView1.Nodes(0).Nodes(1).Nodes.Add(New _
               TreeNode("Project File" & Str(loopindex)))
        Next loopindex
    End Sub
End Class