Imports MySql.Data.MySqlClient
Public Class IEquipmentDetails
    Dim Inventory As IInventorySearch

    Sub New(IInventory As IInventorySearch)
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        Inventory = IInventory
    End Sub
    Private Sub IEquipmentDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'on va chercher les informations détaillées de l'équipement grâce à son ID
        Try
            Dim item As DataTable = EntityEquipment.getInstance().getEquipmentDetailed(Inventory.DataGridView1.SelectedRows.Item(0).Cells(0).Value)
            For Each it As DataRow In item.Rows
                EquipmentID.Text = it.Item(0)
                EquipmentName.Text = it.Item(1)
                CategoryName.Text = it.Item(2)
                EquipmentState.Text = it.Item(3)
                'certains Équipements ne sont pas empruntés on évite les erreurs possibles en mettant les prochaines informations dans un try catch
                Try
                    'Insertion des informations d'emprunt et de personne dans les textbox
                    RenterFirstName.Text = it.Item(4)
                    RenterLastName.Text = it.Item(5)
                    RenterStatus.Text = it.Item(6)
                    Email.Text = it.Item(7)
                    Authorisation.Text = it.Item(8)
                    RentalDate.Value = it.Item(9)
                    ReturnDate.Value = it.Item(10)
                Catch

                End Try
            Next
        Catch ex As Exception
            MessageBox.Show("Il y a eu une erreur lors du chargement des détails de l'équipement:" + ex.Message)
        End Try
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        'Retour au UC inventaire
        Try
            If MessageBox.Show($"Voulez-vous vraiment faire cette opération?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                Me.SendToBack()
            End If
        Catch ex As Exception
            MessageBox.Show("Il y a eu une erreur lors du retour à la page précédente:" + ex.Message)
        End Try
    End Sub
End Class
