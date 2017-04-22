Public Class updateForm

    Private Sub Close_Click(sender As Object, e As EventArgs) Handles Close.Click
        Me.Dispose()
        Admin.Show()
    End Sub

    Private Sub Reset_Click(sender As Object, e As EventArgs) Handles Reset.Click
        midterm1.Text = Nothing
        midterm2.Text = Nothing
        finalExam.Text = Nothing
        classGrade.Text = Nothing
    End Sub
End Class