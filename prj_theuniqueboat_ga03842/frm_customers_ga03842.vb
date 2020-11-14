Public Class frm_customers_ga03842
    Private Sub frm_customers_ga03842_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim mysql As String = "SELECT * FROM TBL_CUSTOMER_GA03842"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        grd_customers.DataSource = mydatatable
    End Sub

    Private Sub grd_customers_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_customers.CellContentClick

    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Me.Hide()
        frm_allcustomers_ga03842.Show()
    End Sub
End Class