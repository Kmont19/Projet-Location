Public Class IViewReturnDetails

    Dim viewReturns As IViewReturns
    Dim returnID As Integer

    Sub New(v As IViewReturns, id As Integer)
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        viewReturns = v
        returnID = id
    End Sub

    Private Sub IViewReturnDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If returnID <> 0 Then
            'R.noRetour, R.nomReception, P.nom, P.prenom, P.statut, P.email, R.dateRetour, R.note
            Dim data As DataRow = EntityReturn.getInstance().getReturnByID(returnID).Rows(0)
            ID.Text = data.Item(0)
            Reception.Text = data.Item(1)
            LastName.Text = data.Item(2)
            FirstName.Text = data.Item(3)
            Status.Text = data.Item(4)
            Email.Text = data.Item(5)
            ReturnDate.Value = data.Item(6)
            Comments.Text = data.Item(7)
            Dim equipmentList As DataTable = EntityReturn.getInstance().getReturnEquipments(returnID)
            Equipments.DataSource = equipmentList
        End If
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Me.SendToBack()
    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        Dim printed As Boolean = False
        If MessageBox.Show($"Êtes-vous sur de vouloir supprimer cet enregistrement?{Environment.NewLine}ATTENTION!!{Environment.NewLine}Si vous confirmez vous ne pourrez plus jamais y avoir accès.", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            For Each it As DataGridViewRow In Equipments.Rows
                If Not IsNothing(it.Cells(0).Value) And Equipments.Rows.Count > 0 Then
                    ModelReturn.getInstance().deleteReturn(it.Cells(0).Value, printed)
                    printed = True
                End If
            Next
            Me.SendToBack()
            viewReturns.loadData()
        End If
    End Sub
End Class
