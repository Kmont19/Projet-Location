Public Class IRentals

    Dim mainForm As MainForm

    Sub New(main As MainForm)
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        mainForm = main
        DetailsButton.Enabled = False
        SearchButton.Enabled = True
        ReturnButton.Enabled = False
    End Sub

    Private Sub IRentals_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadData(EntityRental.getInstance().getRentals())
    End Sub

    ''' <summary>
    ''' Fonction affichant la liste des emprunts et empêche
    ''' l'utilisateur d'appuyer le bouton recherche s'il n'y en a pas.
    ''' </summary>
    ''' <param name="data"></param>
    ''' <returns></returns>
    Public Function loadData(data As DataTable)
        ListView1.Items.Clear()
        Dim rentalTable As DataTable = data
        If Not rentalTable.Rows.Count > 0 Then
            SearchButton.Enabled = False
        Else
            For Each it As DataRow In rentalTable.Rows
                If Not IsNothing(it) Then
                    ListView1.Items.Add(New ListViewItem({it.Item(0), it.Item(1), it.Item(2)}))
                End If
            Next
        End If
    End Function

    Private Sub DetailsButton_EnabledChanged(sender As Object, e As EventArgs) Handles DetailsButton.EnabledChanged, ReturnButton.EnabledChanged
        If DetailsButton.Enabled Then
            WarningLabel.Hide()
        Else
            WarningLabel.Show()
        End If
    End Sub

    ''' <summary>
    ''' Permet l'utilisateur d'appuyer le boutton détail
    ''' si un emprunt est sélectionné dans la liste.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        If ListView1.Items.Count > 0 Then
            If Not IsNothing(ListView1.FocusedItem) AndAlso ListView1.FocusedItem.Index >= 0 Then
                DetailsButton.Enabled = True
                ReturnButton.Enabled = True
            Else
                DetailsButton.Enabled = False
                ReturnButton.Enabled = False
            End If
        End If
    End Sub

    Private Sub RentButton_Click(sender As Object, e As EventArgs) Handles RentButton.Click
        Dim rent As New IEmprunt(Me)
        rent.Dock = DockStyle.Fill
        mainForm.InterfacePanel.Controls.Add(rent)
        rent.BringToFront()
    End Sub

    Private Sub ReturnButton_Click(sender As Object, e As EventArgs) Handles ReturnButton.Click
        If Not String.IsNullOrEmpty(ListView1.Items(ListView1.FocusedItem.Index).SubItems(0).Text) Then
            Dim ret As New IReturnDetails(mainForm, Me, ListView1.Items(ListView1.FocusedItem.Index).SubItems(0).Text)
            ret.Dock = DockStyle.Fill
            mainForm.InterfacePanel.Controls.Add(ret)
            ret.BringToFront()
        End If
    End Sub


    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        Dim search As New IRentalsSearch(mainForm, Me)
        search.Dock = DockStyle.Fill
        mainForm.InterfacePanel.Controls.Add(search)
        search.BringToFront()
    End Sub

    Private Sub ShowButton_Click(sender As Object, e As EventArgs) Handles ListView1.DoubleClick, DetailsButton.Click
        If Not String.IsNullOrEmpty(ListView1.Items(ListView1.FocusedItem.Index).SubItems(0).Text) Then
            Dim detail As New IRentalsDetails(mainForm, CInt(ListView1.Items(ListView1.FocusedItem.Index).SubItems(0).Text))
            detail.Dock = DockStyle.Fill
            mainForm.InterfacePanel.Controls.Add(detail)
            detail.BringToFront()
        End If
    End Sub
End Class
