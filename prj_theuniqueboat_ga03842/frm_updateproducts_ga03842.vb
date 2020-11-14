Public Class frm_updateproducts_ga03842

    Dim current_id As String
    Private Sub frm_updateproducts_ga03842_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        refresh_grid()
        get_current_id()
    End Sub

    Private Sub refresh_grid()

        Dim mysql As String = "SELECT * FROM TBL_PRODUCT_GA03842"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        grd_products.DataSource = mydatatable

    End Sub
    Private Sub clear_fields()

        txt_id.Text = ""
        txt_name.Text = ""
        txt_price.Text = ""
        txt_type.Text = ""
        txt_brand.Text = ""
        txt_warranty.Text = ""
        txt_description.Text = ""

    End Sub

    Private Sub get_current_id()

        Dim current_row As Integer = grd_products.CurrentRow.Index
        current_id = grd_products(0, current_row).Value

        txt_id.Text = current_id
        txt_name.Text = grd_products(1, current_row).Value
        txt_price.Text = grd_products(2, current_row).Value
        txt_type.Text = grd_products(3, current_row).Value
        txt_brand.Text = grd_products(4, current_row).Value
        txt_warranty.Text = grd_products(5, current_row).Value
        txt_description.Text = grd_products(6, current_row).Value

    End Sub

    Private Sub grd_courses_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_products.CellClick
        get_current_id()
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        run_sql_command("UPDATE TBL_PRODUCT_GA03842 SET FLD_PRODUCT_NAME='" & txt_name.Text & "' WHERE FLD_PRODUCT_ID='" & current_id & "'")
        run_sql_command("UPDATE TBL_PRODUCT_GA03842 SET FLD_PRICE=" & txt_price.Text & " WHERE FLD_PRODUCT_ID='" & current_id & "'")
        run_sql_command("UPDATE TBL_PRODUCT_GA03842 SET FLD_TYPE='" & txt_type.Text & "' WHERE FLD_PRODUCT_ID='" & current_id & "'")
        run_sql_command("UPDATE TBL_PRODUCT_GA03842 SET FLD_BRAND='" & txt_brand.Text & "' WHERE FLD_PRODUCT_ID='" & current_id & "'")
        run_sql_command("UPDATE TBL_PRODUCT_GA03842 SET FLD_WARRANTY='" & txt_warranty.Text & "' WHERE FLD_PRODUCT_ID='" & current_id & "'")
        run_sql_command("UPDATE TBL_PRODUCT_GA03842 SET FLD_DESCRIPTION='" & txt_description.Text & "' WHERE FLD_PRODUCT_ID='" & current_id & "'")

        Beep()
        MsgBox("You have successfully updated the product """ & current_id & """.")

        refresh_grid()
        clear_fields()
        get_current_id()

    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click

        Dim delete_confirmation = MsgBox("Are you sure you would like to delete the product """ & current_id & """?", MsgBoxStyle.YesNo)
        If delete_confirmation = MsgBoxResult.Yes Then
            run_sql_command("DELETE FROM TBL_PRODUCT_GA03842 WHERE FLD_PRODUCT_ID='" & current_id & "'")

            Beep()
            MsgBox("The product """ & current_id & """ has been successfully deleted.")

            refresh_grid()
            clear_fields()
            get_current_id()



        End If

    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Me.Hide()
        frm_allproducts_ga03842.Show()
    End Sub
End Class