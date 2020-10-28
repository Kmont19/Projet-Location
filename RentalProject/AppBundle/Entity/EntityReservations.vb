Imports MySql.Data.MySqlClient


Public Class EntityReservations

    Dim connection As New MySqlConnection(MainForm.getInstance().connectionString)
    Shared instance As EntityReservations = Nothing

    Public Shared Function getInstance() As EntityReservations
        If IsNothing(instance) Then
            instance = New EntityReservations()
        End If
        Return instance
    End Function

    Public Function getReservation() As DataTable
        Dim command As New MySqlCommand
        command.Connection = connection
        command.CommandText = $"Select distinct E.ID, initcap(concat(P.nom, ', ', P.prenom)) as Emprunté_par, initcap(E.autorisation) as autorisation from emprunt E inner join personne P on E.noPersonne = P.noPersonne order by E.ID"
        connection.Open()
        Dim reader = command.ExecuteReader()
        Dim table As New DataTable("Reservation")
        table.Load(reader)
        connection.Close()
        Return table
    End Function

End Class