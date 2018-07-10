﻿Imports System.Windows.Forms
Imports Tundra

Public Class dlgAccentMark
    Public Property Character As String
    Private AccentsList As List(Of String) = New List(Of String)
    Private AccentsString As String = ""

    Private Sub UpdateResult()
        If cbSmartReplace.Checked Then
            If txtCharacter.Text = "" Then
                lblResult.Text = ""
                Exit Sub
            End If

            Dim result As String = txtCharacter.Text & AccentsString '
            pnlSmartReplace.Visible = False

            For Each pair As KeyValuePair(Of String, String) In SmartReplaceList
                result = result.Replace(pair.Key, pair.Value)

                If result.Contains(pair.Value) Then
                    pnlSmartReplace.Visible = True
                End If
            Next

            lblResult.Text = result
        Else
            lblResult.Text = txtCharacter.Text & AccentsString
            If txtCharacter.Text = "" Then lblResult.Text = ""
        End If
    End Sub

    Private Sub ToggleAccent(sender As Object, e As EventArgs)
        Dim button As AccentCheckButton = CType(sender, AccentCheckButton)

        If (button.Checked) Then
            AccentsList.Add(button.Text.Replace("◌", ""))
        Else
            AccentsList.Remove(button.Text.Replace("◌", ""))
        End If

        AccentsString = ""
        For Each accent As String In AccentsList
            AccentsString += accent
        Next

        UpdateResult()
    End Sub

    Private Sub dlgAccentMark_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbSmartReplace.Visible = My.Settings.SmartReplace

        AccentsLayoutPanel.Controls.Clear()
        AccentsList.Clear()
        AccentsString = ""
        UpdateResult()

        For Each IPA As KeyValuePair(Of String, String) In ZiaFile.Read(My.Resources.Accents)
            Dim SymbolButton As New AccentCheckButton
            SymbolButton.Text = "◌" + IPA.Value
            SymbolButton.BackColor = Color.Transparent

            Dim IPAFont = New Font("Calibri", 22, FontStyle.Regular)
            Dim IPAPadding = New Padding(0)
            Dim IPAMargin = New Padding(1)
            Dim IPAMin = New Size(55, 42)

            SymbolButton.Padding = IPAPadding
            SymbolButton.Font = IPAFont
            SymbolButton.MinimumSize = IPAMin
            SymbolButton.Margin = IPAMargin

            AddHandler SymbolButton.Click, AddressOf ToggleAccent
            AccentsLayoutPanel.Controls.Add(SymbolButton)
        Next

        If Character = "" Then Character = "a"
        txtCharacter.Text = Character
    End Sub

    Private Sub txtCharacters_TextChanged(sender As Object, e As EventArgs) Handles txtCharacter.TextChanged
        UpdateResult()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim NewSymbols As String = My.Settings.CustomSymbols
        NewSymbols = NewSymbols & Environment.NewLine & lblResult.Text
        My.Settings.CustomSymbols = NewSymbols

        frmMain.CustomLayoutPanel.Controls.Clear()
        frmDictionary.CustomLayoutPanel.Controls.Clear()
        Dim LineList As String() = My.Settings.CustomSymbols.Split({Environment.NewLine}, StringSplitOptions.RemoveEmptyEntries)
        For Each IPA As String In LineList
            Dim IPAButton As New SymbolButton
            IPAButton.Text = IPA
            AddHandler IPAButton.Click, AddressOf frmMain.InsertIPA
            frmMain.CustomLayoutPanel.Controls.Add(IPAButton)

            Dim DictionaryIPAButton As New SymbolButton
            DictionaryIPAButton.Text = IPA
            AddHandler DictionaryIPAButton.Click, AddressOf frmDictionary.InsertIPA
            frmDictionary.CustomLayoutPanel.Controls.Add(DictionaryIPAButton)
        Next
    End Sub

    Private Sub btnCopy_Click(sender As Object, e As EventArgs) Handles btnCopy.Click
        Clipboard.SetText(lblResult.Text)
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Character = lblResult.Text
        DialogResult = DialogResult.OK
        Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        DialogResult = DialogResult.Cancel
        Close()
    End Sub

    Private Sub btnPreviewFont_Click(sender As Object, e As EventArgs) Handles btnPreviewFont.Click
        dlgFont.Font = lblResult.Font
        If dlgFont.ShowDialog() = DialogResult.OK Then
            lblResult.Font = dlgFont.Font
        End If
    End Sub

    Private Sub cbSmartReplace_CheckedChanged(sender As Object, e As EventArgs) Handles cbSmartReplace.CheckedChanged
        UpdateResult()
    End Sub
End Class
