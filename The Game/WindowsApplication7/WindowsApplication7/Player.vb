Public Class Player
    Protected id As Integer
    Public name As String
    Protected stren As Integer
    Protected ag As Integer
    Protected wis As Integer
    Protected gender As String
    Public picture As Bitmap
    Public avgAbilityPlayer As Double


    Sub New()
        id = 1
        name = ""
        gender = ""
        stren = 0
        ag = 0
        wis = 0
        picture = Nothing
        avgAbilityPlayer = 0
    End Sub

    Sub setName(n As String)
        name = n
    End Sub
    Sub setStrength(s As Integer)
        stren = s
    End Sub
    Sub setAgility(a As Integer)
        ag = a
    End Sub
    Sub setWisdom(w As Integer)
        wis = w
    End Sub
    Sub setStrengthPlus(s As Integer)
        stren += s
    End Sub
    Sub setAgilityPlus(a As Integer)
        ag += a
    End Sub
    Sub setWisdomPlus(w As Integer)
        wis += w
    End Sub
    Sub setGender(g As String)
        gender = g
    End Sub
    Sub setPicture(p As Bitmap)
        picture = p
    End Sub
    Sub setAbilityPlayer()
        avgAbilityPlayer = (stren + ag + wis) / 3
    End Sub

    Function getStrength() As Integer
        Return stren
    End Function

    Function getAgility() As Integer
        Return ag
    End Function

    Function getWisdom() As Integer
        Return wis
    End Function

    Function getPicture() As Bitmap
        Return picture
    End Function
End Class
