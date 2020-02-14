<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(login))
        Me.User_TXB = New System.Windows.Forms.TextBox()
        Me.Pass_TXB = New System.Windows.Forms.TextBox()
        Me.Login_BTN = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'User_TXB
        '
        Me.User_TXB.Location = New System.Drawing.Point(66, 13)
        Me.User_TXB.Name = "User_TXB"
        Me.User_TXB.Size = New System.Drawing.Size(162, 20)
        Me.User_TXB.TabIndex = 0
        '
        'Pass_TXB
        '
        Me.Pass_TXB.Location = New System.Drawing.Point(66, 40)
        Me.Pass_TXB.Name = "Pass_TXB"
        Me.Pass_TXB.Size = New System.Drawing.Size(162, 20)
        Me.Pass_TXB.TabIndex = 1
        Me.Pass_TXB.UseSystemPasswordChar = True
        '
        'Login_BTN
        '
        Me.Login_BTN.Location = New System.Drawing.Point(110, 66)
        Me.Login_BTN.Name = "Login_BTN"
        Me.Login_BTN.Size = New System.Drawing.Size(75, 23)
        Me.Login_BTN.TabIndex = 2
        Me.Login_BTN.Text = "Login"
        Me.Login_BTN.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Username"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Password"
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(256, 99)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Login_BTN)
        Me.Controls.Add(Me.Pass_TXB)
        Me.Controls.Add(Me.User_TXB)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(272, 137)
        Me.MinimumSize = New System.Drawing.Size(272, 137)
        Me.Name = "login"
        Me.Text = "Please login to Continue"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents User_TXB As TextBox
    Friend WithEvents Pass_TXB As TextBox
    Friend WithEvents Login_BTN As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
