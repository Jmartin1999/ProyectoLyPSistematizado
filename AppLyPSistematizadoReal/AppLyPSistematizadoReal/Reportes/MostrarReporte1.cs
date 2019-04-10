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
    public partial class MostrarReporte1 : Form
    {
        public MostrarReporte1()
        {
            InitializeComponent();
        }
     
       
        private void MostrarReporte1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dtsInforme1.DataTable1' Puede moverla o quitarla según sea necesario.
         

            this.reportViewer1.RefreshReport();
        }
    }
}
