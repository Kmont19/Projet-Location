﻿Public Class Connexion
    Private Sub BTConnexion_Click(sender As Object, e As EventArgs) Handles BTConnexion.Click
        Dim user, password
        Dim verif = False

        user = Trim(TBUser.Text)
        password = Trim(TBPassword.Text)

        If (user.Length > 0 And password.Length > 0) Then
            verif = EntityConnexion.getInstance.verifUser(user, password)
            If (verif = True) Then
                Me.Close()
                Dim main = New MainForm()
                main.Show()
            Else
                MessageBox.Show("Les données de connexion sont incorrects, veuillez essayer à nouveau.", "Error de connexion")
            End If

        End If
    End Sub
End Class