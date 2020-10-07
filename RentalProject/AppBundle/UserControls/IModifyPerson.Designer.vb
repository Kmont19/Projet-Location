<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IModifyPerson
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.ResetButton = New System.Windows.Forms.Button()
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ID = New System.Windows.Forms.TextBox()
        Me.LastName = New System.Windows.Forms.TextBox()
        Me.Department = New System.Windows.Forms.TextBox()
        Me.Service = New System.Windows.Forms.TextBox()
        Me.Status = New System.Windows.Forms.ComboBox()
        Me.Phone = New System.Windows.Forms.MaskedTextBox()
        Me.FirstName = New System.Windows.Forms.MaskedTextBox()
        Me.Office = New System.Windows.Forms.MaskedTextBox()
        Me.Extension = New System.Windows.Forms.MaskedTextBox()
        Me.Email = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.SaveButton)
        Me.Panel1.Controls.Add(Me.ResetButton)
        Me.Panel1.Controls.Add(Me.CancelButton)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 471)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(781, 71)
        Me.Panel1.TabIndex = 80
        '
        'SaveButton
        '
        Me.SaveButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.SaveButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SaveButton.Dock = System.Windows.Forms.DockStyle.Right
        Me.SaveButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.SaveButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SaveButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.SaveButton.Location = New System.Drawing.Point(262, 0)
        Me.SaveButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(173, 71)
        Me.SaveButton.TabIndex = 84
        Me.SaveButton.Text = "Sauvegarder"
        Me.SaveButton.UseVisualStyleBackColor = False
        '
        'ResetButton
        '
        Me.ResetButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.ResetButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ResetButton.Dock = System.Windows.Forms.DockStyle.Right
        Me.ResetButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.ResetButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.ResetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ResetButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResetButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.ResetButton.Location = New System.Drawing.Point(435, 0)
        Me.ResetButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ResetButton.Name = "ResetButton"
        Me.ResetButton.Size = New System.Drawing.Size(173, 71)
        Me.ResetButton.TabIndex = 83
        Me.ResetButton.Text = "Réinitialiser"
        Me.ResetButton.UseVisualStyleBackColor = False
        '
        'CancelButton
        '
        Me.CancelButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.CancelButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CancelButton.Dock = System.Windows.Forms.DockStyle.Right
        Me.CancelButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.CancelButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CancelButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CancelButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.CancelButton.Location = New System.Drawing.Point(608, 0)
        Me.CancelButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(173, 71)
        Me.CancelButton.TabIndex = 82
        Me.CancelButton.Text = "Annuler"
        Me.CancelButton.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(64, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 20)
        Me.Label1.TabIndex = 81
        Me.Label1.Text = "ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(79, 133)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 20)
        Me.Label2.TabIndex = 82
        Me.Label2.Text = "Prénom"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(436, 133)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 20)
        Me.Label3.TabIndex = 83
        Me.Label3.Text = "Nom"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(92, 208)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 20)
        Me.Label4.TabIndex = 84
        Me.Label4.Text = "Statut"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(39, 284)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 20)
        Me.Label5.TabIndex = 85
        Me.Label5.Text = "Département"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(418, 284)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 20)
        Me.Label6.TabIndex = 86
        Me.Label6.Text = "Service"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(82, 417)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 20)
        Me.Label7.TabIndex = 87
        Me.Label7.Text = "Bureau"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(59, 358)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(86, 20)
        Me.Label8.TabIndex = 88
        Me.Label8.Text = "Telephone"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(428, 356)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 20)
        Me.Label9.TabIndex = 89
        Me.Label9.Text = "Poste"
        '
        'ID
        '
        Me.ID.Enabled = False
        Me.ID.Location = New System.Drawing.Point(111, 76)
        Me.ID.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.Size = New System.Drawing.Size(100, 22)
        Me.ID.TabIndex = 90
        '
        'LastName
        '
        Me.LastName.Location = New System.Drawing.Point(510, 129)
        Me.LastName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LastName.Name = "LastName"
        Me.LastName.Size = New System.Drawing.Size(204, 22)
        Me.LastName.TabIndex = 92
        '
        'Department
        '
        Me.Department.Location = New System.Drawing.Point(176, 281)
        Me.Department.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Department.Name = "Department"
        Me.Department.Size = New System.Drawing.Size(204, 22)
        Me.Department.TabIndex = 93
        '
        'Service
        '
        Me.Service.Location = New System.Drawing.Point(510, 281)
        Me.Service.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Service.Name = "Service"
        Me.Service.Size = New System.Drawing.Size(204, 22)
        Me.Service.TabIndex = 94
        '
        'Status
        '
        Me.Status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Status.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Status.FormattingEnabled = True
        Me.Status.Items.AddRange(New Object() {"Étudiant", "Professeur", "Technicien", "Administration"})
        Me.Status.Location = New System.Drawing.Point(176, 203)
        Me.Status.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Status.Name = "Status"
        Me.Status.Size = New System.Drawing.Size(204, 24)
        Me.Status.TabIndex = 98
        '
        'Phone
        '
        Me.Phone.Location = New System.Drawing.Point(176, 354)
        Me.Phone.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Phone.Mask = "(000) 000-0000"
        Me.Phone.Name = "Phone"
        Me.Phone.Size = New System.Drawing.Size(204, 22)
        Me.Phone.TabIndex = 99
        '
        'FirstName
        '
        Me.FirstName.Location = New System.Drawing.Point(176, 129)
        Me.FirstName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.FirstName.Name = "FirstName"
        Me.FirstName.Size = New System.Drawing.Size(204, 22)
        Me.FirstName.TabIndex = 100
        '
        'Office
        '
        Me.Office.Location = New System.Drawing.Point(176, 415)
        Me.Office.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Office.Mask = "LL0000"
        Me.Office.Name = "Office"
        Me.Office.Size = New System.Drawing.Size(95, 22)
        Me.Office.TabIndex = 101
        '
        'Extension
        '
        Me.Extension.Location = New System.Drawing.Point(510, 354)
        Me.Extension.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Extension.Mask = "999999"
        Me.Extension.Name = "Extension"
        Me.Extension.Size = New System.Drawing.Size(95, 22)
        Me.Extension.TabIndex = 102
        '
        'Email
        '
        Me.Email.Location = New System.Drawing.Point(510, 204)
        Me.Email.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Email.Name = "Email"
        Me.Email.Size = New System.Drawing.Size(204, 22)
        Me.Email.TabIndex = 104
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(429, 208)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(51, 20)
        Me.Label10.TabIndex = 105
        Me.Label10.Text = "Email"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(781, 71)
        Me.Panel2.TabIndex = 106
        '
        'Label13
        '
        Me.Label13.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.Label13.Location = New System.Drawing.Point(0, 0)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(781, 71)
        Me.Label13.TabIndex = 20
        Me.Label13.Text = "Modification de Personne"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'IModifyPerson
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Email)
        Me.Controls.Add(Me.Extension)
        Me.Controls.Add(Me.Office)
        Me.Controls.Add(Me.FirstName)
        Me.Controls.Add(Me.Phone)
        Me.Controls.Add(Me.Status)
        Me.Controls.Add(Me.Service)
        Me.Controls.Add(Me.Department)
        Me.Controls.Add(Me.LastName)
        Me.Controls.Add(Me.ID)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MinimumSize = New System.Drawing.Size(781, 542)
        Me.Name = "IModifyPerson"
        Me.Size = New System.Drawing.Size(781, 542)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents SaveButton As Button
    Friend WithEvents ResetButton As Button
    Friend WithEvents CancelButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents ID As TextBox
    Friend WithEvents LastName As TextBox
    Friend WithEvents Department As TextBox
    Friend WithEvents Service As TextBox
    Friend WithEvents Status As ComboBox
    Friend WithEvents Phone As MaskedTextBox
    Friend WithEvents FirstName As MaskedTextBox
    Friend WithEvents Office As MaskedTextBox
    Friend WithEvents Extension As MaskedTextBox
    Friend WithEvents Email As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label13 As Label
End Class
