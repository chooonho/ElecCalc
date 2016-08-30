<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mainMenu))
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnCredits = New System.Windows.Forms.Button()
        Me.btnStart = New System.Windows.Forms.Button()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pictureBox1
        '
        Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"), System.Drawing.Image)
        Me.pictureBox1.Location = New System.Drawing.Point(12, -1)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(358, 143)
        Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureBox1.TabIndex = 8
        Me.pictureBox1.TabStop = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Transparent
        Me.btnExit.BackgroundImage = Global.ElecCalc.My.Resources.Resources.orangeBg
        Me.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnExit.FlatAppearance.BorderSize = 0
        Me.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.White
        Me.btnExit.Location = New System.Drawing.Point(115, 283)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(151, 56)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnCredits
        '
        Me.btnCredits.BackColor = System.Drawing.Color.Transparent
        Me.btnCredits.BackgroundImage = Global.ElecCalc.My.Resources.Resources.orangeBg
        Me.btnCredits.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCredits.FlatAppearance.BorderSize = 0
        Me.btnCredits.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnCredits.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnCredits.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCredits.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCredits.ForeColor = System.Drawing.Color.White
        Me.btnCredits.Location = New System.Drawing.Point(115, 221)
        Me.btnCredits.Name = "btnCredits"
        Me.btnCredits.Size = New System.Drawing.Size(151, 56)
        Me.btnCredits.TabIndex = 6
        Me.btnCredits.Text = "Credits"
        Me.btnCredits.UseVisualStyleBackColor = False
        '
        'btnStart
        '
        Me.btnStart.BackColor = System.Drawing.Color.Transparent
        Me.btnStart.BackgroundImage = Global.ElecCalc.My.Resources.Resources.orangeBg
        Me.btnStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnStart.FlatAppearance.BorderSize = 0
        Me.btnStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStart.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStart.ForeColor = System.Drawing.Color.White
        Me.btnStart.Location = New System.Drawing.Point(115, 159)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(151, 56)
        Me.btnStart.TabIndex = 5
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = False
        '
        'mainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(382, 353)
        Me.Controls.Add(Me.pictureBox1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCredits)
        Me.Controls.Add(Me.btnStart)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "mainMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ElecCalc"
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnCredits As System.Windows.Forms.Button
    Friend WithEvents btnStart As System.Windows.Forms.Button

End Class
