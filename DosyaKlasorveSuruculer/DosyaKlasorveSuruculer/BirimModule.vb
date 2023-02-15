Module BirimModule
    Public Function BirimDonusturucu(Boyut As Long) As String
        Dim YeniBoyut As Decimal = Boyut
        Dim Birimler() As String = {"Byte", "KB", "MB", "GB", "TB", "PB", "EB", "YB", "ZB"}
        Dim Yer As Short = 0
        Do Until YeniBoyut < 1024
            YeniBoyut = YeniBoyut / 1024
            Yer += 1
        Loop
        YeniBoyut = Math.Round(YeniBoyut, 2)
        Return String.Format("{0} {1}", YeniBoyut, Birimler(Yer))
    End Function
End Module
