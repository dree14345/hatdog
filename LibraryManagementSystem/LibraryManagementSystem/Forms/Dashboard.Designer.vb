﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 105)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(198, 51)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Books"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(12, 162)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(198, 55)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Borrow"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(12, 223)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(198, 52)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Students"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(12, 281)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(198, 58)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Staffs"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(12, 345)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(198, 52)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "Return"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel1.Location = New System.Drawing.Point(220, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(3, 451)
        Me.Panel1.TabIndex = 5
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(12, 403)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(198, 48)
        Me.Button6.TabIndex = 6
        Me.Button6.Text = "Logout"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 463)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Dashboard"
        Me.Text = "Dashboard"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button6 As System.Windows.Forms.Button
End Class
