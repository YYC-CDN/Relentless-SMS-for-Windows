' 3/1/2023
' Made by ░▒▓█│【MrBungle】│█▓▒░

'  https://www.ipqualityscore.com/user/search
' https://www.ipqualityscore.com/user/phone-number-validation-api

Option Explicit On
Imports System.IO
Imports System.Net
Imports System.Text.RegularExpressions
Imports Microsoft.Web
Imports Newtonsoft.Json.Linq
Imports Microsoft.Web.WebView2.Core
Imports Microsoft.Web.WebView2.WinForms


Public Class frmMain
    Private imageFiles As String()
    Private random As New Random()

    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Text = "Relentless SMS V3.380 BETA"

        x.startup()

        x.buildfiles() ' If Needed. 

        ' Set directory path
        Dim directoryPath As String = "C:\RelentlessSMS"

        ' Enable the target number textbox for user input
        txtTargetNumber.ReadOnly = False

        ' Uncheck the cbImagesCheckbox on startup
        cbImagesCheckbox.Checked = False

        ' Clear this box on load. The text in there is sample for design. 
        txtVerificationResults.Clear()

        'Load default API from file
        Dim default_api As String = LoadAPI()


        ' Populate the dropdown box with the provider options
        dbSelectCellProvider.Text = "Select Carrier"
        'dbSelectCellProvider.Items.Add("Select Carrier")
        For Each provider In provider_options
            dbSelectCellProvider.Items.Add(provider.Key)
        Next

        ' Populate the dropdown box with the Language options
        dbOutgoingLanguage.Text = "English (Default)"
        'dbOutgoingLanguage.Items.Add("English (Default)")
        For Each language In language_options
            dbOutgoingLanguage.Items.Add(language.Key)
        Next

        txtTargetNumber.ForeColor = Color.FromArgb(209, 219, 221)
        txtNumberofMessages.ForeColor = Color.FromArgb(209, 219, 221)
        'lblMessRemain.ForeColor = Color.FromArgb(209, 219, 221)
        'lblBalance.ForeColor = Color.FromArgb(209, 219, 221)
        txtSecondsBetween.ForeColor = Color.FromArgb(209, 219, 221)

        txtVerificationResults.Text = "We want to emphasize that using this tool ethically and responsibly is of utmost importance. It is critical to research and verify your target before using this tool, as using it on someone without proper justification can have severe consequences. This tool is intended for educational or testing purposes only and should not be used to harm or harass anyone. This service is provided 'as is' and with no express or implied warranties, endorsements, or associations. We assume no responsibility for any damages or losses resulting from your use of this service. Let's always use technology with integrity and responsibility."
        'txtVerificationResults.Font = New Font("Verdana", 9)

        txtOpenTabs.Text = "25"

        Dim ipAddress As String = GetIPAddress()
        lblIPAddress.Text = ipAddress



    End Sub



    Private Function GetIPAddress() As String
        Dim hostName As String = System.Net.Dns.GetHostName()
        Dim ipEntry As System.Net.IPHostEntry = System.Net.Dns.GetHostEntry(hostName)
        Dim ipAddress As String = ipEntry.AddressList.FirstOrDefault(Function(a) a.AddressFamily = System.Net.Sockets.AddressFamily.InterNetwork).ToString()
        Return ipAddress
    End Function






    Private Function LoadAPI() As String
        'Read API from file
        Dim api As String = ""
        Try
            api = File.ReadAllText("C:\RelentlessSMS\APIs\TextNowAPI.txt")
        Catch ex As Exception
            MessageBox.Show("Error reading API file: " & ex.Message)
        End Try

        Return api
    End Function


    Private Sub txtTargetNumber_TextChanged(sender As Object, e As EventArgs) Handles txtTargetNumber.TextChanged
        ' Trim the whitespace from the input text
        Dim targetNumber As String = txtTargetNumber.Text.Trim()

        ' Enable or disable controls based on whether the input contains an "@" symbol
        btnSendSMS.Enabled = Not targetNumber.Contains("@")
        'dbOutgoingLanguage.Enabled = Not targetNumber.Contains("@")
        lblOutgoingLanguage.Enabled = Not targetNumber.Contains("@")
        lblSecondsBetween.Enabled = Not targetNumber.Contains("@")
        txtSecondsBetween.Enabled = Not targetNumber.Contains("@")
        btnVerifyNumber.Enabled = Not targetNumber.Contains("@")
        'lblMessRemain.Enabled = Not targetNumber.Contains("@")

        ' Enable or disable the "Email to SMS" button based on the input text
        If txtTargetNumber.Text.StartsWith("@") OrElse String.IsNullOrEmpty(txtTargetNumber.Text) Then
            btnEmailToSMS.Enabled = False ' Disable the button
        Else
            ' Check if the number of digits before "@" is at least 10
            Dim phoneNumber As String = txtTargetNumber.Text.Split({"@"}, StringSplitOptions.RemoveEmptyEntries)(0)
            btnEmailToSMS.Enabled = phoneNumber.Length >= 10 ' Enable or disable the button based on the phone number length
        End If
    End Sub

    Private Function ValidateNumber(number As String) As Boolean
        ' Add "+1" to the beginning of the number
        number = "+1" & number
        ' all the current and reserved toll-free area codes in the USA and Canada.
        Dim toll_free_pattern As String = "^\+1(800|822|833|844|855|866|877|880|881|882|883|884|885|886|887|888)[0-9]{7}$"

        If Regex.IsMatch(number, toll_free_pattern) Then
            ' Show error message if the phone number is a toll-free number
            MessageBox.Show("Cannot send SMS to toll-free numbers.")
            Return False
        End If
        Return True
    End Function

    Private Sub btnClose_Click_1(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnEmailToSMS_Click_1(sender As Object, e As EventArgs) Handles btnEmailToSMS.Click

        ' Check if the email address is empty or does not contain the "@" symbol
        If String.IsNullOrEmpty(txtTargetNumber.Text) OrElse Not txtTargetNumber.Text.Contains("@") Then
            MessageBox.Show("Please enter a valid target email address and cellular provider address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If


        ' Check if a cellular provider has been selected.
        If dbSelectCellProvider.SelectedItem IsNot Nothing Then
            ' Check if a target number has been entered.
            If txtTargetNumber.Text.Trim() <> "" Then
                ' Ask the user to verify the target number and number of messages.
                Dim verifyTargetNumber As DialogResult = MessageBox.Show("Is " & txtTargetNumber.Text & " the correct target number with " & txtNumberofMessages.Text & " messages?", "Confirm Target Number and Number of Messages", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                If verifyTargetNumber = DialogResult.Yes Then
                    ' Send the email message as SMS.
                    Dim selected_provider As String = dbSelectCellProvider.SelectedItem.ToString()
                    Try ' Windows 7 error 
                        SendEmailToSMS.sendemailtosms()
                    Catch ex As Exception
                        MessageBox.Show("Divide by Zero error Windows 7,", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End Try

                End If
            Else
                ' Notify the user to enter a target number.
                MessageBox.Show("Please enter a target number.")
            End If
        Else
            ' Notify the user to select a cellular provider.
            MessageBox.Show("Please Select a cellular provider.")
        End If

    End Sub

    Public Function IsValidEmail(email As String) As Boolean
        Try
            Dim mailAddress = New System.Net.Mail.MailAddress(email)
            Return mailAddress.Address = email
        Catch ex As Exception
            Return False
        End Try
    End Function


    Private Sub DbSelectCellProvider_SelectedIndexChanged(sender As Object, e As EventArgs) Handles dbSelectCellProvider.SelectedIndexChanged
        ' Get the selected provider option
        Dim selected_provider As String = dbSelectCellProvider.SelectedItem.ToString()
        ' Get the corresponding email domain from the provider options dictionary
        Dim email_domain As String = provider_options(selected_provider)

        ' Update the txtTargetNumber field with the email domain, if applicable
        If txtTargetNumber.Text.Contains("@") Then
            ' Replace the domain
            txtTargetNumber.Text = Regex.Replace(txtTargetNumber.Text, "@.*\.", email_domain & ".")
        Else
            ' Append the domain
            txtTargetNumber.Text = txtTargetNumber.Text & email_domain
        End If
    End Sub


    ' Define the provider options dictionary
    Dim provider_options As New Dictionary(Of String, String) From {
    {"Verizon", "@vtext.com"},
    {"AT&T", "@txt.att.net"},
    {"T-Mobile", "@tmomail.net"},
    {"Sprint", "@messaging.sprintpcs.com"},
    {"Google Fi", "@msg.fi.google.com"},
    {"Bell Canada", "@txt.bell.ca"},
    {"Rogers Wireless", "@sms.rogers.com"},
    {"Telus", "@msg.telus.com"},
    {"Onvoy", "@vtext.com"},
    {"MetroPCS", "@mymetropcs.com"},
    {"Cricket Wireless", "@mms.cricketwireless.net"},
    {"U.S. Cellular", "@email.uscc.net"},
    {"Virgin Mobile", "@vmobl.com"},
    {"Boost Mobile", "@sms.myboostmobile.com"},
    {"Fido", "@fido.ca"},
    {"Koodo Mobile", "@msg.koodomobile.com"},
    {"SaskTel Mobility", "@sms.sasktel.com"},
    {"MTS Mobility", "@text.mtsmobility.com"},
    {"Wind Mobile", "@txt.windmobile.ca"},
    {"Chatr Mobile", "@chatrwireless.com"},
    {"Freedom Mobile", "@txt.freedommobile.ca"},
    {"Public Mobile", "@msg.telus.com"},
    {"Videotron Mobile", "@mobiletxt.ca"},
    {"Eastlink", "@sms.eastlink.ca"},
    {"Tbaytel", "@tbayteltxt.net"},
    {"NorthernTel Mobility", "@sms.northerntelmobility.com"},
    {"PC Mobile", "@mobiletxt.ca"},
    {"Cityfone", "@txt.cityfone.net"},
    {"Zoomer Wireless", "@sms.zoomerwireless.ca"},
    {"SimplyConnect", "@mobiletxt.ca"},
    {"Lucky Mobile", "@txt.luckymobile.ca"},
    {"7-Eleven SpeakOut", "@sms.speakoutwireless.ca"},
    {"Petro-Canada Mobility", "@mobiletxt.ca"}
}

    ' Define the provider options dictionary
    Dim language_options As New Dictionary(Of String, String) From {
    {"English (Default)", "en"},
    {"Chinese", "zh"},
    {"Hindi", "hi"},
    {"Nigerian", "yo"}
    }
    '{"Punjabi", "pa"},
    '{"Russian", "ru"},
    '{"North Korean", "ko"},
    '{"Nigerian", "yo"},
    '{"International", "auto"}

    Private Sub btnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click
        Dim settingsForm As New frmSettings()
        settingsForm.Show()
    End Sub

    Private Sub txtTargetNumber_Click(sender As Object, e As EventArgs) Handles txtTargetNumber.Click

        ' Set the text color to 209, 219, 221- the off white color
        'txtTargetNumber.ForeColor = Color.FromArgb(209, 219, 221)

    End Sub

    Private Sub btnSendSMS_Click_1(sender As Object, e As EventArgs) Handles btnSendSMS.Click

        ' Sent over on 03/21/23
        SendSMS.SendSMS()


    End Sub

    Private Sub btnVerifyNumber_Click(sender As Object, e As EventArgs) Handles btnVerifyNumber.Click

        Try
            ' Show the spinning wheel cursor
            Me.UseWaitCursor = True
            ' Disable the button so the user cannot click it while the verification is in progress
            btnVerifyNumber.Enabled = False
            ' Read the API key from the text file.
            Dim apiKeyFilePath As String = "C:\RelentlessSMS\APIs\IPQualityScoreAPI.txt"
            Dim apiKey As String = ""

            If Not System.IO.File.Exists(apiKeyFilePath) Then
                MessageBox.Show("API key file not found. Please go to Settings and add one.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                Exit Sub
            End If

            apiKey = System.IO.File.ReadAllText(apiKeyFilePath).Trim()

            ' Set the default country code to +1 or USA/Canada.
            Dim countryCode As String = "1"

            ' Append country code to phone number if not already present.
            Dim phoneNumber As String = txtTargetNumber.Text.Trim()
            If Not phoneNumber.StartsWith("+") Then
                phoneNumber = "+" & countryCode & phoneNumber
            End If

            ' Build the API request URL.
            Dim apiUrl As String = "https://www.ipqualityscore.com/api/json/phone/" & apiKey & "/" & phoneNumber & "?strictness=1"

            ' Send the API request.
            Dim client As New WebClient()
            Dim responseJson As String = client.DownloadString(apiUrl)

            ' Parse the API response.
            Dim responseObj As JObject = JObject.Parse(responseJson)

            ' Display the verification results.
            txtVerificationResults.Text = "Active: " & responseObj("active").ToString() & vbCrLf
            txtVerificationResults.Text += "Fraud Score: " + responseObj("fraud_score").ToString() + vbCrLf
            txtVerificationResults.Text += "Recent Abuse: " + responseObj("recent_abuse").ToString() + vbCrLf
            txtVerificationResults.Text += "VOIP: " + responseObj("VOIP").ToString() + vbCrLf
            txtVerificationResults.Text += "Prepaid: " + responseObj("prepaid").ToString() + vbCrLf
            txtVerificationResults.Text += "Dialing Code: " + responseObj("dialing_code").ToString() + vbCrLf
            txtVerificationResults.Text += "Local Format: " + responseObj("local_format").ToString() + vbCrLf
            txtVerificationResults.Text += "Risky: " + responseObj("risky").ToString() + vbCrLf
            txtVerificationResults.Text += "Name: " + responseObj("name").ToString() + vbCrLf
            txtVerificationResults.Text += "Carrier: " + responseObj("carrier").ToString() + vbCrLf
            txtVerificationResults.Text += "Line Type: " + responseObj("line_type").ToString() + vbCrLf
            txtVerificationResults.Text += "Region: " + responseObj("region").ToString() + vbCrLf
            txtVerificationResults.Text += "City: " + responseObj("city").ToString() + vbCrLf
            txtVerificationResults.Text += "Zip Code: " + responseObj("zip_code").ToString() + vbCrLf
            txtVerificationResults.Text += "Leaked: " + responseObj("leaked").ToString() + vbCrLf
            txtVerificationResults.Text += "Spammer: " + responseObj("spammer").ToString() + vbCrLf
            txtVerificationResults.Text += "Do Not Call: " + responseObj("do_not_call").ToString() + vbCrLf

        Catch ex As WebException
            Dim response As HttpWebResponse = CType(ex.Response, HttpWebResponse)
            Dim responseContent As String = New StreamReader(response.GetResponseStream()).ReadToEnd()
            MessageBox.Show("API Error: " + responseContent)

        Catch ex As Exception
            MessageBox.Show("Error: " + ex.Message)
            ' Hide the hourglass cursor
            Cursor.Current = Cursors.Default
        End Try
        ' Hide the spinning wheel cursor and re-enable the button
        Me.UseWaitCursor = False
        btnVerifyNumber.Enabled = True

    End Sub

    Private counter As Integer = 0
    Private tabsToOpen As Integer = 0



    Private Async Sub btnMailbaitSubmit_Click(sender As Object, e As EventArgs) Handles btnMailbaitSubmit.Click


        ' Start the progress bar animation
        pbAllFunctions.Style = ProgressBarStyle.Marquee
        pbAllFunctions.MarqueeAnimationSpeed = 50 ' Set a value that works well for you

        txtOutgoingMessages.Text = "Currently submitting targets information to hundreds of spam outlets. Do not close. "

        ' Show the browser form
        frmBrowser.Show()

        ' Check if the email address is empty or does not contain the "@" symbol
        If String.IsNullOrEmpty(txtTargetNumber.Text) OrElse Not txtTargetNumber.Text.Contains("@") Then
            MessageBox.Show("Please enter a valid target email address and cellular provider address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If

        ' Set the number of tabs to open
        tabsToOpen = Integer.Parse(txtOpenTabs.Text)

        ' Loop to open multiple tabs
        For i As Integer = 1 To tabsToOpen
            ' Load the Mailbait website in a new tab
            Dim url As String = "http://mailbait.info/run.html"
            Dim tabPage As New TabPage("Tab " & i)
            Dim webView As New WebView2()
            tabPage.Controls.Add(webView)
            webView.Dock = DockStyle.Fill
            frmBrowser.TabControl1.TabPages.Add(tabPage)

            ' Wait for the WebView2 control to be initialized before navigating to the URL
            AddHandler webView.CoreWebView2InitializationCompleted,
            Async Sub(sender2 As Object, e2 As CoreWebView2InitializationCompletedEventArgs)
                Await webView.EnsureCoreWebView2Async(Nothing)
                webView.CoreWebView2.Navigate(url)

                ' Wait for the page to finish loading
                AddHandler webView.CoreWebView2.NavigationCompleted,
                    Sub(sender3 As Object, e3 As CoreWebView2NavigationCompletedEventArgs)
                        ' Find the input element for the email address field and set its value
                        Dim emailAddress As String = txtTargetNumber.Text.Trim()
                        webView.CoreWebView2.ExecuteScriptAsync(
                            $"document.getElementById('.mbe').value = '{emailAddress}'")

                        ' Find the "Run MailBait" button and simulate a click using JavaScript code, then un click the Catagories checkbox
                        webView.CoreWebView2.ExecuteScriptAsync(
     "var button = document.querySelector('input[value=""Run MailBait""]');" +
     "if (button) { button.click(); }" +
     "var checkbox = document.getElementById('categories1');" +
     "if (checkbox && checkbox.checked) { checkbox.click(); }")

                        ' Increment the counter
                        counter += 1

                        ' Check if all tabs have been opened
                        If counter = tabsToOpen Then

                        End If

                    End Sub
            End Sub
            Await webView.EnsureCoreWebView2Async(Nothing)
        Next

    End Sub






End Class










'    ' Launch the default browser and navigate to the webpage URL
'    Dim url As String = "http://mailbait.info/run.html"
'    Process.Start(New ProcessStartInfo With {.FileName = url, .UseShellExecute = True})



'    ' Wait for the page to load
'    Threading.Thread.Sleep(5000) ' You may need to adjust this delay depending on the page load time

'    ' Find the input element for the target number field and set its value
'    Dim targetNumber As String = txtTargetNumber.Text.Trim() ' Get the value of the txtTargetNumber text box
'Dim inputElement As HtmlElement = webBrowser1.Document.GetElementById(".mbe")
'If inputElement IsNot Nothing Then
'        inputElement.SetAttribute("value", targetNumber)
'        inputElement.InvokeMember("click") ' Click the input element to submit the form
'    End If








'   ===========================================================================================================================================


' Process.Start("cmd", $"/c start hProcess.Start("cmd", $"/c start https//textbelt.com/purchase/?generateKey=1")

' Process.Start("C:\Program Files\Google\Chrome Beta\Application\chrome.exe", "http://mailbait.info/run.html")

'Dim browserPath As String = "C:\Program Files\Google\Chrome Beta\Application\chrome.exe" ' Replace this with the path to your default browser executable file
'Process.Start(browserPath, "Process.Start("cmd", $"/c start https://textbelt.com/purchase/?generateKey=1")


'   ===========================================================================================================================================

'   'End Sub


' Dim url As String = "http://mailbait.info/run.html"
' Shell(url, AppWinStyle.MaximizedFocus)
