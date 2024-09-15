namespace App_GestionArticulos
{
    partial class frmNuevaImagen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNuevaImagen));
            this.txt_Url = new System.Windows.Forms.TextBox();
            this.labelUrl = new System.Windows.Forms.Label();
            this.pb_Imagen = new System.Windows.Forms.PictureBox();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Imagen)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Url
            // 
            this.txt_Url.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Url.Location = new System.Drawing.Point(114, 18);
            this.txt_Url.MaxLength = 1000;
            this.txt_Url.Multiline = true;
            this.txt_Url.Name = "txt_Url";
            this.txt_Url.Size = new System.Drawing.Size(247, 21);
            this.txt_Url.TabIndex = 15;
            this.txt_Url.TextChanged += new System.EventHandler(this.txt_Url_TextChanged);
            this.txt_Url.Leave += new System.EventHandler(this.txt_Url_Leave);
            // 
            // labelUrl
            // 
            this.labelUrl.AutoSize = true;
            this.labelUrl.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUrl.Location = new System.Drawing.Point(25, 21);
            this.labelUrl.Name = "labelUrl";
            this.labelUrl.Size = new System.Drawing.Size(83, 15);
            this.labelUrl.TabIndex = 16;
            this.labelUrl.Text = "Url Imagen:";
            // 
            // pb_Imagen
            // 
            this.pb_Imagen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pb_Imagen.Location = new System.Drawing.Point(45, 53);
            this.pb_Imagen.Margin = new System.Windows.Forms.Padding(2);
            this.pb_Imagen.Name = "pb_Imagen";
            this.pb_Imagen.Size = new System.Drawing.Size(316, 277);
            this.pb_Imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Imagen.TabIndex = 17;
            this.pb_Imagen.TabStop = false;
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonAceptar.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.buttonAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen;
            this.buttonAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAceptar.Image = ((System.Drawing.Image)(resources.GetObject("buttonAceptar.Image")));
            this.buttonAceptar.Location = new System.Drawing.Point(158, 335);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(43, 43);
            this.buttonAceptar.TabIndex = 18;
            this.buttonAceptar.UseVisualStyleBackColor = false;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSalmon;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(207, 335);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(43, 43);
            this.button1.TabIndex = 19;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmNuevaImagen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(205)))), ((int)(((byte)(159)))));
            this.ClientSize = new System.Drawing.Size(415, 395);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.pb_Imagen);
            this.Controls.Add(this.txt_Url);
            this.Controls.Add(this.labelUrl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmNuevaImagen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Nueva Imagen";
            this.Load += new System.EventHandler(this.frmNuevaImagen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Imagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Url;
        private System.Windows.Forms.Label labelUrl;
        private System.Windows.Forms.PictureBox pb_Imagen;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolTip toolTip;
    }
}