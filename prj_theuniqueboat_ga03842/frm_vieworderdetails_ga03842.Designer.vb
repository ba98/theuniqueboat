<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_vieworderdetails_ga03842
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
        Me.lbl_customer_id = New System.Windows.Forms.Label()
        Me.cbb_order_id = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbl_customer_name = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbl_order_date = New System.Windows.Forms.Label()
        Me.lbl_staff_id = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbl_staff_name = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lbl_total = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbl_sub_total = New System.Windows.Forms.Label()
        Me.grd_orderdetail = New System.Windows.Forms.DataGridView()
        Me.btn_make_order = New System.Windows.Forms.Button()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.lbl_title2 = New System.Windows.Forms.Label()
        Me.btn_exit = New System.Windows.Forms.Button()
        CType(Me.grd_orderdetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_customer_id
        '
        Me.lbl_customer_id.AutoSize = True
        Me.lbl_customer_id.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_customer_id.ForeColor = System.Drawing.Color.Black
        Me.lbl_customer_id.Location = New System.Drawing.Point(150, 139)
        Me.lbl_customer_id.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lbl_customer_id.Name = "lbl_customer_id"
        Me.lbl_customer_id.Size = New System.Drawing.Size(95, 19)
        Me.lbl_customer_id.TabIndex = 29
        Me.lbl_customer_id.Text = ": Customer ID"
        '
        'cbb_order_id
        '
        Me.cbb_order_id.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbb_order_id.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbb_order_id.FormattingEnabled = True
        Me.cbb_order_id.Location = New System.Drawing.Point(153, 73)
        Me.cbb_order_id.Margin = New System.Windows.Forms.Padding(5)
        Me.cbb_order_id.Name = "cbb_order_id"
        Me.cbb_order_id.Size = New System.Drawing.Size(132, 21)
        Me.cbb_order_id.TabIndex = 28
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(14, 167)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 19)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Customer Name"
        '
        'lbl_customer_name
        '
        Me.lbl_customer_name.AutoSize = True
        Me.lbl_customer_name.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_customer_name.ForeColor = System.Drawing.Color.Black
        Me.lbl_customer_name.Location = New System.Drawing.Point(150, 167)
        Me.lbl_customer_name.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lbl_customer_name.Name = "lbl_customer_name"
        Me.lbl_customer_name.Size = New System.Drawing.Size(116, 19)
        Me.lbl_customer_name.TabIndex = 26
        Me.lbl_customer_name.Text = ": Customer Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(14, 139)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 19)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Customer ID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(14, 73)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 19)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Order ID"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(558, 75)
        Me.Label6.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(111, 19)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "Date of Issued - "
        '
        'lbl_order_date
        '
        Me.lbl_order_date.AutoSize = True
        Me.lbl_order_date.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_order_date.ForeColor = System.Drawing.Color.Black
        Me.lbl_order_date.Location = New System.Drawing.Point(671, 75)
        Me.lbl_order_date.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lbl_order_date.Name = "lbl_order_date"
        Me.lbl_order_date.Size = New System.Drawing.Size(83, 19)
        Me.lbl_order_date.TabIndex = 34
        Me.lbl_order_date.Text = "mm/dd/yyyy"
        '
        'lbl_staff_id
        '
        Me.lbl_staff_id.AutoSize = True
        Me.lbl_staff_id.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_staff_id.ForeColor = System.Drawing.Color.Black
        Me.lbl_staff_id.Location = New System.Drawing.Point(672, 141)
        Me.lbl_staff_id.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lbl_staff_id.Name = "lbl_staff_id"
        Me.lbl_staff_id.Size = New System.Drawing.Size(64, 19)
        Me.lbl_staff_id.TabIndex = 33
        Me.lbl_staff_id.Text = ": Staff ID"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(558, 169)
        Me.Label5.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 19)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Staff Name"
        '
        'lbl_staff_name
        '
        Me.lbl_staff_name.AutoSize = True
        Me.lbl_staff_name.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_staff_name.ForeColor = System.Drawing.Color.Black
        Me.lbl_staff_name.Location = New System.Drawing.Point(672, 169)
        Me.lbl_staff_name.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lbl_staff_name.Name = "lbl_staff_name"
        Me.lbl_staff_name.Size = New System.Drawing.Size(85, 19)
        Me.lbl_staff_name.TabIndex = 31
        Me.lbl_staff_name.Text = ": Staff Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(558, 141)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 19)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Staff ID"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(582, 420)
        Me.Label10.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(39, 19)
        Me.Label10.TabIndex = 42
        Me.Label10.Text = "Total"
        '
        'lbl_total
        '
        Me.lbl_total.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_total.ForeColor = System.Drawing.Color.Black
        Me.lbl_total.Location = New System.Drawing.Point(671, 420)
        Me.lbl_total.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lbl_total.Name = "lbl_total"
        Me.lbl_total.Size = New System.Drawing.Size(96, 18)
        Me.lbl_total.TabIndex = 41
        Me.lbl_total.Text = "RM0.00"
        Me.lbl_total.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(582, 384)
        Me.Label8.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 19)
        Me.Label8.TabIndex = 40
        Me.Label8.Text = "Tax (SST)"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(741, 384)
        Me.Label9.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(30, 19)
        Me.Label9.TabIndex = 39
        Me.Label9.Text = "6%"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(582, 348)
        Me.Label7.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 19)
        Me.Label7.TabIndex = 38
        Me.Label7.Text = "Sub Total"
        '
        'lbl_sub_total
        '
        Me.lbl_sub_total.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_sub_total.ForeColor = System.Drawing.Color.Black
        Me.lbl_sub_total.Location = New System.Drawing.Point(674, 348)
        Me.lbl_sub_total.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lbl_sub_total.Name = "lbl_sub_total"
        Me.lbl_sub_total.Size = New System.Drawing.Size(93, 18)
        Me.lbl_sub_total.TabIndex = 37
        Me.lbl_sub_total.Text = "RM0.00"
        Me.lbl_sub_total.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'grd_orderdetail
        '
        Me.grd_orderdetail.AllowUserToAddRows = False
        Me.grd_orderdetail.AllowUserToResizeRows = False
        Me.grd_orderdetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grd_orderdetail.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.grd_orderdetail.Location = New System.Drawing.Point(18, 189)
        Me.grd_orderdetail.Name = "grd_orderdetail"
        Me.grd_orderdetail.ReadOnly = True
        Me.grd_orderdetail.Size = New System.Drawing.Size(555, 150)
        Me.grd_orderdetail.TabIndex = 36
        '
        'btn_make_order
        '
        Me.btn_make_order.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_make_order.BackColor = System.Drawing.Color.LightGray
        Me.btn_make_order.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_make_order.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_make_order.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_make_order.FlatAppearance.BorderSize = 0
        Me.btn_make_order.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn_make_order.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn_make_order.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_make_order.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_make_order.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_make_order.Location = New System.Drawing.Point(18, 413)
        Me.btn_make_order.Name = "btn_make_order"
        Me.btn_make_order.Size = New System.Drawing.Size(111, 23)
        Me.btn_make_order.TabIndex = 43
        Me.btn_make_order.Text = "Make an order"
        Me.btn_make_order.UseVisualStyleBackColor = False
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.Font = New System.Drawing.Font("Cooper Black", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.Location = New System.Drawing.Point(285, 9)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(210, 27)
        Me.lbl_title.TabIndex = 44
        Me.lbl_title.Text = "The unique boat"
        '
        'lbl_title2
        '
        Me.lbl_title2.AutoSize = True
        Me.lbl_title2.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title2.Location = New System.Drawing.Point(13, 9)
        Me.lbl_title2.Name = "lbl_title2"
        Me.lbl_title2.Size = New System.Drawing.Size(160, 19)
        Me.lbl_title2.TabIndex = 45
        Me.lbl_title2.Text = "View order details"
        '
        'btn_exit
        '
        Me.btn_exit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_exit.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_exit.Location = New System.Drawing.Point(343, 413)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(75, 23)
        Me.btn_exit.TabIndex = 54
        Me.btn_exit.Text = "Exit"
        Me.btn_exit.UseVisualStyleBackColor = True
        '
        'frm_vieworderdetails_ga03842
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(785, 448)
        Me.Controls.Add(Me.btn_exit)
        Me.Controls.Add(Me.lbl_title2)
        Me.Controls.Add(Me.lbl_title)
        Me.Controls.Add(Me.btn_make_order)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lbl_total)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lbl_sub_total)
        Me.Controls.Add(Me.grd_orderdetail)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lbl_order_date)
        Me.Controls.Add(Me.lbl_staff_id)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lbl_staff_name)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbl_customer_id)
        Me.Controls.Add(Me.cbb_order_id)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lbl_customer_name)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frm_vieworderdetails_ga03842"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "View order details"
        CType(Me.grd_orderdetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_customer_id As Label
    Friend WithEvents cbb_order_id As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lbl_customer_name As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lbl_order_date As Label
    Friend WithEvents lbl_staff_id As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lbl_staff_name As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lbl_total As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lbl_sub_total As Label
    Friend WithEvents grd_orderdetail As DataGridView
    Friend WithEvents btn_make_order As Button
    Friend WithEvents lbl_title As Label
    Friend WithEvents lbl_title2 As Label
    Friend WithEvents btn_exit As Button
End Class
