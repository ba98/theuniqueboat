Public Class frm_allcustomers_ga03842
    Private Sub btn_customers_Click(sender As Object, e As EventArgs) Handles btn_customers.Click
        frm_customers_ga03842.Show()
    End Sub

    Private Sub btn_insertcustomers_Click(sender As Object, e As EventArgs) Handles btn_insertcustomers.Click
        frm_insertcustomers_ga03842.Show()
    End Sub

    Private Sub btn_updatecustomers_Click(sender As Object, e As EventArgs) Handles btn_updatecustomers.Click
        frm_updatecustomers_ga03842.Show()
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Me.Hide()
        frm_mainmenu_ga03842.Show()
    End Sub
End Class