<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBrowser
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(frmBrowser))
        TabControl1 = New TabControl()
        StatusStrip = New StatusStrip()
        StatusStripProgressBar = New ToolStripProgressBar()
        StatusStripStatusText = New ToolStripStatusLabel()
        WebView21 = New Microsoft.Web.WebView2.WinForms.WebView2()
        MenuStrip1 = New MenuStrip()
        FileToolStripMenuItem = New ToolStripMenuItem()
        CloseToolStripMenuItem = New ToolStripMenuItem()
        ToolStrip1 = New ToolStrip()
        NewToolStripButton = New ToolStripButton()
        OpenToolStripButton = New ToolStripButton()
        toolStripSeparator = New ToolStripSeparator()
        CutToolStripButton = New ToolStripButton()
        toolStripSeparator1 = New ToolStripSeparator()
        HelpToolStripButton = New ToolStripButton()
        ToolStripURL = New ToolStripComboBox()
        StatusStrip.SuspendLayout()
        CType(WebView21, ComponentModel.ISupportInitialize).BeginInit()
        MenuStrip1.SuspendLayout()
        ToolStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' TabControl1
        ' 
        TabControl1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        TabControl1.Location = New Point(0, 52)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(826, 392)
        TabControl1.TabIndex = 0
        ' 
        ' StatusStrip
        ' 
        StatusStrip.Items.AddRange(New ToolStripItem() {StatusStripProgressBar, StatusStripStatusText})
        StatusStrip.Location = New Point(0, 447)
        StatusStrip.Name = "StatusStrip"
        StatusStrip.Padding = New Padding(1, 0, 16, 0)
        StatusStrip.Size = New Size(826, 22)
        StatusStrip.TabIndex = 1
        StatusStrip.Text = "StatusStrip1"' 
        ' StatusStripProgressBar
        ' 
        StatusStripProgressBar.Name = "StatusStripProgressBar"
        StatusStripProgressBar.Size = New Size(100, 16)
        ' 
        ' StatusStripStatusText
        ' 
        StatusStripStatusText.Name = "StatusStripStatusText"
        StatusStripStatusText.Size = New Size(59, 17)
        StatusStripStatusText.Text = "Loading..."' 
        ' WebView21
        ' 
        WebView21.AllowExternalDrop = True
        WebView21.CreationProperties = Nothing
        WebView21.DefaultBackgroundColor = Color.White
        WebView21.Location = New Point(0, 76)
        WebView21.Name = "WebView21"
        WebView21.Size = New Size(826, 47)
        WebView21.TabIndex = 3
        WebView21.ZoomFactor = 1R
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {FileToolStripMenuItem, CloseToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(826, 24)
        MenuStrip1.TabIndex = 4
        MenuStrip1.Text = "MenuStrip1"' 
        ' FileToolStripMenuItem
        ' 
        FileToolStripMenuItem.Enabled = False
        FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        FileToolStripMenuItem.Size = New Size(37, 20)
        FileToolStripMenuItem.Text = "File"' 
        ' CloseToolStripMenuItem
        ' 
        CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        CloseToolStripMenuItem.Size = New Size(48, 20)
        CloseToolStripMenuItem.Text = "Close"' 
        ' ToolStrip1
        ' 
        ToolStrip1.Items.AddRange(New ToolStripItem() {NewToolStripButton, OpenToolStripButton, toolStripSeparator, CutToolStripButton, toolStripSeparator1, HelpToolStripButton, ToolStripURL})
        ToolStrip1.Location = New Point(0, 24)
        ToolStrip1.Name = "ToolStrip1"
        ToolStrip1.Size = New Size(826, 25)
        ToolStrip1.TabIndex = 5
        ToolStrip1.Text = "ToolStrip1"' 
        ' NewToolStripButton
        ' 
        NewToolStripButton.Image = My.Resources.Resources.icons8_back_arrow_50
        NewToolStripButton.ImageTransparentColor = Color.Magenta
        NewToolStripButton.Name = "NewToolStripButton"
        NewToolStripButton.Size = New Size(52, 22)
        NewToolStripButton.Text = "&Back"' 
        ' OpenToolStripButton
        ' 
        OpenToolStripButton.Image = My.Resources.Resources.icons8_forward_button_50
        OpenToolStripButton.ImageTransparentColor = Color.Magenta
        OpenToolStripButton.Name = "OpenToolStripButton"
        OpenToolStripButton.Size = New Size(70, 22)
        OpenToolStripButton.Text = "&Forward"' 
        ' toolStripSeparator
        ' 
        toolStripSeparator.Name = "toolStripSeparator"
        toolStripSeparator.Size = New Size(6, 25)
        ' 
        ' CutToolStripButton
        ' 
        CutToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        CutToolStripButton.Image = My.Resources.Resources.icons8_home_50
        CutToolStripButton.ImageTransparentColor = Color.Magenta
        CutToolStripButton.Name = "CutToolStripButton"
        CutToolStripButton.Size = New Size(23, 22)
        CutToolStripButton.Text = "C&ut"' 
        ' toolStripSeparator1
        ' 
        toolStripSeparator1.Name = "toolStripSeparator1"
        toolStripSeparator1.Size = New Size(6, 25)
        ' 
        ' HelpToolStripButton
        ' 
        HelpToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        HelpToolStripButton.Image = CType(resources.GetObject("HelpToolStripButton.Image"), Image)
        HelpToolStripButton.ImageTransparentColor = Color.Magenta
        HelpToolStripButton.Name = "HelpToolStripButton"
        HelpToolStripButton.Size = New Size(23, 22)
        HelpToolStripButton.Text = "He&lp"' 
        ' ToolStripURL
        ' 
        ToolStripURL.Name = "ToolStripURL"
        ToolStripURL.Size = New Size(500, 25)
        ' 
        ' frmBrowser
        ' 
        AutoScaleDimensions = New SizeF(8F, 16F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(826, 469)
        Controls.Add(ToolStrip1)
        Controls.Add(StatusStrip)
        Controls.Add(MenuStrip1)
        Controls.Add(TabControl1)
        Controls.Add(WebView21)
        Font = New Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MainMenuStrip = MenuStrip1
        Name = "frmBrowser"
        StartPosition = FormStartPosition.CenterScreen
        Text = "RSMS Browser Window"
        StatusStrip.ResumeLayout(False)
        StatusStrip.PerformLayout()
        CType(WebView21, ComponentModel.ISupportInitialize).EndInit()
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ToolStrip1.ResumeLayout(False)
        ToolStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents StatusStrip As StatusStrip
    Friend WithEvents WebView21 As Microsoft.Web.WebView2.WinForms.WebView2
    Friend WithEvents StatusStripProgressBar As ToolStripProgressBar
    Friend WithEvents StatusStripStatusText As ToolStripStatusLabel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents NewToolStripButton As ToolStripButton
    Friend WithEvents OpenToolStripButton As ToolStripButton
    Friend WithEvents toolStripSeparator As ToolStripSeparator
    Friend WithEvents CutToolStripButton As ToolStripButton
    Friend WithEvents toolStripSeparator1 As ToolStripSeparator
    Friend WithEvents HelpToolStripButton As ToolStripButton
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripURL As ToolStripComboBox
End Class
