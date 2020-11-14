<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_makeorders_ga03842
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbl_staff_name = New System.Windows.Forms.Label()
        Me.lbl_customer_name = New System.Windows.Forms.Label()
        Me.cbb_staff_id = New System.Windows.Forms.ComboBox()
        Me.cbb_customer_id = New System.Windows.Forms.ComboBox()
        Me.txt_order_id = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lst_products = New System.Windows.Forms.ListBox()
        Me.grd_order = New System.Windows.Forms.DataGridView()
        Me.txt_quantity = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.pb_product_display = New System.Windows.Forms.PictureBox()
        Me.lbl_price = New System.Windows.Forms.Label()
        Me.lbl_name = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lbl_total = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btn_add_to_cart = New System.Windows.Forms.Button()
        Me.btn_order = New System.Windows.Forms.Button()
        Me.btn_view_order = New System.Windows.Forms.Button()
        CType(Me.grd_order, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_product_display, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.Location = New System.Drawing.Point(418, 9)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(157, 33)
        Me.lbl_title.TabIndex = 1
        Me.lbl_title.Text = "Make orders"
        '
        'btn_exit
        '
        Me.btn_exit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_exit.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_exit.Location = New System.Drawing.Point(753, 526)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(75, 23)
        Me.btn_exit.TabIndex = 53
        Me.btn_exit.Text = "Exit"
        Me.btn_exit.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(14, 149)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 19)
        Me.Label3.TabIndex = 56
        Me.Label3.Text = "Staff ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(14, 114)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 19)
        Me.Label2.TabIndex = 55
        Me.Label2.Text = "Customer ID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(14, 83)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 19)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "Order ID"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(246, 152)
        Me.Label5.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 19)
        Me.Label5.TabIndex = 63
        Me.Label5.Text = "Staff Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(246, 117)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 19)
        Me.Label4.TabIndex = 62
        Me.Label4.Text = "Customer Name"
        '
        'lbl_staff_name
        '
        Me.lbl_staff_name.AutoSize = True
        Me.lbl_staff_name.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_staff_name.ForeColor = System.Drawing.Color.Black
        Me.lbl_staff_name.Location = New System.Drawing.Point(354, 149)
        Me.lbl_staff_name.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lbl_staff_name.Name = "lbl_staff_name"
        Me.lbl_staff_name.Size = New System.Drawing.Size(85, 19)
        Me.lbl_staff_name.TabIndex = 61
        Me.lbl_staff_name.Text = ": Staff Name"
        '
        'lbl_customer_name
        '
        Me.lbl_customer_name.AutoSize = True
        Me.lbl_customer_name.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_customer_name.ForeColor = System.Drawing.Color.Black
        Me.lbl_customer_name.Location = New System.Drawing.Point(354, 117)
        Me.lbl_customer_name.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lbl_customer_name.Name = "lbl_customer_name"
        Me.lbl_customer_name.Size = New System.Drawing.Size(116, 19)
        Me.lbl_customer_name.TabIndex = 60
        Me.lbl_customer_name.Text = ": Customer Name"
        '
        'cbb_staff_id
        '
        Me.cbb_staff_id.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbb_staff_id.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbb_staff_id.FormattingEnabled = True
        Me.cbb_staff_id.Location = New System.Drawing.Point(103, 149)
        Me.cbb_staff_id.Margin = New System.Windows.Forms.Padding(5)
        Me.cbb_staff_id.Name = "cbb_staff_id"
        Me.cbb_staff_id.Size = New System.Drawing.Size(132, 21)
        Me.cbb_staff_id.TabIndex = 59
        '
        'cbb_customer_id
        '
        Me.cbb_customer_id.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbb_customer_id.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbb_customer_id.FormattingEnabled = True
        Me.cbb_customer_id.Location = New System.Drawing.Point(104, 114)
        Me.cbb_customer_id.Margin = New System.Windows.Forms.Padding(5)
        Me.cbb_customer_id.Name = "cbb_customer_id"
        Me.cbb_customer_id.Size = New System.Drawing.Size(132, 21)
        Me.cbb_customer_id.TabIndex = 58
        '
        'txt_order_id
        '
        Me.txt_order_id.Location = New System.Drawing.Point(104, 83)
        Me.txt_order_id.Margin = New System.Windows.Forms.Padding(5)
        Me.txt_order_id.Name = "txt_order_id"
        Me.txt_order_id.Size = New System.Drawing.Size(132, 20)
        Me.txt_order_id.TabIndex = 57
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(646, 83)
        Me.Label7.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 19)
        Me.Label7.TabIndex = 65
        Me.Label7.Text = "Choose:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lst_products
        '
        Me.lst_products.FormattingEnabled = True
        Me.lst_products.Location = New System.Drawing.Point(706, 83)
        Me.lst_products.Margin = New System.Windows.Forms.Padding(5)
        Me.lst_products.Name = "lst_products"
        Me.lst_products.Size = New System.Drawing.Size(164, 134)
        Me.lst_products.TabIndex = 64
        '
        'grd_order
        '
        Me.grd_order.AllowUserToAddRows = False
        Me.grd_order.AllowUserToDeleteRows = False
        Me.grd_order.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grd_order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_order.Location = New System.Drawing.Point(12, 227)
        Me.grd_order.Name = "grd_order"
        Me.grd_order.Size = New System.Drawing.Size(683, 259)
        Me.grd_order.TabIndex = 66
        '
        'txt_quantity
        '
        Me.txt_quantity.Location = New System.Drawing.Point(772, 287)
        Me.txt_quantity.Margin = New System.Windows.Forms.Padding(5)
        Me.txt_quantity.Name = "txt_quantity"
        Me.txt_quantity.Size = New System.Drawing.Size(64, 20)
        Me.txt_quantity.TabIndex = 73
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(703, 290)
        Me.Label9.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 19)
        Me.Label9.TabIndex = 72
        Me.Label9.Text = "Quantity"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pb_product_display
        '
        Me.pb_product_display.BackColor = System.Drawing.Color.Transparent
        Me.pb_product_display.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pb_product_display.Location = New System.Drawing.Point(706, 323)
        Me.pb_product_display.Name = "pb_product_display"
        Me.pb_product_display.Size = New System.Drawing.Size(150, 150)
        Me.pb_product_display.TabIndex = 71
        Me.pb_product_display.TabStop = False
        '
        'lbl_price
        '
        Me.lbl_price.AutoSize = True
        Me.lbl_price.BackColor = System.Drawing.Color.Transparent
        Me.lbl_price.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_price.ForeColor = System.Drawing.Color.Black
        Me.lbl_price.Location = New System.Drawing.Point(769, 260)
        Me.lbl_price.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lbl_price.Name = "lbl_price"
        Me.lbl_price.Size = New System.Drawing.Size(34, 19)
        Me.lbl_price.TabIndex = 70
        Me.lbl_price.Text = ": ---"
        Me.lbl_price.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_name
        '
        Me.lbl_name.AutoSize = True
        Me.lbl_name.BackColor = System.Drawing.Color.Transparent
        Me.lbl_name.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_name.ForeColor = System.Drawing.Color.Black
        Me.lbl_name.Location = New System.Drawing.Point(769, 227)
        Me.lbl_name.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(34, 19)
        Me.lbl_name.TabIndex = 69
        Me.lbl_name.Text = ": ---"
        Me.lbl_name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(703, 260)
        Me.Label6.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 19)
        Me.Label6.TabIndex = 68
        Me.Label6.Text = "Price"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(703, 227)
        Me.Label8.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 19)
        Me.Label8.TabIndex = 67
        Me.Label8.Text = "Name"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_total
        '
        Me.lbl_total.AutoSize = True
        Me.lbl_total.BackColor = System.Drawing.Color.Transparent
        Me.lbl_total.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_total.ForeColor = System.Drawing.Color.Black
        Me.lbl_total.Location = New System.Drawing.Point(637, 510)
        Me.lbl_total.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lbl_total.Name = "lbl_total"
        Me.lbl_total.Size = New System.Drawing.Size(61, 19)
        Me.lbl_total.TabIndex = 75
        Me.lbl_total.Text = "RM0.00"
        Me.lbl_total.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(574, 510)
        Me.Label10.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(39, 19)
        Me.Label10.TabIndex = 74
        Me.Label10.Text = "Total"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btn_add_to_cart
        '
        Me.btn_add_to_cart.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_add_to_cart.BackColor = System.Drawing.Color.LightGray
        Me.btn_add_to_cart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_add_to_cart.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_add_to_cart.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_add_to_cart.FlatAppearance.BorderSize = 0
        Me.btn_add_to_cart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn_add_to_cart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn_add_to_cart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_add_to_cart.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_add_to_cart.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_add_to_cart.Location = New System.Drawing.Point(732, 479)
        Me.btn_add_to_cart.Name = "btn_add_to_cart"
        Me.btn_add_to_cart.Size = New System.Drawing.Size(104, 23)
        Me.btn_add_to_cart.TabIndex = 76
        Me.btn_add_to_cart.Text = "Add to Cart"
        Me.btn_add_to_cart.UseVisualStyleBackColor = False
        '
        'btn_order
        '
        Me.btn_order.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_order.BackColor = System.Drawing.Color.LightGray
        Me.btn_order.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_order.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_order.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_order.FlatAppearance.BorderSize = 0
        Me.btn_order.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn_order.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn_order.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_order.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_order.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_order.Location = New System.Drawing.Point(12, 501)
        Me.btn_order.Name = "btn_order"
        Me.btn_order.Size = New System.Drawing.Size(59, 27)
        Me.btn_order.TabIndex = 77
        Me.btn_order.Text = "Order"
        Me.btn_order.UseVisualStyleBackColor = False
        '
        'btn_view_order
        '
        Me.btn_view_order.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_view_order.BackColor = System.Drawing.Color.LightGray
        Me.btn_view_order.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_view_order.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_view_order.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_view_order.FlatAppearance.BorderSize = 0
        Me.btn_view_order.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn_view_order.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn_view_order.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_view_order.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_view_order.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_view_order.Location = New System.Drawing.Point(323, 501)
        Me.btn_view_order.Name = "btn_view_order"
        Me.btn_view_order.Size = New System.Drawing.Size(97, 27)
        Me.btn_view_order.TabIndex = 78
        Me.btn_view_order.Text = "View orders"
        Me.btn_view_order.UseVisualStyleBackColor = False
        '
        'frm_makeorders_ga03842
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(946, 561)
        Me.Controls.Add(Me.btn_view_order)
        Me.Controls.Add(Me.btn_order)
        Me.Controls.Add(Me.btn_add_to_cart)
        Me.Controls.Add(Me.lbl_total)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txt_quantity)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.pb_product_display)
        Me.Controls.Add(Me.lbl_price)
        Me.Controls.Add(Me.lbl_name)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.grd_order)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lst_products)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lbl_staff_name)
        Me.Controls.Add(Me.lbl_customer_name)
        Me.Controls.Add(Me.cbb_staff_id)
        Me.Controls.Add(Me.cbb_customer_id)
        Me.Controls.Add(Me.txt_order_id)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_exit)
        Me.Controls.Add(Me.lbl_title)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_makeorders_ga03842"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Make orders"
        CType(Me.grd_order, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_product_display, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents lbl_title As Label
    Friend WithEvents btn_exit As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lbl_staff_name As Label
    Friend WithEvents lbl_customer_name As Label
    Friend WithEvents cbb_staff_id As ComboBox
    Friend WithEvents cbb_customer_id As ComboBox
    Friend WithEvents txt_order_id As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents lst_products As ListBox
    Friend WithEvents grd_order As DataGridView
    Friend WithEvents txt_quantity As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents pb_product_display As PictureBox
    Friend WithEvents lbl_price As Label
    Friend WithEvents lbl_name As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lbl_total As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents btn_add_to_cart As Button
    Friend WithEvents btn_order As Button
    Friend WithEvents btn_view_order As Button
End Class
