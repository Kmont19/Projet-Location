Imports MySql.Data.MySqlClient

Public Class EntityConnexion
    Dim connection As New MySqlConnection(Connexion.getInstance().connectionString)
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

    Public Function verifUser(matricule As Integer, password As String) As Boolean

        Dim verif = False

        Dim command As New MySqlCommand
        command.Connection = connection
        command.CommandText = $"Select count(*) from utilisateur where matricule = {matricule} and password = {password}"
        connection.Open()
        Dim reader = command.ExecuteReader()

        If (reader.Read = 1) Then
            verif = True
        ElseIf (reader.Read = 0) Then
            verif = False
        End If

        connection.Close()
        Return verif

    End Function

End Class
