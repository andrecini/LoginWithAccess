<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.picUser = New System.Windows.Forms.PictureBox()
        Me.picKey = New System.Windows.Forms.PictureBox()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbEmpresas = New System.Windows.Forms.ComboBox()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.btnCancela = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        CType(Me.picUser,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.picKey,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'picUser
        '
        Me.picUser.Location = New System.Drawing.Point(17, 16)
        Me.picUser.Name = "picUser"
        Me.picUser.Size = New System.Drawing.Size(35, 35)
        Me.picUser.TabIndex = 0
        Me.picUser.TabStop = false
        '
        'picKey
        '
        Me.picKey.Location = New System.Drawing.Point(17, 66)
        Me.picKey.Name = "picKey"
        Me.picKey.Size = New System.Drawing.Size(35, 35)
        Me.picKey.TabIndex = 1
        Me.picKey.TabStop = false
        '
        'txtUser
        '
        Me.txtUser.Location = New System.Drawing.Point(70, 31)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(160, 20)
        Me.txtUser.TabIndex = 2
        '
        'txtpassword
        '
        Me.txtpassword.Location = New System.Drawing.Point(70, 82)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpassword.Size = New System.Drawing.Size(160, 20)
        Me.txtpassword.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label1.Location = New System.Drawing.Point(67, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Login:"
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label2.Location = New System.Drawing.Point(67, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Senha:"
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Empresa:"
        '
        'cbEmpresas
        '
        Me.cbEmpresas.FormattingEnabled = true
        Me.cbEmpresas.Location = New System.Drawing.Point(19, 130)
        Me.cbEmpresas.Name = "cbEmpresas"
        Me.cbEmpresas.Size = New System.Drawing.Size(212, 21)
        Me.cbEmpresas.TabIndex = 7
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(41, 158)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(75, 23)
        Me.btnOk.TabIndex = 8
        Me.btnOk.Text = "OK"
        Me.btnOk.UseVisualStyleBackColor = true
        '
        'btnCancela
        '
        Me.btnCancela.Location = New System.Drawing.Point(131, 158)
        Me.btnCancela.Name = "btnCancela"
        Me.btnCancela.Size = New System.Drawing.Size(75, 23)
        Me.btnCancela.TabIndex = 9
        Me.btnCancela.Text = "CANCELA"
        Me.btnCancela.UseVisualStyleBackColor = true
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = true
        Me.CheckBox1.Location = New System.Drawing.Point(137, 107)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(93, 17)
        Me.CheckBox1.TabIndex = 10
        Me.CheckBox1.Text = "Mostrar senha"
        Me.CheckBox1.UseVisualStyleBackColor = true
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(246, 193)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.btnCancela)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.cbEmpresas)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtpassword)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.picKey)
        Me.Controls.Add(Me.picUser)
        Me.Name = "Login"
        Me.Text = "LOGIN"
        CType(Me.picUser,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.picKey,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents picUser As PictureBox
    Friend WithEvents picKey As PictureBox
    Friend WithEvents txtUser As TextBox
    Friend WithEvents txtpassword As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cbEmpresas As ComboBox
    Friend WithEvents btnOk As Button
    Friend WithEvents btnCancela As Button
    Friend WithEvents CheckBox1 As CheckBox
End Class
