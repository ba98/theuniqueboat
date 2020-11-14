Public Class frm_allstaff_ga03842
    Private Sub btn_staff_Click(sender As Object, e As EventArgs) Handles btn_staff.Click
        frm_staff_ga03842.Show()
    End Sub

    Private Sub btn_insertstaff_Click(sender As Object, e As EventArgs) Handles btn_insertstaff.Click
        frm_insertstaff_ga03842.Show()
    End Sub

    Private Sub btn_updatestaff_Click(sender As Object, e As EventArgs) Handles btn_updatestaff.Click
        frm_updatestaff_ga03842.Show()
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Me.Hide()
        frm_mainmenu_ga03842.Show()
    End Sub
End Class