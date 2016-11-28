Module Position

    Public xPosition() As Integer = {2, 2}

    Public Flag As Boolean = False

    Private name As String
    Private xclass As String
    Private xrace As String
    Public Function checkposition()
        If (xPosition Is {2, 2}) Then
            Flag = False
        Else
            Flag = True
        End If
        Return Flag
    End Function
  
    Public counter As Integer = 0
End Module
