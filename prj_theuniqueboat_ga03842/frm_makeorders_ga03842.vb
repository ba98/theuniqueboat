

Public Class frm_makeorders_ga03842

    Dim customerID As String
    Dim staffID As String
    Dim myOrderDataTable As New DataTable
    Dim customerTable As New DataTable
    Dim staffTable As New DataTable
    Dim row As Integer = 0
    Dim productID As String
    Dim price As String
    Dim total As Double = 0.0

    Private Sub frm_makeorders_ga03842_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        myOrderDataTable.Columns.Add("OrderID")
        myOrderDataTable.Columns.Add("CustomerID")
        myOrderDataTable.Columns.Add("StaffID")
        myOrderDataTable.Columns.Add("ProductID")
        myOrderDataTable.Columns.Add("Quantity")
        myOrderDataTable.Columns.Add("SubTotal")
        myOrderDataTable.Columns.Add("OrderDate")

        lst_products.DataSource = run_sql_query("SELECT FLD_PRODUCT_NAME FROM TBL_PRODUCT_GA03842")
        lst_products.DisplayMember = "FLD_PRODUCT_NAME"

        RefreshText(lst_products.Text)

        Try
            txt_order_id.Text = GenerateOrderID()
        Catch ex As Exception
            txt_order_id.Text = "O001"
        End Try

        customerTable = run_sql_query("SELECT FLD_CUSTOMER_ID FROM TBL_CUSTOMER_GA03842")
        If customerTable.Rows.Count > 0 Then
            With cbb_customer_id
                .Items.Clear()
                For i As Integer = 0 To customerTable.Rows.Count - 1
                    .Items.Add(customerTable.Rows(i).Item(0))
                Next
                .SelectedIndex = 0
            End With
        End If

        customerID = cbb_customer_id.SelectedItem.ToString
        lbl_customer_name.Text = ": " & run_sql_query("SELECT * FROM TBL_CUSTOMER_GA03842 WHERE FLD_CUSTOMER_ID='" & customerID & "'").Rows(0).Item("FLD_CUSTOMER_NAME")

        staffTable = run_sql_query("SELECT FLD_STAFF_ID FROM TBL_STAFF_GA03842")
        If staffTable.Rows.Count > 0 Then
            With cbb_staff_id
                .Items.Clear()
                For i As Integer = 0 To staffTable.Rows.Count - 1
                    .Items.Add(staffTable.Rows(i).Item(0))
                Next
                .SelectedIndex = 0
            End With
        End If

        staffID = cbb_staff_id.SelectedItem.ToString
        lbl_staff_name.Text = ": " & run_sql_query("SELECT * FROM TBL_STAFF_GA03842 WHERE FLD_STAFF_ID='" & staffID & "'").Rows(0).Item("FLD_STAFF_NAME")

        ResetForm()
    End Sub

    Private Function GenerateOrderID() As String
        Dim lastorder As String = run_sql_query("SELECT MAX(FLD_ORDER_ID) AS LASTORDER FROM TBL_ORDERS_GA03842").Rows(0).Item("LASTORDER")
        Dim neworderID As Integer = Mid(lastorder, 2) + 1
        Dim neworder As String

        If (neworderID < 10) Then
            neworder = "O00" & neworderID.ToString
        ElseIf (neworderID < 100) Then
            neworder = "O0" & neworderID.ToString
        Else
            neworder = "O" & neworderID.ToString
        End If
        Return neworder
    End Function

    Private Sub RefreshText(prodName As String)
        Dim mydatatable As New DataTable
        mydatatable = run_sql_query("SELECT * FROM TBL_PRODUCT_GA03842 WHERE FLD_PRODUCT_NAME = '" & prodName & "'")
        productID = mydatatable.Rows(0).Item("FLD_PRODUCT_ID")
        lbl_name.Text = ": " & mydatatable.Rows(0).Item("FLD_PRODUCT_NAME")
        price = mydatatable.Rows(0).Item("FLD_PRICE")
        'Dim type As String = mydatatable.Rows(0).Item("FLD_TYPE")
        lbl_price.Text = ": RM" & price & " per one" '& type
        Try
            pb_product_display.BackgroundImage = Image.FromFile("pictures/" & productID & ".jpg")
        Catch ex As Exception
            pb_product_display.BackgroundImage = Image.FromFile("Pictures/nophoto.png")
        End Try
    End Sub

    Private Sub ResetForm()
        txt_order_id.Text = GenerateOrderID()
        myOrderDataTable.Rows.Clear()
        grd_order.DataSource = myOrderDataTable
        txt_order_id.Enabled = True
        cbb_customer_id.Enabled = True
        cbb_staff_id.Enabled = True
        txt_quantity.Text = "1"
        row = 0
        total = 0.0
        lbl_total.Text = "RM0.00"
        cbb_customer_id.SelectedIndex = 0
        cbb_staff_id.SelectedIndex = 0
    End Sub

    Private Sub cbb_customer_id_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbb_customer_id.SelectedIndexChanged
        customerID = cbb_customer_id.SelectedItem.ToString
        lbl_customer_name.Text = ": " & run_sql_query("SELECT * FROM TBL_CUSTOMER_GA03842 WHERE FLD_CUSTOMER_ID='" & customerID & "'").Rows(0).Item("FLD_CUSTOMER_NAME")
    End Sub

    Private Sub cbb_staff_id_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbb_staff_id.SelectedIndexChanged

        staffID = cbb_staff_id.SelectedItem.ToString
        lbl_staff_name.Text = ": " & run_sql_query("SELECT * FROM TBL_STAFF_GA03842 WHERE FLD_STAFF_ID='" & staffID & "'").Rows(0).Item("FLD_STAFF_NAME")
    End Sub

    Private Sub lst_products_MouseClick(sender As Object, e As MouseEventArgs) Handles lst_products.MouseClick
        RefreshText(lst_products.Text)
    End Sub

    Private Sub btn_order_Click(sender As Object, e As EventArgs) Handles btn_order.Click
        Dim mytransaction As OleDb.OleDbTransaction

        myconnection2.Open()
        mytransaction = myconnection2.BeginTransaction

        Try
            Dim orderID As String = grd_order(0, 0).Value
            Dim customerID As String = grd_order(1, 0).Value
            Dim staffID As String = grd_order(2, 0).Value
            Dim productID As String = grd_order(3, 0).Value
            Dim quantity As String = grd_order(4, 0).Value
            Dim subTotal As String = Mid(grd_order(5, 0).Value, 2)
            Dim orderDate As String = grd_order(6, 0).Value
            Dim orderSql As String = "INSERT INTO TBL_ORDERS_GA03842 VALUES('" & orderID & "' , '" & orderDate & "' , '" & customerID & "', '" & staffID & "')"
            Dim mywriter1 As New OleDb.OleDbCommand(orderSql, myconnection2, mytransaction)
            mywriter1.ExecuteNonQuery()

            For i As Integer = 0 To grd_order.RowCount - 1
                orderID = grd_order(0, i).Value
                customerID = grd_order(1, i).Value
                staffID = grd_order(2, i).Value
                productID = grd_order(3, i).Value
                quantity = grd_order(4, i).Value
                subTotal = Mid(grd_order(5, i).Value, 2)
                orderDate = grd_order(6, i).Value

                Dim orderDetailSql As String = "INSERT INTO TBL_INVOICE_GA03842 VALUES('" & productID & "' ,'" & orderID & "', " & quantity & ")"
                Dim mywriter2 As New OleDb.OleDbCommand(orderDetailSql, myconnection2, mytransaction)

                mywriter2.ExecuteNonQuery()
            Next

            mytransaction.Commit()
            myconnection2.Close()

            Beep()
            MsgBox("Order Successful!")
            ResetForm()

        Catch ex As Exception
            Beep()
            MsgBox("Error occured during transaction:" & vbCrLf & ex.Message)
            mytransaction.Rollback()
            myconnection2.Close()
            ResetForm()
        End Try
    End Sub

    Private Sub btn_add_to_cart_Click(sender As Object, e As EventArgs) Handles btn_add_to_cart.Click
        Dim qty As Double = txt_quantity.Text
        Dim pri As Double = price

        myOrderDataTable.Rows.Add()
        myOrderDataTable.Rows(row).Item(0) = txt_order_id.Text
        myOrderDataTable.Rows(row).Item(1) = cbb_customer_id.SelectedItem.ToString
        myOrderDataTable.Rows(row).Item(2) = cbb_staff_id.SelectedItem.ToString
        myOrderDataTable.Rows(row).Item(3) = productID
        myOrderDataTable.Rows(row).Item(4) = txt_quantity.Text
        myOrderDataTable.Rows(row).Item(5) = "RM" & (qty * pri).ToString
        myOrderDataTable.Rows(row).Item(6) = "" & Today.Month & "/" & Today.Day & "/" & Today.Year & ""
        total = total + (qty * price)
        lbl_total.Text = "RM" & total.ToString

        grd_order.DataSource = myOrderDataTable
        row = row + 1

        txt_order_id.Enabled = False
        cbb_customer_id.Enabled = False
        cbb_staff_id.Enabled = False
    End Sub

    Private Sub btn_view_order_Click(sender As Object, e As EventArgs) Handles btn_view_order.Click
        Me.Close()
        frm_mainmenu_ga03842.Hide()
        frm_vieworderdetails_ga03842.Show()
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub pb_product_display_Click(sender As Object, e As EventArgs) Handles pb_product_display.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub lst_products_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lst_products.SelectedIndexChanged

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub lbl_staff_name_Click(sender As Object, e As EventArgs) Handles lbl_staff_name.Click

    End Sub

    Private Sub lbl_customer_name_Click(sender As Object, e As EventArgs) Handles lbl_customer_name.Click

    End Sub

    Private Sub txt_order_id_TextChanged(sender As Object, e As EventArgs) Handles txt_order_id.TextChanged

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub txt_quantity_TextChanged(sender As Object, e As EventArgs) Handles txt_quantity.TextChanged

    End Sub

    Private Sub lbl_price_Click(sender As Object, e As EventArgs) Handles lbl_price.Click

    End Sub

    Private Sub lbl_name_Click(sender As Object, e As EventArgs) Handles lbl_name.Click

    End Sub

    Private Sub grd_order_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_order.CellContentClick

    End Sub

    Private Sub lbl_total_Click(sender As Object, e As EventArgs) Handles lbl_total.Click

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Me.Hide()
        frm_allorders_ga03842.Show()

    End Sub

    Private Sub grd_makeorders_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class