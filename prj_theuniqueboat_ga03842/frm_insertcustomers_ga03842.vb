Public Class frm_insertcustomers_ga03842
    Private Sub frm_insertcustomers_ga03842_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refresh_grid()
    End Sub

    Private Sub refresh_grid()

        Dim mysql As String = "SELECT * FROM TBL_CUSTOMER_GA03842"

        txt_id.Text = generate_id()
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        grd_courses.DataSource = mydatatable

    End Sub
    Private Function generate_id() As String
        Dim lastid As String = run_sql_query("SELECT MAX(FLD_CUSTOMER_ID) AS LASTID FROM TBL_CUSTOMER_GA03842").Rows(0).Item("LASTID")
        Dim newid As String = "C" & Mid(lastid, 2) + 1
        Return newid
    End Function

    Private Sub clear_fields()

        txt_id.Text = generate_id()
        txt_name.Text = ""
        txt_phone.Text = ""

    End Sub

    Private Sub btn_insert_Click(sender As Object, e As EventArgs) Handles btn_insert.Click
        Dim mysql As String = "INSERT INTO TBL_CUSTOMER_GA03842 VALUES ('” & txt_id.Text & "', '" & txt_name.Text & "', " & txt_phone.Text & ")"
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

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Me.Hide()
        frm_allcustomers_ga03842.Show()
    End Sub
End Class