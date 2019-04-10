using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppLyPSistematizadoReal.Reportes;

namespace AppLyPSistematizadoReal.Vista
{
    public partial class frmJefe : Form
    {
        public frmJefe()
        {
            InitializeComponent();
        }
        frmRegistroPersonal objRegistro = new frmRegistroPersonal();
        frmTarifa objTarifa = new frmTarifa();
        frmMensualidad objMensualidad = new frmMensualidad();
        MostrarReporte1 objReporte1 = new MostrarReporte1();
        MostrarReporte2 objReporte2 = new MostrarReporte2();
        private void pcRegistro_Click(object sender, EventArgs e)
        {
            objRegistro.Show();
        }

        private void pcTarifa_Click(object sender, EventArgs e)
        {
            objTarifa.Show();
        }

        private void pcMensualidad_Click(object sender, EventArgs e)
        {
            objMensualidad.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            objReporte1.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            objReporte2.Show();
        }
    }
}
