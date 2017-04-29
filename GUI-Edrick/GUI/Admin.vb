Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Public Class Admin
    Dim MysqlConn As SqlConnection
    Dim COMMAND As SqlCommand

    Private Sub Close_Click(sender As Object, e As EventArgs) Handles Close.Click
        Login.Show()
    End Sub

    Private Sub Reset_Click(sender As Object, e As EventArgs) Handles Reset.Click
        StudentIDBox.Text = Nothing
        semester.Text = Nothing
    End Sub

    Private Sub Update_Click(sender As Object, e As EventArgs) Handles gradeUpdate.Click
        updateForm.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        NewStudent.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MysqlConn = New SqlConnection
        MysqlConn.ConnectionString =
            "Server= Brenda; Database = SchoolSystem; Integrated Security = true"

        Dim READER1 As SqlDataReader
        Dim READER2 As SqlDataReader

        Try
            MysqlConn.Open()

            Dim Query1 As String
            Query1 = "SELECT * FROM Registered
                        WHERE StudentID = '" & Login.Username.Text & "' ;"

            COMMAND = New SqlCommand(Query1, MysqlConn)
            READER1 = Command.ExecuteReader

            While READER1.Read
                StudentIDBox.Text = READER1.GetInt32("StudentID")
                'NameLBL.Text = READER1.GetString("First_Name") + " " + READER1.GetString("Last_Name")
            End While
            READER1.Dispose()

            Dim Query2 As String
            Query2 = "SELECT * FROM Registered
                        WHERE StudentID = '" & Login.Username.Text & "' ;"

            COMMAND.Dispose()

            COMMAND = New SqlCommand(Query2, MysqlConn)
            READER2 = Command.ExecuteReader

            While READER2.Read
                semester.Text = READER2.GetString("semester")

                ListBox1.Items.Add("CRN 1: " + CStr(READER2.GetInt64("CRN")) +
                                     "; Course Grade: " + CStr(READER2.GetInt64("CourseGrade_1")))

                ListBox1.Items.Add("Exam 1: " + CStr(READER2.GetInt64("Exam 1")))
                ListBox1.Items.Add("Exam 2: " + CStr(READER2.GetInt64("Exam_2-1")))
                ListBox1.Items.Add("Final: " + CStr(READER2.GetInt64("Final_1")))

                ListBox1.Items.Add("CRN 2: " + CStr(READER2.GetInt64("CRN2")) +
                                     "; Course Grade: " + CStr(READER2.GetInt64("CourseGrade_2")))

                ListBox1.Items.Add("Exam 1: " + CStr(READER2.GetInt64("Exam_1-2")))
                ListBox1.Items.Add("Exam 2: " + CStr(READER2.GetInt64("Exam_2-2")))
                ListBox1.Items.Add("Final: " + CStr(READER2.GetInt64("Final_2")))

                ListBox1.Items.Add("CRN 3: " + CStr(READER2.GetInt64("CRN3")) +
                                     "; Course Grade: " + CStr(READER2.GetInt64("CourseGrade_3")))

                ListBox1.Items.Add("Exam 1: " + CStr(READER2.GetInt64("Exam_1-3")))
                ListBox1.Items.Add("Exam 2: " + CStr(READER2.GetInt64("Exam_2-3")))
                ListBox1.Items.Add("Final: " + CStr(READER2.GetInt64("Final_3")))

                ListBox1.Items.Add("CRN 4: " + CStr(READER2.GetInt64("CRN4")) +
                                     "; Course Grade: " + CStr(READER2.GetInt64("CourseGrade_4")))

                ListBox1.Items.Add("Exam 1: " + CStr(READER2.GetInt64("Exam_1-4")))
                ListBox1.Items.Add("Exam 2: " + CStr(READER2.GetInt64("Exam_2-4")))
                ListBox1.Items.Add("Final: " + CStr(READER2.GetInt64("Final_4")))

                ListBox1.Items.Add("CRN 5: " + CStr(READER2.GetInt64("CRN5")) +
                                     "; Course Grade: " + CStr(READER2.GetInt64("CourseGrade_5")))

                ListBox1.Items.Add("Exam 1: " + CStr(READER2.GetInt64("Exam_1-5")))
                ListBox1.Items.Add("Exam 2: " + CStr(READER2.GetInt64("Exam_2-5")))
                ListBox1.Items.Add("Final: " + CStr(READER2.GetInt64("Final_5")))

            End While
            READER2.Dispose()

            MysqlConn.Close()

        Catch ex As SqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        NewRecord.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'DeleteRecord.Show()
    End Sub
End Class