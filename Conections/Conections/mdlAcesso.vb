Imports System.Data.OleDb

Module mdlAcesso

    Dim sql As String

    Public Function getConnectionAccess() As OleDbConnection

        sql = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=G:\projetos_vb\conectionsBD\bdAccess.accdb"

        Return New OleDbConnection(sql)
    End Function

End Module
