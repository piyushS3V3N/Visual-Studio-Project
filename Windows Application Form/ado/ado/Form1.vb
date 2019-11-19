Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'StudentDataSet1.Table1' table. You can move, or remove it, as needed.
        Me.Table1TableAdapter.Fill(Me.StudentDataSet1.Table1)

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Validate()
        Me.Table1BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.StudentDataSet1)
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Table1BindingSource.RemoveCurrent()
        Me.TableAdapterManager.UpdateAll(Me.StudentDataSet1)
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Table1BindingSource.MovePrevious()
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Table1BindingSource.MoveNext()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Table1BindingSource.AddNew()
        Me.TableAdapterManager.UpdateAll(Me.StudentDataSet1)
    End Sub
End Class
