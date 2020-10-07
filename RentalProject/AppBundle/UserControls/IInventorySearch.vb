'Imports MySql.Data.MySqlClient
Imports System.Text.RegularExpressions

Public Class IInventorySearch
    Dim Inventory As IInventory

    Sub New(IInventory As IInventory)
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        Inventory = IInventory
    End Sub

    Private Sub IInventorySearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'on copie la datagridview inventaire pour la mettre dans le contrôle utilisateur de recherche
        DataGridView1.DataSource = EntityEquipment.getInstance().getEquipment()
        ByEquipmentID.Focus()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        If Not String.IsNullOrEmpty(TextBox1.Text) Then
            'on vérifie quel radio button est sélectionné pour savoir quel est le critère de recherche
            If ByEquipmentID.Checked Then
                TextBox1.Text = Regex.Replace(TextBox1.Text, "[^a-zA-Z0-9-_]", String.Empty)
                DataGridView1.DataSource = EntityEquipment.getInstance().getEquipmentByID(TextBox1.Text)
            ElseIf ByEquipementName.Checked Then
                TextBox1.Text = Regex.Replace(TextBox1.Text, "[^a-zA-Z0-9-_', ]", String.Empty)
                DataGridView1.DataSource = EntityEquipment.getInstance().getEquipmentByName(TextBox1.Text)
            ElseIf ByCategoryName.Checked Then
                TextBox1.Text = Regex.Replace(TextBox1.Text, "'", "''")
                TextBox1.Text = Regex.Replace(TextBox1.Text, "[^A-Za-z0-9' ]", String.Empty)
                DataGridView1.DataSource = EntityEquipment.getInstance().getEquipmentByCategoryName(TextBox1.Text)
            ElseIf ByStatus.Checked Then
                DataGridView1.DataSource = EntityEquipment.getInstance().getEquipmentByEtat(TextBox1.Text)
            Else
                'message d'erreur si aucun bouton n'est sélectionné
                MessageBox.Show("Veuillez sélectionner une valeur de recherche")
            End If
            If DataGridView1.Rows.Count = 0 Then
                MessageBox.Show("Aucun résultat selon ces paramètres de recherche.")
                DataGridView1.DataSource = EntityEquipment.getInstance().getEquipment()
            End If
        End If
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        'Retour au UC inventaire
        Me.SendToBack()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles DetailsButton.Click
        'on s'assure qu'un équipement est sélectionné
        Try
            If DataGridView1.CurrentRow.Index >= 0 And DataGridView1.SelectedRows.Item(0).Cells(0).Value <> "" Then
                'on ouvre le contrôle utilisateur de détails
                Dim InventoryDetails As New IEquipmentDetails(Me)
                InventoryDetails.Dock = DockStyle.Fill
                MainForm.InterfacePanel.Controls.Add(InventoryDetails)
                InventoryDetails.BringToFront()
            Else
                'message d'erreur lorsque l'index est négatif
                MessageBox.Show("Veuillez sélectionner une élément à détailler")
            End If
        Catch
            'message d'erreur lorsque l'index n'est pas adéquat
            MessageBox.Show("Veuillez sélectionner une élément à détailler")
        End Try
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles ByStatus.CheckedChanged, ByCategoryName.CheckedChanged, ByEquipementName.CheckedChanged, ByEquipmentID.CheckedChanged
        TextBox1.Text = ""
        If ByStatus.Checked Then
            createEquipmentStatusAutoComplete(TextBox1)
        ElseIf ByEquipementName.Checked Then
            createEquipmentNamesAutoComplete(TextBox1)
        ElseIf ByEquipmentID.Checked Then
            createEquipmentIDAutoComplete(TextBox1)
        ElseIf ByCategoryName.Checked Then
            createCategoryNamesAutoComplete(TextBox1)
        End If
    End Sub
End Class
