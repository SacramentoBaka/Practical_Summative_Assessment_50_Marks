Public Class Form1
    Private Sub SplashScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ProgressBar1.Value = 0
        Timer1.Start()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Value += 1
        Label2.Text = ProgressBar1.Value & "%..."
        If ProgressBar1.Value = 100 Then
            Timer1.Stop()
            Timer2.Start()
        End If

        If ProgressBar1.Value = 15 Then
            Label3.Text = "Loading..."
        End If
        If ProgressBar1.Value = 35 Then
            Label3.Text = "Please wait..."
        End If
        If ProgressBar1.Value = 50 Then
            Label3.Text = "Halfway there..."
        End If
        If ProgressBar1.Value = 75 Then
            Label3.Text = "Preparing database.."
        End If
        If ProgressBar1.Value = 90 Then
            Label3.Text = "Launching..."
        End If
        If ProgressBar1.Value = 100 Then
            Main.Show()
            Me.Hide()

        End If

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Timer2.Stop()

    End Sub

End Class
