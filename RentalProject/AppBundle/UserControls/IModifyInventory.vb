Imports System.Text.RegularExpressions
Public Class IModifyInventory

    Dim Inventory As IInventory

    Sub New(IInventory As IInventory)
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        Inventory = IInventory
    End Sub

    Private Sub IModifyInventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'on va chercher les différentes catégories existantes pour la combobox
        loadData(EntityCategory.getInstance.getCategory)
    End Sub

    Public Function loadData(data As DataTable)
        'Création de la table comprenant toutes les catégories
        Try
            Dim categoryTable As DataTable = data
            For Each it As DataRow In categoryTable.Rows
                If Not IsNothing(it) Then
                    CBCat.DataSource = categoryTable
                    CBCat.DisplayMember = "nom"
                    CBCat.ValueMember = "nocategorie"
                End If
            Next
            'Inscrire les informations de l'équipement Sélectionné
            'on ne doit pas permettre la modification de l'ID c'Est pourquoi c'Est un label
            LabelNo.Text = Inventory.DataGridView1.SelectedRows.Item(0).Cells(0).Value
            TBName.Text = Inventory.DataGridView1.SelectedRows.Item(0).Cells(1).Value
            CBCat.Text = Inventory.DataGridView1.SelectedRows.Item(0).Cells(2).Value
            CBEtat.Text = Inventory.DataGridView1.SelectedRows.Item(0).Cells(3).Value
            TBDispo.Text = Inventory.DataGridView1.SelectedRows.Item(0).Cells(4).Value
        Catch ex As Exception
            MessageBox.Show("Le chargement des données de l'équipement a échoué:" + ex.Message)
        End Try
    End Function

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click, ButtonCancel.Click
        'Retour au UC inventaire
        If MessageBox.Show($"Voulez-vous vraiment faire cette opération?{Environment.NewLine}Tous vos changement seront perdus.", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Me.SendToBack()
        End If
    End Sub

    Public Function UpdateEquipement()
        'Création des variables pour l'update
        Dim noEquipement As String
        Dim nom As String
        Dim nocategorie As Integer
        Dim etat As String
        Dim disponibilite As String = "oui"
        Try
            'on vérifie si tous les champs sont Remplis
            noEquipement = LabelNo.Text
            nom = TBName.Text
            nocategorie = EntityCategory.getInstance.getNoCategorieByName(CBCat.Text)
            etat = CBEtat.Text
            If etat <> "Neuf" Then
                If etat = "Endommagé" Then
                    If MessageBox.Show($"Cet article est endommagé,{Environment.NewLine}Souhaitez-vous quand même le rendre disponible?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                        disponibilite = "oui"
                    Else
                        disponibilite = "non"
                    End If
                Else
                    disponibilite = "non"
                End If
            End If
            'on update l'équipement dans la table
            ModelEquipment.getInstance.updateequipment(noEquipement, nom, nocategorie, etat, disponibilite)
            ModelCategory.getInstance().UpdateCategorieQuantite(nocategorie)
        Catch ex As Exception
            'message d'erreur lorsque l'un des champs n'est pas rempli
            MessageBox.Show("Valeur invalide - Veuillez vérifier tous les champs")
        End Try
    End Function

    Private Sub ButtonModif_Click(sender As Object, e As EventArgs) Handles ButtonModif.Click
        'Confirmation de la modification
        Static textExpression As New Regex("^[a-zA-Z0-9]+$")
        If Trim(TBName.Text) = "" Or Trim(CBCat.Text = "") Or Trim(CBEtat.Text) = "" Then
            MessageBox.Show("Veuillez remplir tous les champs avant d'ajouter un équipement", "Erreur")
        Else
            If textExpression.IsMatch(TBName.Text) Then
                Dim result As DialogResult = MessageBox.Show("Voulez vous modifier l'équipement de la base de donnée, ses nouvelles informations seront:" & vbCrLf & "NoEquipement: " & LabelNo.Text & vbCrLf & "Nom: " & TBName.Text & vbCrLf & "Catégorie: " & CBCat.Text & vbCrLf & "État:" & CBEtat.Text & vbCrLf & "Dispo: " & TBDispo.Text, "Confirmation", MessageBoxButtons.YesNo)
                If result = DialogResult.Yes Then

                    'appel de la procédure de mise à jour
                    UpdateEquipement()
                    'mise à jour de la datagridview Inventaire
                    Inventory.DataGridView1.DataSource = EntityEquipment.getInstance().getEquipment()
                    Me.SendToBack()
                End If
            Else
                MessageBox.Show("Veuillez utiliser des chiffres et/ou des lettres pour le nom")
            End If
        End If
    End Sub
End Class
