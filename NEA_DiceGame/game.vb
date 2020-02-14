Public Class game
    Dim Player1Score As Integer
    Dim Player2Score As Integer
    Dim Rounds As Integer
    Dim Dice1 As Integer
    Dim Dice2 As Integer
    Dim Dice3 As Integer
    Dim Dice4 As Integer
    Dim iseven As Boolean
    Dim Generator As System.Random = New System.Random()

    Private Sub SP_BTN_Click(sender As Object, e As EventArgs) Handles SP_BTN.Click
        Dice1 = Generator.Next(1, 6)
        Dice2 = Generator.Next(1, 6)

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
            TurnDisplay.Text = "Player 2's Turn"
            SP_BTN.Visible = False
            TP_BTN.Visible = True

        ElseIf (Dice1 = Dice2) Then
            Player1Score += (Dice1 + Dice2)
            Dice3 = Math.Ceiling(Rnd() * 6)
            Player1Score += (Dice3)
            P1Score.Text = CStr(Player1Score)
            MessageBox.Show("Player 2, Roll your dice!")
            TurnDisplay.Text = "Player 2's Turn"
            If Player1Score < 0 Then
                Player1Score = 0
            End If
            SP_BTN.Visible = False
            TP_BTN.Visible = True

        Else
            iseven = False
            Player1Score += (Dice1 + Dice2)
            Player1Score -= 5
            P1Score.Text = CStr(Player1Score)
            MessageBox.Show("Player 2, Roll your dice!")
            TurnDisplay.Text = "Player 2's Turn"
            If Player1Score < 0 Then
                Player1Score = 0
            End If
            SP_BTN.Visible = False
            TP_BTN.Visible = True
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
        Dice1 = Generator.Next(1, 6)
        Dice2 = Generator.Next(1, 6)

        Select Case Dice1
            Case 1
                DiceFace1.Visible = True
            Case 2
                DiceFace2.Visible = True  ' This Case function allows me to show the 
                                          ' repective dice face for the number genorated.
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
                Dice2Face2.Visible = True   ' I Have repeated the same method above for Dice 2
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
            Player2Score += 10                             ' If the total of Dice1 & 2 are even then
            P2Score.Text = CStr(Player2Score)              ' it adds the total to the Players score and then
            Rounds += 1                                    ' add a additional
            RoundDisplay.Text = CStr(Rounds)
            MessageBox.Show("Player 1, Roll your dice!")
            TurnDisplay.Text = "Player 1's Turn"
            If Player2Score < 0 Then                       ' If the Player's score falls below zero this If statment
                Player2Score = 0                           ' then the score will be reset to zero to keep in line with the games rules
            End If
            TP_BTN.Visible = False
            SP_BTN.Visible = True


        ElseIf (Dice1 = Dice2) Then
            Player2Score += (Dice1 + Dice2)               ' If the Dice's are the same then it will roll
            Dice3 = Generator.Next(1, 6)                  ' a third dice and that will be added to the players total.
            Player2Score += (Dice3)
            P2Score.Text = CStr(Player2Score)
            Rounds += 1                                   ' Since the second player has finished their turn one round 
            RoundDisplay.Text = CStr(Rounds)              ' will be added to the varible and the next round starts
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
            If Player2Score < 0 Then
               Player2Score = 0
                  End If

            MessageBox.Show("Player 1, Roll your dice!")
            TurnDisplay.Text = "Player 1's Turn"
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
            TurnDisplay.Text = "Player 1's Turn"
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
                TurnDisplay.Text = "Game Over!"
                MessageBox.Show("Player 1 Won!")      ' Once the rounds count has reached five then it will determine who
                Dim winner As New winner              ' has the highest score and then proceed to the Winners Form
                winner.WinScore = Player1Score
                winner.Show()
                Me.Hide()
            ElseIf Player1Score < Player2Score Then
                TurnDisplay.Text = "Game Over!"
                MessageBox.Show("Player 2 Won!")
                Dim winner As New winner
                winner.WinScore = Player2Score
                winner.Show()
                Me.Hide()
            ElseIf Player1Score = Player2Score Then
                MessageBox.Show("Each Player will now roll a dice do determine the winner!")


                Do While Player1Score = Player2Score
                    Dice1 = Generator.Next(1, 6)
                    Dice2 = Generator.Next(1, 6)

                    ' If the Players scores are the same then it will continue the game
                    ' and only stop, once a gap in scores has been discovered in an If
                    ' statement then the game will continue to crowning a winner.

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
                        Dice3 = Generator.Next(1, 6)
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

                    If Player2Score < 0 Then
                        Player2Score = 0
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

                    Dice1 = Generator.Next(1, 6)
                    Dice2 = Generator.Next(1, 6)

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



                    ElseIf (Dice1 = Dice2) Then
                        Player2Score += (Dice1 + Dice2)
                        Dice3 = Generator.Next(1, 6)
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


                    Else
                        iseven = False
                        Player2Score += (Dice1 + Dice2)
                        Player2Score -= 5
                        P2Score.Text = CStr(Player2Score)
                        Rounds += 1
                        RoundDisplay.Text = CStr(Rounds)

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

                If Player1Score < Player2Score Then
                    TurnDisplay.Text = "Game Over!"
                    MessageBox.Show("Player 2 Won!")
                    Dim winner As New winner
                    winner.WinScore = Player2Score
                    winner.Show()
                    Me.Hide()

                ElseIf Player1Score > Player2Score Then
                    TurnDisplay.Text = "Game Over!"
                    MessageBox.Show("Player 1 Won!")
                    Dim winner As New winner
                    winner.WinScore = Player1Score
                    winner.Show()
                    Me.Hide()
                End If


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
        'This hides the dice until the dice is rolled on startup
        Dice2Face1.Visible = False
        Dice2Face2.Visible = False
        Dice2Face3.Visible = False
        Dice2Face4.Visible = False
        Dice2Face5.Visible = False
        Dice2Face6.Visible = False
    End Sub
End Class
