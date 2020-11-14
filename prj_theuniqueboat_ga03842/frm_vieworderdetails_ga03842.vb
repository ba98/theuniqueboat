Public Class frm_vieworderdetails_ga03842

    Dim myViewOrderTable As New DataTable
    Dim myOrderTable As New DataTable
    Dim myProductTable As DataTable
    Dim orderID As String
    Dim customerID As String
    Dim staffID As String
    Dim productID As String
    Dim subTotal As Double = 0.0

    Private Sub frm_vieworderdetails_ga03842_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()

        myViewOrderTable.Columns.Add("ProductID")
        myViewOrderTable.Columns.Add("ProductName")
        myViewOrderTable.Columns.Add("Price")
        myViewOrderTable.Columns.Add("Quantity")
        myViewOrderTable.Columns.Add("Amount")

        myOrderTable = run_sql_query("SELECT DISTINCT FLD_ORDER_ID FROM TBL_INVOICE_GA03842")
        If myOrderTable.Rows.Count > 0 Then
            With cbb_order_id
                .Items.Clear()
                For i As Integer = 0 To myOrderTable.Rows.Count - 1
                    .Items.Add(myOrderTable.Rows(i).Item(0))
                Next
                .SelectedIndex = 0
            End With
        End If

        myViewOrderTable.Rows.Clear()
        ResetViewOrderForm()
    End Sub

    Private Sub ResetViewOrderForm()
        orderID = cbb_order_id.SelectedItem.ToString()
        myProductTable = run_sql_query("SELECT FLD_PRODUCT_ID FROM TBL_INVOICE_GA03842 WHERE FLD_ORDER_ID='" & orderID & "'")

        CalculateAndDisplay()
        grd_orderdetail.DataSource = myViewOrderTable
        grd_orderdetail.Columns(0).HeaderText = "ID"
        grd_orderdetail.Columns(1).HeaderText = "Product Name"
        grd_orderdetail.Columns(2).HeaderText = "Price"
        grd_orderdetail.Columns(3).HeaderText = "Quantity"
        grd_orderdetail.Columns(4).HeaderText = "Amount"

        customerID = (run_sql_query("SELECT FLD_CUSTOMER_ID FROM TBL_ORDERS_GA03842 WHERE FLD_ORDER_ID='" & orderID & "'")).Rows(0).Item(0).ToString
        lbl_customer_id.Text = ": " & customerID
        lbl_customer_name.Text = ": " & (run_sql_query("SELECT FLD_CUSTOMER_NAME FROM TBL_CUSTOMER_GA03842 WHERE FLD_CUSTOMER_ID='" & customerID & "'")).Rows(0).Item(0).ToString

        staffID = (run_sql_query("SELECT FLD_STAFF_ID FROM TBL_ORDERS_GA03842 WHERE FLD_ORDER_ID='" & orderID & "'")).Rows(0).Item(0).ToString
        lbl_staff_id.Text = ": " & staffID
        lbl_staff_name.Text = ": " & (run_sql_query("SELECT FLD_STAFF_NAME FROM TBL_STAFF_GA03842 WHERE FLD_STAFF_ID='" & staffID & "'")).Rows(0).Item(0).ToString

        lbl_order_date.Text = Mid((run_sql_query("SELECT FLD_ORDER_DATE FROM TBL_ORDERS_GA03842 WHERE FLD_ORDER_ID='" & orderID & "'")).Rows(0).Item(0).ToString, 1, 10)
    End Sub

    Private Sub cbb_order_id_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbb_order_id.SelectedIndexChanged
        myViewOrderTable.Rows.Clear()
        ResetViewOrderForm()
    End Sub

    Private Sub CalculateAndDisplay()
        If myProductTable.Rows.Count > 0 Then
            subTotal = 0.0
            Dim qty As Double = 0.0
            Dim pri As Double = 0.0
            Dim amt As Double = 0.0

            For i As Integer = 0 To myProductTable.Rows.Count - 1
                productID = myProductTable.Rows(i).Item(0).ToString
                Dim productName As String = run_sql_query("SELECT FLD_PRODUCT_NAME FROM TBL_PRODUCT_GA03842 WHERE FLD_PRODUCT_ID='" & productID & "'").Rows(0).Item(0).ToString
                Dim price As String = run_sql_query("SELECT FLD_PRICE FROM TBL_PRODUCT_GA03842 WHERE FLD_PRODUCT_ID='" & productID & "'").Rows(0).Item(0).ToString
                Dim quantity As String = run_sql_query("SELECT FLD_QUANTITY FROM TBL_INVOICE_GA03842 WHERE FLD_PRODUCT_ID='" & productID & "'").Rows(0).Item(0).ToString
                Dim unit As String = run_sql_query("SELECT FLD_TYPE FROM TBL_PRODUCT_GA03842 WHERE FLD_PRODUCT_ID='" & productID & "'").Rows(0).Item(0).ToString
                pri = Integer.Parse(price)
                qty = Integer.Parse(quantity)
                amt = pri * qty
                subTotal = subTotal + amt

                Dim amount As String = amt.ToString

                myViewOrderTable.Rows.Add()
                myViewOrderTable.Rows(i).Item(0) = productID
                myViewOrderTable.Rows(i).Item(1) = productName
                myViewOrderTable.Rows(i).Item(2) = "RM" & price
                myViewOrderTable.Rows(i).Item(3) = quantity & "  " & unit & "(s)"
                myViewOrderTable.Rows(i).Item(4) = "RM" & amount
            Next

            lbl_sub_total.Text = "RM" & subTotal.ToString
            lbl_total.Text = "RM" & (subTotal * 1.06).ToString
        End If
    End Sub

    Private Sub btn_make_order_Click(sender As Object, e As EventArgs) Handles btn_make_order.Click
        Me.Close()
        frm_mainmenu_ga03842.Hide()
        frm_makeorders_ga03842.Show()
    End Sub
    Private Sub lbl_staff_name_Click(sender As Object, e As EventArgs) Handles lbl_staff_name.Click

    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Me.Hide()
        frm_allorders_ga03842.Show()

    End Sub
End Class