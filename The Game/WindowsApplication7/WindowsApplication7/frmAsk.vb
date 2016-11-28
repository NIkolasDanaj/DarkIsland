Public Class frmAsk
    Dim generator As New Random
    Dim value As Integer
    Private Sub frmAsk_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Me.BackgroundImageLayout = ImageLayout.Stretch
        Me.BackgroundImage = Image.FromFile("C:\Users\tonia\Documents\Visual Studio 2013\Projects\WindowsApplication1_RaceGame_VB\WindowsApplication1_RaceGame_VB\Resources\here.png")
        Qarray = {question1, question2, question3}
        value = generator.Next(0, 2)

        current = Qarray(value)
        lblQuestion.Text = current.question
        btna1.Text = current.answer(0)
        btna2.Text = current.answer(1)
        btna3.Text = current.answer(2)

    End Sub

    Private Sub btna1_Click(sender As Object, e As EventArgs) Handles btna1.Click

        btna1.Enabled = False
        btna2.Enabled = False
        btna3.Enabled = False

        If btna1.Text Is current.correct Then
            lblMsg.Text = "Well Done ! You've gained some wisdom! You may move to map..."
            playerNew.setWisdomPlus(30)
            Form2.Label7.Text = playerNew.getWisdom().ToString

        Else
            lblMsg.Text = "Wrong answer...Your strength will get lower if not zero, get luckier next time..."
            If playerNew.getStrength() > 50 Then
                playerNew.setStrengthPlus(-30)
            ElseIf playerNew.getStrength() > 10 Then
                playerNew.setStrengthPlus(-10)
            Else
                playerNew.setStrength(0)
            End If

            Form2.Label5.Text = playerNew.getStrength().ToString()

        End If
        btnMoveToMap.Enabled = True


    End Sub

    Private Sub btna2_Click(sender As Object, e As EventArgs) Handles btna2.Click

        btna1.Enabled = False
        btna2.Enabled = False
        btna3.Enabled = False

        If btna2.Text Is current.correct Then
            lblMsg.Text = "Well Done ! You've gained some wisdom! You may move to map..."
            playerNew.setWisdomPlus(30)
            Form2.Label7.Text = playerNew.getWisdom().ToString()


        Else
            lblMsg.Text = "Wrong answer...Your strength will get lower if not zero, get luckier next time..."
            If playerNew.getStrength() > 50 Then
                playerNew.setStrengthPlus(-30)
            ElseIf playerNew.getStrength() > 10 Then
                playerNew.setStrengthPlus(-10)
            Else
                playerNew.setStrength(0)
            End If

            Form2.Label5.Text = playerNew.getStrength().ToString()

        End If
        btnMoveToMap.Enabled = True


    End Sub

    Private Sub btna3_Click(sender As Object, e As EventArgs) Handles btna3.Click

        btna1.Enabled = False
        btna2.Enabled = False
        btna3.Enabled = False

        If btna3.Text Is current.correct Then
            lblMsg.Text = "Well Done ! You've gained some wisdom! You may move to map..."
            playerNew.setWisdomPlus(30)
            Form2.Label7.Text = playerNew.getWisdom().ToString


        Else
            lblMsg.Text = "Wrong answer...Your strength will get lower if not zero, get luckier next time..."
            If playerNew.getStrength() > 50 Then
                playerNew.setStrengthPlus(-30)
            ElseIf playerNew.getStrength() > 10 Then
                playerNew.setStrengthPlus(-10)
            Else
                playerNew.setStrength(0)
            End If

            Form2.Label5.Text = playerNew.getStrength().ToString()
        End If
        btnMoveToMap.Enabled = True
    End Sub

    Private Sub btnMove_Click(sender As Object, e As EventArgs) Handles btnMoveToMap.Click

        Me.Close()
    End Sub
End Class