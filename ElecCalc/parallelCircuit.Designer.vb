<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class parallelCircuit
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
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.lblWatt = New System.Windows.Forms.Label()
        Me.lblAmpere = New System.Windows.Forms.Label()
        Me.lblOhm = New System.Windows.Forms.Label()
        Me.lblVolt = New System.Windows.Forms.Label()
        Me.lblPowerVal = New System.Windows.Forms.Label()
        Me.txtVoltageVal = New System.Windows.Forms.TextBox()
        Me.lblResist = New System.Windows.Forms.Label()
        Me.lblVoltage = New System.Windows.Forms.Label()
        Me.lblBCrumb1 = New System.Windows.Forms.LinkLabel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblBCrumb3 = New System.Windows.Forms.Label()
        Me.lblCurrentVal = New System.Windows.Forms.Label()
        Me.lblCurrent = New System.Windows.Forms.Label()
        Me.lblResistVal = New System.Windows.Forms.Label()
        Me.lblPower = New System.Windows.Forms.Label()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblBCrumb2 = New System.Windows.Forms.LinkLabel()
        Me.gStats = New System.Windows.Forms.GroupBox()
        Me.chkRounding = New System.Windows.Forms.CheckBox()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gStats.SuspendLayout()
        Me.SuspendLayout()
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
        Me.btnAdd.Location = New System.Drawing.Point(173, 257)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(122, 41)
        Me.btnAdd.TabIndex = 32
        Me.btnAdd.Text = "Add Resistor"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'lblWatt
        '
        Me.lblWatt.AutoSize = True
        Me.lblWatt.Location = New System.Drawing.Point(358, 105)
        Me.lblWatt.Name = "lblWatt"
        Me.lblWatt.Size = New System.Drawing.Size(69, 20)
        Me.lblWatt.TabIndex = 14
        Me.lblWatt.Text = "Watt (W)"
        '
        'lblAmpere
        '
        Me.lblAmpere.AutoSize = True
        Me.lblAmpere.Location = New System.Drawing.Point(358, 78)
        Me.lblAmpere.Name = "lblAmpere"
        Me.lblAmpere.Size = New System.Drawing.Size(86, 20)
        Me.lblAmpere.TabIndex = 13
        Me.lblAmpere.Text = "Ampere (A)"
        '
        'lblOhm
        '
        Me.lblOhm.AutoSize = True
        Me.lblOhm.Location = New System.Drawing.Point(358, 52)
        Me.lblOhm.Name = "lblOhm"
        Me.lblOhm.Size = New System.Drawing.Size(66, 20)
        Me.lblOhm.TabIndex = 12
        Me.lblOhm.Text = "Ohm (Ω)"
        '
        'lblVolt
        '
        Me.lblVolt.AutoSize = True
        Me.lblVolt.Location = New System.Drawing.Point(358, 26)
        Me.lblVolt.Name = "lblVolt"
        Me.lblVolt.Size = New System.Drawing.Size(59, 20)
        Me.lblVolt.TabIndex = 11
        Me.lblVolt.Text = "Volt (V)"
        '
        'lblPowerVal
        '
        Me.lblPowerVal.Location = New System.Drawing.Point(167, 105)
        Me.lblPowerVal.Name = "lblPowerVal"
        Me.lblPowerVal.Size = New System.Drawing.Size(185, 20)
        Me.lblPowerVal.TabIndex = 9
        Me.lblPowerVal.Text = "Power Value"
        Me.lblPowerVal.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtVoltageVal
        '
        Me.txtVoltageVal.Location = New System.Drawing.Point(167, 23)
        Me.txtVoltageVal.Name = "txtVoltageVal"
        Me.txtVoltageVal.Size = New System.Drawing.Size(185, 27)
        Me.txtVoltageVal.TabIndex = 10
        Me.txtVoltageVal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblResist
        '
        Me.lblResist.AutoSize = True
        Me.lblResist.Location = New System.Drawing.Point(69, 52)
        Me.lblResist.Name = "lblResist"
        Me.lblResist.Size = New System.Drawing.Size(85, 20)
        Me.lblResist.TabIndex = 0
        Me.lblResist.Text = "Resistance: "
        '
        'lblVoltage
        '
        Me.lblVoltage.AutoSize = True
        Me.lblVoltage.Location = New System.Drawing.Point(69, 26)
        Me.lblVoltage.Name = "lblVoltage"
        Me.lblVoltage.Size = New System.Drawing.Size(68, 20)
        Me.lblVoltage.TabIndex = 1
        Me.lblVoltage.Text = "Voltage: "
        '
        'lblBCrumb1
        '
        Me.lblBCrumb1.AutoSize = True
        Me.lblBCrumb1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBCrumb1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.lblBCrumb1.LinkColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblBCrumb1.Location = New System.Drawing.Point(12, 10)
        Me.lblBCrumb1.Name = "lblBCrumb1"
        Me.lblBCrumb1.Size = New System.Drawing.Size(64, 20)
        Me.lblBCrumb1.TabIndex = 30
        Me.lblBCrumb1.TabStop = True
        Me.lblBCrumb1.Text = "ElecCalc"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(191, 10)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(19, 20)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = ">"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(80, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(19, 20)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = ">"
        '
        'lblBCrumb3
        '
        Me.lblBCrumb3.AutoSize = True
        Me.lblBCrumb3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBCrumb3.Location = New System.Drawing.Point(213, 10)
        Me.lblBCrumb3.Name = "lblBCrumb3"
        Me.lblBCrumb3.Size = New System.Drawing.Size(104, 20)
        Me.lblBCrumb3.TabIndex = 27
        Me.lblBCrumb3.Text = "Parallel Circuit"
        '
        'lblCurrentVal
        '
        Me.lblCurrentVal.Location = New System.Drawing.Point(167, 78)
        Me.lblCurrentVal.Name = "lblCurrentVal"
        Me.lblCurrentVal.Size = New System.Drawing.Size(185, 20)
        Me.lblCurrentVal.TabIndex = 8
        Me.lblCurrentVal.Text = "Current Value"
        Me.lblCurrentVal.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblCurrent
        '
        Me.lblCurrent.AutoSize = True
        Me.lblCurrent.Location = New System.Drawing.Point(69, 78)
        Me.lblCurrent.Name = "lblCurrent"
        Me.lblCurrent.Size = New System.Drawing.Size(64, 20)
        Me.lblCurrent.TabIndex = 2
        Me.lblCurrent.Text = "Current: "
        '
        'lblResistVal
        '
        Me.lblResistVal.Location = New System.Drawing.Point(167, 52)
        Me.lblResistVal.Name = "lblResistVal"
        Me.lblResistVal.Size = New System.Drawing.Size(185, 20)
        Me.lblResistVal.TabIndex = 6
        Me.lblResistVal.Text = "Resistance Value"
        Me.lblResistVal.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblPower
        '
        Me.lblPower.AutoSize = True
        Me.lblPower.Location = New System.Drawing.Point(69, 105)
        Me.lblPower.Name = "lblPower"
        Me.lblPower.Size = New System.Drawing.Size(57, 20)
        Me.lblPower.TabIndex = 3
        Me.lblPower.Text = "Power: "
        '
        'pictureBox1
        '
        Me.pictureBox1.Image = Global.ElecCalc.My.Resources.Resources.parallel_circuit
        Me.pictureBox1.Location = New System.Drawing.Point(12, 40)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(458, 211)
        Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureBox1.TabIndex = 33
        Me.pictureBox1.TabStop = False
        '
        'lblBCrumb2
        '
        Me.lblBCrumb2.AutoSize = True
        Me.lblBCrumb2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBCrumb2.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.lblBCrumb2.LinkColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblBCrumb2.Location = New System.Drawing.Point(102, 10)
        Me.lblBCrumb2.Name = "lblBCrumb2"
        Me.lblBCrumb2.Size = New System.Drawing.Size(87, 20)
        Me.lblBCrumb2.TabIndex = 31
        Me.lblBCrumb2.TabStop = True
        Me.lblBCrumb2.Text = "Circuit Type"
        '
        'gStats
        '
        Me.gStats.Controls.Add(Me.lblWatt)
        Me.gStats.Controls.Add(Me.lblAmpere)
        Me.gStats.Controls.Add(Me.lblOhm)
        Me.gStats.Controls.Add(Me.lblVolt)
        Me.gStats.Controls.Add(Me.lblPowerVal)
        Me.gStats.Controls.Add(Me.txtVoltageVal)
        Me.gStats.Controls.Add(Me.lblResist)
        Me.gStats.Controls.Add(Me.lblVoltage)
        Me.gStats.Controls.Add(Me.lblResistVal)
        Me.gStats.Controls.Add(Me.lblCurrentVal)
        Me.gStats.Controls.Add(Me.lblCurrent)
        Me.gStats.Controls.Add(Me.lblPower)
        Me.gStats.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.gStats.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gStats.Location = New System.Drawing.Point(0, 315)
        Me.gStats.Name = "gStats"
        Me.gStats.Size = New System.Drawing.Size(482, 138)
        Me.gStats.TabIndex = 26
        Me.gStats.TabStop = False
        Me.gStats.Text = "Circuit Stats"
        '
        'chkRounding
        '
        Me.chkRounding.AutoSize = True
        Me.chkRounding.Location = New System.Drawing.Point(330, 277)
        Me.chkRounding.Name = "chkRounding"
        Me.chkRounding.Size = New System.Drawing.Size(140, 21)
        Me.chkRounding.TabIndex = 34
        Me.chkRounding.Text = "Round-off Values"
        Me.chkRounding.UseVisualStyleBackColor = True
        '
        'parallelCircuit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(482, 453)
        Me.Controls.Add(Me.chkRounding)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.lblBCrumb1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblBCrumb3)
        Me.Controls.Add(Me.pictureBox1)
        Me.Controls.Add(Me.lblBCrumb2)
        Me.Controls.Add(Me.gStats)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "parallelCircuit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Parallel Circuit"
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gStats.ResumeLayout(False)
        Me.gStats.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents lblWatt As System.Windows.Forms.Label
    Friend WithEvents lblAmpere As System.Windows.Forms.Label
    Friend WithEvents lblOhm As System.Windows.Forms.Label
    Friend WithEvents lblVolt As System.Windows.Forms.Label
    Friend WithEvents lblPowerVal As System.Windows.Forms.Label
    Friend WithEvents txtVoltageVal As System.Windows.Forms.TextBox
    Friend WithEvents lblResist As System.Windows.Forms.Label
    Friend WithEvents lblVoltage As System.Windows.Forms.Label
    Friend WithEvents lblBCrumb1 As System.Windows.Forms.LinkLabel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblBCrumb3 As System.Windows.Forms.Label
    Friend WithEvents lblCurrentVal As System.Windows.Forms.Label
    Friend WithEvents lblCurrent As System.Windows.Forms.Label
    Friend WithEvents lblResistVal As System.Windows.Forms.Label
    Friend WithEvents lblPower As System.Windows.Forms.Label
    Friend WithEvents pictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblBCrumb2 As System.Windows.Forms.LinkLabel
    Friend WithEvents gStats As System.Windows.Forms.GroupBox
    Friend WithEvents chkRounding As System.Windows.Forms.CheckBox
End Class
