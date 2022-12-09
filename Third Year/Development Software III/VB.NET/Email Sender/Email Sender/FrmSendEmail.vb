Imports System.Net
Imports System.Net.Mail
Public Class FrmSendEmail
    Private Sub BtnSend_Click(sender As Object, e As EventArgs) Handles BtnSend.Click
        Dim body, subject, receiverEmail As String
        subject = txtSubject.Text.Trim()
        receiverEmail = txtTo.Text.Trim()
        body = txtBody.Text.Trim()


        Dim smtpServer As SmtpClient
        'Login
        Try
            smtpServer = New SmtpClient("smtp.office365.com")
            smtpServer.Port = 587
            smtpServer.EnableSsl = True
            smtpServer.UseDefaultCredentials = False
            smtpServer.Credentials = New NetworkCredential("ATAL-Brains@hotmail.com", "Qzmp@012")
            smtpServer.DeliveryMethod = SmtpDeliveryMethod.Network

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Login", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End Try


        'Prepare Body

        Try
            Dim Message = New MailMessage()
            Message.From = New MailAddress("ATAL-Brains@hotmail.com", "ATAL Brains")
            Message.To.Add(receiverEmail)
            Message.Bcc.Add("christoph.percival@outlook.com")
            Message.Subject = subject
            'Message.IsBodyHtml = True 'To make message body As html  
            Message.Body = body

            'Send Email
            smtpServer.Send(Message)

            MessageBox.Show("Email Sent Successfully", "Sending Email", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Sending Email", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End Try

    End Sub
End Class
