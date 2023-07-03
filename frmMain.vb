' 3/1/2023
' Made by ░▒▓█│【MrBungle】│█▓▒░

'  https://www.ipqualityscore.com/user/search
' https://www.ipqualityscore.com/user/phone-number-validation-api

Option Explicit On
Imports System.IO
Imports System
Imports System.Net
Imports System.Net.Http
Imports System.Text
Imports System.Text.RegularExpressions
Imports Newtonsoft.Json.Linq
Imports SHDocVw
Imports Microsoft.Web.WebView2.Core
Imports Microsoft.Web
Imports System.Threading
Imports Microsoft.Web.WebView2.WinForms
Imports System.Diagnostics.Metrics
Imports Newtonsoft.Json.Serialization
Imports System.Diagnostics


Public Class frmMain
    Private imageFiles As String()
    Private random As New Random()
    ' Declare provider_options at the class level
    Private provider_options As Dictionary(Of String, List(Of String))

    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Me.Text = "V3.760 BETA | FOR GOVERNMENT USE ONLY | NON GOV'T USE PROHIBITED "
        x.startup()
        x.buildfiles() ' If Needed. 
        Dim directoryPath As String = "C:\RelentlessSMS" ' Set directory path
        txtTargetNumber.ReadOnly = False    ' Enable the target number textbox for user input
        cbImagesCheckbox.Checked = False ' Uncheck the cbImagesCheckbox on startup
        txtVerificationResults.Clear()  ' Clear this box on load. The text in there is sample for design. 
        Dim default_api As String = LoadAPI()  'Load default API from file
        Dim apiProxy As String = LoadProxyDetectionAPI()
        dbOutgoingLanguage.Text = "English (Default)"   ' Populate the dropdown box with the Language options
        For Each language In language_options
            dbOutgoingLanguage.Items.Add(language.Key)
        Next
        txtTargetNumber.ForeColor = Color.FromArgb(209, 219, 221)
        txtNumberofMessages.ForeColor = Color.FromArgb(209, 219, 221)
        txtSecondsBetween.ForeColor = Color.FromArgb(209, 219, 221)
        txtVerificationResults.Text = "We want to emphasize that using this tool ethically and responsibly is of utmost importance. It is critical to research and verify your target before using this tool, as using it on someone without proper justification can have severe consequences. This tool is intended for educational or testing purposes only and should not be used to harm or harass anyone. This service is provided 'as is' and with no express or implied warranties, endorsements, or associations. We assume no responsibility for any damages or losses resulting from your use of this service. Let's always use technology with integrity and responsibility."
        txtOpenTabs.Text = "75"
        provider_options = New Dictionary(Of String, List(Of String))() ' Read the provider options from the text file
        For Each line As String In File.ReadLines("C:\RelentlessSMS\Providers.txt") ' Read the file line by line and process valid entries
            If Not line.StartsWith("#") AndAlso Not String.IsNullOrWhiteSpace(line) Then  ' Ignore lines starting with a hash symbol or empty lines
                Dim parts As String() = line.Split(","c)   ' Split the line into provider name and email domain
                If parts.Length = 2 Then
                    ' Trim leading/trailing whitespaces
                    Dim provider As String = parts(0).Trim()
                    Dim emailDomain As String = parts(1).Trim()
                    If provider_options.ContainsKey(provider) Then   ' Check if the provider key already exists in the dictionary
                        ' If the key exists, add the email domain to the existing list
                        provider_options(provider).Add(emailDomain)
                    Else
                        provider_options.Add(provider, New List(Of String) From {emailDomain}) ' If the key doesn't exist, create a new list and add the email domain
                    End If
                End If
            End If
        Next
        ' Populate the dbSelectCellProvider ComboBox
        dbSelectCellProvider.Items.AddRange(provider_options.Keys.ToArray())
        ' all the IP bullshit
        Try
            FetchProxyDetails()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Async Function GetIPAddressAsync() As Task(Of String)
        Dim ipAddress As String = ""
        Try
            ' Use a web service to get the public IP address asynchronously
            Using client As New WebClient()
                Dim response As String = Await client.DownloadStringTaskAsync("https://api.ipify.org")
                ipAddress = response.Trim()
            End Using
        Catch ex As Exception
            ' Handle the exception as per your requirement
            ' Display an error message or take appropriate action
            ' You can also set a default IP address in case of failure
        End Try
        Return ipAddress
    End Function

    Private Async Sub FetchProxyDetails()
        ' Read the API key from the text file.
        Dim apiKeyFilePath As String = "C:\RelentlessSMS\APIs\IPQualityScoreAPI.txt"
        Dim apiKey As String = ""

        If Not File.Exists(apiKeyFilePath) Then
            MessageBox.Show("API key file not found. Please go to Settings and add one. Basic use keys are no cost.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        apiKey = File.ReadAllText(apiKeyFilePath).Trim()

        ' Build the API request URL.
        Dim ipAddress As String = Await GetIPAddressAsync()
        Dim apiUrl As String = $"https://www.ipqualityscore.com/api/json/ip/{apiKey}/{ipAddress}"

        ' Send the API request.
        Try
            Using client As New WebClient()
                Dim responseJson As String = Await client.DownloadStringTaskAsync(apiUrl)

                ' Parse the API response.
                Dim responseObj As JObject = JObject.Parse(responseJson)

                ' Get the proxy detection data from the response.
                Dim proxyValue As String = responseObj("proxy")?.ToString()
                Dim countryCodeValue As String = responseObj("country_code")?.ToString()
                Dim regionValue As String = responseObj("region")?.ToString()
                Dim vpnValue As String = responseObj("vpn")?.ToString()

                ' Display the proxy detection information.
                lblVPN.Text = "VPN: " & If(Not String.IsNullOrEmpty(vpnValue), vpnValue, "Not Available")
                lblRegion.Text = "Region: " & If(Not String.IsNullOrEmpty(regionValue), regionValue, "Not Available")
                lblProxy.Text = "Proxy: " & If(Not String.IsNullOrEmpty(proxyValue), proxyValue, "Not Available")
                lblCountryCode.Text = "Country Code: " & If(Not String.IsNullOrEmpty(countryCodeValue), countryCodeValue, "Not Available")
            End Using
        Catch ex As WebException
            Dim response As HttpWebResponse = CType(ex.Response, HttpWebResponse)
            If response.StatusCode = HttpStatusCode.NotFound Then
                MessageBox.Show("API URL not found. Please check the URL and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MessageBox.Show("API Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

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

    Private Function LoadProxyDetectionAPI() As String
        'Read API from file
        Dim apiProxy As String = ""
        Try
            apiProxy = File.ReadAllText("C:\RelentlessSMS\APIs\IPQualityScoreAPI.txt")
        Catch ex As Exception
            MessageBox.Show("Error reading API file: " & ex.Message)
        End Try

        Return apiProxy
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
        If targetNumber.StartsWith("@") OrElse String.IsNullOrEmpty(targetNumber) Then
            btnEmailToSMS.Enabled = False ' Disable the button
        Else
            ' Check if the number of digits before "@" is at least 10
            Dim phoneNumber As String = targetNumber.Split({"@"}, StringSplitOptions.RemoveEmptyEntries)(0)
            btnEmailToSMS.Enabled = phoneNumber.Length >= 5 ' Enable or disable the button based on the phone number length
        End If

        ' Enable or disable the "btnEmailValidation" button based on the input text
        If targetNumber.StartsWith("@") OrElse String.IsNullOrEmpty(targetNumber) Then
            btnEmailValidation.Enabled = False ' Disable the button
        Else
            ' Check if the number of digits before "@" is at least 10
            Dim phoneNumber As String = targetNumber.Split({"@"}, StringSplitOptions.RemoveEmptyEntries)(0)
            btnEmailValidation.Enabled = phoneNumber.Length >= 5 ' Enable or disable the button based on the phone number length
        End If

        ' Enable or disable the "Mailbait Submit" button based on the presence of the "@" symbol
        btnMailbaitSubmit.Enabled = targetNumber.Contains("@")

        ' Enable or disable the "Mail Check Submit" button based on the presence of the "@" symbol
        btnEmailValidation.Enabled = targetNumber.Contains("@")

        ' Check if the input contains at least 10 numbers before enabling the buttons
        Dim numericInput As String = New String(targetNumber.Where(Function(c) Char.IsDigit(c)).ToArray())
        Dim hasTenDigits As Boolean = numericInput.Length >= 5
        btnSendSMS.Enabled = btnSendSMS.Enabled AndAlso hasTenDigits
        btnEmailToSMS.Enabled = btnEmailToSMS.Enabled AndAlso hasTenDigits
        btnVerifyNumber.Enabled = btnVerifyNumber.Enabled AndAlso hasTenDigits
        btnEmailValidation.Enabled = btnEmailValidation.Enabled AndAlso hasTenDigits
    End Sub

    Private Sub cbImagesCheckbox_CheckedChanged(sender As Object, e As EventArgs) Handles cbImagesCheckbox.CheckedChanged
        ' Enable or disable the buttons based on the checked state of cbImagesCheckbox
        If cbImagesCheckbox.Checked Then
            btnEmailToSMS.Enabled = True ' Enable the btnEmailToSMS button
            btnSendSMS.Enabled = False ' Disable other buttons
            btnMailbaitSubmit.Enabled = False
            btnVerifyNumber.Enabled = False
            btnEmailValidation.Enabled = False
            ' ... disable other buttons as needed
        Else
            btnEmailToSMS.Enabled = False ' Disable the btnEmailToSMS button
            btnSendSMS.Enabled = False ' Disable other buttons
            btnMailbaitSubmit.Enabled = False
            btnVerifyNumber.Enabled = False
            btnEmailValidation.Enabled = False
            ' ... disable other buttons as needed
        End If
        'btnSettings.Enabled = False ' Disable the Settings button
        'btnClose.Enabled = False ' Disable the Close button
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

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.Exit()
    End Sub

    Private Sub btnEmailToSMS_Click(sender As Object, e As EventArgs) Handles btnEmailToSMS.Click
        ' Show the spinning wheel cursor
        Me.UseWaitCursor = True
        ' Check if the email address is empty or does not contain the "@" symbol
        If String.IsNullOrEmpty(txtTargetNumber.Text) OrElse Not txtTargetNumber.Text.Contains("@") Then
            MessageBox.Show("Please enter a valid target email address OR cellular provider address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
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
                    SendEmailToSMS.sendemailtosms()
                    'Task.Run(Sub() SendEmailToSMS())
                End If
            Else
                ' Notify the user to enter a target number.
                MessageBox.Show("Please enter a target number.")
            End If
        Else
            ' Notify the user to select a cellular provider.
            MessageBox.Show("Please select a cellular provider.")
        End If
        ' Hide the spinning wheel cursor and re-enable the button
        Me.UseWaitCursor = False

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
        ' Get the corresponding email domains list from the provider options dictionary
        Dim email_domains As List(Of String) = provider_options(selected_provider)

        ' Select the first email domain from the list
        Dim email_domain As String = email_domains(0)

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
    Dim language_options As New Dictionary(Of String, String) From {
    {"English (Default)", "en"},
    {"Chinese", "zh"},
    {"Hindi", "hi"}
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

    Private Sub btnSendSMS_Click(sender As Object, e As EventArgs) Handles btnSendSMS.Click
        ' Show the spinning wheel cursor
        Me.UseWaitCursor = True
        ' Check if the target number textbox is empty
        If String.IsNullOrEmpty(txtTargetNumber.Text.Trim()) Then
            MessageBox.Show("Please enter a target number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If

        ' Ask for confirmation of the number of messages to be sent
        Dim numberOfMessages As Integer
        If Integer.TryParse(txtNumberofMessages.Text, numberOfMessages) Then
            Dim confirmationMessage As String = $"Are you sure you want to send {numberOfMessages} messages to {txtTargetNumber.Text}?"
            Dim confirmDialog As DialogResult = MessageBox.Show(confirmationMessage, "Confirm Message Sending", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)

            If confirmDialog = DialogResult.Yes Then
                ' Sent over on 03/21/23
                SendSMS.SendSMS()
            End If
        Else
            MessageBox.Show("Invalid number of messages.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
        ' Hide the spinning wheel cursor and re-enable the button
        Me.UseWaitCursor = False
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
                MessageBox.Show("API key file not found. Please go to Settings and add one. Basic use keys are no cost. ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
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
            txtVerificationResults.Text += "User Activity: " + responseObj("user_activity").ToString() + vbCrLf
            txtVerificationResults.Text += "Message: " + responseObj("message").ToString() + vbCrLf
            txtVerificationResults.Text += "Errors: " + responseObj("errors").ToString() + vbCrLf
            txtVerificationResults.Text += "Associated emails found: " + responseObj("associated_email_addresses").ToString() + vbCrLf
            txtVerificationResults.Text += "END " + vbCrLf


        Catch ex As WebException
            Dim response As HttpWebResponse = CType(ex.Response, HttpWebResponse)
            Dim responseContent As String = New StreamReader(response.GetResponseStream()).ReadToEnd()
            MessageBox.Show("API Error: " + responseContent)

        Catch ex As Exception
            'MessageBox.Show("Error: " + ex.Message)
        End Try
        ' Hide the spinning wheel cursor and re-enable the button
        Me.UseWaitCursor = False
        btnVerifyNumber.Enabled = True

    End Sub



    Private counter As Integer = 0
    Private tabsToOpen As Integer = 0


    Private Async Sub btnMailbaitSubmit_Click(sender As Object, e As EventArgs) Handles btnMailbaitSubmit.Click
        ' Show the spinning wheel cursor
        Me.UseWaitCursor = True



        'If frmSettings.cbShowBrowser.Checked Then
        '    frmBrowser.Show()
        'Else
        '    frmBrowser.Hide()
        'End If
        Try
            Dim openTabsCount As Integer = 0
            If Integer.TryParse(txtOpenTabs.Text, openTabsCount) Then
                Dim message As String = "IMPORTANT! Activate your VPN before proceeding. If you don't, you'll BLAST YOUR IP TO THE TARGET!" & vbCrLf &
                                        "You have selected " & openTabsCount.ToString() & " open session(s)." & vbCrLf &
                                    "To emphasize the seriousness of the matter, open a significant number of sessions (approximately 50-75) over the course of 48 to 72 hours." & vbCrLf &
                "This extended duration will undoubtedly leave a lasting impact to your target." & vbCrLf &
                "Click 'Yes' to continue or 'No' to cancel."

                Dim result As DialogResult = MessageBox.Show(message, "VPN Reminder To Set", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

                ' Continue with the logic based on the user's response
                If result = DialogResult.Yes Then
                    ' Start the progress bar animation
                    pbAllFunctions.Style = ProgressBarStyle.Marquee
                    pbAllFunctions.MarqueeAnimationSpeed = 50 ' Set a value that works well for you

                    txtOutgoingMessages.Text = "Currently submitting targets information to hundreds of spam outlets. Do not close. "

                    ' Show the browser form
                    'frmBrowser.Show()


                    Dim frmBrowser As New frmBrowser()
                    frmBrowser.Visible = False ' Set the Visible property to False

                    ' Check if the email address is empty or does not contain the "@" symbol
                    If String.IsNullOrEmpty(txtTargetNumber.Text) OrElse Not txtTargetNumber.Text.Contains("@") Then
                        MessageBox.Show("Please enter a valid target email address or cellular provider address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
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
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        ' Hide the spinning wheel cursor and re-enable the button
        Me.UseWaitCursor = False
    End Sub




    Private Sub btnEmailValidation_Click(sender As Object, e As EventArgs) Handles btnEmailValidation.Click

        ' Show the spinning wheel cursor
        Me.UseWaitCursor = True
        ' Disable the button so the user cannot click it while the verification is in progress
        btnEmailValidation.Enabled = False
        ' Read the API key from the text file.
        Try
            ' Read the API key from the text file.
            Dim apiKeyFilePath As String = "C:\RelentlessSMS\APIs\IPQualityScoreAPI.txt"
            Dim apiKey As String = ""

            If Not File.Exists(apiKeyFilePath) Then
                MessageBox.Show("API key file not found. Please go to Settings and add one.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            apiKey = File.ReadAllText(apiKeyFilePath).Trim()

            ' Set the email address to verify.
            Dim emailAddress As String = txtTargetNumber.Text.Trim()

            ' Build the API request URL.
            Dim apiUrl As String = $"https://www.ipqualityscore.com/api/json/email/{apiKey}/{emailAddress}"

            ' Send the API request.
            Dim client As New WebClient()
            Dim responseJson As String = client.DownloadString(apiUrl)

            ' Parse the API response.
            Dim responseObj As JObject = JObject.Parse(responseJson)

            ' Display the verification results.
            txtVerificationResults.Text = "Valid: " & responseObj("valid").ToString() & vbCrLf
            txtVerificationResults.Text += "Disposable: " & responseObj("disposable").ToString() & vbCrLf
            txtVerificationResults.Text += "Deliverability: " & responseObj("deliverability").ToString() & vbCrLf
            txtVerificationResults.Text += "Catch All: " & responseObj("catch_all").ToString() & vbCrLf
            txtVerificationResults.Text += "Leaked: " & responseObj("leaked").ToString() & vbCrLf
            txtVerificationResults.Text += "Suspect: " & responseObj("suspect").ToString() & vbCrLf
            txtVerificationResults.Text += "SMTP Score: " & responseObj("smtp_score").ToString() & vbCrLf
            txtVerificationResults.Text += "Overall Score: " & responseObj("overall_score").ToString() & vbCrLf
            txtVerificationResults.Text += "First Name: " & responseObj("first_name").ToString() & vbCrLf
            txtVerificationResults.Text += "Common: " & responseObj("common").ToString() & vbCrLf
            txtVerificationResults.Text += "Generic: " & responseObj("generic").ToString() & vbCrLf
            txtVerificationResults.Text += "DNS Valid: " & responseObj("dns_valid").ToString() & vbCrLf
            txtVerificationResults.Text += "Honeypot: " & responseObj("honeypot").ToString() & vbCrLf
            txtVerificationResults.Text += "Spam Trap Score: " & responseObj("spam_trap_score").ToString() & vbCrLf
            txtVerificationResults.Text += "Fraud Score: " & responseObj("fraud_score").ToString() & vbCrLf
            txtVerificationResults.Text += "Recent Abuse: " & responseObj("recent_abuse").ToString() & vbCrLf
            txtVerificationResults.Text += "Frequent Complainer: " & responseObj("frequent_complainer").ToString() & vbCrLf
            txtVerificationResults.Text += "Sanitized Email: " & responseObj("sanitized_email").ToString() & vbCrLf
            txtVerificationResults.Text += "User Activity: " & responseObj("user_activity").ToString() & vbCrLf
            txtVerificationResults.Text += "Domain Velocity: " & responseObj("domain_velocity").ToString() & vbCrLf
            'txtVerificationResults.Text += "Associated Names: " & responseObj("associated_names").ToString() & vbCrLf
            'txtVerificationResults.Text += "Associated Phone Numbers: " & responseObj("associated_phone_numbers").ToString() & vbCrLf
            txtVerificationResults.Text += "END " + vbCrLf





        Catch ex As WebException
            Dim response As HttpWebResponse = CType(ex.Response, HttpWebResponse)
            Dim responseContent As String = New StreamReader(response.GetResponseStream()).ReadToEnd()
            MessageBox.Show("API Error: " + responseContent)

        Catch ex As Exception
            'MessageBox.Show("Error: " + ex.Message)
        End Try
        ' Hide the spinning wheel cursor and re-enable the button
        Me.UseWaitCursor = False
        btnEmailValidation.Enabled = True

    End Sub

    Private Sub btnInternalEmailSend_Click(sender As Object, e As EventArgs) Handles btnInternalEmailSend.Click
        ' Show the spinning wheel cursor
        Me.UseWaitCursor = True

        ' Start the progress bar animation
        pbAllFunctions.Style = ProgressBarStyle.Marquee
        pbAllFunctions.MarqueeAnimationSpeed = 100 ' Set a value that works well for you

        txtOutgoingMessages.Text = "Currently submitting targets information to hundreds of spam outlets. Do not close. "



        'Start the internal mass email program 06/28/23
        InternalMaillistSubscriber.EmailSend()
        'Console.ReadLine() ' Wait for user input before closing the console window



    End Sub

    Private Sub btnStopAll_Click(sender As Object, e As EventArgs) Handles btnStopAll.Click

        If frmBrowser.Visible = True Then
            frmBrowser.Close()
        End If
        ' Clear this box on load. The text in there is sample for design. 
        'txtVerificationResults.Clear()
        'Application.Exit()
        Me.UseWaitCursor = False

    End Sub
End Class





'Imports System.Diagnostics

'Private Sub btnMailbaitSubmit_Click(sender As Object, e As EventArgs) Handles btnMailbaitSubmit.Click
'    ' Start the progress bar animation
'    pbAllFunctions.Style = ProgressBarStyle.Marquee
'    pbAllFunctions.MarqueeAnimationSpeed = 50

'    txtOutgoingMessages.Text = "Currently submitting targets information to hundreds of spam outlets. Do not close."

'    ' Validate email address
'    If String.IsNullOrEmpty(txtTargetNumber.Text) OrElse Not txtTargetNumber.Text.Contains("@") Then
'        MessageBox.Show("Please enter a valid target email address and cellular provider address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
'        Return
'    End If

'    ' Set the number of tabs to open
'    tabsToOpen = Integer.Parse(txtOpenTabs.Text)

'    ' Open multiple tabs
'    For i As Integer = 1 To tabsToOpen
'        Dim url As String = "http://mailbait.info/run.html"
'        Dim psi As New ProcessStartInfo(url) With {.UseShellExecute = True}
'        Process.Start(psi)
'    Next
'End Sub

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
