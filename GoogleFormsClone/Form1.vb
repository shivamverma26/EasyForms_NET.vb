Public Class Form1
    Inherits Form

    ' Ensure the KeyPreview property is set to True
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
    End Sub

    ' Override the ProcessCmdKey method
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean
        If keyData = (Keys.Control Or Keys.S) Then
            ' Ctrl+S for Create Submission
            btnCreateSubmission.PerformClick()
            Return True
        ElseIf keyData = (Keys.Control Or Keys.V) Then
            ' Ctrl+V for View Submissions
            btnViewSubmissions.PerformClick()
            Return True
        End If
        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function

    Private Sub btnViewSubmissions_Click(sender As Object, e As EventArgs) Handles btnViewSubmissions.Click
        Dim viewForm As New ViewSubmissionsForm()
        viewForm.Show()
    End Sub

    Private Sub btnCreateSubmission_Click(sender As Object, e As EventArgs) Handles btnCreateSubmission.Click
        Dim createForm As New CreateSubmissionForm()
        createForm.Show()
    End Sub
End Class
