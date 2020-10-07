Imports System.Text.RegularExpressions

Public Class ICategory
    Dim inventory As IInventory

    Sub New(invt As IInventory)
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        inventory = invt
    End Sub
    Private Sub Category_Refresh()
        DGVCategory.DataSource = EntityCategory.getInstance.getCategory
        DGVCategory.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        If DGVCategory.Rows.Count = 0 Then
            ModifyButton.Enabled = False
        Else
            ModifyButton.Enabled = True
        End If
    End Sub
    Private Sub ICategory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Category_Refresh()
        AddButton.Enabled = False
    End Sub

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        Dim name = Regex.Replace(TBName.Text, "[^A-Za-z0-9' ]", String.Empty)
        If name.Trim.Length > 0 Then
            ModelCategory.getInstance.addCategory(name)
            Category_Refresh()
        Else
            MessageBox.Show("Vous devez entrer un nom de categorie.")
        End If
    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        If DGVCategory.Rows.Count <> 0 Then
            If DGVCategory.SelectedRows(0).Cells(0).Value <> 0 Then
                If MessageBox.Show("Effacer la catégorie déplacera tous les équipements attachés à celle-ci dans la catégorie Autre, êtes-vous sûr?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                    Dim selectIndex As Integer = DGVCategory.SelectedCells(0).RowIndex
                    Dim selectRow As DataGridViewRow = DGVCategory.Rows(selectIndex)
                    Dim id As Integer = selectRow.Cells("noCategorie").Value

                    ModelCategory.getInstance().deleteCategory(id)

                    DGVCategory.DataSource = EntityCategory.getInstance().getCategory()
                    DGVCategory.SelectionMode = DataGridViewSelectionMode.FullRowSelect
                Else
                    DGVCategory.Select()
                End If
            Else
                MessageBox.Show("La catégorie Autre ne peut pas être supprimée")
            End If
        End If
        Category_Refresh()
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        inventory.DataGridView1.DataSource = EntityEquipment.getInstance().getEquipment()
        Me.SendToBack()
    End Sub

    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        Dim search As New ICategorySearch(Me)
        search.Dock = DockStyle.Fill
        MainForm.InterfacePanel.Controls.Add(search)
        search.BringToFront()
    End Sub

    Private Sub ModifyButton_Click(sender As Object, e As EventArgs) Handles ModifyButton.Click
        Dim categoryName = InputBox("Entrez le nouveau nom de la catégorie", "Modifier catégorie")
        categoryName = Regex.Replace(categoryName, "'", "''")
        categoryName = Regex.Replace(categoryName, "[^A-Za-z0-9' ]", String.Empty)
        If Not String.IsNullOrEmpty(categoryName) Then
            ModelCategory.getInstance.updateCategory(DGVCategory.SelectedRows.Item(0).Cells(0).Value, categoryName)
            Category_Refresh()
        Else
            While MessageBox.Show($"Vous devez entrer un nom de catégorie valide.{Environment.NewLine}Voulez-vous rééssayer?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes
                categoryName = InputBox("Quel est le nom de la catégorie?", "Ajout d'une Catégorie")
                categoryName = Regex.Replace(categoryName, "[^A-Za-z0-9' ]", String.Empty)
                If Not String.IsNullOrEmpty(categoryName) Then
                    ModelCategory.getInstance.updateCategory(DGVCategory.SelectedRows.Item(0).Cells(0).Value, categoryName)
                    Category_Refresh()
                End If
            End While
        End If
    End Sub

    Private Sub TBName_TextChanged(sender As Object, e As EventArgs) Handles TBName.TextChanged
        TBName.Text = Trim(TBName.Text)
        If Not TBName.Text.Length > 0 Then
            AddButton.Enabled = False
        Else
            AddButton.Enabled = True
        End If
    End Sub

    Private Sub AddButton_EnabledChanged(sender As Object, e As EventArgs) Handles AddButton.EnabledChanged
        If AddButton.Enabled Then
            WarningLabel.Hide()
        Else
            WarningLabel.Show()
        End If
    End Sub
End Class
