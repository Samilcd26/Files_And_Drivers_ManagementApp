Imports System.IO

Public Class SurucuBilgiFormu
    Private Sub Suruculer()
        SurucuCBox.Items.Clear()
        For Each Surucu As DriveInfo In My.Computer.FileSystem.Drives
            SurucuCBox.Items.Add(Surucu.Name)
        Next
    End Sub
    Private Sub SurucuBilgiFormu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Suruculer()
    End Sub

    Private Sub TazeleBtn_Click(sender As Object, e As EventArgs) Handles TazeleBtn.Click
        Suruculer()
    End Sub

    Private Sub SurucuCBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SurucuCBox.SelectedIndexChanged
        If SurucuCBox.SelectedIndex > -1 Then
            Dim Surucu As DriveInfo = My.Computer.FileSystem.GetDriveInfo(SurucuCBox.SelectedItem)
            BilgiLBox.Items.Clear()
            BilgiLBox.Items.Add("Sürücü Adı: " & Surucu.Name)
            BilgiLBox.Items.Add("Sürücü Tipi: " & Surucu.DriveType.ToString)
            If Surucu.IsReady Then
                BilgiLBox.Items.Add("Sürücü Etiketi: " & Surucu.VolumeLabel)
                BilgiLBox.Items.Add("Sürücü Formatı: " & Surucu.DriveFormat)
                BilgiLBox.Items.Add("Sürücü Ana Klasörü: " & Surucu.RootDirectory.FullName)
                BilgiLBox.Items.Add("Sürücü Kullanılabilir Boş Alan: " & BirimDonusturucu(Surucu.AvailableFreeSpace))
                BilgiLBox.Items.Add("Sürücü Toplam Alanı: " & BirimDonusturucu(Surucu.TotalSize))
                Dim Kullanilan As Long = Surucu.TotalSize - Surucu.TotalFreeSpace
                BilgiLBox.Items.Add("Sürücü Kullanılan Alan: " & BirimDonusturucu(Kullanilan))
            Else
                BilgiLBox.Items.Add(Surucu.Name & " Sürücüsü Hazır Değil ")
            End If
        End If
    End Sub
End Class
