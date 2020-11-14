<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_allproducts_ga03842
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
        Me.btn_updateproducts = New System.Windows.Forms.Button()
        Me.btn_insertproducts = New System.Windows.Forms.Button()
        Me.btn_details = New System.Windows.Forms.Button()
        Me.btn_products = New System.Windows.Forms.Button()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_updateproducts
        '
        Me.btn_updateproducts.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_updateproducts.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_updateproducts.Location = New System.Drawing.Point(144, 151)
        Me.btn_updateproducts.Name = "btn_updateproducts"
        Me.btn_updateproducts.Size = New System.Drawing.Size(125, 23)
        Me.btn_updateproducts.TabIndex = 15
        Me.btn_updateproducts.Text = "Update products"
        Me.btn_updateproducts.UseVisualStyleBackColor = True
        '
        'btn_insertproducts
        '
        Me.btn_insertproducts.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_insertproducts.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_insertproducts.Location = New System.Drawing.Point(144, 122)
        Me.btn_insertproducts.Name = "btn_insertproducts"
        Me.btn_insertproducts.Size = New System.Drawing.Size(125, 23)
        Me.btn_insertproducts.TabIndex = 14
        Me.btn_insertproducts.Text = "Insert products"
        Me.btn_insertproducts.UseVisualStyleBackColor = True
        '
        'btn_details
        '
        Me.btn_details.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_details.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_details.Location = New System.Drawing.Point(144, 93)
        Me.btn_details.Name = "btn_details"
        Me.btn_details.Size = New System.Drawing.Size(125, 23)
        Me.btn_details.TabIndex = 13
        Me.btn_details.Text = "Product details"
        Me.btn_details.UseVisualStyleBackColor = True
        '
        'btn_products
        '
        Me.btn_products.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_products.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_products.Location = New System.Drawing.Point(144, 64)
        Me.btn_products.Name = "btn_products"
        Me.btn_products.Size = New System.Drawing.Size(125, 23)
        Me.btn_products.TabIndex = 12
        Me.btn_products.Text = "Products"
        Me.btn_products.UseVisualStyleBackColor = True
        '
        'btn_exit
        '
        Me.btn_exit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_exit.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_exit.Location = New System.Drawing.Point(168, 200)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(75, 23)
        Me.btn_exit.TabIndex = 16
        Me.btn_exit.Text = "Exit"
        Me.btn_exit.UseVisualStyleBackColor = True
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.Location = New System.Drawing.Point(100, 9)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(223, 33)
        Me.lbl_title.TabIndex = 17
        Me.lbl_title.Text = "All about products"
        '
        'frm_allproducts_ga03842
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(412, 235)
        Me.Controls.Add(Me.lbl_title)
        Me.Controls.Add(Me.btn_exit)
        Me.Controls.Add(Me.btn_updateproducts)
        Me.Controls.Add(Me.btn_insertproducts)
        Me.Controls.Add(Me.btn_details)
        Me.Controls.Add(Me.btn_products)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_allproducts_ga03842"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "All about products"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_updateproducts As Button
    Friend WithEvents btn_insertproducts As Button
    Friend WithEvents btn_details As Button
    Friend WithEvents btn_products As Button
    Friend WithEvents btn_exit As Button
    Friend WithEvents lbl_title As Label
End Class
