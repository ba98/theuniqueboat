Public Class frm_insertproducts_ga03842

    Dim defaultpicture As String = Application.StartupPath & "\pictures\nophoto.png"

    Private Sub frm_insertproducts_ga03842_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grd_products.DataSource = run_sql_query("SELECT * FROM TBL_PRODUCT_GA03842")

        txt_id.Text = generate_id()

        txt_picture.Text = defaultpicture
        pic_product.BackgroundImage = Image.FromFile(defaultpicture)
    End Sub

    Private Function generate_id() As String
        Dim lastid As String = run_sql_query("SELECT MAX(FLD_PRODUCT_ID) AS LASTID FROM TBL_PRODUCT_GA03842").Rows(0).Item("LASTID")
        Dim newid As String = "P" & Mid(lastid, 2) + 1
        Return newid
    End Function

    Private Sub btn_insert_Click(sender As Object, e As EventArgs) Handles btn_insert.Click

        Dim mysql As String = "INSERT INTO TBL_PRODUCT_GA03842 VALUES ('" & txt_id.Text & "', '" & txt_name.Text & "', " & txt_price.Text & ", '" & txt_type.Text & "', '" & txt_brand.Text & "', '" & txt_warranty.Text & "', '" & txt_description.Text & "')"
        Dim mywriter As New OleDb.OleDbCommand(mysql, myconnection2)
        Try

            mywriter.Connection.Open()
            mywriter.ExecuteNonQuery()
            mywriter.Connection.Close()

            My.Computer.FileSystem.CopyFile(txt_picture.Text, "pictures\" & txt_id.Text & ".jpg")

            grd_products.DataSource = run_sql_query("SELECT * FROM TBL_PRODUCT_GA03842")

            txt_id.Text = generate_id()
            txt_name.Text = ""
            txt_price.Text = ""
            txt_type.Text = ""
            txt_brand.Text = ""
            txt_warranty.Text = ""
            txt_description.Text = ""
            txt_picture.Text = defaultpicture
            pic_product.BackgroundImage = Image.FromFile(defaultpicture)

        Catch ex As Exception
            Beep()
            MsgBox(“There is a mistake in the data inserted, as shown below” & vbCrLf & vbCrLf & ex.Message)

            mywriter.Connection.Close()

        End Try

    End Sub

    Private Sub btn_picture_Click(sender As Object, e As EventArgs) Handles btn_picture.Click

        Dim mydesktop As String = My.Computer.FileSystem.SpecialDirectories.Desktop

        OpenFileDialog1.InitialDirectory = mydesktop
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.Filter = "JPG files (*.jpg)|*.jpg"
        OpenFileDialog1.ShowDialog()

        pic_product.BackgroundImage = Image.FromFile(OpenFileDialog1.FileName)
        txt_picture.Text = OpenFileDialog1.FileName
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Me.Hide()
        frm_allproducts_ga03842.Show()

    End Sub
End Class