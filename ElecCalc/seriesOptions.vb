Public Class seriesOptions
    Dim ColorA As System.Drawing.Color = Color.FromArgb(201, 125, 26)
    Dim ColorB As System.Drawing.Color = Color.FromArgb(201, 125, 26)
    Dim ColorC As System.Drawing.Color = Color.FromArgb(201, 125, 26)
    Dim ColorD As System.Drawing.Color = Color.FromArgb(201, 125, 26)
    Dim FWidth As Integer
    Dim FHeight As Integer
    Dim TotalResistance As Double

    Public ReadOnly Property Resistance As Double
        Get
            Return TotalResistance
        End Get
    End Property

    Private Sub seriesOptions_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Hide()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Call AddResistor(cBoxA, cBoxB, cBoxC, cBoxD, listBox1, TotalResistance, True)
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        Call RemoveResistor(listBox1, TotalResistance, True)
    End Sub

    Private Sub cboxA_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cBoxA.SelectedIndexChanged
        Call AddFormula(cBoxA, cBoxB, cBoxC, cBoxD, txtFormula)
        ColorA = SetColor(cBoxA)
        Me.Refresh()
    End Sub

    Private Sub cboxB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cBoxB.SelectedIndexChanged
        Call AddFormula(cBoxA, cBoxB, cBoxC, cBoxD, txtFormula)
        ColorB = SetColor(cBoxB)
        Me.Refresh()
    End Sub

    Private Sub cboxC_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cBoxC.SelectedIndexChanged
        Call AddFormula(cBoxA, cBoxB, cBoxC, cBoxD, txtFormula)
        ColorC = SetColor(cBoxC)
        Me.Refresh()
    End Sub

    Private Sub cboxD_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cBoxD.SelectedIndexChanged
        Call AddFormula(cBoxA, cBoxB, cBoxC, cBoxD, txtFormula)
        ColorD = SetColor(cBoxD)
        Me.Refresh()
    End Sub

    Private Sub seriesOptions_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        Dim BlackLine As New Drawing.Pen(Color.Black, 5)
        Dim ResistorBody As New Drawing.SolidBrush(Color.FromArgb(201, 125, 26))
        Dim BrushA As New Drawing.SolidBrush(ColorA)
        Dim BrushB As New Drawing.SolidBrush(ColorB)
        Dim BrushC As New Drawing.SolidBrush(ColorC)
        Dim BrushD As New Drawing.SolidBrush(ColorD)
        e.Graphics.DrawLine(BlackLine, 0, CInt(FHeight * 0.06), FWidth, CInt(FHeight * 0.06))
        e.Graphics.FillRectangle(ResistorBody, CInt(FWidth * 0.22), CInt(FHeight * 0.01), CInt(FWidth * 0.52), CInt(FHeight * 0.1))
        e.Graphics.FillRectangle(BrushA, CInt(FWidth * 0.39), CInt(FHeight * 0.01), CInt(FWidth * 0.03), CInt(FHeight * 0.1))
        e.Graphics.FillRectangle(BrushB, CInt((FWidth * 0.39) + (FWidth * 0.05)), CInt(FHeight * 0.01), CInt(FWidth * 0.03), CInt(FHeight * 0.1))
        e.Graphics.FillRectangle(BrushC, CInt((FWidth * 0.39) + ((FWidth * 0.05) * 2)), CInt(FHeight * 0.01), CInt(FWidth * 0.03), CInt(FHeight * 0.1))
        e.Graphics.FillRectangle(BrushD, CInt((FWidth * 0.39) + ((FWidth * 0.05) * 3)), CInt(FHeight * 0.01), CInt(FWidth * 0.03), CInt(FHeight * 0.1))
    End Sub

    Private Sub parallelOptions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FWidth = Me.Width
        FHeight = Me.Height
        lblA.Location = New Point(CInt(FWidth * 0.38), CInt(FHeight * 0.11))
        lblB.Location = New Point(CInt((FWidth * 0.38) + (FWidth * 0.05)), CInt(FHeight * 0.11))
        lblC.Location = New Point(CInt((FWidth * 0.38) + ((FWidth * 0.05) * 2)), CInt(FHeight * 0.11))
        lblD.Location = New Point(CInt((FWidth * 0.38) + ((FWidth * 0.05) * 3)), CInt(FHeight * 0.11))
        Me.Location = New Point(seriesCircuit.Location.X + seriesCircuit.Width, seriesCircuit.Location.Y)
    End Sub
End Class