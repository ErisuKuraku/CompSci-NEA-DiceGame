<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class winner
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
        Me.Playing_Label = New System.Windows.Forms.Label()
        Me.Title_Label = New System.Windows.Forms.Label()
        Me.Name_TXB = New System.Windows.Forms.TextBox()
        Me.Submit_BTN = New System.Windows.Forms.Button()
        Me.Leaderboard_TXB = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Playing_Label
        '
        Me.Playing_Label.AutoSize = True
        Me.Playing_Label.Font = New System.Drawing.Font("Gill Sans MT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Playing_Label.Location = New System.Drawing.Point(34, 9)
        Me.Playing_Label.Name = "Playing_Label"
        Me.Playing_Label.Size = New System.Drawing.Size(190, 27)
        Me.Playing_Label.TabIndex = 1
        Me.Playing_Label.Text = "Thank You For Playing!"
        '
        'Title_Label
        '
        Me.Title_Label.AutoSize = True
        Me.Title_Label.Font = New System.Drawing.Font("Gill Sans MT", 12.0!)
        Me.Title_Label.Location = New System.Drawing.Point(58, 48)
        Me.Title_Label.Name = "Title_Label"
        Me.Title_Label.Size = New System.Drawing.Size(139, 23)
        Me.Title_Label.TabIndex = 2
        Me.Title_Label.Text = "What is your name?"
        '
        'Name_TXB
        '
        Me.Name_TXB.Location = New System.Drawing.Point(62, 74)
        Me.Name_TXB.Name = "Name_TXB"
        Me.Name_TXB.Size = New System.Drawing.Size(135, 20)
        Me.Name_TXB.TabIndex = 3
        '
        'Submit_BTN
        '
        Me.Submit_BTN.Font = New System.Drawing.Font("Gill Sans MT", 12.0!)
        Me.Submit_BTN.Location = New System.Drawing.Point(90, 100)
        Me.Submit_BTN.Name = "Submit_BTN"
        Me.Submit_BTN.Size = New System.Drawing.Size(75, 34)
        Me.Submit_BTN.TabIndex = 4
        Me.Submit_BTN.Text = "Submit"
        Me.Submit_BTN.UseVisualStyleBackColor = True
        '
        'Leaderboard_TXB
        '
        Me.Leaderboard_TXB.Location = New System.Drawing.Point(39, 74)
        Me.Leaderboard_TXB.Multiline = True
        Me.Leaderboard_TXB.Name = "Leaderboard_TXB"
        Me.Leaderboard_TXB.Size = New System.Drawing.Size(185, 116)
        Me.Leaderboard_TXB.TabIndex = 5
        Me.Leaderboard_TXB.Visible = False
        '
        'winner
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(263, 225)
        Me.Controls.Add(Me.Leaderboard_TXB)
        Me.Controls.Add(Me.Submit_BTN)
        Me.Controls.Add(Me.Name_TXB)
        Me.Controls.Add(Me.Title_Label)
        Me.Controls.Add(Me.Playing_Label)
        Me.MaximumSize = New System.Drawing.Size(279, 263)
        Me.MinimumSize = New System.Drawing.Size(279, 263)
        Me.Name = "winner"
        Me.Text = "winner"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Playing_Label As Label
    Friend WithEvents Title_Label As Label
    Friend WithEvents Name_TXB As TextBox
    Friend WithEvents Submit_BTN As Button
    Friend WithEvents Leaderboard_TXB As TextBox
End Class
