Public Class seriesCircuit
    Private Sub seriesCircuit_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Application.Exit()
    End Sub

    Private Sub seriesCircuit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblCurrentVal.Text = "0"
        lblPowerVal.Text = "0"
        lblResistVal.Text = "0"
        txtVoltageVal.Text = "0"
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        seriesOptions.ShowDialog()
    End Sub

    Private Sub lblResistVal_TextChanged(sender As Object, e As EventArgs) Handles lblResistVal.TextChanged
        Call CalculateStats(txtVoltageVal, lblResistVal, lblCurrentVal, lblPowerVal, seriesOptions, chkRounding)
    End Sub

    Private Sub txtVoltageVal_TextChanged(sender As Object, e As EventArgs) Handles txtVoltageVal.TextChanged
        Call CalculateStats(txtVoltageVal, lblResistVal, lblCurrentVal, lblPowerVal, seriesOptions, chkRounding)
    End Sub

    Private Sub txtVoltageVal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtVoltageVal.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If (Asc(e.KeyChar) < 48 And Asc(e.KeyChar) <> 46) Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            ElseIf Asc(e.KeyChar) = 46 Then
                If StringFind(txtVoltageVal.Text, ".") = True Then
                    e.Handled = True
                End If
            End If
        End If
    End Sub

    Private Sub lblBCrumb2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblBCrumb2.LinkClicked
        Me.Visible = False
        circuitType.Visible = True
    End Sub

    Private Sub lblBCrumb1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblBCrumb1.LinkClicked
        Me.Visible = False
        mainMenu.Visible = True
    End Sub

    Private Sub chkRounding_CheckedChanged(sender As Object, e As EventArgs) Handles chkRounding.CheckedChanged
        Call CalculateStats(txtVoltageVal, lblResistVal, lblCurrentVal, lblPowerVal, seriesOptions, chkRounding)
    End Sub
End Class