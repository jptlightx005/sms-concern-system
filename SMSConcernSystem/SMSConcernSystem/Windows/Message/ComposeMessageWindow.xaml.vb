﻿Public Class ComposeMessageWindow
    Public recipients As List(Of ContactInformation)

    Private Sub Window_Loaded(sender As Object, e As RoutedEventArgs)
        If recipients.Count > 0 Then
            txtRecipients.Text = ""
            For Each contact In recipients
                txtRecipients.Text += String.Format("{0} {1} ({2}),", contact.firstName, contact.lastName, contact.contactNo)
            Next
            If txtRecipients.Text.Length > 0 Then
                txtRecipients.Text = txtRecipients.Text.Substring(0, txtRecipients.Text.Length - 1)
            End If
        End If
    End Sub

    Private Sub btnSend_Click(sender As Object, e As RoutedEventArgs) Handles btnSend.Click
        If Not txtMessage.Text = String.Empty Then
            If SendMessage(txtMessage.Text, recipients) Then
                MsgBox("Successfully sent!", vbInformation)
            Else
                MsgBox("Failed to send messages!", vbExclamation)
            End If
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As RoutedEventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class
