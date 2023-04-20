Imports System.Data.SqlClient
Public Class Books
    Dim con = New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Admin\Documents\LBMSdb.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True")
    Private Sub DisplayBook()
        con.Open()
        Dim query = "SELECT * FROM BookTab"
        Dim adapter As SqlDataAdapter
        Dim cmd = New SqlCommand(query, con)
        adapter = New SqlDataAdapter(cmd)
        Dim builder = New SqlCommandBuilder(adapter)
        Dim ds = New DataSet()
        adapter.Fill(ds)
        BooksDGV.DataSource = ds.Tables(0)
        con.Close()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If txtName.Text = "" Or txtAuthor.Text = "" Or txtPublisher.Text = "" Or txtTotal.Text = "" Or txtBorrowed.Text = "" Then
            MsgBox("Missing information", MsgBoxStyle.Information)
        Else
            con.Open()
            Dim query = "Insert into BookTab values('" & txtName.Text & "', '" & txtAuthor.Text & "', '" & txtPublisher.Text & "', '" & txtTotal.Text & "', '" & txtBorrowed.Text & "')"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, con)
            cmd.ExecuteNonQuery()
            MsgBox("Book Saved", MsgBoxStyle.Information)
            con.Close()
            DisplayBook()
        End If
    End Sub

    Private Sub Books_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DisplayBook()
    End Sub
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        If MsgBox("Would you like to exit?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Application.ExitThread()
        End If
    End Sub
    Private Sub Reset()
        txtName.Text = ""
        txtAuthor.Text = ""
        txtBorrowed.Text = ""
        txtPublisher.Text = ""
        txtTotal.Text = ""
    End Sub

    Private Sub btnRes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRes.Click
        Reset()
    End Sub

    Private Sub btnDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDel.Click
        If key = 0 Then
            MsgBox("Missing Information", MsgBoxStyle.Information)
        Else
            con.Open()
            Dim query = "Delete from BookTab where BId = " & key & ""
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, con)
            cmd.ExecuteNonQuery()
            MsgBox("Book Saved", MsgBoxStyle.Information)
            con.Close()
            DisplayBook()
        End If
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        con.Open()
        Dim query = "TRUNCATE TABLE BookTab"
        Dim cmd As SqlCommand
        cmd = New SqlCommand(query, con)
        cmd.ExecuteNonQuery()
        MsgBox("All Books Cleared", MsgBoxStyle.Information)
        con.Close()
        DisplayBook()
    End Sub

    Private Sub BooksDGV_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles BooksDGV.CellContentClick

    End Sub
    Dim key = 0
    Private Sub BooksDGV_CellMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles BooksDGV.CellMouseClick
        Dim row As DataGridViewRow = BooksDGV.Rows(e.RowIndex)
        txtName.Text = row.Cells(1).Value.ToString
        txtAuthor.Text = row.Cells(2).Value.ToString
        txtPublisher.Text = row.Cells(3).Value.ToString
        txtTotal.Text = row.Cells(4).Value.ToString
        txtBorrowed.Text = row.Cells(5).Value.ToString
        If txtName.Text = "" Then
            key = 0
        Else
            key = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        If txtName.Text = "" Or txtAuthor.Text = "" Or txtPublisher.Text = "" Or txtTotal.Text = "" Or txtBorrowed.Text = "" Then
            MsgBox("Missing information", MsgBoxStyle.Information)
        Else
            con.Open()
            Dim query = "Update BookTab set BName = '" & txtName.Text & "', BAuthor = '" & txtAuthor.Text & "', BPublisher = '" & txtPublisher.Text & "', BTotalCopies = '" & txtTotal.Text & "', BBorrowedCopies = '" & txtBorrowed.Text & "' where BId= '" & key & "'"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, con)
            cmd.ExecuteNonQuery()
            MsgBox("Book Saved", MsgBoxStyle.Information)
            con.Close()
            DisplayBook()
        End If
    End Sub

    Private Sub btnReturn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReturn.Click
        Me.Hide()
        Dashboard.Show()

    End Sub

    Private Sub Panel3_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel3.Paint

    End Sub
End Class