Public Class Form2
    Dim Password
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Password = "123"
        Timer1.Enabled = False
        Timer1.Interval = 1000
    End Sub
    Private Sub Btn_Admin_Click(sender As Object, e As EventArgs) Handles btn_Admin.Click
        If Password = tbx_Admin.Text Then
            Me.Hide()
            Form3.Show()
            tbx_Admin.Text = ""
        Else
            Timer1.Enabled = True
            tbx_Admin.Text = ""
            tbx_Admin.BackColor = Color.Red
        End If
    End Sub
    Private Sub tbx_Admin_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tbx_Admin.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Password = tbx_Admin.Text Then
                Me.Hide()
                Form3.Show()
                tbx_Admin.Text = ""
            Else
                Timer1.Enabled = True
                tbx_Admin.Text = ""
                tbx_Admin.BackColor = Color.Red
            End If
        End If
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Enabled = False
        tbx_Admin.BackColor = Color.White
    End Sub
End Class