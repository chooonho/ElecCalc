<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class seriesOptions
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblA = New System.Windows.Forms.Label()
        Me.lblBandA = New System.Windows.Forms.Label()
        Me.lblBandB = New System.Windows.Forms.Label()
        Me.lblD = New System.Windows.Forms.Label()
        Me.lblC = New System.Windows.Forms.Label()
        Me.cBoxA = New System.Windows.Forms.ComboBox()
        Me.cBoxB = New System.Windows.Forms.ComboBox()
        Me.txtFormula = New System.Windows.Forms.TextBox()
        Me.gColorCode = New System.Windows.Forms.GroupBox()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.cBoxD = New System.Windows.Forms.ComboBox()
        Me.lblBandC = New System.Windows.Forms.Label()
        Me.cBoxC = New System.Windows.Forms.ComboBox()
        Me.lblBandD = New System.Windows.Forms.Label()
        Me.lblB = New System.Windows.Forms.Label()
        Me.listBox1 = New System.Windows.Forms.ListBox()
        Me.gColorCode.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblA
        '
        Me.lblA.AutoSize = True
        Me.lblA.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblA.Location = New System.Drawing.Point(142, 56)
        Me.lblA.Name = "lblA"
        Me.lblA.Size = New System.Drawing.Size(19, 20)
        Me.lblA.TabIndex = 29
        Me.lblA.Text = "A"
        '
        'lblBandA
        '
        Me.lblBandA.AutoSize = True
        Me.lblBandA.Location = New System.Drawing.Point(12, 27)
        Me.lblBandA.Name = "lblBandA"
        Me.lblBandA.Size = New System.Drawing.Size(57, 20)
        Me.lblBandA.TabIndex = 1
        Me.lblBandA.Text = "Band A"
        '
        'lblBandB
        '
        Me.lblBandB.AutoSize = True
        Me.lblBandB.Location = New System.Drawing.Point(12, 57)
        Me.lblBandB.Name = "lblBandB"
        Me.lblBandB.Size = New System.Drawing.Size(56, 20)
        Me.lblBandB.TabIndex = 2
        Me.lblBandB.Text = "Band B"
        '
        'lblD
        '
        Me.lblD.AutoSize = True
        Me.lblD.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblD.Location = New System.Drawing.Point(202, 56)
        Me.lblD.Name = "lblD"
        Me.lblD.Size = New System.Drawing.Size(20, 20)
        Me.lblD.TabIndex = 32
        Me.lblD.Text = "D"
        '
        'lblC
        '
        Me.lblC.AutoSize = True
        Me.lblC.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblC.Location = New System.Drawing.Point(182, 56)
        Me.lblC.Name = "lblC"
        Me.lblC.Size = New System.Drawing.Size(18, 20)
        Me.lblC.TabIndex = 31
        Me.lblC.Text = "C"
        '
        'cBoxA
        '
        Me.cBoxA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cBoxA.FormattingEnabled = True
        Me.cBoxA.Items.AddRange(New Object() {"Black", "Brown", "Red", "Orange", "Yellow", "Green", "Blue", "Violet", "Gray", "White"})
        Me.cBoxA.Location = New System.Drawing.Point(132, 24)
        Me.cBoxA.Name = "cBoxA"
        Me.cBoxA.Size = New System.Drawing.Size(121, 28)
        Me.cBoxA.TabIndex = 6
        '
        'cBoxB
        '
        Me.cBoxB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cBoxB.FormattingEnabled = True
        Me.cBoxB.Items.AddRange(New Object() {"Black", "Brown", "Red", "Orange", "Yellow", "Green", "Blue", "Violet", "Gray", "White"})
        Me.cBoxB.Location = New System.Drawing.Point(132, 54)
        Me.cBoxB.Name = "cBoxB"
        Me.cBoxB.Size = New System.Drawing.Size(121, 28)
        Me.cBoxB.TabIndex = 7
        '
        'txtFormula
        '
        Me.txtFormula.Enabled = False
        Me.txtFormula.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFormula.Location = New System.Drawing.Point(0, 138)
        Me.txtFormula.Name = "txtFormula"
        Me.txtFormula.ReadOnly = True
        Me.txtFormula.Size = New System.Drawing.Size(382, 27)
        Me.txtFormula.TabIndex = 28
        Me.txtFormula.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'gColorCode
        '
        Me.gColorCode.Controls.Add(Me.cBoxA)
        Me.gColorCode.Controls.Add(Me.btnRemove)
        Me.gColorCode.Controls.Add(Me.lblBandA)
        Me.gColorCode.Controls.Add(Me.btnAdd)
        Me.gColorCode.Controls.Add(Me.lblBandB)
        Me.gColorCode.Controls.Add(Me.cBoxB)
        Me.gColorCode.Controls.Add(Me.cBoxD)
        Me.gColorCode.Controls.Add(Me.lblBandC)
        Me.gColorCode.Controls.Add(Me.cBoxC)
        Me.gColorCode.Controls.Add(Me.lblBandD)
        Me.gColorCode.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.gColorCode.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gColorCode.Location = New System.Drawing.Point(0, 301)
        Me.gColorCode.Name = "gColorCode"
        Me.gColorCode.Size = New System.Drawing.Size(382, 152)
        Me.gColorCode.TabIndex = 27
        Me.gColorCode.TabStop = False
        Me.gColorCode.Text = "Color Code"
        '
        'btnRemove
        '
        Me.btnRemove.BackColor = System.Drawing.Color.Transparent
        Me.btnRemove.BackgroundImage = Global.ElecCalc.My.Resources.Resources.orangeBg
        Me.btnRemove.FlatAppearance.BorderSize = 0
        Me.btnRemove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnRemove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemove.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnRemove.ForeColor = System.Drawing.Color.White
        Me.btnRemove.Location = New System.Drawing.Point(281, 84)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(89, 61)
        Me.btnRemove.TabIndex = 12
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.Transparent
        Me.btnAdd.BackgroundImage = Global.ElecCalc.My.Resources.Resources.orangeBg
        Me.btnAdd.FlatAppearance.BorderSize = 0
        Me.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.Location = New System.Drawing.Point(281, 15)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(89, 63)
        Me.btnAdd.TabIndex = 11
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'cBoxD
        '
        Me.cBoxD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cBoxD.FormattingEnabled = True
        Me.cBoxD.Items.AddRange(New Object() {"Gold", "Silver", "None"})
        Me.cBoxD.Location = New System.Drawing.Point(132, 114)
        Me.cBoxD.Name = "cBoxD"
        Me.cBoxD.Size = New System.Drawing.Size(121, 28)
        Me.cBoxD.TabIndex = 9
        '
        'lblBandC
        '
        Me.lblBandC.AutoSize = True
        Me.lblBandC.Location = New System.Drawing.Point(12, 87)
        Me.lblBandC.Name = "lblBandC"
        Me.lblBandC.Size = New System.Drawing.Size(56, 20)
        Me.lblBandC.TabIndex = 3
        Me.lblBandC.Text = "Band C"
        '
        'cBoxC
        '
        Me.cBoxC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cBoxC.FormattingEnabled = True
        Me.cBoxC.Items.AddRange(New Object() {"Black", "Brown", "Red", "Orange", "Yellow", "Green", "Blue", "Violet", "Gray", "White"})
        Me.cBoxC.Location = New System.Drawing.Point(132, 84)
        Me.cBoxC.Name = "cBoxC"
        Me.cBoxC.Size = New System.Drawing.Size(121, 28)
        Me.cBoxC.TabIndex = 8
        '
        'lblBandD
        '
        Me.lblBandD.AutoSize = True
        Me.lblBandD.Location = New System.Drawing.Point(11, 117)
        Me.lblBandD.Name = "lblBandD"
        Me.lblBandD.Size = New System.Drawing.Size(58, 20)
        Me.lblBandD.TabIndex = 4
        Me.lblBandD.Text = "Band D"
        '
        'lblB
        '
        Me.lblB.AutoSize = True
        Me.lblB.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblB.Location = New System.Drawing.Point(162, 56)
        Me.lblB.Name = "lblB"
        Me.lblB.Size = New System.Drawing.Size(18, 20)
        Me.lblB.TabIndex = 30
        Me.lblB.Text = "B"
        '
        'listBox1
        '
        Me.listBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listBox1.FormattingEnabled = True
        Me.listBox1.ItemHeight = 20
        Me.listBox1.Location = New System.Drawing.Point(0, 171)
        Me.listBox1.Name = "listBox1"
        Me.listBox1.Size = New System.Drawing.Size(382, 124)
        Me.listBox1.TabIndex = 26
        '
        'seriesOptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(382, 453)
        Me.Controls.Add(Me.lblA)
        Me.Controls.Add(Me.lblD)
        Me.Controls.Add(Me.lblC)
        Me.Controls.Add(Me.txtFormula)
        Me.Controls.Add(Me.gColorCode)
        Me.Controls.Add(Me.lblB)
        Me.Controls.Add(Me.listBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "seriesOptions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Resistor"
        Me.gColorCode.ResumeLayout(False)
        Me.gColorCode.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblA As System.Windows.Forms.Label
    Friend WithEvents lblBandA As System.Windows.Forms.Label
    Friend WithEvents lblBandB As System.Windows.Forms.Label
    Friend WithEvents lblD As System.Windows.Forms.Label
    Friend WithEvents lblC As System.Windows.Forms.Label
    Friend WithEvents cBoxA As System.Windows.Forms.ComboBox
    Friend WithEvents cBoxB As System.Windows.Forms.ComboBox
    Friend WithEvents txtFormula As System.Windows.Forms.TextBox
    Friend WithEvents gColorCode As System.Windows.Forms.GroupBox
    Friend WithEvents btnRemove As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents cBoxD As System.Windows.Forms.ComboBox
    Friend WithEvents lblBandC As System.Windows.Forms.Label
    Friend WithEvents cBoxC As System.Windows.Forms.ComboBox
    Friend WithEvents lblBandD As System.Windows.Forms.Label
    Friend WithEvents lblB As System.Windows.Forms.Label
    Friend WithEvents listBox1 As System.Windows.Forms.ListBox
End Class
