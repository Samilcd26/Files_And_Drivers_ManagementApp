Public Class AnaForm
    Private Sub SurucuBilgiBtn_Click(sender As Object, e As EventArgs) Handles SurucuBilgiBtn.Click
        SurucuBilgiFormu.ShowDialog(Me)
    End Sub

    Private Sub DosyaBilgiBtn_Click(sender As Object, e As EventArgs) Handles DosyaBilgiBtn.Click
        DosyaBilgiFormu.ShowDialog(Me)
    End Sub

    Private Sub KlasorislemBtn_Click(sender As Object, e As EventArgs) Handles KlasorislemBtn.Click
        KlasorislemFormu.ShowDialog(Me)
    End Sub
End Class
