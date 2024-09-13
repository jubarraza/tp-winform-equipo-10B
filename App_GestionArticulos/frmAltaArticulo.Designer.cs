namespace App_GestionArticulos
{
    partial class frmAltaArticulo
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
            this.labelCodigo = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelDesc = new System.Windows.Forms.Label();
            this.labelMarca = new System.Windows.Forms.Label();
            this.labelCategoria = new System.Windows.Forms.Label();
            this.labelPrecio = new System.Windows.Forms.Label();
            this.textBoxCodigo = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxDescrip = new System.Windows.Forms.TextBox();
            this.comboBoxMarca = new System.Windows.Forms.ComboBox();
            this.comboBoxCategoria = new System.Windows.Forms.ComboBox();
            this.textBoxPrecio = new System.Windows.Forms.TextBox();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.txt_Url = new System.Windows.Forms.TextBox();
            this.labelUrl = new System.Windows.Forms.Label();
            this.pb_Imagen = new System.Windows.Forms.PictureBox();
            this.btn_Adelante = new System.Windows.Forms.Button();
            this.btn_Atras = new System.Windows.Forms.Button();
            this.btn_AgregarImagenes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Imagen)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCodigo
            // 
            this.labelCodigo.AutoSize = true;
            this.labelCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCodigo.Location = new System.Drawing.Point(90, 59);
            this.labelCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCodigo.Name = "labelCodigo";
            this.labelCodigo.Size = new System.Drawing.Size(81, 25);
            this.labelCodigo.TabIndex = 0;
            this.labelCodigo.Text = "Codigo:";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.Location = new System.Drawing.Point(84, 107);
            this.labelNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(87, 25);
            this.labelNombre.TabIndex = 1;
            this.labelNombre.Text = "Nombre:";
            // 
            // labelDesc
            // 
            this.labelDesc.AutoSize = true;
            this.labelDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDesc.Location = new System.Drawing.Point(51, 152);
            this.labelDesc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDesc.Name = "labelDesc";
            this.labelDesc.Size = new System.Drawing.Size(120, 25);
            this.labelDesc.TabIndex = 2;
            this.labelDesc.Text = "Descripción:";
            // 
            // labelMarca
            // 
            this.labelMarca.AutoSize = true;
            this.labelMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMarca.Location = new System.Drawing.Point(98, 258);
            this.labelMarca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMarca.Name = "labelMarca";
            this.labelMarca.Size = new System.Drawing.Size(73, 25);
            this.labelMarca.TabIndex = 3;
            this.labelMarca.Text = "Marca:";
            // 
            // labelCategoria
            // 
            this.labelCategoria.AutoSize = true;
            this.labelCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCategoria.Location = new System.Drawing.Point(68, 308);
            this.labelCategoria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCategoria.Name = "labelCategoria";
            this.labelCategoria.Size = new System.Drawing.Size(103, 25);
            this.labelCategoria.TabIndex = 4;
            this.labelCategoria.Text = "Categoria:";
            // 
            // labelPrecio
            // 
            this.labelPrecio.AutoSize = true;
            this.labelPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrecio.Location = new System.Drawing.Point(494, 57);
            this.labelPrecio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPrecio.Name = "labelPrecio";
            this.labelPrecio.Size = new System.Drawing.Size(73, 25);
            this.labelPrecio.TabIndex = 5;
            this.labelPrecio.Text = "Precio:";
            // 
            // textBoxCodigo
            // 
            this.textBoxCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCodigo.Location = new System.Drawing.Point(195, 59);
            this.textBoxCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCodigo.Name = "textBoxCodigo";
            this.textBoxCodigo.Size = new System.Drawing.Size(236, 24);
            this.textBoxCodigo.TabIndex = 0;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombre.Location = new System.Drawing.Point(195, 107);
            this.textBoxNombre.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(236, 24);
            this.textBoxNombre.TabIndex = 1;
            // 
            // textBoxDescrip
            // 
            this.textBoxDescrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDescrip.Location = new System.Drawing.Point(195, 152);
            this.textBoxDescrip.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDescrip.Multiline = true;
            this.textBoxDescrip.Name = "textBoxDescrip";
            this.textBoxDescrip.Size = new System.Drawing.Size(236, 69);
            this.textBoxDescrip.TabIndex = 2;
            // 
            // comboBoxMarca
            // 
            this.comboBoxMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMarca.FormattingEnabled = true;
            this.comboBoxMarca.Location = new System.Drawing.Point(195, 259);
            this.comboBoxMarca.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxMarca.Name = "comboBoxMarca";
            this.comboBoxMarca.Size = new System.Drawing.Size(236, 24);
            this.comboBoxMarca.TabIndex = 3;
            // 
            // comboBoxCategoria
            // 
            this.comboBoxCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCategoria.FormattingEnabled = true;
            this.comboBoxCategoria.Location = new System.Drawing.Point(195, 309);
            this.comboBoxCategoria.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxCategoria.Name = "comboBoxCategoria";
            this.comboBoxCategoria.Size = new System.Drawing.Size(236, 24);
            this.comboBoxCategoria.TabIndex = 4;
            // 
            // textBoxPrecio
            // 
            this.textBoxPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPrecio.Location = new System.Drawing.Point(591, 58);
            this.textBoxPrecio.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPrecio.Name = "textBoxPrecio";
            this.textBoxPrecio.Size = new System.Drawing.Size(226, 24);
            this.textBoxPrecio.TabIndex = 6;
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(312, 486);
            this.buttonAceptar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(167, 33);
            this.buttonAceptar.TabIndex = 7;
            this.buttonAceptar.Text = "Guardar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(513, 486);
            this.buttonCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(167, 33);
            this.buttonCancelar.TabIndex = 8;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // txt_Url
            // 
            this.txt_Url.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Url.Location = new System.Drawing.Point(195, 370);
            this.txt_Url.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Url.Name = "txt_Url";
            this.txt_Url.Size = new System.Drawing.Size(236, 24);
            this.txt_Url.TabIndex = 5;
            this.txt_Url.Leave += new System.EventHandler(this.txt_Url_Leave);
            // 
            // labelUrl
            // 
            this.labelUrl.AutoSize = true;
            this.labelUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUrl.Location = new System.Drawing.Point(59, 368);
            this.labelUrl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUrl.Name = "labelUrl";
            this.labelUrl.Size = new System.Drawing.Size(112, 25);
            this.labelUrl.TabIndex = 14;
            this.labelUrl.Text = "Url Imagen:";
            // 
            // pb_Imagen
            // 
            this.pb_Imagen.Location = new System.Drawing.Point(521, 107);
            this.pb_Imagen.Name = "pb_Imagen";
            this.pb_Imagen.Size = new System.Drawing.Size(355, 291);
            this.pb_Imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Imagen.TabIndex = 16;
            this.pb_Imagen.TabStop = false;
            // 
            // btn_Adelante
            // 
            this.btn_Adelante.Location = new System.Drawing.Point(711, 404);
            this.btn_Adelante.Name = "btn_Adelante";
            this.btn_Adelante.Size = new System.Drawing.Size(48, 42);
            this.btn_Adelante.TabIndex = 24;
            this.btn_Adelante.Text = ">";
            this.btn_Adelante.UseVisualStyleBackColor = true;
            this.btn_Adelante.Click += new System.EventHandler(this.btn_Adelante_Click);
            // 
            // btn_Atras
            // 
            this.btn_Atras.Location = new System.Drawing.Point(657, 404);
            this.btn_Atras.Name = "btn_Atras";
            this.btn_Atras.Size = new System.Drawing.Size(48, 42);
            this.btn_Atras.TabIndex = 23;
            this.btn_Atras.Text = "<";
            this.btn_Atras.UseVisualStyleBackColor = true;
            this.btn_Atras.Click += new System.EventHandler(this.btn_Atras_Click);
            // 
            // btn_AgregarImagenes
            // 
            this.btn_AgregarImagenes.Location = new System.Drawing.Point(255, 410);
            this.btn_AgregarImagenes.Name = "btn_AgregarImagenes";
            this.btn_AgregarImagenes.Size = new System.Drawing.Size(176, 30);
            this.btn_AgregarImagenes.TabIndex = 25;
            this.btn_AgregarImagenes.Text = "Agregar nueva imagen";
            this.btn_AgregarImagenes.UseVisualStyleBackColor = true;
            this.btn_AgregarImagenes.Click += new System.EventHandler(this.lbl_AgregarImagenes_Click);
            // 
            // frmAltaArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 559);
            this.Controls.Add(this.btn_AgregarImagenes);
            this.Controls.Add(this.btn_Adelante);
            this.Controls.Add(this.btn_Atras);
            this.Controls.Add(this.pb_Imagen);
            this.Controls.Add(this.txt_Url);
            this.Controls.Add(this.labelUrl);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.textBoxPrecio);
            this.Controls.Add(this.comboBoxCategoria);
            this.Controls.Add(this.comboBoxMarca);
            this.Controls.Add(this.textBoxDescrip);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.textBoxCodigo);
            this.Controls.Add(this.labelPrecio);
            this.Controls.Add(this.labelCategoria);
            this.Controls.Add(this.labelMarca);
            this.Controls.Add(this.labelDesc);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.labelCodigo);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAltaArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta de articulo";
            this.Load += new System.EventHandler(this.frmAltaArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Imagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCodigo;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelDesc;
        private System.Windows.Forms.Label labelMarca;
        private System.Windows.Forms.Label labelCategoria;
        private System.Windows.Forms.Label labelPrecio;
        private System.Windows.Forms.TextBox textBoxCodigo;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxDescrip;
        private System.Windows.Forms.ComboBox comboBoxMarca;
        private System.Windows.Forms.ComboBox comboBoxCategoria;
        private System.Windows.Forms.TextBox textBoxPrecio;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.TextBox txt_Url;
        private System.Windows.Forms.Label labelUrl;
        private System.Windows.Forms.PictureBox pb_Imagen;
        private System.Windows.Forms.Button btn_Adelante;
        private System.Windows.Forms.Button btn_Atras;
        private System.Windows.Forms.Button btn_AgregarImagenes;
    }
}