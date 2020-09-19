Public Class Form3

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbox_Admin.Items.Clear()
        For i As Integer = 0 To 4
            cbox_Admin.Items.Add(Sodavand(i))
        Next

        cbox_Mønter.Items.Clear()
        For i As Integer = 0 To 5
            cbox_Mønter.Items.Add(Mønt(i))
        Next

        tbx_pris.DecimalPlaces = 2
        lbl_Profit.Text = CStr(MoneyEarned) + " kr"

    End Sub

    Private Sub Cbox_Admin_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbox_Admin.SelectedIndexChanged
        tbx_antal.Text = Stock(cbox_Admin.SelectedIndex)
        tbx_pris.Text = CDec(Pris(cbox_Admin.SelectedIndex))
    End Sub

    Private Sub btn_Home_Click(sender As Object, e As EventArgs) Handles btn_Home.Click
        Me.Hide()
        Form1.Show()

        Form1.btn_SV1.Text = Sodavand(0) + ": " + CStr(Pris(0)) + " kr"
        Form1.btn_SV2.Text = Sodavand(1) + ": " + CStr(Pris(1)) + " kr"
        Form1.btn_SV3.Text = Sodavand(2) + ": " + CStr(Pris(2)) + " kr"
        Form1.btn_SV4.Text = Sodavand(3) + ": " + CStr(Pris(3)) + " kr"
        Form1.btn_SV5.Text = Sodavand(4) + ": " + CStr(Pris(4)) + " kr"

        If Stock(0) > 0 Then
            Form1.btn_SV1.Enabled = True
        Else
            Form1.btn_SV1.Enabled = False
        End If

        If Stock(1) > 0 Then
            Form1.btn_SV2.Enabled = True
        Else
            Form1.btn_SV2.Enabled = False
        End If

        If Stock(2) > 0 Then
            Form1.btn_SV3.Enabled = True
        Else
            Form1.btn_SV3.Enabled = False
        End If

        If Stock(3) > 0 Then
            Form1.btn_SV4.Enabled = True
        Else
            Form1.btn_SV4.Enabled = False
        End If

        If Stock(4) > 0 Then
            Form1.btn_SV5.Enabled = True
        Else
            Form1.btn_SV5.Enabled = False
        End If

    End Sub

    Private Sub Tbx_pris_ValueChanged(sender As Object, e As EventArgs) Handles tbx_pris.ValueChanged
        Pris(cbox_Admin.SelectedIndex) = Math.Round(tbx_pris.Value * 2) / 2
    End Sub

    Private Sub Tbx_antal_ValueChanged(sender As Object, e As EventArgs) Handles tbx_antal.ValueChanged
        Stock(cbox_Admin.SelectedIndex) = tbx_antal.Value
    End Sub
    Private Sub Cbox_Mønter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbox_Mønter.SelectedIndexChanged
        tbx_AntalMønter.Text = MøntStock(cbox_Mønter.SelectedIndex)
    End Sub
    Private Sub Tbx_AntalMønter_ValueChanged(sender As Object, e As EventArgs) Handles tbx_AntalMønter.ValueChanged
        MøntStock(cbox_Mønter.SelectedIndex) = tbx_AntalMønter.Value
    End Sub
End Class