Public Class BECARIOS
    Private Sub BecariosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles BecariosBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.BecariosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.KiaDatosDataSet1)

    End Sub

    Private Sub BECARIOS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'KiaDatosDataSet1.becarios' Puede moverla o quitarla según sea necesario.
        Me.BecariosTableAdapter.Fill(Me.KiaDatosDataSet1.becarios)

    End Sub

    Private Sub FotoLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.BecariosTableAdapter.FillBy(Me.KiaDatosDataSet1.becarios, NombresTextBox.Text)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Validate()
        Me.BecariosBindingSource.AddNew()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Validate()
        Me.BecariosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.KiaDatosDataSet1)

        Me.BecariosTableAdapter.Fill(Me.KiaDatosDataSet1.becarios)

        IdbecarioTextBox.Clear()
        NombresTextBox.Clear()
        ApellidosTextBox.Clear()
        Me.Fe_nacimientoDateTimePicker.Text = Now.ToLongDateString
        CarreraTextBox.Clear()
        UniversidadTextBox.Clear()
        PeriodoDateTimePicker.Text = Now.ToLongDateString
        Periodo_finDateTimePicker.Text = Now.ToLongDateString
        HorasTextBox.Clear()
        Horas_finTextBox.Clear()
        ComentariosTextBox.Clear()
        FotoPictureBox.Image = Nothing
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.BecariosTableAdapter.BORRAR(NombresTextBox.Text)
        Dim r As Integer
        r = MsgBox("Desea eliminar este empleado", vbYesNo + vbQuestion)
        If r = vbYes Then
            MsgBox("eliminado")
        Else

        End If

        Me.BecariosTableAdapter.Fill(Me.KiaDatosDataSet1.becarios)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Try
            OpenFileDialog1.Title = "Abrir Imagen"
            OpenFileDialog1.FileName = ".jpg"
            OpenFileDialog1.Filter = "All Files |*.*"
            OpenFileDialog1.ShowDialog()
            FotoPictureBox.Image = System.Drawing.Image.FromFile(OpenFileDialog1.FileName)

        Catch ex As Exception

            'Do Nothing End Try 

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        BUSCARBECARIO.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.BecariosTableAdapter.Fill(Me.KiaDatosDataSet1.becarios)
    End Sub

    Private Sub Fe_nacimientoDateTimePicker_ValueChanged(sender As Object, e As EventArgs) Handles Fe_nacimientoDateTimePicker.ValueChanged

    End Sub
End Class