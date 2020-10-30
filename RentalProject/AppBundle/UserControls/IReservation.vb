Public Class IReservation

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


    Private Sub IReservation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadData(EntityReservations.getInstance().getReservation)
    End Sub

    Public Function loadData(data As DataTable)
        ListView1.Items.Clear()
        Dim reservationTable As DataTable = data
        If Not reservationTable.Rows.Count > 0 Then
            SearchButton.Enabled = False
        Else
            For Each it As DataRow In reservationTable.Rows
                If Not IsNothing(it) Then
                    ListView1.Items.Add(New ListViewItem({it.Item(0), it.Item(1), it.Item(2)}))
                End If
            Next
        End If
    End Function

    Private Sub DetailsButton_Click(sender As Object, e As EventArgs) Handles DetailsButton.EnabledChanged, ReturnButton.EnabledChanged
        If DetailsButton.Enabled Then
            WarningLabel.Hide()
        Else
            WarningLabel.Show()
        End If
    End Sub

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
        Dim reserv As New IAddReservation(Me)
        reserv.Dock = DockStyle.Fill
        mainForm.InterfacePanel.Controls.Add(reserv)
        reserv.BringToFront()
    End Sub

    Private Sub ReturnButton_Click(sender As Object, e As EventArgs) Handles ReturnButton.Click

    End Sub


    Private Sub SearchButton_Click(sender As Object, e As EventArgs)

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
