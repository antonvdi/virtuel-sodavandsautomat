<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.tbx_Input = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_Retur = New System.Windows.Forms.Button()
        Me.tbx_Retur = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_Accepter = New System.Windows.Forms.Button()
        Me.lbl_Retur = New System.Windows.Forms.Label()
        Me.pbox_Output = New System.Windows.Forms.PictureBox()
        Me.btn_Admin = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_SV5 = New System.Windows.Forms.Button()
        Me.btn_SV4 = New System.Windows.Forms.Button()
        Me.btn_SV3 = New System.Windows.Forms.Button()
        Me.btn_SV2 = New System.Windows.Forms.Button()
        Me.btn_SV1 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        CType(Me.pbox_Output, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbx_Input
        '
        Me.tbx_Input.ForeColor = System.Drawing.Color.Black
        Me.tbx_Input.Location = New System.Drawing.Point(644, 154)
        Me.tbx_Input.Margin = New System.Windows.Forms.Padding(4)
        Me.tbx_Input.Name = "tbx_Input"
        Me.tbx_Input.ReadOnly = True
        Me.tbx_Input.Size = New System.Drawing.Size(242, 31)
        Me.tbx_Input.TabIndex = 2
        Me.tbx_Input.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(514, 160)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Beløb:"
        '
        'btn_Retur
        '
        Me.btn_Retur.Location = New System.Drawing.Point(528, 615)
        Me.btn_Retur.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_Retur.Name = "btn_Retur"
        Me.btn_Retur.Size = New System.Drawing.Size(100, 44)
        Me.btn_Retur.TabIndex = 6
        Me.btn_Retur.Text = "Retur:"
        Me.btn_Retur.UseVisualStyleBackColor = True
        '
        'tbx_Retur
        '
        Me.tbx_Retur.Location = New System.Drawing.Point(644, 619)
        Me.tbx_Retur.Margin = New System.Windows.Forms.Padding(4)
        Me.tbx_Retur.Name = "tbx_Retur"
        Me.tbx_Retur.ReadOnly = True
        Me.tbx_Retur.Size = New System.Drawing.Size(242, 31)
        Me.tbx_Retur.TabIndex = 7
        Me.tbx_Retur.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Timer1
        '
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(900, 160)
        Me.Label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 25)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "kr"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(900, 625)
        Me.Label3.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 25)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "kr"
        '
        'btn_Accepter
        '
        Me.btn_Accepter.Location = New System.Drawing.Point(528, 677)
        Me.btn_Accepter.Margin = New System.Windows.Forms.Padding(6)
        Me.btn_Accepter.Name = "btn_Accepter"
        Me.btn_Accepter.Size = New System.Drawing.Size(362, 44)
        Me.btn_Accepter.TabIndex = 9
        Me.btn_Accepter.Text = "Tag penge"
        Me.btn_Accepter.UseVisualStyleBackColor = True
        '
        'lbl_Retur
        '
        Me.lbl_Retur.AutoSize = True
        Me.lbl_Retur.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Retur.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Retur.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl_Retur.Location = New System.Drawing.Point(531, 727)
        Me.lbl_Retur.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lbl_Retur.Name = "lbl_Retur"
        Me.lbl_Retur.Size = New System.Drawing.Size(65, 25)
        Me.lbl_Retur.TabIndex = 5
        Me.lbl_Retur.Text = "Label"
        '
        'pbox_Output
        '
        Me.pbox_Output.BackColor = System.Drawing.Color.Transparent
        Me.pbox_Output.Location = New System.Drawing.Point(26, 808)
        Me.pbox_Output.Name = "pbox_Output"
        Me.pbox_Output.Size = New System.Drawing.Size(180, 232)
        Me.pbox_Output.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbox_Output.TabIndex = 13
        Me.pbox_Output.TabStop = False
        '
        'btn_Admin
        '
        Me.btn_Admin.Image = Global.virtuel_sodavandsautomat.My.Resources.Resources.nøgle_Tegnebræt_11
        Me.btn_Admin.Location = New System.Drawing.Point(978, 944)
        Me.btn_Admin.Margin = New System.Windows.Forms.Padding(6)
        Me.btn_Admin.Name = "btn_Admin"
        Me.btn_Admin.Size = New System.Drawing.Size(100, 96)
        Me.btn_Admin.TabIndex = 12
        Me.btn_Admin.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(523, 248)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(135, 25)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Møntindkast:"
        '
        'btn_SV5
        '
        Me.btn_SV5.Location = New System.Drawing.Point(47, 633)
        Me.btn_SV5.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_SV5.Name = "btn_SV5"
        Me.btn_SV5.Size = New System.Drawing.Size(344, 100)
        Me.btn_SV5.TabIndex = 25
        Me.btn_SV5.Text = "Sodavand 5"
        Me.btn_SV5.UseVisualStyleBackColor = True
        '
        'btn_SV4
        '
        Me.btn_SV4.Location = New System.Drawing.Point(47, 501)
        Me.btn_SV4.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_SV4.Name = "btn_SV4"
        Me.btn_SV4.Size = New System.Drawing.Size(344, 100)
        Me.btn_SV4.TabIndex = 24
        Me.btn_SV4.Text = "Sodavand 4"
        Me.btn_SV4.UseVisualStyleBackColor = True
        '
        'btn_SV3
        '
        Me.btn_SV3.Location = New System.Drawing.Point(47, 368)
        Me.btn_SV3.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_SV3.Name = "btn_SV3"
        Me.btn_SV3.Size = New System.Drawing.Size(344, 100)
        Me.btn_SV3.TabIndex = 23
        Me.btn_SV3.Text = "Sodavand 3"
        Me.btn_SV3.UseVisualStyleBackColor = True
        '
        'btn_SV2
        '
        Me.btn_SV2.Location = New System.Drawing.Point(47, 237)
        Me.btn_SV2.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_SV2.Name = "btn_SV2"
        Me.btn_SV2.Size = New System.Drawing.Size(344, 100)
        Me.btn_SV2.TabIndex = 22
        Me.btn_SV2.Text = "Sodavand 2"
        Me.btn_SV2.UseVisualStyleBackColor = True
        '
        'btn_SV1
        '
        Me.btn_SV1.Location = New System.Drawing.Point(47, 105)
        Me.btn_SV1.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_SV1.Name = "btn_SV1"
        Me.btn_SV1.Size = New System.Drawing.Size(344, 100)
        Me.btn_SV1.TabIndex = 21
        Me.btn_SV1.Text = "Sodavand 1"
        Me.btn_SV1.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(42, 69)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(115, 25)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Sodavand:"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.virtuel_sodavandsautomat.My.Resources.Resources.mønter_01
        Me.PictureBox1.InitialImage = Global.virtuel_sodavandsautomat.My.Resources.Resources.mønter_01
        Me.PictureBox1.Location = New System.Drawing.Point(530, 288)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(99, 100)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 27
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.virtuel_sodavandsautomat.My.Resources.Resources.mønter_02
        Me.PictureBox2.InitialImage = Global.virtuel_sodavandsautomat.My.Resources.Resources.mønter_01
        Me.PictureBox2.Location = New System.Drawing.Point(673, 288)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(99, 100)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 28
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = Global.virtuel_sodavandsautomat.My.Resources.Resources.mønter_03
        Me.PictureBox3.InitialImage = Global.virtuel_sodavandsautomat.My.Resources.Resources.mønter_01
        Me.PictureBox3.Location = New System.Drawing.Point(812, 288)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(99, 100)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 29
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.Image = Global.virtuel_sodavandsautomat.My.Resources.Resources.mønter_04
        Me.PictureBox4.InitialImage = Global.virtuel_sodavandsautomat.My.Resources.Resources.mønter_01
        Me.PictureBox4.Location = New System.Drawing.Point(529, 421)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(99, 100)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 30
        Me.PictureBox4.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox5.Image = Global.virtuel_sodavandsautomat.My.Resources.Resources.mønter_05
        Me.PictureBox5.InitialImage = Global.virtuel_sodavandsautomat.My.Resources.Resources.mønter_01
        Me.PictureBox5.Location = New System.Drawing.Point(673, 421)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(99, 100)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 31
        Me.PictureBox5.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox6.Image = Global.virtuel_sodavandsautomat.My.Resources.Resources.mønter_06
        Me.PictureBox6.InitialImage = Global.virtuel_sodavandsautomat.My.Resources.Resources.mønter_01
        Me.PictureBox6.Location = New System.Drawing.Point(812, 421)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(99, 100)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox6.TabIndex = 32
        Me.PictureBox6.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.BackgroundImage = Global.virtuel_sodavandsautomat.My.Resources.Resources.background_012
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1101, 1429)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btn_SV5)
        Me.Controls.Add(Me.btn_SV4)
        Me.Controls.Add(Me.btn_SV3)
        Me.Controls.Add(Me.btn_SV2)
        Me.Controls.Add(Me.btn_SV1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.pbox_Output)
        Me.Controls.Add(Me.lbl_Retur)
        Me.Controls.Add(Me.btn_Admin)
        Me.Controls.Add(Me.btn_Accepter)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbx_Retur)
        Me.Controls.Add(Me.btn_Retur)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbx_Input)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Sodavands Automat"
        CType(Me.pbox_Output, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbx_Input As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_Retur As Button
    Friend WithEvents tbx_Retur As TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_Accepter As Button
    Friend WithEvents btn_Admin As Button
    Friend WithEvents lbl_Retur As Label
    Friend WithEvents pbox_Output As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btn_SV5 As Button
    Friend WithEvents btn_SV4 As Button
    Friend WithEvents btn_SV3 As Button
    Friend WithEvents btn_SV2 As Button
    Friend WithEvents btn_SV1 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
End Class
