Public Class Form3

    Private Function IsAtPosition(x As Integer, y As Integer) As Boolean
        Return xPosition(0) = x AndAlso xPosition(1) = y
    End Function

    Private Function IsAtCenter() As Boolean
        Return IsAtPosition(2, 2)
    End Function



    Private Sub Form3_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.BackgroundImageLayout = ImageLayout.Stretch
        Me.BackgroundImage = My.Resources.xartis
    End Sub

    Private Sub ButtonCenter_Click(sender As System.Object, e As System.EventArgs) Handles ButtonCenter.Click
        If IsAtCenter() Then
            MsgBox("You're already in the center of the map!")
            Exit Sub
        End If
        If playerNew.getAgility() > 50 Then
            playerNew.setAgilityPlus(-30)
        ElseIf playerNew.getAgility() >= 15 Then
            playerNew.setAgilityPlus(-10)
        Else
            playerNew.setAgility(0)
        End If
        Form2.Label6.Text = playerNew.getAgility().ToString

        xPosition = {2, 2}
    End Sub

    Private Sub ButtonSouth_Click(sender As System.Object, e As System.EventArgs) Handles ButtonSouth.Click
        Dim generator As New Random()
        Dim value As Integer
        value = generator.Next(0, 5)

        If IsAtPosition(3, 2) Then
            MsgBox("You are already South!")
            Exit Sub
        End If

        If IsAtCenter() = False Then
            MsgBox("You have to go back to center, but your agility will get lower...")
            Exit Sub
        End If

        If i < 5 Then
            i += 1
            pbxWarray(i).BackgroundImage = inventory(value).picture
            If flagInventory = False Then
                InventoryForm.Show()
                flagInventory = True
            Else
                InventoryForm.Refresh()
            End If
        Else
            MsgBox("Your inventory is full!!  To gain some space, click on an item to put away...")
        End If
        xPosition = {3, 2}

        eventValue = generatorEvent.Next(1, 3)
        If eventValue = 1 Then
            Dim f As formMonsterA = New formMonsterA()

            f.ShowDialog()
        ElseIf eventValue = 2 Then
            Dim f As formMonsterB = New formMonsterB()

            f.ShowDialog()
        ElseIf eventValue = 3 Then
            Dim f As formMonsterC = New formMonsterC()

            f.ShowDialog()
        End If
    End Sub

    Private Sub ButtonWest_Click(sender As System.Object, e As System.EventArgs) Handles ButtonWest.Click
        Dim generator As New Random()
        Dim value As Integer
        value = generator.Next(0, 5)

        If IsAtPosition(2, 1) Then
            MsgBox("You are already West!")
            Exit Sub
        End If

        If IsAtCenter() = False Then
            MsgBox("You have to go back to center, but your agility will get lower...")
            Exit Sub
        End If

        If i < 5 Then
            i += 1
            pbxWarray(i).BackgroundImage = inventory(value).picture
            If flagInventory = False Then
                InventoryForm.Show()
                flagInventory = True
            Else
                InventoryForm.Refresh()
            End If
        Else
            MsgBox("Your inventory is full!!  To gain some space, click on an item to put away...")
        End If
        xPosition = {2, 1}

        eventValue = generatorEvent.Next(1, 3)
        If eventValue = 1 Then
            Dim f As formMonsterA = New formMonsterA()

            f.ShowDialog()
        ElseIf eventValue = 2 Then
            Dim f As formMonsterB = New formMonsterB()

            f.ShowDialog()
        ElseIf eventValue = 3 Then
            Dim f As formMonsterC = New formMonsterC()

            f.ShowDialog()
        End If
    End Sub

    Private Sub ButtonNorth_Click(sender As System.Object, e As System.EventArgs) Handles ButtonNorth.Click
        Dim generator As New Random()
        Dim value As Integer
        value = generator.Next(0, 5)

        If IsAtPosition(1, 2) Then
            MsgBox("You are already North!")
            Exit Sub
        End If

        If IsAtCenter() = False Then
            MsgBox("You have to go back to center, but your agility will get lower...")
            Exit Sub
        End If

        If i < 5 Then
            i += 1
            pbxWarray(i).BackgroundImage = inventory(value).picture
            If flagInventory = False Then
                InventoryForm.Show()
                flagInventory = True
            Else
                InventoryForm.Refresh()
            End If
        Else
            MsgBox("Your inventory is full!! To gain some space, click on an item to put away...")
        End If
        xPosition = {1, 2}


        eventValue = generatorEvent.Next(1, 3)


        If eventValue = 1 Then
            Dim f As formMonsterA = New formMonsterA()

            f.ShowDialog()
        ElseIf eventValue = 2 Then
            Dim f As formMonsterB = New formMonsterB()

            f.ShowDialog()
        ElseIf eventValue = 3 Then
            Dim f As formMonsterC = New formMonsterC()

            f.ShowDialog()
        End If
    End Sub

    Private Sub ButtonEast_Click(sender As System.Object, e As System.EventArgs) Handles ButtonEast.Click
        Dim generator As New Random()
        Dim value As Integer
        value = generator.Next(0, 5)

        If IsAtPosition(2, 3) Then
            MsgBox("You are already East!")
            Exit Sub
        End If

        If IsAtCenter() = False Then
            MsgBox("You have to go back to center, but your agility will get lower...")
            Exit Sub
        End If
        If i < 5 Then
            i += 1
            pbxWarray(i).BackgroundImage = inventory(value).picture
            If flagInventory = False Then
                InventoryForm.Show()
                flagInventory = True
            Else
                InventoryForm.Refresh()
            End If

        Else
            MsgBox("Your inventory is full!!  To gain some space, click on an item to put away...")
        End If

        xPosition = {2, 3}

        eventValue = generatorEvent.Next(1, 3)
        If eventValue = 1 Then
            Dim f As formMonsterA = New formMonsterA()

            f.ShowDialog()
        ElseIf eventValue = 2 Then
            Dim f As formMonsterB = New formMonsterB()

            f.ShowDialog()
        ElseIf eventValue = 3 Then
            Dim f As formMonsterC = New formMonsterC()

            f.ShowDialog()
        End If
    End Sub

    Private Sub Form3_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Form1.Close()

    End Sub
End Class