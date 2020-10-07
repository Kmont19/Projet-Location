<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IEmprunt
    Inherits System.Windows.Forms.UserControl

    'UserControl remplace la méthode Dispose pour nettoyer la liste des composants.
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TbAutorise = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.CbCategorie = New System.Windows.Forms.ComboBox()
        Me.CbEquipement = New System.Windows.Forms.ComboBox()
        Me.NumericUpDownJour = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.NumericUpDownHeure = New System.Windows.Forms.NumericUpDown()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Comments = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.ResetButton = New System.Windows.Forms.Button()
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.EquipmentCollection = New System.Windows.Forms.ListView()
        Me.EquipmentID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.EquipmentName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.NewPersonButton = New System.Windows.Forms.Button()
        Me.SelectButton = New System.Windows.Forms.Button()
        Me.Person = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        CType(Me.NumericUpDownJour, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownHeure, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(35, 98)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Emprunté par"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(63, 149)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Categorie"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(47, 202)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Équipement"
        '
        'TbAutorise
        '
        Me.TbAutorise.Location = New System.Drawing.Point(159, 250)
        Me.TbAutorise.Margin = New System.Windows.Forms.Padding(4)
        Me.TbAutorise.MaxLength = 30
        Me.TbAutorise.Name = "TbAutorise"
        Me.TbAutorise.Size = New System.Drawing.Size(265, 22)
        Me.TbAutorise.TabIndex = 6
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(61, 418)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(4)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(311, 22)
        Me.DateTimePicker1.TabIndex = 7
        '
        'CbCategorie
        '
        Me.CbCategorie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbCategorie.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CbCategorie.FormattingEnabled = True
        Me.CbCategorie.Location = New System.Drawing.Point(159, 149)
        Me.CbCategorie.Margin = New System.Windows.Forms.Padding(4)
        Me.CbCategorie.Name = "CbCategorie"
        Me.CbCategorie.Size = New System.Drawing.Size(265, 24)
        Me.CbCategorie.TabIndex = 9
        '
        'CbEquipement
        '
        Me.CbEquipement.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbEquipement.Enabled = False
        Me.CbEquipement.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CbEquipement.FormattingEnabled = True
        Me.CbEquipement.Location = New System.Drawing.Point(159, 202)
        Me.CbEquipement.Margin = New System.Windows.Forms.Padding(4)
        Me.CbEquipement.Name = "CbEquipement"
        Me.CbEquipement.Size = New System.Drawing.Size(213, 24)
        Me.CbEquipement.TabIndex = 10
        '
        'NumericUpDownJour
        '
        Me.NumericUpDownJour.Location = New System.Drawing.Point(61, 356)
        Me.NumericUpDownJour.Margin = New System.Windows.Forms.Padding(4)
        Me.NumericUpDownJour.Maximum = New Decimal(New Integer() {720, 0, 0, 0})
        Me.NumericUpDownJour.Name = "NumericUpDownJour"
        Me.NumericUpDownJour.Size = New System.Drawing.Size(81, 22)
        Me.NumericUpDownJour.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(44, 250)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 20)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Autorisé par"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(19, 334)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(178, 20)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Durée de l'emprunt (J)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(85, 394)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(117, 20)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Date de retour"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(269, 390)
        Me.CheckBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(103, 24)
        Me.CheckBox1.TabIndex = 16
        Me.CheckBox1.Text = "Date Fixe"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(243, 334)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(182, 20)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Durée de l'emprunt (H)"
        '
        'NumericUpDownHeure
        '
        Me.NumericUpDownHeure.Location = New System.Drawing.Point(291, 358)
        Me.NumericUpDownHeure.Margin = New System.Windows.Forms.Padding(4)
        Me.NumericUpDownHeure.Maximum = New Decimal(New Integer() {720, 0, 0, 0})
        Me.NumericUpDownHeure.Name = "NumericUpDownHeure"
        Me.NumericUpDownHeure.Size = New System.Drawing.Size(81, 22)
        Me.NumericUpDownHeure.TabIndex = 17
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.Panel1.Controls.Add(Me.BackButton)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(781, 62)
        Me.Panel1.TabIndex = 22
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
        Me.BackButton.Margin = New System.Windows.Forms.Padding(2)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(70, 62)
        Me.BackButton.TabIndex = 0
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.Label11.Location = New System.Drawing.Point(0, 0)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(781, 62)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "Ajout d'un Emprunt"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Comments
        '
        Me.Comments.Location = New System.Drawing.Point(448, 334)
        Me.Comments.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Comments.MaxLength = 1000
        Me.Comments.Multiline = True
        Me.Comments.Name = "Comments"
        Me.Comments.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Comments.Size = New System.Drawing.Size(327, 106)
        Me.Comments.TabIndex = 87
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(444, 311)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(118, 20)
        Me.Label10.TabIndex = 86
        Me.Label10.Text = "Commentaires"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.SaveButton)
        Me.Panel2.Controls.Add(Me.ResetButton)
        Me.Panel2.Controls.Add(Me.CancelButton)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 471)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(781, 71)
        Me.Panel2.TabIndex = 88
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
        Me.SaveButton.TabIndex = 87
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
        Me.ResetButton.TabIndex = 86
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
        Me.CancelButton.TabIndex = 85
        Me.CancelButton.Text = "Annuler"
        Me.CancelButton.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(444, 66)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(201, 20)
        Me.Label9.TabIndex = 92
        Me.Label9.Text = "Équipements à emprunter"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(457, 278)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(251, 17)
        Me.Label8.TabIndex = 96
        Me.Label8.Text = "* Pour retirer, Double-clicker sur l'item."
        '
        'EquipmentCollection
        '
        Me.EquipmentCollection.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.EquipmentID, Me.EquipmentName})
        Me.EquipmentCollection.FullRowSelect = True
        Me.EquipmentCollection.HideSelection = False
        Me.EquipmentCollection.Location = New System.Drawing.Point(448, 91)
        Me.EquipmentCollection.Margin = New System.Windows.Forms.Padding(4)
        Me.EquipmentCollection.MultiSelect = False
        Me.EquipmentCollection.Name = "EquipmentCollection"
        Me.EquipmentCollection.Size = New System.Drawing.Size(327, 182)
        Me.EquipmentCollection.TabIndex = 97
        Me.EquipmentCollection.UseCompatibleStateImageBehavior = False
        Me.EquipmentCollection.View = System.Windows.Forms.View.Details
        '
        'EquipmentID
        '
        Me.EquipmentID.Text = "ID"
        Me.EquipmentID.Width = 38
        '
        'EquipmentName
        '
        Me.EquipmentName.Text = "Nom d'équipement"
        Me.EquipmentName.Width = 173
        '
        'NewPersonButton
        '
        Me.NewPersonButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.NewPersonButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NewPersonButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.NewPersonButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.NewPersonButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.NewPersonButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewPersonButton.ForeColor = System.Drawing.Color.White
        Me.NewPersonButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.NewPersonButton.Location = New System.Drawing.Point(381, 94)
        Me.NewPersonButton.Margin = New System.Windows.Forms.Padding(4)
        Me.NewPersonButton.Name = "NewPersonButton"
        Me.NewPersonButton.Size = New System.Drawing.Size(44, 26)
        Me.NewPersonButton.TabIndex = 102
        Me.NewPersonButton.Text = "+"
        Me.NewPersonButton.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.NewPersonButton.UseVisualStyleBackColor = False
        '
        'SelectButton
        '
        Me.SelectButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.SelectButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SelectButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.SelectButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.SelectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SelectButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SelectButton.ForeColor = System.Drawing.Color.White
        Me.SelectButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.SelectButton.Location = New System.Drawing.Point(381, 202)
        Me.SelectButton.Margin = New System.Windows.Forms.Padding(4)
        Me.SelectButton.Name = "SelectButton"
        Me.SelectButton.Size = New System.Drawing.Size(44, 26)
        Me.SelectButton.TabIndex = 101
        Me.SelectButton.Text = "->"
        Me.SelectButton.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.SelectButton.UseVisualStyleBackColor = False
        '
        'Person
        '
        Me.Person.Location = New System.Drawing.Point(159, 96)
        Me.Person.Margin = New System.Windows.Forms.Padding(4)
        Me.Person.MaxLength = 30
        Me.Person.Name = "Person"
        Me.Person.Size = New System.Drawing.Size(213, 22)
        Me.Person.TabIndex = 103
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(156, 75)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(94, 17)
        Me.Label12.TabIndex = 104
        Me.Label12.Text = "Nom, Prénom"
        '
        'IEmprunt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Person)
        Me.Controls.Add(Me.NewPersonButton)
        Me.Controls.Add(Me.SelectButton)
        Me.Controls.Add(Me.EquipmentCollection)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Comments)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.NumericUpDownHeure)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.NumericUpDownJour)
        Me.Controls.Add(Me.CbEquipement)
        Me.Controls.Add(Me.CbCategorie)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.TbAutorise)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimumSize = New System.Drawing.Size(781, 542)
        Me.Name = "IEmprunt"
        Me.Size = New System.Drawing.Size(781, 542)
        CType(Me.NumericUpDownJour, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownHeure, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TbAutorise As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents CbCategorie As ComboBox
    Friend WithEvents CbEquipement As ComboBox
    Friend WithEvents NumericUpDownJour As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Label7 As Label
    Friend WithEvents NumericUpDownHeure As NumericUpDown
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BackButton As Button
    Friend WithEvents Comments As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents SaveButton As Button
    Friend WithEvents ResetButton As Button
    Friend WithEvents CancelButton As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents EquipmentCollection As ListView
    Friend WithEvents EquipmentID As ColumnHeader
    Friend WithEvents EquipmentName As ColumnHeader
    Friend WithEvents NewPersonButton As Button
    Friend WithEvents SelectButton As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents Person As TextBox
    Friend WithEvents Label12 As Label
End Class
