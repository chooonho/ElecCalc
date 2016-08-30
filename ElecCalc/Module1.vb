Module Module1
    Public Sub CalculateStats(ByVal VoltageVal As Object, ByVal ResistanceVal As Object, ByVal CurrentVal As Object, ByVal PowerVal As Object, ByVal Circuit As Object, ByVal Rounding As Object)
        If VoltageVal.Text <> "" And ResistanceVal.Text <> "" Then
            Try
                Dim Current As Double = GetCurrent(Circuit.Resistance, Val(VoltageVal.Text))
                Dim Power As Double = GetPower(Val(VoltageVal.Text), Current)
                If Rounding.Checked = True Then
                    CurrentVal.Text = CStr(Math.Round(Current, 2))
                    PowerVal.Text = CStr(Math.Round(Power, 2))
                Else
                    CurrentVal.Text = Current
                    PowerVal.Text = Power
                End If
            Catch ex As Exception
                MessageBox.Show("One does not play around with high voltage.")
            End Try
        End If
    End Sub

    Public Function GetPower(ByVal Voltage As Double, ByVal Current As Double) As Double
        Dim Power As Double
        Power = Voltage * Current
        Return Power
    End Function

    Public Function GetCurrent(ByVal Resistance As Double, ByVal Voltage As Double) As Double
        Dim Current As Double
        Current = Voltage / Resistance
        Return Current
    End Function

    Public Sub AddResistor(ByVal cBoxA As Object, ByVal cBoxB As Object, ByVal cBoxC As Object, ByVal cBoxD As Object, ByVal OutputList As Object, ByRef TotalResistance As Double, ByVal Series As Boolean)
        Dim Validate As Boolean = True
        Dim cBox(3) As Object
        cBox(0) = cBoxA
        cBox(1) = cBoxB
        cBox(2) = cBoxC
        cBox(3) = cBoxD
        For Each a As Object In cBox
            If a.SelectedItem = "" Then
                Validate = False
            End If
        Next
        If Validate = True Then
            Dim Band(3) As String
            Band(0) = CStr(ConvColor(cBox(0)))
            Band(1) = CStr(ConvColor(cBox(1)))
            Band(2) = CStr(Math.Pow(10, ConvColor(cBox(2))))
            Band(3) = CStr(ConvColor(cBox(3))) & "%"
            Dim BandAB As String = Band(0) & Band(1)
            Dim BandABC As Double = Val(BandAB) * Val(Band(2))
            Dim BandABCD As String = CStr(BandABC) & "Ω ±" & Band(3)
            OutputList.Items.Add(BandABCD)
            If Series = True Then
                TotalResistance += BandABC
                seriesCircuit.lblResistVal.Text = CStr(Math.Round(seriesOptions.Resistance, 2))
            Else
                If BandABC <> 0 Then
                    TotalResistance += (1 / BandABC)
                    parallelCircuit.lblResistVal.Text = CStr(Math.Round(parallelOptions.Resistance, 2))
                Else
                    MessageBox.Show("Cannot divide by 0.")
                End If
            End If
        End If
    End Sub

    Public Sub RemoveResistor(ByVal InputList As Object, ByRef TotalResistance As Double, ByVal Series As Boolean)
        If InputList.SelectedItems.Count > 0 Then
            Dim SelectedItem As String = InputList.SelectedItem
            Dim StartPos As Integer = InStr(SelectedItem, "Ω") - 1
            Dim SubStr As String = SelectedItem.Substring(StartPos)
            Dim Resistance As String = SelectedItem.Replace(SubStr, "")
            If Series = True Then
                TotalResistance -= Val(Resistance)
                seriesCircuit.lblResistVal.Text = CStr(Math.Round(seriesOptions.Resistance, 2))
            Else
                If InputList.Items.Count = 1 Then
                    TotalResistance = 0
                    parallelCircuit.lblResistVal.Text = "0"
                Else
                    TotalResistance -= (1 / Val(Resistance))
                    parallelCircuit.lblResistVal.Text = CStr(Math.Round(parallelOptions.Resistance, 2))
                End If
            End If
            InputList.Items.Remove(InputList.SelectedItem)
        Else
            MessageBox.Show("Please select a resistor!")
        End If
    End Sub

    Public Sub AddFormula(ByVal cBoxA As Object, ByVal cBoxB As Object, ByVal cBoxC As Object, ByVal cBoxD As Object, ByVal Output As Object)
        Dim Formula As String
        Dim BandA As String = "A"
        Dim BandB As String = "B"
        Dim BandC As String = "C"
        Dim BandD As String = "D"
        If cBoxA.selecteditem <> "" Then
            BandA = CStr(ConvColor(cBoxA))
        End If
        If cBoxB.selecteditem <> "" Then
            BandB = CStr(ConvColor(cBoxB))
        End If
        If cBoxC.selecteditem <> "" Then
            BandC = CStr(ConvColor(cBoxC))
        End If
        If cBoxD.selecteditem <> "" Then
            BandD = CStr(ConvColor(cBoxD))
        End If
        Formula = BandA & BandB & " * 10^" & BandC & " Ω ±" & BandD & "%"
        Output.Text = Formula
    End Sub

    Public Function ConvColor(ByVal cBox As Object) As Integer
        Dim i As Integer
        Select Case cBox.SelectedItem
            Case "Black"
                i = 0
            Case "Brown"
                i = 1
            Case "Red"
                i = 2
            Case "Orange"
                i = 3
            Case "Yellow"
                i = 4
            Case "Green"
                i = 5
            Case "Blue"
                i = 6
            Case "Violet"
                i = 7
            Case "Gray"
                i = 8
            Case "White"
                i = 9
            Case "Gold"
                i = 5
            Case "Silver"
                i = 10
            Case "None"
                i = 20
        End Select
        Return i
    End Function

    Public Function SetColor(ByVal cBox As Object) As Object
        Select Case cBox.SelectedItem
            Case "Black"
                Return Color.Black
            Case "Brown"
                Return Color.Brown
            Case "Red"
                Return Color.Red
            Case "Orange"
                Return Color.Orange
            Case "Yellow"
                Return Color.Yellow
            Case "Green"
                Return Color.Green
            Case "Blue"
                Return Color.Blue
            Case "Violet"
                Return Color.Violet
            Case "Gray"
                Return Color.Gray
            Case "White"
                Return Color.White
            Case "Gold"
                Return Color.Gold
            Case "Silver"
                Return Color.Silver
            Case "None"
                Return Color.FromArgb(201, 125, 26)
            Case Else
                Return Color.FromArgb(201, 125, 26)
        End Select
    End Function

    Public Function StringFind(ByVal String1 As String, ByVal String2 As String) As Boolean
        Dim Status As Boolean = False
        If InStr(String1, string2) > 0 Then
            Status = True
        End If
        Return Status
    End Function
End Module