Public NotInheritable Class frmAbout

    Private Sub AboutBox1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Set the title of the form.
        Dim ApplicationTitle As String
        If My.Application.Info.Title <> "" Then
            ApplicationTitle = My.Application.Info.Title
        Else
            ApplicationTitle = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If
        Me.Text = String.Format("About {0}", ApplicationTitle)
        ' Initialize all of the text displayed on the About Box.
        ' TODO: Customize the application's assembly information in the "Application" pane of the project 
        '    properties dialog (under the "Project" menu).
        Me.LabelProductName.Text = "Product Name: Additional Controls"
        Me.LabelVersion.Text = "Version: 1.0"
        Me.LabelCopyright.Text = "Copyright: " & Convert.ToChar(169) & " 2021 Soulistic Tech PTY (Ltd)"
        Me.LabelCompanyName.Text = "Company Name: " & "Soulistic Tech PTY (Ltd)"
        Me.TextBoxDescription.Text = "Additional Controls App Is An App To Test Other Controls Which Are Found In The ToolBox" &
            System.Environment.NewLine & System.Environment.NewLine & "CONTROLS:" & System.Environment.NewLine &
            "1. Masked TextBox" & System.Environment.NewLine &
            "2. Group Box" & System.Environment.NewLine &
            "3. CheckBox" & System.Environment.NewLine &
            "4. Radio Button" & System.Environment.NewLine &
            "5. Combo Box" & System.Environment.NewLine &
            "6. Timer " & System.Environment.NewLine &
            "7. MenuStrip" & System.Environment.NewLine &
            "8. Picture Box" & System.Environment.NewLine &
            "9. Horizontal Scroll Bar" & System.Environment.NewLine &
            "10. Vertical Scroll Bar" & System.Environment.NewLine & System.Environment.NewLine &
            "It Is Also Used To Test Multiple Forms"

    End Sub

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        frmLogin.ShowDialog()
    End Sub

End Class
