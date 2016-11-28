Public Class InventoryForm

    Private Sub PictureBox2_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub InventoryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pbxw2.BackgroundImageLayout = ImageLayout.Stretch
        pbxw3.BackgroundImageLayout = ImageLayout.Stretch
        pbxw4.BackgroundImageLayout = ImageLayout.Stretch
        pbxw5.BackgroundImageLayout = ImageLayout.Stretch
        pbxw6.BackgroundImageLayout = ImageLayout.Stretch
        pbxw7.BackgroundImageLayout = ImageLayout.Stretch

    End Sub

    Private Sub InventoryForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        flagInventory = False

    End Sub

    Private Sub pbxw2_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles pbxw2.MouseDoubleClick
        pbxWarray(0).BackgroundImage = Nothing


    End Sub

    Private Sub pbxw3_DoubleClick(sender As Object, e As EventArgs) Handles pbxw3.DoubleClick
        pbxWarray(1).BackgroundImage = Nothing

    End Sub

    Private Sub pbxw4_DoubleClick(sender As Object, e As EventArgs) Handles pbxw4.DoubleClick
        pbxWarray(2).BackgroundImage = Nothing

    End Sub

    Private Sub pbxw5_DoubleClick(sender As Object, e As EventArgs) Handles pbxw5.DoubleClick
        pbxWarray(3).BackgroundImage = Nothing

    End Sub

    Private Sub pbxw6_DoubleClick(sender As Object, e As EventArgs) Handles pbxw6.DoubleClick
        pbxWarray(4).BackgroundImage = Nothing

    End Sub

    Private Sub pbxw7_DoubleClick(sender As Object, e As EventArgs) Handles pbxw7.DoubleClick
        pbxWarray(5).BackgroundImage = Nothing

    End Sub
End Class