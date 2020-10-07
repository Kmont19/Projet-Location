Imports System.Text.RegularExpressions

Public Class IViewReturns

    Dim mainForm As MainForm

    Sub New(main As MainForm)
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        mainForm = main
    End Sub

    Private Sub IViewReturns_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadData()
        ReturnDate.CustomFormat = "dd-MM-yyyy"
        ReturnDate.Value = Date.Now
        createReceptionAutoComplete(Reception)
        createEquipmentAutoComplete(RenterName)
    End Sub

    Public Function loadData()
        Dim returns As DataTable = EntityReturn.getInstance().getReturn()
        If returns.Rows.Count = 0 Then
            MessageBox.Show("Il n'y à aucun retour à afficher.")
            mainForm.InterfacePanel.Controls.Clear()
            Dim home As New IHome()
            home.Dock = DockStyle.Fill
            mainForm.InterfacePanel.Controls.Add(home)
            home.BringToFront()
        End If
        DataGridView1.DataSource = returns
    End Function

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        Dim printed As Boolean = False
        If DataGridView1.SelectedRows.Count <> 0 Then
            If MessageBox.Show($"Êtes-vous sur de vouloir supprimer ces enregistrements?{Environment.NewLine}ATTENTION!!{Environment.NewLine}Si vous confirmez vous ne pourrez plus jamais y avoir accès.", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                For Each it As DataGridViewRow In DataGridView1.SelectedRows
                    If Not IsNothing(it.Cells(0).Value) And DataGridView1.Rows.Count > 0 Then
                        ModelReturn.getInstance().deleteReturn(it.Cells(0).Value, printed)
                        printed = True
                    End If
                Next
                loadData()
            End If
        End If
    End Sub

    ''' <summary>
    ''' Ce sub agit lorsqu'un nouveau boutton radio est choisi
    ''' et déactive les autres champs text.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Radio_CheckedChanged(sender As Object, e As EventArgs) Handles ByReception.CheckedChanged, ByEquipment.CheckedChanged, ByDate.CheckedChanged
        Reception.Text = ""
        RenterName.Text = ""
        ReturnDate.Value = Date.Now
        If ByReception.Checked Then
            Reception.Enabled = True
            RenterName.Enabled = False
            ReturnDate.Enabled = False
        ElseIf ByEquipment.Checked Then
            Reception.Enabled = False
            RenterName.Enabled = True
            ReturnDate.Enabled = False
        ElseIf ByDate.Checked Then
            Reception.Enabled = False
            RenterName.Enabled = False
            ReturnDate.Enabled = True
        End If
    End Sub

    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        SearchItems()
    End Sub

    ''' <summary>
    ''' Cette fonction effectue la recherche lorsque le bouton
    ''' recherche est appuyé selon les paramètres de chercherches entrés.
    ''' </summary>
    ''' <returns></returns>
    Private Function SearchItems()
        Reception.Text = Regex.Replace(Reception.Text, "[\d-]", String.Empty)
        Reception.Text = Regex.Replace(Reception.Text, "[^A-Za-z, ]", String.Empty)
        RenterName.Text = Regex.Replace(RenterName.Text, "[\d-]", String.Empty)
        RenterName.Text = Regex.Replace(RenterName.Text, "[^A-Za-z0-9, ]", String.Empty)
        Dim data As DataTable
        If Reception.Text.Length > 0 Then
            data = EntityReturn.getInstance().getReturnByReception(Reception.Text)
        ElseIf RenterName.Text.Length > 0 Then
            data = EntityReturn.getInstance().getReturnByRenterName(RenterName.Text)
        ElseIf ReturnDate.Enabled Then
            data = EntityReturn.getInstance().getReturnByDate(ReturnDate.Value)
        Else
            MessageBox.Show("Veillez entrez un paramètre de recherche.")
        End If
        If Not IsNothing(data) Then
            If data.Rows.Count = 0 Then
                MessageBox.Show("Aucun historique selon cette recherche.")
                If ByReception.Checked Then
                    Reception.Focus()
                ElseIf ByEquipment.Checked Then
                    RenterName.Focus()
                ElseIf ByDate.Checked Then
                    ReturnDate.Focus()
                End If
                loadData()
            Else
                DataGridView1.DataSource = data
            End If
        End If
    End Function

    Private Sub DetailsButton_Click(sender As Object, e As EventArgs) Handles DetailsButton.Click
        If DataGridView1.SelectedRows.Count <> 0 And Not DataGridView1.SelectedRows.Count > 1 Then
            Dim viewDetails As New IViewReturnDetails(Me, CInt(DataGridView1.SelectedRows(0).Cells(0).Value))
            viewDetails.Dock = DockStyle.Fill
            mainForm.InterfacePanel.Controls.Add(viewDetails)
            viewDetails.BringToFront()
        ElseIf DataGridView1.SelectedRows.Count > 1 Then
            MessageBox.Show("Veuillez sélectionner 1 seul enregistrement.")
        Else
            MessageBox.Show("Veuillez sélectionner un enregistrement.")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        loadData()
    End Sub
End Class
