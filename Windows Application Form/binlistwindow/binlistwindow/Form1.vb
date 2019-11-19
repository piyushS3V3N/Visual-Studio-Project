Public Class Form1
    Dim Myarray As New ArrayList
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListBox1.SelectionMode = SelectionMode.MultiSimple
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListBox1.Items.Add(TextBox1.Text)
        Myarray.Add(TextBox1.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim add As Integer
        add = InputBox("Enter An Address To Add Value At")
        ListBox1.Items.Insert(add, TextBox1.Text)
        Myarray.Insert(add, TextBox1.Text)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim flag, value As Integer
        value = InputBox("Enter The value To  Be Searched ")
        For Each lbitem As Object In ListBox1.Items
            If lbitem.ToString = value Then
                ListBox1.SelectedItem = lbitem
                flag = 1
                Exit For
            Else
                flag = 0
            End If
        Next
        If flag = 1 Then
            MsgBox(ListBox1.SelectedItem)
        Else
            MsgBox("Error File not in list")
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim value As String = InputBox("Enter the value to be deleted")
        ListBox1.Items.Remove(value)
        Myarray.Remove(value)
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim pos As Integer = InputBox("Enter Position of element ") - 1
        ListBox1.Items.RemoveAt(pos)
        Myarray.RemoveAt(pos)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        ListBox1.Sorted = True
        ListBox1.Sorted = False
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

        Myarray.Reverse()
        ListBox1.Items.Clear()
        For Each word In Myarray
            ListBox1.Items.Add(word)
        Next
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click

        Dim message = String.Join(Environment.NewLine, Myarray.ToArray())
        MessageBox.Show(message)
    End Sub
End Class
