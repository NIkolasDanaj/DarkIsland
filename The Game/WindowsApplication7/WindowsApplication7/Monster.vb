Public Class Monster
    Public Damage As Integer = 0
    Protected id As Integer
    Public name As String
    Protected stren As Integer
    Protected ag As Integer
    Protected wis As Integer
    Public picture As Bitmap
    Public avgAbilityMonster As Double



    Sub New(i As Integer, n As String, s As Integer, a As Integer, w As Integer, p As Bitmap)
        id = i
        name = n
        stren = s
        ag = a
        wis = w
        picture = p
        avgAbilityMonster = (s + a + w) / 3
    End Sub

    Function Fight(p1 As Player) As String

        If avgAbilityMonster > p1.avgAbilityPlayer Then
            Return Me.name
        ElseIf avgAbilityMonster = p1.avgAbilityPlayer Then
            Return "You're strong enough... I'll getcha next time!!"
        Else
            Return p1.name
        End If

    End Function
End Class
