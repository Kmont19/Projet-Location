Imports System.Text.RegularExpressions
Public Class IAddInventory
    Dim Inventory As IInventory

    Sub New(IInventory As IInventory)
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        Inventory = IInventory
    End Sub

    Private Sub IAddInventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'aller chercher les catégories existantes pour la combobox
        loaddata(EntityCategory.getInstance.getCategory())
    End Sub

    Private Function loaddata(data As DataTable)
        'Création de la table comprenant toutes les catégories
        Dim categoryTable As DataTable = data
        For Each it As DataRow In categoryTable.Rows
            If Not IsNothing(it) Then
                CBCat.DataSource = categoryTable
                CBCat.DisplayMember = "nom"
                CBCat.ValueMember = "nocategorie"
            End If
        Next
    End Function

    Private Function insert_equipment()
        'Création des variables pour l'ajout
        Dim noEquipement As String
        Dim nom As String
        Dim nocategorie As Integer
        Dim etat As String
        Dim disponibilite As String
        Dim isUnique As Boolean = True
        Dim data As DataTable = EntityEquipment.getInstance().getEquipmentIDs()
        Try
            For Each it As DataRow In data.Rows
                If it.Item(0) = ID.Text Then
                    isUnique = False
                End If
            Next
            If isUnique Then
                noEquipement = ID.Text
                'les nom est entré dans la textbox
                nom = TBName.Text
                'la catégorie est entrée dans la combobox

                nocategorie = EntityCategory.getInstance.getNoCategorieByName(CBCat.Text)
                'l'état est entré dans la textbox
                etat = CBEtat.Text
                'l'équipement est disponible selon l'état
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
                Else
                    disponibilite = "oui"
                End If
                'Ajout de l'équipement à la base de données
                ModelEquipment.getInstance.addequipment(noEquipement, nom, nocategorie, etat, disponibilite)
                ModelCategory.getInstance().UpdateCategorieQuantite(nocategorie)
            Else
                MessageBox.Show($"Ce numéro d'équipement est déja utilisé,{Environment.NewLine}Veuillez en entrer un différent.")
            End If
        Catch ex As Exception
            'message d'erreur lorsque les champs ne sont pas tous remplis
            MessageBox.Show("Valeur invalide - Veuillez vérifier tous les champs")
        End Try
    End Function

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click, CancelButton.Click
        'Retour au UC inventaire
        If MessageBox.Show($"Voulez-vous vraiment faire cette opération?{Environment.NewLine}Tous vos changement seront perdus.", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Me.SendToBack()
        End If
    End Sub

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        'Confirmation que tous les champs sont remplis
        Static textExpression As New Regex("^[a-zA-Z0-9-_]+$")
        Static textExpressionName As New Regex("^[a-zA-Z0-9-_', ]+$")
        TBName.Text = Regex.Replace(TBName.Text, "'", "''")
        If Trim(ID.Text) = "" Or Trim(TBName.Text) = "" Or Trim(CBCat.Text = "") Or Trim(CBEtat.Text) = "" Then
            MessageBox.Show("Veuillez remplir tous les champs avant d'ajouter un équipement", "Erreur")
        Else
            If textExpression.IsMatch(ID.Text) Then
                If textExpressionName.IsMatch(TBName.Text) Then
                    'confirmation de l'ajout
                    Dim result As DialogResult = MessageBox.Show("Voulez vous ajouter un nouvel équipement à la base de donnée, ses informations sont:" & vbCrLf & "NoEquipement: " & ID.Text & vbCrLf & "Nom: " & TBName.Text & vbCrLf & "Catégorie: " & CBCat.Text & vbCrLf & "État:" & CBEtat.Text, "Confirmation", MessageBoxButtons.YesNo)
                    If result = DialogResult.Yes Then
                        'la procédure d'insertion se lance
                        insert_equipment()
                        'on met la datagridview à jour
                        Inventory.DataGridView1.DataSource = EntityEquipment.getInstance().getEquipment()
                        'on retourne au contrôle utilisateur d'inventaire
                        Inventory.DeleteButton.Enabled = True
                        Inventory.ModifyButton.Enabled = True
                        Me.SendToBack()
                    End If
                Else
                    MessageBox.Show("Veuillez utiliser uniquement des lettres, chiffres, tirets ou appostrophes pour le Nom d'équipement")
                End If
            Else
                MessageBox.Show("Veuillez utiliser uniquement des lettres, chiffres ou tirets pour le Numéro d'équipement")
            End If
        End If
    End Sub

    Private Sub NewCategoryButton_Click(sender As Object, e As EventArgs) Handles NewCategoryButton.Click
        Dim categoryName As String = InputBox("Quel est le nom de la catégorie?", "Ajout d'une Catégorie")
        categoryName = Regex.Replace(categoryName, "'", "''")
        categoryName = Regex.Replace(categoryName, "[^A-Za-z0-9' ]", String.Empty)
        If Not String.IsNullOrEmpty(categoryName) Then
            ModelCategory.getInstance().addCategory(categoryName)
        Else
            While MessageBox.Show($"Vous devez entrer un nom de catégorie valide.{Environment.NewLine}Voulez-vous rééssayer?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes
                categoryName = InputBox("Quel est le nom de la catégorie?", "Ajout d'une Catégorie")
                categoryName = Regex.Replace(categoryName, "[^A-Za-z0-9' ]", String.Empty)
                If Not String.IsNullOrEmpty(categoryName) Then
                    ModelCategory.getInstance().addCategory(categoryName)
                End If
            End While
        End If
        loaddata(EntityCategory.getInstance.getCategory())
    End Sub
End Class
