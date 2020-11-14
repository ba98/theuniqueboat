Public Class frm_mainmenu_ga03842

    Private Sub btn_products_Click(sender As Object, e As EventArgs) Handles btn_products.Click
        Me.Hide()
        frm_allproducts_ga03842.Show()

    End Sub

    Private Sub btn_staff_Click(sender As Object, e As EventArgs) Handles btn_staff.Click
        Me.Hide()
        frm_allstaff_ga03842.Show()

    End Sub

    Private Sub btn_customers_Click(sender As Object, e As EventArgs) Handles btn_customers.Click
        Me.Hide()
        frm_allcustomers_ga03842.Show()

    End Sub

    Private Sub btn_orders_Click(sender As Object, e As EventArgs) Handles btn_orders.Click
        Me.Hide()
        frm_allorders_ga03842.Show()

    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click

        Dim result = MessageBox.Show("Are you sure you want to terminate the program?", "Are you sure!", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Application.Exit()
        End If

    End Sub

    Private Sub frm_mainmenu_ga03842_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Hide()
        frm_allproducts_ga03842.Show()

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Hide()
        frm_allstaff_ga03842.Show()

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.Hide()
        frm_allcustomers_ga03842.Show()

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Me.Hide()
        frm_allorders_ga03842.Show()

    End Sub
End Class