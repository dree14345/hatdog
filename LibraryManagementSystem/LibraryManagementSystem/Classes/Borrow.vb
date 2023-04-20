Imports System.Data.SqlClient

Public Class Borrow
    Dim con = New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Admin\Documents\LBMSdb.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True")
    Private Sub DisplayBook()
        con.Open()
        Dim query = "SELECT * FROM BorrowTab"
        Dim adapter As SqlDataAdapter
        Dim cmd = New SqlCommand(query, con)
        adapter = New SqlDataAdapter(cmd)
        Dim builder = New SqlCommandBuilder(adapter)
        Dim ds = New DataSet()
        adapter.Fill(ds)
        BorrowDGV.DataSource = ds.Tables(0)
        con.Close()
    End Sub
    Dim num = 0
    Private Sub CountBook()
        Try
            Dim Num As Integer
            con.Open()
            Dim query = "SELECT Count(*) from BorrowTab where stdId = '" & stdIdCb.SelectedValue.ToString() & "'"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, con)
            Num = cmd.ExecuteScalar
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub FillStudents()
        con.Open()
        Dim query = "SELECT * FROM StudentTbl"
        Dim cmd As New SqlCommand(query, con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim Tbl As New DataTable()
        adapter.Fill(Tbl)
        stdIdCb.DataSource = Tbl
        stdIdCb.DisplayMember = "stdId"
        stdIdCb.ValueMember = "stdId"
        con.Close()

    End Sub
    Private Sub GetStudentName()
        con.Open()
        Dim query = "SELECT * FROM StudentTbl Where stdId = '" & stdIdCb.SelectedValue.ToString() & "'"
        Dim cmd As New SqlCommand(query, con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        Dim reader As SqlDataReader
        reader = cmd.ExecuteReader()
        While reader.Read
            stName.Text = "" + reader(1).ToString()
        End While
        con.Close()

    End Sub
    Private Sub GetBookName()
        con.Open()
        Dim query = "SELECT * FROM BookTab Where BID = '" & stdBCb.SelectedValue.ToString() & "'"
        Dim cmd As New SqlCommand(query, con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        Dim reader As SqlDataReader
        reader = cmd.ExecuteReader()
        While reader.Read
            bName.Text = "" + reader(1).ToString()
        End While
        con.Close()
    End Sub
    Private Sub FillBooks()
        con.Open()
        Dim query = "SELECT * FROM BookTab"
        Dim cmd As New SqlCommand(query, con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim Tbl As New DataTable()
        adapter.Fill(Tbl)
        stdBCb.DataSource = Tbl
        stdBCb.DisplayMember = "BID"
        stdBCb.ValueMember = "BID"
        con.Close()
    End Sub
    Private Sub Reset()
        stdIdCb.SelectedValue = ""
        stName.Text = ""
        stdBCb.SelectedValue = ""
        bName.Text = ""
    End Sub
    Private Sub Borrow_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DisplayBook()
        FillStudents()
        FillBooks()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubmit.Click
        CountBook()
        If stName.Text = "" Or bName.Text = "" Or stdIdCb.SelectedIndex = -1 Or stdBCb.Text = "" Then
            MsgBox("Missing information")
        ElseIf num = 5 Then
            MsgBox("No more than 5 Books should be Borrowed")
        Else
            Try
                con.Open()
                Dim query = "Insert into BorrowTab values(" & stdIdCb.SelectedValue.ToString() & ", '" & stName.Text & "', '" & stdBCb.SelectedValue.ToString() & "', '" & bName.Text & "', '" & borrowDTP.Value.Date & "')"
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, con)
                cmd.ExecuteNonQuery()
                MsgBox("Book Successfully Returned!", MsgBoxStyle.Information)
                con.Close()
                DisplayBook()
            Catch ex As Exception
                MsgBox(ex.Message)
                con.Close()
            End Try

        End If
    End Sub

    Private Sub stdBCb_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles stdBCb.SelectedIndexChanged

    End Sub

    Private Sub stdIdCb_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles stdIdCb.SelectionChangeCommitted
        GetStudentName()

    End Sub

    Private Sub stdBCb_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles stdBCb.SelectionChangeCommitted
        GetBookName()

    End Sub

    Private Sub btnRes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRes.Click
        Reset()

    End Sub

    Private Sub Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub BorrowDGV_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles BorrowDGV.CellContentClick

    End Sub
    Dim key = 0
    Private Sub BorrowDGV_CellMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles BorrowDGV.CellMouseClick
        Dim row As DataGridViewRow = BorrowDGV.Rows(e.RowIndex)
        stdIdCb.SelectedValue = row.Cells(1).Value.ToString
        stName.Text = row.Cells(2).Value.ToString
        stdBCb.SelectedValue = row.Cells(3).Value.ToString
        bName.Text = row.Cells(4).Value.ToString
        borrowDTP.Text = row.Cells(5).Value.ToString
        If stName.Text = "" Then
            key = 0
        Else
            key = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        If stName.Text = "" Or bName.Text = "" Or stdIdCb.SelectedIndex = -1 Or stdBCb.Text = "" Then
            MsgBox("Missing information", MsgBoxStyle.Information)
        Else
            con.Open()
            Dim query = "Update BorrowTab set stdId = '" & stdIdCb.SelectedValue.ToString() & "', stdName = '" _
                        & stName.Text & "', BId = '" & stdBCb.SelectedValue.ToString() & "', BName = '" & bName.Text & "', BDate = '" & borrowDTP.Value.Date & "' where INum = '" & key & "'"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, con)
            cmd.ExecuteNonQuery()
            MsgBox("Edit Successfully!", MsgBoxStyle.Information)
            con.Close()
            DisplayBook()
            Reset()

        End If
    End Sub

    Private Sub Panel3_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub stdIdCb_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles stdIdCb.SelectedIndexChanged

    End Sub

    Private Sub btnReturn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReturn.Click
        Me.Hide()
        Dashboard.Show()

    End Sub
End Class