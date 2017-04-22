Public Class Admin

    Private Sub Close_Click(sender As Object, e As EventArgs) Handles Close.Click
        Me.Dispose()
        Login.Show()
    End Sub

    Private Sub Reset_Click(sender As Object, e As EventArgs) Handles Reset.Click
        studentID.Text = Nothing
        semester.Text = Nothing
        courseID.Text = Nothing
    End Sub

    Private Sub Update_Click(sender As Object, e As EventArgs) Handles gradeUpdate.Click
        Me.Hide()
        updateForm.Show()
    End Sub
End Class