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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.dgv_Marcas.AllowUserToAddRows = false;
            this.dgv_Marcas.AllowUserToDeleteRows = false;
            this.dgv_Marcas.AllowUserToResizeRows = false;
            this.dgv_Marcas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Marcas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(163)))), ((int)(((byte)(153)))));
            this.dgv_Marcas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Marcas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Marcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Marcas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_Marcas.Location = new System.Drawing.Point(64, 67);
            this.dgv_Marcas.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_Marcas.MultiSelect = false;
            this.dgv_Marcas.Name = "dgv_Marcas";
            this.dgv_Marcas.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Marcas.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Marcas.RowHeadersWidth = 51;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_Marcas.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Marcas.RowTemplate.Height = 24;
            this.dgv_Marcas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Marcas.Size = new System.Drawing.Size(213, 199);
            this.dgv_Marcas.TabIndex = 0;
            // 
            // lbl_Titulo_Menu_Marcas
            // 
            this.lbl_Titulo_Menu_Marcas.AutoSize = true;
            this.lbl_Titulo_Menu_Marcas.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo_Menu_Marcas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(244)))), ((int)(((byte)(197)))));
            this.lbl_Titulo_Menu_Marcas.Location = new System.Drawing.Point(90, 22);
            this.lbl_Titulo_Menu_Marcas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Titulo_Menu_Marcas.Name = "lbl_Titulo_Menu_Marcas";
            this.lbl_Titulo_Menu_Marcas.Size = new System.Drawing.Size(205, 22);
            this.lbl_Titulo_Menu_Marcas.TabIndex = 5;
            this.lbl_Titulo_Menu_Marcas.Text = "Marcas disponibles";
            // 
            // btn_AgregarMarca
            // 
            this.btn_AgregarMarca.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AgregarMarca.Location = new System.Drawing.Point(302, 69);
            this.btn_AgregarMarca.Margin = new System.Windows.Forms.Padding(2);
            this.btn_AgregarMarca.Name = "btn_AgregarMarca";
            this.btn_AgregarMarca.Size = new System.Drawing.Size(71, 25);
            this.btn_AgregarMarca.TabIndex = 1;
            this.btn_AgregarMarca.Text = "Agregar";
            this.btn_AgregarMarca.UseVisualStyleBackColor = true;
            this.btn_AgregarMarca.Click += new System.EventHandler(this.btn_AgregarMarca_Click);
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Modificar.Location = new System.Drawing.Point(302, 98);
            this.btn_Modificar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(71, 25);
            this.btn_Modificar.TabIndex = 2;
            this.btn_Modificar.Text = "Modificar";
            this.btn_Modificar.UseVisualStyleBackColor = true;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Eliminar.Location = new System.Drawing.Point(302, 127);
            this.btn_Eliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(71, 25);
            this.btn_Eliminar.TabIndex = 3;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btn_VolverMenu
            // 
            this.btn_VolverMenu.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_VolverMenu.Location = new System.Drawing.Point(125, 294);
            this.btn_VolverMenu.Margin = new System.Windows.Forms.Padding(2);
            this.btn_VolverMenu.Name = "btn_VolverMenu";
            this.btn_VolverMenu.Size = new System.Drawing.Size(170, 31);
            this.btn_VolverMenu.TabIndex = 4;
            this.btn_VolverMenu.Text = "Volver al Menu Principal";
            this.btn_VolverMenu.UseVisualStyleBackColor = true;
            this.btn_VolverMenu.Click += new System.EventHandler(this.btn_VolverMenu_Click);
            // 
            // frmMenuMarcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(163)))), ((int)(((byte)(153)))));
            this.ClientSize = new System.Drawing.Size(399, 351);
            this.Controls.Add(this.btn_VolverMenu);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.btn_Modificar);
            this.Controls.Add(this.btn_AgregarMarca);
            this.Controls.Add(this.lbl_Titulo_Menu_Marcas);
            this.Controls.Add(this.dgv_Marcas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
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