﻿Public Class PACIFIC
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ADMINS.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MsgBox("ES UN SISTEMA DE CONTROL DE EMPLEADOS")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        EMPLEADOS.Show()


    End Sub

    Private Sub PACIFIC_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        BECARIOS.Show()
    End Sub
End Class