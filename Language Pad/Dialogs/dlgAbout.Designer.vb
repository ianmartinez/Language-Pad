﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgAbout
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgAbout))
        Me.MainTabControl = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.txtLicense = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.txtChangelog = New System.Windows.Forms.TextBox()
        Me.ttMain = New System.Windows.Forms.ToolTip(Me.components)
        Me.DoubleBufferedPanel1 = New TundraLib.DoubleBufferedPanel()
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.lblLanguagePad = New System.Windows.Forms.Label()
        Me.MainTableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.MainTabControl.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.DoubleBufferedPanel1.SuspendLayout()
        Me.MainTableLayoutPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'MainTabControl
        '
        Me.MainTabControl.Controls.Add(Me.TabPage1)
        Me.MainTabControl.Controls.Add(Me.TabPage2)
        Me.MainTabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainTabControl.Location = New System.Drawing.Point(7, 158)
        Me.MainTabControl.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MainTabControl.Name = "MainTabControl"
        Me.MainTabControl.SelectedIndex = 0
        Me.MainTabControl.Size = New System.Drawing.Size(698, 525)
        Me.MainTabControl.TabIndex = 9
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.txtLicense)
        Me.TabPage1.Location = New System.Drawing.Point(4, 29)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(9)
        Me.TabPage1.Size = New System.Drawing.Size(690, 492)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "License"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'txtLicense
        '
        Me.txtLicense.BackColor = System.Drawing.Color.White
        Me.txtLicense.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtLicense.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtLicense.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtLicense.Location = New System.Drawing.Point(9, 9)
        Me.txtLicense.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtLicense.Multiline = True
        Me.txtLicense.Name = "txtLicense"
        Me.txtLicense.ReadOnly = True
        Me.txtLicense.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtLicense.Size = New System.Drawing.Size(672, 474)
        Me.txtLicense.TabIndex = 7
        Me.txtLicense.Text = resources.GetString("txtLicense.Text")
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.txtChangelog)
        Me.TabPage2.Location = New System.Drawing.Point(4, 29)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(9)
        Me.TabPage2.Size = New System.Drawing.Size(690, 492)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Changelog"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'txtChangelog
        '
        Me.txtChangelog.BackColor = System.Drawing.Color.White
        Me.txtChangelog.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtChangelog.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtChangelog.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtChangelog.Location = New System.Drawing.Point(9, 9)
        Me.txtChangelog.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtChangelog.Multiline = True
        Me.txtChangelog.Name = "txtChangelog"
        Me.txtChangelog.ReadOnly = True
        Me.txtChangelog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtChangelog.Size = New System.Drawing.Size(672, 474)
        Me.txtChangelog.TabIndex = 8
        Me.txtChangelog.Text = resources.GetString("txtChangelog.Text")
        '
        'DoubleBufferedPanel1
        '
        Me.DoubleBufferedPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DoubleBufferedPanel1.BackgroundImage = CType(resources.GetObject("DoubleBufferedPanel1.BackgroundImage"), System.Drawing.Image)
        Me.DoubleBufferedPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.DoubleBufferedPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DoubleBufferedPanel1.Controls.Add(Me.lblVersion)
        Me.DoubleBufferedPanel1.Controls.Add(Me.lblLanguagePad)
        Me.DoubleBufferedPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DoubleBufferedPanel1.Location = New System.Drawing.Point(6, 6)
        Me.DoubleBufferedPanel1.Name = "DoubleBufferedPanel1"
        Me.DoubleBufferedPanel1.Size = New System.Drawing.Size(700, 144)
        Me.DoubleBufferedPanel1.TabIndex = 76
        '
        'lblVersion
        '
        Me.lblVersion.AutoSize = True
        Me.lblVersion.BackColor = System.Drawing.Color.Transparent
        Me.lblVersion.ForeColor = System.Drawing.Color.White
        Me.lblVersion.Location = New System.Drawing.Point(10, 94)
        Me.lblVersion.Margin = New System.Windows.Forms.Padding(9, 5, 4, 5)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(89, 20)
        Me.lblVersion.TabIndex = 74
        Me.lblVersion.Text = "Version 1.0"
        Me.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLanguagePad
        '
        Me.lblLanguagePad.AutoSize = True
        Me.lblLanguagePad.BackColor = System.Drawing.Color.Transparent
        Me.lblLanguagePad.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLanguagePad.ForeColor = System.Drawing.Color.White
        Me.lblLanguagePad.Location = New System.Drawing.Point(10, 31)
        Me.lblLanguagePad.Margin = New System.Windows.Forms.Padding(9, 5, 4, 5)
        Me.lblLanguagePad.Name = "lblLanguagePad"
        Me.lblLanguagePad.Size = New System.Drawing.Size(251, 40)
        Me.lblLanguagePad.TabIndex = 12
        Me.lblLanguagePad.Text = "Language Pad"
        Me.lblLanguagePad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MainTableLayoutPanel
        '
        Me.MainTableLayoutPanel.ColumnCount = 1
        Me.MainTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.MainTableLayoutPanel.Controls.Add(Me.DoubleBufferedPanel1, 0, 0)
        Me.MainTableLayoutPanel.Controls.Add(Me.MainTabControl, 0, 1)
        Me.MainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainTableLayoutPanel.Location = New System.Drawing.Point(6, 6)
        Me.MainTableLayoutPanel.Name = "MainTableLayoutPanel"
        Me.MainTableLayoutPanel.Padding = New System.Windows.Forms.Padding(3)
        Me.MainTableLayoutPanel.RowCount = 2
        Me.MainTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.MainTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.MainTableLayoutPanel.Size = New System.Drawing.Size(712, 691)
        Me.MainTableLayoutPanel.TabIndex = 77
        '
        'dlgAbout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(724, 703)
        Me.Controls.Add(Me.MainTableLayoutPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgAbout"
        Me.Padding = New System.Windows.Forms.Padding(6)
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "About"
        Me.MainTabControl.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.DoubleBufferedPanel1.ResumeLayout(False)
        Me.DoubleBufferedPanel1.PerformLayout()
        Me.MainTableLayoutPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MainTabControl As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents txtLicense As System.Windows.Forms.TextBox
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents txtChangelog As System.Windows.Forms.TextBox
    Friend WithEvents ttMain As ToolTip
    Friend WithEvents lblLanguagePad As Label
    Friend WithEvents lblVersion As Label
    Friend WithEvents DoubleBufferedPanel1 As TundraLib.DoubleBufferedPanel
    Friend WithEvents MainTableLayoutPanel As TableLayoutPanel
End Class
