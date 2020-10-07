Imports System.Text.RegularExpressions

Public Class IReturnDetails

    Dim mainForm As MainForm
    Dim rentals As IRentals
    Dim id As Integer

    Sub New(main As MainForm, r As IRentals, number As Integer)
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        mainForm = main
        rentals = r
        id = number
    End Sub

    ''' <summary>
    ''' Ce Sub applique les données récupérées dans les champs textes.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub IReturnDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim item As DataTable = EntityRental.getInstance().getRentalDetailed(id)
        For Each it As DataRow In item.Rows
            RentalID.Text = it.Item(0)
            RenterFirstName.Text = it.Item(1)
            RenterLastName.Text = it.Item(2)
            RenterStatus.Text = it.Item(3)
            Email.Text = it.Item(4)
            Authorisation.Text = it.Item(5)
            RentalDate.Value = it.Item(6)
        Next
        RentalDate.CustomFormat = "dd-MM-yyyy hh:mm:ss"
        DGVEquipments.DataSource = EntityEquipment.getInstance.getEquipmentRented(RentalID.Text)
    End Sub

    Private Sub EquipReturnButton_Click(sender As Object, e As EventArgs) Handles EquipReturnButton.Click
        Dim comment As String = ""
        Dim reception As String = ""
        Dim equipmentNumber As String = ""
        If MessageBox.Show("Êtes-vous sûr de vouloir effectuer le retour pour cet equipement?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            If MessageBox.Show("Voulez vous ajouter un commentaire à ce retour?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                comment = InputBox("Note:", "Commentaires")
            End If
            reception = InputBox("Votre Nom:", "La personne qui reçoit ce retour")
            Dim selectIndex As Integer = DGVEquipments.SelectedCells(0).RowIndex
            Dim selectRow As DataGridViewRow = DGVEquipments.Rows(selectIndex)
            Dim equipment As String = selectRow.Cells("No_Équipement").Value
            equipmentNumber = selectRow.Cells("No_Équipement").Value
            comment = Regex.Replace(comment, "'", "''")
            comment = Regex.Replace(comment, "[^A-Za-z0-9' ]", String.Empty)
            Dim personNumber As DataRow = EntityRental.getInstance().getRentalByID(CInt(RentalID.Text)).Rows(0)
            ModelReturn.getInstance().addReturn(CInt(RentalID.Text), reception, personNumber.Item(1), equipmentNumber, comment, False)
            ModelRental.getInstance().deleteEquipmentFromRental(equipment)
            DGVEquipments.DataSource = EntityEquipment.getInstance.getEquipmentRented(RentalID.Text)
            DGVEquipments.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            If DGVEquipments.Rows.Count = 0 Then
                rentals.loadData(EntityRental.getInstance().getRentals())
                rentals.DetailsButton.Enabled = False
                rentals.ReturnButton.Enabled = False
                mainForm.InterfacePanel.Controls.Clear()
                Dim rental As New IRentals(mainForm)
                rental.Dock = DockStyle.Fill
                mainForm.InterfacePanel.Controls.Add(rental)
                rental.BringToFront()
            End If
        Else
            DGVEquipments.Select()
        End If
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Me.SendToBack()
    End Sub

    Private Sub FullReturnButton_Click(sender As Object, e As EventArgs) Handles FullReturnButton.Click
        Dim comment As String = ""
        Dim reception As String = ""
        Dim printed As Boolean = False
        If MessageBox.Show("Êtes-vous sûr de vouloir effectuer le retour?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            If MessageBox.Show("Voulez vous ajouter un commentaire à ce retour?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                comment = InputBox("Note:", "Commentaires")
                comment = Regex.Replace(comment, "'", "''")
                comment = Regex.Replace(comment, "[^A-Za-z0-9' ]", String.Empty)
            End If
            While reception = ""
                reception = InputBox("Votre Nom:", "La personne qui reçoit ce retour")
                reception = Trim(reception)
                reception = Regex.Replace(reception, "[^A-Za-z- ]", String.Empty)
                If reception = "" Then
                    MessageBox.Show("Vous devez entrer un nom de réception.")
                End If
            End While
            For Each it As DataGridViewRow In DGVEquipments.Rows
                Dim personNumber As DataRow = EntityRental.getInstance().getRentalByID(CInt(RentalID.Text)).Rows(0)
                ModelReturn.getInstance().addReturn(CInt(RentalID.Text), reception, personNumber.Item(1), it.Cells(0).Value, comment, printed)
                ModelRental.getInstance().deleteRental(RentalID.Text, it.Cells(0).Value)
                printed = True
            Next
            rentals.loadData(EntityRental.getInstance().getRentals())
            rentals.DetailsButton.Enabled = False
            rentals.ReturnButton.Enabled = False
            mainForm.InterfacePanel.Controls.Clear()
            Dim rental As New IRentals(mainForm)
            rental.Dock = DockStyle.Fill
            mainForm.InterfacePanel.Controls.Add(rental)
            rental.BringToFront()
        Else
            DGVEquipments.Select()
        End If
    End Sub
End Class
