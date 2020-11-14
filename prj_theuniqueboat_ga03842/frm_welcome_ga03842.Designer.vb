<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_welcome_ga03842
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_welcome_ga03842))
        Me.welcome_progress_bar = New System.Windows.Forms.ProgressBar()
        Me.welcome_timer = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'welcome_progress_bar
        '
        Me.welcome_progress_bar.Location = New System.Drawing.Point(12, 379)
        Me.welcome_progress_bar.Name = "welcome_progress_bar"
        Me.welcome_progress_bar.Size = New System.Drawing.Size(621, 10)
        Me.welcome_progress_bar.TabIndex = 4
        '
        'welcome_timer
        '
        Me.welcome_timer.Enabled = True
        '
        'frm_welcome_ga03842
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(657, 410)
        Me.Controls.Add(Me.welcome_progress_bar)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_welcome_ga03842"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "The Unique Boat"
        Me.TransparencyKey = System.Drawing.Color.White
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents welcome_progress_bar As ProgressBar
    Friend WithEvents welcome_timer As Timer
End Class
