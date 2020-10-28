﻿Public Class IReservation


    Sub New(main As MainForm)
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        MainForm = main
        DetailsButton.Enabled = False
        SearchButton.Enabled = True
        ReturnButton.Enabled = False
    End Sub


    Private Sub IReservation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadData(EntityReservation.getInstance().getReservation)
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


End Class
