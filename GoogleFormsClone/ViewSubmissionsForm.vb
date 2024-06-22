Imports System.Collections.Generic
Imports System.Net.Http
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class ViewSubmissionsForm
    ' Placeholder for submissions list
    Dim submissions As List(Of Submission)
    Dim currentIndex As Integer = 0

    ' Class to hold submission data
    Public Class Submission
        Public Property Name As String
        Public Property Email As String
        Public Property Phone As String
        Public Property GithubLink As String
        Public Property StopwatchTime As TimeSpan
    End Class

    Private Async Sub ViewSubmissionsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Fetch submissions from the backend
        Await FetchSubmissions()

        ' Display the first submission if available
        If submissions IsNot Nothing AndAlso submissions.Count > 0 Then
            DisplaySubmission(currentIndex)
        End If
    End Sub

    Private Async Function FetchSubmissions() As Task
        Try
            Dim apiUrl As String = "http://localhost:3000/read"

            Using client As New HttpClient()
                Dim response As HttpResponseMessage = Await client.GetAsync(apiUrl)

                If response.IsSuccessStatusCode Then
                    Dim json As String = Await response.Content.ReadAsStringAsync()

                    ' Deserialize JSON response to JObject
                    Dim result As JObject = JObject.Parse(json)

                    ' Check if 'submissions' key exists
                    If result.ContainsKey("submissions") Then
                        ' Deserialize 'submissions' array to List(Of Submission)
                        Dim submissionsArray As JArray = result("submissions")
                        submissions = submissionsArray.ToObject(Of List(Of Submission))()

                        ' For debugging: Show the count of submissions
                        MessageBox.Show($"Loaded {submissions.Count} submissions.")
                    Else
                        MessageBox.Show("No submissions found.")
                    End If
                Else
                    MessageBox.Show("Failed to fetch submissions.")
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show($"An error occurred: {ex.Message}")
        End Try
    End Function

    Private Sub DisplaySubmission(index As Integer)
        If index >= 0 AndAlso index < submissions.Count Then
            Dim submission As Submission = submissions(index)
            txtName.Text = submission.Name
            txtEmail.Text = submission.Email
            txtPhone.Text = submission.Phone
            txtGithub.Text = submission.GithubLink
            txtStopwatch.Text = submission.StopwatchTime.ToString()
        End If
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If currentIndex > 0 Then
            currentIndex -= 1
            DisplaySubmission(currentIndex)
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If currentIndex < submissions.Count - 1 Then
            currentIndex += 1
            DisplaySubmission(currentIndex)
        End If
    End Sub
End Class
