Public Class IModifyRental

    Dim mainForm As MainForm
    Dim data As DataTable
    Dim defaultDays As Integer
    Dim defaultHours As Integer
    Dim defaultReturn As Date
    Dim loaded As Boolean = False

    Sub New(main As MainForm, items As DataTable)
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        mainForm = main
        data = items
    End Sub

    Private Sub IModifyRental_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        setDefaults()
    End Sub

    ''' <summary>
    ''' Entre les valeurs initiales de l'emprunt dans les champs text et les dates.
    ''' </summary>
    ''' <returns></returns>
    Private Function setDefaults()
        For Each it As DataRow In data.Rows
            'setting defaults
            defaultDays = CInt(it.Item(5)) / 24
            defaultHours = CInt(it.Item(5)) Mod 24
            defaultReturn = it.Item(6)
            'Inserting values into textBoxes
            RentalID.Text = it.Item(0)
            RenterName.Text = it.Item(1)
            Authorisation.Text = it.Item(3)
            RentalDate.Value = it.Item(4)
            NumericDays.Value = defaultDays
            NumericHours.Value = defaultHours
            ReturnDate.Value = defaultReturn
            Comments.Text = it.Item(7)
            If defaultReturn < Date.Now Then
                ReturnDate.MinDate = defaultReturn
            Else
                ReturnDate.MinDate = Date.Now
            End If
        Next
        Dim equipmentList As DataTable = EntityRental.getInstance().getRentalEquipments(CInt(RentalID.Text))
        Equipments.DataSource = equipmentList
        If ReturnDate.Value < Date.Now Then
            MessageBox.Show("Cet emprunt est en retard.")
        End If
        RentalDate.Format = DateTimePickerFormat.Custom
        RentalDate.CustomFormat = "dd-MM-yyyy hh:mm:ss"
        ReturnDate.Format = DateTimePickerFormat.Custom
        ReturnDate.CustomFormat = "dd-MM-yyyy hh:mm:ss"
        loaded = True
    End Function

    ''' <summary>
    ''' Vérifie si la date de retour sélectionné est valide selon
    ''' les dates d'ouverture du cegep. Elle débloque ou bloque
    ''' aussi le boutton sauvegarder selon la date de retour.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Duration_ValueChanged(sender As Object, e As EventArgs) Handles NumericDays.ValueChanged, NumericHours.ValueChanged
        If NumericHours.Value = 24 Then
            NumericDays.Increment = 1
            NumericHours.Value = 0
        End If
        If loaded AndAlso Not CheckBox1.Checked Then
            ReturnDate.Value = RentalDate.Value.AddHours(NumericHours.Value + (NumericDays.Value * 24))
            If Not ControllerDates.getInstance().isValidReturnDate(ReturnDate.Value) Then
                SaveButton.Enabled = False
                MessageBox.Show($"La date ou l'heure de retour est invalide{Environment.NewLine}Puisque le Cégep sera fermé.{Environment.NewLine}Veuillez en sélectionner un nouvelle.")
            ElseIf ReturnDate.Value < Date.Now Then
                SaveButton.Enabled = False
            Else
                SaveButton.Enabled = True
            End If
        End If
    End Sub

    ''' <summary>
    ''' Gestion des champs de temps d'emprunt selon
    ''' si la boite de date fixe est cochée.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            NumericDays.Enabled = False
            NumericHours.Enabled = False
            ReturnDate.Enabled = True
        Else
            NumericDays.Enabled = True
            NumericHours.Enabled = True
            ReturnDate.Enabled = False
        End If
    End Sub

    ''' <summary>
    ''' Entre automatiquement le délai en heure et jours selon la date de retour.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ReturnDate_ValueChanged(sender As Object, e As EventArgs) Handles ReturnDate.ValueChanged
        If loaded AndAlso CheckBox1.Checked Then
            Dim hourDiff As Integer = DateDiff(DateInterval.Hour, RentalDate.Value, ReturnDate.Value)
            NumericDays.Value = hourDiff / 24
            NumericHours.Value = hourDiff Mod 24
            If Not ControllerDates.getInstance().isValidReturnDate(ReturnDate.Value) Then
                SaveButton.Enabled = False
                MessageBox.Show($"La date ou l'heure de retour est invalide{Environment.NewLine}Puisque le Cégep sera fermé.{Environment.NewLine}Veuillez en sélectionner un nouvelle.")
            ElseIf ReturnDate.Value < Date.Now Then
                SaveButton.Enabled = False
                MessageBox.Show($"Cette date est passée.{Environment.NewLine}Veuillez en sélectionner une nouvelle.")
            Else
                SaveButton.Enabled = True
            End If
        End If
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        Dim duree As String = DateDiff(DateInterval.Hour, RentalDate.Value, ReturnDate.Value).ToString()
        ModelRental.getInstance().updateRentalReturnDate(RentalID.Text, duree, ReturnDate.Value, Trim(Comments.Text))
        mainForm.InterfacePanel.Controls.Clear()
        Dim rentals As New IRentals(mainForm)
        rentals.Dock = DockStyle.Fill
        mainForm.InterfacePanel.Controls.Add(rentals)
        rentals.BringToFront()
    End Sub

    Private Sub ResetButton_Click(sender As Object, e As EventArgs) Handles ResetButton.Click
        If MessageBox.Show($"Voulez-vous vraiment faire cette opération?{Environment.NewLine}Tous vos changement seront perdus.", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            setDefaults()
        End If
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        If MessageBox.Show($"Voulez-vous vraiment faire cette opération?{Environment.NewLine}Tous vos changement seront perdus.", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Me.SendToBack()
        End If
    End Sub
End Class