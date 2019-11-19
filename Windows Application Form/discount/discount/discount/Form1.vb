Public Class Form1
    Dim discount, netamount As Single
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If 5000 < Val(TextBox1.Text) And Val(TextBox1.Text) < 10000 Then
            discount = Val(TextBox1.Text) * 0.05
            Label2.Text = "Discount : 5%"
        ElseIf Val(TextBox1.Text) > 10000 Then
            discount = Val(TextBox1.Text) * 0.08
            Label2.Text = "Discount : 8%"
        ElseIf Val(TextBox1.Text) < 5000 Then
            discount = Val(TextBox1.Text) * 0.02
            Label2.Text = "Discount : 2%"
        End If
        netamount = Val(TextBox1.Text) - discount
        Label3.Text = "Net Amount Payable : " + Str(netamount)
    End Sub
End Class
