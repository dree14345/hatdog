Imports System.Data.SqlClient

Public Class Form1
    Dim con = New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Admin\Documents\LBMSdb.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True")
    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
        Registration_Form.Show()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim username As String = txtName.Text
        Dim password As String = txtPass.Text

        con.Open()
        Dim query As String = "SELECT * FROM Users where Username = @username And Password = @password"
        Dim com = New SqlCommand(query, con)
        com.Parameters.AddWithValue("@username", username)
        com.Parameters.AddWithValue("@password", password)
        Dim reader As SqlDataReader = com.ExecuteReader()
        If reader.HasRows Then
            MessageBox.Show("Login Successfully!")
            Me.Hide()
            Dashboard.Show()
            con.Close()

        Else
            MessageBox.Show("Invalid username or password!")
            con.Close()

        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
