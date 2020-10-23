Public Class Connexion
    Private Sub BTConnexion_Click(sender As Object, e As EventArgs) Handles BTConnexion.Click
        Dim user, password

        user = Trim(TBUser.Text)
        password = Trim(TBPassword.Text)

        If (user.Length > 0 And password.Length > 0) Then
            EntityConnexion.getInstance.getUserByMatricule(user)
        End If
    End Sub
End Class