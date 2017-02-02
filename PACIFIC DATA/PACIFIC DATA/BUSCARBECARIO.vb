Public Class BUSCARBECARIO
    Private Sub BecariosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles BecariosBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.BecariosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.KiaDatosDataSet1)

    End Sub

    Private Sub BUSCARBECARIO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'KiaDatosDataSet1.becarios' Puede moverla o quitarla según sea necesario.
        Me.BecariosTableAdapter.Fill(Me.KiaDatosDataSet1.becarios)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.BecariosTableAdapter.FillBy(Me.KiaDatosDataSet1.becarios, NombresTextBox.Text)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim report As New ReportBECARIO
        report.SetDataSource(KiaDatosDataSet1)
        REPORTEBECA.CrystalReportViewer1.ReportSource = report
        REPORTEBECA.Show()

    End Sub
End Class