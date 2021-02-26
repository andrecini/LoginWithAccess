Imports System.Data.OleDb

Public Class Cadastro
    Inherits Connection

    Public Shared Function DataBaseInsert(ByVal user As String, ByVal password As String, ByVal confirm As String) As Boolean
        
        If Validation.CheckIsNull(user, password, confirm) = True And Validation.CheckConfirmation(password, confirm) = True
            CadastroUser(user, password)
            CadastroConfig(user)
            Return True
        End If
        Return False       
    End Function

    Public Shared Sub CadastroUser(ByVal user As String, ByVal password As String)
        Try 
                Connection.Open()
                Dim str As String
                str = "INSERT INTO [Tabela1] ([user], [password]) VALUES ('@user', '@password')"
                
                Using cmd As New OleDbCommand(str, cn)
                    cmd.Parameters.AddWithValue("@user", user)
                    cmd.Parameters.AddWithValue("@password", password)
                    cmd.ExecuteNonQuery()
                End using
                                        
                Connection.Close()                
            Catch 
                
                MessageBox.Show("Erro com o banco de dados!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
    End Sub

    Public Shared Sub CadastroConfig(ByVal user As String)
        Try 
            Connection.Open()
            Dim str As String
            str = "INSERT INTO [Configuracoes] ([user], [minLenght], [maxLenght], [attempts], [timer]) VALUES ('" & user & "', 4, 8, 999, 9999)"
            Dim cmd As OleDbCommand = New OleDbCommand(str, cn)
            
            cmd.ExecuteNonQuery()
            
            Connection.Close()
            
        Catch 
            
            MessageBox.Show("Erro com o banco de dados!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    

End Class
'Abstraído!!!
