Public Class updateForm
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Close_Click(sender As Object, e As EventArgs) Handles Close.Click
        Admin.Show()
        Me.Hide()
    End Sub

    Private Sub Reset_Click(sender As Object, e As EventArgs) Handles Reset.Click
        midterm1.Text = Nothing
        midterm2.Text = Nothing
        finalExam.Text = Nothing
        classGrade.Text = Nothing
    End Sub

    Private Sub Update_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class