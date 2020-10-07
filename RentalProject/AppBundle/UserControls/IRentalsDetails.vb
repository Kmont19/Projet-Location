Public Class IRentalsDetails

    Dim mainForm As MainForm
    ''' <summary>
    ''' Cet attribut est le numéro de'emprunt pour récupérer
    ''' touts les informations requises de la base de données
    ''' </summary>
    Dim id As Integer

    Sub New(main As MainForm, number As Integer)
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        mainForm = main
        id = number
    End Sub

    ''' <summary>
    ''' Ce Sub applique les données récupérées dans les champs textes.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub IRentalsDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim item As DataTable = EntityRental.getInstance().getRentalDetailed(id)
        For Each it As DataRow In item.Rows
            RentalID.Text = it.Item(0)
            RenterFirstName.Text = it.Item(1)
            RenterLastName.Text = it.Item(2)
            RenterStatus.Text = it.Item(3)
            Email.Text = it.Item(4)
            Authorisation.Text = it.Item(5)
            RentalDate.Value = it.Item(6)
            ReturnDate.Value = it.Item(7)
        Next
        RentalDate.CustomFormat = "dd-MM-yyyy hh:mm:ss"
        ReturnDate.CustomFormat = "dd-MM-yyyy hh:mm:ss"

        DGVEquipments.DataSource = EntityEquipment.getInstance.getEquipmentRented(RentalID.Text)

    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Me.SendToBack()
    End Sub

    ''' <summary>
    ''' Ce sub permet de modifier les informations de l'emprunt affiché.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ModifyButton_Click(sender As Object, e As EventArgs) Handles ModifyButton.Click
        Dim data As DataTable = EntityRental.getInstance().getRentalDatesbyID(RentalID.Text)
        Dim modifyRental As New IModifyRental(mainForm, data)
        modifyRental.Dock = DockStyle.Fill
        mainForm.InterfacePanel.Controls.Add(modifyRental)
        modifyRental.BringToFront()
    End Sub

    Private Sub ReturnButton_Click(sender As Object, e As EventArgs) Handles ReturnButton.Click
        Dim returnDetail As New IReturnDetails(mainForm, New IRentals(mainForm), CInt(RentalID.Text))
        returnDetail.Dock = DockStyle.Fill
        mainForm.InterfacePanel.Controls.Add(returnDetail)
        returnDetail.BringToFront()
    End Sub
End Class
