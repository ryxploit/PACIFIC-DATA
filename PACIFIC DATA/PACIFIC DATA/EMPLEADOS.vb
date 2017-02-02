Public Class EMPLEADOS
    Private Sub EmpleadosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles EmpleadosBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.EmpleadosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.KiaDatosDataSet)

    End Sub

    Private Sub EMPLEADOS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'KiaDatosDataSet.empleados' Puede moverla o quitarla según sea necesario.
        Me.EmpleadosTableAdapter.Fill(Me.KiaDatosDataSet.empleados)


        PagadoraComboBox.Items.Add("CF administracion, S.A. de C.V.")
        PagadoraComboBox.Items.Add("CF Servicios Mecanicos, S.A. de C.V.")
        PagadoraComboBox.Items.Add("CF Accesorios y Refacciones, S.A. de C.V.")
        PagadoraComboBox.Items.Add("CF Controller, S.A. de S.V.")
        PagadoraComboBox.Items.Add("Servicios Grantt Level S.A. de C.V.")
        PagadoraComboBox.Items.Add("Otros")
        
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.EmpleadosTableAdapter.FillBy(Me.KiaDatosDataSet.empleados, NombresTextBox.Text)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Validate()
        Me.EmpleadosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.KiaDatosDataSet)

        Me.EmpleadosTableAdapter.Fill(Me.KiaDatosDataSet.empleados)

        IdempleadoTextBox.Clear()
        NombresTextBox.Clear()
        ApellidosTextBox.Clear()
        Me.Fe_ingresoDateTimePicker.Text = Now.ToLongDateString
        AreaTextBox.Clear()
        PuestoTextBox.Clear()
        Tel_celTextBox.Clear()
        PagadoraComboBox.Items.Clear()
        Ti_sangreTextBox.Clear()
        Nu_emergenciaTextBox.Clear()
        Me.Cu_añosDateTimePicker.Text = Now.ToLongDateString
        ComentarioTextBox1.Clear()
        Me.VacacionesDateTimePicker.Text = Now.ToLongDateString
        Me.Vacaciones_finDateTimePicker.Text = Now.ToLongDateString
        ComentarioTextBox.Clear()
        FotoPictureBox.Image = Nothing



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Validate()
        Me.EmpleadosBindingSource.AddNew()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.EmpleadosTableAdapter.BORRAR(NombresTextBox.Text)
        Dim r As Integer
        r = MsgBox("Desea eliminar este empleado", vbYesNo + vbQuestion)
        If r = vbYes Then
            MsgBox("eliminado")
        Else

        End If

        Me.EmpleadosTableAdapter.Fill(Me.KiaDatosDataSet.empleados)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.EmpleadosTableAdapter.Fill(Me.KiaDatosDataSet.empleados)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
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

    Private Sub FotoLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click


        buscareport.Show()

    End Sub

    Private Sub Fe_ingresoDateTimePicker_ValueChanged(sender As Object, e As EventArgs) Handles Fe_ingresoDateTimePicker.ValueChanged
        Dim Fecha As String
        Fecha = FormatDateTime(Now, DateFormat.ShortDate)

    End Sub
End Class