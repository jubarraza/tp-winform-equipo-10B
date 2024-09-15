namespace App_GestionArticulos
{
    partial class frmAlta_Edicion_Marca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlta_Edicion_Marca));
            this.lbl_NombreMarca = new System.Windows.Forms.Label();
            this.txt_NombreMarca = new System.Windows.Forms.TextBox();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_NombreMarca
            // 
            this.lbl_NombreMarca.AutoSize = true;
            this.lbl_NombreMarca.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NombreMarca.Location = new System.Drawing.Point(36, 31);
            this.lbl_NombreMarca.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_NombreMarca.Name = "lbl_NombreMarca";
            this.lbl_NombreMarca.Size = new System.Drawing.Size(117, 17);
            this.lbl_NombreMarca.TabIndex = 0;
            this.lbl_NombreMarca.Text = "Nombre marca:";
            // 
            // txt_NombreMarca
            // 
            this.txt_NombreMarca.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NombreMarca.Location = new System.Drawing.Point(39, 50);
            this.txt_NombreMarca.Margin = new System.Windows.Forms.Padding(2);
            this.txt_NombreMarca.MaxLength = 50;
            this.txt_NombreMarca.Name = "txt_NombreMarca";
            this.txt_NombreMarca.Size = new System.Drawing.Size(272, 25);
            this.txt_NombreMarca.TabIndex = 1;
            this.txt_NombreMarca.TextChanged += new System.EventHandler(this.txt_NombreMarca_TextChanged);
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Guardar.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.btn_Guardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen;
            this.btn_Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Guardar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Guardar.Image")));
            this.btn_Guardar.Location = new System.Drawing.Point(130, 82);
            this.btn_Guardar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(43, 43);
            this.btn_Guardar.TabIndex = 2;
            this.btn_Guardar.UseVisualStyleBackColor = false;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Cancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Cancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSalmon;
            this.btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancelar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Cancelar.Image")));
            this.btn_Cancelar.Location = new System.Drawing.Point(177, 82);
            this.btn_Cancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(43, 43);
            this.btn_Cancelar.TabIndex = 3;
            this.btn_Cancelar.UseVisualStyleBackColor = false;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // frmAlta_Edicion_Marca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(205)))), ((int)(((byte)(159)))));
            this.ClientSize = new System.Drawing.Size(343, 149);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.txt_NombreMarca);
            this.Controls.Add(this.lbl_NombreMarca);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmAlta_Edicion_Marca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar nueva Marca";
            this.Load += new System.EventHandler(this.frmAlta_Edicion_Marca_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_NombreMarca;
        private System.Windows.Forms.TextBox txt_NombreMarca;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.Button btn_Cancelar;
    }
}