Imports System.Data.OleDb
Public Class ADMINS
    Dim conexion As New OleDbConnection
    Dim comandos As New OleDbCommand
    Dim adaptador As New OleDbDataAdapter
    Dim registro As New DataSet
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            comandos = New OleDbCommand("INSERT INTO login(usuarios,contraseña ) VALUES (TexBox1,TexBox2)", conexion)

            comandos.Parameters.AddWithValue("@usuarios", TextBox1.Text)
            comandos.Parameters.AddWithValue("@contraseña", TextBox2.Text)

            comandos.ExecuteNonQuery()

            MsgBox("agregado")
            Me.Hide()
            PACIFIC.Show()

            TextBox1.Clear()
            TextBox2.Clear()
        Catch ex As Exception
            MsgBox("error al agregar")
        End Try
    End Sub

    Private Sub ADMINS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source = ..\KiaDatos.mdb"
        Try
            conexion.Open()

        Catch ex As Exception
            MsgBox("error")
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        PACIFIC.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim consulta As String
        Dim lista As Byte
        If TextBox1.Text <> "" Then
            consulta = "SELECT *FROM login WHERE usuarios = '" & TextBox1.Text & "'"
            adaptador = New OleDbDataAdapter(consulta, conexion)
            registro = New DataSet
            adaptador.Fill(registro, "login")
            lista = registro.Tables("login").Rows.Count

        End If

        If lista <> 0 Then
            TextBox1.Text = registro.Tables("login").Rows(0).Item("usuarios")
            TextBox2.Text = registro.Tables("login").Rows(0).Item("contraseña")

        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim eliminar As String
        Dim respuesta As Byte

        respuesta = MsgBox("¿estas seguro que desea eliminar este registro?", vbYesNo, "eliminado")

        If respuesta = vbYes Then
            eliminar = "DELETE FROM login WHERE usuarios = '" & TextBox1.Text & "'"

            'adaptador = New OleDbDataAdapter(consulta, conexion)

            comandos = New OleDbCommand(eliminar, conexion)
            comandos.ExecuteNonQuery()

            MsgBox("Registro eliminado correctamente")

            TextBox1.Clear()
            TextBox2.Clear()


        Else
            MsgBox("Error al eliminar")


        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim actualizar As String

        Try
            actualizar = "UPDATE  login SET  usuarios = '" & TextBox1.Text &
            "',contraseña = '" & TextBox2.Text &
            "'WHERE usuarios = '" & TextBox1.Text & "'"

            comandos = New OleDbCommand(actualizar, conexion)
            comandos.ExecuteNonQuery()
            MsgBox("El registro ha sido actualizado correctamente")

            TextBox1.Clear()
            TextBox2.Clear()


        Catch ex As Exception
            MsgBox("No se a podido actualizar el registro")

        End Try
    End Sub
End Class