Imports MySql.Data.MySqlClient

Public Class EntityConnexion
    Dim connection As New MySqlConnection(MainForm.getInstance().connectionString)
    Shared instance As EntityConnexion = Nothing

    Public Shared Function getInstance() As EntityConnexion
        If IsNothing(instance) Then
            instance = New EntityConnexion()
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

    Public Function getUserByMatricule(matricule As Integer) As Integer
        Dim command As New MySqlCommand
        command.Connection = connection
        command.CommandText = $"Select Count(*) from utilisateur where matricule = '{matricule}"
        connection.Open()
        Dim reader = command.ExecuteReader()
        Dim verif = reader
        connection.Close()
        Return verif
    End Function

End Class
