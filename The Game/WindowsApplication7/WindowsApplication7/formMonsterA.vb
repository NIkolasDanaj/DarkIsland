Public Class formMonsterA

    Private Sub formMonsterA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.BackgroundImage = playerNew.getPicture()
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        Me.BackgroundImageLayout = ImageLayout.Stretch
        If xPosition Is {1, 2} Then
            Me.BackgroundImage = My.Resources.forest
        ElseIf xPosition Is {2, 3} Then
            Me.BackgroundImage = My.Resources.cave
        ElseIf xPosition Is {3, 2} Then

            Me.BackgroundImage = My.Resources.lake
        Else
            Me.BackgroundImage = My.Resources.village

        End If


    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click


    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ProgressBar1.PerformStep()
        If ProgressBar1.Value = ProgressBar1.Maximum Then
            MsgBox("You won!! Good job!")
            xPosition = {2, 2}
            Me.Close()

        End If

    End Sub

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles ProgressBar1.Click

    End Sub

    Private Sub ProgressBar1_SizeChanged(sender As Object, e As EventArgs) Handles ProgressBar1.SizeChanged
        If ProgressBar1.Size = MaximumSize Then
            xPosition = {2, 2}
            MsgBox("You won good job!")
            Me.Close()
        End If
    End Sub
End Class