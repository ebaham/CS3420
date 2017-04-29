Imports System.Data.SqlClient
Public Class updateForm

    Private Sub Close_Click(sender As Object, e As EventArgs) Handles Close.Click
        Admin.Show()
        Me.Hide()
    End Sub

    Private Sub Reset_Click(sender As Object, e As EventArgs) Handles Reset.Click
        midterm1.Text = Nothing
        midterm2.Text = Nothing
        finalExam.Text = Nothing
        classGrade.Text = Nothing
        CRNBox.Text = Nothing
    End Sub

    Private Sub Update_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Save_Click(sender As Object, e As EventArgs) Handles Save.Click
        Dim connection As New System.Data.SqlClient.SqlConnection("Server= Brenda; Database = SchoolSystem; Integrated Security = true")
        Dim command As New System.Data.SqlClient.SqlCommand

        command.CommandType = System.Data.CommandType.Text
        command.CommandType = "UPDATE Registered SET CRNNumber = '" & CRNBox.Text & "', Exam 1 = '" & midterm1.Text & "', Exam 2 ='" & midterm2.Text & "', Final = '" & finalExam.Text & "' WHERE StudentID= '" & Admin.StudentIDBox.Text & "' AND semester = '" & Admin.semester.Text & "'"
        'command.CommandText = "INSERT INTO Registered (StudentId, CRNNumber, Exam 1, Exam 2, Final, Semester) VALUES ('" & Admin.StudentIDBox.Text & "','" & CRNBox.Text & "','" & midterm1.Text & "','" & midterm2.Text & "','" & finalExam.Text & "','" & Admin.semester.Text & "')"
        command.Connection = connection

        connection.Open()
        command.ExecuteNonQuery()
        connection.Close()

        'Me.Close()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub classGrade_TextChanged(sender As Object, e As EventArgs) Handles classGrade.TextChanged

    End Sub

    Private Sub finalExam_TextChanged(sender As Object, e As EventArgs) Handles finalExam.TextChanged

    End Sub

    Private Sub midterm2_TextChanged(sender As Object, e As EventArgs) Handles midterm2.TextChanged

    End Sub

    Private Sub midterm1_TextChanged(sender As Object, e As EventArgs) Handles midterm1.TextChanged

    End Sub

    Private Sub CRNBox_TextChanged(sender As Object, e As EventArgs) Handles CRNBox.TextChanged

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class