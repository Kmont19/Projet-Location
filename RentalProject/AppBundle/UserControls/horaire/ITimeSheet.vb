Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports System.Windows.Forms.Calendar
Imports System.Xml.Serialization
Imports System.IO

Public Class ITimeSheet
    'Inherits Form

    Private _items As List(Of CalendarItem) = New List(Of CalendarItem)()
    Private contextItem As CalendarItem = Nothing

    Public Sub New()
        InitializeComponent()
        monthView1.MonthTitleColor = CSharpImpl.__Assign(monthView1.MonthTitleColorInactive, CalendarColorTable.FromHex("#C2DAFC"))
        monthView1.ArrowsColor = CalendarColorTable.FromHex("#77A1D3")
        monthView1.DaySelectedBackgroundColor = CalendarColorTable.FromHex("#F4CC52")
        monthView1.DaySelectedTextColor = monthView1.ForeColor
    End Sub

    Public ReadOnly Property ItemsFile As FileInfo
        Get
            Return New FileInfo(Path.Combine(Application.StartupPath, "items.xml"))
        End Get
    End Property

    Private Sub ITimeSheet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If ItemsFile.Exists Then
            Dim lst As List(Of ItemInfo) = New List(Of ItemInfo)()
            Dim xml As XmlSerializer = New XmlSerializer(lst.[GetType]())

            Using s As Stream = ItemsFile.OpenRead()
                lst = TryCast(xml.Deserialize(s), List(Of ItemInfo))
            End Using

            For Each item As ItemInfo In lst
                Dim cal As CalendarItem = New CalendarItem(calendar1, item.StartTime, item.EndTime, item.Text)

                If Not (item.R = 0 AndAlso item.G = 0 AndAlso item.B = 0) Then
                    cal.ApplyColor(Color.FromArgb(item.A, item.R, item.G, item.B))
                End If

                _items.Add(cal)
            Next

            PlaceItems()
        End If
    End Sub

    Private Sub calendar1_LoadItems(ByVal sender As Object, ByVal e As CalendarLoadEventArgs)
        PlaceItems()
    End Sub

    Private Sub PlaceItems()
        For Each item As CalendarItem In _items

            If calendar1.ViewIntersects(item) Then
                calendar1.Items.Add(item)
            End If
        Next
    End Sub

    Private Sub calendar1_ItemCreated(ByVal sender As Object, ByVal e As CalendarItemCancelEventArgs)
        _items.Add(e.Item)
    End Sub

    Private Sub calendar1_ItemMouseHover(ByVal sender As Object, ByVal e As CalendarItemEventArgs)
        Text = e.Item.Text
    End Sub

    Private Sub calendar1_ItemClick(ByVal sender As Object, ByVal e As CalendarItemEventArgs)
    End Sub

    Private Sub hourToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        calendar1.TimeScale = CalendarTimeScale.SixtyMinutes
    End Sub

    Private Sub minutesToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        calendar1.TimeScale = CalendarTimeScale.ThirtyMinutes
    End Sub

    Private Sub toolStripMenuItem4_Click(ByVal sender As Object, ByVal e As EventArgs)
        calendar1.TimeScale = CalendarTimeScale.FifteenMinutes
    End Sub

    Private Sub minutesToolStripMenuItem2_Click(ByVal sender As Object, ByVal e As EventArgs)
        calendar1.TimeScale = CalendarTimeScale.SixMinutes
    End Sub

    Private Sub minutesToolStripMenuItem1_Click(ByVal sender As Object, ByVal e As EventArgs)
        calendar1.TimeScale = CalendarTimeScale.TenMinutes
    End Sub

    Private Sub minutesToolStripMenuItem3_Click(ByVal sender As Object, ByVal e As EventArgs)
        calendar1.TimeScale = CalendarTimeScale.FiveMinutes
    End Sub

    Private Sub contextMenuStrip1_Opening(ByVal sender As Object, ByVal e As CancelEventArgs)
        contextItem = calendar1.ItemAt(contextMenuStrip1.Bounds.Location)
    End Sub

    Private Sub redTagToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        For Each item As CalendarItem In calendar1.GetSelectedItems()
            item.ApplyColor(Color.Red)
            calendar1.Invalidate(item)
        Next
    End Sub

    Private Sub yellowTagToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        For Each item As CalendarItem In calendar1.GetSelectedItems()
            item.ApplyColor(Color.Gold)
            calendar1.Invalidate(item)
        Next
    End Sub

    Private Sub greenTagToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        For Each item As CalendarItem In calendar1.GetSelectedItems()
            item.ApplyColor(Color.Green)
            calendar1.Invalidate(item)
        Next
    End Sub

    Private Sub blueTagToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        For Each item As CalendarItem In calendar1.GetSelectedItems()
            item.ApplyColor(Color.DarkBlue)
            calendar1.Invalidate(item)
        Next
    End Sub

    Private Sub editItemToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        calendar1.ActivateEditMode()
    End Sub

    Private Sub DemoForm_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs)
        Dim lst As List(Of ItemInfo) = New List(Of ItemInfo)()

        For Each item As CalendarItem In _items
            lst.Add(New ItemInfo(item.StartDate, item.EndDate, item.Text, item.BackgroundColor))
        Next

        Dim xmls As XmlSerializer = New XmlSerializer(lst.[GetType]())

        If ItemsFile.Exists Then
            ItemsFile.Delete()
        End If

        Using s As Stream = ItemsFile.OpenWrite()
            xmls.Serialize(s, lst)
            s.Close()
        End Using
    End Sub

    Private Sub otherColorTagToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Using dlg As ColorDialog = New ColorDialog()

            If dlg.ShowDialog() = DialogResult.OK Then

                For Each item As CalendarItem In calendar1.GetSelectedItems()
                    item.ApplyColor(dlg.Color)
                    calendar1.Invalidate(item)
                Next
            End If
        End Using
    End Sub

    Private Sub calendar1_ItemDoubleClick(ByVal sender As Object, ByVal e As CalendarItemEventArgs)
        MessageBox.Show("Double click: " & e.Item.Text)
    End Sub

    Private Sub calendar1_ItemDeleted(ByVal sender As Object, ByVal e As CalendarItemEventArgs)
        _items.Remove(e.Item)
    End Sub

    Private Sub calendar1_DayHeaderClick(ByVal sender As Object, ByVal e As CalendarDayEventArgs)
        calendar1.SetViewRange(e.CalendarDay.Date, e.CalendarDay.Date)
    End Sub

    Private Sub diagonalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        For Each item As CalendarItem In calendar1.GetSelectedItems()
            item.Pattern = System.Drawing.Drawing2D.HatchStyle.ForwardDiagonal
            item.PatternColor = Color.Red
            calendar1.Invalidate(item)
        Next
    End Sub

    Private Sub verticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        For Each item As CalendarItem In calendar1.GetSelectedItems()
            item.Pattern = System.Drawing.Drawing2D.HatchStyle.Vertical
            item.PatternColor = Color.Red
            calendar1.Invalidate(item)
        Next
    End Sub

    Private Sub horizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        For Each item As CalendarItem In calendar1.GetSelectedItems()
            item.Pattern = System.Drawing.Drawing2D.HatchStyle.Horizontal
            item.PatternColor = Color.Red
            calendar1.Invalidate(item)
        Next
    End Sub

    Private Sub hatchToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        For Each item As CalendarItem In calendar1.GetSelectedItems()
            item.Pattern = System.Drawing.Drawing2D.HatchStyle.DiagonalCross
            item.PatternColor = Color.Red
            calendar1.Invalidate(item)
        Next
    End Sub

    Private Sub noneToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        For Each item As CalendarItem In calendar1.GetSelectedItems()
            item.Pattern = System.Drawing.Drawing2D.HatchStyle.DiagonalCross
            item.PatternColor = Color.Empty
            calendar1.Invalidate(item)
        Next
    End Sub

    Private Sub monthView1_SelectionChanged(ByVal sender As Object, ByVal e As EventArgs)
        calendar1.SetViewRange(monthView1.SelectionStart, monthView1.SelectionEnd)
    End Sub

    Private Sub northToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        For Each item As CalendarItem In calendar1.GetSelectedItems()
            item.ImageAlign = CalendarItemImageAlign.North
            calendar1.Invalidate(item)
        Next
    End Sub

    Private Sub eastToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        For Each item As CalendarItem In calendar1.GetSelectedItems()
            item.ImageAlign = CalendarItemImageAlign.East
            calendar1.Invalidate(item)
        Next
    End Sub

    Private Sub southToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        For Each item As CalendarItem In calendar1.GetSelectedItems()
            item.ImageAlign = CalendarItemImageAlign.South
            calendar1.Invalidate(item)
        Next
    End Sub

    Private Sub westToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        For Each item As CalendarItem In calendar1.GetSelectedItems()
            item.ImageAlign = CalendarItemImageAlign.West
            calendar1.Invalidate(item)
        Next
    End Sub

    Private Sub selectImageToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Using dlg As OpenFileDialog = New OpenFileDialog()
            dlg.Filter = "*.gif|*.gif|*.png|*.png|*.jpg|*.jpg"

            If dlg.ShowDialog(Me) = DialogResult.OK Then
                Dim img As Image = Image.FromFile(dlg.FileName)

                For Each item As CalendarItem In calendar1.GetSelectedItems()
                    item.Image = img
                    calendar1.Invalidate(item)
                Next
            End If
        End Using
    End Sub

    Private Class CSharpImpl
        <Obsolete("Please refactor calling code to use normal Visual Basic assignment")>
        Shared Function __Assign(Of T)(ByRef target As T, value As T) As T
            target = value
            Return value
        End Function
    End Class
End Class
