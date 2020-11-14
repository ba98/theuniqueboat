<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_allorders_ga03842
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
        Me.btn_invoices = New System.Windows.Forms.Button()
        Me.btn_orders = New System.Windows.Forms.Button()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.btn_orderdetails = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_invoices
        '
        Me.btn_invoices.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_invoices.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_invoices.Location = New System.Drawing.Point(146, 95)
        Me.btn_invoices.Name = "btn_invoices"
        Me.btn_invoices.Size = New System.Drawing.Size(125, 23)
        Me.btn_invoices.TabIndex = 7
        Me.btn_invoices.Text = "Invoices"
        Me.btn_invoices.UseVisualStyleBackColor = True
        '
        'btn_orders
        '
        Me.btn_orders.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_orders.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_orders.Location = New System.Drawing.Point(146, 66)
        Me.btn_orders.Name = "btn_orders"
        Me.btn_orders.Size = New System.Drawing.Size(125, 23)
        Me.btn_orders.TabIndex = 6
        Me.btn_orders.Text = "Orders"
        Me.btn_orders.UseVisualStyleBackColor = True
        '
        'btn_exit
        '
        Me.btn_exit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_exit.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_exit.Location = New System.Drawing.Point(171, 201)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(75, 23)
        Me.btn_exit.TabIndex = 8
        Me.btn_exit.Text = "Exit"
        Me.btn_exit.UseVisualStyleBackColor = True
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.Location = New System.Drawing.Point(105, 9)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(197, 33)
        Me.lbl_title.TabIndex = 9
        Me.lbl_title.Text = "All about orders"
        '
        'btn_orderdetails
        '
        Me.btn_orderdetails.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_orderdetails.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_orderdetails.Location = New System.Drawing.Point(146, 124)
        Me.btn_orderdetails.Name = "btn_orderdetails"
        Me.btn_orderdetails.Size = New System.Drawing.Size(125, 23)
        Me.btn_orderdetails.TabIndex = 10
        Me.btn_orderdetails.Text = "Make an order"
        Me.btn_orderdetails.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(146, 153)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(125, 23)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Order details"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frm_allorders_ga03842
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(412, 235)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btn_orderdetails)
        Me.Controls.Add(Me.lbl_title)
        Me.Controls.Add(Me.btn_exit)
        Me.Controls.Add(Me.btn_invoices)
        Me.Controls.Add(Me.btn_orders)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_allorders_ga03842"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "All about orders"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_invoices As Button
    Friend WithEvents btn_orders As Button
    Friend WithEvents btn_exit As Button
    Friend WithEvents lbl_title As Label
    Friend WithEvents btn_orderdetails As Button
    Friend WithEvents Button1 As Button
End Class
