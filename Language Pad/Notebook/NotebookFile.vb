﻿Imports System.IO
Imports TundraLib.ZiaFile
Imports System.IO.Compression

<Serializable()>
Public Class NotebookPage
    Public Title As String
    Public RTF As String
End Class

<Serializable()>
Public Class NotebookFile
    Public Modified As Boolean = False
    Public EmbedSymbols As Boolean = False
    Public DocumentPath As String
    Public ProgramVersion As String = ProgramVersion
    Public NTSpecificationVersion As Decimal = NTVersion

    Public Title As String
    Public Language As String
    Public Author As String
    Public Website As String
    Public CustomSymbols As String
    Public Info As String

    Public Pages As New List(Of NotebookPage)
    Public WordDictionary As New DictionaryFile

    Public Sub Save(ByVal FilePath As String)
        If File.Exists(FilePath) Then File.Delete(FilePath)
        NotebookFileAccess.Save(FilePath, Me)
        Modified = False
    End Sub

    Public Sub Open(ByVal FilePath As String, Optional ByVal Opening As Boolean = False)
        Dim NewNotebook As NotebookFile = NotebookFileAccess.Open(FilePath)
        Author = NewNotebook.Author
        ProgramVersion = NewNotebook.ProgramVersion
        NTSpecificationVersion = NewNotebook.NTSpecificationVersion
        Title = NewNotebook.Title
        Language = NewNotebook.Language
        Website = NewNotebook.Website
        Pages = NewNotebook.Pages
        DocumentPath = FilePath
        Info = NewNotebook.Info
        CustomSymbols = NewNotebook.CustomSymbols
        EmbedSymbols = NewNotebook.EmbedSymbols
        WordDictionary = NewNotebook.WordDictionary
    End Sub

    Public Sub New()
    End Sub
End Class

Module NotebookFileAccess
    Dim PagesFolder As String
    Sub Save(ByVal FilePath As String, ByVal Notebook As NotebookFile)
        frmMain.SaveTabs()

        If frmDictionary.Loaded = False Then
            frmDictionary.LoadDictionary()
        End If

        frmDictionary.SaveDictionary()

        Dim guid As Guid = Guid.NewGuid
        Dim tmp As String = Application.LocalUserAppDataPath & "\zip-" & guid.ToString
        If Directory.Exists(tmp) Then
            Directory.Delete(tmp, True)
        End If

        Directory.CreateDirectory(tmp)

        PagesFolder = tmp & "\pages\"
        Directory.CreateDirectory(PagesFolder)

        Dim DataFile As New List(Of ZiaLine) From {
            New ZiaLine(LineType.Comment, "Settings"),
            New ZiaLine(LineType.KeyValue, "Title", Notebook.Title),
            New ZiaLine(LineType.KeyValue, "Language", Notebook.Language),
            New ZiaLine(LineType.KeyValue, "Author", Notebook.Author),
            New ZiaLine(LineType.KeyValue, "Website", Notebook.Website),
            New ZiaLine(LineType.KeyValue, "NTVersion", NTVersion),
            New ZiaLine(LineType.KeyValue, "LangPadVersion", LangPadVersion),
            New ZiaLine(LineType.Blank),
            New ZiaLine(LineType.Comment, "Pages")
        }

        For i = 0 To Notebook.Pages.Count - 1
            Dim Page = Notebook.Pages.Item(i)
            DataFile.Add(New ZiaLine(LineType.KeyValue, "Page" & i, ToCompatibleString(Page.Title)))

            Dim txtWriter As StreamWriter
            txtWriter = New StreamWriter(PagesFolder & i & ".rtf")
            txtWriter.Write(Page.RTF)
            txtWriter.Close()
        Next

        If Notebook.EmbedSymbols = True Then
            Notebook.CustomSymbols = My.Settings.CustomSymbols
        Else
            Notebook.CustomSymbols = ""
        End If

        'Write to disk
        File.WriteAllText(tmp & "\data.txt", Write(DataFile))
        File.WriteAllText(tmp & "\info.txt", Notebook.Info)
        File.WriteAllText(tmp & "\custom_symbols.txt", Notebook.CustomSymbols)
        Notebook.WordDictionary.Save(tmp & "\dictionary.txt")
        Notebook.DocumentPath = FilePath

        ZipFile.CreateFromDirectory(tmp, FilePath, CompressionLevel.Optimal, False)
    End Sub

    Public Function Open(ByVal FilePath As String) As NotebookFile
        Dim NewNotebook As New NotebookFile
        Dim guid As Guid = Guid.NewGuid
        Dim tmp As String = Application.LocalUserAppDataPath & "\zip-" & guid.ToString

        If (Directory.Exists(tmp)) Then
            Directory.Delete(tmp, True)
        End If

        Directory.CreateDirectory(tmp)

        ZipFile.ExtractToDirectory(FilePath, tmp)
        PagesFolder = tmp & "\pages\"

        Dim LineList = Read(File.ReadAllText(tmp & "\data.txt"))
        NewNotebook.NTSpecificationVersion = Search(LineList, "NTVersion")
        Dim CompatMode As Boolean = (NewNotebook.NTSpecificationVersion < 2)

        If CompatMode Then ' Use the legacy method of storing pages
            Dim PageOrder = Search(LineList, "Page Order").Split({"|"}, StringSplitOptions.RemoveEmptyEntries)
            For Each PageTitle As String In PageOrder
                Dim Page As New NotebookPage With {
                    .Title = PageTitle,
                    .RTF = File.ReadAllText(PagesFolder & PageTitle & ".rtf")
                }
                NewNotebook.Pages.Add(Page)
            Next
        Else ' Use the new method of storing pages that allows for arbitrary names
            Dim PageCount As Integer = Directory.EnumerateFiles(PagesFolder).Count
            For i = 0 To PageCount - 1
                Dim Page As New NotebookPage
                Dim PageName As String = Search(LineList, "Page" & i)

                If PageName Is Nothing Then
                    PageName = i + 1
                End If

                Page.Title = PageName
                Page.RTF = File.ReadAllText(PagesFolder & i & ".rtf")
                NewNotebook.Pages.Add(Page)
            Next
        End If



        NewNotebook.Title = Search(LineList, "Title")
        NewNotebook.Language = Search(LineList, "Language")
        NewNotebook.Author = Search(LineList, "Author")
        NewNotebook.Website = Search(LineList, "Website")
        NewNotebook.ProgramVersion = Search(LineList, "LangPadVersion")
        NewNotebook.CustomSymbols = File.ReadAllText(tmp & "\custom_symbols.txt")
        NewNotebook.Info = File.ReadAllText(tmp & "\info.txt")
        NewNotebook.WordDictionary.Open(tmp & "\dictionary.txt")

        If Not (NewNotebook.CustomSymbols = "") Then NewNotebook.EmbedSymbols = True

        If NewNotebook.CustomSymbols = "" Then
        ElseIf NewNotebook.CustomSymbols = My.Settings.CustomSymbols Then
        ElseIf My.Settings.CustomSymbols.StartsWith(NewNotebook.CustomSymbols) Then
        Else
            dlgAppendReplace.ShowDialog()
            If dlgAppendReplace.Result = dlgAppendReplace.AppendReplaceDialogResult.Append Then
                My.Settings.CustomSymbols = My.Settings.CustomSymbols & NewNotebook.CustomSymbols
            ElseIf dlgAppendReplace.Result = dlgAppendReplace.AppendReplaceDialogResult.Replace Then
                My.Settings.CustomSymbols = NewNotebook.CustomSymbols
            Else
            End If

            frmMain.CustomLayoutPanel.Controls.Clear()
            frmDictionary.CustomLayoutPanel.Controls.Clear()

            Dim LineList2 As String() = My.Settings.CustomSymbols.Split({Environment.NewLine}, StringSplitOptions.RemoveEmptyEntries)
            For Each IPA As String In LineList2
                Dim SymbolButton As New SymbolButton With {
                    .Text = IPA
                }
                AddHandler SymbolButton.Click, AddressOf frmMain.InsertIPA
                frmMain.CustomLayoutPanel.Controls.Add(SymbolButton)

                Dim SymbolButtonDictionary As New SymbolButton With {
                    .Text = IPA
                }
                AddHandler SymbolButtonDictionary.Click, AddressOf frmDictionary.InsertIPA
                frmDictionary.CustomLayoutPanel.Controls.Add(SymbolButtonDictionary)
            Next
        End If

        Return NewNotebook
    End Function
End Module