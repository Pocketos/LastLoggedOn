Public Module GlobalVariables
    Public userkey As String
End Module

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        userkey = My.Computer.Registry.GetValue(
                "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Authentication\LogonUI", "LastLoggedOnUser", Nothing)
        txt_username.Text = userkey

    End Sub

    Private Sub btn_replace_Click(sender As Object, e As EventArgs) Handles btn_replace.Click
        userkey = txt_username.Text
        Try
            My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Authentication\LogonUI", "LastLoggedOnUser", userkey)
        Catch Exc As System.UnauthorizedAccessException
            MsgBox("An permission error has occured.  Is this application being run as Administrator?", , "!")
        End Try
    End Sub

    Private Sub btn_check_Click(sender As Object, e As EventArgs) Handles btn_check.Click
        If My.Computer.Registry.GetValue(
                "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Authentication\LogonUI", "LastLoggedOnUser", Nothing) Is Nothing Then
            MsgBox("Value Doen't Exist", , My.Application.Info.AssemblyName.ToString)
        End If
        MsgBox(userkey)
    End Sub

    Private Sub btn_logoff_Click(sender As Object, e As EventArgs) Handles btn_logoff.Click
        Shell("shutdown -l")
    End Sub

    Private Sub btn_help_Click(sender As Object, e As EventArgs) Handles btn_help.Click
        MsgBox("Click Check Vaue to see the currently last logged on user." & Environment.NewLine & "Click Replace to change the currently Last Logged on User to whatever is in the text box" & Environment.NewLine & "Click Loggout once the value is replaced to logout.", , My.Application.Info.AssemblyName.ToString & " --Help")
    End Sub
End Class
