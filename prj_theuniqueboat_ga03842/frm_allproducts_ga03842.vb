Public Class frm_allproducts_ga03842
    Private Sub btn_products_Click(sender As Object, e As EventArgs) Handles btn_products.Click
        frm_products_ga03842.Show()
    End Sub

    Private Sub btn_details_Click(sender As Object, e As EventArgs) Handles btn_details.Click
        frm_productdetails_ga03842.Show()
    End Sub

    Private Sub btn_insertproducts_Click(sender As Object, e As EventArgs) Handles btn_insertproducts.Click
        frm_insertproducts_ga03842.Show()
    End Sub

    Private Sub btn_updateproducts_Click(sender As Object, e As EventArgs) Handles btn_updateproducts.Click
        frm_updateproducts_ga03842.Show()
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Me.Hide()
        frm_mainmenu_ga03842.Show()
    End Sub
End Class