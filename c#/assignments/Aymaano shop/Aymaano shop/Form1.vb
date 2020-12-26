Public Class Form1

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles LblAymaano.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Chkcalculate_CheckedChanged(sender As Object, e As EventArgs) Handles Chkcalculate.CheckedChanged

        txttatal.Text = txtquantity.Text * txtprice.Text


    End Sub
End Class
