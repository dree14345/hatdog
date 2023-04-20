Imports System.Data.SqlClient

Public Class Students
    Dim con = New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Admin\Documents\LBMSdb.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True")
    Private Sub DisplayStudents()
        con.Open()
        Dim query = "SELECT * FROM StudentTbl"
        Dim adapter As SqlDataAdapter
        Dim cmd = New SqlCommand(query, con)
        adapter = New SqlDataAdapter(cmd)
        Dim builder = New SqlCommandBuilder(adapter)
        Dim ds = New DataSet()
        adapter.Fill(ds)
        StudentsDGV.DataSource = ds.Tables(0)
        con.Close()
    End Sub
    Private Sub Students_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DisplayStudents()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If txtName.Text = "" Or txtDep.Text = "" Or txtSem.Text = "" Or txtPhone.Text = "" Then
            MsgBox("Missing information", MsgBoxStyle.Information)
        Else
            con.Open()
            Dim query = "Insert into StudentTbl values('" & txtName.Text & "', '" & txtDep.Text & "', '" & txtSem.Text & "', '" & txtPhone.Text & "')"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, con)
            cmd.ExecuteNonQuery()
            MsgBox("Student info saved!", MsgBoxStyle.Information)
            con.Close()
            DisplayStudents()
        End If
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub
    Public Sub Reset()
        txtName.Text = ""
        txtDep.Text = ""
        txtSem.Text = ""
        txtPhone.Text = ""
    End Sub
    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        If txtName.Text = "" Or txtDep.Text = "" Or txtSem.Text = "" Or txtPhone.Text = "" Then
            MsgBox("Missing information", MsgBoxStyle.Information)
        Else
            con.Open()
            Dim query = "Update StudentTbl set stdName = '" & txtName.Text & "', stdDep = '" _
                        & txtDep.Text & "', stSem = '" & txtSem.Text & "', stPhone = '" & txtPhone.Text & "'"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, con)
            cmd.ExecuteNonQuery()
            MsgBox("Edit Successfully!", MsgBoxStyle.Information)
            con.Close()
            DisplayStudents()
            Reset()

        End If
    End Sub

    Private Sub btnDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDel.Click
        If txtName.Text = "" Or txtDep.Text = "" Or txtSem.Text = "" Or txtPhone.Text = "" Then
            MsgBox("Missing information", MsgBoxStyle.Information)
        Else
            con.Open()
            Dim query = "Update StudentTbl set stdName = '" & txtName.Text & "', stdDep = '" _
                        & txtDep.Text & "', stSem = '" & txtSem.Text & "', stPhone = '" & txtPhone.Text & "'"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, con)
            cmd.ExecuteNonQuery()
            MsgBox("Delete Succesfully!", MsgBoxStyle.Information)
            con.Close()
            DisplayStudents()
            Reset()

        End If
    End Sub

    Private Sub btnReturn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReturn.Click
        Me.Hide()
        Dashboard.Show()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        If MsgBox("Would you like to exit?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Application.ExitThread()
        End If
    End Sub

    Private Sub StudentsDGV_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles StudentsDGV.CellContentClick

    End Sub
    Dim key = 0
    Private Sub StudentsDGV_CellMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles StudentsDGV.CellMouseClick
        Dim row As DataGridViewRow = StudentsDGV.Rows(e.RowIndex)
        txtName.Text = row.Cells(1).Value.ToString
        txtDep.Text = row.Cells(2).Value.ToString
        txtSem.Text = row.Cells(3).Value.ToString
        txtPhone.Text = row.Cells(4).Value.ToString
        If txtName.Text = "" Then
            key = 0
        Else
            key = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        con.Open()
        Dim query = "TRUNCATE TABLE StudentTbl"
        Dim cmd As SqlCommand
        cmd = New SqlCommand(query, con)
        cmd.ExecuteNonQuery()
        MsgBox("All Books Cleared", MsgBoxStyle.Information)
        con.Close()
        DisplayStudents()
    End Sub
    
    Private Sub btnRes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRes.Click
        Reset()
    End Sub
End Class