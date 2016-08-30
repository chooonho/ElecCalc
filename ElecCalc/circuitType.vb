Public Class circuitType
    Private Sub circuitType_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Application.Exit()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Visible = False
        mainMenu.Visible = True
    End Sub

    Private Sub picSeries_Click(sender As Object, e As EventArgs) Handles picSeries.Click
        Me.Visible = False
        seriesCircuit.Visible = True
    End Sub

    Private Sub picParallel_Click(sender As Object, e As EventArgs) Handles picParallel.Click
        Me.Visible = False
        parallelCircuit.Visible = True
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblSeries.Click
        Me.Visible = False
        seriesCircuit.Visible = True
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles lblParallel.Click
        Me.Visible = False
        parallelCircuit.Visible = True
    End Sub
End Class