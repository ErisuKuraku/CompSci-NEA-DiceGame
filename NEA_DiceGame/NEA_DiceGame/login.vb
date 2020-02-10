Public Class login
    Private Sub Login_BTN_Click(sender As Object, e As EventArgs) Handles Login_BTN.Click
        If User_TXB.Text = "user" And Pass_TXB.Text = "Password1" Then
            game.Show()
            Me.Hide()
        Else
            MessageBox.Show("Please enter the correct username and password!")
            Me.Close()
        End If
    End Sub
End Class
