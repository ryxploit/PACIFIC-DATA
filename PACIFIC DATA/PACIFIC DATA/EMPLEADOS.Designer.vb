<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EMPLEADOS
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
        Dim ComentarioLabel1 As System.Windows.Forms.Label
        Dim Cu_añosLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EMPLEADOS))
        Me.IdempleadoLabel = New System.Windows.Forms.Label()
        Me.NombresLabel = New System.Windows.Forms.Label()
        Me.ApellidosLabel = New System.Windows.Forms.Label()
        Me.Fe_ingresoLabel = New System.Windows.Forms.Label()
        Me.AreaLabel = New System.Windows.Forms.Label()
        Me.PuestoLabel = New System.Windows.Forms.Label()
        Me.Tel_celLabel = New System.Windows.Forms.Label()
        Me.PagadoraLabel = New System.Windows.Forms.Label()
        Me.Ti_sangreLabel = New System.Windows.Forms.Label()
        Me.NssLabel = New System.Windows.Forms.Label()
        Me.Nu_emergenciaLabel = New System.Windows.Forms.Label()
        Me.VacacionesLabel = New System.Windows.Forms.Label()
        Me.Vacaciones_finLabel = New System.Windows.Forms.Label()
        Me.ComentarioLabel = New System.Windows.Forms.Label()
        Me.FotoLabel = New System.Windows.Forms.Label()
        Me.EmpleadosBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.EmpleadosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KiaDatosDataSet = New PACIFIC_DATA.KiaDatosDataSet()
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
        Me.EmpleadosBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.EmpleadosDataGridView = New System.Windows.Forms.DataGridView()
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
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.IdempleadoTextBox = New System.Windows.Forms.TextBox()
        Me.NombresTextBox = New System.Windows.Forms.TextBox()
        Me.ApellidosTextBox = New System.Windows.Forms.TextBox()
        Me.Fe_ingresoDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.AreaTextBox = New System.Windows.Forms.TextBox()
        Me.PuestoTextBox = New System.Windows.Forms.TextBox()
        Me.Tel_celTextBox = New System.Windows.Forms.TextBox()
        Me.PagadoraComboBox = New System.Windows.Forms.ComboBox()
        Me.Ti_sangreTextBox = New System.Windows.Forms.TextBox()
        Me.NssTextBox = New System.Windows.Forms.TextBox()
        Me.Nu_emergenciaTextBox = New System.Windows.Forms.TextBox()
        Me.VacacionesDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Vacaciones_finDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ComentarioTextBox = New System.Windows.Forms.TextBox()
        Me.FotoPictureBox = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.EmpleadosTableAdapter = New PACIFIC_DATA.KiaDatosDataSetTableAdapters.empleadosTableAdapter()
        Me.TableAdapterManager = New PACIFIC_DATA.KiaDatosDataSetTableAdapters.TableAdapterManager()
        Me.ComentarioTextBox1 = New System.Windows.Forms.TextBox()
        Me.Cu_añosDateTimePicker = New System.Windows.Forms.DateTimePicker()
        ComentarioLabel1 = New System.Windows.Forms.Label()
        Cu_añosLabel = New System.Windows.Forms.Label()
        CType(Me.EmpleadosBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EmpleadosBindingNavigator.SuspendLayout()
        CType(Me.EmpleadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KiaDatosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpleadosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FotoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComentarioLabel1
        '
        ComentarioLabel1.AutoSize = True
        ComentarioLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ComentarioLabel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        ComentarioLabel1.Location = New System.Drawing.Point(16, 338)
        ComentarioLabel1.Name = "ComentarioLabel1"
        ComentarioLabel1.Size = New System.Drawing.Size(75, 15)
        ComentarioLabel1.TabIndex = 43
        ComentarioLabel1.Text = "UNIFORME:"
        '
        'Cu_añosLabel
        '
        Cu_añosLabel.AutoSize = True
        Cu_añosLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Cu_añosLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Cu_añosLabel.Location = New System.Drawing.Point(9, 312)
        Cu_añosLabel.Name = "Cu_añosLabel"
        Cu_añosLabel.Size = New System.Drawing.Size(125, 15)
        Cu_añosLabel.TabIndex = 44
        Cu_añosLabel.Text = "FE. DE NACIMIENTO:"
        '
        'IdempleadoLabel
        '
        Me.IdempleadoLabel.AutoSize = True
        Me.IdempleadoLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.IdempleadoLabel.Location = New System.Drawing.Point(17, 27)
        Me.IdempleadoLabel.Name = "IdempleadoLabel"
        Me.IdempleadoLabel.Size = New System.Drawing.Size(83, 13)
        Me.IdempleadoLabel.TabIndex = 2
        Me.IdempleadoLabel.Text = "ID EMPLEADO:"
        '
        'NombresLabel
        '
        Me.NombresLabel.AutoSize = True
        Me.NombresLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.NombresLabel.Location = New System.Drawing.Point(17, 53)
        Me.NombresLabel.Name = "NombresLabel"
        Me.NombresLabel.Size = New System.Drawing.Size(70, 13)
        Me.NombresLabel.TabIndex = 4
        Me.NombresLabel.Text = "NOMBRE(S):"
        '
        'ApellidosLabel
        '
        Me.ApellidosLabel.AutoSize = True
        Me.ApellidosLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ApellidosLabel.Location = New System.Drawing.Point(17, 79)
        Me.ApellidosLabel.Name = "ApellidosLabel"
        Me.ApellidosLabel.Size = New System.Drawing.Size(75, 13)
        Me.ApellidosLabel.TabIndex = 6
        Me.ApellidosLabel.Text = "APELLIDO(S):"
        '
        'Fe_ingresoLabel
        '
        Me.Fe_ingresoLabel.AutoSize = True
        Me.Fe_ingresoLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Fe_ingresoLabel.Location = New System.Drawing.Point(17, 106)
        Me.Fe_ingresoLabel.Name = "Fe_ingresoLabel"
        Me.Fe_ingresoLabel.Size = New System.Drawing.Size(115, 13)
        Me.Fe_ingresoLabel.TabIndex = 8
        Me.Fe_ingresoLabel.Text = "FECHA DE INGRESO:"
        '
        'AreaLabel
        '
        Me.AreaLabel.AutoSize = True
        Me.AreaLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.AreaLabel.Location = New System.Drawing.Point(17, 131)
        Me.AreaLabel.Name = "AreaLabel"
        Me.AreaLabel.Size = New System.Drawing.Size(39, 13)
        Me.AreaLabel.TabIndex = 10
        Me.AreaLabel.Text = "AREA:"
        '
        'PuestoLabel
        '
        Me.PuestoLabel.AutoSize = True
        Me.PuestoLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.PuestoLabel.Location = New System.Drawing.Point(17, 158)
        Me.PuestoLabel.Name = "PuestoLabel"
        Me.PuestoLabel.Size = New System.Drawing.Size(54, 13)
        Me.PuestoLabel.TabIndex = 12
        Me.PuestoLabel.Text = "PUESTO:"
        '
        'Tel_celLabel
        '
        Me.Tel_celLabel.AutoSize = True
        Me.Tel_celLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Tel_celLabel.Location = New System.Drawing.Point(17, 184)
        Me.Tel_celLabel.Name = "Tel_celLabel"
        Me.Tel_celLabel.Size = New System.Drawing.Size(55, 13)
        Me.Tel_celLabel.TabIndex = 14
        Me.Tel_celLabel.Text = "TEL/CEL:"
        '
        'PagadoraLabel
        '
        Me.PagadoraLabel.AutoSize = True
        Me.PagadoraLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.PagadoraLabel.Location = New System.Drawing.Point(17, 210)
        Me.PagadoraLabel.Name = "PagadoraLabel"
        Me.PagadoraLabel.Size = New System.Drawing.Size(70, 13)
        Me.PagadoraLabel.TabIndex = 16
        Me.PagadoraLabel.Text = "PAGADORA:"
        '
        'Ti_sangreLabel
        '
        Me.Ti_sangreLabel.AutoSize = True
        Me.Ti_sangreLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Ti_sangreLabel.Location = New System.Drawing.Point(17, 237)
        Me.Ti_sangreLabel.Name = "Ti_sangreLabel"
        Me.Ti_sangreLabel.Size = New System.Drawing.Size(101, 13)
        Me.Ti_sangreLabel.TabIndex = 18
        Me.Ti_sangreLabel.Text = "TIPO DE SANGRE:"
        '
        'NssLabel
        '
        Me.NssLabel.AutoSize = True
        Me.NssLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.NssLabel.Location = New System.Drawing.Point(17, 263)
        Me.NssLabel.Name = "NssLabel"
        Me.NssLabel.Size = New System.Drawing.Size(32, 13)
        Me.NssLabel.TabIndex = 20
        Me.NssLabel.Text = "NSS:"
        '
        'Nu_emergenciaLabel
        '
        Me.Nu_emergenciaLabel.AutoSize = True
        Me.Nu_emergenciaLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Nu_emergenciaLabel.Location = New System.Drawing.Point(17, 289)
        Me.Nu_emergenciaLabel.Name = "Nu_emergenciaLabel"
        Me.Nu_emergenciaLabel.Size = New System.Drawing.Size(121, 13)
        Me.Nu_emergenciaLabel.TabIndex = 22
        Me.Nu_emergenciaLabel.Text = "NO. DE EMERGENCIA:"
        '
        'VacacionesLabel
        '
        Me.VacacionesLabel.AutoSize = True
        Me.VacacionesLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.VacacionesLabel.Location = New System.Drawing.Point(17, 406)
        Me.VacacionesLabel.Name = "VacacionesLabel"
        Me.VacacionesLabel.Size = New System.Drawing.Size(131, 13)
        Me.VacacionesLabel.TabIndex = 28
        Me.VacacionesLabel.Text = "INICIO DE VACACIONES:"
        '
        'Vacaciones_finLabel
        '
        Me.Vacaciones_finLabel.AutoSize = True
        Me.Vacaciones_finLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Vacaciones_finLabel.Location = New System.Drawing.Point(17, 432)
        Me.Vacaciones_finLabel.Name = "Vacaciones_finLabel"
        Me.Vacaciones_finLabel.Size = New System.Drawing.Size(98, 13)
        Me.Vacaciones_finLabel.TabIndex = 30
        Me.Vacaciones_finLabel.Text = "FIN VACACIONES:"
        '
        'ComentarioLabel
        '
        Me.ComentarioLabel.AutoSize = True
        Me.ComentarioLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ComentarioLabel.Location = New System.Drawing.Point(17, 457)
        Me.ComentarioLabel.Name = "ComentarioLabel"
        Me.ComentarioLabel.Size = New System.Drawing.Size(89, 13)
        Me.ComentarioLabel.TabIndex = 32
        Me.ComentarioLabel.Text = "COMENTARIOS:"
        '
        'FotoLabel
        '
        Me.FotoLabel.Location = New System.Drawing.Point(0, 0)
        Me.FotoLabel.Name = "FotoLabel"
        Me.FotoLabel.Size = New System.Drawing.Size(100, 23)
        Me.FotoLabel.TabIndex = 43
        '
        'EmpleadosBindingNavigator
        '
        Me.EmpleadosBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.EmpleadosBindingNavigator.BindingSource = Me.EmpleadosBindingSource
        Me.EmpleadosBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.EmpleadosBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.EmpleadosBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.EmpleadosBindingNavigatorSaveItem})
        Me.EmpleadosBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.EmpleadosBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.EmpleadosBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.EmpleadosBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.EmpleadosBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.EmpleadosBindingNavigator.Name = "EmpleadosBindingNavigator"
        Me.EmpleadosBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.EmpleadosBindingNavigator.Size = New System.Drawing.Size(728, 25)
        Me.EmpleadosBindingNavigator.TabIndex = 0
        Me.EmpleadosBindingNavigator.Text = "BindingNavigator1"
        Me.EmpleadosBindingNavigator.Visible = False
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'EmpleadosBindingSource
        '
        Me.EmpleadosBindingSource.DataMember = "empleados"
        Me.EmpleadosBindingSource.DataSource = Me.KiaDatosDataSet
        '
        'KiaDatosDataSet
        '
        Me.KiaDatosDataSet.DataSetName = "KiaDatosDataSet"
        Me.KiaDatosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
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
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
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
        'EmpleadosBindingNavigatorSaveItem
        '
        Me.EmpleadosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.EmpleadosBindingNavigatorSaveItem.Name = "EmpleadosBindingNavigatorSaveItem"
        Me.EmpleadosBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.EmpleadosBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'EmpleadosDataGridView
        '
        Me.EmpleadosDataGridView.AutoGenerateColumns = False
        Me.EmpleadosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EmpleadosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewImageColumn1})
        Me.EmpleadosDataGridView.DataSource = Me.EmpleadosBindingSource
        Me.EmpleadosDataGridView.Enabled = False
        Me.EmpleadosDataGridView.Location = New System.Drawing.Point(12, 543)
        Me.EmpleadosDataGridView.Name = "EmpleadosDataGridView"
        Me.EmpleadosDataGridView.Size = New System.Drawing.Size(704, 186)
        Me.EmpleadosDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Idempleado"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Idempleado"
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
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "fe_ingreso"
        Me.DataGridViewTextBoxColumn4.HeaderText = "fe_ingreso"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "area"
        Me.DataGridViewTextBoxColumn5.HeaderText = "area"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "puesto"
        Me.DataGridViewTextBoxColumn6.HeaderText = "puesto"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "tel_cel"
        Me.DataGridViewTextBoxColumn7.HeaderText = "tel_cel"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "pagadora"
        Me.DataGridViewTextBoxColumn8.HeaderText = "pagadora"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "ti_sangre"
        Me.DataGridViewTextBoxColumn9.HeaderText = "ti_sangre"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "nss"
        Me.DataGridViewTextBoxColumn10.HeaderText = "nss"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "nu_emergencia"
        Me.DataGridViewTextBoxColumn11.HeaderText = "nu_emergencia"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "cu_años"
        Me.DataGridViewTextBoxColumn12.HeaderText = "cu_años"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "uniforme"
        Me.DataGridViewTextBoxColumn13.HeaderText = "uniforme"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "vacaciones"
        Me.DataGridViewTextBoxColumn14.HeaderText = "vacaciones"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "vacaciones_fin"
        Me.DataGridViewTextBoxColumn15.HeaderText = "vacaciones_fin"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "comentario"
        Me.DataGridViewTextBoxColumn16.HeaderText = "comentario"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.DataPropertyName = "foto"
        Me.DataGridViewImageColumn1.HeaderText = "foto"
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        '
        'IdempleadoTextBox
        '
        Me.IdempleadoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "Idempleado", True))
        Me.IdempleadoTextBox.Location = New System.Drawing.Point(152, 24)
        Me.IdempleadoTextBox.Name = "IdempleadoTextBox"
        Me.IdempleadoTextBox.Size = New System.Drawing.Size(41, 20)
        Me.IdempleadoTextBox.TabIndex = 3
        '
        'NombresTextBox
        '
        Me.NombresTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "nombres", True))
        Me.NombresTextBox.Location = New System.Drawing.Point(152, 50)
        Me.NombresTextBox.Name = "NombresTextBox"
        Me.NombresTextBox.Size = New System.Drawing.Size(200, 20)
        Me.NombresTextBox.TabIndex = 5
        '
        'ApellidosTextBox
        '
        Me.ApellidosTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "apellidos", True))
        Me.ApellidosTextBox.Location = New System.Drawing.Point(152, 76)
        Me.ApellidosTextBox.Name = "ApellidosTextBox"
        Me.ApellidosTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ApellidosTextBox.TabIndex = 7
        '
        'Fe_ingresoDateTimePicker
        '
        Me.Fe_ingresoDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.EmpleadosBindingSource, "fe_ingreso", True))
        Me.Fe_ingresoDateTimePicker.Location = New System.Drawing.Point(152, 102)
        Me.Fe_ingresoDateTimePicker.Name = "Fe_ingresoDateTimePicker"
        Me.Fe_ingresoDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Fe_ingresoDateTimePicker.TabIndex = 9
        Me.Fe_ingresoDateTimePicker.Value = New Date(2016, 10, 13, 0, 0, 0, 0)
        '
        'AreaTextBox
        '
        Me.AreaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "area", True))
        Me.AreaTextBox.Location = New System.Drawing.Point(152, 128)
        Me.AreaTextBox.Name = "AreaTextBox"
        Me.AreaTextBox.Size = New System.Drawing.Size(200, 20)
        Me.AreaTextBox.TabIndex = 11
        '
        'PuestoTextBox
        '
        Me.PuestoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "puesto", True))
        Me.PuestoTextBox.Location = New System.Drawing.Point(152, 155)
        Me.PuestoTextBox.Name = "PuestoTextBox"
        Me.PuestoTextBox.Size = New System.Drawing.Size(200, 20)
        Me.PuestoTextBox.TabIndex = 13
        '
        'Tel_celTextBox
        '
        Me.Tel_celTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "tel_cel", True))
        Me.Tel_celTextBox.Location = New System.Drawing.Point(152, 181)
        Me.Tel_celTextBox.Name = "Tel_celTextBox"
        Me.Tel_celTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Tel_celTextBox.TabIndex = 15
        '
        'PagadoraComboBox
        '
        Me.PagadoraComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "pagadora", True))
        Me.PagadoraComboBox.FormattingEnabled = True
        Me.PagadoraComboBox.Location = New System.Drawing.Point(152, 207)
        Me.PagadoraComboBox.Name = "PagadoraComboBox"
        Me.PagadoraComboBox.Size = New System.Drawing.Size(200, 21)
        Me.PagadoraComboBox.TabIndex = 17
        '
        'Ti_sangreTextBox
        '
        Me.Ti_sangreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "ti_sangre", True))
        Me.Ti_sangreTextBox.Location = New System.Drawing.Point(152, 234)
        Me.Ti_sangreTextBox.Name = "Ti_sangreTextBox"
        Me.Ti_sangreTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Ti_sangreTextBox.TabIndex = 19
        '
        'NssTextBox
        '
        Me.NssTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "nss", True))
        Me.NssTextBox.Location = New System.Drawing.Point(152, 260)
        Me.NssTextBox.Name = "NssTextBox"
        Me.NssTextBox.Size = New System.Drawing.Size(200, 20)
        Me.NssTextBox.TabIndex = 21
        '
        'Nu_emergenciaTextBox
        '
        Me.Nu_emergenciaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "nu_emergencia", True))
        Me.Nu_emergenciaTextBox.Location = New System.Drawing.Point(152, 286)
        Me.Nu_emergenciaTextBox.Name = "Nu_emergenciaTextBox"
        Me.Nu_emergenciaTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Nu_emergenciaTextBox.TabIndex = 23
        '
        'VacacionesDateTimePicker
        '
        Me.VacacionesDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.EmpleadosBindingSource, "vacaciones", True))
        Me.VacacionesDateTimePicker.Location = New System.Drawing.Point(152, 402)
        Me.VacacionesDateTimePicker.Name = "VacacionesDateTimePicker"
        Me.VacacionesDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.VacacionesDateTimePicker.TabIndex = 29
        '
        'Vacaciones_finDateTimePicker
        '
        Me.Vacaciones_finDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.EmpleadosBindingSource, "vacaciones_fin", True))
        Me.Vacaciones_finDateTimePicker.Location = New System.Drawing.Point(152, 428)
        Me.Vacaciones_finDateTimePicker.Name = "Vacaciones_finDateTimePicker"
        Me.Vacaciones_finDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Vacaciones_finDateTimePicker.TabIndex = 31
        '
        'ComentarioTextBox
        '
        Me.ComentarioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "comentario", True))
        Me.ComentarioTextBox.Location = New System.Drawing.Point(152, 454)
        Me.ComentarioTextBox.Multiline = True
        Me.ComentarioTextBox.Name = "ComentarioTextBox"
        Me.ComentarioTextBox.Size = New System.Drawing.Size(200, 71)
        Me.ComentarioTextBox.TabIndex = 33
        '
        'FotoPictureBox
        '
        Me.FotoPictureBox.BackColor = System.Drawing.Color.White
        Me.FotoPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.FotoPictureBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.EmpleadosBindingSource, "foto", True))
        Me.FotoPictureBox.Location = New System.Drawing.Point(465, 50)
        Me.FotoPictureBox.Name = "FotoPictureBox"
        Me.FotoPictureBox.Size = New System.Drawing.Size(146, 115)
        Me.FotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.FotoPictureBox.TabIndex = 35
        Me.FotoPictureBox.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(413, 267)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(102, 39)
        Me.Button1.TabIndex = 36
        Me.Button1.Text = "NUEVO"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(412, 326)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(103, 39)
        Me.Button2.TabIndex = 37
        Me.Button2.Text = "ELIMINAR"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.White
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(555, 267)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(102, 39)
        Me.Button3.TabIndex = 38
        Me.Button3.Text = "GUARDAR"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.White
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(555, 326)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(103, 39)
        Me.Button4.TabIndex = 39
        Me.Button4.Text = "BUSCAR"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.White
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(489, 171)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(102, 39)
        Me.Button5.TabIndex = 40
        Me.Button5.Text = "EXAMINAR"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.White
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(612, 486)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(104, 39)
        Me.Button6.TabIndex = 41
        Me.Button6.Text = "REFRESCAR"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.White
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Location = New System.Drawing.Point(486, 486)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(105, 39)
        Me.Button7.TabIndex = 42
        Me.Button7.Text = "REPORTE"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'EmpleadosTableAdapter
        '
        Me.EmpleadosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.becariosTableAdapter = Nothing
        Me.TableAdapterManager.empleadosTableAdapter = Me.EmpleadosTableAdapter
        Me.TableAdapterManager.loginTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = PACIFIC_DATA.KiaDatosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ComentarioTextBox1
        '
        Me.ComentarioTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "comentario", True))
        Me.ComentarioTextBox1.Location = New System.Drawing.Point(152, 337)
        Me.ComentarioTextBox1.Multiline = True
        Me.ComentarioTextBox1.Name = "ComentarioTextBox1"
        Me.ComentarioTextBox1.Size = New System.Drawing.Size(200, 59)
        Me.ComentarioTextBox1.TabIndex = 44
        '
        'Cu_añosDateTimePicker
        '
        Me.Cu_añosDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.EmpleadosBindingSource, "cu_años", True))
        Me.Cu_añosDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cu_añosDateTimePicker.Location = New System.Drawing.Point(152, 312)
        Me.Cu_añosDateTimePicker.Name = "Cu_añosDateTimePicker"
        Me.Cu_añosDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Cu_añosDateTimePicker.TabIndex = 45
        '
        'EMPLEADOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.DarkRed
        Me.ClientSize = New System.Drawing.Size(736, 741)
        Me.Controls.Add(Cu_añosLabel)
        Me.Controls.Add(Me.Cu_añosDateTimePicker)
        Me.Controls.Add(ComentarioLabel1)
        Me.Controls.Add(Me.ComentarioTextBox1)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.IdempleadoLabel)
        Me.Controls.Add(Me.IdempleadoTextBox)
        Me.Controls.Add(Me.NombresLabel)
        Me.Controls.Add(Me.NombresTextBox)
        Me.Controls.Add(Me.ApellidosLabel)
        Me.Controls.Add(Me.ApellidosTextBox)
        Me.Controls.Add(Me.Fe_ingresoLabel)
        Me.Controls.Add(Me.Fe_ingresoDateTimePicker)
        Me.Controls.Add(Me.AreaLabel)
        Me.Controls.Add(Me.AreaTextBox)
        Me.Controls.Add(Me.PuestoLabel)
        Me.Controls.Add(Me.PuestoTextBox)
        Me.Controls.Add(Me.Tel_celLabel)
        Me.Controls.Add(Me.Tel_celTextBox)
        Me.Controls.Add(Me.PagadoraLabel)
        Me.Controls.Add(Me.PagadoraComboBox)
        Me.Controls.Add(Me.Ti_sangreLabel)
        Me.Controls.Add(Me.Ti_sangreTextBox)
        Me.Controls.Add(Me.NssLabel)
        Me.Controls.Add(Me.NssTextBox)
        Me.Controls.Add(Me.Nu_emergenciaLabel)
        Me.Controls.Add(Me.Nu_emergenciaTextBox)
        Me.Controls.Add(Me.VacacionesLabel)
        Me.Controls.Add(Me.VacacionesDateTimePicker)
        Me.Controls.Add(Me.Vacaciones_finLabel)
        Me.Controls.Add(Me.Vacaciones_finDateTimePicker)
        Me.Controls.Add(Me.ComentarioLabel)
        Me.Controls.Add(Me.ComentarioTextBox)
        Me.Controls.Add(Me.FotoLabel)
        Me.Controls.Add(Me.FotoPictureBox)
        Me.Controls.Add(Me.EmpleadosDataGridView)
        Me.Controls.Add(Me.EmpleadosBindingNavigator)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "EMPLEADOS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EMPLEADOS"
        CType(Me.EmpleadosBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EmpleadosBindingNavigator.ResumeLayout(False)
        Me.EmpleadosBindingNavigator.PerformLayout()
        CType(Me.EmpleadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KiaDatosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpleadosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FotoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents KiaDatosDataSet As KiaDatosDataSet
    Friend WithEvents EmpleadosBindingSource As BindingSource
    Friend WithEvents EmpleadosTableAdapter As KiaDatosDataSetTableAdapters.empleadosTableAdapter
    Friend WithEvents TableAdapterManager As KiaDatosDataSetTableAdapters.TableAdapterManager
    Friend WithEvents EmpleadosBindingNavigator As BindingNavigator
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
    Friend WithEvents EmpleadosBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents EmpleadosDataGridView As DataGridView
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
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents IdempleadoTextBox As TextBox
    Friend WithEvents NombresTextBox As TextBox
    Friend WithEvents ApellidosTextBox As TextBox
    Friend WithEvents Fe_ingresoDateTimePicker As DateTimePicker
    Friend WithEvents AreaTextBox As TextBox
    Friend WithEvents PuestoTextBox As TextBox
    Friend WithEvents Tel_celTextBox As TextBox
    Friend WithEvents PagadoraComboBox As ComboBox
    Friend WithEvents Ti_sangreTextBox As TextBox
    Friend WithEvents NssTextBox As TextBox
    Friend WithEvents Nu_emergenciaTextBox As TextBox
    Friend WithEvents VacacionesDateTimePicker As DateTimePicker
    Friend WithEvents Vacaciones_finDateTimePicker As DateTimePicker
    Friend WithEvents ComentarioTextBox As TextBox
    Friend WithEvents FotoPictureBox As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents IdempleadoLabel As Label
    Friend WithEvents NombresLabel As Label
    Friend WithEvents ApellidosLabel As Label
    Friend WithEvents Fe_ingresoLabel As Label
    Friend WithEvents AreaLabel As Label
    Friend WithEvents PuestoLabel As Label
    Friend WithEvents Tel_celLabel As Label
    Friend WithEvents PagadoraLabel As Label
    Friend WithEvents Ti_sangreLabel As Label
    Friend WithEvents NssLabel As Label
    Friend WithEvents Nu_emergenciaLabel As Label
    Friend WithEvents VacacionesLabel As Label
    Friend WithEvents Vacaciones_finLabel As Label
    Friend WithEvents ComentarioLabel As Label
    Friend WithEvents FotoLabel As Label
    Friend WithEvents ComentarioTextBox1 As TextBox
    Friend WithEvents Cu_añosDateTimePicker As DateTimePicker
End Class
