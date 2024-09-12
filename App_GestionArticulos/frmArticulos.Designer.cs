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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridArticulo
            // 
            this.dataGridArticulo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridArticulo.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridArticulo.Location = new System.Drawing.Point(52, 103);
            this.dataGridArticulo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.buttonAgregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.buttonModificar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.buttonEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.buttonInformación.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.textBoxBusqueda.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.buttonFiltroAvanz.Location = new System.Drawing.Point(631, 429);
            this.buttonFiltroAvanz.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonFiltroAvanz.Name = "buttonFiltroAvanz";
            this.buttonFiltroAvanz.Size = new System.Drawing.Size(137, 31);
            this.buttonFiltroAvanz.TabIndex = 7;
            this.buttonFiltroAvanz.Text = "Filtros avanzados";
            this.buttonFiltroAvanz.UseVisualStyleBackColor = true;
            this.buttonFiltroAvanz.Click += new System.EventHandler(this.buttonFiltroAvanz_Click);
            // 
            // lbl_Titulo_Articulos
            // 
            this.lbl_Titulo_Articulos.AutoSize = true;
            this.lbl_Titulo_Articulos.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo_Articulos.Location = new System.Drawing.Point(268, 28);
            this.lbl_Titulo_Articulos.Name = "lbl_Titulo_Articulos";
            this.lbl_Titulo_Articulos.Size = new System.Drawing.Size(228, 31);
            this.lbl_Titulo_Articulos.TabIndex = 8;
            this.lbl_Titulo_Articulos.Text = "Articulos disponibles";
            // 
            // frmArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 514);
            this.Controls.Add(this.lbl_Titulo_Articulos);
            this.Controls.Add(this.buttonFiltroAvanz);
            this.Controls.Add(this.lbl_BusquedaNombre);
            this.Controls.Add(this.textBoxBusqueda);
            this.Controls.Add(this.buttonInformación);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonModificar);
            this.Controls.Add(this.buttonAgregar);
            this.Controls.Add(this.dataGridArticulo);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmArticulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Articulos";
            this.Load += new System.EventHandler(this.frmArticulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridArticulo)).EndInit();
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
    }
}