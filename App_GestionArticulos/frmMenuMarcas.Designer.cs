namespace App_GestionArticulos
{
    partial class frmMenuMarcas
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
            this.dgv_Marcas = new System.Windows.Forms.DataGridView();
            this.lbl_Titulo_Menu_Marcas = new System.Windows.Forms.Label();
            this.btn_AgregarMarca = new System.Windows.Forms.Button();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_VolverMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Marcas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Marcas
            // 
            this.dgv_Marcas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Marcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Marcas.Location = new System.Drawing.Point(34, 88);
            this.dgv_Marcas.Name = "dgv_Marcas";
            this.dgv_Marcas.RowHeadersWidth = 51;
            this.dgv_Marcas.RowTemplate.Height = 24;
            this.dgv_Marcas.Size = new System.Drawing.Size(339, 245);
            this.dgv_Marcas.TabIndex = 0;
            // 
            // lbl_Titulo_Menu_Marcas
            // 
            this.lbl_Titulo_Menu_Marcas.AutoSize = true;
            this.lbl_Titulo_Menu_Marcas.Location = new System.Drawing.Point(138, 28);
            this.lbl_Titulo_Menu_Marcas.Name = "lbl_Titulo_Menu_Marcas";
            this.lbl_Titulo_Menu_Marcas.Size = new System.Drawing.Size(125, 16);
            this.lbl_Titulo_Menu_Marcas.TabIndex = 1;
            this.lbl_Titulo_Menu_Marcas.Text = "Marcas disponibles";
            // 
            // btn_AgregarMarca
            // 
            this.btn_AgregarMarca.Location = new System.Drawing.Point(444, 116);
            this.btn_AgregarMarca.Name = "btn_AgregarMarca";
            this.btn_AgregarMarca.Size = new System.Drawing.Size(183, 43);
            this.btn_AgregarMarca.TabIndex = 2;
            this.btn_AgregarMarca.Text = "Agregar";
            this.btn_AgregarMarca.UseVisualStyleBackColor = true;
            this.btn_AgregarMarca.Click += new System.EventHandler(this.btn_AgregarMarca_Click);
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.Location = new System.Drawing.Point(444, 184);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(183, 43);
            this.btn_Modificar.TabIndex = 3;
            this.btn_Modificar.Text = "Modificar";
            this.btn_Modificar.UseVisualStyleBackColor = true;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Location = new System.Drawing.Point(444, 252);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(183, 43);
            this.btn_Eliminar.TabIndex = 4;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btn_VolverMenu
            // 
            this.btn_VolverMenu.Location = new System.Drawing.Point(231, 370);
            this.btn_VolverMenu.Name = "btn_VolverMenu";
            this.btn_VolverMenu.Size = new System.Drawing.Size(226, 38);
            this.btn_VolverMenu.TabIndex = 5;
            this.btn_VolverMenu.Text = "Volver al Menu Principal";
            this.btn_VolverMenu.UseVisualStyleBackColor = true;
            this.btn_VolverMenu.Click += new System.EventHandler(this.btn_VolverMenu_Click);
            // 
            // frmMenuMarcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 450);
            this.Controls.Add(this.btn_VolverMenu);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.btn_Modificar);
            this.Controls.Add(this.btn_AgregarMarca);
            this.Controls.Add(this.lbl_Titulo_Menu_Marcas);
            this.Controls.Add(this.dgv_Marcas);
            this.Name = "frmMenuMarcas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Marcas";
            this.Load += new System.EventHandler(this.frmMenuMarcas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Marcas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Marcas;
        private System.Windows.Forms.Label lbl_Titulo_Menu_Marcas;
        private System.Windows.Forms.Button btn_AgregarMarca;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_VolverMenu;
    }
}