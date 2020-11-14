Public Class frm_welcome_ga03842
    Private Sub welcome_timer_Tick(sender As Object, e As EventArgs) Handles welcome_timer.Tick

        welcome_progress_bar.Value += 2
        If welcome_progress_bar.Value = 100 Then
            welcome_timer.Enabled = False
            Me.Hide()
            frm_mainmenu_ga03842.Show()
        End If

    End Sub

    Private Sub frm_welcome_ga03842_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class