Imports System.Data.OleDb

Public Class Validation
    Inherits Configurations      
        
    Public Shared Function Existence(ByVal field As String, ByVal contents As String) As Boolean
              
        Connection.Open()
        cmd.Connection = cn
        cmd.CommandText = "SELECT * FROM Tabela1 " & _
           " WHERE " & field & " = '" & contents & "'"
        
        Dim reader As OleDbDataReader
        reader = cmd.ExecuteReader()
        
        If reader.Read() = false 
            Connection.Close()
            Return False
        Else 
            Connection.Close()
            Return true
        End If
        
    End Function

    Public Shared Function CheckSize() As Boolean
        If (password.Length < minLenght Or password.Length > maxLenght)
            MessageBox.Show("Tamanho incorreto!", "Formato incorreto", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            Return False
        End If

        Return True
    End Function

    Public Shared Function CheckAttempts() As Boolean
        counter+=1
        
        If counter >= Configurations.attempts
            Return False
        End If
        Return true
    End Function

    #Region "Sobrecarga CheckIsNull"
    Public Shared Function CheckIsNull() As Boolean
        If password = "" Or user = ""
            Return False
        End If
        Return True
    End Function

    Public Shared Function CheckIsNull(ByVal user As String, ByVal password As String, ByVal confirm As String) As Boolean
        If password = "" Or user = "" Or confirm = ""
            Return False
        End If
        Return True
    End Function

    Public Shared Function CheckIsNull(ByVal user As String, ByVal password As String, 
                      ByVal confirm As String, ByVal securityCode As String) As Boolean
        
        If password = "" Or user = "" Or confirm = "" Or securityCode = ""
            Return False
        End If
        Return True
     End Function
    #End Region

    Public Shared Function CheckAll (ByVal field1 As String, ByVal contents1 As String, ByVal field2 As String, ByVal contents2 As String) As Boolean
        If CheckIsNull() = False
            MessageBox.Show("Complete todos os campos!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        ElseIf  Existence(field1, contents1) = False And Existence(field2, contents2) = False
            MessageBox.Show("Usuário e Senha incorretos!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        ElseIf Existence(field1, contents1) = False
            MessageBox.Show("Usuário incorreto!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        ElseIf Existence(field2, contents2) = False
            MessageBox.Show("Senha incorreta!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        Else
            Return True
        End If
    End Function
  
    Public Shared Function CheckConfirmation(ByVal password1 As String, ByVal password2 As String) As Boolean
        If password1 = password2
            Return True
        End If
        Return False
    End Function
End Class
'Abstraído
