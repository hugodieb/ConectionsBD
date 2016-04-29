Imports System.Data.OleDb

Public Class main

    Private sql As String
    Private cmd As OleDbCommand
    Private da As OleDbDataAdapter
    Private dt As DataTable

    Private Sub loadDataAccess()
        Using con As OleDbConnection = getConnectionAccess()

            Try
                con.Open()
                sql = "SELECT * FROM cadastro"
                cmd = New OleDbCommand(sql, con)
                da = New OleDbDataAdapter(cmd)
                dt = New DataTable

                da.Fill(dt)
                dgvBD.DataSource = dt

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()

            End Try

        End Using
    End Sub

    
    Private Sub btnAccess_Click(sender As Object, e As EventArgs) Handles btnAccess.Click
        loadDataAccess()
    End Sub
End Class
