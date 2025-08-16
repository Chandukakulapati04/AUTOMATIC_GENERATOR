<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AUTO_GENERATOR
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AUTO_GENERATOR))
        Me.OpcDaCom1 = New AdvancedHMIDrivers.OpcDaCom(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Motor1 = New AdvancedHMIControls.Motor()
        Me.BasicLabel1 = New AdvancedHMIControls.BasicLabel()
        Me.BasicIndicator1 = New AdvancedHMIControls.BasicIndicator()
        Me.BasicIndicator2 = New AdvancedHMIControls.BasicIndicator()
        Me.BasicIndicator3 = New AdvancedHMIControls.BasicIndicator()
        Me.BasicLabel3 = New AdvancedHMIControls.BasicLabel()
        Me.BasicLabel4 = New AdvancedHMIControls.BasicLabel()
        Me.MeterCompact1 = New AdvancedHMIControls.MeterCompact()
        Me.PilotLight1 = New AdvancedHMIControls.PilotLight()
        Me.PilotLight2 = New AdvancedHMIControls.PilotLight()
        Me.MomentaryButton1 = New AdvancedHMIControls.MomentaryButton()
        Me.MomentaryButton2 = New AdvancedHMIControls.MomentaryButton()
        Me.BasicLabel2 = New AdvancedHMIControls.BasicLabel()
        Me.BasicIndicator4 = New AdvancedHMIControls.BasicIndicator()
        Me.BasicLabel5 = New AdvancedHMIControls.BasicLabel()
        Me.SoundPlayer1 = New AdvancedHMIControls.SoundPlayer()
        Me.BasicLabel6 = New AdvancedHMIControls.BasicLabel()
        Me.BasicIndicator5 = New AdvancedHMIControls.BasicIndicator()
        Me.BasicLabel7 = New AdvancedHMIControls.BasicLabel()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SoundPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OpcDaCom1
        '
        Me.OpcDaCom1.DisableSubscriptions = False
        Me.OpcDaCom1.OPCGroup = ""
        Me.OpcDaCom1.OPCServer = "RsLinx OPC Server"
        Me.OpcDaCom1.OPCServerPath = "opcda://localhost"
        Me.OpcDaCom1.OPCTopic = "AUTOGENE"
        Me.OpcDaCom1.PollRateOverride = 500
        Me.OpcDaCom1.SynchronizingObject = Me
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Image = Global.MfgControl.AdvancedHMI.My.Resources.Resources.AdvancedHMILogoBR
        Me.PictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox1.Location = New System.Drawing.Point(834, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(322, 47)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 71
        Me.PictureBox1.TabStop = False
        '
        'Motor1
        '
        Me.Motor1.ComComponent = Me.OpcDaCom1
        Me.Motor1.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.Motor1.LightColor = MfgControl.AdvancedHMI.Controls.Motor.LightColors.Green
        Me.Motor1.Location = New System.Drawing.Point(319, 485)
        Me.Motor1.Name = "Motor1"
        Me.Motor1.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.Motor1.PLCAddressClick = ""
        Me.Motor1.PLCAddressText = ""
        Me.Motor1.PLCAddressValue = "O:0/0"
        Me.Motor1.PLCAddressVisible = ""
        Me.Motor1.Rotation = System.Drawing.RotateFlipType.RotateNoneFlipNone
        Me.Motor1.Size = New System.Drawing.Size(316, 214)
        Me.Motor1.TabIndex = 72
        Me.Motor1.Value = False
        '
        'BasicLabel1
        '
        Me.BasicLabel1.BackColor = System.Drawing.Color.Black
        Me.BasicLabel1.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.BasicLabel1.ComComponent = Me.OpcDaCom1
        Me.BasicLabel1.DisplayAsTime = False
        Me.BasicLabel1.Font = New System.Drawing.Font("Arial", 15.0!, System.Drawing.FontStyle.Bold)
        Me.BasicLabel1.ForeColor = System.Drawing.Color.White
        Me.BasicLabel1.Highlight = False
        Me.BasicLabel1.HighlightColor = System.Drawing.Color.Red
        Me.BasicLabel1.HighlightForeColor = System.Drawing.Color.White
        Me.BasicLabel1.HighlightKeyCharacter = "!"
        Me.BasicLabel1.InterpretValueAsBCD = False
        Me.BasicLabel1.KeypadAlphaNumeric = False
        Me.BasicLabel1.KeypadFont = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.BasicLabel1.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel1.KeypadMaxValue = 0R
        Me.BasicLabel1.KeypadMinValue = 0R
        Me.BasicLabel1.KeypadScaleFactor = 1.0R
        Me.BasicLabel1.KeypadShowCurrentValue = False
        Me.BasicLabel1.KeypadText = Nothing
        Me.BasicLabel1.KeypadWidth = 300
        Me.BasicLabel1.Location = New System.Drawing.Point(391, 720)
        Me.BasicLabel1.Name = "BasicLabel1"
        Me.BasicLabel1.NumericFormat = Nothing
        Me.BasicLabel1.PLCAddressKeypad = ""
        Me.BasicLabel1.PollRate = 0
        Me.BasicLabel1.Size = New System.Drawing.Size(307, 49)
        Me.BasicLabel1.TabIndex = 73
        Me.BasicLabel1.Text = "GENERATOR"
        Me.BasicLabel1.Value = "GENERATOR"
        Me.BasicLabel1.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(32)
        Me.BasicLabel1.ValueLeftPadLength = 0
        Me.BasicLabel1.ValuePrefix = Nothing
        Me.BasicLabel1.ValueScaleFactor = 1.0R
        Me.BasicLabel1.ValueSuffix = Nothing
        Me.BasicLabel1.ValueToSubtractFrom = 0!
        '
        'BasicIndicator1
        '
        Me.BasicIndicator1.Color1 = System.Drawing.Color.DarkGray
        Me.BasicIndicator1.Color2 = System.Drawing.Color.Green
        Me.BasicIndicator1.Color3 = System.Drawing.Color.Red
        Me.BasicIndicator1.ComComponent = Me.OpcDaCom1
        Me.BasicIndicator1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BasicIndicator1.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.BasicIndicator1.Location = New System.Drawing.Point(929, 348)
        Me.BasicIndicator1.Name = "BasicIndicator1"
        Me.BasicIndicator1.OutlineColor = System.Drawing.Color.Transparent
        Me.BasicIndicator1.OutlineWidth = 1
        Me.BasicIndicator1.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicIndicator1.PLCAddressSelectColor3 = "B3:3/10"
        Me.BasicIndicator1.SelectColor2 = False
        Me.BasicIndicator1.SelectColor3 = False
        Me.BasicIndicator1.Shape = MfgControl.AdvancedHMI.Controls.Indicator.ShapeTypes.Round
        Me.BasicIndicator1.Size = New System.Drawing.Size(81, 80)
        Me.BasicIndicator1.TabIndex = 78
        '
        'BasicIndicator2
        '
        Me.BasicIndicator2.Color1 = System.Drawing.Color.DarkGray
        Me.BasicIndicator2.Color2 = System.Drawing.Color.Green
        Me.BasicIndicator2.Color3 = System.Drawing.Color.Red
        Me.BasicIndicator2.ComComponent = Me.OpcDaCom1
        Me.BasicIndicator2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BasicIndicator2.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.BasicIndicator2.Location = New System.Drawing.Point(639, 106)
        Me.BasicIndicator2.Name = "BasicIndicator2"
        Me.BasicIndicator2.OutlineColor = System.Drawing.Color.Transparent
        Me.BasicIndicator2.OutlineWidth = 1
        Me.BasicIndicator2.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicIndicator2.PLCAddressSelectColor2 = "B3:0/0"
        Me.BasicIndicator2.SelectColor2 = False
        Me.BasicIndicator2.SelectColor3 = False
        Me.BasicIndicator2.Shape = MfgControl.AdvancedHMI.Controls.Indicator.ShapeTypes.Round
        Me.BasicIndicator2.Size = New System.Drawing.Size(81, 80)
        Me.BasicIndicator2.TabIndex = 79
        '
        'BasicIndicator3
        '
        Me.BasicIndicator3.Color1 = System.Drawing.Color.DarkGray
        Me.BasicIndicator3.Color2 = System.Drawing.Color.Green
        Me.BasicIndicator3.Color3 = System.Drawing.Color.Red
        Me.BasicIndicator3.ComComponent = Me.OpcDaCom1
        Me.BasicIndicator3.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BasicIndicator3.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.BasicIndicator3.Location = New System.Drawing.Point(639, 234)
        Me.BasicIndicator3.Name = "BasicIndicator3"
        Me.BasicIndicator3.OutlineColor = System.Drawing.Color.Transparent
        Me.BasicIndicator3.OutlineWidth = 1
        Me.BasicIndicator3.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicIndicator3.PLCAddressSelectColor3 = "B3:0/0"
        Me.BasicIndicator3.SelectColor2 = False
        Me.BasicIndicator3.SelectColor3 = False
        Me.BasicIndicator3.Shape = MfgControl.AdvancedHMI.Controls.Indicator.ShapeTypes.Round
        Me.BasicIndicator3.Size = New System.Drawing.Size(81, 80)
        Me.BasicIndicator3.TabIndex = 80
        '
        'BasicLabel3
        '
        Me.BasicLabel3.BackColor = System.Drawing.Color.Black
        Me.BasicLabel3.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.BasicLabel3.ComComponent = Me.OpcDaCom1
        Me.BasicLabel3.DisplayAsTime = False
        Me.BasicLabel3.Font = New System.Drawing.Font("Arial", 15.0!, System.Drawing.FontStyle.Bold)
        Me.BasicLabel3.ForeColor = System.Drawing.Color.White
        Me.BasicLabel3.Highlight = False
        Me.BasicLabel3.HighlightColor = System.Drawing.Color.Red
        Me.BasicLabel3.HighlightForeColor = System.Drawing.Color.White
        Me.BasicLabel3.HighlightKeyCharacter = "!"
        Me.BasicLabel3.InterpretValueAsBCD = False
        Me.BasicLabel3.KeypadAlphaNumeric = False
        Me.BasicLabel3.KeypadFont = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.BasicLabel3.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel3.KeypadMaxValue = 0R
        Me.BasicLabel3.KeypadMinValue = 0R
        Me.BasicLabel3.KeypadScaleFactor = 1.0R
        Me.BasicLabel3.KeypadShowCurrentValue = False
        Me.BasicLabel3.KeypadText = Nothing
        Me.BasicLabel3.KeypadWidth = 300
        Me.BasicLabel3.Location = New System.Drawing.Point(598, 189)
        Me.BasicLabel3.Name = "BasicLabel3"
        Me.BasicLabel3.NumericFormat = Nothing
        Me.BasicLabel3.PLCAddressKeypad = ""
        Me.BasicLabel3.PollRate = 0
        Me.BasicLabel3.Size = New System.Drawing.Size(176, 25)
        Me.BasicLabel3.TabIndex = 81
        Me.BasicLabel3.Text = "SYSTEM ON"
        Me.BasicLabel3.Value = "SYSTEM ON"
        Me.BasicLabel3.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(32)
        Me.BasicLabel3.ValueLeftPadLength = 0
        Me.BasicLabel3.ValuePrefix = Nothing
        Me.BasicLabel3.ValueScaleFactor = 1.0R
        Me.BasicLabel3.ValueSuffix = Nothing
        Me.BasicLabel3.ValueToSubtractFrom = 0!
        '
        'BasicLabel4
        '
        Me.BasicLabel4.BackColor = System.Drawing.Color.Black
        Me.BasicLabel4.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.BasicLabel4.ComComponent = Me.OpcDaCom1
        Me.BasicLabel4.DisplayAsTime = False
        Me.BasicLabel4.Font = New System.Drawing.Font("Arial", 15.0!, System.Drawing.FontStyle.Bold)
        Me.BasicLabel4.ForeColor = System.Drawing.Color.White
        Me.BasicLabel4.Highlight = False
        Me.BasicLabel4.HighlightColor = System.Drawing.Color.Red
        Me.BasicLabel4.HighlightForeColor = System.Drawing.Color.White
        Me.BasicLabel4.HighlightKeyCharacter = "!"
        Me.BasicLabel4.InterpretValueAsBCD = False
        Me.BasicLabel4.KeypadAlphaNumeric = False
        Me.BasicLabel4.KeypadFont = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.BasicLabel4.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel4.KeypadMaxValue = 0R
        Me.BasicLabel4.KeypadMinValue = 0R
        Me.BasicLabel4.KeypadScaleFactor = 1.0R
        Me.BasicLabel4.KeypadShowCurrentValue = False
        Me.BasicLabel4.KeypadText = Nothing
        Me.BasicLabel4.KeypadWidth = 300
        Me.BasicLabel4.Location = New System.Drawing.Point(598, 328)
        Me.BasicLabel4.Name = "BasicLabel4"
        Me.BasicLabel4.NumericFormat = Nothing
        Me.BasicLabel4.PLCAddressKeypad = ""
        Me.BasicLabel4.PollRate = 0
        Me.BasicLabel4.Size = New System.Drawing.Size(176, 25)
        Me.BasicLabel4.TabIndex = 82
        Me.BasicLabel4.Text = "POWER OFF"
        Me.BasicLabel4.Value = "POWER OFF"
        Me.BasicLabel4.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(32)
        Me.BasicLabel4.ValueLeftPadLength = 0
        Me.BasicLabel4.ValuePrefix = Nothing
        Me.BasicLabel4.ValueScaleFactor = 1.0R
        Me.BasicLabel4.ValueSuffix = Nothing
        Me.BasicLabel4.ValueToSubtractFrom = 0!
        '
        'MeterCompact1
        '
        Me.MeterCompact1.BackColor = System.Drawing.Color.Transparent
        Me.MeterCompact1.Band1Color = System.Drawing.Color.Lime
        Me.MeterCompact1.Band1EndValue = 100.0R
        Me.MeterCompact1.Band1StartValue = 70.0R
        Me.MeterCompact1.Band2Color = System.Drawing.Color.Red
        Me.MeterCompact1.Band2EndValue = 0R
        Me.MeterCompact1.Band2StartValue = 20.0R
        Me.MeterCompact1.BorderColor = System.Drawing.Color.DimGray
        Me.MeterCompact1.BorderWidth = 0
        Me.MeterCompact1.ComComponent = Me.OpcDaCom1
        Me.MeterCompact1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.MeterCompact1.ForeColor = System.Drawing.Color.LightGray
        Me.MeterCompact1.HighlightColor = System.Drawing.Color.Red
        Me.MeterCompact1.Location = New System.Drawing.Point(777, 65)
        Me.MeterCompact1.MajorTickColor = System.Drawing.Color.DimGray
        Me.MeterCompact1.MajorTickDivisions = 10
        Me.MeterCompact1.MajorTickLength = 15
        Me.MeterCompact1.Maximum = 100.0R
        Me.MeterCompact1.Minimum = 0R
        Me.MeterCompact1.MinorTickColor = System.Drawing.Color.DimGray
        Me.MeterCompact1.MinorTickDivisions = 5
        Me.MeterCompact1.Name = "MeterCompact1"
        Me.MeterCompact1.NumericFormat = Nothing
        Me.MeterCompact1.PLCAddressText = ""
        Me.MeterCompact1.PLCAddressValue = CType(resources.GetObject("MeterCompact1.PLCAddressValue"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem)
        Me.MeterCompact1.PLCAddressVisible = ""
        Me.MeterCompact1.ShowLabels = True
        Me.MeterCompact1.Size = New System.Drawing.Size(379, 237)
        Me.MeterCompact1.TabIndex = 83
        Me.MeterCompact1.Text = "FUEL LEVEL"
        Me.MeterCompact1.Value = 0R
        '
        'PilotLight1
        '
        Me.PilotLight1.Blink = False
        Me.PilotLight1.ComComponent = Me.OpcDaCom1
        Me.PilotLight1.LegendPlate = MfgControl.AdvancedHMI.Controls.PilotLight.LegendPlates.Large
        Me.PilotLight1.LightColor = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.Green
        Me.PilotLight1.LightColorOff = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.Green
        Me.PilotLight1.Location = New System.Drawing.Point(12, 325)
        Me.PilotLight1.Name = "PilotLight1"
        Me.PilotLight1.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.Toggle
        Me.PilotLight1.PLCAddressClick = "B3:0/10"
        Me.PilotLight1.PLCAddressText = ""
        Me.PilotLight1.PLCAddressValue = "B3:0/10"
        Me.PilotLight1.PLCAddressVisible = ""
        Me.PilotLight1.Size = New System.Drawing.Size(118, 173)
        Me.PilotLight1.TabIndex = 84
        Me.PilotLight1.Text = "POWER ON"
        Me.PilotLight1.Value = False
        Me.PilotLight1.ValueToWrite = 0
        '
        'PilotLight2
        '
        Me.PilotLight2.Blink = False
        Me.PilotLight2.ComComponent = Me.OpcDaCom1
        Me.PilotLight2.LegendPlate = MfgControl.AdvancedHMI.Controls.PilotLight.LegendPlates.Large
        Me.PilotLight2.LightColor = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.Red
        Me.PilotLight2.LightColorOff = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.Red
        Me.PilotLight2.Location = New System.Drawing.Point(12, 546)
        Me.PilotLight2.Name = "PilotLight2"
        Me.PilotLight2.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.Toggle
        Me.PilotLight2.PLCAddressClick = "B3:0/11"
        Me.PilotLight2.PLCAddressText = ""
        Me.PilotLight2.PLCAddressValue = "B3:0/11"
        Me.PilotLight2.PLCAddressVisible = ""
        Me.PilotLight2.Size = New System.Drawing.Size(118, 173)
        Me.PilotLight2.TabIndex = 85
        Me.PilotLight2.Text = "EMERGENCY STOP"
        Me.PilotLight2.Value = False
        Me.PilotLight2.ValueToWrite = 0
        '
        'MomentaryButton1
        '
        Me.MomentaryButton1.ButtonColor = MfgControl.AdvancedHMI.Controls.MomemtaryButton.ButtonColors.Red
        Me.MomentaryButton1.ComComponent = Me.OpcDaCom1
        Me.MomentaryButton1.LegendPlate = MfgControl.AdvancedHMI.Controls.MomemtaryButton.LegendPlates.Large
        Me.MomentaryButton1.Location = New System.Drawing.Point(21, 117)
        Me.MomentaryButton1.MaximumHoldTime = 3000
        Me.MomentaryButton1.MinimumHoldTime = 500
        Me.MomentaryButton1.Name = "MomentaryButton1"
        Me.MomentaryButton1.OutputType = MfgControl.AdvancedHMI.Controls.MomemtaryButton.OutputTypes.MomentarySet
        Me.MomentaryButton1.PLCAddressClick = "B3:0/6"
        Me.MomentaryButton1.PLCAddressVisible = ""
        Me.MomentaryButton1.Size = New System.Drawing.Size(109, 160)
        Me.MomentaryButton1.TabIndex = 86
        Me.MomentaryButton1.Text = "ALARM RESET"
        '
        'MomentaryButton2
        '
        Me.MomentaryButton2.ButtonColor = MfgControl.AdvancedHMI.Controls.MomemtaryButton.ButtonColors.Red
        Me.MomentaryButton2.ComComponent = Me.OpcDaCom1
        Me.MomentaryButton2.LegendPlate = MfgControl.AdvancedHMI.Controls.MomemtaryButton.LegendPlates.Large
        Me.MomentaryButton2.Location = New System.Drawing.Point(163, 116)
        Me.MomentaryButton2.MaximumHoldTime = 3000
        Me.MomentaryButton2.MinimumHoldTime = 500
        Me.MomentaryButton2.Name = "MomentaryButton2"
        Me.MomentaryButton2.OutputType = MfgControl.AdvancedHMI.Controls.MomemtaryButton.OutputTypes.MomentarySet
        Me.MomentaryButton2.PLCAddressClick = "B3:0/8"
        Me.MomentaryButton2.PLCAddressVisible = ""
        Me.MomentaryButton2.Size = New System.Drawing.Size(110, 161)
        Me.MomentaryButton2.TabIndex = 87
        Me.MomentaryButton2.Text = "ALARM SILENCE"
        '
        'BasicLabel2
        '
        Me.BasicLabel2.BackColor = System.Drawing.Color.Black
        Me.BasicLabel2.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.BasicLabel2.ComComponent = Me.OpcDaCom1
        Me.BasicLabel2.DisplayAsTime = False
        Me.BasicLabel2.Font = New System.Drawing.Font("Arial", 15.0!, System.Drawing.FontStyle.Bold)
        Me.BasicLabel2.ForeColor = System.Drawing.Color.White
        Me.BasicLabel2.Highlight = False
        Me.BasicLabel2.HighlightColor = System.Drawing.Color.Red
        Me.BasicLabel2.HighlightForeColor = System.Drawing.Color.White
        Me.BasicLabel2.HighlightKeyCharacter = "!"
        Me.BasicLabel2.InterpretValueAsBCD = False
        Me.BasicLabel2.KeypadAlphaNumeric = False
        Me.BasicLabel2.KeypadFont = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.BasicLabel2.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel2.KeypadMaxValue = 0R
        Me.BasicLabel2.KeypadMinValue = 0R
        Me.BasicLabel2.KeypadScaleFactor = 1.0R
        Me.BasicLabel2.KeypadShowCurrentValue = False
        Me.BasicLabel2.KeypadText = Nothing
        Me.BasicLabel2.KeypadWidth = 300
        Me.BasicLabel2.Location = New System.Drawing.Point(335, 388)
        Me.BasicLabel2.Name = "BasicLabel2"
        Me.BasicLabel2.NumericFormat = Nothing
        Me.BasicLabel2.PLCAddressKeypad = ""
        Me.BasicLabel2.PollRate = 0
        Me.BasicLabel2.Size = New System.Drawing.Size(352, 28)
        Me.BasicLabel2.TabIndex = 89
        Me.BasicLabel2.Text = "EMERGENCY STOP"
        Me.BasicLabel2.Value = "EMERGENCY STOP"
        Me.BasicLabel2.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(32)
        Me.BasicLabel2.ValueLeftPadLength = 0
        Me.BasicLabel2.ValuePrefix = Nothing
        Me.BasicLabel2.ValueScaleFactor = 1.0R
        Me.BasicLabel2.ValueSuffix = Nothing
        Me.BasicLabel2.ValueToSubtractFrom = 0!
        '
        'BasicIndicator4
        '
        Me.BasicIndicator4.Color1 = System.Drawing.Color.DarkGray
        Me.BasicIndicator4.Color2 = System.Drawing.Color.Green
        Me.BasicIndicator4.Color3 = System.Drawing.Color.Red
        Me.BasicIndicator4.ComComponent = Me.OpcDaCom1
        Me.BasicIndicator4.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BasicIndicator4.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.BasicIndicator4.Location = New System.Drawing.Point(396, 234)
        Me.BasicIndicator4.Name = "BasicIndicator4"
        Me.BasicIndicator4.OutlineColor = System.Drawing.Color.Transparent
        Me.BasicIndicator4.OutlineWidth = 1
        Me.BasicIndicator4.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicIndicator4.PLCAddressSelectColor3 = "B3:0/11"
        Me.BasicIndicator4.SelectColor2 = False
        Me.BasicIndicator4.SelectColor3 = False
        Me.BasicIndicator4.Shape = MfgControl.AdvancedHMI.Controls.Indicator.ShapeTypes.Round
        Me.BasicIndicator4.Size = New System.Drawing.Size(132, 131)
        Me.BasicIndicator4.TabIndex = 88
        '
        'BasicLabel5
        '
        Me.BasicLabel5.BackColor = System.Drawing.Color.Black
        Me.BasicLabel5.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.BasicLabel5.ComComponent = Me.OpcDaCom1
        Me.BasicLabel5.DisplayAsTime = False
        Me.BasicLabel5.Font = New System.Drawing.Font("Arial", 15.0!, System.Drawing.FontStyle.Bold)
        Me.BasicLabel5.ForeColor = System.Drawing.Color.White
        Me.BasicLabel5.Highlight = False
        Me.BasicLabel5.HighlightColor = System.Drawing.Color.Red
        Me.BasicLabel5.HighlightForeColor = System.Drawing.Color.White
        Me.BasicLabel5.HighlightKeyCharacter = "!"
        Me.BasicLabel5.InterpretValueAsBCD = False
        Me.BasicLabel5.KeypadAlphaNumeric = False
        Me.BasicLabel5.KeypadFont = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.BasicLabel5.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel5.KeypadMaxValue = 0R
        Me.BasicLabel5.KeypadMinValue = 0R
        Me.BasicLabel5.KeypadScaleFactor = 1.0R
        Me.BasicLabel5.KeypadShowCurrentValue = False
        Me.BasicLabel5.KeypadText = Nothing
        Me.BasicLabel5.KeypadWidth = 300
        Me.BasicLabel5.Location = New System.Drawing.Point(899, 431)
        Me.BasicLabel5.Name = "BasicLabel5"
        Me.BasicLabel5.NumericFormat = Nothing
        Me.BasicLabel5.PLCAddressKeypad = ""
        Me.BasicLabel5.PollRate = 0
        Me.BasicLabel5.Size = New System.Drawing.Size(176, 25)
        Me.BasicLabel5.TabIndex = 90
        Me.BasicLabel5.Text = "LOW FUEL "
        Me.BasicLabel5.Value = "LOW FUEL "
        Me.BasicLabel5.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(32)
        Me.BasicLabel5.ValueLeftPadLength = 0
        Me.BasicLabel5.ValuePrefix = Nothing
        Me.BasicLabel5.ValueScaleFactor = 1.0R
        Me.BasicLabel5.ValueSuffix = Nothing
        Me.BasicLabel5.ValueToSubtractFrom = 0!
        '
        'SoundPlayer1
        '
        Me.SoundPlayer1.ComComponent = Me.OpcDaCom1
        Me.SoundPlayer1.Enabled = True
        Me.SoundPlayer1.FileFolder = "C:\Users\chand\Downloads"
        Me.SoundPlayer1.PLCAddressValue = CType(resources.GetObject("SoundPlayer1.PLCAddressValue"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem)
        Me.SoundPlayer1.SoundFileName = "ALARM.wav"
        Me.SoundPlayer1.TriggerType = AdvancedHMIControls.SoundPlayer.TriggerTypeOptions.PositiveChange
        Me.SoundPlayer1.Value = Nothing
        '
        'BasicLabel6
        '
        Me.BasicLabel6.BackColor = System.Drawing.Color.Black
        Me.BasicLabel6.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.BasicLabel6.ComComponent = Me.OpcDaCom1
        Me.BasicLabel6.DisplayAsTime = False
        Me.BasicLabel6.Font = New System.Drawing.Font("Arial", 15.0!, System.Drawing.FontStyle.Bold)
        Me.BasicLabel6.ForeColor = System.Drawing.Color.White
        Me.BasicLabel6.Highlight = False
        Me.BasicLabel6.HighlightColor = System.Drawing.Color.Red
        Me.BasicLabel6.HighlightForeColor = System.Drawing.Color.White
        Me.BasicLabel6.HighlightKeyCharacter = "!"
        Me.BasicLabel6.InterpretValueAsBCD = False
        Me.BasicLabel6.KeypadAlphaNumeric = False
        Me.BasicLabel6.KeypadFont = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.BasicLabel6.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel6.KeypadMaxValue = 0R
        Me.BasicLabel6.KeypadMinValue = 0R
        Me.BasicLabel6.KeypadScaleFactor = 1.0R
        Me.BasicLabel6.KeypadShowCurrentValue = False
        Me.BasicLabel6.KeypadText = Nothing
        Me.BasicLabel6.KeypadWidth = 300
        Me.BasicLabel6.Location = New System.Drawing.Point(834, 592)
        Me.BasicLabel6.Name = "BasicLabel6"
        Me.BasicLabel6.NumericFormat = Nothing
        Me.BasicLabel6.PLCAddressKeypad = ""
        Me.BasicLabel6.PollRate = 0
        Me.BasicLabel6.Size = New System.Drawing.Size(287, 25)
        Me.BasicLabel6.TabIndex = 92
        Me.BasicLabel6.Text = "GENERATOR FAULT"
        Me.BasicLabel6.Value = "GENERATOR FAULT"
        Me.BasicLabel6.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(32)
        Me.BasicLabel6.ValueLeftPadLength = 0
        Me.BasicLabel6.ValuePrefix = Nothing
        Me.BasicLabel6.ValueScaleFactor = 1.0R
        Me.BasicLabel6.ValueSuffix = Nothing
        Me.BasicLabel6.ValueToSubtractFrom = 0!
        '
        'BasicIndicator5
        '
        Me.BasicIndicator5.Color1 = System.Drawing.Color.DarkGray
        Me.BasicIndicator5.Color2 = System.Drawing.Color.Green
        Me.BasicIndicator5.Color3 = System.Drawing.Color.Red
        Me.BasicIndicator5.ComComponent = Me.OpcDaCom1
        Me.BasicIndicator5.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BasicIndicator5.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.BasicIndicator5.Location = New System.Drawing.Point(929, 497)
        Me.BasicIndicator5.Name = "BasicIndicator5"
        Me.BasicIndicator5.OutlineColor = System.Drawing.Color.Transparent
        Me.BasicIndicator5.OutlineWidth = 1
        Me.BasicIndicator5.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicIndicator5.PLCAddressSelectColor3 = "B3:0/9"
        Me.BasicIndicator5.SelectColor2 = False
        Me.BasicIndicator5.SelectColor3 = False
        Me.BasicIndicator5.Shape = MfgControl.AdvancedHMI.Controls.Indicator.ShapeTypes.Round
        Me.BasicIndicator5.Size = New System.Drawing.Size(81, 80)
        Me.BasicIndicator5.TabIndex = 91
        '
        'BasicLabel7
        '
        Me.BasicLabel7.BackColor = System.Drawing.Color.Black
        Me.BasicLabel7.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.BasicLabel7.ComComponent = Me.OpcDaCom1
        Me.BasicLabel7.DisplayAsTime = False
        Me.BasicLabel7.Font = New System.Drawing.Font("Arial", 20.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.BasicLabel7.ForeColor = System.Drawing.Color.White
        Me.BasicLabel7.Highlight = False
        Me.BasicLabel7.HighlightColor = System.Drawing.Color.Red
        Me.BasicLabel7.HighlightForeColor = System.Drawing.Color.White
        Me.BasicLabel7.HighlightKeyCharacter = "!"
        Me.BasicLabel7.InterpretValueAsBCD = False
        Me.BasicLabel7.KeypadAlphaNumeric = False
        Me.BasicLabel7.KeypadFont = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.BasicLabel7.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel7.KeypadMaxValue = 0R
        Me.BasicLabel7.KeypadMinValue = 0R
        Me.BasicLabel7.KeypadScaleFactor = 1.0R
        Me.BasicLabel7.KeypadShowCurrentValue = False
        Me.BasicLabel7.KeypadText = Nothing
        Me.BasicLabel7.KeypadWidth = 300
        Me.BasicLabel7.Location = New System.Drawing.Point(315, 9)
        Me.BasicLabel7.Name = "BasicLabel7"
        Me.BasicLabel7.NumericFormat = Nothing
        Me.BasicLabel7.PLCAddressKeypad = ""
        Me.BasicLabel7.PollRate = 0
        Me.BasicLabel7.Size = New System.Drawing.Size(459, 55)
        Me.BasicLabel7.TabIndex = 93
        Me.BasicLabel7.Text = "AUTOMATIC GENERATOR "
        Me.BasicLabel7.Value = "AUTOMATIC GENERATOR "
        Me.BasicLabel7.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(32)
        Me.BasicLabel7.ValueLeftPadLength = 0
        Me.BasicLabel7.ValuePrefix = Nothing
        Me.BasicLabel7.ValueScaleFactor = 1.0R
        Me.BasicLabel7.ValueSuffix = Nothing
        Me.BasicLabel7.ValueToSubtractFrom = 0!
        '
        'AUTO_GENERATOR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1157, 789)
        Me.Controls.Add(Me.BasicLabel7)
        Me.Controls.Add(Me.BasicLabel6)
        Me.Controls.Add(Me.BasicIndicator5)
        Me.Controls.Add(Me.BasicLabel5)
        Me.Controls.Add(Me.BasicLabel2)
        Me.Controls.Add(Me.BasicIndicator4)
        Me.Controls.Add(Me.MomentaryButton2)
        Me.Controls.Add(Me.MomentaryButton1)
        Me.Controls.Add(Me.PilotLight2)
        Me.Controls.Add(Me.PilotLight1)
        Me.Controls.Add(Me.MeterCompact1)
        Me.Controls.Add(Me.BasicLabel4)
        Me.Controls.Add(Me.BasicLabel3)
        Me.Controls.Add(Me.BasicIndicator3)
        Me.Controls.Add(Me.BasicIndicator2)
        Me.Controls.Add(Me.BasicIndicator1)
        Me.Controls.Add(Me.BasicLabel1)
        Me.Controls.Add(Me.Motor1)
        Me.Controls.Add(Me.PictureBox1)
        Me.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.Name = "AUTO_GENERATOR"
        Me.Text = "AUTO_GENERATOR"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SoundPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents OpcDaCom1 As AdvancedHMIDrivers.OpcDaCom
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Motor1 As AdvancedHMIControls.Motor
    Friend WithEvents BasicLabel1 As AdvancedHMIControls.BasicLabel
    Friend WithEvents BasicIndicator1 As AdvancedHMIControls.BasicIndicator
    Friend WithEvents BasicLabel4 As AdvancedHMIControls.BasicLabel
    Friend WithEvents BasicLabel3 As AdvancedHMIControls.BasicLabel
    Friend WithEvents BasicIndicator3 As AdvancedHMIControls.BasicIndicator
    Friend WithEvents BasicIndicator2 As AdvancedHMIControls.BasicIndicator
    Friend WithEvents MeterCompact1 As AdvancedHMIControls.MeterCompact
    Friend WithEvents PilotLight2 As AdvancedHMIControls.PilotLight
    Friend WithEvents PilotLight1 As AdvancedHMIControls.PilotLight
    Friend WithEvents MomentaryButton2 As AdvancedHMIControls.MomentaryButton
    Friend WithEvents MomentaryButton1 As AdvancedHMIControls.MomentaryButton
    Friend WithEvents BasicLabel2 As AdvancedHMIControls.BasicLabel
    Friend WithEvents BasicIndicator4 As AdvancedHMIControls.BasicIndicator
    Friend WithEvents BasicLabel5 As AdvancedHMIControls.BasicLabel
    Friend WithEvents SoundPlayer1 As AdvancedHMIControls.SoundPlayer
    Friend WithEvents BasicLabel6 As AdvancedHMIControls.BasicLabel
    Friend WithEvents BasicIndicator5 As AdvancedHMIControls.BasicIndicator
    Friend WithEvents BasicLabel7 As AdvancedHMIControls.BasicLabel
End Class
