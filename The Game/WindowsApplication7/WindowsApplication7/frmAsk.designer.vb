<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAsk
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
        Me.lblQuestion = New System.Windows.Forms.Label()
        Me.btna1 = New System.Windows.Forms.Button()
        Me.btna3 = New System.Windows.Forms.Button()
        Me.btna2 = New System.Windows.Forms.Button()
        Me.lblMsg = New System.Windows.Forms.Label()
        Me.btnMoveToMap = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblQuestion
        '
        Me.lblQuestion.AutoEllipsis = True
        Me.lblQuestion.AutoSize = True
        Me.lblQuestion.BackColor = System.Drawing.Color.Chartreuse
        Me.lblQuestion.Font = New System.Drawing.Font("Segoe Script", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.lblQuestion.Location = New System.Drawing.Point(13, 9)
        Me.lblQuestion.Name = "lblQuestion"
        Me.lblQuestion.Size = New System.Drawing.Size(0, 27)
        Me.lblQuestion.TabIndex = 0
        '
        'btna1
        '
        Me.btna1.Location = New System.Drawing.Point(16, 196)
        Me.btna1.Name = "btna1"
        Me.btna1.Size = New System.Drawing.Size(75, 75)
        Me.btna1.TabIndex = 1
        Me.btna1.UseVisualStyleBackColor = True
        '
        'btna3
        '
        Me.btna3.Location = New System.Drawing.Point(341, 196)
        Me.btna3.Name = "btna3"
        Me.btna3.Size = New System.Drawing.Size(75, 75)
        Me.btna3.TabIndex = 2
        Me.btna3.UseVisualStyleBackColor = True
        '
        'btna2
        '
        Me.btna2.Location = New System.Drawing.Point(179, 196)
        Me.btna2.Name = "btna2"
        Me.btna2.Size = New System.Drawing.Size(75, 75)
        Me.btna2.TabIndex = 3
        Me.btna2.UseVisualStyleBackColor = True
        '
        'lblMsg
        '
        Me.lblMsg.AutoEllipsis = True
        Me.lblMsg.AutoSize = True
        Me.lblMsg.BackColor = System.Drawing.Color.Chartreuse
        Me.lblMsg.Font = New System.Drawing.Font("Segoe Script", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.lblMsg.Location = New System.Drawing.Point(13, 75)
        Me.lblMsg.Name = "lblMsg"
        Me.lblMsg.Size = New System.Drawing.Size(0, 30)
        Me.lblMsg.TabIndex = 4
        '
        'btnMoveToMap
        '
        Me.btnMoveToMap.Font = New System.Drawing.Font("Segoe Script", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.btnMoveToMap.Location = New System.Drawing.Point(139, 300)
        Me.btnMoveToMap.Name = "btnMoveToMap"
        Me.btnMoveToMap.Size = New System.Drawing.Size(150, 38)
        Me.btnMoveToMap.TabIndex = 5
        Me.btnMoveToMap.Text = "Move To Map"
        Me.btnMoveToMap.UseVisualStyleBackColor = True
        '
        'frmAsk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(449, 364)
        Me.Controls.Add(Me.btnMoveToMap)
        Me.Controls.Add(Me.lblMsg)
        Me.Controls.Add(Me.btna2)
        Me.Controls.Add(Me.btna3)
        Me.Controls.Add(Me.btna1)
        Me.Controls.Add(Me.lblQuestion)
        Me.Name = "frmAsk"
        Me.Text = "Quiz Time!"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblQuestion As System.Windows.Forms.Label
    Friend WithEvents btna1 As System.Windows.Forms.Button
    Friend WithEvents btna3 As System.Windows.Forms.Button
    Friend WithEvents btna2 As System.Windows.Forms.Button
    Friend WithEvents lblMsg As System.Windows.Forms.Label
    Friend WithEvents btnMoveToMap As System.Windows.Forms.Button
End Class
