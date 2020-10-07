Public Class IPersonDetails

    Dim mainForm As MainForm
    Dim data As DataTable

    Sub New(main As MainForm, items As DataTable)
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        mainForm = main
        data = items
    End Sub

    Private Sub IPersonDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        setDefaults()
    End Sub

    ''' <summary>
    ''' Entre les données de la personne selectionné dans les champs text.
    ''' </summary>
    ''' <returns></returns>
    Private Function setDefaults()
        For Each it As DataRow In data.Rows
            'Inserting values into textBoxes
            ID.Text = it.Item(0)
            LastName.Text = it.Item(1)
            FirstName.Text = it.Item(2)
            Status.Text = it.Item(3)
            Department.Text = it.Item(4)
            Service.Text = it.Item(5)
            Office.Text = it.Item(6)
            Phone.Text = it.Item(7)
            Extension.Text = it.Item(8)
            Email.Text = it.Item(9)
        Next
        ''' Cette partie recherche touos les quipements que cette
        ''' personne à emprunté et les affiche dans la liste.
        Dim equipmentList As DataTable = EntityPerson.getInstance().getPersonRentedItemsByID(CInt(ID.Text))
        For Each it As DataRow In equipmentList.Rows
            If Not IsNothing(it) Then
                ListView1.Items.Add(New ListViewItem({it.Item(0)}))
            End If
        Next
    End Function

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Me.SendToBack()
    End Sub

    Private Sub ModifyButton_Click(sender As Object, e As EventArgs) Handles ModifyButton.Click
        Dim data As DataTable = EntityPerson.getInstance().getPersonByID(CInt(ID.Text))
        Dim modifyPerson As New IModifyPerson(mainForm, data, New IPerson(mainForm))
        modifyPerson.Dock = DockStyle.Fill
        mainForm.InterfacePanel.Controls.Add(modifyPerson)
        modifyPerson.BringToFront()
    End Sub
End Class
