Public Class Main
    Private Sub Button_Click(sender As Object, e As EventArgs) 
        Try
            Configurations.maxLenght = Convert.ToUInt16(txtMax.Text)
            Configurations.minLenght = Convert.ToUInt16(txtMin.Text)
            Configurations.attempts = Convert.ToUInt16(txtAttempts.Text)
            Configurations.timer = Convert.ToUInt32(txtTimer.Text)

            Configurations.DataBaseUpdate()
            MessageBox.Show("Alteração feita com sucesso!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch
            MessageBox.Show("Digite valores somente interios!", "Formato Incorreto", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub btnCadastrar_Click(sender As Object, e As EventArgs) Handles btnCadastrar.Click
        If Cadastro.DataBaseInsert(txtUser.Text, txtPassword.Text, txtConfirm.Text) = True
            MessageBox.Show("Dados cadastrados com sucesso!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Dados não cadastrados!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        End Sub

    Private Sub btnalterar_Click(sender As Object, e As EventArgs) Handles btnalterar.Click

    End Sub
End Class