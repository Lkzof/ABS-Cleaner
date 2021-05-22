Imports System.IO
Public Class Form1
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Escaneador.Tick
        ValorEscaneado.Text = ValorEscaneado.Text + 1

        If ValorEscaneado.Text = 100 Then
            Escaneador.Stop()
            MsgBox("Nenhuma ameaça foi encontrada")
            ChecarVirus.Text = "Escanear"
            ValorEscaneado.Text = "0"
            ChecarVirus.ForeColor = Color.Red

        End If

        If ValorEscaneado.Text = "0" Then
            ValorEscaneado.Hide()

        End If
    End Sub

    Private Sub ChecarVirus_Click(sender As Object, e As EventArgs) Handles ChecarVirus.Click
        Escaneador.Enabled = True
        ValorEscaneado.Show()
        ChecarVirus.Text = "Escaneando..."
        ChecarVirus.ForeColor = Color.Aqua
    End Sub

    Private Sub SobreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SobreToolStripMenuItem.Click
        Sobre.Show()

    End Sub

    Private Sub FPSBoostToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FPSBoostToolStripMenuItem.Click
        Cleaner.Hide()
        AntiMalware.Hide()
        Booster.Show()

    End Sub

    Private Sub AntiMalwareToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AntiMalwareToolStripMenuItem.Click
        AntiMalware.Show()
        Cleaner.Hide()
        Booster.Hide()

    End Sub

    Private Sub AntiMalware_Paint(sender As Object, e As PaintEventArgs) Handles AntiMalware.Paint
        ValorEscaneado.Hide()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("Esta opção ainda não está pronta, nossos desenvolvedores estão trabalhando para lança-la o mais rapido possivel.")

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MsgBox("Esta opção ainda não está pronta, nossos desenvolvedores estão trabalhando para lança-la o mais rapido possivel.")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MsgBox("Esta opção ainda não está pronta, nossos desenvolvedores estão trabalhando para lança-la o mais rapido possivel.")
    End Sub

    Private Sub Boosting_Tick(sender As Object, e As EventArgs) Handles Boosting.Tick

        ButtonBooster.Text = "Boosting"
        BoostBar.Value = BoostBar.Value + 1

        If BoostBar.Value = 100 Then
            BoostBar.Value = 0
            Boosting.Stop()
            ButtonBooster.Text = "FPS Boost"
            MsgBox("Seu PC foi optimizado com as configurações recomendadas")
        End If

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles ButtonBooster.Click
        Boosting.Enabled = True

    End Sub

    Private Sub CleanerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CleanerToolStripMenuItem.Click
        Cleaner.Show()
        Booster.Hide()
        AntiMalware.Hide()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
