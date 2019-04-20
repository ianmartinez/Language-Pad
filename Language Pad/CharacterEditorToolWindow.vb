﻿Public Class CharacterEditorToolWindow
    Private _GetCurrentTexbox As Func(Of TextBoxBase)
    Public Property GetCurrentTexbox As Func(Of TextBoxBase)
        Get
            Return _GetCurrentTexbox
        End Get

        Set(value As Func(Of TextBoxBase))
            _GetCurrentTexbox = Function()
                                    CharTool.Focus()
                                    Return value()
                                End Function

            charEdit.GetCurrentTexbox = _GetCurrentTexbox
        End Set
    End Property

    Private Sub CharacterEditorToolWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        charEdit.GetCurrentTexbox = GetCurrentTexbox
    End Sub

    Private Sub CharacterEditorToolWindow_Activated(sender As Object, e As EventArgs) Handles Me.Activated
    End Sub

    Private Sub CharacterEditorToolWindow_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = True
        Visible = False
    End Sub
End Class