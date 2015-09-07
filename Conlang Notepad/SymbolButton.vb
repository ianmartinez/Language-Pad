﻿Public Class IPAToolTip
    Inherits ToolTip
    Sub New()
        MyBase.New()
        Me.OwnerDraw = True
        AddHandler Me.Draw, AddressOf OnDraw
    End Sub
    Public Sub New(ByVal Cont As System.ComponentModel.IContainer)
        MyBase.New(Cont)
        Me.OwnerDraw = True
        Me.ReshowDelay = 10
        Me.InitialDelay = 10
        Me.AutomaticDelay = 2
        AddHandler Me.Draw, AddressOf OnDraw
    End Sub

    Private Sub IPAToolTip_Popup(sender As Object, e As PopupEventArgs) Handles Me.Popup
        Dim TextSize As Size = TextRenderer.MeasureText(Me.GetToolTip(e.AssociatedControl), New Font("Calibri", 32, FontStyle.Bold))

        e.ToolTipSize = New Size(TextSize.Width + 6, TextSize.Height + 6)
    End Sub

    Private Sub OnDraw(ByVal sender As Object, ByVal e As DrawToolTipEventArgs)
        Dim newArgs As DrawToolTipEventArgs = New DrawToolTipEventArgs(
           e.Graphics,
           e.AssociatedWindow,
           e.AssociatedControl,
           e.Bounds,
           e.ToolTipText,
           Me.BackColor,
           Me.ForeColor,
           New Font("Calibri", 32, FontStyle.Bold))
        newArgs.DrawBackground()
        newArgs.DrawBorder()

        Dim newArgs2 As DrawToolTipEventArgs = New DrawToolTipEventArgs(
           e.Graphics,
           e.AssociatedWindow,
           e.AssociatedControl,
            New Rectangle(e.Bounds.Left + 3, e.Bounds.Top + 3, e.Bounds.Right - 6, e.Bounds.Bottom - 6),
           e.ToolTipText,
           Me.BackColor,
           Me.ForeColor,
           New Font("Calibri", 32, FontStyle.Bold))

        newArgs2.DrawText()
    End Sub

    Private Sub InitializeComponent()

    End Sub
End Class
Public Class SymbolButton
    Inherits Button
    Private ttIPa As New IPAToolTip
    Private components As System.ComponentModel.IContainer

    Public Sub New()

        Dim IPAFont = New Font("Calibri", 11, FontStyle.Bold)
        Dim IPAPadding = New Padding(0)
        Dim IPAMargin = New Padding(1)
        Dim IPAMin = New Size(45, 32)

        'Me.Style = My.Resources.KeyStyle
        Me.Padding = IPAPadding
        Me.Font = IPAFont
        Me.AutoSize = True
        Me.MinimumSize = IPAMin
        Me.Margin = IPAMargin
        Me.AutoSizeMode = Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.UseCompatibleTextRendering = True

    End Sub
    Private Sub InitializeComponent()
        Me.SuspendLayout()
        Me.ResumeLayout(False)

    End Sub

    Private Sub SymbolButton_TextChanged(sender As Object, e As EventArgs) Handles Me.TextChanged
        ttIPa.SetToolTip(Me, Me.Text)
    End Sub

    Private Sub SymbolButton_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

    End Sub

    Private Sub SymbolButton_Click(sender As Object, e As EventArgs) Handles Me.Click
        If My.Computer.Keyboard.CtrlKeyDown Then
            Dim LineList1 As String() = My.Settings.CustomSymbols.Split({Environment.NewLine}, StringSplitOptions.RemoveEmptyEntries)
            If LineList1.Contains(Me.Text) Then Exit Sub

            My.Settings.CustomSymbols = My.Settings.CustomSymbols & Environment.NewLine & Me.Text

            frmMain.CustomLayoutPanel.Controls.Clear()
            frmDictionary.CustomLayoutPanel.Controls.Clear()

            Dim LineList2 As String() = My.Settings.CustomSymbols.Split({Environment.NewLine}, StringSplitOptions.RemoveEmptyEntries)
            For Each IPA As String In LineList2
                Dim SymbolButton As New SymbolButton
                SymbolButton.Text = IPA
                AddHandler SymbolButton.Click, AddressOf frmMain.InsertIPA
                frmMain.CustomLayoutPanel.Controls.Add(SymbolButton)

                Dim SymbolButtonDictionary As New SymbolButton
                SymbolButtonDictionary.Text = IPA
                AddHandler SymbolButtonDictionary.Click, AddressOf frmDictionary.InsertIPA
                frmDictionary.CustomLayoutPanel.Controls.Add(SymbolButtonDictionary)
            Next
        End If

    End Sub
End Class
