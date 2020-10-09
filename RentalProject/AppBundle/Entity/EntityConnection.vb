Imports MySql.Data.MySqlClient

Public Class EntityConnection

    Dim connection As New MySqlConnection(MainForm.getInstance().connectionString)
    Shared instance As EntityConnection = Nothing

    Public Shared Function getInstance() As EntityConnection
        If IsNothing(instance) Then
            instance = New EntityConnection()
        End If
        Return instance
    End Function

    Public Function getUser() As DataTable
        Dim command As New MySqlCommand
        command.Connection = connection
        command.CommandText = $"Select * from utilisateur"
        connection.Open()
        Dim reader = command.ExecuteReader()
        Dim table As New DataTable("utilisateur")
        table.Load(reader)
        connection.Close()
        Return table
    End Function

    Public Function getUserByStatut(statut As String) As DataTable
        Dim command As New MySqlCommand
        command.Connection = connection
        command.CommandText = $"Select * from utilisateur where statut = {statut}"
        connection.Open()
        Dim reader = command.ExecuteReader()
        Dim table As New DataTable("utilisateur")
        table.Load(reader)
        connection.Close()
        Return table
    End Function

End Class
