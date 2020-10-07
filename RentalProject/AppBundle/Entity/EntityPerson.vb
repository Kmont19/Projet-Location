Imports MySql.Data.MySqlClient

Public Class EntityPerson

    Dim connection As New MySqlConnection(MainForm.getInstance().connectionString)
    Shared instance As EntityPerson = Nothing

    Public Shared Function getInstance() As EntityPerson
        If IsNothing(instance) Then
            instance = New EntityPerson()
        End If
        Return instance
    End Function

    Public Function getPerson() As DataTable
        Dim command As New MySqlCommand
        command.Connection = connection
        command.CommandText = $"Select * from personne"
        connection.Open()
        Dim reader = command.ExecuteReader()
        Dim table As New DataTable("personne")
        table.Load(reader)
        connection.Close()
        Return table
    End Function

    Public Function getPersonByID(id As Integer) As DataTable
        Dim command As New MySqlCommand
        command.Connection = connection
        command.CommandText = $"Select * from personne where noPersonne = {id}"
        connection.Open()
        Dim reader = command.ExecuteReader()
        Dim table As New DataTable("personne")
        table.Load(reader)
        connection.Close()
        Return table
    End Function

    Public Function getPersonneByFirstName(name As String) As DataTable
        Dim command As New MySqlCommand
        command.Connection = connection
        command.CommandText = $"Select * from personne where upper(prenom) like upper('%{name}%')"
        connection.Open()
        Dim reader = command.ExecuteReader()
        Dim table As New DataTable("personne")
        table.Load(reader)
        connection.Close()
        Return table
    End Function

    Public Function getPersonneByLastName(name As String) As DataTable
        Dim command As New MySqlCommand
        command.Connection = connection
        command.CommandText = $"Select * from personne where upper(nom) like upper('%{name}%')"
        connection.Open()
        Dim reader = command.ExecuteReader()
        Dim table As New DataTable("personne")
        table.Load(reader)
        connection.Close()
        'fsfsf'
        Return table

    End Function

    Public Function getPersonneByFirstNameAndLastName(firstName As String, lastName As String) As DataTable
        Dim command As New MySqlCommand
        command.Connection = connection
        command.CommandText = $"Select * from personne where upper(prenom) like upper('%{firstName}%') and upper(nom) like upper('%{lastName}%')"
        connection.Open()
        Dim reader = command.ExecuteReader()
        Dim table As New DataTable("personne")
        table.Load(reader)
        connection.Close()
        Return table
    End Function

    Public Function getPersonneByStatut(statut As String) As DataTable
        Dim command As New MySqlCommand
        command.Connection = connection
        command.CommandText = $"Select * from personne where upper(statut) like upper('{statut}')"
        connection.Open()
        Dim reader = command.ExecuteReader()
        Dim table As New DataTable("personne")
        table.Load(reader)
        connection.Close()
        Return table
    End Function

    Public Function getPersonRentedItemsByID(id As Integer) As DataTable
        Dim command As New MySqlCommand
        command.Connection = connection
        command.CommandText = $"select E.nom from equipement E INNER JOIN emprunt E2 on E.noEquipement = E2.noEquipement where E2.noPersonne = {id}"
        connection.Open()
        Dim reader = command.ExecuteReader()
        Dim table As New DataTable("personne")
        table.Load(reader)
        connection.Close()
        Return table
    End Function

    Public Function getPersonByDepartment(department As String) As DataTable
        Dim command As New MySqlCommand
        command.Connection = connection
        command.CommandText = $"select * from personne where upper(nomDepartement) like upper('%{department}%')"
        connection.Open()
        Dim reader = command.ExecuteReader()
        Dim table As New DataTable("personne")
        table.Load(reader)
        connection.Close()
        Return table
    End Function

    Public Function getPersonByService(service As String) As DataTable
        Dim command As New MySqlCommand
        command.Connection = connection
        command.CommandText = $"select * from personne where upper(nomService) like upper('%{service}%')"
        connection.Open()
        Dim reader = command.ExecuteReader()
        Dim table As New DataTable("personne")
        table.Load(reader)
        connection.Close()
        Return table
    End Function

    Public Function getPersonByRenting() As DataTable
        Dim command As New MySqlCommand
        command.Connection = connection
        command.CommandText = $"select * from personne P inner join emprunt E on E.noPersonne = P.noPersonne"
        connection.Open()
        Dim reader = command.ExecuteReader()
        Dim table As New DataTable("personne")
        table.Load(reader)
        connection.Close()
        Return table
    End Function

    Public Function getPersonByLate() As DataTable
        Dim command As New MySqlCommand
        command.Connection = connection
        command.CommandText = $"select * from personne P inner join emprunt E on E.noPersonne = P.noPersonne where dateRetour < current_date"
        connection.Open()
        Dim reader = command.ExecuteReader()
        Dim table As New DataTable("personne")
        table.Load(reader)
        connection.Close()
        Return table
    End Function
End Class
