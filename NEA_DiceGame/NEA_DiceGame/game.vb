Public Class game
    Dim Player1Score As Integer
    Dim Player2Score As Integer
    Dim Rounds As Integer
    Dim Dice1 As Integer
    Dim Dice2 As Integer
    Dim Dice3 As Integer
    Dim Dice4 As Integer
    Dim iseven As Boolean

    Private Sub SP_BTN_Click(sender As Object, e As EventArgs) Handles SP_BTN.Click
        Dice1 = Math.Ceiling(Rnd() * 6)
        Dice2 = Math.Ceiling(Rnd() * 6)

        Select Case Dice1
            Case 1
                DiceFace1.Visible = True

            Case 2
                DiceFace2.Visible = True

            Case 3
                DiceFace3.Visible = True

            Case 4
                DiceFace4.Visible = True

            Case 5
                DiceFace5.Visible = True


            Case 6
                DiceFace6.Visible = True

        End Select

        Select Case Dice2
            Case 1
                Dice2Face1.Visible = True

            Case 2
                Dice2Face2.Visible = True

            Case 3
                Dice2Face3.Visible = True

            Case 4
                Dice2Face4.Visible = True

            Case 5
                Dice2Face5.Visible = True


            Case 6
                Dice2Face6.Visible = True

        End Select

        If (Dice1 + Dice2) Mod 2 = 0 Then
            iseven = True
            Player1Score += (Dice1 + Dice2)
            Player1Score += 10
            P1Score.Text = CStr(Player1Score)
            MessageBox.Show("Player 2, Roll your dice!")
            SP_BTN.Visible = False
            TP_BTN.Visible = True

        ElseIf (Dice1 = Dice2) Then
            Player1Score += (Dice1 + Dice2)
            Dice3 = Math.Ceiling(Rnd() * 6)
            Player1Score += (Dice3)
            P1Score.Text = CStr(Player1Score)
            MessageBox.Show("Player 2, Roll your dice!")
            SP_BTN.Visible = False
            TP_BTN.Visible = True

        Else
            iseven = False
            Player1Score += (Dice1 + Dice2)
            Player1Score -= 5
            P1Score.Text = CStr(Player1Score)
            MessageBox.Show("Player 2, Roll your dice!")
            SP_BTN.Visible = False
            TP_BTN.Visible = True
        End If

        If Player1Score < 0 Then
            Player1Score = 0
        End If

        DiceFace1.Visible = False
        DiceFace2.Visible = False
        DiceFace3.Visible = False
        DiceFace4.Visible = False
        DiceFace5.Visible = False
        DiceFace6.Visible = False

        Dice2Face1.Visible = False
        Dice2Face2.Visible = False
        Dice2Face3.Visible = False
        Dice2Face4.Visible = False
        Dice2Face5.Visible = False
        Dice2Face6.Visible = False



    End Sub

    Private Sub TP_BTN_Click(sender As Object, e As EventArgs) Handles TP_BTN.Click
        Dice1 = Math.Ceiling(Rnd() * 6)
        Dice2 = Math.Ceiling(Rnd() * 6)

        Select Case Dice1
            Case 1
                DiceFace1.Visible = True

            Case 2
                DiceFace2.Visible = True

            Case 3
                DiceFace3.Visible = True

            Case 4
                DiceFace4.Visible = True

            Case 5
                DiceFace5.Visible = True


            Case 6
                DiceFace6.Visible = True

        End Select

        Select Case Dice2
            Case 1
                Dice2Face1.Visible = True

            Case 2
                Dice2Face2.Visible = True

            Case 3
                Dice2Face3.Visible = True

            Case 4
                Dice2Face4.Visible = True

            Case 5
                Dice2Face5.Visible = True


            Case 6
                Dice2Face6.Visible = True

        End Select


        If (Dice1 + Dice2) Mod 2 = 0 Then
            iseven = True
            Player2Score += (Dice1 + Dice2)
            Player2Score += 10
            P2Score.Text = CStr(Player2Score)
            Rounds += 1
            RoundDisplay.Text = CStr(Rounds)
            MessageBox.Show("Player 1, Roll your dice!")
            TP_BTN.Visible = False
            SP_BTN.Visible = True


        ElseIf (Dice1 = Dice2) Then
            Player2Score += (Dice1 + Dice2)
            Dice3 = Math.Ceiling(Rnd() * 6)
            Player2Score += (Dice3)
            P2Score.Text = CStr(Player2Score)
            Rounds += 1
            RoundDisplay.Text = CStr(Rounds)
            Select Case Dice3
                Case 1
                    DiceFace1.Visible = True

                Case 2
                    DiceFace2.Visible = True

                Case 3
                    DiceFace3.Visible = True

                Case 4
                    DiceFace4.Visible = True

                Case 5
                    DiceFace5.Visible = True


                Case 6
                    DiceFace6.Visible = True

            End Select
            MessageBox.Show("Player 1, Roll your dice!")
            TP_BTN.Visible = False
            SP_BTN.Visible = True
        Else
            iseven = False
            Player2Score += (Dice1 + Dice2)
            Player2Score -= 5
            P2Score.Text = CStr(Player2Score)
            Rounds += 1
            RoundDisplay.Text = CStr(Rounds)
            MessageBox.Show("Player 1, Roll your dice!")
            TP_BTN.Visible = False
            SP_BTN.Visible = True

        End If

        DiceFace1.Visible = False
        DiceFace2.Visible = False
        DiceFace3.Visible = False
        DiceFace4.Visible = False
        DiceFace5.Visible = False
        DiceFace6.Visible = False

        Dice2Face1.Visible = False
        Dice2Face2.Visible = False
        Dice2Face3.Visible = False
        Dice2Face4.Visible = False
        Dice2Face5.Visible = False
        Dice2Face6.Visible = False



        If Rounds = 5 Then
            If Player1Score > Player2Score Then
                MessageBox.Show("Player 1 Won!")
                Dim winner As New winner
                winner.WinScore = Player1Score
                winner.Show()
                Me.Hide()
            ElseIf Player1Score < Player2Score Then
                MessageBox.Show("Player 2 Won!")
                Dim winner As New winner
                winner.WinScore = Player2Score
                winner.Show()
                Me.Hide()
            ElseIf Player1Score = Player2Score Then
                MessageBox.Show("Each Player will now roll a dice do determine the winner!")


                Do While Player1Score = Player2Score
                    Dice1 = Math.Ceiling(Rnd() * 6)
                    Dice2 = Math.Ceiling(Rnd() * 6)

                    Select Case Dice1
                        Case 1
                            DiceFace1.Visible = True

                        Case 2
                            DiceFace2.Visible = True

                        Case 3
                            DiceFace3.Visible = True

                        Case 4
                            DiceFace4.Visible = True

                        Case 5
                            DiceFace5.Visible = True


                        Case 6
                            DiceFace6.Visible = True

                    End Select

                    Select Case Dice2
                        Case 1
                            Dice2Face1.Visible = True

                        Case 2
                            Dice2Face2.Visible = True

                        Case 3
                            Dice2Face3.Visible = True

                        Case 4
                            Dice2Face4.Visible = True

                        Case 5
                            Dice2Face5.Visible = True


                        Case 6
                            Dice2Face6.Visible = True

                    End Select

                    If (Dice1 + Dice2) Mod 2 = 0 Then
                        iseven = True
                        Player1Score += (Dice1 + Dice2)
                        Player1Score += 10
                        P1Score.Text = CStr(Player1Score)
                        MessageBox.Show("Player 2's Dice will now roll")

                    ElseIf (Dice1 = Dice2) Then
                        Player1Score += (Dice1 + Dice2)
                        Dice3 = Math.Ceiling(Rnd() * 6)
                        Player1Score += (Dice3)
                        P1Score.Text = CStr(Player1Score)
                        MessageBox.Show("Player 2's Dice will now roll")
                    Else
                        iseven = False
                        Player1Score += (Dice1 + Dice2)
                        Player1Score -= 5
                        P1Score.Text = CStr(Player1Score)
                        MessageBox.Show("Player 2's Dice will now roll")
                    End If

                    If Player1Score < 0 Then
                        Player1Score = 0
                    End If

                    DiceFace1.Visible = False
                    DiceFace2.Visible = False
                    DiceFace3.Visible = False
                    DiceFace4.Visible = False
                    DiceFace5.Visible = False
                    DiceFace6.Visible = False

                    Dice2Face1.Visible = False
                    Dice2Face2.Visible = False
                    Dice2Face3.Visible = False
                    Dice2Face4.Visible = False
                    Dice2Face5.Visible = False
                    Dice2Face6.Visible = False

                    Dice1 = Math.Ceiling(Rnd() * 6)
                    Dice2 = Math.Ceiling(Rnd() * 6)

                    Select Case Dice1
                        Case 1
                            DiceFace1.Visible = True

                        Case 2
                            DiceFace2.Visible = True

                        Case 3
                            DiceFace3.Visible = True

                        Case 4
                            DiceFace4.Visible = True

                        Case 5
                            DiceFace5.Visible = True


                        Case 6
                            DiceFace6.Visible = True

                    End Select

                    Select Case Dice2
                        Case 1
                            Dice2Face1.Visible = True

                        Case 2
                            Dice2Face2.Visible = True

                        Case 3
                            Dice2Face3.Visible = True

                        Case 4
                            Dice2Face4.Visible = True

                        Case 5
                            Dice2Face5.Visible = True


                        Case 6
                            Dice2Face6.Visible = True

                    End Select


                    If (Dice1 + Dice2) Mod 2 = 0 Then
                        iseven = True
                        Player2Score += (Dice1 + Dice2)
                        Player2Score += 10
                        P2Score.Text = CStr(Player2Score)
                        Rounds += 1
                        RoundDisplay.Text = CStr(Rounds)
                        MessageBox.Show("Player 1, Roll your dice!")


                    ElseIf (Dice1 = Dice2) Then
                        Player2Score += (Dice1 + Dice2)
                        Dice3 = Math.Ceiling(Rnd() * 6)
                        Player2Score += (Dice3)
                        P2Score.Text = CStr(Player2Score)
                        Rounds += 1
                        RoundDisplay.Text = CStr(Rounds)
                        If Dice3 = 1 Then
                            DiceFace2.Visible = False
                            DiceFace3.Visible = False
                            DiceFace4.Visible = False
                            DiceFace5.Visible = False
                            DiceFace6.Visible = False

                            Dice2Face1.Visible = False
                            Dice2Face2.Visible = False
                            Dice2Face3.Visible = False
                            Dice2Face4.Visible = False
                            Dice2Face5.Visible = False
                            Dice2Face6.Visible = False

                        End If
                        MessageBox.Show("Calculating the Winner!")

                    Else
                        iseven = False
                        Player2Score += (Dice1 + Dice2)
                        Player2Score -= 5
                        P2Score.Text = CStr(Player2Score)
                        Rounds += 1
                        RoundDisplay.Text = CStr(Rounds)
                        MessageBox.Show("Calculating the Winner!")

                    End If

                    DiceFace1.Visible = False
                    DiceFace2.Visible = False
                    DiceFace3.Visible = False
                    DiceFace4.Visible = False
                    DiceFace5.Visible = False
                    DiceFace6.Visible = False

                    Dice2Face1.Visible = False
                    Dice2Face2.Visible = False
                    Dice2Face3.Visible = False
                    Dice2Face4.Visible = False
                    Dice2Face5.Visible = False
                    Dice2Face6.Visible = False

                Loop


            End If
        End If
    End Sub

    Private Sub game_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DiceFace1.Visible = False
        DiceFace2.Visible = False
        DiceFace3.Visible = False
        DiceFace4.Visible = False
        DiceFace5.Visible = False
        DiceFace6.Visible = False

        Dice2Face1.Visible = False
        Dice2Face2.Visible = False
        Dice2Face3.Visible = False
        Dice2Face4.Visible = False
        Dice2Face5.Visible = False
        Dice2Face6.Visible = False
    End Sub
End Class