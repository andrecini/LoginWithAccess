Public Class Connection
    Private Shared Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;
                                   Data Source=C:\Users\admin\Documents\Database3.accdb"
    Public Shared Dim cn As New OleDb.OleDbConnection 
    
    Public Shared Sub Open()
        cn.ConnectionString = connectionString
        cn.Open()
    End Sub

    Public Shared Sub Close()
        cn.Close()
    End Sub

End Class
'Abstraído!!!