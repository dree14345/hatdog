<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Borrow
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
        Me.BorrowDGV = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnRes = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.borrowDTP = New System.Windows.Forms.DateTimePicker()
        Me.stdBCb = New System.Windows.Forms.ComboBox()
        Me.stdIdCb = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.stName = New System.Windows.Forms.TextBox()
        Me.bName = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnReturn = New System.Windows.Forms.Button()
        CType(Me.BorrowDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'BorrowDGV
        '
        Me.BorrowDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.BorrowDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.BorrowDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BorrowDGV.Location = New System.Drawing.Point(408, 12)
        Me.BorrowDGV.Name = "BorrowDGV"
        Me.BorrowDGV.Size = New System.Drawing.Size(325, 396)
        Me.BorrowDGV.TabIndex = 14
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel1.Controls.Add(Me.btnExit)
        Me.Panel1.Controls.Add(Me.btnRes)
        Me.Panel1.Controls.Add(Me.btnEdit)
        Me.Panel1.Controls.Add(Me.btnSubmit)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.borrowDTP)
        Me.Panel1.Controls.Add(Me.stdBCb)
        Me.Panel1.Controls.Add(Me.stdIdCb)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.stName)
        Me.Panel1.Controls.Add(Me.bName)
        Me.Panel1.Location = New System.Drawing.Point(31, 41)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(344, 396)
        Me.Panel1.TabIndex = 13
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(622, 115)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 27
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnRes
        '
        Me.btnRes.Location = New System.Drawing.Point(223, 276)
        Me.btnRes.Name = "btnRes"
        Me.btnRes.Size = New System.Drawing.Size(75, 23)
        Me.btnRes.TabIndex = 25
        Me.btnRes.Text = "Reset"
        Me.btnRes.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(129, 276)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 23)
        Me.btnEdit.TabIndex = 23
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(30, 276)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(75, 23)
        Me.btnSubmit.TabIndex = 22
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(177, 120)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 13)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Borrow Date"
        '
        'borrowDTP
        '
        Me.borrowDTP.Location = New System.Drawing.Point(180, 144)
        Me.borrowDTP.Name = "borrowDTP"
        Me.borrowDTP.Size = New System.Drawing.Size(118, 20)
        Me.borrowDTP.TabIndex = 17
        '
        'stdBCb
        '
        Me.stdBCb.FormattingEnabled = True
        Me.stdBCb.Location = New System.Drawing.Point(30, 210)
        Me.stdBCb.Name = "stdBCb"
        Me.stdBCb.Size = New System.Drawing.Size(122, 21)
        Me.stdBCb.TabIndex = 16
        '
        'stdIdCb
        '
        Me.stdIdCb.FormattingEnabled = True
        Me.stdIdCb.Location = New System.Drawing.Point(30, 67)
        Me.stdIdCb.Name = "stdIdCb"
        Me.stdIdCb.Size = New System.Drawing.Size(122, 21)
        Me.stdIdCb.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(177, 31)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Book Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(30, 184)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Book"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Student ID"
        '
        'stName
        '
        Me.stName.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.stName.Location = New System.Drawing.Point(30, 144)
        Me.stName.Name = "stName"
        Me.stName.Size = New System.Drawing.Size(122, 20)
        Me.stName.TabIndex = 1
        '
        'bName
        '
        Me.bName.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.bName.Location = New System.Drawing.Point(180, 68)
        Me.bName.Name = "bName"
        Me.bName.Size = New System.Drawing.Size(118, 20)
        Me.bName.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel2.Controls.Add(Me.BorrowDGV)
        Me.Panel2.Location = New System.Drawing.Point(12, 29)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(750, 424)
        Me.Panel2.TabIndex = 15
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.btnReturn)
        Me.Panel3.Location = New System.Drawing.Point(2, 2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(786, 33)
        Me.Panel3.TabIndex = 15
        '
        'btnReturn
        '
        Me.btnReturn.Location = New System.Drawing.Point(337, -2)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(75, 23)
        Me.btnReturn.TabIndex = 16
        Me.btnReturn.Text = "Return"
        Me.btnReturn.UseVisualStyleBackColor = True
        '
        'Borrow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(788, 465)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Borrow"
        Me.Text = "Borrow"
        CType(Me.BorrowDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BorrowDGV As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents stName As System.Windows.Forms.TextBox
    Friend WithEvents bName As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents borrowDTP As System.Windows.Forms.DateTimePicker
    Friend WithEvents stdBCb As System.Windows.Forms.ComboBox
    Friend WithEvents stdIdCb As System.Windows.Forms.ComboBox
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnRes As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btnReturn As System.Windows.Forms.Button
End Class
