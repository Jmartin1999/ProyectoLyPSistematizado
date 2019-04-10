namespace AppLyPSistematizadoReal.Vista
{
    partial class frmAdministrador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdministrador));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pcLavado = new System.Windows.Forms.PictureBox();
            this.pcParqueo = new System.Windows.Forms.PictureBox();
            this.pcMensualidad = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcLavado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcParqueo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcMensualidad)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(801, 453);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pcLavado
            // 
            this.pcLavado.Image = ((System.Drawing.Image)(resources.GetObject("pcLavado.Image")));
            this.pcLavado.Location = new System.Drawing.Point(283, 325);
            this.pcLavado.Name = "pcLavado";
            this.pcLavado.Size = new System.Drawing.Size(144, 92);
            this.pcLavado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcLavado.TabIndex = 2;
            this.pcLavado.TabStop = false;
            this.pcLavado.Click += new System.EventHandler(this.pcLavado_Click);
            // 
            // pcParqueo
            // 
            this.pcParqueo.Image = ((System.Drawing.Image)(resources.GetObject("pcParqueo.Image")));
            this.pcParqueo.Location = new System.Drawing.Point(12, 144);
            this.pcParqueo.Name = "pcParqueo";
            this.pcParqueo.Size = new System.Drawing.Size(147, 92);
            this.pcParqueo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcParqueo.TabIndex = 3;
            this.pcParqueo.TabStop = false;
            this.pcParqueo.Click += new System.EventHandler(this.pcParqueo_Click);
            // 
            // pcMensualidad
            // 
            this.pcMensualidad.Image = ((System.Drawing.Image)(resources.GetObject("pcMensualidad.Image")));
            this.pcMensualidad.Location = new System.Drawing.Point(565, 155);
            this.pcMensualidad.Name = "pcMensualidad";
            this.pcMensualidad.Size = new System.Drawing.Size(152, 92);
            this.pcMensualidad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcMensualidad.TabIndex = 5;
            this.pcMensualidad.TabStop = false;
            this.pcMensualidad.Click += new System.EventHandler(this.pcMensualidad_Click);
            // 
            // frmAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pcMensualidad);
            this.Controls.Add(this.pcParqueo);
            this.Controls.Add(this.pcLavado);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmAdministrador";
            this.Text = "frmAdministrador";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcLavado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcParqueo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcMensualidad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pcLavado;
        private System.Windows.Forms.PictureBox pcParqueo;
        private System.Windows.Forms.PictureBox pcMensualidad;
    }
}