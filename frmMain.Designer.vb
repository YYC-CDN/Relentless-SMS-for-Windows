<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
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
        components = New ComponentModel.Container()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(frmMain))
        cbImagesCheckbox = New CheckBox()
        phone_number_label = New Label()
        SplitContainer1 = New SplitContainer()
        LinkLabel1 = New LinkLabel()
        Label2 = New Label()
        PictureBox1 = New PictureBox()
        btnEmailToSMS = New Button()
        dbSelectCellProvider = New ComboBox()
        txtSecondsBetween = New TextBox()
        lblOutgoingLanguage = New Label()
        lblSecondsBetween = New Label()
        dbOutgoingLanguage = New ComboBox()
        txtNumberofMessages = New TextBox()
        number_of_messages_label = New Label()
        btnSendSMS = New Button()
        txtOutgoingMessages = New TextBox()
        pbAllFunctions = New ProgressBar()
        txtTargetNumber = New TextBox()
        btnSettings = New Button()
        btnClose = New Button()
        tmrMessagesRemaining = New Timer(components)
        ToolTip1 = New ToolTip(components)
        btnVerifyNumber = New Button()
        btnMailbaitSubmit = New Button()
        Label1 = New Label()
        txtOpenTabs = New TextBox()
        btnEmailValidation = New Button()
        txtVerificationResults = New TextBox()
        lblIPAddress = New Label()
        Label3 = New Label()
        Label4 = New Label()
        CType(SplitContainer1, ComponentModel.ISupportInitialize).BeginInit()
        SplitContainer1.Panel1.SuspendLayout()
        SplitContainer1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' cbImagesCheckbox
        ' 
        cbImagesCheckbox.AutoSize = True
        cbImagesCheckbox.Checked = True
        cbImagesCheckbox.CheckState = CheckState.Checked
        cbImagesCheckbox.Font = New Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        cbImagesCheckbox.ForeColor = Color.FromArgb(CByte(209), CByte(219), CByte(221))
        cbImagesCheckbox.Location = New Point(235, 326)
        cbImagesCheckbox.Name = "cbImagesCheckbox"
        cbImagesCheckbox.Size = New Size(383, 22)
        cbImagesCheckbox.TabIndex = 1
        cbImagesCheckbox.Text = "Check to send Images with Email to SMS (only)"
        ToolTip1.SetToolTip(cbImagesCheckbox, "Images are stored here- C:\RelentlessSMS\OutgoingImages and this is " & vbCrLf & "NOT applicable with SpamSend Campaigns.")
        cbImagesCheckbox.UseVisualStyleBackColor = True
        ' 
        ' phone_number_label
        ' 
        phone_number_label.AutoSize = True
        phone_number_label.Font = New Font("Verdana", 21.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        phone_number_label.ForeColor = Color.FromArgb(CByte(209), CByte(219), CByte(221))
        phone_number_label.Location = New Point(455, 24)
        phone_number_label.Name = "phone_number_label"
        phone_number_label.Size = New Size(416, 35)
        phone_number_label.TabIndex = 3
        phone_number_label.Text = "Target Number or Email:"' 
        ' SplitContainer1
        ' 
        SplitContainer1.Location = New Point(1, 60)
        SplitContainer1.Name = "SplitContainer1"' 
        ' SplitContainer1.Panel1
        ' 
        SplitContainer1.Panel1.BackColor = Color.Gainsboro
        SplitContainer1.Panel1.BackgroundImageLayout = ImageLayout.Center
        SplitContainer1.Panel1.Controls.Add(LinkLabel1)
        SplitContainer1.Panel1.Controls.Add(Label2)
        SplitContainer1.Size = New Size(54, 79)
        SplitContainer1.SplitterDistance = 25
        SplitContainer1.TabIndex = 4
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.BackColor = Color.Transparent
        LinkLabel1.Font = New Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point)
        LinkLabel1.LinkColor = Color.White
        LinkLabel1.Location = New Point(121, 609)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(0, 18)
        LinkLabel1.TabIndex = 17
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ForeColor = SystemColors.ControlLightLight
        Label2.Location = New Point(-3321, 274)
        Label2.Name = "Label2"
        Label2.Size = New Size(732, 161)
        Label2.TabIndex = 2
        Label2.Text = resources.GetString("Label2.Text")
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.FromArgb(CByte(18), CByte(18), CByte(18))
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(211, 624)
        PictureBox1.TabIndex = 3
        PictureBox1.TabStop = False
        ' 
        ' btnEmailToSMS
        ' 
        btnEmailToSMS.BackColor = Color.BlueViolet
        btnEmailToSMS.BackgroundImageLayout = ImageLayout.Center
        btnEmailToSMS.Cursor = Cursors.Hand
        btnEmailToSMS.Font = New Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        btnEmailToSMS.ForeColor = SystemColors.ControlLightLight
        btnEmailToSMS.Location = New Point(55, 181)
        btnEmailToSMS.Name = "btnEmailToSMS"
        btnEmailToSMS.Size = New Size(100, 56)
        btnEmailToSMS.TabIndex = 8
        btnEmailToSMS.Text = "Start Email to SMS Campaign"
        btnEmailToSMS.UseVisualStyleBackColor = False
        ' 
        ' dbSelectCellProvider
        ' 
        dbSelectCellProvider.BackColor = Color.FromArgb(CByte(30), CByte(30), CByte(30))
        dbSelectCellProvider.FlatStyle = FlatStyle.Flat
        dbSelectCellProvider.Font = New Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        dbSelectCellProvider.ForeColor = Color.FromArgb(CByte(209), CByte(219), CByte(221))
        dbSelectCellProvider.FormattingEnabled = True
        dbSelectCellProvider.ItemHeight = 18
        dbSelectCellProvider.Location = New Point(472, 280)
        dbSelectCellProvider.MaxDropDownItems = 15
        dbSelectCellProvider.Name = "dbSelectCellProvider"
        dbSelectCellProvider.Size = New Size(217, 26)
        dbSelectCellProvider.TabIndex = 3
        ToolTip1.SetToolTip(dbSelectCellProvider, "This is a list of carriers providing Short Message Service (SMS) transit via SMS gateways.")
        ' 
        ' txtSecondsBetween
        ' 
        txtSecondsBetween.BackColor = Color.FromArgb(CByte(30), CByte(30), CByte(30))
        txtSecondsBetween.BorderStyle = BorderStyle.None
        txtSecondsBetween.Font = New Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtSecondsBetween.ForeColor = Color.FromArgb(CByte(209), CByte(219), CByte(221))
        txtSecondsBetween.Location = New Point(607, 193)
        txtSecondsBetween.Name = "txtSecondsBetween"
        txtSecondsBetween.Size = New Size(48, 19)
        txtSecondsBetween.TabIndex = 3
        txtSecondsBetween.Text = "1"
        ToolTip1.SetToolTip(txtSecondsBetween, "How many seconds between messages sent")
        ' 
        ' lblOutgoingLanguage
        ' 
        lblOutgoingLanguage.AutoSize = True
        lblOutgoingLanguage.Font = New Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        lblOutgoingLanguage.ForeColor = Color.FromArgb(CByte(209), CByte(219), CByte(221))
        lblOutgoingLanguage.Location = New Point(235, 237)
        lblOutgoingLanguage.Name = "lblOutgoingLanguage"
        lblOutgoingLanguage.Size = New Size(231, 18)
        lblOutgoingLanguage.TabIndex = 8
        lblOutgoingLanguage.Text = "Select an Outgoing Language:"' 
        ' lblSecondsBetween
        ' 
        lblSecondsBetween.AutoSize = True
        lblSecondsBetween.Font = New Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        lblSecondsBetween.ForeColor = Color.FromArgb(CByte(209), CByte(219), CByte(221))
        lblSecondsBetween.Location = New Point(235, 193)
        lblSecondsBetween.Name = "lblSecondsBetween"
        lblSecondsBetween.Size = New Size(364, 18)
        lblSecondsBetween.TabIndex = 6
        lblSecondsBetween.Text = "Seconds between sent messages (default is 1):"' 
        ' dbOutgoingLanguage
        ' 
        dbOutgoingLanguage.BackColor = Color.FromArgb(CByte(30), CByte(30), CByte(30))
        dbOutgoingLanguage.FlatStyle = FlatStyle.Flat
        dbOutgoingLanguage.Font = New Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        dbOutgoingLanguage.ForeColor = Color.FromArgb(CByte(209), CByte(219), CByte(221))
        dbOutgoingLanguage.FormattingEnabled = True
        dbOutgoingLanguage.ItemHeight = 18
        dbOutgoingLanguage.Location = New Point(472, 234)
        dbOutgoingLanguage.Name = "dbOutgoingLanguage"
        dbOutgoingLanguage.Size = New Size(217, 26)
        dbOutgoingLanguage.TabIndex = 9
        ToolTip1.SetToolTip(dbOutgoingLanguage, "Select an outgoing language. Messages will send in that language")
        ' 
        ' txtNumberofMessages
        ' 
        txtNumberofMessages.BackColor = Color.FromArgb(CByte(30), CByte(30), CByte(30))
        txtNumberofMessages.BorderStyle = BorderStyle.None
        txtNumberofMessages.Font = New Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtNumberofMessages.ForeColor = Color.FromArgb(CByte(209), CByte(219), CByte(221))
        txtNumberofMessages.Location = New Point(607, 152)
        txtNumberofMessages.Name = "txtNumberofMessages"
        txtNumberofMessages.Size = New Size(48, 19)
        txtNumberofMessages.TabIndex = 2
        txtNumberofMessages.Text = "1"
        ToolTip1.SetToolTip(txtNumberofMessages, "The number of total outgoing messages")
        ' 
        ' number_of_messages_label
        ' 
        number_of_messages_label.AutoSize = True
        number_of_messages_label.Font = New Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        number_of_messages_label.ForeColor = Color.FromArgb(CByte(209), CByte(219), CByte(221))
        number_of_messages_label.Location = New Point(235, 152)
        number_of_messages_label.Name = "number_of_messages_label"
        number_of_messages_label.Size = New Size(369, 18)
        number_of_messages_label.TabIndex = 4
        number_of_messages_label.Text = "Number of overall outgoing messages to target:"' 
        ' btnSendSMS
        ' 
        btnSendSMS.BackColor = Color.BlueViolet
        btnSendSMS.BackgroundImageLayout = ImageLayout.Center
        btnSendSMS.Cursor = Cursors.Hand
        btnSendSMS.Font = New Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        btnSendSMS.ForeColor = SystemColors.ControlLightLight
        btnSendSMS.Location = New Point(55, 135)
        btnSendSMS.Name = "btnSendSMS"
        btnSendSMS.Size = New Size(100, 42)
        btnSendSMS.TabIndex = 7
        btnSendSMS.Text = "Start SMS Campaign"
        ToolTip1.SetToolTip(btnSendSMS, "Starts the SMS/Text Message Campaign")
        btnSendSMS.UseVisualStyleBackColor = False
        ' 
        ' txtOutgoingMessages
        ' 
        txtOutgoingMessages.BackColor = Color.FromArgb(CByte(30), CByte(30), CByte(30))
        txtOutgoingMessages.BorderStyle = BorderStyle.None
        txtOutgoingMessages.Font = New Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtOutgoingMessages.ForeColor = Color.FromArgb(CByte(209), CByte(219), CByte(221))
        txtOutgoingMessages.Location = New Point(232, 519)
        txtOutgoingMessages.Multiline = True
        txtOutgoingMessages.Name = "txtOutgoingMessages"
        txtOutgoingMessages.PlaceholderText = "Preview of Target Screen"
        txtOutgoingMessages.ReadOnly = True
        txtOutgoingMessages.Size = New Size(861, 58)
        txtOutgoingMessages.TabIndex = 99
        txtOutgoingMessages.TextAlign = HorizontalAlignment.Center
        ' 
        ' pbAllFunctions
        ' 
        pbAllFunctions.BackColor = Color.FromArgb(CByte(34), CByte(39), CByte(42))
        pbAllFunctions.ForeColor = Color.FromArgb(CByte(34), CByte(39), CByte(42))
        pbAllFunctions.Location = New Point(232, 586)
        pbAllFunctions.MarqueeAnimationSpeed = 200
        pbAllFunctions.Maximum = 500
        pbAllFunctions.Name = "pbAllFunctions"
        pbAllFunctions.Size = New Size(861, 25)
        pbAllFunctions.TabIndex = 11
        ' 
        ' txtTargetNumber
        ' 
        txtTargetNumber.BackColor = Color.FromArgb(CByte(30), CByte(30), CByte(30))
        txtTargetNumber.BorderStyle = BorderStyle.None
        txtTargetNumber.Font = New Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        txtTargetNumber.ForeColor = Color.FromArgb(CByte(209), CByte(219), CByte(221))
        txtTargetNumber.Location = New Point(237, 76)
        txtTargetNumber.MaxLength = 45
        txtTargetNumber.Name = "txtTargetNumber"
        txtTargetNumber.PlaceholderText = "202456TEST or example@domain.ca"
        txtTargetNumber.Size = New Size(856, 26)
        txtTargetNumber.TabIndex = 1
        txtTargetNumber.TextAlign = HorizontalAlignment.Center
        ToolTip1.SetToolTip(txtTargetNumber, "This is your TARGET NUMBER. Be very, very sure this is the number you want to influence")
        txtTargetNumber.WordWrap = False
        ' 
        ' btnSettings
        ' 
        btnSettings.BackColor = Color.BlueViolet
        btnSettings.BackgroundImageLayout = ImageLayout.Center
        btnSettings.Cursor = Cursors.Hand
        btnSettings.Font = New Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        btnSettings.ForeColor = SystemColors.ControlLightLight
        btnSettings.Location = New Point(55, 404)
        btnSettings.Name = "btnSettings"
        btnSettings.Size = New Size(99, 38)
        btnSettings.TabIndex = 11
        btnSettings.Text = "Settings"
        btnSettings.UseVisualStyleBackColor = False
        ' 
        ' btnClose
        ' 
        btnClose.BackColor = Color.BlueViolet
        btnClose.BackgroundImageLayout = ImageLayout.Center
        btnClose.Cursor = Cursors.Hand
        btnClose.Font = New Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        btnClose.ForeColor = SystemColors.ControlLightLight
        btnClose.Location = New Point(55, 447)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(99, 38)
        btnClose.TabIndex = 12
        btnClose.Text = "Close"
        btnClose.UseVisualStyleBackColor = False
        ' 
        ' tmrMessagesRemaining
        ' 
        tmrMessagesRemaining.Enabled = True
        tmrMessagesRemaining.Interval = 5000
        ' 
        ' btnVerifyNumber
        ' 
        btnVerifyNumber.BackColor = Color.BlueViolet
        btnVerifyNumber.Cursor = Cursors.Hand
        btnVerifyNumber.Font = New Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        btnVerifyNumber.ForeColor = SystemColors.Control
        btnVerifyNumber.Location = New Point(55, 303)
        btnVerifyNumber.Name = "btnVerifyNumber"
        btnVerifyNumber.Size = New Size(100, 46)
        btnVerifyNumber.TabIndex = 10
        btnVerifyNumber.Text = "Number Validation"
        ToolTip1.SetToolTip(btnVerifyNumber, "Phone number validation tool")
        btnVerifyNumber.UseVisualStyleBackColor = False
        ' 
        ' btnMailbaitSubmit
        ' 
        btnMailbaitSubmit.BackColor = Color.BlueViolet
        btnMailbaitSubmit.Cursor = Cursors.Hand
        btnMailbaitSubmit.Font = New Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        btnMailbaitSubmit.ForeColor = SystemColors.ControlLight
        btnMailbaitSubmit.Location = New Point(55, 241)
        btnMailbaitSubmit.Name = "btnMailbaitSubmit"
        btnMailbaitSubmit.Size = New Size(100, 58)
        btnMailbaitSubmit.TabIndex = 9
        btnMailbaitSubmit.Text = "Open SpamSend Campaign"
        ToolTip1.SetToolTip(btnMailbaitSubmit, "Opens Browser for Spam Campaign")
        btnMailbaitSubmit.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = Color.FromArgb(CByte(209), CByte(219), CByte(221))
        Label1.Location = New Point(235, 370)
        Label1.Name = "Label1"
        Label1.Size = New Size(424, 18)
        Label1.TabIndex = 22
        Label1.Text = "Number of mass email streams (or tabs- 25 is default):"
        ToolTip1.SetToolTip(Label1, "The more, the better. 50 for 24 hours is great. 75 tabs for 72 hours is brutal. ")
        ' 
        ' txtOpenTabs
        ' 
        txtOpenTabs.BackColor = Color.FromArgb(CByte(30), CByte(30), CByte(30))
        txtOpenTabs.BorderStyle = BorderStyle.None
        txtOpenTabs.Font = New Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtOpenTabs.ForeColor = Color.FromArgb(CByte(209), CByte(219), CByte(221))
        txtOpenTabs.Location = New Point(661, 370)
        txtOpenTabs.Name = "txtOpenTabs"
        txtOpenTabs.PlaceholderText = "25"
        txtOpenTabs.Size = New Size(40, 19)
        txtOpenTabs.TabIndex = 6
        ToolTip1.SetToolTip(txtOpenTabs, "The more, the better. Don't ever close this window. 50 for 24 hours is great. 75 tabs for 72 hours is brutal. ")
        ' 
        ' btnEmailValidation
        ' 
        btnEmailValidation.BackColor = Color.BlueViolet
        btnEmailValidation.Cursor = Cursors.Hand
        btnEmailValidation.Font = New Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        btnEmailValidation.ForeColor = SystemColors.Control
        btnEmailValidation.Location = New Point(55, 353)
        btnEmailValidation.Name = "btnEmailValidation"
        btnEmailValidation.Size = New Size(100, 46)
        btnEmailValidation.TabIndex = 101
        btnEmailValidation.Text = "Email Validation"
        ToolTip1.SetToolTip(btnEmailValidation, "Phone number validation tool")
        btnEmailValidation.UseVisualStyleBackColor = False
        ' 
        ' txtVerificationResults
        ' 
        txtVerificationResults.BackColor = Color.FromArgb(CByte(30), CByte(30), CByte(30))
        txtVerificationResults.BorderStyle = BorderStyle.None
        txtVerificationResults.Font = New Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point)
        txtVerificationResults.ForeColor = Color.FromArgb(CByte(209), CByte(219), CByte(221))
        txtVerificationResults.Location = New Point(723, 145)
        txtVerificationResults.Multiline = True
        txtVerificationResults.Name = "txtVerificationResults"
        txtVerificationResults.Size = New Size(370, 357)
        txtVerificationResults.TabIndex = 1
        txtVerificationResults.Text = resources.GetString("txtVerificationResults.Text")
        ' 
        ' lblIPAddress
        ' 
        lblIPAddress.AutoSize = True
        lblIPAddress.BackColor = Color.FromArgb(CByte(18), CByte(18), CByte(18))
        lblIPAddress.ForeColor = SystemColors.ControlLightLight
        lblIPAddress.Location = New Point(79, 592)
        lblIPAddress.Name = "lblIPAddress"
        lblIPAddress.Size = New Size(88, 15)
        lblIPAddress.TabIndex = 100
        lblIPAddress.Text = "000.000.000.000"
        lblIPAddress.TextAlign = Drawing.ContentAlignment.MiddleCenter
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.FromArgb(CByte(18), CByte(18), CByte(18))
        Label3.ForeColor = SystemColors.ControlLightLight
        Label3.Location = New Point(53, 592)
        Label3.Name = "Label3"
        Label3.Size = New Size(30, 15)
        Label3.TabIndex = 102
        Label3.Text = "You:"
        Label3.TextAlign = Drawing.ContentAlignment.MiddleCenter
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.ForeColor = Color.FromArgb(CByte(209), CByte(219), CByte(221))
        Label4.Location = New Point(235, 283)
        Label4.Name = "Label4"
        Label4.Size = New Size(198, 18)
        Label4.TabIndex = 103
        Label4.Text = "Select a Cellular Provider:"' 
        ' frmMain
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(30), CByte(30), CByte(30))
        ClientSize = New Size(1108, 624)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(btnEmailValidation)
        Controls.Add(lblIPAddress)
        Controls.Add(txtOutgoingMessages)
        Controls.Add(btnClose)
        Controls.Add(Label1)
        Controls.Add(btnEmailToSMS)
        Controls.Add(btnMailbaitSubmit)
        Controls.Add(txtOpenTabs)
        Controls.Add(lblOutgoingLanguage)
        Controls.Add(cbImagesCheckbox)
        Controls.Add(btnSendSMS)
        Controls.Add(dbSelectCellProvider)
        Controls.Add(dbOutgoingLanguage)
        Controls.Add(number_of_messages_label)
        Controls.Add(lblSecondsBetween)
        Controls.Add(txtSecondsBetween)
        Controls.Add(txtNumberofMessages)
        Controls.Add(btnSettings)
        Controls.Add(btnVerifyNumber)
        Controls.Add(PictureBox1)
        Controls.Add(txtTargetNumber)
        Controls.Add(phone_number_label)
        Controls.Add(pbAllFunctions)
        Controls.Add(SplitContainer1)
        Controls.Add(txtVerificationResults)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "frmMain"
        Opacity = 0.99R
        StartPosition = FormStartPosition.CenterScreen
        SplitContainer1.Panel1.ResumeLayout(False)
        SplitContainer1.Panel1.PerformLayout()
        CType(SplitContainer1, ComponentModel.ISupportInitialize).EndInit()
        SplitContainer1.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents cbImagesCheckbox As CheckBox
    Friend WithEvents phone_number_label As Label
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents Label2 As Label
    Friend WithEvents txtTargetNumber As TextBox
    Friend WithEvents dbOutgoingLanguage As ComboBox
    Friend WithEvents lblOutgoingLanguage As Label
    Friend WithEvents txtSecondsBetween As TextBox
    Friend WithEvents lblSecondsBetween As Label
    Friend WithEvents txtNumberofMessages As TextBox
    Friend WithEvents number_of_messages_label As Label
    Friend WithEvents pbAllFunctions As ProgressBar
    Friend WithEvents btnSendSMS As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents btnEmailToSMS As Button
    Friend WithEvents dbSelectCellProvider As ComboBox
    Friend WithEvents txtOutgoingMessages As TextBox
    Friend WithEvents btnSettings As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents tmrMessagesRemaining As Timer
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents btnVerifyNumber As Button
    Friend WithEvents txtVerificationResults As TextBox
    Friend WithEvents btnMailbaitSubmit As Button
    Friend WithEvents txtOpenTabs As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblIPAddress As Label
    Friend WithEvents btnEmailValidation As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
