<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MapSettingsCustomizerForm
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
    Private components As ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MapSettingsCustomizerForm))
        Me.HoverToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.NewHPRelative = New System.Windows.Forms.CheckBox()
        Me.NewCSRelative = New System.Windows.Forms.CheckBox()
        Me.NewARRelative = New System.Windows.Forms.CheckBox()
        Me.NewODRelative = New System.Windows.Forms.CheckBox()
        Me.IncludeOldMaps = New System.Windows.Forms.CheckBox()
        Me.ProcessMapsButton = New System.Windows.Forms.Button()
        Me.CreateModeRadioButton = New System.Windows.Forms.RadioButton()
        Me.UpdateModeRadioButton = New System.Windows.Forms.RadioButton()
        Me.DeleteModeRadioButton = New System.Windows.Forms.RadioButton()
        Me.BatchfileSaveDialog = New System.Windows.Forms.SaveFileDialog()
        Me.osuDirectoryBrowseDialog = New System.Windows.Forms.FolderBrowserDialog()
        Me.BatchfileInfoLabel = New System.Windows.Forms.Label()
        Me.BatchfileSaveButton = New System.Windows.Forms.Button()
        Me.BatchfileGroup = New System.Windows.Forms.GroupBox()
        Me.FromOldHPBar = New System.Windows.Forms.TrackBar()
        Me.FromOldARBar = New System.Windows.Forms.TrackBar()
        Me.FromOldCSBar = New System.Windows.Forms.TrackBar()
        Me.FromOldODBar = New System.Windows.Forms.TrackBar()
        Me.FromOldHPLabel = New System.Windows.Forms.Label()
        Me.FromOldARLabel = New System.Windows.Forms.Label()
        Me.FromOldCSLabel = New System.Windows.Forms.Label()
        Me.FromOldODLabel = New System.Windows.Forms.Label()
        Me.ToOldHPBar = New System.Windows.Forms.TrackBar()
        Me.ToOldARBar = New System.Windows.Forms.TrackBar()
        Me.ToOldCSBar = New System.Windows.Forms.TrackBar()
        Me.ToOldODBar = New System.Windows.Forms.TrackBar()
        Me.ToOldHPLabel = New System.Windows.Forms.Label()
        Me.ToOldARLabel = New System.Windows.Forms.Label()
        Me.ToOldCSLabel = New System.Windows.Forms.Label()
        Me.ToOldODLabel = New System.Windows.Forms.Label()
        Me.OldHPLabel = New System.Windows.Forms.Label()
        Me.OldARLabel = New System.Windows.Forms.Label()
        Me.OldCSLabel = New System.Windows.Forms.Label()
        Me.OldODLabel = New System.Windows.Forms.Label()
        Me.OldMapsGroup = New System.Windows.Forms.GroupBox()
        Me.NewODBar = New System.Windows.Forms.TrackBar()
        Me.NewCSLabel = New System.Windows.Forms.Label()
        Me.NewARLabel = New System.Windows.Forms.Label()
        Me.NewCSBar = New System.Windows.Forms.TrackBar()
        Me.NewARBar = New System.Windows.Forms.TrackBar()
        Me.NewHPLabel = New System.Windows.Forms.Label()
        Me.NewHPBar = New System.Windows.Forms.TrackBar()
        Me.NewODLabel = New System.Windows.Forms.Label()
        Me.NewHPBox = New System.Windows.Forms.TextBox()
        Me.NewCSBox = New System.Windows.Forms.TextBox()
        Me.NewARBox = New System.Windows.Forms.TextBox()
        Me.NewODBox = New System.Windows.Forms.TextBox()
        Me.NewMapsGroup = New System.Windows.Forms.GroupBox()
        Me.NameInputBox = New System.Windows.Forms.TextBox()
        Me.ProcessMapsGroup = New System.Windows.Forms.GroupBox()
        Me.JTFInfoLabel = New System.Windows.Forms.Label()
        Me.DubuLink = New System.Windows.Forms.LinkLabel()
        Me.JTFLink = New System.Windows.Forms.LinkLabel()
        Me.DubuInfoLabel = New System.Windows.Forms.Label()
        Me.DirectoryDetectButton = New System.Windows.Forms.Button()
        Me.DirectoryBrowseButton = New System.Windows.Forms.Button()
        Me.DirectoryInputBox = New System.Windows.Forms.TextBox()
        Me.DirectoryGroup = New System.Windows.Forms.GroupBox()
        Me.BatchfileGroup.SuspendLayout()
        CType(Me.FromOldHPBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FromOldARBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FromOldCSBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FromOldODBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ToOldHPBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ToOldARBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ToOldCSBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ToOldODBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.OldMapsGroup.SuspendLayout()
        CType(Me.NewODBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NewCSBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NewARBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NewHPBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NewMapsGroup.SuspendLayout()
        Me.ProcessMapsGroup.SuspendLayout()
        Me.DirectoryGroup.SuspendLayout()
        Me.SuspendLayout()
        '
        'NewHPRelative
        '
        Me.NewHPRelative.AutoSize = True
        Me.NewHPRelative.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewHPRelative.Location = New System.Drawing.Point(297, 19)
        Me.NewHPRelative.Name = "NewHPRelative"
        Me.NewHPRelative.Size = New System.Drawing.Size(65, 17)
        Me.NewHPRelative.TabIndex = 1
        Me.NewHPRelative.Text = "Relative"
        Me.HoverToolTip.SetToolTip(Me.NewHPRelative, "Modify maps using +/- relative values.")
        Me.NewHPRelative.UseVisualStyleBackColor = True
        '
        'NewCSRelative
        '
        Me.NewCSRelative.AutoSize = True
        Me.NewCSRelative.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewCSRelative.Location = New System.Drawing.Point(297, 66)
        Me.NewCSRelative.Name = "NewCSRelative"
        Me.NewCSRelative.Size = New System.Drawing.Size(65, 17)
        Me.NewCSRelative.TabIndex = 4
        Me.NewCSRelative.Text = "Relative"
        Me.HoverToolTip.SetToolTip(Me.NewCSRelative, "Modify maps using +/- relative values.")
        Me.NewCSRelative.UseVisualStyleBackColor = True
        '
        'NewARRelative
        '
        Me.NewARRelative.AutoSize = True
        Me.NewARRelative.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewARRelative.Location = New System.Drawing.Point(297, 115)
        Me.NewARRelative.Name = "NewARRelative"
        Me.NewARRelative.Size = New System.Drawing.Size(65, 17)
        Me.NewARRelative.TabIndex = 7
        Me.NewARRelative.Text = "Relative"
        Me.HoverToolTip.SetToolTip(Me.NewARRelative, "Modify maps using +/- relative values.")
        Me.NewARRelative.UseVisualStyleBackColor = True
        '
        'NewODRelative
        '
        Me.NewODRelative.AutoSize = True
        Me.NewODRelative.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewODRelative.Location = New System.Drawing.Point(297, 162)
        Me.NewODRelative.Name = "NewODRelative"
        Me.NewODRelative.Size = New System.Drawing.Size(65, 17)
        Me.NewODRelative.TabIndex = 10
        Me.NewODRelative.Text = "Relative"
        Me.HoverToolTip.SetToolTip(Me.NewODRelative, "Modify maps using +/- relative values.")
        Me.NewODRelative.UseVisualStyleBackColor = True
        '
        'IncludeOldMaps
        '
        Me.IncludeOldMaps.AutoSize = True
        Me.IncludeOldMaps.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IncludeOldMaps.Location = New System.Drawing.Point(6, 191)
        Me.IncludeOldMaps.Name = "IncludeOldMaps"
        Me.IncludeOldMaps.Size = New System.Drawing.Size(106, 17)
        Me.IncludeOldMaps.TabIndex = 12
        Me.IncludeOldMaps.Text = "Include old maps"
        Me.HoverToolTip.SetToolTip(Me.IncludeOldMaps, "Beatmaps older than v8 use a single setting for both AR and OD." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "It will be updat" &
        "ed using the value chosen for AR.")
        Me.IncludeOldMaps.UseVisualStyleBackColor = True
        '
        'ProcessMapsButton
        '
        Me.ProcessMapsButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProcessMapsButton.Location = New System.Drawing.Point(340, 47)
        Me.ProcessMapsButton.Name = "ProcessMapsButton"
        Me.ProcessMapsButton.Size = New System.Drawing.Size(110, 23)
        Me.ProcessMapsButton.TabIndex = 4
        Me.ProcessMapsButton.Text = "Run"
        Me.HoverToolTip.SetToolTip(Me.ProcessMapsButton, "Process maps using the selected settings.")
        Me.ProcessMapsButton.UseVisualStyleBackColor = True
        '
        'CreateModeRadioButton
        '
        Me.CreateModeRadioButton.AutoSize = True
        Me.CreateModeRadioButton.Checked = True
        Me.CreateModeRadioButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.CreateModeRadioButton.Location = New System.Drawing.Point(8, 50)
        Me.CreateModeRadioButton.Name = "CreateModeRadioButton"
        Me.CreateModeRadioButton.Size = New System.Drawing.Size(56, 17)
        Me.CreateModeRadioButton.TabIndex = 1
        Me.CreateModeRadioButton.TabStop = True
        Me.CreateModeRadioButton.Text = "Create"
        Me.HoverToolTip.SetToolTip(Me.CreateModeRadioButton, "Create new maps using the name prefix and the settings above.")
        Me.CreateModeRadioButton.UseVisualStyleBackColor = True
        '
        'UpdateModeRadioButton
        '
        Me.UpdateModeRadioButton.AutoSize = True
        Me.UpdateModeRadioButton.Enabled = False
        Me.UpdateModeRadioButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.UpdateModeRadioButton.Location = New System.Drawing.Point(117, 50)
        Me.UpdateModeRadioButton.Name = "UpdateModeRadioButton"
        Me.UpdateModeRadioButton.Size = New System.Drawing.Size(60, 17)
        Me.UpdateModeRadioButton.TabIndex = 2
        Me.UpdateModeRadioButton.Text = "Update"
        Me.HoverToolTip.SetToolTip(Me.UpdateModeRadioButton, "Update existing maps matching the name prefix using the settings above.")
        Me.UpdateModeRadioButton.UseVisualStyleBackColor = True
        '
        'DeleteModeRadioButton
        '
        Me.DeleteModeRadioButton.AutoSize = True
        Me.DeleteModeRadioButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.DeleteModeRadioButton.Location = New System.Drawing.Point(226, 50)
        Me.DeleteModeRadioButton.Name = "DeleteModeRadioButton"
        Me.DeleteModeRadioButton.Size = New System.Drawing.Size(56, 17)
        Me.DeleteModeRadioButton.TabIndex = 3
        Me.DeleteModeRadioButton.Text = "Delete"
        Me.HoverToolTip.SetToolTip(Me.DeleteModeRadioButton, "Delete custom maps matching the name prefix and the settings above." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "If no prefix" &
        " is entered, ALL custom beatmaps will be deleted")
        Me.DeleteModeRadioButton.UseVisualStyleBackColor = True
        '
        'BatchfileSaveDialog
        '
        Me.BatchfileSaveDialog.DefaultExt = "bat"
        Me.BatchfileSaveDialog.Filter = "Batch file (.bat)|*.bat"
        '
        'BatchfileInfoLabel
        '
        Me.BatchfileInfoLabel.AutoSize = True
        Me.BatchfileInfoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BatchfileInfoLabel.Location = New System.Drawing.Point(6, 14)
        Me.BatchfileInfoLabel.Name = "BatchfileInfoLabel"
        Me.BatchfileInfoLabel.Size = New System.Drawing.Size(384, 26)
        Me.BatchfileInfoLabel.TabIndex = 0
        Me.BatchfileInfoLabel.Text = "You can save a batch file that will execute the program with the current settings" &
    "." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Handy for those who want to make sure their copies are up to date."
        '
        'BatchfileSaveButton
        '
        Me.BatchfileSaveButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.BatchfileSaveButton.Location = New System.Drawing.Point(340, 33)
        Me.BatchfileSaveButton.Name = "BatchfileSaveButton"
        Me.BatchfileSaveButton.Size = New System.Drawing.Size(110, 23)
        Me.BatchfileSaveButton.TabIndex = 0
        Me.BatchfileSaveButton.Text = "Save as..."
        Me.BatchfileSaveButton.UseVisualStyleBackColor = True
        '
        'BatchfileGroup
        '
        Me.BatchfileGroup.Controls.Add(Me.BatchfileSaveButton)
        Me.BatchfileGroup.Controls.Add(Me.BatchfileInfoLabel)
        Me.BatchfileGroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BatchfileGroup.Location = New System.Drawing.Point(12, 605)
        Me.BatchfileGroup.Name = "BatchfileGroup"
        Me.BatchfileGroup.Size = New System.Drawing.Size(456, 62)
        Me.BatchfileGroup.TabIndex = 4
        Me.BatchfileGroup.TabStop = False
        Me.BatchfileGroup.Text = "Create a batch (.bat) file (optional)"
        '
        'FromOldHPBar
        '
        Me.FromOldHPBar.Location = New System.Drawing.Point(109, 35)
        Me.FromOldHPBar.Maximum = 100
        Me.FromOldHPBar.Name = "FromOldHPBar"
        Me.FromOldHPBar.Size = New System.Drawing.Size(166, 45)
        Me.FromOldHPBar.TabIndex = 0
        Me.FromOldHPBar.TickFrequency = 10
        '
        'FromOldARBar
        '
        Me.FromOldARBar.Location = New System.Drawing.Point(109, 131)
        Me.FromOldARBar.Maximum = 100
        Me.FromOldARBar.Name = "FromOldARBar"
        Me.FromOldARBar.Size = New System.Drawing.Size(166, 45)
        Me.FromOldARBar.TabIndex = 4
        Me.FromOldARBar.TickFrequency = 10
        '
        'FromOldCSBar
        '
        Me.FromOldCSBar.Location = New System.Drawing.Point(109, 82)
        Me.FromOldCSBar.Maximum = 70
        Me.FromOldCSBar.Name = "FromOldCSBar"
        Me.FromOldCSBar.Size = New System.Drawing.Size(166, 45)
        Me.FromOldCSBar.TabIndex = 2
        Me.FromOldCSBar.TickFrequency = 10
        '
        'FromOldODBar
        '
        Me.FromOldODBar.Location = New System.Drawing.Point(109, 178)
        Me.FromOldODBar.Maximum = 100
        Me.FromOldODBar.Name = "FromOldODBar"
        Me.FromOldODBar.Size = New System.Drawing.Size(166, 45)
        Me.FromOldODBar.TabIndex = 6
        Me.FromOldODBar.TickFrequency = 10
        '
        'FromOldHPLabel
        '
        Me.FromOldHPLabel.AutoSize = True
        Me.FromOldHPLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FromOldHPLabel.Location = New System.Drawing.Point(106, 20)
        Me.FromOldHPLabel.Name = "FromOldHPLabel"
        Me.FromOldHPLabel.Size = New System.Drawing.Size(42, 13)
        Me.FromOldHPLabel.TabIndex = 0
        Me.FromOldHPLabel.Text = "From: 0"
        '
        'FromOldARLabel
        '
        Me.FromOldARLabel.AutoSize = True
        Me.FromOldARLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FromOldARLabel.Location = New System.Drawing.Point(106, 116)
        Me.FromOldARLabel.Name = "FromOldARLabel"
        Me.FromOldARLabel.Size = New System.Drawing.Size(42, 13)
        Me.FromOldARLabel.TabIndex = 0
        Me.FromOldARLabel.Text = "From: 0"
        '
        'FromOldCSLabel
        '
        Me.FromOldCSLabel.AutoSize = True
        Me.FromOldCSLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FromOldCSLabel.Location = New System.Drawing.Point(106, 67)
        Me.FromOldCSLabel.Name = "FromOldCSLabel"
        Me.FromOldCSLabel.Size = New System.Drawing.Size(42, 13)
        Me.FromOldCSLabel.TabIndex = 0
        Me.FromOldCSLabel.Text = "From: 0"
        '
        'FromOldODLabel
        '
        Me.FromOldODLabel.AutoSize = True
        Me.FromOldODLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FromOldODLabel.Location = New System.Drawing.Point(106, 163)
        Me.FromOldODLabel.Name = "FromOldODLabel"
        Me.FromOldODLabel.Size = New System.Drawing.Size(42, 13)
        Me.FromOldODLabel.TabIndex = 0
        Me.FromOldODLabel.Text = "From: 0"
        '
        'ToOldHPBar
        '
        Me.ToOldHPBar.Location = New System.Drawing.Point(284, 36)
        Me.ToOldHPBar.Maximum = 100
        Me.ToOldHPBar.Name = "ToOldHPBar"
        Me.ToOldHPBar.Size = New System.Drawing.Size(166, 45)
        Me.ToOldHPBar.TabIndex = 1
        Me.ToOldHPBar.TickFrequency = 10
        Me.ToOldHPBar.Value = 100
        '
        'ToOldARBar
        '
        Me.ToOldARBar.Location = New System.Drawing.Point(284, 132)
        Me.ToOldARBar.Maximum = 100
        Me.ToOldARBar.Name = "ToOldARBar"
        Me.ToOldARBar.Size = New System.Drawing.Size(166, 45)
        Me.ToOldARBar.TabIndex = 5
        Me.ToOldARBar.TickFrequency = 10
        Me.ToOldARBar.Value = 100
        '
        'ToOldCSBar
        '
        Me.ToOldCSBar.Location = New System.Drawing.Point(284, 83)
        Me.ToOldCSBar.Maximum = 100
        Me.ToOldCSBar.Name = "ToOldCSBar"
        Me.ToOldCSBar.Size = New System.Drawing.Size(166, 45)
        Me.ToOldCSBar.TabIndex = 3
        Me.ToOldCSBar.TickFrequency = 10
        Me.ToOldCSBar.Value = 100
        '
        'ToOldODBar
        '
        Me.ToOldODBar.Location = New System.Drawing.Point(284, 179)
        Me.ToOldODBar.Maximum = 100
        Me.ToOldODBar.Name = "ToOldODBar"
        Me.ToOldODBar.Size = New System.Drawing.Size(166, 45)
        Me.ToOldODBar.TabIndex = 7
        Me.ToOldODBar.TickFrequency = 10
        Me.ToOldODBar.Value = 100
        '
        'ToOldHPLabel
        '
        Me.ToOldHPLabel.AutoSize = True
        Me.ToOldHPLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToOldHPLabel.Location = New System.Drawing.Point(281, 20)
        Me.ToOldHPLabel.Name = "ToOldHPLabel"
        Me.ToOldHPLabel.Size = New System.Drawing.Size(38, 13)
        Me.ToOldHPLabel.TabIndex = 0
        Me.ToOldHPLabel.Text = "To: 10"
        '
        'ToOldARLabel
        '
        Me.ToOldARLabel.AutoSize = True
        Me.ToOldARLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToOldARLabel.Location = New System.Drawing.Point(281, 116)
        Me.ToOldARLabel.Name = "ToOldARLabel"
        Me.ToOldARLabel.Size = New System.Drawing.Size(38, 13)
        Me.ToOldARLabel.TabIndex = 0
        Me.ToOldARLabel.Text = "To: 10"
        '
        'ToOldCSLabel
        '
        Me.ToOldCSLabel.AutoSize = True
        Me.ToOldCSLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToOldCSLabel.Location = New System.Drawing.Point(281, 67)
        Me.ToOldCSLabel.Name = "ToOldCSLabel"
        Me.ToOldCSLabel.Size = New System.Drawing.Size(38, 13)
        Me.ToOldCSLabel.TabIndex = 0
        Me.ToOldCSLabel.Text = "To: 10"
        '
        'ToOldODLabel
        '
        Me.ToOldODLabel.AutoSize = True
        Me.ToOldODLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToOldODLabel.Location = New System.Drawing.Point(281, 163)
        Me.ToOldODLabel.Name = "ToOldODLabel"
        Me.ToOldODLabel.Size = New System.Drawing.Size(38, 13)
        Me.ToOldODLabel.TabIndex = 0
        Me.ToOldODLabel.Text = "To: 10"
        '
        'OldHPLabel
        '
        Me.OldHPLabel.AutoSize = True
        Me.OldHPLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OldHPLabel.Location = New System.Drawing.Point(9, 20)
        Me.OldHPLabel.Name = "OldHPLabel"
        Me.OldHPLabel.Size = New System.Drawing.Size(76, 13)
        Me.OldHPLabel.TabIndex = 0
        Me.OldHPLabel.Text = "HP Drain Rate"
        '
        'OldARLabel
        '
        Me.OldARLabel.AutoSize = True
        Me.OldARLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OldARLabel.Location = New System.Drawing.Point(9, 116)
        Me.OldARLabel.Name = "OldARLabel"
        Me.OldARLabel.Size = New System.Drawing.Size(79, 13)
        Me.OldARLabel.TabIndex = 0
        Me.OldARLabel.Text = "Approach Rate"
        '
        'OldCSLabel
        '
        Me.OldCSLabel.AutoSize = True
        Me.OldCSLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OldCSLabel.Location = New System.Drawing.Point(9, 67)
        Me.OldCSLabel.Name = "OldCSLabel"
        Me.OldCSLabel.Size = New System.Drawing.Size(56, 13)
        Me.OldCSLabel.TabIndex = 0
        Me.OldCSLabel.Text = "Circle Size"
        '
        'OldODLabel
        '
        Me.OldODLabel.AutoSize = True
        Me.OldODLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OldODLabel.Location = New System.Drawing.Point(9, 163)
        Me.OldODLabel.Name = "OldODLabel"
        Me.OldODLabel.Size = New System.Drawing.Size(83, 13)
        Me.OldODLabel.TabIndex = 0
        Me.OldODLabel.Text = "Overall Difficulty"
        '
        'OldMapsGroup
        '
        Me.OldMapsGroup.Controls.Add(Me.OldODLabel)
        Me.OldMapsGroup.Controls.Add(Me.OldCSLabel)
        Me.OldMapsGroup.Controls.Add(Me.OldARLabel)
        Me.OldMapsGroup.Controls.Add(Me.OldHPLabel)
        Me.OldMapsGroup.Controls.Add(Me.ToOldODLabel)
        Me.OldMapsGroup.Controls.Add(Me.ToOldCSLabel)
        Me.OldMapsGroup.Controls.Add(Me.ToOldARLabel)
        Me.OldMapsGroup.Controls.Add(Me.ToOldHPLabel)
        Me.OldMapsGroup.Controls.Add(Me.ToOldODBar)
        Me.OldMapsGroup.Controls.Add(Me.ToOldCSBar)
        Me.OldMapsGroup.Controls.Add(Me.ToOldARBar)
        Me.OldMapsGroup.Controls.Add(Me.ToOldHPBar)
        Me.OldMapsGroup.Controls.Add(Me.FromOldODLabel)
        Me.OldMapsGroup.Controls.Add(Me.FromOldCSLabel)
        Me.OldMapsGroup.Controls.Add(Me.FromOldARLabel)
        Me.OldMapsGroup.Controls.Add(Me.FromOldHPLabel)
        Me.OldMapsGroup.Controls.Add(Me.FromOldODBar)
        Me.OldMapsGroup.Controls.Add(Me.FromOldCSBar)
        Me.OldMapsGroup.Controls.Add(Me.FromOldARBar)
        Me.OldMapsGroup.Controls.Add(Me.FromOldHPBar)
        Me.OldMapsGroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OldMapsGroup.Location = New System.Drawing.Point(12, 65)
        Me.OldMapsGroup.Name = "OldMapsGroup"
        Me.OldMapsGroup.Size = New System.Drawing.Size(456, 232)
        Me.OldMapsGroup.TabIndex = 1
        Me.OldMapsGroup.TabStop = False
        Me.OldMapsGroup.Text = "Include maps matching these settings:"
        '
        'NewODBar
        '
        Me.NewODBar.Location = New System.Drawing.Point(109, 162)
        Me.NewODBar.Maximum = 100
        Me.NewODBar.Name = "NewODBar"
        Me.NewODBar.Size = New System.Drawing.Size(166, 45)
        Me.NewODBar.TabIndex = 9
        Me.NewODBar.TickFrequency = 10
        Me.NewODBar.Value = 100
        '
        'NewCSLabel
        '
        Me.NewCSLabel.AutoSize = True
        Me.NewCSLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewCSLabel.Location = New System.Drawing.Point(6, 66)
        Me.NewCSLabel.Name = "NewCSLabel"
        Me.NewCSLabel.Size = New System.Drawing.Size(56, 13)
        Me.NewCSLabel.TabIndex = 0
        Me.NewCSLabel.Text = "Circle Size"
        '
        'NewARLabel
        '
        Me.NewARLabel.AutoSize = True
        Me.NewARLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewARLabel.Location = New System.Drawing.Point(6, 115)
        Me.NewARLabel.Name = "NewARLabel"
        Me.NewARLabel.Size = New System.Drawing.Size(79, 13)
        Me.NewARLabel.TabIndex = 0
        Me.NewARLabel.Text = "Approach Rate"
        '
        'NewCSBar
        '
        Me.NewCSBar.Location = New System.Drawing.Point(109, 66)
        Me.NewCSBar.Maximum = 100
        Me.NewCSBar.Name = "NewCSBar"
        Me.NewCSBar.Size = New System.Drawing.Size(166, 45)
        Me.NewCSBar.TabIndex = 3
        Me.NewCSBar.TickFrequency = 10
        Me.NewCSBar.Value = 40
        '
        'NewARBar
        '
        Me.NewARBar.Location = New System.Drawing.Point(109, 115)
        Me.NewARBar.Maximum = 100
        Me.NewARBar.Name = "NewARBar"
        Me.NewARBar.Size = New System.Drawing.Size(166, 45)
        Me.NewARBar.TabIndex = 6
        Me.NewARBar.TickFrequency = 10
        Me.NewARBar.Value = 90
        '
        'NewHPLabel
        '
        Me.NewHPLabel.AutoSize = True
        Me.NewHPLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewHPLabel.Location = New System.Drawing.Point(6, 19)
        Me.NewHPLabel.Name = "NewHPLabel"
        Me.NewHPLabel.Size = New System.Drawing.Size(76, 13)
        Me.NewHPLabel.TabIndex = 0
        Me.NewHPLabel.Text = "HP Drain Rate"
        '
        'NewHPBar
        '
        Me.NewHPBar.Location = New System.Drawing.Point(109, 19)
        Me.NewHPBar.Maximum = 100
        Me.NewHPBar.Name = "NewHPBar"
        Me.NewHPBar.Size = New System.Drawing.Size(166, 45)
        Me.NewHPBar.TabIndex = 0
        Me.NewHPBar.TickFrequency = 10
        Me.NewHPBar.Value = 50
        '
        'NewODLabel
        '
        Me.NewODLabel.AutoSize = True
        Me.NewODLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewODLabel.Location = New System.Drawing.Point(6, 162)
        Me.NewODLabel.Name = "NewODLabel"
        Me.NewODLabel.Size = New System.Drawing.Size(83, 13)
        Me.NewODLabel.TabIndex = 0
        Me.NewODLabel.Text = "Overall Difficulty"
        '
        'NewHPBox
        '
        Me.NewHPBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.NewHPBox.Location = New System.Drawing.Point(297, 40)
        Me.NewHPBox.Name = "NewHPBox"
        Me.NewHPBox.Size = New System.Drawing.Size(140, 20)
        Me.NewHPBox.TabIndex = 2
        Me.NewHPBox.Text = "5"
        '
        'NewCSBox
        '
        Me.NewCSBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.NewCSBox.Location = New System.Drawing.Point(297, 85)
        Me.NewCSBox.Name = "NewCSBox"
        Me.NewCSBox.Size = New System.Drawing.Size(140, 20)
        Me.NewCSBox.TabIndex = 5
        Me.NewCSBox.Text = "4"
        '
        'NewARBox
        '
        Me.NewARBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.NewARBox.Location = New System.Drawing.Point(297, 134)
        Me.NewARBox.Name = "NewARBox"
        Me.NewARBox.Size = New System.Drawing.Size(140, 20)
        Me.NewARBox.TabIndex = 8
        Me.NewARBox.Text = "9"
        '
        'NewODBox
        '
        Me.NewODBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.NewODBox.Location = New System.Drawing.Point(297, 181)
        Me.NewODBox.Name = "NewODBox"
        Me.NewODBox.Size = New System.Drawing.Size(140, 20)
        Me.NewODBox.TabIndex = 11
        Me.NewODBox.Text = "10"
        '
        'NewMapsGroup
        '
        Me.NewMapsGroup.Controls.Add(Me.IncludeOldMaps)
        Me.NewMapsGroup.Controls.Add(Me.NewODBox)
        Me.NewMapsGroup.Controls.Add(Me.NewARBox)
        Me.NewMapsGroup.Controls.Add(Me.NewCSBox)
        Me.NewMapsGroup.Controls.Add(Me.NewHPBox)
        Me.NewMapsGroup.Controls.Add(Me.NewODRelative)
        Me.NewMapsGroup.Controls.Add(Me.NewARRelative)
        Me.NewMapsGroup.Controls.Add(Me.NewCSRelative)
        Me.NewMapsGroup.Controls.Add(Me.NewHPRelative)
        Me.NewMapsGroup.Controls.Add(Me.NewODLabel)
        Me.NewMapsGroup.Controls.Add(Me.NewHPBar)
        Me.NewMapsGroup.Controls.Add(Me.NewHPLabel)
        Me.NewMapsGroup.Controls.Add(Me.NewARBar)
        Me.NewMapsGroup.Controls.Add(Me.NewCSBar)
        Me.NewMapsGroup.Controls.Add(Me.NewARLabel)
        Me.NewMapsGroup.Controls.Add(Me.NewCSLabel)
        Me.NewMapsGroup.Controls.Add(Me.NewODBar)
        Me.NewMapsGroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewMapsGroup.Location = New System.Drawing.Point(12, 303)
        Me.NewMapsGroup.Name = "NewMapsGroup"
        Me.NewMapsGroup.Size = New System.Drawing.Size(456, 214)
        Me.NewMapsGroup.TabIndex = 2
        Me.NewMapsGroup.TabStop = False
        Me.NewMapsGroup.Text = "Create/Update maps using these settings:"
        '
        'NameInputBox
        '
        Me.NameInputBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameInputBox.Location = New System.Drawing.Point(8, 19)
        Me.NameInputBox.Name = "NameInputBox"
        Me.NameInputBox.Size = New System.Drawing.Size(280, 20)
        Me.NameInputBox.TabIndex = 0
        '
        'ProcessMapsGroup
        '
        Me.ProcessMapsGroup.Controls.Add(Me.DeleteModeRadioButton)
        Me.ProcessMapsGroup.Controls.Add(Me.UpdateModeRadioButton)
        Me.ProcessMapsGroup.Controls.Add(Me.CreateModeRadioButton)
        Me.ProcessMapsGroup.Controls.Add(Me.NameInputBox)
        Me.ProcessMapsGroup.Controls.Add(Me.ProcessMapsButton)
        Me.ProcessMapsGroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProcessMapsGroup.Location = New System.Drawing.Point(12, 523)
        Me.ProcessMapsGroup.Name = "ProcessMapsGroup"
        Me.ProcessMapsGroup.Size = New System.Drawing.Size(456, 76)
        Me.ProcessMapsGroup.TabIndex = 3
        Me.ProcessMapsGroup.TabStop = False
        Me.ProcessMapsGroup.Text = "Beatmap name prefix:"
        '
        'JTFInfoLabel
        '
        Me.JTFInfoLabel.AutoSize = True
        Me.JTFInfoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.JTFInfoLabel.Location = New System.Drawing.Point(9, 673)
        Me.JTFInfoLabel.Name = "JTFInfoLabel"
        Me.JTFInfoLabel.Size = New System.Drawing.Size(187, 13)
        Me.JTFInfoLabel.TabIndex = 0
        Me.JTFInfoLabel.Text = "If you have any questions contact me:"
        '
        'DubuLink
        '
        Me.DubuLink.AutoSize = True
        Me.DubuLink.Location = New System.Drawing.Point(88, 690)
        Me.DubuLink.Name = "DubuLink"
        Me.DubuLink.Size = New System.Drawing.Size(33, 13)
        Me.DubuLink.TabIndex = 6
        Me.DubuLink.TabStop = True
        Me.DubuLink.Text = "Dubu"
        '
        'JTFLink
        '
        Me.JTFLink.AutoSize = True
        Me.JTFLink.Location = New System.Drawing.Point(197, 674)
        Me.JTFLink.Name = "JTFLink"
        Me.JTFLink.Size = New System.Drawing.Size(43, 13)
        Me.JTFLink.TabIndex = 5
        Me.JTFLink.TabStop = True
        Me.JTFLink.Text = "JTF195"
        '
        'DubuInfoLabel
        '
        Me.DubuInfoLabel.AutoSize = True
        Me.DubuInfoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DubuInfoLabel.Location = New System.Drawing.Point(9, 689)
        Me.DubuInfoLabel.Name = "DubuInfoLabel"
        Me.DubuInfoLabel.Size = New System.Drawing.Size(78, 13)
        Me.DubuInfoLabel.TabIndex = 0
        Me.DubuInfoLabel.Text = "Original author:"
        '
        'DirectoryDetectButton
        '
        Me.DirectoryDetectButton.BackColor = System.Drawing.Color.Transparent
        Me.DirectoryDetectButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.DirectoryDetectButton.Location = New System.Drawing.Point(294, 19)
        Me.DirectoryDetectButton.Name = "DirectoryDetectButton"
        Me.DirectoryDetectButton.Size = New System.Drawing.Size(75, 22)
        Me.DirectoryDetectButton.TabIndex = 1
        Me.DirectoryDetectButton.Text = "Detect"
        Me.DirectoryDetectButton.UseVisualStyleBackColor = True
        '
        'DirectoryBrowseButton
        '
        Me.DirectoryBrowseButton.BackColor = System.Drawing.Color.Transparent
        Me.DirectoryBrowseButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.DirectoryBrowseButton.Location = New System.Drawing.Point(375, 19)
        Me.DirectoryBrowseButton.Name = "DirectoryBrowseButton"
        Me.DirectoryBrowseButton.Size = New System.Drawing.Size(75, 22)
        Me.DirectoryBrowseButton.TabIndex = 2
        Me.DirectoryBrowseButton.Text = "Browse..."
        Me.DirectoryBrowseButton.UseVisualStyleBackColor = True
        '
        'DirectoryInputBox
        '
        Me.DirectoryInputBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.DirectoryInputBox.Location = New System.Drawing.Point(8, 20)
        Me.DirectoryInputBox.Name = "DirectoryInputBox"
        Me.DirectoryInputBox.Size = New System.Drawing.Size(280, 20)
        Me.DirectoryInputBox.TabIndex = 0
        '
        'DirectoryGroup
        '
        Me.DirectoryGroup.Controls.Add(Me.DirectoryInputBox)
        Me.DirectoryGroup.Controls.Add(Me.DirectoryBrowseButton)
        Me.DirectoryGroup.Controls.Add(Me.DirectoryDetectButton)
        Me.DirectoryGroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.DirectoryGroup.Location = New System.Drawing.Point(12, 12)
        Me.DirectoryGroup.Name = "DirectoryGroup"
        Me.DirectoryGroup.Size = New System.Drawing.Size(456, 47)
        Me.DirectoryGroup.TabIndex = 0
        Me.DirectoryGroup.TabStop = False
        Me.DirectoryGroup.Text = "Songs directory:"
        '
        'MapSettingsCustomizerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(481, 709)
        Me.Controls.Add(Me.DirectoryGroup)
        Me.Controls.Add(Me.DubuInfoLabel)
        Me.Controls.Add(Me.JTFLink)
        Me.Controls.Add(Me.DubuLink)
        Me.Controls.Add(Me.JTFInfoLabel)
        Me.Controls.Add(Me.ProcessMapsGroup)
        Me.Controls.Add(Me.NewMapsGroup)
        Me.Controls.Add(Me.OldMapsGroup)
        Me.Controls.Add(Me.BatchfileGroup)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(497, 748)
        Me.Name = "MapSettingsCustomizerForm"
        Me.Text = "osu! Map Settings Customizer 2.0"
        Me.BatchfileGroup.ResumeLayout(False)
        Me.BatchfileGroup.PerformLayout()
        CType(Me.FromOldHPBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FromOldARBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FromOldCSBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FromOldODBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ToOldHPBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ToOldARBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ToOldCSBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ToOldODBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.OldMapsGroup.ResumeLayout(False)
        Me.OldMapsGroup.PerformLayout()
        CType(Me.NewODBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NewCSBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NewARBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NewHPBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NewMapsGroup.ResumeLayout(False)
        Me.NewMapsGroup.PerformLayout()
        Me.ProcessMapsGroup.ResumeLayout(False)
        Me.ProcessMapsGroup.PerformLayout()
        Me.DirectoryGroup.ResumeLayout(False)
        Me.DirectoryGroup.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents HoverToolTip As ToolTip
    Friend WithEvents BatchfileSaveDialog As SaveFileDialog
    Friend WithEvents osuDirectoryBrowseDialog As FolderBrowserDialog
    Friend WithEvents BatchfileInfoLabel As Label
    Friend WithEvents BatchfileSaveButton As Button
    Friend WithEvents BatchfileGroup As GroupBox
    Friend WithEvents FromOldHPBar As TrackBar
    Friend WithEvents FromOldARBar As TrackBar
    Friend WithEvents FromOldCSBar As TrackBar
    Friend WithEvents FromOldODBar As TrackBar
    Friend WithEvents FromOldHPLabel As Label
    Friend WithEvents FromOldARLabel As Label
    Friend WithEvents FromOldCSLabel As Label
    Friend WithEvents FromOldODLabel As Label
    Friend WithEvents ToOldHPBar As TrackBar
    Friend WithEvents ToOldARBar As TrackBar
    Friend WithEvents ToOldCSBar As TrackBar
    Friend WithEvents ToOldODBar As TrackBar
    Friend WithEvents ToOldHPLabel As Label
    Friend WithEvents ToOldARLabel As Label
    Friend WithEvents ToOldCSLabel As Label
    Friend WithEvents ToOldODLabel As Label
    Friend WithEvents OldHPLabel As Label
    Friend WithEvents OldARLabel As Label
    Friend WithEvents OldCSLabel As Label
    Friend WithEvents OldODLabel As Label
    Friend WithEvents OldMapsGroup As GroupBox
    Friend WithEvents NewODBar As TrackBar
    Friend WithEvents NewCSLabel As Label
    Friend WithEvents NewARLabel As Label
    Friend WithEvents NewCSBar As TrackBar
    Friend WithEvents NewARBar As TrackBar
    Friend WithEvents NewHPLabel As Label
    Friend WithEvents NewHPBar As TrackBar
    Friend WithEvents NewODLabel As Label
    Friend WithEvents NewHPRelative As CheckBox
    Friend WithEvents NewCSRelative As CheckBox
    Friend WithEvents NewARRelative As CheckBox
    Friend WithEvents NewODRelative As CheckBox
    Friend WithEvents NewHPBox As TextBox
    Friend WithEvents NewCSBox As TextBox
    Friend WithEvents NewARBox As TextBox
    Friend WithEvents NewODBox As TextBox
    Friend WithEvents IncludeOldMaps As CheckBox
    Friend WithEvents NewMapsGroup As GroupBox
    Friend WithEvents ProcessMapsButton As Button
    Friend WithEvents NameInputBox As TextBox
    Friend WithEvents CreateModeRadioButton As RadioButton
    Friend WithEvents UpdateModeRadioButton As RadioButton
    Friend WithEvents DeleteModeRadioButton As RadioButton
    Friend WithEvents ProcessMapsGroup As GroupBox
    Friend WithEvents JTFInfoLabel As Label
    Friend WithEvents DubuLink As LinkLabel
    Friend WithEvents JTFLink As LinkLabel
    Friend WithEvents DubuInfoLabel As Label
    Friend WithEvents DirectoryDetectButton As Button
    Friend WithEvents DirectoryBrowseButton As Button
    Friend WithEvents DirectoryInputBox As TextBox
    Friend WithEvents DirectoryGroup As GroupBox
End Class
