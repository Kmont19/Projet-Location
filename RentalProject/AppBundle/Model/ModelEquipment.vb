Imports MySql.Data.MySqlClient
Public Class ModelEquipment

    'Connection à la base de données
    Dim connection As New MySqlConnection(MainForm.getInstance().connectionString)
    Shared instance As ModelEquipment = Nothing

    Public Shared Function getInstance() As ModelEquipment
        If IsNothing(instance) Then
            instance = New ModelEquipment()
        End If
        Return instance
    End Function

    'on va modifier un équipement en fonction de certaines valeurs
    Public Function updateequipment(noequipement As String, nom As String, nocategorie As Integer, etat As String, disponibilite As String)
        Try


            Dim command As New MySqlCommand
            command.Connection = connection
            command.CommandText = $"update equipement set nom='{nom}',nocategorie='{nocategorie}',etat='{etat}',disponibilite='{disponibilite}' where noequipement='{noequipement}'"
            connection.Open()
            Dim add As Integer = command.ExecuteNonQuery()
            connection.Close()
        Catch ex As Exception
            MessageBox.Show("La modification de la base de données a échoué:" + ex.Message)
            connection.Close()
        End Try
    End Function

    'on ajoute un équipement à la base de données en fonction de certaines valeurs
    Public Function addequipment(noequipement As String, nom As String, nocategorie As Integer, etat As String, disponibilite As String)
        Try
            Dim command As New MySqlCommand
            command.Connection = connection
            command.CommandText = $"insert into equipement values ('{noequipement}','{nom}','{nocategorie}','{etat}','{disponibilite}')"
            connection.Open()
            Dim add As Integer = command.ExecuteNonQuery()
            connection.Close()
        Catch ex As Exception
            MessageBox.Show("L'ajout de l'équipement a échoué:" + ex.Message)
            connection.Close()
        End Try
    End Function

    'on supprime un Équipement de la table via son ID
    Public Function delequipement(noequipement As String)
        Try
            Dim command As New MySqlCommand
            command.Connection = connection
            command.CommandText = $"Delete from equipement where noequipement = '{noequipement}'"
            connection.Open()
            command.ExecuteNonQuery()
            connection.Close()
        Catch ex As Exception
            MessageBox.Show("La suppression de l'équipement a échoué:" + ex.Message)
            connection.Close()
        End Try
    End Function

    Public Function updateeEquipementCategorie(noequipement As String, nocategorie As Integer)
        Dim command As New MySqlCommand
        command.Connection = connection
        command.CommandText = $"update equipement set nocategorie={nocategorie} where noequipement='{noequipement}'"
        connection.Open()
        command.ExecuteNonQuery()
        connection.Close()
        ModelCategory.getInstance().UpdateCategorieQuantite(nocategorie)
    End Function
End Class

