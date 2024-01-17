Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim FIRSTNUMBER, SECONDNUMBER As Integer
        FIRSTNUMBER = Val(TextBox1.Text)
        SECONDNUMBER = Val(TextBox2.Text)

        SUM(FIRSTNUMBER, SECONDNUMBER)

    End Sub
    Sub sum(a As Integer, b As Integer)
        Dim total As Integer
        total = a + b
        TextBox3.Text = total

    End Sub
End Class
