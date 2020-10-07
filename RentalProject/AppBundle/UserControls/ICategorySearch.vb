Public Class ICategorySearch

    Dim category As ICategory

    Sub New(categ As ICategory)
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        category = categ
        SearchButton.Enabled = False
        ByName.Checked = True
    End Sub

    Private Sub ICategorySearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGVQuantity.DataSource = EntityCategory.getInstance.getCategory
        DGVQuantity.SelectionMode = DataGridViewSelectionMode.FullRowSelect
    End Sub

    Private Sub Radio_CheckedChanged(sender As Object, e As EventArgs) Handles ByQuantity.CheckedChanged, ByName.CheckedChanged
        TBNom.Text = ""
        TBQuantity.Text = ""
        If ByName.Checked Then
            TBNom.Enabled = True
            TBQuantity.Enabled = False
        ElseIf ByQuantity.Checked Then
            TBQuantity.Enabled = True
            TBNom.Enabled = False
        End If
    End Sub

    Private Sub SearchBoxes_TextChanged(sender As Object, e As EventArgs) Handles TBNom.TextChanged, TBQuantity.TextChanged
        If Not IsNumeric(TBQuantity.Text) And TBQuantity.Text.Length > 0 Then
            MessageBox.Show("Vous devez entrer une valeur numérique.")
            TBQuantity.Clear()
            SearchButton.Enabled = False
        ElseIf (TBQuantity.Name.Length > 0 Or TBQuantity.Text.Length > 0) Then
            SearchButton.Enabled = True
        Else
            SearchButton.Enabled = False
        End If
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Me.SendToBack()
    End Sub

    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        SearchItems()
    End Sub

    Private Sub PressedEnter(sender As Object, e As KeyEventArgs) Handles TBNom.KeyUp, TBQuantity.KeyUp
        If e.KeyCode = Keys.Enter Then
            SearchItems()
        End If
    End Sub

    Private Function SearchItems()
        Dim name = Trim(TBNom.Text)
        Dim quantity = Trim(TBQuantity.Text)

        If name.Length > 0 Then
            DGVQuantity.DataSource = EntityCategory.getInstance.getCategoryByName(name)
        ElseIf quantity.Length > 0 Then
            DGVQuantity.DataSource = EntityCategory.getInstance.getCategoryByQuantity(quantity)
        End If
    End Function


End Class
