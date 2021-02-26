Public Class Login
    Private Const V As Boolean = False

    Private Sub btnCancela_Click(sender As Object, e As EventArgs) Handles btnCancela.Click
       Me.Close()
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        Dim Validation As New Validation
        Configurations.password = txtpassword.Text
        Configurations.user = txtUser.Text
        Configurations.DataBaseCollect()  
        
        If Validation.CheckAll("user", txtUser.Text, "password", txtpassword.Text) = True
            Dim screen As New Main
            Me.Hide()
            screen.ShowDialog()
        End If

    End Sub

    Dim mostraSenha As Boolean = true

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If mostraSenha
            txtpassword.PasswordChar = ""
            mostraSenha = false
        Else
            txtpassword.PasswordChar = "*"
            mostraSenha = true
        End If
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Configurations.DataBaseUpdate()
    End Sub
End Class
