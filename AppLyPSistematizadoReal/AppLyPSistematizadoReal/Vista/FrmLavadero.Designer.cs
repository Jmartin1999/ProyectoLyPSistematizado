namespace AppLyPSistematizadoReal.Vista
{
    partial class FrmLavadero
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLavadero));
            this.lblidServicio = new System.Windows.Forms.Label();
            this.lblServicio = new System.Windows.Forms.Label();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnServicio = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbTipoVehiculo = new System.Windows.Forms.ComboBox();
            this.EMPLEADO = new System.Windows.Forms.Label();
            this.cmbPersona = new System.Windows.Forms.ComboBox();
            this.lblAutomovil = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnautomovil = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtServicio = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblidServicio
            // 
            this.lblidServicio.AutoSize = true;
            this.lblidServicio.BackColor = System.Drawing.Color.Transparent;
            this.lblidServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lblidServicio.ForeColor = System.Drawing.Color.Black;
            this.lblidServicio.Location = new System.Drawing.Point(917, 60);
            this.lblidServicio.Name = "lblidServicio";
            this.lblidServicio.Size = new System.Drawing.Size(33, 29);
            this.lblidServicio.TabIndex = 20;
            this.lblidServicio.Text = "Id";
            this.lblidServicio.Visible = false;
            // 
            // lblServicio
            // 
            this.lblServicio.AutoSize = true;
            this.lblServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lblServicio.ForeColor = System.Drawing.Color.Transparent;
            this.lblServicio.Location = new System.Drawing.Point(705, 57);
            this.lblServicio.Name = "lblServicio";
            this.lblServicio.Size = new System.Drawing.Size(100, 29);
            this.lblServicio.TabIndex = 19;
            this.lblServicio.Text = "Servicio";
            // 
            // dgvDatos
            // 
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Location = new System.Drawing.Point(566, 112);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.Size = new System.Drawing.Size(440, 272);
            this.dgvDatos.TabIndex = 18;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnServicio);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbTipoVehiculo);
            this.groupBox1.Controls.Add(this.EMPLEADO);
            this.groupBox1.Controls.Add(this.cmbPersona);
            this.groupBox1.Controls.Add(this.lblAutomovil);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnautomovil);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.btnNuevo);
            this.groupBox1.Controls.Add(this.txtPlaca);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtServicio);
            this.groupBox1.Location = new System.Drawing.Point(46, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(475, 392);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // btnServicio
            // 
            this.btnServicio.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServicio.Location = new System.Drawing.Point(44, 295);
            this.btnServicio.Name = "btnServicio";
            this.btnServicio.Size = new System.Drawing.Size(112, 33);
            this.btnServicio.TabIndex = 19;
            this.btnServicio.Text = "Guardar ";
            this.btnServicio.UseVisualStyleBackColor = true;
            this.btnServicio.Click += new System.EventHandler(this.btnServicio_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 23);
            this.label3.TabIndex = 18;
            this.label3.Text = "TIPO DE VEHICULO : ";
            // 
            // cmbTipoVehiculo
            // 
            this.cmbTipoVehiculo.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoVehiculo.FormattingEnabled = true;
            this.cmbTipoVehiculo.Items.AddRange(new object[] {
            "CARRO",
            "MOTO",
            "BICICLETA"});
            this.cmbTipoVehiculo.Location = new System.Drawing.Point(224, 166);
            this.cmbTipoVehiculo.Name = "cmbTipoVehiculo";
            this.cmbTipoVehiculo.Size = new System.Drawing.Size(219, 31);
            this.cmbTipoVehiculo.TabIndex = 17;
            this.cmbTipoVehiculo.SelectedIndexChanged += new System.EventHandler(this.cmbTipoVehiculo_SelectedIndexChanged);
            // 
            // EMPLEADO
            // 
            this.EMPLEADO.AutoSize = true;
            this.EMPLEADO.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EMPLEADO.Location = new System.Drawing.Point(74, 243);
            this.EMPLEADO.Name = "EMPLEADO";
            this.EMPLEADO.Size = new System.Drawing.Size(99, 23);
            this.EMPLEADO.TabIndex = 16;
            this.EMPLEADO.Text = "EMPLEADO";
            // 
            // cmbPersona
            // 
            this.cmbPersona.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPersona.FormattingEnabled = true;
            this.cmbPersona.Location = new System.Drawing.Point(224, 240);
            this.cmbPersona.Name = "cmbPersona";
            this.cmbPersona.Size = new System.Drawing.Size(219, 31);
            this.cmbPersona.TabIndex = 15;
            // 
            // lblAutomovil
            // 
            this.lblAutomovil.AutoSize = true;
            this.lblAutomovil.BackColor = System.Drawing.Color.Transparent;
            this.lblAutomovil.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblAutomovil.ForeColor = System.Drawing.Color.Black;
            this.lblAutomovil.Location = new System.Drawing.Point(18, 17);
            this.lblAutomovil.Name = "lblAutomovil";
            this.lblAutomovil.Size = new System.Drawing.Size(35, 26);
            this.lblAutomovil.TabIndex = 14;
            this.lblAutomovil.Text = "id ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar Placa";
            // 
            // btnautomovil
            // 
            this.btnautomovil.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnautomovil.Location = new System.Drawing.Point(341, 69);
            this.btnautomovil.Name = "btnautomovil";
            this.btnautomovil.Size = new System.Drawing.Size(102, 33);
            this.btnautomovil.TabIndex = 8;
            this.btnautomovil.Text = "Ingresar";
            this.btnautomovil.UseVisualStyleBackColor = true;
            this.btnautomovil.Click += new System.EventHandler(this.btnautomovil_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(341, 108);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 33);
            this.button2.TabIndex = 12;
            this.button2.Text = "Buscar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Location = new System.Drawing.Point(201, 293);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(131, 36);
            this.btnNuevo.TabIndex = 13;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // txtPlaca
            // 
            this.txtPlaca.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlaca.Location = new System.Drawing.Point(28, 74);
            this.txtPlaca.MaxLength = 6;
            this.txtPlaca.Multiline = true;
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(289, 67);
            this.txtPlaca.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "TOTAL DE  SERVICIO";
            // 
            // txtServicio
            // 
            this.txtServicio.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServicio.Location = new System.Drawing.Point(224, 206);
            this.txtServicio.Name = "txtServicio";
            this.txtServicio.Size = new System.Drawing.Size(219, 30);
            this.txtServicio.TabIndex = 6;
            // 
            // FrmLavadero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1035, 474);
            this.Controls.Add(this.lblidServicio);
            this.Controls.Add(this.lblServicio);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Name = "FrmLavadero";
            this.Text = "Lavado";
            this.Load += new System.EventHandler(this.FrmLavadero_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblidServicio;
        private System.Windows.Forms.Label lblServicio;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnServicio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbTipoVehiculo;
        private System.Windows.Forms.Label EMPLEADO;
        private System.Windows.Forms.ComboBox cmbPersona;
        private System.Windows.Forms.Label lblAutomovil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnautomovil;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtServicio;
    }
}