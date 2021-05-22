Imports System.Net
Public Class UpdateChecker
    Dim cliente As New WebClient

    Private Sub UpdateChecker_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BarMais_Tick(sender As Object, e As EventArgs) Handles BarMais.Tick
        ProgressBar1.Value = ProgressBar1.Value + 1

        If ProgressBar1.Value = 100 Then
            BarMais.Stop()
            UpdateTimer.Start()

        End If
    End Sub

    Private Sub UpdateTimer_Tick(sender As Object, e As EventArgs) Handles UpdateTimer.Tick
        Try
            Dim Retorna As String = cliente.DownloadString("https://pastebin.com/8t58bgvP")
            UpdateTimer.Stop()
            If (Retorna = Application.ProductVersion) = False Then
                MsgBox("Uma nova atualização foi encontrada, baixe-a em: site.com")
                Me.Hide()
                Form1.Show()
                Form1.labelUpdate.Visible = True

            Else
                Form1.labelUpdate.Visible = False


            End If

        Catch ex As Exception

        End Try


    End Sub
End Class