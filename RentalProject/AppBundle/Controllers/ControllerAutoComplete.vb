Imports System.Text.RegularExpressions

Module ControllerAutoComplete

    Public Function loadPersonData() As AutoCompleteStringCollection
        Dim MySource As New AutoCompleteStringCollection()
        Dim data As DataTable = EntityPerson.getInstance().getPerson()
        If data.Rows.Count <> 0 Then
            For Each it As DataRow In data.Rows
                If Not IsNothing(it.Item(1)) And Not IsNothing(it.Item(2)) And
                   Not it.Item(1) = "" And Not it.Item(2) = "" Then
                    MySource.Add($"{it.Item(1)}, {it.Item(2)}")
                End If
            Next
        End If
        Return MySource
    End Function

    Public Sub createPersonAutoComplete(ByVal txt As TextBox)
        With txt
            .Text = Regex.Replace(.Text, "[\d-]", String.Empty)
            .Text = Regex.Replace(.Text, "[^A-Za-z, ]", String.Empty)
            .AutoCompleteMode = AutoCompleteMode.SuggestAppend
            .AutoCompleteSource = AutoCompleteSource.CustomSource
            .AutoCompleteCustomSource = loadPersonData()
        End With
    End Sub

    Public Function loadReceptionData() As AutoCompleteStringCollection
        Dim MySource As New AutoCompleteStringCollection()
        Dim data As DataTable = EntityReturn.getInstance().getReturn()
        If data.Rows.Count <> 0 Then
            For Each it As DataRow In data.Rows
                If Not IsNothing(it.Item(1)) And Not it.Item(1) = "" Then
                    MySource.Add($"{it.Item(1)}")
                End If
            Next
        End If
        Return MySource
    End Function

    Public Sub createReceptionAutoComplete(ByVal txt As TextBox)
        With txt
            .Text = Regex.Replace(.Text, "[\d-]", String.Empty)
            .Text = Regex.Replace(.Text, "[^A-Za-z, ]", String.Empty)
            .AutoCompleteMode = AutoCompleteMode.SuggestAppend
            .AutoCompleteSource = AutoCompleteSource.CustomSource
            .AutoCompleteCustomSource = loadReceptionData()
        End With
    End Sub

    Public Function loadEquipmentData() As AutoCompleteStringCollection
        Dim MySource As New AutoCompleteStringCollection()
        Dim data As DataTable = EntityPerson.getInstance().getPerson()
        If data.Rows.Count <> 0 Then
            For Each it As DataRow In data.Rows
                If Not IsNothing(it.Item(1)) And Not it.Item(1) = "" And
                   Not IsNothing(it.Item(2)) And Not it.Item(2) = "" Then
                    MySource.Add($"{it.Item(1)}, {it.Item(2)}")
                End If
            Next
        End If
        Return MySource
    End Function

    Public Sub createEquipmentAutoComplete(ByVal txt As TextBox)
        With txt
            .Text = Regex.Replace(.Text, "[\d-]", String.Empty)
            .Text = Regex.Replace(.Text, "[^A-Za-z0-9-_, ]", String.Empty)
            .AutoCompleteMode = AutoCompleteMode.SuggestAppend
            .AutoCompleteSource = AutoCompleteSource.CustomSource
            .AutoCompleteCustomSource = loadEquipmentData()
        End With
    End Sub

    Public Sub createEquipmentStatusAutoComplete(ByVal txt As TextBox)
        Dim MySource As New AutoCompleteStringCollection()
        MySource.Add("Neuf")
        MySource.Add("Endommagé")
        MySource.Add("En réparation")
        MySource.Add("Brisé")
        With txt
            .Text = Regex.Replace(.Text, "[\d-]", String.Empty)
            .AutoCompleteMode = AutoCompleteMode.SuggestAppend
            .AutoCompleteSource = AutoCompleteSource.CustomSource
            .AutoCompleteCustomSource = MySource
        End With
    End Sub

    Public Function loadEquipmentNamesData() As AutoCompleteStringCollection
        Dim MySource As New AutoCompleteStringCollection()
        Dim data As DataTable = EntityEquipment.getInstance().getEquipment()
        If data.Rows.Count <> 0 Then
            For Each it As DataRow In data.Rows
                If Not IsNothing(it.Item(1)) And Not it.Item(1) = "" Then
                    MySource.Add($"{it.Item(1)}")
                End If
            Next
        End If
        Return MySource
    End Function

    Public Sub createEquipmentNamesAutoComplete(ByVal txt As TextBox)
        With txt
            .Text = Regex.Replace(.Text, "[\d-]", String.Empty)
            .Text = Regex.Replace(.Text, "[^A-Za-z0-9-_, ]", String.Empty)
            .AutoCompleteMode = AutoCompleteMode.SuggestAppend
            .AutoCompleteSource = AutoCompleteSource.CustomSource
            .AutoCompleteCustomSource = loadEquipmentNamesData()
        End With
    End Sub

    Public Function loadEquipmentIDData() As AutoCompleteStringCollection
        Dim MySource As New AutoCompleteStringCollection()
        Dim data As DataTable = EntityEquipment.getInstance().getEquipment()
        If data.Rows.Count <> 0 Then
            For Each it As DataRow In data.Rows
                If Not IsNothing(it.Item(0)) And Not it.Item(0) = "" Then
                    MySource.Add($"{it.Item(0)}")
                End If
            Next
        End If
        Return MySource
    End Function

    Public Sub createEquipmentIDAutoComplete(ByVal txt As TextBox)
        With txt
            .AutoCompleteMode = AutoCompleteMode.SuggestAppend
            .AutoCompleteSource = AutoCompleteSource.CustomSource
            .AutoCompleteCustomSource = loadEquipmentIDData()
        End With
    End Sub

    Public Function loadCategoryNamesData() As AutoCompleteStringCollection
        Dim MySource As New AutoCompleteStringCollection()
        Dim data As DataTable = EntityCategory.getInstance().getCategory()
        If data.Rows.Count <> 0 Then
            For Each it As DataRow In data.Rows
                If Not IsNothing(it.Item(1)) And Not it.Item(1) = "" Then
                    MySource.Add($"{it.Item(1)}")
                End If
            Next
        End If
        Return MySource
    End Function

    Public Sub createCategoryNamesAutoComplete(ByVal txt As TextBox)
        With txt
            .AutoCompleteMode = AutoCompleteMode.SuggestAppend
            .AutoCompleteSource = AutoCompleteSource.CustomSource
            .AutoCompleteCustomSource = loadCategoryNamesData()
        End With
    End Sub
End Module
