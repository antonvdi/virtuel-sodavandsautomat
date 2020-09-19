<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.cbox_Admin = New System.Windows.Forms.ComboBox()
        Me.lbl_antal = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbx_antal = New System.Windows.Forms.NumericUpDown()
        Me.tbx_pris = New System.Windows.Forms.NumericUpDown()
        Me.btn_Home = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbl_Profit = New System.Windows.Forms.Label()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbx_AntalMønter = New System.Windows.Forms.NumericUpDown()
        Me.cbox_Mønter = New System.Windows.Forms.ComboBox()
        CType(Me.tbx_antal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbx_pris, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbx_AntalMønter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbox_Admin
        '
        Me.cbox_Admin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbox_Admin.FormattingEnabled = True
        Me.cbox_Admin.Items.AddRange(New Object() {"Sodavand 1", "Sodavand 2", "Sodavand 3", "Sodavand 4", "Sodavand 5"})
        Me.cbox_Admin.Location = New System.Drawing.Point(40, 79)
        Me.cbox_Admin.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.cbox_Admin.Name = "cbox_Admin"
        Me.cbox_Admin.Size = New System.Drawing.Size(238, 33)
        Me.cbox_Admin.TabIndex = 0
        '
        'lbl_antal
        '
        Me.lbl_antal.AutoSize = True
        Me.lbl_antal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_antal.Location = New System.Drawing.Point(472, 108)
        Me.lbl_antal.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lbl_antal.Name = "lbl_antal"
        Me.lbl_antal.Size = New System.Drawing.Size(0, 37)
        Me.lbl_antal.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.Location = New System.Drawing.Point(282, -6)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 33)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Antal:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(474, -6)
        Me.Label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 33)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Pris:"
        '
        'tbx_antal
        '
        Me.tbx_antal.Location = New System.Drawing.Point(312, 79)
        Me.tbx_antal.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.tbx_antal.Name = "tbx_antal"
        Me.tbx_antal.Size = New System.Drawing.Size(160, 31)
        Me.tbx_antal.TabIndex = 1
        '
        'tbx_pris
        '
        Me.tbx_pris.Location = New System.Drawing.Point(504, 79)
        Me.tbx_pris.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.tbx_pris.Name = "tbx_pris"
        Me.tbx_pris.Size = New System.Drawing.Size(160, 31)
        Me.tbx_pris.TabIndex = 2
        '
        'btn_Home
        '
        Me.btn_Home.Image = Global.virtuel_sodavandsautomat.My.Resources.Resources.hus_02
        Me.btn_Home.Location = New System.Drawing.Point(724, 48)
        Me.btn_Home.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btn_Home.Name = "btn_Home"
        Me.btn_Home.Size = New System.Drawing.Size(100, 96)
        Me.btn_Home.TabIndex = 3
        Me.btn_Home.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.lbl_Profit)
        Me.GroupBox1.Controls.Add(Me.NumericUpDown1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.tbx_AntalMønter)
        Me.GroupBox1.Controls.Add(Me.cbox_Mønter)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(24, 40)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.GroupBox1.Size = New System.Drawing.Size(664, 294)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 104)
        Me.Label4.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(149, 33)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Vælg Mønt:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 237)
        Me.Label5.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 33)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Profit:"
        '
        'lbl_Profit
        '
        Me.lbl_Profit.AutoSize = True
        Me.lbl_Profit.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lbl_Profit.Location = New System.Drawing.Point(286, 237)
        Me.lbl_Profit.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lbl_Profit.Name = "lbl_Profit"
        Me.lbl_Profit.Size = New System.Drawing.Size(29, 33)
        Me.lbl_Profit.TabIndex = 4
        Me.lbl_Profit.Text = "0"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Enabled = False
        Me.NumericUpDown1.Location = New System.Drawing.Point(480, 144)
        Me.NumericUpDown1.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(160, 31)
        Me.NumericUpDown1.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label3.Location = New System.Drawing.Point(10, -6)
        Me.Label3.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(202, 33)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Vælg Sodavand:"
        '
        'tbx_AntalMønter
        '
        Me.tbx_AntalMønter.Location = New System.Drawing.Point(288, 144)
        Me.tbx_AntalMønter.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.tbx_AntalMønter.Name = "tbx_AntalMønter"
        Me.tbx_AntalMønter.Size = New System.Drawing.Size(160, 31)
        Me.tbx_AntalMønter.TabIndex = 1
        '
        'cbox_Mønter
        '
        Me.cbox_Mønter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbox_Mønter.FormattingEnabled = True
        Me.cbox_Mønter.Items.AddRange(New Object() {"Sodavand 1", "Sodavand 2", "Sodavand 3", "Sodavand 4", "Sodavand 5"})
        Me.cbox_Mønter.Location = New System.Drawing.Point(16, 144)
        Me.cbox_Mønter.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.cbox_Mønter.Name = "cbox_Mønter"
        Me.cbox_Mønter.Size = New System.Drawing.Size(238, 33)
        Me.cbox_Mønter.TabIndex = 0
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(868, 367)
        Me.Controls.Add(Me.btn_Home)
        Me.Controls.Add(Me.tbx_pris)
        Me.Controls.Add(Me.tbx_antal)
        Me.Controls.Add(Me.lbl_antal)
        Me.Controls.Add(Me.cbox_Admin)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Name = "Form3"
        Me.Text = "Lagerstyring"
        CType(Me.tbx_antal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbx_pris, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbx_AntalMønter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbox_Admin As ComboBox
    Friend WithEvents lbl_antal As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tbx_antal As NumericUpDown
    Friend WithEvents tbx_pris As NumericUpDown
    Friend WithEvents btn_Home As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents tbx_AntalMønter As NumericUpDown
    Friend WithEvents cbox_Mønter As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents lbl_Profit As Label
    Friend WithEvents Label4 As Label
End Class
