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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAltaArticulo));
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
            this.btn_BorrarImg = new System.Windows.Forms.Button();
            this.toolTip_am = new System.Windows.Forms.ToolTip(this.components);
            this.lbl_campos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Imagen)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCodigo
            // 
            this.labelCodigo.AutoSize = true;
            this.labelCodigo.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCodigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.labelCodigo.Location = new System.Drawing.Point(56, 44);
            this.labelCodigo.Name = "labelCodigo";
            this.labelCodigo.Size = new System.Drawing.Size(68, 17);
            this.labelCodigo.TabIndex = 0;
            this.labelCodigo.Text = "Codigo*";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.labelNombre.Location = new System.Drawing.Point(51, 87);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(73, 17);
            this.labelNombre.TabIndex = 1;
            this.labelNombre.Text = "Nombre*";
            // 
            // labelDesc
            // 
            this.labelDesc.AutoSize = true;
            this.labelDesc.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.labelDesc.Location = new System.Drawing.Point(27, 128);
            this.labelDesc.Name = "labelDesc";
            this.labelDesc.Size = new System.Drawing.Size(101, 17);
            this.labelDesc.TabIndex = 2;
            this.labelDesc.Text = "Descripción*";
            // 
            // labelMarca
            // 
            this.labelMarca.AutoSize = true;
            this.labelMarca.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMarca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.labelMarca.Location = new System.Drawing.Point(62, 218);
            this.labelMarca.Name = "labelMarca";
            this.labelMarca.Size = new System.Drawing.Size(57, 17);
            this.labelMarca.TabIndex = 3;
            this.labelMarca.Text = "Marca*";
            // 
            // labelCategoria
            // 
            this.labelCategoria.AutoSize = true;
            this.labelCategoria.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.labelCategoria.Location = new System.Drawing.Point(40, 263);
            this.labelCategoria.Name = "labelCategoria";
            this.labelCategoria.Size = new System.Drawing.Size(84, 17);
            this.labelCategoria.TabIndex = 4;
            this.labelCategoria.Text = "Categoria*";
            // 
            // labelPrecio
            // 
            this.labelPrecio.AutoSize = true;
            this.labelPrecio.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrecio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.labelPrecio.Location = new System.Drawing.Point(379, 44);
            this.labelPrecio.Name = "labelPrecio";
            this.labelPrecio.Size = new System.Drawing.Size(61, 17);
            this.labelPrecio.TabIndex = 5;
            this.labelPrecio.Text = "Precio*";
            // 
            // textBoxCodigo
            // 
            this.textBoxCodigo.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCodigo.Location = new System.Drawing.Point(127, 41);
            this.textBoxCodigo.MaxLength = 50;
            this.textBoxCodigo.Name = "textBoxCodigo";
            this.textBoxCodigo.Size = new System.Drawing.Size(178, 23);
            this.textBoxCodigo.TabIndex = 0;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombre.Location = new System.Drawing.Point(127, 84);
            this.textBoxNombre.MaxLength = 50;
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(178, 23);
            this.textBoxNombre.TabIndex = 1;
            // 
            // textBoxDescrip
            // 
            this.textBoxDescrip.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDescrip.Location = new System.Drawing.Point(127, 128);
            this.textBoxDescrip.MaxLength = 150;
            this.textBoxDescrip.Multiline = true;
            this.textBoxDescrip.Name = "textBoxDescrip";
            this.textBoxDescrip.Size = new System.Drawing.Size(178, 57);
            this.textBoxDescrip.TabIndex = 2;
            // 
            // comboBoxMarca
            // 
            this.comboBoxMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMarca.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxMarca.FormattingEnabled = true;
            this.comboBoxMarca.Location = new System.Drawing.Point(127, 215);
            this.comboBoxMarca.Name = "comboBoxMarca";
            this.comboBoxMarca.Size = new System.Drawing.Size(178, 23);
            this.comboBoxMarca.TabIndex = 3;
            // 
            // comboBoxCategoria
            // 
            this.comboBoxCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCategoria.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCategoria.FormattingEnabled = true;
            this.comboBoxCategoria.Location = new System.Drawing.Point(127, 260);
            this.comboBoxCategoria.Name = "comboBoxCategoria";
            this.comboBoxCategoria.Size = new System.Drawing.Size(178, 23);
            this.comboBoxCategoria.TabIndex = 4;
            // 
            // textBoxPrecio
            // 
            this.textBoxPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPrecio.Location = new System.Drawing.Point(452, 45);
            this.textBoxPrecio.MaxLength = 15;
            this.textBoxPrecio.Name = "textBoxPrecio";
            this.textBoxPrecio.Size = new System.Drawing.Size(195, 22);
            this.textBoxPrecio.TabIndex = 6;
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonAceptar.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.buttonAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen;
            this.buttonAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAceptar.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAceptar.Image = ((System.Drawing.Image)(resources.GetObject("buttonAceptar.Image")));
            this.buttonAceptar.Location = new System.Drawing.Point(316, 385);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(43, 43);
            this.buttonAceptar.TabIndex = 7;
            this.buttonAceptar.UseVisualStyleBackColor = false;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.buttonCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSalmon;
            this.buttonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelar.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelar.Image = ((System.Drawing.Image)(resources.GetObject("buttonCancelar.Image")));
            this.buttonCancelar.Location = new System.Drawing.Point(365, 385);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(43, 43);
            this.buttonCancelar.TabIndex = 8;
            this.buttonCancelar.UseVisualStyleBackColor = false;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // txt_Url
            // 
            this.txt_Url.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Url.Location = new System.Drawing.Point(127, 309);
            this.txt_Url.MaxLength = 1000;
            this.txt_Url.Multiline = true;
            this.txt_Url.Name = "txt_Url";
            this.txt_Url.Size = new System.Drawing.Size(178, 50);
            this.txt_Url.TabIndex = 5;
            this.txt_Url.Leave += new System.EventHandler(this.txt_Url_Leave);
            // 
            // labelUrl
            // 
            this.labelUrl.AutoSize = true;
            this.labelUrl.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUrl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.labelUrl.Location = new System.Drawing.Point(33, 312);
            this.labelUrl.Name = "labelUrl";
            this.labelUrl.Size = new System.Drawing.Size(88, 17);
            this.labelUrl.TabIndex = 14;
            this.labelUrl.Text = "Url Imagen";
            // 
            // pb_Imagen
            // 
            this.pb_Imagen.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pb_Imagen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pb_Imagen.Location = new System.Drawing.Point(380, 84);
            this.pb_Imagen.Margin = new System.Windows.Forms.Padding(2);
            this.pb_Imagen.Name = "pb_Imagen";
            this.pb_Imagen.Size = new System.Drawing.Size(267, 237);
            this.pb_Imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Imagen.TabIndex = 16;
            this.pb_Imagen.TabStop = false;
            // 
            // btn_Adelante
            // 
            this.btn_Adelante.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(225)))), ((int)(((byte)(217)))));
            this.btn_Adelante.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btn_Adelante.FlatAppearance.MouseDownBackColor = System.Drawing.Color.AliceBlue;
            this.btn_Adelante.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
            this.btn_Adelante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Adelante.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Adelante.Image = ((System.Drawing.Image)(resources.GetObject("btn_Adelante.Image")));
            this.btn_Adelante.Location = new System.Drawing.Point(520, 325);
            this.btn_Adelante.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Adelante.Name = "btn_Adelante";
            this.btn_Adelante.Size = new System.Drawing.Size(34, 34);
            this.btn_Adelante.TabIndex = 24;
            this.btn_Adelante.UseVisualStyleBackColor = false;
            this.btn_Adelante.Click += new System.EventHandler(this.btn_Adelante_Click);
            // 
            // btn_Atras
            // 
            this.btn_Atras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(225)))), ((int)(((byte)(217)))));
            this.btn_Atras.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btn_Atras.FlatAppearance.MouseDownBackColor = System.Drawing.Color.AliceBlue;
            this.btn_Atras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
            this.btn_Atras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Atras.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Atras.Image = ((System.Drawing.Image)(resources.GetObject("btn_Atras.Image")));
            this.btn_Atras.Location = new System.Drawing.Point(482, 325);
            this.btn_Atras.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Atras.Name = "btn_Atras";
            this.btn_Atras.Size = new System.Drawing.Size(34, 34);
            this.btn_Atras.TabIndex = 23;
            this.btn_Atras.UseVisualStyleBackColor = false;
            this.btn_Atras.Click += new System.EventHandler(this.btn_Atras_Click);
            // 
            // btn_AgregarImagenes
            // 
            this.btn_AgregarImagenes.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_AgregarImagenes.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.btn_AgregarImagenes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen;
            this.btn_AgregarImagenes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AgregarImagenes.Image = ((System.Drawing.Image)(resources.GetObject("btn_AgregarImagenes.Image")));
            this.btn_AgregarImagenes.Location = new System.Drawing.Point(660, 144);
            this.btn_AgregarImagenes.Margin = new System.Windows.Forms.Padding(2);
            this.btn_AgregarImagenes.Name = "btn_AgregarImagenes";
            this.btn_AgregarImagenes.Size = new System.Drawing.Size(32, 38);
            this.btn_AgregarImagenes.TabIndex = 25;
            this.btn_AgregarImagenes.UseVisualStyleBackColor = false;
            this.btn_AgregarImagenes.Click += new System.EventHandler(this.lbl_AgregarImagenes_Click);
            // 
            // btn_BorrarImg
            // 
            this.btn_BorrarImg.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_BorrarImg.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btn_BorrarImg.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSalmon;
            this.btn_BorrarImg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_BorrarImg.Image = ((System.Drawing.Image)(resources.GetObject("btn_BorrarImg.Image")));
            this.btn_BorrarImg.Location = new System.Drawing.Point(660, 197);
            this.btn_BorrarImg.Margin = new System.Windows.Forms.Padding(2);
            this.btn_BorrarImg.Name = "btn_BorrarImg";
            this.btn_BorrarImg.Size = new System.Drawing.Size(32, 38);
            this.btn_BorrarImg.TabIndex = 26;
            this.btn_BorrarImg.UseVisualStyleBackColor = false;
            this.btn_BorrarImg.Click += new System.EventHandler(this.btn_BorrarImg_Click);
            // 
            // lbl_campos
            // 
            this.lbl_campos.Font = new System.Drawing.Font("Lucida Sans", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_campos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(225)))), ((int)(((byte)(217)))));
            this.lbl_campos.Location = new System.Drawing.Point(134, 374);
            this.lbl_campos.Name = "lbl_campos";
            this.lbl_campos.Size = new System.Drawing.Size(159, 21);
            this.lbl_campos.TabIndex = 27;
            this.lbl_campos.Text = "* campos obligatorios";
            // 
            // frmAltaArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(105)))), ((int)(((byte)(137)))));
            this.ClientSize = new System.Drawing.Size(715, 444);
            this.Controls.Add(this.lbl_campos);
            this.Controls.Add(this.btn_BorrarImg);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(731, 483);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(731, 483);
            this.Name = "frmAltaArticulo";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
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
        private System.Windows.Forms.Button btn_BorrarImg;
        private System.Windows.Forms.ToolTip toolTip_am;
        private System.Windows.Forms.Label lbl_campos;
    }
}