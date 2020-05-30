
Public Class winner
    'This code must not be copied but only used as a guide to write your own code 
    Public Property WinScore As Integer
    Dim leaderline As String
    Dim leaderdata As String
    Dim Leaderboard As System.IO.StreamWriter



    Private Sub Submit_BTN_Click(sender As Object, e As EventArgs) Handles Submit_BTN.Click
        MessageBox.Show("Thanks!")
        leaderline = Name_TXB.Text + " " + (CStr(WinScore))
        Title_Label.Text = "Leaderboard"
        Leaderboard_TXB.Clear()
        Leaderboard = My.Computer.FileSystem.OpenTextFileWriter(".\DiceGame_Leaderboard.txt", True)
        Leaderboard.WriteLine(leaderline)
        Leaderboard.Close()
        leaderdata = My.Computer.FileSystem.ReadAllText(".\DiceGame_Leaderboard.txt")
        Leaderboard_TXB.Text = leaderdata
        Leaderboard_TXB.Visible = True
    End Sub
End Class
