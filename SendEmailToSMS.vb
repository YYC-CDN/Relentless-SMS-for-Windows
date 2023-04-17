'03/21/23

Imports System.Net
Imports System.Net.Mail



Module SendEmailToSMS

    Public Sub sendemailtosms()

        ' Show the hourglass cursor
        ' Cursor.Current = Cursors.WaitCursor

        ' Read the SMTP configuration from the file
        Dim smtpConfig As String() = IO.File.ReadAllLines("C:\RelentlessSMS\EmailInformation\SMTP.txt")

        ' Set up SMTP client with SMTP server and port number
        Dim smtp As New SmtpClient(smtpConfig(0)) With {
    .Port = Integer.Parse(smtpConfig(1)),
    .EnableSsl = Boolean.Parse(smtpConfig(2))
}
        ' Read the email addresses and passwords from the file
        Dim email_list As New List(Of Dictionary(Of String, String))
        For Each line As String In IO.File.ReadAllLines("C:\RelentlessSMS\EmailInformation\EmailAddress.txt")
            Dim parts As String() = line.Split(" "c)
            If parts.Length >= 2 Then
                email_list.Add(New Dictionary(Of String, String) From {
            {"smtp_server", smtpConfig(0)},
            {"smtp_port", smtpConfig(1)},
            {"email", parts(0)},
            {"password", parts(1)}
        })
            Else
                ' handle invalid line format
            End If
        Next

        ' Get the target email address and number of messages to send from textboxes
        Dim target_email As String = frmMain.txtTargetNumber.Text
        Dim num_of_messages As Integer = CInt(frmMain.txtNumberofMessages.Text)

        ' Set the minimum and maximum values of the progress bar
        frmMain.pbAllFunctions.Minimum = 0
        frmMain.pbAllFunctions.Maximum = num_of_messages

        ' Set the folder path for the images
        Dim folder_path As String = "C:\RelentlessSMS\OutgoingImages\"

        ' Get the list of files in the folder
        Dim files As String() = System.IO.Directory.GetFiles(folder_path)

        ' Read the lines from the AntiCrimeEmail.txt file
        Dim message_lines As String() = System.IO.File.ReadAllLines("C:\RelentlessSMS\AntiCrimeMessages\AntiCrimeEnglish.txt")

        ' Counter variable for the index of the current image to be attached
        Dim current_image_index As Integer = 0

        For i As Integer = 0 To num_of_messages - 1

            ' Clear the outgoing messages textbox before sending the current message
            frmMain.txtOutgoingMessages.Clear()
            ' Update the progress bar value
            frmMain.pbAllFunctions.Value = i

            ' Get the current message and email details
            Dim message As String = message_lines(i Mod message_lines.Length)
            Dim email_index As Integer = i Mod email_list.Count
            Dim smtp_server As String = email_list(email_index)("smtp_server")
            Dim smtp_port As Integer = CInt(email_list(email_index)("smtp_port"))
            Dim email As String = email_list(email_index)("email")
            Dim password As String = email_list(email_index)("password")

            Try
                ' Send the email
                Dim client As New SmtpClient(smtp_server, smtp_port)
                client.EnableSsl = True
                client.Credentials = New NetworkCredential(email, password)
                Dim mail As New MailMessage()
                mail.From = New MailAddress(email)
                mail.To.Add(target_email)
                mail.Subject = "/"
                mail.Body = message

                ' Attach the current image to the email if the cbImagesCheckbox is checked
                If frmMain.cbImagesCheckbox.Checked Then
                    Dim attachment As New Attachment(files(current_image_index))
                    mail.Attachments.Add(attachment)

                    ' Increment the counter variable for the index of the current image
                    current_image_index = (current_image_index + 1) Mod files.Length
                End If

                client.Send(mail)

                ' Update the outgoing messages textbox with the current message
                frmMain.txtOutgoingMessages.AppendText(message & Environment.NewLine)
            Catch ex As Exception
                MessageBox.Show("                                    " & ex.Message)
            End Try

            ' Increment progress bar value
            frmMain.pbAllFunctions.Increment(1)
        Next
        ' Reset the progress bar value
        frmMain.pbAllFunctions.Value = 0
        ' Show the success message
        ' MessageBox.Show("Mail Sent.         ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

End Module
