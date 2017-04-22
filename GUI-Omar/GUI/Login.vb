Imports MySql.Data.MySqlClient

Public Class Login

    Dim MysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand

    Private Sub OK_Click(sender As Object, e As EventArgs) Handles OK.Click

        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
            "server = localhost; userid = root; password = wali; database = SIMS"
        Dim READER As MySqlDataReader

        Try
            MysqlConn.Open()
            Dim Query As String

            Dim count As Integer
            count = 0

            If ChooseDomainCB.Text = "Student" Then
                Query = "SELECT * FROM SIMS.Student_Data 
                        WHERE Student_Id='" & Username.Text & "' 
                        AND Password='" & Password.Text & "'; "
                COMMAND = New MySqlCommand(Query, MysqlConn)
                READER = COMMAND.ExecuteReader
                While READER.Read
                    count = count + 1
                End While
            ElseIf ChooseDomainCB.Text = "Admin" Then
                Query = "SELECT * FROM SIMS.Admin_Data
                        WHERE AUsername ='" & Username.Text & "'
                        And APassword = '" & Password.Text & "';"
                COMMAND = New MySqlCommand(Query, MysqlConn)
                READER = COMMAND.ExecuteReader
                While READER.Read
                    count = count + 1
                End While
            Else
                MessageBox.Show("Error: Please choose domain from dropbox")
            End If

            If count = 1 Then
                If ChooseDomainCB.Text = "Student" Then
                    MessageBox.Show("Student Username and Password are correct")
                    Student.Show()
                    Me.Hide()
                ElseIf ChooseDomainCB.Text = "Admin" Then
                    MessageBox.Show("Admin Username and Password are correct")
                    Admin.Show()
                    Me.Hide()
                Else
                    MessageBox.Show("Please Choose Domain")
                End If

            ElseIf count > 1 Then
                MessageBox.Show("Username and Password are Duplicate")
            Else
                MessageBox.Show("Username and Password are not correct")
            End If

            MysqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try

    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        Me.Dispose()
        Me.Close()
        Application.Exit()
    End Sub

    Private Sub ChooseDomainCB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ChooseDomainCB.SelectedIndexChanged
        If ChooseDomainCB.Text = "Student" Then
            ChooseDomainCB.Text = "Student"
        ElseIf ChooseDomainCB.Text = "Admin" Then
            ChooseDomainCB.Text = "Admin"
        Else
            ChooseDomainCB.Text = "None"
        End If
    End Sub

    Private Sub Username_TextChanged(sender As Object, e As EventArgs) Handles Username.TextChanged
        Username.Text = Username.Text
    End Sub

    Private Sub Password_TextChanged(sender As Object, e As EventArgs) Handles Password.TextChanged
        Password.Text = Password.Text
    End Sub

    Private Sub Password_MouseClick(sender As Object, e As MouseEventArgs) Handles Password.MouseClick
        Password.PasswordChar = "*"
        Password.SelectAll()
    End Sub

    Private Sub Password_TabIndexChanged(sender As Object, e As EventArgs) Handles Password.TabIndexChanged
        Password.PasswordChar = "*"
        Password.SelectAll()
    End Sub
End Class