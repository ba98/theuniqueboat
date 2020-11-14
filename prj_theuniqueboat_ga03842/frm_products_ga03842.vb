Public Class frm_products_ga03842

    Private Sub frm_products_ga03842_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim mysql As String = "SELECT * FROM TBL_PRODUCT_GA03842"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        grd_products.DataSource = mydatatable

    End Sub

    Private Sub lbl_title_Click(sender As Object, e As EventArgs) Handles lbl_title.Click

    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Me.Hide()
        frm_allproducts_ga03842.Show()
    End Sub
End Class