﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.HeaderBar = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MinimizeButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.MenuPanel = New System.Windows.Forms.Panel()
        Me.NotifyButton = New System.Windows.Forms.Button()
        Me.StatsButton = New System.Windows.Forms.Button()
        Me.TimesheetButton = New System.Windows.Forms.Button()
        Me.ReservationButton = New System.Windows.Forms.Button()
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.PersonButton = New System.Windows.Forms.Button()
        Me.InventoryButton = New System.Windows.Forms.Button()
        Me.ReturnButton = New System.Windows.Forms.Button()
        Me.RentalsButton = New System.Windows.Forms.Button()
        Me.InterfacePanel = New System.Windows.Forms.Panel()
        Me.HeaderBar.SuspendLayout()
        Me.MenuPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'HeaderBar
        '
        Me.HeaderBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.HeaderBar.Controls.Add(Me.Label1)
        Me.HeaderBar.Controls.Add(Me.MinimizeButton)
        Me.HeaderBar.Controls.Add(Me.ExitButton)
        Me.HeaderBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.HeaderBar.Location = New System.Drawing.Point(0, 0)
        Me.HeaderBar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.HeaderBar.Name = "HeaderBar"
        Me.HeaderBar.Size = New System.Drawing.Size(981, 44)
        Me.HeaderBar.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(11, 7, 0, 4)
        Me.Label1.Size = New System.Drawing.Size(247, 40)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Gestion d'Inventaire"
        '
        'MinimizeButton
        '
        Me.MinimizeButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MinimizeButton.Dock = System.Windows.Forms.DockStyle.Right
        Me.MinimizeButton.FlatAppearance.BorderSize = 0
        Me.MinimizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.MinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MinimizeButton.Image = Global.RentalProject.My.Resources.Resources.baseline_minimize_black_18dp
        Me.MinimizeButton.Location = New System.Drawing.Point(867, 0)
        Me.MinimizeButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MinimizeButton.Name = "MinimizeButton"
        Me.MinimizeButton.Size = New System.Drawing.Size(57, 44)
        Me.MinimizeButton.TabIndex = 15
        Me.MinimizeButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ExitButton.Dock = System.Windows.Forms.DockStyle.Right
        Me.ExitButton.FlatAppearance.BorderSize = 0
        Me.ExitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ExitButton.Image = Global.RentalProject.My.Resources.Resources.baseline_clear_black_18dp
        Me.ExitButton.Location = New System.Drawing.Point(924, 0)
        Me.ExitButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(57, 44)
        Me.ExitButton.TabIndex = 17
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'MenuPanel
        '
        Me.MenuPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.MenuPanel.Controls.Add(Me.NotifyButton)
        Me.MenuPanel.Controls.Add(Me.StatsButton)
        Me.MenuPanel.Controls.Add(Me.TimesheetButton)
        Me.MenuPanel.Controls.Add(Me.ReservationButton)
        Me.MenuPanel.Controls.Add(Me.CloseButton)
        Me.MenuPanel.Controls.Add(Me.PersonButton)
        Me.MenuPanel.Controls.Add(Me.InventoryButton)
        Me.MenuPanel.Controls.Add(Me.ReturnButton)
        Me.MenuPanel.Controls.Add(Me.RentalsButton)
        Me.MenuPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.MenuPanel.Location = New System.Drawing.Point(0, 44)
        Me.MenuPanel.Margin = New System.Windows.Forms.Padding(11, 10, 11, 10)
        Me.MenuPanel.Name = "MenuPanel"
        Me.MenuPanel.Size = New System.Drawing.Size(200, 542)
        Me.MenuPanel.TabIndex = 1
        '
        'NotifyButton
        '
        Me.NotifyButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.NotifyButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NotifyButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.NotifyButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.NotifyButton.FlatAppearance.BorderSize = 2
        Me.NotifyButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.NotifyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.NotifyButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NotifyButton.Location = New System.Drawing.Point(0, 406)
        Me.NotifyButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.NotifyButton.Name = "NotifyButton"
        Me.NotifyButton.Size = New System.Drawing.Size(200, 58)
        Me.NotifyButton.TabIndex = 9
        Me.NotifyButton.Text = "Centre de notifications"
        Me.NotifyButton.UseVisualStyleBackColor = False
        '
        'StatsButton
        '
        Me.StatsButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.StatsButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.StatsButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.StatsButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.StatsButton.FlatAppearance.BorderSize = 2
        Me.StatsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.StatsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StatsButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatsButton.Location = New System.Drawing.Point(0, 348)
        Me.StatsButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.StatsButton.Name = "StatsButton"
        Me.StatsButton.Size = New System.Drawing.Size(200, 58)
        Me.StatsButton.TabIndex = 8
        Me.StatsButton.Text = "Statistiques"
        Me.StatsButton.UseVisualStyleBackColor = False
        '
        'TimesheetButton
        '
        Me.TimesheetButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.TimesheetButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TimesheetButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.TimesheetButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.TimesheetButton.FlatAppearance.BorderSize = 2
        Me.TimesheetButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.TimesheetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TimesheetButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimesheetButton.Location = New System.Drawing.Point(0, 290)
        Me.TimesheetButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TimesheetButton.Name = "TimesheetButton"
        Me.TimesheetButton.Size = New System.Drawing.Size(200, 58)
        Me.TimesheetButton.TabIndex = 7
        Me.TimesheetButton.Text = "Horaire"
        Me.TimesheetButton.UseVisualStyleBackColor = False
        '
        'ReservationButton
        '
        Me.ReservationButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.ReservationButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ReservationButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.ReservationButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.ReservationButton.FlatAppearance.BorderSize = 2
        Me.ReservationButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.ReservationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ReservationButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReservationButton.Location = New System.Drawing.Point(0, 232)
        Me.ReservationButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ReservationButton.Name = "ReservationButton"
        Me.ReservationButton.Size = New System.Drawing.Size(200, 58)
        Me.ReservationButton.TabIndex = 6
        Me.ReservationButton.Text = "Réservation"
        Me.ReservationButton.UseVisualStyleBackColor = False
        '
        'CloseButton
        '
        Me.CloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CloseButton.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.CloseButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.CloseButton.FlatAppearance.BorderSize = 2
        Me.CloseButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CloseButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseButton.Location = New System.Drawing.Point(0, 484)
        Me.CloseButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(200, 58)
        Me.CloseButton.TabIndex = 3
        Me.CloseButton.Text = "Quitter l'application"
        Me.CloseButton.UseVisualStyleBackColor = False
        '
        'PersonButton
        '
        Me.PersonButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.PersonButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PersonButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.PersonButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.PersonButton.FlatAppearance.BorderSize = 2
        Me.PersonButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.PersonButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PersonButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PersonButton.Location = New System.Drawing.Point(0, 174)
        Me.PersonButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PersonButton.Name = "PersonButton"
        Me.PersonButton.Size = New System.Drawing.Size(200, 58)
        Me.PersonButton.TabIndex = 2
        Me.PersonButton.Text = "Personnes"
        Me.PersonButton.UseVisualStyleBackColor = False
        '
        'InventoryButton
        '
        Me.InventoryButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.InventoryButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.InventoryButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.InventoryButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.InventoryButton.FlatAppearance.BorderSize = 2
        Me.InventoryButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.InventoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.InventoryButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InventoryButton.Location = New System.Drawing.Point(0, 116)
        Me.InventoryButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.InventoryButton.Name = "InventoryButton"
        Me.InventoryButton.Size = New System.Drawing.Size(200, 58)
        Me.InventoryButton.TabIndex = 1
        Me.InventoryButton.Text = "Inventaire"
        Me.InventoryButton.UseVisualStyleBackColor = False
        '
        'ReturnButton
        '
        Me.ReturnButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.ReturnButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ReturnButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.ReturnButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.ReturnButton.FlatAppearance.BorderSize = 2
        Me.ReturnButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.ReturnButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ReturnButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReturnButton.Location = New System.Drawing.Point(0, 58)
        Me.ReturnButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ReturnButton.Name = "ReturnButton"
        Me.ReturnButton.Size = New System.Drawing.Size(200, 58)
        Me.ReturnButton.TabIndex = 5
        Me.ReturnButton.Text = "Historique"
        Me.ReturnButton.UseVisualStyleBackColor = False
        '
        'RentalsButton
        '
        Me.RentalsButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.RentalsButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RentalsButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.RentalsButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.RentalsButton.FlatAppearance.BorderSize = 2
        Me.RentalsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.RentalsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RentalsButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RentalsButton.Location = New System.Drawing.Point(0, 0)
        Me.RentalsButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RentalsButton.Name = "RentalsButton"
        Me.RentalsButton.Size = New System.Drawing.Size(200, 58)
        Me.RentalsButton.TabIndex = 0
        Me.RentalsButton.Text = "Emprunts"
        Me.RentalsButton.UseVisualStyleBackColor = False
        '
        'InterfacePanel
        '
        Me.InterfacePanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.InterfacePanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.InterfacePanel.Location = New System.Drawing.Point(200, 44)
        Me.InterfacePanel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.InterfacePanel.Name = "InterfacePanel"
        Me.InterfacePanel.Size = New System.Drawing.Size(781, 542)
        Me.InterfacePanel.TabIndex = 2
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(981, 586)
        Me.Controls.Add(Me.InterfacePanel)
        Me.Controls.Add(Me.MenuPanel)
        Me.Controls.Add(Me.HeaderBar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "MainForm"
        Me.Text = "MainForm"
        Me.HeaderBar.ResumeLayout(False)
        Me.HeaderBar.PerformLayout()
        Me.MenuPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents HeaderBar As Panel
    Friend WithEvents MinimizeButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents MenuPanel As Panel
    Friend WithEvents InterfacePanel As Panel
    Friend WithEvents CloseButton As Button
    Friend WithEvents PersonButton As Button
    Friend WithEvents InventoryButton As Button
    Friend WithEvents RentalsButton As Button
    Friend WithEvents ReturnButton As Button
    Friend WithEvents ReservationButton As Button
    Friend WithEvents NotifyButton As Button
    Friend WithEvents StatsButton As Button
    Friend WithEvents TimesheetButton As Button
End Class
