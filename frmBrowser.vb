' 3/28/23
' Made by ░▒▓█│【MrBungle】│█▓▒░

Public Class FrmBrowser

    Private Sub FrmBrowser_Load(sender As Object, e As EventArgs)

        '' Hide the form
        'Me.Visible = False
        'Me.ShowInTaskbar = False
        'Me.Opacity = 0
        'Me.FormBorderStyle = FormBorderStyle.None

        ' StatusStripProgressBar
        StatusStripProgressBar.Style = ProgressBarStyle.Marquee
        StatusStripProgressBar.MarqueeAnimationSpeed = 75 ' Set a value that works well for you

    End Sub

    Private Sub StatusTextChanged()
        StatusStripStatusText.Text = CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).StatusText
    End Sub

    Private Sub CloseToolStripMenuItem_Click_1(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub ProgressChanged(sender As Object, e As Windows.Forms.WebBrowserProgressChangedEventArgs)
        StatusStripProgressBar.Value = (e.CurrentProgress / e.MaximumProgress) * 100
        If ToolStripURL.Focused = False Then
            ToolStripURL.Text = CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Url.ToString
        End If
    End Sub


    Private Sub frmBrowser_Close(sender As Object, e As EventArgs) Handles MyBase.FormClosed
        frmMain.txtOutgoingMessages.Text = ""
        frmMain.pbAllFunctions.Dispose()
    End Sub
End Class



