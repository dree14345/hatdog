<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BReturns
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
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.txtFine = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.returnDTP = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.borrowDTP = New System.Windows.Forms.DateTimePicker()
        Me.stdBCb = New System.Windows.Forms.ComboBox()
        Me.stdIdCb = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.stName = New System.Windows.Forms.TextBox()
        Me.bName = New System.Windows.Forms.TextBox()
        Me.ReturnDGV = New System.Windows.Forms.DataGridView()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.BorrowDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.ReturnDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BorrowDGV
        '
        Me.BorrowDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BorrowDGV.Location = New System.Drawing.Point(449, 39)
        Me.BorrowDGV.Name = "BorrowDGV"
        Me.BorrowDGV.Size = New System.Drawing.Size(398, 211)
        Me.BorrowDGV.TabIndex = 14
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btnCalc)
        Me.Panel1.Controls.Add(Me.txtFine)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.returnDTP)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.borrowDTP)
        Me.Panel1.Controls.Add(Me.stdBCb)
        Me.Panel1.Controls.Add(Me.stdIdCb)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btnEdit)
        Me.Panel1.Controls.Add(Me.stName)
        Me.Panel1.Controls.Add(Me.bName)
        Me.Panel1.Location = New System.Drawing.Point(12, 25)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(372, 454)
        Me.Panel1.TabIndex = 13
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(190, 242)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(75, 23)
        Me.btnCalc.TabIndex = 37
        Me.btnCalc.Text = "Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'txtFine
        '
        Me.txtFine.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtFine.Location = New System.Drawing.Point(190, 204)
        Me.txtFine.Name = "txtFine"
        Me.txtFine.Size = New System.Drawing.Size(111, 20)
        Me.txtFine.TabIndex = 36
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(192, 168)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(27, 13)
        Me.Label7.TabIndex = 35
        Me.Label7.Text = "Fine"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(26, 326)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 21
        Me.btnSave.Text = "Return"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(188, 106)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 13)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "Return Date"
        '
        'returnDTP
        '
        Me.returnDTP.Location = New System.Drawing.Point(190, 123)
        Me.returnDTP.Name = "returnDTP"
        Me.returnDTP.Size = New System.Drawing.Size(111, 20)
        Me.returnDTP.TabIndex = 33
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(187, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 13)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Borrow Date"
        '
        'borrowDTP
        '
        Me.borrowDTP.Location = New System.Drawing.Point(190, 54)
        Me.borrowDTP.Name = "borrowDTP"
        Me.borrowDTP.Size = New System.Drawing.Size(111, 20)
        Me.borrowDTP.TabIndex = 31
        '
        'stdBCb
        '
        Me.stdBCb.FormattingEnabled = True
        Me.stdBCb.Location = New System.Drawing.Point(23, 203)
        Me.stdBCb.Name = "stdBCb"
        Me.stdBCb.Size = New System.Drawing.Size(117, 21)
        Me.stdBCb.TabIndex = 30
        '
        'stdIdCb
        '
        Me.stdIdCb.FormattingEnabled = True
        Me.stdIdCb.Location = New System.Drawing.Point(23, 57)
        Me.stdIdCb.Name = "stdIdCb"
        Me.stdIdCb.Size = New System.Drawing.Size(117, 21)
        Me.stdIdCb.TabIndex = 29
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 242)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Book Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 168)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Book"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Student ID"
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(155, 326)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 23)
        Me.btnEdit.TabIndex = 22
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'stName
        '
        Me.stName.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.stName.Location = New System.Drawing.Point(23, 126)
        Me.stName.Name = "stName"
        Me.stName.Size = New System.Drawing.Size(117, 20)
        Me.stName.TabIndex = 20
        '
        'bName
        '
        Me.bName.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.bName.Location = New System.Drawing.Point(26, 269)
        Me.bName.Name = "bName"
        Me.bName.Size = New System.Drawing.Size(114, 20)
        Me.bName.TabIndex = 19
        '
        'ReturnDGV
        '
        Me.ReturnDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ReturnDGV.Location = New System.Drawing.Point(449, 268)
        Me.ReturnDGV.Name = "ReturnDGV"
        Me.ReturnDGV.Size = New System.Drawing.Size(398, 211)
        Me.ReturnDGV.TabIndex = 14
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(449, 12)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(213, 20)
        Me.txtSearch.TabIndex = 15
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(678, 9)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Search"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BReturns
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(870, 514)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.BorrowDGV)
        Me.Controls.Add(Me.ReturnDGV)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "BReturns"
        Me.Text = "BReturns"
        CType(Me.BorrowDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ReturnDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BorrowDGV As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents returnDTP As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents borrowDTP As System.Windows.Forms.DateTimePicker
    Friend WithEvents stdBCb As System.Windows.Forms.ComboBox
    Friend WithEvents stdIdCb As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents stName As System.Windows.Forms.TextBox
    Friend WithEvents bName As System.Windows.Forms.TextBox
    Friend WithEvents txtFine As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnCalc As System.Windows.Forms.Button
    Friend WithEvents ReturnDGV As System.Windows.Forms.DataGridView
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
