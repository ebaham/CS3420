Imports System.Data.SqlClient
Public Class Login
    Private Sub OK_Click(sender As Object, e As EventArgs) Handles OK.Click
        Dim connection As New SqlConnection("Server= Brenda; Database = SchoolSystem; Integrated Security = true")
        Dim command As New SqlCommand("SELECT StudentId, Password FROM StudentData WHERE StudentId = '" & Username.Text & "' AND Password = '" & Password.Text & "'", connection)
        connection.Open()

        Dim sdr As SqlDataReader = command.ExecuteReader()

        If Username.Text = "admin" And Password.Text = "admin" Then
            Admin.Show()
        Else
            If sdr.Read() = True Then
                Student.Show()
            Else
                MsgBox("Invalid Username And/Or Password!", MsgBoxStyle.Critical, "Error")
            End If
        End If
        connection.Close()
    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub
End Class