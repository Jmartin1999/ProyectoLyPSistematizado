using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppLyPSistematizadoReal
{
    public partial class MostrarReporte2 : Form
    {
        public MostrarReporte2()
        {
            InitializeComponent();
        }

        private void MostrarReporte2_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dtsInforme2.DataTable1' Puede moverla o quitarla según sea necesario.
       

            this.reportViewer1.RefreshReport();
        }
    }
}
