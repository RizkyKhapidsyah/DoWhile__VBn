Public Class Form1

    Private Sub tombolJalankan_Click(sender As Object, e As EventArgs) Handles tombolJalankan.Click
        Dim intHitung As Integer = 0

        Do While intHitung < 10
            listKeluaran.Items.Add("Hallo, Nama Saya Anu")
            intHitung += 1
        Loop
    End Sub

    Private Sub tombolBersihkan_Click(sender As Object, e As EventArgs) Handles tombolBersihkan.Click
        listKeluaran.Items.Clear()
    End Sub

    Private Sub tombolKeluar_Click(sender As Object, e As EventArgs) Handles tombolKeluar.Click
        'menutup form
        Me.Close()
    End Sub
End Class
