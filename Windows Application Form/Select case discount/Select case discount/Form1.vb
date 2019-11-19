Public Class Form1
    Dim discount, netamount, amount As Single
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        amount = Val(TextBox1.Text)
        Select Case amount
            Case 5000 To 10000
                Label3.Text = "5%"
                discount = amount * 0.05
            Case Is < 5000
                Label3.Text = "2%"
                discount = amount * 0.02
            Case Is > 10000
                Label3.Text = "8%"
                discount = amount * 0.02
        End Select
        netamount = amount - discount
        Label5.Text = netamount
    End Sub
End Class
