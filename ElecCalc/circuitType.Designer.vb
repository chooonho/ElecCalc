<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class circuitType
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
        Me.lblParallel = New System.Windows.Forms.Label()
        Me.lblSeries = New System.Windows.Forms.Label()
        Me.picParallel = New System.Windows.Forms.PictureBox()
        Me.picSeries = New System.Windows.Forms.PictureBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.lblInst = New System.Windows.Forms.Label()
        CType(Me.picParallel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSeries, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblParallel
        '
        Me.lblParallel.AutoSize = True
        Me.lblParallel.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblParallel.Location = New System.Drawing.Point(391, 302)
        Me.lblParallel.Name = "lblParallel"
        Me.lblParallel.Size = New System.Drawing.Size(58, 20)
        Me.lblParallel.TabIndex = 13
        Me.lblParallel.Text = "Parallel"
        '
        'lblSeries
        '
        Me.lblSeries.AutoSize = True
        Me.lblSeries.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblSeries.Location = New System.Drawing.Point(139, 302)
        Me.lblSeries.Name = "lblSeries"
        Me.lblSeries.Size = New System.Drawing.Size(48, 20)
        Me.lblSeries.TabIndex = 12
        Me.lblSeries.Text = "Series"
        '
        'picParallel
        '
        Me.picParallel.Image = Global.ElecCalc.My.Resources.Resources.parallel_circuit
        Me.picParallel.Location = New System.Drawing.Point(294, 78)
        Me.picParallel.Name = "picParallel"
        Me.picParallel.Size = New System.Drawing.Size(250, 221)
        Me.picParallel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picParallel.TabIndex = 11
        Me.picParallel.TabStop = False
        '
        'picSeries
        '
        Me.picSeries.Image = Global.ElecCalc.My.Resources.Resources.series_circuit
        Me.picSeries.Location = New System.Drawing.Point(36, 78)
        Me.picSeries.Name = "picSeries"
        Me.picSeries.Size = New System.Drawing.Size(250, 221)
        Me.picSeries.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picSeries.TabIndex = 10
        Me.picSeries.TabStop = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Transparent
        Me.btnBack.BackgroundImage = Global.ElecCalc.My.Resources.Resources.orangeBg
        Me.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBack.FlatAppearance.BorderSize = 0
        Me.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnBack.ForeColor = System.Drawing.Color.White
        Me.btnBack.Location = New System.Drawing.Point(227, 347)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(127, 53)
        Me.btnBack.TabIndex = 9
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'lblInst
        '
        Me.lblInst.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblInst.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInst.Location = New System.Drawing.Point(0, 0)
        Me.lblInst.Name = "lblInst"
        Me.lblInst.Size = New System.Drawing.Size(582, 59)
        Me.lblInst.TabIndex = 8
        Me.lblInst.Text = "Choose your preferred circuit:"
        Me.lblInst.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'circuitType
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(582, 453)
        Me.Controls.Add(Me.lblParallel)
        Me.Controls.Add(Me.lblSeries)
        Me.Controls.Add(Me.picParallel)
        Me.Controls.Add(Me.picSeries)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lblInst)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "circuitType"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Choose your preferred circuit"
        CType(Me.picParallel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSeries, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblParallel As System.Windows.Forms.Label
    Friend WithEvents lblSeries As System.Windows.Forms.Label
    Friend WithEvents picParallel As System.Windows.Forms.PictureBox
    Friend WithEvents picSeries As System.Windows.Forms.PictureBox
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents lblInst As System.Windows.Forms.Label
End Class
