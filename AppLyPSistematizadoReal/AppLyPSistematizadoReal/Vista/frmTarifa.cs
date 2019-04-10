using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppLyPSistematizadoReal.Datos;

namespace AppLyPSistematizadoReal.Vista
{
    public partial class frmTarifa : Form
    {
        public frmTarifa()
        {
            InitializeComponent();
        }

        private void frmTarifa_Load(object sender, EventArgs e)
        {
            clTipo ObjTipo = new clTipo();
            List<clTipo> listaDatos = new List<clTipo>();
            listaDatos = ObjTipo.mtdListar();
            dgvTipo.DataSource = ObjTipo.mtdListar();

            for (int i = 0; i < listaDatos.Count; i++)
            {

            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTipoS.Text) || string.IsNullOrEmpty(txtTipoV.Text))
            {
                MessageBox.Show("debe ingresar la informacion completa");
            }
            else if (string.IsNullOrEmpty(txtCosto.Text))
            {
                MessageBox.Show("debe ingresar la informacion completa");
            }
            else
            {
                clTipo objTipo = new clTipo();
                objTipo.TipoServicio = txtTipoS.Text;
                objTipo.TipoVehiculo = txtTipoV.Text;
                objTipo.Costo = txtCosto.Text;
                int Cantidad = objTipo.mtdRegistro();
                if (Cantidad > 0)
                {
                    MessageBox.Show("Registrado");
                    clTipo ObjTipo = new clTipo();
                    dgvTipo.DataSource = ObjTipo.mtdListar();
                }
                else
                {
                    MessageBox.Show("No se registro");
                }
                txtTipoS.Clear();
                txtTipoV.Clear();
                txtCosto.Clear();
            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            clTipo ObjTipo = new clTipo();
            ObjTipo.TipoServicio = txtBuscar.Text;
            dgvTipo.DataSource = ObjTipo.mtdBuscar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            clTipo ObjTipo = new clTipo();
            ObjTipo.TipoServicio = txtTipoS.Text;
            ObjTipo.TipoVehiculo = txtTipoV.Text;
            ObjTipo.Costo = txtCosto.Text;
            int Cantidad = ObjTipo.mtdModificar();
            if (Cantidad > 0)
            {
                MessageBox.Show("Datos Modificados" + Cantidad);
            }
            else
            {
                MessageBox.Show("Error");
            }
            dgvTipo.DataSource = ObjTipo.mtdListar();
            txtTipoS.Clear();
            txtTipoV.Clear();
            txtCosto.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            clTipo objTipo = new clTipo();
            objTipo.TipoServicio = txtBuscar.Text;
            objTipo.mtdEliminar();
            MessageBox.Show("Datos Eliminados");
            dgvTipo.DataSource = objTipo.mtdListar();
            txtTipoS.Clear();
            txtTipoV.Clear();
            txtCosto.Clear();
        }

        private void dgvTipo_DoubleClick(object sender, EventArgs e)
        {
            txtTipoS.Text = Convert.ToString(dgvTipo.CurrentRow.Cells[0].Value);
            txtTipoV.Text = Convert.ToString(dgvTipo.CurrentRow.Cells[1].Value);
            txtCosto.Text = Convert.ToString(dgvTipo.CurrentRow.Cells[2].Value);
        }
    }
}
