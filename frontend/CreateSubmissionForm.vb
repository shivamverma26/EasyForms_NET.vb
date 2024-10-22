Imports System.Diagnostics
Imports System.Net.Http
Imports Newtonsoft.Json

Public Class CreateSubmissionForm
    Dim stopwatch As New Stopwatch()
    Dim WithEvents timerUpdateElapsedTime As New Timer()

    Private Sub CreateSubmissionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set interval to update every 1 second (1000 milliseconds)
        timerUpdateElapsedTime.Interval = 1000
        AddHandler timerUpdateElapsedTime.Tick, AddressOf TimerUpdateElapsedTime_Tick
    End Sub

    Private Sub TimerUpdateElapsedTime_Tick(sender As Object, e As EventArgs)
        ' Update the elapsed time display
        lblElapsedTime.Text = stopwatch.Elapsed.ToString("hh\:mm\:ss")
    End Sub

    Private Sub btnStopwatch_Click(sender As Object, e As EventArgs) Handles btnStopwatch.Click
        If stopwatch.IsRunning Then
            stopwatch.Stop()
            timerUpdateElapsedTime.Stop()
            btnStopwatch.Text = "Start Stopwatch"
        Else
            stopwatch.Start()
            timerUpdateElapsedTime.Start()
            btnStopwatch.Text = "Stop Stopwatch"
        End If
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim name As String = txtName.Text
        Dim email As String = txtEmail.Text
        Dim phone As String = txtPhone.Text
        Dim githubLink As String = txtGithub.Text
        Dim elapsedTime As TimeSpan = stopwatch.Elapsed

        ' Call backend API to submit the form data
        SubmitForm(name, email, phone, githubLink, elapsedTime)
    End Sub

    Private Async Sub SubmitForm(name As String, email As String, phone As String, githubLink As String, elapsedTime As TimeSpan)
        Try
            Using client As New HttpClient()
                Dim values As New Dictionary(Of String, String) From {
                    {"name", name},
                    {"email", email},
                    {"phone", phone},
                    {"github_link", githubLink},
                    {"stopwatch_time", elapsedTime.ToString()}
                }
                Dim json As String = JsonConvert.SerializeObject(values)
                Dim content As New StringContent(json, System.Text.Encoding.UTF8, "application/json")
                Dim response As HttpResponseMessage = Await client.PostAsync("http://localhost:3000/submit", content)

                If response.IsSuccessStatusCode Then
                    MessageBox.Show("Form submitted successfully.")

                    ' Optional: Reset stopwatch and timer after submission
                    stopwatch.Reset()
                    lblElapsedTime.Text = "00:00:00"
                    timerUpdateElapsedTime.Stop()
                    btnStopwatch.Text = "Start Stopwatch"

                    ' Optional: Clear form input fields
                    txtName.Text = ""
                    txtEmail.Text = ""
                    txtPhone.Text = ""
                    txtGithub.Text = ""
                Else
                    MessageBox.Show("Failed to submit form.")
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show($"An error occurred: {ex.Message}")
        End Try
    End Sub
End Class
