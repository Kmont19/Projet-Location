Imports System.Text.RegularExpressions

Public Class IPersonSearch

    Dim person As IPerson
    Dim mainForm As MainForm

    Sub New(pers As IPerson)
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        person = pers
        SearchButton.Enabled = False
        ByName.Checked = True
    End Sub

    Private Sub IPersonSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGVPerson.DataSource = EntityPerson.getInstance.getPerson
        DGVPerson.SelectionMode = DataGridViewSelectionMode.FullRowSelect
    End Sub

    ''' <summary>
    ''' Fait la gestion des champs textes lorsq'un boutton radio différent
    ''' est sélectionné.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Radio_CheckedChanged(sender As Object, e As EventArgs) Handles ByName.CheckedChanged, ByStatut.CheckedChanged, ByDepartment.CheckedChanged, ByService.CheckedChanged, ByRenting.CheckedChanged, ByLate.CheckedChanged
        TBNom.Text = ""
        TBPrenom.Text = ""
        CBStatut.Text = ""
        Department.Text = ""
        Service.Text = ""
        If ByName.Checked Then
            TBNom.Enabled = True
            TBPrenom.Enabled = True
            CBStatut.Enabled = False
            Department.Enabled = False
            Service.Enabled = False
            ByRenting.Checked = False
            ByLate.Checked = False
        ElseIf ByStatut.Checked Then
            TBNom.Enabled = False
            TBPrenom.Enabled = False
            CBStatut.Enabled = True
            Department.Enabled = False
            Service.Enabled = False
            ByRenting.Checked = False
            ByLate.Checked = False
        ElseIf ByDepartment.Checked Then
            TBNom.Enabled = False
            TBPrenom.Enabled = False
            CBStatut.Enabled = False
            Department.Enabled = True
            Service.Enabled = False
            ByRenting.Checked = False
            ByLate.Checked = False
        ElseIf ByService.Checked Then
            TBNom.Enabled = False
            TBPrenom.Enabled = False
            CBStatut.Enabled = False
            Department.Enabled = False
            Service.Enabled = True
            ByRenting.Checked = False
            ByLate.Checked = False
        ElseIf ByRenting.Checked Then
            TBNom.Enabled = False
            TBPrenom.Enabled = False
            CBStatut.Enabled = False
            Department.Enabled = False
            Service.Enabled = False
            ByRenting.Checked = True
            ByLate.Checked = False
        ElseIf ByLate.Checked Then
            TBNom.Enabled = False
            TBPrenom.Enabled = False
            CBStatut.Enabled = False
            Department.Enabled = False
            Service.Enabled = False
            ByRenting.Checked = False
            ByLate.Checked = True
        End If
    End Sub

    ''' <summary>
    ''' Fait la gestion des valeurs entrées dans les champs textes.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        TBPrenom.Text = Regex.Replace(TBPrenom.Text, "[\d-]", String.Empty)
        TBPrenom.Text = Regex.Replace(TBPrenom.Text, "[^A-Za-z ]", String.Empty)
        TBNom.Text = Regex.Replace(TBNom.Text, "[\d-]", String.Empty)
        TBNom.Text = Regex.Replace(TBNom.Text, "[^A-Za-z ]", String.Empty)
        Department.Text = Regex.Replace(Department.Text, "[\d-]", String.Empty)
        Department.Text = Regex.Replace(Department.Text, "[^A-Za-z ]", String.Empty)
        Service.Text = Regex.Replace(Service.Text, "[\d-]", String.Empty)
        Service.Text = Regex.Replace(Service.Text, "[^A-Za-z ]", String.Empty)
        SearchItems()
    End Sub

    Private Sub PressedEnter(sender As Object, e As KeyEventArgs) Handles TBPrenom.KeyUp, TBNom.KeyUp, CBStatut.KeyUp
        If e.KeyCode = Keys.Enter Then
            SearchItems()
        End If
    End Sub

    ''' <summary>
    ''' Fait la recherche selon les parametres entrés et les affiche.
    ''' </summary>
    ''' <returns></returns>
    Private Function SearchItems()
        Dim lastName = Trim(TBNom.Text)
        Dim firstName = Trim(TBPrenom.Text)
        Dim dept = Trim(Department.Text)
        Dim serv = Trim(Service.Text)
        If (lastName.Length > 0 Or firstName.Length > 0) And ByName.Checked Then
            If lastName.Length > 0 And firstName.Length > 0 Then
                DGVPerson.DataSource = EntityPerson.getInstance.getPersonneByFirstNameAndLastName(firstName, lastName)
            ElseIf lastName.Length > 0 And Not firstName.Length > 0 Then
                DGVPerson.DataSource = EntityPerson.getInstance.getPersonneByLastName(lastName)
            ElseIf Not lastName.Length > 0 And firstName.Length > 0 Then
                DGVPerson.DataSource = EntityPerson.getInstance.getPersonneByFirstName(firstName)
            End If
        ElseIf CBStatut.Text.Length > 0 And ByStatut.Checked Then
            DGVPerson.DataSource = EntityPerson.getInstance.getPersonneByStatut(CBStatut.Text)
        ElseIf dept.Length > 0 And ByDepartment.Checked Then
            DGVPerson.DataSource = EntityPerson.getInstance.getPersonByDepartment(dept)
        ElseIf serv.Length > 0 And ByService.Checked Then
            DGVPerson.DataSource = EntityPerson.getInstance.getPersonByService(serv)
        ElseIf ByRenting.Checked Then
            Dim data As DataTable = EntityPerson.getInstance.getPersonByRenting()
            DGVPerson.DataSource = data
        ElseIf ByLate.Checked Then
            Dim data As DataTable = EntityPerson.getInstance.getPersonByLate()
            DGVPerson.DataSource = data
        End If

        If DGVPerson.Rows.Count = 0 Then
            MessageBox.Show("Il n'y a aucun personne de trouvée selon ces paramètres")
            DGVPerson.DataSource = EntityPerson.getInstance().getPerson()
        End If
    End Function

    ''' <summary>
    ''' Débloque le bouton recherche si selon les valeurs entrés
    ''' dans les champs text ou si l'un des bouttons radio selon les emprunts est coché.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub SearchBoxes_TextChanged(sender As Object, e As EventArgs) Handles TBPrenom.TextChanged, TBNom.TextChanged, CBStatut.TextChanged, Department.TextChanged, Service.TextChanged, ByStatut.CheckedChanged, ByRenting.CheckedChanged, ByLate.CheckedChanged
        Dim lastName = Trim(TBNom.Text)
        Dim firstName = Trim(TBPrenom.Text)
        Dim statut = Trim(CBStatut.Text)
        Dim dept = Trim(Department.Text)
        Dim serv = Trim(Service.Text)
        If (firstName.Length > 0 Or lastName.Length > 0) Or (ByStatut.Checked And statut.Length > 0) Or dept.Length > 0 Or serv.Length > 0 Or ByRenting.Checked Or ByLate.Checked Then
            SearchButton.Enabled = True
        Else
            SearchButton.Enabled = False
        End If
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Me.SendToBack()
    End Sub
End Class
