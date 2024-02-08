Public Class Form1




    Private Sub Btn1_Click(sender As Object, e As EventArgs) Handles Btn1.Click
        Dim a As Integer
        Dim b As Integer
        a = txtfirstNum.Text
        b = txtsecondNum.Text
        lblResult.Text = a + b

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtfirstNum.TextChanged

    End Sub
End Class
