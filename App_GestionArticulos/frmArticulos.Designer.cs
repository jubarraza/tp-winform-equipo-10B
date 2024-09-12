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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridArticulo)).BeginInit();
            this.barraMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridArticulo
            // 
            this.dataGridArticulo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridArticulo.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridArticulo.Location = new System.Drawing.Point(52, 103);
            this.dataGridArticulo.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridArticulo.MultiSelect = false;
            this.dataGridArticulo.Name = "dataGridArticulo";
            this.dataGridArticulo.RowHeadersWidth = 51;
            this.dataGridArticulo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridArticulo.Size = new System.Drawing.Size(716, 305);
            this.dataGridArticulo.TabIndex = 0;
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.Location = new System.Drawing.Point(807, 232);
            this.buttonAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(192, 39);
            this.buttonAgregar.TabIndex = 1;
            this.buttonAgregar.Text = "Agregar";
            this.buttonAgregar.UseVisualStyleBackColor = true;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // buttonModificar
            // 
            this.buttonModificar.Location = new System.Drawing.Point(807, 279);
            this.buttonModificar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(192, 39);
            this.buttonModificar.TabIndex = 2;
            this.buttonModificar.Text = "Modificar";
            this.buttonModificar.UseVisualStyleBackColor = true;
            this.buttonModificar.Click += new System.EventHandler(this.buttonModificar_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(807, 326);
            this.buttonEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(192, 39);
            this.buttonEliminar.TabIndex = 3;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonInformación
            // 
            this.buttonInformación.Location = new System.Drawing.Point(807, 124);
            this.buttonInformación.Margin = new System.Windows.Forms.Padding(4);
            this.buttonInformación.Name = "buttonInformación";
            this.buttonInformación.Size = new System.Drawing.Size(192, 39);
            this.buttonInformación.TabIndex = 4;
            this.buttonInformación.Text = "Información detallada";
            this.buttonInformación.UseVisualStyleBackColor = true;
            this.buttonInformación.Click += new System.EventHandler(this.buttonInformación_Click);
            // 
            // textBoxBusqueda
            // 
            this.textBoxBusqueda.Location = new System.Drawing.Point(274, 433);
            this.textBoxBusqueda.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxBusqueda.Name = "textBoxBusqueda";
            this.textBoxBusqueda.Size = new System.Drawing.Size(180, 22);
            this.textBoxBusqueda.TabIndex = 5;
            this.textBoxBusqueda.TextChanged += new System.EventHandler(this.textBoxBusqueda_TextChanged_1);
            // 
            // lbl_BusquedaNombre
            // 
            this.lbl_BusquedaNombre.AutoSize = true;
            this.lbl_BusquedaNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BusquedaNombre.Location = new System.Drawing.Point(60, 433);
            this.lbl_BusquedaNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_BusquedaNombre.Name = "lbl_BusquedaNombre";
            this.lbl_BusquedaNombre.Size = new System.Drawing.Size(182, 20);
            this.lbl_BusquedaNombre.TabIndex = 6;
            this.lbl_BusquedaNombre.Text = "Busqueda por Nombre:";
            // 
            // buttonFiltroAvanz
            // 
            this.buttonFiltroAvanz.Location = new System.Drawing.Point(506, 431);
            this.buttonFiltroAvanz.Margin = new System.Windows.Forms.Padding(4);
            this.buttonFiltroAvanz.Name = "buttonFiltroAvanz";
            this.buttonFiltroAvanz.Size = new System.Drawing.Size(129, 31);
            this.buttonFiltroAvanz.TabIndex = 7;
            this.buttonFiltroAvanz.Text = "Filtros avanzados";
            this.buttonFiltroAvanz.UseVisualStyleBackColor = true;
            this.buttonFiltroAvanz.Click += new System.EventHandler(this.buttonFiltroAvanz_Click);
            // 
            // lbl_Titulo_Articulos
            // 
            this.lbl_Titulo_Articulos.AutoSize = true;
            this.lbl_Titulo_Articulos.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo_Articulos.Location = new System.Drawing.Point(293, 56);
            this.lbl_Titulo_Articulos.Name = "lbl_Titulo_Articulos";
            this.lbl_Titulo_Articulos.Size = new System.Drawing.Size(228, 31);
            this.lbl_Titulo_Articulos.TabIndex = 8;
            this.lbl_Titulo_Articulos.Text = "Articulos disponibles";
            // 
            // barraMenu
            // 
            this.barraMenu.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.barraMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.barraMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_articulos,
            this.tsm_marcas,
            this.tsm_categorias,
            this.tsm_opciones});
            this.barraMenu.Location = new System.Drawing.Point(0, 0);
            this.barraMenu.Name = "barraMenu";
            this.barraMenu.Size = new System.Drawing.Size(1054, 28);
            this.barraMenu.TabIndex = 9;
            this.barraMenu.Text = "Menu";
            // 
            // tsm_articulos
            // 
            this.tsm_articulos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_informacionDetalladaArticulo,
            this.tsm_agregarArticulo,
            this.tsm_modificarArticulo,
            this.tsm_eliminarArticulo});
            this.tsm_articulos.Name = "tsm_articulos";
            this.tsm_articulos.Size = new System.Drawing.Size(81, 24);
            this.tsm_articulos.Text = "Articulos";
            // 
            // tsm_informacionDetalladaArticulo
            // 
            this.tsm_informacionDetalladaArticulo.Name = "tsm_informacionDetalladaArticulo";
            this.tsm_informacionDetalladaArticulo.Size = new System.Drawing.Size(239, 26);
            this.tsm_informacionDetalladaArticulo.Text = "Informacion detallada";
            this.tsm_informacionDetalladaArticulo.Click += new System.EventHandler(this.tsm_informacionDetalladaArticulo_Click);
            // 
            // tsm_agregarArticulo
            // 
            this.tsm_agregarArticulo.Name = "tsm_agregarArticulo";
            this.tsm_agregarArticulo.Size = new System.Drawing.Size(239, 26);
            this.tsm_agregarArticulo.Text = "Agregar";
            this.tsm_agregarArticulo.Click += new System.EventHandler(this.tsm_agregarArticulo_Click);
            // 
            // tsm_modificarArticulo
            // 
            this.tsm_modificarArticulo.Name = "tsm_modificarArticulo";
            this.tsm_modificarArticulo.Size = new System.Drawing.Size(239, 26);
            this.tsm_modificarArticulo.Text = "Modificar";
            this.tsm_modificarArticulo.Click += new System.EventHandler(this.tsm_modificarArticulo_Click);
            // 
            // tsm_eliminarArticulo
            // 
            this.tsm_eliminarArticulo.Name = "tsm_eliminarArticulo";
            this.tsm_eliminarArticulo.Size = new System.Drawing.Size(239, 26);
            this.tsm_eliminarArticulo.Text = "Eliminar";
            this.tsm_eliminarArticulo.Click += new System.EventHandler(this.tsm_eliminarArticulo_Click);
            // 
            // tsm_marcas
            // 
            this.tsm_marcas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_verMarcas,
            this.tsm_agregarMarca});
            this.tsm_marcas.Name = "tsm_marcas";
            this.tsm_marcas.Size = new System.Drawing.Size(70, 24);
            this.tsm_marcas.Text = "Marcas";
            // 
            // tsm_verMarcas
            // 
            this.tsm_verMarcas.Name = "tsm_verMarcas";
            this.tsm_verMarcas.Size = new System.Drawing.Size(191, 26);
            this.tsm_verMarcas.Text = "Ver Marcas";
            this.tsm_verMarcas.Click += new System.EventHandler(this.tsm_verMarcas_Click);
            // 
            // tsm_agregarMarca
            // 
            this.tsm_agregarMarca.Name = "tsm_agregarMarca";
            this.tsm_agregarMarca.Size = new System.Drawing.Size(191, 26);
            this.tsm_agregarMarca.Text = "Agregar Marca";
            this.tsm_agregarMarca.Click += new System.EventHandler(this.tsm_agregarMarca_Click);
            // 
            // tsm_categorias
            // 
            this.tsm_categorias.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_verCategorias,
            this.tsm_agregarCategorias});
            this.tsm_categorias.Name = "tsm_categorias";
            this.tsm_categorias.Size = new System.Drawing.Size(94, 24);
            this.tsm_categorias.Text = "Categorias";
            // 
            // tsm_verCategorias
            // 
            this.tsm_verCategorias.Name = "tsm_verCategorias";
            this.tsm_verCategorias.Size = new System.Drawing.Size(221, 26);
            this.tsm_verCategorias.Text = "Ver Categorias";
            this.tsm_verCategorias.Click += new System.EventHandler(this.tsm_verCategorias_Click);
            // 
            // tsm_agregarCategorias
            // 
            this.tsm_agregarCategorias.Name = "tsm_agregarCategorias";
            this.tsm_agregarCategorias.Size = new System.Drawing.Size(221, 26);
            this.tsm_agregarCategorias.Text = "Agregar Categorias";
            this.tsm_agregarCategorias.Click += new System.EventHandler(this.tsm_agregarCategorias_Click);
            // 
            // tsm_opciones
            // 
            this.tsm_opciones.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_sobreGestorDeProductos,
            this.ts_separador,
            this.tsm_salir});
            this.tsm_opciones.Name = "tsm_opciones";
            this.tsm_opciones.Size = new System.Drawing.Size(85, 24);
            this.tsm_opciones.Text = "Opciones";
            // 
            // tsm_sobreGestorDeProductos
            // 
            this.tsm_sobreGestorDeProductos.Name = "tsm_sobreGestorDeProductos";
            this.tsm_sobreGestorDeProductos.Size = new System.Drawing.Size(269, 26);
            this.tsm_sobreGestorDeProductos.Text = "Sobre Gestor de Productos";
            this.tsm_sobreGestorDeProductos.Click += new System.EventHandler(this.tsm_sobreGestorDeProductos_Click);
            // 
            // ts_separador
            // 
            this.ts_separador.Name = "ts_separador";
            this.ts_separador.Size = new System.Drawing.Size(266, 6);
            // 
            // tsm_salir
            // 
            this.tsm_salir.Name = "tsm_salir";
            this.tsm_salir.Size = new System.Drawing.Size(269, 26);
            this.tsm_salir.Text = "Salir";
            this.tsm_salir.Click += new System.EventHandler(this.tsm_salir_Click);
            // 
            // buttonBorrarFiltros
            // 
            this.buttonBorrarFiltros.Location = new System.Drawing.Point(643, 431);
            this.buttonBorrarFiltros.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBorrarFiltros.Name = "buttonBorrarFiltros";
            this.buttonBorrarFiltros.Size = new System.Drawing.Size(125, 31);
            this.buttonBorrarFiltros.TabIndex = 10;
            this.buttonBorrarFiltros.Text = "Borrar filtros";
            this.buttonBorrarFiltros.UseVisualStyleBackColor = true;
            this.buttonBorrarFiltros.Click += new System.EventHandler(this.buttonBorrarFiltros_Click);
            // 
            // frmArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 514);
            this.Controls.Add(this.buttonBorrarFiltros);
            this.Controls.Add(this.lbl_Titulo_Articulos);
            this.Controls.Add(this.buttonFiltroAvanz);
            this.Controls.Add(this.lbl_BusquedaNombre);
            this.Controls.Add(this.textBoxBusqueda);
            this.Controls.Add(this.buttonInformación);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonModificar);
            this.Controls.Add(this.buttonAgregar);
            this.Controls.Add(this.dataGridArticulo);
            this.Controls.Add(this.barraMenu);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmArticulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestor de Productos";
            this.Load += new System.EventHandler(this.frmArticulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridArticulo)).EndInit();
            this.barraMenu.ResumeLayout(false);
            this.barraMenu.PerformLayout();
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
    }
}