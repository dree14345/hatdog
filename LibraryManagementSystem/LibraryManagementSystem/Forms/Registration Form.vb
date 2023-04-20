Imports System.Data.SqlClient

Public Class Registration_Form
    Dim con = New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Admin\Documents\LBMSdb.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True")
    Private Sub Registration_Form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnReg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReg.Click
        If txtName.Text = "" Or txtPass.Text = "" Then
            MsgBox("Missing information", MsgBoxStyle.Information)
        Else
            con.Open()
            Dim query = "Insert into Users values('" & txtName.Text & "', '" & txtPass.Text & "')"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, con)
            cmd.ExecuteNonQuery()
            MsgBox("You have registered successfully!", MsgBoxStyle.Information)
            con.Close()
            Form1.Show()

        End If
    End Sub
End Class