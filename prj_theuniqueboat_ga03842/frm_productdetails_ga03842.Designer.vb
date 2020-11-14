<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_productdetails_ga03842
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
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.lst_products = New System.Windows.Forms.ListBox()
        Me.pic_product = New System.Windows.Forms.PictureBox()
        Me.txt_price = New System.Windows.Forms.TextBox()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.txt_type = New System.Windows.Forms.TextBox()
        Me.txt_brand = New System.Windows.Forms.TextBox()
        Me.txt_description = New System.Windows.Forms.TextBox()
        Me.txt_warranty = New System.Windows.Forms.TextBox()
        Me.lbl_product_id = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btn_exit = New System.Windows.Forms.Button()
        CType(Me.pic_product, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.Location = New System.Drawing.Point(296, 9)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(183, 33)
        Me.lbl_title.TabIndex = 0
        Me.lbl_title.Text = "Product details"
        '
        'lst_products
        '
        Me.lst_products.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lst_products.FormattingEnabled = True
        Me.lst_products.Location = New System.Drawing.Point(668, 81)
        Me.lst_products.Name = "lst_products"
        Me.lst_products.Size = New System.Drawing.Size(105, 316)
        Me.lst_products.TabIndex = 2
        '
        'pic_product
        '
        Me.pic_product.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pic_product.Location = New System.Drawing.Point(259, 79)
        Me.pic_product.Name = "pic_product"
        Me.pic_product.Size = New System.Drawing.Size(253, 291)
        Me.pic_product.TabIndex = 6
        Me.pic_product.TabStop = False
        '
        'txt_price
        '
        Me.txt_price.Location = New System.Drawing.Point(12, 189)
        Me.txt_price.Name = "txt_price"
        Me.txt_price.Size = New System.Drawing.Size(100, 20)
        Me.txt_price.TabIndex = 9
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(12, 134)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(100, 20)
        Me.txt_name.TabIndex = 8
        '
        'txt_id
        '
        Me.txt_id.Location = New System.Drawing.Point(12, 79)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(100, 20)
        Me.txt_id.TabIndex = 7
        '
        'txt_type
        '
        Me.txt_type.Location = New System.Drawing.Point(12, 244)
        Me.txt_type.Name = "txt_type"
        Me.txt_type.Size = New System.Drawing.Size(100, 20)
        Me.txt_type.TabIndex = 10
        '
        'txt_brand
        '
        Me.txt_brand.Location = New System.Drawing.Point(12, 301)
        Me.txt_brand.Name = "txt_brand"
        Me.txt_brand.Size = New System.Drawing.Size(100, 20)
        Me.txt_brand.TabIndex = 11
        '
        'txt_description
        '
        Me.txt_description.Location = New System.Drawing.Point(12, 407)
        Me.txt_description.Name = "txt_description"
        Me.txt_description.Size = New System.Drawing.Size(761, 20)
        Me.txt_description.TabIndex = 12
        '
        'txt_warranty
        '
        Me.txt_warranty.Location = New System.Drawing.Point(12, 350)
        Me.txt_warranty.Name = "txt_warranty"
        Me.txt_warranty.Size = New System.Drawing.Size(100, 20)
        Me.txt_warranty.TabIndex = 13
        '
        'lbl_product_id
        '
        Me.lbl_product_id.AutoSize = True
        Me.lbl_product_id.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_product_id.Location = New System.Drawing.Point(12, 57)
        Me.lbl_product_id.Name = "lbl_product_id"
        Me.lbl_product_id.Size = New System.Drawing.Size(77, 19)
        Me.lbl_product_id.TabIndex = 14
        Me.lbl_product_id.Text = "Product ID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 385)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 19)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Description"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 328)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 19)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Warranty"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 279)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 19)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Product brand"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 222)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 19)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Product type"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 167)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 19)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Product price"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 112)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 19)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Product name"
        '
        'btn_exit
        '
        Me.btn_exit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_exit.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_exit.Location = New System.Drawing.Point(352, 378)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(75, 23)
        Me.btn_exit.TabIndex = 21
        Me.btn_exit.Text = "Exit"
        Me.btn_exit.UseVisualStyleBackColor = True
        '
        'frm_productdetails_ga03842
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(785, 448)
        Me.Controls.Add(Me.btn_exit)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_product_id)
        Me.Controls.Add(Me.txt_warranty)
        Me.Controls.Add(Me.txt_description)
        Me.Controls.Add(Me.txt_brand)
        Me.Controls.Add(Me.txt_type)
        Me.Controls.Add(Me.txt_price)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.txt_id)
        Me.Controls.Add(Me.pic_product)
        Me.Controls.Add(Me.lst_products)
        Me.Controls.Add(Me.lbl_title)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_productdetails_ga03842"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Product details"
        CType(Me.pic_product, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_title As Label
    Friend WithEvents lst_products As ListBox
    Friend WithEvents pic_product As PictureBox
    Friend WithEvents txt_price As TextBox
    Friend WithEvents txt_name As TextBox
    Friend WithEvents txt_id As TextBox
    Friend WithEvents txt_type As TextBox
    Friend WithEvents txt_brand As TextBox
    Friend WithEvents txt_description As TextBox
    Friend WithEvents txt_warranty As TextBox
    Friend WithEvents lbl_product_id As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btn_exit As Button
End Class
