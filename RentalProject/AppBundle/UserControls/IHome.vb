Public Class IHome
    Private Sub IHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    ''' <summary>
    ''' Pour le fun: si vous double cliquez sur le logo,
    ''' vous pourrez être redirigé vers la page du département.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.DoubleClick
        If MessageBox.Show($"Vous allez être redirigé vers la page du département.{Environment.NewLine}Voulez-vous poursuivre?{Environment.NewLine}{Environment.NewLine}https://www.cegeptr.qc.ca/cours-cegep/programmes-techniques/informatique-gestion/", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Process.Start("https://www.cegeptr.qc.ca/cours-cegep/programmes-techniques/informatique-gestion/")
        End If
    End Sub


End Class
