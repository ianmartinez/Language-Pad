﻿Imports LangPadUI.Themes

Public NotInheritable Class SplashScreenForm
    Private Sub SplashScreenForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        LangPadLabel.Text = GetAppDisplayName()
        BackColor = New LightTheme().PanelBackColor
    End Sub
End Class
