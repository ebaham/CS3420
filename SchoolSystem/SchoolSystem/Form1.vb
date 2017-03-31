Imports System.Data.OleDb

Public Class Form1

    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Dim myConnection As OleDbConnection = New OleDbConnection

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If UserBox.Text = "rfb" And PassWBox.Text = "reflection" Then
            AdminView.Show()
            Me.Close()
        ElseIf provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source =" Then
            'Change the follow to your access database location'
            dataFile = "C:\Users\Brenda\Documents\Customers.accdb"
            connString = provider & dataFile
            myConnection.ConnectionString = connString

            'the query:'
            Dim cmd As OleDbCommand = New OleDbCommand("SELECT * FROM [Students] WHERE [StudentId] = '" & UserBox.Text & "' AND [password] = '" & PassWBox.Text & "'", myConnection)
            Dim inputUser As OleDbDataReader = cmd.ExecuteReader

            'variable to hold if user is found'
            Dim userFound As Boolean = False
            Dim studentId As String = " "
            Dim passWord As String = " "

            'If found:'
            While inputUser.Read
                userFound = True
            End While

            'Checking the result'
            If userFound = True Then
                StudentSystem.Show()
                Me.Close()
            End If
        Else
            MsgBox("Sorry, username or password not found", MsgBoxStyle.OkOnly, "Invalid")
        End If
    End Sub

End Class