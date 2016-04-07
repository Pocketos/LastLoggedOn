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
        My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Authentication\LogonUI", "LastLoggedOnUser", userkey)
    End Sub

    Private Sub btn_check_Click(sender As Object, e As EventArgs) Handles btn_check.Click
        If My.Computer.Registry.GetValue(
                "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Authentication\LogonUI", "LastLoggedOnUser", Nothing) Is Nothing Then
            MsgBox("Value Doen't Exist")
        End If
        MsgBox(userkey)
    End Sub

    Private Sub btn_logoff_Click(sender As Object, e As EventArgs) Handles btn_logoff.Click
        Shell("shutdown -l")
    End Sub
End Class
