Imports System.Data.OleDb
Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient

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

    Private Sub loadDataMYSQL()
        Using con As MySqlConnection = getConnectionMYSQL()

            Try
                con.Open()
                sql = "SELECT * FROM cadastro"

                Dim cm As MySqlCommand
                Dim da As MySqlDataAdapter
                cm = New MySqlCommand(sql, con)
                da = New MySqlDataAdapter(cm)
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

    Private Sub loadDataSQLServer()
        Dim cm As SqlCommand
        Dim da As SqlDataAdapter
        Dim dt As DataTable

        Using con As SqlConnection = getConnectionSQLServer()
            Try
                con.Open()

                sql = "SELECT * FROM CADASTRO"

                cm = New SqlCommand(sql, con)
                da = New SqlDataAdapter(cm)
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

    Private Sub btnMYSQL_Click(sender As Object, e As EventArgs) Handles btnMYSQL.Click
        loadDataMYSQL()
    End Sub

    Private Sub btnSQLServer_Click(sender As Object, e As EventArgs) Handles btnSQLServer.Click
        loadDataSQLServer()
    End Sub
End Class
