<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btn_replace = New System.Windows.Forms.Button()
        Me.txt_username = New System.Windows.Forms.TextBox()
        Me.btn_check = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.tsslbl_status = New System.Windows.Forms.ToolStripStatusLabel()
        Me.btn_logoff = New System.Windows.Forms.Button()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_replace
        '
        Me.btn_replace.Location = New System.Drawing.Point(12, 38)
        Me.btn_replace.Name = "btn_replace"
        Me.btn_replace.Size = New System.Drawing.Size(55, 23)
        Me.btn_replace.TabIndex = 0
        Me.btn_replace.Text = "Reaplce"
        Me.btn_replace.UseVisualStyleBackColor = True
        '
        'txt_username
        '
        Me.txt_username.Location = New System.Drawing.Point(12, 12)
        Me.txt_username.Name = "txt_username"
        Me.txt_username.Size = New System.Drawing.Size(220, 20)
        Me.txt_username.TabIndex = 1
        Me.txt_username.Text = "Username"
        '
        'btn_check
        '
        Me.btn_check.Location = New System.Drawing.Point(73, 38)
        Me.btn_check.Name = "btn_check"
        Me.btn_check.Size = New System.Drawing.Size(93, 23)
        Me.btn_check.TabIndex = 2
        Me.btn_check.Text = "Check Value"
        Me.btn_check.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsslbl_status})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 67)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(244, 22)
        Me.StatusStrip1.TabIndex = 3
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'tsslbl_status
        '
        Me.tsslbl_status.Name = "tsslbl_status"
        Me.tsslbl_status.Size = New System.Drawing.Size(64, 17)
        Me.tsslbl_status.Text = "Version 1.0"
        '
        'btn_logoff
        '
        Me.btn_logoff.Location = New System.Drawing.Point(172, 38)
        Me.btn_logoff.Name = "btn_logoff"
        Me.btn_logoff.Size = New System.Drawing.Size(60, 23)
        Me.btn_logoff.TabIndex = 4
        Me.btn_logoff.Text = "Logoff"
        Me.btn_logoff.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(244, 89)
        Me.Controls.Add(Me.btn_logoff)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.btn_check)
        Me.Controls.Add(Me.txt_username)
        Me.Controls.Add(Me.btn_replace)
        Me.MaximumSize = New System.Drawing.Size(260, 128)
        Me.MinimumSize = New System.Drawing.Size(260, 128)
        Me.Name = "Form1"
        Me.Text = "LastLoggedOn"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_replace As Button
    Friend WithEvents txt_username As TextBox
    Friend WithEvents btn_check As Button
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents tsslbl_status As ToolStripStatusLabel
    Friend WithEvents btn_logoff As Button
End Class
