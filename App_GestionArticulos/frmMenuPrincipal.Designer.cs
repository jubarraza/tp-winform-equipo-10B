namespace App_GestionArticulos
{
    partial class frmMenuPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_MenuMarcas = new System.Windows.Forms.Button();
            this.btn_MenuCategorias = new System.Windows.Forms.Button();
            this.btn_MenuArticulos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_MenuMarcas
            // 
            this.btn_MenuMarcas.Location = new System.Drawing.Point(228, 162);
            this.btn_MenuMarcas.Margin = new System.Windows.Forms.Padding(2);
            this.btn_MenuMarcas.Name = "btn_MenuMarcas";
            this.btn_MenuMarcas.Size = new System.Drawing.Size(138, 43);
            this.btn_MenuMarcas.TabIndex = 0;
            this.btn_MenuMarcas.Text = "Marcas";
            this.btn_MenuMarcas.UseVisualStyleBackColor = true;
            this.btn_MenuMarcas.Click += new System.EventHandler(this.btn_MenuMarcas_Click);
            // 
            // btn_MenuCategorias
            // 
            this.btn_MenuCategorias.Location = new System.Drawing.Point(392, 162);
            this.btn_MenuCategorias.Margin = new System.Windows.Forms.Padding(2);
            this.btn_MenuCategorias.Name = "btn_MenuCategorias";
            this.btn_MenuCategorias.Size = new System.Drawing.Size(138, 43);
            this.btn_MenuCategorias.TabIndex = 1;
            this.btn_MenuCategorias.Text = "Categorias";
            this.btn_MenuCategorias.UseVisualStyleBackColor = true;
            this.btn_MenuCategorias.Click += new System.EventHandler(this.btn_MenuCategorias_Click);
            // 
            // btn_MenuArticulos
            // 
            this.btn_MenuArticulos.Location = new System.Drawing.Point(64, 162);
            this.btn_MenuArticulos.Margin = new System.Windows.Forms.Padding(2);
            this.btn_MenuArticulos.Name = "btn_MenuArticulos";
            this.btn_MenuArticulos.Size = new System.Drawing.Size(138, 43);
            this.btn_MenuArticulos.TabIndex = 2;
            this.btn_MenuArticulos.Text = "Articulos";
            this.btn_MenuArticulos.UseVisualStyleBackColor = true;
            this.btn_MenuArticulos.Click += new System.EventHandler(this.btn_MenuArticulos_Click);
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btn_MenuArticulos);
            this.Controls.Add(this.btn_MenuCategorias);
            this.Controls.Add(this.btn_MenuMarcas);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion de Articulos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_MenuMarcas;
        private System.Windows.Forms.Button btn_MenuCategorias;
        private System.Windows.Forms.Button btn_MenuArticulos;
    }
}

