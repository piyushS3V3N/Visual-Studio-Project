Public Class Form1
    Sub fixbuttoncolor()
        Me.RadioButton1.BackColor = Color.White
        Me.RadioButton2.BackColor = Color.White
        Me.RadioButton3.BackColor = Color.White
        Me.RadioButton4.BackColor = Color.White
        Me.RadioButton5.BackColor = Color.White
    End Sub
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        Me.BackColor = Color.Red
        fixbuttoncolor()
    End Sub
    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        Me.BackColor = Color.Blue
        fixbuttoncolor()
    End Sub
    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        Me.BackColor = Color.Black
    End Sub
    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        Me.BackColor = Color.Green
    End Sub
    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        Me.BackColor = Color.White
    End Sub
End Class
