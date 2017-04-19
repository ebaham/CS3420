Public Class Admin
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles studentID.TextChanged

    End Sub

    Private Sub Close_Click(sender As Object, e As EventArgs) Handles Close.Click
        End
    End Sub

    Private Sub Reset_Click(sender As Object, e As EventArgs) Handles Reset.Click
        studentID.Text = Nothing
        semester.Text = Nothing
        courseID.Text = Nothing
    End Sub

    Private Sub Update_Click(sender As Object, e As EventArgs) Handles gradeUpdate.Click
        updateForm.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        NewStudent.Show()
    End Sub
End Class