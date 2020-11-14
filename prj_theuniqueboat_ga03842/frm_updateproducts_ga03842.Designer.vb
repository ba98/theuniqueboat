<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_updateproducts_ga03842
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
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.txt_price = New System.Windows.Forms.TextBox()
        Me.txt_type = New System.Windows.Forms.TextBox()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.grd_products = New System.Windows.Forms.DataGridView()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.txt_description = New System.Windows.Forms.TextBox()
        Me.txt_brand = New System.Windows.Forms.TextBox()
        Me.txt_warranty = New System.Windows.Forms.TextBox()
        Me.lbl_description = New System.Windows.Forms.Label()
        Me.lbl_warranty = New System.Windows.Forms.Label()
        Me.lbl_brand = New System.Windows.Forms.Label()
        Me.lbl_type = New System.Windows.Forms.Label()
        Me.lbl_price = New System.Windows.Forms.Label()
        Me.lbl_name = New System.Windows.Forms.Label()
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.btn_exit = New System.Windows.Forms.Button()
        CType(Me.grd_products, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_delete
        '
        Me.btn_delete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_delete.Location = New System.Drawing.Point(412, 414)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(75, 23)
        Me.btn_delete.TabIndex = 15
        Me.btn_delete.Text = "DELETE"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'btn_update
        '
        Me.btn_update.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_update.Location = New System.Drawing.Point(331, 414)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(75, 23)
        Me.btn_update.TabIndex = 14
        Me.btn_update.Text = "UPDATE"
        Me.btn_update.UseVisualStyleBackColor = True
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(12, 286)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(100, 20)
        Me.txt_name.TabIndex = 13
        '
        'txt_price
        '
        Me.txt_price.Location = New System.Drawing.Point(12, 312)
        Me.txt_price.Name = "txt_price"
        Me.txt_price.Size = New System.Drawing.Size(100, 20)
        Me.txt_price.TabIndex = 12
        '
        'txt_type
        '
        Me.txt_type.Location = New System.Drawing.Point(12, 338)
        Me.txt_type.Name = "txt_type"
        Me.txt_type.Size = New System.Drawing.Size(100, 20)
        Me.txt_type.TabIndex = 11
        '
        'txt_id
        '
        Me.txt_id.Location = New System.Drawing.Point(12, 260)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.ReadOnly = True
        Me.txt_id.Size = New System.Drawing.Size(100, 20)
        Me.txt_id.TabIndex = 10
        '
        'grd_products
        '
        Me.grd_products.AllowUserToAddRows = False
        Me.grd_products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_products.Location = New System.Drawing.Point(12, 53)
        Me.grd_products.Name = "grd_products"
        Me.grd_products.ReadOnly = True
        Me.grd_products.Size = New System.Drawing.Size(761, 201)
        Me.grd_products.TabIndex = 9
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.Location = New System.Drawing.Point(295, 9)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(219, 32)
        Me.lbl_title.TabIndex = 8
        Me.lbl_title.Text = "Update products"
        '
        'txt_description
        '
        Me.txt_description.Location = New System.Drawing.Point(12, 416)
        Me.txt_description.Name = "txt_description"
        Me.txt_description.Size = New System.Drawing.Size(244, 20)
        Me.txt_description.TabIndex = 24
        '
        'txt_brand
        '
        Me.txt_brand.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_brand.Location = New System.Drawing.Point(12, 364)
        Me.txt_brand.Name = "txt_brand"
        Me.txt_brand.Size = New System.Drawing.Size(100, 20)
        Me.txt_brand.TabIndex = 23
        '
        'txt_warranty
        '
        Me.txt_warranty.Location = New System.Drawing.Point(12, 390)
        Me.txt_warranty.Name = "txt_warranty"
        Me.txt_warranty.Size = New System.Drawing.Size(100, 20)
        Me.txt_warranty.TabIndex = 22
        '
        'lbl_description
        '
        Me.lbl_description.AutoSize = True
        Me.lbl_description.Location = New System.Drawing.Point(262, 417)
        Me.lbl_description.Name = "lbl_description"
        Me.lbl_description.Size = New System.Drawing.Size(63, 13)
        Me.lbl_description.TabIndex = 35
        Me.lbl_description.Text = "Description "
        Me.lbl_description.UseWaitCursor = True
        '
        'lbl_warranty
        '
        Me.lbl_warranty.AutoSize = True
        Me.lbl_warranty.Location = New System.Drawing.Point(118, 393)
        Me.lbl_warranty.Name = "lbl_warranty"
        Me.lbl_warranty.Size = New System.Drawing.Size(50, 13)
        Me.lbl_warranty.TabIndex = 34
        Me.lbl_warranty.Text = "Warranty"
        Me.lbl_warranty.UseWaitCursor = True
        '
        'lbl_brand
        '
        Me.lbl_brand.AutoSize = True
        Me.lbl_brand.Location = New System.Drawing.Point(118, 367)
        Me.lbl_brand.Name = "lbl_brand"
        Me.lbl_brand.Size = New System.Drawing.Size(35, 13)
        Me.lbl_brand.TabIndex = 33
        Me.lbl_brand.Text = "Brand"
        Me.lbl_brand.UseWaitCursor = True
        '
        'lbl_type
        '
        Me.lbl_type.AutoSize = True
        Me.lbl_type.Location = New System.Drawing.Point(118, 341)
        Me.lbl_type.Name = "lbl_type"
        Me.lbl_type.Size = New System.Drawing.Size(31, 13)
        Me.lbl_type.TabIndex = 32
        Me.lbl_type.Text = "Type"
        Me.lbl_type.UseWaitCursor = True
        '
        'lbl_price
        '
        Me.lbl_price.AutoSize = True
        Me.lbl_price.Location = New System.Drawing.Point(118, 315)
        Me.lbl_price.Name = "lbl_price"
        Me.lbl_price.Size = New System.Drawing.Size(31, 13)
        Me.lbl_price.TabIndex = 31
        Me.lbl_price.Text = "Price"
        Me.lbl_price.UseWaitCursor = True
        '
        'lbl_name
        '
        Me.lbl_name.AutoSize = True
        Me.lbl_name.Location = New System.Drawing.Point(118, 289)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(73, 13)
        Me.lbl_name.TabIndex = 30
        Me.lbl_name.Text = "Product name"
        Me.lbl_name.UseWaitCursor = True
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.Location = New System.Drawing.Point(118, 263)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(58, 13)
        Me.lbl_id.TabIndex = 29
        Me.lbl_id.Text = "Product ID"
        Me.lbl_id.UseWaitCursor = True
        '
        'btn_exit
        '
        Me.btn_exit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_exit.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_exit.Location = New System.Drawing.Point(566, 413)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(75, 23)
        Me.btn_exit.TabIndex = 36
        Me.btn_exit.Text = "Exit"
        Me.btn_exit.UseVisualStyleBackColor = True
        '
        'frm_updateproducts_ga03842
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(785, 448)
        Me.Controls.Add(Me.btn_exit)
        Me.Controls.Add(Me.lbl_description)
        Me.Controls.Add(Me.lbl_warranty)
        Me.Controls.Add(Me.lbl_brand)
        Me.Controls.Add(Me.lbl_type)
        Me.Controls.Add(Me.lbl_price)
        Me.Controls.Add(Me.lbl_name)
        Me.Controls.Add(Me.lbl_id)
        Me.Controls.Add(Me.txt_description)
        Me.Controls.Add(Me.txt_brand)
        Me.Controls.Add(Me.txt_warranty)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.txt_price)
        Me.Controls.Add(Me.txt_type)
        Me.Controls.Add(Me.txt_id)
        Me.Controls.Add(Me.grd_products)
        Me.Controls.Add(Me.lbl_title)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_updateproducts_ga03842"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Update products"
        CType(Me.grd_products, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_delete As Button
    Friend WithEvents btn_update As Button
    Friend WithEvents txt_name As TextBox
    Friend WithEvents txt_price As TextBox
    Friend WithEvents txt_type As TextBox
    Friend WithEvents txt_id As TextBox
    Friend WithEvents grd_products As DataGridView
    Friend WithEvents lbl_title As Label
    Friend WithEvents txt_description As TextBox
    Friend WithEvents txt_brand As TextBox
    Friend WithEvents txt_warranty As TextBox
    Friend WithEvents lbl_description As Label
    Friend WithEvents lbl_warranty As Label
    Friend WithEvents lbl_brand As Label
    Friend WithEvents lbl_type As Label
    Friend WithEvents lbl_price As Label
    Friend WithEvents lbl_name As Label
    Friend WithEvents lbl_id As Label
    Friend WithEvents btn_exit As Button
End Class
