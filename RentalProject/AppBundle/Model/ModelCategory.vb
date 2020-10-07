Imports MySql.Data.MySqlClient

Public Class ModelCategory

    Dim connection As New MySqlConnection(MainForm.getInstance().connectionString)
    Shared instance As ModelCategory = Nothing

    Public Shared Function getInstance() As ModelCategory
        If IsNothing(instance) Then
            instance = New ModelCategory()
        End If
        Return instance
    End Function

    Public Sub deleteCategory(id As Integer)
        Dim command As New MySqlCommand
        Dim reader As MySqlDataReader
        Dim qte As Integer
        If (id <> 0) Then
            command.Connection = connection
            command.CommandText = $"select quantite from categorie where noCategorie = {id}"
            connection.Open()
            reader = command.ExecuteReader()
            If (reader.Read) Then
                qte = CInt(reader.GetString(0))
                connection.Close()
                connection.Open()
                command.CommandText = $"update categorie set quantite=quantite+{qte} where noCategorie = 0"
                command.ExecuteNonQuery()
                connection.Close()
            End If


            command.CommandText = $"Delete from categorie where noCategorie = {id}"
            connection.Open()
            command.ExecuteNonQuery()
            connection.Close()
            command.CommandText = $"update equipement set noCategorie=0 where noCategorie = {id}"
            connection.Open()
            command.ExecuteNonQuery()
            connection.Close()
        Else
            MessageBox.Show("La catégorie Autre ne peut pas être supprimée")
        End If
    End Sub

    Public Sub addCategory(ByVal nom As String)
        Try
            Dim command As New MySqlCommand
            command.Connection = connection
            connection.Open()
            command.CommandText = $"insert into categorie values('','{nom}',0)"

            Dim result = command.ExecuteNonQuery()
            connection.Close()
            MessageBox.Show("La categorie à été ajoutée avec succès.")
        Catch ex As Exception
            MessageBox.Show("Une erreur s'est produite lors de l'ajout.")
        End Try
    End Sub

    Public Sub updateCategory(ByVal noCategorie As Integer, ByVal nom As String)
        Try
            If (noCategorie <> 0) Then
                Dim command As New MySqlCommand
                command.Connection = connection
                connection.Open()
                command.CommandText = $"update categorie set nom = '{nom}' where noCategorie = {noCategorie}"
                Dim result = command.ExecuteNonQuery()
                connection.Close()
                MessageBox.Show("La categorie à été modifiée avec succès.")
            Else
                MessageBox.Show("La catégorie Autre ne peut pas être modifiée")
            End If
        Catch ex As Exception
            MessageBox.Show("Une erreur s'est produite lors de l'a modification")
        End Try
    End Sub

    Public Function UpdateCategorieQuantite(categoryNumber As Integer)
        Try
            Dim command As New MySqlCommand
            command.Connection = connection
            connection.Open()
            command.CommandText = $"update categorie set quantite = (select count(noEquipement) from equipement where noCategorie = {categoryNumber}) where noCategorie = {categoryNumber}"
            command.ExecuteNonQuery()
            connection.Close()
        Catch ex As Exception
            MessageBox.Show("Une erreur s'est produite lors de la modification de la quantite de categorie")
        End Try
    End Function
End Class
