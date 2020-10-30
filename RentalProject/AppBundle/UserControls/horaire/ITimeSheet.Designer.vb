Imports System.Windows.Forms.Calendar

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ITimeSheet
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()

        'Panel1

        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(586, 71)
        Me.Panel1.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(586, 71)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Horaire"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 71)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(586, 369)
        Me.Panel2.TabIndex = 12
        '
        'ITimeSheet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(251, Byte), Integer))
        'Me.Controls.Add(Me.Panel2)
        'Me.Controls.Add(Me.Panel1)
        Me.MinimumSize = New System.Drawing.Size(586, 440)
        Me.Name = "ITimeSheet"
        Me.Size = New System.Drawing.Size(586, 440)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

        Me.components = New System.ComponentModel.Container()
        Dim calendarHighlightRange1 As System.Windows.Forms.Calendar.CalendarHighlightRange = New System.Windows.Forms.Calendar.CalendarHighlightRange()
        Dim calendarHighlightRange2 As System.Windows.Forms.Calendar.CalendarHighlightRange = New System.Windows.Forms.Calendar.CalendarHighlightRange()
        Dim calendarHighlightRange3 As System.Windows.Forms.Calendar.CalendarHighlightRange = New System.Windows.Forms.Calendar.CalendarHighlightRange()
        Dim calendarHighlightRange4 As System.Windows.Forms.Calendar.CalendarHighlightRange = New System.Windows.Forms.Calendar.CalendarHighlightRange()
        Dim calendarHighlightRange5 As System.Windows.Forms.Calendar.CalendarHighlightRange = New System.Windows.Forms.Calendar.CalendarHighlightRange()
        Me.contextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.redTagToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.yellowTagToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.greenTagToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.blueTagToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.otherColorTagToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.patternToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.diagonalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.verticalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.horizontalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.hatchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
        Me.noneToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.timescaleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.hourToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.minutesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.minutesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.minutesToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.minutesToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.selectImageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.imageAlignmentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.northToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.eastToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.southToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.westToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItem5 = New System.Windows.Forms.ToolStripSeparator()
        Me.editItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.splitter1 = New System.Windows.Forms.Splitter()
        Me.calendar1 = New System.Windows.Forms.Calendar.Calendar()
        Me.monthView1 = New System.Windows.Forms.Calendar.MonthView()
        Me.contextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        Me.contextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.redTagToolStripMenuItem, Me.yellowTagToolStripMenuItem, Me.greenTagToolStripMenuItem, Me.blueTagToolStripMenuItem, Me.otherColorTagToolStripMenuItem, Me.toolStripMenuItem1, Me.patternToolStripMenuItem, Me.timescaleToolStripMenuItem, Me.toolStripMenuItem2, Me.selectImageToolStripMenuItem, Me.imageAlignmentToolStripMenuItem, Me.toolStripMenuItem5, Me.editItemToolStripMenuItem})
        Me.contextMenuStrip1.Name = "contextMenuStrip1"
        Me.contextMenuStrip1.Size = New System.Drawing.Size(167, 242)
        'AddHandler Me.contextMenuStrip1.Opening, New System.ComponentModel.CancelEventHandler(Me.contextMenuStrip1_Opening)
        AddHandler Me.contextMenuStrip1.Opening, AddressOf contextMenuStrip1_Opening
        Me.redTagToolStripMenuItem.Name = "redTagToolStripMenuItem"
        Me.redTagToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.redTagToolStripMenuItem.Text = "Red tag"
        'AddHandler Me.redTagToolStripMenuItem.Click, New System.EventHandler(Me.redTagToolStripMenuItem_Click)
        AddHandler Me.redTagToolStripMenuItem.Click, AddressOf redTagToolStripMenuItem_Click
        Me.yellowTagToolStripMenuItem.Name = "yellowTagToolStripMenuItem"
        Me.yellowTagToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.yellowTagToolStripMenuItem.Text = "Yellow tag"
        'AddHandler Me.yellowTagToolStripMenuItem.Click, New System.EventHandler(Me.yellowTagToolStripMenuItem_Click)
        AddHandler Me.yellowTagToolStripMenuItem.Click, AddressOf yellowTagToolStripMenuItem_Click
        Me.greenTagToolStripMenuItem.Name = "greenTagToolStripMenuItem"
        Me.greenTagToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.greenTagToolStripMenuItem.Text = "Green tag"
        'AddHandler Me.greenTagToolStripMenuItem.Click, New System.EventHandler(Me.greenTagToolStripMenuItem_Click)
        AddHandler Me.greenTagToolStripMenuItem.Click, AddressOf greenTagToolStripMenuItem_Click
        Me.blueTagToolStripMenuItem.Name = "blueTagToolStripMenuItem"
        Me.blueTagToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.blueTagToolStripMenuItem.Text = "Blue tag"
        'AddHandler Me.blueTagToolStripMenuItem.Click, New System.EventHandler(Me.blueTagToolStripMenuItem_Click)
        AddHandler Me.blueTagToolStripMenuItem.Click, AddressOf blueTagToolStripMenuItem_Click
        Me.otherColorTagToolStripMenuItem.Name = "otherColorTagToolStripMenuItem"
        Me.otherColorTagToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.otherColorTagToolStripMenuItem.Text = "Other color tag..."
        'AddHandler Me.otherColorTagToolStripMenuItem.Click, New System.EventHandler(Me.otherColorTagToolStripMenuItem_Click)
        AddHandler Me.otherColorTagToolStripMenuItem.Click, AddressOf otherColorTagToolStripMenuItem_Click
        Me.toolStripMenuItem1.Name = "toolStripMenuItem1"
        Me.toolStripMenuItem1.Size = New System.Drawing.Size(163, 6)
        Me.patternToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.diagonalToolStripMenuItem, Me.verticalToolStripMenuItem, Me.horizontalToolStripMenuItem, Me.hatchToolStripMenuItem, Me.toolStripMenuItem3, Me.noneToolStripMenuItem})
        Me.patternToolStripMenuItem.Name = "patternToolStripMenuItem"
        Me.patternToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.patternToolStripMenuItem.Text = "Pattern"
        Me.diagonalToolStripMenuItem.Name = "diagonalToolStripMenuItem"
        Me.diagonalToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.diagonalToolStripMenuItem.Text = "Diagonal"
        'AddHandler Me.diagonalToolStripMenuItem.Click, New System.EventHandler(Me.diagonalToolStripMenuItem_Click)
        AddHandler Me.diagonalToolStripMenuItem.Click, AddressOf diagonalToolStripMenuItem_Click
        Me.verticalToolStripMenuItem.Name = "verticalToolStripMenuItem"
        Me.verticalToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.verticalToolStripMenuItem.Text = "Vertical"
        'AddHandler Me.verticalToolStripMenuItem.Click, New System.EventHandler(Me.verticalToolStripMenuItem_Click)
        AddHandler Me.verticalToolStripMenuItem.Click, AddressOf verticalToolStripMenuItem_Click
        Me.horizontalToolStripMenuItem.Name = "horizontalToolStripMenuItem"
        Me.horizontalToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.horizontalToolStripMenuItem.Text = "Horizontal"
        'AddHandler Me.horizontalToolStripMenuItem.Click, New System.EventHandler(Me.horizontalToolStripMenuItem_Click)
        AddHandler Me.horizontalToolStripMenuItem.Click, AddressOf horizontalToolStripMenuItem_Click
        Me.hatchToolStripMenuItem.Name = "hatchToolStripMenuItem"
        Me.hatchToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.hatchToolStripMenuItem.Text = "Cross"
        'AddHandler Me.hatchToolStripMenuItem.Click, New System.EventHandler(Me.hatchToolStripMenuItem_Click)
        AddHandler Me.hatchToolStripMenuItem.Click, AddressOf hatchToolStripMenuItem_Click
        Me.toolStripMenuItem3.Name = "toolStripMenuItem3"
        Me.toolStripMenuItem3.Size = New System.Drawing.Size(126, 6)
        Me.noneToolStripMenuItem.Name = "noneToolStripMenuItem"
        Me.noneToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.noneToolStripMenuItem.Text = "None"
        'AddHandler Me.noneToolStripMenuItem.Click, New System.EventHandler(Me.noneToolStripMenuItem_Click)
        AddHandler Me.noneToolStripMenuItem.Click, AddressOf noneToolStripMenuItem_Click
        Me.timescaleToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.hourToolStripMenuItem, Me.minutesToolStripMenuItem, Me.toolStripMenuItem4, Me.minutesToolStripMenuItem1, Me.minutesToolStripMenuItem2, Me.minutesToolStripMenuItem3})
        Me.timescaleToolStripMenuItem.Name = "timescaleToolStripMenuItem"
        Me.timescaleToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.timescaleToolStripMenuItem.Text = "Timescale"
        Me.hourToolStripMenuItem.Name = "hourToolStripMenuItem"
        Me.hourToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.hourToolStripMenuItem.Text = "1 hour"
        'AddHandler Me.hourToolStripMenuItem.Click, New System.EventHandler(Me.hourToolStripMenuItem_Click)
        AddHandler Me.hourToolStripMenuItem.Click, AddressOf hourToolStripMenuItem_Click
        Me.minutesToolStripMenuItem.Name = "minutesToolStripMenuItem"
        Me.minutesToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.minutesToolStripMenuItem.Text = "30 minutes"
        'AddHandler Me.minutesToolStripMenuItem.Click, New System.EventHandler(Me.minutesToolStripMenuItem_Click)
        AddHandler Me.minutesToolStripMenuItem.Click, AddressOf minutesToolStripMenuItem_Click
        Me.toolStripMenuItem4.Name = "toolStripMenuItem4"
        Me.toolStripMenuItem4.Size = New System.Drawing.Size(132, 22)
        Me.toolStripMenuItem4.Text = "15 minutes"
        'AddHandler Me.toolStripMenuItem4.Click, New System.EventHandler(Me.toolStripMenuItem4_Click)
        AddHandler Me.toolStripMenuItem4.Click, AddressOf toolStripMenuItem4_Click
        Me.minutesToolStripMenuItem1.Name = "minutesToolStripMenuItem1"
        Me.minutesToolStripMenuItem1.Size = New System.Drawing.Size(132, 22)
        Me.minutesToolStripMenuItem1.Text = "10 minutes"
        'AddHandler Me.minutesToolStripMenuItem1.Click, New System.EventHandler(Me.minutesToolStripMenuItem1_Click)
        AddHandler Me.minutesToolStripMenuItem1.Click, AddressOf minutesToolStripMenuItem1_Click
        Me.minutesToolStripMenuItem2.Name = "minutesToolStripMenuItem2"
        Me.minutesToolStripMenuItem2.Size = New System.Drawing.Size(132, 22)
        Me.minutesToolStripMenuItem2.Text = "6 minutes"
        'AddHandler Me.minutesToolStripMenuItem2.Click, New System.EventHandler(Me.minutesToolStripMenuItem2_Click)
        AddHandler Me.minutesToolStripMenuItem2.Click, AddressOf Me.minutesToolStripMenuItem2_Click
        Me.minutesToolStripMenuItem3.Name = "minutesToolStripMenuItem3"
        Me.minutesToolStripMenuItem3.Size = New System.Drawing.Size(132, 22)
        Me.minutesToolStripMenuItem3.Text = "5 minutes"
        'AddHandler Me.minutesToolStripMenuItem3.Click, New System.EventHandler(Me.minutesToolStripMenuItem3_Click)
        AddHandler Me.minutesToolStripMenuItem3.Click, AddressOf minutesToolStripMenuItem3_Click
        Me.toolStripMenuItem2.Name = "toolStripMenuItem2"
        Me.toolStripMenuItem2.Size = New System.Drawing.Size(163, 6)
        Me.selectImageToolStripMenuItem.Name = "selectImageToolStripMenuItem"
        Me.selectImageToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.selectImageToolStripMenuItem.Text = "Select Image..."
        'AddHandler Me.selectImageToolStripMenuItem.Click, New System.EventHandler(Me.selectImageToolStripMenuItem_Click)
        AddHandler Me.selectImageToolStripMenuItem.Click, AddressOf selectImageToolStripMenuItem_Click
        Me.imageAlignmentToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.northToolStripMenuItem, Me.eastToolStripMenuItem, Me.southToolStripMenuItem, Me.westToolStripMenuItem})
        Me.imageAlignmentToolStripMenuItem.Name = "imageAlignmentToolStripMenuItem"
        Me.imageAlignmentToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.imageAlignmentToolStripMenuItem.Text = "Image Alignment"
        Me.northToolStripMenuItem.Name = "northToolStripMenuItem"
        Me.northToolStripMenuItem.Size = New System.Drawing.Size(105, 22)
        Me.northToolStripMenuItem.Text = "North"
        'AddHandler Me.northToolStripMenuItem.Click, New System.EventHandler(Me.northToolStripMenuItem_Click)
        AddHandler Me.northToolStripMenuItem.Click, AddressOf northToolStripMenuItem_Click
        Me.eastToolStripMenuItem.Name = "eastToolStripMenuItem"
        Me.eastToolStripMenuItem.Size = New System.Drawing.Size(105, 22)
        Me.eastToolStripMenuItem.Text = "East"
        'AddHandler Me.eastToolStripMenuItem.Click, New System.EventHandler(Me.eastToolStripMenuItem_Click)
        AddHandler Me.eastToolStripMenuItem.Click, AddressOf eastToolStripMenuItem_Click
        Me.southToolStripMenuItem.Name = "southToolStripMenuItem"
        Me.southToolStripMenuItem.Size = New System.Drawing.Size(105, 22)
        Me.southToolStripMenuItem.Text = "South"
        'AddHandler Me.southToolStripMenuItem.Click, New System.EventHandler(Me.southToolStripMenuItem_Click)
        AddHandler Me.southToolStripMenuItem.Click, AddressOf southToolStripMenuItem_Click
        Me.westToolStripMenuItem.Name = "westToolStripMenuItem"
        Me.westToolStripMenuItem.Size = New System.Drawing.Size(105, 22)
        Me.westToolStripMenuItem.Text = "West"
        'AddHandler Me.westToolStripMenuItem.Click, New System.EventHandler(Me.westToolStripMenuItem_Click)
        AddHandler Me.westToolStripMenuItem.Click, AddressOf westToolStripMenuItem_Click
        Me.toolStripMenuItem5.Name = "toolStripMenuItem5"
        Me.toolStripMenuItem5.Size = New System.Drawing.Size(163, 6)
        Me.editItemToolStripMenuItem.Name = "editItemToolStripMenuItem"
        Me.editItemToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.editItemToolStripMenuItem.Text = "Edit item's text"
        'AddHandler Me.editItemToolStripMenuItem.Click, New System.EventHandler(Me.editItemToolStripMenuItem_Click)
        AddHandler Me.editItemToolStripMenuItem.Click, AddressOf editItemToolStripMenuItem_Click
        Me.splitter1.Location = New System.Drawing.Point(208, 0)
        Me.splitter1.Name = "splitter1"
        Me.splitter1.Size = New System.Drawing.Size(5, 342)
        Me.splitter1.TabIndex = 4
        Me.splitter1.TabStop = False
        Me.calendar1.ContextMenuStrip = Me.contextMenuStrip1
        Me.calendar1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.calendar1.Font = New System.Drawing.Font("Segoe UI", 9.0F)
        calendarHighlightRange1.DayOfWeek = System.DayOfWeek.Monday
        calendarHighlightRange1.EndTime = System.TimeSpan.Parse("17:00:00")
        calendarHighlightRange1.StartTime = System.TimeSpan.Parse("08:00:00")
        calendarHighlightRange2.DayOfWeek = System.DayOfWeek.Tuesday
        calendarHighlightRange2.EndTime = System.TimeSpan.Parse("17:00:00")
        calendarHighlightRange2.StartTime = System.TimeSpan.Parse("08:00:00")
        calendarHighlightRange3.DayOfWeek = System.DayOfWeek.Wednesday
        calendarHighlightRange3.EndTime = System.TimeSpan.Parse("17:00:00")
        calendarHighlightRange3.StartTime = System.TimeSpan.Parse("08:00:00")
        calendarHighlightRange4.DayOfWeek = System.DayOfWeek.Thursday
        calendarHighlightRange4.EndTime = System.TimeSpan.Parse("17:00:00")
        calendarHighlightRange4.StartTime = System.TimeSpan.Parse("08:00:00")
        calendarHighlightRange5.DayOfWeek = System.DayOfWeek.Friday
        calendarHighlightRange5.EndTime = System.TimeSpan.Parse("17:00:00")
        calendarHighlightRange5.StartTime = System.TimeSpan.Parse("08:00:00")
        Me.calendar1.HighlightRanges = New System.Windows.Forms.Calendar.CalendarHighlightRange() {calendarHighlightRange1, calendarHighlightRange2, calendarHighlightRange3, calendarHighlightRange4, calendarHighlightRange5}
        Me.calendar1.Location = New System.Drawing.Point(213, 0)
        Me.calendar1.Name = "calendar1"
        Me.calendar1.Size = New System.Drawing.Size(458, 342)
        Me.calendar1.TabIndex = 2
        Me.calendar1.Text = "calendar1"
        'Me.calendar1.LoadItems += New System.Windows.Forms.Calendar.Calendar.CalendarLoadEventHandler(Me.calendar1_LoadItems)
        'Me.calendar1.DayHeaderClick += New System.Windows.Forms.Calendar.Calendar.CalendarDayEventHandler(Me.calendar1_DayHeaderClick)
        'Me.calendar1.ItemCreated += New System.Windows.Forms.Calendar.Calendar.CalendarItemCancelEventHandler(Me.calendar1_ItemCreated)
        'Me.calendar1.ItemDeleted += New System.Windows.Forms.Calendar.Calendar.CalendarItemEventHandler(Me.calendar1_ItemDeleted)
        'Me.calendar1.ItemClick += New System.Windows.Forms.Calendar.Calendar.CalendarItemEventHandler(Me.calendar1_ItemClick)
        'Me.calendar1.ItemDoubleClick += New System.Windows.Forms.Calendar.Calendar.CalendarItemEventHandler(Me.calendar1_ItemDoubleClick)
        'Me.calendar1.ItemMouseHover += New System.Windows.Forms.Calendar.Calendar.CalendarItemEventHandler(Me.calendar1_ItemMouseHover)
        'AddHandler calendar1.LoadItems, New System.Windows.Forms.Calendar.Calendar.CalendarLoadEventHandler(AddressOf calendar1_LoadItems)
        'AddHandler calendar1.DayHeaderClick, New System.Windows.Forms.Calendar.Calendar.CalendarDayEventHandler(AddressOf calendar1_DayHeaderClick)
        'AddHandler calendar1.ItemCreated, New System.Windows.Forms.Calendar.Calendar.CalendarItemCancelEventHandler(AddressOf calendar1_ItemCreated)
        'AddHandler calendar1.ItemDeleted, New System.Windows.Forms.Calendar.Calendar.CalendarItemEventHandler(AddressOf calendar1_ItemDeleted)
        'AddHandler calendar1.ItemClick, New System.Windows.Forms.Calendar.Calendar.CalendarItemEventHandler(AddressOf calendar1_ItemClick)
        'AddHandler calendar1.ItemDoubleClick, New System.Windows.Forms.Calendar.Calendar.CalendarItemEventHandler(AddressOf calendar1_ItemDoubleClick)
        'AddHandler calendar1.ItemMouseHover, New System.Windows.Forms.Calendar.Calendar.CalendarItemEventHandler(AddressOf calendar1_ItemMouseHover)

        Me.monthView1.ArrowsColor = System.Drawing.SystemColors.Window
        Me.monthView1.ArrowsSelectedColor = System.Drawing.Color.Gold
        Me.monthView1.DayBackgroundColor = System.Drawing.Color.Empty
        Me.monthView1.DayGrayedText = System.Drawing.SystemColors.GrayText
        Me.monthView1.DaySelectedBackgroundColor = System.Drawing.SystemColors.Highlight
        Me.monthView1.DaySelectedColor = System.Drawing.SystemColors.WindowText
        Me.monthView1.DaySelectedTextColor = System.Drawing.SystemColors.HighlightText
        Me.monthView1.Dock = System.Windows.Forms.DockStyle.Left
        Me.monthView1.ItemPadding = New System.Windows.Forms.Padding(2)
        Me.monthView1.Location = New System.Drawing.Point(0, 0)
        Me.monthView1.MaxSelectionCount = 35
        Me.monthView1.MonthTitleColor = System.Drawing.SystemColors.ActiveCaption
        Me.monthView1.MonthTitleColorInactive = System.Drawing.SystemColors.InactiveCaption
        Me.monthView1.MonthTitleTextColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.monthView1.MonthTitleTextColorInactive = System.Drawing.SystemColors.InactiveCaptionText
        Me.monthView1.Name = "monthView1"
        Me.monthView1.Size = New System.Drawing.Size(208, 342)
        Me.monthView1.TabIndex = 3
        Me.monthView1.Text = "monthView1"
        Me.monthView1.TodayBorderColor = System.Drawing.Color.Maroon
        'AddHandler Me.monthView1.SelectionChanged, New System.EventHandler(Me.monthView1_SelectionChanged)
        AddHandler Me.monthView1.SelectionChanged, AddressOf monthView1_SelectionChanged
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(671, 342)
        Me.Controls.Add(Me.calendar1)
        Me.Controls.Add(Me.splitter1)
        Me.Controls.Add(Me.monthView1)
        Me.Name = "Horaire"
        Me.Text = "Horaire"
        'AddHandler Me.Load, New System.EventHandler(Me.ITimeSheet_Load)
        AddHandler Me.Load, AddressOf ITimeSheet_Load
        Me.contextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)


    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel

    Private calendar1 As System.Windows.Forms.Calendar.Calendar
    Private contextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Private redTagToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private yellowTagToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private greenTagToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private blueTagToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private toolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Private timescaleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private hourToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private minutesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private toolStripMenuItem4 As System.Windows.Forms.ToolStripMenuItem
    Private toolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Private editItemToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private minutesToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Private minutesToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Private minutesToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Private otherColorTagToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private patternToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private diagonalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private verticalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private horizontalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private hatchToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private toolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator
    Private noneToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private monthView1 As System.Windows.Forms.Calendar.MonthView
    Private splitter1 As System.Windows.Forms.Splitter
    Private toolStripMenuItem5 As System.Windows.Forms.ToolStripSeparator
    Private selectImageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private imageAlignmentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private northToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private eastToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private southToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private westToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
