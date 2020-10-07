Imports System.Text.RegularExpressions

Public Class IModifyPerson

    Dim mainForm As MainForm
    Dim data As DataTable
    Dim person As IPerson
    Dim detailPerson As IPersonDetails

    Sub New(main As MainForm, items As DataTable, p As IPerson)
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        mainForm = main
        data = items
        person = p
    End Sub

    Private Sub IModifyPerson_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        setDefaults()
    End Sub

    ''' <summary>
    ''' Entre les valeurs initiales de la personne sélectionné.
    ''' </summary>
    ''' <returns></returns>
    Private Function setDefaults()
        For Each it As DataRow In data.Rows
            'Inserting values into textBoxes
            ID.Text = it.Item(0)
            LastName.Text = it.Item(1)
            FirstName.Text = it.Item(2)
            Status.Text = it.Item(3)
            Department.Text = it.Item(4)
            Service.Text = it.Item(5)
            Office.Text = it.Item(6)
            Phone.Text = it.Item(7)
            Extension.Text = it.Item(8)
            Email.Text = it.Item(9)
        Next
    End Function

    Private Sub ResetButton_Click(sender As Object, e As EventArgs) Handles ResetButton.Click
        If MessageBox.Show($"Voulez-vous vraiment faire cette opération?{Environment.NewLine}Tous vos changement seront perdus.", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            setDefaults()
        End If
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        If MessageBox.Show($"Voulez-vous vraiment faire cette opération?{Environment.NewLine}Tous vos changement seront perdus.", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Me.SendToBack()
        End If
    End Sub

    ''' <summary>
    ''' Cette fonction vérifie que l'adresse courriel est valide.
    ''' </summary>
    ''' <param name="email"></param>
    ''' <returns></returns>
    Function IsEmail(ByVal email As String) As Boolean
        Static emailExpression As New Regex("^[_a-z0-9-]+(.[a-z0-9-]+)@[a-z0-9-]+(.[a-z0-9-]+)*(.[a-z]{2,4})$")
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

    ''' <summary>
    ''' Gestion des valeurs entrés dans les champs texts et permet l'ajout
    ''' seulement si les champs sont valide.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        FirstName.Text = Regex.Replace(FirstName.Text, "[\d-]", String.Empty)
        LastName.Text = Regex.Replace(LastName.Text, "[\d-]", String.Empty)
        Department.Text = Regex.Replace(Department.Text, "[\d-]", String.Empty)
        Service.Text = Regex.Replace(Service.Text, "[\d-]", String.Empty)
        FirstName.Text = Regex.Replace(FirstName.Text, "[^A-Za-z ]", String.Empty)
        LastName.Text = Regex.Replace(LastName.Text, "[^A-Za-z ]", String.Empty)
        Department.Text = Regex.Replace(Department.Text, "[^A-Za-z ]", String.Empty)
        Service.Text = Regex.Replace(Service.Text, "[^A-Za-z ]", String.Empty)
        If String.IsNullOrEmpty(Extension.Text) Then
            Extension.Text = 0
        End If
        LastName.Text = Trim(LastName.Text)
        FirstName.Text = Trim(FirstName.Text)
        Department.Text = Trim(Department.Text)
        Service.Text = Trim(Service.Text)
        Office.Text = Trim(Office.Text)
        Phone.Text = Trim(Phone.Text)
        Extension.Text = Trim(Extension.Text)
        Email.Text = Regex.Replace(Email.Text, "[^A-Za-z0-9.@]", String.Empty)
        If String.IsNullOrEmpty(LastName.Text) Or String.IsNullOrEmpty(FirstName.Text) Or
           String.IsNullOrEmpty(Status.Text) Or String.IsNullOrEmpty(Department.Text) Or
           (String.IsNullOrEmpty(Service.Text) And Status.Text <> "Étudiant") Or
           String.IsNullOrEmpty(Phone.Text) Then
            MessageBox.Show("Veuillez remplir tous les champs avant de soumettre.")
        ElseIf Not IsEmail(Email.Text) Then
            MessageBox.Show("Veuillez entrer une adresse de courriel valide.")
        ElseIf MessageBox.Show($"Est-ce que cette addresse courriel est valide?{Environment.NewLine}{Email.Text}", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            If Not Status.Text = "Étudiant" And Office.Text.Length < 6 Then
                MessageBox.Show("Veuillez entrer un Bureau valide.")
            ElseIf MessageBox.Show($"Voulez-vous vraiment sauvegarder ces modifications?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                If Status.Text = "Étudiant" Then
                    ModelPerson.getInstance().modifyPerson(ID.Text, LastName.Text, FirstName.Text, Status.Text, Department.Text, "", "", Phone.Text, Extension.Text, Email.Text)
                    mainForm.InterfacePanel.Controls.Clear()
                    Dim persons As New IPerson(mainForm)
                    persons.Dock = DockStyle.Fill
                    mainForm.InterfacePanel.Controls.Add(persons)
                    persons.BringToFront()
                Else
                    ModelPerson.getInstance().modifyPerson(ID.Text, LastName.Text, FirstName.Text, Status.Text, Department.Text, Service.Text, Office.Text, Phone.Text, Extension.Text, Email.Text)
                    mainForm.InterfacePanel.Controls.Clear()
                    Dim persons As New IPerson(mainForm)
                    persons.Dock = DockStyle.Fill
                    mainForm.InterfacePanel.Controls.Add(persons)
                    persons.BringToFront()
                End If

            End If
        End If

        person.DGVPerson.DataSource = EntityPerson.getInstance().getPerson()
        person.DGVPerson.SelectionMode = DataGridViewSelectionMode.FullRowSelect
    End Sub

    ''' <summary>
    ''' Gestion des champs acéssibles selon le statut de personne (étudiant, prof, etc).
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Status_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Status.SelectedIndexChanged
        If Status.SelectedIndex = 0 Then
            Department.Enabled = False
            Service.Enabled = False
            Office.Enabled = False
        Else
            Department.Enabled = True
            Service.Enabled = True
            Office.Enabled = True
        End If
    End Sub
End Class
