Imports MySql.Data.MySqlClient

Public Class ModelPerson

    Dim connection As New MySqlConnection(MainForm.getInstance().connectionString)
    Shared instance As ModelPerson = Nothing

    Public Shared Function getInstance() As ModelPerson
        If IsNothing(instance) Then
            instance = New ModelPerson()
        End If
        Return instance
    End Function

    Public Function deletePerson(id As Integer)
        Dim command As New MySqlCommand
        command.Connection = connection
        command.CommandText = $"Delete from personne where noPersonne = {id}"
        connection.Open()
        command.ExecuteNonQuery()
        connection.Close()
    End Function

    Public Function addPerson(ByVal nom As String,
                         ByVal prenom As String,
                         ByVal statut As String,
                         ByVal departement As String,
                         ByVal service As String,
                         ByVal bureau As String,
                         ByVal telephone As String,
                         ByVal poste As Integer,
                         ByVal email As String)
        Try
            Dim command As New MySqlCommand
            command.Connection = connection
            connection.Open()
            command.CommandText = $"insert into personne
            values('','{nom}','{prenom}', '{statut}', '{departement}', '{service}', '{bureau}', '{telephone}', {poste}, '{email}')"

            Dim result = command.ExecuteNonQuery()
            connection.Close()
            MessageBox.Show("La personne à été ajouté avec succès.")
        Catch ex As Exception
            MessageBox.Show("Une erreur s'est produite lors de l'ajout.")
        End Try
    End Function

    Public Function modifyPerson(id As Integer,
                                 lastName As String,
                                 firstName As String,
                                 status As String,
                                 department As String,
                                 service As String,
                                 office As String,
                                 phone As String,
                                 extension As Integer,
                                 mail As String)
        Try
            Dim command As New MySqlCommand
            command.Connection = connection
            connection.Open()
            command.CommandText = $"update personne set nom = initcap('{lastName}'), prenom = initcap('{firstName}'), statut = initcap('{status}'), nomDepartement = initcap('{department}'), nomService = initcap('{service}'), noBureau = upper('{office}'), telephone = '{phone}', poste = '{extension}', email='{mail}' where noPersonne = {id}"
            Dim result = command.ExecuteNonQuery()
            connection.Close()
            MessageBox.Show("La personne à été modifié avec succès.")
        Catch ex As Exception
            MessageBox.Show("Une erreur s'est produite lors de la modification.")
        End Try
    End Function
End Class
