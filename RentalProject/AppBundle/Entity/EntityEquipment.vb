Imports MySql.Data.MySqlClient

Public Class EntityEquipment

    'création de la connection mysql
    Dim connection As New MySqlConnection(MainForm.getInstance().connectionString)
    Shared instance As EntityEquipment = Nothing

    Public Shared Function getInstance() As EntityEquipment
        If IsNothing(instance) Then
            instance = New EntityEquipment()
        End If
        Return instance
    End Function

    'on va chercher les informations nécessaires pour la datagridview inventaire (select all de équipement, mais on remplace le noCategorie par le nom de la dite catégorie)
    Public Function getEquipment() As DataTable
        Try
            Dim command As New MySqlCommand
            command.Connection = connection
            command.CommandText = $"Select e.noequipement, e.nom, c2.nom as categorie, e.etat, e.disponibilite from equipement e inner join categorie c2 on c2.nocategorie=e.nocategorie"
            connection.Open()
            Dim reader = command.ExecuteReader()
            Dim table As New DataTable("equipement")
            table.Load(reader)
            connection.Close()
            Return table
        Catch ex As Exception
            MessageBox.Show("Le chargement des données de la Base de Données a échoué:" + ex.Message)
        End Try
    End Function

    'on va chercher toutes les informations des équipements (select all)
    Public Function getEquipment_noCategorie() As DataTable
        Try
            Dim command As New MySqlCommand
            command.Connection = connection
            command.CommandText = $"Select * from equipement"
            connection.Open()
            Dim reader = command.ExecuteReader()
            Dim table As New DataTable("equipement")
            table.Load(reader)
            connection.Close()
            Return table
        Catch ex As Exception
            MessageBox.Show("Le chargement des données de la Base de Données a échoué:" + ex.Message)
        End Try
    End Function

    'On va chercher le(s) équipement(s) qui ont un certain ID
    Public Function getEquipmentByID(id As String) As DataTable
        Try
            Dim command As New MySqlCommand
            command.Connection = connection
            command.CommandText = $"Select e.noequipement, e.nom, c2.nom as categorie, e.etat, e.disponibilite from equipement e inner join categorie c2 on e.noCategorie = c2.noCategorie where upper(noEquipement) like upper('%{id}%')"
            connection.Open()
            Dim reader = command.ExecuteReader()
            Dim table As New DataTable("equipement")
            table.Load(reader)
            connection.Close()
            Return table
        Catch ex As Exception
            MessageBox.Show("Le chargement des données de la Base de Données a échoué:" + ex.Message)
        End Try
    End Function

    'On va chercher le(s) équipement(s) qui ont un certain Nom
    Public Function getEquipmentByName(name As String) As DataTable
        Try
            Dim command As New MySqlCommand
            command.Connection = connection
            command.CommandText = $"Select E.noequipement, E.nom, C2.nom as categorie, E.etat, E.disponibilite  from equipement E inner join categorie C2 on E.noCategorie = C2.noCategorie where upper(E.nom) like upper('%{name}%')"
            connection.Open()
            Dim reader = command.ExecuteReader()
            Dim table As New DataTable("equipement")
            table.Load(reader)
            connection.Close()
            Return table
        Catch ex As Exception
            MessageBox.Show("Le chargement des données de la Base de Données a échoué:" + ex.Message)
        End Try
    End Function

    'On va chercher le(s) équipement(s) qui ont un certain nom de catégorie
    Public Function getEquipmentByCategoryName(name As String) As DataTable
        Try
            Dim command As New MySqlCommand
            command.Connection = connection
            command.CommandText = $"Select E.noequipement, E.nom, C2.nom as categorie, E.etat, E.disponibilite  from equipement E inner join categorie C2 on E.noCategorie = C2.noCategorie where upper(C2.nom) like upper('%{name}%')"
            connection.Open()
            Dim reader = command.ExecuteReader()
            Dim table As New DataTable("equipement")
            table.Load(reader)
            connection.Close()
            Return table
        Catch ex As Exception
            MessageBox.Show("Le chargement des données de la Base de Données a échoué:" + ex.Message)
        End Try
    End Function

    'On va chercher le(s) équipement(s) qui ont un certain noCategorie
    Public Function getEquipmentByCategoryID(id As Integer) As DataTable
        Try
            Dim command As New MySqlCommand
            command.Connection = connection
            command.CommandText = $"Select E.noequipement, E.nom, C2.nom as categorie, E.etat, E.disponibilite  from equipement E inner join categorie C2 on E.noCategorie = C2.noCategorie where C2.noCategorie = {id}"
            connection.Open()
            Dim reader = command.ExecuteReader()
            Dim table As New DataTable("equipement")
            table.Load(reader)
            connection.Close()
            Return table
        Catch ex As Exception
            MessageBox.Show("Le chargement des données de la Base de Données a échoué:" + ex.Message)
        End Try
    End Function

    'On va chercher le(s) équipement(s) qui ont un certain Etat
    Public Function getEquipmentByEtat(etat As String) As DataTable
        Try
            Dim command As New MySqlCommand
            command.Connection = connection
            command.CommandText = $"Select E.noequipement, E.nom, C2.nom as categorie, E.etat, E.disponibilite  from equipement E inner join categorie C2 on E.noCategorie = C2.noCategorie where upper(etat) like upper('%{etat}%')"
            connection.Open()
            Dim reader = command.ExecuteReader()
            Dim table As New DataTable("equipement")
            table.Load(reader)
            connection.Close()
            Return table
        Catch ex As Exception
            MessageBox.Show("Le chargement des données de la Base de Données a échoué:" + ex.Message)
        End Try
    End Function

    'On va chercher les infroamtions d'un équipement en fonction de son Id, ainsi que de l'emprunt qui lui est associé et de la personne qui l'a emprunté
    Public Function getEquipmentDetailed(id As String) As DataTable
        Try
            Dim command As New MySqlCommand
            command.Connection = connection
            connection.Open()
            command.CommandText = $"Select E.noEquipement, initcap(E.nom), initcap(C2.nom), initcap(E.etat),initcap(P.prenom), initcap(P.nom), initcap(P.statut), P.email, initcap(E2.autorisation), E2.DateEmprunt, E2.dateRetour from equipement E left join emprunt E2 on E.noEquipement = E2.noEquipement left join personne P on E2.noPersonne = P.noPersonne inner join categorie C2 on E.noCategorie = C2.noCategorie where E.NoEquipement = '{id}'"
            Dim reader = command.ExecuteReader()
            Dim equipmentTable As New DataTable("equipement")
            equipmentTable.Load(reader)
            connection.Close()
            Return equipmentTable
        Catch ex As Exception
            MessageBox.Show("Le chargement des données de la Base de Données a échoué:" + ex.Message)
        End Try
    End Function

    Public Function getEquipmentIDs() As DataTable
        Try
            Dim command As New MySqlCommand
            command.Connection = connection
            connection.Open()
            command.CommandText = $"Select noEquipement from equipement"
            Dim reader = command.ExecuteReader()
            Dim equipmentTable As New DataTable("equipement")
            equipmentTable.Load(reader)
            connection.Close()
            Return equipmentTable
        Catch ex As Exception
            MessageBox.Show("Le chargement des données de la Base de Données a échoué:" + ex.Message)
        End Try
    End Function

    Public Function getEquipmentRented(ID As String) As DataTable
        Try
            Dim command As New MySqlCommand
            command.Connection = connection
            command.CommandText = $"Select EQ.noEquipement as No_Équipement, EQ.nom as Nom_Équipement from emprunt EM inner join equipement EQ on EM.noEquipement = EQ.noEquipement where upper(EM.ID) = upper('{ID}')"
            connection.Open()
            Dim reader = command.ExecuteReader()
            Dim equipmentTable As New DataTable("equipement")
            equipmentTable.Load(reader)
            connection.Close()
            Return equipmentTable
        Catch ex As Exception
            MessageBox.Show("Le chargement des données de la Base de Données a échoué:" + ex.Message)
        End Try
    End Function
End Class
