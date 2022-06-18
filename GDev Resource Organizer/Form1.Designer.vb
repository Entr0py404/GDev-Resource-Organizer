<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ListView_ProjectResources = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ContextMenuStrip_ProjectResources = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MoveToSelectedDirectoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.SelectAllWithThisFilePathToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ReloadProjectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ContextMenuStrip_Log = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ClearLogToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button_MoveSelectedResources = New System.Windows.Forms.Button()
        Me.Panel_Top = New System.Windows.Forms.Panel()
        Me.Panel_FilePath = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox_ProjectFilePath = New System.Windows.Forms.TextBox()
        Me.ShapeContainer3 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape_FilePath = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button_SelectProjectJSON = New System.Windows.Forms.Button()
        Me.Button_Close = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBox_Directory = New System.Windows.Forms.ComboBox()
        Me.ContextMenuStrip_Directory = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ReloadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.RichTextBox_Log = New System.Windows.Forms.RichTextBox()
        Me.TextBox_NewDirectory = New System.Windows.Forms.TextBox()
        Me.Panel_Log = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ShapeContainer2 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape_Log = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.CheckBox_CompletionNotifications = New System.Windows.Forms.CheckBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel_Directory = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape_NewDirectory = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Button_CreateDirectory = New System.Windows.Forms.Button()
        Me.Label_Loading = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.ContextMenuStrip_ProjectResources.SuspendLayout()
        Me.ContextMenuStrip_Log.SuspendLayout()
        Me.Panel_Top.SuspendLayout()
        Me.Panel_FilePath.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.ContextMenuStrip_Directory.SuspendLayout()
        Me.Panel_Log.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel_Directory.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListView_ProjectResources
        '
        Me.ListView_ProjectResources.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.ListView_ProjectResources.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListView_ProjectResources.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.ListView_ProjectResources.ContextMenuStrip = Me.ContextMenuStrip_ProjectResources
        Me.ListView_ProjectResources.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView_ProjectResources.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView_ProjectResources.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.ListView_ProjectResources.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListView_ProjectResources.HideSelection = False
        Me.ListView_ProjectResources.LargeImageList = Me.ImageList1
        Me.ListView_ProjectResources.Location = New System.Drawing.Point(0, 72)
        Me.ListView_ProjectResources.Name = "ListView_ProjectResources"
        Me.ListView_ProjectResources.Size = New System.Drawing.Size(936, 360)
        Me.ListView_ProjectResources.SmallImageList = Me.ImageList1
        Me.ListView_ProjectResources.TabIndex = 96
        Me.ToolTip1.SetToolTip(Me.ListView_ProjectResources, "Right-click for options." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "You can drag & drop a project json file here." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        Me.ListView_ProjectResources.UseCompatibleStateImageBehavior = False
        Me.ListView_ProjectResources.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Name"
        Me.ColumnHeader1.Width = 250
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "File"
        Me.ColumnHeader2.Width = 519
        '
        'ContextMenuStrip_ProjectResources
        '
        Me.ContextMenuStrip_ProjectResources.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.ContextMenuStrip_ProjectResources.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContextMenuStrip_ProjectResources.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MoveToSelectedDirectoryToolStripMenuItem, Me.ToolStripSeparator2, Me.SelectAllWithThisFilePathToolStripMenuItem, Me.SelectAllToolStripMenuItem, Me.ToolStripSeparator1, Me.ReloadProjectToolStripMenuItem})
        Me.ContextMenuStrip_ProjectResources.Name = "ContextMenuStrip3"
        Me.ContextMenuStrip_ProjectResources.ShowImageMargin = False
        Me.ContextMenuStrip_ProjectResources.Size = New System.Drawing.Size(286, 112)
        '
        'MoveToSelectedDirectoryToolStripMenuItem
        '
        Me.MoveToSelectedDirectoryToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.MoveToSelectedDirectoryToolStripMenuItem.Name = "MoveToSelectedDirectoryToolStripMenuItem"
        Me.MoveToSelectedDirectoryToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.M), System.Windows.Forms.Keys)
        Me.MoveToSelectedDirectoryToolStripMenuItem.Size = New System.Drawing.Size(285, 24)
        Me.MoveToSelectedDirectoryToolStripMenuItem.Text = "Move to selected directory"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(282, 6)
        '
        'SelectAllWithThisFilePathToolStripMenuItem
        '
        Me.SelectAllWithThisFilePathToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.SelectAllWithThisFilePathToolStripMenuItem.Name = "SelectAllWithThisFilePathToolStripMenuItem"
        Me.SelectAllWithThisFilePathToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SelectAllWithThisFilePathToolStripMenuItem.Size = New System.Drawing.Size(285, 24)
        Me.SelectAllWithThisFilePathToolStripMenuItem.Text = "Select all with this file path"
        '
        'SelectAllToolStripMenuItem
        '
        Me.SelectAllToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.SelectAllToolStripMenuItem.Name = "SelectAllToolStripMenuItem"
        Me.SelectAllToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.SelectAllToolStripMenuItem.Size = New System.Drawing.Size(285, 24)
        Me.SelectAllToolStripMenuItem.Text = "Select all"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(282, 6)
        '
        'ReloadProjectToolStripMenuItem
        '
        Me.ReloadProjectToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.ReloadProjectToolStripMenuItem.Name = "ReloadProjectToolStripMenuItem"
        Me.ReloadProjectToolStripMenuItem.Size = New System.Drawing.Size(285, 24)
        Me.ReloadProjectToolStripMenuItem.Text = "Reload"
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(32, 32)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'ContextMenuStrip_Log
        '
        Me.ContextMenuStrip_Log.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.ContextMenuStrip_Log.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContextMenuStrip_Log.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClearLogToolStripMenuItem})
        Me.ContextMenuStrip_Log.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip_Log.ShowImageMargin = False
        Me.ContextMenuStrip_Log.Size = New System.Drawing.Size(88, 28)
        '
        'ClearLogToolStripMenuItem
        '
        Me.ClearLogToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.ClearLogToolStripMenuItem.Name = "ClearLogToolStripMenuItem"
        Me.ClearLogToolStripMenuItem.Size = New System.Drawing.Size(87, 24)
        Me.ClearLogToolStripMenuItem.Text = "Clear"
        '
        'Button_MoveSelectedResources
        '
        Me.Button_MoveSelectedResources.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Button_MoveSelectedResources.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Button_MoveSelectedResources.FlatAppearance.BorderSize = 0
        Me.Button_MoveSelectedResources.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_MoveSelectedResources.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Button_MoveSelectedResources.Location = New System.Drawing.Point(320, 16)
        Me.Button_MoveSelectedResources.Name = "Button_MoveSelectedResources"
        Me.Button_MoveSelectedResources.Size = New System.Drawing.Size(200, 32)
        Me.Button_MoveSelectedResources.TabIndex = 97
        Me.Button_MoveSelectedResources.Text = "Move Selected Resources"
        Me.Button_MoveSelectedResources.UseVisualStyleBackColor = False
        '
        'Panel_Top
        '
        Me.Panel_Top.Controls.Add(Me.Panel_FilePath)
        Me.Panel_Top.Controls.Add(Me.Panel1)
        Me.Panel_Top.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_Top.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Top.Name = "Panel_Top"
        Me.Panel_Top.Size = New System.Drawing.Size(936, 72)
        Me.Panel_Top.TabIndex = 98
        '
        'Panel_FilePath
        '
        Me.Panel_FilePath.Controls.Add(Me.Label1)
        Me.Panel_FilePath.Controls.Add(Me.TextBox_ProjectFilePath)
        Me.Panel_FilePath.Controls.Add(Me.ShapeContainer3)
        Me.Panel_FilePath.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_FilePath.Location = New System.Drawing.Point(0, 0)
        Me.Panel_FilePath.Name = "Panel_FilePath"
        Me.Panel_FilePath.Size = New System.Drawing.Size(752, 72)
        Me.Panel_FilePath.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Project File Path"
        '
        'TextBox_ProjectFilePath
        '
        Me.TextBox_ProjectFilePath.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.TextBox_ProjectFilePath.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_ProjectFilePath.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_ProjectFilePath.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.TextBox_ProjectFilePath.Location = New System.Drawing.Point(16, 40)
        Me.TextBox_ProjectFilePath.Name = "TextBox_ProjectFilePath"
        Me.TextBox_ProjectFilePath.ReadOnly = True
        Me.TextBox_ProjectFilePath.Size = New System.Drawing.Size(720, 14)
        Me.TextBox_ProjectFilePath.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.TextBox_ProjectFilePath, "You can drag & drop a project json file here.")
        '
        'ShapeContainer3
        '
        Me.ShapeContainer3.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer3.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer3.Name = "ShapeContainer3"
        Me.ShapeContainer3.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape_FilePath})
        Me.ShapeContainer3.Size = New System.Drawing.Size(752, 72)
        Me.ShapeContainer3.TabIndex = 1
        Me.ShapeContainer3.TabStop = False
        '
        'RectangleShape_FilePath
        '
        Me.RectangleShape_FilePath.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.RectangleShape_FilePath.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape_FilePath.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.RectangleShape_FilePath.CornerRadius = 3
        Me.RectangleShape_FilePath.FillColor = System.Drawing.Color.WhiteSmoke
        Me.RectangleShape_FilePath.FillGradientColor = System.Drawing.Color.WhiteSmoke
        Me.RectangleShape_FilePath.Location = New System.Drawing.Point(8, 32)
        Me.RectangleShape_FilePath.Name = "RectangleShape_FilePath"
        Me.RectangleShape_FilePath.SelectionColor = System.Drawing.Color.Transparent
        Me.RectangleShape_FilePath.Size = New System.Drawing.Size(736, 24)
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button_SelectProjectJSON)
        Me.Panel1.Controls.Add(Me.Button_Close)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(752, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(184, 72)
        Me.Panel1.TabIndex = 14
        '
        'Button_SelectProjectJSON
        '
        Me.Button_SelectProjectJSON.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button_SelectProjectJSON.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Button_SelectProjectJSON.FlatAppearance.BorderSize = 0
        Me.Button_SelectProjectJSON.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_SelectProjectJSON.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_SelectProjectJSON.Location = New System.Drawing.Point(8, 32)
        Me.Button_SelectProjectJSON.Name = "Button_SelectProjectJSON"
        Me.Button_SelectProjectJSON.Size = New System.Drawing.Size(64, 24)
        Me.Button_SelectProjectJSON.TabIndex = 2
        Me.Button_SelectProjectJSON.Text = "..."
        Me.ToolTip1.SetToolTip(Me.Button_SelectProjectJSON, "You can drag & drop a project json file here.")
        Me.Button_SelectProjectJSON.UseVisualStyleBackColor = False
        '
        'Button_Close
        '
        Me.Button_Close.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button_Close.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Button_Close.FlatAppearance.BorderSize = 0
        Me.Button_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Close.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Close.Location = New System.Drawing.Point(96, 32)
        Me.Button_Close.Name = "Button_Close"
        Me.Button_Close.Size = New System.Drawing.Size(80, 24)
        Me.Button_Close.TabIndex = 11
        Me.Button_Close.Text = "Close"
        Me.Button_Close.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(72, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 21)
        Me.Label2.TabIndex = 100
        Me.Label2.Text = "Directory"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ComboBox_Directory
        '
        Me.ComboBox_Directory.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.ComboBox_Directory.ContextMenuStrip = Me.ContextMenuStrip_Directory
        Me.ComboBox_Directory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_Directory.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox_Directory.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.ComboBox_Directory.FormattingEnabled = True
        Me.ComboBox_Directory.Location = New System.Drawing.Point(152, 16)
        Me.ComboBox_Directory.Name = "ComboBox_Directory"
        Me.ComboBox_Directory.Size = New System.Drawing.Size(240, 23)
        Me.ComboBox_Directory.TabIndex = 101
        Me.ToolTip1.SetToolTip(Me.ComboBox_Directory, "Right-click for options.")
        '
        'ContextMenuStrip_Directory
        '
        Me.ContextMenuStrip_Directory.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.ContextMenuStrip_Directory.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContextMenuStrip_Directory.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReloadToolStripMenuItem})
        Me.ContextMenuStrip_Directory.Name = "ContextMenuStrip2"
        Me.ContextMenuStrip_Directory.ShowImageMargin = False
        Me.ContextMenuStrip_Directory.Size = New System.Drawing.Size(101, 28)
        '
        'ReloadToolStripMenuItem
        '
        Me.ReloadToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.ReloadToolStripMenuItem.Name = "ReloadToolStripMenuItem"
        Me.ReloadToolStripMenuItem.Size = New System.Drawing.Size(100, 24)
        Me.ReloadToolStripMenuItem.Text = "Reload"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.Filter = "Json files (*.json)|*.json"
        '
        'ToolTip1
        '
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTip1.ToolTipTitle = "Hint"
        '
        'RichTextBox_Log
        '
        Me.RichTextBox_Log.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.RichTextBox_Log.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox_Log.ContextMenuStrip = Me.ContextMenuStrip_Log
        Me.RichTextBox_Log.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox_Log.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.RichTextBox_Log.Location = New System.Drawing.Point(16, 32)
        Me.RichTextBox_Log.Name = "RichTextBox_Log"
        Me.RichTextBox_Log.ReadOnly = True
        Me.RichTextBox_Log.Size = New System.Drawing.Size(904, 88)
        Me.RichTextBox_Log.TabIndex = 8
        Me.RichTextBox_Log.Text = ""
        Me.ToolTip1.SetToolTip(Me.RichTextBox_Log, "Right-click for options.")
        Me.RichTextBox_Log.WordWrap = False
        '
        'TextBox_NewDirectory
        '
        Me.TextBox_NewDirectory.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.TextBox_NewDirectory.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_NewDirectory.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_NewDirectory.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.TextBox_NewDirectory.Location = New System.Drawing.Point(160, 64)
        Me.TextBox_NewDirectory.Name = "TextBox_NewDirectory"
        Me.TextBox_NewDirectory.Size = New System.Drawing.Size(224, 14)
        Me.TextBox_NewDirectory.TabIndex = 104
        '
        'Panel_Log
        '
        Me.Panel_Log.Controls.Add(Me.RichTextBox_Log)
        Me.Panel_Log.Controls.Add(Me.Label3)
        Me.Panel_Log.Controls.Add(Me.ShapeContainer2)
        Me.Panel_Log.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel_Log.Location = New System.Drawing.Point(0, 527)
        Me.Panel_Log.Name = "Panel_Log"
        Me.Panel_Log.Size = New System.Drawing.Size(936, 136)
        Me.Panel_Log.TabIndex = 103
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Log"
        '
        'ShapeContainer2
        '
        Me.ShapeContainer2.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer2.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer2.Name = "ShapeContainer2"
        Me.ShapeContainer2.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape_Log})
        Me.ShapeContainer2.Size = New System.Drawing.Size(936, 136)
        Me.ShapeContainer2.TabIndex = 0
        Me.ShapeContainer2.TabStop = False
        '
        'RectangleShape_Log
        '
        Me.RectangleShape_Log.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.RectangleShape_Log.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape_Log.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.RectangleShape_Log.CornerRadius = 3
        Me.RectangleShape_Log.FillColor = System.Drawing.Color.WhiteSmoke
        Me.RectangleShape_Log.FillGradientColor = System.Drawing.Color.WhiteSmoke
        Me.RectangleShape_Log.Location = New System.Drawing.Point(8, 24)
        Me.RectangleShape_Log.Name = "RectangleShape_Log"
        Me.RectangleShape_Log.SelectionColor = System.Drawing.Color.Transparent
        Me.RectangleShape_Log.Size = New System.Drawing.Size(920, 104)
        '
        'CheckBox_CompletionNotifications
        '
        Me.CheckBox_CompletionNotifications.AutoSize = True
        Me.CheckBox_CompletionNotifications.Checked = True
        Me.CheckBox_CompletionNotifications.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox_CompletionNotifications.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox_CompletionNotifications.Location = New System.Drawing.Point(152, 24)
        Me.CheckBox_CompletionNotifications.Name = "CheckBox_CompletionNotifications"
        Me.CheckBox_CompletionNotifications.Size = New System.Drawing.Size(163, 17)
        Me.CheckBox_CompletionNotifications.TabIndex = 7
        Me.CheckBox_CompletionNotifications.Text = "Completion Notifications"
        Me.CheckBox_CompletionNotifications.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel_Directory)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 432)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(936, 95)
        Me.Panel2.TabIndex = 105
        '
        'Panel_Directory
        '
        Me.Panel_Directory.Controls.Add(Me.Label4)
        Me.Panel_Directory.Controls.Add(Me.TextBox_NewDirectory)
        Me.Panel_Directory.Controls.Add(Me.Label2)
        Me.Panel_Directory.Controls.Add(Me.ComboBox_Directory)
        Me.Panel_Directory.Controls.Add(Me.ShapeContainer1)
        Me.Panel_Directory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_Directory.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Directory.Name = "Panel_Directory"
        Me.Panel_Directory.Size = New System.Drawing.Size(402, 95)
        Me.Panel_Directory.TabIndex = 103
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(136, 21)
        Me.Label4.TabIndex = 106
        Me.Label4.Text = "New Directory Name"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape_NewDirectory})
        Me.ShapeContainer1.Size = New System.Drawing.Size(402, 95)
        Me.ShapeContainer1.TabIndex = 105
        Me.ShapeContainer1.TabStop = False
        '
        'RectangleShape_NewDirectory
        '
        Me.RectangleShape_NewDirectory.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.RectangleShape_NewDirectory.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape_NewDirectory.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.RectangleShape_NewDirectory.CornerRadius = 3
        Me.RectangleShape_NewDirectory.FillColor = System.Drawing.Color.WhiteSmoke
        Me.RectangleShape_NewDirectory.FillGradientColor = System.Drawing.Color.WhiteSmoke
        Me.RectangleShape_NewDirectory.Location = New System.Drawing.Point(152, 56)
        Me.RectangleShape_NewDirectory.Name = "RectangleShape_NewDirectory"
        Me.RectangleShape_NewDirectory.SelectionColor = System.Drawing.Color.Transparent
        Me.RectangleShape_NewDirectory.Size = New System.Drawing.Size(240, 24)
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.CheckBox_CompletionNotifications)
        Me.Panel3.Controls.Add(Me.Button_MoveSelectedResources)
        Me.Panel3.Controls.Add(Me.Button_CreateDirectory)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(402, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(534, 95)
        Me.Panel3.TabIndex = 102
        '
        'Button_CreateDirectory
        '
        Me.Button_CreateDirectory.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Button_CreateDirectory.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Button_CreateDirectory.FlatAppearance.BorderSize = 0
        Me.Button_CreateDirectory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_CreateDirectory.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Button_CreateDirectory.Location = New System.Drawing.Point(8, 56)
        Me.Button_CreateDirectory.Name = "Button_CreateDirectory"
        Me.Button_CreateDirectory.Size = New System.Drawing.Size(128, 32)
        Me.Button_CreateDirectory.TabIndex = 102
        Me.Button_CreateDirectory.Text = "Create Directory"
        Me.Button_CreateDirectory.UseVisualStyleBackColor = False
        '
        'Label_Loading
        '
        Me.Label_Loading.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label_Loading.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Loading.ForeColor = System.Drawing.Color.PaleGoldenrod
        Me.Label_Loading.Location = New System.Drawing.Point(0, 72)
        Me.Label_Loading.Name = "Label_Loading"
        Me.Label_Loading.Size = New System.Drawing.Size(936, 360)
        Me.Label_Loading.TabIndex = 106
        Me.Label_Loading.Text = "Loading Please Wait..."
        Me.Label_Loading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label_Loading.Visible = False
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerReportsProgress = True
        Me.BackgroundWorker1.WorkerSupportsCancellation = True
        '
        'Form1
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(936, 663)
        Me.Controls.Add(Me.Label_Loading)
        Me.Controls.Add(Me.ListView_ProjectResources)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel_Top)
        Me.Controls.Add(Me.Panel_Log)
        Me.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(626, 600)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GDev Resource Organizer"
        Me.ContextMenuStrip_ProjectResources.ResumeLayout(False)
        Me.ContextMenuStrip_Log.ResumeLayout(False)
        Me.Panel_Top.ResumeLayout(False)
        Me.Panel_FilePath.ResumeLayout(False)
        Me.Panel_FilePath.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ContextMenuStrip_Directory.ResumeLayout(False)
        Me.Panel_Log.ResumeLayout(False)
        Me.Panel_Log.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel_Directory.ResumeLayout(False)
        Me.Panel_Directory.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button_MoveSelectedResources As Button
    Friend WithEvents ListView_ProjectResources As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents Panel_Top As Panel
    Friend WithEvents Button_Close As Button
    Friend WithEvents Button_SelectProjectJSON As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox_ProjectFilePath As TextBox
    Friend WithEvents ComboBox_Directory As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ContextMenuStrip_Log As ContextMenuStrip
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents RectangleShape_FilePath As RectangleShape
    Friend WithEvents Panel_Log As Panel
    Friend WithEvents RichTextBox_Log As RichTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ShapeContainer2 As ShapeContainer
    Friend WithEvents RectangleShape_Log As RectangleShape
    Friend WithEvents ClearLogToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip_Directory As ContextMenuStrip
    Friend WithEvents ReloadToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel_FilePath As Panel
    Friend WithEvents ShapeContainer3 As ShapeContainer
    Friend WithEvents ContextMenuStrip_ProjectResources As ContextMenuStrip
    Friend WithEvents MoveToSelectedDirectoryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReloadProjectToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel_Directory As Panel
    Friend WithEvents SelectAllToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SelectAllWithThisFilePathToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents CheckBox_CompletionNotifications As CheckBox
    Friend WithEvents TextBox_NewDirectory As TextBox
    Friend WithEvents Button_CreateDirectory As Button
    Friend WithEvents ShapeContainer1 As ShapeContainer
    Friend WithEvents RectangleShape_NewDirectory As RectangleShape
    Friend WithEvents Label4 As Label
    Friend WithEvents Label_Loading As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
End Class
