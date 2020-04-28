﻿Imports System.Drawing.Drawing2D
Imports System.IO
Imports System.Text
Imports LangPadSupport
Imports LangPadSupport.Themes

Public Class DictionaryForm
    Dim CurrentTextbox As TextBox
    Public Loaded As Boolean = False
    Public Color1 As Color
    Public Color2 As Color
    Public VerticalMenuGradient As Boolean = False

    Private Sub DictionaryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetIcons()
        LoadDictionary()
        SetDisplayFont()
        Loaded = True
    End Sub

    Public Sub SetTheme(Theme As Theme)
        Color1 = Theme.PanelBack
        Color2 = Theme.PanelBack
        VerticalMenuGradient = Theme.VerticalMenuGradient
        BackColor = Theme.PanelBack
        DictionaryGrid.BackgroundColor = Theme.PanelBack

        MainToolStrip.Renderer = Theme.GetToolStripRenderer()

        ' Center buttons relative to text boxes
        ' Because Windows' scaling throws them off
        FindButton.Top = FindTextBox.Top - (FindButton.Height / 2 - FindTextBox.Height / 2)

        Refresh()
    End Sub

    Public Sub SetIcons()
        Dim Res As IconResolution = GetIconResolution()

        NewToolStripButton.Image = IconManager.Get("document-new", IconSize.Large, Res)
        OpenToolStripButton.Image = IconManager.Get("document-open", IconSize.Large, Res)
        SaveToolStripButton.Image = IconManager.Get("document-save", IconSize.Large, Res)
        ExportHtmlToolStripButton.Image = IconManager.Get("filetype-html", IconSize.Large, Res)
        CharacterEditorToolStripButton.Image = IconManager.Get("language", IconSize.Large, Res)
        AddToolStripButton.Image = IconManager.Get("list-add", IconSize.Large, Res)
        RemoveToolStripButton.Image = IconManager.Get("list-remove", IconSize.Large, Res)
        FontToolStripButton.Image = IconManager.Get("font", IconSize.Large, Res)
        ResetFontToolStripButton.Image = IconManager.Get("restart", IconSize.Large, Res)
        FindToolStripButton.Image = IconManager.Get("edit-find", IconSize.Large, Res)
    End Sub

    Private Sub MainToolStripContainer_ToolStripPanel_Paint(ByVal sender As Object, ByVal e As PaintEventArgs) Handles MainToolStripContainer.TopToolStripPanel.Paint,
        MainToolStripContainer.BottomToolStripPanel.Paint, MainToolStripContainer.LeftToolStripPanel.Paint, MainToolStripContainer.RightToolStripPanel.Paint
        Dim Rect As New Rectangle(0, 0, MainToolStripContainer.Width, Height)
        Dim FillBrush As New LinearGradientBrush(Rect, Color1, Color2, If(VerticalMenuGradient, LinearGradientMode.Vertical, LinearGradientMode.Horizontal))
        e.Graphics.FillRectangle(FillBrush, Rect)
    End Sub

    Private Sub MainToolStripContainer_ToolStripPanel_SizeChanged(ByVal sender As Object, ByVal e As EventArgs) Handles MainToolStripContainer.TopToolStripPanel.SizeChanged,
        MainToolStripContainer.BottomToolStripPanel.SizeChanged, MainToolStripContainer.LeftToolStripPanel.SizeChanged, MainToolStripContainer.RightToolStripPanel.SizeChanged
        MainToolStripContainer.Invalidate()
    End Sub

    Public Sub SetDisplayFont()
        DictionaryGrid.DefaultCellStyle.Font = My.Settings.DictionaryFont
        DictionaryGrid.DefaultCellStyle.ForeColor = My.Settings.DictionaryFontColor
    End Sub

    Public Sub LoadDictionary()
        DictionaryGrid.Rows.Clear()
        Dim Words = CurrentDocument.WordDictionary.Words
        For Each Word As DictionaryWord In CurrentDocument.WordDictionary.Words
            Dim Row As New DataGridViewRow
            Row.CreateCells(DictionaryGrid)
            Row.Cells.Item(0).Value = Word.Word
            Row.Cells.Item(1).Value = Word.Pronunciation
            Row.Cells.Item(2).Value = Word.Definition
            Row.Cells.Item(3).Value = Word.Notes

            DictionaryGrid.Rows.Add(Row)
        Next

        DictionaryGrid.Refresh()
    End Sub

    Public Sub SaveDictionary()
        CurrentDocument.WordDictionary.Words.Clear()
        For i = 0 To DictionaryGrid.RowCount - 1
            Dim NewWord As New DictionaryWord With {
                .Word = DictionaryGrid.Rows.Item(i).Cells.Item(0).Value,
                .Pronunciation = DictionaryGrid.Rows.Item(i).Cells.Item(1).Value,
                .Definition = DictionaryGrid.Rows.Item(i).Cells.Item(2).Value,
                .Notes = DictionaryGrid.Rows.Item(i).Cells.Item(3).Value
            }

            If NewWord.Word = Nothing Then NewWord.Word = ""
            If NewWord.Pronunciation = Nothing Then NewWord.Pronunciation = ""
            If NewWord.Definition = Nothing Then NewWord.Definition = ""
            If NewWord.Notes = Nothing Then NewWord.Notes = ""

            CurrentDocument.WordDictionary.Words.Add(NewWord)
        Next
    End Sub

    Private Sub DictionaryGrid_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles DictionaryGrid.EditingControlShowing
        CurrentTextbox = e.Control
    End Sub

    Private Sub DictionaryGrid_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles DictionaryGrid.RowPostPaint
        Dim Grid As DataGridView = CType(sender, DataGridView)
        Dim RowIndex As String = (e.RowIndex + 1).ToString()
        Dim RowFont As Font = Font

        Dim CenterFormat = New StringFormat With {
            .Alignment = StringAlignment.Center,
            .LineAlignment = StringAlignment.Center
        }

        Dim headerBounds As Rectangle = New Rectangle(e.RowBounds.Left, e.RowBounds.Top, Grid.RowHeadersWidth, e.RowBounds.Height)
        e.Graphics.DrawString(RowIndex, RowFont, SystemBrushes.ControlText, headerBounds, CenterFormat)
    End Sub

    Private Sub NewToolStripButton_Click(sender As Object, e As EventArgs) Handles NewToolStripButton.Click
        If MessageBox.Show("This cannot be undone. Are you sure you want to continue? ", "Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) = DialogResult.Yes Then
            DictionaryGrid.Rows.Clear()
        End If
    End Sub

    Private Sub OpenToolStripButton_Click(sender As Object, e As EventArgs) Handles OpenToolStripButton.Click
        If OpenDialog.ShowDialog = DialogResult.OK Then
            If Path.GetExtension(OpenDialog.FileName).ToLower() = ".csv" Then
                CurrentDocument.WordDictionary.OpenCSV(OpenDialog.FileName)
            Else
                CurrentDocument.WordDictionary.Open(OpenDialog.FileName)
            End If

            LoadDictionary()
        End If
    End Sub

    Private Sub SaveToolStripButton_Click(sender As Object, e As EventArgs) Handles SaveToolStripButton.Click
        SaveDictionary()
        If SaveDialog.ShowDialog = DialogResult.OK Then
            If Path.GetExtension(SaveDialog.FileName).ToLower() = ".csv" Then
                Dim Writer As New StreamWriter(New FileStream(SaveDialog.FileName, FileMode.Create, FileAccess.ReadWrite), Encoding.UTF8)
                Dim ColCount As Integer = DictionaryGrid.Columns.Count

                For i As Integer = 0 To ColCount - 1
                    Writer.Write(DictionaryGrid.Columns(i).Name.ToString().ToUpper() + ",")
                Next
                Writer.WriteLine()

                ' Write rows to CSV
                For i As Integer = 0 To DictionaryGrid.Rows.Count - 1
                    For j As Integer = 0 To ColCount - 1
                        If DictionaryGrid.Rows(i).Cells(j).Value IsNot Nothing Then
                            Writer.Write(DictionaryGrid.Rows(i).Cells(j).Value + ",")
                        Else
                            Writer.Write(",")
                        End If
                    Next

                    Writer.WriteLine()
                Next
                Writer.Close()
            Else
                CurrentDocument.WordDictionary.Save(SaveDialog.FileName)
            End If
        End If
    End Sub

    Private Sub AddToolStripButton_Click(sender As Object, e As EventArgs) Handles AddToolStripButton.Click
        DictionaryGrid.Rows.Add(1)
        CurrentDocument.Modified = True
    End Sub

    Private Sub RemoveToolStripButton_Click(sender As Object, e As EventArgs) Handles RemoveToolStripButton.Click
        If DictionaryGrid.CurrentCell IsNot Nothing Then
            DictionaryGrid.Rows.RemoveAt(DictionaryGrid.CurrentCell.RowIndex)
            CurrentDocument.Modified = True
        End If
    End Sub

    Private Sub FontToolStripButton_Click(sender As Object, e As EventArgs) Handles FontToolStripButton.Click
        FontPicker.Color = DictionaryGrid.DefaultCellStyle.ForeColor
        FontPicker.Font = DictionaryGrid.DefaultCellStyle.Font

        If FontPicker.ShowDialog = DialogResult.OK Then
            My.Settings.DictionaryFont = FontPicker.Font
            My.Settings.DictionaryFontColor = FontPicker.Color
            My.Settings.Save()
            SetDisplayFont()
        End If
    End Sub

    Private Sub DictionaryForm_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        LoadDictionary()
    End Sub

    Private Sub DictionaryGrid_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DictionaryGrid.CellEndEdit
        SaveDictionary()
        CurrentDocument.Modified = True
    End Sub

    Private Sub ExportHtmlToolStripButton_Click(sender As Object, e As EventArgs) Handles ExportHtmlToolStripButton.Click
        SaveDictionary()
        If SaveHtmlDialog.ShowDialog = DialogResult.OK Then
            ExportHtmlDialog.FilePath = SaveHtmlDialog.FileName
            ExportHtmlDialog.ShowDialog()
        End If
    End Sub

    Private Sub FindToolStripButton_Click(sender As Object, e As EventArgs) Handles FindToolStripButton.Click
        FindReplaceDialog.Visible = FindReplaceDialog.Visible Xor True
        If FindReplaceDialog.Visible = True Then FindTextBox.Focus()
    End Sub

    Private Sub FindButton_Click(sender As Object, e As EventArgs) Handles FindButton.Click
        SaveDictionary()
        DictionaryGrid.ClearSelection()

        Dim Matches As Boolean
        Dim CurrentPos As Integer = 0
        Dim NormalizedFindText As String = FindTextBox.Text.ToLower()

        If WordRadio.Checked Then
            For Each Word As DictionaryWord In CurrentDocument.WordDictionary.Words
                Matches = If(StartsWithCheck.Checked, Word.Word.ToLower().StartsWith(NormalizedFindText), Word.Word.ToLower().Equals(NormalizedFindText))
                If Matches Then Exit For
                CurrentPos += 1
            Next
        Else
            For Each Word As DictionaryWord In CurrentDocument.WordDictionary.Words
                Matches = If(StartsWithCheck.Checked, Word.Definition.ToLower().StartsWith(NormalizedFindText), Word.Definition.ToLower().Equals(NormalizedFindText))
                If Matches Then Exit For
                CurrentPos += 1
            Next
        End If

        If Matches Then
            DictionaryGrid.Rows(CurrentPos).Selected = True
            DictionaryGrid.FirstDisplayedScrollingRowIndex = DictionaryGrid.SelectedRows(0).Index
        Else
            MessageBox.Show("""" + FindTextBox.Text + """ was not found " + "")
        End If
    End Sub

    Private Sub CharacterEditorToolStripButton_Click(sender As Object, e As EventArgs) Handles CharacterEditorToolStripButton.Click
        CharEditWindow.Show()
    End Sub

    Private Sub DictionaryForm_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        CharEditWindow.TargetForm = Me
        CharEditWindow.GetCurrentTexbox = Function()
                                          If DictionaryGrid.CurrentCell IsNot Nothing Then
                                              DictionaryGrid.Focus()
                                              DictionaryGrid.BeginEdit(False)
                                          End If

                                          Return CurrentTextbox
                                      End Function
    End Sub

    Private Sub ResetFontToolStripButton_Click(sender As Object, e As EventArgs) Handles ResetFontToolStripButton.Click
        My.Settings.DictionaryFont = New Font("Calibri", 9, FontStyle.Regular)
        My.Settings.DictionaryFontColor = Color.Black
        My.Settings.Save()
        SetDisplayFont()
    End Sub

    Private Sub DictionaryForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        e.Cancel = True
        If MainForm IsNot Nothing Then
            CharEditWindow.TargetForm = MainForm
            MainForm.Activate()
        End If
        SaveDictionary()
        Hide()
    End Sub
End Class