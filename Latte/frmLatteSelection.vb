'Eddie Switek
'CST 171 Fall 2018
'9-30-18
'Chapter 3 Guided Program Development
'
'This program allows the user to choose between two different Lattes
'and display a picture of that selection.

Public Class frmLatteSelection
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnPumpkin_Click(sender As Object, e As EventArgs) Handles btnSpice.Click
        'This is to make sure that the pumpkin spice picture shows and hides the Mocha picture.
        picSpice.Show()
        picMocha.Hide()
        btnSelect.Enabled() = True

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'This closes the window and the program.
        Me.Close()
    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        'This confirms the User's selection and disables the other options.
        lblInstructions.Visible = False
        btnMocha.Enabled = False
        btnSpice.Enabled = False

        lblConfirmation.Show()
    End Sub

    Private Sub btnMocha_Click(sender As Object, e As EventArgs) Handles btnMocha.Click
        'This makes sure to show the Mocha picture and hides the Pupmkin Spice picture.
        picMocha.Show()
        picSpice.Hide()
        btnSelect.Enabled() = True
    End Sub

    Private Sub btnExit_MouseHover(sender As Object, e As EventArgs) Handles btnExit.MouseHover
        'This describes to the user what the exit button is used for.
        lblExit.Show()
    End Sub
End Class
