<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class game
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(game))
        Me.SP_BTN = New System.Windows.Forms.Button()
        Me.TP_BTN = New System.Windows.Forms.Button()
        Me.P1Score = New System.Windows.Forms.Label()
        Me.P2Score = New System.Windows.Forms.Label()
        Me.DiceFace1 = New System.Windows.Forms.PictureBox()
        Me.DiceFace2 = New System.Windows.Forms.PictureBox()
        Me.DiceFace3 = New System.Windows.Forms.PictureBox()
        Me.DiceFace6 = New System.Windows.Forms.PictureBox()
        Me.DiceFace5 = New System.Windows.Forms.PictureBox()
        Me.DiceFace4 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RoundDisplay = New System.Windows.Forms.Label()
        Me.Dice2Face4 = New System.Windows.Forms.PictureBox()
        Me.Dice2Face5 = New System.Windows.Forms.PictureBox()
        Me.Dice2Face6 = New System.Windows.Forms.PictureBox()
        Me.Dice2Face3 = New System.Windows.Forms.PictureBox()
        Me.Dice2Face2 = New System.Windows.Forms.PictureBox()
        Me.Dice2Face1 = New System.Windows.Forms.PictureBox()
        Me.TurnDisplay = New System.Windows.Forms.Label()
        CType(Me.DiceFace1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DiceFace2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DiceFace3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DiceFace6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DiceFace5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DiceFace4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dice2Face4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dice2Face5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dice2Face6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dice2Face3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dice2Face2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dice2Face1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SP_BTN
        '
        Me.SP_BTN.Location = New System.Drawing.Point(16, 455)
        Me.SP_BTN.Name = "SP_BTN"
        Me.SP_BTN.Size = New System.Drawing.Size(75, 23)
        Me.SP_BTN.TabIndex = 0
        Me.SP_BTN.Text = "P1 Roll Dice"
        Me.SP_BTN.UseVisualStyleBackColor = True
        '
        'TP_BTN
        '
        Me.TP_BTN.Location = New System.Drawing.Point(263, 455)
        Me.TP_BTN.Name = "TP_BTN"
        Me.TP_BTN.Size = New System.Drawing.Size(76, 23)
        Me.TP_BTN.TabIndex = 1
        Me.TP_BTN.Text = "P2 Roll Dice"
        Me.TP_BTN.UseVisualStyleBackColor = True
        '
        'P1Score
        '
        Me.P1Score.AutoSize = True
        Me.P1Score.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.P1Score.Location = New System.Drawing.Point(12, 420)
        Me.P1Score.Name = "P1Score"
        Me.P1Score.Size = New System.Drawing.Size(87, 24)
        Me.P1Score.TabIndex = 2
        Me.P1Score.Text = "P1 Score"
        '
        'P2Score
        '
        Me.P2Score.AutoSize = True
        Me.P2Score.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.P2Score.Location = New System.Drawing.Point(259, 420)
        Me.P2Score.Name = "P2Score"
        Me.P2Score.Size = New System.Drawing.Size(87, 24)
        Me.P2Score.TabIndex = 3
        Me.P2Score.Text = "P2 Score"
        '
        'DiceFace1
        '
        Me.DiceFace1.Image = CType(resources.GetObject("DiceFace1.Image"), System.Drawing.Image)
        Me.DiceFace1.Location = New System.Drawing.Point(12, 12)
        Me.DiceFace1.Name = "DiceFace1"
        Me.DiceFace1.Size = New System.Drawing.Size(100, 85)
        Me.DiceFace1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.DiceFace1.TabIndex = 4
        Me.DiceFace1.TabStop = False
        '
        'DiceFace2
        '
        Me.DiceFace2.Image = CType(resources.GetObject("DiceFace2.Image"), System.Drawing.Image)
        Me.DiceFace2.Location = New System.Drawing.Point(127, 12)
        Me.DiceFace2.Name = "DiceFace2"
        Me.DiceFace2.Size = New System.Drawing.Size(100, 85)
        Me.DiceFace2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.DiceFace2.TabIndex = 5
        Me.DiceFace2.TabStop = False
        '
        'DiceFace3
        '
        Me.DiceFace3.Image = CType(resources.GetObject("DiceFace3.Image"), System.Drawing.Image)
        Me.DiceFace3.Location = New System.Drawing.Point(248, 12)
        Me.DiceFace3.Name = "DiceFace3"
        Me.DiceFace3.Size = New System.Drawing.Size(100, 85)
        Me.DiceFace3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.DiceFace3.TabIndex = 6
        Me.DiceFace3.TabStop = False
        '
        'DiceFace6
        '
        Me.DiceFace6.Image = CType(resources.GetObject("DiceFace6.Image"), System.Drawing.Image)
        Me.DiceFace6.Location = New System.Drawing.Point(248, 103)
        Me.DiceFace6.Name = "DiceFace6"
        Me.DiceFace6.Size = New System.Drawing.Size(100, 85)
        Me.DiceFace6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.DiceFace6.TabIndex = 7
        Me.DiceFace6.TabStop = False
        '
        'DiceFace5
        '
        Me.DiceFace5.Image = CType(resources.GetObject("DiceFace5.Image"), System.Drawing.Image)
        Me.DiceFace5.Location = New System.Drawing.Point(127, 103)
        Me.DiceFace5.Name = "DiceFace5"
        Me.DiceFace5.Size = New System.Drawing.Size(100, 85)
        Me.DiceFace5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.DiceFace5.TabIndex = 8
        Me.DiceFace5.TabStop = False
        '
        'DiceFace4
        '
        Me.DiceFace4.Image = CType(resources.GetObject("DiceFace4.Image"), System.Drawing.Image)
        Me.DiceFace4.Location = New System.Drawing.Point(12, 103)
        Me.DiceFace4.Name = "DiceFace4"
        Me.DiceFace4.Size = New System.Drawing.Size(100, 85)
        Me.DiceFace4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.DiceFace4.TabIndex = 9
        Me.DiceFace4.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(139, 465)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Round: "
        '
        'RoundDisplay
        '
        Me.RoundDisplay.AutoSize = True
        Me.RoundDisplay.Location = New System.Drawing.Point(178, 465)
        Me.RoundDisplay.Name = "RoundDisplay"
        Me.RoundDisplay.Size = New System.Drawing.Size(0, 13)
        Me.RoundDisplay.TabIndex = 11
        '
        'Dice2Face4
        '
        Me.Dice2Face4.Image = CType(resources.GetObject("Dice2Face4.Image"), System.Drawing.Image)
        Me.Dice2Face4.Location = New System.Drawing.Point(12, 285)
        Me.Dice2Face4.Name = "Dice2Face4"
        Me.Dice2Face4.Size = New System.Drawing.Size(100, 85)
        Me.Dice2Face4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Dice2Face4.TabIndex = 17
        Me.Dice2Face4.TabStop = False
        '
        'Dice2Face5
        '
        Me.Dice2Face5.Image = CType(resources.GetObject("Dice2Face5.Image"), System.Drawing.Image)
        Me.Dice2Face5.Location = New System.Drawing.Point(127, 285)
        Me.Dice2Face5.Name = "Dice2Face5"
        Me.Dice2Face5.Size = New System.Drawing.Size(100, 85)
        Me.Dice2Face5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Dice2Face5.TabIndex = 16
        Me.Dice2Face5.TabStop = False
        '
        'Dice2Face6
        '
        Me.Dice2Face6.Image = CType(resources.GetObject("Dice2Face6.Image"), System.Drawing.Image)
        Me.Dice2Face6.Location = New System.Drawing.Point(248, 285)
        Me.Dice2Face6.Name = "Dice2Face6"
        Me.Dice2Face6.Size = New System.Drawing.Size(100, 85)
        Me.Dice2Face6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Dice2Face6.TabIndex = 15
        Me.Dice2Face6.TabStop = False
        '
        'Dice2Face3
        '
        Me.Dice2Face3.Image = CType(resources.GetObject("Dice2Face3.Image"), System.Drawing.Image)
        Me.Dice2Face3.Location = New System.Drawing.Point(248, 194)
        Me.Dice2Face3.Name = "Dice2Face3"
        Me.Dice2Face3.Size = New System.Drawing.Size(100, 85)
        Me.Dice2Face3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Dice2Face3.TabIndex = 14
        Me.Dice2Face3.TabStop = False
        '
        'Dice2Face2
        '
        Me.Dice2Face2.Image = CType(resources.GetObject("Dice2Face2.Image"), System.Drawing.Image)
        Me.Dice2Face2.Location = New System.Drawing.Point(127, 194)
        Me.Dice2Face2.Name = "Dice2Face2"
        Me.Dice2Face2.Size = New System.Drawing.Size(100, 85)
        Me.Dice2Face2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Dice2Face2.TabIndex = 13
        Me.Dice2Face2.TabStop = False
        '
        'Dice2Face1
        '
        Me.Dice2Face1.Image = CType(resources.GetObject("Dice2Face1.Image"), System.Drawing.Image)
        Me.Dice2Face1.Location = New System.Drawing.Point(12, 194)
        Me.Dice2Face1.Name = "Dice2Face1"
        Me.Dice2Face1.Size = New System.Drawing.Size(100, 85)
        Me.Dice2Face1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Dice2Face1.TabIndex = 12
        Me.Dice2Face1.TabStop = False
        '
        'TurnDisplay
        '
        Me.TurnDisplay.AutoSize = True
        Me.TurnDisplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.TurnDisplay.Location = New System.Drawing.Point(114, 420)
        Me.TurnDisplay.Name = "TurnDisplay"
        Me.TurnDisplay.Size = New System.Drawing.Size(130, 24)
        Me.TurnDisplay.TabIndex = 18
        Me.TurnDisplay.Text = "Player1's Turn"
        '
        'game
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(360, 496)
        Me.Controls.Add(Me.TurnDisplay)
        Me.Controls.Add(Me.Dice2Face4)
        Me.Controls.Add(Me.Dice2Face5)
        Me.Controls.Add(Me.Dice2Face6)
        Me.Controls.Add(Me.Dice2Face3)
        Me.Controls.Add(Me.Dice2Face2)
        Me.Controls.Add(Me.Dice2Face1)
        Me.Controls.Add(Me.RoundDisplay)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DiceFace4)
        Me.Controls.Add(Me.DiceFace5)
        Me.Controls.Add(Me.DiceFace6)
        Me.Controls.Add(Me.DiceFace3)
        Me.Controls.Add(Me.DiceFace2)
        Me.Controls.Add(Me.DiceFace1)
        Me.Controls.Add(Me.P2Score)
        Me.Controls.Add(Me.P1Score)
        Me.Controls.Add(Me.TP_BTN)
        Me.Controls.Add(Me.SP_BTN)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(376, 534)
        Me.MinimumSize = New System.Drawing.Size(376, 534)
        Me.Name = "game"
        Me.Text = "NEA_DiceGame"
        CType(Me.DiceFace1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DiceFace2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DiceFace3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DiceFace6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DiceFace5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DiceFace4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dice2Face4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dice2Face5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dice2Face6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dice2Face3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dice2Face2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dice2Face1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SP_BTN As Button
    Friend WithEvents TP_BTN As Button
    Friend WithEvents P1Score As Label
    Friend WithEvents P2Score As Label
    Friend WithEvents DiceFace1 As PictureBox
    Friend WithEvents DiceFace2 As PictureBox
    Friend WithEvents DiceFace3 As PictureBox
    Friend WithEvents DiceFace6 As PictureBox
    Friend WithEvents DiceFace5 As PictureBox
    Friend WithEvents DiceFace4 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents RoundDisplay As Label
    Friend WithEvents Dice2Face4 As PictureBox
    Friend WithEvents Dice2Face5 As PictureBox
    Friend WithEvents Dice2Face6 As PictureBox
    Friend WithEvents Dice2Face3 As PictureBox
    Friend WithEvents Dice2Face2 As PictureBox
    Friend WithEvents Dice2Face1 As PictureBox
    Friend WithEvents TurnDisplay As Label
End Class
