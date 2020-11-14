Public Class frm_productdetails_ga03842

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lbl_title.Click

    End Sub
    Private Sub frm_productdetails_ga03842_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim mysql As String = "SELECT FLD_PRODUCT_ID FROM TBL_PRODUCT_GA03842"

        Dim mydatatable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        lst_products.DataSource = mydatatable
        lst_products.DisplayMember = "FLD_PRODUCT_ID"

        refresh_text(lst_products.Text)

    End Sub

    Private Sub refresh_text(id As String)

        Dim mysql As String = "SELECT * FROM TBL_PRODUCT_GA03842 WHERE FLD_PRODUCT_ID ='" & id & "'"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mydatatable)

        txt_id.Text = mydatatable.Rows(0).Item("FLD_PRODUCT_ID")
        txt_name.Text = mydatatable.Rows(0).Item("FLD_PRODUCT_NAME")
        txt_price.Text = mydatatable.Rows(0).Item("FLD_PRICE")
        txt_type.Text = mydatatable.Rows(0).Item("FLD_TYPE")
        txt_brand.Text = mydatatable.Rows(0).Item("FLD_BRAND")
        txt_warranty.Text = mydatatable.Rows(0).Item("FLD_WARRANTY")
        txt_description.Text = mydatatable.Rows(0).Item("FLD_DESCRIPTION")

        Try
            pic_product.BackgroundImage = Image.FromFile("pictures/" & txt_id.Text & ".jpg")

        Catch ex As Exception
            pic_product.BackgroundImage = Image.FromFile("pictures/nophoto.png")
        End Try

    End Sub

    Private Sub lst_products_MouseClick(sender As Object, e As MouseEventArgs) Handles lst_products.MouseClick
        refresh_text(lst_products.Text)
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Me.Hide()
        frm_allproducts_ga03842.Show()
    End Sub
End Class