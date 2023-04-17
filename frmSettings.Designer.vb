<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSettings
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(frmSettings))
        btnClose = New Button()
        Label1 = New Label()
        txtTextNowAPI = New TextBox()
        Label6 = New Label()
        btnAddTextNowAPI = New Button()
        lblLinkHome = New LinkLabel()
        Label2 = New Label()
        Label3 = New Label()
        RichTextBox2 = New RichTextBox()
        btnIPQualityScore = New Button()
        Label4 = New Label()
        txtIPQualityScore = New TextBox()
        Label5 = New Label()
        LinkLabel1 = New LinkLabel()
        Label7 = New Label()
        txtSMTPbox = New TextBox()
        txtPort = New TextBox()
        Label8 = New Label()
        Label9 = New Label()
        LinkLabel2 = New LinkLabel()
        cbEnableSSL = New ComboBox()
        btnAddSMTP = New Button()
        btnAddEmailPass = New Button()
        txtEmailAddresses = New TextBox()
        txtEmailPassword = New TextBox()
        GroupBox1 = New GroupBox()
        Label10 = New Label()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnClose
        ' 
        btnClose.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        btnClose.Location = New Point(629, 459)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(107, 37)
        btnClose.TabIndex = 15
        btnClose.Text = "Close"
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(7, 68)
        Label1.Name = "Label1"
        Label1.Size = New Size(29, 17)
        Label1.TabIndex = 100
        Label1.Text = "API:"' 
        ' txtTextNowAPI
        ' 
        txtTextNowAPI.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        txtTextNowAPI.Location = New Point(54, 65)
        txtTextNowAPI.Name = "txtTextNowAPI"
        txtTextNowAPI.PlaceholderText = "4c04870a460a4ea485d939c338e3be279f80573dfeRCuqYAOiMYnmD1E_EXAMPLE"
        txtTextNowAPI.Size = New Size(694, 25)
        txtTextNowAPI.TabIndex = 0
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(7, 32)
        Label6.Name = "Label6"
        Label6.Size = New Size(199, 17)
        Label6.TabIndex = 100
        Label6.Text = "Regular Text Message Send API"' 
        ' btnAddTextNowAPI
        ' 
        btnAddTextNowAPI.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        btnAddTextNowAPI.Location = New Point(550, 96)
        btnAddTextNowAPI.Name = "btnAddTextNowAPI"
        btnAddTextNowAPI.Size = New Size(198, 39)
        btnAddTextNowAPI.TabIndex = 1
        btnAddTextNowAPI.Text = "Add API"
        btnAddTextNowAPI.UseVisualStyleBackColor = True
        ' 
        ' lblLinkHome
        ' 
        lblLinkHome.AutoSize = True
        lblLinkHome.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblLinkHome.LinkColor = Color.DarkViolet
        lblLinkHome.Location = New Point(646, 32)
        lblLinkHome.Name = "lblLinkHome"
        lblLinkHome.Size = New Size(102, 17)
        lblLinkHome.TabIndex = 100
        lblLinkHome.TabStop = True
        lblLinkHome.Text = "Get the API here"' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(205, 121)
        Label2.Name = "Label2"
        Label2.Size = New Size(0, 17)
        Label2.TabIndex = 17
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(277, 102)
        Label3.Name = "Label3"
        Label3.Size = New Size(0, 17)
        Label3.TabIndex = 18
        ' 
        ' RichTextBox2
        ' 
        RichTextBox2.BackColor = SystemColors.Control
        RichTextBox2.BorderStyle = BorderStyle.None
        RichTextBox2.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        RichTextBox2.Location = New Point(7, 96)
        RichTextBox2.Name = "RichTextBox2"
        RichTextBox2.Size = New Size(522, 50)
        RichTextBox2.TabIndex = 100
        RichTextBox2.Text = "To add an API, enter it in the textbox and click ""Add API"". The API will be added to the list, which will be cycled through when sending messages. You can enter the file by"' 
        ' btnIPQualityScore
        ' 
        btnIPQualityScore.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        btnIPQualityScore.Location = New Point(480, 241)
        btnIPQualityScore.Name = "btnIPQualityScore"
        btnIPQualityScore.Size = New Size(268, 39)
        btnIPQualityScore.TabIndex = 3
        btnIPQualityScore.Text = "Add API for Number Verification"
        btnIPQualityScore.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(7, 177)
        Label4.Name = "Label4"
        Label4.Size = New Size(396, 17)
        Label4.TabIndex = 100
        Label4.Text = "API for IP Quality Score to retrieve and validate phone numbers"' 
        ' txtIPQualityScore
        ' 
        txtIPQualityScore.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        txtIPQualityScore.Location = New Point(51, 210)
        txtIPQualityScore.Name = "txtIPQualityScore"
        txtIPQualityScore.Size = New Size(694, 25)
        txtIPQualityScore.TabIndex = 2
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(7, 218)
        Label5.Name = "Label5"
        Label5.Size = New Size(29, 17)
        Label5.TabIndex = 100
        Label5.Text = "API:"' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        LinkLabel1.LinkColor = Color.DarkViolet
        LinkLabel1.Location = New Point(548, 177)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(197, 17)
        LinkLabel1.TabIndex = 100
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "Get the IP Quality Score API here"' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.Location = New Point(14, 40)
        Label7.Name = "Label7"
        Label7.Size = New Size(41, 17)
        Label7.TabIndex = 100
        Label7.Text = "SMTP"' 
        ' txtSMTPbox
        ' 
        txtSMTPbox.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        txtSMTPbox.Location = New Point(57, 36)
        txtSMTPbox.Name = "txtSMTPbox"
        txtSMTPbox.PlaceholderText = "smtp.yourdomain.com"
        txtSMTPbox.Size = New Size(193, 25)
        txtSMTPbox.TabIndex = 4
        ' 
        ' txtPort
        ' 
        txtPort.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        txtPort.Location = New Point(304, 36)
        txtPort.Name = "txtPort"
        txtPort.PlaceholderText = "587"
        txtPort.Size = New Size(58, 25)
        txtPort.TabIndex = 5
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label8.Location = New Point(263, 40)
        Label8.Name = "Label8"
        Label8.Size = New Size(32, 17)
        Label8.TabIndex = 100
        Label8.Text = "Port"' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label9.Location = New Point(367, 40)
        Label9.Name = "Label9"
        Label9.Size = New Size(67, 17)
        Label9.TabIndex = 100
        Label9.Text = "EnableSSL"' 
        ' LinkLabel2
        ' 
        LinkLabel2.AutoSize = True
        LinkLabel2.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        LinkLabel2.LinkColor = Color.DarkViolet
        LinkLabel2.Location = New Point(7, 131)
        LinkLabel2.Name = "LinkLabel2"
        LinkLabel2.Size = New Size(80, 17)
        LinkLabel2.TabIndex = 100
        LinkLabel2.TabStop = True
        LinkLabel2.Text = "clicking here"' 
        ' cbEnableSSL
        ' 
        cbEnableSSL.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        cbEnableSSL.FormattingEnabled = True
        cbEnableSSL.Items.AddRange(New Object() {"Please Select", "True", "False"})
        cbEnableSSL.Location = New Point(436, 36)
        cbEnableSSL.Name = "cbEnableSSL"
        cbEnableSSL.Size = New Size(102, 25)
        cbEnableSSL.TabIndex = 6
        cbEnableSSL.Text = "Please Select"' 
        ' btnAddSMTP
        ' 
        btnAddSMTP.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        btnAddSMTP.Location = New Point(555, 33)
        btnAddSMTP.Name = "btnAddSMTP"
        btnAddSMTP.Size = New Size(145, 30)
        btnAddSMTP.TabIndex = 7
        btnAddSMTP.Text = "Save SMTP Details"
        btnAddSMTP.UseVisualStyleBackColor = True
        ' 
        ' btnAddEmailPass
        ' 
        btnAddEmailPass.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        btnAddEmailPass.Location = New Point(511, 86)
        btnAddEmailPass.Name = "btnAddEmailPass"
        btnAddEmailPass.Size = New Size(189, 30)
        btnAddEmailPass.TabIndex = 11
        btnAddEmailPass.Text = "Add Email and Password"
        btnAddEmailPass.UseVisualStyleBackColor = True
        ' 
        ' txtEmailAddresses
        ' 
        txtEmailAddresses.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        txtEmailAddresses.Location = New Point(14, 89)
        txtEmailAddresses.Name = "txtEmailAddresses"
        txtEmailAddresses.PlaceholderText = "oj.simpson@domain.com"
        txtEmailAddresses.Size = New Size(328, 25)
        txtEmailAddresses.TabIndex = 9
        ' 
        ' txtEmailPassword
        ' 
        txtEmailPassword.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        txtEmailPassword.Location = New Point(382, 89)
        txtEmailPassword.Name = "txtEmailPassword"
        txtEmailPassword.PlaceholderText = "iD1dnTd01T"
        txtEmailPassword.Size = New Size(105, 25)
        txtEmailPassword.TabIndex = 10
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Label10)
        GroupBox1.Controls.Add(txtPort)
        GroupBox1.Controls.Add(txtEmailPassword)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(txtEmailAddresses)
        GroupBox1.Controls.Add(txtSMTPbox)
        GroupBox1.Controls.Add(btnAddEmailPass)
        GroupBox1.Controls.Add(Label8)
        GroupBox1.Controls.Add(btnAddSMTP)
        GroupBox1.Controls.Add(cbEnableSSL)
        GroupBox1.Controls.Add(Label9)
        GroupBox1.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        GroupBox1.Location = New Point(7, 310)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(720, 136)
        GroupBox1.TabIndex = 37
        GroupBox1.TabStop = False
        GroupBox1.Text = "Email Information"' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(13, 127)
        Label10.Name = "Label10"
        Label10.Size = New Size(0, 17)
        Label10.TabIndex = 101
        ' 
        ' frmSettings
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(758, 503)
        ControlBox = False
        Controls.Add(LinkLabel2)
        Controls.Add(LinkLabel1)
        Controls.Add(btnIPQualityScore)
        Controls.Add(Label4)
        Controls.Add(txtIPQualityScore)
        Controls.Add(Label5)
        Controls.Add(RichTextBox2)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(lblLinkHome)
        Controls.Add(btnAddTextNowAPI)
        Controls.Add(Label6)
        Controls.Add(txtTextNowAPI)
        Controls.Add(Label1)
        Controls.Add(btnClose)
        Controls.Add(GroupBox1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "frmSettings"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Relentless SMS Settings"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnClose As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtTextNowAPI As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnAddTextNowAPI As Button
    Friend WithEvents lblLinkHome As LinkLabel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents RichTextBox2 As RichTextBox
    Friend WithEvents btnIPQualityScore As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txtIPQualityScore As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label7 As Label
    Friend WithEvents txtSMTPbox As TextBox
    Friend WithEvents txtPort As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents cbEnableSSL As ComboBox
    Friend WithEvents btnAddSMTP As Button
    Friend WithEvents btnAddEmailPass As Button
    Friend WithEvents txtEmailAddresses As TextBox
    Friend WithEvents txtEmailPassword As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label10 As Label
End Class
