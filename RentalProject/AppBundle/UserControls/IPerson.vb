Public Class IPerson
    Dim mainForm As MainForm

    Sub New(main As MainForm)
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        mainForm = main
        DetailsButton.Enabled = False
        DeleteButton.Enabled = False
        ModifyButton.Enabled = False
    End Sub

    Private Sub IPeople_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGVPerson.DataSource = EntityPerson.getInstance().getPerson()
        DGVPerson.SelectionMode = DataGridViewSelectionMode.FullRowSelect
    End Sub

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        Dim person As New IAddPerson(New IEmprunt(New IRentals(mainForm)), Me)
        person.Dock = DockStyle.Fill
        mainForm.InterfacePanel.Controls.Add(person)
        person.BringToFront()
    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        If DGVPerson.Rows.Count <> 0 Then
            If MessageBox.Show("Êtes-vous sûr de vouloir effacer cette personne?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                Dim selectIndex As Integer = DGVPerson.SelectedCells(0).RowIndex
                Dim selectRow As DataGridViewRow = DGVPerson.Rows(selectIndex)
                Dim id As Integer = selectRow.Cells("noPersonne").Value

                If Not EntityRental.getInstance().verifPersonHasRental(id) Then
                    If EntityReturn.getInstance().verifPersonHasReturn(id) Then
                        If MessageBox.Show($"Cette personnes possède un historique de retour{Environment.NewLine}Voulez-vous tout de même la supprimer?{Environment.NewLine}Cette action supprimera tout l'historique d'emprunt de cette personne", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                            ModelPerson.getInstance().deletePerson(id)
                            DeleteButton.Enabled = False
                        End If
                    Else
                        ModelPerson.getInstance().deletePerson(id)
                        DeleteButton.Enabled = False
                    End If
                Else
                    MessageBox.Show("Cette personne ne peut pas être supprimer parce qu'elle possède un emprunt")
                End If
                DGVPerson.DataSource = EntityPerson.getInstance().getPerson()
                DGVPerson.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            Else
                DGVPerson.Select()
            End If
        End If
    End Sub

    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        Dim person As New IPersonSearch(Me)
        person.Dock = DockStyle.Fill
        mainForm.InterfacePanel.Controls.Add(person)
        person.BringToFront()
    End Sub

    Private Sub ModifyButton_Click(sender As Object, e As EventArgs) Handles ModifyButton.Click
        If Not IsNothing(DGVPerson.Rows(DGVPerson.SelectedRows.Item(0).Index).Cells(0).Value) Then
            Dim data As DataTable = EntityPerson.getInstance().getPersonByID(DGVPerson.Rows(DGVPerson.SelectedRows.Item(0).Index).Cells(0).Value)
            Dim modifyPerson As New IModifyPerson(mainForm, data, Me)
            modifyPerson.Dock = DockStyle.Fill
            mainForm.InterfacePanel.Controls.Add(modifyPerson)
            modifyPerson.BringToFront()
        End If
    End Sub

    Private Sub DetailsButton_Click(sender As Object, e As EventArgs) Handles DetailsButton.Click
        If Not IsNothing(DGVPerson.Rows(DGVPerson.SelectedRows.Item(0).Index).Cells(0).Value) Then
            Dim data As DataTable = EntityPerson.getInstance().getPersonByID(DGVPerson.Rows(DGVPerson.SelectedRows.Item(0).Index).Cells(0).Value)
            Dim detailsPerson As New IPersonDetails(mainForm, data)
            detailsPerson.Dock = DockStyle.Fill
            mainForm.InterfacePanel.Controls.Add(detailsPerson)
            detailsPerson.BringToFront()
        End If
    End Sub

    Private Sub DGVPerson_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVPerson.CellContentClick
        DeleteButton.Enabled = True
        DetailsButton.Enabled = True
        ModifyButton.Enabled = True
    End Sub
End Class
