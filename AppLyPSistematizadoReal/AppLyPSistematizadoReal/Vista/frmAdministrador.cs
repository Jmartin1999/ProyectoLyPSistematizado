﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppLyPSistematizadoReal.Vista
{
    public partial class frmAdministrador : Form
    {
        public frmAdministrador()
        {
            InitializeComponent();
        }

        frmMensualidad objMensualidad = new frmMensualidad();
  

        private void pcMensualidad_Click(object sender, EventArgs e)
        {
            objMensualidad.Show();
        }

        private void pcLavado_Click(object sender, EventArgs e)
        {
            FrmLavadero lavadero = new FrmLavadero();
            lavadero.Show();
            this.Hide();
        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
            this.Hide();
        }

        private void pcParqueo_Click(object sender, EventArgs e)
        {
            frmParqueo login = new frmParqueo();
            login.Show();
            this.Hide();
        }
    }
}
