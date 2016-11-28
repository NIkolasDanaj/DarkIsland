Imports System.Threading

Public Class Form2


    Private Sub Label1_Click(sender As System.Object, e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        

    End Sub

    Private Sub Label5_Click(sender As System.Object, e As System.EventArgs) Handles Label5.Click

    End Sub

    Private Sub CheckedListBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub Label9_Click(sender As System.Object, e As System.EventArgs) Handles Label9.Click

    End Sub

    Private Sub Label11_Click(sender As System.Object, e As System.EventArgs) Handles Label11.Click

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton2.CheckedChanged
        playerNew.setGender("Female")
        If ComboBox1.SelectedIndex = 0 Then
            playerNew.setPicture(My.Resources.human_f)
        ElseIf ComboBox1.SelectedIndex = 1 Then
            playerNew.setPicture(My.Resources.orc_f)
        ElseIf ComboBox1.SelectedIndex = 2 Then
            playerNew.setPicture(My.Resources.dwarf_f)
        ElseIf ComboBox1.SelectedIndex = 3 Then
            playerNew.setPicture(My.Resources.elf_f)
        End If
        PictureBox1.Image = playerNew.getPicture()
    End Sub

    Private Sub PictureBox2_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged_1(sender As System.Object, e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        

        If ComboBox1.SelectedIndex = 0 Then

            playerNew.setStrength(65)
            playerNew.setAgility(40)
            playerNew.setWisdom(35)

            RichTextBox1.Text = "In the reckonings of most worlds, humans are the youngest of the common races, late to arrive on the world scene and short-lived in comparison to dwarves, elves, and dragons. Perhaps it is because of their shorter lives that they strive to achieve as much as they can in the years they are given. Perhaps they feel they have something to prove to the elder races, and that’s why they build their mighty empires on the foundation of conquest and trade."
        End If

        If ComboBox1.SelectedIndex = 0 And RadioButton1.Checked Then
            playerNew.setPicture(My.Resources.human_m)
        ElseIf ComboBox1.SelectedIndex = 0 And RadioButton2.Checked Then
            playerNew.setPicture(My.Resources.human_f)
        End If

        If ComboBox1.SelectedIndex = 1 Then

            playerNew.setStrength(90)
            playerNew.setAgility(20)
            playerNew.setWisdom(0)

            RichTextBox1.Text = "Orcs regard battle scars as tokens of pride and ornamental scars as things of beauty. Other scars, though, mark an orc or half-orc as a former slave or a disgraced exile. Any half-orc who has lived among or near orcs has scars, whether they are marks of humiliation or of pride, recounting their past exploits and injuries. Such a half-orc living among humans might display these scars proudly or hide them in shame."
        End If

        If ComboBox1.SelectedIndex = 1 And RadioButton1.Checked Then
            playerNew.setPicture(My.Resources.orc_m)
        ElseIf ComboBox1.SelectedIndex = 1 And RadioButton2.Checked Then
            playerNew.setPicture(My.Resources.orc_f)
        End If

        If ComboBox1.SelectedIndex = 2 Then
           
            playerNew.setStrength(70)
            playerNew.setAgility(10)
            playerNew.setWisdom(20)
            RichTextBox1.Text = "Dwarves respect the traditions of their clans, tracing their ancestry back to the founding of their most ancient strongholds in the youth of the world, and do not abandon those traditions lightly. Part of those traditions is devotion to the gods of the dwarves, who uphold the dwarven ideals of industrious labor, skill in battle, and devotion to the forge."

        End If

        If ComboBox1.SelectedIndex = 2 And RadioButton1.Checked Then
            playerNew.setPicture(My.Resources.dwarf_m)
        ElseIf ComboBox1.SelectedIndex = 2 And RadioButton2.Checked Then
            playerNew.setPicture(My.Resources.dwarf_f)
        End If

        If ComboBox1.SelectedIndex = 3 Then
           
            playerNew.setStrength(60)
            playerNew.setAgility(60)
            playerNew.setWisdom(60)
            RichTextBox1.Text = "Elves are renowned for their grace and mastery of magic and weapons such as the sword and bow. Becoming physically mature by the age of 25 and emotionally mature at around 125, they are also famously long-lived, capable of living more than half a millennium and remaining physically youthful. Possessed of innate beauty and easy gracefulness, they are viewed as both wondrous and haughty by other races; however, their natural detachment is seen by some as introversion or xenophobia."

        End If

        If ComboBox1.SelectedIndex = 3 And RadioButton1.Checked Then
            playerNew.setPicture(My.Resources.elf_m)
        ElseIf ComboBox1.SelectedIndex = 3 And RadioButton2.Checked Then
            playerNew.setPicture(My.Resources.elf_f)
        End If

        Label5.Text = playerNew.getStrength().ToString
        Label6.Text = playerNew.getAgility().ToString
        Label7.Text = playerNew.getWisdom().ToString
        PictureBox1.Image = playerNew.getPicture()


    End Sub

    Private Sub Label6_Click(sender As System.Object, e As System.EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label7_Click(sender As System.Object, e As System.EventArgs) Handles Label7.Click

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        If ComboBox2.SelectedIndex = 0 Then
          
            playerNew.setStrengthPlus(15)
            playerNew.setAgilityPlus(5)
            playerNew.setWisdomPlus(5)
            RichTextBox2.Text = "Questing knights, conquering overlords, royal champions, elite foot soldiers, hardened mercenaries, and bandit kings—as warriors, they all share an unparalleled mastery with weapons and armor, and a thorough knowledge of the skills of combat."
        End If

        If ComboBox2.SelectedIndex = 1 Then
           
            playerNew.setStrengthPlus(5)
            playerNew.setAgilityPlus(0)
            playerNew.setWisdomPlus(15)
            RichTextBox2.Text = "Paladins are intermediaries between the mortal world and the distant planes of the gods. As varied as the gods they serve, they strive to embody the handiwork of their deities."
        End If

        If ComboBox2.SelectedIndex = 2 Then
           
            playerNew.setStrengthPlus(0)
            playerNew.setAgilityPlus(0)
            playerNew.setWisdomPlus(35)
            RichTextBox2.Text = "Drawing on the subtle weave of magic that permeates the cosmos, mages cast spells of explosive fire, arcing lightning, subtle deception, and brute-force mind control."
        End If

        If ComboBox2.SelectedIndex = 3 Then
           
            playerNew.setStrengthPlus(5)
            playerNew.setAgilityPlus(15)
            playerNew.setWisdomPlus(5)
            RichTextBox2.Text = "Far from the bustle of cities and towns, amid the dense-packed trees of trackless forests and across wide and empty plains, archers keep their unending watch."
        End If
        Label5.Text = playerNew.getStrength().ToString
        Label6.Text = playerNew.getAgility().ToString
        Label7.Text = playerNew.getWisdom().ToString

    End Sub

    Private Sub Label15_Click(sender As System.Object, e As System.EventArgs) Handles Label15.Click

    End Sub

    Private Sub Label16_Click(sender As System.Object, e As System.EventArgs) Handles Label16.Click

    End Sub

    Private Sub Label18_Click(sender As System.Object, e As System.EventArgs) Handles Label18.Click

    End Sub

    Private Sub Label17_Click(sender As System.Object, e As System.EventArgs) Handles Label17.Click

    End Sub

    Private Sub PictureBox3_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton1.CheckedChanged
        playerNew.setGender("Male")
        If ComboBox1.SelectedIndex = 0 Then
            PictureBox1.Image = My.Resources.human_m
        ElseIf ComboBox1.SelectedIndex = 1 Then
            PictureBox1.Image = My.Resources.orc_m
        ElseIf ComboBox1.SelectedIndex = 2 Then
            PictureBox1.Image = My.Resources.dwarf_m
        ElseIf ComboBox1.SelectedIndex = 3 Then
            PictureBox1.Image = My.Resources.elf_m
        End If
    End Sub


    Private Sub Form2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Label5.Text = "0"
        Label6.Text = "0"
        Label7.Text = "0"
    End Sub

    Private Sub Label10_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub Label3_Click(sender As System.Object, e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub RichTextBox1_TextChanged(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub PictureBox1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub RichTextBox1_TextChanged_1(sender As System.Object, e As System.EventArgs) Handles RichTextBox1.TextChanged
 
    End Sub

    Private Sub RichTextBox2_TextChanged(sender As System.Object, e As System.EventArgs) Handles RichTextBox2.TextChanged
       
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        ComboBox1.Enabled = False
        ComboBox2.Enabled = False
        RadioButton1.Enabled = False
        RadioButton2.Enabled = False
        playerNew.setName(txtName.Text)

        Form3.Show()
        Me.Close()


    End Sub
End Class
