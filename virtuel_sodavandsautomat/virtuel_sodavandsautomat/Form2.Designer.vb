<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.btn_Admin = New System.Windows.Forms.Button()
        Me.lbl_Admin = New System.Windows.Forms.Label()
        Me.tbx_Admin = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'btn_Admin
        '
        Me.btn_Admin.Location = New System.Drawing.Point(470, 33)
        Me.btn_Admin.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btn_Admin.Name = "btn_Admin"
        Me.btn_Admin.Size = New System.Drawing.Size(100, 44)
        Me.btn_Admin.TabIndex = 2
        Me.btn_Admin.Text = "Enter"
        Me.btn_Admin.UseVisualStyleBackColor = True
        '
        'lbl_Admin
        '
        Me.lbl_Admin.AutoSize = True
        Me.lbl_Admin.Location = New System.Drawing.Point(44, 44)
        Me.lbl_Admin.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lbl_Admin.Name = "lbl_Admin"
        Me.lbl_Admin.Size = New System.Drawing.Size(182, 25)
        Me.lbl_Admin.TabIndex = 0
        Me.lbl_Admin.Text = "Indtast Password:"
        '
        'tbx_Admin
        '
        Me.tbx_Admin.Location = New System.Drawing.Point(238, 37)
        Me.tbx_Admin.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.tbx_Admin.Name = "tbx_Admin"
        Me.tbx_Admin.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbx_Admin.Size = New System.Drawing.Size(196, 31)
        Me.tbx_Admin.TabIndex = 1
        '
        'Timer1
        '
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(638, 115)
        Me.Controls.Add(Me.tbx_Admin)
        Me.Controls.Add(Me.lbl_Admin)
        Me.Controls.Add(Me.btn_Admin)
        Me.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Name = "Form2"
        Me.Text = "Admin"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_Admin As Button
    Friend WithEvents lbl_Admin As Label
    Friend WithEvents tbx_Admin As TextBox
    Friend WithEvents Timer1 As Timer
End Class
