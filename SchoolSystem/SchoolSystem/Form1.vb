Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If UserBox.Text = "rfb" And PassWBox.Text = "reflection" Then
            Form2.Show()
            Me.Close()
        Else
            MsgBox("Sorry, username or password not found", MsgBoxStyle.OkOnly, "Invalid")
        End If
    End Sub

End Class
