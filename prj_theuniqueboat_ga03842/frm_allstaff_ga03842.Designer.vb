<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_allstaff_ga03842
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
        Me.btn_updatestaff = New System.Windows.Forms.Button()
        Me.btn_insertstaff = New System.Windows.Forms.Button()
        Me.btn_staff = New System.Windows.Forms.Button()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_updatestaff
        '
        Me.btn_updatestaff.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_updatestaff.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_updatestaff.Location = New System.Drawing.Point(144, 137)
        Me.btn_updatestaff.Name = "btn_updatestaff"
        Me.btn_updatestaff.Size = New System.Drawing.Size(125, 23)
        Me.btn_updatestaff.TabIndex = 15
        Me.btn_updatestaff.Text = "Update staff"
        Me.btn_updatestaff.UseVisualStyleBackColor = True
        '
        'btn_insertstaff
        '
        Me.btn_insertstaff.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_insertstaff.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_insertstaff.Location = New System.Drawing.Point(144, 108)
        Me.btn_insertstaff.Name = "btn_insertstaff"
        Me.btn_insertstaff.Size = New System.Drawing.Size(125, 23)
        Me.btn_insertstaff.TabIndex = 14
        Me.btn_insertstaff.Text = "Insert staff"
        Me.btn_insertstaff.UseVisualStyleBackColor = True
        '
        'btn_staff
        '
        Me.btn_staff.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_staff.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_staff.Location = New System.Drawing.Point(144, 79)
        Me.btn_staff.Name = "btn_staff"
        Me.btn_staff.Size = New System.Drawing.Size(125, 23)
        Me.btn_staff.TabIndex = 13
        Me.btn_staff.Text = "Staff"
        Me.btn_staff.UseVisualStyleBackColor = True
        '
        'btn_exit
        '
        Me.btn_exit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_exit.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_exit.Location = New System.Drawing.Point(167, 200)
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
        Me.lbl_title.Location = New System.Drawing.Point(122, 9)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(175, 33)
        Me.lbl_title.TabIndex = 17
        Me.lbl_title.Text = "All about staff"
        '
        'frm_allstaff_ga03842
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(412, 235)
        Me.Controls.Add(Me.lbl_title)
        Me.Controls.Add(Me.btn_exit)
        Me.Controls.Add(Me.btn_updatestaff)
        Me.Controls.Add(Me.btn_insertstaff)
        Me.Controls.Add(Me.btn_staff)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_allstaff_ga03842"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "All about staff"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_updatestaff As Button
    Friend WithEvents btn_insertstaff As Button
    Friend WithEvents btn_staff As Button
    Friend WithEvents btn_exit As Button
    Friend WithEvents lbl_title As Label
End Class
