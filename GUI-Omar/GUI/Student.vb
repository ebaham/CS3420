Imports MySql.Data.MySqlClient

Public Class Student

    Dim MysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand

    Private Sub Close_Click(sender As Object, e As EventArgs) Handles Close.Click
        Me.Dispose()
        Application.Exit()
        Login.Show()
    End Sub

    Private Sub Student_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
            "server = localhost; userid = root; password = wali; database = SIMS"

        Dim READER1 As MySqlDataReader
        Dim READER2 As MySqlDataReader

        Try
            MysqlConn.Open()

            Dim Query1 As String
            Query1 = "SELECT * FROM SIMS.student_data
                        WHERE Student_Id = '" & Login.Username.Text & "' ;"

            COMMAND = New MySqlCommand(Query1, MysqlConn)
            READER1 = COMMAND.ExecuteReader

            While READER1.Read
                StudentIDLBL.Text = READER1.GetInt32("Student_Id")
                NameLBL.Text = READER1.GetString("First_Name") + " " + READER1.GetString("Last_Name")
            End While
            READER1.Dispose()

            Dim Query2 As String
            Query2 = "SELECT * FROM SIMS.grade_record
                        WHERE StudentId = '" & Login.Username.Text & "' ;"

            COMMAND.Dispose()

            COMMAND = New MySqlCommand(Query2, MysqlConn)
            READER2 = COMMAND.ExecuteReader

            While READER2.Read
                SemesterLBL.Text = READER2.GetString("Semester")

                StudentGridLSTBOX.Items.Add("CRN 1: " + CStr(READER2.GetInt64("CRN1")) +
                                     "; Course Grade: " + CStr(READER2.GetInt64("CourseGrade_1")))

                StudentGridLSTBOX.Items.Add("Exam 1: " + CStr(READER2.GetInt64("Exam_1-1")))
                StudentGridLSTBOX.Items.Add("Exam 2: " + CStr(READER2.GetInt64("Exam_2-1")))
                StudentGridLSTBOX.Items.Add("Final: " + CStr(READER2.GetInt64("Final_1")))

                StudentGridLSTBOX.Items.Add("CRN 2: " + CStr(READER2.GetInt64("CRN2")) +
                                     "; Course Grade: " + CStr(READER2.GetInt64("CourseGrade_2")))

                StudentGridLSTBOX.Items.Add("Exam 1: " + CStr(READER2.GetInt64("Exam_1-2")))
                StudentGridLSTBOX.Items.Add("Exam 2: " + CStr(READER2.GetInt64("Exam_2-2")))
                StudentGridLSTBOX.Items.Add("Final: " + CStr(READER2.GetInt64("Final_2")))

                StudentGridLSTBOX.Items.Add("CRN 3: " + CStr(READER2.GetInt64("CRN3")) +
                                     "; Course Grade: " + CStr(READER2.GetInt64("CourseGrade_3")))

                StudentGridLSTBOX.Items.Add("Exam 1: " + CStr(READER2.GetInt64("Exam_1-3")))
                StudentGridLSTBOX.Items.Add("Exam 2: " + CStr(READER2.GetInt64("Exam_2-3")))
                StudentGridLSTBOX.Items.Add("Final: " + CStr(READER2.GetInt64("Final_3")))

                StudentGridLSTBOX.Items.Add("CRN 4: " + CStr(READER2.GetInt64("CRN4")) +
                                     "; Course Grade: " + CStr(READER2.GetInt64("CourseGrade_4")))

                StudentGridLSTBOX.Items.Add("Exam 1: " + CStr(READER2.GetInt64("Exam_1-4")))
                StudentGridLSTBOX.Items.Add("Exam 2: " + CStr(READER2.GetInt64("Exam_2-4")))
                StudentGridLSTBOX.Items.Add("Final: " + CStr(READER2.GetInt64("Final_4")))

                StudentGridLSTBOX.Items.Add("CRN 5: " + CStr(READER2.GetInt64("CRN5")) +
                                     "; Course Grade: " + CStr(READER2.GetInt64("CourseGrade_5")))

                StudentGridLSTBOX.Items.Add("Exam 1: " + CStr(READER2.GetInt64("Exam_1-5")))
                StudentGridLSTBOX.Items.Add("Exam 2: " + CStr(READER2.GetInt64("Exam_2-5")))
                StudentGridLSTBOX.Items.Add("Final: " + CStr(READER2.GetInt64("Final_5")))

            End While
            READER2.Dispose()

            MysqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try

    End Sub

    Private Sub Student_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

    Private Sub Student_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub
End Class