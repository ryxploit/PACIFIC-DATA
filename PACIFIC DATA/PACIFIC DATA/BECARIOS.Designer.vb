<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BECARIOS
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim IdbecarioLabel As System.Windows.Forms.Label
        Dim NombresLabel As System.Windows.Forms.Label
        Dim ApellidosLabel As System.Windows.Forms.Label
        Dim Fe_nacimientoLabel As System.Windows.Forms.Label
        Dim CarreraLabel As System.Windows.Forms.Label
        Dim UniversidadLabel As System.Windows.Forms.Label
        Dim PeriodoLabel As System.Windows.Forms.Label
        Dim Periodo_finLabel As System.Windows.Forms.Label
        Dim HorasLabel As System.Windows.Forms.Label
        Dim Horas_finLabel As System.Windows.Forms.Label
        Dim ComentariosLabel As System.Windows.Forms.Label
        Dim FotoLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BECARIOS))
        Me.KiaDatosDataSet1 = New PACIFIC_DATA.KiaDatosDataSet1()
        Me.BecariosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BecariosTableAdapter = New PACIFIC_DATA.KiaDatosDataSet1TableAdapters.becariosTableAdapter()
        Me.TableAdapterManager = New PACIFIC_DATA.KiaDatosDataSet1TableAdapters.TableAdapterManager()
        Me.BecariosBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BecariosBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.BecariosDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.IdbecarioTextBox = New System.Windows.Forms.TextBox()
        Me.NombresTextBox = New System.Windows.Forms.TextBox()
        Me.ApellidosTextBox = New System.Windows.Forms.TextBox()
        Me.Fe_nacimientoDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.CarreraTextBox = New System.Windows.Forms.TextBox()
        Me.UniversidadTextBox = New System.Windows.Forms.TextBox()
        Me.PeriodoDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Periodo_finDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.HorasTextBox = New System.Windows.Forms.TextBox()
        Me.Horas_finTextBox = New System.Windows.Forms.TextBox()
        Me.ComentariosTextBox = New System.Windows.Forms.TextBox()
        Me.FotoPictureBox = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        IdbecarioLabel = New System.Windows.Forms.Label()
        NombresLabel = New System.Windows.Forms.Label()
        ApellidosLabel = New System.Windows.Forms.Label()
        Fe_nacimientoLabel = New System.Windows.Forms.Label()
        CarreraLabel = New System.Windows.Forms.Label()
        UniversidadLabel = New System.Windows.Forms.Label()
        PeriodoLabel = New System.Windows.Forms.Label()
        Periodo_finLabel = New System.Windows.Forms.Label()
        HorasLabel = New System.Windows.Forms.Label()
        Horas_finLabel = New System.Windows.Forms.Label()
        ComentariosLabel = New System.Windows.Forms.Label()
        FotoLabel = New System.Windows.Forms.Label()
        CType(Me.KiaDatosDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BecariosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BecariosBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BecariosBindingNavigator.SuspendLayout()
        CType(Me.BecariosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FotoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdbecarioLabel
        '
        IdbecarioLabel.AutoSize = True
        IdbecarioLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IdbecarioLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        IdbecarioLabel.Location = New System.Drawing.Point(12, 39)
        IdbecarioLabel.Name = "IdbecarioLabel"
        IdbecarioLabel.Size = New System.Drawing.Size(77, 15)
        IdbecarioLabel.TabIndex = 2
        IdbecarioLabel.Text = "ID BECARIO:"
        '
        'NombresLabel
        '
        NombresLabel.AutoSize = True
        NombresLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NombresLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        NombresLabel.Location = New System.Drawing.Point(12, 67)
        NombresLabel.Name = "NombresLabel"
        NombresLabel.Size = New System.Drawing.Size(80, 15)
        NombresLabel.TabIndex = 4
        NombresLabel.Text = "NOMBRE(S):"
        '
        'ApellidosLabel
        '
        ApellidosLabel.AutoSize = True
        ApellidosLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ApellidosLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        ApellidosLabel.Location = New System.Drawing.Point(12, 93)
        ApellidosLabel.Name = "ApellidosLabel"
        ApellidosLabel.Size = New System.Drawing.Size(84, 15)
        ApellidosLabel.TabIndex = 6
        ApellidosLabel.Text = "APELLIDO(S):"
        '
        'Fe_nacimientoLabel
        '
        Fe_nacimientoLabel.AutoSize = True
        Fe_nacimientoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Fe_nacimientoLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Fe_nacimientoLabel.Location = New System.Drawing.Point(12, 115)
        Fe_nacimientoLabel.Name = "Fe_nacimientoLabel"
        Fe_nacimientoLabel.Size = New System.Drawing.Size(84, 30)
        Fe_nacimientoLabel.TabIndex = 8
        Fe_nacimientoLabel.Text = "FECHA DE " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "NACIMIENTO:"
        '
        'CarreraLabel
        '
        CarreraLabel.AutoSize = True
        CarreraLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CarreraLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        CarreraLabel.Location = New System.Drawing.Point(12, 156)
        CarreraLabel.Name = "CarreraLabel"
        CarreraLabel.Size = New System.Drawing.Size(67, 15)
        CarreraLabel.TabIndex = 10
        CarreraLabel.Text = "CARRERA:"
        '
        'UniversidadLabel
        '
        UniversidadLabel.AutoSize = True
        UniversidadLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        UniversidadLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        UniversidadLabel.Location = New System.Drawing.Point(12, 183)
        UniversidadLabel.Name = "UniversidadLabel"
        UniversidadLabel.Size = New System.Drawing.Size(65, 15)
        UniversidadLabel.TabIndex = 12
        UniversidadLabel.Text = "ESCUELA:"
        '
        'PeriodoLabel
        '
        PeriodoLabel.AutoSize = True
        PeriodoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PeriodoLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        PeriodoLabel.Location = New System.Drawing.Point(12, 208)
        PeriodoLabel.Name = "PeriodoLabel"
        PeriodoLabel.Size = New System.Drawing.Size(65, 15)
        PeriodoLabel.TabIndex = 14
        PeriodoLabel.Text = "PERIODO:"
        '
        'Periodo_finLabel
        '
        Periodo_finLabel.AutoSize = True
        Periodo_finLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Periodo_finLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Periodo_finLabel.Location = New System.Drawing.Point(12, 234)
        Periodo_finLabel.Name = "Periodo_finLabel"
        Periodo_finLabel.Size = New System.Drawing.Size(107, 15)
        Periodo_finLabel.TabIndex = 16
        Periodo_finLabel.Text = "FIN DE PERIODO:"
        '
        'HorasLabel
        '
        HorasLabel.AutoSize = True
        HorasLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        HorasLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        HorasLabel.Location = New System.Drawing.Point(12, 264)
        HorasLabel.Name = "HorasLabel"
        HorasLabel.Size = New System.Drawing.Size(52, 15)
        HorasLabel.TabIndex = 18
        HorasLabel.Text = "HORAS:"
        '
        'Horas_finLabel
        '
        Horas_finLabel.AutoSize = True
        Horas_finLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Horas_finLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Horas_finLabel.Location = New System.Drawing.Point(12, 290)
        Horas_finLabel.Name = "Horas_finLabel"
        Horas_finLabel.Size = New System.Drawing.Size(74, 15)
        Horas_finLabel.TabIndex = 20
        Horas_finLabel.Text = "FIN HORAS:"
        '
        'ComentariosLabel
        '
        ComentariosLabel.AutoSize = True
        ComentariosLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ComentariosLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        ComentariosLabel.Location = New System.Drawing.Point(12, 316)
        ComentariosLabel.Name = "ComentariosLabel"
        ComentariosLabel.Size = New System.Drawing.Size(98, 15)
        ComentariosLabel.TabIndex = 22
        ComentariosLabel.Text = "COMENTARIOS:"
        '
        'FotoLabel
        '
        FotoLabel.AutoSize = True
        FotoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FotoLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        FotoLabel.Location = New System.Drawing.Point(405, 41)
        FotoLabel.Name = "FotoLabel"
        FotoLabel.Size = New System.Drawing.Size(42, 15)
        FotoLabel.TabIndex = 24
        FotoLabel.Text = "FOTO:"
        AddHandler FotoLabel.Click, AddressOf Me.FotoLabel_Click
        '
        'KiaDatosDataSet1
        '
        Me.KiaDatosDataSet1.DataSetName = "KiaDatosDataSet1"
        Me.KiaDatosDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BecariosBindingSource
        '
        Me.BecariosBindingSource.DataMember = "becarios"
        Me.BecariosBindingSource.DataSource = Me.KiaDatosDataSet1
        '
        'BecariosTableAdapter
        '
        Me.BecariosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.becariosTableAdapter = Me.BecariosTableAdapter
        Me.TableAdapterManager.empleadosTableAdapter = Nothing
        Me.TableAdapterManager.loginTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = PACIFIC_DATA.KiaDatosDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'BecariosBindingNavigator
        '
        Me.BecariosBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.BecariosBindingNavigator.BindingSource = Me.BecariosBindingSource
        Me.BecariosBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.BecariosBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.BecariosBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.BecariosBindingNavigatorSaveItem})
        Me.BecariosBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.BecariosBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BecariosBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BecariosBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BecariosBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BecariosBindingNavigator.Name = "BecariosBindingNavigator"
        Me.BecariosBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.BecariosBindingNavigator.Size = New System.Drawing.Size(676, 25)
        Me.BecariosBindingNavigator.TabIndex = 0
        Me.BecariosBindingNavigator.Text = "BindingNavigator1"
        Me.BecariosBindingNavigator.Visible = False
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'BecariosBindingNavigatorSaveItem
        '
        Me.BecariosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BecariosBindingNavigatorSaveItem.Image = CType(resources.GetObject("BecariosBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.BecariosBindingNavigatorSaveItem.Name = "BecariosBindingNavigatorSaveItem"
        Me.BecariosBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.BecariosBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'BecariosDataGridView
        '
        Me.BecariosDataGridView.AutoGenerateColumns = False
        Me.BecariosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BecariosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewImageColumn1})
        Me.BecariosDataGridView.DataSource = Me.BecariosBindingSource
        Me.BecariosDataGridView.Enabled = False
        Me.BecariosDataGridView.Location = New System.Drawing.Point(12, 448)
        Me.BecariosDataGridView.Name = "BecariosDataGridView"
        Me.BecariosDataGridView.Size = New System.Drawing.Size(652, 220)
        Me.BecariosDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Idbecario"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Idbecario"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "nombres"
        Me.DataGridViewTextBoxColumn2.HeaderText = "nombres"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "apellidos"
        Me.DataGridViewTextBoxColumn3.HeaderText = "apellidos"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "fe_nacimiento"
        Me.DataGridViewTextBoxColumn4.HeaderText = "fe_nacimiento"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "carrera"
        Me.DataGridViewTextBoxColumn5.HeaderText = "carrera"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "universidad"
        Me.DataGridViewTextBoxColumn6.HeaderText = "universidad"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "periodo"
        Me.DataGridViewTextBoxColumn7.HeaderText = "periodo"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "periodo_fin"
        Me.DataGridViewTextBoxColumn8.HeaderText = "periodo_fin"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "horas"
        Me.DataGridViewTextBoxColumn9.HeaderText = "horas"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "horas fin"
        Me.DataGridViewTextBoxColumn10.HeaderText = "horas fin"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "comentarios"
        Me.DataGridViewTextBoxColumn11.HeaderText = "comentarios"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.DataPropertyName = "foto"
        Me.DataGridViewImageColumn1.HeaderText = "foto"
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        '
        'IdbecarioTextBox
        '
        Me.IdbecarioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BecariosBindingSource, "Idbecario", True))
        Me.IdbecarioTextBox.Location = New System.Drawing.Point(123, 36)
        Me.IdbecarioTextBox.Multiline = True
        Me.IdbecarioTextBox.Name = "IdbecarioTextBox"
        Me.IdbecarioTextBox.Size = New System.Drawing.Size(68, 20)
        Me.IdbecarioTextBox.TabIndex = 3
        '
        'NombresTextBox
        '
        Me.NombresTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BecariosBindingSource, "nombres", True))
        Me.NombresTextBox.Location = New System.Drawing.Point(123, 65)
        Me.NombresTextBox.Multiline = True
        Me.NombresTextBox.Name = "NombresTextBox"
        Me.NombresTextBox.Size = New System.Drawing.Size(200, 20)
        Me.NombresTextBox.TabIndex = 5
        '
        'ApellidosTextBox
        '
        Me.ApellidosTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BecariosBindingSource, "apellidos", True))
        Me.ApellidosTextBox.Location = New System.Drawing.Point(123, 92)
        Me.ApellidosTextBox.Multiline = True
        Me.ApellidosTextBox.Name = "ApellidosTextBox"
        Me.ApellidosTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ApellidosTextBox.TabIndex = 7
        '
        'Fe_nacimientoDateTimePicker
        '
        Me.Fe_nacimientoDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BecariosBindingSource, "fe_nacimiento", True))
        Me.Fe_nacimientoDateTimePicker.Location = New System.Drawing.Point(123, 122)
        Me.Fe_nacimientoDateTimePicker.Name = "Fe_nacimientoDateTimePicker"
        Me.Fe_nacimientoDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Fe_nacimientoDateTimePicker.TabIndex = 9
        '
        'CarreraTextBox
        '
        Me.CarreraTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BecariosBindingSource, "carrera", True))
        Me.CarreraTextBox.Location = New System.Drawing.Point(123, 154)
        Me.CarreraTextBox.Name = "CarreraTextBox"
        Me.CarreraTextBox.Size = New System.Drawing.Size(200, 20)
        Me.CarreraTextBox.TabIndex = 11
        '
        'UniversidadTextBox
        '
        Me.UniversidadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BecariosBindingSource, "universidad", True))
        Me.UniversidadTextBox.Location = New System.Drawing.Point(123, 181)
        Me.UniversidadTextBox.Name = "UniversidadTextBox"
        Me.UniversidadTextBox.Size = New System.Drawing.Size(200, 20)
        Me.UniversidadTextBox.TabIndex = 13
        '
        'PeriodoDateTimePicker
        '
        Me.PeriodoDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BecariosBindingSource, "periodo", True))
        Me.PeriodoDateTimePicker.Location = New System.Drawing.Point(123, 208)
        Me.PeriodoDateTimePicker.Name = "PeriodoDateTimePicker"
        Me.PeriodoDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.PeriodoDateTimePicker.TabIndex = 15
        '
        'Periodo_finDateTimePicker
        '
        Me.Periodo_finDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BecariosBindingSource, "periodo_fin", True))
        Me.Periodo_finDateTimePicker.Location = New System.Drawing.Point(123, 235)
        Me.Periodo_finDateTimePicker.Name = "Periodo_finDateTimePicker"
        Me.Periodo_finDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Periodo_finDateTimePicker.TabIndex = 17
        '
        'HorasTextBox
        '
        Me.HorasTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BecariosBindingSource, "horas", True))
        Me.HorasTextBox.Location = New System.Drawing.Point(123, 263)
        Me.HorasTextBox.Name = "HorasTextBox"
        Me.HorasTextBox.Size = New System.Drawing.Size(200, 20)
        Me.HorasTextBox.TabIndex = 19
        '
        'Horas_finTextBox
        '
        Me.Horas_finTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BecariosBindingSource, "horas fin", True))
        Me.Horas_finTextBox.Location = New System.Drawing.Point(123, 289)
        Me.Horas_finTextBox.Name = "Horas_finTextBox"
        Me.Horas_finTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Horas_finTextBox.TabIndex = 21
        '
        'ComentariosTextBox
        '
        Me.ComentariosTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BecariosBindingSource, "comentarios", True))
        Me.ComentariosTextBox.Location = New System.Drawing.Point(123, 316)
        Me.ComentariosTextBox.Multiline = True
        Me.ComentariosTextBox.Name = "ComentariosTextBox"
        Me.ComentariosTextBox.Size = New System.Drawing.Size(200, 126)
        Me.ComentariosTextBox.TabIndex = 23
        '
        'FotoPictureBox
        '
        Me.FotoPictureBox.BackColor = System.Drawing.Color.White
        Me.FotoPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.FotoPictureBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.BecariosBindingSource, "foto", True))
        Me.FotoPictureBox.Location = New System.Drawing.Point(453, 41)
        Me.FotoPictureBox.Name = "FotoPictureBox"
        Me.FotoPictureBox.Size = New System.Drawing.Size(160, 121)
        Me.FotoPictureBox.TabIndex = 25
        Me.FotoPictureBox.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(421, 409)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(92, 33)
        Me.Button1.TabIndex = 26
        Me.Button1.Text = "REPORTE"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(555, 409)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(109, 33)
        Me.Button2.TabIndex = 27
        Me.Button2.Text = "REFRESCAR"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.White
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(421, 307)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(92, 33)
        Me.Button3.TabIndex = 28
        Me.Button3.Text = "ELIMINAR"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.White
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(545, 250)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(92, 33)
        Me.Button4.TabIndex = 29
        Me.Button4.Text = "GUARDAR"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.White
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(421, 250)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(92, 33)
        Me.Button5.TabIndex = 30
        Me.Button5.Text = "NUEVO"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.White
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(545, 307)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(92, 33)
        Me.Button6.TabIndex = 31
        Me.Button6.Text = "BUSCAR"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.White
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Location = New System.Drawing.Point(487, 168)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(92, 33)
        Me.Button7.TabIndex = 32
        Me.Button7.Text = "EXAMINAR"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'BECARIOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.DarkRed
        Me.ClientSize = New System.Drawing.Size(684, 679)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(IdbecarioLabel)
        Me.Controls.Add(Me.IdbecarioTextBox)
        Me.Controls.Add(NombresLabel)
        Me.Controls.Add(Me.NombresTextBox)
        Me.Controls.Add(ApellidosLabel)
        Me.Controls.Add(Me.ApellidosTextBox)
        Me.Controls.Add(Fe_nacimientoLabel)
        Me.Controls.Add(Me.Fe_nacimientoDateTimePicker)
        Me.Controls.Add(CarreraLabel)
        Me.Controls.Add(Me.CarreraTextBox)
        Me.Controls.Add(UniversidadLabel)
        Me.Controls.Add(Me.UniversidadTextBox)
        Me.Controls.Add(PeriodoLabel)
        Me.Controls.Add(Me.PeriodoDateTimePicker)
        Me.Controls.Add(Periodo_finLabel)
        Me.Controls.Add(Me.Periodo_finDateTimePicker)
        Me.Controls.Add(HorasLabel)
        Me.Controls.Add(Me.HorasTextBox)
        Me.Controls.Add(Horas_finLabel)
        Me.Controls.Add(Me.Horas_finTextBox)
        Me.Controls.Add(ComentariosLabel)
        Me.Controls.Add(Me.ComentariosTextBox)
        Me.Controls.Add(FotoLabel)
        Me.Controls.Add(Me.FotoPictureBox)
        Me.Controls.Add(Me.BecariosDataGridView)
        Me.Controls.Add(Me.BecariosBindingNavigator)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "BECARIOS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BECARIOS"
        CType(Me.KiaDatosDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BecariosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BecariosBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BecariosBindingNavigator.ResumeLayout(False)
        Me.BecariosBindingNavigator.PerformLayout()
        CType(Me.BecariosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FotoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents KiaDatosDataSet1 As KiaDatosDataSet1
    Friend WithEvents BecariosBindingSource As BindingSource
    Friend WithEvents BecariosTableAdapter As KiaDatosDataSet1TableAdapters.becariosTableAdapter
    Friend WithEvents TableAdapterManager As KiaDatosDataSet1TableAdapters.TableAdapterManager
    Friend WithEvents BecariosBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents BecariosBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents BecariosDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents IdbecarioTextBox As TextBox
    Friend WithEvents NombresTextBox As TextBox
    Friend WithEvents ApellidosTextBox As TextBox
    Friend WithEvents Fe_nacimientoDateTimePicker As DateTimePicker
    Friend WithEvents CarreraTextBox As TextBox
    Friend WithEvents UniversidadTextBox As TextBox
    Friend WithEvents PeriodoDateTimePicker As DateTimePicker
    Friend WithEvents Periodo_finDateTimePicker As DateTimePicker
    Friend WithEvents HorasTextBox As TextBox
    Friend WithEvents Horas_finTextBox As TextBox
    Friend WithEvents ComentariosTextBox As TextBox
    Friend WithEvents FotoPictureBox As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
