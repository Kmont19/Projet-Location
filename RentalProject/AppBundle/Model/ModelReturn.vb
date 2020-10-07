Imports MySql.Data.MySqlClient

Public Class ModelReturn

    Dim connection As New MySqlConnection(MainForm.getInstance().connectionString)
    Shared instance As ModelReturn = Nothing
    Public Shared Function getInstance() As ModelReturn
        If IsNothing(instance) Then
            instance = New ModelReturn()
        End If
        Return instance
    End Function

    Public Sub addReturn(id As Integer,
                         reception As String,
                         personNumber As Integer,
                         equipment As String,
                         comment As String,
                         ByRef printed As Boolean)
        Try
            Dim command As New MySqlCommand
            command.Connection = connection
            command.CommandText = $"insert into retour values({id}, '{reception}', {personNumber}, '{equipment}', '{Date.Now.ToString("yyyy-MM-dd HH:mm:ss")}', '{comment}')"
            connection.Open()
            command.ExecuteNonQuery()
            connection.Close()
            If Not printed Then
                MessageBox.Show("La suppression s'est effecté avec succès.")
            End If
        Catch ex As Exception
            MessageBox.Show($"Une erreur c'est produite lors de la sauvegarde du retour. {Environment.NewLine}{ex.Message}")
        End Try
    End Sub

    Public Sub deleteReturn(id As Integer, printed As Boolean)
        Try
            Dim command As New MySqlCommand
            command.Connection = connection
            command.CommandText = $"delete from retour where noRetour = {id}"
            connection.Open()
            command.ExecuteNonQuery()
            connection.Close()
            If Not printed Then
                MessageBox.Show("La suppression s'est effecté avec succès.")
            End If
        Catch ex As Exception
            MessageBox.Show("Une erreur c'est produite lors de la suppression du retour.")
        End Try
    End Sub
End Class
