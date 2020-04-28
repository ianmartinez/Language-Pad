﻿Imports System.Windows.Forms
Imports Tundra
Imports System.IO

Public Class dlgCustomSymbols

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        Dim CustomTXT As String = ""
        For i = 0 To dgvSymbols.RowCount - 1
            If dgvSymbols.Rows.Item(i).Cells(0).Value = "" Then Continue For
            CustomTXT = CustomTXT & String.Format("{0}{1}", dgvSymbols.Rows.Item(i).Cells(0).Value, Environment.NewLine)
        Next
        My.Settings.CustomSymbols = CustomTXT

        Dim IPAFont = New Font("Segoe UI", 11, FontStyle.Regular)
        Dim IPAPadding = New Padding(0)
        frmMain.CustomLayoutPanel.Controls.Clear()
        Dim LineList As String() = My.Settings.CustomSymbols.Split({Environment.NewLine}, StringSplitOptions.RemoveEmptyEntries)
        For Each IPA As String In LineList
            Dim IPAButton As New StylizedButton
            IPAButton.Style = My.Resources.KeyStyle
            IPAButton.Padding = IPAPadding
            IPAButton.Font = IPAFont
            IPAButton.AutoSize = True
            IPAButton.MinimumSize = New Size(40, 32)
            IPAButton.Margin = New Padding(1)
            IPAButton.AutoSizeMode = Windows.Forms.AutoSizeMode.GrowAndShrink
            IPAButton.Text = IPA
            AddHandler IPAButton.Click, AddressOf frmMain.InsertIPA
            frmMain.CustomLayoutPanel.Controls.Add(IPAButton)
        Next

        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub dlgCustomSymbols_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvSymbols.Rows.Clear()
        Dim Lines As String() = My.Settings.CustomSymbols.Split({Environment.NewLine}, StringSplitOptions.RemoveEmptyEntries)
        For i = 0 To Lines.Length - 1
            If Lines.GetValue(i) = "" Then Continue For
            dgvSymbols.Rows.Add()
            dgvSymbols.Rows.Item(i).Cells(0).Value = Lines.GetValue(i)
        Next
    End Sub

    Private Sub dgvSymbols_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSymbols.CellContentClick

    End Sub

    Private Sub btnDeleteAll_Click(sender As Object, e As EventArgs) Handles btnDeleteAll.Click
        dgvSymbols.Rows.Clear()
    End Sub

    Private Sub btnOpen_Click(sender As Object, e As EventArgs) Handles btnOpen.Click
        If dlgOpen.ShowDialog = Windows.Forms.DialogResult.OK Then
            My.Settings.CustomSymbols = File.ReadAllText(dlgOpen.FileName)

            dgvSymbols.Rows.Clear()
            Dim Lines As String() = My.Settings.CustomSymbols.Split({Environment.NewLine}, StringSplitOptions.RemoveEmptyEntries)
            For i = 0 To Lines.Length - 1
                If Lines.GetValue(i) = "" Then Continue For
                dgvSymbols.Rows.Add()
                dgvSymbols.Rows.Item(i).Cells(0).Value = Lines.GetValue(i)
            Next
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If dlgSave.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim CustomTXT As String = ""
            For i = 0 To dgvSymbols.RowCount - 1
                If dgvSymbols.Rows.Item(i).Cells(0).Value = "" Then Continue For
                CustomTXT = CustomTXT & String.Format("{0}{1}", dgvSymbols.Rows.Item(i).Cells(0).Value, Environment.NewLine)
            Next
            File.WriteAllText(dlgSave.FileName, CustomTXT)
        End If
    End Sub

    Private Sub dlgSave_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles dlgSave.FileOk

    End Sub

    Private Sub dlgOpen_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles dlgOpen.FileOk

    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel1.Paint

    End Sub
End Class