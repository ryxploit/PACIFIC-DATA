Public Class buscareport
    Private Sub EmpleadosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles EmpleadosBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.EmpleadosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.KiaDatosDataSet)

    End Sub

    Private Sub buscareport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'KiaDatosDataSet.empleados' Puede moverla o quitarla según sea necesario.
        Me.EmpleadosTableAdapter.Fill(Me.KiaDatosDataSet.empleados)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.EmpleadosTableAdapter.FillBy(Me.KiaDatosDataSet.empleados, NombresTextBox.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim repor As New ReportEMPLEADOS
        repor.SetDataSource(KiaDatosDataSet)
        REPORTE_EMPLEADOS.CrystalReportViewer1.ReportSource = repor
        REPORTE_EMPLEADOS.Show()

    End Sub
End Class