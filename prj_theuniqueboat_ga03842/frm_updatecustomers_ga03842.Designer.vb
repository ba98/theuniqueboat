<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_updatecustomers_ga03842
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
        Me.lbl_phoneno = New System.Windows.Forms.Label()
        Me.lbl_name = New System.Windows.Forms.Label()
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.txt_phoneno = New System.Windows.Forms.TextBox()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.grd_customers = New System.Windows.Forms.DataGridView()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.btn_exit = New System.Windows.Forms.Button()
        CType(Me.grd_customers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_phoneno
        '
        Me.lbl_phoneno.AutoSize = True
        Me.lbl_phoneno.Location = New System.Drawing.Point(423, 350)
        Me.lbl_phoneno.Name = "lbl_phoneno"
        Me.lbl_phoneno.Size = New System.Drawing.Size(99, 13)
        Me.lbl_phoneno.TabIndex = 61
        Me.lbl_phoneno.Text = "Customer phone no"
        Me.lbl_phoneno.UseWaitCursor = True
        '
        'lbl_name
        '
        Me.lbl_name.AutoSize = True
        Me.lbl_name.Location = New System.Drawing.Point(423, 324)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(80, 13)
        Me.lbl_name.TabIndex = 60
        Me.lbl_name.Text = "Customer name"
        Me.lbl_name.UseWaitCursor = True
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.Location = New System.Drawing.Point(423, 298)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(65, 13)
        Me.lbl_id.TabIndex = 59
        Me.lbl_id.Text = "Customer ID"
        Me.lbl_id.UseWaitCursor = True
        '
        'btn_delete
        '
        Me.btn_delete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_delete.Location = New System.Drawing.Point(423, 373)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(75, 23)
        Me.btn_delete.TabIndex = 58
        Me.btn_delete.Text = "DELETE"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'btn_update
        '
        Me.btn_update.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_update.Location = New System.Drawing.Point(342, 373)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(75, 23)
        Me.btn_update.TabIndex = 57
        Me.btn_update.Text = "UPDATE"
        Me.btn_update.UseVisualStyleBackColor = True
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(317, 321)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(100, 20)
        Me.txt_name.TabIndex = 56
        '
        'txt_phoneno
        '
        Me.txt_phoneno.Location = New System.Drawing.Point(317, 347)
        Me.txt_phoneno.Name = "txt_phoneno"
        Me.txt_phoneno.Size = New System.Drawing.Size(100, 20)
        Me.txt_phoneno.TabIndex = 55
        '
        'txt_id
        '
        Me.txt_id.Location = New System.Drawing.Point(317, 295)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.ReadOnly = True
        Me.txt_id.Size = New System.Drawing.Size(100, 20)
        Me.txt_id.TabIndex = 53
        '
        'grd_customers
        '
        Me.grd_customers.AllowUserToAddRows = False
        Me.grd_customers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_customers.Location = New System.Drawing.Point(231, 55)
        Me.grd_customers.Name = "grd_customers"
        Me.grd_customers.ReadOnly = True
        Me.grd_customers.Size = New System.Drawing.Size(344, 222)
        Me.grd_customers.TabIndex = 52
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.Location = New System.Drawing.Point(296, 9)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(236, 32)
        Me.lbl_title.TabIndex = 51
        Me.lbl_title.Text = "Update customers"
        '
        'btn_exit
        '
        Me.btn_exit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_exit.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_exit.Location = New System.Drawing.Point(383, 413)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(75, 23)
        Me.btn_exit.TabIndex = 62
        Me.btn_exit.Text = "Exit"
        Me.btn_exit.UseVisualStyleBackColor = True
        '
        'frm_updatecustomers_ga03842
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(785, 448)
        Me.Controls.Add(Me.btn_exit)
        Me.Controls.Add(Me.lbl_phoneno)
        Me.Controls.Add(Me.lbl_name)
        Me.Controls.Add(Me.lbl_id)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.txt_phoneno)
        Me.Controls.Add(Me.txt_id)
        Me.Controls.Add(Me.grd_customers)
        Me.Controls.Add(Me.lbl_title)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_updatecustomers_ga03842"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Update customers"
        CType(Me.grd_customers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_phoneno As Label
    Friend WithEvents lbl_name As Label
    Friend WithEvents lbl_id As Label
    Friend WithEvents btn_delete As Button
    Friend WithEvents btn_update As Button
    Friend WithEvents txt_name As TextBox
    Friend WithEvents txt_phoneno As TextBox
    Friend WithEvents txt_id As TextBox
    Friend WithEvents grd_customers As DataGridView
    Friend WithEvents lbl_title As Label
    Friend WithEvents btn_exit As Button
End Class
