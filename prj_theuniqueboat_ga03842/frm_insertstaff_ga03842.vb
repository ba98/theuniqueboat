Public Class frm_insertstaff_ga03842
    Private Sub frm_insertstaff_ga03842_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refresh_grid()
    End Sub

    Private Sub refresh_grid()

        Dim mysql As String = "SELECT * FROM TBL_STAFF_GA03842"

        txt_id.Text = generate_id()
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        grd_courses.DataSource = mydatatable

    End Sub
    Private Function generate_id() As String
        Dim lastid As String = run_sql_query("SELECT MAX(FLD_STAFF_ID) AS LASTID FROM TBL_STAFF_GA03842").Rows(0).Item("LASTID")
        Dim newid As String = "S" & Mid(lastid, 2) + 1
        Return newid
    End Function

    Private Sub clear_fields()

        txt_id.Text = generate_id()
        txt_name.Text = ""
        txt_phone.Text = ""
        txt_address.Text = ""

    End Sub

    Private Sub btn_insert_Click(sender As Object, e As EventArgs) Handles btn_insert.Click
        Dim mysql As String = "INSERT INTO TBL_STAFF_GA03842 VALUES ('" & txt_id.Text & "', '" & txt_name.Text & "', " & txt_phone.Text & ", '" & txt_address.Text & "')"
        Dim mywriter As New OleDb.OleDbCommand(mysql, myconnection2)
        Try
            mywriter.Connection.Open()
            mywriter.ExecuteNonQuery()
            mywriter.Connection.Close()
            refresh_grid()
            clear_fields()

        Catch ex As Exception

            Beep()
            MsgBox(“There is a mistake in the data inserted, as shown below” & vbCrLf & vbCrLf & ex.Message)
            mywriter.Connection.Close()
        End Try


    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Me.Hide()
        frm_allstaff_ga03842.Show()
    End Sub
End Class