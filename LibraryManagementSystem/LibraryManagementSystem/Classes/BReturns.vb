Imports System.Data.SqlClient

Public Class BReturns
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
    Private Sub DisplayReturnBook()
        con.Open()
        Dim query = "SELECT * FROM ReturnTbl"
        Dim adapter As SqlDataAdapter
        Dim cmd = New SqlCommand(query, con)
        adapter = New SqlDataAdapter(cmd)
        Dim builder = New SqlCommandBuilder(adapter)
        Dim ds = New DataSet()
        adapter.Fill(ds)
        ReturnDGV.DataSource = ds.Tables(0)
        con.Close()
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles stdIdCb.SelectedIndexChanged

    End Sub

    Private Sub Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub

    Private Sub BReturns_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DisplayBook()
        DisplayReturnBook()

    End Sub
    Dim key = 0
    Dim Fine As Integer
    Private Sub btnCalc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalc.Click
        Dim dif As TimeSpan
        dif = returnDTP.Value.Date - borrowDTP.Value.Date
        Dim Days = dif.Days
        If Days <= 7 Then
            Fine = 0
            txtFine.Text = "No Fine"
        Else
            Fine = Days - 5
            txtFine.Text = "Php" + Convert.ToString(Fine * 5)
        End If
    End Sub
    Private Sub RemoveRecords()
        Try
            con.Open()
            Dim query = "Delete from  BorrowTab where INum = '" & key & "'"
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
    End Sub
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If stName.Text = "" Or bName.Text = "" Or stdIdCb.Text = "" Or stdBCb.Text = "" Then
            MsgBox("Missing information")
        Else
            Try
                con.Open()
                Dim query = "Insert into ReturnTbl values('" & stdIdCb.SelectedValue.ToString() & "', '" & stName.Text & "', '" & stdBCb.SelectedValue.ToString() & "', '" & bName.Text & "', '" & borrowDTP.Value.Date & "', '" & returnDTP.Value.Date & "', '" & txtFine.Text & "')"
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, con)
                cmd.ExecuteNonQuery()
                MsgBox("Book Returned!", MsgBoxStyle.Information)
                con.Close()
                DisplayReturnBook()
                Reset()
            Catch ex As Exception
                MsgBox(ex.Message)
                con.Close()

            End Try

        End If
    End Sub

    Private Sub BorrowDGV_CellMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles BorrowDGV.CellMouseClick
        Dim row As DataGridViewRow = BorrowDGV.Rows(e.RowIndex)
        stdIdCb.Text = row.Cells(1).Value.ToString
        stName.Text = row.Cells(2).Value.ToString
        stdBCb.Text = row.Cells(3).Value.ToString
        bName.Text = row.Cells(4).Value.ToString
        borrowDTP.Text = row.Cells(5).Value.ToString
        If stName.Text = "" Then
            key = 0
        Else
            key = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim searchText As String = txtSearch.Text.Trim()

        If Not String.IsNullOrEmpty(searchText) Then
            con.Open()
            Dim query As String = "SELECT * FROM BorrowTab Where bName like @searchText or stdName like @searchText"
            Dim cmd As SqlCommand = New SqlCommand(query, con)
            cmd.Parameters.AddWithValue("@searchText", "%" & searchText & "%")
            Dim adapter As New SqlDataAdapter(cmd)
            Dim table As New DataTable
            adapter.Fill(table)
            BorrowDGV.DataSource = table
            con.Close()
            MsgBox("Search is Successful!", MsgBoxStyle.Information)
        End If
    End Sub
End Class