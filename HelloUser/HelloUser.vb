Public Class HelloUser

    Private Sub BtnOK_Click(sender As Object, e As EventArgs) Handles BtnOK.Click

        'Display a message box greeting the user.
        MessageBox.Show("Hello, " & TxtName.Text & "! Welcome to Visual Basic 2019.", "Hello User Message")
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click

        'End the program and close the form.
        Me.Close()
    End Sub
End Class
