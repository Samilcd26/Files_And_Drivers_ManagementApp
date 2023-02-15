Imports System.IO

Public Class KlasorislemFormu

    Private Sub OlusturBtn_Click(sender As Object, e As EventArgs) Handles OlusturBtn.Click
        Dim KlasorAdi As String = KlasorAdiTBox.Text.Trim
        If KlasorAdi.Length > 0 Then
            Dim Klasor As New DirectoryInfo(KlasorAdi)
            'Dim Klasorum As DirectoryInfo = My.Computer.FileSystem.GetDirectoryInfo(KlasorAdi)
            If Not Klasor.Exists Then
                Klasor.Create()
            End If
            Process.Start("explorer.exe", Klasor.Parent.FullName)
        End If
    End Sub

    Private Sub KopyalaBtn_Click(sender As Object, e As EventArgs) Handles KopyalaBtn.Click
        Dim KlasorAdi As String = KlasorAdiTBox.Text.Trim
        If KlasorAdi.Length > 0 Then
            Dim Klasor As New DirectoryInfo(KlasorAdi)
            'Dim Klasorum As DirectoryInfo = My.Computer.FileSystem.GetDirectoryInfo(KlasorAdi)
            If Klasor.Exists Then
                Dim HedefKlasor As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments
                If Not Path.EndsInDirectorySeparator(HedefKlasor) Then
                    HedefKlasor = HedefKlasor & Path.DirectorySeparatorChar
                End If
                HedefKlasor = HedefKlasor & Klasor.Name
                If My.Computer.FileSystem.DirectoryExists(HedefKlasor) Then
                    If MsgBox(HedefKlasor & " klasörü zaten mevcut. Varolan dosya üzerine yazmak ister misiniz?", MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Mevcut Dosya") = MsgBoxResult.Yes Then
                        My.Computer.FileSystem.CopyDirectory(Klasor.FullName, HedefKlasor, True)
                    End If
                Else
                    My.Computer.FileSystem.CopyDirectory(Klasor.FullName, HedefKlasor)
                End If

                Process.Start("explorer.exe", My.Computer.FileSystem.GetParentPath(HedefKlasor))
            End If
        End If
    End Sub

    Private Sub SilBtn_Click(sender As Object, e As EventArgs) Handles SilBtn.Click
        Dim KlasorAdi As String = KlasorAdiTBox.Text.Trim
        If KlasorAdi.Length > 0 Then
            Dim Klasor As New DirectoryInfo(KlasorAdi)
            'Dim Klasorum As DirectoryInfo = My.Computer.FileSystem.GetDirectoryInfo(KlasorAdi)
            If Klasor.Exists Then
                Klasor.Delete()
            End If
            Process.Start("explorer.exe", Klasor.Parent.FullName)
        End If
    End Sub
End Class
