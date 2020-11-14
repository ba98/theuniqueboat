Public Class frm_updatestaff_ga03842

    Dim current_id As String
    Private Sub frm_updatestaff_ga03842_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        refresh_grid()
        get_current_id()
    End Sub

    Private Sub refresh_grid()

        Dim mysql As String = "SELECT * FROM TBL_STAFF_GA03842"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        grd_staff.DataSource = mydatatable

    End Sub
    Private Sub clear_fields()

        txt_id.Text = ""
        txt_name.Text = ""
        txt_phoneno.Text = ""
        txt_address.Text = ""

    End Sub

    Private Sub get_current_id()

        Dim current_row As Integer = grd_staff.CurrentRow.Index
        current_id = grd_staff(0, current_row).Value

        txt_id.Text = current_id
        txt_name.Text = grd_staff(1, current_row).Value
        txt_phoneno.Text = grd_staff(2, current_row).Value
        txt_address.Text = grd_staff(3, current_row).Value

    End Sub

    Private Sub grd_courses_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_staff.CellClick
        get_current_id()
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        run_sql_command("UPDATE TBL_STAFF_GA03842 SET FLD_STAFF_NAME='" & txt_name.Text & "' WHERE FLD_STAFF_ID='" & current_id & "'")
        run_sql_command("UPDATE TBL_STAFF_GA03842 SET FLD_STAFF_PHONE=" & txt_phoneno.Text & " WHERE FLD_STAFF_ID='" & current_id & "'")
        run_sql_command("UPDATE TBL_STAFF_GA03842 SET FLD_STAFF_ADDRESS='" & txt_address.Text & "' WHERE FLD_STAFF_ID='" & current_id & "'")

        Beep()
        MsgBox("You have successfully updated the staff """ & current_id & """.")

        refresh_grid()
        clear_fields()
        get_current_id()

    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click

        Dim delete_confirmation = MsgBox("Are you sure you would like to delete the staff """ & current_id & """?", MsgBoxStyle.YesNo)
        If delete_confirmation = MsgBoxResult.Yes Then
            run_sql_command("DELETE FROM TBL_STAFF_GA03842 WHERE FLD_STAFF_ID='" & current_id & "'")

            Beep()
            MsgBox("The staff """ & current_id & """ has been successfully deleted.")

            refresh_grid()
            clear_fields()
            get_current_id()



        End If

    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Me.Hide()
        frm_allstaff_ga03842.Show()
    End Sub
End Class