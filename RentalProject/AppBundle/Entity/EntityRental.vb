Imports MySql.Data.MySqlClient

Public Class EntityRental

    Dim connection As New MySqlConnection(MainForm.getInstance().connectionString)
    Shared instance As EntityRental = Nothing

    Public Shared Function getInstance() As EntityRental
        If IsNothing(instance) Then
            instance = New EntityRental()
        End If
        Return instance
    End Function

    Public Function getRentals() As DataTable
        Dim command As New MySqlCommand
        command.Connection = connection
        command.CommandText = $"Select distinct E.ID, initcap(concat(P.nom, ', ', P.prenom)) as Emprunté_par, initcap(E.autorisation) as autorisation from emprunt E inner join personne P on E.noPersonne = P.noPersonne order by E.ID"
        connection.Open()
        Dim reader = command.ExecuteReader()
        Dim table As New DataTable("emprunt")
        table.Load(reader)
        connection.Close()
        Return table
    End Function

    Public Function getRentalEquipments(id As Integer) As DataTable
        Dim command As New MySqlCommand
        command.Connection = connection
        command.CommandText = $"Select E2.nom from emprunt E inner join equipement E2 on E2.noEquipement = E.noEquipement where ID = {id}"
        connection.Open()
        Dim reader = command.ExecuteReader()
        Dim table As New DataTable("emprunt")
        table.Load(reader)
        connection.Close()
        Return table
    End Function

    Public Function getRentalsByRenterFirstName(firstName As String) As DataTable
        Dim command As New MySqlCommand
        command.Connection = connection
        command.CommandText = $"Select E.ID, initcap(concat(P.nom, ', ', P.prenom)), E2.nom as Nom_Équipement, initcap(E.autorisation) from emprunt E inner join equipement E2 on E.noEquipement = E2.noEquipement inner join personne P on E.noPersonne = P.noPersonne where upper(P.prenom) like upper('{firstName}%') order by E.ID"
        connection.Open()
        Dim reader = command.ExecuteReader()
        Dim table As New DataTable("emprunt")
        table.Load(reader)
        connection.Close()
        Return table
    End Function

    Public Function getRentalsByRenterLastName(lastName As String) As DataTable
        Dim command As New MySqlCommand
        command.Connection = connection
        command.CommandText = $"Select E.ID, initcap(concat(P.nom, ', ', P.prenom)), E2.nom as Nom_Équipement, initcap(E.autorisation) from emprunt E inner join equipement E2 on E.noEquipement = E2.noEquipement inner join personne P on E.noPersonne = P.noPersonne where upper(P.nom) like upper('{lastName}%') order by E.ID"
        connection.Open()
        Dim reader = command.ExecuteReader()
        Dim table As New DataTable("emprunt")
        table.Load(reader)
        connection.Close()
        Return table
    End Function

    Public Function getRentalsByRenterFirstAndLastName(firstName As String, lastName As String) As DataTable
        Dim command As New MySqlCommand
        command.Connection = connection
        command.CommandText = $"Select E.ID, initcap(concat(P.nom, ', ', P.prenom)), E2.nom as Nom_Équipement, initcap(E.autorisation) from emprunt E inner join equipement E2 on E.noEquipement = E2.noEquipement inner join personne P on E.noPersonne = P.noPersonne where upper(P.prenom) like upper('{firstName}%') and upper(P.nom) like upper('{lastName}%') order by E.ID"
        connection.Open()
        Dim reader = command.ExecuteReader()
        Dim table As New DataTable("emprunt")
        table.Load(reader)
        connection.Close()
        Return table
    End Function

    Public Function getRentalsByEquipment(ID As String) As Integer
        Dim command As New MySqlCommand
        command.Connection = connection
        command.CommandText = $"Select E.ID from emprunt E where upper(E.noequipement) = upper('{ID}') order by E.ID"
        connection.Open()
        Dim value As Integer = command.ExecuteScalar()
        connection.Close()
        Return value
    End Function

    Public Function getEquipmentIsRented(ID As String) As Boolean
        Dim command As New MySqlCommand
        command.Connection = connection
        command.CommandText = $"Select count(E.ID) from emprunt E where upper(E.noequipement) = upper('{ID}') order by E.ID"
        connection.Open()
        Dim number As Integer = command.ExecuteScalar()
        connection.Close()
        Return number > 0
    End Function

    Public Function getRentalsByCategoryName(name As String) As DataTable
        Dim command As New MySqlCommand
        command.Connection = connection
        command.CommandText = $"Select E.ID, initcap(concat(P.nom, ', ', P.prenom)), E2.nom as Nom_Équipement, initcap(E.autorisation) from emprunt E inner join equipement E2 on E.noEquipement = E2.noEquipement inner join personne P on E.noPersonne = P.noPersonne inner join categorie C2 on E2.noCategorie = C2.noCategorie where upper(C2.nom) like upper('%{name}%')"
        connection.Open()
        Dim reader = command.ExecuteReader()
        Dim table As New DataTable("emprunt")
        table.Load(reader)
        connection.Close()
        Return table
    End Function

    Public Function getRentalsByRenteeName(name As String) As DataTable
        Dim command As New MySqlCommand
        command.Connection = connection
        command.CommandText = $"Select E.ID, initcap(concat(P.nom, ', ', P.prenom)), E2.nom as Nom_Équipement, initcap(E.autorisation) from emprunt E inner join equipement E2 on E.noEquipement = E2.noEquipement inner join personne P on E.noPersonne = P.noPersonne where upper(E.autorisation) like upper('{name}%') order by E.ID"
        connection.Open()
        Dim reader = command.ExecuteReader()
        Dim table As New DataTable("emprunt")
        table.Load(reader)
        connection.Close()
        Return table
    End Function

    Public Function getRentalByID(id As Integer) As DataTable
        Dim command As New MySqlCommand
        command.Connection = connection
        connection.Open()
        command.CommandText = $"Select * from emprunt where ID = {id} order by ID"
        Dim reader = command.ExecuteReader()
        Dim rentalTable As New DataTable("emprunt")
        rentalTable.Load(reader)
        connection.Close()
        Return rentalTable
    End Function

    Public Function getRentalDetailed(id As Integer) As DataTable
        Dim command As New MySqlCommand
        command.Connection = connection
        connection.Open()
        command.CommandText = $"Select E.ID, initcap(P.prenom), initcap(P.nom), initcap(P.statut), P.email, initcap(E.autorisation), E.DateEmprunt, E.dateRetour from emprunt E inner join equipement E2 on E.noEquipement = E2.noEquipement inner join personne P on E.noPersonne = P.noPersonne inner join categorie C2 on E2.noCategorie = C2.noCategorie where E.ID = {id} order by E.ID"
        Dim reader = command.ExecuteReader()
        Dim rentalTable As New DataTable("emprunt")
        rentalTable.Load(reader)
        connection.Close()
        Return rentalTable
    End Function

    Public Function getRentalDatesbyID(id As Integer) As DataTable
        Dim command As New MySqlCommand
        command.Connection = connection
        connection.Open()
        command.CommandText = $"Select E.ID, initcap(concat(P.nom, ', ', P.prenom)), E2.nom as Nom_Équipement, initcap(E.autorisation), E.DateEmprunt, E.duree, E.dateRetour, E.commentaires from emprunt E inner join equipement E2 on E.noEquipement = E2.noEquipement inner join personne P on E.noPersonne = P.noPersonne where E.ID = {id} order by E.ID"
        Dim reader = command.ExecuteReader()
        Dim rentalTable As New DataTable("emprunt")
        rentalTable.Load(reader)
        connection.Close()
        Return rentalTable
    End Function

    Public Function Empruntnextid() As Integer
        Dim command As New MySqlCommand
        Dim ID As Integer
        command.Connection = connection
        command.CommandText = "select max(distinct id) from emprunt"
        connection.Open()
        Dim reader = command.ExecuteReader()
        Dim rentalTable As New DataTable("emprunt")
        rentalTable.Load(reader)
        connection.Close()
        If rentalTable.Rows.Count = 1 And String.IsNullOrEmpty(rentalTable.Rows(0).Item(0).ToString()) Then
            Return 1
        Else
            Return rentalTable.Rows(0).Item(0) + 1
        End If
    End Function

    Public Function verifPersonHasRental(id As Integer) As Boolean
        Try
            Dim command As New MySqlCommand
            command.Connection = connection
            command.CommandText = $"Select noPersonne from emprunt where noPersonne = {id}"
            connection.Open()
            Dim reader = command.ExecuteReader()
            Dim rentalTable As New DataTable("emprunt")
            rentalTable.Load(reader)
            connection.Close()
            If rentalTable.Rows.Count = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            MessageBox.Show("Erreur lors de la vérification des emprunts de cette personne.")
        End Try
    End Function
End Class