Imports System.Text.RegularExpressions

Public Class IAddPerson

    Dim rent As IEmprunt
    Dim person As IPerson

    Sub New(r As IEmprunt, p As IPerson)
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        rent = r
        person = p
    End Sub

    Private Sub IAddPerson_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TBService.Enabled = False
        TBBureau.Enabled = False
        TBPoste.Enabled = False
    End Sub

    ''' <summary>
    ''' Cette fonction vérifie que l'adresse courriel est valide.
    ''' </summary>
    ''' <param name="email"></param>
    ''' <returns></returns>
    Function IsEmail(ByVal email As String) As Boolean
        Static emailExpression As New Regex("^[_a-z0-9-.]+(.[a-z0-9-.]+)@[a-z0-9-]+(.[a-z0-9-]+)*(.[a-z]{2,4})$")
        Dim containsAt As Boolean = False
        For i = 0 To email.Length - 1
            If email.Chars(i) = "@" Then
                containsAt = True
            End If
        Next
        If Not containsAt Then
            _Email.Text = $"{_Email.Text}@cegeptr.qc.ca"
            email = $"{email}@cegeptr.qc.ca"
        End If
        Return emailExpression.IsMatch(email)
    End Function
    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        TBPrenom.Text = Regex.Replace(TBPrenom.Text, "[\d-]", String.Empty)
        TBNom.Text = Regex.Replace(TBNom.Text, "[\d-]", String.Empty)
        TBDepartement.Text = Regex.Replace(TBDepartement.Text, "[\d-]", String.Empty)
        TBService.Text = Regex.Replace(TBService.Text, "[\d-]", String.Empty)
        TBPrenom.Text = Regex.Replace(TBPrenom.Text, "[^A-Za-z ]", String.Empty)
        TBNom.Text = Regex.Replace(TBNom.Text, "[^A-Za-z ]", String.Empty)
        TBDepartement.Text = Regex.Replace(TBDepartement.Text, "[^A-Za-z ]", String.Empty)
        TBService.Text = Regex.Replace(TBService.Text, "[^A-Za-z ]", String.Empty)
        Email.Text = Regex.Replace(Email.Text, "[^A-Za-z0-9-._@]", String.Empty)
        If Not String.IsNullOrEmpty(TBNom.Text) And
            Not String.IsNullOrEmpty(TBPrenom.Text) And
            Not String.IsNullOrEmpty(CBStatut.Text) And
            Not String.IsNullOrEmpty(TBTelephone.Text) And TBTelephone.TextLength = 14 Then
            If IsEmail(Email.Text) Then
                If MessageBox.Show($"Est-ce que cette addresse courriel est valide?{Environment.NewLine}{Email.Text}", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                    If CBStatut.Text <> "Étudiant" Then
                        If Not String.IsNullOrEmpty(TBDepartement.Text) And
                            Not String.IsNullOrEmpty(TBService.Text) And
                            Not String.IsNullOrEmpty(TBBureau.Text) Then
                            If String.IsNullOrEmpty(TBPoste.Text) Then
                                TBPoste.Text = 0
                            End If
                            ModelPerson.getInstance.addPerson(TBNom.Text, TBPrenom.Text, CBStatut.Text, TBDepartement.Text, TBService.Text, TBBureau.Text, TBTelephone.Text, CInt(TBPoste.Text), Email.Text)
                        Else MessageBox.Show("Veuillez Vérifier les informations")
                        End If
                    Else
                        ModelPerson.getInstance.addPerson(TBNom.Text, TBPrenom.Text, CBStatut.Text, TBDepartement.Text, "", "", TBTelephone.Text, CInt("0"), Email.Text)
                    End If
                    createPersonAutoComplete(rent.Person)
                    Me.SendToBack()
                End If
            Else
                MessageBox.Show("Cette adresse courriel est invalide.")
            End If
        Else
            MessageBox.Show("Veuillez vérifier les informations")
        End If
        person.DGVPerson.DataSource = EntityPerson.getInstance().getPerson()
        person.DGVPerson.SelectionMode = DataGridViewSelectionMode.FullRowSelect
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click, CancelButton.Click
        'Retour au UC person
        If MessageBox.Show($"Voulez-vous vraiment faire cette opération?{Environment.NewLine}Tous vos changement seront perdus.", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Me.SendToBack()
        End If
    End Sub

    Private Sub CBStatut_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBStatut.SelectedIndexChanged
        If CBStatut.Text <> "Étudiant" Then
            TBService.Enabled = True
            TBBureau.Enabled = True
            TBPoste.Enabled = True
        Else
            TBService.Enabled = False
            TBBureau.Enabled = False
            TBPoste.Enabled = False
        End If
    End Sub

End Class
