Imports System.Data
Imports System.Data.OleDb

Public Class Configurations
    Inherits Connection
    
    #Region "Variáveis de configuração"
    Public Shared Dim maxLenght As Int16   
    Public Shared Dim minLenght As Int16   
    Public Shared Dim attempts As Int16       
    Public Shared Dim timer As Int16   
    Public Shared Dim password As String
    Public Shared Dim user As String
    Public Shared Dim counter As Int16
    #End Region

    #Region "Variáveis de Banco de Dados"
    Public Shared Dim cmd As New OleDb.OleDbCommand
    Private Shared Dim dr As OleDb.OleDbDataReader
    #End Region
    
    Public Shared Sub DataBaseUpdate()
        Open()
        cmd.Connection = cn
        cmd.CommandText = "UPDATE Configuracoes SET minLenght = " & minLenght & ", maxLenght = " & maxLenght & ", Attempts = " & attempts & " WHERE user = '" & user & "'"

        cmd.ExecuteNonQuery()
        
        Close()
        
    End Sub

    Public Shared Sub DataBaseCollect()
        Connection.Open()
        Dim str As String
        str = "SELECT * FROM Configuracoes WHERE (user = '" & user & "')"
        Dim cmd As OleDbCommand = New OleDbCommand(str, cn)
        dr = cmd.ExecuteReader()
        
        While dr.Read()
            minLenght = Convert.ToInt16(dr("minLenght"))
            maxLenght = Convert.ToInt16(dr("maxLenght"))
            attempts = Convert.ToInt16(dr("attempts"))
            timer = Convert.ToInt32(dr("timer"))
        End While

        Connection.Close()
    End Sub
    
End Class
'Abstraido