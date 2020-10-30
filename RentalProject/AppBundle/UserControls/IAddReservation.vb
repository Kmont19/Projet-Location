Imports MySql.Data.MySqlClient

Public Class IAddReservation

    Public connectionString = $"{MainForm.getInstance.connectionString}Convert Zero Datetime=True"
    Dim connection As New MySqlConnection(connectionString)
    Dim validDate As Boolean = False
    Dim reader As MySqlDataReader
    Dim readdate As MySqlDataReader
    Dim com As New MySqlCommand
    Dim comdate As New MySqlCommand
    Dim ListPersonne(999, 3) As String
    Dim ListCategorie(999, 2) As String
    Dim ListEquipement(999, 3) As String
    Dim slPersonne As String = "SELECT noPersonne,prenom,nom from personne;"
    Dim slCategorie As String = "select noCategorie,nom from categorie;"
    Dim slEquipement As String = "select noEquipement,nom,Etat from Equipement where noCategorie="
    Dim reservs As IReservation



    Sub New(reserv As IReservation)
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        reservs = reserv
    End Sub
End Class
