Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("Produk 1")
        ComboBox1.Items.Add("Produk 2")
        ComboBox1.Items.Add("Produk 3")
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

        If ComboBox1.Text = "Produk 1" Then
            txtnama.Text = "AQUA"
            txtharga.Text = "3000"
        ElseIf ComboBox1.Text = "Produk 2" Then
            txtnama.Text = "Sari Roti"
            txtharga.Text = "5000"
        ElseIf ComboBox1.Text = "Produk 3" Then
            txtnama.Text = "Silverqueen"
            txtharga.Text = "10000"
        End If

    End Sub

    Private Sub proses_Click(sender As Object, e As EventArgs) Handles proses.Click
        If txtjumlah.Text = "" Then
            txtjumlah.Text = 0
        End If
        txttotal.Text = Val(txtharga.Text) * Val(txtjumlah.Text)
    End Sub

    Private Sub bersih_Click(sender As Object, e As EventArgs) Handles bersih.Click
        txtjumlah.Clear()
        txttotal.Clear()
    End Sub

    Private Sub tutup_Click(sender As Object, e As EventArgs) Handles tutup.Click
        Me.Close()
    End Sub
End Class
