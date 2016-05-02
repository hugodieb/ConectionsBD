Imports System.Data.OleDb
Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient

Module mdlAcesso

    Dim sql As String

    Public Function getConnectionAccess() As OleDbConnection

        sql = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=G:\projetos_vb\conectionsBD\ConectionsBD\bdAccess.accdb"

        Return New OleDbConnection(sql)
    End Function

    Public Function getConnectionMYSQL() As MySqlConnection

        sql = "SERVER=localhost; DATABASE=pessoa;Uid=root;Pwd=root"

        Return New MySqlConnection(sql)
    End Function

    Public Function getConnectionSQLServer() As SqlConnection

        sql = "Data Source=(LocalDB)\v11.0;AttachDbFilename=G:\projetos_vb\conectionsBD\ConectionsBD\Conections\Conections\pessoa.mdf;Integrated Security=True"
        Return New SqlConnection(sql)
    End Function

End Module
