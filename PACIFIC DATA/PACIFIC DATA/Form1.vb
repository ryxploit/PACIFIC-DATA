Imports System.Data.OleDb
Public Class Form1
    Dim conexion As New OleDbConnection
    Dim comandos As New OleDbCommand
    Dim adaptador As New OleDbDataAdapter
    Dim lector As OleDbDataReader
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim consulta As String

        consulta = "SELECT  usuarios, contraseña FROM login WHERE usuarios = '" & TextBox1.Text & "' AND contraseña = '" & TextBox2.Text & "'"
        comandos = New OleDbCommand(consulta, conexion)
        adaptador.SelectCommand = comandos
        lector = comandos.ExecuteReader
        If lector.HasRows = True Then

            Me.Hide()
            conexion.Close()
            PACIFIC.Show()
        Else
            MsgBox("usuario o contraseñas incorrectas")
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source = ..\KiaDatos.mdb"
        Try
            conexion.Open()

        Catch ex As Exception
            MsgBox("error")
        End Try
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            TextBox2.UseSystemPasswordChar = False

        Else
            TextBox2.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class
