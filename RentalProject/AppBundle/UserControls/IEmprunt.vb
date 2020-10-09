Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient
Public Class IEmprunt

    Public connectionString = $"{MainForm.getInstance.connectionString}Convert Zero Datetime=True"
    Dim connection As New MySqlConnection(connectionString)
    Dim validDate As Boolean = False
    Dim reader As MySqlDataReader
    Dim readdate As MySqlDataReader
    Dim com As New MySqlCommand
    Dim comdate As New MySqlCommand
    Dim ListPersonne(999, 3) As String
    Dim ListCategorie(999, 2) As String
    Dim ListEquipement(999, 3) As String
    Dim slPersonne As String = "SELECT noPersonne,prenom,nom from personne;"
    Dim slCategorie As String = "select noCategorie,nom from categorie;"
    Dim slEquipement As String = "select noEquipement,nom,Etat from Equipement where noCategorie="
    Dim rentals As IRentals

    Sub New(rental As IRentals)
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        rentals = rental
    End Sub

    Private Sub IEmprunt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '  Dim noCategorie As String
        DateTimePicker1.MinDate = Date.Now
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "dd-MM-yyyy hh:mm:ss"
        DateTimePicker1.Enabled = False
        CbCategorie.Text = "Sélectionnez une catégorie"
        refreshCategorie()
        createPersonAutoComplete(Person)
    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDownJour.ValueChanged
        DateTimePicker1.Value = Date.Now.AddHours(NumericUpDownHeure.Value + (NumericUpDownJour.Value * 24))
    End Sub

    Public Function ValideDate() As Boolean
        If (DateTimePicker1.Value.DayOfWeek = 6 Or DateTimePicker1.Value.DayOfWeek = 0) Then
            Return False
        Else
            Return True
        End If
    End Function
    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        NumericUpDownJour.Value = DateTimePicker1.Value.DayOfYear - Date.Now.DayOfYear
        NumericUpDownHeure.Value = DateTimePicker1.Value.Hour - Date.Now.Hour
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbCategorie.SelectedIndexChanged
        RefreshEquipement()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            DateTimePicker1.Enabled = True
            NumericUpDownJour.ReadOnly = True
            NumericUpDownHeure.ReadOnly = True
        Else
            DateTimePicker1.Enabled = False
            NumericUpDownJour.ReadOnly = False
            NumericUpDownHeure.ReadOnly = False
        End If
    End Sub

    Private Sub NumericUpDownHeure_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDownHeure.ValueChanged
        DateTimePicker1.Value = Date.Now.AddHours(NumericUpDownHeure.Value + (NumericUpDownJour.Value * 24))
    End Sub

    Public Function RefreshEquipement()
        CbEquipement.Enabled = True
        Dim noCategorie As String
        Dim ctrEquipement As Integer
        CbEquipement.Items.Clear()
        CbEquipement.Text = "Sélectionnez un equipement"
        If (CbCategorie.SelectedIndex > -1) Then
            noCategorie = ListCategorie(CbCategorie.SelectedIndex, 0)
            ctrEquipement = 0
            com.Connection = connection
            connection.Open()
            com.CommandText = slEquipement + noCategorie + " and disponibilite='oui';"
            reader = com.ExecuteReader
            While (reader.Read)
                CbEquipement.Items.Add(reader.GetString(0) + "-" + reader.GetString(1) + " " + reader.GetString(2))
                ListEquipement(ctrEquipement, 0) = reader.GetString(0)
                ListEquipement(ctrEquipement, 1) = reader.GetString(1)
                ListEquipement(ctrEquipement, 2) = reader.GetString(2)
                ctrEquipement += 1
            End While
            connection.Close()
        Else
            MessageBox.Show("Aucune Categorie sélectionné")
        End If
    End Function

    Public Function insertToRental()
        Dim empruntEntity As New ModelRental
        Dim equipementEntity As New EntityEquipment
        Dim no_personne As Integer
        Dim no_equipement As String
        Dim autorisation As String
        Dim duree As String
        Dim dateRetour As Date
        Dim id As Integer
        Dim nomPersonne = Person.Text.Substring(0, Person.Text.IndexOf(","))
        Try
            If EquipmentCollection.Items.Count > 0 Then
                For Each it As DataRow In EntityPerson.getInstance().getPersonneByLastName(nomPersonne).Rows
                    no_personne = it.Item(0)
                Next
                autorisation = TbAutorise.Text
                duree = (NumericUpDownJour.Value * 24) + NumericUpDownHeure.Value
                dateRetour = DateTimePicker1.Value
                id = EntityRental.getInstance.Empruntnextid()
                For Each item As ListViewItem In EquipmentCollection.Items
                    no_equipement = item.SubItems(0).Text
                    empruntEntity.addRental(id, no_personne, no_equipement, autorisation, Date.Now, duree, dateRetour, Trim(Comments.Text))
                    empruntEntity.updateEquipmentNonAvailable(no_equipement)
                Next
                rentals.loadData(EntityRental.getInstance().getRentals())
                MessageBox.Show("L'emprunt à été ajouté avec succès.")
                Me.SendToBack()
                rentals.DetailsButton.Enabled = False
                rentals.ReturnButton.Enabled = False
            Else
                MessageBox.Show("Veuillez sélectionner des équipement à emprunter.")
            End If
        Catch ex As Exception
            MessageBox.Show("Valeur invalide - Veuillez vérifier tous les champs")
        End Try
    End Function

    Public Function refreshCategorie()
        CbCategorie.Items.Clear()
        CbCategorie.Enabled = True
        Dim ctr1 As Integer
        ctr1 = 0
        Dim command As New MySqlCommand
        command.Connection = connection
        command.CommandText = slCategorie
        connection.Open()
        reader = command.ExecuteReader
        While (reader.Read)
            CbCategorie.Items.Add(reader.GetString(0) + " - " + reader.GetString(1))
            ListCategorie(ctr1, 0) = reader.GetString(0)
            ListCategorie(ctr1, 1) = reader.GetString(1)
            ctr1 += 1
        End While
        CbEquipement.Items.Clear()
        connection.Close()
    End Function

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click, CancelButton.Click
        If MessageBox.Show($"Voulez-vous vraiment faire cette opération?{Environment.NewLine}Tous vos changement seront perdus.", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Me.SendToBack()
            rentals.loadData(EntityRental.getInstance().getRentals())
            rentals.DetailsButton.Enabled = False
            rentals.ReturnButton.Enabled = False
        End If
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        If ValideDate() Then
            If validPerson() Then
                If (Not String.IsNullOrEmpty(TbAutorise.Text) And DateTimePicker1.Value > DateTime.Now) Then
                    insertToRental()
                    RefreshEquipement()
                Else
                    MessageBox.Show("Valeur invalide - Veuillez vérifier tous les champs")
                End If
            Else
                MessageBox.Show("Veuillez entrer une personne existante ou en ajouter une nouvelle.")
            End If
        Else
            MessageBox.Show("La date n'est pas valide")
        End If
    End Sub

    Public Function validPerson() As Boolean
        For Each it As DataRow In EntityPerson.getInstance().getPerson().Rows
            Dim personName = $"{it.Item(1)}, {it.Item(2)}"
            If personName = Person.Text Then
                Return True
            End If
        Next
        Return False
    End Function

    Private Sub ResetButton_Click(sender As Object, e As EventArgs) Handles ResetButton.Click
        If MessageBox.Show($"Voulez-vous vraiment faire cette opération?{Environment.NewLine}Tous vos changement seront perdus.", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            CbEquipement.Items.Clear()
            CbCategorie.Items.Clear()
            Person.Text = ""
            refreshCategorie()
            TbAutorise.Text = ""
            EquipmentCollection.Items.Clear()
            NumericUpDownJour.Value = 0
            NumericUpDownHeure.Value = 0
            DateTimePicker1.Value = Date.Now
        End If
    End Sub

    Private Sub SelectButton_Click(sender As Object, e As EventArgs) Handles SelectButton.Click
        Dim isUnique As Boolean = True
        For Each it As ListViewItem In EquipmentCollection.Items
            If CbEquipement.SelectedIndex > -1 Then
                If it.SubItems(0).Text = ListEquipement(CbEquipement.SelectedIndex, 0) Then
                    isUnique = False
                End If
            End If
        Next
        If Not IsNothing(CbEquipement.Text) And Not CbEquipement.Text = "" And CbEquipement.Items.Count > 0 And isUnique Then
            EquipmentCollection.Items.Add(New ListViewItem({ListEquipement(CbEquipement.SelectedIndex, 0), ListEquipement(CbEquipement.SelectedIndex, 1)}))
        ElseIf Not isUnique Then
            MessageBox.Show("Cet article est déja sélectionné.")
        End If
        RefreshEquipement()
    End Sub

    Private Sub EquipmentCollection_DoubleClick(sender As Object, e As EventArgs) Handles EquipmentCollection.DoubleClick
        If Not IsNothing(EquipmentCollection.SelectedItems.Item(0).Text) Then
            If MessageBox.Show($"Voulez vous retirer cet item?{Environment.NewLine}{EquipmentCollection.SelectedItems.Item(0).Text}", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                EquipmentCollection.Items.Remove(EquipmentCollection.SelectedItems.Item(0))
            End If
        End If
    End Sub

    Private Sub NewPersonButton_Click(sender As Object, e As EventArgs) Handles NewPersonButton.Click
        Dim person As New IAddPerson(Me, New IPerson(MainForm))
        person.Dock = DockStyle.Fill
        MainForm.InterfacePanel.Controls.Add(person)
        person.BringToFront()
    End Sub
End Class


