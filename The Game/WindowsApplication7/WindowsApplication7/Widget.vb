Public Class Widget
    Protected Friend name As String
    Protected Friend picture As Bitmap
    Public id As Integer


    Sub New(i As Integer, n As String, b As Bitmap)

        id = i
        name = n
        picture = b
    End Sub
    Public Sub throwWidget(n As String)
        For i As Integer = 0 To 5 Step 1
            If (StrComp(inventory(i).name, n) = 0) Then
                pbxWarray(i).Image = Nothing

            End If
        Next i
    End Sub


End Class
