Imports System.IO

Public Class DosyaBilgiFormu


    Private Sub DosyaSecBtn_Click(sender As Object, e As EventArgs) Handles DosyaSecBtn.Click
        DosyaAcDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.Desktop
        BilgiLBox.Items.Clear()
        If DosyaAcDialog.ShowDialog = DialogResult.OK Then
            DosyaTBox.Text = DosyaAcDialog.FileName
            Dim Dosya As FileInfo = My.Computer.FileSystem.GetFileInfo(DosyaAcDialog.FileName)
            'Dim Dosyam As New FileInfo(DosyaAcDialog.FileName)
            If Dosya.Exists Then
                BilgiLBox.Items.Add("Dosya Adı: " & Dosya.Name)
                BilgiLBox.Items.Add("Dosya Yoluyla Birlikte Adı: " & Dosya.FullName)
                BilgiLBox.Items.Add("Dosya Uzantısı: " & Dosya.Extension)
                BilgiLBox.Items.Add("Uzantı Olmadan Dosya Adı: " & Path.GetFileNameWithoutExtension(Dosya.FullName))
                BilgiLBox.Items.Add("Dosya Bulunduğu Klasör: " & Dosya.DirectoryName)
                BilgiLBox.Items.Add("Dosya Oluşturma Tarihi: " & Dosya.CreationTime)
                BilgiLBox.Items.Add("Dosya Son Erişim Tarihi: " & Dosya.LastAccessTime)
                BilgiLBox.Items.Add("Dosya Son Değiştirme Tarihi: " & Dosya.LastWriteTime)
                BilgiLBox.Items.Add("Dosya Boyutu: " & BirimDonusturucu(Dosya.Length))

            End If
        End If
    End Sub

    Private Sub KopyalaBtn_Click(sender As Object, e As EventArgs) Handles KopyalaBtn.Click
        If DosyaTBox.TextLength > 0 Then
            'Dim Dosyam As FileInfo = My.Computer.FileSystem.GetFileInfo(DosyaTBox.Text)
            Dim Dosya As New FileInfo(DosyaTBox.Text)
            If Dosya.Exists Then
                Dim HedefKlasor As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments
                If Not Path.EndsInDirectorySeparator(HedefKlasor) Then
                    HedefKlasor = HedefKlasor & Path.DirectorySeparatorChar
                End If
                Dim HedefDosya As String = HedefKlasor & Dosya.Name
                If My.Computer.FileSystem.FileExists(HedefDosya) Then
                    If MsgBox(HedefDosya & " dosyası zaten mevcut. Varolan dosya üzerine yazmak ister misiniz?", MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Mevcut Dosya") = MsgBoxResult.Yes Then
                        Dosya.CopyTo(HedefDosya, True)
                    End If
                Else
                    Dosya.CopyTo(HedefDosya)
                End If
                Process.Start("explorer.exe", HedefKlasor)
            End If
        End If
    End Sub

    Private Sub TasiBtn_Click(sender As Object, e As EventArgs) Handles TasiBtn.Click
        If DosyaTBox.TextLength > 0 Then
            'Dim Dosyam As FileInfo = My.Computer.FileSystem.GetFileInfo(DosyaTBox.Text)
            Dim Dosya As New FileInfo(DosyaTBox.Text)
            If Dosya.Exists Then
                Dim HedefKlasor As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments
                If Not Path.EndsInDirectorySeparator(HedefKlasor) Then
                    HedefKlasor = HedefKlasor & Path.DirectorySeparatorChar
                End If
                Dim HedefDosya As String = HedefKlasor & Dosya.Name
                If My.Computer.FileSystem.FileExists(HedefDosya) Then
                    If MsgBox(HedefDosya & " dosyası zaten mevcut. Varolan dosya üzerine yazmak ister misiniz?", MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Mevcut Dosya") = MsgBoxResult.Yes Then
                        'Dosya.MoveTo(HedefDosya, True)
                        My.Computer.FileSystem.MoveFile(Dosya.FullName, HedefDosya, True)
                    End If
                Else
                    'Dosya.MoveTo(HedefDosya)
                    My.Computer.FileSystem.MoveFile(Dosya.FullName, HedefDosya)
                End If
                Process.Start("explorer.exe", HedefKlasor)
            End If
        End If
    End Sub
End Class
