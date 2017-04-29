Public Class NewRecord
    Private Sub Save_Click(sender As Object, e As EventArgs) Handles Save.Click
        Dim connection As New System.Data.SqlClient.SqlConnection("Server= Brenda; Database = SchoolSystem; Integrated Security = true")
        Dim command As New System.Data.SqlClient.SqlCommand

        command.CommandType = System.Data.CommandType.Text
        command.CommandText = "INSERT INTO Registered (StudentId, CRNNumber, Exam 1, Exam 2, Final, Semester) VALUES ('" & Admin.StudentIDBox.Text & "','" & CRNBox.Text & "','" & midterm1.Text & "','" & midterm2.Text & "','" & finalExam.Text & "','" & Admin.semester.Text & "')"
        command.Connection = connection

        connection.Open()
        command.ExecuteNonQuery()
        connection.Close()
    End Sub

    Private Sub Reset_Click(sender As Object, e As EventArgs) Handles Reset.Click
        midterm1.Text = Nothing
        midterm2.Text = Nothing
        finalExam.Text = Nothing
        classGrade.Text = Nothing
        CRNBox.Text = Nothing
    End Sub

    Private Sub Close_Click(sender As Object, e As EventArgs) Handles Close.Click
        'Me.Close()
    End Sub

End Class