Public Class frm_allorders_ga03842
    Private Sub btn_orders_Click(sender As Object, e As EventArgs) Handles btn_orders.Click
        frm_orders_ga03842.Show()
    End Sub

    Private Sub btn_invoices_Click(sender As Object, e As EventArgs) Handles btn_invoices.Click
        frm_invoice_ga03842.Show()
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Me.Hide()
        frm_mainmenu_ga03842.Show()
    End Sub

    Private Sub btn_orderdetails_Click(sender As Object, e As EventArgs) Handles btn_orderdetails.Click
        frm_makeorders_ga03842.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frm_vieworderdetails_ga03842.Show()

    End Sub
End Class