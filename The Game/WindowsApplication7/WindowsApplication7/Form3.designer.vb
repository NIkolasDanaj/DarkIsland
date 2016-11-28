<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ButtonCenter = New System.Windows.Forms.Button()
        Me.ButtonWest = New System.Windows.Forms.Button()
        Me.ButtonNorth = New System.Windows.Forms.Button()
        Me.ButtonSouth = New System.Windows.Forms.Button()
        Me.ButtonEast = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ButtonCenter
        '
        Me.ButtonCenter.Location = New System.Drawing.Point(338, 221)
        Me.ButtonCenter.Name = "ButtonCenter"
        Me.ButtonCenter.Size = New System.Drawing.Size(75, 23)
        Me.ButtonCenter.TabIndex = 0
        Me.ButtonCenter.Text = "Center"
        Me.ButtonCenter.UseVisualStyleBackColor = True
        '
        'ButtonWest
        '
        Me.ButtonWest.Location = New System.Drawing.Point(170, 222)
        Me.ButtonWest.Name = "ButtonWest"
        Me.ButtonWest.Size = New System.Drawing.Size(78, 22)
        Me.ButtonWest.TabIndex = 1
        Me.ButtonWest.Text = "West"
        Me.ButtonWest.UseVisualStyleBackColor = True
        '
        'ButtonNorth
        '
        Me.ButtonNorth.Location = New System.Drawing.Point(338, 110)
        Me.ButtonNorth.Name = "ButtonNorth"
        Me.ButtonNorth.Size = New System.Drawing.Size(75, 23)
        Me.ButtonNorth.TabIndex = 2
        Me.ButtonNorth.Text = "North"
        Me.ButtonNorth.UseVisualStyleBackColor = True
        '
        'ButtonSouth
        '
        Me.ButtonSouth.Location = New System.Drawing.Point(338, 342)
        Me.ButtonSouth.Name = "ButtonSouth"
        Me.ButtonSouth.Size = New System.Drawing.Size(75, 23)
        Me.ButtonSouth.TabIndex = 3
        Me.ButtonSouth.Text = "South"
        Me.ButtonSouth.UseVisualStyleBackColor = True
        '
        'ButtonEast
        '
        Me.ButtonEast.Location = New System.Drawing.Point(512, 221)
        Me.ButtonEast.Name = "ButtonEast"
        Me.ButtonEast.Size = New System.Drawing.Size(75, 23)
        Me.ButtonEast.TabIndex = 4
        Me.ButtonEast.Text = "East"
        Me.ButtonEast.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication7.My.Resources.Resources.xartis
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.ButtonEast)
        Me.Controls.Add(Me.ButtonSouth)
        Me.Controls.Add(Me.ButtonNorth)
        Me.Controls.Add(Me.ButtonWest)
        Me.Controls.Add(Me.ButtonCenter)
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ButtonCenter As System.Windows.Forms.Button
    Friend WithEvents ButtonWest As System.Windows.Forms.Button
    Friend WithEvents ButtonNorth As System.Windows.Forms.Button
    Friend WithEvents ButtonSouth As System.Windows.Forms.Button
    Friend WithEvents ButtonEast As System.Windows.Forms.Button
End Class
