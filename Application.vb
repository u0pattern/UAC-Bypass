Imports Microsoft.Win32

Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Registry.SetValue("HKEY_CURRENT_USER\Software\Classes\ms-settings\shell\open\", "DelegateExecute", "")
        Registry.SetValue("HKEY_CURRENT_USER\Software\Classes\ms-settings\shell\open\", "(Default)", "cmd /c start powershell.exe")
        Process.Start("CMD", "/c start powershell.exe ")
    End Sub
End Class
