<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_insertproducts_ga03842
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btn_picture = New System.Windows.Forms.Button()
        Me.pic_product = New System.Windows.Forms.PictureBox()
        Me.txt_picture = New System.Windows.Forms.TextBox()
        Me.btn_insert = New System.Windows.Forms.Button()
        Me.txt_price = New System.Windows.Forms.TextBox()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.grd_products = New System.Windows.Forms.DataGridView()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.txt_warranty = New System.Windows.Forms.TextBox()
        Me.txt_brand = New System.Windows.Forms.TextBox()
        Me.txt_type = New System.Windows.Forms.TextBox()
        Me.txt_description = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btn_exit = New System.Windows.Forms.Button()
        CType(Me.pic_product, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd_products, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_picture
        '
        Me.btn_picture.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_picture.Location = New System.Drawing.Point(673, 417)
        Me.btn_picture.Name = "btn_picture"
        Me.btn_picture.Size = New System.Drawing.Size(100, 23)
        Me.btn_picture.TabIndex = 17
        Me.btn_picture.Text = "Select a picture"
        Me.btn_picture.UseVisualStyleBackColor = True
        '
        'pic_product
        '
        Me.pic_product.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pic_product.Location = New System.Drawing.Point(673, 313)
        Me.pic_product.Name = "pic_product"
        Me.pic_product.Size = New System.Drawing.Size(100, 94)
        Me.pic_product.TabIndex = 16
        Me.pic_product.TabStop = False
        '
        'txt_picture
        '
        Me.txt_picture.Location = New System.Drawing.Point(673, 287)
        Me.txt_picture.Name = "txt_picture"
        Me.txt_picture.Size = New System.Drawing.Size(100, 20)
        Me.txt_picture.TabIndex = 15
        '
        'btn_insert
        '
        Me.btn_insert.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_insert.Location = New System.Drawing.Point(364, 422)
        Me.btn_insert.Name = "btn_insert"
        Me.btn_insert.Size = New System.Drawing.Size(75, 23)
        Me.btn_insert.TabIndex = 14
        Me.btn_insert.Text = "INSERT"
        Me.btn_insert.UseVisualStyleBackColor = True
        '
        'txt_price
        '
        Me.txt_price.Location = New System.Drawing.Point(12, 320)
        Me.txt_price.Name = "txt_price"
        Me.txt_price.Size = New System.Drawing.Size(100, 20)
        Me.txt_price.TabIndex = 13
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(12, 294)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(100, 20)
        Me.txt_name.TabIndex = 12
        '
        'txt_id
        '
        Me.txt_id.Location = New System.Drawing.Point(12, 268)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.ReadOnly = True
        Me.txt_id.Size = New System.Drawing.Size(100, 20)
        Me.txt_id.TabIndex = 11
        '
        'grd_products
        '
        Me.grd_products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_products.Location = New System.Drawing.Point(12, 44)
        Me.grd_products.Name = "grd_products"
        Me.grd_products.ReadOnly = True
        Me.grd_products.Size = New System.Drawing.Size(761, 218)
        Me.grd_products.TabIndex = 10
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.Location = New System.Drawing.Point(274, 9)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(244, 32)
        Me.lbl_title.TabIndex = 9
        Me.lbl_title.Text = "Add New Products"
        Me.lbl_title.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'txt_warranty
        '
        Me.txt_warranty.Location = New System.Drawing.Point(12, 398)
        Me.txt_warranty.Name = "txt_warranty"
        Me.txt_warranty.Size = New System.Drawing.Size(100, 20)
        Me.txt_warranty.TabIndex = 18
        '
        'txt_brand
        '
        Me.txt_brand.Location = New System.Drawing.Point(12, 372)
        Me.txt_brand.Name = "txt_brand"
        Me.txt_brand.Size = New System.Drawing.Size(100, 20)
        Me.txt_brand.TabIndex = 19
        '
        'txt_type
        '
        Me.txt_type.Location = New System.Drawing.Point(12, 346)
        Me.txt_type.Name = "txt_type"
        Me.txt_type.Size = New System.Drawing.Size(100, 20)
        Me.txt_type.TabIndex = 20
        '
        'txt_description
        '
        Me.txt_description.Location = New System.Drawing.Point(12, 424)
        Me.txt_description.Name = "txt_description"
        Me.txt_description.Size = New System.Drawing.Size(244, 20)
        Me.txt_description.TabIndex = 21
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(118, 273)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Product ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(118, 299)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Product name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(118, 325)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Price"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(118, 351)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Type"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(118, 377)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Brand"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(118, 403)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 13)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Warranty"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(262, 427)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 13)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "Description "
        '
        'btn_exit
        '
        Me.btn_exit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_exit.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_exit.Location = New System.Drawing.Point(513, 421)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(75, 23)
        Me.btn_exit.TabIndex = 52
        Me.btn_exit.Text = "Exit"
        Me.btn_exit.UseVisualStyleBackColor = True
        '
        'frm_insertproducts_ga03842
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(785, 448)
        Me.Controls.Add(Me.btn_exit)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_description)
        Me.Controls.Add(Me.txt_type)
        Me.Controls.Add(Me.txt_brand)
        Me.Controls.Add(Me.txt_warranty)
        Me.Controls.Add(Me.btn_picture)
        Me.Controls.Add(Me.pic_product)
        Me.Controls.Add(Me.txt_picture)
        Me.Controls.Add(Me.btn_insert)
        Me.Controls.Add(Me.txt_price)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.txt_id)
        Me.Controls.Add(Me.grd_products)
        Me.Controls.Add(Me.lbl_title)
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_insertproducts_ga03842"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add new products"
        CType(Me.pic_product, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd_products, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_picture As Button
    Friend WithEvents pic_product As PictureBox
    Friend WithEvents txt_picture As TextBox
    Friend WithEvents btn_insert As Button
    Friend WithEvents txt_price As TextBox
    Friend WithEvents txt_name As TextBox
    Friend WithEvents txt_id As TextBox
    Friend WithEvents grd_products As DataGridView
    Friend WithEvents lbl_title As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents txt_warranty As TextBox
    Friend WithEvents txt_brand As TextBox
    Friend WithEvents txt_type As TextBox
    Friend WithEvents txt_description As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btn_exit As Button
End Class
