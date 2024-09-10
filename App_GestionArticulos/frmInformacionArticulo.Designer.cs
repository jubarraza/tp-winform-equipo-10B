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
            this.dgv_InfoArticulo = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_InfoArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_InfoArticulo
            // 
            this.dgv_InfoArticulo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_InfoArticulo.Location = new System.Drawing.Point(41, 85);
            this.dgv_InfoArticulo.Name = "dgv_InfoArticulo";
            this.dgv_InfoArticulo.RowHeadersWidth = 51;
            this.dgv_InfoArticulo.RowTemplate.Height = 24;
            this.dgv_InfoArticulo.Size = new System.Drawing.Size(388, 227);
            this.dgv_InfoArticulo.TabIndex = 0;
            // 
            // frmInformacionArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv_InfoArticulo);
            this.Name = "frmInformacionArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmInformacionArticulo";
            this.Load += new System.EventHandler(this.frmInformacionArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_InfoArticulo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_InfoArticulo;
    }
}