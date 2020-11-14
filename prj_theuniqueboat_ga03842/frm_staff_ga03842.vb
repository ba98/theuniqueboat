Public Class frm_staff_ga03842
    Private Sub frm_staff_ga03842_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim mysql As String = "SELECT * FROM TBL_STAFF_GA03842"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        grd_staff.DataSource = mydatatable

    End Sub

    Private Sub grd_staff_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_staff.CellContentClick

    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Me.Hide()
        frm_allstaff_ga03842.Show()
    End Sub
End Class