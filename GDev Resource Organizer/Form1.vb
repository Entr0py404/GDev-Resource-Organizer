Imports System.ComponentModel
Imports System.IO
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Public Class Form1
    ReadOnly SupportedAudioFormats() As String = {".wav", ".mp3", ".ogg", ".acc"}
    Dim RichTextBox_Log_Padding As Integer = 0
    Dim RectangleShape_Log_Padding As Integer = 0
    Dim RectangleShape_FilePath_Padding As Integer = 0
    Dim TextBox_ProjectFilePath_Padding As Integer = 0
    Dim ComboBox_Directory_Padding As Integer = 0
    Dim TextBox_NewDirectory_Padding As Integer = 0
    Dim RectangleShape_NewDirectory_Padding As Integer = 0
    Dim resizeLoadlock As Boolean = True

    'Form1 - Load
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ContextMenuStrip_Log.Renderer = New ToolStripProfessionalRenderer(New ColorTable())
        ContextMenuStrip_Directory.Renderer = New ToolStripProfessionalRenderer(New ColorTable())
        ContextMenuStrip_ProjectResources.Renderer = New ToolStripProfessionalRenderer(New ColorTable())

        'FilePath area
        RectangleShape_FilePath_Padding = Panel_FilePath.Width - RectangleShape_FilePath.Width
        TextBox_ProjectFilePath_Padding = RectangleShape_FilePath.Width - TextBox_ProjectFilePath.Width

        'log area
        RectangleShape_Log_Padding = Panel_Log.Width - RectangleShape_Log.Width
        RichTextBox_Log_Padding = RectangleShape_Log.Width - RichTextBox_Log.Width

        'Directory area
        ComboBox_Directory_Padding = Panel_Directory.Width - ComboBox_Directory.Width
        RectangleShape_NewDirectory_Padding = Panel_Directory.Width - RectangleShape_NewDirectory.Width
        TextBox_NewDirectory_Padding = RectangleShape_NewDirectory.Width - TextBox_NewDirectory.Width

        resizeLoadlock = False
    End Sub
    'Button_SelectProjectJSON - Click
    Private Sub Button_SelectProjectJSON_Click(sender As Object, e As EventArgs) Handles Button_SelectProjectJSON.Click
        OpenFileDialog1.FileName = ""
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            TextBox_ProjectFilePath.Text = OpenFileDialog1.FileName
            'ProjectJSON()
            If Not BackgroundWorker1.IsBusy Then
                Log_msg("Loading project", Color.PaleGoldenrod)
                BackgroundWorker1.RunWorkerAsync()
            End If

            loadDirectories()
            If ComboBox_Directory.Items.Count > 0 Then
                ComboBox_Directory.SelectedIndex = 0
            End If
        End If
    End Sub
    'Button_Close - Click
    Private Sub Button_Close_Click(sender As Object, e As EventArgs) Handles Button_Close.Click
        If Not BackgroundWorker1.IsBusy Then
            TextBox_ProjectFilePath.Clear()
            ListView_ProjectResources.Items.Clear()
            ImageList1.Images.Clear()
            ComboBox_Directory.Items.Clear()
            RichTextBox_Log.Clear()
            'Log msg
            Log_msg("Project closed", Color.PaleGoldenrod)
        End If
    End Sub
    'Reload (ToolStripMenuItem) - Click
    Private Sub ReloadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReloadToolStripMenuItem.Click
        If File.Exists(TextBox_ProjectFilePath.Text) Then
            loadDirectories()
            If ComboBox_Directory.Items.Count > 0 Then
                ComboBox_Directory.SelectedIndex = 0
            End If

            'Log msg
            Log_msg("Directories reloaded", Color.PaleGoldenrod)
        End If
    End Sub
    'ClearLog (ToolStripMenuItem) - Click
    Private Sub ClearLogToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearLogToolStripMenuItem.Click
        RichTextBox_Log.Clear()
        'Log msg
        Log_msg("Log cleared", Color.PaleGoldenrod)
    End Sub
    'ReloadProject (ToolStripMenuItem) - Click
    Private Sub ReloadProjectToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReloadProjectToolStripMenuItem.Click
        If File.Exists(TextBox_ProjectFilePath.Text) Then
            'ProjectJSON()
            If Not BackgroundWorker1.IsBusy Then
                'Log msg
                Log_msg("Reloading project json file", Color.PaleGoldenrod)
                BackgroundWorker1.RunWorkerAsync()
            End If

            loadDirectories()
            If ComboBox_Directory.Items.Count > 0 Then
                ComboBox_Directory.SelectedIndex = 0
            End If
        End If
    End Sub
    'MoveToSelectedDirectory (ToolStripMenuItem) - Click
    Private Sub MoveToSelectedDirectoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MoveToSelectedDirectoryToolStripMenuItem.Click
        Button_MoveSelectedResources.PerformClick()
    End Sub
    'ContextMenuStrip_ProjectResources - Opening
    Private Sub ContextMenuStrip_ProjectResources_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip_ProjectResources.Opening
        If Not ComboBox_Directory.SelectedIndex = -1 Then
            MoveToSelectedDirectoryToolStripMenuItem.Enabled = True
        Else
            MoveToSelectedDirectoryToolStripMenuItem.Enabled = False
        End If

        If ListView_ProjectResources.SelectedItems.Count = 1 Then
            SelectAllWithThisFilePathToolStripMenuItem.Enabled = True
        Else
            SelectAllWithThisFilePathToolStripMenuItem.Enabled = False
        End If
    End Sub
    'Form1 - Resize
    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If resizeLoadlock = False Then
            'FilePath area
            RectangleShape_FilePath.Width = Panel_FilePath.Width - RectangleShape_FilePath_Padding
            TextBox_ProjectFilePath.Width = RectangleShape_FilePath.Width - TextBox_ProjectFilePath_Padding

            'log area
            RectangleShape_Log.Width = Panel_Log.Width - RectangleShape_Log_Padding
            RichTextBox_Log.Width = RectangleShape_Log.Width - RichTextBox_Log_Padding

            'Directory area
            ComboBox_Directory.Width = Panel_Directory.Width - ComboBox_Directory_Padding
            RectangleShape_NewDirectory.Width = Panel_Directory.Width - RectangleShape_NewDirectory_Padding
            TextBox_NewDirectory.Width = RectangleShape_NewDirectory.Width - TextBox_NewDirectory_Padding
        End If
    End Sub
    'Form1 - DragDrop
    Private Sub Form1_DragDrop(sender As Object, e As DragEventArgs) Handles Me.DragDrop
        Dim files() As String = CType(e.Data.GetData(DataFormats.FileDrop), String())
        If files.Length <> 0 Then
            Try
                OpenFileDialog1.FileName = files(0)
                TextBox_ProjectFilePath.Text = files(0)
                'ProjectJSON()
                If Not BackgroundWorker1.IsBusy Then
                    Log_msg("Loading project", Color.PaleGoldenrod)
                    BackgroundWorker1.RunWorkerAsync()
                End If

                loadDirectories()
                If ComboBox_Directory.Items.Count > 0 Then
                    ComboBox_Directory.SelectedIndex = 0
                End If
            Catch ex As Exception
                MsgBox("Problem opening file.", MsgBoxStyle.Critical)
            End Try
        End If
    End Sub
    'Form1 - DragEnter
    Private Sub Form1_DragEnter(sender As Object, e As DragEventArgs) Handles Me.DragEnter
        Dim files() As String = CType(e.Data.GetData(DataFormats.FileDrop), String())
        If e.Data.GetDataPresent(DataFormats.FileDrop) And Path.GetExtension(files(0)) = ".json" Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub
    'Button_MoveSelectedResources - Click
    Private Sub Button_MoveSelectedResources_Click(sender As Object, e As EventArgs) Handles Button_MoveSelectedResources.Click
        If File.Exists(TextBox_ProjectFilePath.Text) And Not ComboBox_Directory.SelectedIndex = -1 And ListView_ProjectResources.SelectedItems.Count > 0 Then
            Try
                Dim reader = New JsonTextReader(New StringReader(File.ReadAllText(TextBox_ProjectFilePath.Text)))
                reader.FloatParseHandling = FloatParseHandling.Decimal
                Dim jsonFile As JObject = JObject.Load(reader)

                For Each SelectedResource As Integer In ListView_ProjectResources.SelectedIndices
                    'Check if there is any naming collisions
                    Dim TempDirPath As String = Path.GetDirectoryName(TextBox_ProjectFilePath.Text) & "\"
                    Dim TempFilePath As String = ListView_ProjectResources.Items.Item(SelectedResource).SubItems(1).Text
                    If Not File.Exists(TempDirPath & ComboBox_Directory.SelectedItem.ToString() & "\" & Path.GetFileName(TempFilePath)) Then
                        'Move files
                        My.Computer.FileSystem.MoveFile(TempDirPath & TempFilePath, TempDirPath & ComboBox_Directory.SelectedItem.ToString() & "\" & Path.GetFileName(TempFilePath))

                        'Change ListView text
                        ListView_ProjectResources.Items.Item(SelectedResource).SubItems(1).Text = ComboBox_Directory.SelectedItem.ToString() & "\" & Path.GetFileName(TempFilePath)

                        'Change project file resources
                        jsonFile.Item("resources")("resources")(SelectedResource)("file") = (ComboBox_Directory.SelectedItem.ToString() & "\" & Path.GetFileName(TempFilePath).ToString).Replace("\", "/")

                        'Log msg moved file
                        Log_msg("File: " & TempFilePath & ", Moved to: " & ComboBox_Directory.SelectedItem.ToString() & "\" & Path.GetFileName(TempFilePath), Color.MediumSeaGreen)
                    Else
                        'Log msg could not move file
                        Log_msg("Could not move file: " & TempFilePath, Color.Tomato)
                    End If

                Next

                'Write project file
                Dim utf8WithoutBom As New System.Text.UTF8Encoding(False)
                Using sink As New StreamWriter(TextBox_ProjectFilePath.Text, False, utf8WithoutBom)
                    sink.WriteLine(jsonFile.ToString)
                End Using

                'Log msg Move operation completed
                Log_msg("Move operation completed", Color.PaleGoldenrod)

                If CheckBox_CompletionNotifications.Checked Then
                    MsgBox("Move operation completed.", MsgBoxStyle.Information)
                End If
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            End Try
        End If
    End Sub
    'ProjectJSON()
    Private Sub ProjectJSON()
        'NOT USED ANYMORE
    End Sub
    'SafeImageFromFile()
    Public Shared Function SafeImageFromFile(path As String) As Image
        Dim bytes = File.ReadAllBytes(path)
        Using ms As New MemoryStream(bytes)
            Dim img = Image.FromStream(ms)
            Return img
        End Using
    End Function
    'SelectAll (ToolStripMenuItem) - Click
    Private Sub SelectAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectAllToolStripMenuItem.Click
        ListView_ProjectResources.BeginUpdate()
        For Each item As ListViewItem In ListView_ProjectResources.Items
            item.Selected = True
        Next
        ListView_ProjectResources.EndUpdate()
    End Sub
    'SelectAllWithThisFilePath (ToolStripMenuItem) - Click
    Private Sub SelectAllWithThisFilePathToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectAllWithThisFilePathToolStripMenuItem.Click
        If ListView_ProjectResources.SelectedItems.Count = 1 Then
            Dim selectfilePath As String = Path.GetDirectoryName(ListView_ProjectResources.SelectedItems(0).SubItems(1).Text)
            ListView_ProjectResources.BeginUpdate()
            For Each item As ListViewItem In ListView_ProjectResources.Items
                If Path.GetDirectoryName(item.SubItems(1).Text) = selectfilePath Then
                    item.Selected = True
                End If
            Next
            ListView_ProjectResources.EndUpdate()
        End If
    End Sub
    'loadDirectories()
    Private Sub loadDirectories()
        Dim tempArryList As New ArrayList
        tempArryList.AddRange(Directory.GetDirectories(Path.GetDirectoryName(TextBox_ProjectFilePath.Text), "*.*", SearchOption.AllDirectories))
        ComboBox_Directory.Items.Clear()
        ComboBox_Directory.BeginUpdate()

        For Each item As String In tempArryList
            ComboBox_Directory.Items.Add(item.Replace(Path.GetDirectoryName(TextBox_ProjectFilePath.Text) & "\", ""))
        Next
        ComboBox_Directory.Sorted = True
        ComboBox_Directory.Sorted = False
        ComboBox_Directory.Items.Insert(0, "\")
        ComboBox_Directory.EndUpdate()
    End Sub
    'TextBox_NewDirectory - KeyPress
    Private Sub TextBox_NewDirectory_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_NewDirectory.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            If TextBox_NewDirectory.Text.Length > 0 And Not ComboBox_Directory.SelectedIndex = -1 Then
                e.Handled = True
                Button_CreateDirectory.PerformClick()
            End If
        End If
    End Sub
    'Button_CreateDirectory - Click
    Private Sub Button_CreateDirectory_Click(sender As Object, e As EventArgs) Handles Button_CreateDirectory.Click
        If TextBox_NewDirectory.Text.Length > 0 And Not ComboBox_Directory.SelectedIndex = -1 Then
            Try
                Dim tempDirectoryString As String = ""
                Dim tempDirectoryStringShort As String = ""
                If ComboBox_Directory.SelectedItem.ToString = "\" Then
                    tempDirectoryString = Path.GetDirectoryName(TextBox_ProjectFilePath.Text) & ComboBox_Directory.Text & TextBox_NewDirectory.Text
                    tempDirectoryStringShort = ComboBox_Directory.Text & TextBox_NewDirectory.Text
                Else
                    tempDirectoryString = Path.GetDirectoryName(TextBox_ProjectFilePath.Text) & "\" & ComboBox_Directory.Text & "\" & TextBox_NewDirectory.Text
                    tempDirectoryStringShort = "\" & ComboBox_Directory.Text & "\" & TextBox_NewDirectory.Text
                End If

                If Not Directory.Exists(tempDirectoryString) Then
                    Directory.CreateDirectory(tempDirectoryString)
                    TextBox_NewDirectory.Clear()

                    ComboBox_Directory.BeginUpdate()
                    ComboBox_Directory.Items.Add(tempDirectoryStringShort.Remove(0, 1))
                    ComboBox_Directory.Items.Remove("\")
                    ComboBox_Directory.Sorted = True
                    ComboBox_Directory.Sorted = False
                    ComboBox_Directory.Items.Insert(0, "\")
                    ComboBox_Directory.SelectedItem = tempDirectoryStringShort.Remove(0, 1)
                    ComboBox_Directory.EndUpdate()

                    'Log msg
                    Log_msg("Created Directory: " & tempDirectoryStringShort, Color.MediumSeaGreen)

                    If CheckBox_CompletionNotifications.Checked Then
                        MsgBox("Created Directory: " & tempDirectoryStringShort & vbNewLine, MsgBoxStyle.Information)
                    End If
                End If
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            End Try
        Else
            Log_msg("Could not create directory, Directory already exists", Color.Tomato)
            MsgBox("Directory already exists.", MsgBoxStyle.Information)
        End If
    End Sub
    'ComboBox_Directory - SelectedIndexChanged
    Private Sub ComboBox_Directory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_Directory.SelectedIndexChanged
        If Not ComboBox_Directory.SelectedIndex = -1 Then
            Try
                Dim tempDirectoryString As String = ""
                If ComboBox_Directory.SelectedItem.ToString = "\" Then
                    tempDirectoryString = Path.GetDirectoryName(TextBox_ProjectFilePath.Text) & ComboBox_Directory.Text
                Else
                    tempDirectoryString = Path.GetDirectoryName(TextBox_ProjectFilePath.Text) & "\" & ComboBox_Directory.Text
                End If
                If Not Directory.Exists(tempDirectoryString) Then
                    'Log msg
                    Log_msg("Directory does not exist reloading directories", Color.Tomato)

                    'Reload Directories
                    loadDirectories()

                    'Log msg
                    Log_msg("Directories reloaded", Color.PaleGoldenrod)
                End If
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            End Try
        End If
    End Sub
    'Log_msg()
    Private Sub Log_msg(msg As String, color As Color)
        RichTextBox_Log.SelectionColor = color
        RichTextBox_Log.AppendText(msg & vbNewLine)
    End Sub
    '
    'Threading
    '
    'Delegates
    Private Delegate Sub ListView_Invoker(name As String, imageIndex As Integer, filePath As String)
    Private Delegate Sub ImageList_Invoker(filePath As String)
    Private Delegate Sub LabelLoading_Invoker(currentCount As Integer, maxCount As Integer)
    'ListView_AccessControl(name, filePath)
    Private Sub ListView_AccessControl(name As String, imageIndex As Integer, filePath As String)
        If Me.InvokeRequired Then
            Invoke(New ListView_Invoker(AddressOf ListView_AccessControl), name, imageIndex, filePath)
        Else
            ListView_ProjectResources.Items.Add(name, ImageList1.Images.Count - 1).SubItems.Add(filePath)
        End If
    End Sub
    'ImageList_AccessControl(filePath)
    Private Sub ImageList_AccessControl(filePath As String)
        If Me.InvokeRequired Then
            Invoke(New ImageList_Invoker(AddressOf ImageList_AccessControl), filePath)
        Else
            ImageList1.Images.Add(SafeImageFromFile(filePath))
        End If
    End Sub
    'LabelLoading_AccessControl(CurrentCount)
    Private Sub LabelLoading_AccessControl(currentCount As Integer, maxCount As Integer)
        If Me.InvokeRequired Then
            Invoke(New LabelLoading_Invoker(AddressOf LabelLoading_AccessControl), currentCount, maxCount)
        Else
            Label_Loading.Text = "Loading Please Wait... " & Math.Ceiling(currentCount / maxCount * 100) & "%" & vbNewLine & "File " & currentCount & " of " & maxCount
        End If
    End Sub
    'StartOfLoading_AccessControl()
    Public Sub StartOfLoading_AccessControl()
        If InvokeRequired Then
            Invoke(New MethodInvoker(AddressOf StartOfLoading_AccessControl))
        Else
            Label_Loading.Text = "Loading Please Wait... "
            Label_Loading.Visible = True
            ListView_ProjectResources.Items.Clear()
            ListView_ProjectResources.BeginUpdate()
        End If
    End Sub
    'EndtOfLoading_AccessControl()
    Public Sub EndtOfLoading_AccessControl()
        If InvokeRequired Then
            Invoke(New MethodInvoker(AddressOf EndtOfLoading_AccessControl))
        Else
            ListView_ProjectResources.EndUpdate()
            Label_Loading.Visible = False
            Log_msg("Project loaded", Color.PaleGoldenrod)
        End If
    End Sub
    'BackgroundWorker1 - DoWork
    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Try
            StartOfLoading_AccessControl()
            ImageList1.Images.Clear()
            ImageList1.Images.Add(My.Resources.blank) '0
            ImageList1.Images.Add(My.Resources.json) '1
            ImageList1.Images.Add(My.Resources.webp) '2
            ImageList1.Images.Add(My.Resources.font) '3
            ImageList1.Images.Add(My.Resources.video) '4
            ImageList1.Images.Add(My.Resources.bitmap_font) '5
            ImageList1.Images.Add(My.Resources.audio) '6
            Dim jsonFile As JObject = JObject.Parse(File.ReadAllText(TextBox_ProjectFilePath.Text))
            For Each resource As JObject In jsonFile.Item("resources")("resources")
                Dim tempFilePath As String = Path.GetDirectoryName(TextBox_ProjectFilePath.Text) & "\" & resource.Item("file").ToString.Replace("/", "\")
                If File.Exists(tempFilePath) Then
                    If Path.GetExtension(tempFilePath) = ".png" Then
                        ImageList_AccessControl(tempFilePath)
                        ListView_AccessControl(resource.Item("name").ToString, ImageList1.Images.Count - 1, resource.Item("file").ToString.Replace("/", "\"))
                    ElseIf Path.GetExtension(tempFilePath) = ".json" Then
                        ListView_AccessControl(resource.Item("name").ToString, 1, resource.Item("file").ToString.Replace("/", "\"))
                    ElseIf Path.GetExtension(tempFilePath) = ".webp" Then
                        ListView_AccessControl(resource.Item("name").ToString, 2, resource.Item("file").ToString.Replace("/", "\"))
                    ElseIf Path.GetExtension(tempFilePath) = ".ttf" Or Path.GetExtension(tempFilePath) = ".otf" Then
                        ListView_AccessControl(resource.Item("name").ToString, 3, resource.Item("file").ToString.Replace("/", "\"))
                    ElseIf Path.GetExtension(tempFilePath) = ".mp4" Or Path.GetExtension(tempFilePath) = ".webm" Then
                        ListView_AccessControl(resource.Item("name").ToString, 4, resource.Item("file").ToString.Replace("/", "\"))
                    ElseIf Path.GetExtension(tempFilePath) = ".fnt" Or Path.GetExtension(tempFilePath) = ".xml" Then
                        ListView_AccessControl(resource.Item("name").ToString, 5, resource.Item("file").ToString.Replace("/", "\"))
                    ElseIf SupportedAudioFormats.Contains(Path.GetExtension(tempFilePath).ToLower) Then
                        ListView_AccessControl(resource.Item("name").ToString, 6, resource.Item("file").ToString.Replace("/", "\"))
                    Else
                        ListView_AccessControl(resource.Item("name").ToString, 0, resource.Item("file").ToString.Replace("/", "\"))
                    End If
                End If

                LabelLoading_AccessControl(ListView_ProjectResources.Items.Count, jsonFile.Item("resources")("resources").Count)

            Next
            EndtOfLoading_AccessControl()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    '
    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        'Ask the user if they would like to create a backup file
        If MessageBox.Show("Would you like to create a backup of your project file?, it's highly suggested that you do.)", "Create backup file", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Asterisk) = DialogResult.Yes Then
            'Create needed Backup folder
            If Not Directory.Exists(Path.GetDirectoryName(TextBox_ProjectFilePath.Text) & "\!BACKUP") Then
                Directory.CreateDirectory(Path.GetDirectoryName(TextBox_ProjectFilePath.Text) & "\!BACKUP")
            End If
            'Back up project file
            My.Computer.FileSystem.CopyFile(TextBox_ProjectFilePath.Text, Path.GetDirectoryName(TextBox_ProjectFilePath.Text) & "\!BACKUP\" & Path.GetFileNameWithoutExtension(TextBox_ProjectFilePath.Text) & "_" & Now.ToString("MMddyyyy_hhmmss") & "_BACKUP.json")
        End If
    End Sub
End Class