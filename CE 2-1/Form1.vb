Public Class Form1

    'MIS 322
    'Damanbir Singh
    'CE 2-1
    '9/30/2022

    'declare variables

    Private x, y As Integer

    Private clickCount As Integer


    Private Sub gameButton_Click(sender As Object, e As EventArgs) Handles gameButton.Click

        'display name of game the amount of times we want

        Convert.ToInt32(numberOfTimesText.Text)

        y = numberOfTimesText.Text

        numberOfTimesText.Text = " "

        moviesGamesText.Text = " "
        x = "0"

        Do While x < y

            moviesGamesText.Text = "NBA 2K16" & vbNewLine & moviesGamesText.Text

            clicksText.Text = clicksText.Text & x

            x += +1

        Loop

        clickCount += 1

        clicksText.Text = " " & clickCount.ToString

    End Sub

    Private Sub movieButton_Click(sender As Object, e As EventArgs) Handles movieButton.Click

        'display movie name as many times as we want

        Convert.ToInt32(numberOfTimesText.Text)

        y = numberOfTimesText.Text

        numberOfTimesText.Text = " "

        moviesGamesText.Text = " "
        x = "0"

        Do While x < y

            moviesGamesText.Text = "3 Idiots" & vbNewLine & moviesGamesText.Text

            clicksText.Text = clicksText.Text & x

            x += +1


        Loop

        clickCount += 1

        clicksText.Text = " " & clickCount.ToString



    End Sub
End Class
