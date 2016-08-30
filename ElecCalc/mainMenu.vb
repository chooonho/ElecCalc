Public Class mainMenu
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Me.Visible = False
        circuitType.Visible = True
    End Sub

    Private Sub btnCredits_Click(sender As Object, e As EventArgs) Handles btnCredits.Click
        creditsForm.ShowDialog()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub
End Class