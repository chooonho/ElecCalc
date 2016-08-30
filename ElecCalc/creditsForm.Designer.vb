<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class creditsForm
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
        Me.lblCreator3 = New System.Windows.Forms.Label()
        Me.lblCreator2 = New System.Windows.Forms.Label()
        Me.lblCreator1 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblCreator3
        '
        Me.lblCreator3.AutoSize = True
        Me.lblCreator3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblCreator3.Location = New System.Drawing.Point(48, 163)
        Me.lblCreator3.Name = "lblCreator3"
        Me.lblCreator3.Size = New System.Drawing.Size(185, 20)
        Me.lblCreator3.TabIndex = 7
        Me.lblCreator3.Text = "Chong Ee Xen 1122703183"
        '
        'lblCreator2
        '
        Me.lblCreator2.AutoSize = True
        Me.lblCreator2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblCreator2.Location = New System.Drawing.Point(48, 133)
        Me.lblCreator2.Name = "lblCreator2"
        Me.lblCreator2.Size = New System.Drawing.Size(188, 20)
        Me.lblCreator2.TabIndex = 6
        Me.lblCreator2.Text = "Ooi Choon Ho 1122702995"
        '
        'lblCreator1
        '
        Me.lblCreator1.AutoSize = True
        Me.lblCreator1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblCreator1.Location = New System.Drawing.Point(48, 102)
        Me.lblCreator1.Name = "lblCreator1"
        Me.lblCreator1.Size = New System.Drawing.Size(178, 20)
        Me.lblCreator1.TabIndex = 5
        Me.lblCreator1.Text = "Lee Zhen Zhi 1122702996"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(36, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(211, 23)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Designed and Tested by: "
        '
        'creditsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(282, 253)
        Me.Controls.Add(Me.lblCreator3)
        Me.Controls.Add(Me.lblCreator2)
        Me.Controls.Add(Me.lblCreator1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "creditsForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Credits"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCreator3 As System.Windows.Forms.Label
    Friend WithEvents lblCreator2 As System.Windows.Forms.Label
    Friend WithEvents lblCreator1 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
