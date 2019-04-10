namespace AppLyPSistematizadoReal.Vista
{
    partial class frmJefe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmJefe));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pcTarifa = new System.Windows.Forms.PictureBox();
            this.pcRegistro = new System.Windows.Forms.PictureBox();
            this.pcMensualidad = new System.Windows.Forms.PictureBox();
            this.pcParqueo = new System.Windows.Forms.PictureBox();
            this.pcLavado = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcTarifa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcRegistro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcMensualidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcParqueo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcLavado)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 448);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pcTarifa
            // 
            this.pcTarifa.Image = ((System.Drawing.Image)(resources.GetObject("pcTarifa.Image")));
            this.pcTarifa.Location = new System.Drawing.Point(594, 124);
            this.pcTarifa.Name = "pcTarifa";
            this.pcTarifa.Size = new System.Drawing.Size(120, 103);
            this.pcTarifa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcTarifa.TabIndex = 6;
            this.pcTarifa.TabStop = false;
            this.pcTarifa.Click += new System.EventHandler(this.pcTarifa_Click);
            // 
            // pcRegistro
            // 
            this.pcRegistro.Image = ((System.Drawing.Image)(resources.GetObject("pcRegistro.Image")));
            this.pcRegistro.Location = new System.Drawing.Point(40, 136);
            this.pcRegistro.Name = "pcRegistro";
            this.pcRegistro.Size = new System.Drawing.Size(100, 103);
            this.pcRegistro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcRegistro.TabIndex = 5;
            this.pcRegistro.TabStop = false;
            this.pcRegistro.Click += new System.EventHandler(this.pcRegistro_Click);
            // 
            // pcMensualidad
            // 
            this.pcMensualidad.Image = ((System.Drawing.Image)(resources.GetObject("pcMensualidad.Image")));
            this.pcMensualidad.Location = new System.Drawing.Point(585, 333);
            this.pcMensualidad.Name = "pcMensualidad";
            this.pcMensualidad.Size = new System.Drawing.Size(152, 92);
            this.pcMensualidad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcMensualidad.TabIndex = 9;
            this.pcMensualidad.TabStop = false;
            this.pcMensualidad.Click += new System.EventHandler(this.pcMensualidad_Click);
            // 
            // pcParqueo
            // 
            this.pcParqueo.Image = ((System.Drawing.Image)(resources.GetObject("pcParqueo.Image")));
            this.pcParqueo.Location = new System.Drawing.Point(40, 333);
            this.pcParqueo.Name = "pcParqueo";
            this.pcParqueo.Size = new System.Drawing.Size(147, 92);
            this.pcParqueo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcParqueo.TabIndex = 8;
            this.pcParqueo.TabStop = false;
            this.pcParqueo.Click += new System.EventHandler(this.pcParqueo_Click);
            // 
            // pcLavado
            // 
            this.pcLavado.Image = ((System.Drawing.Image)(resources.GetObject("pcLavado.Image")));
            this.pcLavado.Location = new System.Drawing.Point(326, 333);
            this.pcLavado.Name = "pcLavado";
            this.pcLavado.Size = new System.Drawing.Size(144, 92);
            this.pcLavado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcLavado.TabIndex = 7;
            this.pcLavado.TabStop = false;
            this.pcLavado.Click += new System.EventHandler(this.pcLavado_Click);
            // 
            // frmJefe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pcMensualidad);
            this.Controls.Add(this.pcParqueo);
            this.Controls.Add(this.pcLavado);
            this.Controls.Add(this.pcTarifa);
            this.Controls.Add(this.pcRegistro);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmJefe";
            this.Text = "frmJefe";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcTarifa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcRegistro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcMensualidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcParqueo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcLavado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pcTarifa;
        private System.Windows.Forms.PictureBox pcRegistro;
        private System.Windows.Forms.PictureBox pcMensualidad;
        private System.Windows.Forms.PictureBox pcParqueo;
        private System.Windows.Forms.PictureBox pcLavado;
    }
}