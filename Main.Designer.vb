<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btnCadastrar = New System.Windows.Forms.Button()
        Me.txtConfirm = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtTimer = New System.Windows.Forms.TextBox()
        Me.txtAttempts = New System.Windows.Forms.TextBox()
        Me.txtMax = New System.Windows.Forms.TextBox()
        Me.txtMin = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtUserForgotten = New System.Windows.Forms.TextBox()
        Me.txtnewPassword = New System.Windows.Forms.TextBox()
        Me.txtConfimForgotten = New System.Windows.Forms.TextBox()
        Me.txtSecurity = New System.Windows.Forms.TextBox()
        Me.btnalterar = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout
        Me.TabPage1.SuspendLayout
        Me.TabPage2.SuspendLayout
        Me.TabPage3.SuspendLayout
        Me.SuspendLayout
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(11, 8)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(272, 209)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btnCadastrar)
        Me.TabPage1.Controls.Add(Me.txtConfirm)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.txtPassword)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.txtUser)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(264, 183)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Cadastro"
        Me.TabPage1.UseVisualStyleBackColor = true
        '
        'btnCadastrar
        '
        Me.btnCadastrar.Location = New System.Drawing.Point(155, 137)
        Me.btnCadastrar.Name = "btnCadastrar"
        Me.btnCadastrar.Size = New System.Drawing.Size(77, 24)
        Me.btnCadastrar.TabIndex = 6
        Me.btnCadastrar.Text = "Cadastrar"
        Me.btnCadastrar.UseVisualStyleBackColor = true
        '
        'txtConfirm
        '
        Me.txtConfirm.Location = New System.Drawing.Point(93, 101)
        Me.txtConfirm.Name = "txtConfirm"
        Me.txtConfirm.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtConfirm.Size = New System.Drawing.Size(140, 20)
        Me.txtConfirm.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = true
        Me.Label7.Location = New System.Drawing.Point(42, 104)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 13)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Confirm:"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(93, 68)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(140, 20)
        Me.txtPassword.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = true
        Me.Label6.Location = New System.Drawing.Point(31, 71)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Password:"
        '
        'txtUser
        '
        Me.txtUser.Location = New System.Drawing.Point(93, 33)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(140, 20)
        Me.txtUser.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = true
        Me.Label5.Location = New System.Drawing.Point(55, 36)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "User:"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Button1)
        Me.TabPage2.Controls.Add(Me.txtTimer)
        Me.TabPage2.Controls.Add(Me.txtAttempts)
        Me.TabPage2.Controls.Add(Me.txtMax)
        Me.TabPage2.Controls.Add(Me.txtMin)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(264, 183)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Config."
        Me.TabPage2.UseVisualStyleBackColor = true
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(162, 145)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Alterar"
        Me.Button1.UseVisualStyleBackColor = true
        '
        'txtTimer
        '
        Me.txtTimer.Location = New System.Drawing.Point(149, 115)
        Me.txtTimer.Name = "txtTimer"
        Me.txtTimer.Size = New System.Drawing.Size(88, 20)
        Me.txtTimer.TabIndex = 16
        '
        'txtAttempts
        '
        Me.txtAttempts.Location = New System.Drawing.Point(149, 82)
        Me.txtAttempts.Name = "txtAttempts"
        Me.txtAttempts.Size = New System.Drawing.Size(88, 20)
        Me.txtAttempts.TabIndex = 15
        '
        'txtMax
        '
        Me.txtMax.Location = New System.Drawing.Point(149, 47)
        Me.txtMax.Name = "txtMax"
        Me.txtMax.Size = New System.Drawing.Size(88, 20)
        Me.txtMax.TabIndex = 14
        '
        'txtMin
        '
        Me.txtMin.Location = New System.Drawing.Point(149, 15)
        Me.txtMin.Name = "txtMin"
        Me.txtMin.Size = New System.Drawing.Size(88, 20)
        Me.txtMin.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Location = New System.Drawing.Point(29, 118)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Timer de utilização:"
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Location = New System.Drawing.Point(28, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Limite de tentativas:"
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Location = New System.Drawing.Point(29, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Tamanho Máximo:"
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Location = New System.Drawing.Point(29, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Tamanho Mínimo:"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.btnalterar)
        Me.TabPage3.Controls.Add(Me.txtSecurity)
        Me.TabPage3.Controls.Add(Me.txtConfimForgotten)
        Me.TabPage3.Controls.Add(Me.txtnewPassword)
        Me.TabPage3.Controls.Add(Me.txtUserForgotten)
        Me.TabPage3.Controls.Add(Me.Label11)
        Me.TabPage3.Controls.Add(Me.Label10)
        Me.TabPage3.Controls.Add(Me.Label9)
        Me.TabPage3.Controls.Add(Me.Label8)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(264, 183)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Trocar Senha"
        Me.TabPage3.UseVisualStyleBackColor = true
        '
        'Label8
        '
        Me.Label8.AutoSize = true
        Me.Label8.Location = New System.Drawing.Point(21, 14)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(32, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "User:"
        '
        'Label9
        '
        Me.Label9.AutoSize = true
        Me.Label9.Location = New System.Drawing.Point(21, 42)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(81, 13)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "New Password:"
        '
        'Label10
        '
        Me.Label10.AutoSize = true
        Me.Label10.Location = New System.Drawing.Point(21, 71)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(45, 13)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Confirm:"
        '
        'Label11
        '
        Me.Label11.AutoSize = true
        Me.Label11.Location = New System.Drawing.Point(21, 117)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(76, 13)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "Security Code:"
        '
        'txtUserForgotten
        '
        Me.txtUserForgotten.Location = New System.Drawing.Point(123, 11)
        Me.txtUserForgotten.Name = "txtUserForgotten"
        Me.txtUserForgotten.Size = New System.Drawing.Size(121, 20)
        Me.txtUserForgotten.TabIndex = 4
        '
        'txtnewPassword
        '
        Me.txtnewPassword.Location = New System.Drawing.Point(123, 39)
        Me.txtnewPassword.Name = "txtnewPassword"
        Me.txtnewPassword.Size = New System.Drawing.Size(121, 20)
        Me.txtnewPassword.TabIndex = 5
        '
        'txtConfimForgotten
        '
        Me.txtConfimForgotten.Location = New System.Drawing.Point(123, 68)
        Me.txtConfimForgotten.Name = "txtConfimForgotten"
        Me.txtConfimForgotten.Size = New System.Drawing.Size(121, 20)
        Me.txtConfimForgotten.TabIndex = 6
        '
        'txtSecurity
        '
        Me.txtSecurity.Location = New System.Drawing.Point(123, 114)
        Me.txtSecurity.Name = "txtSecurity"
        Me.txtSecurity.Size = New System.Drawing.Size(121, 20)
        Me.txtSecurity.TabIndex = 7
        '
        'btnalterar
        '
        Me.btnalterar.Location = New System.Drawing.Point(160, 145)
        Me.btnalterar.Name = "btnalterar"
        Me.btnalterar.Size = New System.Drawing.Size(84, 27)
        Me.btnalterar.TabIndex = 8
        Me.btnalterar.Text = "Alterar"
        Me.btnalterar.UseVisualStyleBackColor = true
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(294, 225)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Main"
        Me.Text = "Configurations"
        Me.TabControl1.ResumeLayout(false)
        Me.TabPage1.ResumeLayout(false)
        Me.TabPage1.PerformLayout
        Me.TabPage2.ResumeLayout(false)
        Me.TabPage2.PerformLayout
        Me.TabPage3.ResumeLayout(false)
        Me.TabPage3.PerformLayout
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents txtConfirm As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtUser As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Button1 As Button
    Friend WithEvents txtTimer As TextBox
    Friend WithEvents txtAttempts As TextBox
    Friend WithEvents txtMax As TextBox
    Friend WithEvents txtMin As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCadastrar As Button
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents btnalterar As Button
    Friend WithEvents txtSecurity As TextBox
    Friend WithEvents txtConfimForgotten As TextBox
    Friend WithEvents txtnewPassword As TextBox
    Friend WithEvents txtUserForgotten As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
End Class
