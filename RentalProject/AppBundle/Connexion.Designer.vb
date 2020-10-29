<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Connexion
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TBUser = New System.Windows.Forms.TextBox()
        Me.LaUser = New System.Windows.Forms.Label()
        Me.LaPassword = New System.Windows.Forms.Label()
        Me.TBPassword = New System.Windows.Forms.TextBox()
        Me.BTConnexion = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TBUser
        '
        Me.TBUser.Location = New System.Drawing.Point(149, 61)
        Me.TBUser.Name = "TBUser"
        Me.TBUser.Size = New System.Drawing.Size(145, 20)
        Me.TBUser.TabIndex = 0
        '
        'LaUser
        '
        Me.LaUser.AutoSize = True
        Me.LaUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.LaUser.Location = New System.Drawing.Point(43, 62)
        Me.LaUser.Name = "LaUser"
        Me.LaUser.Size = New System.Drawing.Size(71, 17)
        Me.LaUser.TabIndex = 1
        Me.LaUser.Text = "Utilisateur"
        '
        'LaPassword
        '
        Me.LaPassword.AutoSize = True
        Me.LaPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.LaPassword.Location = New System.Drawing.Point(21, 122)
        Me.LaPassword.Name = "LaPassword"
        Me.LaPassword.Size = New System.Drawing.Size(93, 17)
        Me.LaPassword.TabIndex = 3
        Me.LaPassword.Text = "Mot de passe"
        '
        'TBPassword
        '
        Me.TBPassword.Location = New System.Drawing.Point(149, 121)
        Me.TBPassword.Name = "TBPassword"
        Me.TBPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TBPassword.Size = New System.Drawing.Size(145, 20)
        Me.TBPassword.TabIndex = 1
        '
        'BTConnexion
        '
        Me.BTConnexion.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.BTConnexion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTConnexion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTConnexion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.BTConnexion.ForeColor = System.Drawing.Color.White
        Me.BTConnexion.Location = New System.Drawing.Point(111, 185)
        Me.BTConnexion.Margin = New System.Windows.Forms.Padding(0)
        Me.BTConnexion.Name = "BTConnexion"
        Me.BTConnexion.Size = New System.Drawing.Size(102, 40)
        Me.BTConnexion.TabIndex = 2
        Me.BTConnexion.Text = "Se connecter"
        Me.BTConnexion.UseVisualStyleBackColor = False
        '
        'Connexion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(322, 273)
        Me.Controls.Add(Me.BTConnexion)
        Me.Controls.Add(Me.LaPassword)
        Me.Controls.Add(Me.TBPassword)
        Me.Controls.Add(Me.LaUser)
        Me.Controls.Add(Me.TBUser)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Connexion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Connexion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TBUser As TextBox
    Friend WithEvents LaUser As Label
    Friend WithEvents LaPassword As Label
    Friend WithEvents TBPassword As TextBox
    Friend WithEvents BTConnexion As Button
End Class
