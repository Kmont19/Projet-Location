Public Class MainForm

    Public connectionString = "Server='localhost';Database='projetsession';Uid='root';Pwd='';Port=3308;"
    Private isMouseDown As Boolean = False
    Private mouseOffset As Point
    Shared instance As MainForm = Nothing

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Dim home As New IHome()
        home.Dock = DockStyle.Fill
        InterfacePanel.Controls.Add(home)
        home.BringToFront()
    End Sub

    Public Shared Function getInstance() As MainForm
        If IsNothing(instance) Then
            instance = New MainForm()
        End If
        Return instance
    End Function

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click, CloseButton.Click
        If MessageBox.Show("Voulez-vous quitter le programme ?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub MinimizeButton_Click(sender As Object, e As EventArgs) Handles MinimizeButton.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub HeaderBar_MouseDown(sender As Object, e As MouseEventArgs) Handles HeaderBar.MouseDown
        If e.Button = MouseButtons.Left Then
            ' Window Position
            mouseOffset = New Point(-e.X, -e.Y)
            ' Left Mouse Button has been pressed
            isMouseDown = True
        End If
    End Sub

    Private Sub HeaderBar_MouseMove(sender As Object, e As MouseEventArgs) Handles HeaderBar.MouseMove
        If isMouseDown Then
            Dim mousePos As Point = Control.MousePosition
            ' Obtain new Window Position
            mousePos.Offset(mouseOffset.X, mouseOffset.Y)
            Me.Location = mousePos
        End If
    End Sub

    Private Sub HeaderBar_MouseUp(sender As Object, e As MouseEventArgs) Handles HeaderBar.MouseUp
        If e.Button = MouseButtons.Left Then
            'Left Mouse Button has been released
            isMouseDown = False
        End If
    End Sub

    Private Sub InventoryButton_Click(sender As Object, e As EventArgs) Handles InventoryButton.Click
        Dim inventory As New IInventory(Me)
        InterfacePanel.Controls.Clear()
        inventory.Dock = DockStyle.Fill
        InterfacePanel.Controls.Add(inventory)
        inventory.BringToFront()
    End Sub

    Private Sub RentalsButton_Click(sender As Object, e As EventArgs) Handles RentalsButton.Click
        InterfacePanel.Controls.Clear()
        Dim rentals As New IRentals(Me)
        rentals.Dock = DockStyle.Fill
        InterfacePanel.Controls.Add(rentals)
        rentals.BringToFront()
    End Sub

    Private Sub PeopleButton_Click(sender As Object, e As EventArgs) Handles PersonButton.Click
        InterfacePanel.Controls.Clear()
        Dim persons As New IPerson(Me)
        persons.Dock = DockStyle.Fill
        InterfacePanel.Controls.Add(persons)
        persons.BringToFront()
    End Sub

    Private Sub ReturnButton_Click(sender As Object, e As EventArgs) Handles ReturnButton.Click
        InterfacePanel.Controls.Clear()
        Dim viewReturns As New IViewReturns(Me)
        viewReturns.Dock = DockStyle.Fill
        InterfacePanel.Controls.Add(viewReturns)
        viewReturns.BringToFront()
    End Sub

End Class
