﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PropertiesEditor
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PropertiesEditor))
        Me.ttMain = New System.Windows.Forms.ToolTip(Me.components)
        Me.DocumentToolStripContainer = New System.Windows.Forms.ToolStripContainer()
        Me.StylizedPanel1 = New TundraLib.DoubleBufferedPanel()
        Me.lbPages = New System.Windows.Forms.ListBox()
        Me.DocumentToolStrip = New System.Windows.Forms.ToolStrip()
        Me.PageUpToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.PageDownToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.AddToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.RemoveToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.DuplicateToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.RenameToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ImportToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ExportToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.DictionaryToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtInfo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnGo = New System.Windows.Forms.Button()
        Me.txtWebsite = New System.Windows.Forms.TextBox()
        Me.txtLanguage = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtAuthor = New System.Windows.Forms.TextBox()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DocumentToolStripContainer.ContentPanel.SuspendLayout()
        Me.DocumentToolStripContainer.TopToolStripPanel.SuspendLayout()
        Me.DocumentToolStripContainer.SuspendLayout()
        Me.StylizedPanel1.SuspendLayout()
        Me.DocumentToolStrip.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DocumentToolStripContainer
        '
        '
        'DocumentToolStripContainer.BottomToolStripPanel
        '
        '
        'DocumentToolStripContainer.ContentPanel
        '
        Me.DocumentToolStripContainer.ContentPanel.Controls.Add(Me.StylizedPanel1)
        Me.DocumentToolStripContainer.ContentPanel.Size = New System.Drawing.Size(422, 487)
        Me.DocumentToolStripContainer.Dock = System.Windows.Forms.DockStyle.Fill
        '
        'DocumentToolStripContainer.LeftToolStripPanel
        '
        Me.DocumentToolStripContainer.Location = New System.Drawing.Point(0, 466)
        Me.DocumentToolStripContainer.Name = "DocumentToolStripContainer"
        '
        'DocumentToolStripContainer.RightToolStripPanel
        '
        Me.DocumentToolStripContainer.Size = New System.Drawing.Size(422, 528)
        Me.DocumentToolStripContainer.TabIndex = 81
        Me.DocumentToolStripContainer.Text = "ToolStripContainer1"
        '
        'DocumentToolStripContainer.TopToolStripPanel
        '
        Me.DocumentToolStripContainer.TopToolStripPanel.Controls.Add(Me.DocumentToolStrip)
        '
        'StylizedPanel1
        '
        Me.StylizedPanel1.BackColor = System.Drawing.Color.Transparent
        Me.StylizedPanel1.Controls.Add(Me.lbPages)
        Me.StylizedPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.StylizedPanel1.Location = New System.Drawing.Point(0, 0)
        Me.StylizedPanel1.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.StylizedPanel1.Name = "StylizedPanel1"
        Me.StylizedPanel1.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.StylizedPanel1.Size = New System.Drawing.Size(422, 487)
        Me.StylizedPanel1.TabIndex = 80
        '
        'lbPages
        '
        Me.lbPages.BackColor = System.Drawing.Color.White
        Me.lbPages.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lbPages.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbPages.ForeColor = System.Drawing.Color.Black
        Me.lbPages.IntegralHeight = False
        Me.lbPages.ItemHeight = 20
        Me.lbPages.Location = New System.Drawing.Point(2, 0)
        Me.lbPages.Name = "lbPages"
        Me.lbPages.Size = New System.Drawing.Size(420, 487)
        Me.lbPages.TabIndex = 15
        '
        'DocumentToolStrip
        '
        Me.DocumentToolStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.DocumentToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.DocumentToolStrip.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.DocumentToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PageUpToolStripButton, Me.PageDownToolStripButton, Me.ToolStripSeparator1, Me.AddToolStripButton, Me.RemoveToolStripButton, Me.DuplicateToolStripButton, Me.ToolStripSeparator3, Me.RenameToolStripButton, Me.ToolStripSeparator2, Me.ImportToolStripButton, Me.ExportToolStripButton, Me.ToolStripSeparator4, Me.DictionaryToolStripButton})
        Me.DocumentToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.DocumentToolStrip.Name = "DocumentToolStrip"
        Me.DocumentToolStrip.Size = New System.Drawing.Size(422, 41)
        Me.DocumentToolStrip.Stretch = True
        Me.DocumentToolStrip.TabIndex = 0
        '
        'PageUpToolStripButton
        '
        Me.PageUpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PageUpToolStripButton.Image = CType(resources.GetObject("PageUpToolStripButton.Image"), System.Drawing.Image)
        Me.PageUpToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.PageUpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PageUpToolStripButton.Name = "PageUpToolStripButton"
        Me.PageUpToolStripButton.Size = New System.Drawing.Size(36, 36)
        Me.PageUpToolStripButton.Text = "Move Page Up"
        '
        'PageDownToolStripButton
        '
        Me.PageDownToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PageDownToolStripButton.Image = CType(resources.GetObject("PageDownToolStripButton.Image"), System.Drawing.Image)
        Me.PageDownToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.PageDownToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PageDownToolStripButton.Name = "PageDownToolStripButton"
        Me.PageDownToolStripButton.Size = New System.Drawing.Size(36, 36)
        Me.PageDownToolStripButton.Text = "Move Page Down"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 41)
        '
        'AddToolStripButton
        '
        Me.AddToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AddToolStripButton.Image = CType(resources.GetObject("AddToolStripButton.Image"), System.Drawing.Image)
        Me.AddToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.AddToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AddToolStripButton.Name = "AddToolStripButton"
        Me.AddToolStripButton.Size = New System.Drawing.Size(36, 36)
        Me.AddToolStripButton.Text = "Add Page"
        '
        'RemoveToolStripButton
        '
        Me.RemoveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.RemoveToolStripButton.Image = CType(resources.GetObject("RemoveToolStripButton.Image"), System.Drawing.Image)
        Me.RemoveToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.RemoveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.RemoveToolStripButton.Name = "RemoveToolStripButton"
        Me.RemoveToolStripButton.Size = New System.Drawing.Size(36, 36)
        Me.RemoveToolStripButton.Text = "Remove Page"
        '
        'DuplicateToolStripButton
        '
        Me.DuplicateToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DuplicateToolStripButton.Image = CType(resources.GetObject("DuplicateToolStripButton.Image"), System.Drawing.Image)
        Me.DuplicateToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.DuplicateToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.DuplicateToolStripButton.Name = "DuplicateToolStripButton"
        Me.DuplicateToolStripButton.Size = New System.Drawing.Size(36, 36)
        Me.DuplicateToolStripButton.Text = "Duplicate Page"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 41)
        '
        'RenameToolStripButton
        '
        Me.RenameToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.RenameToolStripButton.Image = CType(resources.GetObject("RenameToolStripButton.Image"), System.Drawing.Image)
        Me.RenameToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.RenameToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.RenameToolStripButton.Name = "RenameToolStripButton"
        Me.RenameToolStripButton.Size = New System.Drawing.Size(36, 36)
        Me.RenameToolStripButton.Text = "Rename Page"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 41)
        '
        'ImportToolStripButton
        '
        Me.ImportToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ImportToolStripButton.Image = CType(resources.GetObject("ImportToolStripButton.Image"), System.Drawing.Image)
        Me.ImportToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ImportToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ImportToolStripButton.Name = "ImportToolStripButton"
        Me.ImportToolStripButton.Size = New System.Drawing.Size(36, 36)
        Me.ImportToolStripButton.Text = "Import Page"
        '
        'ExportToolStripButton
        '
        Me.ExportToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ExportToolStripButton.Image = CType(resources.GetObject("ExportToolStripButton.Image"), System.Drawing.Image)
        Me.ExportToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ExportToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ExportToolStripButton.Name = "ExportToolStripButton"
        Me.ExportToolStripButton.Size = New System.Drawing.Size(36, 36)
        Me.ExportToolStripButton.Text = "Export Page"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 41)
        '
        'DictionaryToolStripButton
        '
        Me.DictionaryToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DictionaryToolStripButton.Image = CType(resources.GetObject("DictionaryToolStripButton.Image"), System.Drawing.Image)
        Me.DictionaryToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.DictionaryToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.DictionaryToolStripButton.Name = "DictionaryToolStripButton"
        Me.DictionaryToolStripButton.Size = New System.Drawing.Size(36, 36)
        Me.DictionaryToolStripButton.Text = "Dictionary"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Location = New System.Drawing.Point(23, 312)
        Me.Label4.Margin = New System.Windows.Forms.Padding(3, 6, 3, 3)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(376, 20)
        Me.Label4.TabIndex = 78
        Me.Label4.Text = "Info:"
        '
        'txtInfo
        '
        Me.txtInfo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtInfo.Location = New System.Drawing.Point(23, 341)
        Me.txtInfo.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.txtInfo.Multiline = True
        Me.txtInfo.Name = "txtInfo"
        Me.txtInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtInfo.Size = New System.Drawing.Size(376, 115)
        Me.txtInfo.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Location = New System.Drawing.Point(23, 202)
        Me.Label3.Margin = New System.Windows.Forms.Padding(3, 6, 3, 3)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(376, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Website:"
        '
        'btnGo
        '
        Me.btnGo.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnGo.Location = New System.Drawing.Point(282, 0)
        Me.btnGo.Margin = New System.Windows.Forms.Padding(3, 3, 0, 3)
        Me.btnGo.MinimumSize = New System.Drawing.Size(80, 0)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(94, 40)
        Me.btnGo.TabIndex = 79
        Me.btnGo.Text = "Go"
        Me.btnGo.UseVisualStyleBackColor = True
        '
        'txtWebsite
        '
        Me.txtWebsite.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtWebsite.Location = New System.Drawing.Point(23, 231)
        Me.txtWebsite.Margin = New System.Windows.Forms.Padding(3, 6, 3, 3)
        Me.txtWebsite.Name = "txtWebsite"
        Me.txtWebsite.Size = New System.Drawing.Size(376, 26)
        Me.txtWebsite.TabIndex = 3
        '
        'txtLanguage
        '
        Me.txtLanguage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtLanguage.Location = New System.Drawing.Point(23, 103)
        Me.txtLanguage.Margin = New System.Windows.Forms.Padding(3, 6, 3, 3)
        Me.txtLanguage.Name = "txtLanguage"
        Me.txtLanguage.Size = New System.Drawing.Size(376, 26)
        Me.txtLanguage.TabIndex = 80
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Location = New System.Drawing.Point(23, 74)
        Me.Label5.Margin = New System.Windows.Forms.Padding(3, 6, 3, 3)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(376, 20)
        Me.Label5.TabIndex = 81
        Me.Label5.Text = "Language:"
        '
        'txtAuthor
        '
        Me.txtAuthor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtAuthor.Location = New System.Drawing.Point(23, 167)
        Me.txtAuthor.Margin = New System.Windows.Forms.Padding(3, 6, 3, 3)
        Me.txtAuthor.Name = "txtAuthor"
        Me.txtAuthor.Size = New System.Drawing.Size(376, 26)
        Me.txtAuthor.TabIndex = 2
        '
        'txtTitle
        '
        Me.txtTitle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtTitle.Location = New System.Drawing.Point(23, 39)
        Me.txtTitle.Margin = New System.Windows.Forms.Padding(3, 6, 3, 3)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(376, 26)
        Me.txtTitle.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Location = New System.Drawing.Point(23, 138)
        Me.Label2.Margin = New System.Windows.Forms.Padding(3, 6, 3, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(376, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Author:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(23, 10)
        Me.Label1.Margin = New System.Windows.Forms.Padding(3, 6, 3, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(376, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Title:"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 10)
        Me.TableLayoutPanel1.Controls.Add(Me.txtWebsite, 0, 9)
        Me.TableLayoutPanel1.Controls.Add(Me.txtInfo, 0, 12)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 11)
        Me.TableLayoutPanel1.Controls.Add(Me.txtLanguage, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.txtTitle, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.txtAuthor, 0, 6)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.Padding = New System.Windows.Forms.Padding(20, 4, 20, 4)
        Me.TableLayoutPanel1.RowCount = 13
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(422, 466)
        Me.TableLayoutPanel1.TabIndex = 82
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnGo)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(23, 263)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(376, 40)
        Me.Panel1.TabIndex = 16
        '
        'PropertiesEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.DocumentToolStripContainer)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.DoubleBuffered = True
        Me.Name = "PropertiesEditor"
        Me.Size = New System.Drawing.Size(422, 994)
        Me.DocumentToolStripContainer.ContentPanel.ResumeLayout(False)
        Me.DocumentToolStripContainer.TopToolStripPanel.ResumeLayout(False)
        Me.DocumentToolStripContainer.TopToolStripPanel.PerformLayout()
        Me.DocumentToolStripContainer.ResumeLayout(False)
        Me.DocumentToolStripContainer.PerformLayout()
        Me.StylizedPanel1.ResumeLayout(False)
        Me.DocumentToolStrip.ResumeLayout(False)
        Me.DocumentToolStrip.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtTitle As System.Windows.Forms.TextBox
    Friend WithEvents txtAuthor As System.Windows.Forms.TextBox
    Friend WithEvents txtWebsite As System.Windows.Forms.TextBox
    Friend WithEvents lbPages As System.Windows.Forms.ListBox
    Friend WithEvents ttMain As System.Windows.Forms.ToolTip
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtInfo As System.Windows.Forms.TextBox
    Friend WithEvents StylizedPanel1 As TundraLib.DoubleBufferedPanel
    Friend WithEvents PageUpToolStripButton As ToolStripButton
    Friend WithEvents PageDownToolStripButton As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents AddToolStripButton As ToolStripButton
    Friend WithEvents RemoveToolStripButton As ToolStripButton
    Friend WithEvents DuplicateToolStripButton As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents RenameToolStripButton As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ImportToolStripButton As ToolStripButton
    Friend WithEvents ExportToolStripButton As ToolStripButton
    Friend WithEvents DocumentToolStrip As ToolStrip
    Friend WithEvents DocumentToolStripContainer As ToolStripContainer
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents DictionaryToolStripButton As ToolStripButton
    Friend WithEvents btnGo As Button
    Friend WithEvents txtLanguage As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
End Class
