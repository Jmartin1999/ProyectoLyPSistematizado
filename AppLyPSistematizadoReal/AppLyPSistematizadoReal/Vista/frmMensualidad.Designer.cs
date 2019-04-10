namespace AppLyPSistematizadoReal.Vista
{
    partial class frmMensualidad
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabCliente = new System.Windows.Forms.TabPage();
            this.gpAutomovil = new System.Windows.Forms.GroupBox();
            this.btnEliminarA = new System.Windows.Forms.Button();
            this.btnModificarA = new System.Windows.Forms.Button();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRegistrarA = new System.Windows.Forms.Button();
            this.txtObservacion = new System.Windows.Forms.TextBox();
            this.gbCliente = new System.Windows.Forms.GroupBox();
            this.btnEliminarC = new System.Windows.Forms.Button();
            this.btnModificarC = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegistrarC = new System.Windows.Forms.Button();
            this.dgvBuscar = new System.Windows.Forms.DataGridView();
            this.tabPagos = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbTipoServicio = new System.Windows.Forms.ComboBox();
            this.lblAutomovil = new System.Windows.Forms.Label();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.btnPago = new System.Windows.Forms.Button();
            this.dgvPagos = new System.Windows.Forms.DataGridView();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.txtPlaca3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnBuscarPlaca = new System.Windows.Forms.Button();
            this.txtPlaca2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tabCliente.SuspendLayout();
            this.gpAutomovil.SuspendLayout();
            this.gbCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscar)).BeginInit();
            this.tabPagos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagos)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabCliente);
            this.tabControl1.Controls.Add(this.tabPagos);
            this.tabControl1.Location = new System.Drawing.Point(2, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(876, 521);
            this.tabControl1.TabIndex = 1;
            // 
            // tabCliente
            // 
            this.tabCliente.BackColor = System.Drawing.Color.Gray;
            this.tabCliente.Controls.Add(this.gpAutomovil);
            this.tabCliente.Controls.Add(this.gbCliente);
            this.tabCliente.Controls.Add(this.dgvBuscar);
            this.tabCliente.Location = new System.Drawing.Point(4, 22);
            this.tabCliente.Name = "tabCliente";
            this.tabCliente.Padding = new System.Windows.Forms.Padding(3);
            this.tabCliente.Size = new System.Drawing.Size(868, 495);
            this.tabCliente.TabIndex = 0;
            this.tabCliente.Text = "Registro";
            // 
            // gpAutomovil
            // 
            this.gpAutomovil.Controls.Add(this.btnEliminarA);
            this.gpAutomovil.Controls.Add(this.btnModificarA);
            this.gpAutomovil.Controls.Add(this.txtPlaca);
            this.gpAutomovil.Controls.Add(this.cmbTipo);
            this.gpAutomovil.Controls.Add(this.label15);
            this.gpAutomovil.Controls.Add(this.label8);
            this.gpAutomovil.Controls.Add(this.label5);
            this.gpAutomovil.Controls.Add(this.btnRegistrarA);
            this.gpAutomovil.Controls.Add(this.txtObservacion);
            this.gpAutomovil.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpAutomovil.Location = new System.Drawing.Point(24, 246);
            this.gpAutomovil.Name = "gpAutomovil";
            this.gpAutomovil.Size = new System.Drawing.Size(419, 240);
            this.gpAutomovil.TabIndex = 38;
            this.gpAutomovil.TabStop = false;
            this.gpAutomovil.Text = "Vehiculo";
            // 
            // btnEliminarA
            // 
            this.btnEliminarA.Location = new System.Drawing.Point(284, 196);
            this.btnEliminarA.Name = "btnEliminarA";
            this.btnEliminarA.Size = new System.Drawing.Size(111, 38);
            this.btnEliminarA.TabIndex = 26;
            this.btnEliminarA.Text = "Eliminar";
            this.btnEliminarA.UseVisualStyleBackColor = true;
            this.btnEliminarA.Click += new System.EventHandler(this.btnEliminarA_Click);
            // 
            // btnModificarA
            // 
            this.btnModificarA.Location = new System.Drawing.Point(144, 196);
            this.btnModificarA.Name = "btnModificarA";
            this.btnModificarA.Size = new System.Drawing.Size(111, 38);
            this.btnModificarA.TabIndex = 25;
            this.btnModificarA.Text = "Modificar";
            this.btnModificarA.UseVisualStyleBackColor = true;
            this.btnModificarA.Click += new System.EventHandler(this.btnModificarA_Click);
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(155, 42);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(100, 30);
            this.txtPlaca.TabIndex = 23;
            this.txtPlaca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPlaca_KeyPress);
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "Carro",
            "Moto",
            "Bicicleta"});
            this.cmbTipo.Location = new System.Drawing.Point(155, 78);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(100, 31);
            this.cmbTipo.TabIndex = 22;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(12, 78);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(108, 23);
            this.label15.TabIndex = 18;
            this.label15.Text = "Tipo Vehiculo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 23);
            this.label8.TabIndex = 17;
            this.label8.Text = "Placa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 23);
            this.label5.TabIndex = 20;
            this.label5.Text = "Observaciones";
            // 
            // btnRegistrarA
            // 
            this.btnRegistrarA.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarA.Location = new System.Drawing.Point(6, 196);
            this.btnRegistrarA.Name = "btnRegistrarA";
            this.btnRegistrarA.Size = new System.Drawing.Size(120, 43);
            this.btnRegistrarA.TabIndex = 15;
            this.btnRegistrarA.Text = "Registrar Vehiculo";
            this.btnRegistrarA.UseVisualStyleBackColor = true;
            this.btnRegistrarA.Click += new System.EventHandler(this.btnRegistrarA_Click);
            // 
            // txtObservacion
            // 
            this.txtObservacion.Location = new System.Drawing.Point(155, 115);
            this.txtObservacion.Multiline = true;
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.Size = new System.Drawing.Size(100, 61);
            this.txtObservacion.TabIndex = 21;
            // 
            // gbCliente
            // 
            this.gbCliente.Controls.Add(this.btnEliminarC);
            this.gbCliente.Controls.Add(this.btnModificarC);
            this.gbCliente.Controls.Add(this.lblId);
            this.gbCliente.Controls.Add(this.txtDocumento);
            this.gbCliente.Controls.Add(this.txtTelefono);
            this.gbCliente.Controls.Add(this.label3);
            this.gbCliente.Controls.Add(this.label2);
            this.gbCliente.Controls.Add(this.txtNombre);
            this.gbCliente.Controls.Add(this.label1);
            this.gbCliente.Controls.Add(this.btnRegistrarC);
            this.gbCliente.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCliente.Location = new System.Drawing.Point(24, 19);
            this.gbCliente.Name = "gbCliente";
            this.gbCliente.Size = new System.Drawing.Size(417, 221);
            this.gbCliente.TabIndex = 37;
            this.gbCliente.TabStop = false;
            this.gbCliente.Text = "Cliente";
            // 
            // btnEliminarC
            // 
            this.btnEliminarC.Location = new System.Drawing.Point(264, 177);
            this.btnEliminarC.Name = "btnEliminarC";
            this.btnEliminarC.Size = new System.Drawing.Size(115, 38);
            this.btnEliminarC.TabIndex = 19;
            this.btnEliminarC.Text = "Eliminar";
            this.btnEliminarC.UseVisualStyleBackColor = true;
            this.btnEliminarC.Click += new System.EventHandler(this.btnEliminarC_Click);
            // 
            // btnModificarC
            // 
            this.btnModificarC.Location = new System.Drawing.Point(133, 177);
            this.btnModificarC.Name = "btnModificarC";
            this.btnModificarC.Size = new System.Drawing.Size(111, 38);
            this.btnModificarC.TabIndex = 18;
            this.btnModificarC.Text = "Modificar";
            this.btnModificarC.UseVisualStyleBackColor = true;
            this.btnModificarC.Click += new System.EventHandler(this.btnModificarC_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(390, 14);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(15, 23);
            this.lblId.TabIndex = 17;
            this.lblId.Text = ":";
            this.lblId.Visible = false;
            // 
            // txtDocumento
            // 
            this.txtDocumento.Location = new System.Drawing.Point(209, 42);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(134, 30);
            this.txtDocumento.TabIndex = 15;
            this.txtDocumento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDocumento_KeyPress);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(209, 131);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(134, 30);
            this.txtTelefono.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Telefono";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre y Apellidos";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(209, 81);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(134, 30);
            this.txtNombre.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 23);
            this.label1.TabIndex = 12;
            this.label1.Text = "Documento";
            // 
            // btnRegistrarC
            // 
            this.btnRegistrarC.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarC.Location = new System.Drawing.Point(17, 177);
            this.btnRegistrarC.Name = "btnRegistrarC";
            this.btnRegistrarC.Size = new System.Drawing.Size(99, 38);
            this.btnRegistrarC.TabIndex = 14;
            this.btnRegistrarC.Text = "Registrar Cliente";
            this.btnRegistrarC.UseVisualStyleBackColor = true;
            this.btnRegistrarC.Click += new System.EventHandler(this.btnRegistrarC_Click);
            // 
            // dgvBuscar
            // 
            this.dgvBuscar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuscar.Location = new System.Drawing.Point(449, 97);
            this.dgvBuscar.Name = "dgvBuscar";
            this.dgvBuscar.Size = new System.Drawing.Size(398, 235);
            this.dgvBuscar.TabIndex = 36;
            // 
            // tabPagos
            // 
            this.tabPagos.BackColor = System.Drawing.Color.Gray;
            this.tabPagos.Controls.Add(this.label11);
            this.tabPagos.Controls.Add(this.label9);
            this.tabPagos.Controls.Add(this.label7);
            this.tabPagos.Controls.Add(this.cmbTipoServicio);
            this.tabPagos.Controls.Add(this.lblAutomovil);
            this.tabPagos.Controls.Add(this.lblTiempo);
            this.tabPagos.Controls.Add(this.btnPago);
            this.tabPagos.Controls.Add(this.dgvPagos);
            this.tabPagos.Controls.Add(this.txtTipo);
            this.tabPagos.Controls.Add(this.txtObservaciones);
            this.tabPagos.Controls.Add(this.txtPlaca3);
            this.tabPagos.Controls.Add(this.label6);
            this.tabPagos.Controls.Add(this.btnBuscarPlaca);
            this.tabPagos.Controls.Add(this.txtPlaca2);
            this.tabPagos.Controls.Add(this.label4);
            this.tabPagos.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPagos.Location = new System.Drawing.Point(4, 22);
            this.tabPagos.Name = "tabPagos";
            this.tabPagos.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagos.Size = new System.Drawing.Size(868, 495);
            this.tabPagos.TabIndex = 1;
            this.tabPagos.Text = "Pagos";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(33, 159);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(109, 23);
            this.label11.TabIndex = 35;
            this.label11.Text = "Tipo Servicio";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(765, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 23);
            this.label9.TabIndex = 33;
            this.label9.Text = "label9";
            this.label9.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(761, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 23);
            this.label7.TabIndex = 32;
            this.label7.Text = "label7";
            this.label7.Visible = false;
            // 
            // cmbTipoServicio
            // 
            this.cmbTipoServicio.FormattingEnabled = true;
            this.cmbTipoServicio.Items.AddRange(new object[] {
            "MENSUALIDAD1",
            "MENSUALIDAD2",
            "MENSUALIDAD3"});
            this.cmbTipoServicio.Location = new System.Drawing.Point(160, 156);
            this.cmbTipoServicio.Name = "cmbTipoServicio";
            this.cmbTipoServicio.Size = new System.Drawing.Size(171, 31);
            this.cmbTipoServicio.TabIndex = 31;
            // 
            // lblAutomovil
            // 
            this.lblAutomovil.AutoSize = true;
            this.lblAutomovil.Location = new System.Drawing.Point(63, 66);
            this.lblAutomovil.Name = "lblAutomovil";
            this.lblAutomovil.Size = new System.Drawing.Size(15, 23);
            this.lblAutomovil.TabIndex = 30;
            this.lblAutomovil.Text = ":";
            this.lblAutomovil.Visible = false;
            // 
            // lblTiempo
            // 
            this.lblTiempo.AutoSize = true;
            this.lblTiempo.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempo.Location = new System.Drawing.Point(445, 14);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(15, 23);
            this.lblTiempo.TabIndex = 29;
            this.lblTiempo.Text = ":";
            // 
            // btnPago
            // 
            this.btnPago.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPago.Location = new System.Drawing.Point(346, 428);
            this.btnPago.Name = "btnPago";
            this.btnPago.Size = new System.Drawing.Size(130, 41);
            this.btnPago.TabIndex = 28;
            this.btnPago.Text = "Registrar Pago ";
            this.btnPago.UseVisualStyleBackColor = true;
            this.btnPago.Click += new System.EventHandler(this.btnPago_Click);
            // 
            // dgvPagos
            // 
            this.dgvPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPagos.Location = new System.Drawing.Point(138, 205);
            this.dgvPagos.Name = "dgvPagos";
            this.dgvPagos.Size = new System.Drawing.Size(634, 204);
            this.dgvPagos.TabIndex = 27;
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(250, 103);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(100, 30);
            this.txtTipo.TabIndex = 26;
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(378, 103);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(125, 46);
            this.txtObservaciones.TabIndex = 25;
            // 
            // txtPlaca3
            // 
            this.txtPlaca3.Location = new System.Drawing.Point(128, 103);
            this.txtPlaca3.Name = "txtPlaca3";
            this.txtPlaca3.Size = new System.Drawing.Size(100, 30);
            this.txtPlaca3.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(29, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 23);
            this.label6.TabIndex = 23;
            this.label6.Text = "Automovil";
            // 
            // btnBuscarPlaca
            // 
            this.btnBuscarPlaca.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarPlaca.Location = new System.Drawing.Point(346, 49);
            this.btnBuscarPlaca.Name = "btnBuscarPlaca";
            this.btnBuscarPlaca.Size = new System.Drawing.Size(100, 34);
            this.btnBuscarPlaca.TabIndex = 22;
            this.btnBuscarPlaca.Text = "Buscar";
            this.btnBuscarPlaca.UseVisualStyleBackColor = true;
            // 
            // txtPlaca2
            // 
            this.txtPlaca2.Location = new System.Drawing.Point(222, 49);
            this.txtPlaca2.Name = "txtPlaca2";
            this.txtPlaca2.Size = new System.Drawing.Size(100, 30);
            this.txtPlaca2.TabIndex = 21;
            this.txtPlaca2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPlaca2_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(98, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 23);
            this.label4.TabIndex = 20;
            this.label4.Text = "Buscar Placa";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmMensualidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 521);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmMensualidad";
            this.Text = "frmMensualidad";
            this.Load += new System.EventHandler(this.frmMensualidad_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabCliente.ResumeLayout(false);
            this.gpAutomovil.ResumeLayout(false);
            this.gpAutomovil.PerformLayout();
            this.gbCliente.ResumeLayout(false);
            this.gbCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscar)).EndInit();
            this.tabPagos.ResumeLayout(false);
            this.tabPagos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabCliente;
        private System.Windows.Forms.GroupBox gpAutomovil;
        private System.Windows.Forms.Button btnEliminarA;
        private System.Windows.Forms.Button btnModificarA;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnRegistrarA;
        private System.Windows.Forms.TextBox txtObservacion;
        private System.Windows.Forms.GroupBox gbCliente;
        private System.Windows.Forms.Button btnEliminarC;
        private System.Windows.Forms.Button btnModificarC;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegistrarC;
        private System.Windows.Forms.DataGridView dgvBuscar;
        private System.Windows.Forms.TabPage tabPagos;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbTipoServicio;
        private System.Windows.Forms.Label lblAutomovil;
        private System.Windows.Forms.Label lblTiempo;
        private System.Windows.Forms.Button btnPago;
        private System.Windows.Forms.DataGridView dgvPagos;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.TextBox txtPlaca3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnBuscarPlaca;
        private System.Windows.Forms.TextBox txtPlaca2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
    }
}