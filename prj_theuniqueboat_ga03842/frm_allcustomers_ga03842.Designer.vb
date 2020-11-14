<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_allcustomers_ga03842
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
        Me.btn_updatecustomers = New System.Windows.Forms.Button()
        Me.btn_insertcustomers = New System.Windows.Forms.Button()
        Me.btn_customers = New System.Windows.Forms.Button()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_updatecustomers
        '
        Me.btn_updatecustomers.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_updatecustomers.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_updatecustomers.Location = New System.Drawing.Point(140, 134)
        Me.btn_updatecustomers.Name = "btn_updatecustomers"
        Me.btn_updatecustomers.Size = New System.Drawing.Size(125, 23)
        Me.btn_updatecustomers.TabIndex = 16
        Me.btn_updatecustomers.Text = "Update customers"
        Me.btn_updatecustomers.UseVisualStyleBackColor = True
        '
        'btn_insertcustomers
        '
        Me.btn_insertcustomers.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_insertcustomers.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_insertcustomers.Location = New System.Drawing.Point(140, 105)
        Me.btn_insertcustomers.Name = "btn_insertcustomers"
        Me.btn_insertcustomers.Size = New System.Drawing.Size(125, 23)
        Me.btn_insertcustomers.TabIndex = 15
        Me.btn_insertcustomers.Text = "Insert customers"
        Me.btn_insertcustomers.UseVisualStyleBackColor = True
        '
        'btn_customers
        '
        Me.btn_customers.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_customers.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_customers.Location = New System.Drawing.Point(140, 76)
        Me.btn_customers.Name = "btn_customers"
        Me.btn_customers.Size = New System.Drawing.Size(125, 23)
        Me.btn_customers.TabIndex = 14
        Me.btn_customers.Text = "Customers"
        Me.btn_customers.UseVisualStyleBackColor = True
        '
        'btn_exit
        '
        Me.btn_exit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_exit.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_exit.Location = New System.Drawing.Point(166, 199)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(75, 23)
        Me.btn_exit.TabIndex = 17
        Me.btn_exit.Text = "Exit"
        Me.btn_exit.UseVisualStyleBackColor = True
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.Location = New System.Drawing.Point(83, 9)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(241, 33)
        Me.lbl_title.TabIndex = 18
        Me.lbl_title.Text = "All about customers"
        '
        'frm_allcustomers_ga03842
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(412, 235)
        Me.Controls.Add(Me.lbl_title)
        Me.Controls.Add(Me.btn_exit)
        Me.Controls.Add(Me.btn_updatecustomers)
        Me.Controls.Add(Me.btn_insertcustomers)
        Me.Controls.Add(Me.btn_customers)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_allcustomers_ga03842"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "All about customers"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_updatecustomers As Button
    Friend WithEvents btn_insertcustomers As Button
    Friend WithEvents btn_customers As Button
    Friend WithEvents btn_exit As Button
    Friend WithEvents lbl_title As Label
End Class
