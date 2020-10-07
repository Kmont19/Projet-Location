<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ICategorySearch
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TBQuantity = New System.Windows.Forms.TextBox()
        Me.ByQuantity = New System.Windows.Forms.RadioButton()
        Me.TBNom = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ByName = New System.Windows.Forms.RadioButton()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.DGVQuantity = New System.Windows.Forms.DataGridView()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.SearchButton = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.DGVQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.BackButton)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(781, 62)
        Me.Panel1.TabIndex = 3
        '
        'BackButton
        '
        Me.BackButton.Dock = System.Windows.Forms.DockStyle.Left
        Me.BackButton.FlatAppearance.BorderSize = 0
        Me.BackButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BackButton.Image = Global.RentalProject.My.Resources.Resources.baseline_backward_black_18dp_4x
        Me.BackButton.Location = New System.Drawing.Point(0, 0)
        Me.BackButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(93, 62)
        Me.BackButton.TabIndex = 0
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.Label5.Location = New System.Drawing.Point(0, 0)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(781, 62)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Recherche - Catégorie"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.TBQuantity)
        Me.Panel2.Controls.Add(Me.ByQuantity)
        Me.Panel2.Controls.Add(Me.TBNom)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.ByName)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 62)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(205, 480)
        Me.Panel2.TabIndex = 5
        '
        'TBQuantity
        '
        Me.TBQuantity.Enabled = False
        Me.TBQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBQuantity.Location = New System.Drawing.Point(36, 203)
        Me.TBQuantity.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TBQuantity.Name = "TBQuantity"
        Me.TBQuantity.Size = New System.Drawing.Size(136, 24)
        Me.TBQuantity.TabIndex = 18
        '
        'ByQuantity
        '
        Me.ByQuantity.AutoSize = True
        Me.ByQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ByQuantity.Location = New System.Drawing.Point(36, 172)
        Me.ByQuantity.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ByQuantity.Name = "ByQuantity"
        Me.ByQuantity.Size = New System.Drawing.Size(93, 24)
        Me.ByQuantity.TabIndex = 17
        Me.ByQuantity.TabStop = True
        Me.ByQuantity.Text = "Quantité"
        Me.ByQuantity.UseVisualStyleBackColor = True
        '
        'TBNom
        '
        Me.TBNom.Enabled = False
        Me.TBNom.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBNom.Location = New System.Drawing.Point(36, 92)
        Me.TBNom.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TBNom.Name = "TBNom"
        Me.TBNom.Size = New System.Drawing.Size(136, 24)
        Me.TBNom.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(157, 24)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Rechercher par..."
        '
        'ByName
        '
        Me.ByName.AutoSize = True
        Me.ByName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ByName.Location = New System.Drawing.Point(36, 62)
        Me.ByName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ByName.Name = "ByName"
        Me.ByName.Size = New System.Drawing.Size(65, 24)
        Me.ByName.TabIndex = 11
        Me.ByName.TabStop = True
        Me.ByName.Text = "Nom"
        Me.ByName.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.DGVQuantity)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(205, 62)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(576, 480)
        Me.Panel3.TabIndex = 6
        '
        'DGVQuantity
        '
        Me.DGVQuantity.AllowUserToAddRows = False
        Me.DGVQuantity.AllowUserToDeleteRows = False
        Me.DGVQuantity.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DGVQuantity.BackgroundColor = System.Drawing.Color.White
        Me.DGVQuantity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVQuantity.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGVQuantity.Location = New System.Drawing.Point(0, 0)
        Me.DGVQuantity.Margin = New System.Windows.Forms.Padding(4)
        Me.DGVQuantity.Name = "DGVQuantity"
        Me.DGVQuantity.ReadOnly = True
        Me.DGVQuantity.RowHeadersWidth = 51
        Me.DGVQuantity.Size = New System.Drawing.Size(576, 417)
        Me.DGVQuantity.TabIndex = 11
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.SearchButton)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 417)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(576, 63)
        Me.Panel4.TabIndex = 0
        '
        'SearchButton
        '
        Me.SearchButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.SearchButton.Dock = System.Windows.Forms.DockStyle.Right
        Me.SearchButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.SearchButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SearchButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchButton.ForeColor = System.Drawing.Color.White
        Me.SearchButton.Image = Global.RentalProject.My.Resources.Resources.baseline_search_white_18dp
        Me.SearchButton.Location = New System.Drawing.Point(450, 0)
        Me.SearchButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SearchButton.Name = "SearchButton"
        Me.SearchButton.Size = New System.Drawing.Size(126, 63)
        Me.SearchButton.TabIndex = 12
        Me.SearchButton.UseVisualStyleBackColor = False
        '
        'ICategorySearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimumSize = New System.Drawing.Size(781, 542)
        Me.Name = "ICategorySearch"
        Me.Size = New System.Drawing.Size(781, 542)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.DGVQuantity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents BackButton As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ByQuantity As RadioButton
    Friend WithEvents TBNom As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ByName As RadioButton
    Friend WithEvents TBQuantity As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents DGVQuantity As DataGridView
    Friend WithEvents Panel4 As Panel
    Friend WithEvents SearchButton As Button
    Friend WithEvents Label5 As Label
End Class
