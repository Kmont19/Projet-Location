<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class IReturnDetails
    Inherits System.Windows.Forms.UserControl

    'UserControl remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.EquipReturnButton = New System.Windows.Forms.Button()
        Me.FullReturnButton = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DGVEquipments = New System.Windows.Forms.DataGridView()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Email = New System.Windows.Forms.TextBox()
        Me.RentalID = New System.Windows.Forms.TextBox()
        Me.RentalDate = New System.Windows.Forms.DateTimePicker()
        Me.Authorisation = New System.Windows.Forms.TextBox()
        Me.RenterFirstName = New System.Windows.Forms.TextBox()
        Me.RenterLastName = New System.Windows.Forms.TextBox()
        Me.RenterStatus = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DGVEquipments, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.BackButton)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(781, 71)
        Me.Panel1.TabIndex = 5
        '
        'BackButton
        '
        Me.BackButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BackButton.Dock = System.Windows.Forms.DockStyle.Left
        Me.BackButton.FlatAppearance.BorderSize = 0
        Me.BackButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BackButton.Image = Global.RentalProject.My.Resources.Resources.baseline_backward_black_18dp_4x
        Me.BackButton.Location = New System.Drawing.Point(0, 0)
        Me.BackButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(69, 71)
        Me.BackButton.TabIndex = 110
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.Label13.Location = New System.Drawing.Point(0, 0)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(781, 71)
        Me.Label13.TabIndex = 111
        Me.Label13.Text = "Retour"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.EquipReturnButton)
        Me.Panel3.Controls.Add(Me.FullReturnButton)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 71)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(222, 471)
        Me.Panel3.TabIndex = 7
        '
        'EquipReturnButton
        '
        Me.EquipReturnButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.EquipReturnButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.EquipReturnButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.EquipReturnButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.EquipReturnButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.EquipReturnButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EquipReturnButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EquipReturnButton.ForeColor = System.Drawing.Color.White
        Me.EquipReturnButton.Location = New System.Drawing.Point(0, 71)
        Me.EquipReturnButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.EquipReturnButton.Name = "EquipReturnButton"
        Me.EquipReturnButton.Size = New System.Drawing.Size(222, 71)
        Me.EquipReturnButton.TabIndex = 114
        Me.EquipReturnButton.Text = "Retourner un equipement"
        Me.EquipReturnButton.UseVisualStyleBackColor = False
        '
        'FullReturnButton
        '
        Me.FullReturnButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.FullReturnButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FullReturnButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.FullReturnButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.FullReturnButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.FullReturnButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FullReturnButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FullReturnButton.ForeColor = System.Drawing.Color.White
        Me.FullReturnButton.Location = New System.Drawing.Point(0, 0)
        Me.FullReturnButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.FullReturnButton.Name = "FullReturnButton"
        Me.FullReturnButton.Size = New System.Drawing.Size(222, 71)
        Me.FullReturnButton.TabIndex = 115
        Me.FullReturnButton.Text = "Retourner au complet"
        Me.FullReturnButton.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.DGVEquipments)
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Email)
        Me.Panel2.Controls.Add(Me.RentalID)
        Me.Panel2.Controls.Add(Me.RentalDate)
        Me.Panel2.Controls.Add(Me.Authorisation)
        Me.Panel2.Controls.Add(Me.RenterFirstName)
        Me.Panel2.Controls.Add(Me.RenterLastName)
        Me.Panel2.Controls.Add(Me.RenterStatus)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(222, 71)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(559, 471)
        Me.Panel2.TabIndex = 8
        '
        'DGVEquipments
        '
        Me.DGVEquipments.AllowUserToAddRows = False
        Me.DGVEquipments.AllowUserToDeleteRows = False
        Me.DGVEquipments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DGVEquipments.BackgroundColor = System.Drawing.Color.White
        Me.DGVEquipments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVEquipments.Location = New System.Drawing.Point(36, 292)
        Me.DGVEquipments.Margin = New System.Windows.Forms.Padding(4)
        Me.DGVEquipments.Name = "DGVEquipments"
        Me.DGVEquipments.RowHeadersWidth = 51
        Me.DGVEquipments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVEquipments.Size = New System.Drawing.Size(489, 158)
        Me.DGVEquipments.TabIndex = 108
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(169, 252)
        Me.Label14.Name = "Label14"
        Me.Label14.Padding = New System.Windows.Forms.Padding(11, 5, 0, 0)
        Me.Label14.Size = New System.Drawing.Size(222, 25)
        Me.Label14.TabIndex = 1
        Me.Label14.Text = "Équipements empruntés"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(105, 163)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 20)
        Me.Label6.TabIndex = 107
        Me.Label6.Text = "Email"
        '
        'Email
        '
        Me.Email.Enabled = False
        Me.Email.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Email.Location = New System.Drawing.Point(173, 161)
        Me.Email.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Email.Name = "Email"
        Me.Email.ReadOnly = True
        Me.Email.Size = New System.Drawing.Size(266, 24)
        Me.Email.TabIndex = 106
        '
        'RentalID
        '
        Me.RentalID.Enabled = False
        Me.RentalID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RentalID.Location = New System.Drawing.Point(88, 16)
        Me.RentalID.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RentalID.Multiline = True
        Me.RentalID.Name = "RentalID"
        Me.RentalID.ReadOnly = True
        Me.RentalID.Size = New System.Drawing.Size(139, 22)
        Me.RentalID.TabIndex = 57
        '
        'RentalDate
        '
        Me.RentalDate.Enabled = False
        Me.RentalDate.Location = New System.Drawing.Point(172, 209)
        Me.RentalDate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RentalDate.Name = "RentalDate"
        Me.RentalDate.Size = New System.Drawing.Size(267, 22)
        Me.RentalDate.TabIndex = 55
        '
        'Authorisation
        '
        Me.Authorisation.Enabled = False
        Me.Authorisation.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Authorisation.Location = New System.Drawing.Point(386, 16)
        Me.Authorisation.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Authorisation.Multiline = True
        Me.Authorisation.Name = "Authorisation"
        Me.Authorisation.ReadOnly = True
        Me.Authorisation.Size = New System.Drawing.Size(139, 22)
        Me.Authorisation.TabIndex = 54
        '
        'RenterFirstName
        '
        Me.RenterFirstName.Enabled = False
        Me.RenterFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RenterFirstName.Location = New System.Drawing.Point(88, 63)
        Me.RenterFirstName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RenterFirstName.Multiline = True
        Me.RenterFirstName.Name = "RenterFirstName"
        Me.RenterFirstName.ReadOnly = True
        Me.RenterFirstName.Size = New System.Drawing.Size(139, 22)
        Me.RenterFirstName.TabIndex = 49
        '
        'RenterLastName
        '
        Me.RenterLastName.Enabled = False
        Me.RenterLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RenterLastName.Location = New System.Drawing.Point(386, 65)
        Me.RenterLastName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RenterLastName.Multiline = True
        Me.RenterLastName.Name = "RenterLastName"
        Me.RenterLastName.ReadOnly = True
        Me.RenterLastName.Size = New System.Drawing.Size(139, 22)
        Me.RenterLastName.TabIndex = 48
        '
        'RenterStatus
        '
        Me.RenterStatus.Enabled = False
        Me.RenterStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RenterStatus.Location = New System.Drawing.Point(88, 111)
        Me.RenterStatus.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RenterStatus.Multiline = True
        Me.RenterStatus.Name = "RenterStatus"
        Me.RenterStatus.ReadOnly = True
        Me.RenterStatus.Size = New System.Drawing.Size(139, 22)
        Me.RenterStatus.TabIndex = 47
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(32, 209)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(124, 20)
        Me.Label11.TabIndex = 45
        Me.Label11.Text = "Date d'emprunt"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(276, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(100, 20)
        Me.Label10.TabIndex = 44
        Me.Label10.Text = "Autorisé par"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(26, 113)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 20)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "Statut"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(332, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 20)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Nom"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 20)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Prénom"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(56, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 20)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "ID"
        '
        'IReturnDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MinimumSize = New System.Drawing.Size(781, 542)
        Me.Name = "IReturnDetails"
        Me.Size = New System.Drawing.Size(781, 542)
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DGVEquipments, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label13 As Label
    Friend WithEvents BackButton As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents FullReturnButton As Button
    Friend WithEvents EquipReturnButton As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DGVEquipments As DataGridView
    Friend WithEvents Label14 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Email As TextBox
    Friend WithEvents RentalID As TextBox
    Friend WithEvents RentalDate As DateTimePicker
    Friend WithEvents Authorisation As TextBox
    Friend WithEvents RenterFirstName As TextBox
    Friend WithEvents RenterLastName As TextBox
    Friend WithEvents RenterStatus As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
