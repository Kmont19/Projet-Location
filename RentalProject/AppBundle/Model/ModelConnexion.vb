Imports MySql.Data.MySqlClient

Public Class ModelConnexion

    Dim connection As New MySqlConnection(MainForm.getInstance().connectionString)
    Shared instance As ModelConnexion = Nothing

    Public Shared Function getInstance() As ModelConnexion
        If IsNothing(instance) Then
            instance = New ModelConnexion()
        End If
        Return instance
    End Function

    Public Sub deleteUser(matricule As Integer)
        Dim command As New MySqlCommand
        command.Connection = connection
        command.CommandText = $"Delete from utilisateur where matricule = {matricule}"
        connection.Open()
        command.ExecuteNonQuery()
        connection.Close()
    End Sub

    Public Sub addUser(ByVal matricule As Integer,
                         ByVal password As String,
                         ByVal statut As String)
        Try
            Dim command As New MySqlCommand
            command.Connection = connection
            connection.Open()
            command.CommandText = $"insert into utilisateur
            values('{matricule}','{password}','{statut}')"

            Dim result = command.ExecuteNonQuery()
            connection.Close()
            MessageBox.Show("L'utilisateur à été ajouté avec succès.")
        Catch ex As Exception
            MessageBox.Show("Une erreur s'est produite lors de l'ajout.")
        End Try
    End Sub

End Class
