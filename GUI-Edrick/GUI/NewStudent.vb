Imports System.Data.SqlClient
Public Class NewStudent
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'Dim connection As New SqlConnection("Server= Brenda; Database = SchoolSystem; Integrated Security = true")
        Dim connection As New System.Data.SqlClient.SqlConnection("Server= Brenda; Database = SchoolSystem; Integrated Security = true")
        Dim command As New System.Data.SqlClient.SqlCommand

        command.CommandType = System.Data.CommandType.Text
        command.CommandText = "INSERT INTO StudentData (StudentId, FirstName, LastName, Address, City, ZipCode, PhoneNumber, DoB, SSN, Password) VALUES ('" & StudentIDBox.Text & "','" & FNameBox.Text & "','" & LNameBox.Text & "','" & AddressBox.Text & "','" & CityBox.Text & "','" & ZipBox.Text & "','" & PhoneBox.Text & "','" & DateBox.Text & "','" & SocialBox.Text & "','" & PasswordBox.Text & "')"
        command.Connection = connection

        connection.Open()
        command.ExecuteNonQuery()
        connection.Close()

        Me.Close()
    End Sub

    Private Sub NewStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class