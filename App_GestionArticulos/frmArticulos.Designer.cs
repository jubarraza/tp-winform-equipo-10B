namespace App_GestionArticulos
{
    partial class frmArticulos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmArticulos));
            this.dataGridArticulo = new System.Windows.Forms.DataGridView();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.buttonModificar = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonInformación = new System.Windows.Forms.Button();
            this.textBoxBusqueda = new System.Windows.Forms.TextBox();
            this.lbl_BusquedaNombre = new System.Windows.Forms.Label();
            this.buttonFiltroAvanz = new System.Windows.Forms.Button();
            this.lbl_Titulo_Articulos = new System.Windows.Forms.Label();
            this.barraMenu = new System.Windows.Forms.MenuStrip();
            this.tsm_articulos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_informacionDetalladaArticulo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsm_agregarArticulo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_modificarArticulo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_eliminarArticulo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_marcas = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_verMarcas = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_agregarMarca = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_categorias = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_verCategorias = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_agregarCategorias = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_opciones = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_sobreGestorDeProductos = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_separador = new System.Windows.Forms.ToolStripSeparator();
            this.tsm_salir = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonBorrarFiltros = new System.Windows.Forms.Button();
            this.gb_Busqueda = new System.Windows.Forms.GroupBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridArticulo)).BeginInit();
            this.barraMenu.SuspendLayout();
            this.gb_Busqueda.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridArticulo
            // 
            this.dataGridArticulo.AllowUserToAddRows = false;
            this.dataGridArticulo.AllowUserToDeleteRows = false;
            this.dataGridArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridArticulo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridArticulo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(105)))), ((int)(((byte)(137)))));
            this.dataGridArticulo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridArticulo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridArticulo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridArticulo.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridArticulo.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridArticulo.Location = new System.Drawing.Point(41, 141);
            this.dataGridArticulo.MultiSelect = false;
            this.dataGridArticulo.Name = "dataGridArticulo";
            this.dataGridArticulo.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridArticulo.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridArticulo.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.dataGridArticulo.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridArticulo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridArticulo.Size = new System.Drawing.Size(745, 295);
            this.dataGridArticulo.TabIndex = 0;
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(225)))), ((int)(((byte)(217)))));
            this.buttonAgregar.FlatAppearance.BorderColor = System.Drawing.Color.LightBlue;
            this.buttonAgregar.FlatAppearance.BorderSize = 2;
            this.buttonAgregar.FlatAppearance.CheckedBackColor = System.Drawing.Color.AliceBlue;
            this.buttonAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.AliceBlue;
            this.buttonAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue;
            this.buttonAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAgregar.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAgregar.Location = new System.Drawing.Point(40, 102);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(63, 26);
            this.buttonAgregar.TabIndex = 1;
            this.buttonAgregar.Text = "Agregar";
            this.buttonAgregar.UseVisualStyleBackColor = false;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // buttonModificar
            // 
            this.buttonModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(225)))), ((int)(((byte)(217)))));
            this.buttonModificar.FlatAppearance.BorderColor = System.Drawing.Color.LightBlue;
            this.buttonModificar.FlatAppearance.BorderSize = 2;
            this.buttonModificar.FlatAppearance.CheckedBackColor = System.Drawing.Color.AliceBlue;
            this.buttonModificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.AliceBlue;
            this.buttonModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue;
            this.buttonModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonModificar.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModificar.Location = new System.Drawing.Point(109, 102);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(73, 26);
            this.buttonModificar.TabIndex = 2;
            this.buttonModificar.Text = "Modificar";
            this.buttonModificar.UseVisualStyleBackColor = false;
            this.buttonModificar.Click += new System.EventHandler(this.buttonModificar_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(225)))), ((int)(((byte)(217)))));
            this.buttonEliminar.FlatAppearance.BorderColor = System.Drawing.Color.LightBlue;
            this.buttonEliminar.FlatAppearance.BorderSize = 2;
            this.buttonEliminar.FlatAppearance.CheckedBackColor = System.Drawing.Color.AliceBlue;
            this.buttonEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.AliceBlue;
            this.buttonEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue;
            this.buttonEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEliminar.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminar.Location = new System.Drawing.Point(188, 102);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(64, 26);
            this.buttonEliminar.TabIndex = 3;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = false;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonInformación
            // 
            this.buttonInformación.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonInformación.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(225)))), ((int)(((byte)(217)))));
            this.buttonInformación.FlatAppearance.BorderColor = System.Drawing.Color.LightBlue;
            this.buttonInformación.FlatAppearance.BorderSize = 2;
            this.buttonInformación.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonInformación.FlatAppearance.MouseDownBackColor = System.Drawing.Color.AliceBlue;
            this.buttonInformación.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue;
            this.buttonInformación.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInformación.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInformación.Location = new System.Drawing.Point(639, 102);
            this.buttonInformación.Name = "buttonInformación";
            this.buttonInformación.Size = new System.Drawing.Size(147, 26);
            this.buttonInformación.TabIndex = 4;
            this.buttonInformación.Text = "Información detallada";
            this.buttonInformación.UseVisualStyleBackColor = false;
            this.buttonInformación.Click += new System.EventHandler(this.buttonInformación_Click);
            // 
            // textBoxBusqueda
            // 
            this.textBoxBusqueda.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBoxBusqueda.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxBusqueda.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBusqueda.Location = new System.Drawing.Point(162, 17);
            this.textBoxBusqueda.MaxLength = 50;
            this.textBoxBusqueda.Name = "textBoxBusqueda";
            this.textBoxBusqueda.Size = new System.Drawing.Size(136, 22);
            this.textBoxBusqueda.TabIndex = 0;
            this.textBoxBusqueda.TextChanged += new System.EventHandler(this.textBoxBusqueda_TextChanged_1);
            // 
            // lbl_BusquedaNombre
            // 
            this.lbl_BusquedaNombre.AutoSize = true;
            this.lbl_BusquedaNombre.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BusquedaNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.lbl_BusquedaNombre.Location = new System.Drawing.Point(6, 21);
            this.lbl_BusquedaNombre.Name = "lbl_BusquedaNombre";
            this.lbl_BusquedaNombre.Size = new System.Drawing.Size(154, 13);
            this.lbl_BusquedaNombre.TabIndex = 6;
            this.lbl_BusquedaNombre.Text = "Busqueda por Nombre:";
            // 
            // buttonFiltroAvanz
            // 
            this.buttonFiltroAvanz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFiltroAvanz.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFiltroAvanz.Location = new System.Drawing.Point(650, 472);
            this.buttonFiltroAvanz.Name = "buttonFiltroAvanz";
            this.buttonFiltroAvanz.Size = new System.Drawing.Size(136, 25);
            this.buttonFiltroAvanz.TabIndex = 6;
            this.buttonFiltroAvanz.Text = "Filtro avanzado";
            this.buttonFiltroAvanz.UseVisualStyleBackColor = true;
            this.buttonFiltroAvanz.Click += new System.EventHandler(this.buttonFiltroAvanz_Click);
            // 
            // lbl_Titulo_Articulos
            // 
            this.lbl_Titulo_Articulos.AutoSize = true;
            this.lbl_Titulo_Articulos.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo_Articulos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(205)))), ((int)(((byte)(159)))));
            this.lbl_Titulo_Articulos.Location = new System.Drawing.Point(37, 40);
            this.lbl_Titulo_Articulos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Titulo_Articulos.Name = "lbl_Titulo_Articulos";
            this.lbl_Titulo_Articulos.Size = new System.Drawing.Size(147, 23);
            this.lbl_Titulo_Articulos.TabIndex = 8;
            this.lbl_Titulo_Articulos.Text = "INVENTARIO";
            // 
            // barraMenu
            // 
            this.barraMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(225)))), ((int)(((byte)(217)))));
            this.barraMenu.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barraMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.barraMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_articulos,
            this.tsm_marcas,
            this.tsm_categorias,
            this.tsm_opciones});
            this.barraMenu.Location = new System.Drawing.Point(0, 0);
            this.barraMenu.Name = "barraMenu";
            this.barraMenu.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.barraMenu.Size = new System.Drawing.Size(825, 24);
            this.barraMenu.TabIndex = 8;
            this.barraMenu.Text = "Menu";
            // 
            // tsm_articulos
            // 
            this.tsm_articulos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsm_articulos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_informacionDetalladaArticulo,
            this.toolStripSeparator1,
            this.tsm_agregarArticulo,
            this.tsm_modificarArticulo,
            this.tsm_eliminarArticulo});
            this.tsm_articulos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tsm_articulos.Name = "tsm_articulos";
            this.tsm_articulos.Size = new System.Drawing.Size(71, 20);
            this.tsm_articulos.Text = "A&rticulos";
            // 
            // tsm_informacionDetalladaArticulo
            // 
            this.tsm_informacionDetalladaArticulo.Name = "tsm_informacionDetalladaArticulo";
            this.tsm_informacionDetalladaArticulo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Space)));
            this.tsm_informacionDetalladaArticulo.Size = new System.Drawing.Size(270, 22);
            this.tsm_informacionDetalladaArticulo.Text = "&Informacion detallada";
            this.tsm_informacionDetalladaArticulo.Click += new System.EventHandler(this.tsm_informacionDetalladaArticulo_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(267, 6);
            // 
            // tsm_agregarArticulo
            // 
            this.tsm_agregarArticulo.Name = "tsm_agregarArticulo";
            this.tsm_agregarArticulo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.tsm_agregarArticulo.Size = new System.Drawing.Size(270, 22);
            this.tsm_agregarArticulo.Text = "A&gregar";
            this.tsm_agregarArticulo.Click += new System.EventHandler(this.tsm_agregarArticulo_Click);
            // 
            // tsm_modificarArticulo
            // 
            this.tsm_modificarArticulo.Name = "tsm_modificarArticulo";
            this.tsm_modificarArticulo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.tsm_modificarArticulo.Size = new System.Drawing.Size(270, 22);
            this.tsm_modificarArticulo.Text = "&Modificar";
            this.tsm_modificarArticulo.Click += new System.EventHandler(this.tsm_modificarArticulo_Click);
            // 
            // tsm_eliminarArticulo
            // 
            this.tsm_eliminarArticulo.Name = "tsm_eliminarArticulo";
            this.tsm_eliminarArticulo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Delete)));
            this.tsm_eliminarArticulo.Size = new System.Drawing.Size(270, 22);
            this.tsm_eliminarArticulo.Text = "&Eliminar";
            this.tsm_eliminarArticulo.Click += new System.EventHandler(this.tsm_eliminarArticulo_Click);
            // 
            // tsm_marcas
            // 
            this.tsm_marcas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_verMarcas,
            this.tsm_agregarMarca});
            this.tsm_marcas.Name = "tsm_marcas";
            this.tsm_marcas.Size = new System.Drawing.Size(61, 20);
            this.tsm_marcas.Text = "Marca&s";
            // 
            // tsm_verMarcas
            // 
            this.tsm_verMarcas.Name = "tsm_verMarcas";
            this.tsm_verMarcas.Size = new System.Drawing.Size(207, 22);
            this.tsm_verMarcas.Text = "&Ver Marcas";
            this.tsm_verMarcas.Click += new System.EventHandler(this.tsm_verMarcas_Click);
            // 
            // tsm_agregarMarca
            // 
            this.tsm_agregarMarca.Name = "tsm_agregarMarca";
            this.tsm_agregarMarca.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.tsm_agregarMarca.Size = new System.Drawing.Size(207, 22);
            this.tsm_agregarMarca.Text = "Agr&egar Marca";
            this.tsm_agregarMarca.Click += new System.EventHandler(this.tsm_agregarMarca_Click);
            // 
            // tsm_categorias
            // 
            this.tsm_categorias.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_verCategorias,
            this.tsm_agregarCategorias});
            this.tsm_categorias.Name = "tsm_categorias";
            this.tsm_categorias.Size = new System.Drawing.Size(82, 20);
            this.tsm_categorias.Text = "&Categorias";
            // 
            // tsm_verCategorias
            // 
            this.tsm_verCategorias.Name = "tsm_verCategorias";
            this.tsm_verCategorias.Size = new System.Drawing.Size(231, 22);
            this.tsm_verCategorias.Text = "&Ver Categorias";
            this.tsm_verCategorias.Click += new System.EventHandler(this.tsm_verCategorias_Click);
            // 
            // tsm_agregarCategorias
            // 
            this.tsm_agregarCategorias.Name = "tsm_agregarCategorias";
            this.tsm_agregarCategorias.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.tsm_agregarCategorias.Size = new System.Drawing.Size(231, 22);
            this.tsm_agregarCategorias.Text = "Agregar Ca&tegorias";
            this.tsm_agregarCategorias.Click += new System.EventHandler(this.tsm_agregarCategorias_Click);
            // 
            // tsm_opciones
            // 
            this.tsm_opciones.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_sobreGestorDeProductos,
            this.ts_separador,
            this.tsm_salir});
            this.tsm_opciones.Name = "tsm_opciones";
            this.tsm_opciones.Size = new System.Drawing.Size(74, 20);
            this.tsm_opciones.Text = "&Opciones";
            // 
            // tsm_sobreGestorDeProductos
            // 
            this.tsm_sobreGestorDeProductos.Name = "tsm_sobreGestorDeProductos";
            this.tsm_sobreGestorDeProductos.Size = new System.Drawing.Size(233, 22);
            this.tsm_sobreGestorDeProductos.Text = "Sobre &Gestor de Productos";
            this.tsm_sobreGestorDeProductos.Click += new System.EventHandler(this.tsm_sobreGestorDeProductos_Click);
            // 
            // ts_separador
            // 
            this.ts_separador.Name = "ts_separador";
            this.ts_separador.Size = new System.Drawing.Size(230, 6);
            // 
            // tsm_salir
            // 
            this.tsm_salir.Name = "tsm_salir";
            this.tsm_salir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.tsm_salir.Size = new System.Drawing.Size(233, 22);
            this.tsm_salir.Text = "&Salir";
            this.tsm_salir.Click += new System.EventHandler(this.tsm_salir_Click);
            // 
            // buttonBorrarFiltros
            // 
            this.buttonBorrarFiltros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBorrarFiltros.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBorrarFiltros.Location = new System.Drawing.Point(650, 503);
            this.buttonBorrarFiltros.Name = "buttonBorrarFiltros";
            this.buttonBorrarFiltros.Size = new System.Drawing.Size(136, 24);
            this.buttonBorrarFiltros.TabIndex = 7;
            this.buttonBorrarFiltros.Text = "Borrar filtros";
            this.buttonBorrarFiltros.UseVisualStyleBackColor = true;
            this.buttonBorrarFiltros.Click += new System.EventHandler(this.buttonBorrarFiltros_Click);
            // 
            // gb_Busqueda
            // 
            this.gb_Busqueda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gb_Busqueda.Controls.Add(this.lbl_BusquedaNombre);
            this.gb_Busqueda.Controls.Add(this.textBoxBusqueda);
            this.gb_Busqueda.Location = new System.Drawing.Point(41, 472);
            this.gb_Busqueda.Name = "gb_Busqueda";
            this.gb_Busqueda.Size = new System.Drawing.Size(304, 53);
            this.gb_Busqueda.TabIndex = 5;
            this.gb_Busqueda.TabStop = false;
            // 
            // frmArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(105)))), ((int)(((byte)(137)))));
            this.ClientSize = new System.Drawing.Size(825, 595);
            this.Controls.Add(this.gb_Busqueda);
            this.Controls.Add(this.buttonBorrarFiltros);
            this.Controls.Add(this.lbl_Titulo_Articulos);
            this.Controls.Add(this.buttonFiltroAvanz);
            this.Controls.Add(this.buttonInformación);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonModificar);
            this.Controls.Add(this.buttonAgregar);
            this.Controls.Add(this.dataGridArticulo);
            this.Controls.Add(this.barraMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.barraMenu;
            this.MaximizeBox = false;
            this.Name = "frmArticulos";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestor de Productos";
            this.Load += new System.EventHandler(this.frmArticulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridArticulo)).EndInit();
            this.barraMenu.ResumeLayout(false);
            this.barraMenu.PerformLayout();
            this.gb_Busqueda.ResumeLayout(false);
            this.gb_Busqueda.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridArticulo;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.Button buttonModificar;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonInformación;
        private System.Windows.Forms.TextBox textBoxBusqueda;
        private System.Windows.Forms.Label lbl_BusquedaNombre;
        private System.Windows.Forms.Button buttonFiltroAvanz;
        private System.Windows.Forms.Label lbl_Titulo_Articulos;
        private System.Windows.Forms.MenuStrip barraMenu;
        private System.Windows.Forms.ToolStripMenuItem tsm_articulos;
        private System.Windows.Forms.ToolStripMenuItem tsm_informacionDetalladaArticulo;
        private System.Windows.Forms.ToolStripMenuItem tsm_agregarArticulo;
        private System.Windows.Forms.ToolStripMenuItem tsm_modificarArticulo;
        private System.Windows.Forms.ToolStripMenuItem tsm_eliminarArticulo;
        private System.Windows.Forms.ToolStripMenuItem tsm_marcas;
        private System.Windows.Forms.ToolStripMenuItem tsm_verMarcas;
        private System.Windows.Forms.ToolStripMenuItem tsm_agregarMarca;
        private System.Windows.Forms.ToolStripMenuItem tsm_categorias;
        private System.Windows.Forms.ToolStripMenuItem tsm_verCategorias;
        private System.Windows.Forms.ToolStripMenuItem tsm_agregarCategorias;
        private System.Windows.Forms.ToolStripMenuItem tsm_opciones;
        private System.Windows.Forms.ToolStripMenuItem tsm_sobreGestorDeProductos;
        private System.Windows.Forms.ToolStripSeparator ts_separador;
        private System.Windows.Forms.ToolStripMenuItem tsm_salir;
        private System.Windows.Forms.Button buttonBorrarFiltros;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.GroupBox gb_Busqueda;
        private System.Windows.Forms.ToolTip toolTip;
    }
}