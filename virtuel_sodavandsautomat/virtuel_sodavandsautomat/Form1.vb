Public Module Variables
    'Variabler samt arrays opsættes.
    Public Input, Retur, Retur2 As Decimal
    Public Output As String
    Public ReturTekst As String
    Public MoneyEarned As Decimal

    Public Pris = {10.5, 17, 19.5, 25, 27.5}
    Public Sodavand = {"Dumb Coke", "Not Fanta", "No Kondi", "Bathwater", "Bepis"}
    Public Stock = {10, 5, 20, 2, 10}

    Public Mønt = {20, 10, 5, 2, 1, 0.5}
    Public MøntStock = {3, 3, 3, 3, 3, 3}
End Module
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Højde på formen
        Me.Height = 600

        Input = 0
        Retur = 0
        Output = ""

        tbx_Input.Text = Input
        tbx_Retur.Text = Retur
        tbx_Input.BackColor = Color.White
        tbx_Retur.BackColor = Color.White

        Timer1.Interval = 1000
        Timer1.Enabled = False

        btn_SV1.Text = Sodavand(0) + ": " + CStr(Pris(0)) + " kr"
        btn_SV2.Text = Sodavand(1) + ": " + CStr(Pris(1)) + " kr"
        btn_SV3.Text = Sodavand(2) + ": " + CStr(Pris(2)) + " kr"
        btn_SV4.Text = Sodavand(3) + ": " + CStr(Pris(3)) + " kr"
        btn_SV5.Text = Sodavand(4) + ": " + CStr(Pris(4)) + " kr"
        lbl_Retur.Text = ""
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'timer tændes ved køb
        tbx_Input.Text = Input
        Timer1.Enabled = False
        tbx_Input.BackColor = Color.White
    End Sub
    'Sodavands knap 1 opsættes
    Private Sub Btn_SV1_Click(sender As Object, e As EventArgs) Handles btn_SV1.Click
        Timer1.Enabled = True
        Dim l = 0
        'Ting hives ud fra arrays
        If Input - Pris(l) >= 0 And Stock(l) - 1 >= 0 And Output = "" Then
            tbx_Input.BackColor = Color.FromArgb(255, 150, 150)
            tbx_Input.Text = "- " + CStr(Pris(l))
            Input -= Pris(l)
            Output += Sodavand(l) + " "
            'Billede bruges fra Ressources
            pbox_Output.Image = My.Resources.Sodavand_01
            Stock(l) -= 1

            If Stock(l) = 0 Then
                btn_SV1.Enabled = 0
            End If

            MoneyEarned += Pris(l)
            'Stop argumenter opsættes           
        ElseIf Input - Pris(l) < 0 Then
            tbx_Input.Text = "Ikke nok penge"
        ElseIf Stock(l) - 1 < 0 Then
            tbx_Input.Text = "Ikke flere tilbage"
        ElseIf Output IsNot "" Then
            tbx_Input.Text = "Tag din sodavand"
        End If
    End Sub
    Private Sub Btn_SV2_Click(sender As Object, e As EventArgs) Handles btn_SV2.Click
        Timer1.Enabled = True
        Dim l = 1
        If Input - Pris(l) >= 0 And Stock(l) - 1 >= 0 And Output = "" Then
            tbx_Input.BackColor = Color.FromArgb(255, 150, 150)
            tbx_Input.Text = "- " + CStr(Pris(l))
            Input -= Pris(l)
            Output += Sodavand(l) + " "
            pbox_Output.Image = My.Resources.Sodavand_02
            Stock(l) -= 1

            If Stock(l) = 0 Then
                btn_SV2.Enabled = 0
            End If

            MoneyEarned += Pris(l)

        ElseIf Input - Pris(l) < 0 Then
            tbx_Input.Text = "Ikke nok penge"
        ElseIf Stock(l) - 1 < 0 Then
            tbx_Input.Text = "Ikke flere tilbage"
        ElseIf Output IsNot "" Then
            tbx_Input.Text = "Tag din sodavand"
        End If
    End Sub
    Private Sub Btn_SV3_Click(sender As Object, e As EventArgs) Handles btn_SV3.Click
        Timer1.Enabled = True
        Dim l = 2
        If Input - Pris(l) >= 0 And Stock(l) - 1 >= 0 And Output = "" Then
            tbx_Input.BackColor = Color.FromArgb(255, 150, 150)
            tbx_Input.Text = "- " + CStr(Pris(l))
            Input -= Pris(l)
            Output += Sodavand(l) + " "
            pbox_Output.Image = My.Resources.Sodavand_03
            Stock(l) -= 1

            If Stock(l) = 0 Then
                btn_SV3.Enabled = 0
            End If

            MoneyEarned += Pris(l)

        ElseIf Input - Pris(l) < 0 Then
            tbx_Input.Text = "Ikke nok penge"
        ElseIf Stock(l) - 1 < 0 Then
            tbx_Input.Text = "Ikke flere tilbage"
        ElseIf Output IsNot "" Then
            tbx_Input.Text = "Tag din sodavand"
        End If
    End Sub
    Private Sub Btn_SV4_Click(sender As Object, e As EventArgs) Handles btn_SV4.Click
        Timer1.Enabled = True
        Dim l = 3
        If Input - Pris(l) >= 0 And Stock(l) - 1 >= 0 And Output = "" Then
            tbx_Input.BackColor = Color.FromArgb(255, 150, 150)
            tbx_Input.Text = "- " + CStr(Pris(l))
            Input -= Pris(l)
            Output += Sodavand(l) + " "
            pbox_Output.Image = My.Resources.Sodavand_04
            Stock(l) -= 1

            If Stock(l) = 0 Then
                btn_SV4.Enabled = 0
            End If

            MoneyEarned += Pris(l)

        ElseIf Input - Pris(l) < 0 Then
            tbx_Input.Text = "Ikke nok penge"
        ElseIf Stock(l) - 1 < 0 Then
            tbx_Input.Text = "Ikke flere tilbage"
        ElseIf Output IsNot "" Then
            tbx_Input.Text = "Tag din sodavand"
        End If
    End Sub
    Private Sub Btn_SV5_Click(sender As Object, e As EventArgs) Handles btn_SV5.Click
        Timer1.Enabled = True
        Dim l = 4
        If Input - Pris(l) >= 0 And Stock(l) - 1 >= 0 And Output = "" Then
            tbx_Input.BackColor = Color.FromArgb(255, 150, 150)
            tbx_Input.Text = "- " + CStr(Pris(l))
            Input -= Pris(l)
            Output += Sodavand(l) + " "
            pbox_Output.Image = My.Resources.Sodavand_05
            Stock(l) -= 1

            If Stock(l) = 0 Then
                btn_SV5.Enabled = 0
            End If

            MoneyEarned += Pris(l)

        ElseIf Input - Pris(l) < 0 Then
            tbx_Input.Text = "Ikke nok penge"
        ElseIf Stock(l) - 1 < 0 Then
            tbx_Input.Text = "Ikke flere tilbage"
        ElseIf Output IsNot "" Then
            tbx_Input.Text = "Tag din sodavand"
        End If
    End Sub
    '
    Private Sub btn_Accepter_Click(sender As Object, e As EventArgs) Handles btn_Accepter.Click
        Retur = 0
        Retur2 = 0
        tbx_Retur.Text = Retur
        ReturTekst = ""
        lbl_Retur.Text = ReturTekst
    End Sub
    Private Sub Btn_Retur_Click(sender As Object, e As EventArgs) Handles btn_Retur.Click
        'Der opsættes 2 retur variabler, da den ene ændres i loopet, og den anden forbliver hvis brugeren vælger

        'at klikke på retur knappen igen
        Retur += Input
        Retur2 += Input
        tbx_Retur.Text = Retur2
        Input -= Retur
        tbx_Input.Text = Input

        'Der tjekkes om der er nok mønter af arrayindex 0
        While Retur > 0 And MøntStock(0) > 0 And MøntStock(5) > 0
            For i As Integer = 0 To 5
                While Retur >= Mønt(i) And MøntStock(i) > 0
                    Retur -= Mønt(i)
                    ReturTekst += CStr(Mønt(i)) + " "
                    lbl_Retur.Text = ReturTekst
                    MøntStock(i) -= 1
                End While
            Next
        End While
    End Sub
    'Admin menu knap opsættes
    Private Sub Btn_Admin_Click(sender As Object, e As EventArgs) Handles btn_Admin.Click
        Me.Hide()
        Form2.Show()
        Form3.lbl_Profit.Text = CStr(MoneyEarned) + " kr"
    End Sub

    Private Sub Pbox_Output_Click(sender As Object, e As EventArgs) Handles pbox_Output.Click
        Output = ""
        pbox_Output.Image = Nothing
    End Sub
    'Møntknapper animeres ved størrelses ændring
    Private Sub PictureBox1_MouseDown(sender As Object, e As EventArgs) Handles PictureBox1.MouseDown
        PictureBox1.Width = 40
        PictureBox1.Height = 40
        PictureBox1.Left += 5
        PictureBox1.Top += 5
    End Sub

    Private Sub PictureBox1_MouseUp(sender As Object, e As EventArgs) Handles PictureBox1.MouseUp
        Input += Mønt(0)
        tbx_Input.Text = Input
        MøntStock(0) += 1

        PictureBox1.Width = 50
        PictureBox1.Height = 50
        PictureBox1.Left -= 5
        PictureBox1.Top -= 5
    End Sub

    Private Sub PictureBox2_MouseDown(sender As Object, e As EventArgs) Handles PictureBox2.MouseDown
        PictureBox2.Width = 40
        PictureBox2.Height = 40
        PictureBox2.Left += 5
        PictureBox2.Top += 5
    End Sub

    Private Sub PictureBox2_MouseUp(sender As Object, e As EventArgs) Handles PictureBox2.MouseUp
        Input += Mønt(1)
        tbx_Input.Text = Input
        MøntStock(1) += 1

        PictureBox2.Width = 50
        PictureBox2.Height = 50
        PictureBox2.Left -= 5
        PictureBox2.Top -= 5
    End Sub

    Private Sub PictureBox3_MouseDown(sender As Object, e As EventArgs) Handles PictureBox3.MouseDown
        PictureBox3.Width = 40
        PictureBox3.Height = 40
        PictureBox3.Left += 5
        PictureBox3.Top += 5
    End Sub

    Private Sub PictureBox3_MouseUp(sender As Object, e As EventArgs) Handles PictureBox3.MouseUp
        Input += Mønt(2)
        tbx_Input.Text = Input
        MøntStock(2) += 1

        PictureBox3.Width = 50
        PictureBox3.Height = 50
        PictureBox3.Left -= 5
        PictureBox3.Top -= 5
    End Sub

    Private Sub PictureBox4_MouseDown(sender As Object, e As EventArgs) Handles PictureBox4.MouseDown
        PictureBox4.Width = 40
        PictureBox4.Height = 40
        PictureBox4.Left += 5
        PictureBox4.Top += 5
    End Sub

    Private Sub PictureBox4_MouseUp(sender As Object, e As EventArgs) Handles PictureBox4.MouseUp
        Input += Mønt(3)
        tbx_Input.Text = Input
        MøntStock(3) += 1

        PictureBox4.Width = 50
        PictureBox4.Height = 50
        PictureBox4.Left -= 5
        PictureBox4.Top -= 5
    End Sub

    Private Sub PictureBox5_MouseDown(sender As Object, e As EventArgs) Handles PictureBox5.MouseDown
        PictureBox5.Width = 40
        PictureBox5.Height = 40
        PictureBox5.Left += 5
        PictureBox5.Top += 5
    End Sub

    Private Sub PictureBox5_MouseUp(sender As Object, e As EventArgs) Handles PictureBox5.MouseUp
        Input += Mønt(4)
        tbx_Input.Text = Input
        MøntStock(4) += 1

        PictureBox5.Width = 50
        PictureBox5.Height = 50
        PictureBox5.Left -= 5
        PictureBox5.Top -= 5
    End Sub

    Private Sub PictureBox6_MouseDown(sender As Object, e As EventArgs) Handles PictureBox6.MouseDown
        PictureBox6.Width = 40
        PictureBox6.Height = 40
        PictureBox6.Left += 5
        PictureBox6.Top += 5
    End Sub

    Private Sub PictureBox6_MouseUp(sender As Object, e As EventArgs) Handles PictureBox6.MouseUp
        Input += Mønt(5)
        tbx_Input.Text = Input
        MøntStock(5) += 1

        PictureBox6.Width = 50
        PictureBox6.Height = 50
        PictureBox6.Left -= 5
        PictureBox6.Top -= 5
    End Sub

End Class


