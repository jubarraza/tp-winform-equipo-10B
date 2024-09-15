namespace App_GestionArticulos
{
    partial class frmInformacionArticulo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInformacionArticulo));
            this.labelPrecio = new System.Windows.Forms.Label();
            this.labelCategoria = new System.Windows.Forms.Label();
            this.labelMarca = new System.Windows.Forms.Label();
            this.labelDesc = new System.Windows.Forms.Label();
            this.lbl_Articulo = new System.Windows.Forms.Label();
            this.lbl_Desc = new System.Windows.Forms.Label();
            this.pb_Imagenes = new System.Windows.Forms.PictureBox();
            this.btn_Atras = new System.Windows.Forms.Button();
            this.btn_Adelante = new System.Windows.Forms.Button();
            this.lbl_Marca = new System.Windows.Forms.Label();
            this.lbl_Cat = new System.Windows.Forms.Label();
            this.lbl_Precio = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Imagenes)).BeginInit();
            this.SuspendLayout();
            // 
            // labelPrecio
            // 
            this.labelPrecio.AutoSize = true;
            this.labelPrecio.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrecio.ForeColor = System.Drawing.Color.White;
            this.labelPrecio.Location = new System.Drawing.Point(48, 344);
            this.labelPrecio.Name = "labelPrecio";
            this.labelPrecio.Size = new System.Drawing.Size(58, 17);
            this.labelPrecio.TabIndex = 17;
            this.labelPrecio.Text = "Precio:";
            // 
            // labelCategoria
            // 
            this.labelCategoria.AutoSize = true;
            this.labelCategoria.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCategoria.ForeColor = System.Drawing.Color.White;
            this.labelCategoria.Location = new System.Drawing.Point(25, 271);
            this.labelCategoria.Name = "labelCategoria";
            this.labelCategoria.Size = new System.Drawing.Size(81, 17);
            this.labelCategoria.TabIndex = 16;
            this.labelCategoria.Text = "Categoria:";
            // 
            // labelMarca
            // 
            this.labelMarca.AutoSize = true;
            this.labelMarca.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMarca.ForeColor = System.Drawing.Color.White;
            this.labelMarca.Location = new System.Drawing.Point(52, 228);
            this.labelMarca.Name = "labelMarca";
            this.labelMarca.Size = new System.Drawing.Size(54, 17);
            this.labelMarca.TabIndex = 15;
            this.labelMarca.Text = "Marca:";
            // 
            // labelDesc
            // 
            this.labelDesc.AutoSize = true;
            this.labelDesc.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDesc.ForeColor = System.Drawing.Color.White;
            this.labelDesc.Location = new System.Drawing.Point(8, 95);
            this.labelDesc.Name = "labelDesc";
            this.labelDesc.Size = new System.Drawing.Size(98, 17);
            this.labelDesc.TabIndex = 14;
            this.labelDesc.Text = "Descripción:";
            // 
            // lbl_Articulo
            // 
            this.lbl_Articulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Articulo.AutoEllipsis = true;
            this.lbl_Articulo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Articulo.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Articulo.ForeColor = System.Drawing.Color.White;
            this.lbl_Articulo.Location = new System.Drawing.Point(12, 28);
            this.lbl_Articulo.Name = "lbl_Articulo";
            this.lbl_Articulo.Size = new System.Drawing.Size(363, 38);
            this.lbl_Articulo.TabIndex = 12;
            // 
            // lbl_Desc
            // 
            this.lbl_Desc.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Desc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_Desc.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Desc.ForeColor = System.Drawing.Color.White;
            this.lbl_Desc.Location = new System.Drawing.Point(109, 95);
            this.lbl_Desc.Margin = new System.Windows.Forms.Padding(2);
            this.lbl_Desc.Name = "lbl_Desc";
            this.lbl_Desc.Padding = new System.Windows.Forms.Padding(2);
            this.lbl_Desc.Size = new System.Drawing.Size(258, 79);
            this.lbl_Desc.TabIndex = 19;
            // 
            // pb_Imagenes
            // 
            this.pb_Imagenes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_Imagenes.Location = new System.Drawing.Point(404, 18);
            this.pb_Imagenes.Margin = new System.Windows.Forms.Padding(2);
            this.pb_Imagenes.Name = "pb_Imagenes";
            this.pb_Imagenes.Size = new System.Drawing.Size(386, 402);
            this.pb_Imagenes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Imagenes.TabIndex = 20;
            this.pb_Imagenes.TabStop = false;
            // 
            // btn_Atras
            // 
            this.btn_Atras.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Atras.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btn_Atras.FlatAppearance.MouseDownBackColor = System.Drawing.Color.AliceBlue;
            this.btn_Atras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen;
            this.btn_Atras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Atras.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Atras.Image = ((System.Drawing.Image)(resources.GetObject("btn_Atras.Image")));
            this.btn_Atras.Location = new System.Drawing.Point(538, 424);
            this.btn_Atras.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Atras.Name = "btn_Atras";
            this.btn_Atras.Size = new System.Drawing.Size(61, 33);
            this.btn_Atras.TabIndex = 21;
            this.btn_Atras.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Atras.UseVisualStyleBackColor = false;
            this.btn_Atras.Click += new System.EventHandler(this.btn_Atras_Click);
            // 
            // btn_Adelante
            // 
            this.btn_Adelante.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Adelante.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btn_Adelante.FlatAppearance.MouseDownBackColor = System.Drawing.Color.AliceBlue;
            this.btn_Adelante.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen;
            this.btn_Adelante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Adelante.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Adelante.Image = ((System.Drawing.Image)(resources.GetObject("btn_Adelante.Image")));
            this.btn_Adelante.Location = new System.Drawing.Point(603, 424);
            this.btn_Adelante.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Adelante.Name = "btn_Adelante";
            this.btn_Adelante.Size = new System.Drawing.Size(61, 33);
            this.btn_Adelante.TabIndex = 22;
            this.btn_Adelante.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Adelante.UseVisualStyleBackColor = false;
            this.btn_Adelante.Click += new System.EventHandler(this.btn_Adelante_Click);
            // 
            // lbl_Marca
            // 
            this.lbl_Marca.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Marca.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Marca.ForeColor = System.Drawing.Color.White;
            this.lbl_Marca.Location = new System.Drawing.Point(112, 228);
            this.lbl_Marca.Name = "lbl_Marca";
            this.lbl_Marca.Size = new System.Drawing.Size(176, 20);
            this.lbl_Marca.TabIndex = 24;
            // 
            // lbl_Cat
            // 
            this.lbl_Cat.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Cat.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Cat.ForeColor = System.Drawing.Color.White;
            this.lbl_Cat.Location = new System.Drawing.Point(112, 271);
            this.lbl_Cat.Name = "lbl_Cat";
            this.lbl_Cat.Size = new System.Drawing.Size(176, 20);
            this.lbl_Cat.TabIndex = 25;
            // 
            // lbl_Precio
            // 
            this.lbl_Precio.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Precio.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Precio.ForeColor = System.Drawing.Color.White;
            this.lbl_Precio.Location = new System.Drawing.Point(114, 344);
            this.lbl_Precio.Name = "lbl_Precio";
            this.lbl_Precio.Size = new System.Drawing.Size(176, 20);
            this.lbl_Precio.TabIndex = 26;
            // 
            // frmInformacionArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(105)))), ((int)(((byte)(137)))));
            this.ClientSize = new System.Drawing.Size(831, 486);
            this.Controls.Add(this.labelCategoria);
            this.Controls.Add(this.labelMarca);
            this.Controls.Add(this.lbl_Cat);
            this.Controls.Add(this.lbl_Precio);
            this.Controls.Add(this.lbl_Marca);
            this.Controls.Add(this.btn_Adelante);
            this.Controls.Add(this.btn_Atras);
            this.Controls.Add(this.pb_Imagenes);
            this.Controls.Add(this.lbl_Desc);
            this.Controls.Add(this.labelPrecio);
            this.Controls.Add(this.labelDesc);
            this.Controls.Add(this.lbl_Articulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "frmInformacionArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Articulo";
            this.Load += new System.EventHandler(this.frmInformacionArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Imagenes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPrecio;
        private System.Windows.Forms.Label labelCategoria;
        private System.Windows.Forms.Label labelMarca;
        private System.Windows.Forms.Label labelDesc;
        private System.Windows.Forms.Label lbl_Articulo;
        private System.Windows.Forms.Label lbl_Desc;
        private System.Windows.Forms.PictureBox pb_Imagenes;
        private System.Windows.Forms.Button btn_Atras;
        private System.Windows.Forms.Button btn_Adelante;
        private System.Windows.Forms.Label lbl_Marca;
        private System.Windows.Forms.Label lbl_Cat;
        private System.Windows.Forms.Label lbl_Precio;
    }
}